from enum import Enum
from collections.abc import Callable


# Constants
Epsilon: 1e-6
EpsilonSquare: 1e-12
HalfPi: 1.5707963267948966192313215
Infinity: 1e12
OneDegree: 0.017453292519943295769236907684886
Pi: 3.141592653589793238462643
TwoPi: 6.283185307179586476925286

# Classes
class AliasTypeDesc:
	"""
	"""
	alias: str
	def __init__(self, alias: str) -> None: ...
	...

class ArrayTypeDesc:
	"""
	"""
	arrayType: str
	size: int
	def __init__(self, arrayType: str, size: int) -> None: ...
	...

class AutoValueReturn:
	"""Auto value function return
	"""
	values: list[StringPair]
	message: str
	def __init__(self, values: list[StringPair], message: str) -> None: ...
	...

class BoundedInteger:
	"""
	"""
	value: int
	min: int
	max: int
	def __init__(self, value: int, min: int, max: int) -> None: ...
	...

class Color:
	"""A Color defines a color RGB
	"""
	r: float
	g: float
	b: float
	def __init__(self, r: float, g: float, b: float) -> None: ...
	...

class ColorAlpha:
	"""A Color defines a color RGBA
	"""
	r: float
	g: float
	b: float
	a: float
	def __init__(self, r: float, g: float, b: float, a: float) -> None: ...
	...

class ConstantDesc:
	"""
	"""
	name: str
	value: str
	type: TypeDesc
	description: str
	def __init__(self, name: str, value: str, type: TypeDesc, description: str) -> None: ...
	...

class Date:
	"""
	"""
	year: int
	month: int
	day: int
	def __init__(self, year: int, month: int, day: int) -> None: ...
	...

class EnumPropertyInfo:
	"""
	"""
	name: str
	values: list[int]
	labels: list[str]
	def __init__(self, name: str, values: list[int], labels: list[str]) -> None: ...
	...

class EnumTypeDesc:
	"""
	"""
	values: list[int]
	labels: list[str]
	valueType: str
	def __init__(self, values: list[int], labels: list[str], valueType: str) -> None: ...
	...

class EventDesc:
	"""
	"""
	module: str
	name: str
	description: str
	parameters: list[ParameterDesc]
	def __init__(self, module: str, name: str, description: str, parameters: list[ParameterDesc]) -> None: ...
	...

class Field:
	"""
	"""
	name: str
	type: str
	module: str
	defaultValue: str
	description: str
	disableValue: str
	predefinedValues: list[StringPair]
	def __init__(self, name: str, type: str, module: str, defaultValue: str, description: str, disableValue: str, predefinedValues: list[StringPair]) -> None: ...
	...

class Format:
	"""
	"""
	name: str
	extensions: list[str]
	def __init__(self, name: str, extensions: list[str]) -> None: ...
	...

class FunctionDesc:
	"""
	"""
	name: str
	module: str
	parameters: list[ParameterDesc]
	returns: list[ParameterDesc]
	description: str
	stability: Stability
	def __init__(self, name: str, module: str, parameters: list[ParameterDesc], returns: list[ParameterDesc], description: str, stability: Stability) -> None: ...
	...

class GroupDesc:
	"""
	"""
	name: str
	description: str
	functions: list[FunctionDesc]
	def __init__(self, name: str, description: str, functions: list[FunctionDesc]) -> None: ...
	...

class IdentPair:
	"""
	"""
	key: int
	value: int
	def __init__(self, key: int, value: int) -> None: ...
	...

class InheritableBool(Enum):
	"""
	"""
	False: int
	True: int
	Inherited: int
	...

class LicenseInfos:
	"""
	"""
	version: str
	customerName: str
	customerCompany: str
	customerEmail: str
	isFloating: bool
	isRevocable: bool
	startDate: Date
	endDate: Date
	invalidReasons: list[str]
	def __init__(self, version: str, customerName: str, customerCompany: str, customerEmail: str, isFloating: bool, isRevocable: bool, startDate: Date, endDate: Date, invalidReasons: list[str]) -> None: ...
	...

class ListTypeDesc:
	"""
	"""
	listType: str
	def __init__(self, listType: str) -> None: ...
	...

class ModuleDesc:
	"""
	"""
	name: str
	description: str
	author: str
	groups: list[GroupDesc]
	types: list[TypeDesc]
	constants: list[ConstantDesc]
	dependencies: list[str]
	stability: Stability
	def __init__(self, name: str, description: str, author: str, groups: list[GroupDesc], types: list[TypeDesc], constants: list[ConstantDesc], dependencies: list[str], stability: Stability) -> None: ...
	...

