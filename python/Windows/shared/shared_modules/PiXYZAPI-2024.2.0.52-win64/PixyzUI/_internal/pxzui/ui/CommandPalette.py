from imgui_bundle import imgui_command_palette as imcmd, ImVec4, imgui


class Callback:
    def __init__(self, ui, function):
        self.ui = ui
        self.function = function

    def terminatingCallback(self):
        self.ui.functionDialog.open(self.function)

class CommandPalette:
    def __init__(self, ui):
        self.ui = ui
        self._show = False
        self.context = imcmd.ContextWrapper()
        self.populate()
        imcmd.set_style_color(imcmd.ImCmdTextType.highlight, imgui.color_convert_float4_to_u32(ImVec4(1, 1, 1, 1)))

    def populate(self):
        for module in self.ui.functionLibrary.modules:
            for group in module.groups:
                for function in group.functions:
                    cmd = imcmd.Command()
                    # don't show group name in command palette
                    cmd.name = self.ui.functionLibrary.getPrettyFunctionString(module, function, False)
                    cb = Callback(self.ui, function)
                    cmd.terminating_callback = cb.terminatingCallback
                    imcmd.add_command(cmd)

    def toggle(self):
        if self.isEnabled():
            self.disable()
        else:
            self.enable()

    def enable(self):
        self._show = True
        self.ui.shortcuts.disable()

    def disable(self):
        self._show = False
        self.ui.shortcuts.enable()

    def setEnabled(self, enabled):
        if enabled:
            self.enable()
        else:
            self.disable()

    def isEnabled(self):
        return self._show
