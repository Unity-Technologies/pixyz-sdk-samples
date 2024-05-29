// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_POLYGONAL_INTERFACE_POLYGONALINTERFACE_C_H_
#define _PXZ_POLYGONAL_INTERFACE_POLYGONALINTERFACE_C_H_

#include "PolygonalTypes_c.h"

PXZ_EXPORTED char * Polygonal_getLastError();

PXZ_EXPORTED void Polygonal_configureFunctionLogger(Session * pxzSession, Core_String functionName, Core_Boolean enableFunction, Core_Boolean enableParameters, Core_Boolean enableExecutionTime);

// ----------------------------------------------------
// checksum
// functions to compute mesh checksum to identify identical representations
// ----------------------------------------------------

// Compute a checksum of the mesh topology, connectivity
PXZ_EXPORTED Core_String Polygonal_computeMeshTopoChecksum(Session * pxzSession, Polygonal_Mesh mesh);
// Compute a checksum of the mesh vertices positions
PXZ_EXPORTED Core_String Polygonal_computeMeshVertexPositionsChecksum(Session * pxzSession, Polygonal_Mesh mesh, Core_Int precisionFloat);
// Compute a checksum of the uvs topology, connectivity
PXZ_EXPORTED Core_String Polygonal_computeUVTopoChecksum(Session * pxzSession, Polygonal_Mesh mesh, Core_Int uvChannel);
// Compute a checksum of the vertices positions in uv space
PXZ_EXPORTED Core_String Polygonal_computeUVVertexPositionsChecksum(Session * pxzSession, Polygonal_Mesh mesh, Core_Int uvChannel, Core_Int precisionFloat);

// ----------------------------------------------------
// draco
// Draco compression related functions
// ----------------------------------------------------

// decode a mesh using draco
PXZ_EXPORTED Polygonal_StaticMesh Polygonal_dracoDecode(Session * pxzSession, Core_ByteList buffer, Core_Int jointIndicesId, Core_Int jointWeightsId);
// encode a mesh using draco
typedef struct {
   Core_ByteList buffer;
   Core_Int jointIndicesId;
   Core_Int jointWeightsId;
} Polygonal_dracoEncodeReturn;
PXZ_EXPORTED Polygonal_dracoEncodeReturn Polygonal_dracoEncode(Session * pxzSession, Polygonal_StaticMesh mesh, Core_Int compressionLevel, Core_Int quantizationPosition, Core_Int quantizationNormal, Core_Int quantizationTexCoord);

// ----------------------------------------------------
// element attributes access
// functions to access element attributes
// ----------------------------------------------------

// Return the normal attribute of a polygon at a specified vertex
PXZ_EXPORTED Geom_Vector3 Polygonal_getNormal(Session * pxzSession, Polygonal_Polygon Polygon, Polygonal_Vertex Vertex);
// Return the texture coordinates attribute of all the polygons from the tessellation
PXZ_EXPORTED Polygonal_UVCoordList Polygonal_getTextureCoordinates(Session * pxzSession, Polygonal_Tessellation tessellation);
// return the visible polygons from the Visibility attributes (see algo.createVisibilityAttributes)
typedef struct {
   Polygonal_PolygonList polygons;
   Core_IntList pixelCounts;
} Polygonal_getVisiblePolygonsReturn;
PXZ_EXPORTED Polygonal_getVisiblePolygonsReturn Polygonal_getVisiblePolygons(Session * pxzSession, Polygonal_Tessellation tessellation);

// ----------------------------------------------------
// geometry access
// functions to access geometry structure of tessellations
// ----------------------------------------------------

