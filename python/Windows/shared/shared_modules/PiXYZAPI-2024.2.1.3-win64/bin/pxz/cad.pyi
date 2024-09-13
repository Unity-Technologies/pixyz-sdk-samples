from enum import Enum
from collections.abc import Callable

from pxz import core
from pxz import geom
from pxz import material

# Constants

# Classes
class Bounds1D:
	"""1-Dimension bounds
	"""
	min: float
	max: float
	def __init__(self, min: float, max: float) -> None: ...
	...

class Bounds2D:
	"""2-Dimensions bounds
	"""
	u: Bounds1D
	v: Bounds1D
	def __init__(self, u: Bounds1D, v: Bounds1D) -> None: ...
	...

class BrickDefinition:
	"""
	"""
	type: BrickType
	length: int
	width: int
	fullHeight: bool
	def __init__(self, type: BrickType, length: int, width: int, fullHeight: bool) -> None: ...
	...

class BrickType(Enum):
	"""
	"""
	Rectangle: int
	CornerLeft: int
	CornerRight: int
	...

class ExtrusionBoundaryType(Enum):
	"""
	"""
	Full: int
	Hole: int
	Open: int
	...

class OrientedEdge:
	"""Edge with an orientation
	"""
	edge: int
	orientation: bool
	def __init__(self, edge: int, orientation: bool) -> None: ...
	...

class OrientedFace:
	"""Face with an orientation
	"""
	face: int
	orientation: bool
	def __init__(self, face: int, orientation: bool) -> None: ...
	...

class ProfileLoop:
	"""
	"""
	edges: list[OrientedEdge]
	isOuter: bool
	def __init__(self, edges: list[OrientedEdge], isOuter: bool) -> None: ...
	...

class SplittedEdge:
	"""
	"""
	oldEdge: int
	newEdges: list[int]
	def __init__(self, oldEdge: int, newEdges: list[int]) -> None: ...
	...

class TorusType(Enum):
	"""
	"""
	Donut: int
	Vortex: int
	Apple: int
	Lemon: int
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

def getPrecision() -> float:
	"""Get the CAD precision

	Returns:
		precision (float): The current precision
	"""
	...

def setUnitLength(precision: float) -> None:
	"""Set the CAD unity length property

	Args:
		precision (float): Unit length
	"""
	...

def solidIntersection(A: int, B: int) -> list[int]:
	"""perform boolean operation intersection on two bodies (A ^ B)

	Args:
		A (int): The first body
		B (int): The second body

	Returns:
		result (list[int]): List of resulting bodies
	"""
	...

def solidSubtraction(A: int, B: int) -> list[int]:
	"""perform boolean operation subtraction on two bodies (A - B)

	Args:
		A (int): The first body
		B (int): The second body

	Returns:
		result (list[int]): List of resulting bodies
	"""
	...

def solidUnion(A: int, B: int) -> list[int]:
	"""perform boolean operation union on two bodies (A + B)

	Args:
		A (int): The first body
		B (int): The second body

	Returns:
		result (list[int]): List of resulting bodies
	"""
	...

def createBezierCurve(poles: list[geom.Point3]) -> int:
	"""Create a Bezier curve

	Args:
		poles (list[geom.Point3]): Poles list

	Returns:
		BezierCurve (int): Bezier curve
	"""
	...

def createCircleCurve(radius: float, matrix: list[list[float]]) -> int:
	"""Create a new circle

	Args:
		radius (float): Circle radius
		matrix (list[list[float]]): Transformation matrix

	Returns:
		circleCurve (int): Generated circle curve
	"""
	...

def createCompositeCurve(CurveList: list[int]) -> int:
	"""Create a composite curve from a list of limited curves

	Args:
		CurveList (list[int]): List of limited curves

	Returns:
		compositeCurve (int): Composite curve created from the list of limited curves
	"""
	...

def createCosinusCurve(Amplitude: float, Offset: float, Period: float, matrix: list[list[float]]) -> int:
	"""Create a cosinus curve

	Args:
		Amplitude (float): Cosinus amplitude
		Offset (float): Cosinus offset
		Period (float): Cosinus period
		matrix (list[list[float]]): Transformation matrix

	Returns:
		cosinusCurve (int): Cosinus curve
	"""
	...

def createEllipseCurve(URadius: float, VRadius: float, matrix: list[list[float]]) -> int:
	"""Create an ellipse curve

	Args:
		URadius (float): Ellipse radius in u direction
		VRadius (float): Ellipse radius in v direction
		matrix (list[list[float]]): Transformation matrix

	Returns:
		ellipseCurve (int): Ellipse curve
	"""
	...

def createHelixCurve(radius: float, pitch: float, matrix: list[list[float]], trigonometrixOrientation: bool = True) -> int:
	"""Create an helix curve

	Args:
		radius (float): Radius of the helix
		pitch (float): Height of one revolution
		matrix (list[list[float]]): Transformation matrix
		trigonometrixOrientation (bool): Orientation of the rotation

	Returns:
		helixCurve (int): Helix curve
	"""
	...

def createHermiteCurve(FirstPoint: geom.Point3, FirstTangent: geom.Point3, SecondPoint: geom.Point3, SecondTangent: geom.Point3) -> int:
	"""Create a Hermite Curve

	Args:
		FirstPoint (geom.Point3): Starting point of the curve
		FirstTangent (geom.Point3): Tangent of the starting point
		SecondPoint (geom.Point3): Ending point of the curve
		SecondTangent (geom.Point3): Tangent of the ending point

	Returns:
		HermiteCurve (int): Hermite curve
	"""
	...

def createHyperbolaCurve(URadius: float, VRadius: float, matrix: list[list[float]]) -> int:
	"""Create an hyperBola curve

	Args:
		URadius (float): Hyperbola radius in u direction
		VRadius (float): Hyperbola radius in v direction
		matrix (list[list[float]]): Transformation matrix

	Returns:
		parabolaCurve (int): Hyperbola curve
	"""
	...

