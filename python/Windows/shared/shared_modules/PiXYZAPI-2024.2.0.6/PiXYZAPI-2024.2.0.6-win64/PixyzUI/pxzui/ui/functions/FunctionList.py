from imgui_bundle import imgui, ImVec2


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
        self.filteredFunctions = []

    def draw(self):
        imgui.text("Filter")
        imgui.same_line()
        imgui.set_next_item_width(imgui.get_content_region_avail()[0])
        filterChanged, self.filter = imgui.input_text("##Filter", self.filter)
        # Draw a listbox with collapsing_header for modules and tree_node_ex for groups.
        # Under each tree_node_ex, we list selectables for the corresponding functions.
        if imgui.begin_list_box("##FunctionListBox", imgui.get_content_region_avail()):
            if self.filter != "":
                self.drawFiltered()
            else:
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
        def drawSelectables(module, group):
            for function in group.functions:
                isSelected = function == self.selectedFunction
                if imgui.selectable(function.name, isSelected)[1]:
                    self.selectedFunction = function
                if isSelected and self.selectedFunction != self.previousSelectedFunction:
                    self.activate(function)

        for module in self.ui.functionLibrary.modules:
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
                            drawSelectables(module, group)
                            imgui.tree_pop()
                    else:
                        # We are drawing the functions last which do not belong to any group
                        drawLast = group
                if drawLast is not None:
                    drawSelectables(module, drawLast)
        self.drawCollapseExpandContextMenu()

    def drawFiltered(self):
        for module in self.ui.functionLibrary.modules:
            for group in module.groups:
                for function in group.functions:
                    longName = module.name + "." + group.name + "." + function.name
                    if self.filter.lower() not in longName.lower():
                        continue
                    isSelected = function == self.selectedFunction
                    if imgui.selectable(longName, isSelected)[1]:
                        self.selectedFunction = function
                    if isSelected and self.selectedFunction != self.previousSelectedFunction:
                        self.activate(function)
