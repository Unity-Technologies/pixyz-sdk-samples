from imgui_bundle import imgui
import pxz
from imgui_bundle import portable_file_dialogs


class IO:
    def __init__(self, ui):
        self.ui = ui
        self.export_formats = []
        for format in pxz.io.getExportFormats():
            # this should work according to
            # https://github.com/samhocevar/portable-file-dialogs/blob/main/doc/save_file.md
            # but for some reason just doesn't
            #self.export_formats.append(format.name)
            self.export_formats = self.export_formats + format.extensions
        self.addShortcuts()

    def draw(self):
        if imgui.begin_menu("IO", True):
            # import
            clicked_import, selected_import = imgui.menu_item("Import", 'Ctrl+I', False, True)
            if clicked_import:
                self.importFile()
            # export
            clicked_export, selected_export = imgui.menu_item("Export", 'Ctrl+E', False, True)
            if clicked_export:
                self.exportFile()
            imgui.separator()
            # recent files
            for index, path in enumerate(self.ui.recentFilesList):
                clicked_path, _ = imgui.menu_item(path, "", False, True)
                if clicked_path:
                    self.ui.processQueue.enqueue(self.ui.window.importFiles, [path])
            imgui.end_menu()

    def importFile(self):
        file_paths = portable_file_dialogs.open_file("Import file(s)").result()
        if len(file_paths) > 0:
            self.ui.processQueue.enqueue(self.ui.window.importFiles, file_paths)

    def exportFile(self):
        file_path = portable_file_dialogs.save_file("Export file", filters=self.export_formats).result()
        if file_path != "":
            # ugly extension check as file browser is not behaving as expected (see above)
            if not file_path.endswith(tuple([x[1:] for x in self.export_formats])):
                portable_file_dialogs.message("Error", "Please enter the file extension manually.",
                                              _choice=portable_file_dialogs.choice.ok,
                                              _icon=portable_file_dialogs.icon.error)
            else:
                self.ui.processQueue.enqueue(pxz.io.exportScene, file_path, 0)

    def importMostRecentFile(self):
        if len(self.ui.recentFilesList) > 0:
            self.ui.processQueue.enqueue(self.ui.window.importFiles, [self.ui.recentFilesList[0]])

    def addShortcuts(self):
        self.ui.shortcuts.addShortcutCtrl('e', self.exportFile)
        self.ui.shortcuts.addShortcutCtrl('i', self.importFile)
