import pxz
from imgui_bundle import ImVec2
from imgui_bundle import imgui
from imgui_bundle import portable_file_dialogs

from pxzui.utils.EmVec2 import EmVec2


class TextureSelect:
    def __init__(self, ui, doubleClickCallback=None, showNoTextureOption=True):
        self.ui = ui
        self.selectedId = 0
        self.doubleClickCallback = doubleClickCallback
        self.showNoTextureOption = showNoTextureOption

    def draw(self, height=None):
        images = self.ui.textureLibrary.getImageListCopy()
        if self.showNoTextureOption:
            noTextureImageDef = pxz.material.ImageDefinition(0, "No Texture", 0, 0, 0, 0, [])
            images = [{"definition": noTextureImageDef}] + images
        # texture list box
        if height is None:
            height = imgui.get_content_region_avail()[1]
        if imgui.begin_list_box("##TextureSelectListBox", ImVec2(imgui.get_content_region_avail()[0], height)):
            if imgui.button("+", ImVec2(imgui.get_content_region_avail()[0], 0)):
                self.importTexture()
            for texture in images:
                isSelected = texture["definition"].id == self.selectedId
                if "glTextureId" in texture:
                    imgui.image(texture["glTextureId"], EmVec2(4, 4), ImVec2(0, 1), ImVec2(1, 0))
                    imgui.same_line()
                if imgui.selectable("[" + str(texture["definition"].id) + "] " + texture["definition"].name, isSelected, size=EmVec2(0, 4))[1]:
                    self.selectedId = texture["definition"].id
                if imgui.is_item_hovered() and imgui.is_mouse_double_clicked(0) and self.doubleClickCallback is not None:
                    # select texture by double-clicking:
                    self.doubleClickCallback()
                self.drawImageOptionsPopup(texture["definition"].id)
            imgui.end_list_box()

    def importTexture(self):
        file_paths = portable_file_dialogs.open_file("Import texture(s)").result()
        for file_path in file_paths:
            self.ui.processQueue.enqueue(self.ui.window.importImage, file_path)

    def drawImageOptionsPopup(self, id):
        # popup with options for image (currently just export, can be extended)
        if imgui.is_item_clicked(1):
            imgui.open_popup("TextureRightClickPopup" + str(id))
        if imgui.begin_popup("TextureRightClickPopup" + str(id)):
            _, exportClicked = imgui.selectable("Export Image##" + str(id), False)
            if exportClicked:
                filePath = portable_file_dialogs.save_file("Export Image").result()
                if filePath != "":
                    self.ui.processQueue.enqueue(pxz.material.exportImage, id, filePath)
            imgui.end_popup()
