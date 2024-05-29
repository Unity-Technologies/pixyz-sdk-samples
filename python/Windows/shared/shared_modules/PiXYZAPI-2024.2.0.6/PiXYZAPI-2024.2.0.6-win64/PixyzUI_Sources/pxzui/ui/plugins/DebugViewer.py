import pxz
from pxzui.ui.SceneTree import SceneTree
from imgui_bundle import imgui

def onDebugEvent(event_type, debugViewer):
    debugViewer.onDebugEvent(event_type)

class DebugViewer(SceneTree):
    def __init__(self, ui):
        super().__init__(pxz.scene.getDebugRoot())
        self.viewer = ui.window.viewer.viewer
        gpuScene = pxz.view.createGPUScene([pxz.scene.getDebugRoot()])
        pxz.view.addGPUScene(gpuScene, self.viewer)
        pxz.core.addDebugEventCallback(onDebugEvent, self)
        self.paused = False

    def draw(self):
        if self.paused:
            if imgui.button("(Paused) Resume"):
                self.resume()
        super().draw()

    def onDebugEvent(self, event_type):
        if event_type == 0:
            self.pause()

    def pause(self):
        pxz.core.unlockProcessing()
        pxz.view.refreshViewer(self.viewer, 1, True)
        pxz.core.lockProcessing()
        self.paused = True

    def resume(self):
        self.paused = False
        pxz.core.sendDebugMessage(1)

def pluginInit(ui):
    try:
        ui.registerWindow(DebugViewer, ui)
    except:
        # scene.getDebugRoot() does not exists in CUSTOMER_RELEASE
        pass
