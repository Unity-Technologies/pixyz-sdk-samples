// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_RAYTRACE_INTERFACE_RAYTRACETYPES_C_H_
#define _PXZ_RAYTRACE_INTERFACE_RAYTRACETYPES_C_H_

#include <string.h>
#include <PiXYZCore/interface/InterfaceBase_c.h>
#include <PiXYZCAD/interface/CADTypes_c.h>
#include <PiXYZCore/interface/CoreTypes_c.h>
#include <PiXYZGeom/interface/GeomTypes_c.h>
#include <PiXYZPolygonal/interface/PolygonalTypes_c.h>
#include <PiXYZScene/interface/SceneTypes_c.h>


typedef struct {
   Geom_Point3 position;
   Geom_Vector3 direction;
   Geom_Vector3 up;
   Core_Double fov;
} Raytrace_Camera;

PXZ_EXPORTED void Raytrace_Camera_init(Raytrace_Camera * str);
PXZ_EXPORTED void Raytrace_Camera_free(Raytrace_Camera * str);


#endif
