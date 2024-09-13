// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_POLYGONAL_INTERFACE_POLYGONALTYPES_H_
#define _PXZ_POLYGONAL_INTERFACE_POLYGONALTYPES_H_

#include <PiXYZCore/interface/InterfaceBase.h>
#include <PiXYZCore/interface/CoreTypes.h>
#include <PiXYZGeom/interface/GeomTypes.h>
#include <PiXYZMaterial/interface/MaterialTypes.h>
#include <functional> 

PXZ_MODULE_BEGIN(PolygonalI)

typedef GeomI::GeomEntity Element;

PXZ_EXPORTED extern const CoreI::EntityType ElementEntityType;

typedef Element Edge;

PXZ_EXPORTED extern const CoreI::EntityType EdgeEntityType;

typedef CoreI::Entity Joint;

PXZ_EXPORTED extern const CoreI::EntityType JointEntityType;

typedef CoreI::List<Joint> JointList;

typedef GeomI::GeomEntity Mesh;

PXZ_EXPORTED extern const CoreI::EntityType MeshEntityType;

struct Submesh {
   //! Polygon material's dressed with
   MaterialI::Material material;
   //! First triangle.
   CoreI::Int firstTri;
   //! Number of triangles.
   CoreI::Int triCount;
   //! First quad.
   CoreI::Int firstQuad;
   //! Number of quad.
   CoreI::Int quadCount;
   //! External ID.
   CoreI::Ident externalId;
   explicit Submesh(MaterialI::Material _material = 0, CoreI::Int _firstTri = 0, CoreI::Int _triCount = 0, CoreI::Int _firstQuad = 0, CoreI::Int _quadCount = 0, CoreI::Ident _externalId = 0) : material(_material), firstTri(_firstTri), triCount(_triCount), firstQuad(_firstQuad), quadCount(_quadCount), externalId(_externalId) {}
};

typedef CoreI::List<Submesh> SubmeshList;

struct StylizedLine {
   //! List of lineVertices index. The indices for a line must be chained (e.g. 0 3 2 1 will create edges 0-3 3-2 2-1)
   CoreI::IntList lineVertexIndices;
   //! Material applied to the line if any
   MaterialI::Material material;
   //! External ID.
   CoreI::Ident externalId;
   explicit StylizedLine(CoreI::IntList _lineVertexIndices = CoreI::IntList(), MaterialI::Material _material = 0, CoreI::Ident _externalId = 0) : lineVertexIndices(_lineVertexIndices), material(_material), externalId(_externalId) {}
};

typedef CoreI::List<StylizedLine> StylizedLineList;

struct MeshDefinition {
   //! the mesh from which we get the definition
   Mesh id;
   //! External ID used for API integrations.
   CoreI::Ident externalId;
   //! vertices coordinates
   GeomI::Point3List vertices;
   //! vertices normals
   GeomI::Vector3List normals;
   //! vertices tangents
   GeomI::Vector4List tangents;
   //! UV channels
   CoreI::IntList uvChannels;
   //! array of vertices uv coordinates (one array per channel)
   GeomI::Point2ListList uvs;
   //! vertex colors
   CoreI::ColorAlphaList vertexColors;
   //! vertices curvatures
   GeomI::CurvaturesList curvatures;
   //! triangles (vertex indices)
   CoreI::IntList triangles;
   //! quadrangles (vertex indices)
   CoreI::IntList quadrangles;
   //! array which contains for each vertex in vertices the vertex that it is merged with
   CoreI::IntList vertexMerged;
   //! array which contain information about multi materials mesh
   SubmeshList submeshes;
   //! lines vertices coordinates
   GeomI::Point3List linesVertices;
   //! lines vertices indices
   StylizedLineList lines;
   //! points
   GeomI::Point3List points;
   //! points colors
   GeomI::Vector3List pointsColors;
   //! joints (bones) identifiers
   JointList joints;
   //! joints inverse bind matrices (bones poses)
   GeomI::Matrix4List inverseBindMatrices;
   //! joints (bones) weights
   GeomI::Vector4List jointWeights;
   //! joints (bones) indices
   GeomI::Vector4IList jointIndices;
   explicit MeshDefinition(Mesh _id = 0, CoreI::Ident _externalId = 0, GeomI::Point3List _vertices = GeomI::Point3List(), GeomI::Vector3List _normals = GeomI::Vector3List(), GeomI::Vector4List _tangents = GeomI::Vector4List(), CoreI::IntList _uvChannels = CoreI::IntList(), GeomI::Point2ListList _uvs = GeomI::Point2ListList(), CoreI::ColorAlphaList _vertexColors = CoreI::ColorAlphaList(), GeomI::CurvaturesList _curvatures = GeomI::CurvaturesList(), CoreI::IntList _triangles = CoreI::IntList(), CoreI::IntList _quadrangles = CoreI::IntList(), CoreI::IntList _vertexMerged = CoreI::IntList(), SubmeshList _submeshes = SubmeshList(), GeomI::Point3List _linesVertices = GeomI::Point3List(), StylizedLineList _lines = StylizedLineList(), GeomI::Point3List _points = GeomI::Point3List(), GeomI::Vector3List _pointsColors = GeomI::Vector3List(), JointList _joints = JointList(), GeomI::Matrix4List _inverseBindMatrices = GeomI::Matrix4List(), GeomI::Vector4List _jointWeights = GeomI::Vector4List(), GeomI::Vector4IList _jointIndices = GeomI::Vector4IList()) : id(_id), externalId(_externalId), vertices(_vertices), normals(_normals), tangents(_tangents), uvChannels(_uvChannels), uvs(_uvs), vertexColors(_vertexColors), curvatures(_curvatures), triangles(_triangles), quadrangles(_quadrangles), vertexMerged(_vertexMerged), submeshes(_submeshes), linesVertices(_linesVertices), lines(_lines), points(_points), pointsColors(_pointsColors), joints(_joints), inverseBindMatrices(_inverseBindMatrices), jointWeights(_jointWeights), jointIndices(_jointIndices) {}
};

