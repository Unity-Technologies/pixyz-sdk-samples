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
class AlignmentMode(Enum):
	"""
	"""
	Auto: int
	Portrait: int
	Landscape: int
	...

class AttributType(Enum):
	"""
	"""
	Patches: int
	PatchMaterials: int
	PatchBoundaries: int
	UVs: int
	Normals: int
	Tangents: int
	Binormals: int
	...

class BakeMap:
	"""
	"""
	type: MapType
	properties: list[scene.PropertyValue]
	def __init__(self, type: MapType, properties: list[scene.PropertyValue]) -> None: ...
	...

class BakeMaps:
	"""
	"""
	diffuse: bool
	normal: bool
	roughness: bool
	metallic: bool
	opacity: bool
	ambientOcclusion: bool
	emissive: bool
	def __init__(self, diffuse: bool, normal: bool, roughness: bool, metallic: bool, opacity: bool, ambientOcclusion: bool, emissive: bool) -> None: ...
	...

class BakeOption:
	"""
	"""
	resolution: int
	padding: int
	textures: BakeMaps
	def __init__(self, resolution: int, padding: int, textures: BakeMaps) -> None: ...
	...

class BakingMethod(Enum):
	"""
	"""
	RayOnly: int
	ProjOnly: int
	RayAndProj: int
	...

class Box:
	"""
	"""
	position: geom.Affine
	length: float
	height: float
	depth: float
	def __init__(self, position: geom.Affine, length: float, height: float, depth: float) -> None: ...
	...

class BoxParameters:
	"""
	"""
	SizeX: float
	SizeY: float
	SizeZ: float
	Subdivision: int
	def __init__(self, SizeX: float, SizeY: float, SizeZ: float, Subdivision: int) -> None: ...
	...

class BricksReturn:
	"""
	"""
	Root: int
	Bricks: list[cad.BrickDefinition]
	def __init__(self, Root: int, Bricks: list[cad.BrickDefinition]) -> None: ...
	...

class CapsuleParameters:
	"""
	"""
	Radius: float
	Height: float
	Latitude: int
	Longitude: int
	def __init__(self, Radius: float, Height: float, Latitude: int, Longitude: int) -> None: ...
	...

class ComputingQuality(Enum):
	"""
	"""
	High: int
	Medium: int
	Low: int
	...

class ConeParameters:
	"""
	"""
	BottomRadius: float
	Height: float
	Sides: int
	def __init__(self, BottomRadius: float, Height: float, Sides: int) -> None: ...
	...

class ConvexityFilter(Enum):
	"""
	"""
	OnConvex: int
	OnConcave: int
	OnConvexAndConcave: int
	...

class CostEvaluation(Enum):
	"""
	"""
	SumEvaluation: int
	MaxEvaluation: int
	AverageEvaluation: int
	...

class CreateOccluder(Enum):
	"""
	"""
	Occludee: int
	Occluder: int
	...

class CustomBakeMap:
	"""
	"""
	name: str
	component: int
	def __init__(self, name: str, component: int) -> None: ...
	...

class Cylinder:
	"""
	"""
	position: geom.Affine
	radius: float
	length: float
	def __init__(self, position: geom.Affine, radius: float, length: float) -> None: ...
	...

class CylinderParameters:
	"""
	"""
	Radius: float
	Height: float
	Sides: int
	def __init__(self, Radius: float, Height: float, Sides: int) -> None: ...
	...

class DiskSegmentationMethod(Enum):
	"""
	"""
	Perimeter: int
	GaussianCurvature: int
	...

class ElementFilter(Enum):
	"""
	"""
	Polygons: int
	Points: int
	Hybrid: int
	...

class Feature:
	"""
	"""
	type: FeatureType
	inputs: list[FeatureInput]
	def __init__(self, type: FeatureType, inputs: list[FeatureInput]) -> None: ...
	...

class FeatureInput:
	"""
	"""
	position: geom.Point3
	direction: geom.Point3
	diameter: float
	def __init__(self, position: geom.Point3, direction: geom.Point3, diameter: float) -> None: ...
	...

class FeatureType(Enum):
	"""
	"""
	Unknown: int
	ThroughHole: int
	BlindHole: int
	...

class FilletingMode(Enum):
	"""
	"""
	Width: int
	Distance: int
	Depth: int
	Radius: int
	...

class FlatteningStopCondition(Enum):
	"""
	"""
	MEAN_DEFORMATION: int
	ABSOLUTE_DEFORMATION: int
	...

class HexahedronParameters:
	"""
	"""
	XLength: float
	YLength: float
	ZLength: float
	def __init__(self, XLength: float, YLength: float, ZLength: float) -> None: ...
	...

class InnerOuterOption(Enum):
	"""
	"""
	All: int
	OnlyOuter: int
	OnlyInners: int
	...

class MapType(Enum):
	"""
	"""
	Diffuse: int
	Normal: int
	Opacity: int
	Roughness: int
	Specular: int
	Metallic: int
	AO: int
	Emissive: int
	PartId: int
	MaterialId: int
	ComputeAO: int
	Bent: int
	UV: int
	Displacement: int
	LocalPosition: int
	GlobalPosition: int
	Depth: int
	OccurrenceProperty: int
	Feature: int
	VertexColor: int
	...

class MeshBooleanOperation(Enum):
	"""
	"""
	SplitOnly: int
	Union: int
	Intersection: int
	Subtraction: int
	...

class OccurrenceFeatures:
	"""
	"""
	occurrence: int
	features: list[Feature]
	def __init__(self, occurrence: int, features: list[Feature]) -> None: ...
	...

class OctahedralImpostor:
	"""
	"""
	OctaTransform: list[list[float]]
	Radius: float
	NormalMap: int
	DepthMap: int
	DiffuseMap: int
	MetallicMap: int
	AOMap: int
	RoughnessMap: int
	def __init__(self, OctaTransform: list[list[float]], Radius: float, NormalMap: int, DepthMap: int, DiffuseMap: int, MetallicMap: int, AOMap: int, RoughnessMap: int) -> None: ...
	...

class OrientStrategy(Enum):
	"""
	"""
	ExteriorOnly: int
	VisibilityOrExterior: int
	VisibilityByConnected: int
	VisibilityByPolygon: int
	ConformToMajority: int
	...

class OrientStrategyAdvanced(Enum):
	"""
	"""
	VisibilityByConnected: int
	VisibilityByPolygon: int
	...

class Plane:
	"""
	"""
	position: geom.Affine
	length: float
	height: float
	def __init__(self, position: geom.Affine, length: float, height: float) -> None: ...
	...

class PlaneParameters:
	"""
	"""
	SizeX: float
	SizeY: float
	SubdivisionX: int
	SubdivisionY: int
	def __init__(self, SizeX: float, SizeY: float, SubdivisionX: int, SubdivisionY: int) -> None: ...
	...

class QualityMemoryTradeoff(Enum):
	"""
	"""
	PreferQuality: int
	PreferMemory: int
	...

class QualitySpeedTradeoff(Enum):
	"""
	"""
	PreferQuality: int
	PreferSpeed: int
	...

class RatioUV3DMode(Enum):
	"""
	"""
	SmallestRatio: int
	HighestRatio: int
	AverageRatio: int
	MedianRatio: int
	...

class RelaxUVMethod(Enum):
	"""
	"""
	Angle: int
	Edge: int
	...

class ReplaceByBoxType(Enum):
	"""
	"""
	Minimum: int
	LocallyAligned: int
	...

class ReplaceByMode(Enum):
	"""
	"""
	ByOccurrence: int
	All: int
	...

class ReplaceByOccurrenceOptions:
	"""
	"""
	Occurrence: int
	Aligned: bool
	def __init__(self, Occurrence: int, Aligned: bool) -> None: ...
	...

class ReplaceByPrimitiveOptions:
	"""
	"""
	Type: list
	Aligned: bool
	GenerateUV: bool
	def __init__(self, Type: list, Aligned: bool, GenerateUV: bool) -> None: ...
	...

class SawingMode(Enum):
	"""
	"""
	SawOnly: int
	SawAndSplit: int
	KeepInside: int
	KeepOutside: int
	...

class SelectionLevel(Enum):
	"""
	"""
	Parts: int
	Patches: int
	Polygons: int
	...

class Sphere:
	"""
	"""
	position: geom.Affine
	radius: float
	def __init__(self, position: geom.Affine, radius: float) -> None: ...
	...

class SphereParameters:
	"""
	"""
	Radius: float
	Latitude: int
	Longitude: int
	def __init__(self, Radius: float, Latitude: int, Longitude: int) -> None: ...
	...

class TransformationType(Enum):
	"""
	"""
	TRSOnly: int
	TRSAndSkew: int
	...

class UVGenerationMode(Enum):
	"""
	"""
	NoUV: int
	IntrinsicUV: int
	ConformalScaledUV: int
	...

class UVImportanceEnum(Enum):
	"""
	"""
	PreserveSeamsAndReduceDeformation: int
	PreserveSeams: int
	IgnoreUV: int
	...

class UnwrapUVMethod(Enum):
	"""
	"""
	Isometric: int
	Conformal: int
	...

class VisibilityToWeightMode(Enum):
	"""
	"""
	FrontCountOnly: int
	FrontAndBackCount: int
	FrontCountOnlyAreaWeighted: int
	FrontAndBackCountAreaWeighted: int
	...

# Functions
def assembleCAD(occurrences: list[int], tolerance: float, removeDuplicatedFaces: bool = True) -> None:
	"""Assemble faces of CAD shapes

	Args:
		occurrences (list[int]): Occurrences of components to assemble
		tolerance (float): Assembling tolerance
		removeDuplicatedFaces (bool): If True, duplicated faces will be removed
	"""
	...

def backToInitialBRep(occurrences: list[int]) -> None:
	"""Create the BRep shape from a Tessellated shape with Domain Patch Attributes (after tessellate)

	Args:
		occurrences (list[int]): Occurrences of components to process
	"""
	...

def bakeImpostor(occurrence: int, XFrames: int, YFrames: int, hemi: bool = False, resolution: int = 1024, padding: int = 0, roughness: bool = False, metallic: bool = False, ao: bool = False) -> OctahedralImpostor:
	"""bakes impostors textures

	Args:
		occurrence (int): 
		XFrames (int): 
		YFrames (int): 
		hemi (bool): 
		resolution (int): 
		padding (int): 
		roughness (bool): 
		metallic (bool): 
		ao (bool): 

	Returns:
		octahedralImp (OctahedralImpostor): The structure containing impostor data
	"""
	...

def bakeVertexAttributes(destinationOccurrences: list[int], sourceOccurrences: list[int], skinnedMesh: bool, positions: bool, useCurrentPositionAsTPose: bool = False) -> None:
	"""Bake vertex attributes on meshes from other meshes

	Args:
		destinationOccurrences (list[int]): Occurrences of the meshes where to store the baked vertex attributes
		sourceOccurrences (list[int]): Occurrences of components from which to bake vertex attributes
		skinnedMesh (bool): Enabling skinned mesh baking (joint assignation for animation transfer)
		positions (bool): Enabling vertex position baking
		useCurrentPositionAsTPose (bool): Use the current position as the T-Pose
	"""
	...

def calculateNormalsInPointClouds(occurrences: list[int]) -> None:
	"""calculate the normal of each point of a Point Cloud

	Args:
		occurrences (list[int]): Part occurrences to process
	"""
	...

def combineMeshesByMaterials(occurrences: list[int], mergeNoMaterials: bool = True, mergeHiddenPartsMode: scene.MergeHiddenPartsMode = 0) -> list[int]:
	"""Explode and (re)merge a set of mesh parts by visible materials

	Args:
		occurrences (list[int]): Occurrences of the parts to merge
		mergeNoMaterials (bool): If true, merge all parts with no active material together, else do not merge them
		mergeHiddenPartsMode (scene.MergeHiddenPartsMode): Hidden parts handling mode, Destroy them, make visible or merge separately

	Returns:
		mergedOccurrences (list[int]): Resulting occurrences of the merged parts
	"""
	...

