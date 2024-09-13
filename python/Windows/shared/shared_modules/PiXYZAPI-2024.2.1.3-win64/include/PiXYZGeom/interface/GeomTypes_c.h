// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_GEOM_INTERFACE_GEOMTYPES_C_H_
#define _PXZ_GEOM_INTERFACE_GEOMTYPES_C_H_

#include <string.h>
#include <PiXYZCore/interface/InterfaceBase_c.h>
#include <PiXYZCore/interface/CoreTypes_c.h>


typedef struct {
   Core_Double x;
   Core_Double y;
   Core_Double z;
} Geom_Point3;

PXZ_EXPORTED void Geom_Point3_init(Geom_Point3 * str);
PXZ_EXPORTED void Geom_Point3_free(Geom_Point3 * str);
typedef struct {
   Geom_Point3 low;
   Geom_Point3 high;
} Geom_AABB;

PXZ_EXPORTED void Geom_AABB_init(Geom_AABB * str);
PXZ_EXPORTED void Geom_AABB_free(Geom_AABB * str);
typedef struct {
   Core_Double x;
   Core_Double y;
} Geom_Point2;

PXZ_EXPORTED void Geom_Point2_init(Geom_Point2 * str);
PXZ_EXPORTED void Geom_Point2_free(Geom_Point2 * str);
typedef struct {
   Geom_Point2 low;
   Geom_Point2 high;
} Geom_AABR;

PXZ_EXPORTED void Geom_AABR_init(Geom_AABR * str);
PXZ_EXPORTED void Geom_AABR_free(Geom_AABR * str);
typedef Geom_Point3 Geom_Vector3;

typedef struct {
   Geom_Point3 origin;
   Geom_Vector3 xAxis;
   Geom_Vector3 yAxis;
   Geom_Vector3 zAxis;
} Geom_Affine;

PXZ_EXPORTED void Geom_Affine_init(Geom_Affine * str);
PXZ_EXPORTED void Geom_Affine_free(Geom_Affine * str);
typedef Core_Double Geom_Angle;

typedef Core_Double Geom_Area;

typedef Core_Double * Geom_Array3;

PXZ_EXPORTED void Geom_Array3_init(Geom_Array3 * tab);
PXZ_EXPORTED void Geom_Array3_free(Geom_Array3 * tab);
typedef Core_Double * Geom_Array4;

PXZ_EXPORTED void Geom_Array4_init(Geom_Array4 * tab);
PXZ_EXPORTED void Geom_Array4_free(Geom_Array4 * tab);
typedef enum {
 Geom_Axis_X = 0,
 Geom_Axis_Y = 1,
 Geom_Axis_Z = 2,
} Geom_Axis;

typedef enum {
 Geom_AxisPlane_YZ = 0,
 Geom_AxisPlane_ZX = 1,
 Geom_AxisPlane_XY = 2,
} Geom_AxisPlane;

typedef struct {
   Core_Double radial1;
   Core_Double radial2;
   Core_Double radial3;
   Core_Double tangential1;
   Core_Double tangential2;
   Core_Double focalX;
   Core_Double focalY;
   Core_Double centerX;
   Core_Double centerY;
   Core_Double skew;
} Geom_CameraCalibration;

PXZ_EXPORTED void Geom_CameraCalibration_init(Geom_CameraCalibration * str);
PXZ_EXPORTED void Geom_CameraCalibration_free(Geom_CameraCalibration * str);
typedef struct {
   Core_Double k1;
   Core_Double k2;
   Geom_Vector3 v1;
   Geom_Vector3 v2;
} Geom_Curvatures;

PXZ_EXPORTED void Geom_Curvatures_init(Geom_Curvatures * str);
PXZ_EXPORTED void Geom_Curvatures_free(Geom_Curvatures * str);
typedef struct {
   size_t size;
   Geom_Curvatures * list;
} Geom_CurvaturesList;

PXZ_EXPORTED void Geom_CurvaturesList_init(Geom_CurvaturesList * list, size_t size = 0);
PXZ_EXPORTED void Geom_CurvaturesList_free(Geom_CurvaturesList * list);
typedef Core_Double Geom_Distance;

typedef struct {
   size_t size;
   Geom_Distance * list;
} Geom_DistanceList;

PXZ_EXPORTED void Geom_DistanceList_init(Geom_DistanceList * list, size_t size = 0);
PXZ_EXPORTED void Geom_DistanceList_free(Geom_DistanceList * list);
typedef struct {
   Geom_Point3 position;
   Geom_Distance extentX;
   Geom_Distance extentY;
   Geom_Distance extentZ;
} Geom_ExtendedBox;

PXZ_EXPORTED void Geom_ExtendedBox_init(Geom_ExtendedBox * str);
PXZ_EXPORTED void Geom_ExtendedBox_free(Geom_ExtendedBox * str);
typedef Core_Entity Geom_GeomEntity;

typedef struct {
   Geom_Point3 corner;
   Geom_Vector3 xAxis;
   Geom_Vector3 yAxis;
   Geom_Vector3 zAxis;
} Geom_OBB;

PXZ_EXPORTED void Geom_OBB_init(Geom_OBB * str);
PXZ_EXPORTED void Geom_OBB_free(Geom_OBB * str);
typedef Geom_OBB Geom_MBB;

