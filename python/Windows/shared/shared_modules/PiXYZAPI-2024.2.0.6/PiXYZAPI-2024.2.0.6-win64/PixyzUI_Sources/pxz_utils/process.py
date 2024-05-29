import math

import pxz
from pxz import core, algo, io, view, geom, scene


def guided_import(path):
    root = io.importScene(path)
    return root
