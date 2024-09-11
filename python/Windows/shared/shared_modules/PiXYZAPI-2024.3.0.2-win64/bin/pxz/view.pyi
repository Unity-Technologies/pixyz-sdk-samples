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
class AnimationPlayerInfo:
	"""
	"""
	isPlaying: bool
	isLooping: bool
	currentFrame: int
	speed: float
	def __init__(self, isPlaying: bool, isLooping: bool, currentFrame: int, speed: float) -> None: ...
	...

class CameraType(Enum):
	"""
	"""
	Perspective: int
	Orthographic: int
	...

class EncoderSettings:
	"""
	"""
	frameRate: int
	averageBitRate: int
	maxBitRate: int
	rateControl: RateControl
	qp: QP
	targetQuality: int
	def __init__(self, frameRate: int, averageBitRate: int, maxBitRate: int, rateControl: RateControl, qp: QP, targetQuality: int) -> None: ...
	...

class GraphicAPI(Enum):
	"""
	"""
	None: int
	OpenGL: int
	D3D11: int
	Vulkan: int
	...

class GraphicsContext:
	"""
	"""
	api: GraphicAPI
	context: core.Ptr
	def __init__(self, api: GraphicAPI, context: core.Ptr) -> None: ...
	...

class PrimitiveSelectionType(Enum):
	"""
	"""
	Polygon: int
	Patch: int
	ConnectedMesh: int
	...

class QP:
	"""
	"""
	qpInterP: int
	qpInterB: int
	qpIntra: int
	def __init__(self, qpInterP: int, qpInterB: int, qpIntra: int) -> None: ...
	...

class RateControl(Enum):
	"""
	"""
	CONSTQP: int
	CBR: int
	VBR: int
	...

class RenderMap(Enum):
	"""
	"""
	Composited: int
	AlbedoOpacity: int
	Normal: int
	Depth: int
	MetallicRoughnessAOMisc: int
	Emissive: int
	ObjectIdPrimitiveId: int
	UVs: int
	SSAO: int
	...

class StreamedViewerInfo:
	"""
	"""
	host: str
	port: int
	viewer: int
	def __init__(self, host: str, port: int, viewer: int) -> None: ...
	...

class WebRTCInfo:
	"""
	"""
	signalingUrl: str
	stunServer: str
	udpPortRangeBegin: int
	udpPortRangeEnd: int
	def __init__(self, signalingUrl: str, stunServer: str, udpPortRangeBegin: int, udpPortRangeEnd: int) -> None: ...
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

def destroyContext() -> None:
	"""Destroy the Vulkan instance. All existing viewers and gpuScenes will also be destroyed and all view module properties will be reset
	"""
	...

def suitableGPUAvailable() -> bool:
	"""returns true if a suitable device is found.

	Returns:
		found (bool): True if a suitable device was found.
	"""
	...

def applyPlayingAnimations(time: int) -> None:
	"""apply the animations

	Args:
		time (int): Current time
	"""
	...

def getAnimationPlayerInfo(animation: int) -> AnimationPlayerInfo:
	"""packs all AnimationPlayer-related info about an animation in an object

	Args:
		animation (int): Animation to get info of

	Returns:
		animationPlayerInfo (AnimationPlayerInfo): 
	"""
	...

def isAnimationPlaying(animation: int) -> bool:
	"""is this animation playing?

	Args:
		animation (int): Animation to check

	Returns:
		playingValue (bool): 
	"""
	...

def pauseAllAnimation() -> None:
	"""pauses all animations
	"""
	...

def pauseAnimation(animation: int) -> None:
	"""pauses an animation

	Args:
		animation (int): Animation to pause
	"""
	...

def playAnimation(animation: int, speed: float = 1, loop: bool = False) -> None:
	"""plays an animation

	Args:
		animation (int): Animation to play
		speed (float): Speed
		loop (bool): Should the animation loop?
	"""
	...

def resumeAllAnimation() -> None:
	"""resumes all animations
	"""
	...

def resumeAnimation(animation: int) -> None:
	"""resumes an animation

	Args:
		animation (int): Animation to resume
	"""
	...

def setAnimationFrame(animation: int, frame: int) -> None:
	"""set animation's current frame

	Args:
		animation (int): Animation to set frame
		frame (int): Frame to set
	"""
	...

