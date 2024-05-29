// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_RAYTRACE_INTERFACE_RAYTRACETYPES_H_
#define _PXZ_RAYTRACE_INTERFACE_RAYTRACETYPES_H_

#include <PiXYZCore/interface/InterfaceBase.h>
#include <PiXYZCAD/interface/CADTypes.h>
#include <PiXYZCore/interface/CoreTypes.h>
#include <PiXYZGeom/interface/GeomTypes.h>
#include <PiXYZPolygonal/interface/PolygonalTypes.h>
#include <PiXYZScene/interface/SceneTypes.h>
#include <functional> 

PXZ_MODULE_BEGIN(RaytraceI)

struct Camera {
   GeomI::Point3 position;
   GeomI::Vector3 direction;
   GeomI::Vector3 up;
   CoreI::Double fov;
   Camera(GeomI::Point3 _position = GeomI::Point3(), GeomI::Vector3 _direction = GeomI::Vector3(), GeomI::Vector3 _up = GeomI::Vector3(), CoreI::Double _fov = 60) : position(_position), direction(_direction), up(_up), fov(_fov) {}
};


PXZ_MODULE_END

#endif
