// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_ALGO_INTERFACE_IALGOINTERFACE_H_
#define _PXZ_ALGO_INTERFACE_IALGOINTERFACE_H_

#include "AlgoTypes.h"

namespace PiXYZ { class PiXYZAPI; }


PXZ_MODULE_BEGIN(AlgoI)

class PXZ_EXPORTED IAlgoInterface
{
public:
   virtual ~IAlgoInterface() {}

   //! Assemble faces of CAD shapes
   /*!
     \param occurrences Occurrences of components to assemble
     \param tolerance Assembling tolerance
     \param removeDuplicatedFaces If True, duplicated faces will be removed
   */
   virtual void assembleCAD(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & tolerance, const CoreI::Boolean & removeDuplicatedFaces = true) = 0;

   //! Create the BRep shape from a Tessellated shape with Domain Patch Attributes (after tessellate)
   /*!
     \param occurrences Occurrences of components to process
   */
   virtual void backToInitialBRep(const SceneI::OccurrenceList & occurrences) = 0;

   //! bakes impostors textures
   /*!
     \param occurrence 
     \param XFrames 
     \param YFrames 
     \param hemi 
     \param resolution 
     \param padding 
     \param roughness 
     \param metallic 
     \param ao 
     \return octahedralImp The structure containing impostor data
   */
   virtual OctahedralImpostor bakeImpostor(const SceneI::Occurrence & occurrence, const CoreI::Int & XFrames, const CoreI::Int & YFrames, const CoreI::Bool & hemi = false, const CoreI::Int & resolution = 1024, const CoreI::Int & padding = 0, const CoreI::Boolean & roughness = false, const CoreI::Boolean & metallic = false, const CoreI::Boolean & ao = false) = 0;

   //! Bake vertex attributes on meshes from other meshes
   /*!
     \param destinationOccurrences Occurrences of the meshes where to store the baked vertex attributes
     \param sourceOccurrences Occurrences of components from which to bake vertex attributes
     \param skinnedMesh Enabling skinned mesh baking (joint assignation for animation transfer)
     \param positions Enabling vertex position baking
     \param useCurrentPositionAsTPose Use the current position as the T-Pose
   */
   virtual void bakeVertexAttributes(const SceneI::OccurrenceList & destinationOccurrences, const SceneI::OccurrenceList & sourceOccurrences, const CoreI::Boolean & skinnedMesh, const CoreI::Boolean & positions, const CoreI::Boolean & useCurrentPositionAsTPose = false) = 0;

   //! calculate the normal of each point of a Point Cloud
   /*!
     \param occurrences Part occurrences to process
   */
   virtual void calculateNormalsInPointClouds(const SceneI::OccurrenceList & occurrences) = 0;

   //! Explode and (re)merge a set of mesh parts by visible materials
   /*!
     \param occurrences Occurrences of the parts to merge
     \param mergeNoMaterials If true, merge all parts with no active material together, else do not merge them
     \param mergeHiddenPartsMode Hidden parts handling mode, Destroy them, make visible or merge separately
     \return mergedOccurrences Resulting occurrences of the merged parts
   */
   virtual SceneI::OccurrenceList combineMeshesByMaterials(const SceneI::OccurrenceList & occurrences, const CoreI::Boolean & mergeNoMaterials = true, const SceneI::MergeHiddenPartsMode & mergeHiddenPartsMode = SceneI::MergeHiddenPartsMode::Destroy) = 0;

   /*!
     \param functionName 
     \param enableFunction 
     \param enableParameters 
     \param enableExecutionTime 
   */
   virtual void configureFunctionLogger(const CoreI::String & functionName, const CoreI::Boolean & enableFunction, const CoreI::Boolean & enableParameters, const CoreI::Boolean & enableExecutionTime) = 0;

   //! Detect Moebius strip and crack them if there is somme of them in the selection
   /*!
     \param occurrences Occurrences of components to check
   */
   virtual void crackCADMoebiusStrip(const SceneI::OccurrenceList & occurrences) = 0;

   //! crack polygonal edges according to given criteria (deprecated, use crackMeshEdges instead)
   /*!
     \param occurrences Occurrences of components to process
     \param useAttributesFilter Filters by attribute
     \param sharpAngleFilter Sharp angle in degree to filter by edges sharpness, if the angle is negative do not filter
     \param useNonManifoldFilter Filters by manifold-ness.
   */
   virtual void crackEdges(const SceneI::OccurrenceList & occurrences, const CoreI::Boolean & useAttributesFilter = true, const GeomI::Angle & sharpAngleFilter = 45, const CoreI::Boolean & useNonManifoldFilter = false) = 0;

   //! crack polygonal edges according to given criteria
   /*!
     \param occurrences Occurrences of components to process
     \param normal Crack on sharp normals
     \param uvs Crack on UV seams
     \param uvChannels If empty and uvs=true, crack all UV channel, else only channel specified in the list
     \param loi Crack on identifier Lines of Interests
     \param patches Crack on patch borders
     \param nman Crack on non-manifolds
   */
   virtual void crackMeshEdges(const SceneI::OccurrenceList & occurrences, const CoreI::Boolean & normal = false, const CoreI::Boolean & uvs = false, const CoreI::IntList & uvChannels = CoreI::IntList(0), const CoreI::Boolean & loi = false, const CoreI::Boolean & patches = false, const CoreI::Boolean & nman = false) = 0;

   //! Create free edges from patch borders
   /*!
     \param occurrences Occurrences of components to process
   */
   virtual void createFreeEdgesFromPatches(const SceneI::OccurrenceList & occurrences) = 0;

   //! Create identified patch from existing patch (this is useful before cloning for baking)
   /*!
     \param occurrences Occurrences of components to process
   */
   virtual void createIdentifiedPatchesFromPatches(const SceneI::OccurrenceList & occurrences) = 0;

   //! Create an IndexMap and add an UVSet so that each mesh will have UVs refering to one different pixel of the index map and that pixel will have the value i for occurrences[i]. Warning: all occurrences will be singularized
   /*!
     \param occurrences 
     \param uvChannel 
     \param createTexture1D If true, the texture will have a resolution of 1 x occurrences.size, else a square power of two image will be created to fit occurrences.size pixels
     \return indexMap 
   */
   virtual MaterialI::Image createIndexMapFromOccurrences(const SceneI::OccurrenceList & occurrences, const CoreI::Int & uvChannel, const CoreI::Bool & createTexture1D) = 0;

   //! Create normal attributes on tessellations
   /*!
     \param occurrences Occurrences of components to create attributes
     \param sharpEdge Edges with an angle between their polygons greater than sharpEdge will be considered sharp. If negative, smooth normals only.
     \param override If true, override existing normals, else only create normals on meshes without normals
     \param useAreaWeighting If true, normal computation will be weighted using polygon areas
   */
   virtual void createNormals(const SceneI::OccurrenceList & occurrences, const GeomI::Angle & sharpEdge = 45, const CoreI::Boolean & override = true, const CoreI::Boolean & useAreaWeighting = false) = 0;

   //! Create a KD-Tree from some point clouds occurrence, the given occurrences are deleted (even if they contains triangles) and the KD-Tree is represented in a new occurrence sub tree
   /*!
     \param occurrences Occurrences to process
     \param depth Kd tree depth
     \param addToScene Add the KD-Tree to the current scene
     \return root KD-Tree root occurrence
   */
   virtual SceneI::Occurrence createPointCloudKDTree(const SceneI::OccurrenceList & occurrences, const CoreI::Int & depth, const CoreI::Bool & addToScene = true) = 0;

   //! Create tangent attributes on tessellations
   /*!
     \param occurrences Occurrences of components to create attributes
     \param uvChannel UV channel to use for the tangents creation
     \param override If true, override existing tangents, else only create tangents on meshes without tangents
   */
   virtual void createTangents(const SceneI::OccurrenceList & occurrences, const CoreI::Int & uvChannel = 0, const CoreI::Boolean & override = true) = 0;

   //! Bake vertex colors using main material color. May duplicate some vertices
   /*!
     \param occurrenceList 
   */
   virtual void createVertexColorFromMaterials(const SceneI::OccurrenceList & occurrenceList) = 0;

   //! Create visibility patches from existing patches
   /*!
     \param occurrences Occurrences of components to process
   */
   virtual void createVisibilityPatchesFromPatch(const SceneI::OccurrenceList & occurrences) = 0;

   //! reduce the polygon count by removing some vertices
   /*!
     \param occurrences Occurrences of components to process
     \param surfacicTolerance Maximum distance between surfacic vertices and resulting simplified surfaces
     \param lineicTolerance Maximum distance between lineic vertices and resulting simplified lines
     \param normalTolerance Maximum angle between original normals and those interpolated on the simplified surface
     \param texCoordTolerance Maximum distance (in 3D space) between original texcoords and those interpolated on the simplified surface
     \param releaseConstraintOnSmallArea If True, release constraint of normal and/or texcoord tolerance on small areas (according to surfacicTolerance)
   */
   virtual void decimate(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & surfacicTolerance, const GeomI::Distance & lineicTolerance = 0.1, const GeomI::Angle & normalTolerance = 5, const GeomI::Distance & texCoordTolerance = -1, const CoreI::Boolean & releaseConstraintOnSmallArea = false) = 0;

   //! reduce the polygon count by collapsing some edges to obtain an simplified mesh
   /*!
     \param occurrences Occurrences of components to process
     \param surfacicTolerance Error max between the simplified mesh et the old one
     \param boundaryWeight Boundary importance during the decimation
     \param normalWeight Normal importance during the decimation
     \param UVWeight UV importance during the decimation
     \param sharpNormalWeight Importance of sharp edges during the decimation
     \param UVSeamWeight Importance of UV seams during the decimation
     \param normalMaxDeviation Constraint the normals deviation on decimated model
     \param forbidUVOverlaps Forbid UV to fold over and overlap during the decimation
     \param UVMaxDeviation Constraint the uv deviation on decimated model
     \param UVSeamMaxDeviation Constraint the uv seams deviation on decimated model
     \param protectTopology If false, the topology of the mesh can change and some edges can become non-manifold. But the visual quality will be better on model with complex topology
     \param qualityTradeoff For big models it is recommended to choose PreferSpeed tradeoff. In PreferSpeed mode, quadrics are computed only on position (and not on other vertex attributes)
   */
   virtual void decimateEdgeCollapse(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & surfacicTolerance, const CoreI::Double & boundaryWeight = 1., const CoreI::Double & normalWeight = 1., const CoreI::Double & UVWeight = 1., const CoreI::Double & sharpNormalWeight = 1., const CoreI::Double & UVSeamWeight = 10., const GeomI::Angle & normalMaxDeviation = -1, const CoreI::Boolean & forbidUVOverlaps = true, const CoreI::Double & UVMaxDeviation = -1, const CoreI::Double & UVSeamMaxDeviation = -1, const CoreI::Boolean & protectTopology = false, const QualitySpeedTradeoff & qualityTradeoff = QualitySpeedTradeoff::PreferQuality) = 0;

   //! decimate Point Cloud Occurrences according to tolerance 
   /*!
     \param occurrences Part occurrences to process
     \param tolerance Avarage distance between points
   */
   virtual void decimatePointClouds(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & tolerance = 500) = 0;

