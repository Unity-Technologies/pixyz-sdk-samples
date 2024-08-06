// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_POLYGONAL_INTERFACE_IPOLYGONALINTERFACE_H_
#define _PXZ_POLYGONAL_INTERFACE_IPOLYGONALINTERFACE_H_

#include "PolygonalTypes.h"

namespace PiXYZ { class PiXYZAPI; }


PXZ_MODULE_BEGIN(PolygonalI)

class PXZ_EXPORTED IPolygonalInterface
{
public:
   virtual ~IPolygonalInterface() {}

   /*!
     \param functionName 
     \param enableFunction 
     \param enableParameters 
     \param enableExecutionTime 
   */
   virtual void configureFunctionLogger(const CoreI::String & functionName, const CoreI::Boolean & enableFunction, const CoreI::Boolean & enableParameters, const CoreI::Boolean & enableExecutionTime) = 0;


   /**
    * \defgroup checksum functions to compute mesh checksum to identify identical representations
    * @{
    */
   //! Compute a checksum of the mesh topology, connectivity
   /*!
     \param mesh The mesh
     \return checksum The mesh
   */
   virtual CoreI::String computeMeshTopoChecksum(const Mesh & mesh) = 0;

   //! Compute a checksum of the mesh vertices positions
   /*!
     \param mesh The mesh
     \param precisionFloat Floating point precision [1..24], number of significant numbers kept. -1 means no rounded will be applied
     \return checksum The mesh
   */
   virtual CoreI::String computeMeshVertexPositionsChecksum(const Mesh & mesh, const CoreI::Int & precisionFloat = -1) = 0;

   //! Compute a checksum of the uvs topology, connectivity
   /*!
     \param mesh The mesh
     \param uvChannel The uv channel
     \return checksum The mesh
   */
   virtual CoreI::String computeUVTopoChecksum(const Mesh & mesh, const CoreI::Int & uvChannel) = 0;

   //! Compute a checksum of the vertices positions in uv space
   /*!
     \param mesh The mesh
     \param uvChannel The uv channel
     \param precisionFloat Floating point precision [1..24], number of significant numbers kept. -1 means no rounded will be applied
     \return checksum The mesh
   */
   virtual CoreI::String computeUVVertexPositionsChecksum(const Mesh & mesh, const CoreI::Int & uvChannel, const CoreI::Int & precisionFloat = -1) = 0;

   /**@}*/

   /**
    * \defgroup draco Draco compression related functions
    * @{
    */
   //! decode a mesh using draco
   /*!
     \param buffer 
     \param jointIndicesId Unique ID of Generic attribute encoding joint indices
     \param jointWeightsId Unique ID of Generic attribute encoding joint weights
     \return mesh 
   */
   virtual StaticMesh dracoDecode(const CoreI::ByteList & buffer, const CoreI::Int & jointIndicesId = -1, const CoreI::Int & jointWeightsId = -1) = 0;

   //! encode a mesh using draco
   /*!
     \param mesh 
     \param compressionLevel 0=faster but the worst compression, 10=slower but the best compression
     \param quantizationPosition Number of quantization bits used for position attributes
     \param quantizationNormal Number of quantization bits used for normal attributes
     \param quantizationTexCoord Number of quantization bits used for texture coordinates attributes
     \return buffer 
     \return jointIndicesId Unique ID of Generic attribute encoding joint indices (-1 if not applicable or if enocdeSkeleton is false)
     \return jointWeightsId Unique ID of Generic attribute encoding joint weights (-1 if not applicable or if enocdeSkeleton is false)
   */
   virtual dracoEncodeReturn dracoEncode(const StaticMesh & mesh, const CoreI::Int & compressionLevel = 7, const CoreI::Int & quantizationPosition = -1, const CoreI::Int & quantizationNormal = -1, const CoreI::Int & quantizationTexCoord = -1) = 0;

   /**@}*/

