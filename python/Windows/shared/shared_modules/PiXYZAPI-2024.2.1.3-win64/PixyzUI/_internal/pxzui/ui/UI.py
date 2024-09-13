import pxz

from pxzui.ui.ProcessQueue import ProcessQueue
from pxzui.ui.Shortcuts import Shortcuts
from pxzui.ui.Variants import Variants
from pxzui.ui.animations.AnimationLibrary import AnimationLibrary
from pxzui.ui.animations.AnimationPlayer import AnimationPlayer
from pxzui.ui.functions.FunctionLibrary import FunctionLibrary
from pxzui.ui.functions.FunctionBrowser import FunctionBrowser
from pxzui.ui.functions.FunctionDialog import FunctionDialog
from pxzui.ui.ProgressBar import *
from pxzui.ui.Statistics import *
from pxzui.ui.CommandPalette import *
from pxzui.ui.Visualization import *
from pxzui.ui.History import *
from pxzui.ui.SceneTree import *
from pxzui.ui.Inspector import *
from pxzui.ui.functions.Scripting import Scripting
from pxzui.ui.materials.MaterialBrowser import MaterialBrowser
from pxzui.ui.materials.TextureLibrary import TextureLibrary
from pxzui.ui.materials.TextureList import TextureList
from pxzui.ui.materials.UVViewer import UVViewer
from pxzui.ui.menus.MainMenu import *
import json
import os

from pxzui.ui.menus.Windows import Windows

import importlib
import pkgutil
from imgui_bundle import hello_imgui

def iter_namespace(ns_pkg):
    return pkgutil.iter_modules(ns_pkg.__path__, ns_pkg.__name__ + ".")