def createIntersectionCurve(firstSurface: int, secondSurface: int, chart: int, minBounds: float, maxBounds: float) -> int:
	"""Create a Intersection Curve

	Args:
		firstSurface (int): First surface of the intersection curve
		secondSurface (int): Second surface of the intersection curve
		chart (int): Direction curve of the intersection curve
		minBounds (float): Minimum value of the bounds of the intersection curve
		maxBounds (float): Maximum value of the bounds of the intersection curve

	Returns:
		IntersectionCurve (int): Intersection curve
	"""
	...

def createLineCurve(OriginPt: geom.Point3, DirectionPt: geom.Point3) -> int:
	"""Create a Line Curve

	Args:
		OriginPt (geom.Point3): Orinin point of the line curve
		DirectionPt (geom.Point3): Direction vector of the line curve

	Returns:
		LineCurve (int): Line curve
	"""
	...

def createNURBSCurve(degree: int, knots: list[float], poles: list[geom.Point3], weights: list[float] = list[float]()) -> int:
	"""Create a NURBS curve

	Args:
		degree (int): Degree of the curve
		knots (list[float]): Knots of the curve
		poles (list[geom.Point3]): Poles list
		weights (list[float]): Weight list

	Returns:
		NURBSCurve (int): NURBS curve
	"""
	...

def createParabolaCurve(focalLength: float, matrix: list[list[float]]) -> int:
	"""Create an parabola curve

	Args:
		focalLength (float): Focal lecngth of the parabola
		matrix (list[list[float]]): Transformation matrix

	Returns:
		parabolaCurve (int): Parabola curve
	"""
	...

def createPolylineCurve(points: list[geom.Point3], parameters: list[float] = list[float]()) -> int:
	"""Create a Polyline curve

	Args:
		points (list[geom.Point3]): Points of polyline curve
		parameters (list[float]): Params of polyline curve

	Returns:
		polylineCurve (int): Polyline curve
	"""
	...

def createSegmentCurve(firstPoint: geom.Point3, secondPoint: geom.Point3) -> int:
	"""Create a segment curve from two given points

	Args:
		firstPoint (geom.Point3): First point
		secondPoint (geom.Point3): Second point

	Returns:
		segmentCurve (int): Segment curve created from the two given points
	"""
	...

def createSurfacicCurve(surface: int, curve2D: int) -> int:
	"""Create a curve from a surface

	Args:
		surface (int): Surface to bound
		curve2D (int): Curve to project

	Returns:
		surfacicCurve (int): Curve projected on given surface
	"""
	...

def createTransformedCurve(curve: int, matrix: list[list[float]]) -> int:
	"""Create a curve from a surface

	Args:
		curve (int): Curve to transform
		matrix (list[list[float]]): Matrix of the transformation

	Returns:
		transformedCurve (int): Curve transformed by the given matrix
	"""
	...

def invertCurve(curve: int, precision: float) -> int:
	"""Invert a curve parametricaly

	Args:
		curve (int): The curve to invert
		precision (float): The precision used to invert the curve

	Returns:
		invertedCurve (int): The inverted curve
	"""
	...

def createBoundedLinearExtrusionBody(profileBase: list[ProfileLoop], direction: geom.Point3, planeOrigin: geom.Point3, planeNormal: geom.Point3, startTangent: geom.Point3, boundaryType: ExtrusionBoundaryType = 0, profileEnd: list[ProfileLoop] = list[ProfileLoop]()) -> int:
	"""create a linear extrusion body

	Args:
		profileBase (list[ProfileLoop]): Profile loops to revolve
		direction (geom.Point3): The profile curves will be extruded in this direction
		planeOrigin (geom.Point3): The origin of the plane that bound the extrusion
		planeNormal (geom.Point3): The normal of the plane that bound the extrusion
		startTangent (geom.Point3): The starting tangent corresponding of the normal of the plane in which all profile lie
		boundaryType (ExtrusionBoundaryType): If the profile curves define an area or not
		profileEnd (list[ProfileLoop]): The end profile of the extrusion

	Returns:
		boundedLinearExtrusion (int): The created body
	"""
	...

def createCurveExtrusionBody(profileBase: list[ProfileLoop], curve: int, startTangent: geom.Point3, boundaryType: ExtrusionBoundaryType = 0, profileEnd: list[ProfileLoop] = list[ProfileLoop]()) -> int:
	"""create a curve extrusion body

	Args:
		profileBase (list[ProfileLoop]): Profile loops to revolve
		curve (int): The profile curves will be extruded along this curve
		startTangent (geom.Point3): The starting tangent corresponding of the normal of the plane in which all profile lie
		boundaryType (ExtrusionBoundaryType): If the profile curves define an area or not
		profileEnd (list[ProfileLoop]): The end profile of the extrusion

	Returns:
		curveExtrusion (int): The created body
	"""
	...

def createLinearExtrusionBody(profileBase: list[ProfileLoop], direction: geom.Point3, depth: float, startTangent: geom.Point3, boundaryType: ExtrusionBoundaryType = 0, profileEnd: list[ProfileLoop] = list[ProfileLoop]()) -> int:
	"""create a linear extrusion body

	Args:
		profileBase (list[ProfileLoop]): Profile loops to revolve
		direction (geom.Point3): The profile curves will be extruded in this direction
		depth (float): The extrusion will stop at the defined depth
		startTangent (geom.Point3): The starting tangent corresponding of the normal of the plane in which all profile lie
		boundaryType (ExtrusionBoundaryType): If the profile curves define an area or not
		profileEnd (list[ProfileLoop]): The end profile of the extrusion

	Returns:
		linearExtrusion (int): The created body
	"""
	...

def createMultiExtrusionBody(profileBaseList: list[list[ProfileLoop]], profileExtrusionList: list[list[int]], boundaryType: ExtrusionBoundaryType = 0) -> int:
	"""create a linear extrusion body

	Args:
		profileBaseList (list[list[ProfileLoop]]): Profile loops to be extruded
		profileExtrusionList (list[list[int]]): Extrusion profiles
		boundaryType (ExtrusionBoundaryType): If the profile curves define an area or not

	Returns:
		boundedLinearExtrusion (int): The created body
	"""
	...

