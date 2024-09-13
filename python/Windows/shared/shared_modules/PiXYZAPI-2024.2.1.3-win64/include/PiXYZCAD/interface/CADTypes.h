// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_CAD_INTERFACE_CADTYPES_H_
#define _PXZ_CAD_INTERFACE_CADTYPES_H_

#include <PiXYZCore/interface/InterfaceBase.h>
#include <PiXYZCore/interface/CoreTypes.h>
#include <PiXYZGeom/interface/GeomTypes.h>
#include <PiXYZMaterial/interface/MaterialTypes.h>
#include <functional> 

PXZ_MODULE_BEGIN(CADI)

typedef GeomI::GeomEntity CADEntity;

PXZ_EXPORTED extern const CoreI::EntityType CADEntityEntityType;

typedef CADEntity Shape;

PXZ_EXPORTED extern const CoreI::EntityType ShapeEntityType;

typedef Shape Body;

PXZ_EXPORTED extern const CoreI::EntityType BodyEntityType;

typedef CoreI::List<Body> BodyList;

struct Bounds1D {
   CoreI::Double min;
   CoreI::Double max;
   explicit Bounds1D(CoreI::Double _min = 1, CoreI::Double _max = -1) : min(_min), max(_max) {}
};

struct Bounds2D {
   Bounds1D u;
   Bounds1D v;
   explicit Bounds2D(Bounds1D _u = Bounds1D(), Bounds1D _v = Bounds1D()) : u(_u), v(_v) {}
};

