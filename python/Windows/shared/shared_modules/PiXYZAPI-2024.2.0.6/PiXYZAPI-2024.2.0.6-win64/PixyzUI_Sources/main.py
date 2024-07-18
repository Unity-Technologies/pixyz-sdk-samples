import subprocess
import sys
import os

os.chdir(os.path.dirname(__file__))
print("installing requirements...")
subprocess.run([sys.executable, '-m', 'pip', 'install', '-r', 'requirements.txt', '--quiet'])
print("requirements installed")

if len(sys.argv) < 2:
    print("Usage : " + sys.argv[0] + " <pxz_module_path>")
    exit(1)

# Initialize Pixyz Engine
sys.path.append(sys.argv[1])
import pxz
pxz.initialize("PixyzSDK", "VALIDATION_KEY")
sys.path.remove(sys.argv[1])

pxz.core.configureInterfaceLogger(False, False, False)
pxz.core.addConsoleVerbose(pxz.core.Verbose.INFO)
pxz.core.addConsoleVerbose(pxz.core.Verbose.ERR)
pxz.core.addConsoleVerbose(pxz.core.Verbose.WARNING)

from pxzui.Window import Window
Window().open()
