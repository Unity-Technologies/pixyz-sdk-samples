import pxz
from imgui_bundle import imgui, ImVec2
from pxzui.viewer.Viewer import Viewer

class MaterialPreview:
    def __init__(self, window):
        self.window = window
        self.materialId = None
        pxz.core.lockEntityRegistration()
        self.sphereId = pxz.scene.createSphere(500, 32, 32)
        pxz.core.unlockEntityRegistration()
        self.size = 100
        self.viewer = Viewer(self.window, self.size, self.size, root=self.sphereId, previewViewer=True)
        self.lastRotation = 0
        # zoom to have sphere fill window
        self.viewer.camera.zoom(0.72)

    def initialize(self, materialId):
        self.materialId = materialId
        pxz.core.setProperty(self.sphereId, "Material", str(self.materialId))

    def draw(self):
        if self.materialId is None:
            return
        newSize = int(imgui.get_content_region_avail()[0])
        if newSize != self.size:
            self.size = newSize
            self.viewer.resize(self.size, self.size)
        self.viewer.refresh()
        imgui.image_button("##preview image button", pxz.view.getGLTextureHandle(self.viewer.currentTexture, self.viewer.viewer), ImVec2(self.size, self.size))
        if imgui.is_item_hovered() and imgui.is_item_active():
            currentRotation = imgui.get_mouse_drag_delta()[0]
            pxz.scene.rotate(self.sphereId, pxz.geom.Point3(0, 1, 0), currentRotation - self.lastRotation)
            self.lastRotation = currentRotation
        else:
            self.lastRotation = 0
