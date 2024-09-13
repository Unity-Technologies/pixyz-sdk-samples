import pxz

from pxzui.ui.widgets.IWidget import IWidget
from pxzui.ui.widgets.Utility import Utility
from imgui_bundle import imgui

class SelectWidget(IWidget):
    def __init__(self, ui, typeObj, name, defaultValue, readonly=False):
        self.name = name
        # create possible widgets
        self.widgets = {}
        for selType in typeObj.definition[1].types:
            selTypeType = pxz.core.getType(typeObj.module, selType.type)
            self.widgets[selType.name] = Utility.createFunctionParameterWidget(ui, selTypeType, selType.name, selType.defaultValue)
        self.options = list(self.widgets.keys())
        # default to first if no default value was set
        self.selectedOption = ""
        if defaultValue == "":
            self.selectedOption = list(self.widgets.keys())[0]
            self.value = ""
        else:
            self.selectedOption = Utility.parseList(defaultValue)[0].strip("'").strip('"')
            self.value = defaultValue
        self.readonly = readonly

    def draw(self):
        if self.readonly:
            imgui.begin_disabled()
        anyChanges = False
        newValue = '['
        changedOption, selectedOptionIndex = imgui.combo("##OptionSelect" + self.name, self.options.index(self.selectedOption), self.options)
        if changedOption:
            self.selectedOption = self.options[selectedOptionIndex]
        anyChanges |= changedOption
        newValue += "'" + self.selectedOption + "',"
        imgui.set_next_item_width(imgui.get_content_region_avail()[0])
        changedValue, selectedValue = self.widgets[self.selectedOption].draw()
        anyChanges |= changedValue
        newValue += selectedValue
        newValue += ']'
        self.value = newValue
        if self.readonly:
            imgui.end_disabled()
        return anyChanges, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value