typedef CoreI::List<MeshDefinition> MeshDefinitionList;

typedef CoreI::List<Mesh> MeshList;

typedef Joint PlaceholderJoint;

PXZ_EXPORTED extern const CoreI::EntityType PlaceholderJointEntityType;

typedef CoreI::List<PlaceholderJoint> PlaceholderJointList;

typedef Element Polygon;

PXZ_EXPORTED extern const CoreI::EntityType PolygonEntityType;

typedef Mesh StaticMesh;

PXZ_EXPORTED extern const CoreI::EntityType StaticMeshEntityType;

class StyleType {
public:
   typedef enum {
   NORMAL = 0,
   STIPPLE = 1
   } Type;
private:
   Type _value;
public:
   StyleType(Type val = NORMAL) : _value(val) {}
   StyleType & operator=(Type val) { _value = val; return *this; }
   StyleType(const CoreI::Int& val) : _value((Type)val) {}
   StyleType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
typedef Mesh Tessellation;

PXZ_EXPORTED extern const CoreI::EntityType TessellationEntityType;

typedef CoreI::Entity TessellationAttribute;

PXZ_EXPORTED extern const CoreI::EntityType TessellationAttributeEntityType;

typedef CoreI::List<Tessellation> TessellationList;

class TopologyDimensionMask {
public:
   typedef enum {
   NONE = 0,
   VERTEX = 1,
   LINE = 2,
   FACE = 4,
   ALL = 7
   } Type;
private:
   Type _value;
public:
   TopologyDimensionMask(Type val = NONE) : _value(val) {}
   TopologyDimensionMask & operator=(Type val) { _value = val; return *this; }
   TopologyDimensionMask(const CoreI::Int& val) : _value((Type)val) {}
   TopologyDimensionMask & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class TopologyConnectivityMask {
public:
   typedef enum {
   NONE = 0,
   MANIFOLD = 1,
   BOUNDARY = 2,
   NONMANIFOLD = 4,
   BOUNDARY_NONMANIFOLD = 6,
   FREE = 8,
   ALL = 15
   } Type;
private:
   Type _value;
public:
   TopologyConnectivityMask(Type val = NONE) : _value(val) {}
   TopologyConnectivityMask & operator=(Type val) { _value = val; return *this; }
   TopologyConnectivityMask(const CoreI::Int& val) : _value((Type)val) {}
   TopologyConnectivityMask & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct TopologyCategoryMask {
   TopologyDimensionMask dimension;
   TopologyConnectivityMask connectivity;
   explicit TopologyCategoryMask(TopologyDimensionMask _dimension = TopologyDimensionMask::ALL, TopologyConnectivityMask _connectivity = TopologyConnectivityMask::ALL) : dimension(_dimension), connectivity(_connectivity) {}
};

typedef Element Vertex;

PXZ_EXPORTED extern const CoreI::EntityType VertexEntityType;

typedef struct {
   CoreI::ByteList buffer;
   CoreI::Int jointIndicesId;
   CoreI::Int jointWeightsId;
} dracoEncodeReturn;

typedef struct {
   Mesh mesh;
   MaterialI::Material material;
} createMeshFromTextReturn;

typedef struct {
   JointList joints;
   GeomI::Matrix4List IBMs;
} getMeshSkinningReturn;


PXZ_MODULE_END

#endif
