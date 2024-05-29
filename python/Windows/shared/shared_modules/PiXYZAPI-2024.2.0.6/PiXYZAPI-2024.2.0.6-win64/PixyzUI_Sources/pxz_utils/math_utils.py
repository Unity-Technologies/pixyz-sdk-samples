from pxz import *
from math import *


def point_add(pt1: geom.Point3, pt2: geom.Point3) -> geom.Point3:
    return geom.Point3(pt1.x + pt2.x, pt1.y + pt2.y, pt1.z + pt2.z)


def point_sub(pt1: geom.Point3, pt2: geom.Point3) -> geom.Point3:
    return geom.Point3(pt1.x - pt2.x, pt1.y - pt2.y, pt1.z - pt2.z)


def dot_product(pt1: geom.Point3, pt2: geom.Point3) -> geom.Point3:
    return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z


def cross_product(pt1: geom.Point3, pt2: geom.Point3) -> geom.Point3:
    return geom.Point3(pt1.y * pt2.z - pt1.z * pt2.y, pt1.z * pt2.x - pt1.x * pt2.z, pt1.x * pt2.y - pt1.y * pt2.x)


def vector_length(v: geom.Point3) -> float:
    return sqrt(dot_product(v, v))


def aabb_diag_length(aabb: geom.AABB) -> float:
    return vector_length(point_sub(aabb.high, aabb.low))


def center(pt1: geom.Point3, pt2: geom.Point3) -> geom.Point3:
    return geom.Point3((pt1.x + pt2.x) / 2, (pt1.y + pt2.y) / 2, (pt1.z + pt2.z) / 2)


def normalize(v: geom.Point3) -> geom.Point3:
    l = vector_length(v)
    return geom.Point3(v.x / l, v.y / l, v.z / l)


def point_in_aabb(aabb: geom.AABB, pt: geom.Point3) -> bool:
    if pt.x < aabb.low.x:
        return False
    if pt.y < aabb.low.y:
        return False
    if pt.z < aabb.low.z:
        return False
    if pt.x > aabb.high.x:
        return False
    if pt.y > aabb.high.y:
        return False
    if pt.z > aabb.high.z:
        return False
    return True
