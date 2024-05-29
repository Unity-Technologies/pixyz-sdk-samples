from pxzui.ui.widgets.IWidget import IWidget
from imgui_bundle import imgui

class EnumWidget(IWidget):
    def __init__(self, name, defaultValue, labels, valueAsInt=True):
        self.valueAsInt = valueAsInt
        self.name = name
        self.labels = labels
        self.value = defaultValue if defaultValue != "" else "0"

    def draw(self):
        if self.valueAsInt:
            changed, self.value = imgui.combo("##" + self.name, int(self.value), self.labels)
            self.value = str(self.value)
            return changed, self.value
        else:
            changed, valueInt = imgui.combo("##" + self.name, self.labels.index(self.value), self.labels)
            self.value = self.labels[valueInt]
            return changed, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value
