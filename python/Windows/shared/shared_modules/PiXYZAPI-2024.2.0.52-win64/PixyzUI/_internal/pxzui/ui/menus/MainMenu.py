from imgui_bundle import ImVec2

from pxzui.ui.menus.Create import Create
from pxzui.ui.menus.CustomMenu import CustomMenus
from pxzui.ui.menus.IO import *
from pxzui.ui.menus.Session import *
from pxzui.ui.menus.PythonApi import *
from pxzui.ui.menus.Scene import *
from pxzui.ui.menus.UI import *

class MainMenu:
    def __init__(self, ui):
        self.ui = ui
        self.session = Session(ui)
        self.IO = IO(ui)
        self.create = Create(ui)
        self.scene = Scene(ui)
        self.pythonApi = PythonApi(ui)
        self.windows = ui.windows
        self.uiMenu = UI(ui)
        self.customMenus = CustomMenus(ui)

    def draw(self):
        cursorPos = imgui.get_cursor_pos()
        if imgui.begin_main_menu_bar():
            # popup for custom menus on right click
            # workaround to get main menu bar rect, as imgui.is_item_clicked() shows no effect
            menuBarRect = [cursorPos[0], imgui.get_cursor_pos_y(),
                           cursorPos[0] + imgui.get_window_width(), cursorPos[1]]
            if imgui.is_mouse_clicked(1) and imgui.is_mouse_hovering_rect(ImVec2(menuBarRect[0], menuBarRect[1]),
                                                                          ImVec2(menuBarRect[2], menuBarRect[3])):
                imgui.open_popup("CustomMenuPopup")
            if imgui.begin_popup("CustomMenuPopup"):
                self.customMenus.drawInPopup()
                imgui.end_popup()
            # menus
            self.session.draw()
            self.IO.draw()
            self.create.draw()
            self.scene.draw()
            self.pythonApi.draw()
            self.windows.draw()
            self.uiMenu.draw()
            self.customMenus.draw()
            imgui.set_cursor_pos_x(imgui.get_window_width() - imgui.calc_text_size("PowerSaving")[0] - imgui.get_frame_height_with_spacing())
            changed, self.ui.window.powerSaving = imgui.checkbox("PowerSaving", self.ui.window.powerSaving)
            imgui.end_main_menu_bar()

