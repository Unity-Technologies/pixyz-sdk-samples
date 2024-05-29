// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_SCENE_INTERFACE_SCENEINTERFACE_C_H_
#define _PXZ_SCENE_INTERFACE_SCENEINTERFACE_C_H_

#include "SceneTypes_c.h"

PXZ_EXPORTED char * Scene_getLastError();

// Add a component to an occurrence
PXZ_EXPORTED Scene_Component Scene_addComponent(Session * pxzSession, Scene_Occurrence occurrence, Scene_ComponentType componentType);
// Add a components to each occurrence in the array
PXZ_EXPORTED Scene_ComponentList Scene_addComponents(Session * pxzSession, Scene_OccurrenceList occurrences, Scene_ComponentType componentType);
// Add an instance of prototype's child as child in current occurrence recursively
PXZ_EXPORTED void Scene_addInParentInstances(Session * pxzSession, Scene_Occurrence root);
// Remove unused images from texture library
PXZ_EXPORTED Core_Int Scene_cleanUnusedImages(Session * pxzSession);
// Remove unused materials from material library
PXZ_EXPORTED Core_Int Scene_cleanUnusedMaterials(Session * pxzSession, Core_Boolean cleanImages);
// Compute the checksum of a sub-tree
PXZ_EXPORTED Core_String Scene_computeSubTreeChecksum(Session * pxzSession, Scene_Occurrence root);
PXZ_EXPORTED void Scene_configureFunctionLogger(Session * pxzSession, Core_String functionName, Core_Boolean enableFunction, Core_Boolean enableParameters, Core_Boolean enableExecutionTime);
// Convert all materials to materials with a color pattern, trying to keep the visual aspect as similar as possible
PXZ_EXPORTED void Scene_convertMaterialsToColor(Session * pxzSession, Material_MaterialList materials);
// Convert all materials to materials with a PBR pattern, trying to keep the visual aspect as similar as possible
PXZ_EXPORTED void Scene_convertMaterialsToPBR(Session * pxzSession, Material_MaterialList materials);
// Reorganize a sub tree with hierarchical clustering
PXZ_EXPORTED void Scene_createHierarchicalClusters(Session * pxzSession, Scene_Occurrence root, Core_Int childrenCountByNode, Core_Coeff minFitting);
PXZ_EXPORTED Scene_Occurrence Scene_createOBBMesh(Session * pxzSession, Scene_Occurrence occurrence);
// Create a new occurrence
PXZ_EXPORTED Scene_Occurrence Scene_createOccurrence(Session * pxzSession, Core_String name, Scene_Occurrence parent);
// Create a new occurrence and add the given occurrences as children
PXZ_EXPORTED Scene_Occurrence Scene_createOccurrenceFromSelection(Session * pxzSession, Core_String name, Scene_OccurrenceList children, Scene_Occurrence parent, Core_Boolean keepMaterialAssignment);
// Creates an occurrence from string
PXZ_EXPORTED Scene_Occurrence Scene_createOccurrenceFromText(Session * pxzSession, Core_String text, Core_String font, Core_Int fontSize, Core_ColorAlpha color, Core_Double heigth3D);
// Create one new occurrence under each given parent
PXZ_EXPORTED Scene_OccurrenceList Scene_createOccurrences(Session * pxzSession, Core_String name, Scene_OccurrenceList parents);
// Create a set of Parts given meshes and occurrences
PXZ_EXPORTED Scene_PartList Scene_createPartsFromMeshes(Session * pxzSession, Scene_OccurrenceList occurrences, Polygonal_MeshList meshes);
// Create a scene tree with a list of meshes, all meshes becomes part occurrences with the same root. The same mesh Id can be used several times to handle create instances (prototypes)
PXZ_EXPORTED Scene_Occurrence Scene_createSceneFromMeshes(Session * pxzSession, Polygonal_MeshList meshes, Geom_Matrix4List matrices, Core_Boolean centerPartPivots);
// Delete component from type
PXZ_EXPORTED void Scene_deleteComponentByType(Session * pxzSession, Scene_ComponentType componentType, Scene_Occurrence occurrence, Core_Bool followPrototypes);
// Delete all components on subtree from type
PXZ_EXPORTED void Scene_deleteComponentsByType(Session * pxzSession, Scene_ComponentType componentType, Scene_Occurrence rootOccurrence);
// Delete all empty assemblies
PXZ_EXPORTED void Scene_deleteEmptyOccurrences(Session * pxzSession, Scene_Occurrence root);
// Delete a liste of occurrences
PXZ_EXPORTED void Scene_deleteOccurrences(Session * pxzSession, Scene_OccurrenceList occurrences);
PXZ_EXPORTED Scene_Occurrence Scene_generateOctaViews(Session * pxzSession, Core_Double radius, Core_Int XFrames, Core_Int YFrames, Core_Bool hemi);
// Generate a loose octree from the given sub-tree
PXZ_EXPORTED Scene_Occurrence Scene_generateOctree(Session * pxzSession, Scene_Occurrence occurrence, Core_Int maxDepth, Core_Double looseFactor);
// Returns the axis aligned bounding box of a list of scene paths
PXZ_EXPORTED Geom_AABB Scene_getAABB(Session * pxzSession, Scene_OccurrenceList occurrences);
// Get the active material on occurrence
PXZ_EXPORTED Material_Material Scene_getActiveMaterial(Session * pxzSession, Scene_Occurrence occurrence);
// Get the value of a property on the first parent that own it
PXZ_EXPORTED Core_String Scene_getActivePropertyValue(Session * pxzSession, Scene_Occurrence occurrence, Core_String propertyName, Core_Boolean cacheProperty);
// Get the value of a property on the first parent that own it for each given occurrence
PXZ_EXPORTED Core_StringList Scene_getActivePropertyValues(Session * pxzSession, Scene_OccurrenceList occurrences, Core_String propertyName, Core_Boolean cacheProperty);
// Returns the list of ancestors for one occurrence
PXZ_EXPORTED Scene_OccurrenceList Scene_getAncestors(Session * pxzSession, Scene_Occurrence occurrence);
// Returns a component on an occurrence
PXZ_EXPORTED Scene_Component Scene_getComponent(Session * pxzSession, Scene_Occurrence occurrence, Scene_ComponentType componentType, Core_Bool followPrototypes);
// Returns one component of the specified type by occurrence if it exists
PXZ_EXPORTED Scene_ComponentList Scene_getComponentByOccurrence(Session * pxzSession, Scene_OccurrenceList occurrences, Scene_ComponentType componentType, Core_Bool followPrototypes);
// Get the occurrence that own a component
PXZ_EXPORTED Scene_Occurrence Scene_getComponentOccurrence(Session * pxzSession, Scene_Component component);
// Get the type of a component
PXZ_EXPORTED Scene_ComponentType Scene_getComponentType(Session * pxzSession, Scene_Component component);
// Returns the global matrix on an occurrence
PXZ_EXPORTED Geom_Matrix4 Scene_getGlobalMatrix(Session * pxzSession, Scene_Occurrence occurrence);
// Returns the global visibility of a given occurrence
PXZ_EXPORTED Core_Boolean Scene_getGlobalVisibility(Session * pxzSession, Scene_Occurrence occurrence);
// Returns the local matrix on an occurrence
PXZ_EXPORTED Geom_Matrix4 Scene_getLocalMatrix(Session * pxzSession, Scene_Occurrence occurrence);
// Returns the Minimum Bounding Box of a list of scene paths
PXZ_EXPORTED Geom_MBB Scene_getMBB(Session * pxzSession, Scene_OccurrenceList occurrences);
PXZ_EXPORTED Material_MaterialList Scene_getMaterialsFromSubtree(Session * pxzSession, Scene_Occurrence occurrence);
// Returns the Oriented Bounding Box of a list of scene paths (works only on meshes, fast method, not the Minimum Volume Box)
PXZ_EXPORTED Geom_OBB Scene_getOBB(Session * pxzSession, Scene_OccurrenceList occurrences);
// Returns the active material on a given occurrence
PXZ_EXPORTED Material_Material Scene_getOccurrenceActiveMaterial(Session * pxzSession, Scene_Occurrence occurrence);
// Returns the name of an occurrence
PXZ_EXPORTED Core_String Scene_getOccurrenceName(Session * pxzSession, Scene_Occurrence occurrence);
// Recursively get all the occurrences containing a component of the specified type
PXZ_EXPORTED Scene_OccurrenceList Scene_getOccurrencesWithComponent(Session * pxzSession, Scene_ComponentType componentType, Scene_Occurrence fromOcc);
// Returns the active shape of a part
PXZ_EXPORTED Scene_Shape Scene_getPartActiveShape(Session * pxzSession, Scene_Part part);
// Recursively get all the occurrences containing a part component
PXZ_EXPORTED Scene_OccurrenceList Scene_getPartOccurrences(Session * pxzSession, Scene_Occurrence fromOcc);
// Get the part's shape type
PXZ_EXPORTED Scene_ShapeType Scene_getPartShapeType(Session * pxzSession, Scene_Part part);
// Returns the number of polygon in the parts meshes
PXZ_EXPORTED Core_ULong Scene_getPolygonCount(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Bool asTriangleCount, Core_Bool countOnceEachInstance, Core_Bool countHidden);
// Returns some stats of a sub tree
typedef struct {
   Core_ULong partCount;
   Core_ULong partOccurrenceCount;
   Core_ULong triangleCount;
   Core_ULong triangleOccurrenceCount;
   Core_ULong vertexCount;
   Core_ULong vertexOccurrenceCount;
   Core_ULong pointCount;
   Core_ULong pointOccurrenceCount;
   Core_ULong lineCount;
   Core_ULong lineOccurrenceCount;
} Scene_getSubTreeStatsReturn;
PXZ_EXPORTED Scene_getSubTreeStatsReturn Scene_getSubTreeStats(Session * pxzSession, Scene_OccurrenceList roots);
// Returns the number of vertices in the parts meshes
PXZ_EXPORTED Core_ULong Scene_getVertexCount(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Bool countOnceEachInstance, Core_Bool countHidden, Core_Bool countPoints, Core_Bool countMergedVertices);
// Returns viewpoints from model cavities
typedef struct {
   Geom_Point3List positions;
   Geom_Point3List directions;
} Scene_getViewpointsFromCavitiesReturn;
PXZ_EXPORTED Scene_getViewpointsFromCavitiesReturn Scene_getViewpointsFromCavities(Session * pxzSession, Geom_Distance voxelSize, Geom_Distance minCavityVolume);
// Returns True if the given occurrence has the given component type
PXZ_EXPORTED Core_Boolean Scene_hasComponent(Session * pxzSession, Scene_Occurrence occurrence, Scene_ComponentType componentType, Core_Bool followPrototypes);
// Hide the given occurrence
PXZ_EXPORTED void Scene_hide(Session * pxzSession, Scene_Occurrence occurrence);
// Inverse the visibility of the given occurrence
PXZ_EXPORTED void Scene_inverseVisibility(Session * pxzSession, Scene_Occurrence occurrence);
// Test if the occurrences are ancestors to one another.
PXZ_EXPORTED Core_Bool Scene_isAncestorOf(Session * pxzSession, Scene_Occurrence occurrence1, Scene_Occurrence occurrence2);
// List all components on a type on the whole tree
PXZ_EXPORTED Scene_ComponentList Scene_listComponent(Session * pxzSession, Scene_ComponentType componentType);
// List all components on an occurrence
PXZ_EXPORTED Scene_ComponentList Scene_listComponents(Session * pxzSession, Scene_Occurrence occurrence, Core_Bool followPrototypes);
// Merge all equivalent images (i.e. with same pixels)
PXZ_EXPORTED Core_Int Scene_mergeImages(Session * pxzSession, Material_ImageList images);
// Merge all equivalent materials (i.e. with same appearance)
PXZ_EXPORTED Core_Int Scene_mergeMaterials(Session * pxzSession, Material_MaterialList materials, Core_Boolean evaluateNames);
// Recursively remove all materials
PXZ_EXPORTED void Scene_removeMaterials(Session * pxzSession, Scene_OccurrenceList roots);
// truncate names of occurrence with too long names
PXZ_EXPORTED void Scene_renameLongOccurrenceName(Session * pxzSession, Core_Int maxLength);
// Replace a material by another everywhere it is used
PXZ_EXPORTED void Scene_replaceMaterial(Session * pxzSession, Material_Material originalMaterial, Material_Material newMaterial, Scene_OccurrenceList occurrences);
// Resizes the textures from a selection of occurrences (resizes all textures used by these occurrences), or from a selection of textures
PXZ_EXPORTED void Scene_resizeTextures(Session * pxzSession, Scene_ResizeTexturesInputMode inputMode, Scene_ResizeTexturesResizeMode resizeMode, Core_Bool replaceTextures);
// Move a component to an occurrence
PXZ_EXPORTED void Scene_setComponentOccurrence(Session * pxzSession, Scene_Component component, Scene_Occurrence occurrence);
// Set the default variant
PXZ_EXPORTED void Scene_setDefaultVariant(Session * pxzSession);
// Set the material on a occurrence
PXZ_EXPORTED void Scene_setOccurrenceMaterial(Session * pxzSession, Scene_Occurrence occurrence, Material_Material material);
// Returns the name of an occurrence
PXZ_EXPORTED void Scene_setOccurrenceName(Session * pxzSession, Scene_Occurrence occurrence, Core_String name);
// Show the given occurrence
PXZ_EXPORTED void Scene_show(Session * pxzSession, Scene_Occurrence occurrence);
// Show only the given occurrence
PXZ_EXPORTED void Scene_showOnly(Session * pxzSession, Scene_Occurrence occurrence);
// Set all materials on part occurrences
PXZ_EXPORTED void Scene_transferCADMaterialsOnPartOccurrences(Session * pxzSession, Scene_Occurrence rootOccurrence);
// Take the first instance material and set it one the mesh patches
PXZ_EXPORTED void Scene_transferMaterialsOnPatches(Session * pxzSession, Scene_Occurrence rootOccurrence);
   /*!
     \param eventType Type of change
     \param occurrence Occurrence concerned by change
     \param child Child occurrence for child insertion/removal
   */
