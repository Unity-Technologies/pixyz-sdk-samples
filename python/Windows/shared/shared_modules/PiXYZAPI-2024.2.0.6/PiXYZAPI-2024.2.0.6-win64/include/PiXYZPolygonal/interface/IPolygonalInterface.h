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
    * \defgroup element attributes access functions to access element attributes
    * @{
    */
   //! Return the normal attribute of a polygon at a specified vertex
   /*!
     \param Polygon The polygon
     \param Vertex The vertex
     \return normal The normal
   */
   virtual GeomI::Vector3 getNormal(const Polygon & Polygon, const Vertex & Vertex) = 0;

   //! Return the texture coordinates attribute of all the polygons from the tessellation
   /*!
     \param tessellation The tessellation of the wanted polygons
     \return textureCoordinates The textures coordinates
   */
   virtual UVCoordList getTextureCoordinates(const Tessellation & tessellation) = 0;

   //! return the visible polygons from the Visibility attributes (see algo.createVisibilityAttributes)
   /*!
     \param tessellation The tessellation of the wanted polygons
     \return polygons The polygons seen at least once
     \return pixelCounts The number of pixels seen during the whole visibility session
   */
   virtual getVisiblePolygonsReturn getVisiblePolygons(const Tessellation & tessellation) = 0;

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

   /*!
     \param meshDefinition The MeshDefinitions
     \return mesh The new mesh
   */
   virtual Mesh createMeshFromDefinitions(const MeshDefinitionList & meshDefinition) = 0;

   //! Create new meshes with the given MeshDefinitions
   /*!
     \param meshDefinitions The MeshDefinitions
     \return meshes The new Meshes
   */
   virtual MeshList createMeshesFromDefinitions(const MeshDefinitionList & meshDefinitions) = 0;

   //! Returns the polygons connected to an edge
   /*!
     \param edge The edge
     \return polygons The edge polygons
   */
   virtual PolygonList getEdgePolygons(const Edge & edge) = 0;

   //! Returns the vertices of an edge
   /*!
     \param edge The edge
     \return vertices The edge vertices
   */
   virtual VertexList getEdgeVertices(const Edge & edge) = 0;

   //! Returns the edges corresponding to the given connectivity
   /*!
     \param tessellation The tessellation
     \param category Category mask of the wanted edges
     \return edges The edges
   */
   virtual EdgeList getEdges(const Tessellation & tessellation, const TopologyCategoryMask & category) = 0;

   //! Returns the free edges of a tessellation
   /*!
     \param tessellation The tessellation
     \return freeEdges All free edges of the tessellation
   */
   virtual EdgeList getFreeEdges(const Tessellation & tessellation) = 0;

   //! Returns the free vertices of a tessellation
   /*!
     \param tessellation The tessellation
     \return freeVertices All free vertices of the tessellation
   */
   virtual VertexList getFreeVertices(const Tessellation & tessellation) = 0;

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

   //! Returns the patches of a tessellation
   /*!
     \param tessellation The tessellation
     \return patches All patches of the tessellation
   */
   virtual PatchList getPatches(const Tessellation & tessellation) = 0;

   //! Returns the edges of a a polygon
   /*!
     \param polygon The polygon
     \return edges The polygon edges
   */
   virtual EdgeList getPolygonEdges(const Polygon & polygon) = 0;

   //! Returns the vertices of a a polygon
   /*!
     \param polygon The polygon
     \return vertices The polygon vertices
   */
   virtual VertexList getPolygonVertices(const Polygon & polygon) = 0;

   //! Returns the polygons of a tessellation
   /*!
     \param tessellation The tessellation
     \return polygons All polygons of the tessellation
   */
   virtual PolygonList getPolygons(const Tessellation & tessellation) = 0;

   //! Get boundary edges of a tessellation grouped by cycles
   /*!
     \param tessellation The Tessellation
     \return boundaries List of boundary edges grouped by cycles in the given tessellation
   */
   virtual EdgeListList getTessellationBoundaries(const Tessellation & tessellation) = 0;

   //! Returns the vertex coordinates in the tessellation local space
   /*!
     \param vertex The vertex
     \return coordinates Vertex coordinates
   */
   virtual GeomI::Point3 getVertexCoordinates(const Vertex & vertex) = 0;

   //! Returns the edges connected to a vertex
   /*!
     \param vertex The vertex
     \return edges The vertex edges
   */
   virtual EdgeList getVertexEdges(const Vertex & vertex) = 0;

   //! Returns the polygons connected to a vertex
   /*!
     \param vertex The vertex
     \return polygons The vertex polygons
   */
   virtual PolygonList getVertexPolygons(const Vertex & vertex) = 0;

   //! Returns the vertices of a tessellation
   /*!
     \param tessellation The tessellation
     \param category Category mask of the wanted edges
     \return vertices All vertices of the tessellation
   */
   virtual VertexList getVertices(const Tessellation & tessellation, const TopologyCategoryMask & category) = 0;

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
   //! Destroy all the given elements
   /*!
     \param elements List of elements to destroy
   */
   virtual void destroyElements(const ElementList & elements) = 0;

   //! Invert the orientation of all the given elements
   /*!
     \param elements List of elements to invert
   */
   virtual void invertElements(const ElementList & elements) = 0;

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
