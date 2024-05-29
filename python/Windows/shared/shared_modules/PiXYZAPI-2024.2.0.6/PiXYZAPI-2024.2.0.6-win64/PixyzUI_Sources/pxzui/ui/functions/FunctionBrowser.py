from pxzui.ui.ConfigOwner import ConfigOwner
from pxzui.ui.functions.FunctionForm import FunctionForm
from imgui_bundle import imgui, ImVec2
import pxz

from pxzui.ui.functions.FunctionList import FunctionList
from pxzui.utils.EmVec2 import EmVec2


class FunctionBrowser(ConfigOwner):
    def __init__(self, ui):
        super().__init__()
        self.ui = ui
        self.visible = False
        self.functionList = FunctionList(self.ui, self.activate)
        self.functionForm = FunctionForm(self.ui)
        # for movable splitter
        self.setConfig("functionListWidth", 200)

    def draw(self):
        if self.visible:
            _, self.visible = imgui.begin("Function browser", self.visible)
            # function list
            if imgui.begin_child("FunctionListChild", ImVec2(self.getConfig("functionListWidth"), imgui.get_content_region_avail()[1])):
                self.functionList.draw()
            imgui.end_child()
            imgui.same_line()
            # Movable splitter (https://github.com/ocornut/imgui/issues/125#issuecomment-135775009)
            imgui.invisible_button("vsplitter", EmVec2(x=0.3))
            if imgui.is_item_active():
                self.setConfig("functionListWidth", self.getConfig("functionListWidth") + imgui.get_io().mouse_delta.x)
            if imgui.is_item_hovered():
                imgui.set_mouse_cursor(imgui.MouseCursor_.resize_ew)
            imgui.same_line()
            imgui.begin_child("Function Form")
            # selected function name (can be confusing when collapsing all and self.functionForm is drawing selected)
            if self.functionList.selectedFunction is not None:
                imgui.text(self.functionList.selectedFunction.module + " " + self.functionList.selectedFunction.name)
            # function form
            self.functionForm.draw()
            imgui.end_child()
            imgui.end()

    def activate(self, function):
        self.visible = True
        self.functionForm.initialize(function)

    def toggle(self):
        self.visible = not self.visible