PXZ_EXPORTED Core_Ident Scene_addSceneChangedCallback(Session * pxzSession, void(*fp)(void *, Scene_SceneChangeType, Scene_Occurrence, Scene_Occurrence), void * userdata = nullptr);
PXZ_EXPORTED void Scene_removeSceneChangedCallback(Session * pxzSession, Core_Ident id);


// ----------------------------------------------------
// Create primitives
// ----------------------------------------------------

// Create a new capsule
PXZ_EXPORTED Scene_Occurrence Scene_createCapsule(Session * pxzSession, Core_Double radius, Core_Double height, Core_Int subdivisionLatitude, Core_Int subdivisionLongitude, Core_Boolean generateUV);
// Create a new cone
PXZ_EXPORTED Scene_Occurrence Scene_createCone(Session * pxzSession, Core_Double bottomRadius, Core_Double height, Core_Int sides, Core_Boolean generateUV);
// Create a new cube
PXZ_EXPORTED Scene_Occurrence Scene_createCube(Session * pxzSession, Core_Double sizeX, Core_Double sizeY, Core_Double sizeZ, Core_Int subdivision, Core_Boolean generateUV);
// Create a new cylinder
PXZ_EXPORTED Scene_Occurrence Scene_createCylinder(Session * pxzSession, Core_Double radius, Core_Double height, Core_Int sides, Core_Boolean generateUV);
// Create a new bagel klein
PXZ_EXPORTED Scene_Occurrence Scene_createImmersion(Session * pxzSession, Core_Double radius, Core_Int subdivisionX, Core_Int subdivisionY);
// Create a  new plane
PXZ_EXPORTED Scene_Occurrence Scene_createPlane(Session * pxzSession, Core_Double sizeY, Core_Double sizeX, Core_Int subdivisionX, Core_Int subdivisionY, Core_Boolean generateUV);
// Create a new sphere
PXZ_EXPORTED Scene_Occurrence Scene_createSphere(Session * pxzSession, Core_Double radius, Core_Int subdivisionLatitude, Core_Int subdivisionLongitude, Core_Boolean generateUV);
// Create a new torus
PXZ_EXPORTED Scene_Occurrence Scene_createTorus(Session * pxzSession, Core_Double majorRadius, Core_Double minorRadius, Core_Int subdivisionLatitude, Core_Int subdivisionLongitude);

