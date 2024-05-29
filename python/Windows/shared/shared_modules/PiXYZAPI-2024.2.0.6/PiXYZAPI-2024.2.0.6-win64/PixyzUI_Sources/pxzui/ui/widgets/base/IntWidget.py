from imgui_bundle import imgui
from pxzui.ui.widgets.IWidget import IWidget


class IntWidget(IWidget):
    def __init__(self, name, defaultValue):
        self.name = name
        self.value = defaultValue if defaultValue != "" else "0"

    def draw(self):
        changed, intValue = imgui.input_int("##" + self.name, int(self.value))
        self.value = str(intValue)
        return changed, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value
