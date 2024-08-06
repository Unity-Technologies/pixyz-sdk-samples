from imgui_bundle import imgui
import pxz
from imgui_bundle import portable_file_dialogs


class IO:
    def __init__(self, ui):
        self.ui = ui
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

    def exportFileSync(self, filePath, root=0):
        try:
            pxz.io.exportScene(filePath, root)
        except Exception as e:
            portable_file_dialogs.message("Error", str(e),
                                          _choice=portable_file_dialogs.choice.ok,
                                          _icon=portable_file_dialogs.icon.error)

    def exportFile(self):
        file_path = portable_file_dialogs.save_file("Export file").result()
        if file_path != "":
            self.ui.processQueue.enqueue(self.exportFileSync, file_path)

    def importMostRecentFile(self):
        if len(self.ui.recentFilesList) > 0:
            self.ui.processQueue.enqueue(self.ui.window.importFiles, [self.ui.recentFilesList[0]])

    def addShortcuts(self):
        self.ui.shortcuts.addShortcutCtrl('e', self.exportFile)
        self.ui.shortcuts.addShortcutCtrl('i', self.importFile)
