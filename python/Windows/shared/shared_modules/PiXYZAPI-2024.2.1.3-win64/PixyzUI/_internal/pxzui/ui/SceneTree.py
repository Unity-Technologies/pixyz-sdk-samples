import threading

from imgui_bundle import imgui
import pxz

from pxzui.ui.WindowBase import WindowBase


class SceneTree(WindowBase):

    class NodeData:
        def __init__(self, node):
            self.id = node
            self.name = pxz.scene.getOccurrenceName(node)
            if self.name == "":
                self.name = "Occurrence " + str(node)
            self.parent = pxz.scene.getParent(node)
            self.children = pxz.scene.getChildren(node)
            self.hidden = not pxz.scene.getGlobalVisibility(node)
            self.needExpand = False
            self.needCollapse = False
            self.isOpen = False

        @property
        def has_children(self):
            return len(self.children) != 0

    _state = None

    def __init__(self, ui, root=-1):
        super().__init__()
        self.enable()  # enable SceneTree in default ui
        self.ui = ui
        if root < 0:
            root = pxz.scene.getRoot()
        self.root = root
        self.transitionTo(SceneTreeStateDefault(self, root))
        self.ui.window.callback_manager.addSceneChangedCallback(self.onSceneChanged)
        self.ui.window.callback_manager.addSelectionChangedCallback(self.onSelectionChanged)
        self.filter = ""
        self.data = {}
        self.selection = []
        self.active_node = root
        self.active_node_was_drawn = False
        self.scroll_to_active = False
        self.scroll_to_selected = False
        self.scrolling_coeff = None
        self.reset_scrolling_coeff()
        self._deletionLock = threading.Lock()

    def __del__(self):
        self.ui.window.callback_manager.removeSceneChangedCallback(self.onSceneChanged)
        self.ui.window.callback_manager.removeSelectionChangedCallback(self.onSelectionChanged)

    def transitionTo(self, state):
        self._state = state
        self._state.context = self

    def draw(self):
        # locking to avoid concurrent access to the scene tree data
        # (which is modified by the sceneChanged callback and the draw function)
        with self._deletionLock:
            self.active_node_was_drawn = False
            self.keyboardNavigation()
            self.drawFilter()
            self._state.drawOccurrences()
            self.scroll_to_active = self.scroll_to_selected = False

    def drawFilter(self):
        imgui.set_next_item_width(imgui.get_content_region_avail()[0])
        filterChanged, self.filter = imgui.input_text_with_hint("##SceneTreeFilter", "Filter", self.filter, imgui.InputTextFlags_.auto_select_all)
        if imgui.is_item_focused():
            # don't fire shortcuts when typing in the filter
            self.ui.shortcuts.skipBasicThisFrame()
        if filterChanged:
            if self.isInSearchState() and self.filter == "":
                self.transitionTo(SceneTreeStateDefault(self, self.root))
            elif not self.isInSearchState() and self.filter != "":
                self.transitionTo(SceneTreeStateSearch(self, self.root, self.filter))
            elif self.isInSearchState() and self.filter != "":
                self._state.setFilter(self.filter)

    def isInSearchState(self):
        return isinstance(self._state, SceneTreeStateSearch)

    def findSelection(self):
        self._state.findSelection()

    def keyboardNavigation(self):
        if imgui.is_window_focused(imgui.FocusedFlags_.root_and_child_windows):
            io = imgui.get_io()
            if imgui.is_key_pressed(imgui.Key.down_arrow, repeat=True):
                self.active_node = self.next_node(self.active_node)
                if not io.key_ctrl and not io.key_shift:
                    pxz.scene.clearSelection()
                pxz.scene.select([self.active_node])
                self.scroll_to_active = True
                self.scrolling_coeff = 0.9  # cf is_item_visible() bug
            if imgui.is_key_pressed(imgui.Key.up_arrow, repeat=True):
                self.active_node = self.prev_node(self.active_node)
                if not io.key_ctrl and not io.key_shift:
                    pxz.scene.clearSelection()
                pxz.scene.select([self.active_node])
                self.scroll_to_active = True
                self.scrolling_coeff = 0.0
            self._state.keyboardNavigation()

    def onSceneChanged(self, eventType, occurrence, child):
        with self._deletionLock:
            self.deleteSubTreeData(occurrence)
            self._state.onSceneChanged(eventType, occurrence, child)

    def onSelectionChanged(self, selectionChangeType, occurrences):
        self.selection = pxz.scene.getSelectedOccurrences()

    def getNodeData(self, node):
        if not node in self.data.keys():
            self.data[node] = self.NodeData(node)
        return self.data[node]

    def deleteSubTreeData(self, node):
        if node in self.data.keys():
            for child in self.data[node].children:
                self.deleteSubTreeData(child)
            self.data.pop(node)

    def reset_scrolling_coeff(self):
        self.scrolling_coeff = 0.5

    def next_node(self, node):
        return self._state.next_node(node)

    def prev_node(self, node):
        return self._state.prev_node(node)

    def select_node_span(self, beg, end):
        """`beg` *must* be before `end` in the node tree"""
        selection = []
        while beg != end:
            selection.append(beg)
            beg = self.next_node(beg)
        selection.append(end)
        # Select multiple spans : click, shift click somewhere to create a span, ctrl click somewhere, ctrl shift click somewhere else boom you have two spans
        if not imgui.get_io().key_ctrl:
            pxz.scene.clearSelection()
        pxz.scene.select(selection)
        self.active_node = end