   //! reduce the polygon count by collapsing some edges to obtain a target triangle count (iterative version that use less memory)
   /*!
     \param occurrences List of occurrences to process
     \param targetStrategy Select between targetCount or ratio to define the number of triangles left after the decimation process
     \param UVImportance Select importance of texture coordinates
     \param protectTopology If False, the topology of the mesh can change and some edges can become non-manifold
     \param iterativeThreshold Number of triangles above which the iterative algorithm is used to limit the memory usage (disabled if processMeshIndependently=True)
     \param processMeshIndependently If true, each mesh will be processed independently and the triangleCount or ratio will apply by mesh (disable iterative method)
     \param maxQuadricAge If >0, define the maximum memory (number of collapse) of a vertex before a new evaluation of its quadric
   */
   virtual void decimateTarget(const SceneI::OccurrenceList & occurrences, const DecimateOptionsSelector & targetStrategy, const UVImportanceEnum & UVImportance = UVImportanceEnum::PreserveSeamsAndReduceDeformation, const CoreI::Boolean & protectTopology = false, const CoreI::ULong & iterativeThreshold = 5000000, const CoreI::Boolean & processMeshIndependently = false, const CoreI::Int & maxQuadricAge = -1) = 0;

   //! Delete designed attribute on tessellations
   /*!
     \param occurrence Occurrence to detele attribute from
     \param type Attribute type
   */
   virtual void deleteAttibute(const SceneI::Occurrence & occurrence, const AttributType & type) = 0;

   //! Delete BRep representation on parts
   /*!
     \param occurrences Occurrences of components to process
     \param onlyTessellated If True, delete only BRep represensation on part with a tessellated shape
   */
   virtual void deleteBRepShapes(const SceneI::OccurrenceList & occurrences, const CoreI::Boolean & onlyTessellated = true) = 0;

   //! Delete all free vertices of the mesh of given parts
   /*!
     \param occurrences Occurrences of components to process
   */
   virtual void deleteFreeVertices(const SceneI::OccurrenceList & occurrences) = 0;

   //! Delete all free line of the mesh of given parts
   /*!
     \param occurrences Occurrences of components to process
   */
   virtual void deleteLines(const SceneI::OccurrenceList & occurrences) = 0;

   //! Remove normal attributes on tessellations
   /*!
     \param occurrences Occurrences of components to delete
   */
   virtual void deleteNormals(const SceneI::OccurrenceList & occurrences) = 0;

   //! Delete patches attributes on tessellations
   /*!
     \param occurrences Occurrences of components to process
     \param keepOnePatchByMaterial If set, one patch by material will be kept, else all patches will be deleted and materials on patches will be lost
   */
   virtual void deletePatches(const SceneI::OccurrenceList & occurrences, const CoreI::Boolean & keepOnePatchByMaterial = true) = 0;

   //! Delete all polygons of the mesh of given parts
   /*!
     \param occurrences Occurrences of components to process
   */
   virtual void deletePolygons(const SceneI::OccurrenceList & occurrences) = 0;

   //! Remove tangent attributes on tessellations
   /*!
     \param occurrences Occurrences of components to delete
   */
   virtual void deleteTangents(const SceneI::OccurrenceList & occurrences) = 0;

   //! Delete texture coordinates on tessellations
   /*!
     \param occurrences Occurrences of components to process
     \param channel Choose Texture coordinates channel to delete (-1 for all channels)
   */
   virtual void deleteTextureCoordinates(const SceneI::OccurrenceList & occurrences, const CoreI::Int & channel = -1) = 0;

   //! delete the visibility patches of given occurrences
   /*!
     \param occurrences Occurrences of components to process
   */
   virtual void deleteVisibilityPatches(const SceneI::OccurrenceList & occurrences) = 0;

   //! returns the max error to set to reach a given target
   /*!
     \param occurrences List of occurrences to process
     \param TargetStrategy Select between targetCount or ratio to define the number of triangles left after the decimation process
     \param boundaryWeight Defines how important the edges defining the mesh boundaries (free edges) are during the decimation process, to preserve them from distortion
     \param normalWeight Defines how important vertex normals are during the decimation process, to preserve the smoothing of the mesh from being damaged
     \param UVWeight Defines how important UVs (texture coordinates) are during the decimation process, to preserve them from being distorted (along with the textures using the UVs)
     \param sharpNormalWeight Defines how important sharp edges (or hard edges) are during the decimation process, to preserve them from being distorted
     \param UVSeamWeight Defines how important UV seams (UV islands contours) are during the decimation process, to preserve them from being distorted (along with the textures using the UVs)
     \param forbidUVFoldovers Forbids UVs to fold over and overlap each other during the decimation
     \param protectTopology If False, the topology of the mesh can change and some edges can become non-manifold; but the visual quality will be better on model with complex topology
     \return errorMax Max error that can be used in decimateEdgeCollapse function
   */
   virtual CoreI::Double evalDecimateErrorForTarget(const SceneI::OccurrenceList & occurrences, const DecimateOptionsSelector & TargetStrategy, const CoreI::Double & boundaryWeight = 1., const CoreI::Double & normalWeight = 1., const CoreI::Double & UVWeight = 1., const CoreI::Double & sharpNormalWeight = 1., const CoreI::Double & UVSeamWeight = 10., const CoreI::Boolean & forbidUVFoldovers = true, const CoreI::Boolean & protectTopology = false) = 0;

   //! Extract neutral axis from tessellations
   /*!
     \param occurrences Occurrences of components to process
     \param maxDiameter Maximum diameter of beams
     \param removeOriginalMesh Remove or not the original mesh at the end of the algorithm
   */
   virtual void extractNeutralAxis(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & maxDiameter, const CoreI::Boolean & removeOriginalMesh) = 0;

   //! Fillet a mesh according to its Lines of Interest
   /*!
     \param occurrences Input occurrences
     \param value Value (mm)
     \param filletingMode Filleting mode
     \param subdivisionNb Number of subdivision
     \param createFlatChamfer If there is 0 subdivision, should the fillet be a planar flat chamfer?
     \param material Material to apply to created fillets. Default: use a random neighbor material
     \param uvChannel UV Channel for the created fillet polygons. Defaults: Use an existing channel if there is one.
   */
   virtual void filletMesh(const SceneI::OccurrenceList & occurrences, const CoreI::Double & value, const FilletingMode & filletingMode = FilletingMode::Width, const CoreI::Int & subdivisionNb = 0, const CoreI::Boolean & createFlatChamfer = false, const MaterialI::Material & material = MaterialI::Material(), const CoreI::Int & uvChannel = -1) = 0;

   //! remove hidden polygons using voxels and cavities
   /*!
     \param occurrences Part occurrences to process
     \param voxelSize Size of voxels
   */
   virtual void filterHiddenPolygons(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & voxelSize) = 0;

   //! Try to compute the pivot point between 2 sets of occurrences
   /*!
     \param assembly1 Set occurrences 1
     \param assembly2 Set occurrences 2
     \param precision Precision used to determine if elements are similar
     \return matrix Best pivot between the two assembly. If impossible, return the null Matrix4
   */
   virtual GeomI::Matrix4 findBestPivotBetweenOccurrences(const SceneI::OccurrenceList & assembly1, const SceneI::OccurrenceList & assembly2, const CoreI::Double & precision = -1) = 0;

   //! Return all the main axis contained in the CAD models given
   /*!
     \param occurrences Occurrences of components to check
     \return occurrences Occurrence part that contained CAD part
     \return axis The main axis from the CAD models
   */
   virtual getAllAxisFromCADModelReturn getAllAxisFromCADModel(const SceneI::OccurrenceList & occurrences) = 0;

   //! Returns the optimal resolution based on a number of texels per 3D space units (e.g : mm)
   /*!
     \param occurrences Occurrences on which to compute optimal texture resolution
     \param texelPerMm Number of texel per millimeter in a 3D space
     \return textureResolution 
   */
   virtual CoreI::Int getOptimalTextureResolution(const SceneI::OccurrenceList & occurrences, const CoreI::Double & texelPerMm) = 0;

   //! returns all the tessellation of the given occurrences (only returns editable mesh, see algo.toEditableMesh)
   /*!
     \param occurrences Occurrences of components to process
     \return tessellations All the tessellation of the given occurrences
   */
   virtual PolygonalI::TessellationList getTessellations(const SceneI::OccurrenceList & occurrences) = 0;

   //! Returns the ratio of size between UV and 3D (max value, actually at the 90th percentil)
   /*!
     \param occurrences Occurrences on which to compute optimal texture resolution
     \return ratio Equivalent size of 1 in the UV space in 3D (e.g. Ratio/resolution give the 3D size of a texel))
   */
   virtual CoreI::Double getUV3dRatio(const SceneI::OccurrenceList & occurrences) = 0;

   //! returns the visibility statistics for some occurrences
   /*!
     \param occurrences Occurrences of components to process
     \return visibleCountFront 
     \return visibleCountBack 
   */
   virtual getVisibilityStatsReturn getVisibilityStats(const SceneI::OccurrenceList & occurrences) = 0;

   //! Compute the visual footprint of the difference between two sets of occurrences
   /*!
     \param originalOccurrences Set of occurrences representing the ground truth
     \param comparedOccurrences Set of occurrences to compare with the ground truth
     \param resolution Resolution of the viewer
     \param viewpointCount Number of viewpoints generated around the bounding sphere of all occurrences
     \param threshold Tolerance for pixel comparison
     \param onHemisphereOnly Create viewpoints only in the Y+ hemisphere of the bounding sphere
     \return footprint The visual footprint error in mm (worldspace)
   */
   virtual CoreI::Double getVisualComparisonFootprint(const SceneI::OccurrenceList & originalOccurrences, const SceneI::OccurrenceList & comparedOccurrences, const CoreI::Int & resolution = 512, const CoreI::Int & viewpointCount = 256, const CoreI::Double & threshold = 0.2, const CoreI::Bool & onHemisphereOnly = false) = 0;

   //! Identify LoI according to given criteria. It will create a new LoI attribute on the mesh that can be used afterward by some functions
   /*!
     \param occurrences Occurrences of components to process
     \param normal Add LoI on sharp normals
     \param uvs Add LoI on UV seams
     \param uvChannels If empty and uvs=true, add LoI using all UV channels, else only channel specified in the list
     \param border Add LoI on boundary edges
     \param patches Add LoI on submesh borders
     \param nman Add LoI on non-manifolds edges
   */
   virtual void identifyLinesOfInterest(const SceneI::OccurrenceList & occurrences, const CoreI::Boolean & normal = false, const CoreI::Boolean & uvs = false, const CoreI::IntList & uvChannels = CoreI::IntList(0), const CoreI::Boolean & border = false, const CoreI::Boolean & patches = false, const CoreI::Boolean & nman = false) = 0;

   //! Create patches (submeshes) on meshes (needed by some functions)
   /*!
     \param occurrences Occurrences of components to process
     \param useAttributesFilter Filters by attributes
     \param sharpAngleFilter Sharp angle in degree to filter by edges sharpness, if the angle is negative do not filter
     \param useBoundaryFilter Filters by boundaries
     \param useNonManifoldFilter Filters by manifold-ness
     \param useLineEdgeFilter Filters by edge
     \param useQuadLineFilter Filters by quad lines
   */
   virtual void identifyPatches(const SceneI::OccurrenceList & occurrences, const CoreI::Boolean & useAttributesFilter = true, const GeomI::Angle & sharpAngleFilter = 45, const CoreI::Boolean & useBoundaryFilter = true, const CoreI::Boolean & useNonManifoldFilter = true, const CoreI::Boolean & useLineEdgeFilter = true, const CoreI::Boolean & useQuadLineFilter = false) = 0;

   //! Mark as Lines Of Interest the sharp edges 
   /*!
     \param occurrences Input occurrences
     \param minSharpAngle The angle between the normals - all edges sharpest than this will be filleted
     \param maxSharpAngle All edges sharpest than this won't be filleted
     \param convexity Fillet sharp edges that are convex, concave or both
     \param onlyExplicitSharp If toggled, if the explicit normals of an edge says the transition is smooth, the edge won't be selected
   */
   virtual void identifySharpEdges(const SceneI::OccurrenceList & occurrences, const GeomI::Angle & minSharpAngle, const GeomI::Angle & maxSharpAngle = 180, const ConvexityFilter & convexity = ConvexityFilter::OnConvexAndConcave, const CoreI::Boolean & onlyExplicitSharp = false) = 0;

