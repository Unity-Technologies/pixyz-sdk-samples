from pxzui.ui.widgets.IWidget import IWidget
from imgui_bundle import imgui

class EnumWidget(IWidget):
    def __init__(self, name, defaultValue, labels, readonly=False, valueAsInt=True):
        self.valueAsInt = valueAsInt
        self.name = name
        self.labels = labels
        self.value = defaultValue if defaultValue != "" else "0"
        self.readonly = readonly

    def draw(self):
        if self.valueAsInt:
            if self.readonly:
                imgui.begin_disabled()
            changed, self.value = imgui.combo("##" + self.name, int(self.value), self.labels)
            self.value = str(self.value)
            if self.readonly:
                imgui.end_disabled()
            return changed, self.value
        else:
            if self.readonly:
                imgui.begin_disabled()
            changed, valueInt = imgui.combo("##" + self.name, self.labels.index(self.value), self.labels)
            self.value = self.labels[valueInt]
            if self.readonly:
                imgui.end_disabled()
            return changed, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value
