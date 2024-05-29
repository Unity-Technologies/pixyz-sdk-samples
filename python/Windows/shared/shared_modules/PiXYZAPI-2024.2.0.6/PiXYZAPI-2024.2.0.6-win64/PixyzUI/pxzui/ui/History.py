from imgui_bundle import imgui
import pxz

from pxzui.ui.WindowBase import WindowBase

class History(WindowBase):
    def __init__(self, ui):
        super().__init__()
        self.ui = ui
        self.undoStack = self.redoStack = []
        pxz.core.addUndoRedoStackChangedCallback(lambda self : self.updateStack(), self)

    def draw(self):
        imgui.push_style_color(imgui.Col_.text, imgui.ImVec4(0.5,0.5,0.5,1.))
        index = 0
        for step in self.redoStack:
            imgui.selectable(step, False)
            index += 1
            if imgui.is_item_hovered() and imgui.is_mouse_double_clicked(0):
                self.redo(len(self.redoStack) - index + 1)
        imgui.pop_style_color()
        index = 0
        for step in self.undoStack:
            imgui.selectable(step, False)
            index += 1
            if index > 1 and imgui.is_item_hovered() and imgui.is_mouse_double_clicked(0):
                self.undo(index - 1)
        index += 1
        imgui.selectable("<Empty>", False)
        if index > 1 and imgui.is_item_hovered() and imgui.is_mouse_double_clicked(0):
            self.undo(index - 1)


    def undo(self, count):
        self.ui.processQueue.enqueue(pxz.core.undo, count)

    def redo(self, count):
        self.ui.processQueue.enqueue(pxz.core.redo, count)

    def updateStack(self):
        self.redoStack = pxz.core.getRedoStack()
        self.undoStack = pxz.core.getUndoStack()
        self.redoStack.reverse()