   //! Generate a textured quadrangle over an existing mesh of coplanar lines
   /*!
     \param lines Lines to select
     \param useColor Set color policy.
     \param resolution Texture resolution
     \param thickness The thickness of the lines in pixels
   */
   virtual void lineToTexture(const SceneI::OccurrenceList & lines, const UseColorOption & useColor, const CoreI::Int & resolution = 512, const CoreI::Int & thickness = 5) = 0;

   //! List features from tessellations
   /*!
     \param occurrences Occurrences of components to process
     \param throughHoles List through holes
     \param blindHoles List blind holes
     \param maxDiameter Maximum diameter of the holes to be list (-1=no max diameter)
     \return features List of features by occurrence
   */
   virtual OccurrenceFeaturesList listFeatures(const SceneI::OccurrenceList & occurrences, const CoreI::Boolean & throughHoles = true, const CoreI::Boolean & blindHoles = false, const GeomI::Distance & maxDiameter = -1) = 0;

   //! Apply Loop Subdivision on Triangle-only Mesh
   /*!
     \param occurrences Occurrences of components to process
     \param depth Subdivision depth
   */
   virtual void loopSubdivMesh(const SceneI::OccurrenceList & occurrences, const CoreI::Int & depth) = 0;

   //! merge near vertices according to the given distance
   /*!
     \param occurrences Occurrences of components to process
     \param maxDistance Maximum distance between two vertex to merge
     \param mask Topological category of the vertices to merge
   */
   virtual void mergeVertices(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & maxDistance, const PolygonalI::TopologyCategoryMask & mask) = 0;

   //! Computes the boolean operation between the meshes of two occurrence lists
   /*!
     \param occurrencesA Occurrences A
     \param occurrencesB Occurrences B
     \param operation The operation to perform
     \return occurrence A new Occurrence bearing the result
   */
   virtual SceneI::Occurrence meshBooleanOperation(const SceneI::OccurrenceList & occurrencesA, const SceneI::OccurrenceList & occurrencesB, const MeshBooleanOperation & operation) = 0;

   //! compare two meshes
   /*!
     \param mesh_1 
     \param mesh_2 
     \return distance Disance between two meshes
   */
   virtual GeomI::Distance meshComparison(const SceneI::Occurrence & mesh_1, const SceneI::Occurrence & mesh_2) = 0;

   //! compare each couple of meshes and returns the maximum for each couple
   /*!
     \param meshes1 
     \param meshes2 
     \return distances Disance between each couple of meshes
   */
   virtual GeomI::DistanceList meshComparisonBatch(const SceneI::OccurrenceList & meshes1, const SceneI::OccurrenceList & meshes2) = 0;

   //! Computes the list of polylines at the intersections of the meshes of two occurrence lists
   /*!
     \param occurrencesA Occurrences A
     \param occurrencesB Occurrences B
     \return intersections The intersections
   */
   virtual GeomI::Point3ListList meshIntersections(const SceneI::OccurrenceList & occurrencesA, const SceneI::OccurrenceList & occurrencesB) = 0;

   //! Apply noise to vertex positions along their normals
   /*!
     \param occurrences Part occurrencess to noise
     \param maxAmplitude Maximum distance between original vertex and noisy vertex
   */
   virtual void noiseMesh(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & maxAmplitude) = 0;

   //! Optimize CAD Face loops by merging useless loop edges
   /*!
     \param occurrences Occurrences of components to optimize
   */
   virtual void optimizeCADLoops(const SceneI::OccurrenceList & occurrences) = 0;

   //! Optimize mesh for rendering (lossless, only reindexing)
   /*!
     \param occurrences Occurrences of components to optimize
   */
   virtual void optimizeForRendering(const SceneI::OccurrenceList & occurrences) = 0;

   //! Sort sub meshes by materials
   /*!
     \param occurrences Part occurrencess to process
   */
   virtual void optimizeSubMeshes(const SceneI::OccurrenceList & occurrences) = 0;

   //! Resizes scene textures based on a number of texels per 3D space units (e.g: mm)
   /*!
     \param root Root from which texture resizing will process
     \param texelPerMm Number of texel per millimeter in a 3D space
   */
   virtual void optimizeTextureSize(const SceneI::Occurrence & root, const CoreI::Double & texelPerMm) = 0;

   //! Remove some features from tessellations
   /*!
     \param occurrences Occurrences of components to process
     \param throughHoles Remove through holes
     \param blindHoles Remove blind holes
     \param surfacicHoles Remove surfacic holes
     \param maxDiameter Maximum diameter of the holes to be removed (-1=no max diameter)
     \param fillWithMaterial If set, the given material will be used to fill the holes
   */
   virtual void removeHoles(const SceneI::OccurrenceList & occurrences, const CoreI::Boolean & throughHoles, const CoreI::Boolean & blindHoles, const CoreI::Boolean & surfacicHoles, const GeomI::Distance & maxDiameter, const MaterialI::Material & fillWithMaterial = 0) = 0;

   //! Repair CAD shapes, assemble faces, remove duplicated faces, optimize loops and repair topology
   /*!
     \param occurrences Occurrences of components to clean
     \param tolerance Tolerance
     \param orient If true reorient the model
   */
   virtual void repairCAD(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & tolerance, const CoreI::Boolean & orient = true) = 0;

   //! Segment Mesh into clusters guided by edge sharpnesses.
   /*!
     \param occurrences Occurrences of components to process
     \param overwriteLoI Overwrite the lines-of-interest parameters if true, else add them
   */
   virtual void segmentMesh(const SceneI::OccurrenceList & occurrences, const CoreI::Boolean & overwriteLoI = true) = 0;

   //! Remap Index map of each FeatureComponent of selected occurrences
   /*!
     \param occurrences 
     \param maxIndex 
   */
   virtual void setFeatureComponentMaxIndex(const SceneI::OccurrenceList & occurrences, const CoreI::Int & maxIndex) = 0;

   /*!
     \param occurrences Occurrences of components to process
     \param mode Computation of cost
     \param maxIterations Maximum number of swapping iteration
     \param lockSignificantEdges Forbid to swap significant edges (e.g. UV seams, sharp edges, patch borders, ...)
   */
   virtual void smoothMesh(const SceneI::OccurrenceList & occurrences, const CostEvaluation & mode, const CoreI::Int & maxIterations = 100, const CoreI::Boolean & lockSignificantEdges = true) = 0;

   /*!
     \param occurrences Input occurrences
   */
   virtual void splitUVForAtlas(const SceneI::OccurrenceList & occurrences) = 0;

   //! Extrudes a circular section along an underlying polyline (curve)
   /*!
     \param occurrences Occurrences of components to check
     \param radius Radius of cylinders
     \param sides Number of points to create cylinders
     \param createNormals 
     \param keepLines 
     \param generateUV 
   */
   virtual void sweep(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & radius, const CoreI::Int & sides, const CoreI::Boolean & createNormals, const CoreI::Boolean & keepLines, const CoreI::Boolean & generateUV) = 0;

   //! Create a tessellated representation from a CAD representation for each given part
   /*!
     \param occurrences Occurrences of components to tessellate
     \param maxSag Maximum distance between the geometry and the tessellation
     \param maxLength Maximum length of elements
     \param maxAngle Maximum angle between normals of two adjacent elements
     \param createNormals If true, normals will be generated
     \param uvMode Select the texture coordinates generation mode
     \param uvChannel The UV channel of the generated texture coordinates (if any)
     \param uvPadding The UV padding between UV island in UV coordinate space (between 0-1). This parameter is handled as an heuristic so it might not be respected
     \param createTangents If true, tangents will be generated
     \param createFreeEdges If true, free edges will be created for each patch borders
     \param keepBRepShape If true, BRep shapes will be kept for Back to Brep or Retessellate
     \param overrideExistingTessellation If true, already tessellated parts will be re-tessellated
   */
   virtual void tessellate(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & maxSag, const GeomI::Distance & maxLength, const GeomI::Angle & maxAngle, const CoreI::Boolean & createNormals = true, const UVGenerationMode & uvMode = UVGenerationMode::NoUV, const CoreI::Int & uvChannel = 1, const CoreI::Double & uvPadding = 0.0, const CoreI::Boolean & createTangents = false, const CoreI::Boolean & createFreeEdges = false, const CoreI::Boolean & keepBRepShape = true, const CoreI::Boolean & overrideExistingTessellation = false) = 0;

   //! Tessellate point clouds to replace the geometry with a polygonal connect mesh
   /*!
     \param occurrences 
     \param kNeighbors The number of neighbor points used to compute normals
     \param keepPoints Keep points after meshing if enabled
     \param colorize If enabled, vertex colors will be generated on the resulting mesh
   */
   virtual void tessellatePointClouds(const SceneI::OccurrenceList & occurrences, const CoreI::Int & kNeighbors = 20, const CoreI::Boolean & keepPoints = false, const CoreI::Boolean & colorize = true) = 0;

   //! Creates a tessellated representation from a CAD representation for each given part. It multiplies the length of the diagonal of the bounding box by the sagRatio. If the output value is above maxSag, then maxSag is used as tessellation value. Else if the output value is below maxSag, it is used as tessellation value.
   /*!
     \param occurrences Occurrences of components to tessellate
     \param maxSag Maximum distance between the geometry and the tessellation
     \param sagRatio Maximum ratio distance between the geometry and the tessellation
     \param maxLength Maximum length of elements
     \param maxAngle Maximum angle between normals of two adjacent elements
     \param createNormals If true, normals will be generated
     \param uvMode Select the texture coordinates generation mode
     \param uvChannel The UV channel of the generated texture coordinates (if any)
     \param uvPadding The UV padding between UV island in UV coordinate space (between 0-1). This parameter is handled as an heuristic so it might not be respected
     \param createTangents If true, tangents will be generated
     \param createFreeEdges If true, free edges will be created for each patch borders
     \param keepBRepShape If true, BRep shapes will be kept for Back to Brep or Retessellate
     \param overrideExistingTessellation If true, already tessellated parts will be re-tessellated
   */
   virtual void tessellateRelativelyToAABB(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & maxSag, const CoreI::Double & sagRatio, const GeomI::Distance & maxLength, const GeomI::Angle & maxAngle, const CoreI::Boolean & createNormals = true, const UVGenerationMode & uvMode = UVGenerationMode::NoUV, const CoreI::Int & uvChannel = 1, const CoreI::Double & uvPadding = 0.0, const CoreI::Boolean & createTangents = false, const CoreI::Boolean & createFreeEdges = false, const CoreI::Boolean & keepBRepShape = true, const CoreI::Boolean & overrideExistingTessellation = false) = 0;

   //! Explode point clouds to voxels
   /*!
     \param occurrences Part occurrences to process
     \param voxelSize Size of voxels
   */
   virtual void voxelizePointClouds(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & voxelSize = 500) = 0;


   /**
    * \defgroup Baking 
    * @{
    */
   //! Combine materials found on occurrences subtrees into one baked material and assign it to part occurrences
   /*!
     \param occurrences Root occurrences to process
     \param bakingOptions Baking options
     \param overrideExistingUVs If True, override existing UVs on channel
     \param singularizeOnAO If true, singularize all instances in the selected subtree if we want to bake AO in the texture
   */
   virtual void combineMaterials(const SceneI::OccurrenceList & occurrences, const BakeOption & bakingOptions, const CoreI::Boolean & overrideExistingUVs = true, const CoreI::Boolean & singularizeOnAO = false) = 0;

