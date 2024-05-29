import numpy as np
from imgui_bundle import imgui, ImVec2
import pxz

from pxzui.ui.WindowBase import WindowBase

class Variant:
    def __init__(self, camera, variantId, name, isPmi):
        self.camera = camera
        self.id = variantId
        self.name = name
        # TODO
        #  - this class variable does currently not exist as a variant property
        #  - it is set using ViewIsSet which is wrong
        #  - should be replaced by a variant property
        self.isPmi = isPmi
        self.selected = False
        self.renaming = False
        self.newName = ""
        self.color = [255, 255, 255]

    def draw(self):
        imguiColor = imgui.ImColor(self.color[0], self.color[1], self.color[2]).value
        imgui.push_id(self.id)
        if self.renaming:
            imgui.set_next_item_width(imgui.get_content_region_avail()[0])
            imgui.set_keyboard_focus_here()
            nameSet, self.newName = imgui.input_text("##renaming" + str(self.id), self.newName, imgui.InputTextFlags_.enter_returns_true)
            if imgui.is_key_pressed(imgui.Key.enter) or nameSet:
                self.renaming = False
                pxz.core.setProperty(self.id, "Name", self.newName)
                self.name = self.newName
            if imgui.is_key_pressed(imgui.Key.escape) or (imgui.is_mouse_clicked(0) and not imgui.is_item_hovered()):
                self.renaming = False
        else:
            displayName = "[" + str(self.id) + "] " + self.name
            if self.selected:
                imgui.text_colored(imguiColor, displayName)
            else:
                imgui.text(displayName)
            if imgui.is_item_hovered() and imgui.is_mouse_double_clicked(0):
                self.setAsCurrent()
        imgui.pop_id()

    def setAsCurrent(self):
        # TODO set viewer properties (explodedview & cuttingplane)
        pxz.scene.setCurrentVariant(self.id)
        # set camera if defined
        if self.id == 0: # default variant
            return
        viewIsSet = pxz.core.getProperty(self.id, 'ViewIsSet')
        if viewIsSet == 'True':
            if pxz.core.getProperty(self.id, 'ViewIsOrtho') == "True":
                self.camera.setOrthographic(True)
            else:
                self.camera.setOrthographic(False)
                newFov = float(pxz.core.getProperty(self.id, 'ViewFov'))
                if newFov > 0:
                    self.camera.setFovX(newFov)
            view = np.array(eval(pxz.core.getProperty(self.id, 'View')))
            clipping = pxz.geom.Point2(self.camera.getZNear(), self.camera.getZFar())
            # assign new view matrix
            pxz.view.setViewerMatrices([self.camera.getProjMatrix().tolist()], [view.tolist()], clipping, self.camera.viewer.viewer)
            self.camera.setViewMatrix(view)
            # set dirty to false in order to avoid camera reset
            self.camera.setViewDirty(False)
            self.camera.setProjDirty(True)

def onVariantChanged(variantChangeType, id, variants):
    variants.onVariantChanged(variantChangeType, id)

