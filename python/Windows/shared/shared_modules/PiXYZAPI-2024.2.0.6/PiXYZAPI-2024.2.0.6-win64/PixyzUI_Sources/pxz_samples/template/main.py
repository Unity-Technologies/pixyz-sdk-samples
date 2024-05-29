import os
from pxz import core, algo, io, view, geom, scene
from pxz_utils import init, process, screenshot, math_utils
import pxzui
from pxzui import Window


def main():
    # init Pixyz
    init.init_pixyz()
    dir_path = os.path.dirname(os.path.realpath(__file__))

    # import CAD file and save screenshot
    root = process.guided_import(dir_path + "/Bolt.CATPart")
    screenshot.save(root, dir_path + "/output_before.png", screenshot.Orientation.FRONT)

    # prepare model, use an adaptative tolerance based AABB so that small models don't have a too high tolerance value
    tolerance = min(math_utils.aabb_diag_length(scene.getAABB([root])) / 1000, 0.1)
    algo.repairCAD([root], tolerance, False)
    algo.repairMesh([root], tolerance, True, False)
    algo.tessellate([root], tolerance, -1, -1)

    # create your Pixyz recipe here:
    # ...

    # export CAD file and save screenshot
    screenshot.save(root, dir_path + "/output_after.png", screenshot.Orientation.FRONT)
    io.exportScene(dir_path + "/Bolt.glb", root)

    # open Pixyz UI to validate your recipe
    window = pxzui.Window.Window()
    window.open()


if __name__ == "__main__":
    main()