   //! Transfer UV from a mesh to another mesh
   /*!
     \param source Occurrence of the source mesh
     \param destination Occurrence of the destination mesh
     \param sourceChannel Source UV channel to bake
     \param destinationChannel Destination UV channel to bake to
     \param tolerance Geometric tolerance for point projection
   */
   virtual void transferUV(const SceneI::Occurrence & source, const SceneI::Occurrence & destination, const CoreI::Int & sourceChannel = 0, const CoreI::Int & destinationChannel = 0, const GeomI::Distance & tolerance = 0.001) = 0;

   /**@}*/

   /**
    * \defgroup Decomposition 
    * @{
    */
   //! Explode each mesh to approximated convex decomposition
   /*!
     \param occurrences Part occurrences to process
     \param maxCount Maximum number of convex hull to generated
     \param vertexCount Maximum number of vertices per convex hull
     \param approximate Approximate method
     \param resolution Resolution
     \param concavity Concavity
     \return newOccurrences Resulting occurrences of the convexDecomposition
   */
   virtual SceneI::OccurrenceList convexDecomposition(const SceneI::OccurrenceList & occurrences, const CoreI::Int & maxCount, const CoreI::Int & vertexCount, const CoreI::Boolean & approximate, const CoreI::Int & resolution = 100000, const CoreI::Double & concavity = 0.001) = 0;

   //! Explode all CAD Parts by body. New parts will be placed as children of input part occurrences.
   /*!
     \param occurrences Part occurrences to process
     \param groupOpenShells Group all open shells in one part
   */
   virtual void explodeBodies(const SceneI::OccurrenceList & occurrences, const CoreI::Boolean & groupOpenShells = false) = 0;

   //! Explode all parts by material. New parts will be placed as children of input part occurrences.
   /*!
     \param occurrences Part occurrences to process
   */
   virtual void explodeByMaterials(const SceneI::OccurrenceList & occurrences) = 0;

   //! Explode part occurrences to respect a maximum vertex count
   /*!
     \param occurrences Part occurrences to process
     \param maxVertexCount The maximum number of vertices by part
     \param maxTriangleCount The maximum number of triangles by part (quadrangles count twice)
     \param countMergedVerticesOnce If true, one vertex used in several triangles with different normals will be counted once (for Unity must be False)
   */
   virtual void explodeByVertexCount(const SceneI::OccurrenceList & occurrences, const CoreI::Int & maxVertexCount, const CoreI::Int & maxTriangleCount, const CoreI::Boolean & countMergedVerticesOnce = true) = 0;

   //! Explode parts by voxel. New parts will be placed as children of input part occurrences.
   /*!
     \param occurrences Part occurrences to process
     \param voxelSize Voxel size
   */
   virtual void explodeByVoxel(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & voxelSize) = 0;

   //! Explode connected set of polygons to part occurrences. New parts will be placed as children of input part occurrences.
   /*!
     \param occurrences Part occurrences to process
     \param explodeNonManifoldEdges Split connected components along non-manifold edges
   */
   virtual void explodeConnectedMeshes(const SceneI::OccurrenceList & occurrences, const CoreI::Boolean & explodeNonManifoldEdges = false) = 0;

   //! Explode all parts by patch
   /*!
     \param occurrences Part occurrences to process
   */
   virtual void explodePatches(const SceneI::OccurrenceList & occurrences) = 0;

   /**@}*/

   /**
    * \defgroup Occlusion Detection All occlusion detection/removal related function
    * @{
    */
   //! Create visilibity information on part occurrences viewed from a set of camera automatically placed on a sphere around the scene
   /*!
     \param occurrences Occurrences of components to process
     \param level Level of geometries to create visibility information on: Parts, Patches or Polygons
     \param resolution Resolution of the visibility viewer
     \param sphereCount Number of viewpoints generated around the bounding sphere
     \param fovX Horizontal field of view (in degree)
     \param considerTransparentOpaque If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque
     \param root Specify another root for occluder scene
     \param onHemisphereOnly Create viewpoints only in the Y+ hemisphere of the bounding sphere
   */
   virtual void createVisibilityInformation(const SceneI::OccurrenceList & occurrences, const SelectionLevel & level, const CoreI::Int & resolution, const CoreI::Int & sphereCount, const CoreI::Double & fovX = 90, const CoreI::Boolean & considerTransparentOpaque = false, const SceneI::Occurrence & root = 0, const CoreI::Bool & onHemisphereOnly = false) = 0;

   //! Create visilibity information on part occurrences viewed from a set of voxel based view points.
   /*!
     \param occurrences Occurrences of components to process
     \param level Level of geometries to create visibility information on: Parts, Patches or Polygons
     \param voxelSize Size of the voxels in mm (smaller it is, more viewpoints there are)
     \param minimumCavityVolume Minimum volume of a cavity in cubic meter (smaller it is, more viewpoints there are)
     \param resolution Resolution of the visibility viewer
     \param mode Select where to place camera (all cavities, only outer or only inner cavities)
     \param considerTransparentOpaque If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque
     \param root Specify another root for occluder scene
   */
   virtual void createVisibilityInformationAdvanced(const SceneI::OccurrenceList & occurrences, const SelectionLevel & level, const GeomI::Distance & voxelSize, const GeomI::Volume & minimumCavityVolume, const CoreI::Int & resolution, const InnerOuterOption & mode = InnerOuterOption::All, const CoreI::Boolean & considerTransparentOpaque = false, const SceneI::Occurrence & root = 0) = 0;

   //! Create visilibity information on parts viewed from a given set of camera
   /*!
     \param occurrences Occurrences of components to process
     \param cameraPositions List of camera positions
     \param cameraDirections List of camera directions
     \param cameraUps List of camera up vectors
     \param resolution Resolution of the visibility viewer
     \param fovX Horizontal field of view (in degree)
     \param considerTransparentOpaque If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque
     \param root Specify another root for occluder scene
   */
   virtual void createVisibilityInformationFromViewPoints(const SceneI::OccurrenceList & occurrences, const GeomI::Point3List & cameraPositions, const GeomI::Point3List & cameraDirections, const GeomI::Point3List & cameraUps, const CoreI::Int & resolution, const CoreI::Double & fovX = 90, const CoreI::Boolean & considerTransparentOpaque = false, const SceneI::Occurrence & root = 0) = 0;

   //! get part occurrences not viewed from a sphere around the scene
   /*!
     \param occurrences Occurrences of components to process
     \param resolution Resolution of the visibility viewer
     \param sphereCount Number of viewpoints generated around the bounding sphere
     \param fovX Horizontal field of view (in degree)
     \param considerTransparentOpaque If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque
     \param root Specify another root for occluder scene
     \param onHemisphereOnly Create viewpoints only in the Y+ hemisphere of the bounding sphere
     \return filtered The list of occurrences meeting the criteria
   */
   virtual SceneI::OccurrenceList findOccludedPartOccurrences(const SceneI::OccurrenceList & occurrences, const CoreI::Int & resolution, const CoreI::Int & sphereCount, const CoreI::Double & fovX = 90, const CoreI::Boolean & considerTransparentOpaque = false, const SceneI::Occurrence & root = 0, const CoreI::Bool & onHemisphereOnly = false) = 0;

   //! get part occurrences not viewed from a set of voxel based view points.
   /*!
     \param occurrences Occurrences of components to process
     \param voxelSize Size of the voxels in mm (smaller it is, more viewpoints there are)
     \param minimumCavityVolume Minimum volume of a cavity in cubic meter (smaller it is, more viewpoints there are)
     \param resolution Resolution of the visibility viewer
     \param mode Select where to place camera (all cavities, only outer or only inner cavities)
     \param considerTransparentOpaque If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque
     \param root Specify another root for occluder scene
     \return filtered The list of occurrences meeting the criteria
   */
   virtual SceneI::OccurrenceList findOccludedPartOccurrencesAdvanced(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & voxelSize, const GeomI::Volume & minimumCavityVolume, const CoreI::Int & resolution, const InnerOuterOption & mode = InnerOuterOption::All, const CoreI::Boolean & considerTransparentOpaque = false, const SceneI::Occurrence & root = 0) = 0;

   //! Delete part occurrences, patches or polygons not viewed from a sphere around the scene
   /*!
     \param occurrences Occurrences of components to process
     \param level Level of geometries to remove : Parts, Patches or Polygons
     \param resolution Resolution of the visibility viewer
     \param sphereCount Number of viewpoints generated around the bounding sphere
     \param fovX Horizontal field of view (in degree)
     \param considerTransparentOpaque If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque
     \param adjacencyDepth Mark neighbors polygons as visible
     \param occluders Specify other occurrences for occluder scene
     \param onHemisphereOnly Create viewpoints only in the Y+ hemisphere of the bounding sphere
     \return viewedOccurrences For each occurrence in occurrences, tell if the occurrence has been viewed (True) or not (True)
   */
   virtual CoreI::BoolList removeOccludedGeometries(const SceneI::OccurrenceList & occurrences, const SelectionLevel & level, const CoreI::Int & resolution, const CoreI::Int & sphereCount, const CoreI::Double & fovX = 90, const CoreI::Boolean & considerTransparentOpaque = false, const CoreI::Int & adjacencyDepth = 1, const SceneI::OccurrenceList & occluders = SceneI::OccurrenceList(0), const CoreI::Bool & onHemisphereOnly = false) = 0;

   //! Delete part occurrences, patches or polygons not seen from voxel based view points.
   /*!
     \param occurrences Occurrences of components to process
     \param level Level of geometries to remove : Parts, Patches or Polygons
     \param voxelSize Size of the voxels in mm (smaller it is, more viewpoints there are)
     \param minimumCavityVolume Minimum volume of a cavity in cubic meter (smaller it is, more viewpoints there are)
     \param resolution Resolution of the visibility viewer
     \param mode Select where to place camera (all cavities, only outer or only inner cavities)
     \param considerTransparentOpaque If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque
     \param adjacencyDepth Mark neighbors polygons as visible
     \param occluders Specify other occurrences for occluder scene
     \return viewedOccurrences For each occurrence in occurrences, tell if the occurrence has been viewed (True) or not (True)
   */
   virtual CoreI::BoolList removeOccludedGeometriesAdvanced(const SceneI::OccurrenceList & occurrences, const SelectionLevel & level, const GeomI::Distance & voxelSize, const GeomI::Volume & minimumCavityVolume, const CoreI::Int & resolution, const InnerOuterOption & mode = InnerOuterOption::All, const CoreI::Boolean & considerTransparentOpaque = false, const CoreI::Int & adjacencyDepth = 1, const SceneI::OccurrenceList & occluders = SceneI::OccurrenceList(0)) = 0;

   //! Delete part occurrences, patches or polygons not viewed from spheres generated with a set of camera position
   /*!
     \param occurrences Occurrences of components to process
     \param level Level of parts to remove : Parts, Patches or Polygons
     \param positions List of positions
     \param resolution Resolution of the visibility viewer
     \param sphereCount Number of viewpoints generated around the bounding sphere
     \param fovX Horizontal field of view (in degree)
     \param considerTransparentOpaque If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque
     \param adjacencyDepth Mark neighbors polygons as visible
     \param occluders Specify other occurrences for occluder scene
     \return viewedOccurrences For each occurrence in occurrences, tell if the occurrence has been viewed (True) or not (True)
   */
   virtual CoreI::BoolList removeOccludedGeometriesFromPoints(const SceneI::OccurrenceList & occurrences, const SelectionLevel & level, const GeomI::Point3List & positions, const CoreI::Int & resolution, const CoreI::Int & sphereCount, const CoreI::Double & fovX = 90, const CoreI::Boolean & considerTransparentOpaque = false, const CoreI::Int & adjacencyDepth = 1, const SceneI::OccurrenceList & occluders = SceneI::OccurrenceList(0)) = 0;

