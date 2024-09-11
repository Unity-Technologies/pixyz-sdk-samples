import pxz
from imgui_bundle import imgui


class FunctionList:
    def __init__(self, ui, selectionCallback=None):
        self.ui = ui
        self.selectionCallback = selectionCallback
        self.selectedFunction = None
        self.previousSelectedFunction = None
        # needed for expand/collapse all
        self.treeDict = {}
        # filtering
        self.filter = ""
        self._modules = pxz.core.getModules()
        self._initializeTreeDict()

    def draw(self):
        imgui.text("Filter")
        imgui.same_line()
        imgui.set_next_item_width(imgui.get_content_region_avail()[0])
        filterChanged, self.filter = imgui.input_text("##Filter", self.filter)
        if filterChanged:
            if self.filter == "":
                self._modules = self.ui.functionLibrary.getModulesCopy()
            else:
                self._modules = self.filterModules(self.filter, self.ui.functionLibrary.getModulesCopy())
        # Draw a listbox with collapsing_header for modules and tree_node_ex for groups.
        # Under each tree_node_ex, we list selectables for the corresponding functions.
        if imgui.begin_list_box("##FunctionListBox", imgui.get_content_region_avail()):
            self.drawHierarchical()
            imgui.end_list_box()

    def activate(self, function):
        self.previousSelectedFunction = self.selectedFunction
        self.selectedFunction = function
        if self.selectionCallback:
            self.selectionCallback(function)

    def drawCollapseExpandContextMenu(self):
        # context menu collapse / expand
        if imgui.begin_popup_context_window():
            if imgui.menu_item("Expand All", "", False)[0]:
                self.expandAll()
            if imgui.menu_item("Collapse All", "", False)[0]:
                self.collapseAll()
            imgui.end_popup()

    def expandAll(self):
        for key in self.treeDict.keys():
            self.treeDict[key] = True

    def collapseAll(self):
        for key in self.treeDict.keys():
            self.treeDict[key] = False

    def drawHierarchical(self):
        def drawSelectables(group):
            for function in group.functions:
                isSelected = function == self.selectedFunction
                if imgui.selectable(function.name, isSelected)[1]:
                    self.selectedFunction = function
                if isSelected and self.selectedFunction != self.previousSelectedFunction:
                    self.activate(function)

        for module in self._modules:
            # check for collapse/expand all
            if module.name in self.treeDict.keys():
                imgui.set_next_item_open(self.treeDict[module.name])
            self.treeDict[module.name] = imgui.collapsing_header(module.name)
            # is it expanded?
            if self.treeDict[module.name]:
                drawLast = None
                # draw groups
                for group in module.groups:
                    if group.name != "":
                        # check for collapse/expand all
                        if module.name + "." + group.name in self.treeDict.keys():
                            imgui.set_next_item_open(self.treeDict[module.name + "." + group.name])
                        self.treeDict[module.name + "." + group.name] = imgui.tree_node_ex(group.name)
                        if self.treeDict[module.name + "." + group.name]:
                            drawSelectables(group)
                            imgui.tree_pop()
                    else:
                        # We are drawing the functions last which do not belong to any group
                        drawLast = group
                if drawLast is not None:
                    drawSelectables(drawLast)
        self.drawCollapseExpandContextMenu()

    def filterModules(self, filter, modules):
        filter = filter.lower()
        # iterate backwards to remove elements from the list without messing up the indices
        for moduleIndex in range(len(modules) - 1, -1, -1):
            module = modules[moduleIndex]
            if filter in module.name.lower():
                # if the module name matches, we don't need to remove the module
                continue
            for groupIndex in range(len(module.groups) - 1, -1, -1):
                group = module.groups[groupIndex]
                removeGroup = True
                if filter in group.name.lower() and group.name != "":
                    # if the group name matches, we don't need to remove the group
                    continue
                for functionIndex in range(len(group.functions) - 1, -1, -1):
                    function = group.functions[functionIndex]
                    if filter in function.name.lower():
                        removeGroup = False
                    else:
                        group.functions.pop(functionIndex)
                if removeGroup:
                    module.groups.pop(groupIndex)
            if not module.groups:
                modules.pop(moduleIndex)
        return modules

    def _initializeTreeDict(self):
        for module in self._modules:
            self.treeDict[module.name] = False
            for group in module.groups:
                self.treeDict[module.name + "." + group.name] = False
        return self.treeDict
