// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_GEOM_INTERFACE_GEOMTYPES_H_
#define _PXZ_GEOM_INTERFACE_GEOMTYPES_H_

#include <PiXYZCore/interface/InterfaceBase.h>
#include <PiXYZCore/interface/CoreTypes.h>
#include <functional> 

PXZ_MODULE_BEGIN(GeomI)

struct Point3 {
   CoreI::Double x;
   CoreI::Double y;
   CoreI::Double z;
   explicit Point3(CoreI::Double _x = 0, CoreI::Double _y = 0, CoreI::Double _z = 0) : x(_x), y(_y), z(_z) {}
};

struct AABB {
   Point3 low;
   Point3 high;
   explicit AABB(Point3 _low = Point3(), Point3 _high = Point3()) : low(_low), high(_high) {}
};

struct Point2 {
   CoreI::Double x;
   CoreI::Double y;
   explicit Point2(CoreI::Double _x = 0, CoreI::Double _y = 0) : x(_x), y(_y) {}
};

struct AABR {
   Point2 low;
   Point2 high;
   explicit AABR(Point2 _low = Point2(), Point2 _high = Point2()) : low(_low), high(_high) {}
};

typedef Point3 Vector3;

struct Affine {
   Point3 origin;
   Vector3 xAxis;
   Vector3 yAxis;
   Vector3 zAxis;
   explicit Affine(Point3 _origin = Point3(), Vector3 _xAxis = Vector3(), Vector3 _yAxis = Vector3(), Vector3 _zAxis = Vector3()) : origin(_origin), xAxis(_xAxis), yAxis(_yAxis), zAxis(_zAxis) {}
};

typedef CoreI::Double Angle;

typedef CoreI::Double Area;

typedef CoreI::Array<CoreI::Double, 3> Array3;

typedef CoreI::Array<CoreI::Double, 4> Array4;