def createRevolveExtrusionBody(profileBase: list[ProfileLoop], center: geom.Point3, axis: geom.Point3, angle: float, startTangent: geom.Point3, boundaryType: ExtrusionBoundaryType = 0, profileEnd: list[ProfileLoop] = list[ProfileLoop]()) -> int:
	"""create a revolved extrusion body

	Args:
		profileBase (list[ProfileLoop]): Profile loops to revolve
		center (geom.Point3): The center of revolution
		axis (geom.Point3): The profile curves will be revolved around this axis
		angle (float): The revolution will stop at the defined angle
		startTangent (geom.Point3): The starting tangent corresponding of the normal of the plane in which all profile lie
		boundaryType (ExtrusionBoundaryType): If the profile curves define an area or not
		profileEnd (list[ProfileLoop]): The end profile of the extrusion

	Returns:
		revolvedExtrusion (int): The created body
	"""
	...

def getFaceMaterial(face: int) -> int:
	"""get the material on a face

	Args:
		face (int): The face

	Returns:
		material (int): The material
	"""
	...

def setFaceMaterial(face: int, material: int) -> None:
	"""set the material on a face

	Args:
		face (int): The face
		material (int): The material
	"""
	...

def addBodyToModel(body: int, model: int) -> None:
	"""Add a body to the model

	Args:
		body (int): Body added to the model
		model (int): Model
	"""
	...

def addEdgeToModel(edge: int, model: int) -> None:
	"""Add an edge to the model

	Args:
		edge (int): Edge added to the model
		model (int): Model
	"""
	...

def addOpenShellToModel(shell: int, model: int) -> None:
	"""Add an open shell to the model

	Args:
		shell (int): Open shell added to the model
		model (int): Model
	"""
	...

def addVertexToModel(vtx: int, model: int) -> None:
	"""Add a vertex to the model

	Args:
		vtx (int): Vertex added to the model
		model (int): Model
	"""
	...

def buildFaces(surface: int, loopList: list[int]) -> dict:
	"""Build faces from a surface and a set of loop

	Args:
		surface (int): Surface used to build the faces
		loopList (list[int]): List of Loops used to build the faces

	Returns:
		faces (list[int]): The created faces
		splittingInfo (list[SplittedEdge]): Map between the old edges and the new ones
	"""
	...

def createModel(precision: float = -1) -> int:
	"""Create a new model

	Args:
		precision (float): CAD precision for this model

	Returns:
		model (int): The created model
	"""
	...

def endThreadBrepSession() -> None:
	"""Create a new BrepSession on current thread
	"""
	...

def getAllModelFaces(model: int) -> list[int]:
	"""Get all the face of a model recursively

	Args:
		model (int): Model

	Returns:
		faces (list[int]): List of faces in the given model
	"""
	...

def getModelBodies(model: int) -> list[int]:
	"""Get the list of bodies contained in a model

	Args:
		model (int): Model

	Returns:
		bodies (list[int]): List of bodies contained in the given model
	"""
	...

def getModelBoundaries(model: int) -> list[list[int]]:
	"""Get boundary edges of a model grouped by cycles

	Args:
		model (int): Model

	Returns:
		boundaries (list[list[int]]): List of boundary edges grouped by cycles in the given model
	"""
	...

def getModelEdges(model: int) -> list[int]:
	"""Get the list of free edges contained in a model

	Args:
		model (int): Model

	Returns:
		edges (list[int]): List of edges contained in the given model
	"""
	...

def getModelOpenShells(model: int) -> list[int]:
	"""Get the list of open shells contained in a model

	Args:
		model (int): Model

	Returns:
		shells (list[int]): List of open shells contained in the given model
	"""
	...

def getModelPrecision(model: int) -> float:
	"""Get the precision used in a model

	Args:
		model (int): Model

	Returns:
		precision (float): Precision value
	"""
	...

def getModelVertices(model: int) -> list[int]:
	"""Get the list of free vertices contained in a model

	Args:
		model (int): Model

	Returns:
		vertices (list[int]): List of vertices contained in the given model
	"""
	...

def getReferencers(entity: int) -> list[int]:
	"""Returns the entities referencing a given CAD entity

	Args:
		entity (int): CAD entity to get the referencers

	Returns:
		referencers (list[int]): List of CAD entities referencing the given entity
	"""
	...

def startThreadBrepSession(precision: float) -> None:
	"""Create a new BrepSession on current thread

	Args:
		precision (float): CAD precision for this model
	"""
	...

def createBRepCone(radius: float, height: float, matrix: list[list[float]] = geom.IdentityMatrix4) -> int:
	"""Creates a BRep Cone whose axis is the Z axis centered on O

	Args:
		radius (float): Cone radius
		height (float): Cone height
		matrix (list[list[float]]): Positionning matrix of the Cone

	Returns:
		body (int): The created Body
	"""
	...

def createBRepCube(size: float, matrix: list[list[float]] = geom.IdentityMatrix4) -> int:
	"""Creates a BRep Cube

	Args:
		size (float): Side length
		matrix (list[list[float]]): Positionning matrix of the Cube

	Returns:
		body (int): The created Body
	"""
	...

def createBRepCylinder(radius: float, length: float, matrix: list[list[float]] = geom.IdentityMatrix4) -> int:
	"""Creates a BRep Cylinder aligned on the Z axis centered on O

	Args:
		radius (float): Cylinder radius
		length (float): Cylinder length
		matrix (list[list[float]]): Positionning matrix of the Cylinder

	Returns:
		body (int): The created Body
	"""
	...

def createBRepPlane(length: float, width: float, matrix: list[list[float]] = geom.IdentityMatrix4) -> int:
	"""Creates a BRep Plane whose normal is the Z axis centered on O

	Args:
		length (float): Plane length (X axis)
		width (float): Plane width (Y axis)
		matrix (list[list[float]]): Positionning matrix of the Plane

	Returns:
		body (int): The created Body
	"""
	...

def createBRepSphere(radius: float, matrix: list[list[float]] = geom.IdentityMatrix4) -> int:
	"""Creates a BRep Sphere centered on O and whose singularities are on the Z axis

	Args:
		radius (float): Sphere radius
		matrix (list[list[float]]): Positionning matrix of the Sphere

	Returns:
		body (int): The created Body
	"""
	...

