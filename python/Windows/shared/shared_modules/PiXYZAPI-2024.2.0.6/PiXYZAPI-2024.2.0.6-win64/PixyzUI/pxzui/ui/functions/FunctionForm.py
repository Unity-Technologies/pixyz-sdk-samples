from imgui_bundle import imgui, ImVec2
import pxz
import sys
import traceback

from pxzui.ui.widgets.Utility import Utility

def onSelectionChanged(type, occurrences, functionForm):
    functionForm.onSelectionChanged()

class FunctionForm:
    def __init__(self, ui):
        self.ui = ui
        self.function = None
        self.parameterWidgets = []
        self.toolTips = {}
        self.optionalParameters = {}
        self.paramIsString = {}
        self.selectionParameterIndex = None
        self.selCbId = None
        self.setFocus = False

    def __del__(self):
        if self.selectionParameterIndex != None:
            pxz.scene.removeSelectionChangedCallback(self.selCbId)

    def initialize(self, function):
        self.setFocus = False
        self.function = function
        # remove old callback
        if self.selectionParameterIndex != None:
            pxz.scene.removeSelectionChangedCallback(self.selCbId)
        self.selectionParameterIndex = None
        # remove old widgets and data
        for oldWidget in self.parameterWidgets:
            oldWidget.destroy()
        self.parameterWidgets = []
        self.toolTips = {}
        self.optionalParameters = {}
        self.paramIsString = {}
        # create new widgets
        for index, parameter in enumerate(self.function.parameters):
            self.parameterWidgets.append(Utility.createFunctionParameterWidget(self.ui, parameter.type, parameter.name, parameter.defaultValue))
            self.toolTips[parameter.name] = parameter.description
            self.paramIsString[parameter.name] = Utility.isFunctionParameterString(parameter.type)
            if parameter.optional:
                self.optionalParameters[parameter.name] = True
            # adding selectionChangedCallback to automatically sync with occurrences in widget
            if parameter.type.name == "OccurrenceList":
                self.selectionParameterIndex = index
                self.onSelectionChanged()
                self.selCbId = pxz.scene.addSelectionChangedCallback(onSelectionChanged, self)

    def onSelectionChanged(self):
        sel = pxz.scene.getSelectedOccurrences()
        valueAsString = str(sel) if len(sel) > 0 else "[" + str(pxz.scene.getRoot()) + "]"
        self.parameterWidgets[self.selectionParameterIndex].setValue(valueAsString)

    def command(self, retName="_ret_"):
        cmd = "\n" + retName + " = "
        cmd += "pxz." + self.function.module.lower() + "." + self.function.name + "("
        index = 0
        for parameterWidget in self.parameterWidgets:
            if parameterWidget.name in self.optionalParameters and not self.optionalParameters[parameterWidget.name]:
                continue
            if index != 0: cmd += ","
            cmd += parameterWidget.name + "="
            if self.paramIsString[parameterWidget.name]:
                cmd += "\"" + parameterWidget.getValue() + "\""
            else:
                cmd += parameterWidget.getValue()
            index += 1
        cmd += ")"
        return cmd

    def run(self):
        cmd = self.command("_ret_")
        cmd += "\nprint(_ret_)"
        print(cmd)
        pxz.core.lockProcessing()
        try:
            exec(cmd)
        except Exception as e:
            print("Exception : " + str(e))
            traceback.print_exc(file=sys.stdout)
        pxz.core.unlockProcessing()

    def draw(self):
        if self.function is None:
            return
        # setting focus
        if not self.setFocus:
            imgui.set_window_focus()
            self.setFocus = True
        # parameter table
        imgui.set_next_item_width(imgui.get_content_region_avail()[0])
        table_flags = imgui.TableFlags_.borders_h
        if imgui.begin_table("Parameters", 2, table_flags):
            for parameterWidget in self.parameterWidgets:
                imgui.table_next_row()
                imgui.table_next_column()
                # checkbox for optional parameters
                if parameterWidget.name in self.optionalParameters:
                    _, self.optionalParameters[parameterWidget.name] = imgui.checkbox("##Optional" + parameterWidget.name, self.optionalParameters[parameterWidget.name])
                    if not self.optionalParameters[parameterWidget.name]:
                        imgui.begin_disabled()
                    imgui.same_line()
                # parameter name
                imgui.text(parameterWidget.name)
                # tooltip
                if imgui.is_item_hovered():
                    imgui.set_tooltip(self.toolTips[parameterWidget.name])
                imgui.table_next_column()
                # actual parameter widget
                imgui.set_next_item_width(imgui.get_content_region_avail()[0])
                parameterWidget.draw()
                # end of disable from optional parameter
                if parameterWidget.name in self.optionalParameters and not self.optionalParameters[parameterWidget.name]:
                    imgui.end_disabled()
            imgui.end_table()
        # buttons
        ctrlC = imgui.get_io().key_ctrl and imgui.is_key_pressed(imgui.Key.c) and imgui.is_window_focused()
        if imgui.button("Copy to Clipboard (Ctrl+C)", ImVec2(imgui.get_content_region_avail()[0], 0)) or ctrlC:
            imgui.set_clipboard_text(self.command())
        if imgui.button("Run", ImVec2(imgui.get_content_region_avail()[0], 0)):
            self.ui.processQueue.enqueue(self.run)
