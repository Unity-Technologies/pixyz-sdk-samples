from imgui_bundle import imgui
import pxz

class Selection:
    def __init__(self, ui):
        self.ui = ui
        self.addShortcuts()

    def draw(self):
        if imgui.begin_menu("Selection", True):
            if imgui.menu_item("Fit", 'F', False, True)[0]:
                self.fit()
            if imgui.menu_item("Invert Selection", "Ctrl+Shift+I", False, True)[0]:
                self.invertSelection()
            empty = len(pxz.scene.getSelectedOccurrences()) == 0
            if empty:
                imgui.begin_disabled()
            if imgui.menu_item("Delete Occurrences", 'Del', False, True)[0]:
                self.delete()
            imgui.separator()
            if imgui.menu_item("Show", 'S', False, True)[0]:
                self.show()
            if imgui.menu_item("Hide", 'H', False, True)[0]:
                self.hide()
            imgui.separator()
            if imgui.menu_item("Find In Tree", 'Ctrl+F', False, True)[0]:
                self.findInTree()
            if empty:
                imgui.end_disabled()
            imgui.end_menu()

    def fit(self):
        self.ui.window.viewer.camera.fit(pxz.scene.getSelectedOccurrences())

    def findInTree(self):
        self.ui.tree.findSelection()

    def doDelete(self):
        pxz.scene.deleteOccurrences(pxz.scene.getSelectedOccurrences())

    def delete(self):
        self.ui.processQueue.enqueue(self.doDelete)

    def show(self):
        for occ in pxz.scene.getSelectedOccurrences():
            pxz.scene.show(occ)

    def invertSelection(self):
        pxz.scene.invertSelection()

    def hide(self):
        # hide selected occurrences if some are visible
        # else show selected occurrences
        everythingIsHidden = True
        for occ in pxz.scene.getSelectedOccurrences():
            occVisibility = pxz.core.getProperty(occ, "Visible")
            if occVisibility == "True" or occVisibility == "Inherited":
                everythingIsHidden = False
                pxz.scene.hide(occ)
        if everythingIsHidden:
            for occ in pxz.scene.getSelectedOccurrences():
                pxz.scene.show(occ)

    def addShortcuts(self):
        self.ui.shortcuts.addShortcut('f', self.fit)
        self.ui.shortcuts.addShortcut('delete', self.delete)
        self.ui.shortcuts.addShortcut('s', self.show)
        self.ui.shortcuts.addShortcut('h', self.hide)
        self.ui.shortcuts.addShortcutCtrl('f', self.findInTree)
        self.ui.shortcuts.addShortcutCtrlShift('i', self.invertSelection)
