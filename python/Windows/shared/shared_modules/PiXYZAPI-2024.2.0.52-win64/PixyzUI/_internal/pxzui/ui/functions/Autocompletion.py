
import jedi
import pxz
from imgui_bundle import imgui, ImVec2

from pxzui.utils.EmVec2 import EmVec2


class Autocompletion:
    def __init__(self):
        self.selectedIndex = 0
        self.completions = None
        self.fuzzySearch = True
        self.update = False
        self.open = False

    def complete(self, source, update, openPopup, closePopup, cursorPosition, position):
        buttonsPressed = False
        completion = {"replace": False, "completion": None}
        # generating completions with jedi
        if update or self.update:
            interpreter = jedi.Interpreter(source, namespaces=[{"pxz": pxz}])
            self.completions = interpreter.complete(cursorPosition[0], cursorPosition[1], fuzzy=self.fuzzySearch)
        # drawing popup
        closePopup = closePopup or not self.completions
        popupMaxSize = EmVec2(42, 12)
        popupWidth = min(popupMaxSize.x, imgui.get_window_width())
        popupHeight = min(popupMaxSize.y, imgui.get_window_height())
        # open popup if not already open
        if not self.open and openPopup and not closePopup:
            # position popup below the cursor
            if position[1] + popupHeight > imgui.get_io().display_size.y:
                # if the popup would be outside the window, position it above the cursor
                position[1] = position[1] - (popupHeight + imgui.get_text_line_height_with_spacing() + 2 * imgui.get_style().item_spacing.y)
            imgui.set_next_window_pos(position)
            imgui.open_popup("##autocompletion popup", imgui.WindowFlags_.no_focus_on_appearing)
            self.open = True
        if imgui.begin_popup("##autocompletion popup", imgui.WindowFlags_.no_focus_on_appearing):
            # sometimes we want to close the popup from outside (e.g. on new line)
            if closePopup:
                imgui.close_current_popup()
                self.selectedIndex = None
                self.open = False
                imgui.end_popup()
                return buttonsPressed, completion
            if imgui.begin_child("##autocompletion popup child", size=ImVec2(popupWidth, popupHeight)):
                # fill child with list of completions, but leave space for the info text below
                listHeight = popupHeight - imgui.get_text_line_height_with_spacing() - 2 * imgui.get_style().item_spacing.y
                if imgui.begin_list_box("##autocompletion popup child", ImVec2(imgui.get_content_region_avail()[0], listHeight)):
                    if self.selectedIndex is None:
                        self.selectedIndex = 0
                    buttonsPressed = self._keyboardNavigation(self.completions)
                    # list completions
                    for index, c in enumerate(self.completions):
                        isSelected = index == self.selectedIndex
                        imgui.push_id(str(index))
                        _, selected = imgui.selectable(c.name, isSelected)
                        # scroll to selection
                        if isSelected and buttonsPressed and not imgui.is_item_visible() and len(self.completions) > 1:
                            imgui.set_scroll_here_y(index / (len(self.completions) - 1))
                        # tooltip
                        if imgui.is_item_hovered():
                            imgui.set_tooltip(c.description)
                        imgui.pop_id()
                        # close popup and return completion
                        if imgui.is_item_clicked() or (isSelected and (imgui.is_key_pressed(imgui.Key.enter) or imgui.is_key_pressed(imgui.Key.tab))):
                            # replace with tab, insert with enter
                            buttonsPressed = True
                            completion["completion"] = c
                            completion["replace"] = imgui.is_key_pressed(imgui.Key.tab)
                            self.open = False
                            imgui.close_current_popup()
                    imgui.end_list_box()
                imgui.text("Press Enter to insert, Tab to replace")
                self.drawFuzzySearchCheckbox()
                imgui.end_child()
            imgui.end_popup()
        else:
            self.selectedIndex = None
        return buttonsPressed, completion

    def _keyboardNavigation(self, completions):
        if not completions:
            return False
        # navigate with arrow keys
        if imgui.is_key_pressed(imgui.Key.down_arrow):
            if self.selectedIndex is None:
                self.selectedIndex = 0
            else:
                self.selectedIndex = (self.selectedIndex + 1) % len(completions)
            return True
        elif imgui.is_key_pressed(imgui.Key.up_arrow):
            if self.selectedIndex is None:
                self.selectedIndex = len(completions) - 1
            else:
                self.selectedIndex = (self.selectedIndex - 1) % len(completions)
            return True
        return False

    def drawFuzzySearchCheckbox(self):
        label = "Fuzzy search"
        # draw right-aligned checkbox with label
        spacing = imgui.get_content_region_avail()[0]
        spacing -= imgui.calc_text_size(label)[0]
        spacing -= imgui.get_style().item_spacing.x
        spacing -= imgui.get_frame_height()
        imgui.same_line(spacing)
        imgui.text(label)
        imgui.same_line()
        fuzzyChanged, self.fuzzySearch = imgui.checkbox("##fuzzy search checkbox", self.fuzzySearch)
        if fuzzyChanged:
            self.update = True

