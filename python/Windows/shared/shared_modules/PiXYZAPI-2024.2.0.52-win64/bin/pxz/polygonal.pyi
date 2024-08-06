from enum import Enum
from collections.abc import Callable

from pxz import core
from pxz import geom
from pxz import material

# Constants

# Classes
class MeshDefinition:
	"""Mesh definition
	"""
	id: int
	externalId: int
	vertices: list[geom.Point3]
	normals: list[geom.Point3]
	tangents: list[geom.Point4]
	uvChannels: list[int]
	uvs: list[list[geom.Point2]]
	vertexColors: list[core.ColorAlpha]
	curvatures: list[geom.Curvatures]
	triangles: list[int]
	quadrangles: list[int]
	vertexMerged: list[int]
	submeshes: list[Submesh]
	linesVertices: list[geom.Point3]
	lines: list[StylizedLine]
	points: list[geom.Point3]
	pointsColors: list[geom.Point3]
	joints: list[int]
	inverseBindMatrices: list[list[list[float]]]
	jointWeights: list[geom.Point4]
	jointIndices: list[geom.Vector4I]
	def __init__(self, id: int, externalId: int, vertices: list[geom.Point3], normals: list[geom.Point3], tangents: list[geom.Point4], uvChannels: list[int], uvs: list[list[geom.Point2]], vertexColors: list[core.ColorAlpha], curvatures: list[geom.Curvatures], triangles: list[int], quadrangles: list[int], vertexMerged: list[int], submeshes: list[Submesh], linesVertices: list[geom.Point3], lines: list[StylizedLine], points: list[geom.Point3], pointsColors: list[geom.Point3], joints: list[int], inverseBindMatrices: list[list[list[float]]], jointWeights: list[geom.Point4], jointIndices: list[geom.Vector4I]) -> None: ...
	...

class StyleType(Enum):
	"""
	"""
	NORMAL: int
	STIPPLE: int
	...

class StylizedLine:
	"""
	"""
	lineVertexIndices: list[int]
	material: int
	externalId: int
	def __init__(self, lineVertexIndices: list[int], material: int, externalId: int) -> None: ...
	...

class Submesh:
	"""Submesh for polygon material assignation
	"""
	material: int
	firstTri: int
	triCount: int
	firstQuad: int
	quadCount: int
	externalId: int
	def __init__(self, material: int, firstTri: int, triCount: int, firstQuad: int, quadCount: int, externalId: int) -> None: ...
	...

class TopologyCategoryMask:
	"""The topology cmasl is a combination of TopologyConnectivityMask and TopologyDimensionMask
	"""
	dimension: TopologyDimensionMask
	connectivity: TopologyConnectivityMask
	def __init__(self, dimension: TopologyDimensionMask, connectivity: TopologyConnectivityMask) -> None: ...
	...

class TopologyConnectivityMask(Enum):
	"""The topology connectivity mask is used to filter some processus using the topological connectivity of elements (border, non-manifold, etc...)
	"""
	NONE: int
	MANIFOLD: int
	BOUNDARY: int
	NONMANIFOLD: int
	BOUNDARY_NONMANIFOLD: int
	FREE: int
	ALL: int
	...

class TopologyDimensionMask(Enum):
	"""The topology dimension mask is used to filter some processes using the topological dimension of the support of vertices
	"""
	NONE: int
	VERTEX: int
	LINE: int
	FACE: int
	ALL: int
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

def computeMeshTopoChecksum(mesh: int) -> str:
	"""Compute a checksum of the mesh topology, connectivity

	Args:
		mesh (int): The mesh

	Returns:
		checksum (str): The mesh
	"""
	...

def computeMeshVertexPositionsChecksum(mesh: int, precisionFloat: int = -1) -> str:
	"""Compute a checksum of the mesh vertices positions

	Args:
		mesh (int): The mesh
		precisionFloat (int): Floating point precision [1..24], number of significant numbers kept. -1 means no rounded will be applied

	Returns:
		checksum (str): The mesh
	"""
	...

def computeUVTopoChecksum(mesh: int, uvChannel: int) -> str:
	"""Compute a checksum of the uvs topology, connectivity

	Args:
		mesh (int): The mesh
		uvChannel (int): The uv channel

	Returns:
		checksum (str): The mesh
	"""
	...

def computeUVVertexPositionsChecksum(mesh: int, uvChannel: int, precisionFloat: int = -1) -> str:
	"""Compute a checksum of the vertices positions in uv space

	Args:
		mesh (int): The mesh
		uvChannel (int): The uv channel
		precisionFloat (int): Floating point precision [1..24], number of significant numbers kept. -1 means no rounded will be applied

	Returns:
		checksum (str): The mesh
	"""
	...

def dracoDecode(buffer: list[core.Byte], jointIndicesId: int = -1, jointWeightsId: int = -1) -> int:
	"""decode a mesh using draco

	Args:
		buffer (list[core.Byte]): 
		jointIndicesId (int): Unique ID of Generic attribute encoding joint indices
		jointWeightsId (int): Unique ID of Generic attribute encoding joint weights

	Returns:
		mesh (int): 
	"""
	...

