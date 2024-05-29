from imgui_bundle import imgui, ImVec2
from pxzui.ui.functions.FunctionForm import FunctionForm
import pxz

from pxzui.utils.EmVec2 import EmVec2


class FunctionDialog:
    def __init__(self, ui):
        self.ui = ui
        self.function = None
        self.visible = False
        self.functionForm = FunctionForm(self.ui)
        # we check if enter has been released to not fire directly after opening the dialog from the command palette
        self.enterReleased = False

    def open(self, function):
        self.function = function
        self.functionForm.initialize(function)
        self.visible = True
        self.enterReleased = False

    def draw(self):
        # adding min width to avoid crunching big widgets (e.g. matrix4)
        imgui.push_style_var(imgui.StyleVar_.window_min_size, EmVec2(23, 0))
        if self.visible:
            windowFlags = imgui.WindowFlags_.no_resize | imgui.WindowFlags_.no_collapse | imgui.WindowFlags_.no_docking
            _, self.visible = imgui.begin(self.function.name, self.visible, windowFlags)
            self.functionForm.draw()
            self.shortcuts()
            imgui.end()
        imgui.pop_style_var()

    def close(self):
        self.visible = False
        self.function = None
        self.functionForm = FunctionForm(self.ui)

    def shortcuts(self):
        if imgui.is_key_released(imgui.Key.enter):
            self.enterReleased = True
        if imgui.is_key_pressed(imgui.Key.escape) and imgui.is_window_focused():
            self.close()
        if imgui.is_key_pressed(imgui.Key.enter) and self.enterReleased and imgui.is_window_focused():
            self.functionForm.run()
            self.close()
