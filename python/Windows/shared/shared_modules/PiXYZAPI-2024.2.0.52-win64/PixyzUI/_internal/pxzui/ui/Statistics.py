import threading

import pxz
import pynvml as pynvml
from imgui_bundle import imgui, ImVec2
import psutil
from pxzui.ui.WindowBase import WindowBase

class Statistics(WindowBase):
    def __init__(self, ui):
        windowFlags = imgui.WindowFlags_.no_title_bar | imgui.WindowFlags_.always_auto_resize | imgui.WindowFlags_.no_nav | imgui.WindowFlags_.no_background | imgui.WindowFlags_.no_mouse_inputs | imgui.WindowFlags_.no_bring_to_front_on_focus
        super().__init__(flags=windowFlags)
        self.enable()  # enable Statistics in default ui
        self.ui = ui
        pynvml.nvmlInit()
        self.gpuHandle = pynvml.nvmlDeviceGetHandleByIndex(0)  # Assuming a single GPU
        self.windowWidth = 235  # filler value, written on draw
        self._needUpdate = True
        self._lock = threading.Lock()

    def windowPosition(self):
        centralNode = imgui.internal.dock_builder_get_central_node(self.ui.dockSpaceID)
        imgui.set_next_window_pos(ImVec2(centralNode.pos.x + centralNode.size.x - self.windowWidth - 5, centralNode.pos.y + 5))

    def draw(self):
        self.updateIfNeeded()
        # black text for higher contrast
        imgui.push_style_color(imgui.Col_.text, imgui.ImColor(0, 0, 0).value)
        self.drawStatistics()
        imgui.pop_style_color()
        # save width to fit position in windowPosition()
        self.windowWidth = imgui.get_window_size().x

    def updateIfNeeded(self):
        with self._lock:
            if self._needUpdate:
                self._update()
                self._needUpdate = False

    def updateOnNextFrame(self):
        self._needUpdate = True

    def _update(self):
        self.stats = pxz.scene.getSubTreeStats([pxz.scene.getRoot()])
        # scene dimensions
        if self.stats['partOccurrenceCount'] > 0:
            aabb = pxz.scene.getAABB([1])
            self.sceneDimensions = [f"{aabb.high.x - aabb.low.x:.1f} mm", f"{aabb.high.y - aabb.low.y:.1f} mm", f"{aabb.high.z - aabb.low.z:.1f} mm"]
        else:
            self.sceneDimensions = ["0", "0", "0"]
        self.memoryUsage = psutil.virtual_memory().used / 1073741824  # (1024**3)
        self.memoryTotal = psutil.virtual_memory().total / 1073741824
        memInfo = pynvml.nvmlDeviceGetMemoryInfo(self.gpuHandle)
        self.vramUsage = memInfo.used / 1073741824  # (1024**3)
        self.totalVram = memInfo.total / 1073741824

    def drawStatistics(self):
        # label-value table
        if imgui.begin_table("StatisticsTable", 2):
            # FPS
            imgui.table_next_row()
            imgui.table_next_column()
            imgui.text("FPS")
            imgui.table_next_column()
            imgui.text(f"{imgui.get_io().framerate:.2f}")
            imgui.table_next_row()
            imgui.table_next_column()

            # RAM
            imgui.text("RAM")
            imgui.table_next_column()
            ram = f"{self.memoryUsage:05.2f} / {self.memoryTotal:.2f} GB"
            imgui.text(ram)
            imgui.table_next_row()
            imgui.table_next_column()
            # VRAM
            imgui.text("VRAM")
            imgui.table_next_column()
            vram = f"{self.vramUsage:05.2f} / {self.totalVram:.2f} GB"
            imgui.text(vram)
            imgui.table_next_row()
            imgui.table_next_column()
            # part occurrences
            imgui.text("PartOccurrences")
            imgui.table_next_column()
            imgui.text(str(self.stats['partOccurrenceCount']))
            imgui.table_next_row()
            imgui.table_next_column()
            # triangles
            imgui.text("Triangles")
            imgui.table_next_column()
            imgui.text(str(self.stats['triangleOccurrenceCount']))
            imgui.table_next_row()
            imgui.table_next_column()
            # lines
            imgui.text("Lines")
            imgui.table_next_column()
            imgui.text(str(self.stats['lineOccurrenceCount']))
            imgui.table_next_row()
            imgui.table_next_column()
            # points
            imgui.text("Points")
            imgui.table_next_column()
            imgui.text(str(self.stats['pointOccurrenceCount']))
            imgui.table_next_row()
            imgui.table_next_column()
            # scene dimensions
            imgui.text("Scene Dimensions")
            imgui.table_next_column()
            imgui.text("")
            imgui.table_next_row()
            imgui.table_next_column()
            imgui.text("X")
            imgui.table_next_column()
            imgui.text(self.sceneDimensions[0])
            imgui.table_next_row()
            imgui.table_next_column()
            imgui.text("Y")
            imgui.table_next_column()
            imgui.text(self.sceneDimensions[1])
            imgui.table_next_row()
            imgui.table_next_column()
            imgui.text("Z")
            imgui.table_next_column()
            imgui.text(self.sceneDimensions[2])
            imgui.table_next_row()
            imgui.table_next_column()
            # Current Variant
            if self.ui.variants.currentVariant is not None:
                # empty row
                imgui.table_next_row()
                imgui.text("")
                imgui.table_next_column()
                imgui.text("")
                imgui.table_next_row()
                imgui.table_next_column()
                imgui.text("Current Variant")
                imgui.table_next_row()
                imgui.table_next_column()
                imguiColor = imgui.ImColor(self.ui.variants.currentVariant.color[0], self.ui.variants.currentVariant.color[1], self.ui.variants.currentVariant.color[2]).value
                imgui.text_colored(imguiColor, "[" + str(self.ui.variants.currentVariant.id) + "] " + self.ui.variants.currentVariant.name)
            #
            imgui.end_table()
