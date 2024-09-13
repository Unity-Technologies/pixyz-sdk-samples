from enum import Enum
from collections.abc import Callable

from pxz import core

# Constants
IdentityMatrix4: [[1,0,0,0],[0,1,0,0],[0,0,1,0],[0,0,0,1]]
YupToZupMatrix4: [[1,0,0,0],[0,0,-1,0],[0,1,0,0],[0,0,0,1]]
ZupToYupMatrix4: [[1,0,0,0],[0,0,1,0],[0,-1,0,0],[0,0,0,1]]

# Classes
class AABB:
	"""AABB stands for Axis Aligned Bounding Box. It is a bounding volume which is aligned with the axes of the coordinates system
	"""
	low: Point3
	high: Point3
	def __init__(self, low: Point3, high: Point3) -> None: ...
	...

class AABR:
	"""AABR stands for Axis Aligned Bounding Rectangle. It is a bounding surface which is aligned with the axes of the coordinates system
	"""
	low: Point2
	high: Point2
	def __init__(self, low: Point2, high: Point2) -> None: ...
	...

class Affine:
	"""Affine transformation
	"""
	origin: Point3
	xAxis: Point3
	yAxis: Point3
	zAxis: Point3
	def __init__(self, origin: Point3, xAxis: Point3, yAxis: Point3, zAxis: Point3) -> None: ...
	...

class Axis(Enum):
	"""
	"""
	X: int
	Y: int
	Z: int
	...

class AxisPlane(Enum):
	"""
	"""
	YZ: int
	ZX: int
	XY: int
	...

class CameraCalibration:
	"""Calibration of a pinhole camera (intrisic+distortion parameters)
	"""
	radial1: float
	radial2: float
	radial3: float
	tangential1: float
	tangential2: float
	focalX: float
	focalY: float
	centerX: float
	centerY: float
	skew: float
	def __init__(self, radial1: float, radial2: float, radial3: float, tangential1: float, tangential2: float, focalX: float, focalY: float, centerX: float, centerY: float, skew: float) -> None: ...
	...

class Curvatures:
	"""
	"""
	k1: float
	k2: float
	v1: Point3
	v2: Point3
	def __init__(self, k1: float, k2: float, v1: Point3, v2: Point3) -> None: ...
	...

class ExtendedBox:
	"""A box defined by a location and extension sizes
	"""
	position: Point3
	extentX: float
	extentY: float
	extentZ: float
	def __init__(self, position: Point3, extentX: float, extentY: float, extentZ: float) -> None: ...
	...

class OBB:
	"""OBB stands for Oriented Bounding Box
	"""
	corner: Point3
	xAxis: Point3
	yAxis: Point3
	zAxis: Point3
	def __init__(self, corner: Point3, xAxis: Point3, yAxis: Point3, zAxis: Point3) -> None: ...
	...

class Point2:
	"""A Point2 defines a position in 2D space
	"""
	x: float
	y: float
	def __init__(self, x: float, y: float) -> None: ...
	...

class Point3:
	"""A Point3 defines a position in 3D space
	"""
	x: float
	y: float
	z: float
	def __init__(self, x: float, y: float, z: float) -> None: ...
	...

class Point4:
	"""A Point4 defines a position in 3D space
	"""
	x: float
	y: float
	z: float
	w: float
	def __init__(self, x: float, y: float, z: float, w: float) -> None: ...
	...

class Ray:
	"""
	"""
	origin: Point3
	direction: Point3
	def __init__(self, origin: Point3, direction: Point3) -> None: ...
	...

class Vector4I:
	"""A Vector4 has 4 int components
	"""
	x: int
	y: int
	z: int
	w: int
	def __init__(self, x: int, y: int, z: int, w: int) -> None: ...
	...