def setAnimationLoop(animation: int, loop: bool) -> None:
	"""set animation's looping status

	Args:
		animation (int): Animation to set loop status
		loop (bool): Should the animation loop?
	"""
	...

def setAnimationSpeed(animation: int, speed: float) -> None:
	"""set animation's playing speed

	Args:
		animation (int): Animation to set speed
		speed (float): The speed
	"""
	...

def stopAllAnimation(applyDefault: bool = True) -> None:
	"""stops all animations

	Args:
		applyDefault (bool): Should the default position be applied
	"""
	...

def stopAnimation(animation: int, applyDefault: bool = True) -> None:
	"""stops an animation

	Args:
		animation (int): Animation to stop
		applyDefault (bool): Should the default position be applied
	"""
	...

def getD3D11Texture(renderMap: RenderMap, viewer: int = -1) -> core.Ptr:
	"""

	Args:
		renderMap (RenderMap): 
		viewer (int): 

	Returns:
		handle (core.Ptr): 
	"""
	...

def getGLTextureHandle(renderMap: RenderMap, viewer: int = -1) -> int:
	"""

	Args:
		renderMap (RenderMap): 
		viewer (int): 

	Returns:
		handle (int): 
	"""
	...

def getVulkanTexture(renderMap: RenderMap, viewer: int = -1) -> core.Ptr:
	"""

	Args:
		renderMap (RenderMap): 
		viewer (int): 

	Returns:
		handle (core.Ptr): 
	"""
	...

def createGPUScene(roots: list[int], constructEdges: bool = False) -> int:
	"""

	Args:
		roots (list[int]): Roots of the subtrees that will be uploaded to GPU
		constructEdges (bool): Construct buffer to render edges colored by topology (slower to construct)

	Returns:
		scene (int): Identifier of the newly created GPU Scene
	"""
	...

def destroyGPUScene(scene: int) -> None:
	"""

	Args:
		scene (int): GPU Scene to destroy (previously created by createGPUScene)
	"""
	...

def getGlobalGPUScene() -> int:
	"""Returns (and create if it does not exist) a global GPU scene (with the scene root) to be used commonly by several clients

	Returns:
		scene (int): Identifier of the global GPU Scene
	"""
	...

def getLastAABB(scene: int, viewer: int) -> geom.AABB:
	"""Return the lastAABB computed during a frame drawing, requires the viewer property ComputeLastAABB to be True

	Args:
		scene (int): Identifier of the GPU scene to get the last AABB from
		viewer (int): 

	Returns:
		aabb (geom.AABB): The last scene AABB computed during the last frame
	"""
	...

def getOccurrenceIndex(occurrence: int, scene: int) -> int:
	"""Returns the occurrence index in the viewer buffers. Can be used for mapping an index retrieved in a GLTextureHandle id map.

	Args:
		occurrence (int): Occurrence identifier
		scene (int): Scene identifier

	Returns:
		index (int): Occurrence index
	"""
	...

def getSceneIndex(scene: int, viewer: int) -> int:
	"""Returns the GPU scene index in the viewer buffers. Can be used for mapping an index retrieved in a GLTextureHandle id map.

	Args:
		scene (int): GPU scene identifier
		viewer (int): Viewer identifier

	Returns:
		index (int): GPU scene index
	"""
	...

def lockGPUSceneUpdate(scene: int) -> None:
	"""Lock the mutex that ensure no update of the gpu scene is done between lock/unlock

	Args:
		scene (int): Identifier of the GPU scene to lock update for
	"""
	...

def lockGPUScenesUpdate(scenes: list[int]) -> None:
	"""Lock the mutex that ensure no update of multiple gpu scenes is done between lock/unlock

	Args:
		scenes (list[int]): Identifiers of the GPU scenes to lock update for
	"""
	...

def tryLockGPUSceneUpdate(scene: int) -> bool:
	"""Try to lock the mutex that ensure no update of the gpu scene is done between lock/unlock, returns true if the mutex has been locked, false if it was already locked

	Args:
		scene (int): Identifier of the GPU scene to try to lock update for

	Returns:
		locked (bool): True if the mutex has been successfully locked
	"""
	...

def tryLockGPUScenesUpdate(scenes: list[int]) -> list[bool]:
	"""Try to lock the mutex that ensure no update of multiple gpu scenes is done between lock/unlock, returns true if the mutex has been locked, false if it was already locked

	Args:
		scenes (list[int]): Identifiers of the GPU scenes to try to lock update for

	Returns:
		locked (list[bool]): For each scene, true if the mutex has been successfully locked
	"""
	...

