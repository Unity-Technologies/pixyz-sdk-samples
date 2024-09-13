from pxzui.ui.widgets.IWidget import IWidget
from pxzui.ui.widgets.base.ColorWidget import ColorWidget
from imgui_bundle import imgui

from pxzui.ui.widgets.base.TextureWidget import TextureWidget


class ColorOrTextureWidget(IWidget):
    def __init__(self, ui, name, defaultValue, readOnly=False):
        self.ui = ui
        self.name = name
        defaultValue = defaultValue.replace(" ", "")
        self.value = defaultValue
        colorDefault = defaultValue[6:-1] if defaultValue.startswith("COLOR") else "[0, 0, 0]"
        self.colorWidget = ColorWidget(name, colorDefault)
        self.textureWidget = TextureWidget(ui, name, defaultValue if defaultValue.startswith("TEXTURE") else "[[1, 1],[0, 0],0,0]")
        self.readOnly = readOnly

    def draw(self):
        if self.readOnly:
            imgui.begin_disabled()
        # dropdown for color / texture
        colorOrTextureIndex = 1 if self.value.startswith("TEXTURE") else 0
        imgui.set_next_item_width(imgui.get_content_region_avail()[0])
        _, newColorOrTextureIndex = imgui.combo("##" + self.name + "colorTextureCombo", colorOrTextureIndex, "Color\0Texture")
        changed = False
        # widgets for color / texture selection
        match newColorOrTextureIndex:
            case 0:
                # COLOR
                imgui.set_next_item_width(imgui.get_content_region_avail()[0])
                changed, colorValue = self.colorWidget.draw()  # value[1] is just the color
                self.value = 'COLOR(' + colorValue + ')'
            case 1:
                # TEXTURE
                changed, textureValue = self.textureWidget.draw()
                self.value = 'TEXTURE(' + textureValue + ')'
        # We compare the values instead of using the output bool to not switch to default on selecting what is currently selected
        changed = changed or newColorOrTextureIndex != colorOrTextureIndex
        if self.readOnly:
            imgui.end_disabled()
        return changed, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value
