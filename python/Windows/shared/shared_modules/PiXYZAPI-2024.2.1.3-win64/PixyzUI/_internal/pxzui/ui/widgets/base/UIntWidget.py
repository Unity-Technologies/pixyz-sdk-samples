from imgui_bundle import imgui
from pxzui.ui.widgets.IWidget import IWidget


class UIntWidget(IWidget):
    def __init__(self, ui, name, defaultValue, readOnly=False):
        self.ui = ui
        self.name = name
        self.value = defaultValue if defaultValue != "" else "0"
        self.readOnly = readOnly

    def draw(self):
        if self.readOnly:
            imgui.begin_disabled()
        intValue = int(self.value)
        if intValue < 0:
            intValue = -intValue
        changed, intValue = imgui.input_int("##" + self.name, intValue)
        if imgui.is_item_active():
            self.ui.shortcuts.skipBasicThisFrame()
        self.value = str(intValue)
        if self.readOnly:
            imgui.end_disabled()
        return changed, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value