def configureFunctionLogger(functionName: str, enableFunction: bool, enableParameters: bool, enableExecutionTime: bool) -> None:
	"""

	Args:
		functionName (str): 
		enableFunction (bool): 
		enableParameters (bool): 
		enableExecutionTime (bool): 
	"""
	...

def crackCADMoebiusStrip(occurrences: list[int]) -> None:
	"""Detect Moebius strip and crack them if there is somme of them in the selection

	Args:
		occurrences (list[int]): Occurrences of components to check
	"""
	...

def crackEdges(occurrences: list[int], useAttributesFilter: bool = True, sharpAngleFilter: float = 45, useNonManifoldFilter: bool = False) -> None:
	"""crack polygonal edges according to given criteria (deprecated, use crackMeshEdges instead)

	Args:
		occurrences (list[int]): Occurrences of components to process
		useAttributesFilter (bool): Filters by attribute
		sharpAngleFilter (float): Sharp angle in degree to filter by edges sharpness, if the angle is negative do not filter
		useNonManifoldFilter (bool): Filters by manifold-ness.
	"""
	...

def crackMeshEdges(occurrences: list[int], normal: bool = False, uvs: bool = False, uvChannels: list[int] = list[int](), loi: bool = False, patches: bool = False, nman: bool = False) -> None:
	"""crack polygonal edges according to given criteria

	Args:
		occurrences (list[int]): Occurrences of components to process
		normal (bool): Crack on sharp normals
		uvs (bool): Crack on UV seams
		uvChannels (list[int]): If empty and uvs=true, crack all UV channel, else only channel specified in the list
		loi (bool): Crack on identifier Lines of Interests
		patches (bool): Crack on patch borders
		nman (bool): Crack on non-manifolds
	"""
	...

def createFreeEdgesFromPatches(occurrences: list[int]) -> None:
	"""Create free edges from patch borders

	Args:
		occurrences (list[int]): Occurrences of components to process
	"""
	...

def createIdentifiedPatchesFromPatches(occurrences: list[int]) -> None:
	"""Create identified patch from existing patch (this is useful before cloning for baking)

	Args:
		occurrences (list[int]): Occurrences of components to process
	"""
	...

def createIndexMapFromOccurrences(occurrences: list[int], uvChannel: int, createTexture1D: bool) -> int:
	"""Create an IndexMap and add an UVSet so that each mesh will have UVs refering to one different pixel of the index map and that pixel will have the value i for occurrences[i]. Warning: all occurrences will be singularized

	Args:
		occurrences (list[int]): 
		uvChannel (int): 
		createTexture1D (bool): If true, the texture will have a resolution of 1 x occurrences.size, else a square power of two image will be created to fit occurrences.size pixels

	Returns:
		indexMap (int): 
	"""
	...

def createNormals(occurrences: list[int], sharpEdge: float = 45, override: bool = True, useAreaWeighting: bool = False) -> None:
	"""Create normal attributes on tessellations

	Args:
		occurrences (list[int]): Occurrences of components to create attributes
		sharpEdge (float): Edges with an angle between their polygons greater than sharpEdge will be considered sharp. If negative, smooth normals only.
		override (bool): If true, override existing normals, else only create normals on meshes without normals
		useAreaWeighting (bool): If true, normal computation will be weighted using polygon areas
	"""
	...

def createPointCloudKDTree(occurrences: list[int], depth: int, addToScene: bool = True) -> int:
	"""Create a KD-Tree from some point clouds occurrence, the given occurrences are deleted (even if they contains triangles) and the KD-Tree is represented in a new occurrence sub tree

	Args:
		occurrences (list[int]): Occurrences to process
		depth (int): Kd tree depth
		addToScene (bool): Add the KD-Tree to the current scene

	Returns:
		root (int): KD-Tree root occurrence
	"""
	...

def createTangents(occurrences: list[int], uvChannel: int = 0, override: bool = True) -> None:
	"""Create tangent attributes on tessellations

	Args:
		occurrences (list[int]): Occurrences of components to create attributes
		uvChannel (int): UV channel to use for the tangents creation
		override (bool): If true, override existing tangents, else only create tangents on meshes without tangents
	"""
	...

def createVertexColorFromMaterials(occurrenceList: list[int]) -> None:
	"""Bake vertex colors using main material color. May duplicate some vertices

	Args:
		occurrenceList (list[int]): 
	"""
	...

def createVisibilityPatchesFromPatch(occurrences: list[int]) -> None:
	"""Create visibility patches from existing patches

	Args:
		occurrences (list[int]): Occurrences of components to process
	"""
	...

def decimate(occurrences: list[int], surfacicTolerance: float, lineicTolerance: float = 0.1, normalTolerance: float = 5, texCoordTolerance: float = -1, releaseConstraintOnSmallArea: bool = False) -> None:
	"""reduce the polygon count by removing some vertices

	Args:
		occurrences (list[int]): Occurrences of components to process
		surfacicTolerance (float): Maximum distance between surfacic vertices and resulting simplified surfaces
		lineicTolerance (float): Maximum distance between lineic vertices and resulting simplified lines
		normalTolerance (float): Maximum angle between original normals and those interpolated on the simplified surface
		texCoordTolerance (float): Maximum distance (in 3D space) between original texcoords and those interpolated on the simplified surface
		releaseConstraintOnSmallArea (bool): If True, release constraint of normal and/or texcoord tolerance on small areas (according to surfacicTolerance)
	"""
	...

def decimateEdgeCollapse(occurrences: list[int], surfacicTolerance: float, boundaryWeight: float = 1., normalWeight: float = 1., UVWeight: float = 1., sharpNormalWeight: float = 1., UVSeamWeight: float = 10., normalMaxDeviation: float = -1, forbidUVOverlaps: bool = True, UVMaxDeviation: float = -1, UVSeamMaxDeviation: float = -1, protectTopology: bool = False, qualityTradeoff: QualitySpeedTradeoff = 0) -> None:
	"""reduce the polygon count by collapsing some edges to obtain an simplified mesh

	Args:
		occurrences (list[int]): Occurrences of components to process
		surfacicTolerance (float): Error max between the simplified mesh et the old one
		boundaryWeight (float): Boundary importance during the decimation
		normalWeight (float): Normal importance during the decimation
		UVWeight (float): UV importance during the decimation
		sharpNormalWeight (float): Importance of sharp edges during the decimation
		UVSeamWeight (float): Importance of UV seams during the decimation
		normalMaxDeviation (float): Constraint the normals deviation on decimated model
		forbidUVOverlaps (bool): Forbid UV to fold over and overlap during the decimation
		UVMaxDeviation (float): Constraint the uv deviation on decimated model
		UVSeamMaxDeviation (float): Constraint the uv seams deviation on decimated model
		protectTopology (bool): If false, the topology of the mesh can change and some edges can become non-manifold. But the visual quality will be better on model with complex topology
		qualityTradeoff (QualitySpeedTradeoff): For big models it is recommended to choose PreferSpeed tradeoff. In PreferSpeed mode, quadrics are computed only on position (and not on other vertex attributes)
	"""
	...

def decimatePointClouds(occurrences: list[int], tolerance: float = 500) -> None:
	"""decimate Point Cloud Occurrences according to tolerance 

	Args:
		occurrences (list[int]): Part occurrences to process
		tolerance (float): Avarage distance between points
	"""
	...

def decimateTarget(occurrences: list[int], targetStrategy: list, UVImportance: UVImportanceEnum = 0, protectTopology: bool = False, iterativeThreshold: int = 5000000, processMeshIndependently: bool = False, maxQuadricAge: int = -1) -> None:
	"""reduce the polygon count by collapsing some edges to obtain a target triangle count (iterative version that use less memory)

	Args:
		occurrences (list[int]): List of occurrences to process
		targetStrategy (list): Select between targetCount or ratio to define the number of triangles left after the decimation process
		UVImportance (UVImportanceEnum): Select importance of texture coordinates
		protectTopology (bool): If False, the topology of the mesh can change and some edges can become non-manifold
		iterativeThreshold (int): Number of triangles above which the iterative algorithm is used to limit the memory usage (disabled if processMeshIndependently=True)
		processMeshIndependently (bool): If true, each mesh will be processed independently and the triangleCount or ratio will apply by mesh (disable iterative method)
		maxQuadricAge (int): If >0, define the maximum memory (number of collapse) of a vertex before a new evaluation of its quadric
	"""
	...

def deleteAttibute(occurrence: int, type: AttributType) -> None:
	"""Delete designed attribute on tessellations

	Args:
		occurrence (int): Occurrence to detele attribute from
		type (AttributType): Attribute type
	"""
	...

def deleteBRepShapes(occurrences: list[int], onlyTessellated: bool = True) -> None:
	"""Delete BRep representation on parts

	Args:
		occurrences (list[int]): Occurrences of components to process
		onlyTessellated (bool): If True, delete only BRep represensation on part with a tessellated shape
	"""
	...

def deleteFreeVertices(occurrences: list[int]) -> None:
	"""Delete all free vertices of the mesh of given parts

	Args:
		occurrences (list[int]): Occurrences of components to process
	"""
	...

def deleteLines(occurrences: list[int]) -> None:
	"""Delete all free line of the mesh of given parts

	Args:
		occurrences (list[int]): Occurrences of components to process
	"""
	...

def deleteNormals(occurrences: list[int]) -> None:
	"""Remove normal attributes on tessellations

	Args:
		occurrences (list[int]): Occurrences of components to delete
	"""
	...

def deletePatches(occurrences: list[int], keepOnePatchByMaterial: bool = True) -> None:
	"""Delete patches attributes on tessellations

	Args:
		occurrences (list[int]): Occurrences of components to process
		keepOnePatchByMaterial (bool): If set, one patch by material will be kept, else all patches will be deleted and materials on patches will be lost
	"""
	...

def deletePolygons(occurrences: list[int]) -> None:
	"""Delete all polygons of the mesh of given parts

	Args:
		occurrences (list[int]): Occurrences of components to process
	"""
	...

def deleteTangents(occurrences: list[int]) -> None:
	"""Remove tangent attributes on tessellations

	Args:
		occurrences (list[int]): Occurrences of components to delete
	"""
	...

def deleteTextureCoordinates(occurrences: list[int], channel: int = -1) -> None:
	"""Delete texture coordinates on tessellations

	Args:
		occurrences (list[int]): Occurrences of components to process
		channel (int): Choose Texture coordinates channel to delete (-1 for all channels)
	"""
	...

def deleteVisibilityPatches(occurrences: list[int]) -> None:
	"""delete the visibility patches of given occurrences

	Args:
		occurrences (list[int]): Occurrences of components to process
	"""
	...

def evalDecimateErrorForTarget(occurrences: list[int], TargetStrategy: list, boundaryWeight: float = 1., normalWeight: float = 1., UVWeight: float = 1., sharpNormalWeight: float = 1., UVSeamWeight: float = 10., forbidUVFoldovers: bool = True, protectTopology: bool = False) -> float:
	"""returns the max error to set to reach a given target

	Args:
		occurrences (list[int]): List of occurrences to process
		TargetStrategy (list): Select between targetCount or ratio to define the number of triangles left after the decimation process
		boundaryWeight (float): Defines how important the edges defining the mesh boundaries (free edges) are during the decimation process, to preserve them from distortion
		normalWeight (float): Defines how important vertex normals are during the decimation process, to preserve the smoothing of the mesh from being damaged
		UVWeight (float): Defines how important UVs (texture coordinates) are during the decimation process, to preserve them from being distorted (along with the textures using the UVs)
		sharpNormalWeight (float): Defines how important sharp edges (or hard edges) are during the decimation process, to preserve them from being distorted
		UVSeamWeight (float): Defines how important UV seams (UV islands contours) are during the decimation process, to preserve them from being distorted (along with the textures using the UVs)
		forbidUVFoldovers (bool): Forbids UVs to fold over and overlap each other during the decimation
		protectTopology (bool): If False, the topology of the mesh can change and some edges can become non-manifold; but the visual quality will be better on model with complex topology

	Returns:
		errorMax (float): Max error that can be used in decimateEdgeCollapse function
	"""
	...

