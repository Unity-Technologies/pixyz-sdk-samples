import sys
import traceback

import numpy as np
import pxz

from pxzui.ui.ConfigOwner import ConfigOwner
from imgui_bundle import imgui, imgui_color_text_edit as ed, ImVec2

from pxzui.ui.functions.Autocompletion import Autocompletion

TextEditor = ed.TextEditor

class EditorTab():
    currentId = 0
    def __init__(self, scripting_window, text, autocompletion):
        self.scripting_window = scripting_window
        self.editor = self._prepare_text_editor(text)
        self.autocompleteTextCache = self._createAutocompleteTextCache()
        self.autocompletion = autocompletion
        self.id = EditorTab.currentId
        EditorTab.currentId += 1
        self.name = text.split("\n")[0] + "##" + str(self.id)
        self.open = True
        self.visible = True
        self.firstDraw = True

    def draw(self):
        focused = False
        changedSomething = False
        isDeleted = False
        # focusing new tabs without switching back after a tab name change (instead of imgui.TabBarFlags_.auto_select_new_tabs)
        flags = imgui.TabItemFlags_.set_selected if self.firstDraw else imgui.TabItemFlags_.none
        self.visible, self.open = imgui.begin_tab_item(self.name, self.open, flags)
        if self.visible:
            # update the autocomplete cache if something has changed
            if self.editor.is_text_changed():
                changedSomething = True
                self.autocompleteTextCache = self._createAutocompleteTextCache()
            # modify the editor text via autocomplete
            self._autocomplete()
            # draw the editor
            font = self.scripting_window.ui.window.currentFontMono #Monospaced font for the editor
            imgui.push_font(font)
            focused = self.editor.render(self.name)
            imgui.pop_font()
            if self.firstDraw:
                self.firstDraw = False
            imgui.end_tab_item()
        else:
            # set the script tab name to be the first line of the script
            self.name = self.editor.get_text().split("\n")[0] + "##" + str(self.id)
        if not self.open:
            self.editor.delete()
            isDeleted = True
            return focused, changedSomething, isDeleted
        return focused, changedSomething, isDeleted

    def _prepare_text_editor(self, text):
        editor = TextEditor()
        editor.set_text(text)
        editor.set_language_definition(TextEditor.LanguageDefinition.python())
        editor.set_show_whitespaces(self.scripting_window.show_whitespaces)
        return editor
    
    def _calculatePixelCursorPosition(self):
        # filler string for calculating the size of the text
        filler = "\n" * self.editor.get_cursor_position().m_line
        filler += self.editor.get_current_line_text()[0:self.editor.get_cursor_position().m_column]
        cursorPosition = imgui.calc_text_size(filler)
        cursorPosition += np.array([imgui.get_cursor_screen_pos().x, imgui.get_cursor_screen_pos().y])
        return cursorPosition

    def _getAutocompleteOpenClose(self):
        # popup conditions
        ctrlSpace = imgui.get_io().key_ctrl and imgui.is_key_pressed(imgui.Key.space)
        lineContainsNonWhitespaces = any(not char.isspace() for char in self.editor.get_current_line_text())
        clickedOutside = imgui.is_mouse_clicked(0) and not imgui.is_any_item_hovered()
        # comment detection
        # jedi seems to detect multi line comments and strings automatically, no need to consider them
        inComment = "#" in self._getCurrentLine()[:self.editor.get_cursor_position().m_column]
        # finishing characters
        finishingCharacters = ["(", ")", "[", "]", "{", "}", ",", ";", ":", "\"", "\'"]
        finishingCharacterAtCursor = self._getCurrentChar() in finishingCharacters
        # final conditions
        openPopup = lineContainsNonWhitespaces and (not self.firstDraw and self.editor.is_text_changed() or ctrlSpace)
        closePopup = not lineContainsNonWhitespaces or imgui.is_key_pressed(imgui.Key.escape) or clickedOutside or finishingCharacterAtCursor or inComment
        return openPopup, closePopup

    def _getAutocompleteCursorPos(self):
        # Return the cursor position in the editor, jedi uses 1-based indexing for lines and 0-based for columns.
        cursorPos = self.editor.get_cursor_position()
        cursorPos.m_line += 1
        return [cursorPos.m_line, cursorPos.m_column]

    def _autocomplete(self):
        openPopup, closePopup = self._getAutocompleteOpenClose()
        update = self.editor.is_text_changed()
        buttonsPressed, completion = self.autocompletion.complete("\n".join(self.autocompleteTextCache),
                                                                  update,
                                                                  openPopup,
                                                                  closePopup,
                                                                  self._getAutocompleteCursorPos(),
                                                                  self._calculatePixelCursorPosition())
        if buttonsPressed:
            # do not handle keyboard inputs from autocomplete in editor (e.g. enter, arrow keys)
            self.editor.set_handle_keyboard_inputs(False)
        else:
            self.editor.set_handle_keyboard_inputs(True)
        if completion["completion"]:
            replaceCondition = completion["replace"] and completion["completion"].complete != completion["completion"].name
            replaceCondition = replaceCondition or not completion["completion"].complete
            replaceCondition = replaceCondition and self._getCurrentChar().isalpha()
            if replaceCondition:
                # replace the word under the cursor with the completion
                self.editor.move_left(1, True, True)
                self.editor.delete()
                self.editor.insert_text(completion["completion"].name)
            elif completion["completion"].complete:
                self.editor.insert_text(completion["completion"].complete)
            else:
                self.editor.insert_text(completion["completion"].name)
            if completion["completion"].type.lower() in ["function", "class"]:
                # add parentheses after a function
                self.editor.insert_text("()")
                self.editor.move_left(1)
            self.autocompleteTextCache = self._createAutocompleteTextCache()

    def _createAutocompleteTextCache(self):
        # This is cached as a local to avoid string replacements on draw.
        # Jedi does not know our tab size, so we replace them with spaces to match the cursor position.
        cache = self.editor.get_text().replace("\t", self.editor.get_tab_size() * " ").split("\n")
        return cache

    def _getCurrentLine(self):
        return self.autocompleteTextCache[self.editor.get_cursor_position().m_line]

    def _getCurrentChar(self):
        if len(self.autocompleteTextCache[self.editor.get_cursor_position().m_line]) == 0:
            return ""
        else:
            return self.autocompleteTextCache[self.editor.get_cursor_position().m_line][self.editor.get_cursor_position().m_column - 1]


