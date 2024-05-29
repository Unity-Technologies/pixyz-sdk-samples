from enum import Enum
from collections.abc import Callable

from pxz import cad
from pxz import core
from pxz import geom
from pxz import material
from pxz import polygonal
from pxz import scene

# Constants

# Classes
class Camera:
	"""
	"""
	position: geom.Point3
	direction: geom.Point3
	up: geom.Point3
	fov: float
	def __init__(self, position: geom.Point3, direction: geom.Point3, up: geom.Point3, fov: float) -> Camera: ...
	...

# Functions
def configureFunctionLogger(functionName: str, enableFunction: bool, enableParameters: bool, enableExecutionTime: bool) -> None:
	"""

	Args:
		functionName (str): 
		enableFunction (bool): 
		enableParameters (bool): 
		enableExecutionTime (bool): 
	"""
	...

def renderImage(width: int, height: int, camera: Camera, outputImagePath: str) -> None:
	"""

	Args:
		width (int): 
		height (int): 
		camera (Camera): 
		outputImagePath (str): 
	"""
	...

# Callbacks
