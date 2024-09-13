from pxzui.ui.widgets.IWidget import IWidget
from pxzui.ui.widgets.base.CoeffWidget import CoeffWidget
from pxzui.ui.widgets.base.TextureWidget import TextureWidget
from imgui_bundle import imgui

class CoeffOrTextureWidget(IWidget):
    def __init__(self, ui, name, defaultValue, readOnly=False):
        self.ui = ui
        self.name = name
        defaultValue = defaultValue.replace(" ", "")
        self.value = defaultValue
        coeffDefault = defaultValue[6:-1] if defaultValue.startswith("COEFF") else "0"
        self.coeffWidget = CoeffWidget(self.ui, name, coeffDefault)
        self.textureWidget = TextureWidget(ui, name, defaultValue if defaultValue.startswith("TEXTURE") else "[[1, 1],[0, 0],0,0]")
        self.readOnly = readOnly

    def draw(self):
        if self.readOnly:
            imgui.begin_disabled()
        # dropdown for coeff / texture
        coeffOrTextureIndex = 1 if self.value.startswith("TEXTURE") else 0
        imgui.set_next_item_width(imgui.get_content_region_avail()[0])
        _, newCoeffOrTextureIndex = imgui.combo("##" + self.name + "coeffTextureCombo", coeffOrTextureIndex, "Coeff\0Texture")
        changed = False
        # widgets for coeff / texture selection
        match newCoeffOrTextureIndex:
            case 0:
                # COEFF
                imgui.set_next_item_width(imgui.get_content_region_avail()[0])
                changed, coeffValue = self.coeffWidget.draw()
                self.value = 'COEFF(' + coeffValue + ')'
            case 1:
                # TEXTURE
                changed, textureValue = self.textureWidget.draw()
                self.value = 'TEXTURE(' + textureValue + ')'
        # We compare the values instead of using the output bool to not switch to default on selecting what is currently selected
        changed = changed or newCoeffOrTextureIndex != coeffOrTextureIndex
        if self.readOnly:
            imgui.end_disabled()
        return changed, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value
