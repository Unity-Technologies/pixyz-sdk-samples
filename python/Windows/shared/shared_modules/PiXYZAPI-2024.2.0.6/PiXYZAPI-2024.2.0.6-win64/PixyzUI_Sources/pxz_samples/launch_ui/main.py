import sys
sys.path.append("../../")

# Install dependencies
import pip

needed_packages = ["imgui-bundle", "pyopengl", "pillow"]

for package in needed_packages:
    pip.main(['install', package])

# Initialize Pixyz Engine
import pxz
pxz.initialize("PixyzSDK", "204b0ede26cfc54774cbbdaa175c1456c43b253144396405304009f926c0ebfcd5")

from pxzui.Window import Window

window = Window(1024, 768)
window.open()