def createBRepTorus(majorRadius: float, minorRadius: float, matrix: list[list[float]] = geom.IdentityMatrix4) -> int:
	"""Creates a BRep Torus whose axis is the Z axis centered on O

	Args:
		majorRadius (float): Major radius
		minorRadius (float): Minor radius
		matrix (list[list[float]]): Positionning matrix of the Torus

	Returns:
		body (int): The created Body
	"""
	...

def evalCurvatureOnCurve(curve: int, parameter: float) -> float:
	"""evaluate curvature on a curve

	Args:
		curve (int): The curve
		parameter (float): Parameter to evaluate

	Returns:
		curvature (float): Curvature on curve at parameter
	"""
	...

def evalCurvatureOnSurface(surface: int, parameter: geom.Point2) -> geom.Curvatures:
	"""evaluate main curvatures on a surface

	Args:
		surface (int): The surface
		parameter (geom.Point2): Parameter to evaluate

	Returns:
		curvatures (geom.Curvatures): Main curvatures on surface at parameter
	"""
	...

def evalOnCurve(curve: int, parameter: float, derivation: int = 0) -> dict:
	"""evaluate a point and derivatives on a curve

	Args:
		curve (int): The curve
		parameter (float): Parameter to evaluate
		derivation (int): Derivation level (0,1,2)

	Returns:
		d0 (geom.Point3): D0
		du (geom.Point3): Du
		d2u (geom.Point3): D2u
	"""
	...

def evalOnSurface(surface: int, parameter: geom.Point2, derivation: int = 0) -> dict:
	"""evaluate a point and derivatives on a surface

	Args:
		surface (int): The surface
		parameter (geom.Point2): Parameter to evaluate
		derivation (int): Derivation level (0,1,2)

	Returns:
		d0 (geom.Point3): D0
		du (geom.Point3): Du
		dv (geom.Point3): Dv
		d2u (geom.Point3): D2u
		d2v (geom.Point3): D2v
		duv (geom.Point3): Duv
	"""
	...

def getBodyClosedShells(body: int) -> list[int]:
	"""get all closedShells contain in the body

	Args:
		body (int): The body

	Returns:
		closedShells (list[int]): The closedShells contain within the body
	"""
	...

def getCircleCurveDefinition(circleCurve: int) -> dict:
	"""get all parameters contained in the circleCurve

	Args:
		circleCurve (int): The circleCurve

	Returns:
		radius (float): The radius of the circle
		matrix (list[list[float]]): The matrix transformation of the circle
	"""
	...

def getClosedShellOrientedFaces(closedShell: int) -> list[OrientedFace]:
	"""get all orienteFaces contain in the closedShell

	Args:
		closedShell (int): The closedShell

	Returns:
		orientedFaces (list[OrientedFace]): The orientedFaces contain within the closedShell
	"""
	...

def getCoEdgeDefinition(coEdge: int) -> dict:
	"""get all parameters contained in the coEdge

	Args:
		coEdge (int): The coEdge

	Returns:
		edge (int): The edge of the coEdge
		edgeOrientation (bool): Orientation of the edge
		loop (int): The loop containing the coEdge
		surface (int): The surface of the coEdge
		parametricCurve (int): The parametricCurve of the coEdge
	"""
	...

def getCompositeCurveDefinition(compositeCurve: int) -> dict:
	"""get all parameters contained in the compositeCurve

	Args:
		compositeCurve (int): The compositeCurve

	Returns:
		curves (list[int]): The curves of the compositeCurve
		parameters (list[float]): The parameters of the compositeCurve
	"""
	...

def getConeSurfaceDefinition(coneSurface: int) -> dict:
	"""get all parameters contained in the coneSurface

	Args:
		coneSurface (int): The coneSurface

	Returns:
		radius (float): The radius of the coneSurface
		semiAngle (float): The semiAngle of coneSurface
		matrix (list[list[float]]): The transformation matrix of coneSurface
	"""
	...

def getCurveExtrusionSurfaceDefinition(curveExtrusionSurface: int) -> dict:
	"""get all parameters contained in the curveExtrusionSurface

	Args:
		curveExtrusionSurface (int): The curveExtrusionSurface

	Returns:
		generatrixCurve (int): The generatrix curve of the curveExtrusionSurface
		directrixCruve (int): The directrix curve of the curveExtrusionSurface
		surfaceReference (int): The reference surface of curveExtrusionSurface
	"""
	...

def getCurveLength(curve: int) -> float:
	"""returns the length of the curve

	Args:
		curve (int): The curve

	Returns:
		length (float): The length of the edge
	"""
	...

def getCurveLimits(curve: int) -> Bounds1D:
	"""get the parametric space limits of a curve

	Args:
		curve (int): The curve

	Returns:
		limits (Bounds1D): Curve limits
	"""
	...

def getCylinderSurfaceDefinition(cylinderSurface: int) -> dict:
	"""get all parameters contained in the cylinderSurface

	Args:
		cylinderSurface (int): The cylinderSurface

	Returns:
		radius (float): The radius of the cylinderSurface
		matrix (list[list[float]]): The transformation matrix of cylinderSurface
	"""
	...

def getEdgeDefinition(edge: int) -> dict:
	"""get all parameters contained in the edge

	Args:
		edge (int): The edge

	Returns:
		vertex1 (int): The first vertex of the edge
		vertex2 (int): The second vertex of the edge
		curve (int): The curve of the edge
		bounds (Bounds1D): The bounds of the edge
	"""
	...

def getEdgeLength(edge: int) -> float:
	"""returns the length of the edge

	Args:
		edge (int): The edge

	Returns:
		length (float): The length of the edge
	"""
	...

def getEdgeMaterial(edge: int) -> int:
	"""Get the material of the edge, if any

	Args:
		edge (int): 

	Returns:
		material (int): The material applied to the edge, 0 if no material
	"""
	...

