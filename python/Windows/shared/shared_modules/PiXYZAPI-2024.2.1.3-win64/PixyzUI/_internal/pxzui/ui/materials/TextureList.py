import pxz
from imgui_bundle import imgui, ImVec2

from pxzui.ui.WindowBase import WindowBase
from pxzui.ui.materials.TextureSelect import TextureSelect
from pxzui.utils.EmVec2 import EmVec2


class TextureList(WindowBase):
    def __init__(self, ui):
        super().__init__()
        self.ui = ui
        self.textureSelect = TextureSelect(self.ui, showNoTextureOption=False)
        # configs that will be saved
        self.setConfig("listBoxWidth", 300)

    def draw(self):
        if imgui.begin_child("##TextureList",
                             ImVec2(self.getConfig("listBoxWidth"), imgui.get_content_region_avail()[1])):
            # fill with TextureSelect, but leave space for the delete button below
            textureSelectHeight = (imgui.get_content_region_avail()[1]
                                   - imgui.get_frame_height()
                                   - imgui.get_style().item_spacing.y)
            self.textureSelect.draw(textureSelectHeight)
            if imgui.button("Delete", ImVec2(imgui.get_content_region_avail()[0], 0)) and self.textureSelect.selectedId is not None:
                self.ui.processQueue.enqueue(pxz.core.deleteEntities, [self.textureSelect.selectedId])
        imgui.end_child()
        # Movable splitter (https://github.com/ocornut/imgui/issues/125#issuecomment-135775009)
        imgui.same_line()
        imgui.invisible_button("vsplitter", EmVec2(x=0.3))
        if imgui.is_item_active():
            self.setConfig("listBoxWidth", self.getConfig("listBoxWidth") + imgui.get_io().mouse_delta.x)
        if imgui.is_item_hovered():
            imgui.set_mouse_cursor(imgui.MouseCursor_.resize_ew)
        imgui.same_line()
        # big preview
        if not self.ui.textureLibrary.isEmpty() and self.textureSelect.selectedId is not None and self.textureSelect.selectedId != 0:
            # square preview that scales with window size
            imgWidth = imgui.get_content_region_avail()[0]
            glId = self.ui.textureLibrary.getGlId(self.textureSelect.selectedId)
            if glId is not None:
                imgui.image(glId, ImVec2(imgWidth, imgWidth), ImVec2(0, 1), ImVec2(1, 0))
