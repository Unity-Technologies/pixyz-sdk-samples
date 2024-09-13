import threading
from imgui_bundle import imgui
import pxz
from imgui_bundle import imgui
from pxzui.viewer.Viewer import *
from imgui_bundle import portable_file_dialogs

class Session:
    def __init__(self, ui):
        self.ui = ui
        self.undoPossible = False
        self.redoPossible = False
        self.ui.window.callback_manager.addUndoRedoStackChangedCallback(self.whenUndoRedoStackChanged)
        self.addShortcuts()

    def __del__(self):
        self.ui.window.callback_manager.removeUndoRedoStackChangedCallback(self.whenUndoRedoStackChanged)

    def draw(self):
        if imgui.begin_menu("Session", True):
            # reset
            clicked_reset, selected_reset = imgui.menu_item("Reset", 'Ctrl+N', False, True)
            if clicked_reset:
                self.reset()

            imgui.separator()

            undoEnabled = self.undoPossible
            if not undoEnabled:
                imgui.begin_disabled()
            clicked_undo, _ = imgui.menu_item("Undo", 'Ctrl+Z', False, True)
            if clicked_undo:
                self.undo()
            if not undoEnabled:
                imgui.end_disabled()

            redoEnabled = self.redoPossible
            if not redoEnabled:
                imgui.begin_disabled()
            clicked_redo, _ = imgui.menu_item("Redo", 'Ctrl+Y', False, True)
            if clicked_redo:
                self.redo()
            if not redoEnabled:
                imgui.end_disabled()

            imgui.separator()

            # load
            clicked_load, selected_load = imgui.menu_item("Load", "Ctrl+L", False, True)
            if clicked_load:
                self.load()
            # save
            clicked_save, selected_save = imgui.menu_item("Save", "Ctrl+S", False, True)
            if clicked_save:
                self.save()
            imgui.separator()

            # close
            clicked_close, selected_close = imgui.menu_item("Close", '', False, True)
            if clicked_close:
                self.ui.window.onClose()
                exit()
            imgui.end_menu()

    def whenUndoRedoStackChanged(self):
        self.undoPossible = len(pxz.core.getUndoStack()) > 0
        self.redoPossible = len(pxz.core.getRedoStack()) > 0

    def undo(self):
        if not self.undoPossible: return
        #self.ui.processQueue.enqueue(pxz.core.undo)
        self.ui.processQueue.wait()
        pxz.core.undo()

    def redo(self):
        if not self.redoPossible: return
        #self.ui.processQueue.enqueue(pxz.core.redo)
        self.ui.processQueue.wait()
        pxz.core.redo()

    def reset(self):
        self.ui.processQueue.enqueue(pxz.core.resetSession)

    def save(self):
        file_path = portable_file_dialogs.save_file("Save file").result()
        if file_path != "":
            self.ui.processQueue.enqueue(pxz.core.save, file_path)

    def load(self):
        file_paths = portable_file_dialogs.open_file("Select file").result()
        if file_paths and file_paths[0] != "":
            if not file_paths[0].endswith(".pxz"):
                print("Error: Use IO/Import for non .pxz files")
                return
            self.ui.processQueue.enqueue(pxz.core.load, file_paths[0])

    def addShortcuts(self):
        self.ui.shortcuts.addShortcutCtrl('n', self.reset)
        self.ui.shortcuts.addShortcutCtrl('s', self.save)
        self.ui.shortcuts.addShortcutCtrl('l', self.load)
        self.ui.shortcuts.addShortcutCtrl('z', self.undo)
        self.ui.shortcuts.addShortcutCtrl('y', self.redo)
