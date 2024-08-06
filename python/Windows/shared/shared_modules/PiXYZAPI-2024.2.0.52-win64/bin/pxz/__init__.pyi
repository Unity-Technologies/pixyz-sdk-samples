from . import algo
from . import cad
from . import core
from . import geom
from . import io
from . import material
from . import polygonal
from . import raytrace
from . import scene
from . import unity
from . import view

__all__ = ["algo", "cad", "core", "geom", "io", "material", "polygonal", "raytrace", "scene", "unity", "view"]

def initialize(productName: str = ..., validationKey: str = ..., license: str = ...):
	"""Initialize Pixyz Python module with a new Pixyz session
	"""
	...

def release():
	"""Clear the session and release Pixyz Python module
	"""
	...
