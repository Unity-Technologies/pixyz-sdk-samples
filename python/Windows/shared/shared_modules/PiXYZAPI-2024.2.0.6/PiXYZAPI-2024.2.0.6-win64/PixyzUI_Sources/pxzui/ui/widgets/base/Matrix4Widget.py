import math

import numpy as np
from imgui_bundle import imgui
from pxzui.ui.widgets.IWidget import IWidget
from pxzui.utils import MatrixUtils


class Matrix4Widget(IWidget):
    def __init__(self, name, defaultValue):
        self.name = name
        self.value = defaultValue if defaultValue != "" else str(np.identity(4).tolist())

    def draw(self):
        if imgui.begin_table("##Matrix4WidgetTable" + self.name, 2, imgui.TableFlags_.sizing_stretch_prop):
            imgui.table_next_row()
            imgui.table_next_column()
            editingFinished = False
            trans, rot, scale = MatrixUtils.toTRS(np.array(eval(self.value), dtype=np.float32))
            imgui.text("Translation")
            imgui.table_next_column()
            imgui.set_next_item_width(imgui.get_content_region_avail()[0])
            trans = imgui.input_float3("##TranslationInputFloat3", trans)
            editingFinished |= imgui.is_item_deactivated_after_edit()
            imgui.table_next_row()
            imgui.table_next_column()
            imgui.text("Rotation")
            imgui.table_next_column()
            imgui.set_next_item_width(imgui.get_content_region_avail()[0])
            rot = imgui.input_float3("##RotationInputFloat3", rot * (180. / math.pi))  # display degree rotation angles
            editingFinished |= imgui.is_item_deactivated_after_edit()
            imgui.table_next_row()
            imgui.table_next_column()
            imgui.text("Scale")
            imgui.table_next_column()
            imgui.set_next_item_width(imgui.get_content_region_avail()[0])
            scale = imgui.input_float3("##ScaleInputFloat3", scale)
            editingFinished |= imgui.is_item_deactivated_after_edit()
            imgui.end_table()
            # we don't want to update the value if the user is still editing the matrix
            # edited = (trans[0] or rot[0] or scale[0])
            if editingFinished:
                if any(v == 0 for v in scale[1]):
                    print("Scale cannot be 0!")
                else:
                    self.value = str(MatrixUtils.fromTRS(trans[1], np.array(rot[1]) / (180. / math.pi), scale[1]).tolist())
            return editingFinished, self.value
        return False, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value