# Functions
def applyTransform(entity: int, matrix: list[list[float]]) -> None:
	"""Apply a transformation matrix to a geometrical entity

	Args:
		entity (int): The geometric entity
		matrix (list[list[float]]): The transformation matrix
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

def getEntityAABB(entity: int) -> AABB:
	"""Retrieve the Axis-Aligned Bounded Box of a geometric entity

	Args:
		entity (int): The geometric entity

	Returns:
		aabb (AABB): The axis aligned bounded box
	"""
	...

def changeOfBasisMatrix(origin: Point3, x: Point3, y: Point3, z: Point3) -> list[list[float]]:
	"""Construct a Change of Basis Matrix (e.g multiplying the point [0,0,0] will result to the point origin)

	Args:
		origin (Point3): Origin of the new basis
		x (Point3): X axis of the new basis
		y (Point3): Y axis of the new basis
		z (Point3): Z axis of the new basis

	Returns:
		changeOfBasis (list[list[float]]): The change of basis matrix
	"""
	...

def fromAffine(affine: Affine) -> list[list[float]]:
	"""Create a Matrix from an Affine

	Args:
		affine (Affine): The affine

	Returns:
		matrix (list[list[float]]): The created Matrix
	"""
	...

def fromLookAtMatrix(matrix: list[list[float]], distanceFromTarget: float = 1) -> dict:
	"""Get camera position, up and target vectors

	Args:
		matrix (list[list[float]]): The created Matrix
		distanceFromTarget (float): 

	Returns:
		position (Point3): The camera position
		up (Point3): The up vector
		target (Point3): The target position
	"""
	...

def fromOriginNormal(origin: Point3, normal: Point3) -> list[list[float]]:
	"""Create a Matrix from an origin and a normal vector

	Args:
		origin (Point3): The origin point
		normal (Point3): The normal vector

	Returns:
		matrix (list[list[float]]): The created Matrix
	"""
	...

def fromTRS(T: Point3, R: Point3, S: Point3) -> list[list[float]]:
	"""Create a Matrix from translation, rotation and scaling vectors

	Args:
		T (Point3): The translation vector
		R (Point3): The rotations vector
		S (Point3): The scaling vector

	Returns:
		matrix (list[list[float]]): The created Matrix
	"""
	...

def getMaxScale(matrix: list[list[float]]) -> float:
	"""Get maximum matrix scale

	Args:
		matrix (list[list[float]]): 

	Returns:
		scale (float): Max scale value
	"""
	...

def invertMatrix(matrix: list[list[float]]) -> list[list[float]]:
	"""Invert a matrix

	Args:
		matrix (list[list[float]]): The matrix to invert

	Returns:
		inverted (list[list[float]]): The inverted matrix
	"""
	...

def lookAtMatrix(position: Point3, up: Point3, target: Point3) -> list[list[float]]:
	"""Create a matrix from a camera position, up and target

	Args:
		position (Point3): The camera position
		up (Point3): The up vector
		target (Point3): The target position

	Returns:
		matrix (list[list[float]]): The created matrix
	"""
	...

def multiplyMatrices(left: list[list[float]], right: list[list[float]]) -> list[list[float]]:
	"""Multiply two matrices, returns left*right

	Args:
		left (list[list[float]]): Left side matrix
		right (list[list[float]]): Right side matrix

	Returns:
		result (list[list[float]]): Result of the matrices multiplication
	"""
	...

def multiplyMatrixPoint(matrix: list[list[float]], point: Point3) -> Point3:
	"""Multiply a point by a matrix (i.e apply the matrix to a point)

	Args:
		matrix (list[list[float]]): The matrix to apply
		point (Point3): The point to multiply

	Returns:
		result (Point3): The resulting point
	"""
	...

def multiplyMatrixVector(matrix: list[list[float]], vector: Point3) -> Point3:
	"""Multiply a vector by a matrix (i.e apply the matrix to a vector)

	Args:
		matrix (list[list[float]]): The matrix to apply
		vector (Point3): The vector to multiply

	Returns:
		result (Point3): The resulting point
	"""
	...

def orthographicMatrix(width3D: float, height3D: float, nearClipDistance: float, farClipDistance: float) -> list[list[float]]:
	"""Create an orthographic matrix from a 3D width, a 3D height, a near, and a far clipping distance

	Args:
		width3D (float): The 3D width to consider
		height3D (float): The 3D height to consider
		nearClipDistance (float): The near clipping distance
		farClipDistance (float): The far clipping distance

	Returns:
		matrix (list[list[float]]): The created matrix
	"""
	...

def perspectiveMatrix(fovX: float, aspectRatio: float, nearClipDistance: float, farClipDistance: float) -> list[list[float]]:
	"""Create a perspective matrix from a fovX, an aspect ratio, a near, and a far clipping distance

	Args:
		fovX (float): The field of view on the x axis
		aspectRatio (float): The aspect ratio foxX/fovY
		nearClipDistance (float): The near clipping distance
		farClipDistance (float): The far clipping distance

	Returns:
		matrix (list[list[float]]): The created matrix
	"""
	...

def toTRS(matrix: list[list[float]]) -> list[Point3]:
	"""Decompose a Matrix into translation, rotation and scaling vectors

	Args:
		matrix (list[list[float]]): The Matrix to be decomposed

	Returns:
		TRS (list[Point3]): The TRS list
	"""
	...

# Callbacks
