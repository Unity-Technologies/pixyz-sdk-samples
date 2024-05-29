import pxz

from pxzui.ui.widgets.IWidget import IWidget
from imgui_bundle import imgui

from pxzui.ui.widgets.Utility import Utility


class ArrayWidget(IWidget):
    def __init__(self, ui, typeObj, name, defaultValue):
        self.name = name
        self.size = typeObj.definition[1].size
        self.cells = {}
        # for some reason we need to do this twice, the typeObj does not yet contain the cell type
        arrayType = pxz.core.getType(typeObj.module, typeObj.definition[1].arrayType)
        cellType = pxz.core.getType(typeObj.module, arrayType.definition[1].arrayType)
        # create widget array
        for row in range(self.size):
            self.cells[row] = {}
            for column in range(self.size):
                self.cells[row][column] = Utility.createFunctionParameterWidget(ui, cellType, self.name + "[" + str(row) + "," + str(column) + "]")
        # initializing default values if simple matrix
        if defaultValue.startswith("geom.IdentityMatrix"):
            for row in range(self.size):
                for column in range(self.size):
                    self.cells[row][column].value = '1' if row == column else '0'

    def draw(self):
        anyChanges = False
        self.value = '['
        if imgui.begin_table(self.name, self.size):
            for row in range(self.size):
                imgui.table_next_row()
                self.value += '['
                for column in range(self.size):
                    imgui.table_next_column()
                    # Forcing full width for all cells: This might cause some problems if arraywidget is used for
                    # non-matrix arrays, but that is currently not the case.
                    imgui.set_next_item_width(imgui.get_content_region_avail()[0])
                    cellChanged, cellValue = self.cells[row][column].draw()
                    anyChanges |= cellChanged
                    self.value += cellValue
                    if column+1 < self.size: self.value += ','
                self.value += ']'
                if row+1 < self.size: self.value += ','
            self.value += ']'
            imgui.end_table()
        return anyChanges, self.value

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value