// Create fake joint to store in mesh definitions. Thus we can retrieve stored data from getJointPlaceholders
PXZ_EXPORTED Polygonal_PlaceholderJointList Polygonal_createJointPlaceholders(Session * pxzSession, Core_ULongList data, Geom_Matrix4List worldMatrices);
// Create a new mesh with the given MeshDefinition
PXZ_EXPORTED Polygonal_Mesh Polygonal_createMeshFromDefinition(Session * pxzSession, Polygonal_MeshDefinition meshDefinition);
PXZ_EXPORTED Polygonal_Mesh Polygonal_createMeshFromDefinitions(Session * pxzSession, Polygonal_MeshDefinitionList meshDefinition);
// Create new meshes with the given MeshDefinitions
PXZ_EXPORTED Polygonal_MeshList Polygonal_createMeshesFromDefinitions(Session * pxzSession, Polygonal_MeshDefinitionList meshDefinitions);
// Returns the polygons connected to an edge
PXZ_EXPORTED Polygonal_PolygonList Polygonal_getEdgePolygons(Session * pxzSession, Polygonal_Edge edge);
// Returns the vertices of an edge
PXZ_EXPORTED Polygonal_VertexList Polygonal_getEdgeVertices(Session * pxzSession, Polygonal_Edge edge);
// Returns the edges corresponding to the given connectivity
PXZ_EXPORTED Polygonal_EdgeList Polygonal_getEdges(Session * pxzSession, Polygonal_Tessellation tessellation, Polygonal_TopologyCategoryMask category);
// Returns the free edges of a tessellation
PXZ_EXPORTED Polygonal_EdgeList Polygonal_getFreeEdges(Session * pxzSession, Polygonal_Tessellation tessellation);
// Returns the free vertices of a tessellation
PXZ_EXPORTED Polygonal_VertexList Polygonal_getFreeVertices(Session * pxzSession, Polygonal_Tessellation tessellation);
// Get data stored in joint placeholders
PXZ_EXPORTED Core_ULongList Polygonal_getJointPlaceholders(Session * pxzSession, Polygonal_PlaceholderJointList joints);
// Returns the definition
PXZ_EXPORTED Polygonal_MeshDefinition Polygonal_getMeshDefinition(Session * pxzSession, Polygonal_Mesh mesh);
// Returns the definition
PXZ_EXPORTED Polygonal_MeshDefinitionList Polygonal_getMeshDefinitions(Session * pxzSession, Polygonal_MeshList meshes);
// Returns the joints/IBMs list of a given mesh (those referenced by jointIndices)
typedef struct {
   Polygonal_JointList joints;
   Geom_Matrix4List IBMs;
} Polygonal_getMeshSkinningReturn;
PXZ_EXPORTED Polygonal_getMeshSkinningReturn Polygonal_getMeshSkinning(Session * pxzSession, Polygonal_StaticMesh mesh);
// Returns the patches of a tessellation
PXZ_EXPORTED Polygonal_PatchList Polygonal_getPatches(Session * pxzSession, Polygonal_Tessellation tessellation);
// Returns the edges of a a polygon
PXZ_EXPORTED Polygonal_EdgeList Polygonal_getPolygonEdges(Session * pxzSession, Polygonal_Polygon polygon);
// Returns the vertices of a a polygon
PXZ_EXPORTED Polygonal_VertexList Polygonal_getPolygonVertices(Session * pxzSession, Polygonal_Polygon polygon);
// Returns the polygons of a tessellation
PXZ_EXPORTED Polygonal_PolygonList Polygonal_getPolygons(Session * pxzSession, Polygonal_Tessellation tessellation);
// Get boundary edges of a tessellation grouped by cycles
PXZ_EXPORTED Polygonal_EdgeListList Polygonal_getTessellationBoundaries(Session * pxzSession, Polygonal_Tessellation tessellation);
// Returns the vertex coordinates in the tessellation local space
PXZ_EXPORTED Geom_Point3 Polygonal_getVertexCoordinates(Session * pxzSession, Polygonal_Vertex vertex);
// Returns the edges connected to a vertex
PXZ_EXPORTED Polygonal_EdgeList Polygonal_getVertexEdges(Session * pxzSession, Polygonal_Vertex vertex);
// Returns the polygons connected to a vertex
PXZ_EXPORTED Polygonal_PolygonList Polygonal_getVertexPolygons(Session * pxzSession, Polygonal_Vertex vertex);
// Returns the vertices of a tessellation
PXZ_EXPORTED Polygonal_VertexList Polygonal_getVertices(Session * pxzSession, Polygonal_Tessellation tessellation, Polygonal_TopologyCategoryMask category);
// Check if the mesh has joints
PXZ_EXPORTED Core_Bool Polygonal_hasMeshJoints(Session * pxzSession, Polygonal_Mesh mesh);
// Set/Replace the list of joints/IBMs of a given mesh (those referenced by jointIndices)
PXZ_EXPORTED void Polygonal_setMeshSkinning(Session * pxzSession, Polygonal_StaticMesh mesh, Polygonal_JointList joints, Geom_Matrix4List IBMs);

// ----------------------------------------------------
// modification
// function to modify the tessellation
// ----------------------------------------------------

// Destroy all the given elements
PXZ_EXPORTED void Polygonal_destroyElements(Session * pxzSession, Polygonal_ElementList elements);
// Invert the orientation of all the given elements
PXZ_EXPORTED void Polygonal_invertElements(Session * pxzSession, Polygonal_ElementList elements);
// This triangulates a set of points and normals
PXZ_EXPORTED Core_IntList Polygonal_usePointGapFillerNormal(Session * pxzSession, Geom_Point3List points, Geom_Vector3List normals);



#endif
