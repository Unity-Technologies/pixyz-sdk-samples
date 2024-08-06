from imgui_bundle import imgui, ImVec2

from pxzui.ui.WindowBase import WindowBase
from pxzui.ui.materials.MaterialList import MaterialList
from pxzui.ui.materials.MaterialForm import MaterialForm
from pxzui.utils.EmVec2 import EmVec2


class MaterialBrowser(WindowBase):
    def __init__(self, ui):
        super().__init__()
        self.ui = ui
        self.materialList = MaterialList(self.ui)
        self.materialForm = MaterialForm(self.ui, preview=True)
        # configs that will be saved
        self.setConfig("listBoxWidth", 300)

    def draw(self):
        selectionChanged = False
        # material list
        if imgui.begin_child("##MaterialList", ImVec2(self.getConfig("listBoxWidth"), imgui.get_content_region_avail()[1])):
            selectionChanged, _ = self.materialList.draw()
        imgui.end_child()
        # Movable splitter (https://github.com/ocornut/imgui/issues/125#issuecomment-135775009)
        imgui.same_line()
        imgui.invisible_button("vsplitter", EmVec2(x=0.3))
        if imgui.is_item_active():
            self.setConfig("listBoxWidth", self.getConfig("listBoxWidth") + imgui.get_io().mouse_delta.x)
        if imgui.is_item_hovered():
            imgui.set_mouse_cursor(imgui.MouseCursor_.resize_ew)
        imgui.same_line()
        # material form
        if selectionChanged:
            self.materialForm.update(self.materialList.getSelectedMaterial())
        imgui.begin_child("Material Form")
        self.materialForm.draw()
        imgui.end_child()

