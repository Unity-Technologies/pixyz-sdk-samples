import sys

from imgui_bundle import imgui, imgui_color_text_edit as ed

from pxzui.ui.WindowBase import WindowBase

TextEditor = ed.TextEditor

class Logger(object):
    def __init__(self, path):
        self.path = path
        self.stdout = sys.stdout
        self.stderr = sys.stderr
        self.editor = None
        # clear log file
        open(path, 'w').close()
    def __del__(self):
        sys.stdout = self.stdout
        sys.stderr = self.stderr
    def write(self, data):
        if self.editor:
            text_lines = self.editor.get_text_lines()
            lastLine = len(text_lines) - 1
            lastChar = len(text_lines[lastLine])
            self.editor.set_cursor_position(TextEditor.Coordinates(lastLine, lastChar))
            self.editor.insert_text(data)
        with open(self.path, "a") as f:
            f.write(data)
        if self.stdout:
            self.stdout.write(data)
    def flush(self):
        pass
    def setEditor(self, editor):
        self.editor = editor

class Output(WindowBase):
    def __init__(self, outputFilePath):
        super().__init__()
        self.enable()  # enable Output in default ui
        print("Logging to " + outputFilePath)
        # fork stdout to the output window and the log file
        self.logger = Logger(outputFilePath)
        sys.stdout = self.logger
        sys.stderr = self.logger
        self.editor = None

    def initializeEditor(self):
        self.editor = TextEditor()
        self.editor.set_read_only(True)
        self.editor.set_colorizer_enable(False)
        self.logger.setEditor(self.editor)

    def draw(self):
        if not self.editor:
            self.initializeEditor()
        self.editor.render("Output")
        self.drawPopup()

    def drawPopup(self):
        if imgui.is_item_clicked(1):
            imgui.open_popup("OutputContextMenu")
        if imgui.begin_popup("OutputContextMenu"):
            if imgui.menu_item("Clear", "", False)[0]:
                self.editor.set_text("")
            imgui.end_popup()