// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_ALGO_INTERFACE_ALGOINTERFACE_C_H_
#define _PXZ_ALGO_INTERFACE_ALGOINTERFACE_C_H_

#include "AlgoTypes_c.h"

PXZ_EXPORTED char * Algo_getLastError();

// Assemble faces of CAD shapes
PXZ_EXPORTED void Algo_assembleCAD(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance tolerance, Core_Boolean removeDuplicatedFaces);
// Create the BRep shape from a Tessellated shape with Domain Patch Attributes (after tessellate)
PXZ_EXPORTED void Algo_backToInitialBRep(Session * pxzSession, Scene_OccurrenceList occurrences);
// bakes impostors textures
PXZ_EXPORTED Algo_OctahedralImpostor Algo_bakeImpostor(Session * pxzSession, Scene_Occurrence occurrence, Core_Int XFrames, Core_Int YFrames, Core_Bool hemi, Core_Int resolution, Core_Int padding, Core_Boolean roughness, Core_Boolean metallic, Core_Boolean ao);
// Bake vertex attributes on meshes from other meshes
PXZ_EXPORTED void Algo_bakeVertexAttributes(Session * pxzSession, Scene_OccurrenceList destinationOccurrences, Scene_OccurrenceList sourceOccurrences, Core_Boolean skinnedMesh, Core_Boolean positions, Core_Boolean useCurrentPositionAsTPose);
// calculate the normal of each point of a Point Cloud
PXZ_EXPORTED void Algo_calculateNormalsInPointClouds(Session * pxzSession, Scene_OccurrenceList occurrences);
// Explode and (re)merge a set of mesh parts by visible materials
PXZ_EXPORTED Scene_OccurrenceList Algo_combineMeshesByMaterials(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Boolean mergeNoMaterials, Scene_MergeHiddenPartsMode mergeHiddenPartsMode);
PXZ_EXPORTED void Algo_configureFunctionLogger(Session * pxzSession, Core_String functionName, Core_Boolean enableFunction, Core_Boolean enableParameters, Core_Boolean enableExecutionTime);
// Detect Moebius strip and crack them if there is somme of them in the selection
PXZ_EXPORTED void Algo_crackCADMoebiusStrip(Session * pxzSession, Scene_OccurrenceList occurrences);
// crack polygonal edges according to given criteria (deprecated, use crackMeshEdges instead)
PXZ_EXPORTED void Algo_crackEdges(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Boolean useAttributesFilter, Geom_Angle sharpAngleFilter, Core_Boolean useNonManifoldFilter);
// crack polygonal edges according to given criteria
PXZ_EXPORTED void Algo_crackMeshEdges(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Boolean normal, Core_Boolean uvs, Core_IntList uvChannels, Core_Boolean loi, Core_Boolean patches, Core_Boolean nman);
// Create free edges from patch borders
PXZ_EXPORTED void Algo_createFreeEdgesFromPatches(Session * pxzSession, Scene_OccurrenceList occurrences);
// Create identified patch from existing patch (this is useful before cloning for baking)
PXZ_EXPORTED void Algo_createIdentifiedPatchesFromPatches(Session * pxzSession, Scene_OccurrenceList occurrences);
// Create an IndexMap and add an UVSet so that each mesh will have UVs refering to one different pixel of the index map and that pixel will have the value i for occurrences[i]. Warning: all occurrences will be singularized
PXZ_EXPORTED Material_Image Algo_createIndexMapFromOccurrences(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int uvChannel, Core_Bool createTexture1D);
// Create normal attributes on tessellations
PXZ_EXPORTED void Algo_createNormals(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Angle sharpEdge, Core_Boolean override, Core_Boolean useAreaWeighting);
// Create a KD-Tree from some point clouds occurrence, the given occurrences are deleted (even if they contains triangles) and the KD-Tree is represented in a new occurrence sub tree
PXZ_EXPORTED Scene_Occurrence Algo_createPointCloudKDTree(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int depth, Core_Bool addToScene);
// Create tangent attributes on tessellations
PXZ_EXPORTED void Algo_createTangents(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int uvChannel, Core_Boolean override);
// Bake vertex colors using main material color. May duplicate some vertices
PXZ_EXPORTED void Algo_createVertexColorFromMaterials(Session * pxzSession, Scene_OccurrenceList occurrenceList);
// Create visibility patches from existing patches
PXZ_EXPORTED void Algo_createVisibilityPatchesFromPatch(Session * pxzSession, Scene_OccurrenceList occurrences);
// reduce the polygon count by removing some vertices
PXZ_EXPORTED void Algo_decimate(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance surfacicTolerance, Geom_Distance lineicTolerance, Geom_Angle normalTolerance, Geom_Distance texCoordTolerance, Core_Boolean releaseConstraintOnSmallArea);
// reduce the polygon count by collapsing some edges to obtain an simplified mesh
PXZ_EXPORTED void Algo_decimateEdgeCollapse(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance surfacicTolerance, Core_Double boundaryWeight, Core_Double normalWeight, Core_Double UVWeight, Core_Double sharpNormalWeight, Core_Double UVSeamWeight, Geom_Angle normalMaxDeviation, Core_Boolean forbidUVOverlaps, Core_Double UVMaxDeviation, Core_Double UVSeamMaxDeviation, Core_Boolean protectTopology, Algo_QualitySpeedTradeoff qualityTradeoff);
// decimate Point Cloud Occurrences according to tolerance 
PXZ_EXPORTED void Algo_decimatePointClouds(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance tolerance);
// reduce the polygon count by collapsing some edges to obtain a target triangle count (iterative version that use less memory)
PXZ_EXPORTED void Algo_decimateTarget(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_DecimateOptionsSelector targetStrategy, Algo_UVImportanceEnum UVImportance, Core_Boolean protectTopology, Core_ULong iterativeThreshold, Core_Boolean processMeshIndependently, Core_Int maxQuadricAge);
// Delete designed attribute on tessellations
PXZ_EXPORTED void Algo_deleteAttibute(Session * pxzSession, Scene_Occurrence occurrence, Algo_AttributType type);
// Delete BRep representation on parts
PXZ_EXPORTED void Algo_deleteBRepShapes(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Boolean onlyTessellated);
// Delete all free vertices of the mesh of given parts
PXZ_EXPORTED void Algo_deleteFreeVertices(Session * pxzSession, Scene_OccurrenceList occurrences);
// Delete all free line of the mesh of given parts
PXZ_EXPORTED void Algo_deleteLines(Session * pxzSession, Scene_OccurrenceList occurrences);
// Remove normal attributes on tessellations
PXZ_EXPORTED void Algo_deleteNormals(Session * pxzSession, Scene_OccurrenceList occurrences);
// Delete patches attributes on tessellations
PXZ_EXPORTED void Algo_deletePatches(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Boolean keepOnePatchByMaterial);
// Delete all polygons of the mesh of given parts
PXZ_EXPORTED void Algo_deletePolygons(Session * pxzSession, Scene_OccurrenceList occurrences);
// Remove tangent attributes on tessellations
PXZ_EXPORTED void Algo_deleteTangents(Session * pxzSession, Scene_OccurrenceList occurrences);
// Delete texture coordinates on tessellations
PXZ_EXPORTED void Algo_deleteTextureCoordinates(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int channel);
// delete the visibility patches of given occurrences
PXZ_EXPORTED void Algo_deleteVisibilityPatches(Session * pxzSession, Scene_OccurrenceList occurrences);
// returns the max error to set to reach a given target
PXZ_EXPORTED Core_Double Algo_evalDecimateErrorForTarget(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_DecimateOptionsSelector TargetStrategy, Core_Double boundaryWeight, Core_Double normalWeight, Core_Double UVWeight, Core_Double sharpNormalWeight, Core_Double UVSeamWeight, Core_Boolean forbidUVFoldovers, Core_Boolean protectTopology);
// Extract neutral axis from tessellations
PXZ_EXPORTED void Algo_extractNeutralAxis(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance maxDiameter, Core_Boolean removeOriginalMesh);
// Fillet a mesh according to its Lines of Interest
PXZ_EXPORTED void Algo_filletMesh(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Double value, Algo_FilletingMode filletingMode, Core_Int subdivisionNb, Core_Boolean createFlatChamfer, Material_Material material, Core_Int uvChannel);
// remove hidden polygons using voxels and cavities
PXZ_EXPORTED void Algo_filterHiddenPolygons(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance voxelSize);
// Try to compute the pivot point between 2 sets of occurrences
PXZ_EXPORTED Geom_Matrix4 Algo_findBestPivotBetweenOccurrences(Session * pxzSession, Scene_OccurrenceList assembly1, Scene_OccurrenceList assembly2, Core_Double precision);
// Return all the main axis contained in the CAD models given
typedef struct {
   Scene_OccurrenceList occurrences;
   Geom_Matrix4ListList axis;
} Algo_getAllAxisFromCADModelReturn;
PXZ_EXPORTED Algo_getAllAxisFromCADModelReturn Algo_getAllAxisFromCADModel(Session * pxzSession, Scene_OccurrenceList occurrences);
// Returns the optimal resolution based on a number of texels per 3D space units (e.g : mm)
PXZ_EXPORTED Core_Int Algo_getOptimalTextureResolution(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Double texelPerMm);
// returns all the tessellation of the given occurrences (only returns editable mesh, see algo.toEditableMesh)
PXZ_EXPORTED Polygonal_TessellationList Algo_getTessellations(Session * pxzSession, Scene_OccurrenceList occurrences);
// Returns the ratio of size between UV and 3D (max value, actually at the 90th percentil)
PXZ_EXPORTED Core_Double Algo_getUV3dRatio(Session * pxzSession, Scene_OccurrenceList occurrences);
// returns the visibility statistics for some occurrences
typedef struct {
   Core_Int visibleCountFront;
   Core_Int visibleCountBack;
} Algo_getVisibilityStatsReturn;
PXZ_EXPORTED Algo_getVisibilityStatsReturn Algo_getVisibilityStats(Session * pxzSession, Scene_OccurrenceList occurrences);
// Compute the visual footprint of the difference between two sets of occurrences
PXZ_EXPORTED Core_Double Algo_getVisualComparisonFootprint(Session * pxzSession, Scene_OccurrenceList originalOccurrences, Scene_OccurrenceList comparedOccurrences, Core_Int resolution, Core_Int viewpointCount, Core_Double threshold, Core_Bool onHemisphereOnly);
// Identify LoI according to given criteria. It will create a new LoI attribute on the mesh that can be used afterward by some functions
PXZ_EXPORTED void Algo_identifyLinesOfInterest(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Boolean normal, Core_Boolean uvs, Core_IntList uvChannels, Core_Boolean border, Core_Boolean patches, Core_Boolean nman);
// Create patches (submeshes) on meshes (needed by some functions)
PXZ_EXPORTED void Algo_identifyPatches(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Boolean useAttributesFilter, Geom_Angle sharpAngleFilter, Core_Boolean useBoundaryFilter, Core_Boolean useNonManifoldFilter, Core_Boolean useLineEdgeFilter, Core_Boolean useQuadLineFilter);
// Mark as Lines Of Interest the sharp edges 
PXZ_EXPORTED void Algo_identifySharpEdges(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Angle minSharpAngle, Geom_Angle maxSharpAngle, Algo_ConvexityFilter convexity, Core_Boolean onlyExplicitSharp);
// Generate a textured quadrangle over an existing mesh of coplanar lines
PXZ_EXPORTED void Algo_lineToTexture(Session * pxzSession, Scene_OccurrenceList lines, Algo_UseColorOption useColor, Core_Int resolution, Core_Int thickness);
// List features from tessellations
PXZ_EXPORTED Algo_OccurrenceFeaturesList Algo_listFeatures(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Boolean throughHoles, Core_Boolean blindHoles, Geom_Distance maxDiameter);
// Apply Loop Subdivision on Triangle-only Mesh
PXZ_EXPORTED void Algo_loopSubdivMesh(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int depth);
// merge near vertices according to the given distance
PXZ_EXPORTED void Algo_mergeVertices(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance maxDistance, Polygonal_TopologyCategoryMask mask);
// Computes the boolean operation between the meshes of two occurrence lists
PXZ_EXPORTED Scene_Occurrence Algo_meshBooleanOperation(Session * pxzSession, Scene_OccurrenceList occurrencesA, Scene_OccurrenceList occurrencesB, Algo_MeshBooleanOperation operation);
// compare two meshes
PXZ_EXPORTED Geom_Distance Algo_meshComparison(Session * pxzSession, Scene_Occurrence mesh_1, Scene_Occurrence mesh_2);
// compare each couple of meshes and returns the maximum for each couple
PXZ_EXPORTED Geom_DistanceList Algo_meshComparisonBatch(Session * pxzSession, Scene_OccurrenceList meshes1, Scene_OccurrenceList meshes2);
// Computes the list of polylines at the intersections of the meshes of two occurrence lists
PXZ_EXPORTED Geom_Point3ListList Algo_meshIntersections(Session * pxzSession, Scene_OccurrenceList occurrencesA, Scene_OccurrenceList occurrencesB);
// Apply noise to vertex positions along their normals
PXZ_EXPORTED void Algo_noiseMesh(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance maxAmplitude);
// Optimize CAD Face loops by merging useless loop edges
PXZ_EXPORTED void Algo_optimizeCADLoops(Session * pxzSession, Scene_OccurrenceList occurrences);
// Optimize mesh for rendering (lossless, only reindexing)
PXZ_EXPORTED void Algo_optimizeForRendering(Session * pxzSession, Scene_OccurrenceList occurrences);
// Sort sub meshes by materials
PXZ_EXPORTED void Algo_optimizeSubMeshes(Session * pxzSession, Scene_OccurrenceList occurrences);
// Resizes scene textures based on a number of texels per 3D space units (e.g: mm)
PXZ_EXPORTED void Algo_optimizeTextureSize(Session * pxzSession, Scene_Occurrence root, Core_Double texelPerMm);
// Remove some features from tessellations
PXZ_EXPORTED void Algo_removeHoles(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Boolean throughHoles, Core_Boolean blindHoles, Core_Boolean surfacicHoles, Geom_Distance maxDiameter, Material_Material fillWithMaterial);
// Repair CAD shapes, assemble faces, remove duplicated faces, optimize loops and repair topology
PXZ_EXPORTED void Algo_repairCAD(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance tolerance, Core_Boolean orient);
// Segment Mesh into clusters guided by edge sharpnesses.
PXZ_EXPORTED void Algo_segmentMesh(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Boolean overwriteLoI);
// Remap Index map of each FeatureComponent of selected occurrences
PXZ_EXPORTED void Algo_setFeatureComponentMaxIndex(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int maxIndex);
PXZ_EXPORTED void Algo_smoothMesh(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_CostEvaluation mode, Core_Int maxIterations, Core_Boolean lockSignificantEdges);
PXZ_EXPORTED void Algo_splitUVForAtlas(Session * pxzSession, Scene_OccurrenceList occurrences);
// Extrudes a circular section along an underlying polyline (curve)
PXZ_EXPORTED void Algo_sweep(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance radius, Core_Int sides, Core_Boolean createNormals, Core_Boolean keepLines, Core_Boolean generateUV);
// Create a tessellated representation from a CAD representation for each given part
PXZ_EXPORTED void Algo_tessellate(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance maxSag, Geom_Distance maxLength, Geom_Angle maxAngle, Core_Boolean createNormals, Algo_UVGenerationMode uvMode, Core_Int uvChannel, Core_Double uvPadding, Core_Boolean createTangents, Core_Boolean createFreeEdges, Core_Boolean keepBRepShape, Core_Boolean overrideExistingTessellation);
// Tessellate point clouds to replace the geometry with a polygonal connect mesh
PXZ_EXPORTED void Algo_tessellatePointClouds(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int kNeighbors, Core_Boolean keepPoints, Core_Boolean colorize);
// Creates a tessellated representation from a CAD representation for each given part. It multiplies the length of the diagonal of the bounding box by the sagRatio. If the output value is above maxSag, then maxSag is used as tessellation value. Else if the output value is below maxSag, it is used as tessellation value.
PXZ_EXPORTED void Algo_tessellateRelativelyToAABB(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance maxSag, Core_Double sagRatio, Geom_Distance maxLength, Geom_Angle maxAngle, Core_Boolean createNormals, Algo_UVGenerationMode uvMode, Core_Int uvChannel, Core_Double uvPadding, Core_Boolean createTangents, Core_Boolean createFreeEdges, Core_Boolean keepBRepShape, Core_Boolean overrideExistingTessellation);
// Explode point clouds to voxels
PXZ_EXPORTED void Algo_voxelizePointClouds(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance voxelSize);