class Variants(WindowBase):
    def __init__(self, ui):
        super().__init__(name="Variants and PMI")
        self.ui = ui
        defaultVariant = Variant(self.ui.window.viewer.camera, 0, "Default", False)
        self.variants = [defaultVariant]
        self.variantsExpanded = False
        self.pmiExpanded = False
        pxz.scene.addVariantChangedCallback(onVariantChanged, self)
        self.setCurrentVariant(defaultVariant.id)
        self.currentVariant = None
        self.updateColors()

    def draw(self):
        # VARIANTS
        variants = [v for v in self.variants if not v.isPmi]
        selectedVariant = None
        self.variantsExpanded = imgui.collapsing_header("Variants", self.variantsExpanded)
        if self.variantsExpanded:
            if imgui.button("Add Variant", ImVec2(imgui.get_content_region_avail()[0], 0)):
                self.ui.processQueue.enqueue(pxz.scene.addVariant, "New Variant")
            for index, variant in enumerate(variants):
                imgui.push_id(index)
                variant.draw()
                self.drawVariantContextMenu(variant)
                if variant.selected:
                    selectedVariant = variant
                imgui.pop_id()
        # PMI
        pmi = [v for v in self.variants if v.isPmi]
        self.pmiExpanded = imgui.collapsing_header("PMI", self.variantsExpanded)
        if self.pmiExpanded:
            for index, variant in enumerate(pmi):
                variant.draw()
        # If some variant is selected, we add a button to save it
        if selectedVariant:
            if imgui.button("Save " + selectedVariant.name, ImVec2(imgui.get_content_region_avail()[0], 0)):
                self.ui.processQueue.enqueue(self.saveVariant, selectedVariant)

    def onVariantChanged(self, variantChangeType, variantId):
        match variantChangeType:
            case pxz.scene.VariantChangeType.ADDED:
                self.addVariant(variantId)
            case pxz.scene.VariantChangeType.REMOVED:
                self.removeVariant(variantId)
            case pxz.scene.VariantChangeType.CURRENT_CHANGED:
                self.setCurrentVariant(variantId)

    def removeVariant(self, variantId):
        # removing element
        self.variants[:] = [variant for variant in self.variants if variant.id != variantId]
        # updating colors
        self.updateColors()

    def addVariant(self, variantId):
        variantName = pxz.core.getProperty(variantId, "Name")
        # isPmi will always be false on this callback, as it is set afterward.
        # That is why we use updateAll after file import.
        # Still, it is included here for completeness.
        isPmi = pxz.core.getProperty(variantId, "ViewIsSet") == "True"
        self.variants.append(Variant(self.ui.window.viewer.camera, variantId, variantName, isPmi))
        # updating colors
        self.updateColors()

    def setCurrentVariant(self, variantId):
        for variant in self.variants:
            if variant.id == 0:
                variant.name = "Default"
            else:
                pxz.core.getProperty(variant.id, "Name")
            if variant.id == variantId:
                variant.selected = True
                self.currentVariant = variant
            else:
                variant.selected = False

    def drawVariantContextMenu(self, variant=None):
        if imgui.is_item_hovered() and imgui.is_mouse_clicked(1):
            imgui.open_popup("drawVariantContextMenu" + str(variant.id))
        if imgui.begin_popup("drawVariantContextMenu" + str(variant.id)):
            # clicking on empty space
            if imgui.menu_item("Add Variant", "", False)[0]:
                pxz.scene.addVariant("New Variant")
            # clicking on an existing variant
            if variant:
                if imgui.menu_item("Activate", "", False)[0]:
                    pxz.scene.setCurrentVariant(variant.id)
                if imgui.menu_item("Rename", "", False)[0]:
                    self.beginRename(variant)
                if imgui.menu_item("Duplicate", "", False)[0]:
                    pxz.scene.addVariant(variant.name + " (Copy)")
                if imgui.menu_item("Delete", "", False)[0]:
                    if self.currentVariant == variant:
                        self.currentVariant = None
                    pxz.scene.removeVariant(variant.id)
            imgui.end_popup()

    def beginRename(self, variant):
        variant.newName = variant.name
        variant.renaming = True

    def saveVariant(self, variant):
        altTree = pxz.scene.createAlternativeTree(variant.name, pxz.scene.getRoot())
        pxz.scene.setVariantTree(variant.id, altTree)
        viewerMatrices = pxz.view.getViewerMatrices(self.ui.window.viewer.viewer)
        pxz.core.setProperty(variant.id, "ViewIsSet", "True")
        pxz.core.setProperty(variant.id, "View", str(viewerMatrices["views"][0]))
        pxz.core.setProperty(variant.id, 'ViewIsOrtho', str(self.ui.window.viewer.camera.isOrthographic()).capitalize())
        pxz.core.setProperty(variant.id, 'ViewFov', str(self.ui.window.viewer.camera.getFovX()))

    def updateVariantProperties(self):
        # updating the lists for variants and pmi as they might change (by modifying ViewIsSet)
        for variant in self.variants:
            if variant.id == 0: # default
                continue
            variant.name = pxz.core.getProperty(variant.id, "Name")
            variant.isPmi = pxz.core.getProperty(variant.id, "ViewIsSet") == "True"
        # updating colors
        self.updateColors()

    def updateColors(self):
        pmiCount = len([v for v in self.variants if v.isPmi])
        pmiColors = generateColors(pmiCount)
        variantColors = generateColors(len(self.variants) - pmiCount)
        for variant in self.variants:
            if variant.isPmi:
                variant.color = pmiColors.pop()
            else:
                variant.color = variantColors.pop()

def generateColors(n):
    # Generates n colors with evenly distributed hue
    colors = []
    if n <= 0:
        return colors
    hueIncrement = 360 / n
    for i in range(n):
        hue = int(i * hueIncrement)
        rgb = hsvToRgb(hue / 360, 1, 1)
        colors.append(rgb)
    return colors

def hsvToRgb(h, s, v):
    if s == 0:
        r, g, b = v, v, v
    else:
        h = h * 6
        i = int(h)
        f = h - i
        p = v * (1 - s)
        q = v * (1 - s * f)
        t = v * (1 - s * (1 - f))
        if i == 0:
            r, g, b = v, t, p
        elif i == 1:
            r, g, b = q, v, p
        elif i == 2:
            r, g, b = p, v, t
        elif i == 3:
            r, g, b = p, q, v
        elif i == 4:
            r, g, b = t, p, v
        else:
            r, g, b = v, p, q
    return [int(r * 255), int(g * 255), int(b * 255)]