def extractNeutralAxis(occurrences: list[int], maxDiameter: float, removeOriginalMesh: bool) -> None:
	"""Extract neutral axis from tessellations

	Args:
		occurrences (list[int]): Occurrences of components to process
		maxDiameter (float): Maximum diameter of beams
		removeOriginalMesh (bool): Remove or not the original mesh at the end of the algorithm
	"""
	...

def filletMesh(occurrences: list[int], value: float, filletingMode: FilletingMode = 0, subdivisionNb: int = 0, createFlatChamfer: bool = False, material: int = int(), uvChannel: int = -1) -> None:
	"""Fillet a mesh according to its Lines of Interest

	Args:
		occurrences (list[int]): Input occurrences
		value (float): Value (mm)
		filletingMode (FilletingMode): Filleting mode
		subdivisionNb (int): Number of subdivision
		createFlatChamfer (bool): If there is 0 subdivision, should the fillet be a planar flat chamfer?
		material (int): Material to apply to created fillets. Default: use a random neighbor material
		uvChannel (int): UV Channel for the created fillet polygons. Defaults: Use an existing channel if there is one.
	"""
	...

def filterHiddenPolygons(occurrences: list[int], voxelSize: float) -> None:
	"""remove hidden polygons using voxels and cavities

	Args:
		occurrences (list[int]): Part occurrences to process
		voxelSize (float): Size of voxels
	"""
	...

def findBestPivotBetweenOccurrences(assembly1: list[int], assembly2: list[int], precision: float = -1) -> list[list[float]]:
	"""Try to compute the pivot point between 2 sets of occurrences

	Args:
		assembly1 (list[int]): Set occurrences 1
		assembly2 (list[int]): Set occurrences 2
		precision (float): Precision used to determine if elements are similar

	Returns:
		matrix (list[list[float]]): Best pivot between the two assembly. If impossible, return the null Matrix4
	"""
	...

def getAllAxisFromCADModel(occurrences: list[int]) -> dict:
	"""Return all the main axis contained in the CAD models given

	Args:
		occurrences (list[int]): Occurrences of components to check

	Returns:
		occurrences (list[int]): Occurrence part that contained CAD part
		axis (list[list[list[list[float]]]]): The main axis from the CAD models
	"""
	...

def getOptimalTextureResolution(occurrences: list[int], texelPerMm: float) -> int:
	"""Returns the optimal resolution based on a number of texels per 3D space units (e.g : mm)

	Args:
		occurrences (list[int]): Occurrences on which to compute optimal texture resolution
		texelPerMm (float): Number of texel per millimeter in a 3D space

	Returns:
		textureResolution (int): 
	"""
	...

def getTessellations(occurrences: list[int]) -> list[int]:
	"""returns all the tessellation of the given occurrences (only returns editable mesh, see algo.toEditableMesh)

	Args:
		occurrences (list[int]): Occurrences of components to process

	Returns:
		tessellations (list[int]): All the tessellation of the given occurrences
	"""
	...

def getUV3dRatio(occurrences: list[int]) -> float:
	"""Returns the ratio of size between UV and 3D (max value, actually at the 90th percentil)

	Args:
		occurrences (list[int]): Occurrences on which to compute optimal texture resolution

	Returns:
		ratio (float): Equivalent size of 1 in the UV space in 3D (e.g. Ratio/resolution give the 3D size of a texel))
	"""
	...

def getVisibilityStats(occurrences: list[int]) -> dict:
	"""returns the visibility statistics for some occurrences

	Args:
		occurrences (list[int]): Occurrences of components to process

	Returns:
		visibleCountFront (int): 
		visibleCountBack (int): 
	"""
	...

def getVisualComparisonFootprint(originalOccurrences: list[int], comparedOccurrences: list[int], resolution: int = 512, viewpointCount: int = 256, threshold: float = 0.2, onHemisphereOnly: bool = False) -> float:
	"""Compute the visual footprint of the difference between two sets of occurrences

	Args:
		originalOccurrences (list[int]): Set of occurrences representing the ground truth
		comparedOccurrences (list[int]): Set of occurrences to compare with the ground truth
		resolution (int): Resolution of the viewer
		viewpointCount (int): Number of viewpoints generated around the bounding sphere of all occurrences
		threshold (float): Tolerance for pixel comparison
		onHemisphereOnly (bool): Create viewpoints only in the Y+ hemisphere of the bounding sphere

	Returns:
		footprint (float): The visual footprint error in mm (worldspace)
	"""
	...

def identifyLinesOfInterest(occurrences: list[int], normal: bool = False, uvs: bool = False, uvChannels: list[int] = list[int](), border: bool = False, patches: bool = False, nman: bool = False) -> None:
	"""Identify LoI according to given criteria. It will create a new LoI attribute on the mesh that can be used afterward by some functions

	Args:
		occurrences (list[int]): Occurrences of components to process
		normal (bool): Add LoI on sharp normals
		uvs (bool): Add LoI on UV seams
		uvChannels (list[int]): If empty and uvs=true, add LoI using all UV channels, else only channel specified in the list
		border (bool): Add LoI on boundary edges
		patches (bool): Add LoI on submesh borders
		nman (bool): Add LoI on non-manifolds edges
	"""
	...

def identifyPatches(occurrences: list[int], useAttributesFilter: bool = True, sharpAngleFilter: float = 45, useBoundaryFilter: bool = True, useNonManifoldFilter: bool = True, useLineEdgeFilter: bool = True, useQuadLineFilter: bool = False) -> None:
	"""Create patches (submeshes) on meshes (needed by some functions)

	Args:
		occurrences (list[int]): Occurrences of components to process
		useAttributesFilter (bool): Filters by attributes
		sharpAngleFilter (float): Sharp angle in degree to filter by edges sharpness, if the angle is negative do not filter
		useBoundaryFilter (bool): Filters by boundaries
		useNonManifoldFilter (bool): Filters by manifold-ness
		useLineEdgeFilter (bool): Filters by edge
		useQuadLineFilter (bool): Filters by quad lines
	"""
	...

def identifySharpEdges(occurrences: list[int], minSharpAngle: float, maxSharpAngle: float = 180, convexity: ConvexityFilter = 2, onlyExplicitSharp: bool = False) -> None:
	"""Mark as Lines Of Interest the sharp edges 

	Args:
		occurrences (list[int]): Input occurrences
		minSharpAngle (float): The angle between the normals - all edges sharpest than this will be filleted
		maxSharpAngle (float): All edges sharpest than this won't be filleted
		convexity (ConvexityFilter): Fillet sharp edges that are convex, concave or both
		onlyExplicitSharp (bool): If toggled, if the explicit normals of an edge says the transition is smooth, the edge won't be selected
	"""
	...

def lineToTexture(lines: list[int], useColor: list, resolution: int = 512, thickness: int = 5) -> None:
	"""Generate a textured quadrangle over an existing mesh of coplanar lines

	Args:
		lines (list[int]): Lines to select
		useColor (list): Set color policy.
		resolution (int): Texture resolution
		thickness (int): The thickness of the lines in pixels
	"""
	...

def listFeatures(occurrences: list[int], throughHoles: bool = True, blindHoles: bool = False, maxDiameter: float = -1) -> list[OccurrenceFeatures]:
	"""List features from tessellations

	Args:
		occurrences (list[int]): Occurrences of components to process
		throughHoles (bool): List through holes
		blindHoles (bool): List blind holes
		maxDiameter (float): Maximum diameter of the holes to be list (-1=no max diameter)

	Returns:
		features (list[OccurrenceFeatures]): List of features by occurrence
	"""
	...

def loopSubdivMesh(occurrences: list[int], depth: int) -> None:
	"""Apply Loop Subdivision on Triangle-only Mesh

	Args:
		occurrences (list[int]): Occurrences of components to process
		depth (int): Subdivision depth
	"""
	...

def mergeVertices(occurrences: list[int], maxDistance: float, mask: polygonal.TopologyCategoryMask) -> None:
	"""merge near vertices according to the given distance

	Args:
		occurrences (list[int]): Occurrences of components to process
		maxDistance (float): Maximum distance between two vertex to merge
		mask (polygonal.TopologyCategoryMask): Topological category of the vertices to merge
	"""
	...

def meshBooleanOperation(occurrencesA: list[int], occurrencesB: list[int], operation: MeshBooleanOperation) -> int:
	"""Computes the boolean operation between the meshes of two occurrence lists

	Args:
		occurrencesA (list[int]): Occurrences A
		occurrencesB (list[int]): Occurrences B
		operation (MeshBooleanOperation): The operation to perform

	Returns:
		occurrence (int): A new Occurrence bearing the result
	"""
	...

def meshComparison(mesh_1: int, mesh_2: int) -> float:
	"""compare two meshes

	Args:
		mesh_1 (int): 
		mesh_2 (int): 

	Returns:
		distance (float): Disance between two meshes
	"""
	...

def meshComparisonBatch(meshes1: list[int], meshes2: list[int]) -> list[float]:
	"""compare each couple of meshes and returns the maximum for each couple

	Args:
		meshes1 (list[int]): 
		meshes2 (list[int]): 

	Returns:
		distances (list[float]): Disance between each couple of meshes
	"""
	...

def meshIntersections(occurrencesA: list[int], occurrencesB: list[int]) -> list[list[geom.Point3]]:
	"""Computes the list of polylines at the intersections of the meshes of two occurrence lists

	Args:
		occurrencesA (list[int]): Occurrences A
		occurrencesB (list[int]): Occurrences B

	Returns:
		intersections (list[list[geom.Point3]]): The intersections
	"""
	...

def noiseMesh(occurrences: list[int], maxAmplitude: float) -> None:
	"""Apply noise to vertex positions along their normals

	Args:
		occurrences (list[int]): Part occurrencess to noise
		maxAmplitude (float): Maximum distance between original vertex and noisy vertex
	"""
	...

def optimizeCADLoops(occurrences: list[int]) -> None:
	"""Optimize CAD Face loops by merging useless loop edges

	Args:
		occurrences (list[int]): Occurrences of components to optimize
	"""
	...

def optimizeForRendering(occurrences: list[int]) -> None:
	"""Optimize mesh for rendering (lossless, only reindexing)

	Args:
		occurrences (list[int]): Occurrences of components to optimize
	"""
	...

def optimizeSubMeshes(occurrences: list[int]) -> None:
	"""Sort sub meshes by materials

	Args:
		occurrences (list[int]): Part occurrencess to process
	"""
	...

def optimizeTextureSize(root: int, texelPerMm: float) -> None:
	"""Resizes scene textures based on a number of texels per 3D space units (e.g: mm)

	Args:
		root (int): Root from which texture resizing will process
		texelPerMm (float): Number of texel per millimeter in a 3D space
	"""
	...

def removeHoles(occurrences: list[int], throughHoles: bool, blindHoles: bool, surfacicHoles: bool, maxDiameter: float, fillWithMaterial: int = 0) -> None:
	"""Remove some features from tessellations

	Args:
		occurrences (list[int]): Occurrences of components to process
		throughHoles (bool): Remove through holes
		blindHoles (bool): Remove blind holes
		surfacicHoles (bool): Remove surfacic holes
		maxDiameter (float): Maximum diameter of the holes to be removed (-1=no max diameter)
		fillWithMaterial (int): If set, the given material will be used to fill the holes
	"""
	...

def repairCAD(occurrences: list[int], tolerance: float, orient: bool = True) -> None:
	"""Repair CAD shapes, assemble faces, remove duplicated faces, optimize loops and repair topology

	Args:
		occurrences (list[int]): Occurrences of components to clean
		tolerance (float): Tolerance
		orient (bool): If true reorient the model
	"""
	...

