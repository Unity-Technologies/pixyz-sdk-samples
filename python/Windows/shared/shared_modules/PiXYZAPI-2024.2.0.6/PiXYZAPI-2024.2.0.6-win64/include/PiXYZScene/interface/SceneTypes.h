// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_SCENE_INTERFACE_SCENETYPES_H_
#define _PXZ_SCENE_INTERFACE_SCENETYPES_H_

#include <PiXYZCore/interface/InterfaceBase.h>
#include <PiXYZCAD/interface/CADTypes.h>
#include <PiXYZCore/interface/CoreTypes.h>
#include <PiXYZGeom/interface/GeomTypes.h>
#include <PiXYZMaterial/interface/MaterialTypes.h>
#include <PiXYZPolygonal/interface/PolygonalTypes.h>
#include <functional> 

PXZ_MODULE_BEGIN(SceneI)

typedef CoreI::Entity AlternativeTree;

PXZ_EXPORTED extern const CoreI::EntityType AlternativeTreeEntityType;

typedef CoreI::List<AlternativeTree> AlternativeTreeList;

typedef CoreI::Entity AnimChannel;

PXZ_EXPORTED extern const CoreI::EntityType AnimChannelEntityType;

class AnimChannelType {
public:
   typedef enum {
   SIMPLE = 0,
   VECTOR3 = 1,
   QUATERNION = 2,
   MATRIX4 = 3
   } Type;
private:
   Type _value;
public:
   AnimChannelType(Type val = SIMPLE) : _value(val) {}
   AnimChannelType & operator=(Type val) { _value = val; return *this; }
   AnimChannelType(const CoreI::Int& val) : _value((Type)val) {}
   AnimChannelType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct AnimChannelInfo {
   CoreI::String name;
   AnimChannelType type;
   CoreI::Ident mainPropertyBinder;
   CoreI::Bool hasKeyFrames;
   AnimChannelInfo(CoreI::String _name = "", AnimChannelType _type = AnimChannelType::SIMPLE, CoreI::Ident _mainPropertyBinder = 0, CoreI::Bool _hasKeyFrames = false) : name(_name), type(_type), mainPropertyBinder(_mainPropertyBinder), hasKeyFrames(_hasKeyFrames) {}
};

typedef CoreI::List<AnimChannel> AnimChannelList;

typedef GeomI::GeomEntity Occurrence;

PXZ_EXPORTED extern const CoreI::EntityType OccurrenceEntityType;

typedef CoreI::Entity Animation;

PXZ_EXPORTED extern const CoreI::EntityType AnimationEntityType;

struct AnimPropertyBinder {
   Occurrence occurrence;
   Animation animation;
   AnimChannel mainChannel;
   AnimPropertyBinder(Occurrence _occurrence = 0, Animation _animation = 0, AnimChannel _mainChannel = 0) : occurrence(_occurrence), animation(_animation), mainChannel(_mainChannel) {}
};

typedef CoreI::List<AnimPropertyBinder> AnimPropertyBinderList;

typedef CoreI::Entity Component;

PXZ_EXPORTED extern const CoreI::EntityType ComponentEntityType;

typedef Component AnimationComponent;

PXZ_EXPORTED extern const CoreI::EntityType AnimationComponentEntityType;

typedef CoreI::ULong AnimationTime;

struct AnimationInfo {
   CoreI::String name;
   CoreI::String group;
   AnimationTime length;
   AnimationInfo(CoreI::String _name = "", CoreI::String _group = "", AnimationTime _length = 0) : name(_name), group(_group), length(_length) {}
};

typedef CoreI::List<Animation> AnimationList;

typedef CoreI::Entity Annotation;

PXZ_EXPORTED extern const CoreI::EntityType AnnotationEntityType;

typedef CoreI::Entity AnnotationGroup;

PXZ_EXPORTED extern const CoreI::EntityType AnnotationGroupEntityType;

typedef GeomI::GeomEntity Shape;

PXZ_EXPORTED extern const CoreI::EntityType ShapeEntityType;

typedef Shape TessellatedShape;

PXZ_EXPORTED extern const CoreI::EntityType TessellatedShapeEntityType;

typedef CoreI::List<TessellatedShape> TessellatedShapeList;

struct AnnotationDefinition {
   //! the annotation we get the definition
   Annotation id;
   //! name of the annotation
   CoreI::String name;
   //! visibility of the annotation
   CoreI::Boolean visible;
   //! group of the annotation
   AnnotationGroup group;
   //! shapes of the annotation
   TessellatedShapeList shapes;
   AnnotationDefinition(Annotation _id = 0, CoreI::String _name = "", CoreI::Boolean _visible = false, AnnotationGroup _group = 0, TessellatedShapeList _shapes = TessellatedShapeList()) : id(_id), name(_name), visible(_visible), group(_group), shapes(_shapes) {}
};

typedef CoreI::List<AnnotationDefinition> AnnotationDefinitionList;

typedef CoreI::List<AnnotationGroup> AnnotationGroupList;

typedef CoreI::List<Annotation> AnnotationList;

typedef Shape BRepShape;

PXZ_EXPORTED extern const CoreI::EntityType BRepShapeEntityType;

typedef Component CameraComponent;

PXZ_EXPORTED extern const CoreI::EntityType CameraComponentEntityType;

typedef CoreI::List<Component> ComponentList;

class ComponentType {
public:
   typedef enum {
   Part = 0,
   PMI = 1,
   Light = 2,
   VisualBehavior = 3,
   InteractionBehavior = 4,
   Metadata = 5,
   Variant = 6,
   Animation = 7,
   Joint = 8,
   Widget = 9,
   OoCComponent = 10,
   LODComponent = 11,
   ExternalDataComponent = 12,
   HLODComponent = 13,
   CuttingPlaneComponent = 14,
   ReferencedDataComponent = 15,
   CameraComponent = 16,
   FeatureComponent = 17,
   SubpartMaterial = 18
   } Type;
private:
   Type _value;
public:
   ComponentType(Type val = Part) : _value(val) {}
   ComponentType & operator=(Type val) { _value = val; return *this; }
   ComponentType(const CoreI::Int& val) : _value((Type)val) {}
   ComponentType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
typedef Component ExternalDataComponent;

PXZ_EXPORTED extern const CoreI::EntityType ExternalDataComponentEntityType;

typedef CoreI::String FilterExpression;

struct Filter {
   CoreI::Ident id;
   CoreI::String name;
   FilterExpression expr;
   Filter(CoreI::Ident _id = 0, CoreI::String _name = "", FilterExpression _expr = "") : id(_id), name(_name), expr(_expr) {}
};

typedef CoreI::List<Filter> FilterList;

typedef Component JointComponent;

PXZ_EXPORTED extern const CoreI::EntityType JointComponentEntityType;

struct JointDefinition {
   //! the joint from which we get the definition
   PolygonalI::Joint id;
   //! The JointComponent attached to this joint
   Component jointComponent;
   //! is this joint the root
   CoreI::Boolean isRoot;
   //! The joint used as root
   PolygonalI::Joint rootJoint;
   //! vertices tangents
   PolygonalI::Joint parent;
   //! All direct hildren joint
   PolygonalI::JointList children;
   //! local matrix
   GeomI::Matrix4 matrix;
   //! global matrix
   GeomI::Matrix4 gloablMatrix;
   JointDefinition(PolygonalI::Joint _id = 0, Component _jointComponent = 0, CoreI::Boolean _isRoot = false, PolygonalI::Joint _rootJoint = 0, PolygonalI::Joint _parent = 0, PolygonalI::JointList _children = PolygonalI::JointList(), GeomI::Matrix4 _matrix = GeomI::Matrix4(), GeomI::Matrix4 _gloablMatrix = GeomI::Matrix4()) : id(_id), jointComponent(_jointComponent), isRoot(_isRoot), rootJoint(_rootJoint), parent(_parent), children(_children), matrix(_matrix), gloablMatrix(_gloablMatrix) {}
};

typedef CoreI::List<JointDefinition> JointDefinitionList;

typedef CoreI::Entity Keyframe;

PXZ_EXPORTED extern const CoreI::EntityType KeyframeEntityType;

typedef CoreI::List<Keyframe> KeyframeList;

typedef CoreI::Entity LOD;

PXZ_EXPORTED extern const CoreI::EntityType LODEntityType;

typedef Component LODComponent;

PXZ_EXPORTED extern const CoreI::EntityType LODComponentEntityType;

typedef CoreI::List<LODComponent> LODComponentList;

typedef CoreI::List<LOD> LODList;

typedef Component LightComponent;

PXZ_EXPORTED extern const CoreI::EntityType LightComponentEntityType;

class LightType {
public:
   typedef enum {
   DirectionalLight = 0,
   PositionalLight = 1,
   SpotLight = 2
   } Type;
private:
   Type _value;
public:
   LightType(Type val = DirectionalLight) : _value(val) {}
   LightType & operator=(Type val) { _value = val; return *this; }
   LightType(const CoreI::Int& val) : _value((Type)val) {}
   LightType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct MaterialCount {
   MaterialI::Material material;
   CoreI::Int count;
   MaterialCount(MaterialI::Material _material = 0, CoreI::Int _count = -1) : material(_material), count(_count) {}
};

typedef CoreI::List<MaterialCount> MaterialCountList;

struct MergeByRegionsStrategy {
   typedef enum {
      UNKNOWN=0,
      NUMBEROFREGIONS,
      SIZEOFREGIONS
   } Type;
   Type _type; 
   CoreI::Int NumberOfRegions;
   GeomI::Distance SizeOfRegions;
   MergeByRegionsStrategy() : _type(UNKNOWN) {}
   MergeByRegionsStrategy(const CoreI::Int & v) : _type(NUMBEROFREGIONS), NumberOfRegions(v) {}
   MergeByRegionsStrategy(const GeomI::Distance & v) : _type(SIZEOFREGIONS), SizeOfRegions(v) {}
};
class MergeHiddenPartsMode {
public:
   typedef enum {
   Destroy = 0,
   MakeVisible = 1,
   MergeSeparately = 2
   } Type;
private:
   Type _value;
public:
   MergeHiddenPartsMode(Type val = Destroy) : _value(val) {}
   MergeHiddenPartsMode & operator=(Type val) { _value = val; return *this; }
   MergeHiddenPartsMode(const CoreI::Int& val) : _value((Type)val) {}
   MergeHiddenPartsMode & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class MergeStrategy {
public:
   typedef enum {
   mergePartOccurrences = 0,
   MergeByMaterials = 1
   } Type;
private:
   Type _value;
public:
   MergeStrategy(Type val = mergePartOccurrences) : _value(val) {}
   MergeStrategy & operator=(Type val) { _value = val; return *this; }
   MergeStrategy(const CoreI::Int& val) : _value((Type)val) {}
   MergeStrategy & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
typedef Component Metadata;

PXZ_EXPORTED extern const CoreI::EntityType MetadataEntityType;

struct PropertyValue {
   //! name of the property
   CoreI::String name;
   //! value of the property
   CoreI::String value;
   PropertyValue(CoreI::String _name = "", CoreI::String _value = "") : name(_name), value(_value) {}
};

typedef CoreI::List<PropertyValue> PropertyValueList;

typedef PropertyValueList MetadataDefinition;

typedef CoreI::List<MetadataDefinition> MetadataDefinitionList;

typedef CoreI::List<Metadata> MetadataList;

typedef CoreI::List<Occurrence> OccurrenceList;

typedef CoreI::List<OccurrenceList> OccurrenceListList;

typedef CoreI::Ident OccurrenceUserData;

typedef Component OoCComponent;

PXZ_EXPORTED extern const CoreI::EntityType OoCComponentEntityType;

typedef Component PMIComponent;

PXZ_EXPORTED extern const CoreI::EntityType PMIComponentEntityType;

struct PackedTree {
   //! list of all occurrences of the tree. (Note: all parent occurrences appears before their children, thus the first occurrence is the root)
   OccurrenceList occurrences;
   //! specifies the parent index for each occurrence (same index than occurrences). root's parent is -1
   CoreI::IntList parents;
   //! name of each occurrence (same index than occurrences)
   CoreI::StringList names;
   //! visibility of each occurrence (same index than occurrences)
   CoreI::InheritableBoolList visible;
   //! material identifier of each occurrence (same index than occurrences)
   MaterialI::MaterialList materials;
   //! indices of transform matrix of each occurrence (same index than occurrences). (Note: Identity matrix is always 0)
   CoreI::IntList transformIndices;
   //! Matrices referenced by transformIndices. (Note: The first matrix is always Identity)
   GeomI::Matrix4List transformMatrices;
   //! custom properties of each occurrence (same index than occurrences), pair is name -> value
   CoreI::StringPairListList customProperties;
   PackedTree(OccurrenceList _occurrences = OccurrenceList(), CoreI::IntList _parents = CoreI::IntList(), CoreI::StringList _names = CoreI::StringList(), CoreI::InheritableBoolList _visible = CoreI::InheritableBoolList(), MaterialI::MaterialList _materials = MaterialI::MaterialList(), CoreI::IntList _transformIndices = CoreI::IntList(), GeomI::Matrix4List _transformMatrices = GeomI::Matrix4List(), CoreI::StringPairListList _customProperties = CoreI::StringPairListList()) : occurrences(_occurrences), parents(_parents), names(_names), visible(_visible), materials(_materials), transformIndices(_transformIndices), transformMatrices(_transformMatrices), customProperties(_customProperties) {}
};

typedef Component Part;

PXZ_EXPORTED extern const CoreI::EntityType PartEntityType;

typedef CoreI::List<Part> PartList;

class PartialLoad_Status {
public:
   typedef enum {
   NOT_LOADED = 0,
   LOADED = 1,
   LOADING = 2,
   LOADING_ALL = 3
   } Type;
private:
   Type _value;
public:
   PartialLoad_Status(Type val = NOT_LOADED) : _value(val) {}
   PartialLoad_Status & operator=(Type val) { _value = val; return *this; }
   PartialLoad_Status(const CoreI::Int& val) : _value((Type)val) {}
   PartialLoad_Status & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class Primitive_Type {
public:
   typedef enum {
   CUBE = 0,
   SPHERE = 1,
   PLAN = 2,
   CONE = 3,
   ARROW = 4,
   CYLINDER = 5,
   CAPSULE = 6
   } Type;
private:
   Type _value;
public:
   Primitive_Type(Type val = CUBE) : _value(val) {}
   Primitive_Type & operator=(Type val) { _value = val; return *this; }
   Primitive_Type(const CoreI::Int& val) : _value((Type)val) {}
   Primitive_Type & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct ProberInfo {
   Occurrence occurrence;
   GeomI::Point3 position;
   ProberInfo(Occurrence _occurrence = 0, GeomI::Point3 _position = GeomI::Point3()) : occurrence(_occurrence), position(_position) {}
};

typedef CoreI::Entity ProductView;

PXZ_EXPORTED extern const CoreI::EntityType ProductViewEntityType;

typedef CoreI::Entity Variant;

PXZ_EXPORTED extern const CoreI::EntityType VariantEntityType;

struct ProductViewDefinition {
   //! the productview we get the definition
   Variant id;
   //! name of the view
   CoreI::String name;
   //! name of the group of view
   CoreI::String groupName;
   //! view matrix of this view
   GeomI::Matrix4 view;
   //! true if view is set
   CoreI::Boolean viewIsSet;
   //! true if view is orthographic
   CoreI::Boolean viewIsOrtho;
   //! fov of the camera
   CoreI::Double viewFov;
   //! true if cutting plane is set
   CoreI::Boolean cuttingPlane;
   //! position of the cutting plane
   GeomI::Vector3 cuttingPlanePosition;
   //! normal of the cutting plane
   GeomI::Vector3 cuttingPlaneNormal;
   //! fov of the camera
   CoreI::Double explodedViewFactor;
   //! true if exploded along X axis
   CoreI::Boolean explodedViewX;
   //! true if exploded along Y axis
   CoreI::Boolean explodedViewY;
   //! true if exploded along Z axis
   CoreI::Boolean explodedViewZ;
   //! annotations linked to this view
   AnnotationList annotations;
   ProductViewDefinition(Variant _id = 0, CoreI::String _name = "", CoreI::String _groupName = "", GeomI::Matrix4 _view = GeomI::Matrix4(), CoreI::Boolean _viewIsSet = false, CoreI::Boolean _viewIsOrtho = false, CoreI::Double _viewFov = 60, CoreI::Boolean _cuttingPlane = false, GeomI::Vector3 _cuttingPlanePosition = GeomI::Vector3(), GeomI::Vector3 _cuttingPlaneNormal = GeomI::Vector3(), CoreI::Double _explodedViewFactor = 60, CoreI::Boolean _explodedViewX = false, CoreI::Boolean _explodedViewY = false, CoreI::Boolean _explodedViewZ = false, AnnotationList _annotations = AnnotationList()) : id(_id), name(_name), groupName(_groupName), view(_view), viewIsSet(_viewIsSet), viewIsOrtho(_viewIsOrtho), viewFov(_viewFov), cuttingPlane(_cuttingPlane), cuttingPlanePosition(_cuttingPlanePosition), cuttingPlaneNormal(_cuttingPlaneNormal), explodedViewFactor(_explodedViewFactor), explodedViewX(_explodedViewX), explodedViewY(_explodedViewY), explodedViewZ(_explodedViewZ), annotations(_annotations) {}
};

typedef CoreI::List<ProductViewDefinition> ProductViewDefinitionList;

struct RayHit {
   CoreI::Double rayParam;
   Occurrence occurrence;
   CoreI::Int triangleIndex;
   GeomI::Point2 triangleParam;
   RayHit(CoreI::Double _rayParam = -1, Occurrence _occurrence = 0, CoreI::Int _triangleIndex = -1, GeomI::Point2 _triangleParam = GeomI::Point2()) : rayParam(_rayParam), occurrence(_occurrence), triangleIndex(_triangleIndex), triangleParam(_triangleParam) {}
};

typedef CoreI::List<RayHit> RayHitList;

typedef Component ReferencedDataComponent;

PXZ_EXPORTED extern const CoreI::EntityType ReferencedDataComponentEntityType;

struct ResizeByMaximumSizeOptions {
   CoreI::Int TextureSize;
   CoreI::Boolean KeepTextureRatio;
   ResizeByMaximumSizeOptions(CoreI::Int _TextureSize = 4096, CoreI::Boolean _KeepTextureRatio = true) : TextureSize(_TextureSize), KeepTextureRatio(_KeepTextureRatio) {}
};

struct ResizeByTexturesOptions {
   typedef enum {
      UNKNOWN=0,
      ALLTEXTURES,
      SELECTION
   } Type;
   Type _type; 
   CoreI::None AllTextures;
   MaterialI::ImageList Selection;
   ResizeByTexturesOptions() : _type(UNKNOWN) {}
   ResizeByTexturesOptions(const CoreI::None & v) : _type(ALLTEXTURES), AllTextures(v) {}
   ResizeByTexturesOptions(const MaterialI::ImageList & v) : _type(SELECTION), Selection(v) {}
};
struct ResizeTexturesInputMode {
   typedef enum {
      UNKNOWN=0,
      OCCURRENCES,
      TEXTURES
   } Type;
   Type _type; 
   OccurrenceList Occurrences;
   ResizeByTexturesOptions Textures;
   ResizeTexturesInputMode() : _type(UNKNOWN) {}
   ResizeTexturesInputMode(const OccurrenceList & v) : _type(OCCURRENCES), Occurrences(v) {}
   ResizeTexturesInputMode(const ResizeByTexturesOptions & v) : _type(TEXTURES), Textures(v) {}
};
struct ResizeTexturesResizeMode {
   typedef enum {
      UNKNOWN=0,
      RATIO,
      MAXIMUMSIZE
   } Type;
   Type _type; 
   CoreI::Percent Ratio;
   ResizeByMaximumSizeOptions MaximumSize;
   ResizeTexturesResizeMode() : _type(UNKNOWN) {}
   ResizeTexturesResizeMode(const CoreI::Percent & v) : _type(RATIO), Ratio(v) {}
   ResizeTexturesResizeMode(const ResizeByMaximumSizeOptions & v) : _type(MAXIMUMSIZE), MaximumSize(v) {}
};
class SceneChangeType {
public:
   typedef enum {
   CHILD_INSERTED = 0,
   CHILD_REMOVED = 1,
   PROPERTY_CHANGED = 2,
   COMPLETE_CHANGE = 3
   } Type;
private:
   Type _value;
public:
   SceneChangeType(Type val = CHILD_INSERTED) : _value(val) {}
   SceneChangeType & operator=(Type val) { _value = val; return *this; }
   SceneChangeType(const CoreI::Int& val) : _value((Type)val) {}
   SceneChangeType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class SelectionChangeType {
public:
   typedef enum {
   CLEARED = 0,
   ADDED = 1,
   REMOVED = 2
   } Type;
private:
   Type _value;
public:
   SelectionChangeType(Type val = CLEARED) : _value(val) {}
   SelectionChangeType & operator=(Type val) { _value = val; return *this; }
   SelectionChangeType(const CoreI::Int& val) : _value((Type)val) {}
   SelectionChangeType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class ShapeType {
public:
   typedef enum {
   TESSELLATED = 0,
   CAD = 1,
   JOINT = 2
   } Type;
private:
   Type _value;
public:
   ShapeType(Type val = TESSELLATED) : _value(val) {}
   ShapeType & operator=(Type val) { _value = val; return *this; }
   ShapeType(const CoreI::Int& val) : _value((Type)val) {}
   ShapeType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class VariantChangeType {
public:
   typedef enum {
   ADDED = 0,
   REMOVED = 1,
   CURRENT_CHANGED = 2
   } Type;
private:
   Type _value;
public:
   VariantChangeType(Type val = ADDED) : _value(val) {}
   VariantChangeType & operator=(Type val) { _value = val; return *this; }
   VariantChangeType(const CoreI::Int& val) : _value((Type)val) {}
   VariantChangeType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
typedef Component VariantComponent;

PXZ_EXPORTED extern const CoreI::EntityType VariantComponentEntityType;

typedef CoreI::List<VariantComponent> VariantComponentList;

struct VariantDefinition {
   Variant variant;
   PropertyValueList overridedProperties;
   VariantDefinition(Variant _variant = 0, PropertyValueList _overridedProperties = PropertyValueList()) : variant(_variant), overridedProperties(_overridedProperties) {}
};

typedef CoreI::List<VariantDefinition> VariantDefinitionList;

typedef CoreI::List<VariantDefinitionList> VariantDefinitionListList;

typedef CoreI::List<Variant> VariantList;

struct VariantMaterials {
   //! the variant id
   Variant id;
   //! the material list
   MaterialI::MaterialList materials;
   VariantMaterials(Variant _id = 0, MaterialI::MaterialList _materials = MaterialI::MaterialList()) : id(_id), materials(_materials) {}
};

typedef CoreI::List<VariantMaterials> VariantMaterialList;

class VisibilityMode {
public:
   typedef enum {
   Inherited = 0,
   Hide = 1
   } Type;
private:
   Type _value;
public:
   VisibilityMode(Type val = Inherited) : _value(val) {}
   VisibilityMode & operator=(Type val) { _value = val; return *this; }
   VisibilityMode(const CoreI::Int& val) : _value((Type)val) {}
   VisibilityMode & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
typedef struct {
   CoreI::ULong partCount;
   CoreI::ULong partOccurrenceCount;
   CoreI::ULong triangleCount;
   CoreI::ULong triangleOccurrenceCount;
   CoreI::ULong vertexCount;
   CoreI::ULong vertexOccurrenceCount;
   CoreI::ULong pointCount;
   CoreI::ULong pointOccurrenceCount;
   CoreI::ULong lineCount;
   CoreI::ULong lineOccurrenceCount;
} getSubTreeStatsReturn;

typedef struct {
   GeomI::Point3List positions;
   GeomI::Point3List directions;
} getViewpointsFromCavitiesReturn;

typedef struct {
   CoreI::String implementationType;
   CoreI::String implementationParameters;
} getOoCConfigurationReturn;

typedef struct {
   CoreI::Int partCount;
   CoreI::Int totalPartCount;
   CoreI::Int vertexCount;
   CoreI::Int totalVertexCount;
   CoreI::Int edgeCount;
   CoreI::Int totalEdgeCount;
   CoreI::Int openShellCount;
   CoreI::Int totalOpenShellCount;
   CoreI::Int bodyCount;
   CoreI::Int totalBodyCount;
   CoreI::Double area2Dsum;
   CoreI::Int boundaryCount;
   CoreI::Int boundaryEdgeCount;
} getBRepInfosReturn;

typedef struct {
   CoreI::Int partCount;
   CoreI::Int totalPartCount;
   CoreI::Int vertexCount;
   CoreI::Int totalVertexCount;
   CoreI::Int edgeCount;
   CoreI::Int totalEdgeCount;
   CoreI::Int polygonCount;
   CoreI::Int totalPolygonCount;
   CoreI::Int patchCount;
   CoreI::Int totalPatchCount;
   CoreI::Int boundaryCount;
   CoreI::Int boundaryEdgeCount;
   CoreI::Int nonManifoldEdgeCount;
} getTessellationInfosReturn;

typedef struct {
   OccurrenceList occurrences;
   CoreI::StringList evaluations;
} evaluateExpressionOnSubTreeReturn;

typedef struct {
   CoreI::IntList indices;
   GeomI::Matrix4List transforms;
} getPartsTransformsIndexedReturn;


PXZ_MODULE_END

#endif