def unlockGPUSceneUpdate(scene: int) -> None:
	"""Unlock the mutex that ensure no update of the gpu scene is done between lock/unlock

	Args:
		scene (int): Identifier of the GPU scene to unlock update for
	"""
	...

def unlockGPUScenesUpdate(scenes: list[int]) -> None:
	"""Unlock the mutex that ensure no update of multiple gpu scenes is done between lock/unlock

	Args:
		scenes (list[int]): Identifiers of the GPU scenes to unlock update for
	"""
	...

def addGPUScene(scene: int, viewer: int = -1) -> None:
	"""Add a GPU scene to a viewer

	Args:
		scene (int): GPU Scene to render in the viewer
		viewer (int): Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
	"""
	...

def captureNextFrame(viewer: int) -> None:
	"""Debug: capture next frame with renderdoc (only if launched with renderdoc)

	Args:
		viewer (int): Viewer to capture
	"""
	...

def createViewer(width: int, height: int, sharedContext: GraphicsContext = view.GraphicsContext(), nbViews: int = 1) -> int:
	"""Create a new viewer

	Args:
		width (int): Width of the viewer framebuffer
		height (int): Height of the viewer framebuffer
		sharedContext (GraphicsContext): Interop context handle
		nbViews (int): Nb views

	Returns:
		viewer (int): 
	"""
	...

def destroyViewer(viewer: int) -> None:
	"""

	Args:
		viewer (int): Viewer to destroy
	"""
	...

def drawCappingPlane(cuttingPlane: int) -> int:
	"""Create an occurrence that holds the mesh of the surfaces that have been cut by the cutting plane

	Args:
		cuttingPlane (int): Cutting plane component for which we create the capping plane

	Returns:
		root (int): The created occurrence
	"""
	...

def getAutoClipping(viewer: int, cameraPos: geom.Point3) -> geom.Point2:
	"""Automatically compute the near and far planes depending on the scene

	Args:
		viewer (int): Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
		cameraPos (geom.Point3): 

	Returns:
		clipping (geom.Point2): 
	"""
	...

def getCameraFrontAxis(viewer: int = -1, matrixIndex: int = 0) -> geom.Point3:
	"""Get the front axis of the nth view matrix of a given viewer

	Args:
		viewer (int): Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
		matrixIndex (int): Index of the view matrix to use.

	Returns:
		axis (geom.Point3): 
	"""
	...

def getCameraPosition(viewer: int = -1, matrixIndex: int = 0) -> geom.Point3:
	"""Get the position of the nth view matrix of a given viewer

	Args:
		viewer (int): Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
		matrixIndex (int): Index of the view matrix to use.

	Returns:
		position (geom.Point3): 
	"""
	...

def getCameraRightAxis(viewer: int = -1, matrixIndex: int = 0) -> geom.Point3:
	"""Get the right axis of the nth view matrix of a given viewer

	Args:
		viewer (int): Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
		matrixIndex (int): Index of the view matrix to use.

	Returns:
		axis (geom.Point3): 
	"""
	...

def getCameraUpAxis(viewer: int = -1, matrixIndex: int = 0) -> geom.Point3:
	"""Get the up axis of the nth view matrix of a given viewer

	Args:
		viewer (int): Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
		matrixIndex (int): Index of the view matrix to use.

	Returns:
		axis (geom.Point3): 
	"""
	...

def getViewerProperty(propertyName: str, viewer: int = -1) -> str:
	"""Get a viewer property value

	Args:
		propertyName (str): 
		viewer (int): Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).

	Returns:
		propertyValue (str): 
	"""
	...

def getViewerPropertyInfo(propertyName: str, viewer: int = -1) -> core.PropertyInfo:
	"""Get a viewer property info

	Args:
		propertyName (str): 
		viewer (int): Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).

	Returns:
		propertyInfo (core.PropertyInfo): 
	"""
	...

def getViewerSize(viewer: int = -1) -> dict:
	"""Retrieve the viewport size of a viewer

	Args:
		viewer (int): Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).

	Returns:
		width (int): 
		height (int): 
	"""
	...

def getViewerStats(viewer: int = -1) -> dict:
	"""

	Args:
		viewer (int): Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).

	Returns:
		renderedOccurrences (int): Number of rendered occurrences
		renderedTriangles (int): Number of rendered triangles
	"""
	...