typedef Geom_Array3 * Geom_Matrix3;

PXZ_EXPORTED void Geom_Matrix3_init(Geom_Matrix3 * tab);
PXZ_EXPORTED void Geom_Matrix3_free(Geom_Matrix3 * tab);
typedef Geom_Array4 * Geom_Matrix4;

PXZ_EXPORTED void Geom_Matrix4_init(Geom_Matrix4 * tab);
PXZ_EXPORTED void Geom_Matrix4_free(Geom_Matrix4 * tab);
typedef struct {
   size_t size;
   Geom_Matrix4 * list;
} Geom_Matrix4List;

PXZ_EXPORTED void Geom_Matrix4List_init(Geom_Matrix4List * list, size_t size = 0);
PXZ_EXPORTED void Geom_Matrix4List_free(Geom_Matrix4List * list);
typedef struct {
   size_t size;
   Geom_Matrix4List * list;
} Geom_Matrix4ListList;

PXZ_EXPORTED void Geom_Matrix4ListList_init(Geom_Matrix4ListList * list, size_t size = 0);
PXZ_EXPORTED void Geom_Matrix4ListList_free(Geom_Matrix4ListList * list);
typedef Core_Boolean Geom_Orientation;

typedef struct {
   size_t size;
   Geom_Orientation * list;
} Geom_OrientationList;

PXZ_EXPORTED void Geom_OrientationList_init(Geom_OrientationList * list, size_t size = 0);
PXZ_EXPORTED void Geom_OrientationList_free(Geom_OrientationList * list);
typedef struct {
   size_t size;
   Geom_Point2 * list;
} Geom_Point2List;

PXZ_EXPORTED void Geom_Point2List_init(Geom_Point2List * list, size_t size = 0);
PXZ_EXPORTED void Geom_Point2List_free(Geom_Point2List * list);
typedef struct {
   size_t size;
   Geom_Point2List * list;
} Geom_Point2ListList;

PXZ_EXPORTED void Geom_Point2ListList_init(Geom_Point2ListList * list, size_t size = 0);
PXZ_EXPORTED void Geom_Point2ListList_free(Geom_Point2ListList * list);
typedef struct {
   size_t size;
   Geom_Point3 * list;
} Geom_Point3List;

PXZ_EXPORTED void Geom_Point3List_init(Geom_Point3List * list, size_t size = 0);
PXZ_EXPORTED void Geom_Point3List_free(Geom_Point3List * list);
typedef struct {
   size_t size;
   Geom_Point3List * list;
} Geom_Point3ListList;

PXZ_EXPORTED void Geom_Point3ListList_init(Geom_Point3ListList * list, size_t size = 0);
PXZ_EXPORTED void Geom_Point3ListList_free(Geom_Point3ListList * list);
typedef struct {
   Core_Double x;
   Core_Double y;
   Core_Double z;
   Core_Double w;
} Geom_Point4;

PXZ_EXPORTED void Geom_Point4_init(Geom_Point4 * str);
PXZ_EXPORTED void Geom_Point4_free(Geom_Point4 * str);
typedef struct {
   size_t size;
   Geom_Point4 * list;
} Geom_Point4List;

PXZ_EXPORTED void Geom_Point4List_init(Geom_Point4List * list, size_t size = 0);
PXZ_EXPORTED void Geom_Point4List_free(Geom_Point4List * list);
typedef struct {
   Geom_Point3 origin;
   Geom_Vector3 direction;
} Geom_Ray;

PXZ_EXPORTED void Geom_Ray_init(Geom_Ray * str);
PXZ_EXPORTED void Geom_Ray_free(Geom_Ray * str);
typedef Geom_Point2 Geom_Vector2;

typedef struct {
   size_t size;
   Geom_Vector3 * list;
} Geom_Vector3List;

PXZ_EXPORTED void Geom_Vector3List_init(Geom_Vector3List * list, size_t size = 0);
PXZ_EXPORTED void Geom_Vector3List_free(Geom_Vector3List * list);
typedef Geom_Point4 Geom_Vector4;

typedef struct {
   Core_Int x;
   Core_Int y;
   Core_Int z;
   Core_Int w;
} Geom_Vector4I;

PXZ_EXPORTED void Geom_Vector4I_init(Geom_Vector4I * str);
PXZ_EXPORTED void Geom_Vector4I_free(Geom_Vector4I * str);
typedef struct {
   size_t size;
   Geom_Vector4I * list;
} Geom_Vector4IList;

PXZ_EXPORTED void Geom_Vector4IList_init(Geom_Vector4IList * list, size_t size = 0);
PXZ_EXPORTED void Geom_Vector4IList_free(Geom_Vector4IList * list);
typedef struct {
   size_t size;
   Geom_Vector4 * list;
} Geom_Vector4List;

PXZ_EXPORTED void Geom_Vector4List_init(Geom_Vector4List * list, size_t size = 0);
PXZ_EXPORTED void Geom_Vector4List_free(Geom_Vector4List * list);
typedef Core_Double Geom_Volume;

// ----------------------------------------------------
// Constants
// ----------------------------------------------------

inline Geom_Matrix4 * IdentityMatrix4() { return 0; }
inline Geom_Matrix4 * YupToZupMatrix4() { return 0; }
inline Geom_Matrix4 * ZupToYupMatrix4() { return 0; }


#endif
