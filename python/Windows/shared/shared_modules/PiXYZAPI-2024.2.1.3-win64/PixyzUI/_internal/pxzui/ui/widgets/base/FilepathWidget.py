from imgui_bundle import imgui, ImVec2
from imgui_bundle import portable_file_dialogs
from pxzui.ui.widgets.IWidget import IWidget


class FilepathWidget(IWidget):
    def __init__(self, ui, name, defaultValue, readonly=False, directory=False):
        self.ui = ui
        self.name = name
        self.value = defaultValue
        self.directory = directory
        self.dialog = None
        self.readonly = readonly

    def draw(self):
        if self.readonly:
            imgui.begin_disabled()
        changed = False
        # table align text field and button w/ robustness if imgui.set_next_item_width was called before
        if imgui.begin_table("FilePathWidgetTable" + self.name, 2):
            imgui.table_setup_column("##path text field column")
            imgui.table_setup_column("##path browse button column", flags=imgui.TableColumnFlags_.width_fixed)
            imgui.table_next_row()
            imgui.table_set_column_index(0)
            imgui.set_next_item_width(imgui.get_content_region_avail()[0])
            changed, value = imgui.input_text("", self.value, 1024)
            if imgui.is_item_active():
                # don't fire shortcuts when typing in the text field
                self.ui.shortcuts.skipBasicThisFrame()
            imgui.table_set_column_index(1)
            if imgui.button("Browse"):
                if self.directory:
                    self.dialog = portable_file_dialogs.select_folder("Select folder")
                else:
                    self.dialog = portable_file_dialogs.open_file("Select file")
            imgui.end_table()
        if self.dialog and self.dialog.ready():
            result = self.dialog.result()
            if result:
                changed = True
                if self.directory:
                    self.value = self.dialog.result().replace('\\', '/')
                else:
                    self.value = self.dialog.result()[0].replace('\\', '/')
                self.dialog = None
        if self.readonly:
            imgui.end_disabled()
        return changed, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value
