from pxzui.ui.Properties import *
from pxzui.ui.WindowBase import WindowBase
from pxzui.viewer.CameraSettings import CameraSettings


class Visualization(WindowBase):
    def __init__(self, ui, viewer, gizmo):
        super().__init__()
        self.ui = ui
        self.viewer = viewer
        self.viewerProperties = ViewerProperties(ui, viewer.viewer)
        self.gizmo = gizmo
        self.cameraSettings = CameraSettings(ui)

    def draw(self):
        #changed, self.ui.window.powerSaving = imgui.checkbox("PowerSaving", self.ui.window.powerSaving)
        if not pxz.is_remote() and imgui.collapsing_header("Compositing"):
            changed, self.viewer.currentTexture = imgui.combo("Texture", self.viewer.currentTexture, "Composited\0AlbedoOpacity\0Normal\0Depth\0MetallicRoughnessAOMisc\0Emissive\0ObjectIdPrimitiveId\0Tangent\0UVs\0")
        if imgui.collapsing_header("Viewer properties"):
            self.viewerProperties.draw()
        if imgui.collapsing_header("Gizmo"):
            self.gizmo.drawProperties()
        if imgui.collapsing_header("Camera Settings"):
            self.cameraSettings.draw()

    def restoreConfig(self, config):
        super().restoreConfig(config)
        if "PowerSaving" in config.keys():
            self.ui.window.powerSaving = config["PowerSaving"]
        if "ViewerSettings" in config.keys():
            self.viewerProperties.restoreConfig(config["ViewerSettings"])

    def saveConfig(self):
        config = super().saveConfig()
        config["PowerSaving"] = self.ui.window.powerSaving
        config["ViewerSettings"] = {k: v.getValue() for k, v in self.viewerProperties.widgets.items()}
        return config