// ----------------------------------------------------
// FindBy
// ----------------------------------------------------

// Get duplicated parts
PXZ_EXPORTED Scene_OccurrenceList Scene_findDuplicatedPartOccurrences(Session * pxzSession, Scene_Occurrence root, Core_Real acceptVolumeRatio, Core_Real acceptPolycountRatio, Core_Real acceptAABBAxisRatio, Geom_Distance acceptAABBCenterDistance);
// get occurrences for which the property "Material" is the given material
PXZ_EXPORTED Scene_OccurrenceList Scene_findOccurrencesByMaterial(Session * pxzSession, Material_Material material);
// Returns all occurrences which a metadata property value matches the given regular expression (ECMAScript)
PXZ_EXPORTED Scene_OccurrenceList Scene_findOccurrencesByMetadata(Session * pxzSession, Core_String property, Core_Regex regex, Scene_OccurrenceList roots, Core_Bool caseInsensitive);
// Returns all occurrences with a metadata value matching the given regular expression (ECMAScript)
PXZ_EXPORTED Scene_OccurrenceList Scene_findOccurrencesByMetadataValue(Session * pxzSession, Core_Regex regex, Scene_OccurrenceList roots, Core_Bool caseInsensitive);
// Returns all occurrences which a property value matches the given regular expression (ECMAScript)
PXZ_EXPORTED Scene_OccurrenceList Scene_findOccurrencesByProperty(Session * pxzSession, Core_String property, Core_Regex regex, Scene_OccurrenceList roots, Core_Bool caseInsensitive);
// Find all part occurrence with a given material as active material (i.e. as seen in the rendering)
PXZ_EXPORTED Scene_OccurrenceList Scene_findPartOccurrencesByActiveMaterial(Session * pxzSession, Material_Material material, Scene_OccurrenceList roots);
// Get part occurrences by size
PXZ_EXPORTED Scene_OccurrenceList Scene_findPartOccurrencesByMaximumSize(Session * pxzSession, Scene_OccurrenceList roots, Geom_Distance maxDiagLength, Geom_Distance maxSize, Core_Boolean getHidden);
// get part occurrences with more than "minInstanciationCount" occurrence on the scene
PXZ_EXPORTED Scene_OccurrenceList Scene_findPartOccurrencesByMinimumNumberOfInstances(Session * pxzSession, Core_Int minInstanciationCount);
// get part occurrences for which the given material is visible in the viewer
PXZ_EXPORTED Scene_OccurrenceList Scene_findPartOccurrencesByVisibleMaterial(Session * pxzSession, Material_Material material);

// ----------------------------------------------------
// FindIn
// ----------------------------------------------------

// find part occurrences in the scene in a given axis aligned bounding box
PXZ_EXPORTED Scene_OccurrenceList Scene_findPartOccurrencesInAABB(Session * pxzSession, Geom_AABB aabb);
// get part occurrences contained in a given box
PXZ_EXPORTED Scene_OccurrenceList Scene_findPartOccurrencesInBox(Session * pxzSession, Geom_ExtendedBox box, Core_Boolean strictlyIncludes);

// ----------------------------------------------------
// Hierarchy
// ----------------------------------------------------

// Create a complete scene tree
PXZ_EXPORTED Scene_OccurrenceList Scene_createSubTree(Session * pxzSession, Scene_PackedTree tree, Scene_Occurrence root, Core_Bool replaceRoot);
// Get the children of an occurrence
PXZ_EXPORTED Scene_OccurrenceList Scene_getChildren(Session * pxzSession, Scene_Occurrence occurrence);
// Get the current active root. Returns active variant's root if one or global root.
PXZ_EXPORTED Scene_Occurrence Scene_getCurrentVariantRoot(Session * pxzSession);
PXZ_EXPORTED Scene_OccurrenceList Scene_getOccurrenceAncestors(Session * pxzSession, Scene_Occurrence occurrence);
PXZ_EXPORTED Scene_OccurrenceListList Scene_getOccurrencesAncestors(Session * pxzSession, Scene_OccurrenceList occurrences);
// Get the parent of an occurrence
PXZ_EXPORTED Scene_Occurrence Scene_getParent(Session * pxzSession, Scene_Occurrence occurrence);
// Get the root occurrence of the product structure
PXZ_EXPORTED Scene_Occurrence Scene_getRoot(Session * pxzSession);
// Returns a packed version of the whole scene tree
PXZ_EXPORTED Scene_PackedTree Scene_getSubTree(Session * pxzSession, Scene_Occurrence root, Scene_VisibilityMode visibilityMode, Core_Int depth);
// Move an occurrence, adjusting the transformation to keep objects at the same place in the world space
PXZ_EXPORTED void Scene_moveOccurrences(Session * pxzSession, Scene_OccurrenceList occurrences, Scene_Occurrence destination, Scene_Occurrence insertBefore);
// Set the parent of an occurrence
PXZ_EXPORTED void Scene_setParent(Session * pxzSession, Scene_Occurrence occurrence, Scene_Occurrence parent, Core_Boolean addInParentInstances, Scene_Occurrence insertBefore, Core_Boolean worldPositionStays);

// ----------------------------------------------------
// Lights
// ----------------------------------------------------

// Add a light component to an occurrence
PXZ_EXPORTED Scene_Component Scene_addLightComponent(Session * pxzSession, Scene_Occurrence occurrence, Scene_LightType lightType, Core_Color color, Core_Double power, Geom_Angle cutOff);
// Create an occurrence with a light component
PXZ_EXPORTED Scene_Occurrence Scene_createLight(Session * pxzSession, Core_String name, Scene_LightType lightType, Core_Color color, Core_Double power, Geom_Angle cutOff, Scene_Occurrence parent);

// ----------------------------------------------------
// Metadata
// ----------------------------------------------------