class Axis {
public:
   typedef enum {
   X = 0,
   Y = 1,
   Z = 2
   } Type;
private:
   Type _value;
public:
   Axis(Type val = X) : _value(val) {}
   Axis & operator=(Type val) { _value = val; return *this; }
   Axis(const CoreI::Int& val) : _value((Type)val) {}
   Axis & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class AxisPlane {
public:
   typedef enum {
   YZ = 0,
   ZX = 1,
   XY = 2
   } Type;
private:
   Type _value;
public:
   AxisPlane(Type val = YZ) : _value(val) {}
   AxisPlane & operator=(Type val) { _value = val; return *this; }
   AxisPlane(const CoreI::Int& val) : _value((Type)val) {}
   AxisPlane & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct CameraCalibration {
   CoreI::Double radial1;
   CoreI::Double radial2;
   CoreI::Double radial3;
   CoreI::Double tangential1;
   CoreI::Double tangential2;
   CoreI::Double focalX;
   CoreI::Double focalY;
   CoreI::Double centerX;
   CoreI::Double centerY;
   CoreI::Double skew;
   explicit CameraCalibration(CoreI::Double _radial1 = 0, CoreI::Double _radial2 = 0, CoreI::Double _radial3 = 0, CoreI::Double _tangential1 = 0, CoreI::Double _tangential2 = 0, CoreI::Double _focalX = 1, CoreI::Double _focalY = 1, CoreI::Double _centerX = 0, CoreI::Double _centerY = 0, CoreI::Double _skew = 0) : radial1(_radial1), radial2(_radial2), radial3(_radial3), tangential1(_tangential1), tangential2(_tangential2), focalX(_focalX), focalY(_focalY), centerX(_centerX), centerY(_centerY), skew(_skew) {}
};

struct Curvatures {
   CoreI::Double k1;
   CoreI::Double k2;
   Vector3 v1;
   Vector3 v2;
   explicit Curvatures(CoreI::Double _k1 = 0, CoreI::Double _k2 = 0, Vector3 _v1 = Vector3(), Vector3 _v2 = Vector3()) : k1(_k1), k2(_k2), v1(_v1), v2(_v2) {}
};

typedef CoreI::List<Curvatures> CurvaturesList;

typedef CoreI::Double Distance;

typedef CoreI::List<Distance> DistanceList;

struct ExtendedBox {
   Point3 position;
   Distance extentX;
   Distance extentY;
   Distance extentZ;
   explicit ExtendedBox(Point3 _position = Point3(), Distance _extentX = 1, Distance _extentY = 1, Distance _extentZ = 1) : position(_position), extentX(_extentX), extentY(_extentY), extentZ(_extentZ) {}
};

typedef CoreI::Entity GeomEntity;

PXZ_EXPORTED extern const CoreI::EntityType GeomEntityEntityType;

struct OBB {
   Point3 corner;
   Vector3 xAxis;
   Vector3 yAxis;
   Vector3 zAxis;
   explicit OBB(Point3 _corner = Point3(), Vector3 _xAxis = Vector3(), Vector3 _yAxis = Vector3(), Vector3 _zAxis = Vector3()) : corner(_corner), xAxis(_xAxis), yAxis(_yAxis), zAxis(_zAxis) {}
};

typedef OBB MBB;

typedef CoreI::Array<Array3, 3> Matrix3;

typedef CoreI::Array<Array4, 4> Matrix4;

typedef CoreI::List<Matrix4> Matrix4List;

typedef CoreI::List<Matrix4List> Matrix4ListList;

typedef CoreI::Boolean Orientation;

typedef CoreI::List<Orientation> OrientationList;

typedef CoreI::List<Point2> Point2List;

typedef CoreI::List<Point2List> Point2ListList;

typedef CoreI::List<Point3> Point3List;

typedef CoreI::List<Point3List> Point3ListList;

struct Point4 {
   CoreI::Double x;
   CoreI::Double y;
   CoreI::Double z;
   CoreI::Double w;
   explicit Point4(CoreI::Double _x = 0, CoreI::Double _y = 0, CoreI::Double _z = 0, CoreI::Double _w = 0) : x(_x), y(_y), z(_z), w(_w) {}
};

typedef CoreI::List<Point4> Point4List;

struct Ray {
   Point3 origin;
   Vector3 direction;
   explicit Ray(Point3 _origin = Point3(), Vector3 _direction = Vector3()) : origin(_origin), direction(_direction) {}
};

typedef Point2 Vector2;

typedef CoreI::List<Vector3> Vector3List;

typedef Point4 Vector4;

struct Vector4I {
   CoreI::Int x;
   CoreI::Int y;
   CoreI::Int z;
   CoreI::Int w;
   explicit Vector4I(CoreI::Int _x = 0, CoreI::Int _y = 0, CoreI::Int _z = 0, CoreI::Int _w = 0) : x(_x), y(_y), z(_z), w(_w) {}
};

typedef CoreI::List<Vector4I> Vector4IList;

typedef CoreI::List<Vector4> Vector4List;

typedef CoreI::Double Volume;

typedef struct {
   Point3 position;
   Vector3 up;
   Point3 target;
} fromLookAtMatrixReturn;

// ----------------------------------------------------
// Constants
// ----------------------------------------------------

inline Matrix4 IdentityMatrix4() { return Matrix4().set(0, Array4().set(0, 1).set(1, 0).set(2, 0).set(3, 0)).set(1, Array4().set(0, 0).set(1, 1).set(2, 0).set(3, 0)).set(2, Array4().set(0, 0).set(1, 0).set(2, 1).set(3, 0)).set(3, Array4().set(0, 0).set(1, 0).set(2, 0).set(3, 1)); }
inline Matrix4 YupToZupMatrix4() { return Matrix4().set(0, Array4().set(0, 1).set(1, 0).set(2, 0).set(3, 0)).set(1, Array4().set(0, 0).set(1, 0).set(2, -1).set(3, 0)).set(2, Array4().set(0, 0).set(1, 1).set(2, 0).set(3, 0)).set(3, Array4().set(0, 0).set(1, 0).set(2, 0).set(3, 1)); }
inline Matrix4 ZupToYupMatrix4() { return Matrix4().set(0, Array4().set(0, 1).set(1, 0).set(2, 0).set(3, 0)).set(1, Array4().set(0, 0).set(1, 0).set(2, 1).set(3, 0)).set(2, Array4().set(0, 0).set(1, -1).set(2, 0).set(3, 0)).set(3, Array4().set(0, 0).set(1, 0).set(2, 0).set(3, 1)); }

PXZ_MODULE_END

#endif