   //! Delete part occurrences, patches or polygons not viewed from a set of camera position/orientation
   /*!
     \param occurrences Occurrences of components to process
     \param level Level of geometries to remove : Parts, Patches or Polygons
     \param positions List of positions
     \param directions List of directions
     \param ups List of up vectors
     \param resolution Resolution of the visibility viewer
     \param fovX Horizontal field of view (in degree)
     \param considerTransparentOpaque If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque
     \param adjacencyDepth Mark neighbors polygons as visible
     \param occluders Specify other occurrences for occluder scene
     \return viewedOccurrences For each occurrence in occurrences, tell if the occurrence has been viewed (True) or not (True)
   */
   virtual CoreI::BoolList removeOccludedGeometriesFromViewPoints(const SceneI::OccurrenceList & occurrences, const SelectionLevel & level, const GeomI::Point3List & positions, const GeomI::Point3List & directions, const GeomI::Point3List & ups, const CoreI::Int & resolution, const CoreI::Double & fovX = 90, const CoreI::Boolean & considerTransparentOpaque = false, const CoreI::Int & adjacencyDepth = 1, const SceneI::OccurrenceList & occluders = SceneI::OccurrenceList(0)) = 0;

   /**@}*/

   /**
    * \defgroup Reconstruction 
    * @{
    */
   //! Compute an occluder or an occludee with the occurrences selected
   /*!
     \param occurrences Part occurrences to process
     \param type Type of what we create
     \param voxelSize Size of voxels
     \param gap Dilation iterations on the voxel grid
     \return occlusionPart Resulting part occurrence
   */
   virtual SceneI::Occurrence createOcclusionMesh(const SceneI::OccurrenceList & occurrences, const CreateOccluder & type, const GeomI::Distance & voxelSize, const CoreI::Int & gap) = 0;

   //! Replace the tessellations of the selected parts by a retopology based on a dual-contouring
   /*!
     \param occurrences Occurrences of part to process
     \param filteringSize Filtering size - must be a multiple of 2 of voxelSize
     \param voxelSize Voxel size used for the reconstruction
     \param tolerance Tolerance for the quadric error used for the simplification of the octree
     \param sameSizeOnAllAxis If true, use the maximum axis length of the AABB for all axis
     \return dualContouredPart Resulting part occurrence
   */
   virtual SceneI::Occurrence dualContouring(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & filteringSize, const GeomI::Distance & voxelSize, const CoreI::Double & tolerance, const CoreI::Boolean & sameSizeOnAllAxis) = 0;

   //! Replace the tessellations of the selected parts by a marching cube representation
   /*!
     \param occurrences Part occurrences to process
     \param voxelSize Size of voxels
     \param elements Type of elements used to detect the voxels, polygons or points or hybrid
     \param dilation Dilation iterations on the voxel grid (only if surfacic=false)
     \param surfacic Prefer this mode if the source is surfacic, the result is not guaranteed to be watertight
     \return marchingCubePart Resulting part occurrence
   */
   virtual SceneI::Occurrence marchingCubes(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & voxelSize, const ElementFilter & elements = ElementFilter::Polygons, const CoreI::Int & dilation = 0, const CoreI::Boolean & surfacic = false) = 0;

   //! Replace the tessellations of the selected parts by a proxy mesh based on a voxelization
   /*!
     \param occurrences Part occurrences to process
     \param voxelSize Size of voxels
     \param elements Type of elements used to detect the voxels, polygons or points or hybrid
     \param dilation Dilation iterations on the voxel grid (only if surfacic=false)
     \param surfacic Prefer this mode if the source is surfacic, the result is not guaranteed to be watertight
     \return proxyMeshPart Resulting part occurrence
   */
   virtual SceneI::Occurrence proxyMesh(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & voxelSize, const ElementFilter & elements = ElementFilter::Polygons, const CoreI::Int & dilation = 0, const CoreI::Boolean & surfacic = false) = 0;

   //! Replace the tessellations of the selected parts by a retopology of the external hull
   /*!
     \param occurrences Part occurrences to process
     \param targetTriangleCount Target triangle count
     \param pureQuad Retopologize to a pure quad mesh if True, else the resulting mesh will be quad dominant but can contains triangles
     \param pointCloud Set to true if occurrences are point cloud, else False
     \param precision If set, define the precision of the features to preserve
     \return retopologizedPart Resulting part occurrence
   */
   virtual SceneI::Occurrence retopologize(const SceneI::OccurrenceList & occurrences, const CoreI::Int & targetTriangleCount, const CoreI::Bool & pureQuad, const CoreI::Bool & pointCloud, const GeomI::Distance & precision = -1) = 0;

   //! Replace the tessellations of the selected parts by a voxelization of the external skin
   /*!
     \param occurrences Part occurrences to process
     \param voxelSize Size of voxels
     \param elements Type of elements used to detect the voxels, polygons or points or hybrid
     \param dilation Dilation iterations on the voxel grid
     \param useCurrentAnimationPosition Use the current animation position instead of the t-pose
     \return voxelizedPart Resulting part occurrence
   */
   virtual SceneI::Occurrence voxelize(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & voxelSize, const ElementFilter & elements = ElementFilter::Polygons, const CoreI::Int & dilation = 0, const CoreI::Boolean & useCurrentAnimationPosition = false) = 0;

   /**@}*/

   /**
    * \defgroup Replacement 
    * @{
    */
   //! Replace geometries by other shapes, or primitives
   /*!
     \param occurrences Occurrences of components to replace
     \param replaceBy Shape replacement option
   */
   virtual void replaceBy(const SceneI::OccurrenceList & occurrences, const ReplaceByOption & replaceBy) = 0;

   //! Replace objects by a bounding box
   /*!
     \param occurrences Occurrences of components to replace
     \param boxType Bounding box type, oriented, axis-aligned, ...
   */
   virtual void replaceByBox(const SceneI::OccurrenceList & occurrences, const ReplaceByBoxType & boxType) = 0;

   //! Replace objects by convex hull
   /*!
     \param occurrences Occurrences of components to replace
   */
   virtual void replaceByConvexHull(const SceneI::OccurrenceList & occurrences) = 0;

   //! Replace objects by a primitive shapes
   /*!
     \param occurrences Occurrences of components to replace
     \param primitive Primitive type and parameters
     \param generateUV Primitive type and parameters
   */
   virtual void replaceByPrimitive(const SceneI::OccurrenceList & occurrences, const PrimitiveShapeParameters & primitive, const CoreI::Boolean & generateUV = true) = 0;

   /**@}*/

   /**
    * \defgroup Sawing 
    * @{
    */
   //! Saw the mesh with an axis-aligned bounding box. New parts will be placed as children of input part occurrences.
   /*!
     \param occurrences Part occurrences to process
     \param aabb Axis-Aligned Bounding Box
     \param mode The sawing mode
     \param innerSuffix Only if mode is set to SawAndSplit, set the suffix of the inner part
     \param outerSuffix Only if mode is set to SawAndSplit, set the suffix of the outer part
   */
   virtual void sawWithAABB(const SceneI::OccurrenceList & occurrences, const GeomI::AABB & aabb, const SawingMode & mode, const CoreI::String & innerSuffix = "_inner", const CoreI::String & outerSuffix = "_outer") = 0;

   //! Saw the mesh with an oriented bounding box. New parts will be placed as children of input part occurrences.
   /*!
     \param occurrences Part occurrences to process
     \param obb Minimum Bounding Box
     \param mode The sawing mode
     \param innerSuffix Only if mode is set to SawAndSplit, set the suffix of the inner part
     \param outerSuffix Only if mode is set to SawAndSplit, set the suffix of the outer part
   */
   virtual void sawWithOBB(const SceneI::OccurrenceList & occurrences, const GeomI::OBB & obb, const SawingMode & mode, const CoreI::String & innerSuffix = "_inner", const CoreI::String & outerSuffix = "_outer") = 0;

   //! Saw and split the mesh with an octree. New parts will be placed as children of input part occurrences.
   /*!
     \param occurrences Part occurrences to process
     \param aabb Octree Bounding Box
     \param maxDepth Depth of the octree
     \param maxTrianglesByLeaf Set the maximum triangle count on the leaf of the octree ( -1 to not use )
     \param sawTolerance Size in mm of the tolerance of the saw
     \return octreeRoot Root occurrence of the created octree
   */
   virtual SceneI::Occurrence sawWithOctree(const SceneI::OccurrenceList & occurrences, const GeomI::AABB & aabb, const CoreI::Int & maxDepth, const CoreI::Int & maxTrianglesByLeaf = -1, const CoreI::Double & sawTolerance = 0) = 0;

   //! Saw the mesh with a plane. New parts will be placed as children of input part occurrences.
   /*!
     \param occurrences Part occurrences to process
     \param planeOrigin The plane origin
     \param planeNormal The plane normal
     \param mode The sawing mode
     \param innerSuffix Only if mode is set to SawAndSplit, set the suffix of the inner part
     \param outerSuffix Only if mode is set to SawAndSplit, set the suffix of the outer part
     \param tolerance Set a tolerance to make the saw lose
   */
   virtual void sawWithPlane(const SceneI::OccurrenceList & occurrences, const GeomI::Point3 & planeOrigin, const GeomI::Vector3 & planeNormal, const SawingMode & mode, const CoreI::String & innerSuffix = "_inner", const CoreI::String & outerSuffix = "_outer", const CoreI::Double & tolerance = 0) = 0;

   /**@}*/

   /**
    * \defgroup Similarity detection 
    * @{
    */
   //! Create instances from similar part occurrences with an accurate method based on topology checksums. This can be used to repair instances or to simplify a model that has similar parts that could be instantiated instead to reduce the number of unique meshes (reduces drawcalls, GPU memory usage and file size).
   /*!
     \param occurrences Occurrence for which we want to find similar parts and create instances using prototypes.
     \param checkMeshTopo 
     \param checkVertexPositions 
     \param vertexPositionPrecision 
     \param checkUVTopo 
     \param checkUVVertexPositions 
     \param UVPositionprecision 
     \param keepExistingPrototypes 
   */
   virtual void convertSimilarPartOccurrencesToInstances(const SceneI::OccurrenceList & occurrences, const CoreI::Boolean & checkMeshTopo, const CoreI::Boolean & checkVertexPositions, const CoreI::Int & vertexPositionPrecision, const CoreI::Boolean & checkUVTopo, const CoreI::Boolean & checkUVVertexPositions, const CoreI::Int & UVPositionprecision, const CoreI::Boolean & keepExistingPrototypes) = 0;

   //! Create instances from similar part occurrences with a fast but approximate method. This can be used to repair instances or to simplify a model that has similar parts that could be instantiated instead to reduce the number of unique meshes (reduces drawcalls, GPU memory usage and file size). Using 1.0 (100%) in all similarity criteria is non destructive. Using lower values will help finding more similar parts, even if their polycount or dimensions varies a bit.
   /*!
     \param occurrences Root occurrences for which we want to find similar part occurrences and create instances using prototypes.
     \param dimensionsSimilarity The percentage of similarity on dimensions. A value of 1.0 (100%) will find parts that have exactly the same dimensions. A lower value will increase the likelihood to find similar parts, at the cost of precision.
     \param polycountSimilarity The percentage of similarity on polycount. A value of 1.0 (100%) will find parts that have exactly the same polycount. A lower value will increase the likelihood to find similar parts, at the cost of precision.
     \param ignoreSymmetry If True, symmetries will be ignored, otherwise negative scaling will be applied in the occurrence transformation.
     \param keepExistingPrototypes If True, existing prototypes will be kept. Otherwise, the selection will be singularized and instanced will be created from scratch.
     \param createNewOccurrencesForPrototypes If True, a new occurrence will be created for each prototype. Those occurrences won't appear in the hierarchy, and so deleting one of the part in the scene has no risks of singularizing. If set to False, an arbitrary occurrence will be used as the prototype for other similar occurrences, which is less safe but will result in less occurrences.
   */
   virtual void convertSimilarPartOccurrencesToInstancesFast(const SceneI::OccurrenceList & occurrences, const CoreI::Coeff & dimensionsSimilarity, const CoreI::Coeff & polycountSimilarity, const CoreI::Boolean & ignoreSymmetry, const CoreI::Boolean & keepExistingPrototypes, const CoreI::Boolean & createNewOccurrencesForPrototypes) = 0;