class ParameterDesc:
	"""
	"""
	name: str
	type: TypeDesc
	description: str
	optional: bool
	defaultValue: str
	disableValue: str
	attributes: list[StringPair]
	predefinedValues: list[StringPair]
	def __init__(self, name: str, type: TypeDesc, description: str, optional: bool, defaultValue: str, disableValue: str, attributes: list[StringPair], predefinedValues: list[StringPair]) -> None: ...
	...

class PropertyInfo:
	"""
	"""
	name: str
	type: PropertyType
	subType: int
	value: str
	user: bool
	defaultValue: str
	editable: bool
	isSet: bool
	delegated: bool
	delegatedOwnerEntity: int
	group: str
	description: str
	def __init__(self, name: str, type: PropertyType, subType: int, value: str, user: bool, defaultValue: str, editable: bool, isSet: bool, delegated: bool, delegatedOwnerEntity: int, group: str, description: str) -> None: ...
	...

class PropertyType(Enum):
	"""Enumeration of all property types
	"""
	STRING: int
	STRINGLIST: int
	INTEGER: int
	BOUNDED_INTEGER: int
	UNSIGNED_INTEGER: int
	SHORT: int
	UNSIGNED_SHORT: int
	IDENTIFIER: int
	IDENTIFIERLIST: int
	BOOLEAN: int
	INHERITABLEBOOL: int
	REAL: int
	REALLIST: int
	COEFF: int
	PERCENT: int
	COLOR: int
	COLOR_ALPHA: int
	DATE: int
	ANGLE: int
	DISTANCE: int
	MACHINEID: int
	MACHINEIDLIST: int
	SOCKET_PROTOCOL: int
	POINT2: int
	POINT3: int
	AXIS3: int
	VECTOR3: int
	POINT3LIST: int
	POINT4: int
	POINT4LIST: int
	MATRIX4: int
	QUATERNION: int
	BOUNDS1D: int
	BOUNDS2D: int
	TEXTUREDEF: int
	COLORORTEXTURE: int
	COEFFORTEXTURE: int
	ENTITY: int
	FILEPATH: int
	ENUM: int
	UNKNOWN: int
	...

class SelType:
	"""
	"""
	name: str
	type: str
	defaultValue: str
	description: str
	def __init__(self, name: str, type: str, defaultValue: str, description: str) -> None: ...
	...

class SelectTypeDesc:
	"""
	"""
	types: list[SelType]
	def __init__(self, types: list[SelType]) -> None: ...
	...

class Stability(Enum):
	"""Describes the level of maturity of a module/function
	"""
	DEVELOPMENT: int
	EXPERIMENTAL: int
	BETA: int
	STABLE: int
	DEPRECATED: int
	OBSOLETE: int
	...

class StringPair:
	"""
	"""
	key: str
	value: str
	def __init__(self, key: str, value: str) -> None: ...
	...

class StructTypeDesc:
	"""
	"""
	fields: list[Field]
	def __init__(self, fields: list[Field]) -> None: ...
	...

class TypeDesc:
	"""
	"""
	name: str
	module: str
	type: TypeDescType
	description: str
	definition: list
	def __init__(self, name: str, module: str, type: TypeDescType, description: str, definition: list) -> None: ...
	...

class TypeDescType(Enum):
	"""
	"""
	UNKNOWN: int
	BASE: int
	ALIAS: int
	ENUM: int
	LIST: int
	STRUCT: int
	ARRAY: int
	SELECT: int
	FUNCPTR: int
	...

class Verbose(Enum):
	"""The verbose level defines the amount of information shown in outputs
	"""
	ERR: int
	WARNING: int
	INFO: int
	SCRIPT: int
	...

class WebLicenseInfo:
	"""
	"""
	id: int
	product: str
	validity: Date
	count: int
	inUse: int
	revoke: int
	description: str
	onMachine: bool
	current: bool
	def __init__(self, id: int, product: str, validity: Date, count: int, inUse: int, revoke: int, description: str, onMachine: bool, current: bool) -> None: ...
	...

