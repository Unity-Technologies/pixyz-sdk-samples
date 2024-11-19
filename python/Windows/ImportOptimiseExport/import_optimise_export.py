import os
from shared.shared_utils.pixyz_utils import math_utils as math_utils
from shared.shared_utils.pixyz_utils import pixyz_init as pixyz_init
from shared.shared_utils.pixyz_utils import pixyz_utils as pixyz_utils
from shared.shared_utils.pixyz_utils.pixyz_utils import Orientation
from pxz import algo, scene, io, core


# These functions are used for the folder watcher sample
def optimiseModel(root, fileName):
    t0, n_triangles, n_vertices, n_parts = pixyz_utils.getStats(root)

    # Removes through holes from CAD models whose diameter is below the defined diameter
    print("Removing Holes...")
    diameter = 10
    algo.removeHoles([root], True, False, False, diameter, 0)

    # Deletes patches borders (black lines delimiting CAD models' faces) to allow decimation (run in the next step) to be more efficient. Otherwise, patches borders are considered as important information to preserve.
    print("Delete Patches...")
    algo.deletePatches([root], True)

    # Reduces meshes density (triangles count) by decimating them, using the "Decimate To Quality" function (see documentation). The values used here are meant to decimate meshes just enough to lower the triangles count without affecting the visual quality too much, especially on CAD models.
    print("Decimating...")
    algo.decimate([root], 1, 0.1, 3, -1, False)

    # Removes triangles not visible from a set of cameras automatically placed around the model.
    print("Removing Hidden Geometries...")
    algo.removeOccludedGeometries([root], algo.SelectionLevel.Polygons, 1024, 16, 90, False, 1)

    t1, _n_triangles, _n_vertices, _n_parts = pixyz_utils.getStats(root)
    pixyz_utils.printStats(fileName, t1 - t0, n_triangles, _n_triangles, n_vertices, _n_vertices, n_parts, _n_parts)


def convertFile(inputFile, outputFolder, extensions, optimization, publish_to_assetmanager, orgid, projid,
                collection_path, tags):
    modelFiles = []
    fileName = os.path.splitext(os.path.basename(inputFile))[0]

    # Set log file in output folder for debug purposes (otherwise it will be overwritten by next 3d file processing)
    core.setLogFile(outputFolder + '/' + fileName + '.log')

    # Imports the input_files
    root = importModel(inputFile)

    # Tesselate the model based on its size
    prepareModel(root)

    if optimization:  # Comment or delete the lines not necessary to your workflow, adjust parameters' values if necessary
        optimiseModel(root, fileName)

    # Export files
    for extension in extensions:
        print(f"Exporting {extension}...")
        io.exportScene(outputFolder + '/' + fileName + extension)
        modelFiles.append(outputFolder + '/' + fileName + extension)
    if publish_to_assetmanager == "True":
        from shared.shared_utils.unity_cloud_utils import unitycloud_utils as unitycloud_utils
        unitycloud_utils.CreateAndPublishFilesToAsset(fileName, modelFiles,
                                                      orgid, projid,
                                                      collection_path, tags)


def importModel(filepath):
    print(f"Importing {filepath}... ")
    root = io.importScene(filepath)
    return root


def prepareModel(root):
    # prepare model, use tolerance based AABB so
    print("Calculating Tolerances... ")
    tolerance = min(math_utils.aabb_diag_length(scene.getAABB([root])) / 1000, 0.1)
    print("Repairing CAD... ")
    algo.repairCAD([root], tolerance, False)
    print("Tessellating Meshes... ")
    algo.tessellate([root], tolerance, -1, -1)
    print("Repairing Meshes... ")
    algo.repairMesh([root], tolerance, True, False)


def exportModel(filepath, extension, root):
    folder_path = os.path.dirname(filepath)
    filename = os.path.splitext(os.path.basename(filepath))[0]
    global finalPath
    finalPath = os.path.join(folder_path, filename + extension)
    print(f"Exporting {finalPath} ... ")
    io.exportScene(str(finalPath), root)


if __name__ == '__main__':

    pixyz_init.initPixyz()
    pixyz_init.getPixyzLicense()
    model_file_path = "../shared/shared_models/SkidLoaderSolidworks/Skid Loader ASSM 11-4-21.SLDASM"

    if core.checkLicense():
        root = importModel(model_file_path)
        pixyz_utils.saveScreenshot(root, os.path.join(os.path.dirname(model_file_path), "before.png"),
                                   Orientation.LEFT)
        prepareModel(root)
        pixyz_utils.saveScreenshot(root, os.path.join(os.path.dirname(model_file_path), "after.png"),
                                   Orientation.FRONT)
        pixyz_utils.extractHierarchyToJson(root, os.path.join(os.path.dirname(model_file_path),
                                                                f"{os.path.splitext(os.path.basename(model_file_path))[0]}.json"))
        exportModel(model_file_path, "_new.glb", root)
    else:
        print("No License Available")