// Add a new metadata property to a metadata component
PXZ_EXPORTED void Scene_addMetadata(Session * pxzSession, Scene_Metadata metadata, Core_String name, Core_String value);
// Add a new metadata property to a metadata component
PXZ_EXPORTED void Scene_addMetadataBlock(Session * pxzSession, Scene_Metadata metadata, Core_StringList names, Core_StringList values);
// Create Metadata components from definitions
PXZ_EXPORTED Scene_MetadataList Scene_createMetadatasFromDefinitions(Session * pxzSession, Scene_OccurrenceList occurrences, Scene_MetadataDefinitionList definitions);
// Get a metadata property value from a metadata component
PXZ_EXPORTED Core_String Scene_getMetadata(Session * pxzSession, Scene_Metadata metadata, Core_String name);
// Returns definition of Metadata components
PXZ_EXPORTED Scene_MetadataDefinitionList Scene_getMetadatasDefinitions(Session * pxzSession, Scene_MetadataList metadatas);
// Remove a property from a metadata
PXZ_EXPORTED void Scene_removeMetadata(Session * pxzSession, Scene_Metadata metadata, Core_String name);

// ----------------------------------------------------
// OoC
// Out of Core related functions
// ----------------------------------------------------

// Set and configure an Out of Core component implementation
PXZ_EXPORTED void Scene_configureOoC(Session * pxzSession, Scene_OoCComponent ooc, Core_String implementationType, Core_String implementationParameters);
// Get the current configuration of an Out of Core component
typedef struct {
   Core_String implementationType;
   Core_String implementationParameters;
} Scene_getOoCConfigurationReturn;
PXZ_EXPORTED Scene_getOoCConfigurationReturn Scene_getOoCConfiguration(Session * pxzSession, Scene_OoCComponent ooc);
PXZ_EXPORTED Core_StringList Scene_listOoCImplementations(Session * pxzSession);
// Ask an Out of Core component to load its sub-scene
PXZ_EXPORTED void Scene_loadOoC(Session * pxzSession, Scene_OoCComponent ooc);
// Ask an Out of Core component to unload its sub-scene
PXZ_EXPORTED void Scene_unloadOoC(Session * pxzSession, Scene_OoCComponent ooc);

// ----------------------------------------------------
// Subpart materials
// ----------------------------------------------------

// Get a subpart material assignment according to overrides on the scene tree with SubpartMaterial components
PXZ_EXPORTED Material_Material Scene_getSubpartMaterial(Session * pxzSession, Scene_Occurrence occurrence, Core_UInt subpartIndex);
// list all the materials used in the part shape
PXZ_EXPORTED Material_MaterialList Scene_listActiveShapeMaterials(Session * pxzSession, Scene_Part part);
// list all the materials used in the part shape or overrided with a SubpartMaterial component
PXZ_EXPORTED Material_MaterialList Scene_listSubpartMaterials(Session * pxzSession, Scene_Occurrence occurrence);
// list all the materials variants in subpart 
PXZ_EXPORTED Scene_VariantMaterialList Scene_listSubpartVariantMaterials(Session * pxzSession, Scene_Occurrence occurrence);
// Set a subpart material assignment using a SubpartMaterial component
PXZ_EXPORTED void Scene_setSubpartMaterial(Session * pxzSession, Scene_Occurrence occurrence, Core_UInt subpartIndex, Material_Material material);
// set materials in variant 
PXZ_EXPORTED void Scene_setSubpartVariantMaterials(Session * pxzSession, Scene_Occurrence occurrence, Scene_VariantMaterialList variantMaterials);
// set all the materials list in variants 
PXZ_EXPORTED Scene_VariantMaterialList Scene_setSubpartVariantMaterialsList(Session * pxzSession, Scene_VariantList variants, Material_MaterialListList materialListList);
// Assign SubpartMaterialComponent materials on the occurrence's part shapes. This might affect other Part in the scene if not singularized before.
PXZ_EXPORTED void Scene_transferSubpartMaterialsOnPatches(Session * pxzSession, Scene_Occurrence occurrence);

// ----------------------------------------------------
// alternative trees
// AlternativeTree related functions
// ----------------------------------------------------

// Create a new alternative tree
PXZ_EXPORTED Scene_AlternativeTree Scene_createAlternativeTree(Session * pxzSession, Core_String name, Scene_Occurrence root);
// Returns the root occurrence associated with the given AlternativeTree
PXZ_EXPORTED Scene_Occurrence Scene_getAlternativeTreeRoot(Session * pxzSession, Scene_AlternativeTree tree);
// Returns all the available alternative trees
PXZ_EXPORTED Scene_AlternativeTreeList Scene_listAlternativeTrees(Session * pxzSession);

// ----------------------------------------------------
// animations
// Animations related functions
// ----------------------------------------------------