# Functions
def cloneEntity(entity: int) -> int:
	"""Clone an entity

	Args:
		entity (int): The entity to clone

	Returns:
		clonedEntity (int): The cloned entity
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

def createEntity(type: int) -> int:
	"""Create an entity

	Args:
		type (int): The type of entity to create

	Returns:
		entity (int): The created entity id
	"""
	...

def deleteEntities(entities: list[int]) -> None:
	"""Delete a set of entities

	Args:
		entities (list[int]): List of entity to delete
	"""
	...

def getEntitiesByType(type: int, includeUnsubscribed: bool) -> list[int]:
	"""get all entities of a given type

	Args:
		type (int): The type of entities to retrieve
		includeUnsubscribed (bool): Include unsubscribed entities

	Returns:
		entities (list[int]): The returned entity list
	"""
	...

def resetSession() -> None:
	"""Clear all the current session (all unsaved work will be lost)
	"""
	...

def unsavedUserChanges() -> bool:
	"""Returns true if the user has made changes to the project

	Returns:
		hasChanged (bool): Boolean checking if the project has been modified
	"""
	...

def getEvent(moduleName: str, eventName: str) -> EventDesc:
	"""get EventDesc of an event

	Args:
		moduleName (str): Target module name
		eventName (str): 

	Returns:
		event (EventDesc): 
	"""
	...

def getEvents(moduleName: str, groupName: str) -> list[EventDesc]:
	"""get events of a group

	Args:
		moduleName (str): Target module name
		groupName (str): Target group name

	Returns:
		eventDescList (list[EventDesc]): 
	"""
	...

def getFunction(moduleName: str, functionName: str) -> FunctionDesc:
	"""get FunctionDesc of a function

	Args:
		moduleName (str): Target module name
		functionName (str): Target function name

	Returns:
		functionDesc (FunctionDesc): 
	"""
	...

def getFunctions(moduleName: str, groupName: str) -> list[FunctionDesc]:
	"""get functions of a group

	Args:
		moduleName (str): Target module name
		groupName (str): Target group name

	Returns:
		functions (list[FunctionDesc]): 
	"""
	...

def getGroup(moduleName: str, groupName: str) -> GroupDesc:
	"""get a group desc from a specific module

	Args:
		moduleName (str): Target module name
		groupName (str): Target group name

	Returns:
		group (GroupDesc): 
	"""
	...

def getGroups(moduleName: str) -> list[GroupDesc]:
	"""get all group desc of a module

	Args:
		moduleName (str): Target module name

	Returns:
		groups (list[GroupDesc]): 
	"""
	...

def getModuleTypes(moduleName: str) -> list[TypeDesc]:
	"""get TypeDescList from a module name

	Args:
		moduleName (str): Target module name

	Returns:
		typeDescList (list[TypeDesc]): 
	"""
	...

def getModules() -> list[ModuleDesc]:
	"""get all modules desc

	Returns:
		modules (list[ModuleDesc]): 
	"""
	...

def getModulesName() -> list[str]:
	"""get all modules name

	Returns:
		modulesName (list[str]): 
	"""
	...

def getType(moduleName: str, typeNameStr: str) -> TypeDesc:
	"""get TypeDesc from a type name

	Args:
		moduleName (str): Target module name
		typeNameStr (str): Target type name

	Returns:
		typeDesc (TypeDesc): 
	"""
	...

def getTypeAttributes(moduleName: str, typeNameStr: str) -> list[StringPair]:
	"""get attributes TypeDesc from a type name

	Args:
		moduleName (str): Target module name
		typeNameStr (str): Target type name

	Returns:
		attributes (list[StringPair]): 
	"""
	...

def defineCaptchaCallback(callback: Callable[[str, list[Byte]], None]) -> None:
	"""Define a callback function to customize the captha which unlock automated functions in interactive products

	Args:
		callback (Callable[[str, list[Byte]], None]): The callback function
	"""
	...

def entityExists(entity: int) -> bool:
	"""returns true if the entity exists

	Args:
		entity (int): The wanted entity

	Returns:
		exists (bool): True if it exists.
	"""
	...

def getAllEntities() -> list[int]:
	"""returns all the entities on the database

	Returns:
		entities (list[int]): All entities
	"""
	...

def getCurrentPiXYZFile() -> str:
	"""Get current (loaded) Pixyz file path

	Returns:
		fileName (str): The current Pixyz file
	"""
	...

def getEntityType(entity: int) -> int:
	"""returns the type id of the entity

	Args:
		entity (int): The wanted entity

	Returns:
		type (int): Type type of the entity
	"""
	...

def getEntityTypeString(entity: int) -> str:
	"""returns the type name of the entity

	Args:
		entity (int): The wanted entity

	Returns:
		type (str): Name of the entity type
	"""
	...

def getTypeStats() -> list[list[int]]:
	"""Get the database stats

	Returns:
		stats (list[list[int]]): 
	"""
	...

def isCurrentPiXYZFileModified() -> bool:
	"""Return true, if the current (loaded) file has been modified since last load or save

	Returns:
		modified (bool): True if the file is modified
	"""
	...

def load(fileName: str) -> None:
	"""Load a new scene

	Args:
		fileName (str): Path to load the file
	"""
	...

def lockEntityRegistration() -> None:
	"""Lock Entity registration, use with Caution. All entities created after this call will not be saved on .pxz file and will not be listed as existing entities on the Database. Be careful to not references these entities with other registered entities
	"""
	...

def save(fileName: str) -> None:
	"""Save the scene

	Args:
		fileName (str): Path to save the file
	"""
	...

def unlockEntityRegistration() -> None:
	"""Unlock Entity registration
	"""
	...

def addWantedToken(tokenName: str) -> None:
	"""Add a license token to the list of wanted tokens. The wanted tokens list is saved on disk in program data and is used at initialization. Prefer using 'core.needToken' instead.

	Args:
		tokenName (str): Wanted token
	"""
	...

def checkLicense() -> bool:
	"""check the current license

	Returns:
		valid (bool): 
	"""
	...

def checkWebLogin(login: str, password: str) -> bool:
	"""Check if authentification on the Web license API is sucessfull

	Args:
		login (str): WEB account login
		password (str): WEB account password

	Returns:
		valid (bool): 
	"""
	...

def configureLicenseServer(address: str, port: int, flexLM: bool = True) -> None:
	"""Configure the license server to use to get floating licenses

	Args:
		address (str): Server address
		port (int): Server port
		flexLM (bool): Enable FlexLM license server
	"""
	...

def generateActivationCode(filePath: str) -> None:
	"""Create an activation code to generate an offline license

	Args:
		filePath (str): Path to write the activation code
	"""
	...

def generateDeactivationCode(filePath: str) -> None:
	"""Create an deactivation code to release the license from this machine

	Args:
		filePath (str): Path to write the deactivation code
	"""
	...

def getCurrentLicenseInfos() -> LicenseInfos:
	"""get information on current installed license

	Returns:
		licenseInfos (LicenseInfos): 
	"""
	...

def getLicenseError() -> dict:
	"""get errors from license check

	Returns:
		valid (bool): 
		reasons (str): 
	"""
	...

def getLicenseServer() -> dict:
	"""Get current license server

	Returns:
		serverHost (str): Server host name or IP
		serverPort (int): Server port
		useFlexLM (bool): Set to true if flexLM server
	"""
	...

def installLicense(licensePath: str) -> None:
	"""install a new license

	Args:
		licensePath (str): Path of the license file
	"""
	...

def listOwnedTokens() -> list[str]:
	"""Get the list of actually owned license tokens

	Returns:
		ownedTokens (list[str]): Owned token list
	"""
	...

def listTokens(onlyMandatory: bool = False) -> list[str]:
	"""Get the list of license tokens for this product

	Args:
		onlyMandatory (bool): If True, optional tokens will not be returned

	Returns:
		tokens (list[str]): Token list
	"""
	...

def listWantedTokens() -> list[str]:
	"""Get the list of license token configured to be requested at initialization

	Returns:
		tokens (list[str]): Token list
	"""
	...

def needToken(tokenName: str) -> None:
	"""Requests a license token for the current session. This step should be done after configuring license server. Throws an exception if the token is not available.

	Args:
		tokenName (str): Token name
	"""
	...

def ownToken(tokenName: str) -> bool:
	"""Returns True if we own a token, without requesting it

	Args:
		tokenName (str): Token name

	Returns:
		owned (bool): True if the token is owned
	"""
	...

def releaseToken(tokenName: str) -> None:
	"""Release an optional license token

	Args:
		tokenName (str): Token name
	"""
	...

def releaseWebLicense(login: str, password: str, id: int) -> None:
	"""release License owned by user WEB account

	Args:
		login (str): WEB account login
		password (str): WEB account password
		id (int): WEB license id
	"""
	...

def removeWantedToken(tokenName: str) -> None:
	"""remove a license token from the list of wanted optional tokens

	Args:
		tokenName (str): Unwanted token
	"""
	...

def requestWebLicense(login: str, password: str, id: int) -> None:
	"""request License owned by user WEB account

	Args:
		login (str): WEB account login
		password (str): WEB account password
		id (int): WEB license id
	"""
	...

def retrieveWebLicenses(login: str, password: str) -> list[WebLicenseInfo]:
	"""Retrieves License owned by user WEB account

	Args:
		login (str): WEB account login
		password (str): WEB account password

	Returns:
		licenses (list[WebLicenseInfo]): 
	"""
	...

def tokenValid(tokenName: str) -> bool:
	"""Returns True if a token is owned by the product, request will be done if missing

	Args:
		tokenName (str): Token name

	Returns:
		valid (bool): 
	"""
	...

def parallelAddJob(session: Ptr, jobCallback: Callable[[Ptr], None], dataPtr: Ptr) -> None:
	"""Add a job to a parallel session

	Args:
		session (Ptr): 
		jobCallback (Callable[[Ptr], None]): 
		dataPtr (Ptr): 
	"""
	...

def parallelFinish(session: Ptr) -> None:
	"""Ends a parallel session after waiting for all jobs to finish

	Args:
		session (Ptr): 
	"""
	...

def parallelStart(progression: bool = False, name: str = "Parallel session", jobCount: int = -1) -> Ptr:
	"""Starts a new parallel session

	Args:
		progression (bool): Enable progression for the parallel session
		name (str): Name of the parallel session
		jobCount (int): Count of parallel jobs if known (for progression)

	Returns:
		session (Ptr): 
	"""
	...

def getModuleDescFromXML(xmlPath: str, addToModules: bool) -> ModuleDesc:
	"""Generate a ModuleDesc from an .xml description

	Args:
		xmlPath (str): .xml file path
		addToModules (bool): 

	Returns:
		description (ModuleDesc): 
	"""
	...

def removeModule(module: str) -> None:
	"""Remove a module added via getModuleDescFromXML

	Args:
		module (str): Module name
	"""
	...

def popProgression() -> None:
	"""Leave current progression level
	"""
	...

def pushProgression(stepCount: int, progressName: str = "") -> None:
	"""Create a new progression level

	Args:
		stepCount (int): Step count
		progressName (str): Name of the progression step
	"""
	...

def stepProgression(stepCount: int = 1) -> None:
	"""Add a step to current progression level

	Args:
		stepCount (int): Step count
	"""
	...

def addCustomProperties(entities: list[int], names: list[str], values: list[str] = list[str](), types: list[PropertyType] = list[PropertyType]()) -> None:
	"""Add multiple custom property to entities that support custom properties

	Args:
		entities (list[int]): Entities that support custom properties
		names (list[str]): Name of the custom property for each entity
		values (list[str]): Value of the custom property for each entity
		types (list[PropertyType]): Type of the custom property for each entity
	"""
	...

def addCustomProperty(entity: int, name: str, value: str = "", type: PropertyType = 0) -> None:
	"""Add a custom property to an entity that support custom properties

	Args:
		entity (int): An entity that support custom properties
		name (str): Name of the custom property
		value (str): Value of the custom property
		type (PropertyType): Type of the custom property
	"""
	...

def getModuleProperty(module: str, propertyName: str) -> str:
	"""Returns the value of a module property

	Args:
		module (str): Name of the module
		propertyName (str): The property name

	Returns:
		propertyValue (str): The property value
	"""
	...

def getModulePropertyInfo(module: str, propertyName: str) -> PropertyInfo:
	"""Returns the value of a module property

	Args:
		module (str): Name of the module
		propertyName (str): The property name

	Returns:
		propertyInfo (PropertyInfo): The property info
	"""
	...

def getProperties(entities: list[int], propertyName: str, defaultValue: str = "") -> list[str]:
	"""Get the property value on entities (if the property is not set on an entity, defaultValue is returned)

	Args:
		entities (list[int]): List of entities
		propertyName (str): The property name
		defaultValue (str): Default value to return if the property does not exist on an entity

	Returns:
		values (list[str]): Property value on each entity
	"""
	...

def getProperty(entity: int, propertyName: str) -> str:
	"""Get a property value as String on an entity (error if the property does not exist on the entity)

	Args:
		entity (int): The entity
		propertyName (str): The property name

	Returns:
		value (str): The property value as String
	"""
	...

def getPropertyInfo(entity: int, propertyName: str) -> PropertyInfo:
	"""Get a property info on an entity (error if the property does not exist on the entity)

	Args:
		entity (int): The entity
		propertyName (str): The property name

	Returns:
		propertyInfo (PropertyInfo): The property info
	"""
	...

def hasCustomProperty(entityId: int, customPropertyName: str) -> bool:
	"""Return true if the custom property was found on the occurrence

	Args:
		entityId (int): An entity that support properties
		customPropertyName (str): Name of the custom property

	Returns:
		propertyFound (bool): True if the enity has the custom propery, else False
	"""
	...

def hasProperty(entity: int, propertyName: str) -> bool:
	"""Return true if the property was found on the occurrence, will not throw any exception except if the entity does not exist.

	Args:
		entity (int): An entity that support properties
		propertyName (str): Name of the property

	Returns:
		propertyFound (bool): True if the entity has the property asked, else False
	"""
	...

def listEnumLabels(enumType: int) -> EnumPropertyInfo:
	"""Returns the informations of a module property

	Args:
		enumType (int): The real enum type number (ie. The one return in subtype of PropertyInfo)

	Returns:
		enumPropertyInfo (EnumPropertyInfo): The enum property info
	"""
	...

def listModuleProperties(module: str) -> list[PropertyInfo]:
	"""Returns all the properties in the given module

	Args:
		module (str): Name of the module

	Returns:
		properties (list[PropertyInfo]): List of module properties info
	"""
	...

def listProperties(entity: int) -> list[PropertyInfo]:
	"""Returns the names and values of the properties available on an entity

	Args:
		entity (int): Entity to list

	Returns:
		properties (list[PropertyInfo]): List of available properties info
	"""
	...

def listPropertiesBatch(entities: list[int]) -> list[list[PropertyInfo]]:
	"""Returns the names and values of the properties available on multiple entities

	Args:
		entities (list[int]): Entities to list

	Returns:
		properties (list[list[PropertyInfo]]): List of available properties info
	"""
	...

def removeCustomProperty(entity: int, name: str) -> None:
	"""Remove a custom property from an entity that support custom properties

	Args:
		entity (int): An entity that support custom properties
		name (str): Name of the custom property
	"""
	...

def restoreModulePropertyDefaultValue(module: str, propertyName: str) -> str:
	"""Restore the default value of a module property

	Args:
		module (str): Name of the module
		propertyName (str): The property name

	Returns:
		value (str): The property value as String
	"""
	...

def setModuleProperty(module: str, propertyName: str, propertyValue: str) -> str:
	"""Set the value of a module property

	Args:
		module (str): Name of the module
		propertyName (str): The property name
		propertyValue (str): The property value

	Returns:
		value (str): The property value as String
	"""
	...

def setProperties(entities: list[int], propertyNames: list[str], propertyValues: list[str]) -> None:
	"""Set multiple properties values on entities

	Args:
		entities (list[int]): List of entities
		propertyNames (list[str]): The property name for each entity
		propertyValues (list[str]): The property value for each entity
	"""
	...

def setProperty(entity: int, propertyName: str, propertyValue: str) -> str:
	"""Set a property value on an entity

	Args:
		entity (int): The entity
		propertyName (str): The property name
		propertyValue (str): The property value

	Returns:
		value (str): The property value as String
	"""
	...

def supportCustomProperties(entity: int) -> bool:
	"""Return true if an entity support custom properties

	Args:
		entity (int): An entity

	Returns:
		support (bool): True if the entity support custom properties, else False
	"""
	...

def unsetProperty(entity: int, propertyName: str) -> None:
	"""Unset an entity's property

	Args:
		entity (int): The entity
		propertyName (str): The property name
	"""
	...

def availableMemory() -> dict:
	"""returns available memory

	Returns:
		availVirt (int): Available virtual memory in bytes
		totalVirt (int): Total virtual memory in bytes
		availPhys (int): Available physical memory in bytes
		totalPhys (int): Total physical memory in bytes
	"""
	...

def checkForUpdates() -> dict:
	"""check for software update

	Returns:
		newVersionAvailable (bool): True if there is a new version available of this product
		newVersion (str): New version value
		newVersionLink (str): Link to download the new version
		htmlInfo (str): Html info associated with the new version
	"""
	...

def clearOtherTemporaryDirectories() -> None:
	"""remove all other session temporary directories (warning: make sure that no other instance of pixyz is running
	"""
	...

def getCustomVersionTag() -> str:
	"""get the Pixyz custom version tag

	Returns:
		customVersionTag (str): 
	"""
	...

def getMemoryUsagePeak() -> int:
	"""Returns the memory usage peak of the current process in MB ( only available on windows yet )

	Returns:
		peakWorkingSet (int): Maximum physical memory used by the process until now (in MB)
	"""
	...

def getPixyzWebsiteURL() -> str:
	"""get the Pixyz website URL

	Returns:
		url (str): 
	"""
	...

def getProductName() -> str:
	"""get the Pixyz product name

	Returns:
		productName (str): 
	"""
	...

def getTempDirectory() -> str:
	"""get the Pixyz temp directory (server side directory in case of remote access)

	Returns:
		tmpDir (str): 
	"""
	...

def getVersion() -> str:
	"""get the Pixyz product version

	Returns:
		version (str): 
	"""
	...

def setCurrentThreadAsProcessThread() -> None:
	"""Set the process thread. Use this function when you want to get progress changed callbacks from another thread as the one you initialized Pixyz on.
	"""
	...

def clearUndoRedo() -> None:
	"""Clear undo/redo history
	"""
	...

def endUndoRedoStep(deleteIfEmpty: bool = True) -> None:
	"""End current undo/redo step

	Args:
		deleteIfEmpty (bool): If True, empty step with no modification will be deleted from the stack at the end
	"""
	...

def getRedoStack() -> list[str]:
	"""Get the history of actions stack

	Returns:
		redoStack (list[str]): 
	"""
	...

def getRedoStepUserData(index: int) -> str:
	"""Get user data for undo step #index

	Args:
		index (int): 

	Returns:
		userData (str): 
	"""
	...

def getUndoStack() -> list[str]:
	"""Get the history of actions stack

	Returns:
		undoStack (list[str]): 
	"""
	...

def getUndoStepUserData(index: int) -> str:
	"""Get user data for undo step #index

	Args:
		index (int): 

	Returns:
		userData (str): 
	"""
	...

def hasRecordingStep() -> bool:
	"""Has recording step

	Returns:
		hasRecordingStep (bool): True if there is recoding step, else False
	"""
	...

def redo(count: int = 1) -> None:
	"""redo some steps

	Args:
		count (int): 
	"""
	...

def startUndoRedoStep(stepName: str, userData: str = "") -> None:
	"""Start a new undo/redo step

	Args:
		stepName (str): 
		userData (str): 
	"""
	...

def stopProcess() -> None:
	"""Stop process (works if there is recording step)
	"""
	...

def toggleUndoRedo() -> None:
	"""Toggle undo/redo
	"""
	...

def undo(count: int = 1) -> None:
	"""undo some steps

	Args:
		count (int): 
	"""
	...

def addConsoleVerbose(level: Verbose) -> None:
	"""add a console verbose level

	Args:
		level (Verbose): Verbose level
	"""
	...

def addLogFileVerbose(level: Verbose) -> None:
	"""add a log file verbose level

	Args:
		level (Verbose): Verbose level
	"""
	...

def addSessionLogFileVerbose(level: Verbose) -> None:
	"""add a session log file (lastSession{Id}.log) verbose level

	Args:
		level (Verbose): Verbose level
	"""
	...

def configureInterfaceLogger(enableFunction: bool, enableParameters: bool, enableExecutionTime: bool) -> None:
	"""Set new configuration for the Interface Logger

	Args:
		enableFunction (bool): If true, the called function names will be print
		enableParameters (bool): If true, the called function parameters will be print (only if enableFunction=true too)
		enableExecutionTime (bool): If true, the called functions execution times will be print
	"""
	...

def getInterfaceLoggerConfiguration() -> dict:
	"""Get the current Interface Logger configuration

	Returns:
		functionEnabled (bool): True if the called function names are printed
		parametersEnabled (bool): True if the called function parameters are printed
		executionTimeEnabled (bool): True if the called functions execution times are printed
	"""
	...

def getLogFile() -> str:
	"""get the path of the log file

	Returns:
		path (str): Path of the log file
	"""
	...

def log(message: str, level: Verbose) -> None:
	"""log a message to Pixyz output

	Args:
		message (str): Message to log
		level (Verbose): Verbose level
	"""
	...

def removeConsoleVerbose(level: Verbose) -> None:
	"""remove a console verbose level

	Args:
		level (Verbose): Verbose level
	"""
	...

def removeLogFileVerbose(level: Verbose) -> None:
	"""remove a log file verbose level

	Args:
		level (Verbose): Verbose level
	"""
	...

def removeSessionLogFileVerbose(level: Verbose) -> None:
	"""remove a session log file (lastSession{Id}.log) verbose level

	Args:
		level (Verbose): Verbose level
	"""
	...

def setCoreDumpFile(path: str) -> None:
	"""set the path of the core dump file that will be written when a crash occurs (default=none)

	Args:
		path (str): Path of the core dump file
	"""
	...

def setLogFile(path: str, keepHistory: bool = False) -> None:
	"""set the path of the log file

	Args:
		path (str): Path of the log file
		keepHistory (bool): Keep session log history in new log file.
	"""
	...

# Callbacks
def addAfterEntityPropertyChangedCallback(callback: Callable[[int, str, int], None], userdata):
	"""emitted after a property is changed
	"""
	...

def removeAfterEntityPropertyChangedCallback(id: int):
	"""Remove callback added with core.addAfterEntityPropertyChangedCallback
	"""
	...

def addAfterModulePropertyChangedCallback(callback: Callable[[str, str], None], userdata):
	"""emitted after a module is changed
	"""
	...

def removeAfterModulePropertyChangedCallback(id: int):
	"""Remove callback added with core.addAfterModulePropertyChangedCallback
	"""
	...

def addAfterUndoRedoCallback(callback: Callable[[], None], userdata):
	"""emitted just after an undo or redo operation
	"""
	...

def removeAfterUndoRedoCallback(id: int):
	"""Remove callback added with core.addAfterUndoRedoCallback
	"""
	...

def addAtExitCallback(callback: Callable[[], None], userdata):
	"""emitted when pixyz is closed
	"""
	...

def removeAtExitCallback(id: int):
	"""Remove callback added with core.addAtExitCallback
	"""
	...

def addBeforeEntityPropertyChangedCallback(callback: Callable[[int, str], None], userdata):
	"""emitted before a property is changed
	"""
	...

def removeBeforeEntityPropertyChangedCallback(id: int):
	"""Remove callback added with core.addBeforeEntityPropertyChangedCallback
	"""
	...

def addBeforeModulePropertyChangedCallback(callback: Callable[[str, str], None], userdata):
	"""emitted before a module is changed
	"""
	...

def removeBeforeModulePropertyChangedCallback(id: int):
	"""Remove callback added with core.addBeforeModulePropertyChangedCallback
	"""
	...

def addBeforeSessionResetCallback(callback: Callable[[], None], userdata):
	"""emitted just before pixyz's session reset
	"""
	...

def removeBeforeSessionResetCallback(id: int):
	"""Remove callback added with core.addBeforeSessionResetCallback
	"""
	...

def addBeforeUndoRedoCallback(callback: Callable[[], None], userdata):
	"""emitted just before an undo or redo operation
	"""
	...

def removeBeforeUndoRedoCallback(id: int):
	"""Remove callback added with core.addBeforeUndoRedoCallback
	"""
	...

def addCurrentFileChangedCallback(callback: Callable[[], None], userdata):
	"""Current loaded file is modified
	"""
	...

def removeCurrentFileChangedCallback(id: int):
	"""Remove callback added with core.addCurrentFileChangedCallback
	"""
	...

def addEnteringUnsafeModeCallback(callback: Callable[[], None], userdata):
	"""emitted before entering the unsafe mode, during this step accesses to the scene may be unsafe
	"""
	...

def removeEnteringUnsafeModeCallback(id: int):
	"""Remove callback added with core.addEnteringUnsafeModeCallback
	"""
	...

def addLeavingUnsafeModeCallback(callback: Callable[[], None], userdata):
	"""emitted when we leave the unsafe mode
	"""
	...

def removeLeavingUnsafeModeCallback(id: int):
	"""Remove callback added with core.addLeavingUnsafeModeCallback
	"""
	...

def addOnConsoleMessageCallback(callback: Callable[[str, Verbose], None], userdata):
	"""sends all Pixyz console message
	"""
	...

def removeOnConsoleMessageCallback(id: int):
	"""Remove callback added with core.addOnConsoleMessageCallback
	"""
	...

def addOnSessionResetCallback(callback: Callable[[], None], userdata):
	"""emitted when pixyz's session is reset
	"""
	...

def removeOnSessionResetCallback(id: int):
	"""Remove callback added with core.addOnSessionResetCallback
	"""
	...

def addProgressChangedCallback(callback: Callable[[int], None], userdata):
	"""emits the progress of the progress bar
	"""
	...

def removeProgressChangedCallback(id: int):
	"""Remove callback added with core.addProgressChangedCallback
	"""
	...

def addProgressStepFinishedCallback(callback: Callable[[], None], userdata):
	"""emits the name of finished step
	"""
	...

def removeProgressStepFinishedCallback(id: int):
	"""Remove callback added with core.addProgressStepFinishedCallback
	"""
	...

def addProgressStepStartCallback(callback: Callable[[str], None], userdata):
	"""emits the name of starting step
	"""
	...

def removeProgressStepStartCallback(id: int):
	"""Remove callback added with core.addProgressStepStartCallback
	"""
	...

def addDebugEventCallback(callback: Callable[[int], None], userdata):
	"""Special event for dev only
	"""
	...

def removeDebugEventCallback(id: int):
	"""Remove callback added with core.addDebugEventCallback
	"""
	...

def addAfterCustomPropertyAddedCallback(callback: Callable[[int, str, int], None], userdata):
	"""emitted after a custom property is added to an entity
	"""
	...

def removeAfterCustomPropertyAddedCallback(id: int):
	"""Remove callback added with core.addAfterCustomPropertyAddedCallback
	"""
	...

def addUndoRedoStackChangedCallback(callback: Callable[[], None], userdata):
	"""emitted when the undo/redo stack has changed, basically when a step recording is finished or when an undo or redo is performed
	"""
	...

def removeUndoRedoStackChangedCallback(id: int):
	"""Remove callback added with core.addUndoRedoStackChangedCallback
	"""
	...

