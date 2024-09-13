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

def saveScreenshot(occurrence: int, path: str, orientation=Orientation.FRONT, cameraType=pxz.view.CameraType.Perspective,
         resolution=1024, fov=60, showEdges=False, showLines=False):

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
    gpu_scene = view.createGPUScene([occurrence], showEdges)
    view.addGPUScene(gpu_scene, viewer)
    view.fitCamera(direction, cameraType, fov, viewer, [occurrence])
    if showEdges:
        view.setViewerProperty("ShowEdges", "True", viewer)
    if showLines:
        view.setViewerProperty("ShowLines", "False", viewer)

    view.takeScreenshot(path, viewer)
    view.destroyViewer(viewer)
    view.destroyGPUScene(gpu_scene)
