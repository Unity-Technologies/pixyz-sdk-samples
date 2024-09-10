import threading

import pxz

from pxzui.ui.widgets.IWidget import IWidget
from imgui_bundle import imgui, ImVec2

from pxzui.ui.widgets.Utility import Utility


class ListWidget(IWidget):
    minusButtonSize = 50

    def __init__(self, ui, typeObj, name, defaultValue, readonly=False):
        self.ui = ui
        self._lock = threading.Lock()
        self.cellType = pxz.core.getType(typeObj.module, typeObj.definition[1].listType)
        self.name = name
        self.readonly = readonly
        self.cells = []
        self.currentCellId = -1
        if defaultValue != "":
            self.setValue(defaultValue)
        else:
            self.value = ""

    def draw(self):
        if self.readonly:
            imgui.begin_disabled()
        cellsToDelete = []
        anyChanges = False
        newValue = '['
        if imgui.button("+##" + self.name, ImVec2(imgui.get_content_region_avail()[0], 0)):
            self.addCell()
        imgui.set_item_tooltip("Add " + self.cellType.name)
        # drawing listbox
        if imgui.begin_list_box("##" + self.name + "ListBox", ImVec2(imgui.get_content_region_avail()[0], 0)):
            with self._lock:
                for cellIndex in range(len(self.cells)):
                    # table containing the cell and a delete button
                    if imgui.begin_table("##" + self.name + "CellTable" + str(cellIndex), 2):
                        imgui.table_setup_column("##" + self.name + "CellTableFieldValue" + str(cellIndex))
                        imgui.table_setup_column("##" + self.name + "CellTableFieldDeleteButton" + str(cellIndex), flags=imgui.TableColumnFlags_.width_fixed, init_width_or_weight=self.minusButtonSize)
                        imgui.table_next_row()
                        imgui.table_set_column_index(0)
                        imgui.set_next_item_width(imgui.get_content_region_avail()[0])
                        cellChanged, cellValue = self.cells[cellIndex].draw()
                        buttonHeight = imgui.get_item_rect_size()[1]
                        anyChanges |= cellChanged
                        newValue += cellValue
                        if cellIndex + 1 < len(self.cells): newValue += ','
                        imgui.table_set_column_index(1)
                        if imgui.button("-##" + str(cellIndex), ImVec2(self.minusButtonSize, buttonHeight)):
                            cellsToDelete.append(self.cells[cellIndex])
                        imgui.set_item_tooltip("Delete " + self.cellType.name)
                        imgui.end_table()
            imgui.end_list_box()
        newValue += ']'
        self.value = newValue
        # deleting cells here to not do it while iterating
        for cell in cellsToDelete:
            self.removeCell(cell)
        if self.readonly:
            imgui.end_disabled()
        return anyChanges, self.value

    def addCell(self, defaultValue=""):
        with self._lock:
            # this counter only goes up to give unique IDs for new cells
            self.currentCellId += 1
            self.cells.append(Utility.createFunctionParameterWidget(self.ui, self.cellType, self.name + str(self.currentCellId), defaultValue))

    def removeCell(self, cell):
        with self._lock:
            cell.destroy()
            self.cells.remove(cell)

    def getValue(self):
        with self._lock:
            return self.value

    def setValue(self, v):
        with self._lock:
            self.value = v
            # delete current cells
            for cell in self.cells:
                cell.destroy()
            self.cells = []
            # assign new values from passed string
            valuesAsList = Utility.parseList(self.value)
        # outside of lock as addCell is locking
        for value in valuesAsList:
            self.addCell(value)