def getEllipseCurveDefinition(ellipseCurve: int) -> dict:
	"""get all parameters contained in the ellipseCurve

	Args:
		ellipseCurve (int): The ellipseCurve

	Returns:
		radius1 (float): The radius on x of the ellipse
		radius2 (float): The radius on y of the ellipse
		matrix (list[list[float]]): The transformation matrix of the ellipse
	"""
	...

def getEllipticConeSurfaceDefinition(ellipticConeSurface: int) -> dict:
	"""get all parameters contained in the ellipticConeSurface

	Args:
		ellipticConeSurface (int): The EllipticConeSurface

	Returns:
		radius1 (float): The radius on X of the coneSurface
		radius2 (float): The radius on Y of the coneSurface
		semiAngle (float): The semiAngle of coneSurface
		matrix (list[list[float]]): The transformation matrix of coneSurface
	"""
	...

def getFaceDefinition(face: int) -> dict:
	"""get all parameters contain in the face

	Args:
		face (int): The face

	Returns:
		surface (int): The surface contain within the face
		loops (list[int]): The loops contain within the face
		orientation (bool): Relative orientation of the surface
		limits (Bounds2D): Face limits on surfaces
	"""
	...

def getFaceParametricBoundaries(face: int) -> list[list[geom.Point2]]:
	"""get parametric definition of each face loop

	Args:
		face (int): The face

	Returns:
		boundaries (list[list[geom.Point2]]): The parametric boundaries
	"""
	...

def getHelixCurveDefinition(helixCurve: int) -> dict:
	"""get all parameters contained in the helixCurve

	Args:
		helixCurve (int): The helixCurve

	Returns:
		radius (float): The radius of the helixCurve
		matrix (list[list[float]]): The matrix of the helixCurve
		trigonometricOrientation (bool): The trigonometricOrientation of the helixCurve
	"""
	...

def getHermiteCurveDefinition(hermiteCurve: int) -> dict:
	"""get all parameters contained in the hermiteCurve

	Args:
		hermiteCurve (int): The HermiteCurve

	Returns:
		firstPoint (geom.Point3): The first point of the hermiteCurve
		secondPoint (geom.Point3): The second point of the hermiteCurve
		firstTangent (geom.Point3): The first tangent of the hermiteCurve
		secondTangent (geom.Point3): The second tangent of the hermiteCurve
	"""
	...

def getHyperbolaCurveDefinition(hyperbolaCurve: int) -> dict:
	"""get all parameters contained in the hyperbolaCurve

	Args:
		hyperbolaCurve (int): The hyperbolaCurve

	Returns:
		radius1 (float): The radius on x of the hyperbola
		radius2 (float): The radius on y of the hyperbola
		matrix (list[list[float]]): The transformation matrix of the hyperbola
	"""
	...

def getIntersectionCurveDefinition(intersectionCurve: int) -> dict:
	"""get all parameters contained in the intersectionCurve

	Args:
		intersectionCurve (int): The intersectionCurve

	Returns:
		surface1 (int): The first surface of the intersectionCurve
		surface2 (int): The second surface of the intersectionCurve
		chart (int): The chart of the intersectionCurve
		bounds (Bounds1D): The boudns of the intersectionCurve
	"""
	...

def getLineCurveDefinition(lineCurve: int) -> dict:
	"""get all parameters contain in the lineCurve

	Args:
		lineCurve (int): The lineCurve

	Returns:
		origin (geom.Point3): The origin of the lineCurve
		direction (geom.Point3): The direction of the lineCurve
	"""
	...

def getLoopCoEdges(loop: int) -> list[int]:
	"""get all coEdges contain in the loop

	Args:
		loop (int): The loop

	Returns:
		coEdges (list[int]): The coEdges contain within the loop
	"""
	...

def getNURBSCurveDefinition(nurbsCurve: int) -> dict:
	"""get all parameters contained in the nurbsCurve

	Args:
		nurbsCurve (int): The nurbsCurve

	Returns:
		degree (int): The degree of the nurbsCurve
		knots (list[float]): The knots of the nurbsCurve
		poles (list[geom.Point3]): The poles of the nurbsCurve
		weights (list[float]): The weights of the poles of the nurbsCurve
	"""
	...

def getNURBSSurfaceDefinition(nurbsSurface: int) -> dict:
	"""get all parameters contained in the nurbsSurface

	Args:
		nurbsSurface (int): The nurbsSurface

	Returns:
		degreeU (int): The degree on U of the nurbsSurface
		degreeV (int): The degree on V of the nurbsSurface
		knotsU (list[float]): The knots on U of the nurbsSurface
		knotsV (list[float]): The knots on V of the nurbsSurface
		poles (list[list[geom.Point3]]): The poles of nurbsSurface
		weights (list[list[float]]): The weights of the poles of nurbsSurface
	"""
	...

def getOffsetCurveDefinition(offsetCurve: int) -> dict:
	"""get all parameters contained in the offsetCurve

	Args:
		offsetCurve (int): The offsetCurve

	Returns:
		curve (int): The curve of the offsetCurve
		direction (geom.Point3): The direction of the offset
		distance (float): The distance of the offset
		surfaceReference (int): The surfaceReference of the offsetCurve
	"""
	...

def getOffsetSurfaceDefinition(offsetSurface: int) -> dict:
	"""get all parameters contained in the offsetSurface

	Args:
		offsetSurface (int): The offsetSurface

	Returns:
		baseSurface (int): The initial surface
		distance (float): The distance offset
	"""
	...

def getOpenShellOrientedFaces(openShell: int) -> list[OrientedFace]:
	"""get all orienteFaces contain in the openShell

	Args:
		openShell (int): The openShell

	Returns:
		orientedFaces (list[OrientedFace]): The orientedFaces contain within the openShell
	"""
	...

def getParabolaCurveDefinition(parabolaCurve: int) -> dict:
	"""get all parameters contained in the parabolaCurve

	Args:
		parabolaCurve (int): The parabolaCurve

	Returns:
		focalLength (float): The radius of the hyperbola
		matrix (list[list[float]]): The transformation matrix of the hyperbola
	"""
	...