class Scripting(ConfigOwner):
    def __init__(self, ui):
        super().__init__()
        self.ui = ui
        self.show_whitespaces = False
        self.autocomplete = Autocompletion()
        self.setConfig("visible", False)
        self.editorTabs = [EditorTab(self, "# decimate\n\n_ret_ = pxz.algo.decimate(occurrences=[1],surfacicTolerance=1.0)\n",
                                     self.autocomplete)]
        self.activeScript = None
        self.addShortcuts()

    def draw(self):
        anyEditorFocused = False
        if self.getConfig("visible"):
            # We need this flag because otherwise the autocomplete will be drawn behind the scripting window.
            # However, this is not optimal as it will also prevent the scripting window from being brought to the front.
            # https://github.com/ocornut/imgui/issues/3693
            windowFlags = imgui.WindowFlags_.no_bring_to_front_on_focus
            _, visible = imgui.begin("Scripting", self.getConfig("visible"), windowFlags)
            self.setConfig("visible", visible)
            # button to run the script
            if not self.editorTabs:
                self.activeScript = None
            if self.activeScript is None:
                imgui.begin_disabled()
            if imgui.button("Execute Script (Ctrl+ENTER)", ImVec2(imgui.get_content_region_avail()[0], 0)):
                self.run()
            toggled_whitespaces, self.show_whitespaces = imgui.checkbox("Show whitespaces", self.show_whitespaces)
            if toggled_whitespaces:
                self.toggle_whitespaces()
            if self.activeScript is None:
                imgui.end_disabled()
            # draw editors
            toDelete = []
            tabBarFlags = imgui.TabBarFlags_.reorderable | imgui.TabBarFlags_.tab_list_popup_button | imgui.TabBarFlags_.fitting_policy_resize_down
            if imgui.begin_tab_bar("ScriptingTabBar", tabBarFlags):
                for editor in self.editorTabs:
                    editorFocused, editorChanged, isDeleted = editor.draw()
                    anyEditorFocused |= editorFocused
                    if isDeleted:
                        toDelete.append(editor)
                    if editor.visible:
                        self.activeScript = editor.editor.get_text()
                if imgui.tab_item_button("+", imgui.TabItemFlags_.trailing):
                    self.editorTabs.append(EditorTab(self, "# Script " + str(len(self.editorTabs) + 1) + "\n\n", self.autocomplete))
                imgui.end_tab_bar()
            # deleting here to avoid modifying the list while iterating
            for editor in toDelete:
                self.editorTabs.remove(editor)
            imgui.end()
        if anyEditorFocused:
            # don't fire shortcuts on text editor changes
            self.ui.shortcuts.skipBasicThisFrame()

    def saveConfig(self):
        # storing the text of each editor
        self.setConfig("scripts", [editorTab.editor.get_text() for editorTab in self.editorTabs])
        return super().saveConfig()

    def restoreConfig(self, config):
        super().restoreConfig(config)
        # restoring the text of each editor
        if self.hasConfig("scripts") and self.getConfig("scripts") is not None:
            self.editorTabs = [EditorTab(self, text, self.autocomplete) for text in self.getConfig("scripts")]

    def _runAsync(self, script, name):
        pxz.core.lockProcessing()
        try:
            print("\nRunning script : " + name)
            compiled_script = compile(script, filename=name, mode='exec')
            exec(compiled_script, {'pxz': pxz, 'ui': self.ui})
        except Exception as e:
            print("Exception : " + str(e))
            traceback.print_exc(file=sys.stdout)
        pxz.core.unlockProcessing()

    def run(self):
        self.ui.processQueue.enqueue(self._runAsync, self.activeScript, self.activeScript.split('\n')[0])

    def toggle(self):
        self.setConfig("visible", not self.getConfig("visible"))

    def addShortcuts(self):
        self.ui.shortcuts.addShortcutCtrl('enter', self.run)
        
    def toggle_whitespaces(self):
        for editor_tab in self.editorTabs:
            editor_tab.editor.set_show_whitespaces(self.show_whitespaces)
