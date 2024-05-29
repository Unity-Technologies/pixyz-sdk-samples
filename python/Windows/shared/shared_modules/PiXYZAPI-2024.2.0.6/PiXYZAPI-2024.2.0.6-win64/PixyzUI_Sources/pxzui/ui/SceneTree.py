from imgui_bundle import imgui
import pxz

from pxzui.ui.WindowBase import WindowBase


def onSceneChanged(eventType, occurrence, child, sceneTree):
    sceneTree.onSceneChanged(eventType, occurrence, child)

def onSelectionChanged(type, occurrences, sceneTree):
    sceneTree.onSelectionChanged(type, occurrences)

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

    def __init__(self, root = pxz.scene.getRoot()):
        super().__init__()
        self.root = root
        pxz.scene.addSceneChangedCallback(onSceneChanged, self)
        pxz.scene.addSelectionChangedCallback(onSelectionChanged, self)
        self.data = {}
        self.expandingAll = False
        self.collapsingAll = False
        self.selection = []
        self.active_node = self.root
        self.scroll_to_active = False
        self.scrolling_coeff = None
        self.reset_scrolling_coeff()
        self.active_node_was_drawn = False

    def draw(self):
        # Keyboard navigation:
        if imgui.is_window_focused():
            io = imgui.get_io()
            if imgui.is_key_pressed(imgui.Key.right_arrow, repeat=False):
                self.getNodeData(self.active_node).needExpand = True
            if imgui.is_key_pressed(imgui.Key.left_arrow, repeat=False):
                self.getNodeData(self.active_node).needCollapse = True

            if imgui.is_key_pressed(imgui.Key.down_arrow, repeat=True):
                self.active_node = self.next_node_in_tree(self.active_node)
                if not io.key_ctrl and not io.key_shift:
                    pxz.scene.clearSelection()
                pxz.scene.select([self.active_node])
                self.scroll_to_active = True
                self.scrolling_coeff = 0.9 # cf is_item_visible() bug
            if imgui.is_key_pressed(imgui.Key.up_arrow, repeat=True):
                self.active_node = self.prev_node_in_tree(self.active_node)
                if not io.key_ctrl and not io.key_shift:
                    pxz.scene.clearSelection()
                pxz.scene.select([self.active_node])
                self.scroll_to_active = True
                self.scrolling_coeff = 0.0
        
        self.active_node_was_drawn = False
        self.drawTreeNode(self.root)
        self.expandingAll = self.collapsingAll = False
        
        # context Menu
        if imgui.begin_popup_context_window():
            if imgui.menu_item("Expand All", "", False)[0]:
                self.expandAll()
            if imgui.menu_item("Collapse All", "", False)[0]:
                self.collapseAll()
            imgui.end_popup()
        
        self.scroll_to_active = False;

    def expandAll(self):
        self.expandingAll = True

    def collapseAll(self):
        self.collapsingAll = True

    def getNodeData(self, node):
        if not node in self.data.keys():
            self.data[node] = self.NodeData(node)
        return self.data[node]

    def drawTreeNode(self, node):
        data = self.getNodeData(node)
        flags = imgui.TreeNodeFlags_.open_on_double_click | imgui.TreeNodeFlags_.open_on_arrow | imgui.TreeNodeFlags_.span_full_width
        if not data.has_children:
            flags |= imgui.TreeNodeFlags_.leaf
        if node in self.selection:
            flags |= imgui.TreeNodeFlags_.selected
        if node == self.active_node:
            self.active_node_was_drawn = True
            flags |= imgui.TreeNodeFlags_.selected
            if self.scroll_to_active == True and not imgui.is_item_visible(): # There seems to be a bug where the first hidden item is considered visible :/
                imgui.set_scroll_here_y(self.scrolling_coeff)
            
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
        if data.hidden:
            imgui.pop_style_color()
        if imgui.is_item_clicked():
            if imgui.get_io().key_shift:
                # did we click before or after the node?
                if self.active_node_was_drawn:
                    self.select_node_span(self.active_node, node)
                else:
                    self.select_node_span(node, self.active_node)
            else:
                if not imgui.get_io().key_ctrl:
                    pxz.scene.clearSelection()
                pxz.scene.select([node])
            self.active_node = node
        
        if data.isOpen:
            for child in data.children:
                self.drawTreeNode(child)
            imgui.tree_pop()
            

    def onSceneChanged(self, eventType, occurrence, child):
        self.deleteSubTreeData(occurrence)

    def onSelectionChanged(self, type, occurrences):
        self.selection = pxz.scene.getSelectedOccurrences()
        if len(self.selection) > 0:
            self.active_node = self.selection[0]
            self.reset_scrolling_coeff()
            self.scroll_to_active = True

    def expandTo(self, node):
        data = self.getNodeData(node)
        parent = data.parent
        if parent != 0:
            self.expandTo(parent)
        self.getNodeData(node).needExpand = True

    def findSelection(self):
        for node in self.selection:
            self.expandTo(node)
        self.reset_scrolling_coeff()
        self.scroll_to_active = True

    def deleteSubTreeData(self, node):
        if node in self.data.keys():
            for child in self.data[node].children:
                self.deleteSubTreeData(child)
            self.data.pop(node)

    # Navigation:

    def reset_scrolling_coeff(self):
        self.scrolling_coeff = 0.5
        
    def last_opened_child_recur(self, node):
        """Finds the last opened child of the last opened child etc. of a node"""
        data = self.getNodeData(node)
        if data.isOpen and data.has_children:
            return self.last_opened_child_recur(data.children[-1])
        return node
    
    def prev_node_in_tree(self, node):
        """Previous sibling or parent if there's no"""
        if node == self.root:
            return node
        data = self.getNodeData(node)
        parent_id = data.parent
        parent = self.getNodeData(parent_id)
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
        data = self.getNodeData(node)
        parent_id = data.parent
        parent = self.getNodeData(parent_id)
        siblings = parent.children
        for index, child in enumerate(siblings):
            if child == node:
                next_node_index = index + 1
                if next_node_index == len(siblings):
                    return self.next_sibling(parent_id)
                return siblings[next_node_index]
                
    def next_node_in_tree(self, node):
        """Next Occurrence in tree, counting its children if the node is open"""
        data = self.getNodeData(node)
        if data.isOpen and data.has_children:
            return data.children[0]
        next_occ = self.next_sibling(node)
        if next_occ > 0:
            return next_occ
        return node
    
    def select_node_span(self, beg, end):
        """`beg` *must* be before `end` in the node tree"""
        selection = []
        while beg != end:
            selection.append(beg)
            beg = self.next_node_in_tree(beg)
        selection.append(end)

        # Select multiple spans : click, shift click somewhere to create a span, ctrl click somewhere, ctrl shift click somewhere else boom you have two spans
        if not imgui.get_io().key_ctrl:
            pxz.scene.clearSelection()
        pxz.scene.select(selection)
        self.active_node = end