def getParametricPrecisionOnSurface(surface: int, precision: float) -> float:
	"""returns the parametric precision of a surface from the input precision

	Args:
		surface (int): The surface
		precision (float): Input precision

	Returns:
		parametricPrecision (float): 
	"""
	...

def getPlaneSurfaceDefinition(planeSurface: int) -> list[list[float]]:
	"""get all parameters contained in the planeSurface

	Args:
		planeSurface (int): The planeSurface

	Returns:
		matrix (list[list[float]]): The transformation matrix of planeSurface
	"""
	...

def getPolylineCurveDefinition(polylineCurve: int) -> dict:
	"""get all parameters contained in the polylinCurve

	Args:
		polylineCurve (int): The polylineCurve

	Returns:
		points (list[geom.Point3]): The points of the polylineCurve
		parameters (list[float]): The parameters of the polylineCurve
	"""
	...

def getRevolutionSurfaceDefinition(revolutionSurface: int) -> dict:
	"""get all parameters contained in the revolutionSurface

	Args:
		revolutionSurface (int): The revolutionSurface

	Returns:
		generatricCurve (int): Thegeneratrix curve of the revolutionSurface
		axisOrigin (geom.Point3): The origin of the axis of the revolutionSurface
		axisDirection (geom.Point3): The direction of the axis of the revolutionSurface
		startAngle (float): The starting angle of the revolutionSurface
		endAngle (float): The ending angle of the revolutionSurface
	"""
	...

def getRuledSurfaceDefinition(ruledSurface: int) -> dict:
	"""get all parameters contained in the ruledSurface

	Args:
		ruledSurface (int): The ruledSurface

	Returns:
		firstCurve (int): The first curve of the ruledSurface
		secondCurve (int): The second curve of the ruledSurface
	"""
	...

def getSegmentCurveDefinition(segmentCurve: int) -> dict:
	"""get all parameters contained in the segmentCurve

	Args:
		segmentCurve (int): The segmentCurve

	Returns:
		startPoint (geom.Point3): The first point of the segmentCurve
		endPoint (geom.Point3): The second point of the segmentCurve
	"""
	...

def getSphereSurfaceDefinition(sphereSurface: int) -> dict:
	"""get all parameters contained in the sphereSurface

	Args:
		sphereSurface (int): The sphereSurface

	Returns:
		radius (float): The radius of the sphereSurface
		matrix (list[list[float]]): The transformation matrix of sphereSurface
	"""
	...

def getSurfaceLimits(surface: int) -> Bounds2D:
	"""get the parametric space limits of a surface

	Args:
		surface (int): The surface

	Returns:
		limits (Bounds2D): Surface limits
	"""
	...

def getSurfacicCurveDefinition(surfacicCurve: int) -> dict:
	"""get all parameters contained in the surfacicCurve

	Args:
		surfacicCurve (int): The surfacicCurve

	Returns:
		surface (int): The surface of the surfacicCurve
		curve2D (int): The 2D curve of the surfacicCurve
	"""
	...

def getTabulatedCylinderSurfaceDefinition(tabulatedCylinderSurface: int) -> dict:
	"""get all parameters contained in the TabulatedCylinderSurface

	Args:
		tabulatedCylinderSurface (int): The tabulatedCylinderSurface

	Returns:
		directrixCurve (int): The directrix curve of the tabulatedCylinderSurface
		generatrixLine (geom.Point3): The generatrix line of the tabulatedCylinderSurface
		range (Bounds1D): The range of the tabulatedCylinderSurface
	"""
	...

def getTorusSurfaceDefinition(torusSurface: int) -> dict:
	"""get all parameters contained in the torusSurface

	Args:
		torusSurface (int): The torusSurface

	Returns:
		majorRadius (float): The major radius of the torusSurface
		minorRadius (float): The minor radius of the torusSurface
		matrix (list[list[float]]): The transformation matrix of torusSurface
		type (int): The torus shape type id
	"""
	...

def getTransformedCurveDefinition(transformedCurve: int) -> dict:
	"""get all parameters contained in the transformedCurve

	Args:
		transformedCurve (int): The transformedCurve

	Returns:
		curve (int): The initial curve
		matrix (list[list[float]]): The transformation matrix
	"""
	...

def getVertexPosition(vertex: int) -> geom.Point3:
	"""get the position of the vertex

	Args:
		vertex (int): The vertex

	Returns:
		position (geom.Point3): The position of the vertex
	"""
	...

def invertOnCurve(curve: int, point: geom.Point3, precision: float = -1) -> float:
	"""invert a point to a curve

	Args:
		curve (int): The curve
		point (geom.Point3): The point to invert
		precision (float): Inversion precision

	Returns:
		parameter (float): The inversion parameter on the curve
	"""
	...

def invertOnSurface(surface: int, point: geom.Point3, precision: float = -1) -> geom.Point2:
	"""invert a point to a surface

	Args:
		surface (int): The surface
		point (geom.Point3): The point to invert
		precision (float): Inversion precision

	Returns:
		parameter (geom.Point2): The inversion parameter on the surface
	"""
	...

def isCurveClosed(curve: int) -> bool:
	"""if the curve is closed, return true, return false otherwise

	Args:
		curve (int): The curve

	Returns:
		closed (bool): The value
	"""
	...

def isCurveFinite(curve: int) -> bool:
	"""if the curve is finite return true, return false otherwise

	Args:
		curve (int): The curve

	Returns:
		finite (bool): The value
	"""
	...

def isCurvePeriodic(curve: int) -> dict:
	"""if the curve is periodic return true, return false otherwise

	Args:
		curve (int): The curve

	Returns:
		periodic (bool): The value
		period (float): If th curve is periodic, this value is equal to the period value, equal to 0 otherwise
	"""
	...

def isSurfaceClosed(surface: int) -> dict:
	"""return if the surface is closed on U or on V

	Args:
		surface (int): The surface

	Returns:
		closedU (bool): The value on U
		closedV (bool): The value on V
	"""
	...