// ----------------------------------------------------
// Baking
// ----------------------------------------------------

// Combine materials found on occurrences subtrees into one baked material and assign it to part occurrences
PXZ_EXPORTED void Algo_combineMaterials(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_BakeOption bakingOptions, Core_Boolean overrideExistingUVs, Core_Boolean singularizeOnAO);
// Transfer UV from a mesh to another mesh
PXZ_EXPORTED void Algo_transferUV(Session * pxzSession, Scene_Occurrence source, Scene_Occurrence destination, Core_Int sourceChannel, Core_Int destinationChannel, Geom_Distance tolerance);

// ----------------------------------------------------
// Decomposition
// ----------------------------------------------------

// Explode each mesh to approximated convex decomposition
PXZ_EXPORTED Scene_OccurrenceList Algo_convexDecomposition(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int maxCount, Core_Int vertexCount, Core_Boolean approximate, Core_Int resolution, Core_Double concavity);
// Explode all CAD Parts by body. New parts will be placed as children of input part occurrences.
PXZ_EXPORTED void Algo_explodeBodies(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Boolean groupOpenShells);
// Explode all parts by material. New parts will be placed as children of input part occurrences.
PXZ_EXPORTED void Algo_explodeByMaterials(Session * pxzSession, Scene_OccurrenceList occurrences);
// Explode part occurrences to respect a maximum vertex count
PXZ_EXPORTED void Algo_explodeByVertexCount(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int maxVertexCount, Core_Int maxTriangleCount, Core_Boolean countMergedVerticesOnce);
// Explode parts by voxel. New parts will be placed as children of input part occurrences.
PXZ_EXPORTED void Algo_explodeByVoxel(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance voxelSize);
// Explode connected set of polygons to part occurrences. New parts will be placed as children of input part occurrences.
PXZ_EXPORTED void Algo_explodeConnectedMeshes(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Boolean explodeNonManifoldEdges);
// Explode all parts by patch
PXZ_EXPORTED void Algo_explodePatches(Session * pxzSession, Scene_OccurrenceList occurrences);

