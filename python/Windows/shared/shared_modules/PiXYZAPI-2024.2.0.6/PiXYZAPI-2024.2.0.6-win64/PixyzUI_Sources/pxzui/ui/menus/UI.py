from imgui_bundle import imgui
from imgui_bundle import hello_imgui

class UI:
    def __init__(self, ui):
        self.ui = ui

    def draw(self):
        if imgui.begin_menu("UI", True):
            if imgui.menu_item("Hide", "F2", False)[0]:
                self.ui.window.drawUI = False
            imgui.separator()
            if imgui.begin_menu("Theme"):
                for theme in range(hello_imgui.ImGuiTheme_.count):
                    if imgui.menu_item(hello_imgui.imgui_theme_name(hello_imgui.ImGuiTheme_(theme)), "", theme == self.ui.theme)[0]:
                        self.ui.theme = hello_imgui.ImGuiTheme_(theme)
                        hello_imgui.apply_theme(self.ui.theme)
                imgui.end_menu()
            imgui.end_menu()
