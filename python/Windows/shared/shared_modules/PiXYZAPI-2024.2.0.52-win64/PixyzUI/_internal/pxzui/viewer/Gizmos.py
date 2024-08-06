from typing import Tuple
import numpy as np
import numpy.linalg
from imgui_bundle import imguizmo, ImVec2
from imgui_bundle import imgui
import pxz

from pxzui.utils import MatrixUtils
from pxzui.utils.EmVec2 import EmVec2

gizmo = imguizmo.im_guizmo


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
        self.gridSize = 10.0
        self.moving = False
        self.window.callback_manager.addSelectionChangedCallback(self.onSelectionChanged)
        self.window.callback_manager.addAfterEntityPropertyChangedCallback(self.onEntityPropertyChange)

    def __del__(self):
        self.window.callback_manager.removeSelectionChangedCallback(self.onSelectionChanged)
        self.window.callback_manager.removeAfterEntityPropertyChangedCallback(self.onEntityPropertyChange)

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

        # transpose view and matrix to match expected shape
        proj = np.ndarray.copy(np.transpose(proj))
        view = np.ndarray.copy(np.transpose(view))

        # necessary for drawing
        gizmo.begin_frame()
        io = imgui.get_io()
        gizmo.set_rect(0, 0, io.display_size.x, io.display_size.y)
        # TODO : to remove with a replacement grid with depth compositing
        if self.gridToggle:
            gridView = np.ndarray.copy(view)
            for i in range(0, 4):
                gridView[3, i] = gridView[3, i] / 100.
            gizmo.draw_grid(gridView, proj, np.identity(4, dtype=np.float32), self.gridSize)

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
        flippedModel = np.ndarray.copy(np.transpose(self.model))
        manip_result = gizmo.manipulate(
            view,
            proj,
            self.operation,
            self.mode,
            flippedModel,
            None
        )
        if manip_result:
            # check if translation value is too big
            if np.isnan(manip_result.value).any():
                print("Gizmo matrix is invalid!")
                if self.moving:
                    self.moving = False
                    pxz.core.endUndoRedoStep()
                return
            # gizmo was moved
            # undo tf from above
            self.model = np.matmul(self.invParentModel, np.ndarray.copy(np.transpose(manip_result.value)))
            T, R, S = pxz.geom.toTRS(self.model.tolist())
            S.x = max(S.x, 0.01)
            S.y = max(S.y, 0.01)
            S.z = max(S.z, 0.01)
            self.model = np.array(pxz.geom.fromTRS(T, R, S), dtype=np.float32)
            # apply matrix
            if not self.moving:
                self.moving = True
                pxz.core.startUndoRedoStep("3D Manipulation")
            pxz.scene.setLocalMatrix(self.pickedOccurrence, self.model.tolist())
        else:
            if self.moving:
                self.moving = False
                pxz.core.endUndoRedoStep()
        return self.moving


    def create(self, occurrence):
        model = np.array(pxz.scene.getGlobalMatrix(occurrence), dtype=np.float32)
        if not MatrixUtils.isValidTrsMatrix(model):
            self.pickedOccurrence = -1
            return
        self.model = model
        self.pickedOccurrence = occurrence
        parent = pxz.scene.getParent(occurrence)
        if parent != 0:
            self.invParentModel = np.linalg.inv(np.array(pxz.scene.getGlobalMatrix(parent), dtype=np.float32))
        else:
            self.invParentModel = np.identity(4, dtype=np.float32)

    def reset(self):
        self.pickedOccurrence = -1

    def onSelectionChanged(self, selectionChangeType, occurrences):
        if selectionChangeType == pxz.scene.SelectionChangeType.CLEARED or selectionChangeType == pxz.scene.SelectionChangeType.REMOVED:
            self.reset()
        else:
            selection = pxz.scene.getSelectedOccurrences()
            if len(selection)==1:
                self.create(selection[0])
            else:
                self.reset()

    def onEntityPropertyChange(self, entity, property, entityType):
        if entity == self.pickedOccurrence and property == "Transform":
            self.create(self.pickedOccurrence)