// Add an animation in Animation library
PXZ_EXPORTED void Scene_addAnimation(Session * pxzSession, Scene_Animation animation);
// Adds a keyframe in the curve
PXZ_EXPORTED Scene_Keyframe Scene_addKeyframe(Session * pxzSession, Scene_AnimChannel channel, Scene_AnimationTime time, Core_Double value);
// Adds keyframes in a given AnimChannel based on current position
PXZ_EXPORTED void Scene_addKeyframeFromCurrentPosition(Session * pxzSession, Scene_AnimChannel channel, Scene_AnimationTime time);
// Does this Animation animates this Occurrence - or one of its parents (thus animating it indirectly) ?
PXZ_EXPORTED Core_Bool Scene_animatesThisOccurrence(Session * pxzSession, Scene_Animation animation, Scene_Occurrence occurrence);
// Baking soda
PXZ_EXPORTED void Scene_bakeAnimation(Session * pxzSession, Scene_Animation animation, Scene_Occurrence occurrence, Scene_Occurrence end, Scene_AnimationTime interval);
// Creates an animation, need to use addAnimation when animation is filled
PXZ_EXPORTED Scene_Animation Scene_createAnimation(Session * pxzSession, Core_String name);
// Create a skeleton mesh from a joint component tree
PXZ_EXPORTED Scene_Occurrence Scene_createSkeletonMesh(Session * pxzSession, Scene_Occurrence root);
// Decimates by segment a given AnimChannel
PXZ_EXPORTED void Scene_decimateAnimChannelBySegment(Session * pxzSession, Scene_AnimChannel channel, Core_Double precision);
// Deletes an animation
PXZ_EXPORTED void Scene_deleteAnimation(Session * pxzSession, Scene_Animation animation);
// Delete all animation that contain 0 keyframes
PXZ_EXPORTED void Scene_deleteEmptyAnimation(Session * pxzSession);
// Displays info on the selected AnimChannel
PXZ_EXPORTED void Scene_displayAllKeyframesFromAnimChannel(Session * pxzSession, Scene_AnimChannel channel);
// Displays info on the selected animation
PXZ_EXPORTED void Scene_displayAllKeyframesFromAnimation(Session * pxzSession, Scene_Animation animation);
// Displays the value
PXZ_EXPORTED void Scene_displayValueFromAnimChannelAtTime(Session * pxzSession, Scene_AnimChannel channel, Scene_AnimationTime time, Core_Bool defaultValue);
// Returns the main AnimChannel of an Occurrence according to a given Animation
PXZ_EXPORTED Scene_AnimChannel Scene_getAnimChannelIfExists(Session * pxzSession, Scene_Animation animation, Scene_Occurrence occurrence);
// get an animation channel informations
PXZ_EXPORTED Scene_AnimChannelInfo Scene_getAnimChannelInfo(Session * pxzSession, Scene_AnimChannel channel);
// Returns the Occurrence related to a given AnimChannel
PXZ_EXPORTED Scene_Occurrence Scene_getAnimChannelOccurrence(Session * pxzSession, Scene_AnimChannel channel);
// packs all animation-related info in an object
PXZ_EXPORTED Scene_AnimPropertyBinderList Scene_getAnimationComponentPropertyBinderLists(Session * pxzSession, Scene_AnimationComponent animationComponent);
// packs all animation-related info in an object
PXZ_EXPORTED Scene_AnimationInfo Scene_getAnimationInfo(Session * pxzSession, Scene_Animation animation);
// packs all animation-related info in an object
PXZ_EXPORTED Scene_AnimPropertyBinderList Scene_getAnimationPropertyBinderLists(Session * pxzSession, Scene_Animation animation);
// Get joint definition from id
PXZ_EXPORTED Scene_JointDefinition Scene_getJointDefinition(Session * pxzSession, Polygonal_Joint joint);
// Get joint definition from id
PXZ_EXPORTED Scene_JointDefinitionList Scene_getJointDefinitions(Session * pxzSession, Polygonal_JointList joints);
// Returns the parent AnimChannel of a given Keyframe
PXZ_EXPORTED Scene_AnimChannel Scene_getKeyframeParentAnimChannel(Session * pxzSession, Scene_Keyframe keyframe);
// Returns a list of all keyframes of a simple animChannel
PXZ_EXPORTED Scene_KeyframeList Scene_getKeyframes(Session * pxzSession, Scene_AnimChannel channel);
// Returns the main AnimChannel of a given AnimChannel
PXZ_EXPORTED Scene_AnimChannel Scene_getMainChannel(Session * pxzSession, Scene_AnimChannel channel);
// Returns the Joint assigned to an occurrence if any
PXZ_EXPORTED Polygonal_Joint Scene_getOccurrenceJoint(Session * pxzSession, Scene_Occurrence occurrence);
// Returns (if exists) the parent AnimChannel of a given AnimChannel
PXZ_EXPORTED Scene_AnimChannel Scene_getParentChannel(Session * pxzSession, Scene_AnimChannel channel);
// Returns the subchannel of a given name from an AnimChannel
PXZ_EXPORTED Scene_AnimChannel Scene_getSubChannel(Session * pxzSession, Scene_AnimChannel channel, Core_String name);
// Returns all the sub channel of an AnimChannel
PXZ_EXPORTED Scene_AnimChannelList Scene_getSubChannels(Session * pxzSession, Scene_AnimChannel channel);
// Creates a Binder in an Animation stack to animate an entity's property
PXZ_EXPORTED Scene_AnimChannel Scene_linkPropertyToAnimation(Session * pxzSession, Scene_Animation animation, Core_Entity entity, Core_String propertyName);
// List all Animations from the scene
PXZ_EXPORTED Scene_AnimationList Scene_listAnimations(Session * pxzSession);
// List all main AnimChannel from a given Animation
PXZ_EXPORTED Scene_AnimChannelList Scene_listMainChannels(Session * pxzSession, Scene_Animation animation);
// Creates keyframes with the default values of the channel at time 0
PXZ_EXPORTED void Scene_makeDefaultKeyframe(Session * pxzSession, Scene_AnimChannel channel);
// Moving animation
PXZ_EXPORTED void Scene_moveAnimation(Session * pxzSession, Scene_Animation animation, Scene_Occurrence target, Scene_Occurrence newParent, Scene_AnimationTime interval);
// Removes a keyframe in the curve
PXZ_EXPORTED void Scene_removeKeyframe(Session * pxzSession, Scene_AnimChannel channel, Scene_AnimationTime time);
// Unlinks a binder
PXZ_EXPORTED void Scene_unlinkPropertyToAnimation(Session * pxzSession, Scene_Animation animation, Core_Entity entity, Core_String propertyName);
   /*!
     \param animation Added animation
   */
PXZ_EXPORTED Core_Ident Scene_addAnimationAddedCallback(Session * pxzSession, void(*fp)(void *, Scene_Animation), void * userdata = nullptr);
PXZ_EXPORTED void Scene_removeAnimationAddedCallback(Session * pxzSession, Core_Ident id);

   /*!
     \param animation Changed Animation
   */
PXZ_EXPORTED Core_Ident Scene_addAnimationChangedCallback(Session * pxzSession, void(*fp)(void *, Scene_Animation), void * userdata = nullptr);
PXZ_EXPORTED void Scene_removeAnimationChangedCallback(Session * pxzSession, Core_Ident id);