def segmentMesh(occurrences: list[int], overwriteLoI: bool = True) -> None:
	"""Segment Mesh into clusters guided by edge sharpnesses.

	Args:
		occurrences (list[int]): Occurrences of components to process
		overwriteLoI (bool): Overwrite the lines-of-interest parameters if true, else add them
	"""
	...

def setFeatureComponentMaxIndex(occurrences: list[int], maxIndex: int) -> None:
	"""Remap Index map of each FeatureComponent of selected occurrences

	Args:
		occurrences (list[int]): 
		maxIndex (int): 
	"""
	...

def smoothMesh(occurrences: list[int], mode: CostEvaluation, maxIterations: int = 100, lockSignificantEdges: bool = True) -> None:
	"""

	Args:
		occurrences (list[int]): Occurrences of components to process
		mode (CostEvaluation): Computation of cost
		maxIterations (int): Maximum number of swapping iteration
		lockSignificantEdges (bool): Forbid to swap significant edges (e.g. UV seams, sharp edges, patch borders, ...)
	"""
	...

def splitUVForAtlas(occurrences: list[int]) -> None:
	"""

	Args:
		occurrences (list[int]): Input occurrences
	"""
	...

def sweep(occurrences: list[int], radius: float, sides: int, createNormals: bool, keepLines: bool, generateUV: bool) -> None:
	"""Extrudes a circular section along an underlying polyline (curve)

	Args:
		occurrences (list[int]): Occurrences of components to check
		radius (float): Radius of cylinders
		sides (int): Number of points to create cylinders
		createNormals (bool): 
		keepLines (bool): 
		generateUV (bool): 
	"""
	...

def tessellate(occurrences: list[int], maxSag: float, maxLength: float, maxAngle: float, createNormals: bool = True, uvMode: UVGenerationMode = 0, uvChannel: int = 1, uvPadding: float = 0.0, createTangents: bool = False, createFreeEdges: bool = False, keepBRepShape: bool = True, overrideExistingTessellation: bool = False) -> None:
	"""Create a tessellated representation from a CAD representation for each given part

	Args:
		occurrences (list[int]): Occurrences of components to tessellate
		maxSag (float): Maximum distance between the geometry and the tessellation
		maxLength (float): Maximum length of elements
		maxAngle (float): Maximum angle between normals of two adjacent elements
		createNormals (bool): If true, normals will be generated
		uvMode (UVGenerationMode): Select the texture coordinates generation mode
		uvChannel (int): The UV channel of the generated texture coordinates (if any)
		uvPadding (float): The UV padding between UV island in UV coordinate space (between 0-1). This parameter is handled as an heuristic so it might not be respected
		createTangents (bool): If true, tangents will be generated
		createFreeEdges (bool): If true, free edges will be created for each patch borders
		keepBRepShape (bool): If true, BRep shapes will be kept for Back to Brep or Retessellate
		overrideExistingTessellation (bool): If true, already tessellated parts will be re-tessellated
	"""
	...

def tessellatePointClouds(occurrences: list[int], kNeighbors: int = 20, keepPoints: bool = False, colorize: bool = True) -> None:
	"""Tessellate point clouds to replace the geometry with a polygonal connect mesh

	Args:
		occurrences (list[int]): 
		kNeighbors (int): The number of neighbor points used to compute normals
		keepPoints (bool): Keep points after meshing if enabled
		colorize (bool): If enabled, vertex colors will be generated on the resulting mesh
	"""
	...

def tessellateRelativelyToAABB(occurrences: list[int], maxSag: float, sagRatio: float, maxLength: float, maxAngle: float, createNormals: bool = True, uvMode: UVGenerationMode = 0, uvChannel: int = 1, uvPadding: float = 0.0, createTangents: bool = False, createFreeEdges: bool = False, keepBRepShape: bool = True, overrideExistingTessellation: bool = False) -> None:
	"""Creates a tessellated representation from a CAD representation for each given part. It multiplies the length of the diagonal of the bounding box by the sagRatio. If the output value is above maxSag, then maxSag is used as tessellation value. Else if the output value is below maxSag, it is used as tessellation value.

	Args:
		occurrences (list[int]): Occurrences of components to tessellate
		maxSag (float): Maximum distance between the geometry and the tessellation
		sagRatio (float): Maximum ratio distance between the geometry and the tessellation
		maxLength (float): Maximum length of elements
		maxAngle (float): Maximum angle between normals of two adjacent elements
		createNormals (bool): If true, normals will be generated
		uvMode (UVGenerationMode): Select the texture coordinates generation mode
		uvChannel (int): The UV channel of the generated texture coordinates (if any)
		uvPadding (float): The UV padding between UV island in UV coordinate space (between 0-1). This parameter is handled as an heuristic so it might not be respected
		createTangents (bool): If true, tangents will be generated
		createFreeEdges (bool): If true, free edges will be created for each patch borders
		keepBRepShape (bool): If true, BRep shapes will be kept for Back to Brep or Retessellate
		overrideExistingTessellation (bool): If true, already tessellated parts will be re-tessellated
	"""
	...

def voxelizePointClouds(occurrences: list[int], voxelSize: float = 500) -> None:
	"""Explode point clouds to voxels

	Args:
		occurrences (list[int]): Part occurrences to process
		voxelSize (float): Size of voxels
	"""
	...

def combineMaterials(occurrences: list[int], bakingOptions: BakeOption, overrideExistingUVs: bool = True, singularizeOnAO: bool = False) -> None:
	"""Combine materials found on occurrences subtrees into one baked material and assign it to part occurrences

	Args:
		occurrences (list[int]): Root occurrences to process
		bakingOptions (BakeOption): Baking options
		overrideExistingUVs (bool): If True, override existing UVs on channel
		singularizeOnAO (bool): If true, singularize all instances in the selected subtree if we want to bake AO in the texture
	"""
	...

def transferUV(source: int, destination: int, sourceChannel: int = 0, destinationChannel: int = 0, tolerance: float = 0.001) -> None:
	"""Transfer UV from a mesh to another mesh

	Args:
		source (int): Occurrence of the source mesh
		destination (int): Occurrence of the destination mesh
		sourceChannel (int): Source UV channel to bake
		destinationChannel (int): Destination UV channel to bake to
		tolerance (float): Geometric tolerance for point projection
	"""
	...

def convexDecomposition(occurrences: list[int], maxCount: int, vertexCount: int, approximate: bool, resolution: int = 100000, concavity: float = 0.001) -> list[int]:
	"""Explode each mesh to approximated convex decomposition

	Args:
		occurrences (list[int]): Part occurrences to process
		maxCount (int): Maximum number of convex hull to generated
		vertexCount (int): Maximum number of vertices per convex hull
		approximate (bool): Approximate method
		resolution (int): Resolution
		concavity (float): Concavity

	Returns:
		newOccurrences (list[int]): Resulting occurrences of the convexDecomposition
	"""
	...

def explodeBodies(occurrences: list[int], groupOpenShells: bool = False) -> None:
	"""Explode all CAD Parts by body. New parts will be placed as children of input part occurrences.

	Args:
		occurrences (list[int]): Part occurrences to process
		groupOpenShells (bool): Group all open shells in one part
	"""
	...

def explodeByMaterials(occurrences: list[int]) -> None:
	"""Explode all parts by material. New parts will be placed as children of input part occurrences.

	Args:
		occurrences (list[int]): Part occurrences to process
	"""
	...

def explodeByVertexCount(occurrences: list[int], maxVertexCount: int, maxTriangleCount: int, countMergedVerticesOnce: bool = True) -> None:
	"""Explode part occurrences to respect a maximum vertex count

	Args:
		occurrences (list[int]): Part occurrences to process
		maxVertexCount (int): The maximum number of vertices by part
		maxTriangleCount (int): The maximum number of triangles by part (quadrangles count twice)
		countMergedVerticesOnce (bool): If true, one vertex used in several triangles with different normals will be counted once (for Unity must be False)
	"""
	...

def explodeByVoxel(occurrences: list[int], voxelSize: float) -> None:
	"""Explode parts by voxel. New parts will be placed as children of input part occurrences.

	Args:
		occurrences (list[int]): Part occurrences to process
		voxelSize (float): Voxel size
	"""
	...

def explodeConnectedMeshes(occurrences: list[int], explodeNonManifoldEdges: bool = False) -> None:
	"""Explode connected set of polygons to part occurrences. New parts will be placed as children of input part occurrences.

	Args:
		occurrences (list[int]): Part occurrences to process
		explodeNonManifoldEdges (bool): Split connected components along non-manifold edges
	"""
	...

def explodePatches(occurrences: list[int]) -> None:
	"""Explode all parts by patch

	Args:
		occurrences (list[int]): Part occurrences to process
	"""
	...

def createVisibilityInformation(occurrences: list[int], level: SelectionLevel, resolution: int, sphereCount: int, fovX: float = 90, considerTransparentOpaque: bool = False, root: int = 0, onHemisphereOnly: bool = False) -> None:
	"""Create visilibity information on part occurrences viewed from a set of camera automatically placed on a sphere around the scene

	Args:
		occurrences (list[int]): Occurrences of components to process
		level (SelectionLevel): Level of geometries to create visibility information on: Parts, Patches or Polygons
		resolution (int): Resolution of the visibility viewer
		sphereCount (int): Number of viewpoints generated around the bounding sphere
		fovX (float): Horizontal field of view (in degree)
		considerTransparentOpaque (bool): If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque
		root (int): Specify another root for occluder scene
		onHemisphereOnly (bool): Create viewpoints only in the Y+ hemisphere of the bounding sphere
	"""
	...

def createVisibilityInformationAdvanced(occurrences: list[int], level: SelectionLevel, voxelSize: float, minimumCavityVolume: float, resolution: int, mode: InnerOuterOption = 0, considerTransparentOpaque: bool = False, root: int = 0) -> None:
	"""Create visilibity information on part occurrences viewed from a set of voxel based view points.

	Args:
		occurrences (list[int]): Occurrences of components to process
		level (SelectionLevel): Level of geometries to create visibility information on: Parts, Patches or Polygons
		voxelSize (float): Size of the voxels in mm (smaller it is, more viewpoints there are)
		minimumCavityVolume (float): Minimum volume of a cavity in cubic meter (smaller it is, more viewpoints there are)
		resolution (int): Resolution of the visibility viewer
		mode (InnerOuterOption): Select where to place camera (all cavities, only outer or only inner cavities)
		considerTransparentOpaque (bool): If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque
		root (int): Specify another root for occluder scene
	"""
	...

def createVisibilityInformationFromViewPoints(occurrences: list[int], cameraPositions: list[geom.Point3], cameraDirections: list[geom.Point3], cameraUps: list[geom.Point3], resolution: int, fovX: float = 90, considerTransparentOpaque: bool = False, root: int = 0) -> None:
	"""Create visilibity information on parts viewed from a given set of camera

	Args:
		occurrences (list[int]): Occurrences of components to process
		cameraPositions (list[geom.Point3]): List of camera positions
		cameraDirections (list[geom.Point3]): List of camera directions
		cameraUps (list[geom.Point3]): List of camera up vectors
		resolution (int): Resolution of the visibility viewer
		fovX (float): Horizontal field of view (in degree)
		considerTransparentOpaque (bool): If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque
		root (int): Specify another root for occluder scene
	"""
	...

def findOccludedPartOccurrences(occurrences: list[int], resolution: int, sphereCount: int, fovX: float = 90, considerTransparentOpaque: bool = False, root: int = 0, onHemisphereOnly: bool = False) -> list[int]:
	"""get part occurrences not viewed from a sphere around the scene

	Args:
		occurrences (list[int]): Occurrences of components to process
		resolution (int): Resolution of the visibility viewer
		sphereCount (int): Number of viewpoints generated around the bounding sphere
		fovX (float): Horizontal field of view (in degree)
		considerTransparentOpaque (bool): If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque
		root (int): Specify another root for occluder scene
		onHemisphereOnly (bool): Create viewpoints only in the Y+ hemisphere of the bounding sphere

	Returns:
		filtered (list[int]): The list of occurrences meeting the criteria
	"""
	...

