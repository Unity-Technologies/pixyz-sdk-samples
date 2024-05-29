import threading

import numpy as np
import pxz
import glfw
from imgui_bundle import imgui, ImVec2
from pxzui.ui.WindowBase import WindowBase
from pxzui.ui.widgets.base.TextureWidget import TextureWidget
from pxzui.viewer.Viewer import Viewer


class UVViewer(WindowBase):
    """Superposing two GPU scenes to display the UVs on top of a selected texture"""
    def __init__(self, ui):
        super().__init__("UV Viewer")
        self._lock = threading.Lock()
        self.ui = ui
        self.size = 500  # default image size, will be changed with window size
        self.textureWidget = TextureWidget(ui, "Selected Texture")
        self.planeId, self.backgroundMaterial = self.createPlaneAndMaterial()
        # viewer
        self.viewer = None
        self.planeScene = None
        self.windowSizeIsChanging = False
        pxz.scene.addSelectionChangedCallback(lambda: self.onSelectionChanged(), self)
        pxz.core.addOnSessionResetCallback(lambda: self.onResetSession(), self)
        # camera movement
        self.panning = False
        self.panningLast = None
        self.zooming = False
        self.zoomingLast = None
        # uv info
        self.mouseUv = np.array([0, 0])

    def initViewer(self):
        pxz.core.setProperty(self.backgroundMaterial, "ao", "COEFF(0.0)")
        #pxz.core.setProperty(self.root, "Material", str(self.backgroundMaterial))
        pxz.core.setProperty(self.backgroundMaterial, "emissive", "COLOR([0.2,0.2,0.2])")
        # setup viewer with two gpu scenes
        self.planeScene = pxz.view.createGPUScene([self.planeId], True)        
        self.viewer = Viewer(self.size, self.size, glfw.get_wgl_context(self.ui.window.glfwWindow), previewViewer=True)
        pxz.view.addGPUScene(self.planeScene, self.viewer.viewer)
        pxz.view.setViewerProperty("ShowEdges", "True", self.viewer.viewer)
        pxz.view.setViewerProperty("ShowPolygons", "True", self.viewer.viewer)
        pxz.view.setViewerProperty("UseUVAsPosition", "True", self.viewer.viewer)
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
        self.onSelectionChanged()

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
            pxz.core.setProperty(self.backgroundMaterial, "emissive", "TEXTURE(" + str(selectedTexture) + ")")

    def onSelectionChanged(self):
        if self.viewer:
            selection = pxz.scene.getSelectedOccurrences()
            pxz.view.removeGPUScene(self.viewer.gpuScene, self.viewer.viewer)
            pxz.view.destroyGPUScene(self.viewer.gpuScene)
            self.viewer.gpuScene = pxz.view.createGPUScene(selection, True)
            pxz.view.addGPUScene(self.viewer.gpuScene, self.viewer.viewer)

    def createPlaneAndMaterial(self):
        # plane
        pxz.core.lockEntityRegistration()
        planeId = pxz.scene.createPlane(1, 1)
        pxz.scene.setLocalMatrix(planeId, [[1,0,0,0],[0,1,0,0],[0,0,1,-0.1],[0,0,0,1]])
        # material
        backgroundMaterial = pxz.material.createMaterial("BackgroundMaterial", "PBR", False)
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
        self.viewer = None
        self.planeId, self.backgroundMaterial = self.createPlaneAndMaterial()

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
            imgui.text(f"({self.mouseUv[0]:.6}, {self.mouseUv[1]:.6})")
            imgui.end_popup()
