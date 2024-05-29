import time
from pxz import core, scene, view, geom
from enum import Enum
def getStats(root):
    core.configureInterfaceLogger(False, False, False)  # hide next lines from logs

    t = time.time()
    n_triangles = scene.getPolygonCount([root], True, False, False)
    n_vertices = scene.getVertexCount([root], False, False, False)
    n_parts = len(scene.getPartOccurrences(root))

    core.configureInterfaceLogger(True, True, True)  # reenable logs

    return t, n_triangles, n_vertices, n_parts

class Orientation(Enum):
    FRONT = 0
    BACK = 1
    TOP = 2
    BOTTOM = 3
    LEFT = 4
    RIGHT = 5

def save_screenshot(occurrence, path, orientation=Orientation.FRONT, type=view.CameraType.Perspective, resolution=1024, fov=60, show_edges=False, show_lines=False):
    print("Taking Screenshot...")
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
    gpu_scene = view.createGPUScene([occurrence], show_edges)
    view.addGPUScene(gpu_scene, viewer)
    view.fitCamera(direction, type, fov, viewer, occurrence)
    if show_edges:
        view.setViewerProperty("ShowEdges", "True", viewer)
    if show_lines:
        view.setViewerProperty("ShowLines", "False", viewer)

    view.takeScreenshot(path, viewer)
    view.destroyViewer(viewer)
    view.destroyGPUScene(gpu_scene)
def printStats(fileName, t, n_triangles, _n_triangles, n_vertices, _n_vertices, n_parts, _n_parts):
    print('\n')
    print('{:<20s}{:<3s}\n'.format('file ', fileName))
    print('{:<20s}{:<8.3f}{:<3s}\n'.format('optimization ', t, ' s'))
    print('{:<20s}{:<3s}\n'.format('triangles ', str(n_triangles) + ' -> ' + str(_n_triangles)))
    print('{:<20s}{:<3s}\n'.format('vertices ', str(n_vertices) + ' -> ' + str(_n_vertices)))
    print('{:<20s}{:<3s}\n'.format('parts ', str(n_parts) + ' -> ' + str(_n_parts)))