def dracoEncode(mesh: int, compressionLevel: int = 7, quantizationPosition: int = -1, quantizationNormal: int = -1, quantizationTexCoord: int = -1) -> dict:
	"""encode a mesh using draco

	Args:
		mesh (int): 
		compressionLevel (int): 0=faster but the worst compression, 10=slower but the best compression
		quantizationPosition (int): Number of quantization bits used for position attributes
		quantizationNormal (int): Number of quantization bits used for normal attributes
		quantizationTexCoord (int): Number of quantization bits used for texture coordinates attributes

	Returns:
		buffer (list[core.Byte]): 
		jointIndicesId (int): Unique ID of Generic attribute encoding joint indices (-1 if not applicable or if enocdeSkeleton is false)
		jointWeightsId (int): Unique ID of Generic attribute encoding joint weights (-1 if not applicable or if enocdeSkeleton is false)
	"""
	...

def createJointPlaceholders(data: list[int], worldMatrices: list[list[list[float]]]) -> list[int]:
	"""Create fake joint to store in mesh definitions. Thus we can retrieve stored data from getJointPlaceholders

	Args:
		data (list[int]): Create as much joints as there are data, each joint store one data
		worldMatrices (list[list[list[float]]]): World matrix for each joints

	Returns:
		joints (list[int]): Returns one placeholder joint per given data
	"""
	...

def createMeshFromDefinition(meshDefinition: MeshDefinition) -> int:
	"""Create a new mesh with the given MeshDefinition

	Args:
		meshDefinition (MeshDefinition): Mesh definition

	Returns:
		mesh (int): The new mesh
	"""
	...

def createMeshFromDefinitions(meshDefinition: list[MeshDefinition]) -> int:
	"""Create a new mesh from multiple MeshDefinition

	Args:
		meshDefinition (list[MeshDefinition]): The MeshDefinitions

	Returns:
		mesh (int): The new mesh
	"""
	...

def createMeshFromText(text: str, matrix: list[list[float]], font: str = "ChicFont", fontSize: int = 64, color: core.ColorAlpha = core.ColorAlpha(), heigth3D: float = 40) -> dict:
	"""Creates an occurrence from string

	Args:
		text (str): Text to create
		matrix (list[list[float]]): A matrix to apply on mesh
		font (str): The font to use
		fontSize (int): The font size
		color (core.ColorAlpha): The occurrence color
		heigth3D (float): 3D height of text

	Returns:
		mesh (int): 
		material (int): 
	"""
	...

def createMeshesFromDefinitions(meshDefinitions: list[MeshDefinition]) -> list[int]:
	"""Create new meshes with the given MeshDefinitions

	Args:
		meshDefinitions (list[MeshDefinition]): The MeshDefinitions

	Returns:
		meshes (list[int]): The new Meshes
	"""
	...

def getJointPlaceholders(joints: list[int]) -> list[int]:
	"""Get data stored in joint placeholders

	Args:
		joints (list[int]): Placeholder joints to get data from

	Returns:
		data (list[int]): Data stored in each placehold joint (for invalid joint, returned data is undefined)
	"""
	...

def getMeshDefinition(mesh: int) -> MeshDefinition:
	"""Returns the definition

	Args:
		mesh (int): The mesh to get definition

	Returns:
		meshDefinition (MeshDefinition): Mesh definition
	"""
	...

def getMeshDefinitions(meshes: list[int]) -> list[MeshDefinition]:
	"""Returns the definition

	Args:
		meshes (list[int]): The meshes to get definitions

	Returns:
		meshDefinitions (list[MeshDefinition]): The MeshDefinitions
	"""
	...

def getMeshSkinning(mesh: int) -> dict:
	"""Returns the joints/IBMs list of a given mesh (those referenced by jointIndices)

	Args:
		mesh (int): 

	Returns:
		joints (list[int]): 
		IBMs (list[list[list[float]]]): Inverse Bind Matrices
	"""
	...

def hasMeshJoints(mesh: int) -> bool:
	"""Check if the mesh has joints

	Args:
		mesh (int): The Mesh

	Returns:
		value (bool): Return True if the mesh contains joints
	"""
	...

def setMeshSkinning(mesh: int, joints: list[int], IBMs: list[list[list[float]]]) -> None:
	"""Set/Replace the list of joints/IBMs of a given mesh (those referenced by jointIndices)

	Args:
		mesh (int): 
		joints (list[int]): 
		IBMs (list[list[list[float]]]): Inverse Bind Matrices
	"""
	...

def usePointGapFillerNormal(points: list[geom.Point3], normals: list[geom.Point3]) -> list[int]:
	"""This triangulates a set of points and normals

	Args:
		points (list[geom.Point3]): The set of points to triangulate
		normals (list[geom.Point3]): The normals associated to the points to triangulate. This can be empty

	Returns:
		triangulation (list[int]): The indexes of the points from the given array arranged as triangles
	"""
	...

# Callbacks