// ----------------------------------------------------
// Occlusion Detection
// All occlusion detection/removal related function
// ----------------------------------------------------

// Create visilibity information on part occurrences viewed from a set of camera automatically placed on a sphere around the scene
PXZ_EXPORTED void Algo_createVisibilityInformation(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_SelectionLevel level, Core_Int resolution, Core_Int sphereCount, Core_Double fovX, Core_Boolean considerTransparentOpaque, Scene_Occurrence root, Core_Bool onHemisphereOnly);
// Create visilibity information on part occurrences viewed from a set of voxel based view points.
PXZ_EXPORTED void Algo_createVisibilityInformationAdvanced(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_SelectionLevel level, Geom_Distance voxelSize, Geom_Volume minimumCavityVolume, Core_Int resolution, Algo_InnerOuterOption mode, Core_Boolean considerTransparentOpaque, Scene_Occurrence root);
// Create visilibity information on parts viewed from a given set of camera
PXZ_EXPORTED void Algo_createVisibilityInformationFromViewPoints(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Point3List cameraPositions, Geom_Point3List cameraDirections, Geom_Point3List cameraUps, Core_Int resolution, Core_Double fovX, Core_Boolean considerTransparentOpaque, Scene_Occurrence root);
// get part occurrences not viewed from a sphere around the scene
PXZ_EXPORTED Scene_OccurrenceList Algo_findOccludedPartOccurrences(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int resolution, Core_Int sphereCount, Core_Double fovX, Core_Boolean considerTransparentOpaque, Scene_Occurrence root, Core_Bool onHemisphereOnly);
// get part occurrences not viewed from a set of voxel based view points.
PXZ_EXPORTED Scene_OccurrenceList Algo_findOccludedPartOccurrencesAdvanced(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance voxelSize, Geom_Volume minimumCavityVolume, Core_Int resolution, Algo_InnerOuterOption mode, Core_Boolean considerTransparentOpaque, Scene_Occurrence root);
// Delete part occurrences, patches or polygons not viewed from a sphere around the scene
PXZ_EXPORTED Core_BoolList Algo_removeOccludedGeometries(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_SelectionLevel level, Core_Int resolution, Core_Int sphereCount, Core_Double fovX, Core_Boolean considerTransparentOpaque, Core_Int adjacencyDepth, Scene_OccurrenceList occluders, Core_Bool onHemisphereOnly);
// Delete part occurrences, patches or polygons not seen from voxel based view points.
PXZ_EXPORTED Core_BoolList Algo_removeOccludedGeometriesAdvanced(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_SelectionLevel level, Geom_Distance voxelSize, Geom_Volume minimumCavityVolume, Core_Int resolution, Algo_InnerOuterOption mode, Core_Boolean considerTransparentOpaque, Core_Int adjacencyDepth, Scene_OccurrenceList occluders);
// Delete part occurrences, patches or polygons not viewed from spheres generated with a set of camera position
PXZ_EXPORTED Core_BoolList Algo_removeOccludedGeometriesFromPoints(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_SelectionLevel level, Geom_Point3List positions, Core_Int resolution, Core_Int sphereCount, Core_Double fovX, Core_Boolean considerTransparentOpaque, Core_Int adjacencyDepth, Scene_OccurrenceList occluders);
// Delete part occurrences, patches or polygons not viewed from a set of camera position/orientation
PXZ_EXPORTED Core_BoolList Algo_removeOccludedGeometriesFromViewPoints(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_SelectionLevel level, Geom_Point3List positions, Geom_Point3List directions, Geom_Point3List ups, Core_Int resolution, Core_Double fovX, Core_Boolean considerTransparentOpaque, Core_Int adjacencyDepth, Scene_OccurrenceList occluders);

