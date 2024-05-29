import pxz
from pxz import core, algo, io, view, geom, scene
from enum import Enum

class Orientation(Enum):
    FRONT = 0
    BACK = 1
    TOP = 2
    BOTTOM = 3
    LEFT = 4
    RIGHT = 5

def save(occurrence, path, orientation=Orientation.FRONT, type=pxz.view.CameraType.Perspective, resolution=1024, fov=60, show_edges=False, show_lines=False):

    if orientation == Orientation.FRONT:
        direction = geom.Point3(0, 0, -1)
    elif orientation == Orientation.BACK:
        direction = geom.Point3(0, 0, 1)
    elif orientation == Orientation.TOP:
        direction = geom.Point3(0, -1, 0)
    elif orientation == Orientation.BOTTOM:
        direction = geom.Point3(0, 1, 0)
    elif orientation == Orientation.LEFT:
        direction = geom.Point3(1, 0, 0)
    elif orientation == Orientation.RIGHT:
        direction = geom.Point3(-1, 0, 0)
    else:
        direction = geom.Point3(0, 0, 0)

    viewer = view.createViewer(resolution, resolution)
    gpu_scene = view.createGPUScene(occurrence, show_edges)
    view.addGPUScene(gpu_scene, viewer)
    view.fitCamera(direction, type, fov, viewer, occurrence)
    if show_edges:
        view.setViewerProperty("ShowEdges", "True", viewer)
    if show_lines:
        view.setViewerProperty("ShowLines", "False", viewer)

    view.takeScreenshot(path, viewer)
    view.destroyViewer(viewer)
    view.destroyGPUScene(gpu_scene)
