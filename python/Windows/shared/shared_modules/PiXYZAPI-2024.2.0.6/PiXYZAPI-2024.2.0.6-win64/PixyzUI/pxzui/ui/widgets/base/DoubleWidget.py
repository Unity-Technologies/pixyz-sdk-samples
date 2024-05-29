from imgui_bundle import imgui
from pxzui.ui.widgets.IWidget import IWidget


class DoubleWidget(IWidget):
    def __init__(self, name, defaultValue):
        self.name = name
        self.value = defaultValue if defaultValue != "" else "0.0"

    def draw(self):
        changed, floatValue = imgui.input_float("##" + self.name, float(self.value))
        self.value = str(floatValue)
        return changed, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value
