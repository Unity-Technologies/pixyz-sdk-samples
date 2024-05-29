from imgui_bundle import imgui
from pxzui.ui.widgets.IWidget import IWidget


class StringWidget(IWidget):
    def __init__(self, ui, name, defaultValue):
        self.ui = ui
        self.name = name
        self.value = defaultValue

    def draw(self):
        changed, self.value = imgui.input_text("##" + self.name, self.value)
        if imgui.is_item_focused():
            # don't fire shortcuts when typing in the text field
            self.ui.shortcuts.skipBasicThisFrame()
        return changed, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value

