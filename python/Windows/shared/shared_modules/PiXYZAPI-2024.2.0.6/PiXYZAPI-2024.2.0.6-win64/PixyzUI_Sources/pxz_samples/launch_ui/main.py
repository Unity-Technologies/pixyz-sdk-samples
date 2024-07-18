import sys
sys.path.append("../../")

# Install dependencies
import pip

needed_packages = ["imgui-bundle", "pyopengl", "pillow"]

for package in needed_packages:
    pip.main(['install', package])

# Initialize Pixyz Engine
import pxz
pxz.initialize("PixyzSDK", "VALIDATION_KEY")

from pxzui.Window import Window

window = Window(1024, 768)
window.open()