   //! find part occurrences in the whole scene that are similar to the input part occurrences. If multiple part occurrences are passed as input, the output will contain similar part occurrences corresponding to each input part occurrence.
   /*!
     \param occurrences Occurrences for which we want to find similar part occurrences in the scene.
     \param dimensionsSimilarity The percentage of similarity on dimensions. A value of 1.0 (100%) will find parts that have exactly the same dimensions. A lower value will increase the likelihood to find similar parts, at the cost of precision.
     \param polycountSimilarity The percentage of similarity on polycount. A value of 1.0 (100%) will find parts that have exactly the same polycount. A lower value will increase the likelihood to find similar parts, at the cost of precision.
     \param ignoreSymmetry If True, symmetries will be ignored, otherwise negative scaling will be applied in the occurrence transformation.
     \return filtered The list of part occurrences meeting the criteria
   */
   virtual SceneI::OccurrenceList findSimilarPartOccurrencesFast(const SceneI::OccurrenceList & occurrences, const CoreI::Coeff & dimensionsSimilarity, const CoreI::Coeff & polycountSimilarity, const CoreI::Boolean & ignoreSymmetry) = 0;

   /**@}*/

   /**
    * \defgroup UV Mapping 
    * @{
    */
   //! Align with the axes the UVs of the islands
   /*!
     \param occurrences Part occurrences to process
     \param channel UV channel to merge
     \param usePolygonsWeights Use polygons weights to give more importance to what must be aligned
     \param useVerticesWeights Use vertices weights to give more importance to what must be aligned
     \param alignmentMode With which axis the UVs should be aligned
   */
   virtual void alignUVIslands(const SceneI::OccurrenceList & occurrences, const CoreI::Int & channel = 0, const CoreI::Double & usePolygonsWeights = 0, const CoreI::Double & useVerticesWeights = 0, const AlignmentMode & alignmentMode = AlignmentMode::Auto) = 0;

   //! Apply a transformation matrix on texture coordinates
   /*!
     \param occurrences Part occurrences to process
     \param matrix Transformationmatrix
     \param channel UV channel to transform
   */
   virtual void applyUvTransform(const SceneI::OccurrenceList & occurrences, const GeomI::Matrix4 & matrix, const CoreI::Int & channel = 0) = 0;

   //! Generates the texture coordinates and automatically find seams
   /*!
     \param occurrences Part occurrences to process
     \param channel The UV channel which will contains the texture coordinates
     \param maxAngleDistorsion Maximum angle distorsion |2PI-SumVtxAng|/2PI
     \param maxAreaDistorsion Maximum area distorsion before scale to 1. |2DArea-3DArea|/3DArea 
     \param sharpToSeam If enabled, sharp edges are automatically considered as UV seams
     \param forbidOverlapping If enabled, UV cannot overlap
     \param resolution Resolution wanted for the final map when repacking at the end
     \param padding Set the padding (in pixels) between UV islands when repacking at the end
   */
   virtual void automaticUVMapping(const SceneI::OccurrenceList & occurrences, const CoreI::Int & channel = 0, const CoreI::Double & maxAngleDistorsion = 0.5, const CoreI::Double & maxAreaDistorsion = -1, const CoreI::Bool & sharpToSeam = true, const CoreI::Bool & forbidOverlapping = true, const CoreI::UInt & resolution = 1024, const CoreI::UInt & padding = 1) = 0;

   //! Copy an UV channel to another UV channel
   /*!
     \param occurrences Part occurrences to process
     \param sourceChannel The source UV channel to copy
     \param destinationChannel The destination UV channel to copy into
   */
   virtual void copyUV(const SceneI::OccurrenceList & occurrences, const CoreI::Int & sourceChannel = 0, const CoreI::Int & destinationChannel = 0) = 0;

   //! Compute the ratio between the UV and the 3D size
   /*!
     \param occurrences Part occurrences to process
     \param ratioMode Choose how to compute the ratio
     \param channel UV channel to use
     \return ratios Ratios 3Dsize/UVsize of the input occurrences
   */
   virtual CoreI::DoubleList getRatioUV3D(const SceneI::OccurrenceList & occurrences, const RatioUV3DMode & ratioMode, const CoreI::Int & channel = 0) = 0;

   //! Compute UV mapping qualitative metrics.
   /*!
     \param occurrences Part occurrences to process
     \param channel UV channel to use
     \return chartCount Number of UV islands. If 0, all other returns are invalid.
     \return area3D 3D area (sum of 3D triangle areas)
     \return area2D 2D area (sum of UV-space triangle area)
     \return occupancy UV-space occupation (i.e., 2D area over AABR area)
     \return crumbliness Crumbliness (i.e., a measure of how intricate the UV-island borders are, basically a measure of deviation from a perfect disc)
     \return samplingStd Sampling standard deviation (i.e., measure of variation over the mesh of triangle sampling rate, that is ratio of their 2D over 3D area)
   */
   virtual getUVQualityMetricsReturn getUVQualityMetrics(const SceneI::OccurrenceList & occurrences, const CoreI::UInt & channel) = 0;

   //! Compute the UV Axis Aligned Bounding Rectangle of a set of occurrences
   /*!
     \param occurrences Part occurrences to process
     \param channel UV channel to transform
     \return aabr The UV AABR
   */
   virtual GeomI::AABR getUvAabr(const SceneI::OccurrenceList & occurrences, const CoreI::Int & channel = 0) = 0;

   //! Generate texture coordinates using the projection on object Axis Aligned Bounding Box
   /*!
     \param occurrences Part occurrences to process
     \param useLocalAABB If enabled, uses part own bounding box, else use global one
     \param uv3dSize 3D size of the UV space [0-1]
     \param channel The UV channel which will contains the texture coordinates
     \param overrideExistingUVs If True, override existing UVs on channel
     \param ignoreScale If this and useLocalAABB are true, ignore local scale
   */
   virtual void mapUvOnAABB(const SceneI::OccurrenceList & occurrences, const CoreI::Bool & useLocalAABB, const GeomI::Distance & uv3dSize, const CoreI::Int & channel = 0, const CoreI::Boolean & overrideExistingUVs = true, const CoreI::Boolean & ignoreScale = true) = 0;

   //! Generate texture coordinates using the projection on a box
   /*!
     \param occurrences Part occurrences to process
     \param box Box definition
     \param channel The UV channel which will contains the texture coordinates
     \param overrideExistingUVs If True, override existing UVs on channel
   */
   virtual void mapUvOnBox(const SceneI::OccurrenceList & occurrences, const Box & box, const CoreI::Int & channel = 0, const CoreI::Boolean & overrideExistingUVs = true) = 0;

   //! Generate texture coordinates using the projection on object AABB, with same scale on each axis
   /*!
     \param occurrences Part occurrences to process
     \param uv3dSize 3D size of the UV space [0-1]
     \param channel The UV channel which will contains the texture coordinates
     \param overrideExistingUVs If True, override existing UVs on channel
   */
   virtual void mapUvOnCubicAABB(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & uv3dSize, const CoreI::Int & channel = 0, const CoreI::Boolean & overrideExistingUVs = true) = 0;

   //! Generate texture coordinates using the projection on custom AABB
   /*!
     \param occurrences Part occurrences to process
     \param aabb Axis aligned bounding box to project on
     \param uv3dSize 3D size of the UV space [0-1]
     \param channel The UV channel which will contains the texture coordinates
     \param overrideExistingUVs If True, override existing UVs on channel
   */
   virtual void mapUvOnCustomAABB(const SceneI::OccurrenceList & occurrences, const GeomI::AABB & aabb, const GeomI::Distance & uv3dSize, const CoreI::Int & channel = 0, const CoreI::Boolean & overrideExistingUVs = true) = 0;

   //! Generate texture coordinates using the projection on a cylinder
   /*!
     \param occurrences Part occurrences to process
     \param cylinder Cylinder definition
     \param channel The UV channel which will contains the texture coordinates
     \param overrideExistingUVs If True, override existing UVs on channel
   */
   virtual void mapUvOnCylinder(const SceneI::OccurrenceList & occurrences, const Cylinder & cylinder, const CoreI::Int & channel = 0, const CoreI::Boolean & overrideExistingUVs = true) = 0;

   //! Generate texture coordinates using the projection on a fitting cylinder
   /*!
     \param occurrences Part occurrences to process
     \param channel The UV channel which will contains the texture coordinates
     \param overrideExistingUVs If True, override existing UVs on channel
     \param useAABB If true use for the fitting the global Axis Aligned Bounding Box (AABB), else use a Minimum Bounding Box (MBB)
     \param forcedAxis Forced axis of the Cylinder
   */
   virtual void mapUvOnFittingCylinder(const SceneI::OccurrenceList & occurrences, const CoreI::Int & channel = 0, const CoreI::Boolean & overrideExistingUVs = true, const CoreI::Boolean & useAABB = true, const GeomI::Vector3 & forcedAxis = GeomI::Point3(0, 0, 0)) = 0;

   //! Generate texture coordinates using the projection on a fitting sphere
   /*!
     \param occurrences Part occurrences to process
     \param channel The UV channel which will contains the texture coordinates
     \param overrideExistingUVs If True, override existing UVs on channel
     \param useAABB If true use for the fitting the global Axis Aligned Bounding Box (AABB), else use a Minimum Bounding Box (MBB)
   */
   virtual void mapUvOnFittingSphere(const SceneI::OccurrenceList & occurrences, const CoreI::Int & channel = 0, const CoreI::Boolean & overrideExistingUVs = true, const CoreI::Boolean & useAABB = true) = 0;

   //! Generate texture coordinates using the projection on object Minimum Bounding Box
   /*!
     \param occurrences Part occurrences to process
     \param useLocalMBB If enabled, uses part own bounding box, else use global one
     \param uv3dSize 3D size of the UV space [0-1]
     \param channel The UV channel which will contains the texture coordinates
     \param overrideExistingUVs If True, override existing UVs on channel
   */
   virtual void mapUvOnMBB(const SceneI::OccurrenceList & occurrences, const CoreI::Bool & useLocalMBB, const GeomI::Distance & uv3dSize, const CoreI::Int & channel = 0, const CoreI::Boolean & overrideExistingUVs = true) = 0;

   //! Generate texture coordinates using the projection on a plane
   /*!
     \param occurrences Part occurrences to process
     \param plane Plane definition
     \param channel The UV channel which will contains the texture coordinates
     \param overrideExistingUVs If True, override existing UVs on channel
   */
   virtual void mapUvOnPlane(const SceneI::OccurrenceList & occurrences, const Plane & plane, const CoreI::Int & channel = 0, const CoreI::Boolean & overrideExistingUVs = true) = 0;

   //! Generate texture coordinates using the projection on a sphere
   /*!
     \param occurrences Part occurrences to process
     \param sphere Sphere definition
     \param channel The UV channel which will contains the texture coordinates
     \param overrideExistingUVs If True, override existing UVs on channel
   */
   virtual void mapUvOnSphere(const SceneI::OccurrenceList & occurrences, const Sphere & sphere, const CoreI::Int & channel = 0, const CoreI::Boolean & overrideExistingUVs = true) = 0;

