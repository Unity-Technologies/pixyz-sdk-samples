from imgui_bundle import imgui
from pxzui.ui.Properties import *
import pxz

from pxzui.ui.WindowBase import WindowBase


def onSelectionChanged(type, occurrences, sceneTree):
    sceneTree.onSelectionChanged(type, occurrences)

class Inspector(WindowBase):
    def __init__(self, ui):
        super().__init__()
        self.ui = ui
        self.activeOccurrence = None
        self.built = False
        pxz.scene.addSelectionChangedCallback(onSelectionChanged, self)
        self.properties = None
        self.components = []

    def draw(self):
        if self.activeOccurrence is not None:
            if self.built:
                self.properties.draw()
                imgui.separator()
                if imgui.begin_tab_bar("Components"):
                    for component in self.components:
                        if imgui.begin_tab_item(component[0])[0]:
                            component[1].draw()
                            imgui.end_tab_item()
                    if imgui.tab_item_button("+"):
                        pass
                    imgui.end_tab_bar()
        else:
            imgui.text("Empty or multiple occurrence selection")

    def build(self):
        self.properties = None
        self.components = []
        if self.activeOccurrence is not None:
            self.properties = EntityProperties(self.ui, self.activeOccurrence)
            components = pxz.scene.listComponents(self.activeOccurrence)
            for component in components:
                self.components.append((pxz.core.getEntityTypeString(component), EntityProperties(self.ui, component)))
        self.built = True

    def onSelectionChanged(self, type, occurrences):
        self.built = False
        if type == pxz.scene.SelectionChangeType.CLEARED or type == pxz.scene.SelectionChangeType.REMOVED:
            self.activeOccurrence = None
        else:
            selection = pxz.scene.getSelectedOccurrences()
            self.activeOccurrence = selection[0] if len(selection) == 1 else None
        self.build()