def findOccludedPartOccurrencesAdvanced(occurrences: list[int], voxelSize: float, minimumCavityVolume: float, resolution: int, mode: InnerOuterOption = 0, considerTransparentOpaque: bool = False, root: int = 0) -> list[int]:
	"""get part occurrences not viewed from a set of voxel based view points.

	Args:
		occurrences (list[int]): Occurrences of components to process
		voxelSize (float): Size of the voxels in mm (smaller it is, more viewpoints there are)
		minimumCavityVolume (float): Minimum volume of a cavity in cubic meter (smaller it is, more viewpoints there are)
		resolution (int): Resolution of the visibility viewer
		mode (InnerOuterOption): Select where to place camera (all cavities, only outer or only inner cavities)
		considerTransparentOpaque (bool): If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque
		root (int): Specify another root for occluder scene

	Returns:
		filtered (list[int]): The list of occurrences meeting the criteria
	"""
	...

def removeOccludedGeometries(occurrences: list[int], level: SelectionLevel, resolution: int, sphereCount: int, fovX: float = 90, considerTransparentOpaque: bool = False, adjacencyDepth: int = 1, occluders: list[int] = 0, onHemisphereOnly: bool = False) -> list[bool]:
	"""Delete part occurrences, patches or polygons not viewed from a sphere around the scene

	Args:
		occurrences (list[int]): Occurrences of components to process
		level (SelectionLevel): Level of geometries to remove : Parts, Patches or Polygons
		resolution (int): Resolution of the visibility viewer
		sphereCount (int): Number of viewpoints generated around the bounding sphere
		fovX (float): Horizontal field of view (in degree)
		considerTransparentOpaque (bool): If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque
		adjacencyDepth (int): Mark neighbors polygons as visible
		occluders (list[int]): Specify other occurrences for occluder scene
		onHemisphereOnly (bool): Create viewpoints only in the Y+ hemisphere of the bounding sphere

	Returns:
		viewedOccurrences (list[bool]): For each occurrence in occurrences, tell if the occurrence has been viewed (True) or not (True)
	"""
	...

def removeOccludedGeometriesAdvanced(occurrences: list[int], level: SelectionLevel, voxelSize: float, minimumCavityVolume: float, resolution: int, mode: InnerOuterOption = 0, considerTransparentOpaque: bool = False, adjacencyDepth: int = 1, occluders: list[int] = 0) -> list[bool]:
	"""Delete part occurrences, patches or polygons not seen from voxel based view points.

	Args:
		occurrences (list[int]): Occurrences of components to process
		level (SelectionLevel): Level of geometries to remove : Parts, Patches or Polygons
		voxelSize (float): Size of the voxels in mm (smaller it is, more viewpoints there are)
		minimumCavityVolume (float): Minimum volume of a cavity in cubic meter (smaller it is, more viewpoints there are)
		resolution (int): Resolution of the visibility viewer
		mode (InnerOuterOption): Select where to place camera (all cavities, only outer or only inner cavities)
		considerTransparentOpaque (bool): If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque
		adjacencyDepth (int): Mark neighbors polygons as visible
		occluders (list[int]): Specify other occurrences for occluder scene

	Returns:
		viewedOccurrences (list[bool]): For each occurrence in occurrences, tell if the occurrence has been viewed (True) or not (True)
	"""
	...

def removeOccludedGeometriesFromPoints(occurrences: list[int], level: SelectionLevel, positions: list[geom.Point3], resolution: int, sphereCount: int, fovX: float = 90, considerTransparentOpaque: bool = False, adjacencyDepth: int = 1, occluders: list[int] = 0) -> list[bool]:
	"""Delete part occurrences, patches or polygons not viewed from spheres generated with a set of camera position

	Args:
		occurrences (list[int]): Occurrences of components to process
		level (SelectionLevel): Level of parts to remove : Parts, Patches or Polygons
		positions (list[geom.Point3]): List of positions
		resolution (int): Resolution of the visibility viewer
		sphereCount (int): Number of viewpoints generated around the bounding sphere
		fovX (float): Horizontal field of view (in degree)
		considerTransparentOpaque (bool): If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque
		adjacencyDepth (int): Mark neighbors polygons as visible
		occluders (list[int]): Specify other occurrences for occluder scene

	Returns:
		viewedOccurrences (list[bool]): For each occurrence in occurrences, tell if the occurrence has been viewed (True) or not (True)
	"""
	...

def removeOccludedGeometriesFromViewPoints(occurrences: list[int], level: SelectionLevel, positions: list[geom.Point3], directions: list[geom.Point3], ups: list[geom.Point3], resolution: int, fovX: float = 90, considerTransparentOpaque: bool = False, adjacencyDepth: int = 1, occluders: list[int] = 0) -> list[bool]:
	"""Delete part occurrences, patches or polygons not viewed from a set of camera position/orientation

	Args:
		occurrences (list[int]): Occurrences of components to process
		level (SelectionLevel): Level of geometries to remove : Parts, Patches or Polygons
		positions (list[geom.Point3]): List of positions
		directions (list[geom.Point3]): List of directions
		ups (list[geom.Point3]): List of up vectors
		resolution (int): Resolution of the visibility viewer
		fovX (float): Horizontal field of view (in degree)
		considerTransparentOpaque (bool): If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque
		adjacencyDepth (int): Mark neighbors polygons as visible
		occluders (list[int]): Specify other occurrences for occluder scene

	Returns:
		viewedOccurrences (list[bool]): For each occurrence in occurrences, tell if the occurrence has been viewed (True) or not (True)
	"""
	...

def createOcclusionMesh(occurrences: list[int], type: CreateOccluder, voxelSize: float, gap: int) -> int:
	"""Compute an occluder or an occludee with the occurrences selected

	Args:
		occurrences (list[int]): Part occurrences to process
		type (CreateOccluder): Type of what we create
		voxelSize (float): Size of voxels
		gap (int): Dilation iterations on the voxel grid

	Returns:
		occlusionPart (int): Resulting part occurrence
	"""
	...

def dualContouring(occurrences: list[int], filteringSize: float, voxelSize: float, tolerance: float, sameSizeOnAllAxis: bool) -> int:
	"""Replace the tessellations of the selected parts by a retopology based on a dual-contouring

	Args:
		occurrences (list[int]): Occurrences of part to process
		filteringSize (float): Filtering size - must be a multiple of 2 of voxelSize
		voxelSize (float): Voxel size used for the reconstruction
		tolerance (float): Tolerance for the quadric error used for the simplification of the octree
		sameSizeOnAllAxis (bool): If true, use the maximum axis length of the AABB for all axis

	Returns:
		dualContouredPart (int): Resulting part occurrence
	"""
	...

def marchingCubes(occurrences: list[int], voxelSize: float, elements: ElementFilter = 0, dilation: int = 0, surfacic: bool = False) -> int:
	"""Replace the tessellations of the selected parts by a marching cube representation

	Args:
		occurrences (list[int]): Part occurrences to process
		voxelSize (float): Size of voxels
		elements (ElementFilter): Type of elements used to detect the voxels, polygons or points or hybrid
		dilation (int): Dilation iterations on the voxel grid (only if surfacic=false)
		surfacic (bool): Prefer this mode if the source is surfacic, the result is not guaranteed to be watertight

	Returns:
		marchingCubePart (int): Resulting part occurrence
	"""
	...

def proxyMesh(occurrences: list[int], voxelSize: float, elements: ElementFilter = 0, dilation: int = 0, surfacic: bool = False) -> int:
	"""Replace the tessellations of the selected parts by a proxy mesh based on a voxelization

	Args:
		occurrences (list[int]): Part occurrences to process
		voxelSize (float): Size of voxels
		elements (ElementFilter): Type of elements used to detect the voxels, polygons or points or hybrid
		dilation (int): Dilation iterations on the voxel grid (only if surfacic=false)
		surfacic (bool): Prefer this mode if the source is surfacic, the result is not guaranteed to be watertight

	Returns:
		proxyMeshPart (int): Resulting part occurrence
	"""
	...

def retopologize(occurrences: list[int], targetTriangleCount: int, pureQuad: bool, pointCloud: bool, precision: float = -1) -> int:
	"""Replace the tessellations of the selected parts by a retopology of the external hull

	Args:
		occurrences (list[int]): Part occurrences to process
		targetTriangleCount (int): Target triangle count
		pureQuad (bool): Retopologize to a pure quad mesh if True, else the resulting mesh will be quad dominant but can contains triangles
		pointCloud (bool): Set to true if occurrences are point cloud, else False
		precision (float): If set, define the precision of the features to preserve

	Returns:
		retopologizedPart (int): Resulting part occurrence
	"""
	...

def voxelize(occurrences: list[int], voxelSize: float, elements: ElementFilter = 0, dilation: int = 0, useCurrentAnimationPosition: bool = False) -> int:
	"""Replace the tessellations of the selected parts by a voxelization of the external skin

	Args:
		occurrences (list[int]): Part occurrences to process
		voxelSize (float): Size of voxels
		elements (ElementFilter): Type of elements used to detect the voxels, polygons or points or hybrid
		dilation (int): Dilation iterations on the voxel grid
		useCurrentAnimationPosition (bool): Use the current animation position instead of the t-pose

	Returns:
		voxelizedPart (int): Resulting part occurrence
	"""
	...

def replaceBy(occurrences: list[int], replaceBy: list) -> None:
	"""Replace geometries by other shapes, or primitives

	Args:
		occurrences (list[int]): Occurrences of components to replace
		replaceBy (list): Shape replacement option
	"""
	...

def replaceByBox(occurrences: list[int], boxType: ReplaceByBoxType) -> None:
	"""Replace objects by a bounding box

	Args:
		occurrences (list[int]): Occurrences of components to replace
		boxType (ReplaceByBoxType): Bounding box type, oriented, axis-aligned, ...
	"""
	...

def replaceByConvexHull(occurrences: list[int]) -> None:
	"""Replace objects by convex hull

	Args:
		occurrences (list[int]): Occurrences of components to replace
	"""
	...

def replaceByPrimitive(occurrences: list[int], primitive: list, generateUV: bool = True) -> None:
	"""Replace objects by a primitive shapes

	Args:
		occurrences (list[int]): Occurrences of components to replace
		primitive (list): Primitive type and parameters
		generateUV (bool): Primitive type and parameters
	"""
	...

def sawWithAABB(occurrences: list[int], aabb: geom.AABB, mode: SawingMode, innerSuffix: str = "_inner", outerSuffix: str = "_outer") -> None:
	"""Saw the mesh with an axis-aligned bounding box. New parts will be placed as children of input part occurrences.

	Args:
		occurrences (list[int]): Part occurrences to process
		aabb (geom.AABB): Axis-Aligned Bounding Box
		mode (SawingMode): The sawing mode
		innerSuffix (str): Only if mode is set to SawAndSplit, set the suffix of the inner part
		outerSuffix (str): Only if mode is set to SawAndSplit, set the suffix of the outer part
	"""
	...

def sawWithOBB(occurrences: list[int], obb: geom.OBB, mode: SawingMode, innerSuffix: str = "_inner", outerSuffix: str = "_outer") -> None:
	"""Saw the mesh with an oriented bounding box. New parts will be placed as children of input part occurrences.

	Args:
		occurrences (list[int]): Part occurrences to process
		obb (geom.OBB): Minimum Bounding Box
		mode (SawingMode): The sawing mode
		innerSuffix (str): Only if mode is set to SawAndSplit, set the suffix of the inner part
		outerSuffix (str): Only if mode is set to SawAndSplit, set the suffix of the outer part
	"""
	...

