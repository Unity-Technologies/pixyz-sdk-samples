from enum import Enum
from collections.abc import Callable

from pxz import cad
from pxz import core
from pxz import geom
from pxz import material
from pxz import polygonal

# Constants

# Classes
class AnimChannelInfo:
	"""
	"""
	name: str
	type: AnimChannelType
	mainPropertyBinder: int
	hasKeyFrames: bool
	def __init__(self, name: str, type: AnimChannelType, mainPropertyBinder: int, hasKeyFrames: bool) -> AnimChannelInfo: ...
	...

class AnimChannelType(Enum):
	"""
	"""
	SIMPLE: int
	VECTOR3: int
	QUATERNION: int
	MATRIX4: int
	...

class AnimPropertyBinder:
	"""
	"""
	occurrence: int
	animation: int
	mainChannel: int
	def __init__(self, occurrence: int, animation: int, mainChannel: int) -> AnimPropertyBinder: ...
	...

class AnimationInfo:
	"""
	"""
	name: str
	group: str
	length: int
	def __init__(self, name: str, group: str, length: int) -> AnimationInfo: ...
	...

class AnnotationDefinition:
	"""Annotation definition
	"""
	id: int
	name: str
	visible: bool
	group: int
	shapes: list[int]
	def __init__(self, id: int, name: str, visible: bool, group: int, shapes: list[int]) -> AnnotationDefinition: ...
	...

class ComponentType(Enum):
	"""
	"""
	Part: int
	PMI: int
	Light: int
	VisualBehavior: int
	InteractionBehavior: int
	Metadata: int
	Variant: int
	Animation: int
	Joint: int
	Widget: int
	OoCComponent: int
	LODComponent: int
	ExternalDataComponent: int
	HLODComponent: int
	CuttingPlaneComponent: int
	ReferencedDataComponent: int
	CameraComponent: int
	FeatureComponent: int
	SubpartMaterial: int
	...

class Filter:
	"""
	"""
	id: int
	name: str
	expr: str
	def __init__(self, id: int, name: str, expr: str) -> Filter: ...
	...

class JointDefinition:
	"""Joint definition
	"""
	id: int
	jointComponent: int
	isRoot: bool
	rootJoint: int
	parent: int
	children: list[int]
	matrix: list[list[float]]
	gloablMatrix: list[list[float]]
	def __init__(self, id: int, jointComponent: int, isRoot: bool, rootJoint: int, parent: int, children: list[int], matrix: list[list[float]], gloablMatrix: list[list[float]]) -> JointDefinition: ...
	...

class LightType(Enum):
	"""
	"""
	DirectionalLight: int
	PositionalLight: int
	SpotLight: int
	...

class MaterialCount:
	"""
	"""
	material: int
	count: int
	def __init__(self, material: int, count: int) -> MaterialCount: ...
	...

class MergeHiddenPartsMode(Enum):
	"""
	"""
	Destroy: int
	MakeVisible: int
	MergeSeparately: int
	...

class MergeStrategy(Enum):
	"""
	"""
	mergePartOccurrences: int
	MergeByMaterials: int
	...

class PackedTree:
	"""Packed view of the scene tree
	"""
	occurrences: list[int]
	parents: list[int]
	names: list[str]
	visible: list[core.InheritableBool]
	materials: list[int]
	transformIndices: list[int]
	transformMatrices: list[list[list[float]]]
	customProperties: list[list[core.StringPair]]
	def __init__(self, occurrences: list[int], parents: list[int], names: list[str], visible: list[core.InheritableBool], materials: list[int], transformIndices: list[int], transformMatrices: list[list[list[float]]], customProperties: list[list[core.StringPair]]) -> PackedTree: ...
	...

class PartialLoad_Status(Enum):
	"""
	"""
	NOT_LOADED: int
	LOADED: int
	LOADING: int
	LOADING_ALL: int
	...

class Primitive_Type(Enum):
	"""
	"""
	CUBE: int
	SPHERE: int
	PLAN: int
	CONE: int
	ARROW: int
	CYLINDER: int
	CAPSULE: int
	...

class ProberInfo:
	"""
	"""
	occurrence: int
	position: geom.Point3
	def __init__(self, occurrence: int, position: geom.Point3) -> ProberInfo: ...
	...

class ProductViewDefinition:
	"""ProductionView definition
	"""
	id: int
	name: str
	groupName: str
	view: list[list[float]]
	viewIsSet: bool
	viewIsOrtho: bool
	viewFov: float
	cuttingPlane: bool
	cuttingPlanePosition: geom.Point3
	cuttingPlaneNormal: geom.Point3
	explodedViewFactor: float
	explodedViewX: bool
	explodedViewY: bool
	explodedViewZ: bool
	annotations: list[int]
	def __init__(self, id: int, name: str, groupName: str, view: list[list[float]], viewIsSet: bool, viewIsOrtho: bool, viewFov: float, cuttingPlane: bool, cuttingPlanePosition: geom.Point3, cuttingPlaneNormal: geom.Point3, explodedViewFactor: float, explodedViewX: bool, explodedViewY: bool, explodedViewZ: bool, annotations: list[int]) -> ProductViewDefinition: ...
	...

class PropertyValue:
	"""A structure containing a property name and its value
	"""
	name: str
	value: str
	def __init__(self, name: str, value: str) -> PropertyValue: ...
	...

class RayHit:
	"""
	"""
	rayParam: float
	occurrence: int
	triangleIndex: int
	triangleParam: geom.Point2
	def __init__(self, rayParam: float, occurrence: int, triangleIndex: int, triangleParam: geom.Point2) -> RayHit: ...
	...

class ResizeByMaximumSizeOptions:
	"""
	"""
	TextureSize: int
	KeepTextureRatio: bool
	def __init__(self, TextureSize: int, KeepTextureRatio: bool) -> ResizeByMaximumSizeOptions: ...
	...

class SceneChangeType(Enum):
	"""
	"""
	CHILD_INSERTED: int
	CHILD_REMOVED: int
	PROPERTY_CHANGED: int
	COMPLETE_CHANGE: int
	...

class SelectionChangeType(Enum):
	"""
	"""
	CLEARED: int
	ADDED: int
	REMOVED: int
	...

class ShapeType(Enum):
	"""
	"""
	TESSELLATED: int
	CAD: int
	JOINT: int
	...

class VariantChangeType(Enum):
	"""
	"""
	ADDED: int
	REMOVED: int
	CURRENT_CHANGED: int
	...

class VariantDefinition:
	"""
	"""
	variant: int
	overridedProperties: list[PropertyValue]
	def __init__(self, variant: int, overridedProperties: list[PropertyValue]) -> VariantDefinition: ...
	...

class VariantMaterials:
	"""Variant and materials in variant 
	"""
	id: int
	materials: list[int]
	def __init__(self, id: int, materials: list[int]) -> VariantMaterials: ...
	...

class VisibilityMode(Enum):
	"""
	"""
	Inherited: int
	Hide: int
	...

# Functions
def addComponent(occurrence: int, componentType: ComponentType) -> int:
	"""Add a component to an occurrence

	Args:
		occurrence (int): The occurrence to add the new component
		componentType (ComponentType): Type of the component

	Returns:
		component (int): The new component added to occurrence
	"""
	...

def addComponents(occurrences: list[int], componentType: ComponentType) -> list[int]:
	"""Add a components to each occurrence in the array

	Args:
		occurrences (list[int]): Occurrences that need the component to be added
		componentType (ComponentType): Type of the component

	Returns:
		components (list[int]): Component that were added or retrieved
	"""
	...

def addInParentInstances(root: int) -> None:
	"""Add an instance of prototype's child as child in current occurrence recursively

	Args:
		root (int): The occurrence to test.
	"""
	...

def cleanUnusedImages() -> int:
	"""Remove unused images from texture library

	Returns:
		nbTextureDeleted (int): The number of texture deleted by the clean
	"""
	...

def cleanUnusedMaterials(cleanImages: bool = False) -> int:
	"""Remove unused materials from material library

	Args:
		cleanImages (bool): Call cleanUnusedImages if true

	Returns:
		nbMaterialDeleted (int): The number of material deleted by the clean
	"""
	...

