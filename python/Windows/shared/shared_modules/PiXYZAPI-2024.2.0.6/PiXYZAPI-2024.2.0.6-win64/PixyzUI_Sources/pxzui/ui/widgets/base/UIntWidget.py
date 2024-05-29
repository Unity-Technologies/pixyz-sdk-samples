from imgui_bundle import imgui
from pxzui.ui.widgets.IWidget import IWidget


class UIntWidget(IWidget):
    def __init__(self, name, defaultValue):
        self.name = name
        self.value = defaultValue if defaultValue != "" else "0"

    def draw(self):
        intValue = int(self.value)
        if intValue < 0:
            intValue = -intValue
        changed, intValue = imgui.input_int("##" + self.name, intValue)
        self.value = str(intValue)
        return changed, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value

