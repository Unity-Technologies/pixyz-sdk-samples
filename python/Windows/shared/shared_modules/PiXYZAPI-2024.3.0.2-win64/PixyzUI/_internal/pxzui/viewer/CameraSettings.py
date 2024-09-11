import pxz

from pxzui.ui.WindowBase import WindowBase
from imgui_bundle import imgui, ImVec2
import numpy as np

class CameraSettings():
    def __init__(self, ui):
        self.ui = ui
        self.camera = ui.window.viewer.camera

    def draw(self):
        imgui.set_next_item_width(imgui.get_content_region_avail()[0])
        imgui.begin_table("CameraSettingsTable", 2)
        imgui.table_next_row()
        imgui.table_next_column()
        imgui.text("Orthographic")
        imgui.table_next_column()
        orthographicChanged, orthographicValue = imgui.checkbox("##OrthographicCheckbox", self.camera.isOrthographic())
        if orthographicChanged:
            self.camera.setOrthographic(orthographicValue)
        # Orthographic
        if orthographicValue:
            imgui.table_next_row()
            imgui.table_next_column()
            imgui.text("Orthographic Size")
            imgui.table_next_column()
            imgui.set_next_item_width(imgui.get_content_region_avail()[0])
            orthographicSizeChanged, orthographicSizeValue = imgui.drag_float("##OrthographicSizeSlider", self.camera.getOrthographicSize(), v_speed=1, v_min=0.001, v_max=1000000.)
            if orthographicSizeChanged:
                self.camera.setOrthographicSize(orthographicSizeValue)
        # Perspective
        else:
            imgui.table_next_row()
            imgui.table_next_column()
            imgui.text("Horizontal FOV [°]")
            imgui.table_next_column()
            imgui.set_next_item_width(imgui.get_content_region_avail()[0])
            horizontalFovChanged, horizontalFovValue = imgui.drag_float("##HorizontalFovSlider", self.camera.getFovX(), v_speed=1, v_min=0.001, v_max=180.)
            if horizontalFovChanged:
                self.camera.setFovX(horizontalFovValue)
        # clipping planes
        imgui.table_next_row()
        imgui.table_next_column()
        imgui.text("Auto Clipping")
        imgui.table_next_column()
        autoClippingChanged, autoClippingValue = imgui.checkbox("##AutoClippingCheckbox", self.camera.autoClipping())
        if autoClippingChanged:
            self.camera.setAutoClipping(autoClippingValue)
        imgui.table_next_row()
        imgui.table_next_column()
        imgui.text("Clipping Planes")
        imgui.table_next_column()
        imgui.set_next_item_width(imgui.get_content_region_avail()[0])
        zMin = 0.1; zMax = 1000000.
        if autoClippingValue:
            imgui.begin_disabled()
        clippingPlanesChanged, zNear, zFar = imgui.drag_float_range2("##ClippingPlanesSlider", self.camera.getZNear(), self.camera.getZFar(), v_speed=1, v_min=zMin, v_max=zMax, format="%.1f")
        if clippingPlanesChanged:
            if zNear == zFar:
                if zFar == zMax:
                    zNear = zMax - 1
                else:
                    zFar = zNear + 1
            self.camera.setZNear(zNear)
            self.camera.setZFar(zFar)
        if autoClippingValue:
            imgui.end_disabled()
        imgui.end_table()
