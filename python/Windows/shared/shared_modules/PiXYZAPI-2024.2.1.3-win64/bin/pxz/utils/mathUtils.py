from pxz import *
from math import *


def pointAdd(pt1: geom.Point3, pt2: geom.Point3) -> geom.Point3:
    return geom.Point3(pt1.x + pt2.x, pt1.y + pt2.y, pt1.z + pt2.z)


def pointSub(pt1: geom.Point3, pt2: geom.Point3) -> geom.Point3:
    return geom.Point3(pt1.x - pt2.x, pt1.y - pt2.y, pt1.z - pt2.z)


def dotProduct(pt1: geom.Point3, pt2: geom.Point3) -> float:
    return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z


def crossProduct(pt1: geom.Point3, pt2: geom.Point3) -> geom.Point3:
    return geom.Point3(pt1.y * pt2.z - pt1.z * pt2.y, pt1.z * pt2.x - pt1.x * pt2.z, pt1.x * pt2.y - pt1.y * pt2.x)


def vectorLength(v: geom.Point3) -> float:
    return sqrt(dotProduct(v, v))


def aabbDiagLength(aabb: geom.AABB) -> float:
    return vectorLength(pointSub(aabb.high, aabb.low))


def center(pt1: geom.Point3, pt2: geom.Point3) -> geom.Point3:
    return geom.Point3((pt1.x + pt2.x) / 2, (pt1.y + pt2.y) / 2, (pt1.z + pt2.z) / 2)


def normalize(v: geom.Point3) -> geom.Point3:
    l = vectorLength(v)
    return geom.Point3(v.x / l, v.y / l, v.z / l)


def pointInAABB(aabb: geom.AABB, pt: geom.Point3) -> bool:
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