def isSurfacePeriodic(surface: int) -> dict:
	"""return if the surface is periodic on U or on V

	Args:
		surface (int): The surface

	Returns:
		periodicU (bool): The value on U
		periodicV (bool): The value on V
		periodU (float): If th curve is periodic on U, this value is equal to the period value, equal to 0 otherwise
		periodV (float): If th curve is periodic on V, this value is equal to the period value, equal to 0 otherwise
	"""
	...

def needTorusShapeCheck(surface: int, points: list[geom.Point3]) -> bool:
	"""Returns true if the torus has a shape (lemon or apple) corresponding to the provided points

	Args:
		surface (int): The surface
		points (list[geom.Point3]): List of points to check the surface

	Returns:
		result (bool): Result of the check
	"""
	...

def projectOnCurve(curve: int, point: geom.Point3, precision: float = -1) -> float:
	"""project a point to a curve

	Args:
		curve (int): The curve
		point (geom.Point3): The point to project
		precision (float): Projection precision

	Returns:
		projectionParameter (float): The projection parameter on the curve
	"""
	...

def projectOnSurface(surface: int, point: geom.Point3, precision: float = -1) -> geom.Point2:
	"""project a point to a surface

	Args:
		surface (int): The surface
		point (geom.Point3): The point to project
		precision (float): Projection precision

	Returns:
		projectionParameter (geom.Point2): The projection parameter on the surface
	"""
	...

def setCoEdgeCurve2D(coEdge: int, curve2D: int) -> None:
	"""Set the curve 2D value of a coEdge

	Args:
		coEdge (int): The coEdge
		curve2D (int): The new curve 2D
	"""
	...

def setCoEdgeSurface(coEdge: int, surface: int) -> None:
	"""Set the surface value of a coEdge

	Args:
		coEdge (int): The coEdge
		surface (int): The new surface
	"""
	...

def setCurveLimits(curve: int, limits: Bounds1D) -> None:
	"""set the parametric space limits of a curve

	Args:
		curve (int): The curve
		limits (Bounds1D): Curve limits
	"""
	...

def setEdgeMaterial(edge: int, material: int) -> None:
	"""Define an edge's material

	Args:
		edge (int): The edge to apply to style to
		material (int): The material to apply
	"""
	...

def createBody(outerShell: int, innerShells: list[int] = list[int]()) -> int:
	"""Create a body from a surface

	Args:
		outerShell (int): ClosedShell used to create the body
		innerShells (list[int]): List of closedShell used to create the body

	Returns:
		body (int): The created body
	"""
	...

def createClosedShell(faces: list[int], orientations: list[bool]) -> int:
	"""Create a closedShell from a set of faces of a set of orientations

	Args:
		faces (list[int]): List of faces composing the closedShell
		orientations (list[bool]): List of orientations for each face

	Returns:
		closedShell (int): The created closedShell
	"""
	...

def createCoEdge(edge: int, orientation: bool, surface: int = 0, curve2D: int = 0, computeGateway: bool = False) -> int:
	"""Create an coEdge with a edge and an orientation

	Args:
		edge (int): Edge used to create the coEdge
		orientation (bool): Orientation of the edge regarding the loop
		surface (int): The surface trimmed by the edge
		curve2D (int): Surfacic curve of the edge on the surface trimmed
		computeGateway (bool): Needed if 3d curve and 2d curve have different parametrization

	Returns:
		coEdge (int): The created edge
	"""
	...

def createEdge(curve: int, startVertex: int, endVertex: int) -> int:
	"""Create an edge with a curve an extremity vertices

	Args:
		curve (int): Curve used to create the edge
		startVertex (int): The start vertex
		endVertex (int): The end vertex

	Returns:
		edge (int): The created edge
	"""
	...

def createEdgeFromCurve(curve: int) -> int:
	"""Create an edge from a limited curve

	Args:
		curve (int): Limited curve used to create the edge

	Returns:
		edge (int): The created edge
	"""
	...

def createEdgeWithBounds(curve: int, startVertex: int, endVertex: int, bounds: Bounds1D) -> int:
	"""Create an edge with a curve an extremity vertices and a given boundary

	Args:
		curve (int): Curve used to create the edge
		startVertex (int): The start vertex
		endVertex (int): The end vertex
		bounds (Bounds1D): The parametrization boundary

	Returns:
		edge (int): The created edge
	"""
	...

def createFace(surface: int, loopList: list[int] = list[int](), useSurfaceOrientation: bool = False) -> int:
	"""Create a face from a surface

	Args:
		surface (int): Surface used to create the face
		loopList (list[int]): List of Loops used to create the face
		useSurfaceOrientation (bool): If True, the face will have the same orientation than the surface and loops will be inverted if they are inconsistent

	Returns:
		face (int): The created face
	"""
	...

def createLoop(coEdges: list[int], check: bool = True, deleteIsolatedVertices: bool = True) -> int:
	"""Create a loop from a set of edges of a set of orientations

	Args:
		coEdges (list[int]): List of coEdges composing the loop
		check (bool): If true, the loop check if edges are well connected or not
		deleteIsolatedVertices (bool): If true, this will merge isolated vertices in the loop

	Returns:
		loop (int): The created loop
	"""
	...

def createLoopFromCurve(curve: int) -> int:
	"""Create a loop from a finite curve

	Args:
		curve (int): The curve to create the loop with

	Returns:
		loop (int): The created loop
	"""
	...

def createOpenShell(faces: list[int], orientations: list[bool]) -> int:
	"""Create a openShell from a set of faces of a set of orientations and set of loops

	Args:
		faces (list[int]): List of faces composing the openShell
		orientations (list[bool]): List of orientations for each face

	Returns:
		openShell (int): The created openShell
	"""
	...

def createVertex(position: geom.Point3) -> int:
	"""Create a vertex from a position

	Args:
		position (geom.Point3): Vertex position

	Returns:
		vertex (int): The created vertex
	"""
	...

def invertCoEdge(coedge: int) -> None:
	"""Invert a coedge

	Args:
		coedge (int): The coedge to invert
	"""
	...

def invertFaces(faces: list[int], invertLoops: bool = True) -> None:
	"""Invert faces

	Args:
		faces (list[int]): The faces to invert
		invertLoops (bool): If true, invert loops orientation
	"""
	...