def computeSubTreeChecksum(root: int = int()) -> str:
	"""Compute the checksum of a sub-tree

	Args:
		root (int): Occurrence to compute

	Returns:
		checksum (str): 
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

def convertMaterialsToColor(materials: list[int] = []) -> None:
	"""Convert all materials to materials with a color pattern, trying to keep the visual aspect as similar as possible

	Args:
		materials (list[int]): Materials to merge (merge all materials if empty)
	"""
	...

def convertMaterialsToPBR(materials: list[int] = []) -> None:
	"""Convert all materials to materials with a PBR pattern, trying to keep the visual aspect as similar as possible

	Args:
		materials (list[int]): Materials to merge (merge all materials if empty)
	"""
	...

def createHierarchicalClusters(root: int, childrenCountByNode: int = 2, minFitting: float = -1) -> None:
	"""Reorganize a sub tree with hierarchical clustering

	Args:
		root (int): Root of the sub-tree to reorganize
		childrenCountByNode (int): Order of the hierarchical tree
		minFitting (float): Minimal fitting coefficient to allow 2 nodes to be merged/clustered
	"""
	...

def createOBBMesh(occurrence: int) -> int:
	"""

	Args:
		occurrence (int): 

	Returns:
		obbOccurrence (int): The create occurrence
	"""
	...

def createOccurrence(name: str, parent: int = int()) -> int:
	"""Create a new occurrence

	Args:
		name (str): Name of the new occurrence
		parent (int): Create the occurrence as a child of parent, if not set the parent will be root

	Returns:
		occurrence (int): Created occurrence
	"""
	...

def createOccurrenceFromSelection(name: str, children: list[int], parent: int, keepMaterialAssignment: bool = True) -> int:
	"""Create a new occurrence and add the given occurrences as children

	Args:
		name (str): Name of the new occurrence
		children (list[int]): Add given occurrence as children (if any)
		parent (int): If defined, the new occurrence will be created as a child of this parent. Else if children are defined, the first common parent of children will be used as a parent for this new occurrence. Last resort will be to use the root as parent
		keepMaterialAssignment (bool): If defined, material assignation will be updated to keep the visual same aspect

	Returns:
		occurrence (int): Created occurrence
	"""
	...

def createOccurrenceFromText(text: str, font: str = "ChicFont", fontSize: int = 64, color: core.ColorAlpha = core.ColorAlpha(), heigth3D: float = 40) -> int:
	"""Creates an occurrence from string

	Args:
		text (str): The occurrence's name
		font (str): The font to use
		fontSize (int): The font size
		color (core.ColorAlpha): The occurrence color
		heigth3D (float): 3D height of text

	Returns:
		occurrence (int): 
	"""
	...

def createOccurrences(name: str, parents: list[int] = list[int]()) -> list[int]:
	"""Create one new occurrence under each given parent

	Args:
		name (str): Name of the new occurrence
		parents (list[int]): Create the occurrences as a child of each parent. If empty, one occurrence will be created with root as parent

	Returns:
		occurrences (list[int]): Created occurrences
	"""
	...

def createPartsFromMeshes(occurrences: list[int], meshes: list[int]) -> list[int]:
	"""Create a set of Parts given meshes and occurrences

	Args:
		occurrences (list[int]): The occurrence which will contains the part component of the mesh at the same index
		meshes (list[int]): List of mesh to create part, if the mesh is invalid (e.g 0) no part will be created and 0 will be returned in the parts list at this index

	Returns:
		parts (list[int]): List of created parts components, if there is no mesh at an index, no part is created and the identifier is 0
	"""
	...

def createSceneFromMeshes(meshes: list[int], matrices: list[list[list[float]]], centerPartPivots: bool = True) -> int:
	"""Create a scene tree with a list of meshes, all meshes becomes part occurrences with the same root. The same mesh Id can be used several times to handle create instances (prototypes)

	Args:
		meshes (list[int]): List of input meshes
		matrices (list[list[list[float]]]): List of matrices of input meshes (if empty Identity will be used)
		centerPartPivots (bool): If True, the input meshes will be centered in their local coordinate system and the translation will be set as part matrix. If you want to rollback the meshes to their initial pivots use 'resetPartTransform' function

	Returns:
		root (int): The created root occurrence
	"""
	...

def deleteComponentByType(componentType: ComponentType, occurrence: int, followPrototypes: bool = True) -> None:
	"""Delete component from type

	Args:
		componentType (ComponentType): Type of the component
		occurrence (int): The occurrence to remove components from
		followPrototypes (bool): If true and if the component is not set on the occurrence, try to find it on its prototyping chain
	"""
	...

def deleteComponentsByType(componentType: ComponentType, rootOccurrence: int = int()) -> None:
	"""Delete all components on subtree from type

	Args:
		componentType (ComponentType): Type of the component
		rootOccurrence (int): The root occurrence to remove components from
	"""
	...

def deleteEmptyOccurrences(root: int = 0) -> None:
	"""Delete all empty assemblies

	Args:
		root (int): Root occurrence for the process
	"""
	...

def deleteOccurrences(occurrences: list[int]) -> None:
	"""Delete a liste of occurrences

	Args:
		occurrences (list[int]): Occurrences to delete
	"""
	...

def generateOctaViews(radius: float, XFrames: int, YFrames: int, hemi: bool = False) -> int:
	"""

	Args:
		radius (float): 
		XFrames (int): 
		YFrames (int): 
		hemi (bool): 

	Returns:
		occurrence (int): The created Occurrence
	"""
	...

def generateOctree(occurrence: int, maxDepth: int = 5, looseFactor: float = 2) -> int:
	"""Generate a loose octree from the given sub-tree

	Args:
		occurrence (int): Root occurrence of the sub-tree
		maxDepth (int): Defines the depth maximum of the octree
		looseFactor (float): Defines the loose factor of the octree

	Returns:
		rootOctreeId (int): 
	"""
	...

def getAABB(occurrences: list[int]) -> geom.AABB:
	"""Returns the axis aligned bounding box of a list of scene paths

	Args:
		occurrences (list[int]): List of occurrences to retrieve the AABB

	Returns:
		aabb (geom.AABB): The axis aligned bounding box of all given occurrences
	"""
	...

def getActiveMaterial(occurrence: int) -> int:
	"""Get the active material on occurrence

	Args:
		occurrence (int): The occurrence

	Returns:
		material (int): The material
	"""
	...

def getActivePropertyValue(occurrence: int, propertyName: str, cacheProperty: bool = False) -> str:
	"""Get the value of a property on the first parent that own it

	Args:
		occurrence (int): An occurrence
		propertyName (str): Property name
		cacheProperty (bool): If true, the property will be copied on all ancestor of occurrence below the property owner to speed up future calls

	Returns:
		value (str): Property value
	"""
	...

def getActivePropertyValues(occurrences: list[int], propertyName: str, cacheProperty: bool = False) -> list[str]:
	"""Get the value of a property on the first parent that own it for each given occurrence

	Args:
		occurrences (list[int]): List of occurrences
		propertyName (str): Property name
		cacheProperty (bool): If true, the property will be copied on all ancestor of occurrence below the property owner to speed up future calls

	Returns:
		values (list[str]): Property value for each occurrence
	"""
	...

def getAncestors(occurrence: int) -> list[int]:
	"""Returns the list of ancestors for one occurrence

	Args:
		occurrence (int): The occurrence to test.

	Returns:
		ancestorList (list[int]): The list of ancestors.
	"""
	...

def getComponent(occurrence: int, componentType: ComponentType, followPrototypes: bool = True) -> int:
	"""Returns a component on an occurrence

	Args:
		occurrence (int): The occurrence
		componentType (ComponentType): Type of the component
		followPrototypes (bool): If true and if the component is not set on the occurrence, try to find it on its prototyping chain

	Returns:
		component (int): The component
	"""
	...

def getComponentByOccurrence(occurrences: list[int], componentType: ComponentType, followPrototypes: bool = True) -> list[int]:
	"""Returns one component of the specified type by occurrence if it exists

	Args:
		occurrences (list[int]): The occurrences list
		componentType (ComponentType): Type of the component
		followPrototypes (bool): If true and if the component is not set on the occurrence, try to find it on its prototyping chain

	Returns:
		components (list[int]): List of component synchronized with occurrences
	"""
	...

def getComponentOccurrence(component: int) -> int:
	"""Get the occurrence that own a component

	Args:
		component (int): The component

	Returns:
		occurrence (int): The occurrence
	"""
	...

def getComponentType(component: int) -> ComponentType:
	"""Get the type of a component

	Args:
		component (int): The component

	Returns:
		componentType (ComponentType): Type of the component
	"""
	...

def getGlobalMatrix(occurrence: int) -> list[list[float]]:
	"""Returns the global matrix on an occurrence

	Args:
		occurrence (int): Occurrence to get the global matrix

	Returns:
		matrix (list[list[float]]): The global matrix of the occurrence
	"""
	...

def getGlobalVisibility(occurrence: int) -> bool:
	"""Returns the global visibility of a given occurrence

	Args:
		occurrence (int): Occurrence to get the global visibility

	Returns:
		visible (bool): True if the occurrence is visible, else False
	"""
	...

def getLocalMatrix(occurrence: int) -> list[list[float]]:
	"""Returns the local matrix on an occurrence

	Args:
		occurrence (int): Node to get the local matrix

	Returns:
		matrix (list[list[float]]): The node local matrix
	"""
	...

def getMBB(occurrences: list[int]) -> geom.OBB:
	"""Returns the Minimum Bounding Box of a list of scene paths

	Args:
		occurrences (list[int]): List of occurrences to retrieve the AABB

	Returns:
		mbb (geom.OBB): The minimum bounding box of all given occurrences
	"""
	...

def getMaterialsFromSubtree(occurrence: int) -> list[int]:
	"""

	Args:
		occurrence (int): Root occurrence of the subtree on which to get the materials and images

	Returns:
		materials (list[int]): The retrieved materials
	"""
	...

def getOBB(occurrences: list[int]) -> geom.OBB:
	"""Returns the Oriented Bounding Box of a list of scene paths (works only on meshes, fast method, not the Minimum Volume Box)

	Args:
		occurrences (list[int]): List of occurrences to retrieve the AABB

	Returns:
		obb (geom.OBB): The oriented bounding box of all given occurrences
	"""
	...

def getOccurrenceActiveMaterial(occurrence: int) -> int:
	"""Returns the active material on a given occurrence

	Args:
		occurrence (int): Occurrence to get the active material

	Returns:
		material (int): The active material of the occurrence
	"""
	...

def getOccurrenceName(occurrence: int) -> str:
	"""Returns the name of an occurrence

	Args:
		occurrence (int): The occurrence to get the name

	Returns:
		name (str): The occurrence name
	"""
	...

def getOccurrencesWithComponent(componentType: ComponentType, fromOcc: int = int()) -> list[int]:
	"""Recursively get all the occurrences containing a component of the specified type

	Args:
		componentType (ComponentType): The component type
		fromOcc (int): Source occurrence of the recursion

	Returns:
		occurrences (list[int]): Result occurrences
	"""
	...

def getPartActiveShape(part: int) -> int:
	"""Returns the active shape of a part

	Args:
		part (int): The part

	Returns:
		shape (int): The active shape of a part
	"""
	...

def getPartOccurrences(fromOcc: int = int()) -> list[int]:
	"""Recursively get all the occurrences containing a part component

	Args:
		fromOcc (int): Source occurrence of the recursion

	Returns:
		occurrences (list[int]): Result occurrences
	"""
	...

def getPartShapeType(part: int) -> ShapeType:
	"""Get the part's shape type

	Args:
		part (int): The part to test

	Returns:
		shapeType (ShapeType): Shape's type
	"""
	...

def getPolygonCount(occurrences: list[int], asTriangleCount: bool = False, countOnceEachInstance: bool = False, countHidden: bool = False) -> int:
	"""Returns the number of polygon in the parts meshes

	Args:
		occurrences (list[int]): The part occurrences
		asTriangleCount (bool): If true count the equivalent of triangles for each polygon
		countOnceEachInstance (bool): If true ignore multiple instance of each tessellation
		countHidden (bool): If true, also count hidden components

	Returns:
		polygonCount (int): The number of polygons
	"""
	...

def getSubTreeStats(roots: list[int]) -> dict:
	"""Returns some stats of a sub tree

	Args:
		roots (list[int]): The root occurrences to get stats on.

	Returns:
		partCount (int): Number of parts in the sub-tree (instances are counted once)
		partOccurrenceCount (int): Number of part occurrence in the sub-tree (instances are counted multiple times)
		triangleCount (int): Number of triangles in the sub-tree (instances are counted once, quadrangle count for 2 triangles)
		triangleOccurrenceCount (int): Number of triangles in the sub-tree (instances are counted multiples times, quadrangle count for 2 triangles)
		vertexCount (int): Number of surfacic vertices in the sub-tree (instances are counted once)
		vertexOccurrenceCount (int): Number of surfacic vertices in the sub-tree (instances are counted multiples times)
		pointCount (int): Number of free vertices (points) in the sub-tree (instances are counted once)
		pointOccurrenceCount (int): Number of free vertices (points) in the sub-tree (instances are counted multiples times)
		lineCount (int): Number of free edges (line) in the sub-tree (instances are counted once)
		lineOccurrenceCount (int): Number of free edges (line) in the sub-tree (instances are counted multiples times)
	"""
	...

def getVertexCount(occurrences: list[int], countOnceEachInstance: bool = False, countHidden: bool = False, countPoints: bool = False, countMergedVertices: bool = False) -> int:
	"""Returns the number of vertices in the parts meshes

	Args:
		occurrences (list[int]): The part occurrences
		countOnceEachInstance (bool): If true ignore multiple instance of each tessellation
		countHidden (bool): If true, also count hidden components
		countPoints (bool): If true, also count points (for points cloud)
		countMergedVertices (bool): If true count all merged vertices in each tessellation

	Returns:
		vertexCount (int): The number of vertices
	"""
	...

def getViewpointsFromCavities(voxelSize: float, minCavityVolume: float) -> dict:
	"""Returns viewpoints from model cavities

	Args:
		voxelSize (float): Precision for cavities detection
		minCavityVolume (float): Minimum volume for a cavity to be returned

	Returns:
		positions (list[geom.Point3]): List of viewpoint positions
		directions (list[geom.Point3]): List of viewpoint directions
	"""
	...

def hasComponent(occurrence: int, componentType: ComponentType, followPrototypes: bool = True) -> bool:
	"""Returns True if the given occurrence has the given component type

	Args:
		occurrence (int): The occurrence
		componentType (ComponentType): Type of the component
		followPrototypes (bool): If true and if the component is not set on the occurrence, try to find it on its prototyping chain

	Returns:
		hasComp (bool): 
	"""
	...

def hide(occurrence: int) -> None:
	"""Hide the given occurrence

	Args:
		occurrence (int): The occurrence to hide
	"""
	...

def inverseVisibility(occurrence: int) -> None:
	"""Inverse the visibility of the given occurrence

	Args:
		occurrence (int): The occurrence
	"""
	...

def isAncestorOf(occurrence1: int, occurrence2: int) -> bool:
	"""Test if the occurrences are ancestors to one another.

	Args:
		occurrence1 (int): First occurrence to test.
		occurrence2 (int): Second occurrence to test.

	Returns:
		isAncestor (bool): If occurrences are ancestor to one another.
	"""
	...

def listComponent(componentType: ComponentType) -> list[int]:
	"""List all components on a type on the whole tree

	Args:
		componentType (ComponentType): The component type

	Returns:
		components (list[int]): The component list of the type chosen
	"""
	...

def listComponents(occurrence: int, followPrototypes: bool = True) -> list[int]:
	"""List all components on an occurrence

	Args:
		occurrence (int): The occurrence to list the components
		followPrototypes (bool): If true list also components owned by the prototype

	Returns:
		components (list[int]): The components owned by the occurrence
	"""
	...

def mergeImages(images: list[int] = []) -> int:
	"""Merge all equivalent images (i.e. with same pixels)

	Args:
		images (list[int]): Images to merge (merge all images if empty)

	Returns:
		nbTexture (int): The number of texture after the merge
	"""
	...

def mergeMaterials(materials: list[int] = [], evaluateNames: bool = False) -> int:
	"""Merge all equivalent materials (i.e. with same appearance)

	Args:
		materials (list[int]): Materials to merge (merge all materials if empty)
		evaluateNames (bool): If true, materials names will be taken into consideration (on top of other properties). It means that materials having same properties but different names won't be merged together.

	Returns:
		nbMaterial (int): The number of material after the merge
	"""
	...

def removeMaterials(roots: list[int] = list[int]()) -> None:
	"""Recursively remove all materials

	Args:
		roots (list[int]): If specified, remove materials only from the given occurrences and their descendants
	"""
	...

def renameLongOccurrenceName(maxLength: int) -> None:
	"""truncate names of occurrence with too long names

	Args:
		maxLength (int): Maximum name length
	"""
	...

def replaceMaterial(originalMaterial: int, newMaterial: int, occurrences: list[int] = list[int]()) -> None:
	"""Replace a material by another everywhere it is used

	Args:
		originalMaterial (int): The material to replace everywhere
		newMaterial (int): The new material to set in place of originalMaterial
		occurrences (list[int]): The occurrences on which replacing the materials
	"""
	...

def resizeTextures(inputMode: list, resizeMode: list, replaceTextures: bool) -> None:
	"""Resizes the textures from a selection of occurrences (resizes all textures used by these occurrences), or from a selection of textures

	Args:
		inputMode (list): Defines if the textures to resize are textures used by a selection of Occurrences, or a selection among the textures available in the scene
		resizeMode (list): Defines if the textures are resized following a ratio or following a maximum size/resolution (only textures above the defined maximum are downsized)
		replaceTextures (bool): If True, overwrites textures from the selection
	"""
	...

def setComponentOccurrence(component: int, occurrence: int) -> None:
	"""Move a component to an occurrence

	Args:
		component (int): The component
		occurrence (int): The occurrence
	"""
	...

def setDefaultVariant() -> None:
	"""Set the default variant
	"""
	...

def setOccurrenceMaterial(occurrence: int, material: int) -> None:
	"""Set the material on a occurrence

	Args:
		occurrence (int): Occurrence to set the material
		material (int): The new occurrence material
	"""
	...

def setOccurrenceName(occurrence: int, name: str) -> None:
	"""Returns the name of an occurrence

	Args:
		occurrence (int): The occurrence to get the name
		name (str): The occurrence name
	"""
	...

def show(occurrence: int) -> None:
	"""Show the given occurrence

	Args:
		occurrence (int): The occurrence to show
	"""
	...

def showOnly(occurrence: int) -> None:
	"""Show only the given occurrence

	Args:
		occurrence (int): The occurrence to show
	"""
	...

def transferCADMaterialsOnPartOccurrences(rootOccurrence: int = int()) -> None:
	"""Set all materials on part occurrences

	Args:
		rootOccurrence (int): Root occurrence
	"""
	...

def transferMaterialsOnPatches(rootOccurrence: int = int()) -> None:
	"""Take the first instance material and set it one the mesh patches

	Args:
		rootOccurrence (int): Root occurrence
	"""
	...

def createCapsule(radius: float, height: float, subdivisionLatitude: int = 16, subdivisionLongitude: int = 16, generateUV: bool = True) -> int:
	"""Create a new capsule

	Args:
		radius (float): Radius of the Capsule
		height (float): Height of the Capsule (excluding the two size of half spheres)
		subdivisionLatitude (int): Subdivision of the Capsule on the Latitude
		subdivisionLongitude (int): Subdivision of the Capsule (two half spheres) on the Longitude
		generateUV (bool): Generation of the UV

	Returns:
		occurrence (int): The created Occurrence
	"""
	...

def createCone(bottomRadius: float, height: float, sides: int = 16, generateUV: bool = True) -> int:
	"""Create a new cone

	Args:
		bottomRadius (float): Radius of the bottom of the cone 
		height (float): Height of the cone
		sides (int): Number of sides of the cone
		generateUV (bool): Generation of the UV

	Returns:
		occurrence (int): The created Occurrence
	"""
	...

def createCube(sizeX: float, sizeY: float, sizeZ: float, subdivision: int = 1, generateUV: bool = True) -> int:
	"""Create a new cube

	Args:
		sizeX (float): Size of the Cube on the x axis
		sizeY (float): Size of the Cube on the y axis
		sizeZ (float): Size of the Cube on the z axis
		subdivision (int): Subdivision of the Cube on all the axis
		generateUV (bool): Generation of the UV

	Returns:
		occurrence (int): The created Occurrence
	"""
	...

def createCylinder(radius: float, height: float, sides: int = 16, generateUV: bool = True) -> int:
	"""Create a new cylinder

	Args:
		radius (float): Radius of the Cylinder
		height (float): Height of the Cylinder
		sides (int): Number of Sides of the Cylinder
		generateUV (bool): Generation of the UV

	Returns:
		occurrence (int): The created Occurrence
	"""
	...

def createImmersion(radius: float, subdivisionX: int, subdivisionY: int) -> int:
	"""Create a new bagel klein

	Args:
		radius (float): Radius of the Immersion
		subdivisionX (int): Subdivision of the Immersion on the Latitude
		subdivisionY (int): Subdivision of the Immersion on the Longitude

	Returns:
		occurrence (int): The created Occurrence
	"""
	...

def createPlane(sizeY: float, sizeX: float, subdivisionX: int = 1, subdivisionY: int = 1, generateUV: bool = True) -> int:
	"""Create a  new plane

	Args:
		sizeY (float): Size of the Plane on the y axis
		sizeX (float): Size of the Plane on the x axis
		subdivisionX (int): Subdivision of the Plane on the x axis
		subdivisionY (int): Subdivision of the Plane on the y axis
		generateUV (bool): Generation of the UV

	Returns:
		occurrence (int): The created Occurrence
	"""
	...

def createSphere(radius: float, subdivisionLatitude: int = 16, subdivisionLongitude: int = 16, generateUV: bool = True) -> int:
	"""Create a new sphere

	Args:
		radius (float): Radius of the Sphere
		subdivisionLatitude (int): Subdivision of the Sphere on the Latitude
		subdivisionLongitude (int): Subdivision of the Sphere on the Longitude
		generateUV (bool): Generation of the UV

	Returns:
		occurrence (int): The created Occurrence
	"""
	...

def createTorus(majorRadius: float, minorRadius: float, subdivisionLatitude: int, subdivisionLongitude: int) -> int:
	"""Create a new torus

	Args:
		majorRadius (float): Major Radius
		minorRadius (float): Minor Radius
		subdivisionLatitude (int): Subdivision of the Torus on the Latitude
		subdivisionLongitude (int): Subdivision of the Torus on the Longitude

	Returns:
		occurrence (int): The created Occurrence
	"""
	...

def findDuplicatedPartOccurrences(root: int = 0, acceptVolumeRatio: float = 0.01, acceptPolycountRatio: float = 0.1, acceptAABBAxisRatio: float = 0.01, acceptAABBCenterDistance: float = 0.1) -> list[int]:
	"""Get duplicated parts

	Args:
		root (int): Root occurrence for the process
		acceptVolumeRatio (float): If the ratio of volumes of two part is lower than acceptVolumeRatio, they will be considered duplicated
		acceptPolycountRatio (float): If the ratio of polygon counts of two part is lower than acceptPolycountRatio, they will be considered duplicated
		acceptAABBAxisRatio (float): If the ratio of AABB axis of two part is lower than acceptAABBAxisRatio, they will be considered duplicated
		acceptAABBCenterDistance (float): If the ratio of AABB centers of two part is lower than acceptAABBCenterRatio, they will be considered duplicated

	Returns:
		duplicatedPartOccurrences (list[int]): Duplicated part occurrences
	"""
	...

def findOccurrencesByMaterial(material: int) -> list[int]:
	"""get occurrences for which the property "Material" is the given material

	Args:
		material (int): A material

	Returns:
		filtered (list[int]): The list of occurrences meeting the criteria
	"""
	...

def findOccurrencesByMetadata(property: str, regex: str, roots: list[int] = list[int](), caseInsensitive: bool = False) -> list[int]:
	"""Returns all occurrences which a metadata property value matches the given regular expression (ECMAScript)

	Args:
		property (str): Property name
		regex (str): Regular expression (ECMAScript)
		roots (list[int]): If specified, restrict the search from the given roots
		caseInsensitive (bool): If True, the regex will be insensitive to upper and lower cases

	Returns:
		occurrences (list[int]): Occurrences which matches the given regular expression
	"""
	...

def findOccurrencesByMetadataValue(regex: str, roots: list[int] = list[int](), caseInsensitive: bool = False) -> list[int]:
	"""Returns all occurrences with a metadata value matching the given regular expression (ECMAScript)

	Args:
		regex (str): Regular expression (ECMAScript)
		roots (list[int]): If specified, restrict the search from the given roots
		caseInsensitive (bool): If True, the regex will be insensitive to upper and lower cases

	Returns:
		occurrences (list[int]): Occurrences which matches the given regular expression
	"""
	...

def findOccurrencesByProperty(property: str, regex: str, roots: list[int] = list[int](), caseInsensitive: bool = False) -> list[int]:
	"""Returns all occurrences which a property value matches the given regular expression (ECMAScript)

	Args:
		property (str): Property name
		regex (str): Regular expression (ECMAScript)
		roots (list[int]): If specified, restrict the search from the given roots
		caseInsensitive (bool): If True, the regex will be insensitive to upper and lower cases

	Returns:
		occurrences (list[int]): Occurrences which matches the given regular expression
	"""
	...

def findPartOccurrencesByActiveMaterial(material: int, roots: list[int] = list[int]()) -> list[int]:
	"""Find all part occurrence with a given material as active material (i.e. as seen in the rendering)

	Args:
		material (int): A material
		roots (list[int]): If specified, restrict the search from the given roots

	Returns:
		occurrence (list[int]): Occurrences of parts with the given material as active material
	"""
	...

def findPartOccurrencesByMaximumSize(roots: list[int], maxDiagLength: float, maxSize: float = -1, getHidden: bool = False) -> list[int]:
	"""Get part occurrences by size

	Args:
		roots (list[int]): Roots occurrences for the process
		maxDiagLength (float): If the diagonal axis of the bounding box is less than maxDiagLength, part will be filtered. -1 to ignore
		maxSize (float): If the longer axis of the box is less than maxLength, part will be filtered. -1 to ignore
		getHidden (bool): If true, hidden part occurrences meeting the criteria will be filtered as well

	Returns:
		filtered (list[int]): The list of occurrences meeting the criteria
	"""
	...

def findPartOccurrencesByMinimumNumberOfInstances(minInstanciationCount: int) -> list[int]:
	"""get part occurrences with more than "minInstanciationCount" occurrence on the scene

	Args:
		minInstanciationCount (int): Min occurrence count

	Returns:
		filtered (list[int]): The list of occurrences meeting the criteria
	"""
	...

def findPartOccurrencesByVisibleMaterial(material: int) -> list[int]:
	"""get part occurrences for which the given material is visible in the viewer

	Args:
		material (int): A material

	Returns:
		filtered (list[int]): The list of occurrences meeting the criteria
	"""
	...

def findPartOccurrencesInAABB(aabb: geom.AABB) -> list[int]:
	"""find part occurrences in the scene in a given axis aligned bounding box

	Args:
		aabb (geom.AABB): The axis aligned bounding box

	Returns:
		occurrences (list[int]): Occurrences found in the given axis aligned bounded box
	"""
	...

def findPartOccurrencesInBox(box: geom.ExtendedBox, strictlyIncludes: bool) -> list[int]:
	"""get part occurrences contained in a given box

	Args:
		box (geom.ExtendedBox): The extension box
		strictlyIncludes (bool): If false, parts only need to intersect the box to be selected

	Returns:
		occurrences (list[int]): Part occurrences contained in the box
	"""
	...

def createSubTree(tree: PackedTree, root: int = 0, replaceRoot: bool = True) -> list[int]:
	"""Create a complete scene tree

	Args:
		tree (PackedTree): 
		root (int): Specify the root occurrence of the scene
		replaceRoot (bool): If true, the root occurrence will be replaced by the root of the given tree, else it will be added as a child

	Returns:
		occurrences (list[int]): Create occurrences (equivalent to tree.occurrences)
	"""
	...

def getChildren(occurrence: int) -> list[int]:
	"""Get the children of an occurrence

	Args:
		occurrence (int): The occurrence

	Returns:
		children (list[int]): Children occurrences
	"""
	...

def getCurrentVariantRoot() -> int:
	"""Get the current active root. Returns active variant's root if one or global root.

	Returns:
		root (int): The active variant root occurrence or global root if no active variant.
	"""
	...

def getOccurrenceAncestors(occurrence: int) -> list[int]:
	"""

	Args:
		occurrence (int): The occurrence to find ancestors

	Returns:
		ancestors (list[int]): List of ancestors (start with the root and end with occurrence parent). Empty if occurrence is a root
	"""
	...

def getOccurrencesAncestors(occurrences: list[int]) -> list[list[int]]:
	"""

	Args:
		occurrences (list[int]): The list of occurrences to find ancestors

	Returns:
		ancestorsList (list[list[int]]): For each given occurrence, the list of ancestors (start with the root and end with occurrence parent). Empty if occurrence is a root
	"""
	...

def getParent(occurrence: int) -> int:
	"""Get the parent of an occurrence

	Args:
		occurrence (int): The occurrence

	Returns:
		parent (int): The parent occurrence
	"""
	...

def getRoot() -> int:
	"""Get the root occurrence of the product structure

	Returns:
		root (int): The root occurrence
	"""
	...

def getSubTree(root: int = 0, visibilityMode: VisibilityMode = 1, depth: int = -1) -> PackedTree:
	"""Returns a packed version of the whole scene tree

	Args:
		root (int): Specify the root of the returned scene
		visibilityMode (VisibilityMode): The visibility mode
		depth (int): Maximum depth

	Returns:
		tree (PackedTree): 
	"""
	...

def moveOccurrences(occurrences: list[int], destination: int, insertBefore: int = 0) -> None:
	"""Move an occurrence, adjusting the transformation to keep objects at the same place in the world space

	Args:
		occurrences (list[int]): The occurrences to move
		destination (int): Destination occurrence (the new parent)
		insertBefore (int): Occurrence before witch to move, if null append to destination children
	"""
	...

def setParent(occurrence: int, parent: int, addInParentInstances: bool = False, insertBefore: int = int(), worldPositionStays: bool = False) -> None:
	"""Set the parent of an occurrence

	Args:
		occurrence (int): The occurrence
		parent (int): The parent occurrence
		addInParentInstances (bool): If True, each occurrence whose prototype is the target parent will generate a child whose prototype is the occurrence itself
		insertBefore (int): Add before this child occurrence in the children list of the parent occurrence
		worldPositionStays (bool): If true, the parent-relative position, scale and rotation are modified such that the object keeps the same world space position, rotation and scale as before.
	"""
	...

def addLightComponent(occurrence: int, lightType: LightType, color: core.Color, power: float = 1.0, cutOff: float = 20.0) -> int:
	"""Add a light component to an occurrence

	Args:
		occurrence (int): The occurrence to add the new component
		lightType (LightType): The type of the light
		color (core.Color): Color of the light
		power (float): The power of the light
		cutOff (float): The cutoff angle of the light

	Returns:
		component (int): The new component added to occurrence
	"""
	...

def createLight(name: str, lightType: LightType, color: core.Color, power: float = 1.0, cutOff: float = 20.0, parent: int = 0) -> int:
	"""Create an occurrence with a light component

	Args:
		name (str): Name of the light
		lightType (LightType): The type of the light
		color (core.Color): Color of the light
		power (float): The power of the light
		cutOff (float): The cutoff angle of the light
		parent (int): The parent of the light occurrence

	Returns:
		occurrence (int): The light created
	"""
	...

def addMetadata(metadata: int, name: str, value: str) -> None:
	"""Add a new metadata property to a metadata component

	Args:
		metadata (int): The metadata component
		name (str): The new property name
		value (str): The new property value
	"""
	...

def addMetadataBlock(metadata: int, names: list[str], values: list[str]) -> None:
	"""Add a new metadata property to a metadata component

	Args:
		metadata (int): The metadata component
		names (list[str]): The new properties names
		values (list[str]): The new properties values
	"""
	...

def createMetadatasFromDefinitions(occurrences: list[int], definitions: list[list[PropertyValue]]) -> list[int]:
	"""Create Metadata components from definitions

	Args:
		occurrences (list[int]): List of occurrences to add the metadata components
		definitions (list[list[PropertyValue]]): List of metadata definition

	Returns:
		metadatas (list[int]): List of metadata components created from definitions (if definition is empty no component is created)
	"""
	...

def getMetadata(metadata: int, name: str) -> str:
	"""Get a metadata property value from a metadata component

	Args:
		metadata (int): The metadata component
		name (str): The metadata property name

	Returns:
		component (str): The property value
	"""
	...

def getMetadatasDefinitions(metadatas: list[int]) -> list[list[PropertyValue]]:
	"""Returns definition of Metadata components

	Args:
		metadatas (list[int]): List of metadata component to retrieve definition

	Returns:
		definitions (list[list[PropertyValue]]): List of metadata definition for each given metadata component
	"""
	...

def removeMetadata(metadata: int, name: str) -> None:
	"""Remove a property from a metadata

	Args:
		metadata (int): The occurrence
		name (str): The name of the property
	"""
	...

def configureOoC(ooc: int, implementationType: str, implementationParameters: str) -> None:
	"""Set and configure an Out of Core component implementation

	Args:
		ooc (int): An OoC component
		implementationType (str): An implementation type (see listOoCImplementations)
		implementationParameters (str): Depends of implementation type
	"""
	...

def getOoCConfiguration(ooc: int) -> dict:
	"""Get the current configuration of an Out of Core component

	Args:
		ooc (int): An OoC component

	Returns:
		implementationType (str): The implementation type of the given ooc
		implementationParameters (str): Parametrization of the implementation
	"""
	...

def listOoCImplementations() -> list[str]:
	"""

	Returns:
		implementationTypes (list[str]): All available Out of Core implementation types
	"""
	...

def loadOoC(ooc: int) -> None:
	"""Ask an Out of Core component to load its sub-scene

	Args:
		ooc (int): An OoC component
	"""
	...

def unloadOoC(ooc: int) -> None:
	"""Ask an Out of Core component to unload its sub-scene

	Args:
		ooc (int): An OoC component
	"""
	...

def getSubpartMaterial(occurrence: int, subpartIndex: int) -> int:
	"""Get a subpart material assignment according to overrides on the scene tree with SubpartMaterial components

	Args:
		occurrence (int): The Occurrence
		subpartIndex (int): The subpart index

	Returns:
		material (int): The assigned material
	"""
	...

def listActiveShapeMaterials(part: int) -> list[int]:
	"""list all the materials used in the part shape

	Args:
		part (int): The part which contains sub materials

	Returns:
		materials (list[int]): Used materials
	"""
	...

def listSubpartMaterials(occurrence: int) -> list[int]:
	"""list all the materials used in the part shape or overrided with a SubpartMaterial component

	Args:
		occurrence (int): The occurrence which contains sub materials

	Returns:
		materials (list[int]): Used materials
	"""
	...

def listSubpartVariantMaterials(occurrence: int) -> list[VariantMaterials]:
	"""list all the materials variants in subpart 

	Args:
		occurrence (int): The occurrence which contains variants

	Returns:
		variantMaterials (list[VariantMaterials]): List of variant and materials
	"""
	...

def setSubpartMaterial(occurrence: int, subpartIndex: int, material: int) -> None:
	"""Set a subpart material assignment using a SubpartMaterial component

	Args:
		occurrence (int): The Occurrence
		subpartIndex (int): The subpart index
		material (int): The material
	"""
	...

def setSubpartVariantMaterials(occurrence: int, variantMaterials: list[VariantMaterials]) -> None:
	"""set materials in variant 

	Args:
		occurrence (int): The occurrence which contains variants
		variantMaterials (list[VariantMaterials]): List of variant and materials
	"""
	...

def setSubpartVariantMaterialsList(variants: list[int], materialListList: list[list[int]]) -> list[VariantMaterials]:
	"""set all the materials list in variants 

	Args:
		variants (list[int]): The part which contains variants
		materialListList (list[list[int]]): The part which contains the list of material variant list

	Returns:
		materialsVariant (list[VariantMaterials]): List of variant and materials
	"""
	...

def transferSubpartMaterialsOnPatches(occurrence: int) -> None:
	"""Assign SubpartMaterialComponent materials on the occurrence's part shapes. This might affect other Part in the scene if not singularized before.

	Args:
		occurrence (int): The occurrence which has sub materials assigned
	"""
	...

def createAlternativeTree(name: str, root: int = int()) -> int:
	"""Create a new alternative tree

	Args:
		name (str): The name of the new alternative tree
		root (int): The root occurrence

	Returns:
		tree (int): The new alternative tree
	"""
	...

def getAlternativeTreeRoot(tree: int) -> int:
	"""Returns the root occurrence associated with the given AlternativeTree

	Args:
		tree (int): Targeted alternative tree

	Returns:
		root (int): The root occurrence
	"""
	...

def listAlternativeTrees() -> list[int]:
	"""Returns all the available alternative trees

	Returns:
		trees (list[int]): All alternative trees
	"""
	...

def addAnimation(animation: int) -> None:
	"""Add an animation in Animation library

	Args:
		animation (int): Animation to add
	"""
	...

def addKeyframe(channel: int, time: int, value: float) -> int:
	"""Adds a keyframe in the curve

	Args:
		channel (int): The channel one wants to add a keyframe in
		time (int): The time
		value (float): The value

	Returns:
		keyframe (int): The corresponding keyframe
	"""
	...

def addKeyframeFromCurrentPosition(channel: int, time: int) -> None:
	"""Adds keyframes in a given AnimChannel based on current position

	Args:
		channel (int): The channel one wants to add a keyframe in
		time (int): The time
	"""
	...

def animatesThisOccurrence(animation: int, occurrence: int) -> bool:
	"""Does this Animation animates this Occurrence - or one of its parents (thus animating it indirectly) ?

	Args:
		animation (int): The Animation
		occurrence (int): The supposedly animated occurrence

	Returns:
		isAnimated (bool): The answer to this question
	"""
	...

def bakeAnimation(animation: int, occurrence: int, end: int, interval: int) -> None:
	"""Baking soda

	Args:
		animation (int): The Animation
		occurrence (int): The occurrence
		end (int): The parent occurrence
		interval (int): The interval
	"""
	...

def createAnimation(name: str) -> int:
	"""Creates an animation, need to use addAnimation when animation is filled

	Args:
		name (str): Name of the animation

	Returns:
		animation (int): The created animation
	"""
	...

def createSkeletonMesh(root: int) -> int:
	"""Create a skeleton mesh from a joint component tree

	Args:
		root (int): Root joint component node

	Returns:
		skeletonOcc (int): New occurrence containing the skeleton mesh
	"""
	...

def decimateAnimChannelBySegment(channel: int, precision: float) -> None:
	"""Decimates by segment a given AnimChannel

	Args:
		channel (int): The channel
		precision (float): The precision
	"""
	...

def deleteAnimation(animation: int) -> None:
	"""Deletes an animation

	Args:
		animation (int): The created animation
	"""
	...

def deleteEmptyAnimation() -> None:
	"""Delete all animation that contain 0 keyframes
	"""
	...

def displayAllKeyframesFromAnimChannel(channel: int) -> None:
	"""Displays info on the selected AnimChannel

	Args:
		channel (int): The channel
	"""
	...

def displayAllKeyframesFromAnimation(animation: int) -> None:
	"""Displays info on the selected animation

	Args:
		animation (int): The animation
	"""
	...

def displayValueFromAnimChannelAtTime(channel: int, time: int, defaultValue: bool = False) -> None:
	"""Displays the value

	Args:
		channel (int): The channel
		time (int): The time
		defaultValue (bool): Show default instead ?
	"""
	...

def getAnimChannelIfExists(animation: int, occurrence: int) -> int:
	"""Returns the main AnimChannel of an Occurrence according to a given Animation

	Args:
		animation (int): The Animation
		occurrence (int): The Occurrence

	Returns:
		channel (int): The channel
	"""
	...

def getAnimChannelInfo(channel: int) -> AnimChannelInfo:
	"""get an animation channel informations

	Args:
		channel (int): Animation to get info of

	Returns:
		channelInfo (AnimChannelInfo): 
	"""
	...

def getAnimChannelOccurrence(channel: int) -> int:
	"""Returns the Occurrence related to a given AnimChannel

	Args:
		channel (int): The channel

	Returns:
		occurrence (int): The corresponding occurrence
	"""
	...

def getAnimationComponentPropertyBinderLists(animationComponent: int) -> list[AnimPropertyBinder]:
	"""packs all animation-related info in an object

	Args:
		animationComponent (int): Animation to get info of

	Returns:
		animPropertyBinderList (list[AnimPropertyBinder]): 
	"""
	...

def getAnimationInfo(animation: int) -> AnimationInfo:
	"""packs all animation-related info in an object

	Args:
		animation (int): Animation to get info of

	Returns:
		animationInfo (AnimationInfo): 
	"""
	...

def getAnimationPropertyBinderLists(animation: int) -> list[AnimPropertyBinder]:
	"""packs all animation-related info in an object

	Args:
		animation (int): Animation to get info of

	Returns:
		animPropertyBinderList (list[AnimPropertyBinder]): 
	"""
	...

def getJointDefinition(joint: int) -> JointDefinition:
	"""Get joint definition from id

	Args:
		joint (int): Id of the joint

	Returns:
		jointDefinition (JointDefinition): The jointDefinition matching the id provided
	"""
	...

def getJointDefinitions(joints: list[int]) -> list[JointDefinition]:
	"""Get joint definition from id

	Args:
		joints (list[int]): Ids of joints

	Returns:
		jointDefinitions (list[JointDefinition]): An array of all jointDefinition matching joint provided
	"""
	...

def getKeyframeParentAnimChannel(keyframe: int) -> int:
	"""Returns the parent AnimChannel of a given Keyframe

	Args:
		keyframe (int): The keyframe one wants the parent of

	Returns:
		animChannel (int): The Parent
	"""
	...

def getKeyframes(channel: int) -> list[int]:
	"""Returns a list of all keyframes of a simple animChannel

	Args:
		channel (int): The channel one wants to extract the keyframs from

	Returns:
		keyframelist (list[int]): The list of keyframes
	"""
	...

def getMainChannel(channel: int) -> int:
	"""Returns the main AnimChannel of a given AnimChannel

	Args:
		channel (int): The channel one wants the main of

	Returns:
		mainChannel (int): The corresponding main Channel
	"""
	...

def getOccurrenceJoint(occurrence: int) -> int:
	"""Returns the Joint assigned to an occurrence if any

	Args:
		occurrence (int): The occurrence

	Returns:
		joint (int): The joint assigned to the given occurrence
	"""
	...

def getParentChannel(channel: int) -> int:
	"""Returns (if exists) the parent AnimChannel of a given AnimChannel

	Args:
		channel (int): The channel one wants the parent of

	Returns:
		parentChannel (int): The corresponding parent Channel
	"""
	...

def getSubChannel(channel: int, name: str) -> int:
	"""Returns the subchannel of a given name from an AnimChannel

	Args:
		channel (int): The channel one wants the subchannel of
		name (str): The name of the subchannel

	Returns:
		subChannel (int): The corresponding subchannel
	"""
	...

def getSubChannels(channel: int) -> list[int]:
	"""Returns all the sub channel of an AnimChannel

	Args:
		channel (int): The channel one wants the subchannel of

	Returns:
		subChannels (list[int]): The list of direct sub channels
	"""
	...

def linkPropertyToAnimation(animation: int, entity: int, propertyName: str) -> int:
	"""Creates a Binder in an Animation stack to animate an entity's property

	Args:
		animation (int): The Animation stack where to put a animated property
		entity (int): The entity object to animate
		propertyName (str): The name of the property to animate

	Returns:
		mainChannel (int): The main channel of the binder
	"""
	...

def listAnimations() -> list[int]:
	"""List all Animations from the scene

	Returns:
		animList (list[int]): The list containing animations
	"""
	...

def listMainChannels(animation: int) -> list[int]:
	"""List all main AnimChannel from a given Animation

	Args:
		animation (int): The Animation one wants to list the channels from

	Returns:
		channelList (list[int]): The list containing the AnimChannels
	"""
	...

def makeDefaultKeyframe(channel: int) -> None:
	"""Creates keyframes with the default values of the channel at time 0

	Args:
		channel (int): The channel
	"""
	...

def moveAnimation(animation: int, target: int, newParent: int, interval: int) -> None:
	"""Moving animation

	Args:
		animation (int): The Animation
		target (int): The target occurrence
		newParent (int): The new parent occurrence
		interval (int): The interval
	"""
	...

def removeKeyframe(channel: int, time: int) -> None:
	"""Removes a keyframe in the curve

	Args:
		channel (int): The channel one wants to remove a keyframe from
		time (int): The time
	"""
	...

def unlinkPropertyToAnimation(animation: int, entity: int, propertyName: str) -> None:
	"""Unlinks a binder

	Args:
		animation (int): The Animation stack where to put a animated property
		entity (int): The entity object to animate
		propertyName (str): The name of the property to animate
	"""
	...

def getBRepInfos() -> dict:
	"""

	Returns:
		partCount (int): The part count
		totalPartCount (int): The total part count
		vertexCount (int): The vertex count
		totalVertexCount (int): The total vertex count
		edgeCount (int): The edge count
		totalEdgeCount (int): The total edge count
		openShellCount (int): The open shell count
		totalOpenShellCount (int): The total open shell count
		bodyCount (int): The body count
		totalBodyCount (int): The total body count
		area2Dsum (float): The 2D area sum
		boundaryCount (int): The boundary count
		boundaryEdgeCount (int): The boundary edge count
	"""
	...

def getTessellationInfos(root: int = 0) -> dict:
	"""

	Args:
		root (int): Occurrence tree root

	Returns:
		partCount (int): The part count
		totalPartCount (int): The total part count
		vertexCount (int): The vertex count
		totalVertexCount (int): The total vertex count
		edgeCount (int): The edge count
		totalEdgeCount (int): The total edge count
		polygonCount (int): The polygon count
		totalPolygonCount (int): The total polygon count
		patchCount (int): The patch count
		totalPatchCount (int): The total patch count
		boundaryCount (int): The boundary count
		boundaryEdgeCount (int): The boundary edge count
		nonManifoldEdgeCount (int): The non manifold edge count
	"""
	...

def print(root: int = 0) -> None:
	"""Print an occurrence tree on log

	Args:
		root (int): Occurrence tree root
	"""
	...

def addFilterToLibrary(name: str, expr: str) -> int:
	"""Add a filter to the filters library

	Args:
		name (str): Name of the filter
		expr (str): The filter expression

	Returns:
		filterId (int): Identifier of the created filter
	"""
	...

def evaluateExpression(filter: str) -> str:
	"""Evaluate the given filter expression

	Args:
		filter (str): The filter expression

	Returns:
		result (str): Result of the given expression
	"""
	...

def evaluateExpressionOnOccurrences(occurrences: list[int], filter: str) -> list[str]:
	"""evaluate the given filter expression on all occurrences under the given occurrence and returns the result

	Args:
		occurrences (list[int]): Occurrences on which to evaluate the expression
		filter (str): The filter expression

	Returns:
		evaluations (list[str]): The evaluation of the expression on the occurrence at the same index in given occurrences
	"""
	...

def evaluateExpressionOnSubTree(filter: str, fromOcc: int = int()) -> dict:
	"""evaluate the given filter expression on all occurrences under the given occurrence and returns the result

	Args:
		filter (str): The filter expression
		fromOcc (int): Source occurrence of the recursion

	Returns:
		occurrences (list[int]): 
		evaluations (list[str]): The evaluation of the expression on the occurrence at the same index in occurrences
	"""
	...

def exportFilterLibrary(file: str) -> None:
	"""Export filters from a given file

	Args:
		file (str): File path to export
	"""
	...

def findFilterByName(name: str) -> Filter:
	"""Returns the first filter in the filter library with the given name

	Args:
		name (str): Name of the filter to retrieve (case sensitive)

	Returns:
		filter (Filter): The retrieved filter
	"""
	...

def getFilterExpression(filterId: int) -> str:
	"""Returns the filter expression (string) from a filter id stored in the library

	Args:
		filterId (int): Identifier of the filter to fetch

	Returns:
		expr (str): Filter expression
	"""
	...

def getFilterFromLibrary(filterId: int) -> Filter:
	"""Retrieve a filter from the library with its identifier

	Args:
		filterId (int): Identifier of the filter to retrieve

	Returns:
		filter (Filter): The retrieved filter
	"""
	...

def getFilteredOccurrences(filter: str, fromOcc: int = int()) -> list[int]:
	"""Recursively get all the occurrences validating the given filter expression

	Args:
		filter (str): The filter expression
		fromOcc (int): Source occurrence of the recursion

	Returns:
		occurrences (list[int]): Result occurrences
	"""
	...

def importFilterLibrary(file: str) -> None:
	"""Import filters from a given file

	Args:
		file (str): File containing the filter library
	"""
	...

def listFilterLibrary() -> list[Filter]:
	"""Returns all the filter stored in the filter library

	Returns:
		filters (list[Filter]): All the filters stored in the filter library
	"""
	...

def removeFilterFromLibrary(filterId: int) -> None:
	"""Remove a filter from the filters library

	Args:
		filterId (int): Identifier of the filter to remove
	"""
	...

def isolate(occurrences: list[int]) -> None:
	"""Enter isolate mode by isolating a subset of the scene for process, export, viewer, ...

	Args:
		occurrences (list[int]): Occurrences to isolate
	"""
	...

def unisolate() -> None:
	"""Exit the isolate mode
	"""
	...

def findPartOccurrencesWithUnstitchedFaces(root: int) -> list[int]:
	"""Find all the occurrences with unstitched faces

	Args:
		root (int): Root occurrence

	Returns:
		unstitchedFacesOccurrences (list[int]): Unstitched faces occurrences
	"""
	...

def mergeOccurrencesByTreeLevel(roots: list[int], maxLevel: int, mergeHiddenPartsMode: MergeHiddenPartsMode = 2) -> None:
	"""Merge all parts over maxLevel level

	Args:
		roots (list[int]): Roots occurrences for the process
		maxLevel (int): Maximum tree level
		mergeHiddenPartsMode (MergeHiddenPartsMode): Hidden parts handling mode, Destroy them, make visible or merge separately
	"""
	...

def mergePartOccurrences(partOccurrences: list[int], mergeHiddenPartsMode: MergeHiddenPartsMode = 2) -> list[int]:
	"""Merge a set of parts

	Args:
		partOccurrences (list[int]): Occurrence of the parts to merge
		mergeHiddenPartsMode (MergeHiddenPartsMode): Hidden parts handling mode, Destroy them, make visible or merge separately

	Returns:
		mergedOccurrences (list[int]): Resulting merged occurrences
	"""
	...

def mergePartOccurrencesByAssemblies(roots: list[int] = list[int](), mergeHiddenPartsMode: MergeHiddenPartsMode = 2) -> None:
	"""Merge all parts under each assembly together

	Args:
		roots (list[int]): Roots occurrences for the process (will not be removed)
		mergeHiddenPartsMode (MergeHiddenPartsMode): Hidden parts handling mode, Destroy them, make visible or merge separately
	"""
	...

def mergePartOccurrencesByFinalAssemblies(roots: list[int] = list[int](), mergeHiddenPartsMode: MergeHiddenPartsMode = 2, CollapseToParent: bool = True) -> None:
	"""Merge final level (occurrences with only occurrence with part component as children)

	Args:
		roots (list[int]): Roots occurrences for the process (will not be removed)
		mergeHiddenPartsMode (MergeHiddenPartsMode): Hidden parts handling mode, Destroy them, make visible or merge separately
		CollapseToParent (bool): If true, final level unique merged part will replace it's parent
	"""
	...

def mergePartOccurrencesByMaterials(partOccurrences: list[int], mergeNoMaterials: bool = True, mergeHiddenPartsMode: MergeHiddenPartsMode = 2, combineMeshes: bool = True) -> list[int]:
	"""Merge a set of parts by materials

	Args:
		partOccurrences (list[int]): Occurrence of the parts to merge
		mergeNoMaterials (bool): If true, merge all parts with no active material together, else do not merge them
		mergeHiddenPartsMode (MergeHiddenPartsMode): Hidden parts handling mode, Destroy them, make visible or merge separately
		combineMeshes (bool): If true, explode and remerge the input parts by visible materials

	Returns:
		mergedOccurrences (list[int]): Resulting merged occurrences
	"""
	...

def mergePartOccurrencesByName(root: int = 0, mergeHiddenPartsMode: MergeHiddenPartsMode = 2) -> None:
	"""Merge all parts by occurrences names

	Args:
		root (int): Root occurrence of the subtree to process
		mergeHiddenPartsMode (MergeHiddenPartsMode): Hidden parts handling mode, Destroy them, make visible or merge separately
	"""
	...

def mergePartOccurrencesByRegions(roots: list[int], mergeBy: list, strategy: MergeStrategy) -> list[int]:
	"""Merge all parts within the same area.

	Args:
		roots (list[int]): Roots occurrences for the process (will not be removed)
		mergeBy (list): Number: number of output parts (or regions of parts)\nSize: diagonal size of output regions
		strategy (MergeStrategy): Choose the regions merging strategy

	Returns:
		mergedOccurrences (list[int]): Resulting merged occurrences
	"""
	...

def mergePartOccurrencesWithOpenShells(root: int) -> list[int]:
	"""Merge occurrences that contain only openShell as CAD entities

	Args:
		root (int): Root of the main assembly to merge

	Returns:
		mergedOccurrences (list[int]): List of the merged occurrence that contained only openShell
	"""
	...

def applyTransformation(occurrence: int, matrix: list[list[float]]) -> None:
	"""apply a transformation to the local matrix of an occurrence

	Args:
		occurrence (int): Occurrence to apply the matrix on
		matrix (list[list[float]]): Transformation to matrix
	"""
	...

def createSymmetry(occurrences: list[int], plane: geom.AxisPlane) -> None:
	"""Create symmetries from selection

	Args:
		occurrences (list[int]): Selection of occurrences
		plane (geom.AxisPlane): Symmetry plane
	"""
	...

def rotate(occurrence: int, axis: geom.Point3, angle: float) -> None:
	"""Modify the local matrix of the scene node to apply a rotation

	Args:
		occurrence (int): Occurrence to rotate
		axis (geom.Point3): Axis of rotation
		angle (float): Angle of rotation
	"""
	...

def setLocalMatrix(occurrence: int, matrix: list[list[float]]) -> None:
	"""change the local matrix on an occurrence

	Args:
		occurrence (int): Occurrence to set the local matrix
		matrix (list[list[float]]): The new occurrence local matrix
	"""
	...

def getPartMesh(part: int) -> int:
	"""Return the mesh of the TesselatedShape

	Args:
		part (int): The part component

	Returns:
		mesh (int): The mesh of the tessellated shape of the part
	"""
	...

def getPartModel(part: int) -> int:
	"""Return the model of the BRepShape

	Args:
		part (int): The part component

	Returns:
		model (int): The model of the BRep shape of the part
	"""
	...

def getPartsMeshes(parts: list[int]) -> list[int]:
	"""Return the meshes of the TesselatedShape for each given parts if any

	Args:
		parts (list[int]): The list of part component

	Returns:
		meshes (list[int]): The list of mesh of the tessellated shape of each part
	"""
	...

def getPartsModels(parts: list[int]) -> list[int]:
	"""Return the models of the BRepShape for each given parts if any

	Args:
		parts (list[int]): The list of part component

	Returns:
		models (list[int]): The list of models of the BRep shape of each part
	"""
	...

def getPartsTransforms(parts: list[int]) -> list[list[list[float]]]:
	"""Returns the transform matrix of each given parts

	Args:
		parts (list[int]): The parts to retrieve transform

	Returns:
		transforms (list[list[list[float]]]): The transform matrix of each part
	"""
	...

def getPartsTransformsIndexed(parts: list[int]) -> dict:
	"""Returns the transform matrix of each given parts (indexed mode)

	Args:
		parts (list[int]): The parts to retrieve transform

	Returns:
		indices (list[int]): The transform matrix index for each parts (0 for Identity)
		transforms (list[list[list[float]]]): The list of transform matrices (the first is always Identity)
	"""
	...

def setPartMesh(part: int, mesh: int) -> None:
	"""Add a mesh to a part (create a TessellatedShape on the part)

	Args:
		part (int): The part component
		mesh (int): The mesh to add to the part
	"""
	...

def setPartModel(part: int, model: int) -> None:
	"""Add a model to a part (create a BRepShape on the part)

	Args:
		part (int): The part component
		model (int): The model to add to the part
	"""
	...

def setPartsTransforms(parts: list[int], transforms: list[list[list[float]]]) -> None:
	"""Set the transform matrix of each given parts

	Args:
		parts (list[int]): The parts to retrieve transform
		transforms (list[list[list[float]]]): The transform matrix of each part
	"""
	...

def setPartsTransformsIndexed(parts: list[int], indices: list[int], transforms: list[list[list[float]]]) -> None:
	"""Set the transform matrix of each given parts (indexed mode)

	Args:
		parts (list[int]): The parts to retrieve transform
		indices (list[int]): The transform matrix index for each parts
		transforms (list[list[list[float]]]): The list of transform matrices
	"""
	...

def getPartialLoadingStatus(component: int) -> PartialLoad_Status:
	"""Get the current status of a partial loading component

	Args:
		component (int): Referenced Data component

	Returns:
		status (PartialLoad_Status): The current status
	"""
	...

def setReferencedDataComponentParent(component: int, parent: int) -> None:
	"""Defines which referenced data is parent to the given component

	Args:
		component (int): The referenced data component to alter
		parent (int): The parent
	"""
	...

def setReferencedDataComponentPath(component: int, filePath: str) -> None:
	"""Defines which path the refereced data is at

	Args:
		component (int): The referenced data component to alter
		filePath (str): The filepath
	"""
	...

def alignPivotPointToWorld(occurrences: list[int], applyToChildren: bool) -> None:
	"""Re-orient the Pivot Point straight to world origin (the grid)

	Args:
		occurrences (list[int]): The occurrences to modify
		applyToChildren (bool): If True, all the pivot of the descending occurrences from occurrence will be affected
	"""
	...

def movePivotPointToOccurrenceCenter(occurrences: list[int], applyToChildren: bool) -> None:
	"""Move the pivot point of each occurrence listed in the function input, to the center of its bounding box (and of its children if the parameter is True)

	Args:
		occurrences (list[int]): Occurrences (or the roots occurrences if recursively=True)
		applyToChildren (bool): If True, all the pivot of the descending occurrences from occurrence will be affected
	"""
	...

def movePivotPointToOrigin(occurrence: int, applyToChildren: bool) -> None:
	"""Move the pivot point of an occurrence (and its descendants if recursively) to the origin (0,0,0)

	Args:
		occurrence (int): The occurrence (or the root occurrence if recursively=True)
		applyToChildren (bool): If True, all the pivot of the descending occurrences from occurrence will be affected
	"""
	...

def movePivotPointToSelectionCenter(occurrences: list[int]) -> None:
	"""Move the pivot point of all given occurrences to the center of all occurrences

	Args:
		occurrences (list[int]): The occurrences to modify
	"""
	...

def movePivotPointToTargetedOccurrenceCenter(occurrences: list[int], target: int, applyToChildren: bool) -> None:
	"""Move the pivot point of each occurrence listed in the function input, to the center of the targeted occurrence Center (and of its children if the parameter is True)

	Args:
		occurrences (list[int]): The occurrence (or the root occurrence if recursively=True)
		target (int): The target occurrence
		applyToChildren (bool): If True, all the pivot of the descending occurrences from occurrence will be affected
	"""
	...

def setPivotOnly(occurrence: int, pivot: list[list[float]]) -> None:
	"""Set the pivot of an occurrence to the given transformation matrix, the geometry will not be moved (warning: do not confuse with property Transform which actually move the occurrence)

	Args:
		occurrence (int): The occurrence to move the pivot
		pivot (list[list[float]]): The new transformation matrix for the occurrence (pivot)
	"""
	...

def addAnnotationGroup(component: int, name: str) -> int:
	"""add a Annotation Group to the pmi component

	Args:
		component (int): Component to add the Annotation Group
		name (str): Name of the annotation group

	Returns:
		group (int): Annotation group created
	"""
	...

def addMeshToAnnotation(annotation: int, material: int, staticmesh: int) -> None:
	"""add a mesh and its material to a annotation

	Args:
		annotation (int): 
		material (int): 
		staticmesh (int): 
	"""
	...

def convertPMIToOccurrences(occurrences: list[int], convertVisibility: bool = False) -> None:
	"""Convert each PMI component into a set of occurrences with mesh geometries

	Args:
		occurrences (list[int]): Occurrence selection
		convertVisibility (bool): If True, the visibility will be converted (useful to select a specific view/variant), else all occurrences will be visible
	"""
	...

def createAnnotationFromDefinition(definition: AnnotationDefinition) -> int:
	"""

	Args:
		definition (AnnotationDefinition): Annotation definition

	Returns:
		metadata (int): 
	"""
	...

def getAnnotationDefinition(annotation: int) -> AnnotationDefinition:
	"""get definition of given annotation

	Args:
		annotation (int): 

	Returns:
		definition (AnnotationDefinition): 
	"""
	...

def getAnnotationGroups(pmiComponent: int) -> list[int]:
	"""Returns the list of the AnnotationGroup from a PMIComponent

	Args:
		pmiComponent (int): The pmi component

	Returns:
		groups (list[int]): List of AnnotationGroup
	"""
	...

def getAnnotations(group: int) -> list[int]:
	"""Returns the list of the Annotation from a AnnotationGroup

	Args:
		group (int): The AnnotationGroup

	Returns:
		annotations (list[int]): List of Annotation
	"""
	...

def getOccurrenceAnnotationDefinitions(occurrence: int) -> list[AnnotationDefinition]:
	"""get all annotations definition of given occurrence

	Args:
		occurrence (int): 

	Returns:
		definitions (list[AnnotationDefinition]): 
	"""
	...

def getProductViewDefinition(view: int) -> ProductViewDefinition:
	"""get productview definition

	Args:
		view (int): The product view

	Returns:
		definition (ProductViewDefinition): 
	"""
	...

def getProductViewDefinitions() -> list[ProductViewDefinition]:
	"""get all productviews definitions

	Returns:
		definitions (list[ProductViewDefinition]): 
	"""
	...

def setAnnotationToGroup(annotation: int, group: int) -> None:
	"""set Annotation to a Annotation Group

	Args:
		annotation (int): 
		group (int): 
	"""
	...

def cleanInstances(removeUselessInstances: bool, removeHierarchyOverridingInstances: bool, occurrence: int = 0) -> None:
	"""Clean prototypes and instances (lonely instances, overriding their prototypes hierarchies...).

	Args:
		removeUselessInstances (bool): Remove instances where they are not needed (prototype referenced once, ...)
		removeHierarchyOverridingInstances (bool): Remove instances overriding their prototypes sub-hierarchies.
		occurrence (int): Root occurrence for the process
	"""
	...

def getDirectInstances(prototype: int) -> list[int]:
	"""Returns all the occurrences prototyping the given occurrence

	Args:
		prototype (int): The prototype occurrence

	Returns:
		instances (list[int]): The instances
	"""
	...

def getInstances(occurrence: int) -> list[int]:
	"""Get occurrences sharing the same prototype as the given one

	Args:
		occurrence (int): Reference part occurrence

	Returns:
		instances (list[int]): The list of occurrences sharing the same prototype
	"""
	...

def getPrototype(occurrence: int) -> int:
	"""Returns the prototype of an occurrence

	Args:
		occurrence (int): The occurrence

	Returns:
		prototype (int): The prototype (if any)
	"""
	...

def prototypeSubTree(prototype: int) -> int:
	"""Create occurrences that prototype the given occurrence and all its subtree

	Args:
		prototype (int): The root occurrence of the sub-tree to prototype

	Returns:
		occurrence (int): The root occurrence of the prototyped sub-tree
	"""
	...

def setPrototype(occurrence: int, prototype: int) -> None:
	"""Sets the prototype of an occurrence

	Args:
		occurrence (int): The occurrence
		prototype (int): The prototype
	"""
	...

def clearSelection() -> None:
	"""Clear the current selection
	"""
	...

def deleteSelection() -> None:
	"""Delete all selected occurrences, and/or sub-occurrence elements
	"""
	...

def explodeSelection() -> None:
	"""For each occurrence, create a new occurrence with the selected sub-occurrence elements and remove them from the original occurrence
	"""
	...

def getSelectedOccurrences(keepAncestors: bool = False) -> list[int]:
	"""Returns all the selected occurrences

	Args:
		keepAncestors (bool): If True, occurrences with ancestors selected will be remove from the list

	Returns:
		selection (list[int]): The list of selected occurrences
	"""
	...

def invertOrientationSelection() -> None:
	"""Invert the orientation of each selected item (occurrences and/or sub-occurrence elements
	"""
	...

def invertSelection() -> None:
	"""Replace the selection by all unselected part occurrences
	"""
	...

def select(occurrences: list[int]) -> None:
	"""Add occurrences to selection

	Args:
		occurrences (list[int]): Occurrences to add to the selection
	"""
	...

def separateSelection() -> int:
	"""Separate all polygons form their original parts into a new one

	Returns:
		newOccurrence (int): The new occurrence created
	"""
	...

def unselect(occurrence: list[int]) -> None:
	"""Remove occurrences to selection

	Args:
		occurrence (list[int]): Occurrences to remove from the selection
	"""
	...

def compress(occurrence: int = 0) -> int:
	"""Compress a sub-tree by removing occurrence containing only one Child or empty, and by removing useless instances (see removeUselessInstances)

	Args:
		occurrence (int): Root occurrence for the process

	Returns:
		resultingOccurrences (int): The resulting occurrences of compression
	"""
	...

def convertToOldSchoolVisibility(root: int = 0) -> None:
	"""Modify the visible properties of the sub-tree to look like old school visibility (only hidden/inherited)

	Args:
		root (int): Root occurrence
	"""
	...

def getHiddenPartOccurrences(roots: list[int] = list[int]()) -> list[int]:
	"""Get hidden part occurrences

	Args:
		roots (list[int]): Roots occurrences for the process

	Returns:
		filtered (list[int]): The list of hidden occurrences (visibility status)
	"""
	...

def getVisiblePartOccurrences(roots: list[int] = list[int]()) -> list[int]:
	"""Get visible part occurrences

	Args:
		roots (list[int]): Roots occurrences for the process

	Returns:
		filtered (list[int]): The list of visible part occurrences (visibility status)
	"""
	...

def makeInstanceUnique(occurrences: list[int] = 0, keepOnlyPartInstances: bool = False) -> None:
	"""Singularize all instances on the sub-tree of an occurrence

	Args:
		occurrences (list[int]): Root occurrence for the process
		keepOnlyPartInstances (bool): If true, instances of part will not be singularized
	"""
	...

def rake(occurrence: int = 0, keepInstances: bool = False) -> None:
	"""Set the same parent to all descending parts (all parts will be singularized)

	Args:
		occurrence (int): Root occurrence for the process
		keepInstances (bool): If false, the part will be singularized
	"""
	...

def removeSymmetryMatrices(occurrence: int = 0) -> None:
	"""Remove symmetry matrices (apply matrices on geometries on nodes under an occurrence with a symmetry matrix

	Args:
		occurrence (int): Root occurrence for the process
	"""
	...

def resetPartTransform(root: int = 0) -> None:
	"""Set all part transformation matrices to identity in a sub-tree, transformation will be applied to the shapes

	Args:
		root (int): Root occurrence for the process
	"""
	...

def resetTransform(root: int, recursive: bool = True, keepInstantiation: bool = True, keepPartTransform: bool = False) -> None:
	"""Set all transformation matrices to identity in a sub-tree.

	Args:
		root (int): Root occurrence for the process
		recursive (bool): If False, transformation will be applied only on the root and its components
		keepInstantiation (bool): If False, all occurrences will be singularized
		keepPartTransform (bool): If False, transformation will be applied to the shapes (BRepShape points or TessellatedShape vertices)
	"""
	...

def createRayProber() -> int:
	"""Creates a ray prober

	Returns:
		id (int): 
	"""
	...

def createSphereProber() -> int:
	"""Creates a sphere prober

	Returns:
		id (int): 
	"""
	...

def rayCast(ray: geom.Ray, root: int) -> RayHit:
	"""

	Args:
		ray (geom.Ray): The ray to cast
		root (int): The root occurrence to cast from

	Returns:
		hit (RayHit): Information of the first ray hit
	"""
	...

def rayCastAll(ray: geom.Ray, root: int) -> list[RayHit]:
	"""

	Args:
		ray (geom.Ray): The ray to cast
		root (int): The root occurrence to cast from

	Returns:
		hits (list[RayHit]): Information of the first ray hit
	"""
	...

def updateRayProber(proberID: int, ray: geom.Ray) -> None:
	"""Updates the designed ray prober

	Args:
		proberID (int): The ray prober Id
		ray (geom.Ray): Update the prober's ray values
	"""
	...

def updateSphereProber(proberID: int, sphereCenter: geom.Point3, sphereRadius: float) -> None:
	"""Updates the designed sphere prober

	Args:
		proberID (int): The sphere prober Id
		sphereCenter (geom.Point3): The new prober center
		sphereRadius (float): The new prober radius
	"""
	...

def getMultipleOccurrenceUserData(userDataId: int, occurrences: list[int]) -> list[core.Ptr]:
	"""Batch version of getOccurrenceUserData

	Args:
		userDataId (int): UserData identifier provided by subscribeToOccurrenceUserData
		occurrences (list[int]): Occurrences that store the user data

	Returns:
		userDataList (list[core.Ptr]): User data stored for each given occurrence
	"""
	...

def getOccurrenceUserData(userDataId: int, occurrence: int) -> core.Ptr:
	"""Set or replace a userdata stored on an occurrence

	Args:
		userDataId (int): UserData identifier provided by subscribeToOccurrenceUserData
		occurrence (int): Occurrence that store the user data

	Returns:
		userData (core.Ptr): User data stored in the given occurrence
	"""
	...

def hasMultipleOccurrenceUserData(userDataId: int, occurrences: list[int]) -> list[bool]:
	"""Batch version of hasOccurrenceUserData

	Args:
		userDataId (int): UserData identifier provided by subscribeToOccurrenceUserData
		occurrences (list[int]): Occurrences that potentially store the user data

	Returns:
		results (list[bool]): Returns an array of bool that are true if a userdata is stored on the occurrence at the same index for the given userDataId
	"""
	...

def hasOccurrenceUserData(userDataId: int, occurrence: int) -> bool:
	"""Set or replace a userdata stored on an occurrence

	Args:
		userDataId (int): UserData identifier provided by subscribeToOccurrenceUserData
		occurrence (int): Occurrence that potentially store the user data

	Returns:
		result (bool): Returns true if a userdata is stored on this occurrence for the given userDataId
	"""
	...

def setMultipleOccurrenceUserData(userDataId: int, occurrences: list[int], userDataList: list[core.Ptr]) -> None:
	"""Batch version of setOccurrenceUserData

	Args:
		userDataId (int): UserData identifier provided by subscribeToOccurrenceUserData
		occurrences (list[int]): Occurrences that will store the user data
		userDataList (list[core.Ptr]): User data to store on each occurrence
	"""
	...

def setOccurrenceUserData(userDataId: int, occurrence: int, userData: core.Ptr) -> None:
	"""Set or replace a userdata stored on an occurrence

	Args:
		userDataId (int): UserData identifier provided by subscribeToOccurrenceUserData
		occurrence (int): Occurrence that will store the user data
		userData (core.Ptr): User data to store in the given occurrence
	"""
	...

def subscribeToOccurrenceUserData() -> int:
	"""subscribe to occurrence user data. multiple different userdata can be stored on the same occurrences if subscribeToOccurrenceUserData is called multiple times

	Returns:
		userDataId (int): UserData identifier to pass to setUserData/getUserData functions
	"""
	...

def unsetMultipleOccurrenceUserData(userDataId: int, occurrences: list[int]) -> None:
	"""Batch version of unsetOccurrenceUserData

	Args:
		userDataId (int): UserData identifier provided by subscribeToOccurrenceUserData
		occurrences (list[int]): Occurrences that will store the user data
	"""
	...

def unsetOccurrenceUserData(userDataId: int, occurrence: int) -> None:
	"""Unset the userdata stored on an occurrence

	Args:
		userDataId (int): UserData identifier provided by subscribeToOccurrenceUserData
		occurrence (int): Occurrence that will store the user data
	"""
	...

def unsubscribeFromOccurrenceUserData(userDataId: int) -> None:
	"""

	Args:
		userDataId (int): UserData identifier to unsubscribe
	"""
	...

def addVariant(name: str) -> int:
	"""Create a new variant

	Args:
		name (str): The name of the new variant

	Returns:
		variant (int): The new variant
	"""
	...

def duplicateVariant(variant: int, name: str) -> int:
	"""Create a new variant which is a copy of an existing variant

	Args:
		variant (int): The variant to duplicated
		name (str): Name of the new variant

	Returns:
		newVariant (int): The created variant
	"""
	...

def getVariantComponentsDefinitions(variantComponents: list[int]) -> list[list[VariantDefinition]]:
	"""Returns the definitions of multiple variant components

	Args:
		variantComponents (list[int]): The list of variant components to retrieve definitions

	Returns:
		definitions (list[list[VariantDefinition]]): For each variant component, returns one list of variant definition (one by variant)
	"""
	...

def getVariantTree(variant: int) -> int:
	"""Get the alternative tree used by this variant

	Args:
		variant (int): The variant

	Returns:
		tree (int): The alternative tree used by this variant
	"""
	...

def listVariants() -> list[int]:
	"""Returns all the available variants

	Returns:
		variants (list[int]): All variants
	"""
	...

def removeVariant(variant: int) -> None:
	"""Remove a variant

	Args:
		variant (int): The variant to remove
	"""
	...

def setCurrentVariant(variant: int = int()) -> None:
	"""Change the current variant used

	Args:
		variant (int): The variant to enable (can be null)
	"""
	...

def setVariantTree(variant: int, tree: int) -> None:
	"""Set the alternative tree to use for this variant

	Args:
		variant (int): The variant to modify
		tree (int): The alternative tree to use for this variant
	"""
	...

# Callbacks
def addSceneChangedCallback(callback: Callable[[SceneChangeType, int, int], None], userdata):
	"""
	"""
	...

def removeSceneChangedCallback(id: int):
	"""Remove callback added with scene.addSceneChangedCallback
	"""
	...

def addAnimationAddedCallback(callback: Callable[[int], None], userdata):
	"""
	"""
	...

def removeAnimationAddedCallback(id: int):
	"""Remove callback added with scene.addAnimationAddedCallback
	"""
	...

def addAnimationChangedCallback(callback: Callable[[int], None], userdata):
	"""
	"""
	...

def removeAnimationChangedCallback(id: int):
	"""Remove callback added with scene.addAnimationChangedCallback
	"""
	...

def addAnimationClearedCallback(callback: Callable[[], None], userdata):
	"""Ebent sent when Animation library is cleared
	"""
	...

def removeAnimationClearedCallback(id: int):
	"""Remove callback added with scene.addAnimationClearedCallback
	"""
	...

def addAnimationRemovedCallback(callback: Callable[[int], None], userdata):
	"""
	"""
	...

def removeAnimationRemovedCallback(id: int):
	"""Remove callback added with scene.addAnimationRemovedCallback
	"""
	...

def addSelectionChangedCallback(callback: Callable[[SelectionChangeType, list[int]], None], userdata):
	"""
	"""
	...

def removeSelectionChangedCallback(id: int):
	"""Remove callback added with scene.addSelectionChangedCallback
	"""
	...

def addVariantChangedCallback(callback: Callable[[VariantChangeType, int], None], userdata):
	"""
	"""
	...

def removeVariantChangedCallback(id: int):
	"""Remove callback added with scene.addVariantChangedCallback
	"""
	...

def addonRayProbeCallback(callback: Callable[[int, ProberInfo], None], userdata):
	"""
	"""
	...

def removeonRayProbeCallback(id: int):
	"""Remove callback added with scene.addonRayProbeCallback
	"""
	...

def addonSphereProbeCallback(callback: Callable[[int, ProberInfo], None], userdata):
	"""
	"""
	...

def removeonSphereProbeCallback(id: int):
	"""Remove callback added with scene.addonSphereProbeCallback
	"""
	...


def selectByMaximumSize(root, SIZE, param, param1):
    return None