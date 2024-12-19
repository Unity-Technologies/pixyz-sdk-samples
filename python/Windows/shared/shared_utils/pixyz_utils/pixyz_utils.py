import time
from pxz import core, scene, view, geom
from enum import Enum
import json

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
    THREE_FOUR_PERSP = 6



def saveScreenshot(occurrence, path, orientation=Orientation.FRONT, type=view.CameraType.Perspective, resolution=1024,
                   fov=60, showEdges=False, showLines=False, addPostProcess=True):
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
    elif orientation == Orientation.THREE_FOUR_PERSP:
        direction = geom.Point3(0.5, -0.5, -1)
    else:
        direction = geom.Point3(0, 0, 0)

    viewer = view.createViewer(resolution, resolution)
    gpu_scene = view.createGPUScene([occurrence], showEdges)
    view.addGPUScene(gpu_scene, viewer)
    view.fitCamera(direction, type, fov, viewer, [occurrence])
    view.setViewerProperty("OcclusionCullingEnabled", "False", viewer)

    if showEdges:
        view.setViewerProperty("ShowEdges", "True", viewer)
    if showLines:
        view.setViewerProperty("ShowLines", "False", viewer)

    view.setViewerProperty("EnableToneMaping", str(addPostProcess), viewer)
    view.setViewerProperty("UseFXAA", str(addPostProcess), viewer)
    view.setViewerProperty("UseSSAO", str(addPostProcess), viewer)

    view.takeScreenshot(path, viewer)
    print("Screenshot saved at: " + path)
    view.destroyViewer(viewer)
    view.destroyGPUScene(gpu_scene)


def printStats(fileName, t, n_triangles, _n_triangles, n_vertices, _n_vertices, n_parts, _n_parts):
    print('\n')
    print('{:<20s}{:<3s}\n'.format('file ', fileName))
    print('{:<20s}{:<8.3f}{:<3s}\n'.format('optimization ', t, ' s'))
    print('{:<20s}{:<3s}\n'.format('triangles ', str(n_triangles) + ' -> ' + str(_n_triangles)))
    print('{:<20s}{:<3s}\n'.format('vertices ', str(n_vertices) + ' -> ' + str(_n_vertices)))
    print('{:<20s}{:<3s}\n'.format('parts ', str(n_parts) + ' -> ' + str(_n_parts)))


def getMetadataDict(metadata):
    metadata_dict = dict()
    metadata_dict['name'] = metadata.name
    metadata_dict['value'] = metadata.value
    return metadata_dict


def getHierarchyDict(occurrence):
    hierarchy_dict = dict()
    hierarchy_dict['name'] = core.getProperty(occurrence, "Name")
    matrix = scene.getLocalMatrix(occurrence)
    vector3lst = geom.toTRS(matrix)
    hierarchy_dict['translation'] = str([vector3lst[0].x, vector3lst[0].y,vector3lst[0].z])
    hierarchy_dict['rotation'] = str([vector3lst[1].x, vector3lst[1].y,vector3lst[1].z])
    hierarchy_dict['scale'] = str([vector3lst[2].x, vector3lst[2].y,vector3lst[2].z])
    hierarchy_dict['children'] = [getHierarchyDict(child) for child in scene.getChildren(occurrence)]
    if scene.hasComponent(occurrence, scene.ComponentType.Metadata):
        metadata = scene.getComponent(occurrence, scene.ComponentType.Metadata)
        metadata_definitions = scene.getMetadatasDefinitions([metadata])[0]
        hierarchy_dict['metadata'] = [getMetadataDict(metadata_definition) for metadata_definition in
                                      metadata_definitions]

    return hierarchy_dict


def extractHierarchyToJson(root, file_path):
    hierarchy_dict = getHierarchyDict(root)
    with open(file_path, 'w') as file:
        json.dump(hierarchy_dict, file, indent=4)

    print('\nDone: structure tree exported at ' + file_path)
