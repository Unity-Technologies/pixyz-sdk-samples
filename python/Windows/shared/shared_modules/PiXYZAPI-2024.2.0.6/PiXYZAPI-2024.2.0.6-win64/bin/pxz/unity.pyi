from enum import Enum
from collections.abc import Callable

from pxz import cad
from pxz import core
from pxz import geom
from pxz import material
from pxz import polygonal
from pxz import scene
from pxz import view

# Constants

# Classes
class PickResult:
	"""
	"""
	occurrences: list[int]
	positions: list[geom.Point3]
	def __init__(self, occurrences: list[int], positions: list[geom.Point3]) -> PickResult: ...
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

def getD3D11Device() -> core.Ptr:
	"""

	Returns:
		device (core.Ptr): 
	"""
	...

def getD3D11RenderTargetViewFromRenderBuffer(surface: core.Ptr) -> core.Ptr:
	"""

	Args:
		surface (core.Ptr): 

	Returns:
		rtv (core.Ptr): 
	"""
	...

def getD3D11ShaderResourceViewFromNativeTexture(texture: int) -> core.Ptr:
	"""

	Args:
		texture (int): 

	Returns:
		srv (core.Ptr): 
	"""
	...

def getD3D11TextureFromNativeTexture(texture: int) -> core.Ptr:
	"""

	Args:
		texture (int): 

	Returns:
		dxTexture (core.Ptr): 
	"""
	...

def getD3D11TextureFromRenderBuffer(buffer: core.Ptr) -> core.Ptr:
	"""

	Args:
		buffer (core.Ptr): 

	Returns:
		dxTexture (core.Ptr): 
	"""
	...

def getDestroyFunction() -> core.Ptr:
	"""

	Returns:
		destroyFunction (core.Ptr): 
	"""
	...

def getDrawFunction() -> core.Ptr:
	"""

	Returns:
		drawFunction (core.Ptr): 
	"""
	...

def getInitFunction() -> core.Ptr:
	"""

	Returns:
		initFunction (core.Ptr): 
	"""
	...

def asyncPick(session: int, x: int, y: int) -> None:
	"""Asynchronous function to pick in the current viewer

	Args:
		session (int): 
		x (int): 
		y (int): 
	"""
	...

def asyncResize(session: int, width: int, height: int) -> None:
	"""call this function when the texture has to be resized. the resize will take effect during the next render. This will send a ViewSessionResized event when done

	Args:
		session (int): 
		width (int): Viewer width
		height (int): Viewer height
	"""
	...

def createUnityViewSession(width: int, height: int, graphicAPI: view.GraphicAPI, nbViews: int = 1) -> int:
	"""

	Args:
		width (int): Viewer width
		height (int): Viewer height
		graphicAPI (view.GraphicAPI): Graphic api used by Unity
		nbViews (int): Nb views

	Returns:
		session (int): 
	"""
	...

def getUnityViewSessionViewer(session: int) -> int:
	"""Returns the underlying viewer of the given view session

	Args:
		session (int): 

	Returns:
		viewer (int): 
	"""
	...

def getVulkanDevice() -> core.Ptr:
	"""

	Returns:
		vkDevice (core.Ptr): 
	"""
	...

# Callbacks
def addUnityViewSessionDestroyedCallback(callback: Callable[[int], None], userdata):
	"""Emitted when a session is destroyed (via getDestroyFunction unity plugin event)
	"""
	...

def removeUnityViewSessionDestroyedCallback(id: int):
	"""Remove callback added with unity.addUnityViewSessionDestroyedCallback
	"""
	...

def addUnityViewSessionHasPickedCallback(callback: Callable[[PickResult, int], None], userdata):
	"""emited when a pick was performed (after asyncPick) and there is a result to share
	"""
	...

def removeUnityViewSessionHasPickedCallback(id: int):
	"""Remove callback added with unity.addUnityViewSessionHasPickedCallback
	"""
	...

def addUnityViewSessionInitializedCallback(callback: Callable[[int], None], userdata):
	"""Emitted when a session created with CreateUnityViewSession is initialized (via getInitfunction unity plugin event)
	"""
	...

def removeUnityViewSessionInitializedCallback(id: int):
	"""Remove callback added with unity.addUnityViewSessionInitializedCallback
	"""
	...

def addUnityViewSessionResizedCallback(callback: Callable[[int], None], userdata):
	"""emits when a view session is done resizing
	"""
	...

def removeUnityViewSessionResizedCallback(id: int):
	"""Remove callback added with unity.addUnityViewSessionResizedCallback
	"""
	...

