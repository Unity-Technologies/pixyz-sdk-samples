import sys

from pxz_utils.init import debugger_is_active
from pxzui.ui.ConfigOwner import ConfigOwner
from imgui_bundle import imgui, imgui_color_text_edit as ed

TextEditor = ed.TextEditor

class Logger(object):
    def __init__(self, path, editor):
        self.path = path
        self.stdout = sys.stdout
        self.editor = editor
        # clear log file
        open(path, 'w').close()
    def __del__(self):
        sys.stdout = self.stdout
    def write(self, data):
        text_lines = self.editor.get_text_lines()
        lastLine = len(text_lines) - 1
        lastChar = len(text_lines[lastLine])
        self.editor.set_cursor_position(TextEditor.Coordinates(lastLine, lastChar))
        self.editor.insert_text(data)
        with open(self.path, "a") as f:
            f.write(data)
        if debugger_is_active():
            self.stdout.write(data)
    def flush(self):
        pass

class Output(ConfigOwner):
    def __init__(self, ui, outputFilePath):
        super().__init__()
        self.ui = ui
        self.editor = TextEditor()
        self.editor.set_read_only(True)
        self.editor.set_colorizer_enable(False)
        print("Logging to " + outputFilePath)
        # fork stdout to the output window and the log file
        sys.stdout = Logger(outputFilePath, self.editor)

    def draw(self):
        if self.getConfig("visible"):
            _, visible = imgui.begin("Output", self.getConfig("visible"))
            self.setConfig("visible", visible)
            self.editor.render("Output")
            self.drawPopup()
            imgui.end()

    def drawPopup(self):
        if imgui.is_item_clicked(1):
            imgui.open_popup("OutputContextMenu")
        if imgui.begin_popup("OutputContextMenu"):
            if imgui.menu_item("Clear", "", False)[0]:
                self.editor.set_text("")
            imgui.end_popup()

    def toggle(self):
        self.setConfig("visible", not self.getConfig("visible"))