// Ebent sent when Animation library is cleared
PXZ_EXPORTED Core_Ident Scene_addAnimationClearedCallback(Session * pxzSession, void(*fp)(void *), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Scene_removeAnimationClearedCallback(Session * pxzSession, Core_Ident id);

   /*!
     \param animation Removed Animation
   */
PXZ_EXPORTED Core_Ident Scene_addAnimationRemovedCallback(Session * pxzSession, void(*fp)(void *, Scene_Animation), void * userdata = nullptr);
PXZ_EXPORTED void Scene_removeAnimationRemovedCallback(Session * pxzSession, Core_Ident id);


// ----------------------------------------------------
// debug
// Debug functions
// ----------------------------------------------------

typedef struct {
   Core_Int partCount;
   Core_Int totalPartCount;
   Core_Int vertexCount;
   Core_Int totalVertexCount;
   Core_Int edgeCount;
   Core_Int totalEdgeCount;
   Core_Int openShellCount;
   Core_Int totalOpenShellCount;
   Core_Int bodyCount;
   Core_Int totalBodyCount;
   Core_Double area2Dsum;
   Core_Int boundaryCount;
   Core_Int boundaryEdgeCount;
} Scene_getBRepInfosReturn;
PXZ_EXPORTED Scene_getBRepInfosReturn Scene_getBRepInfos(Session * pxzSession);
typedef struct {
   Core_Int partCount;
   Core_Int totalPartCount;
   Core_Int vertexCount;
   Core_Int totalVertexCount;
   Core_Int edgeCount;
   Core_Int totalEdgeCount;
   Core_Int polygonCount;
   Core_Int totalPolygonCount;
   Core_Int patchCount;
   Core_Int totalPatchCount;
   Core_Int boundaryCount;
   Core_Int boundaryEdgeCount;
   Core_Int nonManifoldEdgeCount;
} Scene_getTessellationInfosReturn;
PXZ_EXPORTED Scene_getTessellationInfosReturn Scene_getTessellationInfos(Session * pxzSession, Scene_Occurrence root);
// Print an occurrence tree on log
PXZ_EXPORTED void Scene_print(Session * pxzSession, Scene_Occurrence root);

// ----------------------------------------------------
// filters
// Scene filtering functions
// ----------------------------------------------------

// Add a filter to the filters library
PXZ_EXPORTED Core_Ident Scene_addFilterToLibrary(Session * pxzSession, Core_String name, Scene_FilterExpression expr);
// Evaluate the given filter expression
PXZ_EXPORTED Core_String Scene_evaluateExpression(Session * pxzSession, Scene_FilterExpression filter);
// evaluate the given filter expression on all occurrences under the given occurrence and returns the result
PXZ_EXPORTED Core_StringList Scene_evaluateExpressionOnOccurrences(Session * pxzSession, Scene_OccurrenceList occurrences, Scene_FilterExpression filter);
// evaluate the given filter expression on all occurrences under the given occurrence and returns the result
typedef struct {
   Scene_OccurrenceList occurrences;
   Core_StringList evaluations;
} Scene_evaluateExpressionOnSubTreeReturn;
PXZ_EXPORTED Scene_evaluateExpressionOnSubTreeReturn Scene_evaluateExpressionOnSubTree(Session * pxzSession, Scene_FilterExpression filter, Scene_Occurrence fromOcc);
// Export filters from a given file
PXZ_EXPORTED void Scene_exportFilterLibrary(Session * pxzSession, Core_FilePath file);
// Returns the first filter in the filter library with the given name
PXZ_EXPORTED Scene_Filter Scene_findFilterByName(Session * pxzSession, Core_String name);
// Returns the filter expression (string) from a filter id stored in the library
PXZ_EXPORTED Scene_FilterExpression Scene_getFilterExpression(Session * pxzSession, Core_Ident filterId);
// Retrieve a filter from the library with its identifier
PXZ_EXPORTED Scene_Filter Scene_getFilterFromLibrary(Session * pxzSession, Core_Ident filterId);
// Recursively get all the occurrences validating the given filter expression
PXZ_EXPORTED Scene_OccurrenceList Scene_getFilteredOccurrences(Session * pxzSession, Scene_FilterExpression filter, Scene_Occurrence fromOcc);
// Import filters from a given file
PXZ_EXPORTED void Scene_importFilterLibrary(Session * pxzSession, Core_FilePath file);
// Returns all the filter stored in the filter library
PXZ_EXPORTED Scene_FilterList Scene_listFilterLibrary(Session * pxzSession);
// Remove a filter from the filters library
PXZ_EXPORTED void Scene_removeFilterFromLibrary(Session * pxzSession, Core_Ident filterId);

// ----------------------------------------------------
// isolate
// Isolate functions
// ----------------------------------------------------

// Enter isolate mode by isolating a subset of the scene for process, export, viewer, ...
PXZ_EXPORTED void Scene_isolate(Session * pxzSession, Scene_OccurrenceList occurrences);
// Exit the isolate mode
PXZ_EXPORTED void Scene_unisolate(Session * pxzSession);

// ----------------------------------------------------
// merging
// Part merging related functions
// ----------------------------------------------------

// Find all the occurrences with unstitched faces
PXZ_EXPORTED Scene_OccurrenceList Scene_findPartOccurrencesWithUnstitchedFaces(Session * pxzSession, Scene_Occurrence root);
// Merge all parts over maxLevel level
PXZ_EXPORTED void Scene_mergeOccurrencesByTreeLevel(Session * pxzSession, Scene_OccurrenceList roots, Core_Int maxLevel, Scene_MergeHiddenPartsMode mergeHiddenPartsMode);
// Merge a set of parts
PXZ_EXPORTED Scene_OccurrenceList Scene_mergePartOccurrences(Session * pxzSession, Scene_OccurrenceList partOccurrences, Scene_MergeHiddenPartsMode mergeHiddenPartsMode);
// Merge all parts under each assembly together
PXZ_EXPORTED void Scene_mergePartOccurrencesByAssemblies(Session * pxzSession, Scene_OccurrenceList roots, Scene_MergeHiddenPartsMode mergeHiddenPartsMode);
// Merge final level (occurrences with only occurrence with part component as children)
PXZ_EXPORTED void Scene_mergePartOccurrencesByFinalAssemblies(Session * pxzSession, Scene_OccurrenceList roots, Scene_MergeHiddenPartsMode mergeHiddenPartsMode, Core_Boolean CollapseToParent);
// Merge a set of parts by materials
PXZ_EXPORTED Scene_OccurrenceList Scene_mergePartOccurrencesByMaterials(Session * pxzSession, Scene_OccurrenceList partOccurrences, Core_Boolean mergeNoMaterials, Scene_MergeHiddenPartsMode mergeHiddenPartsMode, Core_Boolean combineMeshes);
// Merge all parts by occurrences names
PXZ_EXPORTED void Scene_mergePartOccurrencesByName(Session * pxzSession, Scene_Occurrence root, Scene_MergeHiddenPartsMode mergeHiddenPartsMode);
// Merge all parts within the same area.
PXZ_EXPORTED Scene_OccurrenceList Scene_mergePartOccurrencesByRegions(Session * pxzSession, Scene_OccurrenceList roots, Scene_MergeByRegionsStrategy mergeBy, Scene_MergeStrategy strategy);
// Merge occurrences that contain only openShell as CAD entities
PXZ_EXPORTED Scene_OccurrenceList Scene_mergePartOccurrencesWithOpenShells(Session * pxzSession, Scene_Occurrence root);

// ----------------------------------------------------
// modification
// ----------------------------------------------------

// apply a transformation to the local matrix of an occurrence
PXZ_EXPORTED void Scene_applyTransformation(Session * pxzSession, Scene_Occurrence occurrence, Geom_Matrix4 matrix);
// Create symmetries from selection
PXZ_EXPORTED void Scene_createSymmetry(Session * pxzSession, Scene_OccurrenceList occurrences, Geom_AxisPlane plane);
// Modify the local matrix of the scene node to apply a rotation
PXZ_EXPORTED void Scene_rotate(Session * pxzSession, Scene_Occurrence occurrence, Geom_Vector3 axis, Geom_Angle angle);
// change the local matrix on an occurrence
PXZ_EXPORTED void Scene_setLocalMatrix(Session * pxzSession, Scene_Occurrence occurrence, Geom_Matrix4 matrix);

// ----------------------------------------------------
// part
// Part component functions
// ----------------------------------------------------

// Return the mesh of the TesselatedShape
PXZ_EXPORTED Polygonal_Mesh Scene_getPartMesh(Session * pxzSession, Scene_Part part);
// Return the model of the BRepShape
PXZ_EXPORTED CAD_Model Scene_getPartModel(Session * pxzSession, Scene_Part part);
// Return the meshes of the TesselatedShape for each given parts if any
PXZ_EXPORTED Polygonal_MeshList Scene_getPartsMeshes(Session * pxzSession, Scene_PartList parts);
// Return the models of the BRepShape for each given parts if any
PXZ_EXPORTED CAD_ModelList Scene_getPartsModels(Session * pxzSession, Scene_PartList parts);
// Returns the transform matrix of each given parts
PXZ_EXPORTED Geom_Matrix4List Scene_getPartsTransforms(Session * pxzSession, Scene_PartList parts);
// Returns the transform matrix of each given parts (indexed mode)
typedef struct {
   Core_IntList indices;
   Geom_Matrix4List transforms;
} Scene_getPartsTransformsIndexedReturn;
PXZ_EXPORTED Scene_getPartsTransformsIndexedReturn Scene_getPartsTransformsIndexed(Session * pxzSession, Scene_PartList parts);
// Add a mesh to a part (create a TessellatedShape on the part)
PXZ_EXPORTED void Scene_setPartMesh(Session * pxzSession, Scene_Part part, Polygonal_Mesh mesh);
// Add a model to a part (create a BRepShape on the part)
PXZ_EXPORTED void Scene_setPartModel(Session * pxzSession, Scene_Part part, CAD_Model model);
// Set the transform matrix of each given parts
PXZ_EXPORTED void Scene_setPartsTransforms(Session * pxzSession, Scene_PartList parts, Geom_Matrix4List transforms);
// Set the transform matrix of each given parts (indexed mode)
PXZ_EXPORTED void Scene_setPartsTransformsIndexed(Session * pxzSession, Scene_PartList parts, Core_IntList indices, Geom_Matrix4List transforms);

// ----------------------------------------------------
// partialLoading
// ----------------------------------------------------

// Get the current status of a partial loading component
PXZ_EXPORTED Scene_PartialLoad_Status Scene_getPartialLoadingStatus(Session * pxzSession, Scene_ReferencedDataComponent component);
// Defines which referenced data is parent to the given component
PXZ_EXPORTED void Scene_setReferencedDataComponentParent(Session * pxzSession, Scene_ReferencedDataComponent component, Scene_ReferencedDataComponent parent);
// Defines which path the refereced data is at
PXZ_EXPORTED void Scene_setReferencedDataComponentPath(Session * pxzSession, Scene_ReferencedDataComponent component, Core_String filePath);

// ----------------------------------------------------
// pivots
// Pivot moving functions
// ----------------------------------------------------

// Re-orient the Pivot Point straight to world origin (the grid)
PXZ_EXPORTED void Scene_alignPivotPointToWorld(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Bool applyToChildren);
// Move the pivot point of each occurrence listed in the function input, to the center of its bounding box (and of its children if the parameter is True)
PXZ_EXPORTED void Scene_movePivotPointToOccurrenceCenter(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Bool applyToChildren);
// Move the pivot point of an occurrence (and its descendants if recursively) to the origin (0,0,0)
PXZ_EXPORTED void Scene_movePivotPointToOrigin(Session * pxzSession, Scene_Occurrence occurrence, Core_Bool applyToChildren);
// Move the pivot point of all given occurrences to the center of all occurrences
PXZ_EXPORTED void Scene_movePivotPointToSelectionCenter(Session * pxzSession, Scene_OccurrenceList occurrences);
// Move the pivot point of each occurrence listed in the function input, to the center of the targeted occurrence Center (and of its children if the parameter is True)
PXZ_EXPORTED void Scene_movePivotPointToTargetedOccurrenceCenter(Session * pxzSession, Scene_OccurrenceList occurrences, Scene_Occurrence target, Core_Bool applyToChildren);
// Set the pivot of an occurrence to the given transformation matrix, the geometry will not be moved (warning: do not confuse with property Transform which actually move the occurrence)
PXZ_EXPORTED void Scene_setPivotOnly(Session * pxzSession, Scene_Occurrence occurrence, Geom_Matrix4 pivot);

// ----------------------------------------------------
// pmi
// ----------------------------------------------------

// add a Annotation Group to the pmi component
PXZ_EXPORTED Scene_AnnotationGroup Scene_addAnnotationGroup(Session * pxzSession, Scene_PMIComponent component, Core_String name);
// add a mesh and its material to a annotation
PXZ_EXPORTED void Scene_addMeshToAnnotation(Session * pxzSession, Scene_Annotation annotation, Material_Material material, Polygonal_StaticMesh staticmesh);
// Convert each PMI component into a set of occurrences with mesh geometries
PXZ_EXPORTED void Scene_convertPMIToOccurrences(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Boolean convertVisibility);
PXZ_EXPORTED Scene_Annotation Scene_createAnnotationFromDefinition(Session * pxzSession, Scene_AnnotationDefinition definition);
// get definition of given annotation
PXZ_EXPORTED Scene_AnnotationDefinition Scene_getAnnotationDefinition(Session * pxzSession, Scene_Annotation annotation);
// Returns the list of the AnnotationGroup from a PMIComponent
PXZ_EXPORTED Scene_AnnotationGroupList Scene_getAnnotationGroups(Session * pxzSession, Scene_Component pmiComponent);
// Returns the list of the Annotation from a AnnotationGroup
PXZ_EXPORTED Scene_AnnotationList Scene_getAnnotations(Session * pxzSession, Scene_AnnotationGroup group);
// get all annotations definition of given occurrence
PXZ_EXPORTED Scene_AnnotationDefinitionList Scene_getOccurrenceAnnotationDefinitions(Session * pxzSession, Scene_Occurrence occurrence);
// get productview definition
PXZ_EXPORTED Scene_ProductViewDefinition Scene_getProductViewDefinition(Session * pxzSession, Scene_Variant view);
// get all productviews definitions
PXZ_EXPORTED Scene_ProductViewDefinitionList Scene_getProductViewDefinitions(Session * pxzSession);
// set Annotation to a Annotation Group
PXZ_EXPORTED void Scene_setAnnotationToGroup(Session * pxzSession, Scene_Annotation annotation, Scene_AnnotationGroup group);

// ----------------------------------------------------
// prototype
// Prototyping related functions
// ----------------------------------------------------

// Clean prototypes and instances (lonely instances, overriding their prototypes hierarchies...).
PXZ_EXPORTED void Scene_cleanInstances(Session * pxzSession, Core_Boolean removeUselessInstances, Core_Boolean removeHierarchyOverridingInstances, Scene_Occurrence occurrence);
// Returns all the occurrences prototyping the given occurrence
PXZ_EXPORTED Scene_OccurrenceList Scene_getDirectInstances(Session * pxzSession, Scene_Occurrence prototype);
// Get occurrences sharing the same prototype as the given one
PXZ_EXPORTED Scene_OccurrenceList Scene_getInstances(Session * pxzSession, Scene_Occurrence occurrence);
// Returns the prototype of an occurrence
PXZ_EXPORTED Scene_Occurrence Scene_getPrototype(Session * pxzSession, Scene_Occurrence occurrence);
// Create occurrences that prototype the given occurrence and all its subtree
PXZ_EXPORTED Scene_Occurrence Scene_prototypeSubTree(Session * pxzSession, Scene_Occurrence prototype);
// Sets the prototype of an occurrence
PXZ_EXPORTED void Scene_setPrototype(Session * pxzSession, Scene_Occurrence occurrence, Scene_Occurrence prototype);

// ----------------------------------------------------
// selection
// Selection related functions
// ----------------------------------------------------

// Clear the current selection
PXZ_EXPORTED void Scene_clearSelection(Session * pxzSession);
// Delete all selected occurrences, and/or sub-occurrence elements
PXZ_EXPORTED void Scene_deleteSelection(Session * pxzSession);
// For each occurrence, create a new occurrence with the selected sub-occurrence elements and remove them from the original occurrence
PXZ_EXPORTED void Scene_explodeSelection(Session * pxzSession);
// Returns all the selected occurrences
PXZ_EXPORTED Scene_OccurrenceList Scene_getSelectedOccurrences(Session * pxzSession, Core_Boolean keepAncestors);
// Invert the orientation of each selected item (occurrences and/or sub-occurrence elements
PXZ_EXPORTED void Scene_invertOrientationSelection(Session * pxzSession);
// Replace the selection by all unselected part occurrences
PXZ_EXPORTED void Scene_invertSelection(Session * pxzSession);
// Add occurrences to selection
PXZ_EXPORTED void Scene_select(Session * pxzSession, Scene_OccurrenceList occurrences);
// Separate all polygons form their original parts into a new one
PXZ_EXPORTED Scene_Occurrence Scene_separateSelection(Session * pxzSession);
// Remove occurrences to selection
PXZ_EXPORTED void Scene_unselect(Session * pxzSession, Scene_OccurrenceList occurrence);
   /*!
     \param type Type of change (CLEARED, ADDED or REMOVED)
     \param occurrences Only if type is ADDED or REMOVED, list of added or removed occurrences
   */
PXZ_EXPORTED Core_Ident Scene_addSelectionChangedCallback(Session * pxzSession, void(*fp)(void *, Scene_SelectionChangeType, Scene_OccurrenceList), void * userdata = nullptr);
PXZ_EXPORTED void Scene_removeSelectionChangedCallback(Session * pxzSession, Core_Ident id);

   /*!
     \param type Type of change (ADDED, REMOVED, CURRENT_CHANGED)
     \param variant 
   */
PXZ_EXPORTED Core_Ident Scene_addVariantChangedCallback(Session * pxzSession, void(*fp)(void *, Scene_VariantChangeType, Scene_Variant), void * userdata = nullptr);
PXZ_EXPORTED void Scene_removeVariantChangedCallback(Session * pxzSession, Core_Ident id);


// ----------------------------------------------------
// simplification
// Scene structure simplification functions
// ----------------------------------------------------

// Compress a sub-tree by removing occurrence containing only one Child or empty, and by removing useless instances (see removeUselessInstances)
PXZ_EXPORTED Scene_Occurrence Scene_compress(Session * pxzSession, Scene_Occurrence occurrence);
// Modify the visible properties of the sub-tree to look like old school visibility (only hidden/inherited)
PXZ_EXPORTED void Scene_convertToOldSchoolVisibility(Session * pxzSession, Scene_Occurrence root);
// Get hidden part occurrences
PXZ_EXPORTED Scene_OccurrenceList Scene_getHiddenPartOccurrences(Session * pxzSession, Scene_OccurrenceList roots);
// Get visible part occurrences
PXZ_EXPORTED Scene_OccurrenceList Scene_getVisiblePartOccurrences(Session * pxzSession, Scene_OccurrenceList roots);
// Singularize all instances on the sub-tree of an occurrence
PXZ_EXPORTED void Scene_makeInstanceUnique(Session * pxzSession, Scene_OccurrenceList occurrences, Core_Boolean keepOnlyPartInstances);
// Set the same parent to all descending parts (all parts will be singularized)
PXZ_EXPORTED void Scene_rake(Session * pxzSession, Scene_Occurrence occurrence, Core_Boolean keepInstances);
// Remove symmetry matrices (apply matrices on geometries on nodes under an occurrence with a symmetry matrix
PXZ_EXPORTED void Scene_removeSymmetryMatrices(Session * pxzSession, Scene_Occurrence occurrence);
// Set all part transformation matrices to identity in a sub-tree, transformation will be applied to the shapes
PXZ_EXPORTED void Scene_resetPartTransform(Session * pxzSession, Scene_Occurrence root);
// Set all transformation matrices to identity in a sub-tree.
PXZ_EXPORTED void Scene_resetTransform(Session * pxzSession, Scene_Occurrence root, Core_Boolean recursive, Core_Boolean keepInstantiation, Core_Boolean keepPartTransform);

// ----------------------------------------------------
// spatialRequest
// ----------------------------------------------------

// Creates a ray prober
PXZ_EXPORTED Core_Ident Scene_createRayProber(Session * pxzSession);
// Creates a sphere prober
PXZ_EXPORTED Core_Ident Scene_createSphereProber(Session * pxzSession);
PXZ_EXPORTED Scene_RayHit Scene_rayCast(Session * pxzSession, Geom_Ray ray, Scene_Occurrence root);
PXZ_EXPORTED Scene_RayHitList Scene_rayCastAll(Session * pxzSession, Geom_Ray ray, Scene_Occurrence root);
// Updates the designed ray prober
PXZ_EXPORTED void Scene_updateRayProber(Session * pxzSession, Core_Ident proberID, Geom_Ray ray);
// Updates the designed sphere prober
PXZ_EXPORTED void Scene_updateSphereProber(Session * pxzSession, Core_Ident proberID, Geom_Vector3 sphereCenter, Core_Double sphereRadius);
   /*!
     \param proberID The ray propber ID
     \param proberInfo The prober's info
   */
PXZ_EXPORTED Core_Ident Scene_addonRayProbeCallback(Session * pxzSession, void(*fp)(void *, Core_Ident, Scene_ProberInfo), void * userdata = nullptr);
PXZ_EXPORTED void Scene_removeonRayProbeCallback(Session * pxzSession, Core_Ident id);

   /*!
     \param proberID The sphere propber ID
     \param proberInfo The prober's info
   */
PXZ_EXPORTED Core_Ident Scene_addonSphereProbeCallback(Session * pxzSession, void(*fp)(void *, Core_Ident, Scene_ProberInfo), void * userdata = nullptr);
PXZ_EXPORTED void Scene_removeonSphereProbeCallback(Session * pxzSession, Core_Ident id);


// ----------------------------------------------------
// userData
// ----------------------------------------------------

// Batch version of getOccurrenceUserData
PXZ_EXPORTED Core_PtrList Scene_getMultipleOccurrenceUserData(Session * pxzSession, Scene_OccurrenceUserData userDataId, Scene_OccurrenceList occurrences);
// Set or replace a userdata stored on an occurrence
PXZ_EXPORTED Core_Ptr Scene_getOccurrenceUserData(Session * pxzSession, Scene_OccurrenceUserData userDataId, Scene_Occurrence occurrence);
// Batch version of hasOccurrenceUserData
PXZ_EXPORTED Core_BoolList Scene_hasMultipleOccurrenceUserData(Session * pxzSession, Scene_OccurrenceUserData userDataId, Scene_OccurrenceList occurrences);
// Set or replace a userdata stored on an occurrence
PXZ_EXPORTED Core_Bool Scene_hasOccurrenceUserData(Session * pxzSession, Scene_OccurrenceUserData userDataId, Scene_Occurrence occurrence);
// Batch version of setOccurrenceUserData
PXZ_EXPORTED void Scene_setMultipleOccurrenceUserData(Session * pxzSession, Scene_OccurrenceUserData userDataId, Scene_OccurrenceList occurrences, Core_PtrList userDataList);
// Set or replace a userdata stored on an occurrence
PXZ_EXPORTED void Scene_setOccurrenceUserData(Session * pxzSession, Scene_OccurrenceUserData userDataId, Scene_Occurrence occurrence, Core_Ptr userData);
// subscribe to occurrence user data. multiple different userdata can be stored on the same occurrences if subscribeToOccurrenceUserData is called multiple times
PXZ_EXPORTED Scene_OccurrenceUserData Scene_subscribeToOccurrenceUserData(Session * pxzSession);
// Batch version of unsetOccurrenceUserData
PXZ_EXPORTED void Scene_unsetMultipleOccurrenceUserData(Session * pxzSession, Scene_OccurrenceUserData userDataId, Scene_OccurrenceList occurrences);
// Unset the userdata stored on an occurrence
PXZ_EXPORTED void Scene_unsetOccurrenceUserData(Session * pxzSession, Scene_OccurrenceUserData userDataId, Scene_Occurrence occurrence);
PXZ_EXPORTED void Scene_unsubscribeFromOccurrenceUserData(Session * pxzSession, Scene_OccurrenceUserData userDataId);

// ----------------------------------------------------
// variant
// variant related functions
// ----------------------------------------------------

// Create a new variant
PXZ_EXPORTED Scene_Variant Scene_addVariant(Session * pxzSession, Core_String name);
// Create a new variant which is a copy of an existing variant
PXZ_EXPORTED Scene_Variant Scene_duplicateVariant(Session * pxzSession, Scene_Variant variant, Core_String name);
// Returns the definitions of multiple variant components
PXZ_EXPORTED Scene_VariantDefinitionListList Scene_getVariantComponentsDefinitions(Session * pxzSession, Scene_VariantComponentList variantComponents);
// Get the alternative tree used by this variant
PXZ_EXPORTED Scene_AlternativeTree Scene_getVariantTree(Session * pxzSession, Scene_Variant variant);
// Returns all the available variants
PXZ_EXPORTED Scene_VariantList Scene_listVariants(Session * pxzSession);
// Remove a variant
PXZ_EXPORTED void Scene_removeVariant(Session * pxzSession, Scene_Variant variant);
// Change the current variant used
PXZ_EXPORTED void Scene_setCurrentVariant(Session * pxzSession, Scene_Variant variant);
// Set the alternative tree to use for this variant
PXZ_EXPORTED void Scene_setVariantTree(Session * pxzSession, Scene_Variant variant, Scene_AlternativeTree tree);



#endif