// ----------------------------------------------------
// Reconstruction
// ----------------------------------------------------

// Compute an occluder or an occludee with the occurrences selected
PXZ_EXPORTED Scene_Occurrence Algo_createOcclusionMesh(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_CreateOccluder type, Geom_Distance voxelSize, Core_Int gap);
// Replace the tessellations of the selected parts by a retopology based on a dual-contouring
PXZ_EXPORTED Scene_Occurrence Algo_dualContouring(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance filteringSize, Geom_Distance voxelSize, Core_Double tolerance, Core_Boolean sameSizeOnAllAxis);
// Replace the tessellations of the selected parts by a marching cube representation
PXZ_EXPORTED Scene_Occurrence Algo_marchingCubes(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance voxelSize, Algo_ElementFilter elements, Core_Int dilation, Core_Boolean surfacic);
// Replace the tessellations of the selected parts by a proxy mesh based on a voxelization
PXZ_EXPORTED Scene_Occurrence Algo_proxyMesh(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance voxelSize, Algo_ElementFilter elements, Core_Int dilation, Core_Boolean surfacic);
// Replace the tessellations of the selected parts by a retopology of the external hull
PXZ_EXPORTED Scene_Occurrence Algo_retopologize(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int targetTriangleCount, Core_Bool pureQuad, Core_Bool pointCloud, Geom_Distance precision);
// Replace the tessellations of the selected parts by a voxelization of the external skin
PXZ_EXPORTED Scene_Occurrence Algo_voxelize(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance voxelSize, Algo_ElementFilter elements, Core_Int dilation, Core_Boolean useCurrentAnimationPosition);

