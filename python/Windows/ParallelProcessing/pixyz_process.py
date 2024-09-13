import sys

from shared.shared_utils.pixyz_utils import pixyz_init as pixyz_init
from ImportOptimiseExport import import_optimise_export as importOptimiseExport

from pxz import core
finalPath = None

def main(filepath):
    pixyz_init.initPixyz()
    pixyz_init.getPixyzLicense()
    if core.checkLicense():
        root = importOptimiseExport.importModel(filepath)
        importOptimiseExport.prepareModel(root)
        importOptimiseExport.exportModel(filepath, "_new.glb", root)
    else:
        print("No License Available")


if __name__ == '__main__':
    if len(sys.argv) > 1:
        main(sys.argv[1])
