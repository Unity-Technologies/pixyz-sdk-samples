from imgui_bundle import imgui, ImVec2
from pxzui.ui.Properties import *
import pxz

from pxzui.ui.WindowBase import WindowBase


class Inspector(WindowBase):
    def __init__(self, ui):
        super().__init__()
        self.enable()  # enable Inspector in default ui
        self.ui = ui
        self.activeOccurrence = None
        self.built = False
        self.ui.window.callback_manager.addSelectionChangedCallback(self.onSelectionChanged)
        self.properties = None
        self.components = []
        self.componentTypeNames = {v: k for k, v in pxz.scene.ComponentType.__dict__.items() if (v is not None and v != "ComponentType")}
        self.componentTypesList = []

    def __del__(self):
        self.ui.window.callback_manager.removeSelectionChangedCallback(self.onSelectionChanged)

    def draw(self):
        if not self.activeOccurrence:
            imgui.text("Empty or multiple occurrence selection")
            return
        if not self.built:
            return

        self.properties.draw()
        imgui.separator()
        if imgui.begin_tab_bar("Components"):
            for component in self.components:
                open = True
                visible, open = imgui.begin_tab_item(pxz.core.getEntityTypeString(component[0]), open)
                if visible:
                    component[1].draw()
                    imgui.end_tab_item()
                if not open:
                    pxz.core.deleteEntities([component[0]])
                    self.built = False
                    self.build()
            if imgui.tab_item_button("+"):
                imgui.open_popup("Add Component")
            if imgui.begin_popup("Add Component"):
                for c in self.componentTypeNames:
                    if c in self.componentTypesList:
                        continue
                    if imgui.menu_item(self.componentTypeNames[c], "", False)[0]:
                        pxz.scene.addComponent(self.activeOccurrence, c)
                        self.built = False
                        self.build()
                imgui.end_popup()
            imgui.end_tab_bar()

    def build(self):
        if self.properties:
            self.properties.detach()
        for component in self.components:
            component[1].detach()
        self.properties = None
        self.components = []
        self.componentTypesList = []
        if self.activeOccurrence is not None:
            self.properties = EntityProperties(self.ui, self.activeOccurrence)
            components = pxz.scene.listComponents(self.activeOccurrence)
            for component in components:
                componentType = pxz.scene.getComponentType(component)
                if componentType == pxz.scene.ComponentType.SubpartMaterial:
                    self.components.append([component, SubpartMaterialProperties(self.ui, component, self.activeOccurrence)])
                elif componentType == pxz.scene.ComponentType.Part:
                    self.components.append([component, PartProperties(self.ui, component, self.activeOccurrence)])
                else:
                    self.components.append([component, EntityProperties(self.ui, component)])
                self.componentTypesList.append(componentType)
        self.built = True

    def onSelectionChanged(self, selectionChangeType, occurrences):
        self.built = False
        if selectionChangeType == pxz.scene.SelectionChangeType.CLEARED or selectionChangeType == pxz.scene.SelectionChangeType.REMOVED:
            self.activeOccurrence = None
        else:
            selection = pxz.scene.getSelectedOccurrences()
            self.activeOccurrence = selection[0] if len(selection) == 1 else None
        self.build()
