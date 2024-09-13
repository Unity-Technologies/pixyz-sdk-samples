from enum import Enum
from collections.abc import Callable

from pxz import core
from pxz import geom

# Constants

# Classes
class ColorMaterialInfos:
	"""
	"""
	name: str
	color: core.ColorAlpha
	def __init__(self, name: str, color: core.ColorAlpha) -> None: ...
	...

class ImageChangeType(Enum):
	"""
	"""
	ADDED: int
	REMOVED: int
	CHANGED: int
	RESET: int
	REPLACED: int
	...

class ImageDefinition:
	"""
	"""
	id: int
	name: str
	width: int
	height: int
	bitsPerComponent: int
	componentsCount: int
	data: list[core.Byte]
	def __init__(self, id: int, name: str, width: int, height: int, bitsPerComponent: int, componentsCount: int, data: list[core.Byte]) -> None: ...
	...

class ImpostorMaterialInfos:
	"""
	"""
	name: str
	albedo: list
	normal: list
	roughness: list
	ao: list
	depth: list
	nbFrames: int
	fullOcta: bool
	octaDiameter: float
	linearSteps: int
	binarySteps: int
	def __init__(self, name: str, albedo: list, normal: list, roughness: list, ao: list, depth: list, nbFrames: int, fullOcta: bool, octaDiameter: float, linearSteps: int, binarySteps: int) -> None: ...
	...

class MaterialChangeType(Enum):
	"""
	"""
	CHANGED: int
	PATTERN_CHANGED: int
	RELOAD: int
	DESTROYED: int
	ICON_CHANGED: int
	ADDED: int
	REMOVED: int
	...

class MaterialDefinition:
	"""
	"""
	name: str
	id: int
	albedo: list
	normal: list
	metallic: list
	roughness: list
	ao: list
	opacity: list
	emissive: list
	def __init__(self, name: str, id: int, albedo: list, normal: list, metallic: list, roughness: list, ao: list, opacity: list, emissive: list) -> None: ...
	...

class MaterialFromMapsReturn:
	"""
	"""
	importedTextureCount: int
	createdMaterialCount: int
	updatedMaterialCount: int
	def __init__(self, importedTextureCount: int, createdMaterialCount: int, updatedMaterialCount: int) -> None: ...
	...

class MaterialPatternType(Enum):
	"""
	"""
	CUSTOM: int
	COLOR: int
	STANDARD: int
	UNLIT_TEXTURE: int
	PBR: int
	IMPOSTOR: int
	LINE: int
	...

class PBRMaterialInfos:
	"""
	"""
	name: str
	albedo: list
	normal: list
	metallic: list
	roughness: list
	ao: list
	opacity: list
	def __init__(self, name: str, albedo: list, normal: list, metallic: list, roughness: list, ao: list, opacity: list) -> None: ...
	...

class ResizeFilterMethod(Enum):
	"""
	"""
	DEFAULT: int
	BOX: int
	TRIANGLE: int
	CUBICBSPLINE: int
	CATMULLROM: int
	MITCHELL: int
	...

class ShaderUniformType(Enum):
	"""The possible types of shader uniform parameters
	"""
	INTEGER: int
	BOOLEAN: int
	REAL: int
	COEFF: int
	POINT3: int
	POINT2: int
	COLOR: int
	COLOR_ALPHA: int
	TEXTURE: int
	COLORORTEXTURE: int
	COEFFORTEXTURE: int
	...

class StandardMaterialInfos:
	"""
	"""
	name: str
	diffuse: list
	specular: list
	ambient: list
	emissive: list
	shininess: float
	transparency: float
	def __init__(self, name: str, diffuse: list, specular: list, ambient: list, emissive: list, shininess: float, transparency: float) -> None: ...
	...

class Texture:
	"""
	"""
	image: int
	channel: int
	offset: geom.Point2
	tilling: geom.Point2
	def __init__(self, image: int, channel: int, offset: geom.Point2, tilling: geom.Point2) -> None: ...
	...

class UnlitTextureMaterialInfos:
	"""
	"""
	name: str
	texture: Texture
	def __init__(self, name: str, texture: Texture) -> None: ...
	...