class SceneTreeState:
    """Abstract class for SceneTree states"""

    def __init__(self, sceneTree: SceneTree, root):
        self._sceneTree = sceneTree
        self.root = root

    @property
    def sceneTree(self) -> SceneTree:
        return self._sceneTree

    @sceneTree.setter
    def sceneTree(self, sceneTree: SceneTree) -> None:
        self._sceneTree = sceneTree

    def drawOccurrences(self) -> None:
        raise NotImplementedError

    def findSelection(self):
        raise NotImplementedError

    def next_node(self, active_node):
        raise NotImplementedError

    def prev_node(self, active_node):
        raise NotImplementedError

    def onSceneChanged(self, eventType, occurrence, child):
        pass

    def keyboardNavigation(self):
        pass

class SceneTreeStateDefault(SceneTreeState):

    def __init__(self, sceneTree: SceneTree, root):
        super().__init__(sceneTree, root)
        self.expandingAll = False
        self.collapsingAll = False

    def drawOccurrences(self) -> None:
        self.drawHierarchical()
        # context Menu
        if imgui.begin_popup_context_window():
            if imgui.menu_item("Expand All", "", False)[0]:
                self.expandAll()
            if imgui.menu_item("Collapse All", "", False)[0]:
                self.collapseAll()
            if self.sceneTree.active_node:
                imgui.separator()
                if imgui.menu_item("Load external reference", "", False)[0]:
                    self.sceneTree.ui.processQueue.enqueue(self.loadReferencedData, False)
                if imgui.menu_item("Load external reference (recursive)", "", False)[0]:
                    self.sceneTree.ui.processQueue.enqueue(self.loadReferencedData, True)
            imgui.end_popup()

    def keyboardNavigation(self):
        # Keyboard navigation:
        if imgui.is_key_pressed(imgui.Key.right_arrow, repeat=False):
            self.sceneTree.getNodeData(self.sceneTree.active_node).needExpand = True
        if imgui.is_key_pressed(imgui.Key.left_arrow, repeat=False):
            self.sceneTree.getNodeData(self.sceneTree.active_node).needCollapse = True

    def drawHierarchical(self):
        self.drawTreeNode(self.root)
        self.expandingAll = self.collapsingAll = False

    def expandAll(self):
        self.expandingAll = True

    def collapseAll(self):
        self.collapsingAll = True

    def doLoadReferencedData(self, occurence, recursive):
        referencedDataComponent = pxz.scene.getComponent(occurence, pxz.scene.ComponentType.ReferencedDataComponent)
        if referencedDataComponent:
            pxz.io.loadReferencedData(referencedDataComponent, False)
        elif recursive:
            for child in pxz.scene.getChildren(occurence):
                self.doLoadReferencedData(child, recursive)

    def loadReferencedData(self, recursive):
        for occurence in pxz.scene.getSelectedOccurrences():
            self.doLoadReferencedData(occurence, recursive)

    def drawTreeNode(self, node):
        data = self.sceneTree.getNodeData(node)
        flags = imgui.TreeNodeFlags_.open_on_double_click | imgui.TreeNodeFlags_.open_on_arrow | imgui.TreeNodeFlags_.span_full_width
        if not data.has_children:
            flags |= imgui.TreeNodeFlags_.leaf
        if node in self.sceneTree.selection:
            flags |= imgui.TreeNodeFlags_.selected
            if self.sceneTree.scroll_to_selected == True and not imgui.is_item_visible():  # There seems to be a bug where the first hidden item is considered visible :/
                imgui.set_scroll_here_y(self.sceneTree.scrolling_coeff)
        if node == self.sceneTree.active_node:
            self.sceneTree.active_node_was_drawn = True
            imgui.push_font(self.sceneTree.ui.window.currentFontBold)
            if self.sceneTree.scroll_to_active == True and not imgui.is_item_visible():  # There seems to be a bug where the first hidden item is considered visible :/
                imgui.set_scroll_here_y(self.sceneTree.scrolling_coeff)

        if self.expandingAll or data.needExpand:
            imgui.set_next_item_open(True)
            data.needExpand = False
        if self.collapsingAll or data.needCollapse:
            imgui.set_next_item_open(False)
            data.needCollapse = False
        if data.hidden:
            hiddenColor = imgui.get_style().color_(imgui.Col_.text_disabled)
            imgui.push_style_color(imgui.Col_.text, hiddenColor)

        data.isOpen = imgui.tree_node_ex(str(data.id), flags, data.name)
        if node == self.sceneTree.active_node:
            imgui.pop_font()
        if data.hidden:
            imgui.pop_style_color()
        if imgui.is_item_clicked() or imgui.is_item_clicked(1):
            if imgui.get_io().key_shift:
                # did we click before or after the node?
                if self.sceneTree.active_node_was_drawn:
                    self.sceneTree.select_node_span(self.sceneTree.active_node, node)
                else:
                    self.sceneTree.select_node_span(node, self.sceneTree.active_node)
            else:
                if not imgui.get_io().key_ctrl:
                    pxz.scene.clearSelection()
                pxz.scene.select([node])
            self.sceneTree.active_node = node

        if data.isOpen:
            for child in data.children:
                self.drawTreeNode(child)
            imgui.tree_pop()

    def expandTo(self, node):
        data = self.sceneTree.getNodeData(node)
        parent = data.parent
        if parent != 0:
            self.expandTo(parent)
        self.sceneTree.getNodeData(node).needExpand = True

    # Navigation:

    def last_opened_child_recur(self, node):
        """Finds the last opened child of the last opened child etc. of a node"""
        data = self.sceneTree.getNodeData(node)
        if data.isOpen and data.has_children:
            return self.last_opened_child_recur(data.children[-1])
        return node

    def prev_node(self, node):
        """Previous sibling or parent if there's no"""
        if node == self.root:
            return node
        data = self.sceneTree.getNodeData(node)
        parent_id = data.parent
        parent = self.sceneTree.getNodeData(parent_id)
        siblings = parent.children
        for index, child in enumerate(siblings):
            if child == node:
                prev_node_index = index - 1
                if prev_node_index == -1:
                    return parent_id
                return self.last_opened_child_recur(siblings[prev_node_index])

    def next_sibling(self, node):
        """Next Occurrence in tree, not counting its children"""
        if node == self.root:
            return -1
        data = self.sceneTree.getNodeData(node)
        parent_id = data.parent
        parent = self.sceneTree.getNodeData(parent_id)
        siblings = parent.children
        for index, child in enumerate(siblings):
            if child == node:
                next_node_index = index + 1
                if next_node_index == len(siblings):
                    return self.next_sibling(parent_id)
                return siblings[next_node_index]

    def next_node(self, node):
        """Next Occurrence in tree, counting its children if the node is open"""
        data = self.sceneTree.getNodeData(node)
        if data.isOpen and data.has_children:
            return data.children[0]
        next_occ = self.next_sibling(node)
        if next_occ > 0:
            return next_occ
        return node

    def findSelection(self):
        for node in self.sceneTree.selection:
            self.expandTo(node)
        self.sceneTree.reset_scrolling_coeff()
        self.sceneTree.scroll_to_selected = True