// ----------------------------------------------------
// Replacement
// ----------------------------------------------------

// Replace geometries by other shapes, or primitives
PXZ_EXPORTED void Algo_replaceBy(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_ReplaceByOption replaceBy);
// Replace objects by a bounding box
PXZ_EXPORTED void Algo_replaceByBox(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_ReplaceByBoxType boxType);
// Replace objects by convex hull
PXZ_EXPORTED void Algo_replaceByConvexHull(Session * pxzSession, Scene_OccurrenceList occurrences);
// Replace objects by a primitive shapes
PXZ_EXPORTED void Algo_replaceByPrimitive(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_PrimitiveShapeParameters primitive, Core_Boolean generateUV);

// ----------------------------------------------------
// Sawing
// ----------------------------------------------------

// Saw the mesh with an axis-aligned bounding box. New parts will be placed as children of input part occurrences.
PXZ_EXPORTED void Algo_sawWithAABB(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_AABB aabb, Algo_SawingMode mode, Core_String innerSuffix, Core_String outerSuffix);
// Saw the mesh with an oriented bounding box. New parts will be placed as children of input part occurrences.
PXZ_EXPORTED void Algo_sawWithOBB(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_OBB obb, Algo_SawingMode mode, Core_String innerSuffix, Core_String outerSuffix);
// Saw and split the mesh with an octree. New parts will be placed as children of input part occurrences.
PXZ_EXPORTED Scene_Occurrence Algo_sawWithOctree(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_AABB aabb, Core_Int maxDepth, Core_Int maxTrianglesByLeaf, Core_Double sawTolerance);
// Saw the mesh with a plane. New parts will be placed as children of input part occurrences.
PXZ_EXPORTED void Algo_sawWithPlane(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Point3 planeOrigin, Geom_Vector3 planeNormal, Algo_SawingMode mode, Core_String innerSuffix, Core_String outerSuffix, Core_Double tolerance);

// ----------------------------------------------------
// Similarity detection
// ----------------------------------------------------

