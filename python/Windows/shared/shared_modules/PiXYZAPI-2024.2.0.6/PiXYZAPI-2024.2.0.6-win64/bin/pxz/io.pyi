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
class DropBoxAccess:
	"""DropBox connection informations
	"""
	path: str
	token: str
	def __init__(self, path: str, token: str) -> DropBoxAccess: ...
	...

class LocalDirectoryAccess:
	"""Local file
	"""
	path: str
	def __init__(self, path: str) -> LocalDirectoryAccess: ...
	...

class LocalFileAccess:
	"""Local file
	"""
	path: str
	def __init__(self, path: str) -> LocalFileAccess: ...
	...

class OpenStackAccess:
	"""OpenStack connection informations
	"""
	path: str
	authUrl: str
	region: str
	user: str
	password: str
	domainId: str
	projectId: str
	container: str
	objectStore: str
	def __init__(self, path: str, authUrl: str, region: str, user: str, password: str, domainId: str, projectId: str, container: str, objectStore: str) -> OpenStackAccess: ...
	...

class OwnCloudAccess:
	"""OwnCloud connection informations
	"""
	path: str
	authUrl: str
	user: str
	password: str
	def __init__(self, path: str, authUrl: str, user: str, password: str) -> OwnCloudAccess: ...
	...

class Protocol(Enum):
	"""Web access protocol
	"""
	HTTP: int
	HTTPS: int
	...

class WebDAVAccess:
	"""WebDAV connection informations
	"""
	path: str
	host: str
	port: int
	protocol: Protocol
	user: str
	password: str
	url: str
	def __init__(self, path: str, host: str, port: int, protocol: Protocol, user: str, password: str, url: str) -> WebDAVAccess: ...
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

def exportSceneToDTPlatform(root: int, directory: str) -> None:
	"""Export current scene to a local directory

	Args:
		root (int): Identifier of the destination occurrence
		directory (str): Directory to export in
	"""
	...

def exportSceneToReflect(root: int = 1, sourceName: str = "", uid: str = "", keepHierarchy: bool = False, configFile: str = "", disableDecimation: bool = True) -> None:
	"""Export current scene to a reflect project

	Args:
		root (int): Identifier of the destination occurrence
		sourceName (str): Push source name
		uid (str): UID of the push, overwrite old push if it's same UID
		keepHierarchy (bool): Keep hierarchy or rake tree
		configFile (str): Use existing JSON config file, discard reflect UI prompt
		disableDecimation (bool): Forces to disable the decimation applied on SyncObjectInstances on Reflect Server side
	"""
	...

def importSceneFromDTPlatform(directory: str, root: int = 0) -> None:
	"""Import scene from a local directory

	Args:
		directory (str): Directory to import from
		root (int): Identifier of the destination occurrence
	"""
	...

def exportScene(fileName: str, root: int = 0) -> None:
	"""Export a file

	Args:
		fileName (str): Path of the file to export
		root (int): Identifier of the root occurrence to export
	"""
	...

def exportSelection(fileName: str, keepIntermediaryNodes: bool = False) -> None:
	"""Export the selection to a file

	Args:
		fileName (str): Path of the file to export
		keepIntermediaryNodes (bool): If true, intermerdiary hierarchy is kept
	"""
	...

def getExportFormats() -> list[core.Format]:
	"""Give all the format name and their extensions that can be exported in Pixyz

	Returns:
		formats (list[core.Format]): Formats that can be exported in Pixyz
	"""
	...

def getImportFormats() -> list[core.Format]:
	"""Give all the format name and their extensions that can be imported in Pixyz

	Returns:
		formats (list[core.Format]): Formats that can be imported in Pixyz
	"""
	...

def importFiles(fileNames: list[str], root: int = 0) -> list[int]:
	"""Import files

	Args:
		fileNames (list[str]): List of files's paths to import
		root (int): Identifier of the destination occurrence

	Returns:
		dest (list[int]): The root occurrences of each imported file
	"""
	...

def importPicture(filename: str, root: int = 0) -> int:
	"""Imports a picture and applies is at as a texture on a 3D plane created in the scene.

	Args:
		filename (str): Path of the file to import
		root (int): Identifier of the destination occurrence

	Returns:
		dest (int): The root occurrence if defined, otherwise a new occurrence created by the importer
	"""
	...

def importRemote3mxFile(filePath: str, origin: str = "", root: int = 0) -> int:
	"""Import a remote 3mx file

	Args:
		filePath (str): The path of the temp file
		origin (str): Remote origin of the file
		root (int): Identifier of the destination occurrence

	Returns:
		dest (int): The root occurrence if defined, otherwise a new occurrence created by the importer
	"""
	...

def importScene(fileName: str, root: int = 0) -> int:
	"""Import a file

	Args:
		fileName (str): Path of the file to import
		root (int): Identifier of the destination occurrence

	Returns:
		dest (int): The root occurrence if defined, otherwise a new occurrence created by the importer
	"""
	...

def listVariants(fileName: str) -> list[str]:
	"""List all variants if file

	Args:
		fileName (str): Path of the file to import

	Returns:
		variants (list[str]): List all variants
	"""
	...

def loadReferencedData(component: int, recursively: bool) -> None:
	"""

	Args:
		component (int): The component to load
		recursively (bool): Load it recursively or not
	"""
	...

def registerImportCallback(name: str, extensions: list[str], callback: Callable[[str, int], None]) -> None:
	"""add new homade importer

	Args:
		name (str): Callback name
		extensions (list[str]): Handled extensions
		callback (Callable[[str, int], None]): Callback that import a file
	"""
	...

def splitPointCloud(files: list[str], outputDirectory: str, minVoxSize: float, useKDTree: bool, aabb: geom.AABB = geom.AABB(), density: float = -1) -> None:
	"""

	Args:
		files (list[str]): Path of the point cloud files to process
		outputDirectory (str): Output directory
		minVoxSize (float): Size of minimum leaves (mm)
		useKDTree (bool): If true, uses a kd_tree, otherwise, uses an octree
		aabb (geom.AABB): Global scene aabb
		density (float): Point cloud density (-1 to compute)
	"""
	...

# Callbacks
