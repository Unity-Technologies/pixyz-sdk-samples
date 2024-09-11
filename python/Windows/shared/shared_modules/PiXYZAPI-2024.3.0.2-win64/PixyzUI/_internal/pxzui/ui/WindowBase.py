from imgui_bundle import imgui

from pxzui.ui.ConfigOwner import ConfigOwner


class WindowBase(ConfigOwner):
    def __init__(self, name="", flags=0):
        super().__init__()
        self.setConfig("enabled", False)
        self.name = self.__class__.__name__ if name == "" else name
        self.flags = flags
        self.firstFrame = True
        self.customBackground = None

    def enable(self):
        self.setConfig("enabled", True)

    def disable(self):
        self.setConfig("enabled", False)

    def toggle(self):
        if self.isEnabled():
            self.disable()
        else:
            self.enable()

    def isEnabled(self):
        return self.getConfig("enabled")

    def drawBase(self):
        if not self.isEnabled():
            return
        self.windowPosition()
        if self.customBackground:
            imgui.push_style_color(imgui.Col_.window_bg, self.customBackground)
        visible, enabled = imgui.begin(self.name, self.isEnabled(), self.flags)
        if not enabled:
            self.disable()
        if not self.firstFrame:
            self.setConfig("visible", visible)
        self.firstFrame = False
        if visible:
            self.draw()
        imgui.end()
        if self.customBackground:
            imgui.pop_style_color()
    def draw(self):
        raise NotImplementedError

    def windowPosition(self):
        pass

    def restoreFocus(self):
        # we use focus to set window visible on top of the docked area
        if self.getConfig("visible"):
            imgui.set_window_focus(self.name)