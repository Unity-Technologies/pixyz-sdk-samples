from imgui_bundle import imgui
from pxzui.ui.widgets.IWidget import IWidget


class Point3Widget(IWidget):
    def __init__(self, ui, name, defaultValue, readonly=False):
        self.ui = ui
        self.name = name
        self.value = defaultValue if defaultValue != "" else "[0,0,0]"
        self.readonly = readonly

    def draw(self):
        if self.readonly:
            imgui.begin_disabled()
        changed, floatListValue = imgui.input_float3("##" + self.name, eval(self.value))
        if imgui.is_item_active():
            self.ui.shortcuts.skipBasicThisFrame()
        self.value = str(floatListValue)
        if self.readonly:
            imgui.end_disabled()
        return changed, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value

