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
// geometry access
// functions to access geometry structure of tessellations
// ----------------------------------------------------

// Create fake joint to store in mesh definitions. Thus we can retrieve stored data from getJointPlaceholders
PXZ_EXPORTED Polygonal_PlaceholderJointList Polygonal_createJointPlaceholders(Session * pxzSession, Core_ULongList data, Geom_Matrix4List worldMatrices);
// Create a new mesh with the given MeshDefinition
PXZ_EXPORTED Polygonal_Mesh Polygonal_createMeshFromDefinition(Session * pxzSession, Polygonal_MeshDefinition meshDefinition);
// Create a new mesh from multiple MeshDefinition
PXZ_EXPORTED Polygonal_Mesh Polygonal_createMeshFromDefinitions(Session * pxzSession, Polygonal_MeshDefinitionList meshDefinition);
// Creates an occurrence from string
typedef struct {
   Polygonal_Mesh mesh;
   Material_Material material;
} Polygonal_createMeshFromTextReturn;
PXZ_EXPORTED Polygonal_createMeshFromTextReturn Polygonal_createMeshFromText(Session * pxzSession, Core_String text, Geom_Matrix4 matrix, Core_String font, Core_Int fontSize, Core_ColorAlpha color, Core_Double heigth3D);
// Create new meshes with the given MeshDefinitions
PXZ_EXPORTED Polygonal_MeshList Polygonal_createMeshesFromDefinitions(Session * pxzSession, Polygonal_MeshDefinitionList meshDefinitions);
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
// Check if the mesh has joints
PXZ_EXPORTED Core_Bool Polygonal_hasMeshJoints(Session * pxzSession, Polygonal_Mesh mesh);
// Set/Replace the list of joints/IBMs of a given mesh (those referenced by jointIndices)
PXZ_EXPORTED void Polygonal_setMeshSkinning(Session * pxzSession, Polygonal_StaticMesh mesh, Polygonal_JointList joints, Geom_Matrix4List IBMs);

// ----------------------------------------------------
// modification
// function to modify the tessellation
// ----------------------------------------------------

// This triangulates a set of points and normals
PXZ_EXPORTED Core_IntList Polygonal_usePointGapFillerNormal(Session * pxzSession, Geom_Point3List points, Geom_Vector3List normals);



#endif