   //! Minimizes the number of seams in the UV mapping by merging UV islands using affine transformation (recommanded for hard surfaces)
   /*!
     \param occurrences Part occurrences to process
     \param channel UV channel to merge
     \param scaleWeights Weight to assign to scale for the merging priority
     \param maxScaleVariationFactor Maximum scaling factor allowed, -1 meaning no limits
     \param curvatureWeights Weight to assign to curvature for the merging priority
     \param usePolygonsWeights Use polygons weights to prioritize seams between polygons with less weight. The value represents the feature weight
     \param useVerticesWeights Use vertices weights to prioritize seams where vertices with less weight. The value represents the feature weight
     \param allowedTransformations Allowed transformation: TRSOnly or TRS+Skew
     \param allowUVInversion Allow merged UVs to be inverted
   */
   virtual void mergeUVIslandsAffine(const SceneI::OccurrenceList & occurrences, const CoreI::Int & channel = 0, const CoreI::Double & scaleWeights = 0, const CoreI::Double & maxScaleVariationFactor = 1.2, const CoreI::Double & curvatureWeights = -1, const CoreI::Double & usePolygonsWeights = 1, const CoreI::Double & useVerticesWeights = -1, const TransformationType & allowedTransformations = TransformationType::TRSOnly, const CoreI::Boolean & allowUVInversion = false) = 0;

   //! Minimizes the number of seams in the UV mapping by merging UV islands using local reparametrization near the UV seams (recommanded for organic surfaces)
   /*!
     \param occurrences Part occurrences to process
     \param channel UV channel to use
     \param targetIslandCount Target number of islands (zero means the algorithm runs until no more merging is possible)
     \param energyThreshold Max energy allowed during local reparametrization
     \param forceIsolatedFaces UV islands consisting in a single isolated face completely surrounded by another island are forced to be merged, without reparametrization.
   */
   virtual void mergeUVIslandsRelaxed(const SceneI::OccurrenceList & occurrences, const CoreI::Int & channel, const CoreI::Int & targetIslandCount = 0, const CoreI::Double & energyThreshold = 0.01, const CoreI::Boolean & forceIsolatedFaces = true) = 0;

   //! Normalize UVs to fit in the [0-1] uv space
   /*!
     \param occurrences Part occurrences to process
     \param sourceUVChannel UV Channel to normalize
     \param destinationUVChannel UV channel to store the normalized UV (if -1, sourceUVChannel will be replaced)
     \param uniform If true, the scale will be uniform. Else UV can be deformed with a non-uniform scale
     \param sharedUVSpace If true, all parts will be processed as if they were merged to avoid overlapping of their UV coordinates
     \param ignoreNullIslands If true, islands with null height and width will be ignored and their UV coordinates will be set to [0,0] (Slower if enabled)
   */
   virtual void normalizeUV(const SceneI::OccurrenceList & occurrences, const CoreI::Int & sourceUVChannel, const CoreI::Int & destinationUVChannel = -1, const CoreI::Boolean & uniform = true, const CoreI::Boolean & sharedUVSpace = true, const CoreI::Boolean & ignoreNullIslands = false) = 0;

   //! Remove one or all UV channel(s)
   /*!
     \param occurrences Part occurrences to process
     \param channel The UV channel to remove (all if channel=-1)
   */
   virtual void removeUV(const SceneI::OccurrenceList & occurrences, const CoreI::Int & channel = -1) = 0;

   //! Pack existing UV (create atlas)
   /*!
     \param occurrences Part occurrences to process
     \param channel The UV channel to repack
     \param shareMap If True, the UV of all given parts will be packed together
     \param resolution Resolution wanted for the final map
     \param padding Set the padding (in pixels) between UV islands
     \param uniformRatio If true, UV of different part will have the same ratio
     \param iterations Fitting iterations
     \param removeOverlaps Remove overlaps to avoid multiple triangles UVs to share the same pixel
     \return failedParts Parts which failed to be repacked at this resolution (try to increase the resolution or decrease the padding)
   */
   virtual SceneI::OccurrenceList repackUV(const SceneI::OccurrenceList & occurrences, const CoreI::Int & channel = 0, const CoreI::Boolean & shareMap = true, const CoreI::Int & resolution = 1024, const CoreI::UInt & padding = 2, const CoreI::Boolean & uniformRatio = false, const CoreI::Int & iterations = 3, const CoreI::Boolean & removeOverlaps = true) = 0;

   //! Rescale the UV coordinates to fit the input texture size
   /*!
     \param occurrences Occurrences to use for the rescaling
     \param TextureSize Texture size to use for the UV coordinates (in millimeters)
     \param channel UV channel to use
   */
   virtual void resizeUVsToTextureSize(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & TextureSize, const CoreI::Int & channel = 0) = 0;

   //! Apply a scale on texture coordinates
   /*!
     \param occurrences Part occurrences to process
     \param scaleU Scale to apply to U coordinate
     \param scaleV Scale to apply to V coordinate
     \param channel UV channel to transform
   */
   virtual void scaleUV(const SceneI::OccurrenceList & occurrences, const CoreI::Double & scaleU, const CoreI::Double & scaleV, const CoreI::Int & channel = 0) = 0;

   //! Swap two UV channels
   /*!
     \param occurrences Part occurrences to process
     \param firstChannel First UV Channel to swap
     \param secondChannel Second UV Channel to swap
   */
   virtual void swapUvChannels(const SceneI::OccurrenceList & occurrences, const CoreI::Int & firstChannel, const CoreI::Int & secondChannel) = 0;

   //! Unwrap UV islands
   /*!
     \param occurrences Part occurrences to process
     \param method Minimization method to use for unwrapping (isometric or conformal)
     \param channel The UV channel which will contains the texture coordinates
     \param createSeamsFromLoI Use Lines of Interest to generate UV islands
     \param iterMax For iterative solvers: set the maximum number of iterations allowed
     \param tolerance For iterative solvers: set the maximum error threshold
   */
   virtual void unwrapUV(const SceneI::OccurrenceList & occurrences, const UnwrapUVMethod & method, const CoreI::Int & channel = -1, const CoreI::Boolean & createSeamsFromLoI = false, const CoreI::Int & iterMax = 50, const CoreI::Double & tolerance = 0.00001) = 0;

   /**@}*/

   /**
    * \defgroup fitting 
    * @{
    */
   //! Returns the fitting cylinder of a set of occurrences (based on MBB)
   /*!
     \param occurrences Occurrences to fit
     \param useAABB If true use the global Axis Aligned Bounding Box (AABB), else use a Minimum Bounding Box (MBB)
     \param forcedAxis Forced axis of the Cylinder when using MBB
     \return affine Affine transformation of the cylinder
   */
   virtual GeomI::Affine getFittingCylinder(const SceneI::OccurrenceList & occurrences, const CoreI::Boolean & useAABB = true, const GeomI::Vector3 & forcedAxis = GeomI::Point3(0, 0, 0)) = 0;

   //! Returns the fitting sphere of a set of occurrences
   /*!
     \param occurrences Occurrences to fit
     \param useAABB If true use the global Axis Aligned Bounding Box (AABB), else use a Minimum Bounding Box (MBB)
     \return affine Affine transformation of the sphere
   */
   virtual GeomI::Affine getFittingSphere(const SceneI::OccurrenceList & occurrences, const CoreI::Boolean & useAABB = true) = 0;

   /**@}*/

   /**
    * \defgroup map_generation Map Generation functions
    * @{
    */
   //! Bake texture maps on meshes from self or other meshes
   /*!
     \param destinationOccurrences Occurrences of the meshes where to store the baked map
     \param sourceOccurrences Occurrences of components from which to bake maps (if empty use destination)
     \param mapsToBake List of map to generate (Normal, Diffuse, ...)
     \param channel UV channel of destOccurrence to use for the map generation
     \param resolution Map resolution
     \param padding Add padding to the map. A negative value means that the texture will be filled, and the padding for uv island is the absolute value
     \param shareMaps If true, all the destinationOccurrences will share the same maps
     \param mapSuffix Add a suffix to the map names
     \param additionalCustomMaps Additional custom maps to bake
     \param tolerance Tolerance of projection for baking from source to destination
     \param method Method to find source color if source occurrences are different than destination occurrences (Prefer ProjOnly for point clouds and RayOnly for meshes)
     \param opacityThreshold If the opacity is under this threshold, considers as fully transparent and store the color behind the intersection
     \param useCurrentPosition Use the current position instead of the T-Pose of the input occurrence
     \param offset Offset from mesh
     \param callbackList Callbacks that returns a color
     \param oneToOne If true, each occurrence in sourceOccurrences will be baked to the occurrence in destinationOccurrences at the same index
     \param reuseMaps Allow to use existing image instead of creating new ones (override shareMaps=true) the maps must be in the same order than mapsToBake+additionalCustomMaps+callbackList + usedMap (see: outputUsedMap)
     \param outputUsedMap If True, an extra maps contained used pixels is output at the end of bakedMaps. It can be used by reuseMaps
     \return bakedMaps Baked map list
   */
   virtual MaterialI::ImageList bakeMaps(const SceneI::OccurrenceList & destinationOccurrences, const SceneI::OccurrenceList & sourceOccurrences, const BakeMapList & mapsToBake, const CoreI::Int & channel = 0, const CoreI::Int & resolution = 1024, const CoreI::Int & padding = 1, const CoreI::Boolean & shareMaps = true, const CoreI::String & mapSuffix = "", const CustomBakeMapList & additionalCustomMaps = CustomBakeMapList(0), const GeomI::Distance & tolerance = -1, const BakingMethod & method = BakingMethod::RayOnly, const CoreI::Coeff & opacityThreshold = 0.1, const CoreI::Boolean & useCurrentPosition = false, const GeomI::Distance & offset = 0, const getPixelValueList & callbackList = getPixelValueList(0), const CoreI::Boolean & oneToOne = false, const MaterialI::ImageList & reuseMaps = MaterialI::ImageList(0), const CoreI::Boolean & outputUsedMap = false) = 0;

   //! Convert an existing normal map between Object-space and Tangent-space
   /*!
     \param partOccurrences Occurrences of components using the given map
     \param normalMap Source normal map to convert
     \param uvChannel UV channel used on the given map
     \param sourceIsObjectSpace If True, consider the given normalMap in Object-space representation, else Tangent-space
     \param destinationIsObjectSpace If True, convert the given normalMap to Object-space representation, else Tangent-space
     \param sourceIsRightHanded Considers source normal map as part of a right-handed coordinates system
     \param destinationIsRightHanded Generate destination normal map as part of a right-handed coordinates system
     \param replaceMap If true, the given normalMap will be replaced by the converted one
     \param resolution New map resolution (if replaceMap=false), if resolution=-1, the input resolution will be used
     \param padding Number of pixels to add for padding. A negative value means that the texture will be filled, and the padding for uv island is the absolute value
     \return convertedNormalMap Converted normal map (equals normalMap if replaceMap=true)
   */
   virtual MaterialI::Image convertNormalMap(const SceneI::OccurrenceList & partOccurrences, const MaterialI::Image & normalMap, const CoreI::Int & uvChannel = 0, const CoreI::Boolean & sourceIsObjectSpace = true, const CoreI::Boolean & destinationIsObjectSpace = false, const CoreI::Boolean & sourceIsRightHanded = true, const CoreI::Boolean & destinationIsRightHanded = true, const CoreI::Boolean & replaceMap = true, const CoreI::Int & resolution = -1, const CoreI::Int & padding = 1) = 0;

   //! Create a billboard imposter
   /*!
     \param occurrences Occurrences to bake in the billboard
     \param resolution Total resolution of the billboard (contains all wanted faces)
     \param XPositive Bake face facing X+
     \param XNegative Bake face facing X-
     \param YPositive Bake face facing Y+
     \param YNegative Bake face facing Y-
     \param ZPositive Bake face facing Z+
     \param ZNegative Bake face facing Z-
     \param moveFacesToCenter If true, all face are moved to the center of the AABB of the occurrences, else it will shape an AABB
     \param leftHandedNormalMap If true, a left handed normal map will be generated
     \return billboard Resulting billboard
   */
   virtual SceneI::Occurrence createBillboard(const SceneI::OccurrenceList & occurrences, const CoreI::Int & resolution = 1024, const CoreI::Bool & XPositive = true, const CoreI::Bool & XNegative = true, const CoreI::Bool & YPositive = true, const CoreI::Bool & YNegative = true, const CoreI::Bool & ZPositive = true, const CoreI::Bool & ZNegative = true, const CoreI::Bool & moveFacesToCenter = true, const CoreI::Bool & leftHandedNormalMap = false) = 0;

