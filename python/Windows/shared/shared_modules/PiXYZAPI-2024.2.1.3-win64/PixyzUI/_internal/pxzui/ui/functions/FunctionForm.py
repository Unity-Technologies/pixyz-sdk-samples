from imgui_bundle import imgui, ImVec2
import pxz
import sys
import traceback

from pxzui.ui.widgets.Utility import Utility


class FunctionForm:
    def __init__(self, ui):
        self.ui = ui
        self.function = None
        self.parameterWidgets = []
        self.optionalParameterWidgets = {}
        self.toolTips = {}
        self.paramIsString = {}
        self.setFocus = False
        self.selectionParameterWidgets = []
        self.selCbId = None
        self.setFocus = False
        self.doesntFit = False
        self.neededSpace = ImVec2(0, 0)

    def __del__(self):
        if self.selectionParameterWidgets:
            self.ui.window.callback_manager.removeSelectionChangedCallback(self.onSelectionChanged)

    def initialize(self, function):
        self.setFocus = False
        self.function = function
        # remove old callback
        if self.selectionParameterWidgets:
            self.ui.window.callback_manager.removeSelectionChangedCallback(self.onSelectionChanged)
        self.selectionParameterWidgets = []
        # remove old widgets and data
        for oldWidget in self.parameterWidgets + list(self.optionalParameterWidgets.keys()):
            oldWidget.destroy()
        self.parameterWidgets = []
        self.optionalParameterWidgets = {}
        self.toolTips = {}
        self.paramIsString = {}
        # create new widgets
        for index, parameter in enumerate(self.function.parameters):
            widget = Utility.createFunctionParameterWidget(self.ui, parameter.type, parameter.name,
                                                           parameter.defaultValue)
            if parameter.optional:
                self.optionalParameterWidgets[widget] = False
            else:
                self.parameterWidgets.append(widget)
            self.toolTips[parameter.name] = parameter.description
            self.paramIsString[parameter.name] = Utility.isFunctionParameterString(parameter.type)
            # adding selectionChangedCallback to automatically sync with occurrences in widget
            if parameter.type.name == "OccurrenceList":
                self.selectionParameterWidgets.append(widget)
                self.onSelectionChanged(None, None)
                if len(self.selectionParameterWidgets) == 1:
                    # Only append for the first selectionParameterWidget, the rest will not be modified by a callback.
                    # Otherwise, we can't set two occurrence list parameters to two different occurrences.
                    self.ui.window.callback_manager.addSelectionChangedCallback(self.onSelectionChanged)

    def onSelectionChanged(self, type, occurrences):
        # set occurrencelist parameter when selecting occurrences, like in studio
        sel = pxz.scene.getSelectedOccurrences()
        valueAsString = str(sel) if len(sel) > 0 else "[" + str(pxz.scene.getRoot()) + "]"
        for parameterWidget in self.selectionParameterWidgets:
            parameterWidget.setValue(valueAsString)

    def command(self, retName="_ret_"):
        cmd = "\n" + retName + " = "
        cmd += "pxz." + self.function.module.lower() + "." + self.function.name + "("
        index = 0
        for parameterWidget in self.parameterWidgets:
            if index != 0: cmd += ","
            cmd += parameterWidget.name + "="
            if self.paramIsString[parameterWidget.name]:
                cmd += "\"" + parameterWidget.getValue() + "\""
            else:
                cmd += parameterWidget.getValue()
            index += 1
        for parameterWidget, enabled in self.optionalParameterWidgets.items():
            if not enabled:
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
        self.ui.window.lockGPUScenesUpdate()
        try:
            exec(cmd)
        except Exception as e:
            print("Exception : " + str(e))
            traceback.print_exc(file=sys.stdout)
        self.ui.window.unlockGPUScenesUpdate()

    def drawParameterTable(self, tableFlags):
        imgui.set_next_item_width(imgui.get_content_region_avail()[0])
        if imgui.begin_table("Parameters", 2, tableFlags):
            imgui.table_setup_column("##ParameterName" + str(self.function.name), flags=imgui.TableColumnFlags_.width_fixed)
            imgui.table_setup_column("##ParameterValue" + str(self.function.name))
            for parameterWidget in self.parameterWidgets:
                imgui.table_next_row()
                imgui.table_set_column_index(0)
                # parameter name
                imgui.text(parameterWidget.name)
                # tooltip
                if imgui.is_item_hovered():
                    imgui.set_tooltip(self.toolTips[parameterWidget.name])
                imgui.table_set_column_index(1)
                # actual parameter widget
                imgui.set_next_item_width(imgui.get_content_region_avail()[0])
                parameterWidget.draw()
            imgui.end_table()

    def drawOptionalParameterTable(self, tableFlags):
        # optional parameters in a collapsible header below the parameter table
        if not self.optionalParameterWidgets:
            return
        if not imgui.collapsing_header("Optional Parameters"):
            return
        imgui.set_next_item_width(imgui.get_content_region_avail()[0])
        if imgui.begin_table("OptionalParameters", 2, tableFlags):
            imgui.table_setup_column("##ParameterName" + str(self.function.name), flags=imgui.TableColumnFlags_.width_fixed)
            imgui.table_setup_column("##ParameterValue" + str(self.function.name))
            for parameterWidget, enabled in self.optionalParameterWidgets.items():
                imgui.table_next_row()
                imgui.table_set_column_index(0)
                # checkbox for optional parameters
                _, self.optionalParameterWidgets[parameterWidget] = imgui.checkbox(
                    "##Optional" + parameterWidget.name, enabled)
                if not enabled:
                    imgui.begin_disabled()
                imgui.same_line()
                # parameter name
                imgui.text(parameterWidget.name)
                # tooltip
                if imgui.is_item_hovered():
                    imgui.set_tooltip(self.toolTips[parameterWidget.name])
                imgui.table_set_column_index(1)
                # actual parameter widget
                imgui.set_next_item_width(imgui.get_content_region_avail()[0])
                parameterWidget.draw()
                # end of disable from optional parameter
                if not enabled:
                    imgui.end_disabled()
            imgui.end_table()

    def draw(self):
        if self.function is None:
            return
        # setting focus
        if not self.setFocus:
            imgui.set_window_focus()
            self.setFocus = True
        # parameter tables
        tableFlags = imgui.TableFlags_.borders_h
        self.drawParameterTable(tableFlags)
        self.drawOptionalParameterTable(tableFlags)
        # buttons
        ctrlC = imgui.get_io().key_ctrl and imgui.is_key_pressed(imgui.Key.c) and imgui.is_window_focused()
        if imgui.button("Copy to Clipboard (Ctrl+C)", ImVec2(imgui.get_content_region_avail()[0], 0)) or ctrlC:
            imgui.set_clipboard_text(self.command())
        if imgui.button("Run", ImVec2(imgui.get_content_region_avail()[0], 0)):
            self.ui.processQueue.enqueue(self.run)
        # check if the window is too small
        availableSpace = imgui.get_content_region_avail()
        if availableSpace[0] != 0 or availableSpace[1] != 0:
            self.doesntFit = True
            self.neededSpace = ImVec2(imgui.get_window_width() - availableSpace[0],
                                      imgui.get_window_height() - availableSpace[1])
        else:
            self.doesntFit = False
            self.neededSpace = ImVec2(0, 0)