class SceneTreeStateSearch(SceneTreeState):
    def __init__(self, sceneTree: SceneTree, root, f):
        super().__init__(sceneTree, root)
        self.filter = f
        self.sceneHasChanged = False
        self.matches, self.idToIndex = self.generateMatches(self.filter)

    def drawOccurrences(self) -> None:
        if self.sceneHasChanged:
            self.matches, self.idToIndex = self.generateMatches(self.filter)
            self.sceneHasChanged = False
        self.drawFiltered()

    def generateMatches(self, searchText):
        matches = []
        def getFilteredRecursive(node, matches):
            d = self.sceneTree.getNodeData(node)
            if searchText.lower() in d.name.lower():
                matches.append(d)
            for child in d.children:
                getFilteredRecursive(child, matches)
        getFilteredRecursive(self.root, matches)
        return matches, {match.id: index for index, match in enumerate(matches)}

    def drawFiltered(self):
        if imgui.begin_list_box("##FilteredOccurrenceListBox", imgui.get_content_region_avail()):
            for data in self.matches:
                isActive = data.id == self.sceneTree.active_node
                if isActive:
                    self.sceneTree.active_node_was_drawn = True
                    if self.sceneTree.scroll_to_active and not imgui.is_item_visible():
                        imgui.set_scroll_here_y(self.sceneTree.scrolling_coeff)
                    imgui.push_font(self.sceneTree.ui.window.currentFontBold)
                isSelected = data.id in self.sceneTree.selection
                if isSelected:
                    if self.sceneTree.scroll_to_selected and not imgui.is_item_visible():
                        imgui.set_scroll_here_y(self.sceneTree.scrolling_coeff)
                imgui.selectable(str(data.name), isSelected)
                if imgui.is_item_clicked():
                    if imgui.get_io().key_shift:
                        # did we click before or after the node?
                        if self.sceneTree.active_node_was_drawn:
                            self.sceneTree.select_node_span(self.sceneTree.active_node, data.id)
                        else:
                            self.sceneTree.select_node_span(data.id, self.sceneTree.active_node)
                    else:
                        if not imgui.get_io().key_ctrl:
                            pxz.scene.clearSelection()
                        pxz.scene.select([data.id])
                    self.sceneTree.active_node = data.id
                if isActive:
                    imgui.pop_font()
            imgui.end_list_box()

    def setFilter(self, f):
        self.filter = f
        self.matches, self.idToIndex = self.generateMatches(self.filter)

    def findSelection(self):
        self.sceneTree.reset_scrolling_coeff()
        self.sceneTree.scroll_to_selected = True

    def next_node(self, node):
        if len(self.matches) == 0:
            return node
        activeIndex = self.activeIndex(node)
        if activeIndex == -1:
            return self.matches[0].id
        return self.matches[(activeIndex + 1) % len(self.matches)].id

    def prev_node(self, active_node):
        if len(self.matches) == 0:
            return active_node
        activeIndex = self.activeIndex(active_node)
        if activeIndex == -1:
            return self.matches[len(self.matches) - 1].id
        return self.matches[(activeIndex - 1) % len(self.matches)].id

    def activeIndex(self, activeNode):
        if activeNode in self.idToIndex:
            return self.idToIndex[activeNode]
        return -1

    def onSceneChanged(self, eventType, occurrence, child):
        self.sceneHasChanged = True