   //! Fill normal map (useful after a decimation for example)
   /*!
     \param normalMap Source normal map to convert
   */
   virtual void fillNormalMap(const MaterialI::Image & normalMap) = 0;

   //! Orient a tangent space normal map (all Z positive)
   /*!
     \param normalMap Normal map to orient
   */
   virtual void orientNormalMap(const MaterialI::Image & normalMap) = 0;

   /**@}*/

   /**
    * \defgroup repair Polygonal repair functions
    * @{
    */
   //! Smooth the tessellations by moving the vertices to the barycenter of their neighbors
   /*!
     \param occurrences Occurrences of components to process
     \param iteration Number of iterations
   */
   virtual void barySmooth(const SceneI::OccurrenceList & occurrences, const CoreI::Int & iteration = 1) = 0;

   //! Remove moebius strip by topologically cracking them (make it orientable)
   /*!
     \param occurrences Occurrences of components to repair
     \param maxEdgeCount Maximum number of edges to crack to remove one moebius strip
   */
   virtual void crackMoebiusStrips(const SceneI::OccurrenceList & occurrences, const CoreI::Int & maxEdgeCount = 3) = 0;

   //! Splits non-manifold vertices
   /*!
     \param occurrences Occurrences of components to repair
   */
   virtual void crackNonManifoldVertices(const SceneI::OccurrenceList & occurrences) = 0;

   //! Identify cavities and create occurrences to show them
   /*!
     \param occurrences Occurrences set to identify cavities
     \param voxelSize Size of the voxels in mm
     \param minimumCavityVolume Minimum volume of a cavity in cubic meter
     \param mode Select where to place camera (all cavities, only outer or only inner cavities)
     \param parent The create occurrence root will be added under the parent if given, else it will be added under the deeper parent of given occurrences
     \return root Parent occurrence of the cavity occurrences
   */
   virtual SceneI::Occurrence createCavityOccurrences(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & voxelSize, const GeomI::Volume & minimumCavityVolume, const InnerOuterOption & mode = InnerOuterOption::All, const SceneI::Occurrence & parent = SceneI::Occurrence()) = 0;

   //! Invert the orientation of tessellation elements
   /*!
     \param occurrences Occurrences of components to process
   */
   virtual void invertPolygonFacesOrientation(const SceneI::OccurrenceList & occurrences) = 0;

   //! Splits moebius ring
   /*!
     \param occurrences Occurrences of components to repair
   */
   virtual void moebiusCracker(const SceneI::OccurrenceList & occurrences) = 0;

   //! Orient existing normal according to the polygons clockwise
   /*!
     \param occurrences Occurrences of components to orient normals
   */
   virtual void orientNormals(const SceneI::OccurrenceList & occurrences) = 0;

   //! Resmesh surfacic holes of tessellations
   /*!
     \param occurrences Occurrences of components to process
     \param maxDiameter Maximum surfacic holes diameters
     \param refine Refine mesh for more details in holes
     \param numberOfNeighbors Number of neighboring vertices to use for the MLS projection
     \param fillWithMaterial If set, the given material will be used to fill the holes
   */
   virtual void remeshSurfacicHoles(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & maxDiameter = 0, const CoreI::Boolean & refine = true, const CoreI::Int & numberOfNeighbors = 3, const MaterialI::Material & fillWithMaterial = 0) = 0;

   //! Remove some kinds of degenerated polygons
   /*!
     \param occurrences Occurrences of components to process
     \param tolerance Degenerated tolerance
   */
   virtual void removeDegeneratedPolygons(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & tolerance) = 0;

   //! Remove multiple polygon
   /*!
     \param occurrences Occurrences of components to repair
   */
   virtual void removeMultiplePolygon(const SceneI::OccurrenceList & occurrences) = 0;

   //! Remove Z-fighting (surfaces overlapping) by slightly shrinking the selected parts' surfaces
   /*!
     \param occurrences Occurrences to process
     \return offset Offset value used by the algorithm
   */
   virtual GeomI::Distance removeZFighting(const SceneI::OccurrenceList & occurrences) = 0;

   //! Launch the repair process to repair a disconnected or not clean tessellation
   /*!
     \param occurrences Occurrences of components to process
     \param tolerance Connection tolerance
     \param crackNonManifold At the end of the repair process, crack resulting non-manifold edges
     \param orient If true reorient the model
   */
   virtual void repairMesh(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & tolerance, const CoreI::Bool & crackNonManifold = true, const CoreI::Boolean & orient = true) = 0;

   //! Create normal on an existing normal set when normal is null (polygons appears black)
   /*!
     \param occurrences Occurrences of components to repair null normals
   */
   virtual void repairNullNormals(const SceneI::OccurrenceList & occurrences) = 0;

   //! Remove non manifold edges and try to reconnect manifold groups of triangles
   /*!
     \param occurrences Occurrences of components to process
   */
   virtual void separateToManifold(const SceneI::OccurrenceList & occurrences) = 0;

   //! Sew boundaries between them
   /*!
     \param occurrences Occurrences of components to repair
     \param maxDistance Maximum distance between bundaries
   */
   virtual void sewBoundary(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & maxDistance) = 0;

   //! Move the vertices by the offsset along their normal
   /*!
     \param occurrences Occurrences to process
     \param offset Displacement
   */
   virtual void vertexOffset(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & offset = 1) = 0;

   /**@}*/

   /**
    * \defgroup repair faces orientation Polygon faces orientation
    * @{
    */
   //! Orient all connected polygons in the same orientation of the polygon selectionned
   virtual void orientFromFace() = 0;

   //! Orient tessellation elements
   /*!
     \param occurrences Occurrences of components to process
     \param makeOrientable Crack moebius strips to make the model orientable
     \param useArea Use the area instead of counting the number of triangle
     \param orientStrategy Strategy to adopt with this algorithm
   */
   virtual void orientPolygonFaces(const SceneI::OccurrenceList & occurrences, const CoreI::Boolean & makeOrientable = true, const CoreI::Boolean & useArea = false, const OrientStrategy & orientStrategy = OrientStrategy::ExteriorOnly) = 0;

   //! Properly orient all polygons in the same direction, using voxel based view points placement.
   /*!
     \param occurrences Occurrences to orient
     \param voxelSize Size of the voxels in mm (smaller it is, more viewpoints there are)
     \param minimumCavityVolume Minimum volume of a cavity in cubic meter (smaller it is, more viewpoints there are)
     \param resolution Resolution of the visibility viewer
     \param mode Select where to place camera (all cavities, only outer or only inner cavities)
     \param considerTransparentOpaque If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque
     \param orientStrategy Strategy to adopt with this algorithm
   */
   virtual void orientPolygonFacesAdvanced(const SceneI::OccurrenceList & occurrences, const GeomI::Distance & voxelSize, const GeomI::Volume & minimumCavityVolume, const CoreI::Int & resolution, const InnerOuterOption & mode = InnerOuterOption::All, const CoreI::Boolean & considerTransparentOpaque = true, const OrientStrategyAdvanced & orientStrategy = OrientStrategyAdvanced::VisibilityByConnected) = 0;

   //! Properly orient all polygons in the same direction, using a specified viewpoint
   /*!
     \param occurrences Occurrences to orient
     \param cameraPosition Camera position
     \param cameraDirection Camera direction
     \param cameraUp Camera up vector
     \param resolution Resolution of the visibility viewer
     \param fovX Horizontal field of view (in degree)
   */
   virtual void orientPolygonFacesFromCamera(const SceneI::OccurrenceList & occurrences, const GeomI::Point3 & cameraPosition, const GeomI::Point3 & cameraDirection, const GeomI::Point3 & cameraUp, const CoreI::Int & resolution, const CoreI::Double & fovX = 90) = 0;

   /**@}*/

   /**
    * \defgroup tessellation conversion Polygonal conversion related functions
    * @{
    */
   //! Sswap edges to make triangles more equilateral
   /*!
     \param occurrences Occurrences of components to process
     \param maxIterations Maximum number of swapping iteration
   */
   virtual void equilateralize(const SceneI::OccurrenceList & occurrences, const CoreI::Int & maxIterations = 1) = 0;

   //! Merge all triangle polygons in the meshes to quadrangles
   /*!
     \param occurrences Occurrences of components to process
   */
   virtual void quadify(const SceneI::OccurrenceList & occurrences) = 0;

   //! Advanced function to requadify a triangle tessellation coming from full quad mesh
   /*!
     \param occurrences Occurrences of components to process
     \param forceFullQuad Force the results to be only full quad. It it's impossible, nothing is done
   */
   virtual void requadify(const SceneI::OccurrenceList & occurrences, const CoreI::Bool & forceFullQuad = true) = 0;

   //! Split all non-triangle polygons in the meshes to triangles
   /*!
     \param occurrences Occurrences of components to process
   */
   virtual void triangularize(const SceneI::OccurrenceList & occurrences) = 0;

   /**@}*/

   /**
    * \defgroup vertex weights 
    * @{
    */
   //! Use vertex colors attributes on meshes of the given occurrence to create vertex weights attributes used by the decimation functions, the finals weights will be computed with w = offset + (red - blue) * scale
   /*!
     \param occurrences Occurrences of components to process
     \param offset Offset value for weight computation
     \param scale Scale value for weight computation
   */
   virtual void createVertexWeightsFromVertexColors(const SceneI::OccurrenceList & occurrences, const CoreI::Double & offset = 0, const CoreI::Double & scale = 1) = 0;

   //! Use visibility attributes on meshes of the given occurrence to create vertex weights attributes used by the decimation functions. The finals weights will be computed with w = offset + (visibility/maxVisibility) * scale
   /*!
     \param occurrences Occurrences of components to process
     \param offset Offset value for weight computation
     \param scale Scale value for weight computation
   */
   virtual void createVertexWeightsFromVisibilityAttributes(const SceneI::OccurrenceList & occurrences, const CoreI::Double & offset = 0, const CoreI::Double & scale = 1) = 0;

   //! Remove any existing vertex weights attributes on given occurrences
   /*!
     \param occurrences Occurrences of components to process
   */
   virtual void deleteVertexWeights(const SceneI::OccurrenceList & occurrences) = 0;

   /**@}*/

   /**
    * \defgroup visibility 
    * @{
    */
   //! Create visibility attributes on tessellations
   /*!
     \param occurrences Occurrences of components to create attributes
   */
   virtual void createVisibilityAttributes(const SceneI::OccurrenceList & occurrences) = 0;

   //! Delete visibility attributes on tessellations
   /*!
     \param occurrences Occurrences of components to delete attributes
   */
   virtual void deleteVisibilityAttributes(const SceneI::OccurrenceList & occurrences) = 0;

   //! Add one count to all visiblility attributes (poly and patch) on transparent patches
   /*!
     \param occurrences Occurrences of components to create attributes
   */
   virtual void flagVisibilityAttributesOnTransparents(const SceneI::OccurrenceList & occurrences) = 0;

   //! Set Polygonal Weight Attribute from Visibility Attribute
   /*!
     \param occurrences Part occurrences to process
     \param Mode Mode used to compute visibility
   */
   virtual void transferVisibilityToPolygonalWeight(const SceneI::OccurrenceList & occurrences, const VisibilityToWeightMode & Mode) = 0;

   /**@}*/

};

PXZ_MODULE_END



#endif
