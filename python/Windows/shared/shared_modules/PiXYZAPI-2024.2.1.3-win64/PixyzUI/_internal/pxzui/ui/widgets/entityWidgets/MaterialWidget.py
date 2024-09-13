import pxz
from imgui_bundle import imgui, ImVec2

from pxzui.ui.materials.MaterialForm import MaterialForm
from pxzui.ui.materials.MaterialList import MaterialList
from pxzui.ui.widgets.IWidget import IWidget
from pxzui.utils.EmVec2 import EmVec2


class MaterialWidget(IWidget):
    def __init__(self, ui, name, defaultValue, selectable=True, readOnly=False):
        self.ui = ui
        self.name = name
        self.value = defaultValue if defaultValue != "" else "0"
        self.materialList = MaterialList(self.ui)
        self.materialForm = MaterialForm(self.ui, int(self.value) if self.value != "0" else None)
        self.selectable = selectable
        self.readOnly = readOnly

    def draw(self):
        if self.readOnly:
            imgui.begin_disabled()
        changed = False
        imgui.text("[" + self.value + "] " + self.name)
        if imgui.begin_table("##MaterialWidgetTable", 2):
            imgui.table_next_row()
            imgui.table_next_column()
            # material list on select button
            if not self.selectable:
                imgui.begin_disabled()
            if imgui.button("Select", ImVec2(imgui.get_content_region_avail()[0], 0)):
                imgui.open_popup("SelectMaterialFromWidget")
            if imgui.begin_popup("SelectMaterialFromWidget"):
                materialChanged, selectedMaterial = self.materialList.draw()
                if materialChanged:
                    self.value = str(selectedMaterial)
                    self.materialForm.update(int(self.value))
                    changed = True
                imgui.end_popup()
            if not self.selectable:
                imgui.end_disabled()
            # material form on edit button
            imgui.table_next_column()
            if self.value == "0":
                imgui.begin_disabled()
            if imgui.button("Edit", ImVec2(imgui.get_content_region_avail()[0], 0)):
                imgui.open_popup("EditMaterialFromWidget")
            if self.value == "0":
                imgui.end_disabled()
            if imgui.begin_popup("EditMaterialFromWidget"):
                # "min width"
                imgui.dummy(EmVec2(20, 0))
                self.materialForm.draw()
                imgui.end_popup()
            imgui.end_table()
        if self.readOnly:
            imgui.end_disabled()
        return changed, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value
        self.materialForm.update(int(self.value) if pxz.core.entityExists(int(self.value)) else None)
