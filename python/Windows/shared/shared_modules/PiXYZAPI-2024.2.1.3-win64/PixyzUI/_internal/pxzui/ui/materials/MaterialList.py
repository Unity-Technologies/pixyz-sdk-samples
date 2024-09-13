import pxz
from imgui_bundle import imgui, ImVec2


class MaterialList():
    def __init__(self, ui):
        self.ui = ui
        self.selectedIndex = -1
        self.previousSelectedIndex = -1
        self.materials = []
        for materialId in pxz.material.getAllMaterials():
            self.materials.append([materialId, pxz.core.getProperty(materialId, "Name")])
        # drag and drop
        self.dragging = False
        self.draggedMaterial = None
        # callbacks
        self.ui.window.callback_manager.addMaterialChangedCallback(self.onMaterialChanged)
        self.ui.window.callback_manager.addOnSessionResetCallback(self.onResetSession)

    def __del__(self):
        self.ui.window.callback_manager.removeMaterialChangedCallback(self.onMaterialChanged)
        self.ui.window.callback_manager.removeOnSessionResetCallback(self.onResetSession)

    def onMaterialChanged(self, materialChangeType, id):
        match materialChangeType:
            case pxz.material.MaterialChangeType.ADDED:
                self.materials.append([id, pxz.core.getProperty(id, "Name")])
            case pxz.material.MaterialChangeType.REMOVED | pxz.material.MaterialChangeType.DESTROYED:
                self.selectedIndex = -1
                self.previousSelectedIndex = -1
                self.materials = [material for material in self.materials if material[0] != id]
            case pxz.material.MaterialChangeType.CHANGED:
                for index, material in enumerate(self.materials):
                    if material[0] == id:
                        self.materials[index][1] = pxz.core.getProperty(id, "Name")
                        break

    def draw(self):
        changed = False
        if imgui.begin_list_box("##MaterialListBox", imgui.get_content_region_avail()):
            imgui.calc_item_width()
            if imgui.button("+", ImVec2(imgui.get_content_region_avail()[0], 0)):
                self.createNewMaterial()
            for index, material in enumerate(self.materials):
                isSelected = index == self.selectedIndex
                _, selected = imgui.selectable("[" + str(material[0]) + "] " + material[1], isSelected)
                # drag from list, drop on scene
                self.dragAndDrop(material)
                # update selection
                if selected:
                    self.selectedIndex = index
                if isSelected and self.selectedIndex != self.previousSelectedIndex:
                    changed = True
                    self.previousSelectedIndex = self.selectedIndex
            imgui.end_list_box()
        return changed, self.getSelectedMaterial()

    def createNewMaterial(self):
        name = "New Material"
        pattern = "color"
        pxz.material.createMaterial(name, pattern)

    def dragAndDrop(self, material):
        if imgui.is_item_hovered() and imgui.is_mouse_dragging(0):
            self.dragging = True
            self.draggedMaterial = material
        if self.dragging:
            imgui.set_tooltip(self.draggedMaterial[1])
            if imgui.is_mouse_released(0):
                self.dragging = False
                if not imgui.is_any_item_hovered():
                    self.ui.processQueue.enqueue(self.assignMaterialOnDrop, self.draggedMaterial[0])

    def assignMaterialOnDrop(self, materialId):
        pickResult = pxz.view.pick(int(self.ui.window.lastxpos),
                                   self.ui.window.viewer.height - int(self.ui.window.lastypos),
                                   self.ui.window.viewer.viewer)
        if pickResult["occurrence"] != 0:
            pxz.core.setProperty(pickResult["occurrence"], "Material", str(materialId))

    def getSelectedMaterial(self):
        if self.materials:
            return self.materials[self.selectedIndex][0]
        else:
            return None

    def onResetSession(self):
        self.ui.processQueue.enqueue(self.reset)

    def reset(self):
        self.selectedIndex = -1
        self.previousSelectedIndex = -1
        self.materials.clear()
