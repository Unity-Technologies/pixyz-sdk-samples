import ctypes
import math
import platform
import sys
import traceback
from enum import IntEnum

import glfw
from PIL import Image

from pxzui.ui.UI import *
from pxzui.ui.Fonts import Fonts
from pxzui.viewer.Gizmos import Gizmo


def initialize_dedicated_graphics():
    """force program to be executed on discrete GPU in case of a dual integrated/discrete architecture
    """
    try:
        if platform.architecture()[0] == "64bit":
            nvapi = ctypes.WinDLL("nvapi64.dll")
        else:
            nvapi = ctypes.WinDLL("nvapi.dll")

        nvapi.fake()  # Call the 'fake' entry point
    except:
        pass  # Ignore any exceptions since the 'fake' entry point doesn't exist


class Window:
    PROJECT_PATH = os.path.dirname(__file__)

    class InputAction(IntEnum):
        NONE = 0
        ROTATE = 1
        ZOOM = 2
        PAN = 3
        SELECT = 4
        SELECT_IN_DEPTH = 5

    def __init__(self, width=1200, height=800):

        initialize_dedicated_graphics()

        self.width = width
        self.height = height
        self.position = None
        self.maximized = False
        self.drawUI = False

        self.restoreConfig()

        print("Initializing glfw")
        glfw.unitycloud_init()
        glfw.window_hint(glfw.CONTEXT_VERSION_MAJOR, 4)
        glfw.window_hint(glfw.CONTEXT_VERSION_MINOR, 0)
        glfw.window_hint(glfw.OPENGL_DEBUG_CONTEXT, True)
        glfw.window_hint(glfw.MAXIMIZED, self.maximized)

        self.monitor = None
        # save font scales for all branched monitors to use them later in imgui context
        monitorContentScalings = []
        for monitor in glfw.get_monitors():
            scaleFactor = 1.0
            xScale, yScale = glfw.get_monitor_content_scale(monitor=monitor)
            if xScale > 1 or yScale > 1:
                scaleFactor = xScale
                #glfw.window_hint(glfw.SCALE_TO_MONITOR, glfw.TRUE);
            monitorContentScalings.append([glfw.get_monitor_name(monitor), scaleFactor])

        self.glfwWindow = glfw.create_window(self.width, self.height, "Pixyz UI v" + pxz.core.getVersion(), None, None)
        if self.position != None:
            glfw.set_window_pos(self.glfwWindow, self.position[0], self.position[1])
        with Image.open(os.path.join(os.path.dirname(__file__), "assets/icons/icon.ico")) as image:
            glfw.set_window_icon(self.glfwWindow, 1, image)
        glfw.set_window_user_pointer(self.glfwWindow, self)
        glfw.make_context_current(self.glfwWindow)
        self.initCallbacks()

        print("Initializing ImGUI")
        imgui.create_context()
        window_address = ctypes.cast(self.glfwWindow, ctypes.c_void_p).value
        imgui.backends.glfw_init_for_open_gl(window_address, True)
        imgui.backends.opengl3_init("#version 330")

        # create fonts (self.currentFont will be automatically set in the renderLoop)
        Fonts.initialize(self.PROJECT_PATH, monitorContentScalings)

        # set style
        self.styleScale = 1.0

        print("Initializing Pixyz Engine Vulkan Viewer")
        self.viewer = Viewer(self.width, self.height, glfw.get_wgl_context(self.glfwWindow))
        self.viewer.camera.fit(scene.getSelectedOccurrences())  # in case we open it with a model already loaded

        self.powerSaving = False
        self.idleFPS = 10
        self.startFrameTime = glfw.get_time()
        self.lastxpos = self.lastypos = 0
        self.currentAction = self.InputAction.NONE

        print("Initializing UI")
        self.gizmo = Gizmo(self)
        self.ui = UI(self)
        self.ui.progressBar.taskFinished()


    def initCallbacks(self):
        # Init callbacks
        glfw.set_window_size_callback(self.glfwWindow, self.whenSizeChanged)
        glfw.set_drop_callback(self.glfwWindow, self.whenFilesDropped)
        glfw.set_mouse_button_callback(self.glfwWindow, self.mouseButtonEvent)
        glfw.set_cursor_pos_callback(self.glfwWindow, self.cursorPosEvent)
        glfw.set_key_callback(self.glfwWindow, self.keyEvent)
        glfw.set_scroll_callback(self.glfwWindow, self.scrollEvent)

    def renderLoop(self):
        print("Starting render loop")

        while not glfw.window_should_close(self.glfwWindow):
            try:
                # Poll events
                self.hasEvents = False
                glfw.poll_events()

                # Limit FPS in powersaving mode
                if self.powerSaving and not self.hasEvents and (glfw.get_time()-self.startFrameTime) < (1./self.idleFPS):
                    continue

                self.startFrameTime = glfw.get_time()

                glfw.make_context_current(self.glfwWindow)

                # Clear background
                glClearColor(0, 0, 0, 1)
                glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT)

                # Draw Pixyz Viewer
                self.viewer.refresh()
                glfw.make_context_current(self.glfwWindow) # restore openGL context
                self.viewer.draw()

                # Draw UI overlay
                imgui.backends.opengl3_new_frame()
                imgui.backends.glfw_new_frame()
                imgui.new_frame()

                # Adapt to dpi scaling of current monitor if changed
                monitor = self.getMonitorForWindow(self.glfwWindow)
                if monitor and glfw.get_monitor_name(monitor) != glfw.get_monitor_name(self.monitor):
                    monitor_name = glfw.get_monitor_name(monitor)
                    print(f"Switching to monitor {monitor_name}")
                    self.monitor = monitor
                    self.currentFont = Fonts.get_regular(monitor_name)
                    self.currentFontMono = Fonts.get_mono(monitor_name)

                imgui.push_font(self.currentFont)

                if self.drawUI:
                    self.ui.draw()
                else:
                    windowFlags = imgui.WindowFlags_.no_title_bar | imgui.WindowFlags_.always_auto_resize | imgui.WindowFlags_.no_nav | imgui.WindowFlags_.no_background | imgui.WindowFlags_.no_mouse_inputs | imgui.WindowFlags_.no_bring_to_front_on_focus
                    hintText = "Press F2 to toggle UI display"
                    hintHeight = imgui.calc_text_size(hintText)[1]
                    hintHeight += imgui.get_frame_height()
                    imgui.set_next_window_pos(ImVec2(5, self.viewer.height - hintHeight))
                    imgui.begin("Text", True, windowFlags)
                    imgui.push_style_color(imgui.Col_.text, imgui.ImVec4(0,0,0,1))
                    imgui.text(hintText)
                    imgui.pop_style_color()
                    imgui.end()

                # Draw selection rectangle (Overlay)
                if self.currentAction == self.InputAction.SELECT or self.currentAction == self.InputAction.SELECT_IN_DEPTH:
                    xmin = min(self.lastxpos, self.selectionStartCorner[0])
                    xmax = max(self.lastxpos, self.selectionStartCorner[0])
                    ymin = min(self.lastypos, self.selectionStartCorner[1])
                    ymax = max(self.lastypos, self.selectionStartCorner[1])
                    imgui.get_background_draw_list().add_rect_filled(ImVec2(xmin, ymin), ImVec2(xmax, ymax), 0x11FF0000)
                    imgui.get_background_draw_list().add_rect(ImVec2(xmin, ymin), ImVec2(xmax, ymax), 0xFF888888)

                self.gizmo.draw()

                imgui.pop_font()

                imgui.render()
                imgui.end_frame()
                imgui.backends.opengl3_render_draw_data(imgui.get_draw_data())

                glfw.swap_buffers(self.glfwWindow)

            except Exception as e:
                print("Exception : " + str(e))
                traceback.print_exc(file=sys.stdout)
                break
        self.onClose()

    def whenSizeChanged(self, window, width, height):
        glViewport(0, 0, width, height)
        self.viewer.resize(width, height)
        self.width = width
        self.height = height

    def importFiles(self, paths):
        pxz.io.importFiles(paths)
        self.viewer.camera.fit([scene.getRoot()])
        self.ui.addRecentPaths(paths)
        # Needs to be called as the property "ViewIsSet" is not updated on addVariantChangedCallback, but afterward
        self.ui.variants.updateVariantProperties()

    def importImage(self, path):
        pxz.material.importImage(path)

    def whenFilesDropped(self, pathCount, paths):
        self.ui.processQueue.enqueue(self.importFiles, paths)

    def cursorPosEvent(self, window, xpos, ypos):
        if self.ui.isOver():
            return
        # TODO : find a way to really catch imgui events which need full performances
        # Without this condition, in powersave mode, each mouse move will force full performance refresh
        if (self.currentAction != self.InputAction.NONE) or glfw.get_mouse_button(self.glfwWindow, 0):
           self.hasEvents = True
        relX = float(xpos - self.lastxpos) / float(self.viewer.width)
        relY = float(ypos - self.lastypos) / float(self.viewer.height)
        self.lastxpos = xpos
        self.lastypos = ypos
        if self.currentAction == self.InputAction.ROTATE:
            self.viewer.camera.rotate(relX * 2. * math.pi, relY * 2. * math.pi)
        elif self.currentAction == self.InputAction.ZOOM:
            factor = -relY
            if factor > 0:
                factor = 1. - factor
            else:
                factor = 1.0 / (1. + factor)
            self.viewer.camera.zoom(factor)
        elif self.currentAction == self.InputAction.PAN:
            panX = relX * 2.0 * math.tan(1.047 * 0.5) * self.viewer.camera.getDistance()
            panY = relY * 2.0 * math.tan(1.047 * 0.5) * self.viewer.camera.getDistance()
            self.viewer.camera.pan(-panX, panY)

    def keyEvent(self, window, key, scancode, action, mod):
        self.hasEvents = True
        if key == glfw.KEY_F2 and action == glfw.RELEASE:
            self.drawUI = not self.drawUI

    def mouseButtonEvent(self, window, button, action, mods):
        if self.ui.isOver():
            return
        self.hasEvents = True
        if action == glfw.PRESS:
            if self.currentAction != self.InputAction.NONE:
                return
            if button == glfw.MOUSE_BUTTON_LEFT and (mods & glfw.MOD_ALT):
                self.currentAction = self.InputAction.ROTATE
            elif button == glfw.MOUSE_BUTTON_MIDDLE and (mods & glfw.MOD_ALT):
                self.currentAction = self.InputAction.PAN
            elif button == glfw.MOUSE_BUTTON_RIGHT and (mods & glfw.MOD_ALT):
                self.currentAction = self.InputAction.ZOOM
            elif button == glfw.MOUSE_BUTTON_LEFT or button == glfw.MOUSE_BUTTON_RIGHT:
                if not imguizmo.im_guizmo.is_over() and not self.ui.isOver():
                    self.currentAction = self.InputAction.SELECT if button == glfw.MOUSE_BUTTON_LEFT else self.InputAction.SELECT_IN_DEPTH
                    self.selectionStartCorner = int(self.lastxpos), int(self.lastypos)
        elif action == glfw.RELEASE:
            if button == glfw.MOUSE_BUTTON_MIDDLE and (self.currentAction == self.InputAction.NONE):
                self.viewer.pick(int(self.lastxpos), int(self.lastypos))
            elif (self.currentAction == self.InputAction.SELECT or self.currentAction == self.InputAction.SELECT_IN_DEPTH):
                if not imgui.get_io().key_ctrl:
                    pxz.scene.clearSelection()
                if self.selectionStartCorner[0] != int(self.lastxpos) and self.selectionStartCorner[1] != int(self.lastypos):
                    xmin = min(int(self.lastxpos), self.selectionStartCorner[0])
                    xmax = max(int(self.lastxpos), self.selectionStartCorner[0])
                    ymin = min(self.viewer.height - int(self.lastypos), self.viewer.height - self.selectionStartCorner[1])
                    ymax = max(self.viewer.height - int(self.lastypos), self.viewer.height - self.selectionStartCorner[1])
                    pxz.scene.select(pxz.view.pickRectangle(xmin, xmax, ymin, ymax, self.viewer.viewer, self.currentAction == self.InputAction.SELECT_IN_DEPTH))
                    #pxz.view.selectPrimitives(xmin, xmax, ymin, ymax, self.viewer.viewer)
                else:
                    pickReturn = pxz.view.pick(int(self.lastxpos), self.viewer.height - int(self.lastypos), self.viewer.viewer)
                    if pickReturn["occurrence"] != 0:
                        pxz.scene.select([pickReturn["occurrence"]])
            self.currentAction = self.InputAction.NONE

    def scrollEvent(self, window, x_offset, y_offset):
        self.hasEvents = True
        if not self.ui.isOver():
            factor = 1 - (y_offset / 10.)
            self.viewer.camera.zoom(factor)

    def onClose(self):
        self.ui.saveConfig()
        imgui.backends.opengl3_shutdown()
        imgui.backends.glfw_shutdown()
        imgui.destroy_context()
        glfw.destroy_window(self.glfwWindow)
        glfw.terminate()
        self.viewer.__del__() # to force stream thread kill if any

    def afterResetSession(self):
        # recreate viewer
        self.viewer = Viewer(self.width, self.height, glfw.get_wgl_context(self.glfwWindow))
        self.gizmo = Gizmo(self)
        self.viewer.camera.fit()
        self.ui.afterResetSession()

    def saveConfig(self):
        config = {}
        config["DrawUI"] = self.drawUI
        config["Width"] = self.width if self.width > 0 else 1200
        config["Height"] = self.height if self.height > 0 else 800
        position = glfw.get_window_pos(self.glfwWindow)
        config["Position"] = position if position[0] > 0 and position[1] > 0 else [100, 100]
        config["Maxmimized"] = glfw.get_window_attrib(self.glfwWindow, glfw.MAXIMIZED)==1
        return config

    def restoreConfig(self):
        if not os.path.isfile(UI.configFilePath()):
            return
        config = json.loads(open(UI.configFilePath(), 'r').read())
        if not "Window" in config.keys():
            return
        config = config["Window"]
        if "DrawUI" in config.keys():
            self.drawUI = config["DrawUI"]
        if "Width" in config.keys():
            self.width = config["Width"]
        if "Height" in config.keys():
            self.height = config["Height"]
        if "Position" in config.keys():
            self.position = config["Position"]
        if "Maxmimized" in config.keys():
            self.maximized = config["Maxmimized"]

    def open(self):
        self.renderLoop()
        #thread = threading.Thread(target=self.renderLoop)
        #thread.start()
        #thread.join()

    def getMonitorForWindow(self, window):
        xPos, yPos = glfw.get_window_pos(window)
        width, height = glfw.get_window_size(window)
        windowCenterX = xPos + width / 2
        windowCenterY = yPos + height / 2
        monitors = glfw.get_monitors()
        for monitor in monitors:
            # Get the monitor's position and size
            monitorX, monitorY = glfw.get_monitor_pos(monitor)
            videoMode = glfw.get_video_mode(monitor)
            monitorWidth = videoMode.size.width
            monitorHeight = videoMode.size.height
            # Calculate the bounds of the monitor
            monitorLeft = monitorX
            monitorRight = monitorX + monitorWidth
            monitorTop = monitorY
            monitorBottom = monitorY + monitorHeight
            # Check if the window's center is within the monitor's bounds
            if monitorLeft <= windowCenterX < monitorRight and \
                    monitorTop <= windowCenterY < monitorBottom:
                return monitor
        return None