import pxz

from pxzui.ui.widgets.IWidget import IWidget
from pxzui.ui.widgets.Utility import Utility
from imgui_bundle import imgui

class StructWidget(IWidget):
    def __init__(self, ui, typeObj, name, defaultValue):
        self.name = name
        self.fields = {}
        self.value = ""
        for field in typeObj.definition[1].fields:
            fieldType = pxz.core.getType(typeObj.module, field.type)
            self.fields[field.name] = Utility.createFunctionParameterWidget(ui, fieldType, field.name)

    def draw(self):
        anyChanges = False
        newValue = '['
        index = 0
        if imgui.begin_table("##StructWidgetTable" + self.name, 2):
            for field in self.fields.keys():
                imgui.table_next_row()
                imgui.table_next_column()
                imgui.text(field)
                imgui.table_next_column()
                fieldChanged, fieldValue = self.fields[field].draw()
                anyChanges |= fieldChanged
                newValue += fieldValue
                if index + 1 < len(self.fields.keys()): newValue += ','
                index += 1
            imgui.end_table()
        newValue += ']'
        self.value = newValue
        return anyChanges, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value
