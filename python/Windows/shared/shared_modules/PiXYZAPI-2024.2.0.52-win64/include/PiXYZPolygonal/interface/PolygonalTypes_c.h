// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_POLYGONAL_INTERFACE_POLYGONALTYPES_C_H_
#define _PXZ_POLYGONAL_INTERFACE_POLYGONALTYPES_C_H_

#include <string.h>
#include <PiXYZCore/interface/InterfaceBase_c.h>
#include <PiXYZCore/interface/CoreTypes_c.h>
#include <PiXYZGeom/interface/GeomTypes_c.h>
#include <PiXYZMaterial/interface/MaterialTypes_c.h>


typedef Geom_GeomEntity Polygonal_Element;

typedef Polygonal_Element Polygonal_Edge;

typedef Core_Entity Polygonal_Joint;

typedef struct {
   size_t size;
   Polygonal_Joint * list;
} Polygonal_JointList;

PXZ_EXPORTED void Polygonal_JointList_init(Polygonal_JointList * list, size_t size = 0);
PXZ_EXPORTED void Polygonal_JointList_free(Polygonal_JointList * list);
typedef Geom_GeomEntity Polygonal_Mesh;

typedef struct {
   Material_Material material;
   Core_Int firstTri;
   Core_Int triCount;
   Core_Int firstQuad;
   Core_Int quadCount;
   Core_Ident externalId;
} Polygonal_Submesh;

PXZ_EXPORTED void Polygonal_Submesh_init(Polygonal_Submesh * str);
PXZ_EXPORTED void Polygonal_Submesh_free(Polygonal_Submesh * str);
typedef struct {
   size_t size;
   Polygonal_Submesh * list;
} Polygonal_SubmeshList;

PXZ_EXPORTED void Polygonal_SubmeshList_init(Polygonal_SubmeshList * list, size_t size = 0);
PXZ_EXPORTED void Polygonal_SubmeshList_free(Polygonal_SubmeshList * list);
typedef struct {
   Core_IntList lineVertexIndices;
   Material_Material material;
   Core_Ident externalId;
} Polygonal_StylizedLine;

PXZ_EXPORTED void Polygonal_StylizedLine_init(Polygonal_StylizedLine * str);
PXZ_EXPORTED void Polygonal_StylizedLine_free(Polygonal_StylizedLine * str);
typedef struct {
   size_t size;
   Polygonal_StylizedLine * list;
} Polygonal_StylizedLineList;

PXZ_EXPORTED void Polygonal_StylizedLineList_init(Polygonal_StylizedLineList * list, size_t size = 0);
PXZ_EXPORTED void Polygonal_StylizedLineList_free(Polygonal_StylizedLineList * list);
typedef struct {
   Polygonal_Mesh id;
   Core_Ident externalId;
   Geom_Point3List vertices;
   Geom_Vector3List normals;
   Geom_Vector4List tangents;
   Core_IntList uvChannels;
   Geom_Point2ListList uvs;
   Core_ColorAlphaList vertexColors;
   Geom_CurvaturesList curvatures;
   Core_IntList triangles;
   Core_IntList quadrangles;
   Core_IntList vertexMerged;
   Polygonal_SubmeshList submeshes;
   Geom_Point3List linesVertices;
   Polygonal_StylizedLineList lines;
   Geom_Point3List points;
   Geom_Vector3List pointsColors;
   Polygonal_JointList joints;
   Geom_Matrix4List inverseBindMatrices;
   Geom_Vector4List jointWeights;
   Geom_Vector4IList jointIndices;
} Polygonal_MeshDefinition;

PXZ_EXPORTED void Polygonal_MeshDefinition_init(Polygonal_MeshDefinition * str);
PXZ_EXPORTED void Polygonal_MeshDefinition_free(Polygonal_MeshDefinition * str);
typedef struct {
   size_t size;
   Polygonal_MeshDefinition * list;
} Polygonal_MeshDefinitionList;

PXZ_EXPORTED void Polygonal_MeshDefinitionList_init(Polygonal_MeshDefinitionList * list, size_t size = 0);
PXZ_EXPORTED void Polygonal_MeshDefinitionList_free(Polygonal_MeshDefinitionList * list);
typedef struct {
   size_t size;
   Polygonal_Mesh * list;
} Polygonal_MeshList;

PXZ_EXPORTED void Polygonal_MeshList_init(Polygonal_MeshList * list, size_t size = 0);
PXZ_EXPORTED void Polygonal_MeshList_free(Polygonal_MeshList * list);
typedef Polygonal_Joint Polygonal_PlaceholderJoint;

typedef struct {
   size_t size;
   Polygonal_PlaceholderJoint * list;
} Polygonal_PlaceholderJointList;

PXZ_EXPORTED void Polygonal_PlaceholderJointList_init(Polygonal_PlaceholderJointList * list, size_t size = 0);
PXZ_EXPORTED void Polygonal_PlaceholderJointList_free(Polygonal_PlaceholderJointList * list);
typedef Polygonal_Element Polygonal_Polygon;

typedef Polygonal_Mesh Polygonal_StaticMesh;

typedef enum {
 Polygonal_StyleType_NORMAL = 0,
 Polygonal_StyleType_STIPPLE = 1,
} Polygonal_StyleType;

typedef Polygonal_Mesh Polygonal_Tessellation;

typedef Core_Entity Polygonal_TessellationAttribute;

typedef struct {
   size_t size;
   Polygonal_Tessellation * list;
} Polygonal_TessellationList;

PXZ_EXPORTED void Polygonal_TessellationList_init(Polygonal_TessellationList * list, size_t size = 0);
PXZ_EXPORTED void Polygonal_TessellationList_free(Polygonal_TessellationList * list);
typedef enum {
 Polygonal_TopologyDimensionMask_NONE = 0,
 Polygonal_TopologyDimensionMask_VERTEX = 1,
 Polygonal_TopologyDimensionMask_LINE = 2,
 Polygonal_TopologyDimensionMask_FACE = 4,
 Polygonal_TopologyDimensionMask_ALL = 7,
} Polygonal_TopologyDimensionMask;

typedef enum {
 Polygonal_TopologyConnectivityMask_NONE = 0,
 Polygonal_TopologyConnectivityMask_MANIFOLD = 1,
 Polygonal_TopologyConnectivityMask_BOUNDARY = 2,
 Polygonal_TopologyConnectivityMask_NONMANIFOLD = 4,
 Polygonal_TopologyConnectivityMask_BOUNDARY_NONMANIFOLD = 6,
 Polygonal_TopologyConnectivityMask_FREE = 8,
 Polygonal_TopologyConnectivityMask_ALL = 15,
} Polygonal_TopologyConnectivityMask;

typedef struct {
   Polygonal_TopologyDimensionMask dimension;
   Polygonal_TopologyConnectivityMask connectivity;
} Polygonal_TopologyCategoryMask;

PXZ_EXPORTED void Polygonal_TopologyCategoryMask_init(Polygonal_TopologyCategoryMask * str);
PXZ_EXPORTED void Polygonal_TopologyCategoryMask_free(Polygonal_TopologyCategoryMask * str);
typedef Polygonal_Element Polygonal_Vertex;



#endif
