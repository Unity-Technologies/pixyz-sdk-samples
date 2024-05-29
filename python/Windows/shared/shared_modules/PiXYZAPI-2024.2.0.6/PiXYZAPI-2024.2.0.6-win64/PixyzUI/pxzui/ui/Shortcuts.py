from imgui_bundle import imgui

class Shortcuts:
    def __init__(self):
        self._shortcuts = {}
        self._shortcutsShift = {}
        self._shortcutsCtrl = {}
        self._shortcutsCtrlShift = {}
        # list of alphabet characters to avoid duplicate shortcuts
        self._allKeys = list(map(chr, range(97, 123))) + ['delete']
        self._active = True
        self._skipBasicThisFrame = False

    def addShortcut(self, key, func):
        if key.lower() in self._shortcuts:
            raise Exception("Shortcut " + key + " already exists")
        self._shortcuts[key] = func

    def addShortcutShift(self, key, func):
        if key.lower() in self._shortcutsShift:
            raise Exception("Shortcut Shift+" + key + " already exists")
        self._shortcutsShift[key] = func

    def addShortcutCtrl(self, key, func):
        if key.lower() in self._shortcutsCtrl:
            raise Exception("Shortcut Ctrl+" + key + " already exists")
        self._shortcutsCtrl[key] = func

    def addShortcutCtrlShift(self, key, func):
        if key.lower() in self._shortcutsCtrlShift:
            raise Exception("Shortcut Ctrl+Shift+" + key + " already exists")
        self._shortcutsCtrlShift[key] = func

    def draw(self):
        if not self._active:
            return
        io = imgui.get_io()
        if io.key_ctrl and io.key_shift:
            for key in self._shortcutsCtrlShift:
                if imgui.is_key_pressed(eval("imgui.Key." + str(key)), False):
                    self._shortcutsCtrlShift[key]()
        elif io.key_ctrl:
            for key in self._shortcutsCtrl:
                if imgui.is_key_pressed(eval("imgui.Key." + str(key)), False):
                    self._shortcutsCtrl[key]()
        # all following shortcuts can be disabled for a frame (e.g. when typing in a text editor)
        elif self._skipBasicThisFrame:
            self._skipBasicThisFrame = False
            return
        elif io.key_shift:
            for key in self._shortcutsShift:
                if imgui.is_key_pressed(eval("imgui.Key." + str(key)), False):
                    self._shortcutsShift[key]()
        else:
            for key in self._shortcuts:
                if imgui.is_key_pressed(eval("imgui.Key." + str(key)), False):
                    self._shortcuts[key]()

    def getAvailableHotkey(self, name, ctrl=False, shift=False):
        # removing whitespace
        name = "".join(name.split())
        # retrieving correct dict
        if ctrl and shift:
            dictToCheck = self._shortcutsCtrlShift
        elif ctrl:
            dictToCheck = self._shortcutsCtrl
        elif shift:
            dictToCheck = self._shortcutsShift
        else:
            dictToCheck = self._shortcuts
        # search for something that resembles the name
        for n in name.lower():
            if n not in dictToCheck:
                return n
        # if not found, get first available from alphabet
        for n in self._allKeys:
            if n not in dictToCheck:
                return n
        # no hotkeys left
        raise Exception("No available hotkey")

    def skipBasicThisFrame(self):
        self._skipBasicThisFrame = True

    def enable(self):
        self._active = True

    def disable(self):
        self._active = False