def invertLoop(loop: int) -> None:
	"""Invert a loop

	Args:
		loop (int): The loop to invert
	"""
	...

def isSurfaceFinite(surface: int) -> bool:
	"""return if the surface is finite

	Args:
		surface (int): The surface

	Returns:
		finite (bool): Tells if finite
	"""
	...

def addPrecisionArea(surface: int, aabr: geom.AABR) -> None:
	"""Define a working area on the 2D projection of the surface to define a parametric precision

	Args:
		surface (int): Surface on which the precision area will be set
		aabr (geom.AABR): 2D area defining the working area
	"""
	...

def createBezierSurface(degreeU: int, degreeV: int, poles: list[geom.Point3]) -> int:
	"""Create a new bezier surface

	Args:
		degreeU (int): U degree
		degreeV (int): V degree
		poles (list[geom.Point3]): Poles list

	Returns:
		bezierSurface (int): The new Bezier surface
	"""
	...

def createConeSurface(radius: float, semiAngle: float, matrix: list[list[float]] = geom.IdentityMatrix4) -> int:
	"""Create a new cone surface

	Args:
		radius (float): Radius of the cone at origin
		semiAngle (float): Semi-angle of the cone (in rad)
		matrix (list[list[float]]): Positionning matrix of the cone

	Returns:
		coneSurface (int): The new cone surface
	"""
	...

def createCurveExtrusionSurface(generatrixCurve: int, directrixCurve: int, refSurface: int = 0) -> int:
	"""Create a new curveExtrusion surface

	Args:
		generatrixCurve (int): The generatrix curve
		directrixCurve (int): The directrix curve
		refSurface (int): The reference surface

	Returns:
		curveExtrusionSurface (int): The new curveExtrusion surface
	"""
	...

def createCylinderSurface(radius: float, matrix: list[list[float]] = geom.IdentityMatrix4) -> int:
	"""Create a new cylinder surface

	Args:
		radius (float): Radius of the cylinder
		matrix (list[list[float]]): Positionning matrix of the cylinder

	Returns:
		cylinderSurface (int): The new cylinder surface
	"""
	...

def createEllipticConeSurface(radius1: float, radius2: float, semiAngle: float, matrix: list[list[float]] = geom.IdentityMatrix4) -> int:
	"""Create a new elliptic cone surface

	Args:
		radius1 (float): Radius of the cone at origin on the X axis
		radius2 (float): Radius of the cone at origin on the Y axis
		semiAngle (float): Semi-angle of the cone (in rad)
		matrix (list[list[float]]): Positionning matrix of the cone

	Returns:
		ellipticConeSurface (int): The new elliptic cone surface
	"""
	...

def createNURBSSurface(degreeU: int, degreeV: int, knotsU: list[float], knotsV: list[float], poles: list[geom.Point3], weights: list[float] = list[float]()) -> int:
	"""Create a new NURBS surface

	Args:
		degreeU (int): U degree
		degreeV (int): V degree
		knotsU (list[float]): Knots on U
		knotsV (list[float]): Knots on V
		poles (list[geom.Point3]): Poles list
		weights (list[float]): Weights list

	Returns:
		NURBSSurface (int): The new NURBS surface
	"""
	...

def createOffsetSurface(baseSurface: int, distance: float) -> int:
	"""Create a new offset surface

	Args:
		baseSurface (int): The base surface
		distance (float): The offset distance

	Returns:
		offsetSurface (int): The new offset surface
	"""
	...

def createPlaneSurface(matrix: list[list[float]] = geom.IdentityMatrix4) -> int:
	"""Create a new plane surface

	Args:
		matrix (list[list[float]]): Positionning matrix of the plane

	Returns:
		planeSurface (int): The new plane surface
	"""
	...

def createRevolutionSurface(generatrixCurve: int, axisOrigin: geom.Point3, axisDirection: geom.Point3, startParam: float = 0, endParam: float = Core.TwoPi) -> int:
	"""Create a new revolution surface

	Args:
		generatrixCurve (int): Generatrix curve rotated to create the revolution surface
		axisOrigin (geom.Point3): Axis origin point
		axisDirection (geom.Point3): Axis direction vector
		startParam (float): Start angle of the revolution surface (in rad)
		endParam (float): End angle of the revolution surface (in rad)

	Returns:
		revolutionSurface (int): Revolution surface generated by rotating the given curve around the axis
	"""
	...

def createRuledSurface(firstCurve: int, secondCurve: int) -> int:
	"""Create a new ruled surface

	Args:
		firstCurve (int): First Curve
		secondCurve (int): Seconde Curve

	Returns:
		ruledSurface (int): The new ruled surface
	"""
	...

def createSphereSurface(radius: float, matrix: list[list[float]] = geom.IdentityMatrix4) -> int:
	"""Create a new sphere surface

	Args:
		radius (float): Radius of the sphere
		matrix (list[list[float]]): Positionning matrix of the sphere

	Returns:
		sphereSurface (int): The new sphere surface
	"""
	...

def createTabulatedCylinderSurface(directrixCurve: int, GeneratixLine: geom.Point3, minRange: float, maxRange: float) -> int:
	"""Create a new tabulated cylinder surface

	Args:
		directrixCurve (int): Directrix Curve
		GeneratixLine (geom.Point3): Generatrix Line
		minRange (float): Minimimum value of the range
		maxRange (float): Maximum value of the range

	Returns:
		tabulatedCylinderSurface (int): The new tabulated cylinder surface
	"""
	...

def createTorusSurface(radiusMax: float, radiusMin: float, matrix: list[list[float]] = geom.IdentityMatrix4) -> int:
	"""Create a new torus surface

	Args:
		radiusMax (float): Major radius 
		radiusMin (float): Minor radius 
		matrix (list[list[float]]): Positionning matrix of the sphere

	Returns:
		torusSurface (int): The new torus surface
	"""
	...

def needPrecisionArea(surface: int) -> bool:
	"""tells if it needs a working area on the surface

	Args:
		surface (int): Surface to check if it needs precision area

	Returns:
		need (bool): Result
	"""
	...

# Callbacks