def sawWithOctree(occurrences: list[int], aabb: geom.AABB, maxDepth: int, maxTrianglesByLeaf: int = -1, sawTolerance: float = 0) -> int:
	"""Saw and split the mesh with an octree. New parts will be placed as children of input part occurrences.

	Args:
		occurrences (list[int]): Part occurrences to process
		aabb (geom.AABB): Octree Bounding Box
		maxDepth (int): Depth of the octree
		maxTrianglesByLeaf (int): Set the maximum triangle count on the leaf of the octree ( -1 to not use )
		sawTolerance (float): Size in mm of the tolerance of the saw

	Returns:
		octreeRoot (int): Root occurrence of the created octree
	"""
	...

def sawWithPlane(occurrences: list[int], planeOrigin: geom.Point3, planeNormal: geom.Point3, mode: SawingMode, innerSuffix: str = "_inner", outerSuffix: str = "_outer", tolerance: float = 0) -> None:
	"""Saw the mesh with a plane. New parts will be placed as children of input part occurrences.

	Args:
		occurrences (list[int]): Part occurrences to process
		planeOrigin (geom.Point3): The plane origin
		planeNormal (geom.Point3): The plane normal
		mode (SawingMode): The sawing mode
		innerSuffix (str): Only if mode is set to SawAndSplit, set the suffix of the inner part
		outerSuffix (str): Only if mode is set to SawAndSplit, set the suffix of the outer part
		tolerance (float): Set a tolerance to make the saw lose
	"""
	...

def convertSimilarPartOccurrencesToInstances(occurrences: list[int], checkMeshTopo: bool, checkVertexPositions: bool, vertexPositionPrecision: int, checkUVTopo: bool, checkUVVertexPositions: bool, UVPositionprecision: int, keepExistingPrototypes: bool) -> None:
	"""Create instances from similar part occurrences with an accurate method based on topology checksums. This can be used to repair instances or to simplify a model that has similar parts that could be instantiated instead to reduce the number of unique meshes (reduces drawcalls, GPU memory usage and file size).

	Args:
		occurrences (list[int]): Occurrence for which we want to find similar parts and create instances using prototypes.
		checkMeshTopo (bool): 
		checkVertexPositions (bool): 
		vertexPositionPrecision (int): 
		checkUVTopo (bool): 
		checkUVVertexPositions (bool): 
		UVPositionprecision (int): 
		keepExistingPrototypes (bool): 
	"""
	...

def convertSimilarPartOccurrencesToInstancesFast(occurrences: list[int], dimensionsSimilarity: float, polycountSimilarity: float, ignoreSymmetry: bool, keepExistingPrototypes: bool, createNewOccurrencesForPrototypes: bool) -> None:
	"""Create instances from similar part occurrences with a fast but approximate method. This can be used to repair instances or to simplify a model that has similar parts that could be instantiated instead to reduce the number of unique meshes (reduces drawcalls, GPU memory usage and file size). Using 1.0 (100%) in all similarity criteria is non destructive. Using lower values will help finding more similar parts, even if their polycount or dimensions varies a bit.

	Args:
		occurrences (list[int]): Root occurrences for which we want to find similar part occurrences and create instances using prototypes.
		dimensionsSimilarity (float): The percentage of similarity on dimensions. A value of 1.0 (100%) will find parts that have exactly the same dimensions. A lower value will increase the likelihood to find similar parts, at the cost of precision.
		polycountSimilarity (float): The percentage of similarity on polycount. A value of 1.0 (100%) will find parts that have exactly the same polycount. A lower value will increase the likelihood to find similar parts, at the cost of precision.
		ignoreSymmetry (bool): If True, symmetries will be ignored, otherwise negative scaling will be applied in the occurrence transformation.
		keepExistingPrototypes (bool): If True, existing prototypes will be kept. Otherwise, the selection will be singularized and instanced will be created from scratch.
		createNewOccurrencesForPrototypes (bool): If True, a new occurrence will be created for each prototype. Those occurrences won't appear in the hierarchy, and so deleting one of the part in the scene has no risks of singularizing. If set to False, an arbitrary occurrence will be used as the prototype for other similar occurrences, which is less safe but will result in less occurrences.
	"""
	...

def findSimilarPartOccurrencesFast(occurrences: list[int], dimensionsSimilarity: float, polycountSimilarity: float, ignoreSymmetry: bool) -> list[int]:
	"""find part occurrences in the whole scene that are similar to the input part occurrences. If multiple part occurrences are passed as input, the output will contain similar part occurrences corresponding to each input part occurrence.

	Args:
		occurrences (list[int]): Occurrences for which we want to find similar part occurrences in the scene.
		dimensionsSimilarity (float): The percentage of similarity on dimensions. A value of 1.0 (100%) will find parts that have exactly the same dimensions. A lower value will increase the likelihood to find similar parts, at the cost of precision.
		polycountSimilarity (float): The percentage of similarity on polycount. A value of 1.0 (100%) will find parts that have exactly the same polycount. A lower value will increase the likelihood to find similar parts, at the cost of precision.
		ignoreSymmetry (bool): If True, symmetries will be ignored, otherwise negative scaling will be applied in the occurrence transformation.

	Returns:
		filtered (list[int]): The list of part occurrences meeting the criteria
	"""
	...

def alignUVIslands(occurrences: list[int], channel: int = 0, usePolygonsWeights: float = 0, useVerticesWeights: float = 0, alignmentMode: AlignmentMode = 0) -> None:
	"""Align with the axes the UVs of the islands

	Args:
		occurrences (list[int]): Part occurrences to process
		channel (int): UV channel to merge
		usePolygonsWeights (float): Use polygons weights to give more importance to what must be aligned
		useVerticesWeights (float): Use vertices weights to give more importance to what must be aligned
		alignmentMode (AlignmentMode): With which axis the UVs should be aligned
	"""
	...

def applyUvTransform(occurrences: list[int], matrix: list[list[float]], channel: int = 0) -> None:
	"""Apply a transformation matrix on texture coordinates

	Args:
		occurrences (list[int]): Part occurrences to process
		matrix (list[list[float]]): Transformationmatrix
		channel (int): UV channel to transform
	"""
	...

def automaticUVMapping(occurrences: list[int], channel: int = 0, maxAngleDistorsion: float = 0.5, maxAreaDistorsion: float = -1, sharpToSeam: bool = True, forbidOverlapping: bool = True, resolution: int = 1024, padding: int = 1) -> None:
	"""Generates the texture coordinates and automatically find seams

	Args:
		occurrences (list[int]): Part occurrences to process
		channel (int): The UV channel which will contains the texture coordinates
		maxAngleDistorsion (float): Maximum angle distorsion |2PI-SumVtxAng|/2PI
		maxAreaDistorsion (float): Maximum area distorsion before scale to 1. |2DArea-3DArea|/3DArea 
		sharpToSeam (bool): If enabled, sharp edges are automatically considered as UV seams
		forbidOverlapping (bool): If enabled, UV cannot overlap
		resolution (int): Resolution wanted for the final map when repacking at the end
		padding (int): Set the padding (in pixels) between UV islands when repacking at the end
	"""
	...

def copyUV(occurrences: list[int], sourceChannel: int = 0, destinationChannel: int = 0) -> None:
	"""Copy an UV channel to another UV channel

	Args:
		occurrences (list[int]): Part occurrences to process
		sourceChannel (int): The source UV channel to copy
		destinationChannel (int): The destination UV channel to copy into
	"""
	...

def getRatioUV3D(occurrences: list[int], ratioMode: RatioUV3DMode, channel: int = 0) -> list[float]:
	"""Compute the ratio between the UV and the 3D size

	Args:
		occurrences (list[int]): Part occurrences to process
		ratioMode (RatioUV3DMode): Choose how to compute the ratio
		channel (int): UV channel to use

	Returns:
		ratios (list[float]): Ratios 3Dsize/UVsize of the input occurrences
	"""
	...

def getUVQualityMetrics(occurrences: list[int], channel: int) -> dict:
	"""Compute UV mapping qualitative metrics.

	Args:
		occurrences (list[int]): Part occurrences to process
		channel (int): UV channel to use

	Returns:
		chartCount (int): Number of UV islands. If 0, all other returns are invalid.
		area3D (float): 3D area (sum of 3D triangle areas)
		area2D (float): 2D area (sum of UV-space triangle area)
		occupancy (float): UV-space occupation (i.e., 2D area over AABR area)
		crumbliness (float): Crumbliness (i.e., a measure of how intricate the UV-island borders are, basically a measure of deviation from a perfect disc)
		samplingStd (float): Sampling standard deviation (i.e., measure of variation over the mesh of triangle sampling rate, that is ratio of their 2D over 3D area)
	"""
	...

def getUvAabr(occurrences: list[int], channel: int = 0) -> geom.AABR:
	"""Compute the UV Axis Aligned Bounding Rectangle of a set of occurrences

	Args:
		occurrences (list[int]): Part occurrences to process
		channel (int): UV channel to transform

	Returns:
		aabr (geom.AABR): The UV AABR
	"""
	...

def mapUvOnAABB(occurrences: list[int], useLocalAABB: bool, uv3dSize: float, channel: int = 0, overrideExistingUVs: bool = True, ignoreScale: bool = True) -> None:
	"""Generate texture coordinates using the projection on object Axis Aligned Bounding Box

	Args:
		occurrences (list[int]): Part occurrences to process
		useLocalAABB (bool): If enabled, uses part own bounding box, else use global one
		uv3dSize (float): 3D size of the UV space [0-1]
		channel (int): The UV channel which will contains the texture coordinates
		overrideExistingUVs (bool): If True, override existing UVs on channel
		ignoreScale (bool): If this and useLocalAABB are true, ignore local scale
	"""
	...

def mapUvOnBox(occurrences: list[int], box: Box, channel: int = 0, overrideExistingUVs: bool = True) -> None:
	"""Generate texture coordinates using the projection on a box

	Args:
		occurrences (list[int]): Part occurrences to process
		box (Box): Box definition
		channel (int): The UV channel which will contains the texture coordinates
		overrideExistingUVs (bool): If True, override existing UVs on channel
	"""
	...

def mapUvOnCubicAABB(occurrences: list[int], uv3dSize: float, channel: int = 0, overrideExistingUVs: bool = True) -> None:
	"""Generate texture coordinates using the projection on object AABB, with same scale on each axis

	Args:
		occurrences (list[int]): Part occurrences to process
		uv3dSize (float): 3D size of the UV space [0-1]
		channel (int): The UV channel which will contains the texture coordinates
		overrideExistingUVs (bool): If True, override existing UVs on channel
	"""
	...

def mapUvOnCustomAABB(occurrences: list[int], aabb: geom.AABB, uv3dSize: float, channel: int = 0, overrideExistingUVs: bool = True) -> None:
	"""Generate texture coordinates using the projection on custom AABB

	Args:
		occurrences (list[int]): Part occurrences to process
		aabb (geom.AABB): Axis aligned bounding box to project on
		uv3dSize (float): 3D size of the UV space [0-1]
		channel (int): The UV channel which will contains the texture coordinates
		overrideExistingUVs (bool): If True, override existing UVs on channel
	"""
	...

def mapUvOnCylinder(occurrences: list[int], cylinder: Cylinder, channel: int = 0, overrideExistingUVs: bool = True) -> None:
	"""Generate texture coordinates using the projection on a cylinder

	Args:
		occurrences (list[int]): Part occurrences to process
		cylinder (Cylinder): Cylinder definition
		channel (int): The UV channel which will contains the texture coordinates
		overrideExistingUVs (bool): If True, override existing UVs on channel
	"""
	...

def mapUvOnFittingCylinder(occurrences: list[int], channel: int = 0, overrideExistingUVs: bool = True, useAABB: bool = True, forcedAxis: geom.Point3 = geom.Vector3(0,0,0)) -> None:
	"""Generate texture coordinates using the projection on a fitting cylinder

	Args:
		occurrences (list[int]): Part occurrences to process
		channel (int): The UV channel which will contains the texture coordinates
		overrideExistingUVs (bool): If True, override existing UVs on channel
		useAABB (bool): If true use for the fitting the global Axis Aligned Bounding Box (AABB), else use a Minimum Bounding Box (MBB)
		forcedAxis (geom.Point3): Forced axis of the Cylinder
	"""
	...

