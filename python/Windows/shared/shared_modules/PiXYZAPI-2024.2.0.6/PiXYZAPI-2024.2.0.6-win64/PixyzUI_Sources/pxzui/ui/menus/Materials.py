
from imgui_bundle import imgui

from pxzui.ui.materials.MaterialBrowser import MaterialBrowser


class Materials:
    def __init__(self, ui):
        self.ui = ui
        self.materialBrowser = ui.materialBrowser

    def draw(self):

        if imgui.begin_menu("Material", True):
            # reset
            clicked_materials, selected_materials = imgui.menu_item("List", '', False, True)
            if clicked_materials:
                self.materialBrowser.open()
            imgui.end_menu()
