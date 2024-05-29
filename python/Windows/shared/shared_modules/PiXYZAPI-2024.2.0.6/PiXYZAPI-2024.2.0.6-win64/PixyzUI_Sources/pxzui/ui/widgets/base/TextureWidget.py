from imgui_bundle import imgui, ImVec2

from pxzui.ui.materials.TextureSelect import TextureSelect
from pxzui.ui.widgets.IWidget import IWidget
from pxzui.ui.widgets.Utility import Utility
from pxzui.utils.EmVec2 import EmVec2


class TextureWidget(IWidget):
    def __init__(self, ui, name, defaultValue=""):
        self.ui = ui
        self.name = name
        # the default for widgets is "" so we keep the convention and just replace it with a custom default
        # instead of saying defaultValue="[[1, 1],[0, 0],0,0]" in the constructor
        self.value = defaultValue if defaultValue != "" else "[[1, 1],[0, 0],0,0]"
        self.textureSelect = TextureSelect(self.ui, doubleClickCallback=self.textureSelectDoubleClickCallback)
        self.textureHasBeenSelected = False
        self.textureSelectPropertyName = ""

    def draw(self):
        imageId, tiling, offset, channel = self.parseTextureString(self.value)
        if imageId == 0:
            # No texture defined yet
            imgui.button("Select Texture##" + self.name, ImVec2(imgui.get_content_region_avail()[0], 0))
        else:
            glId = self.ui.textureLibrary.getGlId(imageId)
            if glId is not None:
                imgui.image(glId, EmVec2(5, 5), ImVec2(0, 1), ImVec2(1, 0))
            else:
                # Texture is not loaded yet
                imgui.button("Select Texture##" + self.name)
        # open texture select to change texture
        if imgui.is_item_clicked():
            self.textureSelectPropertyName = self.name
            imgui.open_popup("MaterialFormModalTextureSelect" + self.name)
            # select current texture in texture select
            if self.textureSelect.selectedId != imageId and imageId != 0:
                self.textureSelect.selectedId = imageId
        imgui.set_next_window_size_constraints(EmVec2(20, 30), EmVec2(30, 40))
        if imgui.begin_popup("MaterialFormModalTextureSelect" + self.name):
            self.textureSelect.draw()
            imgui.end_popup()
        anyChanges = self.textureHasBeenSelected
        # Texture was changed in popup:
        if self.textureHasBeenSelected:
            imageId = self.textureSelect.selectedId
            self.textureHasBeenSelected = False
        imgui.same_line()
        # no texture texture still not defined
        if imageId == 0:
            self.value = self.setTextureString(imageId, tiling, offset, channel)
            return [anyChanges, self.value]
        # name, tiling and offset (makes only sense if texture is defined)
        imgui.set_next_item_width(imgui.get_content_region_avail()[0])
        imgui.begin_group()
        imageName = self.ui.textureLibrary.getName(imageId)
        if imageName is not None:
            imgui.text("[" + str(imageId) + "] " + imageName)
        if imgui.begin_table("##TilingOffsetChannelTable", 2):
            imgui.table_setup_column("##TilingOffsetChannelTableColumn1", imgui.TableColumnFlags_.width_stretch, 150)
            imgui.table_setup_column("##TilingOffsetChannelTableColumn1", imgui.TableColumnFlags_.width_fixed, 100)
            imgui.table_next_row()
            imgui.table_next_column()
            imgui.set_next_item_width(imgui.get_content_region_avail()[0])
            tilingChanged, newTiling = imgui.input_float2("##TilingInput" + self.name, tiling)
            imgui.table_next_column()
            imgui.text("Tiling")
            imgui.table_next_row()
            imgui.table_next_column()
            imgui.set_next_item_width(imgui.get_content_region_avail()[0])
            offsetChanged, newOffset = imgui.input_float2("##OffsetInput" + self.name, offset)
            imgui.table_next_column()
            imgui.text("Offset")
            imgui.table_next_row()
            imgui.table_next_column()
            imgui.set_next_item_width(imgui.get_content_region_avail()[0])
            channelChanged, newChannel = imgui.input_int("##ChannelInput" + self.name, channel)
            imgui.table_next_column()
            imgui.text("Channel")
            # formatting all the new values to the correct string
            anyChanges = anyChanges or tilingChanged or offsetChanged or channelChanged
            self.value = self.setTextureString(imageId, newTiling, newOffset, newChannel)
            imgui.end_table()
        imgui.end_group()
        return [anyChanges, self.value]

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value

    def setTextureString(self, textureId, tiling, offset, channel):
        # e.g. '[[1, 1],[0, 0],11,0]'
        result = "["
        result += str(tiling) + ","
        result += str(offset) + ","
        result += str(textureId) + ","
        result += str(channel) + "]"
        return result

    def parseTextureString(self, textureString):
        tiling = Utility.parseFloatList("[" + textureString.split('[')[2].split(']')[0] + "]")
        offset = Utility.parseFloatList("[" + textureString.split('[')[3].split(']')[0] + "]")
        imageId = int(textureString.split(',')[4])
        channel = int(textureString.split(',')[-1].split(']')[0])
        return imageId, tiling, offset, channel

    def textureSelectDoubleClickCallback(self):
        self.textureHasBeenSelected = True
        imgui.close_current_popup()
