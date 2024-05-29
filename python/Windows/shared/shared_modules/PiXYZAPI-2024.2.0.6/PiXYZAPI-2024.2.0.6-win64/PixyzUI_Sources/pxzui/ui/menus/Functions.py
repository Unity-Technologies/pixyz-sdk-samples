from imgui_bundle import imgui
from imgui_bundle import imgui_command_palette as imcmd

class Functions:
    def __init__(self, ui):
        self.ui = ui
        self.addShortcuts()

    def draw(self):
        if imgui.begin_menu("Functions", True):
            clickedBrowser, selectedBrowser = imgui.menu_item("Browser", "Ctrl+Shift+K", self.ui.functionBrowser.visible, True)
            if clickedBrowser:
                self.ui.functionBrowser.toggle()
            clickedCommandPalette, selectedCommandPalette = imgui.menu_item("CommandPalette", "Ctrl+Shift+P", self.ui.commandPalette.isEnabled(), True)
            if clickedCommandPalette:
                self.ui.commandPalette.toggle()
            if self.ui.commandPalette.isEnabled():
                commandPaletteEnabled = imcmd.command_palette_window("CommandPalette", True)
                self.ui.commandPalette.setEnabled(commandPaletteEnabled)
            clickedScripting, selectedScripting = imgui.menu_item("Scripting", "Ctrl+Shift+J", self.ui.scripting.getConfig("visible"), True)
            if clickedScripting:
                self.ui.scripting.toggle()
            clickedOutput, selectedOutput = imgui.menu_item("Output", "Ctrl+Shift+O", self.ui.output.getConfig("visible"), True)
            if clickedOutput:
                self.ui.output.toggle()
            imgui.end_menu()
        if self.ui.commandPalette.isEnabled():
            commandPaletteEnabled = imcmd.command_palette_window("CommandPalette", True)
            self.ui.commandPalette.setEnabled(commandPaletteEnabled)

    def addShortcuts(self):
        self.ui.shortcuts.addShortcutCtrlShift('k', self.ui.functionBrowser.toggle)
        self.ui.shortcuts.addShortcutCtrlShift('p', self.ui.commandPalette.toggle)
        self.ui.shortcuts.addShortcutCtrlShift('j', self.ui.scripting.toggle)
        self.ui.shortcuts.addShortcutCtrlShift('o', self.ui.output.toggle)