// Create instances from similar part occurrences with an accurate method based on topology checksums. This can be used to repair instances or to simplify a model that has similar parts that could be instantiated instead to reduce the number of unique meshes (reduces drawcalls, GPU memory usage and file size).
PXZ_EXPORTED void Algo_convertSimilarPartOccurrencesToInstances(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Boolean checkMeshTopo, Core_Boolean checkVertexPositions, Core_Int vertexPositionPrecision, Core_Boolean checkUVTopo, Core_Boolean checkUVVertexPositions, Core_Int UVPositionprecision, Core_Boolean keepExistingPrototypes);
// Create instances from similar part occurrences with a fast but approximate method. This can be used to repair instances or to simplify a model that has similar parts that could be instantiated instead to reduce the number of unique meshes (reduces drawcalls, GPU memory usage and file size). Using 1.0 (100%) in all similarity criteria is non destructive. Using lower values will help finding more similar parts, even if their polycount or dimensions varies a bit.
PXZ_EXPORTED void Algo_convertSimilarPartOccurrencesToInstancesFast(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Coeff dimensionsSimilarity, Core_Coeff polycountSimilarity, Core_Boolean ignoreSymmetry, Core_Boolean keepExistingPrototypes, Core_Boolean createNewOccurrencesForPrototypes);
// find part occurrences in the whole scene that are similar to the input part occurrences. If multiple part occurrences are passed as input, the output will contain similar part occurrences corresponding to each input part occurrence.
PXZ_EXPORTED Scene_OccurrenceList Algo_findSimilarPartOccurrencesFast(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Coeff dimensionsSimilarity, Core_Coeff polycountSimilarity, Core_Boolean ignoreSymmetry);

// ----------------------------------------------------
// UV Mapping
// ----------------------------------------------------

// Align with the axes the UVs of the islands
PXZ_EXPORTED void Algo_alignUVIslands(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int channel, Core_Double usePolygonsWeights, Core_Double useVerticesWeights, Algo_AlignmentMode alignmentMode);
// Apply a transformation matrix on texture coordinates
PXZ_EXPORTED void Algo_applyUvTransform(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Matrix4 matrix, Core_Int channel);
// Generates the texture coordinates and automatically find seams
PXZ_EXPORTED void Algo_automaticUVMapping(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int channel, Core_Double maxAngleDistorsion, Core_Double maxAreaDistorsion, Core_Bool sharpToSeam, Core_Bool forbidOverlapping, Core_UInt resolution, Core_UInt padding);
// Copy an UV channel to another UV channel
PXZ_EXPORTED void Algo_copyUV(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int sourceChannel, Core_Int destinationChannel);
// Compute the ratio between the UV and the 3D size
PXZ_EXPORTED Core_DoubleList Algo_getRatioUV3D(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_RatioUV3DMode ratioMode, Core_Int channel);
// Compute UV mapping qualitative metrics.
typedef struct {
   Core_UInt chartCount;
   Core_Double area3D;
   Core_Double area2D;
   Core_Double occupancy;
   Core_Double crumbliness;
   Core_Double samplingStd;
} Algo_getUVQualityMetricsReturn;
PXZ_EXPORTED Algo_getUVQualityMetricsReturn Algo_getUVQualityMetrics(Session * pxzSession, Scene_OccurrenceList occurrences, Core_UInt channel);
// Compute the UV Axis Aligned Bounding Rectangle of a set of occurrences
PXZ_EXPORTED Geom_AABR Algo_getUvAabr(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int channel);
// Generate texture coordinates using the projection on object Axis Aligned Bounding Box
PXZ_EXPORTED void Algo_mapUvOnAABB(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Bool useLocalAABB, Geom_Distance uv3dSize, Core_Int channel, Core_Boolean overrideExistingUVs, Core_Boolean ignoreScale);
// Generate texture coordinates using the projection on a box
PXZ_EXPORTED void Algo_mapUvOnBox(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_Box box, Core_Int channel, Core_Boolean overrideExistingUVs);
// Generate texture coordinates using the projection on object AABB, with same scale on each axis
PXZ_EXPORTED void Algo_mapUvOnCubicAABB(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance uv3dSize, Core_Int channel, Core_Boolean overrideExistingUVs);
// Generate texture coordinates using the projection on custom AABB
PXZ_EXPORTED void Algo_mapUvOnCustomAABB(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_AABB aabb, Geom_Distance uv3dSize, Core_Int channel, Core_Boolean overrideExistingUVs);
// Generate texture coordinates using the projection on a cylinder
PXZ_EXPORTED void Algo_mapUvOnCylinder(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_Cylinder cylinder, Core_Int channel, Core_Boolean overrideExistingUVs);
// Generate texture coordinates using the projection on a fitting cylinder
PXZ_EXPORTED void Algo_mapUvOnFittingCylinder(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int channel, Core_Boolean overrideExistingUVs, Core_Boolean useAABB, Geom_Vector3 forcedAxis);
// Generate texture coordinates using the projection on a fitting sphere
PXZ_EXPORTED void Algo_mapUvOnFittingSphere(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int channel, Core_Boolean overrideExistingUVs, Core_Boolean useAABB);
// Generate texture coordinates using the projection on object Minimum Bounding Box
PXZ_EXPORTED void Algo_mapUvOnMBB(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Bool useLocalMBB, Geom_Distance uv3dSize, Core_Int channel, Core_Boolean overrideExistingUVs);
// Generate texture coordinates using the projection on a plane
PXZ_EXPORTED void Algo_mapUvOnPlane(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_Plane plane, Core_Int channel, Core_Boolean overrideExistingUVs);
// Generate texture coordinates using the projection on a sphere
PXZ_EXPORTED void Algo_mapUvOnSphere(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_Sphere sphere, Core_Int channel, Core_Boolean overrideExistingUVs);
// Minimizes the number of seams in the UV mapping by merging UV islands using affine transformation (recommanded for hard surfaces)
PXZ_EXPORTED void Algo_mergeUVIslandsAffine(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int channel, Core_Double scaleWeights, Core_Double maxScaleVariationFactor, Core_Double curvatureWeights, Core_Double usePolygonsWeights, Core_Double useVerticesWeights, Algo_TransformationType allowedTransformations, Core_Boolean allowUVInversion);
// Minimizes the number of seams in the UV mapping by merging UV islands using local reparametrization near the UV seams (recommanded for organic surfaces)
PXZ_EXPORTED void Algo_mergeUVIslandsRelaxed(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int channel, Core_Int targetIslandCount, Core_Double energyThreshold, Core_Boolean forceIsolatedFaces);
// Normalize UVs to fit in the [0-1] uv space
PXZ_EXPORTED void Algo_normalizeUV(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int sourceUVChannel, Core_Int destinationUVChannel, Core_Boolean uniform, Core_Boolean sharedUVSpace, Core_Boolean ignoreNullIslands);
// Remove one or all UV channel(s)
PXZ_EXPORTED void Algo_removeUV(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int channel);
// Pack existing UV (create atlas)
PXZ_EXPORTED Scene_OccurrenceList Algo_repackUV(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int channel, Core_Boolean shareMap, Core_Int resolution, Core_UInt padding, Core_Boolean uniformRatio, Core_Int iterations, Core_Boolean removeOverlaps);
// Rescale the UV coordinates to fit the input texture size
PXZ_EXPORTED void Algo_resizeUVsToTextureSize(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance TextureSize, Core_Int channel);
// Apply a scale on texture coordinates
PXZ_EXPORTED void Algo_scaleUV(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Double scaleU, Core_Double scaleV, Core_Int channel);
// Swap two UV channels
PXZ_EXPORTED void Algo_swapUvChannels(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int firstChannel, Core_Int secondChannel);
// Unwrap UV islands
PXZ_EXPORTED void Algo_unwrapUV(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_UnwrapUVMethod method, Core_Int channel, Core_Boolean createSeamsFromLoI, Core_Int iterMax, Core_Double tolerance);

