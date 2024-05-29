import pxz
from imgui_bundle import imgui, ImVec2

from pxzui.ui.materials.MaterialPreview import MaterialPreview
from pxzui.ui.widgets.Utility import Utility
from pxzui.utils.EmVec2 import EmVec2


def onMaterialChanged(materialChangeType, id, materialForm):
    materialForm.onMaterialChanged(materialChangeType, id)

def onResetSession(materialForm):
    materialForm.onResetSession()

class MaterialForm:
    def __init__(self, ui, materialId=None, preview=False):
        self.ui = ui
        if preview:
            self.materialPreview = MaterialPreview(self.ui.window.glfwWindow)
        else:
            self.materialPreview = None
        self.showPreview = False
        self.pattern = ""
        self.id = materialId
        self.propertyWidgets = {}
        # is there a better way to get all the pattern names?
        self.materialPatternNamesList = ["unlittexture", "color", "standard", "impostor", "PBR"]
        self.anyPropertyChanged = False
        self.saveInProgress = False
        if materialId is not None:
            self.update(materialId)
        pxz.material.addMaterialChangedCallback(onMaterialChanged, self)
        pxz.core.addOnSessionResetCallback(onResetSession, self)

    def resetPreviewViewer(self):
        if self.materialPreview is not None:
            self.materialPreview = MaterialPreview(self.ui.window.glfwWindow)

    def update(self, newMaterialId=None):
        # don't update on modifs we are doing here
        if self.saveInProgress:
            return
        self.id = newMaterialId
        if newMaterialId is None:
            self.propertyWidgets = {}
        else:
            self.pattern = pxz.material.getMaterialPattern(self.id)
            self.propertyWidgets = self.generatePropertyDict(self.id)
            if self.materialPreview is not None:
                self.materialPreview.initialize(self.id)

    def onMaterialChanged(self, materialChangeType, id):
        if self.id is not None and self.id == id:
            match materialChangeType:
                case pxz.material.MaterialChangeType.REMOVED | pxz.material.MaterialChangeType.DESTROYED:
                    self.update(None)
                case _:
                    self.update(self.id)

    def draw(self):
        if self.id is None:
            return
        # PREVIEW
        if self.materialPreview is not None:
            if imgui.button("Disable Preview" if self.showPreview else "Enable Preview", ImVec2(imgui.get_content_region_avail()[0], 0)):
                self.showPreview = not self.showPreview
            if self.showPreview:
                self.materialPreview.draw()
        # COMBO BOX WITH MATERIAL PATTERN TYPE
        imgui.text("Material Pattern Type")
        imgui.same_line()
        imgui.set_next_item_width(imgui.get_content_region_avail()[0])
        materialPatternChanged, newMaterialPatternIndex = imgui.combo(
            "##Material Pattern Type Combo",
            self.materialPatternNamesList.index(self.pattern),
            self.materialPatternNamesList)
        if materialPatternChanged and newMaterialPatternIndex != self.materialPatternNamesList.index(self.pattern):
            self.pattern = self.materialPatternNamesList[newMaterialPatternIndex]
            self.propertyWidgets = self.generateDefaultProperties(self.pattern)
        self.anyPropertyChanged |= materialPatternChanged
        #
        imgui.dummy(EmVec2(0, 1))
        table_flags = imgui.TableFlags_.borders_h | imgui.TableFlags_.sizing_stretch_same
        if imgui.begin_table("Material Parameters", 2, table_flags):
            # ID
            imgui.table_next_row()
            imgui.table_next_column()
            imgui.text("ID")
            imgui.table_next_column()
            imgui.set_next_item_width(imgui.get_content_region_avail()[0])
            imgui.label_text("##id", str(self.id))
            # MATERIAL PROPERTIES
            for propertyName, propertyWidget in self.propertyWidgets.items():
                imgui.table_next_row()
                imgui.table_next_column()
                imgui.text(propertyName.capitalize())
                imgui.table_next_column()
                imgui.set_next_item_width(imgui.get_content_region_avail()[0])
                propertyChanged, _ = propertyWidget.draw()
                self.anyPropertyChanged |= propertyChanged
            imgui.end_table()
        imgui.dummy(EmVec2(0, 1))
        # SAVE BUTTON
        disableSaveButton = not self.anyPropertyChanged
        if disableSaveButton:
            imgui.begin_disabled()
        if imgui.button("Save", ImVec2(imgui.get_content_region_avail()[0], 0)):
            self.save()
        if disableSaveButton:
            imgui.end_disabled()
        # DELETE BUTTON
        if imgui.button("Delete", ImVec2(imgui.get_content_region_avail()[0], 0)):
            self.delete()
        imgui.calc_item_width()

    def save(self):
        self.saveInProgress = True
        if self.pattern != pxz.material.getMaterialPattern(self.id):
            self.ui.processQueue.enqueue(pxz.material.setMaterialPattern, self.id, self.pattern)
        for propertyName, propertyValue in self.propertyWidgets.items():
            self.ui.processQueue.enqueue(pxz.core.setProperty, self.id, propertyName, propertyValue.value)
        self.anyPropertyChanged = False
        self.saveInProgress = False

    def delete(self):
        pxz.core.deleteEntities([self.id])

    def generatePropertyDict(self, materialId):
        widgets = {}
        propertyList = pxz.core.listProperties(materialId)
        for property in propertyList:
            if property.name == "Id" or property.name == "exposed":
                continue
            widgets[property.name] = Utility.createPropertyWidget(self.ui, property)
        return widgets

    def generateDefaultProperties(self, materialPattern):
        tmpMaterialId = pxz.material.createMaterial(self.propertyWidgets["Name"].value, materialPattern)
        defaultProperties = self.generatePropertyDict(tmpMaterialId)
        pxz.core.deleteEntities([tmpMaterialId])
        return defaultProperties

    def onResetSession(self):
        self.ui.processQueue.enqueue(self.update)
        self.resetPreviewViewer()