class UI:
    def __init__(self, window):
        self.processQueue = ProcessQueue(self)
        self.shortcuts = Shortcuts()
        self.theme = hello_imgui.ImGuiTheme_.darcula_darker
        hello_imgui.apply_theme(self.theme)
        self.opacity = 1
        imgui.get_style().alpha = self.opacity
        self.uiWindows = []
        self.windows = Windows(self.shortcuts)
        self.window = window
        self.dockSpaceID = None
        imgui.get_io().config_flags = imgui.ConfigFlags_.docking_enable
        # libraries
        self.animationLibrary = AnimationLibrary(self)
        self.textureLibrary = TextureLibrary(self)
        self.functionLibrary = FunctionLibrary(self)
        # unique windows
        self.progressBar = ProgressBar(self)
        self.functionBrowser = FunctionBrowser(self)
        self.functionDialog = FunctionDialog(self)
        self.output = self.addWindow(self.window.output)
        self.scripting = Scripting(self)
        self.commandPalette = CommandPalette(self)
        self.mainMenu = MainMenu(self)
        # ui windows
        self.animationPlayer = self.createAndAddWindow(AnimationPlayer, self)
        self.history = self.createAndAddWindow(History, self)
        self.inspector = self.createAndAddWindow(Inspector, self)
        if not pxz.is_remote():
            self.materialBrowser = self.createAndAddWindow(MaterialBrowser, self)
        self.propertyWindow = self.createAndAddWindow(PropertyWindow, self)
        self.statistics = self.createAndAddWindow(Statistics, self)
        self.textureList = self.createAndAddWindow(TextureList, self)
        self.tree = self.createAndAddWindow(SceneTree, self)
        self.uvViewer = self.createAndAddWindow(UVViewer, self)
        self.variants = self.createAndAddWindow(Variants, self)
        self.visualization = self.createAndAddWindow(Visualization, self, window.viewer, window.gizmo)
        self.MaxRecentFiles = 5
        self.recentFilesList = []        
        self.firstDraw = True
        self.loadPlugins()
        try:
            self.restoreConfig()
        except:
            pass

    def loadPlugins(self):
        try:
            import pxzui.ui.plugins
        except ModuleNotFoundError:
            # no plugins
            return

        plugins = {
            name: importlib.import_module(name)
            for finder, name, ispkg
            in iter_namespace(pxzui.ui.plugins)
        }
        for plugin in plugins.keys():
            print("Initializing plugin : " + str(plugin))
            plugins[plugin].pluginInit(self)

    def draw(self):
        # refreshing textures before UI draw call to keep glTextures up to date (needs to be done on main thread)
        self.textureLibrary.updateIfNeeded()

        # draw UI
        dockspace_flags = imgui.DockNodeFlags_.passthru_central_node | imgui.DockNodeFlags_.no_docking_over_central_node
        self.dockSpaceID = imgui.dock_space_over_viewport(imgui.get_main_viewport(), dockspace_flags)
        for win in self.uiWindows:
            win.drawBase()
        self.functionBrowser.draw()
        self.functionDialog.draw()
        self.scripting.draw()
        self.progressBar.draw()
        self.mainMenu.draw()
        if self.firstDraw:
            self.firstDraw = False
            # set layout ini file path after first draw to let imgui read the default .ini the first time
            imgui.get_io().set_ini_filename(os.getenv('APPDATA') + "/PixyzSDK/UILayout.ini")
            for win in self.uiWindows:
                win.restoreFocus()
        # draw the shortcuts always last as they might be disabled by other windows
        self.shortcuts.draw()

    def isOver(self):
        return imgui.get_io().want_capture_mouse

    def configFilePath():
        return os.getenv("APPDATA") + os.sep + "PixyzSDK" + os.sep + "UIConfig.json"

    def layoutFilePath():
        return os.getenv('APPDATA') + os.sep + "PixyzSDK" + os.sep + "UILayout.ini"

    def defaultLayoutFilePath():
        return os.path.dirname(os.path.realpath(__file__)) + os.sep + "default.ini"

    def restoreConfig(self):
        iniPath = UI.layoutFilePath()
        if os.path.isfile(iniPath):
            print("Loading user layout : " + iniPath)
            imgui.get_io().set_ini_filename(iniPath)
        else:
            # Load the default layout the first time
            defaultLayout = UI.defaultLayoutFilePath()
            print("Using default layout : " + defaultLayout)
            imgui.get_io().set_ini_filename(defaultLayout)

        if not os.path.isfile(UI.configFilePath()):
            return
        print("Loading user preferences : " + UI.configFilePath())
        configFile = open(UI.configFilePath(), 'r')
        config = json.loads(configFile.read())
        # Window config is read before window initialization
        #if "Window" in config.keys():
        #    self.window.restoreConfig(config["Window"])
        if "Theme" in config.keys():
            self.theme = hello_imgui.ImGuiTheme_(config["Theme"])
            hello_imgui.apply_theme(self.theme)
        if "Opacity" in config.keys():
            self.opacity = config["Opacity"]
        if "Modules" in config.keys():
            self.propertyWindow.restoreModulesConfig(config["Modules"])
        if "Visualization" in config.keys():
            self.visualization.restoreConfig(config["Visualization"])
        self.recentFilesList = config["RecentFilesList"] if "RecentFilesList" in config else []
        if "FunctionBrowser" in config.keys():
            self.functionBrowser.restoreConfig(config["FunctionBrowser"])
        if "Scripting" in config.keys() and config["Scripting"] is not None:
            self.scripting.restoreConfig(config["Scripting"])
        if "CustomMenus" in config.keys() and config["CustomMenus"] is not None:
            self.mainMenu.customMenus.restoreConfig(config["CustomMenus"])
        for window in self.uiWindows:
            if window.name in config.keys():
                window.restoreConfig(config[window.name])
        imgui.get_style().alpha = self.opacity
        configFile.close()

    def saveConfig(self):
        # Compute config values
        config = {}
        config["Window"] = self.window.saveConfig()
        config["Theme"] = int(self.theme)
        config["Opacity"] = float(self.opacity)
        config["Visualization"] = self.visualization.saveConfig()
        config["Modules"] = self.propertyWindow.saveModulesConfig()
        config["Visualization"] = self.visualization.saveConfig()
        config["RecentFilesList"] = self.recentFilesList[0:self.MaxRecentFiles]
        config["FunctionBrowser"] = self.functionBrowser.saveConfig()
        config["Scripting"] = self.scripting.saveConfig()
        config["CustomMenus"] = self.mainMenu.customMenus.saveConfig()
        for window in self.uiWindows:
            config[window.name] = window.saveConfig()
        print("Saving preferences in " + UI.configFilePath())
        configFile = open(UI.configFilePath(), 'w')
        configFile.write(json.dumps(config, indent=4))
        configFile.close()

    def taskFinished(self):
        self.statistics.updateOnNextFrame()
        self.progressBar.taskFinished()

    def addRecentPaths(self, paths):
        for path in paths:
            self.recentFilesList.insert(0, path)
        self.recentFilesList = list(dict.fromkeys(self.recentFilesList)) # removing duplicates
        self.recentFilesList = self.recentFilesList[0:self.MaxRecentFiles] # remembering only x last

    def afterResetSession(self):        
        # recreate visualization panel since the viewer has changed
        config = self.visualization.saveConfig()
        self.removeWindow(self.visualization)
        self.visualization = self.createAndAddWindow(Visualization, self, self.window.viewer, self.window.gizmo)
        self.visualization.restoreConfig(config)
        # recreate tree
        self.removeWindow(self.tree)
        self.tree = self.createAndAddWindow(SceneTree, self)
        self.history.updateStack()

        self.variants.afterResetSession()

    def createAndAddWindow(self, className, *args, **kwargs):
        instance = className(*args, **kwargs)
        self.uiWindows.append(instance)
        self.windows.addWindow(instance)
        return instance

    def addWindow(self, window):
        self.uiWindows.append(window)
        self.windows.addWindow(window)
        return window

    def removeWindow(self, window):
        self.uiWindows.remove(window)
        self.windows.removeWindow(window)