// ----------------------------------------------------
// fitting
// ----------------------------------------------------

// Returns the fitting cylinder of a set of occurrences (based on MBB)
PXZ_EXPORTED Geom_Affine Algo_getFittingCylinder(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Boolean useAABB, Geom_Vector3 forcedAxis);
// Returns the fitting sphere of a set of occurrences
PXZ_EXPORTED Geom_Affine Algo_getFittingSphere(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Boolean useAABB);

// ----------------------------------------------------
// map_generation
// Map Generation functions
// ----------------------------------------------------

// Bake texture maps on meshes from self or other meshes
PXZ_EXPORTED Material_ImageList Algo_bakeMaps(Session * pxzSession, Scene_OccurrenceList destinationOccurrences, Scene_OccurrenceList sourceOccurrences, Algo_BakeMapList mapsToBake, Core_Int channel, Core_Int resolution, Core_Int padding, Core_Boolean shareMaps, Core_String mapSuffix, Algo_CustomBakeMapList additionalCustomMaps, Geom_Distance tolerance, Algo_BakingMethod method, Core_Coeff opacityThreshold, Core_Boolean useCurrentPosition, Geom_Distance offset, Algo_getPixelValueList callbackList, Core_Boolean oneToOne, Material_ImageList reuseMaps, Core_Boolean outputUsedMap);
// Convert an existing normal map between Object-space and Tangent-space
PXZ_EXPORTED Material_Image Algo_convertNormalMap(Session * pxzSession, Scene_OccurrenceList partOccurrences, Material_Image normalMap, Core_Int uvChannel, Core_Boolean sourceIsObjectSpace, Core_Boolean destinationIsObjectSpace, Core_Boolean sourceIsRightHanded, Core_Boolean destinationIsRightHanded, Core_Boolean replaceMap, Core_Int resolution, Core_Int padding);
// Create a billboard imposter
PXZ_EXPORTED Scene_Occurrence Algo_createBillboard(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int resolution, Core_Bool XPositive, Core_Bool XNegative, Core_Bool YPositive, Core_Bool YNegative, Core_Bool ZPositive, Core_Bool ZNegative, Core_Bool moveFacesToCenter, Core_Bool leftHandedNormalMap);
// Fill normal map (useful after a decimation for example)
PXZ_EXPORTED void Algo_fillNormalMap(Session * pxzSession, Material_Image normalMap);
// Orient a tangent space normal map (all Z positive)
PXZ_EXPORTED void Algo_orientNormalMap(Session * pxzSession, Material_Image normalMap);

// ----------------------------------------------------
// repair
// Polygonal repair functions
// ----------------------------------------------------

