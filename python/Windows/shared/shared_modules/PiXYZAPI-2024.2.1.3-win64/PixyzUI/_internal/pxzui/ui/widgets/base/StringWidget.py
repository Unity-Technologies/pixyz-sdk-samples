from imgui_bundle import imgui
from pxzui.ui.widgets.IWidget import IWidget


class StringWidget(IWidget):
    def __init__(self, ui, name, defaultValue, readOnly=False):
        self.ui = ui
        self.name = name
        # string default values are already escaped
        self.value = defaultValue.replace("'", "").replace('"', '')
        self.readOnly = readOnly

    def draw(self):
        flags = imgui.InputTextFlags_.none
        if self.readOnly:
            flags = imgui.InputTextFlags_.read_only
        changed, self.value = imgui.input_text("##" + self.name, self.value, flags)
        if imgui.is_item_active():
            # don't fire shortcuts when typing in the text field
            self.ui.shortcuts.skipBasicThisFrame()
        return changed, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value

