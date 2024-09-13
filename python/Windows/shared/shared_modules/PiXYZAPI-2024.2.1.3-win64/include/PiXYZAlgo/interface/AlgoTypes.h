// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_ALGO_INTERFACE_ALGOTYPES_H_
#define _PXZ_ALGO_INTERFACE_ALGOTYPES_H_

#include <PiXYZCore/interface/InterfaceBase.h>
#include <PiXYZCore/interface/CoreTypes.h>
#include <PiXYZGeom/interface/GeomTypes.h>
#include <PiXYZMaterial/interface/MaterialTypes.h>
#include <PiXYZPolygonal/interface/PolygonalTypes.h>
#include <PiXYZScene/interface/SceneTypes.h>
#include <functional> 

PXZ_MODULE_BEGIN(AlgoI)

class AlignmentMode {
public:
   typedef enum {
   Auto = 0,
   Portrait = 1,
   Landscape = 2
   } Type;
private:
   Type _value;
public:
   AlignmentMode(Type val = Auto) : _value(val) {}
   AlignmentMode & operator=(Type val) { _value = val; return *this; }
   AlignmentMode(const CoreI::Int& val) : _value((Type)val) {}
   AlignmentMode & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class AttributType {
public:
   typedef enum {
   Patches = 4020,
   PatchMaterials = 4021,
   PatchBoundaries = 4022,
   UVs = 4035,
   Normals = 4036,
   Tangents = 4037,
   Binormals = 4038
   } Type;
private:
   Type _value;
public:
   AttributType(Type val = Patches) : _value(val) {}
   AttributType & operator=(Type val) { _value = val; return *this; }
   AttributType(const CoreI::Int& val) : _value((Type)val) {}
   AttributType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class MapType {
public:
   typedef enum {
   Diffuse = 0,
   Normal = 1,
   Opacity = 2,
   Roughness = 3,
   Specular = 4,
   Metallic = 5,
   AO = 6,
   Emissive = 7,
   PartId = 8,
   MaterialId = 9,
   ComputeAO = 10,
   Bent = 11,
   UV = 12,
   Displacement = 13,
   LocalPosition = 14,
   GlobalPosition = 15,
   Depth = 16,
   OccurrenceProperty = 17,
   Feature = 18,
   VertexColor = 19
   } Type;
private:
   Type _value;
public:
   MapType(Type val = Diffuse) : _value(val) {}
   MapType & operator=(Type val) { _value = val; return *this; }
   MapType(const CoreI::Int& val) : _value((Type)val) {}
   MapType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct BakeMap {
   MapType type;
   SceneI::PropertyValueList properties;
   explicit BakeMap(MapType _type = MapType::Diffuse, SceneI::PropertyValueList _properties = SceneI::PropertyValueList()) : type(_type), properties(_properties) {}
};

typedef CoreI::List<BakeMap> BakeMapList;

struct BakeMaps {
   CoreI::Boolean diffuse;
   CoreI::Boolean normal;
   CoreI::Boolean roughness;
   CoreI::Boolean metallic;
   CoreI::Boolean opacity;
   CoreI::Boolean ambientOcclusion;
   CoreI::Boolean emissive;
   explicit BakeMaps(CoreI::Boolean _diffuse = true, CoreI::Boolean _normal = true, CoreI::Boolean _roughness = true, CoreI::Boolean _metallic = true, CoreI::Boolean _opacity = true, CoreI::Boolean _ambientOcclusion = true, CoreI::Boolean _emissive = true) : diffuse(_diffuse), normal(_normal), roughness(_roughness), metallic(_metallic), opacity(_opacity), ambientOcclusion(_ambientOcclusion), emissive(_emissive) {}
};

struct BakeOption {
   CoreI::Int resolution;
   //! add padding to the map. A negative value means that the texture will be filled, and the padding for uv island is the absolute value
   CoreI::Int padding;
   BakeMaps textures;
   explicit BakeOption(CoreI::Int _resolution = 1024, CoreI::Int _padding = 1, BakeMaps _textures = BakeMaps()) : resolution(_resolution), padding(_padding), textures(_textures) {}
};

class BakingMethod {
public:
   typedef enum {
   RayOnly = 0,
   ProjOnly = 1,
   RayAndProj = 2
   } Type;
private:
   Type _value;
public:
   BakingMethod(Type val = RayOnly) : _value(val) {}
   BakingMethod & operator=(Type val) { _value = val; return *this; }
   BakingMethod(const CoreI::Int& val) : _value((Type)val) {}
   BakingMethod & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct Box {
   GeomI::Affine position;
   CoreI::Double length;
   CoreI::Double height;
   CoreI::Double depth;
   explicit Box(GeomI::Affine _position = GeomI::Affine(), CoreI::Double _length = 200, CoreI::Double _height = 200, CoreI::Double _depth = 200) : position(_position), length(_length), height(_height), depth(_depth) {}
};

struct BoxParameters {
   CoreI::Double SizeX;
   CoreI::Double SizeY;
   CoreI::Double SizeZ;
   CoreI::Int Subdivision;
   explicit BoxParameters(CoreI::Double _SizeX = 1000, CoreI::Double _SizeY = 1000, CoreI::Double _SizeZ = 1000, CoreI::Int _Subdivision = 1) : SizeX(_SizeX), SizeY(_SizeY), SizeZ(_SizeZ), Subdivision(_Subdivision) {}
};

struct BricksReturn {
   SceneI::Occurrence Root;
   CADI::BrickDefinitionList Bricks;
   explicit BricksReturn(SceneI::Occurrence _Root = 0, CADI::BrickDefinitionList _Bricks = CADI::BrickDefinitionList()) : Root(_Root), Bricks(_Bricks) {}
};

struct CapsuleParameters {
   CoreI::Double Radius;
   CoreI::Double Height;
   CoreI::Int Latitude;
   CoreI::Int Longitude;
   explicit CapsuleParameters(CoreI::Double _Radius = 250, CoreI::Double _Height = 250, CoreI::Int _Latitude = 16, CoreI::Int _Longitude = 16) : Radius(_Radius), Height(_Height), Latitude(_Latitude), Longitude(_Longitude) {}
};

class ComputingQuality {
public:
   typedef enum {
   High = 0,
   Medium = 1,
   Low = 2
   } Type;
private:
   Type _value;
public:
   ComputingQuality(Type val = High) : _value(val) {}
   ComputingQuality & operator=(Type val) { _value = val; return *this; }
   ComputingQuality(const CoreI::Int& val) : _value((Type)val) {}
   ComputingQuality & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct ConeParameters {
   CoreI::Double BottomRadius;
   CoreI::Double Height;
   CoreI::Int Sides;
   explicit ConeParameters(CoreI::Double _BottomRadius = 250, CoreI::Double _Height = 500, CoreI::Int _Sides = 16) : BottomRadius(_BottomRadius), Height(_Height), Sides(_Sides) {}
};

class ConvexityFilter {
public:
   typedef enum {
   OnConvex = 0,
   OnConcave = 1,
   OnConvexAndConcave = 2
   } Type;
private:
   Type _value;
public:
   ConvexityFilter(Type val = OnConvex) : _value(val) {}
   ConvexityFilter & operator=(Type val) { _value = val; return *this; }
   ConvexityFilter(const CoreI::Int& val) : _value((Type)val) {}
   ConvexityFilter & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class CostEvaluation {
public:
   typedef enum {
   SumEvaluation = 0,
   MaxEvaluation = 1,
   AverageEvaluation = 2
   } Type;
private:
   Type _value;
public:
   CostEvaluation(Type val = SumEvaluation) : _value(val) {}
   CostEvaluation & operator=(Type val) { _value = val; return *this; }
   CostEvaluation(const CoreI::Int& val) : _value((Type)val) {}
   CostEvaluation & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class CreateOccluder {
public:
   typedef enum {
   Occludee = 0,
   Occluder = 1
   } Type;
private:
   Type _value;
public:
   CreateOccluder(Type val = Occludee) : _value(val) {}
   CreateOccluder & operator=(Type val) { _value = val; return *this; }
   CreateOccluder(const CoreI::Int& val) : _value((Type)val) {}
   CreateOccluder & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct CustomBakeMap {
   CoreI::String name;
   CoreI::Int component;
   explicit CustomBakeMap(CoreI::String _name = "", CoreI::Int _component = 3) : name(_name), component(_component) {}
};

typedef CoreI::List<CustomBakeMap> CustomBakeMapList;

struct Cylinder {
   GeomI::Affine position;
   CoreI::Double radius;
   CoreI::Double length;
   explicit Cylinder(GeomI::Affine _position = GeomI::Affine(), CoreI::Double _radius = 100, CoreI::Double _length = 200) : position(_position), radius(_radius), length(_length) {}
};

struct CylinderParameters {
   CoreI::Double Radius;
   CoreI::Double Height;
   CoreI::Int Sides;
   explicit CylinderParameters(CoreI::Double _Radius = 250, CoreI::Double _Height = 1000, CoreI::Int _Sides = 16) : Radius(_Radius), Height(_Height), Sides(_Sides) {}
};

struct DecimateOptionsSelector {
   typedef enum {
      UNKNOWN=0,
      TRIANGLECOUNT,
      RATIO
   } Type;
   Type _type; 
   CoreI::ULong triangleCount;
   CoreI::Percent ratio;
   DecimateOptionsSelector() : _type(UNKNOWN) {}
   DecimateOptionsSelector(const CoreI::ULong & v) : _type(TRIANGLECOUNT), triangleCount(v) {}
   DecimateOptionsSelector(const CoreI::Percent & v) : _type(RATIO), ratio(v) {}
};
class DiskSegmentationMethod {
public:
   typedef enum {
   Perimeter = 0,
   GaussianCurvature = 1
   } Type;
private:
   Type _value;
public:
   DiskSegmentationMethod(Type val = Perimeter) : _value(val) {}
   DiskSegmentationMethod & operator=(Type val) { _value = val; return *this; }
   DiskSegmentationMethod(const CoreI::Int& val) : _value((Type)val) {}
   DiskSegmentationMethod & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class ElementFilter {
public:
   typedef enum {
   Polygons = 0,
   Points = 1,
   Hybrid = 2
   } Type;
private:
   Type _value;
public:
   ElementFilter(Type val = Polygons) : _value(val) {}
   ElementFilter & operator=(Type val) { _value = val; return *this; }
   ElementFilter(const CoreI::Int& val) : _value((Type)val) {}
   ElementFilter & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class FeatureType {
public:
   typedef enum {
   Unknown = 0,
   ThroughHole = 1,
   BlindHole = 2
   } Type;
private:
   Type _value;
public:
   FeatureType(Type val = Unknown) : _value(val) {}
   FeatureType & operator=(Type val) { _value = val; return *this; }
   FeatureType(const CoreI::Int& val) : _value((Type)val) {}
   FeatureType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct FeatureInput {
   GeomI::Point3 position;
   GeomI::Vector3 direction;
   GeomI::Distance diameter;
   explicit FeatureInput(GeomI::Point3 _position = GeomI::Point3(), GeomI::Vector3 _direction = GeomI::Vector3(), GeomI::Distance _diameter = 0) : position(_position), direction(_direction), diameter(_diameter) {}
};

typedef CoreI::List<FeatureInput> FeatureInputList;

struct Feature {
   FeatureType type;
   FeatureInputList inputs;
   explicit Feature(FeatureType _type = FeatureType::Unknown, FeatureInputList _inputs = FeatureInputList()) : type(_type), inputs(_inputs) {}
};

typedef CoreI::List<Feature> FeatureList;

class FilletingMode {
public:
   typedef enum {
   Width = 0,
   Distance = 1,
   Depth = 2,
   Radius = 3
   } Type;
private:
   Type _value;
public:
   FilletingMode(Type val = Width) : _value(val) {}
   FilletingMode & operator=(Type val) { _value = val; return *this; }
   FilletingMode(const CoreI::Int& val) : _value((Type)val) {}
   FilletingMode & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class FlatteningStopCondition {
public:
   typedef enum {
   MEAN_DEFORMATION = 0,
   ABSOLUTE_DEFORMATION = 1
   } Type;
private:
   Type _value;
public:
   FlatteningStopCondition(Type val = MEAN_DEFORMATION) : _value(val) {}
   FlatteningStopCondition & operator=(Type val) { _value = val; return *this; }
   FlatteningStopCondition(const CoreI::Int& val) : _value((Type)val) {}
   FlatteningStopCondition & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct HexahedronParameters {
   CoreI::Double XLength;
   CoreI::Double YLength;
   CoreI::Double ZLength;
   explicit HexahedronParameters(CoreI::Double _XLength = 1, CoreI::Double _YLength = 1, CoreI::Double _ZLength = 1) : XLength(_XLength), YLength(_YLength), ZLength(_ZLength) {}
};

class InnerOuterOption {
public:
   typedef enum {
   All = 0,
   OnlyOuter = 1,
   OnlyInners = 2
   } Type;
private:
   Type _value;
public:
   InnerOuterOption(Type val = All) : _value(val) {}
   InnerOuterOption & operator=(Type val) { _value = val; return *this; }
   InnerOuterOption(const CoreI::Int& val) : _value((Type)val) {}
   InnerOuterOption & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
typedef CoreI::List<MapType> MapTypeList;

class MeshBooleanOperation {
public:
   typedef enum {
   SplitOnly = 0,
   Union = 1,
   Intersection = 2,
   Subtraction = 3
   } Type;
private:
   Type _value;
public:
   MeshBooleanOperation(Type val = SplitOnly) : _value(val) {}
   MeshBooleanOperation & operator=(Type val) { _value = val; return *this; }
   MeshBooleanOperation(const CoreI::Int& val) : _value((Type)val) {}
   MeshBooleanOperation & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct OccurrenceFeatures {
   SceneI::Occurrence occurrence;
   FeatureList features;
   explicit OccurrenceFeatures(SceneI::Occurrence _occurrence = 0, FeatureList _features = FeatureList()) : occurrence(_occurrence), features(_features) {}
};

typedef CoreI::List<OccurrenceFeatures> OccurrenceFeaturesList;

struct OctahedralImpostor {
   GeomI::Matrix4 OctaTransform;
   CoreI::Double Radius;
   MaterialI::Image NormalMap;
   MaterialI::Image DepthMap;
   MaterialI::Image DiffuseMap;
   MaterialI::Image MetallicMap;
   MaterialI::Image AOMap;
   MaterialI::Image RoughnessMap;
   explicit OctahedralImpostor(GeomI::Matrix4 _OctaTransform = GeomI::Matrix4(), CoreI::Double _Radius = 1, MaterialI::Image _NormalMap = 0, MaterialI::Image _DepthMap = 0, MaterialI::Image _DiffuseMap = 0, MaterialI::Image _MetallicMap = 0, MaterialI::Image _AOMap = 0, MaterialI::Image _RoughnessMap = 0) : OctaTransform(_OctaTransform), Radius(_Radius), NormalMap(_NormalMap), DepthMap(_DepthMap), DiffuseMap(_DiffuseMap), MetallicMap(_MetallicMap), AOMap(_AOMap), RoughnessMap(_RoughnessMap) {}
};

class OrientStrategy {
public:
   typedef enum {
   ExteriorOnly = 0,
   VisibilityOrExterior = 1,
   VisibilityByConnected = 2,
   VisibilityByPolygon = 3,
   ConformToMajority = 4
   } Type;
private:
   Type _value;
public:
   OrientStrategy(Type val = ExteriorOnly) : _value(val) {}
   OrientStrategy & operator=(Type val) { _value = val; return *this; }
   OrientStrategy(const CoreI::Int& val) : _value((Type)val) {}
   OrientStrategy & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class OrientStrategyAdvanced {
public:
   typedef enum {
   VisibilityByConnected = 0,
   VisibilityByPolygon = 1
   } Type;
private:
   Type _value;
public:
   OrientStrategyAdvanced(Type val = VisibilityByConnected) : _value(val) {}
   OrientStrategyAdvanced & operator=(Type val) { _value = val; return *this; }
   OrientStrategyAdvanced(const CoreI::Int& val) : _value((Type)val) {}
   OrientStrategyAdvanced & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct Plane {
   GeomI::Affine position;
   CoreI::Double length;
   CoreI::Double height;
   explicit Plane(GeomI::Affine _position = GeomI::Affine(), CoreI::Double _length = 200, CoreI::Double _height = 200) : position(_position), length(_length), height(_height) {}
};

struct PlaneParameters {
   CoreI::Double SizeX;
   CoreI::Double SizeY;
   CoreI::Int SubdivisionX;
   CoreI::Int SubdivisionY;
   explicit PlaneParameters(CoreI::Double _SizeX = 1000, CoreI::Double _SizeY = 1000, CoreI::Int _SubdivisionX = 1, CoreI::Int _SubdivisionY = 1) : SizeX(_SizeX), SizeY(_SizeY), SubdivisionX(_SubdivisionX), SubdivisionY(_SubdivisionY) {}
};

struct SphereParameters {
   CoreI::Double Radius;
   CoreI::Int Latitude;
   CoreI::Int Longitude;
   explicit SphereParameters(CoreI::Double _Radius = 500, CoreI::Int _Latitude = 16, CoreI::Int _Longitude = 16) : Radius(_Radius), Latitude(_Latitude), Longitude(_Longitude) {}
};

struct PrimitiveShapeParameters {
   typedef enum {
      UNKNOWN=0,
      BOX,
      PLANE,
      SPHERE,
      CYLINDER,
      CONE,
      CAPSULE
   } Type;
   Type _type; 
   BoxParameters Box;
   PlaneParameters Plane;
   SphereParameters Sphere;
   CylinderParameters Cylinder;
   ConeParameters Cone;
   CapsuleParameters Capsule;
   PrimitiveShapeParameters() : _type(UNKNOWN) {}
   PrimitiveShapeParameters(const BoxParameters & v) : _type(BOX), Box(v) {}
   PrimitiveShapeParameters(const PlaneParameters & v) : _type(PLANE), Plane(v) {}
   PrimitiveShapeParameters(const SphereParameters & v) : _type(SPHERE), Sphere(v) {}
   PrimitiveShapeParameters(const CylinderParameters & v) : _type(CYLINDER), Cylinder(v) {}
   PrimitiveShapeParameters(const ConeParameters & v) : _type(CONE), Cone(v) {}
   PrimitiveShapeParameters(const CapsuleParameters & v) : _type(CAPSULE), Capsule(v) {}
};
class QualityMemoryTradeoff {
public:
   typedef enum {
   PreferQuality = 0,
   PreferMemory = 1
   } Type;
private:
   Type _value;
public:
   QualityMemoryTradeoff(Type val = PreferQuality) : _value(val) {}
   QualityMemoryTradeoff & operator=(Type val) { _value = val; return *this; }
   QualityMemoryTradeoff(const CoreI::Int& val) : _value((Type)val) {}
   QualityMemoryTradeoff & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class QualitySpeedTradeoff {
public:
   typedef enum {
   PreferQuality = 0,
   PreferSpeed = 1
   } Type;
private:
   Type _value;
public:
   QualitySpeedTradeoff(Type val = PreferQuality) : _value(val) {}
   QualitySpeedTradeoff & operator=(Type val) { _value = val; return *this; }
   QualitySpeedTradeoff(const CoreI::Int& val) : _value((Type)val) {}
   QualitySpeedTradeoff & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class RatioUV3DMode {
public:
   typedef enum {
   SmallestRatio = 0,
   HighestRatio = 1,
   AverageRatio = 2,
   MedianRatio = 3
   } Type;
private:
   Type _value;
public:
   RatioUV3DMode(Type val = SmallestRatio) : _value(val) {}
   RatioUV3DMode & operator=(Type val) { _value = val; return *this; }
   RatioUV3DMode(const CoreI::Int& val) : _value((Type)val) {}
   RatioUV3DMode & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class RelaxUVMethod {
public:
   typedef enum {
   Angle = 0,
   Edge = 1
   } Type;
private:
   Type _value;
public:
   RelaxUVMethod(Type val = Angle) : _value(val) {}
   RelaxUVMethod & operator=(Type val) { _value = val; return *this; }
   RelaxUVMethod(const CoreI::Int& val) : _value((Type)val) {}
   RelaxUVMethod & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class ReplaceByBoxType {
public:
   typedef enum {
   Minimum = 0,
   LocallyAligned = 1
   } Type;
private:
   Type _value;
public:
   ReplaceByBoxType(Type val = Minimum) : _value(val) {}
   ReplaceByBoxType & operator=(Type val) { _value = val; return *this; }
   ReplaceByBoxType(const CoreI::Int& val) : _value((Type)val) {}
   ReplaceByBoxType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class ReplaceByMode {
public:
   typedef enum {
   ByOccurrence = 0,
   All = 1
   } Type;
private:
   Type _value;
public:
   ReplaceByMode(Type val = ByOccurrence) : _value(val) {}
   ReplaceByMode & operator=(Type val) { _value = val; return *this; }
   ReplaceByMode(const CoreI::Int& val) : _value((Type)val) {}
   ReplaceByMode & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct ReplaceByOccurrenceOptions {
   SceneI::Occurrence Occurrence;
   CoreI::Boolean Aligned;
   explicit ReplaceByOccurrenceOptions(SceneI::Occurrence _Occurrence = 0, CoreI::Boolean _Aligned = false) : Occurrence(_Occurrence), Aligned(_Aligned) {}
};

struct ReplaceByPrimitiveOptions {
   PrimitiveShapeParameters Type;
   CoreI::Boolean Aligned;
   CoreI::Boolean GenerateUV;
   explicit ReplaceByPrimitiveOptions(PrimitiveShapeParameters _Type = PrimitiveShapeParameters(), CoreI::Boolean _Aligned = false, CoreI::Boolean _GenerateUV = true) : Type(_Type), Aligned(_Aligned), GenerateUV(_GenerateUV) {}
};

struct ReplaceByOption {
   typedef enum {
      UNKNOWN=0,
      OCCURRENCE,
      BOUNDINGBOX,
      CONVEXHULL,
      PRIMITIVE
   } Type;
   Type _type; 
   ReplaceByOccurrenceOptions Occurrence;
   ReplaceByBoxType BoundingBox;
   CoreI::None ConvexHull;
   ReplaceByPrimitiveOptions Primitive;
   ReplaceByOption() : _type(UNKNOWN) {}
   ReplaceByOption(const ReplaceByOccurrenceOptions & v) : _type(OCCURRENCE), Occurrence(v) {}
   ReplaceByOption(const ReplaceByBoxType & v) : _type(BOUNDINGBOX), BoundingBox(v) {}
   ReplaceByOption(const CoreI::None & v) : _type(CONVEXHULL), ConvexHull(v) {}
   ReplaceByOption(const ReplaceByPrimitiveOptions & v) : _type(PRIMITIVE), Primitive(v) {}
};
class SawingMode {
public:
   typedef enum {
   SawOnly = 0,
   SawAndSplit = 1,
   KeepInside = 2,
   KeepOutside = 3
   } Type;
private:
   Type _value;
public:
   SawingMode(Type val = SawOnly) : _value(val) {}
   SawingMode & operator=(Type val) { _value = val; return *this; }
   SawingMode(const CoreI::Int& val) : _value((Type)val) {}
   SawingMode & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class SelectionLevel {
public:
   typedef enum {
   Parts = 0,
   Patches = 1,
   Polygons = 2
   } Type;
private:
   Type _value;
public:
   SelectionLevel(Type val = Parts) : _value(val) {}
   SelectionLevel & operator=(Type val) { _value = val; return *this; }
   SelectionLevel(const CoreI::Int& val) : _value((Type)val) {}
   SelectionLevel & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct Sphere {
   GeomI::Affine position;
   CoreI::Double radius;
   explicit Sphere(GeomI::Affine _position = GeomI::Affine(), CoreI::Double _radius = 100) : position(_position), radius(_radius) {}
};

class TransformationType {
public:
   typedef enum {
   TRSOnly = 0,
   TRSAndSkew = 1
   } Type;
private:
   Type _value;
public:
   TransformationType(Type val = TRSOnly) : _value(val) {}
   TransformationType & operator=(Type val) { _value = val; return *this; }
   TransformationType(const CoreI::Int& val) : _value((Type)val) {}
   TransformationType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class UVGenerationMode {
public:
   typedef enum {
   NoUV = 0,
   IntrinsicUV = 1,
   ConformalScaledUV = 2
   } Type;
private:
   Type _value;
public:
   UVGenerationMode(Type val = NoUV) : _value(val) {}
   UVGenerationMode & operator=(Type val) { _value = val; return *this; }
   UVGenerationMode(const CoreI::Int& val) : _value((Type)val) {}
   UVGenerationMode & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class UVImportanceEnum {
public:
   typedef enum {
   PreserveSeamsAndReduceDeformation = 0,
   PreserveSeams = 1,
   IgnoreUV = 2
   } Type;
private:
   Type _value;
public:
   UVImportanceEnum(Type val = PreserveSeamsAndReduceDeformation) : _value(val) {}
   UVImportanceEnum & operator=(Type val) { _value = val; return *this; }
   UVImportanceEnum(const CoreI::Int& val) : _value((Type)val) {}
   UVImportanceEnum & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class UnwrapUVMethod {
public:
   typedef enum {
   Isometric = 0,
   Conformal = 1
   } Type;
private:
   Type _value;
public:
   UnwrapUVMethod(Type val = Isometric) : _value(val) {}
   UnwrapUVMethod & operator=(Type val) { _value = val; return *this; }
   UnwrapUVMethod(const CoreI::Int& val) : _value((Type)val) {}
   UnwrapUVMethod & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct UseColorOption {
   typedef enum {
      UNKNOWN=0,
      USELINESCOLOR,
      CHOOSECOLOR
   } Type;
   Type _type; 
   CoreI::None UseLinesColor;
   CoreI::Color ChooseColor;
   UseColorOption() : _type(UNKNOWN) {}
   UseColorOption(const CoreI::None & v) : _type(USELINESCOLOR), UseLinesColor(v) {}
   UseColorOption(const CoreI::Color & v) : _type(CHOOSECOLOR), ChooseColor(v) {}
};
class VisibilityToWeightMode {
public:
   typedef enum {
   FrontCountOnly = 0,
   FrontAndBackCount = 1,
   FrontCountOnlyAreaWeighted = 2,
   FrontAndBackCountAreaWeighted = 3
   } Type;
private:
   Type _value;
public:
   VisibilityToWeightMode(Type val = FrontCountOnly) : _value(val) {}
   VisibilityToWeightMode & operator=(Type val) { _value = val; return *this; }
   VisibilityToWeightMode(const CoreI::Int& val) : _value((Type)val) {}
   VisibilityToWeightMode & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
typedef std::function<CoreI::ColorAlpha(const GeomI::Point3 & fromPos, const GeomI::Point2 & param, const CoreI::ULong & polygonIndex, const SceneI::Occurrence & occurrence)> getPixelValue;

typedef CoreI::List<getPixelValue> getPixelValueList;

typedef struct {
   SceneI::OccurrenceList occurrences;
   GeomI::Matrix4ListList axis;
} getAllAxisFromCADModelReturn;

typedef struct {
   CoreI::Int visibleCountFront;
   CoreI::Int visibleCountBack;
} getVisibilityStatsReturn;

typedef struct {
   CoreI::UInt chartCount;
   CoreI::Double area3D;
   CoreI::Double area2D;
   CoreI::Double occupancy;
   CoreI::Double crumbliness;
   CoreI::Double samplingStd;
} getUVQualityMetricsReturn;


PXZ_MODULE_END

#endif
