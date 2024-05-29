import threading

import pxz

from pxzui.ui.widgets.IWidget import IWidget
from imgui_bundle import imgui, ImVec2

from pxzui.ui.widgets.Utility import Utility


class ListWidget(IWidget):
    minusButtonSize = 50

    def __init__(self, ui, typeObj, name, defaultValue):
        self.ui = ui
        self._lock = threading.Lock()
        self.cellType = pxz.core.getType(typeObj.module, typeObj.definition[1].listType)
        self.name = name
        self.cells = []
        self.currentCellId = -1
        if defaultValue != "":
            self.setValue(defaultValue)
        else:
            self.value = ""

    def draw(self):
        cellsToDelete = []
        anyChanges = False
        newValue = '['
        # drawing listbox
        if imgui.begin_list_box("##" + self.name + "ListBox", ImVec2(imgui.get_content_region_avail()[0], 0)):
            if imgui.button("+", ImVec2(imgui.get_content_region_avail()[0], 0)):
                self.addCell()
            with self._lock:
                for cellIndex in range(len(self.cells)):
                    # TODO:
                    #  Weird things happen to imgui when trying to wrap the cell.draw in a table cell or child.
                    #  Using imgui.same_line() to make the minus button appear on the same line as the cell until a
                    #  better solution is found.
                    imgui.set_next_item_width(imgui.get_content_region_avail()[0] - ListWidget.minusButtonSize)
                    cellChanged, cellValue = self.cells[cellIndex].draw()
                    anyChanges |= cellChanged
                    newValue += cellValue
                    if cellIndex + 1 < len(self.cells): newValue += ','
                    imgui.same_line()
                    if imgui.button("-##" + str(cellIndex), ImVec2(imgui.get_content_region_avail()[0], 0)):
                        cellsToDelete.append(self.cells[cellIndex])
            imgui.end_list_box()
        newValue += ']'
        self.value = newValue
        # deleting cells here to not do it while iterating
        for cell in cellsToDelete:
            self.removeCell(cell)
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