def listViewerProperties(viewer: int = -1) -> list[core.PropertyInfo]:
	"""Get the list of viewer properties

	Args:
		viewer (int): Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).

	Returns:
		properties (list[core.PropertyInfo]): 
	"""
	...

def pick(x: int, y: int, viewer: int = -1) -> dict:
	"""

	Args:
		x (int): 
		y (int): 
		viewer (int): 

	Returns:
		occurrence (int): Picked occurrence, 0 if not occurrence picked
		position (geom.Point3): World space position of the picking point
		primitiveId (int): Depending of the Part shape representation, it can be a triangle/quadrangle index (Mesh) or a Face identifier (BRep)
	"""
	...

def pickRectangle(xMin: int, xMax: int, yMin: int, yMax: int, viewer: int = -1, inDepth: bool = False) -> list[int]:
	"""

	Args:
		xMin (int): 
		xMax (int): 
		yMin (int): 
		yMax (int): 
		viewer (int): 
		inDepth (bool): 

	Returns:
		occurrences (list[int]): List of picked occurrences
	"""
	...

def refreshViewer(viewer: int = -1) -> None:
	"""Refresh the viewer

	Args:
		viewer (int): Viewer to refresh
	"""
	...

def removeGPUScene(scene: int, viewer: int = -1) -> None:
	"""Remove a viewer root

	Args:
		scene (int): GPU Scene to remove from the viewer
		viewer (int): Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
	"""
	...

def resizeViewer(width: int, height: int, viewer: int = -1) -> None:
	"""

	Args:
		width (int): Width of the viewer framebuffer
		height (int): Height of the viewer framebuffer
		viewer (int): Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
	"""
	...

def selectPrimitives(xMin: int, xMax: int, yMin: int, yMax: int, primitiveType: PrimitiveSelectionType, viewer: int = -1) -> None:
	"""Select the primitives (polygons, surfaces) contained in the given rectangle

	Args:
		xMin (int): 
		xMax (int): 
		yMin (int): 
		yMax (int): 
		primitiveType (PrimitiveSelectionType): 
		viewer (int): 
	"""
	...

def setDefaultViewerId(viewer: int) -> None:
	"""Set default viewer id. This viewer will be used in other functions taking a Viewer as a parameter. Useful if a viewer needs to be shared across different contexts.

	Args:
		viewer (int): 
	"""
	...

def setViewerProperty(propertyName: str, propertyValue: str, viewer: int = -1) -> None:
	"""Set a viewer property value

	Args:
		propertyName (str): 
		propertyValue (str): 
		viewer (int): Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
	"""
	...

def getCompositedImage(viewer: int) -> material.ImageDefinition:
	"""

	Args:
		viewer (int): 

	Returns:
		image (material.ImageDefinition): Returned composited image
	"""
	...

def getRenderMapImage(viewer: int, renderMap: RenderMap) -> material.ImageDefinition:
	"""

	Args:
		viewer (int): 
		renderMap (RenderMap): 

	Returns:
		image (material.ImageDefinition): Returned composited image
	"""
	...

def takeScreenshot(fileName: str, viewer: int) -> None:
	"""

	Args:
		fileName (str): Path where to save the screenshot
		viewer (int): 
	"""
	...

def createStreamedViewer(width: int, height: int, encoderSettings: EncoderSettings = EncoderSettings(), useWebRTC: bool = False, webRTCInfo: WebRTCInfo = WebRTCInfo()) -> StreamedViewerInfo:
	"""create a viewer for streaming

	Args:
		width (int): Width of the viewer framebuffer
		height (int): Height of the viewer framebuffer
		encoderSettings (EncoderSettings): Settings used for the encoder
		useWebRTC (bool): Switch between raw websockets and webRTC
		webRTCInfo (WebRTCInfo): Info for web rtc signaling connection

	Returns:
		streamedViewerInfo (StreamedViewerInfo): Port and host for stream connection
	"""
	...

def resizeStreamedViewer(width: int, height: int, viewer: int = -1, encoderSettings: EncoderSettings = EncoderSettings()) -> None:
	"""

	Args:
		width (int): Width of the viewer framebuffer
		height (int): Height of the viewer framebuffer
		viewer (int): 
		encoderSettings (EncoderSettings): Settings used for the encoder
	"""
	...