// Smooth the tessellations by moving the vertices to the barycenter of their neighbors
PXZ_EXPORTED void Algo_barySmooth(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int iteration);
// Remove moebius strip by topologically cracking them (make it orientable)
PXZ_EXPORTED void Algo_crackMoebiusStrips(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int maxEdgeCount);
// Splits non-manifold vertices
PXZ_EXPORTED void Algo_crackNonManifoldVertices(Session * pxzSession, Scene_OccurrenceList occurrences);
// Identify cavities and create occurrences to show them
PXZ_EXPORTED Scene_Occurrence Algo_createCavityOccurrences(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance voxelSize, Geom_Volume minimumCavityVolume, Algo_InnerOuterOption mode, Scene_Occurrence parent);
// Invert the orientation of tessellation elements
PXZ_EXPORTED void Algo_invertPolygonFacesOrientation(Session * pxzSession, Scene_OccurrenceList occurrences);
// Splits moebius ring
PXZ_EXPORTED void Algo_moebiusCracker(Session * pxzSession, Scene_OccurrenceList occurrences);
// Orient existing normal according to the polygons clockwise
PXZ_EXPORTED void Algo_orientNormals(Session * pxzSession, Scene_OccurrenceList occurrences);
// Resmesh surfacic holes of tessellations
PXZ_EXPORTED void Algo_remeshSurfacicHoles(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance maxDiameter, Core_Boolean refine, Core_Int numberOfNeighbors, Material_Material fillWithMaterial);
// Remove some kinds of degenerated polygons
PXZ_EXPORTED void Algo_removeDegeneratedPolygons(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance tolerance);
// Remove multiple polygon
PXZ_EXPORTED void Algo_removeMultiplePolygon(Session * pxzSession, Scene_OccurrenceList occurrences);
// Remove Z-fighting (surfaces overlapping) by slightly shrinking the selected parts' surfaces
PXZ_EXPORTED Geom_Distance Algo_removeZFighting(Session * pxzSession, Scene_OccurrenceList occurrences);
// Launch the repair process to repair a disconnected or not clean tessellation
PXZ_EXPORTED void Algo_repairMesh(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance tolerance, Core_Bool crackNonManifold, Core_Boolean orient);
// Create normal on an existing normal set when normal is null (polygons appears black)
PXZ_EXPORTED void Algo_repairNullNormals(Session * pxzSession, Scene_OccurrenceList occurrences);
// Remove non manifold edges and try to reconnect manifold groups of triangles
PXZ_EXPORTED void Algo_separateToManifold(Session * pxzSession, Scene_OccurrenceList occurrences);
// Sew boundaries between them
PXZ_EXPORTED void Algo_sewBoundary(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance maxDistance);
// Move the vertices by the offsset along their normal
PXZ_EXPORTED void Algo_vertexOffset(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance offset);

// ----------------------------------------------------
// repair faces orientation
// Polygon faces orientation
// ----------------------------------------------------

// Orient all connected polygons in the same orientation of the polygon selectionned
PXZ_EXPORTED void Algo_orientFromFace(Session * pxzSession);
// Orient tessellation elements
PXZ_EXPORTED void Algo_orientPolygonFaces(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Boolean makeOrientable, Core_Boolean useArea, Algo_OrientStrategy orientStrategy);
// Properly orient all polygons in the same direction, using voxel based view points placement.
PXZ_EXPORTED void Algo_orientPolygonFacesAdvanced(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Distance voxelSize, Geom_Volume minimumCavityVolume, Core_Int resolution, Algo_InnerOuterOption mode, Core_Boolean considerTransparentOpaque, Algo_OrientStrategyAdvanced orientStrategy);
// Properly orient all polygons in the same direction, using a specified viewpoint
PXZ_EXPORTED void Algo_orientPolygonFacesFromCamera(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_Point3 cameraPosition, Geom_Point3 cameraDirection, Geom_Point3 cameraUp, Core_Int resolution, Core_Double fovX);

// ----------------------------------------------------
// tessellation conversion
// Polygonal conversion related functions
// ----------------------------------------------------

// Sswap edges to make triangles more equilateral
PXZ_EXPORTED void Algo_equilateralize(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Int maxIterations);
// Merge all triangle polygons in the meshes to quadrangles
PXZ_EXPORTED void Algo_quadify(Session * pxzSession, Scene_OccurrenceList occurrences);
// Advanced function to requadify a triangle tessellation coming from full quad mesh
PXZ_EXPORTED void Algo_requadify(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Bool forceFullQuad);
// Split all non-triangle polygons in the meshes to triangles
PXZ_EXPORTED void Algo_triangularize(Session * pxzSession, Scene_OccurrenceList occurrences);

// ----------------------------------------------------
// vertex weights
// ----------------------------------------------------

// Use vertex colors attributes on meshes of the given occurrence to create vertex weights attributes used by the decimation functions, the finals weights will be computed with w = offset + (red - blue) * scale
PXZ_EXPORTED void Algo_createVertexWeightsFromVertexColors(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Double offset, Core_Double scale);
// Use visibility attributes on meshes of the given occurrence to create vertex weights attributes used by the decimation functions. The finals weights will be computed with w = offset + (visibility/maxVisibility) * scale
PXZ_EXPORTED void Algo_createVertexWeightsFromVisibilityAttributes(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Double offset, Core_Double scale);
// Remove any existing vertex weights attributes on given occurrences
PXZ_EXPORTED void Algo_deleteVertexWeights(Session * pxzSession, Scene_OccurrenceList occurrences);

// ----------------------------------------------------
// visibility
// ----------------------------------------------------

// Create visibility attributes on tessellations
PXZ_EXPORTED void Algo_createVisibilityAttributes(Session * pxzSession, Scene_OccurrenceList occurrences);
// Delete visibility attributes on tessellations
PXZ_EXPORTED void Algo_deleteVisibilityAttributes(Session * pxzSession, Scene_OccurrenceList occurrences);
// Add one count to all visiblility attributes (poly and patch) on transparent patches
PXZ_EXPORTED void Algo_flagVisibilityAttributesOnTransparents(Session * pxzSession, Scene_OccurrenceList occurrences);
// Set Polygonal Weight Attribute from Visibility Attribute
PXZ_EXPORTED void Algo_transferVisibilityToPolygonalWeight(Session * pxzSession, Scene_OccurrenceList occurrences, Algo_VisibilityToWeightMode Mode);



#endif
