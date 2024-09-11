import struct
import threading

import numpy as np
import pxz
from imgui_bundle import imgui, ImVec2
from pxzui.ui.WindowBase import WindowBase
from pxzui.ui.widgets.base.TextureWidget import TextureWidget
from pxzui.viewer.Viewer import Viewer
from OpenGL.GL import *

class UVViewer(WindowBase):
    """Superposing two GPU scenes to display the UVs on top of a selected texture"""
    def __init__(self, ui):
        super().__init__("UV Viewer")
        self._lock = threading.Lock()
        self.ui = ui
        self.size = 500  # default image size, will be changed with window size
        self.textureWidget = TextureWidget(ui, "Selected Texture")
        self.planeId, self.backgroundMaterial = self.createPlaneAndMaterial()
        self.gridVisible = True
        self.gridAuto = True
        self.gridW = 1 #to store value of widget
        self.gridH = 1 #to store value of widget
        self.gridColor = pxz.core.ColorAlpha()
        self.needGridUpdate = True
        self.gridMaterial = None
        self.gridId = self.createGrid(1, 1)
        #mask
        self.wantR = True
        self.wantG = True
        self.wantB = True
        self.wantA = True
        # viewer
        self.viewer = None
        self.planeScene = None
        self.gridScene = None
        self.windowSizeIsChanging = False
        # callbacks
        self.ui.window.callback_manager.addSelectionChangedCallback(self.onSelectionChanged)
        self.ui.window.callback_manager.addOnSessionResetCallback(self.onResetSession)
        self.ui.window.callback_manager.addBeforeSessionResetCallback(self.onBeforeResetSession)
        # camera movement
        self.panning = False
        self.panningLast = None
        self.zooming = False
        self.zoomingLast = None
        # uv info
        self.mouseUv = np.array([0, 0])
        self.uvSet = 0
        self.customBackground = imgui.ImVec4(0.25, 0.25, 0.25, 1.0)
        self.aabrInfo = (None, None)


    def __del__(self):
        self.ui.window.callback_manager.removeSelectionChangedCallback(self.onSelectionChanged)
        self.ui.window.callback_manager.removeOnSessionResetCallback(self.onResetSession)
        self.ui.window.callback_manager.removeBeforeSessionResetCallback(self.onBeforeResetSession)


    def initViewer(self):
        # setup viewer with two gpu scenes
        self.planeScene = pxz.view.createGPUScene([self.planeId], True)        
        self.ui.window.addUsedGPUScene(self.planeScene)
        self.gridScene = pxz.view.createGPUScene([self.gridId], True)
        self.ui.window.addUsedGPUScene(self.gridScene)
        self.viewer = Viewer(self.ui.window, self.size, self.size, previewViewer=True)
        pxz.view.addGPUScene(self.planeScene, self.viewer.viewer)
        pxz.view.addGPUScene(self.gridScene, self.viewer.viewer)
        pxz.view.setViewerProperty("ShowEdges", "True", self.viewer.viewer)
        pxz.view.setViewerProperty("ShowPolygons", "True", self.viewer.viewer)
        pxz.view.setViewerProperty("UseUVAsPosition", "True", self.viewer.viewer)
        pxz.view.setViewerProperty("UVChannel", f"UV{self.uvSet}", self.viewer.viewer)
        pxz.view.setViewerProperty("EnableToneMaping", "False", self.viewer.viewer)
        pxz.view.setViewerProperty("BackFaceCulling", "DoubleSided", self.viewer.viewer)
        self.viewer.camera.setOrthographic(True)
        self.viewer.camera.setOrthographicSize(1)
        self.viewer.camera.setZNear(0.9)
        self.viewer.camera.setZFar(1.1)
        self.viewer.camera.setTarget(np.array([0.5, 0.5, 0]))
        self.viewer.camera.setDistance(1)
        self.viewer.camera.needsUpdate = True
        # We invert the up/down direction to match the UVs (0,0) being the top left corner
        self.viewer.camera.setUpDownInverted(True)
        self.onSelectionChanged(pxz.scene.SelectionChangeType.CLEARED, [])
        self.fitToUnitSquare()

    def draw(self):
        if self.viewer is None:
            self.initViewer()
        self.handleSizeChanges()
        self.viewer.refresh()
        imageTopLeft = np.array([imgui.get_cursor_screen_pos().x, imgui.get_cursor_screen_pos().y])
        imgui.image(pxz.view.getGLTextureHandle(self.viewer.currentTexture, self.viewer.viewer), ImVec2(self.size, self.size))
        # Camera movement (needs to come after the image as it uses imgui.is_item_clicked)
        self.handleCameraMovement()
        # show uv info
        self.showUvInfo(imageTopLeft)
        # texture selection
        imgui.separator()
        imgui.text("Selected Texture:")
        textureChanged, selectedTexture = self.textureWidget.draw()
        if textureChanged:
            pxz.core.setProperty(self.backgroundMaterial, "unlittexture", "TEXTURE(" + str(selectedTexture) + ")")
            self.fitToUnitSquare()
            if self.textureWidget.imageId != 0:
                imageSize = pxz.material.getImageSize(self.textureWidget.imageId)
                if self.gridAuto:
                    self.needGridUpdate = True
                    self.recreateGrid(imageSize["width"], imageSize["height"])

        
        imgui.text("UV channel:")
        changed, self.uvSet = imgui.combo("UVChannel", self.uvSet, ["UV0","UV1"])
        if changed:
            pxz.view.setViewerProperty("UVChannel", f"UV{self.uvSet}", self.viewer.viewer)
        imgui.separator()
        imgui.text("Grid:")
        if imgui.button("Fit to unit square"):
            self.fitToUnitSquare()

        imgui.same_line(spacing=50)

        if imgui.button("Fit to UV"):
            self.fitToUV()

        imgui.same_line(spacing = 50)


        #grid
        opened, checkboxState = imgui.checkbox("Show grid", self.gridVisible)
        if opened:
            if (checkboxState):
                pxz.scene.show(self.gridId)
                self.gridVisible = True
            else:
                pxz.scene.hide(self.gridId)
                self.gridVisible = False
        if imgui.is_key_pressed(imgui.Key.g):
            self.gridVisible = not self.gridVisible
            if self.gridVisible:
                pxz.scene.show(self.gridId)
            else:
                pxz.scene.hide(self.gridId)
        imgui.same_line(spacing = 50)

        opened, checkboxState = imgui.checkbox("Grid auto", self.gridAuto)

        if (opened):
            if (checkboxState):
                self.gridAuto = True
            else:
                self.gridAuto = False

        if (not self.gridAuto):
            imgui.same_line(spacing=50)
            imgui.set_next_item_width(150)
            modifiedW, w = imgui.input_int("Grid width", self.gridW)
            imgui.same_line(spacing=50)
            imgui.set_next_item_width(150)
            modifiedH, h = imgui.input_int("Grid height", self.gridH)
            if modifiedW:
                if w <= 0:
                    w = 1
                self.gridW = w
                self.needGridUpdate = True
            if modifiedH:
                if h <= 0:
                    h = 1
                self.gridH = h
                self.needGridUpdate = True

            self.recreateGrid(w, h)
        else:
            if opened and self.textureWidget.imageId != 0:
                imageSize = pxz.material.getImageSize(self.textureWidget.imageId)
                self.needGridUpdate = True
                w = imageSize["width"]
                h = imageSize["height"]
                if (w > 0 or h > 0):
                    self.recreateGrid(w, h)

        imgui.text("Filter texture:")
        rOpened, rCheckboxState = imgui.checkbox("R", self.wantR)
        if rOpened:
            self.wantR = True if rCheckboxState else False
            pxz.core.setProperty(self.backgroundMaterial, "R", str(self.wantR))
        imgui.same_line(spacing=50)
        gOpened, gCheckboxState = imgui.checkbox("G", self.wantG)
        if gOpened:
            self.wantG = True if gCheckboxState else False
            pxz.core.setProperty(self.backgroundMaterial, "G", str(self.wantG))
        imgui.same_line(spacing=50)
        bOpened, bCheckboxState = imgui.checkbox("B", self.wantB)
        if bOpened:
            self.wantB = True if bCheckboxState else False
            pxz.core.setProperty(self.backgroundMaterial, "B", str(self.wantB))
        imgui.same_line(spacing=50)
        aOpened, aCheckboxState = imgui.checkbox("A", self.wantA)
        if aOpened:
            self.wantA = True if aCheckboxState else False
            pxz.core.setProperty(self.backgroundMaterial, "A", str(self.wantA))



    def recreateGrid(self, w, h):
        if self.needGridUpdate:
            pxz.core.deleteEntities([self.gridId])
            self.createGrid(w, h)
            if self.gridVisible:
                pxz.scene.show(self.gridId)
            else:
                pxz.scene.hide(self.gridId)


    def onSelectionChanged(self, selectionType, selection):
        if selectionType == pxz.scene.SelectionChangeType.REMOVED:
            return
        if self.viewer:
            # we don't use the selection that is passed here, as it contains unselected occurrences (e.g. on clear)
            selection = pxz.scene.getSelectedOccurrences()
            uvAABR = pxz.algo.getUvAabr(selection, self.uvSet)
            aabrSize = np.sqrt((uvAABR.high.x - uvAABR.low.x) ** 2 + (uvAABR.high.y - uvAABR.low.y) ** 2)
            aabrCenter = np.array([(uvAABR.high.x + uvAABR.low.x) / 2, (uvAABR.high.y + uvAABR.low.y) / 2])
            self.aabrInfo = (aabrSize, aabrCenter)
            self.viewer.recreateGPUScene(selection)

    def createPlaneAndMaterial(self):
        # plane
        pxz.core.lockEntityRegistration()
        planeId = pxz.scene.createPlane(1, 1)
        pxz.algo.copyUV([planeId], 0, 1)
        pxz.scene.setLocalMatrix(planeId, [[1,0,0,0],[0,1,0,0],[0,0,1,-0.1],[0,0,0,1]])
        # material
        backgroundMaterial = pxz.material.createMaterial("BackgroundMaterial", "unlittexture", False)
        pxz.core.unlockEntityRegistration()
        pxz.core.setProperty(planeId, "Material", str(backgroundMaterial))
        return planeId, backgroundMaterial

    def handleCameraMovement(self):
        if imgui.get_io().key_alt:
            # pan
            if imgui.is_item_clicked(2) and not self.panning:
                self.panning = True
                self.panningLast = self.viewer.camera.getTarget()
            elif imgui.is_mouse_released(2):
                self.panning = False
            if self.panning:
                newTarget = np.array([-imgui.get_mouse_drag_delta(2)[0], imgui.get_mouse_drag_delta(2)[1], 0])
                newTarget /= self.size
                newTarget *= self.viewer.camera.getOrthographicSize()
                newTarget += self.panningLast
                #newTarget = np.clip(newTarget, 0, 1)
                self.viewer.camera.setTarget(newTarget)
                self.viewer.camera.needsUpdate = True
            # zoom
            # right click
            if imgui.is_item_clicked(1) and not self.zooming:
                self.zooming = True
                self.zoomingLast = self.viewer.camera.getOrthographicSize()
            elif imgui.is_mouse_released(1):
                self.zooming = False
            if self.zooming:
                delta = imgui.get_mouse_drag_delta(1)[1]
                if delta != 0:
                    factor = 1.0 + delta / 100
                    newSize = self.zoomingLast * factor
                    if newSize < 0.001:
                        newSize = 0.001
                    self.viewer.camera.setOrthographicSize(newSize)
                    self.viewer.camera.needsUpdate = True
        # mousewheel (only if no scrollbar in window)
        if imgui.get_io().mouse_wheel != 0 and imgui.is_item_hovered() and imgui.get_scroll_max_y() == 0:
            factor = 1.0 - imgui.get_io().mouse_wheel / 10
            newSize = self.viewer.camera.getOrthographicSize() * factor
            if newSize < 0.001:
                newSize = 0.001
            #newSize = np.clip(newSize, 0.001, 2)
            self.viewer.camera.setOrthographicSize(newSize)
            self.viewer.camera.needsUpdate = True

    def onResetSession(self):
        self.planeId, self.backgroundMaterial = self.createPlaneAndMaterial()
        self.gridId = self.createGrid(self.gridW, self.gridH)

    def onBeforeResetSession(self):
        self.viewer = None
        self.needGridUpdate = True
        self.gridMaterial = None

    def handleSizeChanges(self):
        newSize = int(imgui.get_content_region_avail()[0])
        if newSize != self.size:
            self.windowSizeIsChanging = True
            self.size = newSize
        else:
            if self.windowSizeIsChanging:
                self.windowSizeIsChanging = False
                self.viewer.resize(self.size, self.size)

    def showUvInfo(self, imageTopLeft):
        if imgui.is_item_hovered() and imgui.is_item_clicked(0):
            # mouse position relative to top left corner of the image
            mousePosRelative = np.array([imgui.get_mouse_pos().x, imgui.get_mouse_pos().y]) - imageTopLeft
            # pick get the mouse position translated to the plane (necessary if zoomed/panned)
            pickReturn = pxz.view.pick(int(mousePosRelative[0]), int(mousePosRelative[1]), self.viewer.viewer)
            self.mouseUv = np.array([pickReturn['position'].x, pickReturn['position'].y])
            imgui.open_popup("UV Info")
        if imgui.begin_popup("UV Info"):
            rgba = self.getRGBAValue()
            uvPosToPixel = self.uvPosToPixel()
            pixelColor = [0.20, 0.20, 0.20, 1]
            if self.textureWidget.imageId != 0:
                pixelColor = [rgba[0], rgba[1], rgba[2], 1]  # Initial color (RGBA)
                
            imgui.push_style_color(imgui.Col_.button, pixelColor)
            imgui.internal.push_item_flag(imgui.internal.ItemFlags_.disabled, True)
            imgui.button("   ", imgui.ImVec2(50, 50))  # Button acts as a colored rectangle
            imgui.internal.pop_item_flag()
            imgui.pop_style_color()
            imgui.same_line()
            imgui.text(f"UV: ({self.mouseUv[0]:.2}, {self.mouseUv[1]:.2})\n"
                       f"Pixel: {int(uvPosToPixel[0]), int(uvPosToPixel[1])}\n"
                       f"R: {int(rgba[0] * 255)}, G: {int(rgba[1] * 255)}, B: {int(rgba[2] * 255)}, A: {int(rgba[3] * 255)}")

            imgui.end_popup()


    def uvPosToPixel(self):
        imageId = self.textureWidget.imageId
        if imageId != 0:
            imageSize = pxz.material.getImageSize(imageId)
            width = imageSize["width"]
            height = imageSize["height"]
            pixelX = np.floor(self.mouseUv[0] * width)
            pixelY = np.floor(self.mouseUv[1] * height)
            if (pixelX <= width and pixelY <= height) and (pixelX >= 0 and pixelY >= 0):
                return np.array([pixelX, pixelY])

        return np.array([-1, -1])

    def getRGBAValue(self):
        x = self.uvPosToPixel()[0]
        y = self.uvPosToPixel()[1]
        imageId = self.textureWidget.imageId
        if imageId != 0 and (x > 0 or y > 0):
            color = pxz.material.getImagePixelColor(imageId, int(x), int(y))
            return np.array([color.r, color.g, color.b, color.a])
        return np.array([-1, -1, -1, -1])
    def fitToUnitSquare(self):
        self.viewer.camera.setTarget(np.array([0.5, 0.5, 0]))
        self.viewer.camera.setOrthographicSize(1.01)
        self.viewer.camera.needsUpdate = True
    def fitToUV(self):
        self.viewer.camera.setTarget(np.array([self.aabrInfo[1][0], self.aabrInfo[1][1], 0]))
        self.viewer.camera.setOrthographicSize(self.aabrInfo[0])
        self.viewer.camera.needsUpdate = True

    def createGrid(self, w, h, color=[1, 1, 1, 1]):
        if self.needGridUpdate:
            pxz.core.lockEntityRegistration()
            vertices = []
            indices = []
            stylizedLines = []
            if self.gridMaterial:
                pxz.core.deleteEntities([self.gridMaterial])
            self.gridMaterial = pxz.material.createMaterial("GridMaterial", "line", False)
            pxz.core.setProperty(self.gridMaterial, "color", str(color))

            for x in range(w + 1):
                vertices.append(pxz.geom.Point3(x / w, 0, 0.1))
                indices.append(len(vertices) - 1)
                vertices.append(pxz.geom.Point3(x / w, 1, 0.1))
                indices.append(len(vertices) - 1)
                indices.append(-1) #creates a new line
            for y in range(h + 1):
                vertices.append(pxz.geom.Point3(0, y / h, 0.1))
                indices.append(len(vertices) - 1)
                vertices.append(pxz.geom.Point3(1, y / h, 0.1))
                indices.append(len(vertices) - 1)
                indices.append(-1)  # creates a new line


            stylizedLines.append(pxz.polygonal.StylizedLine(indices, material=self.gridMaterial, externalId=0))
            meshDef = pxz.polygonal.MeshDefinition(0, 0, [], [], [], [0], [[]], [], [], [], [], [], [], vertices, stylizedLines,
                                               [], [], [], [], [])
            mesh = pxz.polygonal.createMeshFromDefinition(meshDef)
            occurrence = pxz.scene.createOccurrence("Grid")
            part = pxz.scene.addComponent(occurrence, pxz.scene.ComponentType.Part)
            pxz.scene.setPartMesh(part, mesh)
            self.needGridUpdate = False
            pxz.core.unlockEntityRegistration()
            self.gridId = occurrence
            self.gridW = w
            self.gridH = h
            return occurrence





