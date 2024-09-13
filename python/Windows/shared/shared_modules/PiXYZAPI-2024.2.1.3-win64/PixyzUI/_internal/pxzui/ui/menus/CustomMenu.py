import pxz
from imgui_bundle import imgui, ImVec2

from pxzui.ui.ConfigOwner import ConfigOwner
from pxzui.ui.functions.FunctionDialog import FunctionDialog
from pxzui.ui.functions.FunctionList import FunctionList
from pxzui.utils.EmVec2 import EmVec2


class CustomMenus(ConfigOwner):
    def __init__(self, ui):
        super().__init__()
        self.ui = ui
        self.isDrawCreationDeletionWindow = False
        self.creationWindowName = ""
        self.customMenus = []
        self.selectedCustomMenu = None

    def draw(self):
        if self.isDrawCreationDeletionWindow:
            self.drawCreationDeletionWindow()
        for index, customMenu in enumerate(self.customMenus):
            imgui.push_id("CustomMenu"+str(index))
            customMenu.draw()
            imgui.pop_id()

    def drawInPopup(self):
        imgui.separator()
        if imgui.selectable("Custom Menus", False)[1]:
            self.isDrawCreationDeletionWindow = True

    def drawCreationDeletionWindow(self):
        if imgui.is_key_pressed(imgui.Key.escape):
            self.isDrawCreationDeletionWindow = False
        windowFlags = imgui.WindowFlags_.no_resize | imgui.WindowFlags_.no_collapse | imgui.WindowFlags_.no_docking | imgui.WindowFlags_.always_auto_resize
        _, self.isDrawCreationDeletionWindow = imgui.begin("Create Custom Menu", self.isDrawCreationDeletionWindow, windowFlags)
        # draw all custom menu names in a list box
        if imgui.begin_list_box("##custom menu list box", ImVec2(imgui.get_content_region_avail()[0], 0)):
            for customMenu in self.customMenus:
                isSelected = customMenu == self.selectedCustomMenu
                if imgui.selectable(customMenu.name, isSelected)[1]:
                    self.selectedCustomMenu = customMenu
            imgui.end_list_box()
        # input text and button for custom menu name
        _, self.creationWindowName = imgui.input_text_with_hint("##name input text", "Name", self.creationWindowName)
        isCreateButtonDisabled = self.creationWindowName == "" or self.creationWindowName in [customMenu.name for customMenu in self.customMenus]
        if isCreateButtonDisabled:
            imgui.begin_disabled()
        if (imgui.button("Create", ImVec2(imgui.get_content_region_avail()[0], 0)) or imgui.is_key_pressed(imgui.Key.enter)):
            self.createCustomMenu(self.creationWindowName)
            self.creationWindowName = ""
        if isCreateButtonDisabled:
            imgui.end_disabled()
        # button to delete selected custom menu
        isRemoveButtonDisabled = self.selectedCustomMenu is None
        if isRemoveButtonDisabled:
            imgui.begin_disabled()
        if imgui.button("Delete", ImVec2(imgui.get_content_region_avail()[0], 0)) and self.selectedCustomMenu is not None:
            self.customMenus.remove(self.selectedCustomMenu)
            self.selectedCustomMenu = None
        if isRemoveButtonDisabled:
            imgui.end_disabled()
        imgui.end()

    def createCustomMenu(self, creationWindowName):
        self.creationWindowName = ""
        self.customMenus.append(CustomMenu(self.ui, creationWindowName))

    def saveConfig(self):
        customMenus = {}
        for customMenu in self.customMenus:
            customMenus[customMenu.name] = [[function.module, function.name] for function in customMenu.getFunctions()]
        self.setConfig("CustomMenus", customMenus)
        return super().saveConfig()

    def restoreConfig(self, config):
        super().restoreConfig(config)
        if self.hasConfig("CustomMenus") and self.getConfig("CustomMenus") is not None:
            customMenus = self.getConfig("CustomMenus")
            for customMenuName in customMenus.keys():
                customMenu = CustomMenu(self.ui, customMenuName)
                for moduleName, functionName in customMenus[customMenuName]:
                    try:
                        functionDesc = pxz.core.getFunction(moduleName, functionName)
                        customMenu.addFunction(functionDesc)
                    except:
                        print("CustomMenu: Could not find function " + moduleName + "." + functionName)
                self.customMenus.append(customMenu)

class CustomMenu:
    def __init__(self, ui, name):
        self.ui = ui
        self.name = name
        self.manageWindow = ManageWindow(ui, self, self.addFunction, self.removeFunction)
        self.active = False
        self.functions = {}

    def draw(self):
        if imgui.begin_menu(self.name, True):
            for function, functionDialog in self.functions.items():
                if imgui.menu_item(function.module + "." + function.name, "", functionDialog.visible)[0]:
                    if not functionDialog.visible:
                        functionDialog.open(function)
                    else:
                        functionDialog.close()
            imgui.separator()
            if imgui.menu_item("Manage", "", False, True)[0]:
                self.manageWindow.active = True
            imgui.end_menu()
        self.manageWindow.draw()
        for functionDialog in self.functions.values():
            functionDialog.draw()

    def addFunction(self, function):
        self.functions[function] = FunctionDialog(self.ui)

    def removeFunction(self, function):
        self.functions.pop(function)

    def getFunctions(self):
        return self.functions.keys()


class ManageWindow:
    def __init__(self, ui, customMenu, onAddFunctionCallback, onRemoveFunctionCallback):
        self.customMenu = customMenu
        self.functionList = FunctionList(ui, onAddFunctionCallback)
        self.active = False
        self.onRemoveFunctionCallback = onRemoveFunctionCallback
        self.listBoxWidth = 400

    def draw(self):
        imgui.push_style_var(imgui.StyleVar_.window_min_size, EmVec2(32, 16))
        if self.active:
            _, self.active = imgui.begin(self.customMenu.name, self.active)
            # function list (like in browser)
            if imgui.begin_child("FunctionListChild", ImVec2(self.listBoxWidth, imgui.get_content_region_avail()[1])):
                self.functionList.draw()
            imgui.end_child()
            imgui.same_line()
            # Movable splitter (https://github.com/ocornut/imgui/issues/125#issuecomment-135775009)
            imgui.invisible_button("vsplitter", EmVec2(x=0.3))
            if imgui.is_item_active():
                self.listBoxWidth = self.listBoxWidth + imgui.get_io().mouse_delta.x
            if imgui.is_item_hovered():
                imgui.set_mouse_cursor(imgui.MouseCursor_.resize_ew)
            imgui.same_line()
            # selected functions in a simple list box
            if imgui.begin_list_box("##selected functions list box",
                                    ImVec2(imgui.get_content_region_avail()[0], imgui.get_content_region_avail()[1])):
                for function in list(self.customMenu.functions):
                    if imgui.selectable(function.module + "." + function.name, False)[1]:
                        self.onRemoveFunctionCallback(function)
                imgui.end_list_box()
            imgui.end()
        imgui.pop_style_var()
