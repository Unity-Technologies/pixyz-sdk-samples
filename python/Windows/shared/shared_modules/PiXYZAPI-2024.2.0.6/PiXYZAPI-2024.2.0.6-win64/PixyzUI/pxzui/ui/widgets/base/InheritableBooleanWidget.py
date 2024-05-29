from imgui_bundle import imgui
from pxzui.ui.widgets.IWidget import IWidget


class InheritableBooleanWidget(IWidget):
    def __init__(self, name, defaultValue):
        self.name = name
        self.value = defaultValue.capitalize() if defaultValue != "" else "True"

    def draw(self):
        if self.value == "Inherited":
            imgui.internal.push_item_flag(imgui.internal.ItemFlags_.mixed_value, True)
            changed, boolValue = imgui.checkbox("##" + self.name, True)
            imgui.internal.pop_item_flag()
            if changed:
                self.value = "Inherited" if boolValue else "False"
        else:
            changed, boolValue = imgui.checkbox("##" + self.name, self.value == "True")
            if changed:
                self.value = "True" if boolValue else "Inherited"
        return changed, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value
