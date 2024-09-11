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
        self.textureLabels = ["Composited", "AlbedoOpacity", "Normal", "Depth", "MetallicRoughnessAOMeta", "Emissive", "ObjectIdPrimitiveId", "Tangent", "UVs", "SSAO"]
        # We would need to change the shader to display tangents as they are currently split over multiple textures
        self.textureLabels.remove("Tangent")

    def draw(self):
        #changed, self.ui.window.powerSaving = imgui.checkbox("PowerSaving", self.ui.window.powerSaving)
        if not pxz.is_remote() and imgui.collapsing_header("Compositing"):
            changed, self.viewer.currentTexture = imgui.combo("Texture", self.viewer.currentTexture, self.textureLabels)
            if changed:
                self.enableTexture(self.viewer.currentTexture)
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

    def enableTexture(self, id):
        textureName = self.textureLabels[id]
        # depth always rendered
        if textureName == "Depth":
            return
        # set property:
        textureName = "Render" + textureName
        if bool(pxz.view.getViewerProperty(textureName, self.viewer.viewer)) != "True":
            pxz.view.setViewerProperty(textureName, "True", self.viewer.viewer)