def startRecording(filePath: str, viewer: int, encoderSettings: EncoderSettings = EncoderSettings()) -> None:
	"""record viewer in a file

	Args:
		filePath (str): File in which video while be saved
		viewer (int): Viewer to use for recording video
		encoderSettings (EncoderSettings): Settings used for the encoder
	"""
	...

def stopRecording(viewer: int) -> None:
	"""stop recording video

	Args:
		viewer (int): Viewer to use for recording video
	"""
	...

def fitCamera(direction: geom.Point3, cameraType: CameraType = 1, fov: float = 90, viewer: int = -1, fitToOccurrences: list[int] = []) -> None:
	"""Set the viewer matrices to adjust the camera to the scene

	Args:
		direction (geom.Point3): Camera direction
		cameraType (CameraType): Camera type, Orthographic or Perspective
		fov (float): Field of view (perspective mode only)
		viewer (int): Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
		fitToOccurrences (list[int]): 
	"""
	...

def getViewerMatrices(viewer: int = -1) -> dict:
	"""

	Args:
		viewer (int): Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).

	Returns:
		views (list[list[list[float]]]): 
		projs (list[list[list[float]]]): 
		clipping (geom.Point2): 
	"""
	...

def setViewerMatrices(views: list[list[list[float]]], projs: list[list[list[float]]], clipping: geom.Point2, viewer: int = -1) -> None:
	"""

	Args:
		views (list[list[list[float]]]): 
		projs (list[list[list[float]]]): 
		clipping (geom.Point2): 
		viewer (int): Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
	"""
	...

def visibilityShoot(viewer: int = -1, parts: bool = True, patches: bool = True, polygons: bool = True, countOnce: bool = False) -> list[int]:
	"""Render one frame of the visibility session

	Args:
		viewer (int): Viewer to use for the visibility shoot
		parts (bool): If false, optimize when parts seen are not wanted
		patches (bool): If false, optimize when patches seen are not wanted
		polygons (bool): If false, optimize when polygons seen are not wanted
		countOnce (bool): Optimize when it is not needed to count the numbers of pixels seen during the session

	Returns:
		sceneOccurrences (list[int]): The list of scene paths seen from this shoot
	"""
	...

# Callbacks
def addAfterFramebufferCreateCallback(callback: Callable[[int], None], userdata):
	"""event emited once the frame buffer is created
	"""
	...

def removeAfterFramebufferCreateCallback(id: int):
	"""Remove callback added with view.addAfterFramebufferCreateCallback
	"""
	...

def addAfterViewerPropertyChangedCallback(callback: Callable[[int, str], None], userdata):
	"""emitted after a viewer's property is changed
	"""
	...

def removeAfterViewerPropertyChangedCallback(id: int):
	"""Remove callback added with view.addAfterViewerPropertyChangedCallback
	"""
	...

def addBeforeFramebufferDeleteCallback(callback: Callable[[int], None], userdata):
	"""event emited before the frame buffer is deleted
	"""
	...

def removeBeforeFramebufferDeleteCallback(id: int):
	"""Remove callback added with view.addBeforeFramebufferDeleteCallback
	"""
	...

def addBeforeViewerPropertyChangedCallback(callback: Callable[[int, str], None], userdata):
	"""emitted before a viewer's property is changed
	"""
	...

def removeBeforeViewerPropertyChangedCallback(id: int):
	"""Remove callback added with view.addBeforeViewerPropertyChangedCallback
	"""
	...

def addAnimationPausedOrStoppedCallback(callback: Callable[[int], None], userdata):
	"""
	"""
	...

def removeAnimationPausedOrStoppedCallback(id: int):
	"""Remove callback added with view.addAnimationPausedOrStoppedCallback
	"""
	...

def addAnimationPlayedOrResumedCallback(callback: Callable[[int], None], userdata):
	"""
	"""
	...

def removeAnimationPlayedOrResumedCallback(id: int):
	"""Remove callback added with view.addAnimationPlayedOrResumedCallback
	"""
	...

def addAnimationPlayingStatusChangedCallback(callback: Callable[[int, AnimationPlayerInfo], None], userdata):
	"""
	"""
	...

def removeAnimationPlayingStatusChangedCallback(id: int):
	"""Remove callback added with view.addAnimationPlayingStatusChangedCallback
	"""
	...

