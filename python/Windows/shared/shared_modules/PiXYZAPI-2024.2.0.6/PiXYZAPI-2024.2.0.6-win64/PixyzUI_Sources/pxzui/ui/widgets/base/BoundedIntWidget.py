from imgui_bundle import imgui
from pxzui.ui.widgets.IWidget import IWidget
from pxzui.ui.widgets.Utility import *

class BoundedIntWidget(IWidget):
    def __init__(self, name, defaultValue):
        self.name = name
        if defaultValue != "":
            self.setValue(defaultValue)

    def draw(self):
        changed, self.value = imgui.slider_int("##" + self.name, self.value, self.min, self.max)
        return changed, self.getValue()

    def getValue(self):
        return "[" + str(self.value) + "," + str(self.min) + "," + str(self.max) + "]"

    def setValue(self, value):
        values = Utility.parseList(value)
        self.value = int(values[0])
        self.min = int(values[1])
        self.max = int(values[2])
