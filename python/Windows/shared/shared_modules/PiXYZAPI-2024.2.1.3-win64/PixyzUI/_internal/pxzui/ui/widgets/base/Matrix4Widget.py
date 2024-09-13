import numpy as np
from imgui_bundle import imgui
from pxzui.ui.widgets.IWidget import IWidget
from pxzui.utils import MatrixUtils


class Matrix4Widget(IWidget):
    def __init__(self, ui, name, defaultValue, readOnly=False):
        self.ui = ui
        self.name = name
        self.value = defaultValue if defaultValue != "" else str(np.identity(4).tolist())
        self.readOnly = readOnly
        self._hasChanged = True
        self._trans, self._rot, self._scale = np.zeros(3), np.zeros(3), np.ones(3)

    def draw(self):
        if self.readOnly:
            imgui.begin_disabled()
        if imgui.begin_table("##Matrix4WidgetTable" + self.name, 2, imgui.TableFlags_.sizing_stretch_prop):
            imgui.table_next_row()
            imgui.table_next_column()
            isActive = False
            editingFinished = False
            if self._hasChanged:
                self._setFromDecomposedValue()
                self._hasChanged = False
            imgui.text("Translation")
            imgui.table_next_column()
            imgui.set_next_item_width(imgui.get_content_region_avail()[0])
            tChanged, trans = imgui.input_float3("##TranslationInputFloat3", self._trans.tolist())
            self._trans = np.array(trans)
            editingFinished |= imgui.is_item_deactivated_after_edit()
            isActive |= imgui.is_item_active()
            imgui.table_next_row()
            imgui.table_next_column()
            imgui.text("Rotation")
            imgui.table_next_column()
            imgui.set_next_item_width(imgui.get_content_region_avail()[0])
            rChanged, rot = imgui.input_float3("##RotationInputFloat3", np.rad2deg(self._rot).tolist())  # display degree rotation angles
            self._rot = np.deg2rad(np.array(rot))  # convert back to radians
            editingFinished |= imgui.is_item_deactivated_after_edit()
            isActive |= imgui.is_item_active()
            imgui.table_next_row()
            imgui.table_next_column()
            imgui.text("Scale")
            imgui.table_next_column()
            imgui.set_next_item_width(imgui.get_content_region_avail()[0])
            sChanged, scale = imgui.input_float3("##ScaleInputFloat3", self._scale.tolist())
            self._scale = np.array(scale)
            editingFinished |= imgui.is_item_deactivated_after_edit()
            isActive |= imgui.is_item_active()
            imgui.end_table()
            if editingFinished:
                for i in range(0, 3):
                    if 0 <= self._scale[i] < 0.01:
                        self._scale[i] = 0.01
                    if 0 > self._scale[i] > -0.01:
                        self._scale[i] = -0.01
                self.value = str(MatrixUtils.fromTRS(self._trans, self._rot, self._scale).tolist())
            if isActive:
                self.ui.shortcuts.skipBasicThisFrame()
            if self.readOnly:
                imgui.end_disabled()
            return editingFinished, self.value
        if self.readOnly:
            imgui.end_disabled()
        return False, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value
        self._hasChanged = True

    def _setFromDecomposedValue(self):
        matrix = np.array(eval(self.value), dtype=np.float32)
        try:
            self._trans, self._rot, self._scale = MatrixUtils.toTRS(matrix.copy())
        except ValueError:
            # in case of a singularity, we just keep the values as they are and ignore rotation
            self._trans = np.array([matrix[0][3], matrix[1][3], matrix[2][3]])
            self._scale = MatrixUtils.getScale(matrix)