class BrickType {
public:
   typedef enum {
   Rectangle = 0,
   CornerLeft = 1,
   CornerRight = 2
   } Type;
private:
   Type _value;
public:
   BrickType(Type val = Rectangle) : _value(val) {}
   BrickType & operator=(Type val) { _value = val; return *this; }
   BrickType(const CoreI::Int& val) : _value((Type)val) {}
   BrickType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct BrickDefinition {
   BrickType type;
   CoreI::Int length;
   CoreI::Int width;
   CoreI::Boolean fullHeight;
   explicit BrickDefinition(BrickType _type = BrickType::Rectangle, CoreI::Int _length = 1, CoreI::Int _width = 1, CoreI::Boolean _fullHeight = true) : type(_type), length(_length), width(_width), fullHeight(_fullHeight) {}
};

typedef CoreI::List<BrickDefinition> BrickDefinitionList;

typedef CADEntity Curve;

PXZ_EXPORTED extern const CoreI::EntityType CurveEntityType;

typedef Curve CircleCurve;

PXZ_EXPORTED extern const CoreI::EntityType CircleCurveEntityType;

typedef CADEntity ClosedShell;

PXZ_EXPORTED extern const CoreI::EntityType ClosedShellEntityType;

typedef CoreI::List<ClosedShell> ClosedShellList;

typedef CADEntity CoEdge;

PXZ_EXPORTED extern const CoreI::EntityType CoEdgeEntityType;

typedef CoreI::List<CoEdge> CoEdgeList;

typedef Curve CompositeCurve;

PXZ_EXPORTED extern const CoreI::EntityType CompositeCurveEntityType;

typedef CADEntity Surface;

PXZ_EXPORTED extern const CoreI::EntityType SurfaceEntityType;

typedef Surface ConeSurface;

PXZ_EXPORTED extern const CoreI::EntityType ConeSurfaceEntityType;

typedef Surface CurveExtrusionSurface;

PXZ_EXPORTED extern const CoreI::EntityType CurveExtrusionSurfaceEntityType;

typedef CoreI::List<Curve> CurveList;

typedef CoreI::List<CurveList> CurveListList;

typedef Surface CylinderSurface;

PXZ_EXPORTED extern const CoreI::EntityType CylinderSurfaceEntityType;

typedef Shape Edge;

PXZ_EXPORTED extern const CoreI::EntityType EdgeEntityType;

typedef CoreI::List<Edge> EdgeList;

typedef CoreI::List<EdgeList> EdgeListList;

typedef Curve EllipseCurve;

PXZ_EXPORTED extern const CoreI::EntityType EllipseCurveEntityType;

typedef Surface EllipticConeSurface;

PXZ_EXPORTED extern const CoreI::EntityType EllipticConeSurfaceEntityType;

class ExtrusionBoundaryType {
public:
   typedef enum {
   Full = 0,
   Hole = 1,
   Open = 2
   } Type;
private:
   Type _value;
public:
   ExtrusionBoundaryType(Type val = Full) : _value(val) {}
   ExtrusionBoundaryType & operator=(Type val) { _value = val; return *this; }
   ExtrusionBoundaryType(const CoreI::Int& val) : _value((Type)val) {}
   ExtrusionBoundaryType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
typedef Shape Face;

PXZ_EXPORTED extern const CoreI::EntityType FaceEntityType;

typedef CoreI::List<Face> FaceList;

typedef Curve HelixCurve;

PXZ_EXPORTED extern const CoreI::EntityType HelixCurveEntityType;

typedef Curve HermiteCurve;

PXZ_EXPORTED extern const CoreI::EntityType HermiteCurveEntityType;

typedef Curve HyperbolaCurve;

PXZ_EXPORTED extern const CoreI::EntityType HyperbolaCurveEntityType;

typedef Curve IntersectionCurve;

PXZ_EXPORTED extern const CoreI::EntityType IntersectionCurveEntityType;

typedef Curve LineCurve;

PXZ_EXPORTED extern const CoreI::EntityType LineCurveEntityType;

typedef CADEntity Loop;

PXZ_EXPORTED extern const CoreI::EntityType LoopEntityType;

typedef CoreI::List<Loop> LoopList;

typedef CADEntity Model;

PXZ_EXPORTED extern const CoreI::EntityType ModelEntityType;

typedef CoreI::List<Model> ModelList;

typedef Curve NURBSCurve;

PXZ_EXPORTED extern const CoreI::EntityType NURBSCurveEntityType;

typedef Surface NURBSSurface;

PXZ_EXPORTED extern const CoreI::EntityType NURBSSurfaceEntityType;

typedef Curve OffsetCurve;

PXZ_EXPORTED extern const CoreI::EntityType OffsetCurveEntityType;

typedef Surface OffsetSurface;

PXZ_EXPORTED extern const CoreI::EntityType OffsetSurfaceEntityType;

typedef Shape OpenShell;

PXZ_EXPORTED extern const CoreI::EntityType OpenShellEntityType;

typedef CoreI::List<OpenShell> OpenShellList;

struct OrientedEdge {
   Edge edge;
   GeomI::Orientation orientation;
   explicit OrientedEdge(Edge _edge = 0, GeomI::Orientation _orientation = true) : edge(_edge), orientation(_orientation) {}
};

typedef CoreI::List<OrientedEdge> OrientedEdgeList;

struct OrientedFace {
   Face face;
   GeomI::Orientation orientation;
   explicit OrientedFace(Face _face = 0, GeomI::Orientation _orientation = true) : face(_face), orientation(_orientation) {}
};

typedef CoreI::List<OrientedFace> OrientedFaceList;

typedef Curve ParabolaCurve;

PXZ_EXPORTED extern const CoreI::EntityType ParabolaCurveEntityType;

typedef Surface PlaneSurface;

PXZ_EXPORTED extern const CoreI::EntityType PlaneSurfaceEntityType;

typedef Curve PolylineCurve;

PXZ_EXPORTED extern const CoreI::EntityType PolylineCurveEntityType;

struct ProfileLoop {
   OrientedEdgeList edges;
   CoreI::Boolean isOuter;
   explicit ProfileLoop(OrientedEdgeList _edges = OrientedEdgeList(), CoreI::Boolean _isOuter = true) : edges(_edges), isOuter(_isOuter) {}
};

typedef CoreI::List<ProfileLoop> ProfileBase;

typedef CoreI::List<ProfileBase> ProfileBaseList;

typedef Surface RevolutionSurface;

PXZ_EXPORTED extern const CoreI::EntityType RevolutionSurfaceEntityType;

typedef Surface RuledSurface;

PXZ_EXPORTED extern const CoreI::EntityType RuledSurfaceEntityType;

typedef Curve SegmentCurve;

PXZ_EXPORTED extern const CoreI::EntityType SegmentCurveEntityType;

typedef Surface SphereSurface;

PXZ_EXPORTED extern const CoreI::EntityType SphereSurfaceEntityType;

struct SplittedEdge {
   Edge oldEdge;
   EdgeList newEdges;
   explicit SplittedEdge(Edge _oldEdge = 0, EdgeList _newEdges = EdgeList()) : oldEdge(_oldEdge), newEdges(_newEdges) {}
};

typedef CoreI::List<SplittedEdge> SplittedEdgeList;

typedef Curve SurfacicCurve;

PXZ_EXPORTED extern const CoreI::EntityType SurfacicCurveEntityType;

typedef Surface TabulatedCylinderSurface;

PXZ_EXPORTED extern const CoreI::EntityType TabulatedCylinderSurfaceEntityType;

typedef Surface TorusSurface;

PXZ_EXPORTED extern const CoreI::EntityType TorusSurfaceEntityType;

class TorusType {
public:
   typedef enum {
   Donut = 0,
   Vortex = 1,
   Apple = 2,
   Lemon = 3
   } Type;
private:
   Type _value;
public:
   TorusType(Type val = Donut) : _value(val) {}
   TorusType & operator=(Type val) { _value = val; return *this; }
   TorusType(const CoreI::Int& val) : _value((Type)val) {}
   TorusType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
typedef Curve TransformedCurve;

PXZ_EXPORTED extern const CoreI::EntityType TransformedCurveEntityType;

typedef Shape Vertex;

PXZ_EXPORTED extern const CoreI::EntityType VertexEntityType;

typedef CoreI::List<Vertex> VertexList;

typedef struct {
   FaceList faces;
   SplittedEdgeList splittingInfo;
} buildFacesReturn;

typedef struct {
   GeomI::Point3 d0;
   GeomI::Point3 du;
   GeomI::Point3 d2u;
} evalOnCurveReturn;

typedef struct {
   GeomI::Point3 d0;
   GeomI::Point3 du;
   GeomI::Point3 dv;
   GeomI::Point3 d2u;
   GeomI::Point3 d2v;
   GeomI::Point3 duv;
} evalOnSurfaceReturn;

typedef struct {
   CoreI::Double radius;
   GeomI::Matrix4 matrix;
} getCircleCurveDefinitionReturn;

typedef struct {
   Edge edge;
   GeomI::Orientation edgeOrientation;
   Loop loop;
   Surface surface;
   Curve parametricCurve;
} getCoEdgeDefinitionReturn;

typedef struct {
   CurveList curves;
   CoreI::DoubleList parameters;
} getCompositeCurveDefinitionReturn;

typedef struct {
   CoreI::Double radius;
   CoreI::Double semiAngle;
   GeomI::Matrix4 matrix;
} getConeSurfaceDefinitionReturn;

typedef struct {
   Curve generatrixCurve;
   Curve directrixCruve;
   Surface surfaceReference;
} getCurveExtrusionSurfaceDefinitionReturn;

typedef struct {
   CoreI::Double radius;
   GeomI::Matrix4 matrix;
} getCylinderSurfaceDefinitionReturn;

typedef struct {
   Vertex vertex1;
   Vertex vertex2;
   Curve curve;
   Bounds1D bounds;
} getEdgeDefinitionReturn;

typedef struct {
   CoreI::Double radius1;
   CoreI::Double radius2;
   GeomI::Matrix4 matrix;
} getEllipseCurveDefinitionReturn;

typedef struct {
   CoreI::Double radius1;
   CoreI::Double radius2;
   CoreI::Double semiAngle;
   GeomI::Matrix4 matrix;
} getEllipticConeSurfaceDefinitionReturn;

typedef struct {
   Surface surface;
   LoopList loops;
   GeomI::Orientation orientation;
   Bounds2D limits;
} getFaceDefinitionReturn;

typedef struct {
   CoreI::Double radius;
   GeomI::Matrix4 matrix;
   CoreI::Boolean trigonometricOrientation;
} getHelixCurveDefinitionReturn;

typedef struct {
   GeomI::Point3 firstPoint;
   GeomI::Point3 secondPoint;
   GeomI::Point3 firstTangent;
   GeomI::Point3 secondTangent;
} getHermiteCurveDefinitionReturn;

typedef struct {
   CoreI::Double radius1;
   CoreI::Double radius2;
   GeomI::Matrix4 matrix;
} getHyperbolaCurveDefinitionReturn;

typedef struct {
   Surface surface1;
   Surface surface2;
   PolylineCurve chart;
   Bounds1D bounds;
} getIntersectionCurveDefinitionReturn;

typedef struct {
   GeomI::Point3 origin;
   GeomI::Point3 direction;
} getLineCurveDefinitionReturn;

typedef struct {
   CoreI::Int degree;
   CoreI::DoubleList knots;
   GeomI::Point3List poles;
   CoreI::DoubleList weights;
} getNURBSCurveDefinitionReturn;

typedef struct {
   CoreI::Int degreeU;
   CoreI::Int degreeV;
   CoreI::DoubleList knotsU;
   CoreI::DoubleList knotsV;
   GeomI::Point3ListList poles;
   CoreI::DoubleListList weights;
} getNURBSSurfaceDefinitionReturn;

typedef struct {
   Curve curve;
   GeomI::Point3 direction;
   CoreI::Double distance;
   Surface surfaceReference;
} getOffsetCurveDefinitionReturn;

typedef struct {
   Surface baseSurface;
   CoreI::Double distance;
} getOffsetSurfaceDefinitionReturn;

typedef struct {
   CoreI::Double focalLength;
   GeomI::Matrix4 matrix;
} getParabolaCurveDefinitionReturn;

typedef struct {
   GeomI::Point3List points;
   CoreI::DoubleList parameters;
} getPolylineCurveDefinitionReturn;

typedef struct {
   Curve generatricCurve;
   GeomI::Point3 axisOrigin;
   GeomI::Point3 axisDirection;
   CoreI::Double startAngle;
   CoreI::Double endAngle;
} getRevolutionSurfaceDefinitionReturn;

typedef struct {
   Curve firstCurve;
   Curve secondCurve;
} getRuledSurfaceDefinitionReturn;

typedef struct {
   GeomI::Point3 startPoint;
   GeomI::Point3 endPoint;
} getSegmentCurveDefinitionReturn;

typedef struct {
   CoreI::Double radius;
   GeomI::Matrix4 matrix;
} getSphereSurfaceDefinitionReturn;

typedef struct {
   Surface surface;
   Curve curve2D;
} getSurfacicCurveDefinitionReturn;

typedef struct {
   Curve directrixCurve;
   GeomI::Point3 generatrixLine;
   Bounds1D range;
} getTabulatedCylinderSurfaceDefinitionReturn;

typedef struct {
   CoreI::Double majorRadius;
   CoreI::Double minorRadius;
   GeomI::Matrix4 matrix;
   CoreI::Int type;
} getTorusSurfaceDefinitionReturn;

typedef struct {
   Curve curve;
   GeomI::Matrix4 matrix;
} getTransformedCurveDefinitionReturn;

typedef struct {
   CoreI::Boolean periodic;
   CoreI::Double period;
} isCurvePeriodicReturn;

typedef struct {
   CoreI::Boolean closedU;
   CoreI::Boolean closedV;
} isSurfaceClosedReturn;

typedef struct {
   CoreI::Boolean periodicU;
   CoreI::Boolean periodicV;
   CoreI::Double periodU;
   CoreI::Double periodV;
} isSurfacePeriodicReturn;


PXZ_MODULE_END

#endif
