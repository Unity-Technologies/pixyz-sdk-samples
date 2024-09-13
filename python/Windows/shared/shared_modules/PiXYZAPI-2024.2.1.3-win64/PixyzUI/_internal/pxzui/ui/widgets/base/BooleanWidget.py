from imgui_bundle import imgui
from pxzui.ui.widgets.IWidget import IWidget


class BooleanWidget(IWidget):
    def __init__(self, name, defaultValue, readOnly=False):
        self.name = name
        self.value = defaultValue.capitalize() if defaultValue != "" else "True"
        self.readOnly = readOnly

    def draw(self):
        if self.readOnly:
            imgui.begin_disabled()
        changed, boolValue = imgui.checkbox("##" + self.name, self.value == "True")
        self.value = str(boolValue)
        if self.readOnly:
            imgui.end_disabled()
        return changed, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value