def mapUvOnFittingSphere(occurrences: list[int], channel: int = 0, overrideExistingUVs: bool = True, useAABB: bool = True) -> None:
	"""Generate texture coordinates using the projection on a fitting sphere

	Args:
		occurrences (list[int]): Part occurrences to process
		channel (int): The UV channel which will contains the texture coordinates
		overrideExistingUVs (bool): If True, override existing UVs on channel
		useAABB (bool): If true use for the fitting the global Axis Aligned Bounding Box (AABB), else use a Minimum Bounding Box (MBB)
	"""
	...

def mapUvOnMBB(occurrences: list[int], useLocalMBB: bool, uv3dSize: float, channel: int = 0, overrideExistingUVs: bool = True) -> None:
	"""Generate texture coordinates using the projection on object Minimum Bounding Box

	Args:
		occurrences (list[int]): Part occurrences to process
		useLocalMBB (bool): If enabled, uses part own bounding box, else use global one
		uv3dSize (float): 3D size of the UV space [0-1]
		channel (int): The UV channel which will contains the texture coordinates
		overrideExistingUVs (bool): If True, override existing UVs on channel
	"""
	...

def mapUvOnPlane(occurrences: list[int], plane: Plane, channel: int = 0, overrideExistingUVs: bool = True) -> None:
	"""Generate texture coordinates using the projection on a plane

	Args:
		occurrences (list[int]): Part occurrences to process
		plane (Plane): Plane definition
		channel (int): The UV channel which will contains the texture coordinates
		overrideExistingUVs (bool): If True, override existing UVs on channel
	"""
	...

def mapUvOnSphere(occurrences: list[int], sphere: Sphere, channel: int = 0, overrideExistingUVs: bool = True) -> None:
	"""Generate texture coordinates using the projection on a sphere

	Args:
		occurrences (list[int]): Part occurrences to process
		sphere (Sphere): Sphere definition
		channel (int): The UV channel which will contains the texture coordinates
		overrideExistingUVs (bool): If True, override existing UVs on channel
	"""
	...

def mergeUVIslandsAffine(occurrences: list[int], channel: int = 0, scaleWeights: float = 0, maxScaleVariationFactor: float = 1.2, curvatureWeights: float = -1, usePolygonsWeights: float = 1, useVerticesWeights: float = -1, allowedTransformations: TransformationType = 0, allowUVInversion: bool = False) -> None:
	"""Minimizes the number of seams in the UV mapping by merging UV islands using affine transformation (recommanded for hard surfaces)

	Args:
		occurrences (list[int]): Part occurrences to process
		channel (int): UV channel to merge
		scaleWeights (float): Weight to assign to scale for the merging priority
		maxScaleVariationFactor (float): Maximum scaling factor allowed, -1 meaning no limits
		curvatureWeights (float): Weight to assign to curvature for the merging priority
		usePolygonsWeights (float): Use polygons weights to prioritize seams between polygons with less weight. The value represents the feature weight
		useVerticesWeights (float): Use vertices weights to prioritize seams where vertices with less weight. The value represents the feature weight
		allowedTransformations (TransformationType): Allowed transformation: TRSOnly or TRS+Skew
		allowUVInversion (bool): Allow merged UVs to be inverted
	"""
	...

def mergeUVIslandsRelaxed(occurrences: list[int], channel: int, targetIslandCount: int = 0, energyThreshold: float = 0.01, forceIsolatedFaces: bool = True) -> None:
	"""Minimizes the number of seams in the UV mapping by merging UV islands using local reparametrization near the UV seams (recommanded for organic surfaces)

	Args:
		occurrences (list[int]): Part occurrences to process
		channel (int): UV channel to use
		targetIslandCount (int): Target number of islands (zero means the algorithm runs until no more merging is possible)
		energyThreshold (float): Max energy allowed during local reparametrization
		forceIsolatedFaces (bool): UV islands consisting in a single isolated face completely surrounded by another island are forced to be merged, without reparametrization.
	"""
	...

def normalizeUV(occurrences: list[int], sourceUVChannel: int, destinationUVChannel: int = -1, uniform: bool = True, sharedUVSpace: bool = True, ignoreNullIslands: bool = False) -> None:
	"""Normalize UVs to fit in the [0-1] uv space

	Args:
		occurrences (list[int]): Part occurrences to process
		sourceUVChannel (int): UV Channel to normalize
		destinationUVChannel (int): UV channel to store the normalized UV (if -1, sourceUVChannel will be replaced)
		uniform (bool): If true, the scale will be uniform. Else UV can be deformed with a non-uniform scale
		sharedUVSpace (bool): If true, all parts will be processed as if they were merged to avoid overlapping of their UV coordinates
		ignoreNullIslands (bool): If true, islands with null height and width will be ignored and their UV coordinates will be set to [0,0] (Slower if enabled)
	"""
	...

def removeUV(occurrences: list[int], channel: int = -1) -> None:
	"""Remove one or all UV channel(s)

	Args:
		occurrences (list[int]): Part occurrences to process
		channel (int): The UV channel to remove (all if channel=-1)
	"""
	...

def repackUV(occurrences: list[int], channel: int = 0, shareMap: bool = True, resolution: int = 1024, padding: int = 2, uniformRatio: bool = False, iterations: int = 3, removeOverlaps: bool = True) -> list[int]:
	"""Pack existing UV (create atlas)

	Args:
		occurrences (list[int]): Part occurrences to process
		channel (int): The UV channel to repack
		shareMap (bool): If True, the UV of all given parts will be packed together
		resolution (int): Resolution wanted for the final map
		padding (int): Set the padding (in pixels) between UV islands
		uniformRatio (bool): If true, UV of different part will have the same ratio
		iterations (int): Fitting iterations
		removeOverlaps (bool): Remove overlaps to avoid multiple triangles UVs to share the same pixel

	Returns:
		failedParts (list[int]): Parts which failed to be repacked at this resolution (try to increase the resolution or decrease the padding)
	"""
	...

def resizeUVsToTextureSize(occurrences: list[int], TextureSize: float, channel: int = 0) -> None:
	"""Rescale the UV coordinates to fit the input texture size

	Args:
		occurrences (list[int]): Occurrences to use for the rescaling
		TextureSize (float): Texture size to use for the UV coordinates (in millimeters)
		channel (int): UV channel to use
	"""
	...

def scaleUV(occurrences: list[int], scaleU: float, scaleV: float, channel: int = 0) -> None:
	"""Apply a scale on texture coordinates

	Args:
		occurrences (list[int]): Part occurrences to process
		scaleU (float): Scale to apply to U coordinate
		scaleV (float): Scale to apply to V coordinate
		channel (int): UV channel to transform
	"""
	...

def swapUvChannels(occurrences: list[int], firstChannel: int, secondChannel: int) -> None:
	"""Swap two UV channels

	Args:
		occurrences (list[int]): Part occurrences to process
		firstChannel (int): First UV Channel to swap
		secondChannel (int): Second UV Channel to swap
	"""
	...

def unwrapUV(occurrences: list[int], method: UnwrapUVMethod, channel: int = -1, createSeamsFromLoI: bool = False, iterMax: int = 50, tolerance: float = 0.00001) -> None:
	"""Unwrap UV islands

	Args:
		occurrences (list[int]): Part occurrences to process
		method (UnwrapUVMethod): Minimization method to use for unwrapping (isometric or conformal)
		channel (int): The UV channel which will contains the texture coordinates
		createSeamsFromLoI (bool): Use Lines of Interest to generate UV islands
		iterMax (int): For iterative solvers: set the maximum number of iterations allowed
		tolerance (float): For iterative solvers: set the maximum error threshold
	"""
	...

def getFittingCylinder(occurrences: list[int], useAABB: bool = True, forcedAxis: geom.Point3 = geom.Vector3(0,0,0)) -> geom.Affine:
	"""Returns the fitting cylinder of a set of occurrences (based on MBB)

	Args:
		occurrences (list[int]): Occurrences to fit
		useAABB (bool): If true use the global Axis Aligned Bounding Box (AABB), else use a Minimum Bounding Box (MBB)
		forcedAxis (geom.Point3): Forced axis of the Cylinder when using MBB

	Returns:
		affine (geom.Affine): Affine transformation of the cylinder
	"""
	...

def getFittingSphere(occurrences: list[int], useAABB: bool = True) -> geom.Affine:
	"""Returns the fitting sphere of a set of occurrences

	Args:
		occurrences (list[int]): Occurrences to fit
		useAABB (bool): If true use the global Axis Aligned Bounding Box (AABB), else use a Minimum Bounding Box (MBB)

	Returns:
		affine (geom.Affine): Affine transformation of the sphere
	"""
	...

def bakeMaps(destinationOccurrences: list[int], sourceOccurrences: list[int], mapsToBake: list[BakeMap], channel: int = 0, resolution: int = 1024, padding: int = 1, shareMaps: bool = True, mapSuffix: str = "", additionalCustomMaps: list[CustomBakeMap] = list[CustomBakeMap](), tolerance: float = -1, method: BakingMethod = 0, opacityThreshold: float = 0.1, useCurrentPosition: bool = False, offset: float = 0, callbackList: list[Callable[[geom.Point3, geom.Point2, int, int], None]] = [], oneToOne: bool = False, reuseMaps: list[int] = list[int](), outputUsedMap: bool = False) -> list[int]:
	"""Bake texture maps on meshes from self or other meshes

	Args:
		destinationOccurrences (list[int]): Occurrences of the meshes where to store the baked map
		sourceOccurrences (list[int]): Occurrences of components from which to bake maps (if empty use destination)
		mapsToBake (list[BakeMap]): List of map to generate (Normal, Diffuse, ...)
		channel (int): UV channel of destOccurrence to use for the map generation
		resolution (int): Map resolution
		padding (int): Add padding to the map. A negative value means that the texture will be filled, and the padding for uv island is the absolute value
		shareMaps (bool): If true, all the destinationOccurrences will share the same maps
		mapSuffix (str): Add a suffix to the map names
		additionalCustomMaps (list[CustomBakeMap]): Additional custom maps to bake
		tolerance (float): Tolerance of projection for baking from source to destination
		method (BakingMethod): Method to find source color if source occurrences are different than destination occurrences (Prefer ProjOnly for point clouds and RayOnly for meshes)
		opacityThreshold (float): If the opacity is under this threshold, considers as fully transparent and store the color behind the intersection
		useCurrentPosition (bool): Use the current position instead of the T-Pose of the input occurrence
		offset (float): Offset from mesh
		callbackList (list[Callable[[geom.Point3, geom.Point2, int, int], None]]): Callbacks that returns a color
		oneToOne (bool): If true, each occurrence in sourceOccurrences will be baked to the occurrence in destinationOccurrences at the same index
		reuseMaps (list[int]): Allow to use existing image instead of creating new ones (override shareMaps=true) the maps must be in the same order than mapsToBake+additionalCustomMaps+callbackList + usedMap (see: outputUsedMap)
		outputUsedMap (bool): If True, an extra maps contained used pixels is output at the end of bakedMaps. It can be used by reuseMaps

	Returns:
		bakedMaps (list[int]): Baked map list
	"""
	...

