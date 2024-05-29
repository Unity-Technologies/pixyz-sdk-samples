from imgui_bundle import imgui
from pxzui.ui.widgets.IWidget import IWidget


class BooleanWidget(IWidget):
    def __init__(self, name, defaultValue):
        self.name = name
        self.value = defaultValue.capitalize() if defaultValue != "" else "True"

    def draw(self):
        changed, boolValue = imgui.checkbox("##" + self.name, self.value == "True")
        self.value = str(boolValue)
        return changed, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value
