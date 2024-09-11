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
                        imgui.get_style().alpha = self.ui.opacity
                imgui.end_menu()
            if imgui.begin_menu("Opacity"):
                opacityChanged, opacityValue = imgui.drag_float("Opacity", self.ui.opacity, v_speed=0.01,
                                                                            v_min=0.2, v_max=1.)
                if opacityChanged:
                    self.ui.opacity = opacityValue
                    imgui.get_style().alpha = opacityValue
                imgui.end_menu()
            imgui.end_menu()