def convertNormalMap(partOccurrences: list[int], normalMap: int, uvChannel: int = 0, sourceIsObjectSpace: bool = True, destinationIsObjectSpace: bool = False, sourceIsRightHanded: bool = True, destinationIsRightHanded: bool = True, replaceMap: bool = True, resolution: int = -1, padding: int = 1) -> int:
	"""Convert an existing normal map between Object-space and Tangent-space

	Args:
		partOccurrences (list[int]): Occurrences of components using the given map
		normalMap (int): Source normal map to convert
		uvChannel (int): UV channel used on the given map
		sourceIsObjectSpace (bool): If True, consider the given normalMap in Object-space representation, else Tangent-space
		destinationIsObjectSpace (bool): If True, convert the given normalMap to Object-space representation, else Tangent-space
		sourceIsRightHanded (bool): Considers source normal map as part of a right-handed coordinates system
		destinationIsRightHanded (bool): Generate destination normal map as part of a right-handed coordinates system
		replaceMap (bool): If true, the given normalMap will be replaced by the converted one
		resolution (int): New map resolution (if replaceMap=false), if resolution=-1, the input resolution will be used
		padding (int): Number of pixels to add for padding. A negative value means that the texture will be filled, and the padding for uv island is the absolute value

	Returns:
		convertedNormalMap (int): Converted normal map (equals normalMap if replaceMap=true)
	"""
	...

def createBillboard(occurrences: list[int], resolution: int = 1024, XPositive: bool = True, XNegative: bool = True, YPositive: bool = True, YNegative: bool = True, ZPositive: bool = True, ZNegative: bool = True, moveFacesToCenter: bool = True, leftHandedNormalMap: bool = False) -> int:
	"""Create a billboard imposter

	Args:
		occurrences (list[int]): Occurrences to bake in the billboard
		resolution (int): Total resolution of the billboard (contains all wanted faces)
		XPositive (bool): Bake face facing X+
		XNegative (bool): Bake face facing X-
		YPositive (bool): Bake face facing Y+
		YNegative (bool): Bake face facing Y-
		ZPositive (bool): Bake face facing Z+
		ZNegative (bool): Bake face facing Z-
		moveFacesToCenter (bool): If true, all face are moved to the center of the AABB of the occurrences, else it will shape an AABB
		leftHandedNormalMap (bool): If true, a left handed normal map will be generated

	Returns:
		billboard (int): Resulting billboard
	"""
	...

def fillNormalMap(normalMap: int) -> None:
	"""Fill normal map (useful after a decimation for example)

	Args:
		normalMap (int): Source normal map to convert
	"""
	...

def orientNormalMap(normalMap: int) -> None:
	"""Orient a tangent space normal map (all Z positive)

	Args:
		normalMap (int): Normal map to orient
	"""
	...

def barySmooth(occurrences: list[int], iteration: int = 1) -> None:
	"""Smooth the tessellations by moving the vertices to the barycenter of their neighbors

	Args:
		occurrences (list[int]): Occurrences of components to process
		iteration (int): Number of iterations
	"""
	...

def crackMoebiusStrips(occurrences: list[int], maxEdgeCount: int = 3) -> None:
	"""Remove moebius strip by topologically cracking them (make it orientable)

	Args:
		occurrences (list[int]): Occurrences of components to repair
		maxEdgeCount (int): Maximum number of edges to crack to remove one moebius strip
	"""
	...

def crackNonManifoldVertices(occurrences: list[int]) -> None:
	"""Splits non-manifold vertices

	Args:
		occurrences (list[int]): Occurrences of components to repair
	"""
	...

def createCavityOccurrences(occurrences: list[int], voxelSize: float, minimumCavityVolume: float, mode: InnerOuterOption = 0, parent: int = int()) -> int:
	"""Identify cavities and create occurrences to show them

	Args:
		occurrences (list[int]): Occurrences set to identify cavities
		voxelSize (float): Size of the voxels in mm
		minimumCavityVolume (float): Minimum volume of a cavity in cubic meter
		mode (InnerOuterOption): Select where to place camera (all cavities, only outer or only inner cavities)
		parent (int): The create occurrence root will be added under the parent if given, else it will be added under the deeper parent of given occurrences

	Returns:
		root (int): Parent occurrence of the cavity occurrences
	"""
	...

def invertPolygonFacesOrientation(occurrences: list[int]) -> None:
	"""Invert the orientation of tessellation elements

	Args:
		occurrences (list[int]): Occurrences of components to process
	"""
	...

def moebiusCracker(occurrences: list[int]) -> None:
	"""Splits moebius ring

	Args:
		occurrences (list[int]): Occurrences of components to repair
	"""
	...

def orientNormals(occurrences: list[int]) -> None:
	"""Orient existing normal according to the polygons clockwise

	Args:
		occurrences (list[int]): Occurrences of components to orient normals
	"""
	...

def remeshSurfacicHoles(occurrences: list[int], maxDiameter: float = 0, refine: bool = True, numberOfNeighbors: int = 3, fillWithMaterial: int = 0) -> None:
	"""Resmesh surfacic holes of tessellations

	Args:
		occurrences (list[int]): Occurrences of components to process
		maxDiameter (float): Maximum surfacic holes diameters
		refine (bool): Refine mesh for more details in holes
		numberOfNeighbors (int): Number of neighboring vertices to use for the MLS projection
		fillWithMaterial (int): If set, the given material will be used to fill the holes
	"""
	...

def removeDegeneratedPolygons(occurrences: list[int], tolerance: float) -> None:
	"""Remove some kinds of degenerated polygons

	Args:
		occurrences (list[int]): Occurrences of components to process
		tolerance (float): Degenerated tolerance
	"""
	...

def removeMultiplePolygon(occurrences: list[int]) -> None:
	"""Remove multiple polygon

	Args:
		occurrences (list[int]): Occurrences of components to repair
	"""
	...

def removeZFighting(occurrences: list[int]) -> float:
	"""Remove Z-fighting (surfaces overlapping) by slightly shrinking the selected parts' surfaces

	Args:
		occurrences (list[int]): Occurrences to process

	Returns:
		offset (float): Offset value used by the algorithm
	"""
	...

def repairMesh(occurrences: list[int], tolerance: float, crackNonManifold: bool = True, orient: bool = True) -> None:
	"""Launch the repair process to repair a disconnected or not clean tessellation

	Args:
		occurrences (list[int]): Occurrences of components to process
		tolerance (float): Connection tolerance
		crackNonManifold (bool): At the end of the repair process, crack resulting non-manifold edges
		orient (bool): If true reorient the model
	"""
	...

def repairNullNormals(occurrences: list[int]) -> None:
	"""Create normal on an existing normal set when normal is null (polygons appears black)

	Args:
		occurrences (list[int]): Occurrences of components to repair null normals
	"""
	...

def separateToManifold(occurrences: list[int]) -> None:
	"""Remove non manifold edges and try to reconnect manifold groups of triangles

	Args:
		occurrences (list[int]): Occurrences of components to process
	"""
	...

def sewBoundary(occurrences: list[int], maxDistance: float) -> None:
	"""Sew boundaries between them

	Args:
		occurrences (list[int]): Occurrences of components to repair
		maxDistance (float): Maximum distance between bundaries
	"""
	...

def vertexOffset(occurrences: list[int], offset: float = 1) -> None:
	"""Move the vertices by the offsset along their normal

	Args:
		occurrences (list[int]): Occurrences to process
		offset (float): Displacement
	"""
	...

def orientFromFace() -> None:
	"""Orient all connected polygons in the same orientation of the polygon selectionned
	"""
	...

def orientPolygonFaces(occurrences: list[int], makeOrientable: bool = True, useArea: bool = False, orientStrategy: OrientStrategy = 0) -> None:
	"""Orient tessellation elements

	Args:
		occurrences (list[int]): Occurrences of components to process
		makeOrientable (bool): Crack moebius strips to make the model orientable
		useArea (bool): Use the area instead of counting the number of triangle
		orientStrategy (OrientStrategy): Strategy to adopt with this algorithm
	"""
	...

def orientPolygonFacesAdvanced(occurrences: list[int], voxelSize: float, minimumCavityVolume: float, resolution: int, mode: InnerOuterOption = 0, considerTransparentOpaque: bool = True, orientStrategy: OrientStrategyAdvanced = 0) -> None:
	"""Properly orient all polygons in the same direction, using voxel based view points placement.

	Args:
		occurrences (list[int]): Occurrences to orient
		voxelSize (float): Size of the voxels in mm (smaller it is, more viewpoints there are)
		minimumCavityVolume (float): Minimum volume of a cavity in cubic meter (smaller it is, more viewpoints there are)
		resolution (int): Resolution of the visibility viewer
		mode (InnerOuterOption): Select where to place camera (all cavities, only outer or only inner cavities)
		considerTransparentOpaque (bool): If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque
		orientStrategy (OrientStrategyAdvanced): Strategy to adopt with this algorithm
	"""
	...

def orientPolygonFacesFromCamera(occurrences: list[int], cameraPosition: geom.Point3, cameraDirection: geom.Point3, cameraUp: geom.Point3, resolution: int, fovX: float = 90) -> None:
	"""Properly orient all polygons in the same direction, using a specified viewpoint

	Args:
		occurrences (list[int]): Occurrences to orient
		cameraPosition (geom.Point3): Camera position
		cameraDirection (geom.Point3): Camera direction
		cameraUp (geom.Point3): Camera up vector
		resolution (int): Resolution of the visibility viewer
		fovX (float): Horizontal field of view (in degree)
	"""
	...

def equilateralize(occurrences: list[int], maxIterations: int = 1) -> None:
	"""Sswap edges to make triangles more equilateral

	Args:
		occurrences (list[int]): Occurrences of components to process
		maxIterations (int): Maximum number of swapping iteration
	"""
	...

def quadify(occurrences: list[int]) -> None:
	"""Merge all triangle polygons in the meshes to quadrangles

	Args:
		occurrences (list[int]): Occurrences of components to process
	"""
	...

def requadify(occurrences: list[int], forceFullQuad: bool = True) -> None:
	"""Advanced function to requadify a triangle tessellation coming from full quad mesh

	Args:
		occurrences (list[int]): Occurrences of components to process
		forceFullQuad (bool): Force the results to be only full quad. It it's impossible, nothing is done
	"""
	...

def triangularize(occurrences: list[int]) -> None:
	"""Split all non-triangle polygons in the meshes to triangles

	Args:
		occurrences (list[int]): Occurrences of components to process
	"""
	...

def createVertexWeightsFromVertexColors(occurrences: list[int], offset: float = 0, scale: float = 1) -> None:
	"""Use vertex colors attributes on meshes of the given occurrence to create vertex weights attributes used by the decimation functions, the finals weights will be computed with w = offset + (red - blue) * scale

	Args:
		occurrences (list[int]): Occurrences of components to process
		offset (float): Offset value for weight computation
		scale (float): Scale value for weight computation
	"""
	...

def createVertexWeightsFromVisibilityAttributes(occurrences: list[int], offset: float = 0, scale: float = 1) -> None:
	"""Use visibility attributes on meshes of the given occurrence to create vertex weights attributes used by the decimation functions. The finals weights will be computed with w = offset + (visibility/maxVisibility) * scale

	Args:
		occurrences (list[int]): Occurrences of components to process
		offset (float): Offset value for weight computation
		scale (float): Scale value for weight computation
	"""
	...

def deleteVertexWeights(occurrences: list[int]) -> None:
	"""Remove any existing vertex weights attributes on given occurrences

	Args:
		occurrences (list[int]): Occurrences of components to process
	"""
	...

def createVisibilityAttributes(occurrences: list[int]) -> None:
	"""Create visibility attributes on tessellations

	Args:
		occurrences (list[int]): Occurrences of components to create attributes
	"""
	...

def deleteVisibilityAttributes(occurrences: list[int]) -> None:
	"""Delete visibility attributes on tessellations

	Args:
		occurrences (list[int]): Occurrences of components to delete attributes
	"""
	...

def flagVisibilityAttributesOnTransparents(occurrences: list[int]) -> None:
	"""Add one count to all visiblility attributes (poly and patch) on transparent patches

	Args:
		occurrences (list[int]): Occurrences of components to create attributes
	"""
	...

def transferVisibilityToPolygonalWeight(occurrences: list[int], Mode: VisibilityToWeightMode) -> None:
	"""Set Polygonal Weight Attribute from Visibility Attribute

	Args:
		occurrences (list[int]): Part occurrences to process
		Mode (VisibilityToWeightMode): Mode used to compute visibility
	"""
	...

# Callbacks
