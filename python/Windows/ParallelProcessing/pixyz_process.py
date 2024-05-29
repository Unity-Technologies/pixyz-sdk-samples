import sys

from shared.shared_utils.pixyz_Utils import pixyz_init as pixyz_init
from ImportOptimiseExport import import_optimise_export as importoptimiseexport

from pxz import core
finalPath = None

def main(filepath):
    pixyz_init.init_pixyz()
    pixyz_init.get_pixyz_license()
    if core.checkLicense():
        root = importoptimiseexport.importmodel(filepath)
        importoptimiseexport.preparemodel(root)
        importoptimiseexport.exportmodel(filepath, "_new.glb", root)
    else:
        print("No License Available")


if __name__ == '__main__':
    if len(sys.argv) > 1:
        main(sys.argv[1])
