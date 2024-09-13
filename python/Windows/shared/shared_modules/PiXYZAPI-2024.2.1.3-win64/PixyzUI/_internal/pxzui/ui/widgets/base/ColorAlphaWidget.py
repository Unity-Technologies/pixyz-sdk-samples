from imgui_bundle import imgui
from pxzui.ui.widgets.IWidget import IWidget


class ColorAlphaWidget(IWidget):
    def __init__(self, name, defaultValue, readOnly=False):
        self.name = name
        self.value = defaultValue if defaultValue != "" else "[0.0, 0.0, 0.0, 1.0]"
        self.readOnly = readOnly

    def draw(self):
        if self.readOnly:
            imgui.begin_disabled()
        changed, floatValue = imgui.color_edit4("##" + self.name, eval(self.value))
        self.value = str(floatValue)
        if self.readOnly:
            imgui.end_disabled()
        return changed, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value