   /**
    * \defgroup geometry access functions to access geometry structure of tessellations
    * @{
    */
   //! Create fake joint to store in mesh definitions. Thus we can retrieve stored data from getJointPlaceholders
   /*!
     \param data Create as much joints as there are data, each joint store one data
     \param worldMatrices World matrix for each joints
     \return joints Returns one placeholder joint per given data
   */
   virtual PlaceholderJointList createJointPlaceholders(const CoreI::ULongList & data, const GeomI::Matrix4List & worldMatrices) = 0;

   //! Create a new mesh with the given MeshDefinition
   /*!
     \param meshDefinition Mesh definition
     \return mesh The new mesh
   */
   virtual Mesh createMeshFromDefinition(const MeshDefinition & meshDefinition) = 0;

   //! Create a new mesh from multiple MeshDefinition
   /*!
     \param meshDefinition The MeshDefinitions
     \return mesh The new mesh
   */
   virtual Mesh createMeshFromDefinitions(const MeshDefinitionList & meshDefinition) = 0;

   //! Creates an occurrence from string
   /*!
     \param text Text to create
     \param matrix A matrix to apply on mesh
     \param font The font to use
     \param fontSize The font size
     \param color The occurrence color
     \param heigth3D 3D height of text
     \return mesh 
     \return material 
   */
   virtual createMeshFromTextReturn createMeshFromText(const CoreI::String & text, const GeomI::Matrix4 & matrix, const CoreI::String & font = "ChicFont", const CoreI::Int & fontSize = 64, const CoreI::ColorAlpha & color = CoreI::ColorAlpha(), const CoreI::Double & heigth3D = 40) = 0;

   //! Create new meshes with the given MeshDefinitions
   /*!
     \param meshDefinitions The MeshDefinitions
     \return meshes The new Meshes
   */
   virtual MeshList createMeshesFromDefinitions(const MeshDefinitionList & meshDefinitions) = 0;

   //! Get data stored in joint placeholders
   /*!
     \param joints Placeholder joints to get data from
     \return data Data stored in each placehold joint (for invalid joint, returned data is undefined)
   */
   virtual CoreI::ULongList getJointPlaceholders(const PlaceholderJointList & joints) = 0;

   //! Returns the definition
   /*!
     \param mesh The mesh to get definition
     \return meshDefinition Mesh definition
   */
   virtual MeshDefinition getMeshDefinition(const Mesh & mesh) = 0;

   //! Returns the definition
   /*!
     \param meshes The meshes to get definitions
     \return meshDefinitions The MeshDefinitions
   */
   virtual MeshDefinitionList getMeshDefinitions(const MeshList & meshes) = 0;

   //! Returns the joints/IBMs list of a given mesh (those referenced by jointIndices)
   /*!
     \param mesh 
     \return joints 
     \return IBMs Inverse Bind Matrices
   */
   virtual getMeshSkinningReturn getMeshSkinning(const StaticMesh & mesh) = 0;

   //! Check if the mesh has joints
   /*!
     \param mesh The Mesh
     \return value Return True if the mesh contains joints
   */
   virtual CoreI::Bool hasMeshJoints(const Mesh & mesh) = 0;

   //! Set/Replace the list of joints/IBMs of a given mesh (those referenced by jointIndices)
   /*!
     \param mesh 
     \param joints 
     \param IBMs Inverse Bind Matrices
   */
   virtual void setMeshSkinning(const StaticMesh & mesh, const JointList & joints, const GeomI::Matrix4List & IBMs) = 0;

   /**@}*/

   /**
    * \defgroup modification function to modify the tessellation
    * @{
    */
   //! This triangulates a set of points and normals
   /*!
     \param points The set of points to triangulate
     \param normals The normals associated to the points to triangulate. This can be empty
     \return triangulation The indexes of the points from the given array arranged as triangles
   */
   virtual CoreI::IntList usePointGapFillerNormal(const GeomI::Point3List & points, const GeomI::Vector3List & normals) = 0;

   /**@}*/

};

PXZ_MODULE_END



#endif
