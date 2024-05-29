from typing import Tuple
import numpy as np
import numpy.linalg
from imgui_bundle import imguizmo, ImVec2
from imgui_bundle import imgui
import pxz

from pxzui.utils.EmVec2 import EmVec2

gizmo = imguizmo.im_guizmo

def onSelectionChanged(type, occurrences, gizmo):
    gizmo.onSelectionChanged(type, occurrences)

class Gizmo:
    def __init__(self, window):
        self.viewer = window.viewer
        self.window = window
        self.model = np.identity(4, dtype=np.float32)
        self.invParentModel = np.identity(4, dtype=np.float32)
        self.pickedOccurrence = -1
        self.mode = gizmo.MODE.world
        self.operation = gizmo.OPERATION.universal
        self.gridToggle = False
        self.gridSize = 1000.0
        self.moving = False
        pxz.scene.addSelectionChangedCallback(onSelectionChanged, self)

    def drawProperties(self):
        if imgui.radio_button("Translate", self.operation == gizmo.OPERATION.translate):
            self.operation = gizmo.OPERATION.translate
        imgui.same_line()
        if imgui.radio_button("Rotate", self.operation == gizmo.OPERATION.rotate):
            self.operation = gizmo.OPERATION.rotate
        imgui.same_line()
        if imgui.radio_button("Scale", self.operation == gizmo.OPERATION.scale):
            self.operation = gizmo.OPERATION.scale
        imgui.same_line()
        if imgui.radio_button("Universal", self.operation == gizmo.OPERATION.universal):
            self.operation = gizmo.OPERATION.universal
        if imgui.radio_button("Local", self.mode == gizmo.MODE.local):
            self.mode = gizmo.MODE.local
        imgui.same_line()
        if imgui.radio_button("World", self.mode == gizmo.MODE.world):
            self.mode = gizmo.MODE.world
        _, self.gridToggle = imgui.checkbox("Grid", self.gridToggle)
        if self.gridToggle:
            _, self.gridSize = imgui.input_float("Grid Size", self.gridSize)

    def draw(self):
        if self.window.width <= 0 or self.window.height <= 0:
            return
        # TODO gizmos act weird when increasing zNear in projection matrix
        view = self.viewer.camera.getViewMatrix().copy().astype(np.float32)
        proj = self.viewer.camera.getProjMatrix().copy().astype(np.float32)
        # transform view matrix to match expected shape
        view[0:3, 0:3] = np.transpose(view[0:3, 0:3])
        view[3, 0:3] = view[0:3, 3]
        view[0:3, 3] = 0
        # necessary for drawing
        gizmo.begin_frame()
        io = imgui.get_io()
        gizmo.set_rect(0, 0, io.display_size.x, io.display_size.y)
        # TODO : to remove with a replacement grid with depth compositing
        if self.gridToggle:
            gridView = np.ndarray.copy(view)
            gridView[3, 0:3] = gridView[3, 0:3] / 100.
            gizmo.draw_grid(gridView, proj, np.identity(4, dtype=np.float32), self.gridSize/100.)
        #gizmo.draw_cubes(view, proj, [self.model])
        viewManipulateX = viewManipulateY = 0
        if self.window.drawUI and self.window.ui.dockSpaceID is not None:
            centralNode = imgui.internal.dock_builder_get_central_node(self.window.ui.dockSpaceID)
            viewManipulateY = centralNode.pos.y
            viewManipulateX = centralNode.pos.x
        # modification of view matrix via cubeview
        distance = self.viewer.camera.getDistance()
        view_manip_result = gizmo.view_manipulate(
            view, distance, ImVec2(viewManipulateX, viewManipulateY), EmVec2(6, 6), 0
        )
        if distance != self.viewer.camera.getDistance():
            self.viewer.camera.setDistance(distance)
        if view_manip_result:
            # get up & forward vectors, target stays the same
            self.viewer.camera.setUp(view_manip_result.value[0:3, 1])
            self.viewer.camera.setForward(-view_manip_result.value[0:3, 2])
        if self.pickedOccurrence == -1:
            return
        flippedModel = np.ndarray.copy(self.model)
        flippedModel[0:3, 0:3] = np.transpose(flippedModel[0:3, 0:3])
        flippedModel[3, 0:3] = flippedModel[0:3, 3]
        flippedModel[0:3, 3] = 0
        manip_result = gizmo.manipulate(
            view,
            proj,
            self.operation,
            self.mode,
            flippedModel,
            None
        )
        if manip_result:
            # gizmo was moved
            # undo tf from above
            self.model = manip_result.value
            self.model[0:3, 0:3] = np.transpose(self.model[0:3, 0:3])
            self.model[0:3, 3] = self.model[3, 0:3]
            self.model[3, 0:3] = 0
            # apply matrix
            if not self.moving:
                self.moving = True
                pxz.core.startUndoRedoStep("3D Manipulation")
            pxz.scene.setLocalMatrix(self.pickedOccurrence, (np.matmul(self.invParentModel, self.model)).tolist())
        else:
            if self.moving:
                self.moving = False
                pxz.core.endUndoRedoStep()


    def create(self, occurrence):
        self.pickedOccurrence = occurrence
        self.model = np.array(pxz.scene.getGlobalMatrix(occurrence), dtype=np.float32)
        parent = pxz.scene.getParent(occurrence)
        if parent != 0:
            self.invParentModel = np.linalg.inv(np.array(pxz.scene.getGlobalMatrix(parent), dtype=np.float32))
        else:
            self.invParentModel = np.identity(4, dtype=np.float32)

    def reset(self):
        self.pickedOccurrence = -1

    def onSelectionChanged(self, type, occurrences):
        if type == pxz.scene.SelectionChangeType.CLEARED or type == pxz.scene.SelectionChangeType.REMOVED:
            self.reset()
        else:
            selection = pxz.scene.getSelectedOccurrences()
            if len(selection)==1:
                self.create(selection[0])
            else:
                self.reset()