# Functions
def addUniformProperty(pattern: int, name: str, type: ShaderUniformType) -> None:
	"""Add a shader uniform parameter to the given custom pattern

	Args:
		pattern (int): The custom pattern to edit
		name (str): Name of the new property
		type (ShaderUniformType): Type of the new uniform
	"""
	...

def areOpaques(materials: list[int]) -> list[bool]:
	"""Check if some materials are opaques. Function will return 'False' for each material if:\n- The 'Opacity' Coeff is not 1.0\n- The 'Opacity' property is a Texture\n- The 'Albedo' property is a Texture and at least one pixel of the texture has an alpha value

	Args:
		materials (list[int]): Materials to check opacity

	Returns:
		opaques (list[bool]): For each given material, returns True if opaque or False if transparent
	"""
	...

def clearAllMaterials() -> None:
	"""Remove and delete all the materials
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

def convertFloat32To8BitsImage(image32F: int, minValue: float = -1, maxValue: float = 1) -> int:
	"""Returns a new image from the given converter from 32bits float to a 8Bits (e.g. depth render map)

	Args:
		image32F (int): Image to convert
		minValue (float): Minimal value of the floats (will be 0 in 8bits)
		maxValue (float): Minimal value of the floats (will be 255 in 8bits)

	Returns:
		image8U (int): The new 8bits image
	"""
	...

def convertHeightMapToNormalMap(hmap: int, height: float = 0.5) -> int:
	"""Convert a height map to a normal map

	Args:
		hmap (int): Height map reference
		height (float): Maximum height

	Returns:
		nmap (int): Normal map
	"""
	...

def copyMaterial(toCopy: int, addToMaterialLibrary: bool) -> int:
	"""copies a material

	Args:
		toCopy (int): Material to copy
		addToMaterialLibrary (bool): Add to material library

	Returns:
		material (int): The copied material
	"""
	...

def createCustomMaterialPattern(name: str) -> int:
	"""Create a new custom material pattern

	Args:
		name (str): Name of the pattern

	Returns:
		pattern (int): The created material pattern
	"""
	...

def createImageFromData(data: list[core.Byte], name: str = "img") -> int:
	"""Import an Image from only its data

	Args:
		data (list[core.Byte]): The raw data as input
		name (str): If need of a name

	Returns:
		image (int): The created Image
	"""
	...

def createImageFromDefinition(imageDefinition: ImageDefinition) -> int:
	"""Import an image from its raw data

	Args:
		imageDefinition (ImageDefinition): The image definition

	Returns:
		image (int): The created image
	"""
	...

def createImagesFromDefinitions(imageDefinitions: list[ImageDefinition]) -> list[int]:
	"""Import images from their raw data

	Args:
		imageDefinitions (list[ImageDefinition]): The image definitions

	Returns:
		images (list[int]): The created images
	"""
	...

def createMaterial(name: str, pattern: str, addToMaterialLibrary: bool = True) -> int:
	"""Create a new material from pattern

	Args:
		name (str): Name of the material
		pattern (str): Name of the pattern
		addToMaterialLibrary (bool): Name of the pattern

	Returns:
		material (int): The created material
	"""
	...

def createMaterialFromDefinition(materialDefinition: MaterialDefinition) -> int:
	"""Create PBR material from a material definition

	Args:
		materialDefinition (MaterialDefinition): The structure containing all the PBR material information

	Returns:
		material (int): The created material
	"""
	...

def createMaterialsFromDefinitions(materialDefinitions: list[MaterialDefinition]) -> list[int]:
	"""Create PBR materials from material definitions

	Args:
		materialDefinitions (list[MaterialDefinition]): Material definitions containing properties for each given material

	Returns:
		materials (list[int]): The created materials
	"""
	...

def createMaterialsFromMaps(directory: str) -> MaterialFromMapsReturn:
	"""Automatically creates PBR materials when importing PBR texture maps from a folder

	Args:
		directory (str): Directory path

	Returns:
		result (MaterialFromMapsReturn): Results of the createMaterialsFromMaps function
	"""
	...

def exportImage(image: int, filename: str) -> None:
	"""Export an image

	Args:
		image (int): Identifier of the image to export
		filename (str): Filename of the file to export
	"""
	...

def fillUnusedPixels(image: int, unusedColor: core.ColorAlpha) -> int:
	"""Fill unused pixels by propagating and averaging used pixels

	Args:
		image (int): Image to process
		unusedColor (core.ColorAlpha): Color used to identify unused pixels

	Returns:
		filledImage (int): Resulting image with filled pixels
	"""
	...

def filterAO(aoMap: int, normalMap: int, sigmaPos: float = 10, sigmaValue: float = 0.1, sigmaNormal: float = 0.01, levelCount: int = 4, filterLowValues: bool = True, lowValueThreshold: float = 0.01) -> int:
	"""Filter an AO map using ATrous method

	Args:
		aoMap (int): Input AO Map (the alpha component must be set to 0 for unused pixels)
		normalMap (int): Input Normal Map (preferable to use a World space normal map, but an Object space normal map can be used)
		sigmaPos (float): ATrous Sigma pos
		sigmaValue (float): ATrous Sigma value
		sigmaNormal (float): ATrous Sigma normal
		levelCount (int): Atrous #Levels
		filterLowValues (bool): Remove low values from the filtering (see: lowValuesThreshold parameter)
		lowValueThreshold (float): Threshold used if filterLowValues is enabled

	Returns:
		filterAOMap (int): The filtered AO Map
	"""
	...

def findCustomMaterialPatternByName(name: str) -> int:
	"""Returns the material pattern which has the given name

	Args:
		name (str): The name of the material pattern

	Returns:
		pattern (int): The material pattern
	"""
	...

def findMaterialsByPattern(pattern: str) -> list[int]:
	"""Returns all materials using the given pattern

	Args:
		pattern (str): A material pattern

	Returns:
		materials (list[int]): Materials using the pattern
	"""
	...

def findMaterialsByProperty(propertyName: str, propertyValue: str, caseInsensitive: bool = False) -> list[int]:
	"""Returns all materials which match a given property value

	Args:
		propertyName (str): Name of the property to match
		propertyValue (str): Regular expression to match for the property value
		caseInsensitive (bool): If True, the regex will be insensitive to upper and lower cases

	Returns:
		materials (list[int]): Materials matching the property value
	"""
	...

def getAllImages(materials: list[int] = []) -> list[int]:
	"""Returns all the images loaded in the current session or from a list of materials

	Args:
		materials (list[int]): Materials to retrieve the images from (returns all images loaded in the current session if empty)

	Returns:
		images (list[int]): A list containing all images identifiers
	"""
	...

def getAllMaterialPatterns() -> list[str]:
	"""Returns all the material patterns in the current session

	Returns:
		shaders (list[str]): A list containing all material patterns
	"""
	...

def getAllMaterials() -> list[int]:
	"""Retrieve the list of all the materials in the material library

	Returns:
		materials (list[int]): List of materials in the material library
	"""
	...

def getColorMaterialInfos(material: int) -> ColorMaterialInfos:
	"""Get color material properties

	Args:
		material (int): The material to get properties

	Returns:
		infos (ColorMaterialInfos): The ColorMaterialInfos properties
	"""
	...

def getCustomMaterialPattern(material: int) -> int:
	"""Returns the custom material pattern associated to the custom material

	Args:
		material (int): Custom material to get the pattern from

	Returns:
		pattern (int): The custom material pattern
	"""
	...

def getExportImageFormats() -> list[core.Format]:
	"""Returns image format names and extensions which can be exported in Pixyz

	Returns:
		formats (list[core.Format]): Image formats that can be exported
	"""
	...

def getImageDefinition(image: int) -> ImageDefinition:
	"""Returns the raw data of an image

	Args:
		image (int): Image's definition

	Returns:
		imageDefinition (ImageDefinition): Definition of the image
	"""
	...

def getImageDefinitions(images: list[int]) -> list[ImageDefinition]:
	"""Returns the raw data of a set of images

	Args:
		images (list[int]): The images

	Returns:
		imageDefinitions (list[ImageDefinition]): Images's definitions
	"""
	...

def getImagePixelColor(image: int, x: int, y: int) -> core.ColorAlpha:
	"""Returns the color of a given pixel in an image

	Args:
		image (int): The image to get the pixel from
		x (int): The x pixel coordinates
		y (int): The y pixel coordinates

	Returns:
		color (core.ColorAlpha): The color of the pixel at the x,y position
	"""
	...

def getImageSize(image: int) -> dict:
	"""Returns the size of an image

	Args:
		image (int): The image to get the size from

	Returns:
		width (int): The width of the image in pixels
		height (int): The height of the image in pixels
	"""
	...

def getImagesSizes(images: list[int]) -> dict:
	"""Returns the sizes of multiple images

	Args:
		images (list[int]): The image to get the size from

	Returns:
		widths (list[int]): The widths of the images in pixels
		heights (list[int]): The heights of the images in pixels
	"""
	...

def getImportImageFormats() -> list[core.Format]:
	"""Returns the image format names and extensions which can be imported in Pixyz

	Returns:
		formats (list[core.Format]): Image formats that can be imported
	"""
	...

def getImpostorMaterialInfos(material: int) -> ImpostorMaterialInfos:
	"""Get impostor texture material properties

	Args:
		material (int): The material to get properties

	Returns:
		infos (ImpostorMaterialInfos): The getImpostorMaterialInfos properties
	"""
	...

def getMaterialDefinition(material: int) -> MaterialDefinition:
	"""Returns the properties of a PBR Material

	Args:
		material (int): The PBR Material

	Returns:
		materialDefinition (MaterialDefinition): The PBR material definition
	"""
	...

def getMaterialDefinitions(materials: list[int]) -> list[MaterialDefinition]:
	"""Returns the properties of a set of PBR Materials

	Args:
		materials (list[int]): The PBR Materials

	Returns:
		materialDefinitions (list[MaterialDefinition]): The PBR Material definitions
	"""
	...

def getMaterialMainColor(material: int) -> core.ColorAlpha:
	"""Get the main color on any material pattern type

	Args:
		material (int): The material

	Returns:
		color (core.ColorAlpha): The main color
	"""
	...

def getMaterialPattern(material: int) -> str:
	"""Gets the MaterialPattern name of the material

	Args:
		material (int): The material to find the pattern

	Returns:
		pattern (str): The pattern of the material
	"""
	...

def getMaterialPatternType(material: int) -> MaterialPatternType:
	"""Returns the MaterialPatternType name of the material

	Args:
		material (int): The material to find the pattern

	Returns:
		patternType (MaterialPatternType): The pattern type of the material
	"""
	...

def getPBRMaterialInfos(material: int) -> PBRMaterialInfos:
	"""Get PBR  material properties

	Args:
		material (int): The material to get properties

	Returns:
		infos (PBRMaterialInfos): The PBRMaterialInfos properties
	"""
	...

def getPointsAndMaterialFromText(text: str, fontName: str, fontSize: int, matrix: list[list[float]], colorInput: core.Color, offset: float = 0.0, height3D: float = 0.0) -> dict:
	"""Returns a list of 3D Points and a material from a string and a fontname

	Args:
		text (str): Input text
		fontName (str): Fontname
		fontSize (int): FontSize
		matrix (list[list[float]]): Input matrix for the text
		colorInput (core.Color): Color of the font needed
		offset (float): Input offset for the text
		height3D (float): Input height in 3D which will be a ratio from the textSize

	Returns:
		points (list[geom.Point3]): 
		uvs (list[geom.Point2]): 
		normal (geom.Point3): 
		material (int): 
		offset (float): Offset given by the text
	"""
	...

def getStandardMaterialInfos(material: int) -> StandardMaterialInfos:
	"""Get standard material properties

	Args:
		material (int): The material to get properties

	Returns:
		infos (StandardMaterialInfos): The StandardMaterialInfos properties
	"""
	...

def getUniformPropertyType(pattern: int, name: str) -> ShaderUniformType:
	"""Get a shader uniform shader property type

	Args:
		pattern (int): The custom pattern
		name (str): Name of the property to get the type from

	Returns:
		type (ShaderUniformType): Type of the uniform property
	"""
	...

def getUnlitTextureMaterialInfos(material: int) -> UnlitTextureMaterialInfos:
	"""Get unlit texture material properties

	Args:
		material (int): The material to get properties

	Returns:
		infos (UnlitTextureMaterialInfos): The UnlitTextureMaterialInfos properties
	"""
	...

def importImage(filename: str) -> int:
	"""Import an image

	Args:
		filename (str): Filename of the image to import

	Returns:
		image (int): Identifier of the imported image
	"""
	...

def isOpaque(material: int) -> bool:
	"""Check if material is opaque. Function will return 'False' if:\n- The 'Opacity' Coeff is not 1.0\n- The 'Opacity' property is a Texture\n- The 'Albedo' property is a Texture and at least one pixel of the texture has an alpha value

	Args:
		material (int): Material to check opacity

	Returns:
		opaque (bool): Returns True if opaque or False if transparent
	"""
	...

def makeMaterialNamesUnique(materials: list[int] = []) -> None:
	"""Rename materials to have a unique name for each one

	Args:
		materials (list[int]): Materials to rename (rename all materials if empty)
	"""
	...

def remapIndexMap(maps: list[int], maxIndices: int) -> dict:
	"""create remapped versions of index maps

	Args:
		maps (list[int]): Input Images
		maxIndices (int): Number max of indices remapped

	Returns:
		mappedMaps (list[int]): Output maps remapped
		newToOldMapIndices (list[list[int]]): New index to old index for each map
	"""
	...

def resizeImage(image: int, width: int, height: int, filteringMethod: ResizeFilterMethod = 0) -> None:
	"""Resize an image

	Args:
		image (int): Image to be resize
		width (int): New image width
		height (int): New image height
		filteringMethod (ResizeFilterMethod): Filtering method for image resizing
	"""
	...

def setCoeffOrTextureProperty(material: int, name: str, coeffOrTexture: list) -> None:
	"""Set a CoeffOrTexture property

	Args:
		material (int): The material to apply the color on
		name (str): The property to set
		coeffOrTexture (list): The CoeffOrTexture to apply
	"""
	...

def setColorAlphaProperty(material: int, name: str, color: core.ColorAlpha) -> None:
	"""Set a ColorAlpha property

	Args:
		material (int): The material to apply the color on
		name (str): The property to set
		color (core.ColorAlpha): The color to apply
	"""
	...

def setColorOrTextureProperty(material: int, name: str, colorOrTexture: list) -> None:
	"""Set a ColorOrTexture property

	Args:
		material (int): The material to apply the color on
		name (str): The property to set
		colorOrTexture (list): The ColorOrTexture to apply
	"""
	...

def setFragmentShader(pattern: int, code: str) -> None:
	"""Set the fragment shader of a custom pattern

	Args:
		pattern (int): The custom pattern to edit
		code (str): The GLSL code of the fragment shader
	"""
	...

def setMaterialMainColor(material: int, color: core.ColorAlpha) -> None:
	"""Set the main color on any material pattern type

	Args:
		material (int): The material to apply the color on
		color (core.ColorAlpha): The color to apply
	"""
	...

def setMaterialPattern(material: int, pattern: str) -> None:
	"""Sets the MaterialPattern name of the material

	Args:
		material (int): The material to find the pattern
		pattern (str): The pattern of the material
	"""
	...

def setPBRMaterialInfos(material: int, infos: PBRMaterialInfos) -> None:
	"""Set PBR  material properties

	Args:
		material (int): The material to set properties
		infos (PBRMaterialInfos): The PBRMaterialInfos properties
	"""
	...

def setVertexShader(pattern: int, code: str) -> None:
	"""Set the vertex shader of a custom pattern

	Args:
		pattern (int): The custom pattern to edit
		code (str): The GLSL code of the vertex shader
	"""
	...

def updateImageFromDefinition(image: int, imageDefinition: ImageDefinition) -> None:
	"""Update an image from its raw data

	Args:
		image (int): The image to update
		imageDefinition (ImageDefinition): The new data to apply
	"""
	...

def updateImagesFromDefinitions(image: list[int], imageDefinitions: list[ImageDefinition]) -> None:
	"""Update images from their raw data

	Args:
		image (list[int]): The image to update
		imageDefinitions (list[ImageDefinition]): The new data to apply
	"""
	...

def getMaterialUserData(userDataId: int, material: int) -> core.Ptr:
	"""Set or replace a userdata stored on an material

	Args:
		userDataId (int): UserData identifier provided by subscribeToMaterialUserData
		material (int): Material that store the user data

	Returns:
		userData (core.Ptr): User data stored in the given material
	"""
	...

def getMultipleMaterialUserData(userDataId: int, materials: list[int]) -> list[core.Ptr]:
	"""Batch version of getMaterialUserData

	Args:
		userDataId (int): UserData identifier provided by subscribeToMaterialUserData
		materials (list[int]): Materials that store the user data

	Returns:
		userDataList (list[core.Ptr]): User data stored for each given material
	"""
	...

def hasMaterialUserData(userDataId: int, material: int) -> bool:
	"""Set or replace a userdata stored on an material

	Args:
		userDataId (int): UserData identifier provided by subscribeToMaterialUserData
		material (int): Material that potentially store the user data

	Returns:
		result (bool): Returns true if a userdata is stored on this material for the given userDataId
	"""
	...

def hasMultipleMaterialUserData(userDataId: int, materials: list[int]) -> list[bool]:
	"""Batch version of hasMaterialUserData

	Args:
		userDataId (int): UserData identifier provided by subscribeToMaterialUserData
		materials (list[int]): Materials that potentially store the user data

	Returns:
		results (list[bool]): Returns an array of bool that are true if a userdata is stored on the material at the same index for the given userDataId
	"""
	...

def setMaterialUserData(userDataId: int, material: int, userData: core.Ptr) -> None:
	"""Set or replace a userdata stored on an material

	Args:
		userDataId (int): UserData identifier provided by subscribeToMaterialUserData
		material (int): Material that will store the user data
		userData (core.Ptr): User data to store in the given material
	"""
	...

def setMultipleMaterialUserData(userDataId: int, materials: list[int], userDataList: list[core.Ptr]) -> None:
	"""Batch version of setMaterialUserData

	Args:
		userDataId (int): UserData identifier provided by subscribeToMaterialUserData
		materials (list[int]): Materials that will store the user data
		userDataList (list[core.Ptr]): User data to store on each material
	"""
	...

def subscribeToMaterialUserData() -> int:
	"""subscribe to material user data. multiple different userdata can be stored on the same materials if subscribeToMaterialUserData is called multiple times

	Returns:
		userDataId (int): UserData identifier to pass to setUserData/getUserData functions
	"""
	...

def unsetMaterialUserData(userDataId: int, material: int) -> None:
	"""Unset the userdata stored on an material

	Args:
		userDataId (int): UserData identifier provided by subscribeToMaterialUserData
		material (int): Material that will store the user data
	"""
	...

def unsetMultipleMaterialUserData(userDataId: int, materials: list[int]) -> None:
	"""Batch version of unsetMaterialUserData

	Args:
		userDataId (int): UserData identifier provided by subscribeToMaterialUserData
		materials (list[int]): Materials that will store the user data
	"""
	...

def unsubscribeFromMaterialUserData(userDataId: int) -> None:
	"""

	Args:
		userDataId (int): UserData identifier to unsubscribe
	"""
	...

# Callbacks
def addImageChangedCallback(callback: Callable[[ImageChangeType, int], None], userdata):
	"""
	"""
	...

def removeImageChangedCallback(id: int):
	"""Remove callback added with material.addImageChangedCallback
	"""
	...

def addMaterialChangedCallback(callback: Callable[[MaterialChangeType, int], None], userdata):
	"""
	"""
	...

def removeMaterialChangedCallback(id: int):
	"""Remove callback added with material.addMaterialChangedCallback
	"""
	...

