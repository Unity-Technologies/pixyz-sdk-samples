from imgui_bundle import imgui

class Windows:
    def __init__(self, shortcuts):
        self.nameToWindow = {}
        self.shortcuts = shortcuts
        self.shortcutNames = {}

    def addWindow(self, window):
        # adding window
        self.nameToWindow[window.name] = window
        # sorting names alphabetically
        tmpDict = self.nameToWindow
        sortedKeys = sorted(list(self.nameToWindow.keys()))
        self.nameToWindow = {i: tmpDict[i] for i in sortedKeys}
        # assigning hotkey
        self.shortcutNames[window.name] = self.shortcuts.getAvailableHotkey(window.name, ctrl=True, shift=True)
        self.shortcuts.addShortcutCtrlShift(self.shortcutNames[window.name], window.toggle)

    def removeWindow(self, window):
        self.nameToWindow.pop(window.name)
        self.shortcutNames.pop(window.name)

    def draw(self):
        if imgui.begin_menu("Windows", True):
            for name, window in self.nameToWindow.items():
                clicked, selected = imgui.menu_item(name, 'Ctrl+Shift+'+self.shortcutNames[name].upper(), window.isEnabled())
                if clicked:
                    window.toggle()
            imgui.end_menu()
