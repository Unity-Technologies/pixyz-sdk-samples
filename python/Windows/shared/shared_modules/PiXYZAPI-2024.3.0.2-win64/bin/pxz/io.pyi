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
	def __init__(self, path: str, token: str) -> None: ...
	...

class FileFormat:
	"""describe the file format
	"""
	extension: str
	priority: PriorityImportLevel
	read: bool
	write: bool
	product: str
	def __init__(self, extension: str, priority: PriorityImportLevel, read: bool, write: bool, product: str) -> None: ...
	...

class LocalDirectoryAccess:
	"""Local file
	"""
	path: str
	def __init__(self, path: str) -> None: ...
	...

class LocalFileAccess:
	"""Local file
	"""
	path: str
	def __init__(self, path: str) -> None: ...
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
	def __init__(self, path: str, authUrl: str, region: str, user: str, password: str, domainId: str, projectId: str, container: str, objectStore: str) -> None: ...
	...

class OwnCloudAccess:
	"""OwnCloud connection informations
	"""
	path: str
	authUrl: str
	user: str
	password: str
	def __init__(self, path: str, authUrl: str, user: str, password: str) -> None: ...
	...

class PriorityImportLevel(Enum):
	"""Priority levels for importer
	"""
	unavailable: int
	Priority_1: int
	Priority_2: int
	Priority_3: int
	Priority_4: int
	Priority_5: int
	Priority_6: int
	Priority_7: int
	Priority_8: int
	Priority_9: int
	Priority_10: int
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
	def __init__(self, path: str, host: str, port: int, protocol: Protocol, user: str, password: str, url: str) -> None: ...
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

def addAssetPaths(path: list[str]) -> None:
	"""add directory paths to search assets in

	Args:
		path (list[str]): The paths to add
	"""
	...

def clearAssetPaths() -> None:
	"""clear all asset paths
	"""
	...

def findInDirectories(filePath: str) -> str:
	"""find the final path. This will search for the file in asset paths

	Args:
		filePath (str): The (relative) file path to search for

	Returns:
		finalPath (str): The returned final path
	"""
	...

def getAssetPaths() -> list[str]:
	"""get user defined paths to find assets

	Returns:
		assetPaths (list[str]): The asset paths
	"""
	...

def setAssetPaths(assetPaths: list[str]) -> None:
	"""replace paths to find assets

	Args:
		assetPaths (list[str]): The asset paths
	"""
	...

def applyAutoTessellate(part: int) -> None:
	"""Handle auto tessellate options on given part, need to be complete

	Args:
		part (int): Part to be auto tessellated
	"""
	...

def exportScene(fileName: str, root: int = 1) -> None:
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
	"""Load partial model

	Args:
		component (int): The component to load
		recursively (bool): Load it recursively or not
	"""
	...

def unloadReferencedData(component: int) -> None:
	"""Unload partial model

	Args:
		component (int): The component to unload
	"""
	...

def registerIOCallbacks(name: str, importCallback: Callable[[str, int], None], exportCallback: Callable[[int, str], None], fileFormats: list[FileFormat]) -> None:
	"""Register import and export callbacks

	Args:
		name (str): Callback name
		importCallback (Callable[[str, int], None]): Callback that import a file
		exportCallback (Callable[[int, str], None]): Callback that exports to a file
		fileFormats (list[FileFormat]): Gives the extension and parameters to Import/Export
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

def getExtensionPriority(extensionName: str) -> PriorityImportLevel:
	"""get the priority of an extension from the pixyz importer

	Args:
		extensionName (str): The name of the extension

	Returns:
		priority (PriorityImportLevel): The level of priority of the extension
	"""
	...

# Callbacks
