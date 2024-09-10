// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_SCENE_INTERFACE_ISCENEINTERFACE_H_
#define _PXZ_SCENE_INTERFACE_ISCENEINTERFACE_H_

#include "SceneTypes.h"

namespace PiXYZ { class PiXYZAPI; }


PXZ_MODULE_BEGIN(SceneI)

class PXZ_EXPORTED ISceneInterface
{
public:
   virtual ~ISceneInterface() {}

   //! Add a component to an occurrence
   /*!
     \param occurrence The occurrence to add the new component
     \param componentType Type of the component
     \return component The new component added to occurrence
   */
   virtual Component addComponent(const Occurrence & occurrence, const ComponentType & componentType) = 0;

   //! Add a components to each occurrence in the array
   /*!
     \param occurrences Occurrences that need the component to be added
     \param componentType Type of the component
     \return components Component that were added or retrieved
   */
   virtual ComponentList addComponents(const OccurrenceList & occurrences, const ComponentType & componentType) = 0;

   //! Add an instance of prototype's child as child in current occurrence recursively
   /*!
     \param root The occurrence to test.
   */
   virtual void addInParentInstances(const Occurrence & root) = 0;

   //! Remove unused images from texture library
   /*!
     \return nbTextureDeleted The number of texture deleted by the clean
   */
   virtual CoreI::Int cleanUnusedImages() = 0;

   //! Remove unused materials from material library
   /*!
     \param cleanImages Call cleanUnusedImages if true
     \return nbMaterialDeleted The number of material deleted by the clean
   */
   virtual CoreI::Int cleanUnusedMaterials(const CoreI::Boolean & cleanImages = false) = 0;

   //! Compute the checksum of a sub-tree
   /*!
     \param root Occurrence to compute
     \return checksum 
   */
   virtual CoreI::String computeSubTreeChecksum(const Occurrence & root = Occurrence()) = 0;

   /*!
     \param functionName 
     \param enableFunction 
     \param enableParameters 
     \param enableExecutionTime 
   */
   virtual void configureFunctionLogger(const CoreI::String & functionName, const CoreI::Boolean & enableFunction, const CoreI::Boolean & enableParameters, const CoreI::Boolean & enableExecutionTime) = 0;

   //! Convert all materials to materials with a color pattern, trying to keep the visual aspect as similar as possible
   /*!
     \param materials Materials to merge (merge all materials if empty)
   */
   virtual void convertMaterialsToColor(const MaterialI::MaterialList & materials = MaterialI::MaterialList(0)) = 0;

   //! Convert all materials to materials with a PBR pattern, trying to keep the visual aspect as similar as possible
   /*!
     \param materials Materials to merge (merge all materials if empty)
   */
   virtual void convertMaterialsToPBR(const MaterialI::MaterialList & materials = MaterialI::MaterialList(0)) = 0;

   //! Reorganize a sub tree with hierarchical clustering
   /*!
     \param root Root of the sub-tree to reorganize
     \param childrenCountByNode Order of the hierarchical tree
     \param minFitting Minimal fitting coefficient to allow 2 nodes to be merged/clustered
     \return root Hierarchical clustering root
   */
   virtual Occurrence createHierarchicalClusters(const Occurrence & root, const CoreI::Int & childrenCountByNode = 2, const CoreI::Coeff & minFitting = -1) = 0;

   /*!
     \param occurrence 
     \return obbOccurrence The create occurrence
   */
   virtual Occurrence createOBBMesh(const Occurrence & occurrence) = 0;

   //! Create a new occurrence
   /*!
     \param name Name of the new occurrence
     \param parent Create the occurrence as a child of parent, if not set the parent will be root
     \return occurrence Created occurrence
   */
   virtual Occurrence createOccurrence(const CoreI::String & name, const Occurrence & parent = Occurrence()) = 0;

   //! Create a new occurrence and add the given occurrences as children
   /*!
     \param name Name of the new occurrence
     \param children Add given occurrence as children (if any)
     \param parent If defined, the new occurrence will be created as a child of this parent. Else if children are defined, the first common parent of children will be used as a parent for this new occurrence. Last resort will be to use the root as parent
     \param keepMaterialAssignment If defined, material assignation will be updated to keep the visual same aspect
     \return occurrence Created occurrence
   */
   virtual Occurrence createOccurrenceFromSelection(const CoreI::String & name, const OccurrenceList & children, const Occurrence & parent, const CoreI::Boolean & keepMaterialAssignment = true) = 0;

   //! Creates an occurrence from string
   /*!
     \param text The occurrence's name
     \param font The font to use
     \param fontSize The font size
     \param color The occurrence color
     \param heigth3D 3D height of text
     \return occurrence 
   */
   virtual Occurrence createOccurrenceFromText(const CoreI::String & text, const CoreI::String & font = "ChicFont", const CoreI::Int & fontSize = 64, const CoreI::ColorAlpha & color = CoreI::ColorAlpha(), const CoreI::Double & heigth3D = 40) = 0;

   //! Create one new occurrence under each given parent
   /*!
     \param name Name of the new occurrence
     \param parents Create the occurrences as a child of each parent. If empty, one occurrence will be created with root as parent
     \return occurrences Created occurrences
   */
   virtual OccurrenceList createOccurrences(const CoreI::String & name, const OccurrenceList & parents = OccurrenceList(0)) = 0;

   //! Create a set of Parts given meshes and occurrences
   /*!
     \param occurrences The occurrence which will contains the part component of the mesh at the same index
     \param meshes List of mesh to create part, if the mesh is invalid (e.g 0) no part will be created and 0 will be returned in the parts list at this index
     \return parts List of created parts components, if there is no mesh at an index, no part is created and the identifier is 0
   */
   virtual PartList createPartsFromMeshes(const OccurrenceList & occurrences, const PolygonalI::MeshList & meshes) = 0;

   //! Create a scene tree with a list of meshes, all meshes becomes part occurrences with the same root. The same mesh Id can be used several times to handle create instances (prototypes)
   /*!
     \param meshes List of input meshes
     \param matrices List of matrices of input meshes (if empty Identity will be used)
     \param centerPartPivots If True, the input meshes will be centered in their local coordinate system and the translation will be set as part matrix. If you want to rollback the meshes to their initial pivots use 'resetPartTransform' function
     \return root The created root occurrence
   */
   virtual Occurrence createSceneFromMeshes(const PolygonalI::MeshList & meshes, const GeomI::Matrix4List & matrices, const CoreI::Boolean & centerPartPivots = true) = 0;

   //! Delete component from type
   /*!
     \param componentType Type of the component
     \param occurrence The occurrence to remove components from
     \param followPrototypes If true and if the component is not set on the occurrence, try to find it on its prototyping chain
   */
   virtual void deleteComponentByType(const ComponentType & componentType, const Occurrence & occurrence, const CoreI::Bool & followPrototypes = true) = 0;

   //! Delete all components on subtree from type
   /*!
     \param componentType Type of the component
     \param rootOccurrence The root occurrence to remove components from
   */
   virtual void deleteComponentsByType(const ComponentType & componentType, const Occurrence & rootOccurrence = Occurrence()) = 0;

   //! Delete all empty assemblies
   /*!
     \param root Root occurrence for the process
   */
   virtual void deleteEmptyOccurrences(const Occurrence & root = 0) = 0;

   //! Delete a liste of occurrences
   /*!
     \param occurrences Occurrences to delete
   */
   virtual void deleteOccurrences(const OccurrenceList & occurrences) = 0;

   /*!
     \param radius 
     \param XFrames 
     \param YFrames 
     \param hemi 
     \return occurrence The created Occurrence
   */
   virtual Occurrence generateOctaViews(const CoreI::Double & radius, const CoreI::Int & XFrames, const CoreI::Int & YFrames, const CoreI::Bool & hemi = false) = 0;

   //! Generate a loose octree from the given sub-tree
   /*!
     \param occurrence Root occurrence of the sub-tree
     \param maxDepth Defines the depth maximum of the octree
     \param looseFactor Defines the loose factor of the octree
     \return rootOctreeId 
   */
   virtual Occurrence generateOctree(const Occurrence & occurrence, const CoreI::Int & maxDepth = 5, const CoreI::Double & looseFactor = 2) = 0;

   //! Returns the axis aligned bounding box of a list of occurrences
   /*!
     \param occurrences List of occurrences to retrieve the AABB
     \param precise If true, will take more time but returns a true AABB. If false, fast but the AABB is approximated and multiple rotation matrices in the tree structure may extend it a lot
     \return aabb The axis aligned bounding box of all given occurrences
   */
   virtual GeomI::AABB getAABB(const OccurrenceList & occurrences, const CoreI::Boolean & precise = false) = 0;

   //! Get the active material on occurrence
   /*!
     \param occurrence The occurrence
     \return material The material
   */
   virtual MaterialI::Material getActiveMaterial(const Occurrence & occurrence) = 0;

   //! Get the active materials on multiple occurrences
   /*!
     \param occurrences The occurrences to retrieve active material on
     \return materials The active material for each given occurrence
   */
   virtual MaterialI::MaterialList getActiveMaterials(const OccurrenceList & occurrences) = 0;

   //! Get the value of a property on the first parent that own it
   /*!
     \param occurrence An occurrence
     \param propertyName Property name
     \param cacheProperty If true, the property will be copied on all ancestor of occurrence below the property owner to speed up future calls
     \return value Property value
   */
   virtual CoreI::String getActivePropertyValue(const Occurrence & occurrence, const CoreI::String & propertyName, const CoreI::Boolean & cacheProperty = false) = 0;

   //! Get the value of a property on the first parent that own it for each given occurrence
   /*!
     \param occurrences List of occurrences
     \param propertyName Property name
     \param cacheProperty If true, the property will be copied on all ancestor of occurrence below the property owner to speed up future calls
     \return values Property value for each occurrence
   */
   virtual CoreI::StringList getActivePropertyValues(const OccurrenceList & occurrences, const CoreI::String & propertyName, const CoreI::Boolean & cacheProperty = false) = 0;

   //! Returns the list of ancestors for one occurrence
   /*!
     \param occurrence The occurrence to test.
     \return ancestorList The list of ancestors.
   */
   virtual OccurrenceList getAncestors(const Occurrence & occurrence) = 0;

   //! Returns the Brep shape of a part
   /*!
     \param part The Part
     \return brepShape The brep shape of the part
   */
   virtual BRepShape getBrepShape(const Part & part) = 0;

   //! Returns a component on an occurrence
   /*!
     \param occurrence The occurrence
     \param componentType Type of the component
     \param followPrototypes If true and if the component is not set on the occurrence, try to find it on its prototyping chain
     \return component The component
   */
   virtual Component getComponent(const Occurrence & occurrence, const ComponentType & componentType, const CoreI::Bool & followPrototypes = true) = 0;

   //! Returns one component of the specified type by occurrence if it exists
   /*!
     \param occurrences The occurrences list
     \param componentType Type of the component
     \param followPrototypes If true and if the component is not set on the occurrence, try to find it on its prototyping chain
     \return components List of component synchronized with occurrences
   */
   virtual ComponentList getComponentByOccurrence(const OccurrenceList & occurrences, const ComponentType & componentType, const CoreI::Bool & followPrototypes = true) = 0;

   //! Get the occurrence that own a component
   /*!
     \param component The component
     \return occurrence The occurrence
   */
   virtual Occurrence getComponentOccurrence(const Component & component) = 0;

   //! Get the type of a component
   /*!
     \param component The component
     \return componentType Type of the component
   */
   virtual ComponentType getComponentType(const Component & component) = 0;

   //! Returns the global matrix for each given occurrence
   /*!
     \param occurrences Nodes to get the local matrix
     \return matrices The global matrix for each given node
   */
   virtual GeomI::Matrix4List getGlobalMatrices(const OccurrenceList & occurrences) = 0;

   //! Returns the global matrix on an occurrence
   /*!
     \param occurrence Occurrence to get the global matrix
     \return matrix The global matrix of the occurrence
   */
   virtual GeomI::Matrix4 getGlobalMatrix(const Occurrence & occurrence) = 0;

   //! Returns the global visibility of a given occurrence
   /*!
     \param occurrence Occurrence to get the global visibility
     \return visible True if the occurrence is visible, else False
   */
   virtual CoreI::Boolean getGlobalVisibility(const Occurrence & occurrence) = 0;

   //! Returns the local matrix for each given occurrence
   /*!
     \param occurrences Nodes to get the local matrix
     \return matrices The local matrix for each given node
   */
   virtual GeomI::Matrix4List getLocalMatrices(const OccurrenceList & occurrences) = 0;

   //! Returns the local matrix on an occurrence
   /*!
     \param occurrence Node to get the local matrix
     \return matrix The node local matrix
   */
   virtual GeomI::Matrix4 getLocalMatrix(const Occurrence & occurrence) = 0;

   //! Returns the Minimum Bounding Box of a list of occurrences
   /*!
     \param occurrences List of occurrences to retrieve the MBB
     \param forcedAxis Forced axis of the mbb
     \return mbb The minimum bounding box of all given occurrences
   */
   virtual GeomI::MBB getMBB(const OccurrenceList & occurrences, const GeomI::Vector3 & forcedAxis = GeomI::Point3(0, 0, 0)) = 0;

   /*!
     \param occurrence Root occurrence of the subtree on which to get the materials and images
     \return materials The retrieved materials
   */
   virtual MaterialI::MaterialList getMaterialsFromSubtree(const Occurrence & occurrence) = 0;

   //! Returns the Oriented Bounding Box of a list of occurrences (works only on meshes, fast method, not the Minimum Volume Box)
   /*!
     \param occurrences List of occurrences to retrieve the OBB
     \return obb The oriented bounding box of all given occurrences
   */
   virtual GeomI::OBB getOBB(const OccurrenceList & occurrences) = 0;

   //! Returns the active material on a given occurrence
   /*!
     \param occurrence Occurrence to get the active material
     \return material The active material of the occurrence
   */
   virtual MaterialI::Material getOccurrenceActiveMaterial(const Occurrence & occurrence) = 0;

   //! Returns the name of an occurrence
   /*!
     \param occurrence The occurrence to get the name
     \return name The occurrence name
   */
   virtual CoreI::String getOccurrenceName(const Occurrence & occurrence) = 0;

   //! Recursively get all the occurrences containing a component of the specified type
   /*!
     \param componentType The component type
     \param fromOcc Source occurrence of the recursion
     \return occurrences Result occurrences
   */
   virtual OccurrenceList getOccurrencesWithComponent(const ComponentType & componentType, const Occurrence & fromOcc = Occurrence()) = 0;

   //! Returns the active shape of a part
   /*!
     \param part The part
     \return shape The active shape of a part
   */
   virtual Shape getPartActiveShape(const Part & part) = 0;

   //! Recursively get all the occurrences containing a part component
   /*!
     \param fromOcc Source occurrence of the recursion
     \return occurrences Result occurrences
   */
   virtual OccurrenceList getPartOccurrences(const Occurrence & fromOcc = Occurrence()) = 0;

   //! Get the part's shape type
   /*!
     \param part The part to test
     \return shapeType Shape's type
   */
   virtual ShapeType getPartShapeType(const Part & part) = 0;

   //! Returns the number of polygon in the parts meshes
   /*!
     \param occurrences The part occurrences
     \param asTriangleCount If true count the equivalent of triangles for each polygon
     \param countOnceEachInstance If true ignore multiple instance of each tessellation
     \param countHidden If true, also count hidden components
     \return polygonCount The number of polygons
   */
   virtual CoreI::ULong getPolygonCount(const OccurrenceList & occurrences, const CoreI::Bool & asTriangleCount = false, const CoreI::Bool & countOnceEachInstance = false, const CoreI::Bool & countHidden = false) = 0;

   //! Returns some stats of a sub tree
   /*!
     \param roots The root occurrences to get stats on.
     \return partCount Number of parts in the sub-tree (instances are counted once)
     \return partOccurrenceCount Number of part occurrence in the sub-tree (instances are counted multiple times)
     \return triangleCount Number of triangles in the sub-tree (instances are counted once, quadrangle count for 2 triangles)
     \return triangleOccurrenceCount Number of triangles in the sub-tree (instances are counted multiples times, quadrangle count for 2 triangles)
     \return vertexCount Number of surfacic vertices in the sub-tree (instances are counted once)
     \return vertexOccurrenceCount Number of surfacic vertices in the sub-tree (instances are counted multiples times)
     \return pointCount Number of free vertices (points) in the sub-tree (instances are counted once)
     \return pointOccurrenceCount Number of free vertices (points) in the sub-tree (instances are counted multiples times)
     \return lineCount Number of free edges (line) in the sub-tree (instances are counted once)
     \return lineOccurrenceCount Number of free edges (line) in the sub-tree (instances are counted multiples times)
     \return patchesCount Number of patches in the sub-tree (instances are counted multiples times)
   */
   virtual getSubTreeStatsReturn getSubTreeStats(const OccurrenceList & roots) = 0;

   //! Returns the number of vertices in the parts meshes
   /*!
     \param occurrences The part occurrences
     \param countOnceEachInstance If true ignore multiple instance of each tessellation
     \param countHidden If true, also count hidden components
     \param countPoints If true, also count points (for points cloud)
     \param countMergedVertices If true count all merged vertices in each tessellation
     \return vertexCount The number of vertices
   */
   virtual CoreI::ULong getVertexCount(const OccurrenceList & occurrences, const CoreI::Bool & countOnceEachInstance = false, const CoreI::Bool & countHidden = false, const CoreI::Bool & countPoints = false, const CoreI::Bool & countMergedVertices = false) = 0;

   //! Returns viewpoints from model cavities
   /*!
     \param voxelSize Precision for cavities detection
     \param minCavityVolume Minimum volume for a cavity to be returned
     \return positions List of viewpoint positions
     \return directions List of viewpoint directions
   */
   virtual getViewpointsFromCavitiesReturn getViewpointsFromCavities(const GeomI::Distance & voxelSize, const GeomI::Distance & minCavityVolume) = 0;

   //! Return the volume of the occurrence
   /*!
     \param occurrence Entry occurrence
     \return volume The computed volume
   */
   virtual CoreI::Double getVolume(const Occurrence & occurrence) = 0;

   //! Return the volume of a set of root occurrences
   /*!
     \param iRoots List of roots
     \return volumes The computed volumes
   */
   virtual CoreI::DoubleList getVolumes(const OccurrenceList & iRoots) = 0;

   //! Returns True if the given occurrence has the given component type
   /*!
     \param occurrence The occurrence
     \param componentType Type of the component
     \param followPrototypes If true and if the component is not set on the occurrence, try to find it on its prototyping chain
     \return hasComp 
   */
   virtual CoreI::Boolean hasComponent(const Occurrence & occurrence, const ComponentType & componentType, const CoreI::Bool & followPrototypes = true) = 0;

   //! Hide the given occurrence
   /*!
     \param occurrence The occurrence to hide
   */
   virtual void hide(const Occurrence & occurrence) = 0;

   //! Inverse the visibility of the given occurrence
   /*!
     \param occurrence The occurrence
   */
   virtual void inverseVisibility(const Occurrence & occurrence) = 0;

   //! Test if an occurrence is an ancestor of another one.
   /*!
     \param maybeAncestor The potential ancestor of the occurrence
     \param occurrence The occurrence to test
     \return isAncestor If occurrences are ancestor to one another.
   */
   virtual CoreI::Bool isAncestorOf(const Occurrence & maybeAncestor, const Occurrence & occurrence) = 0;

   //! Filter a list of occurrences by removing all occurrences which have an ancestor inside the list.
   /*!
     \param occurrences The list that shall be filtered.
     \return filteredList The list without descendants of members.
   */
   virtual OccurrenceList keepAncestors(const OccurrenceList & occurrences) = 0;

   //! List all components on a type on the whole tree
   /*!
     \param componentType The component type
     \return components The component list of the type chosen
   */
   virtual ComponentList listComponent(const ComponentType & componentType) = 0;

   //! List all components on an occurrence
   /*!
     \param occurrence The occurrence to list the components
     \param followPrototypes If true list also components owned by the prototype
     \return components The components owned by the occurrence
   */
   virtual ComponentList listComponents(const Occurrence & occurrence, const CoreI::Bool & followPrototypes = true) = 0;

   //! Merge all equivalent images (i.e. with same pixels)
   /*!
     \param images Images to merge (merge all images if empty)
     \return nbTexture The number of texture after the merge
   */
   virtual CoreI::Int mergeImages(const MaterialI::ImageList & images = MaterialI::ImageList(0)) = 0;

   //! Merge all equivalent materials (i.e. with same appearance)
   /*!
     \param materials Materials to merge (merge all materials if empty)
     \param evaluateNames If true, materials names will be taken into consideration (on top of other properties). It means that materials having same properties but different names won't be merged together.
     \return nbMaterial The number of material after the merge
   */
   virtual CoreI::Int mergeMaterials(const MaterialI::MaterialList & materials = MaterialI::MaterialList(0), const CoreI::Boolean & evaluateNames = false) = 0;

   //! Recursively remove all materials
   /*!
     \param roots If specified, remove materials only from the given occurrences and their descendants
   */
   virtual void removeMaterials(const OccurrenceList & roots = OccurrenceList(0)) = 0;

   //! truncate names of occurrence with too long names
   /*!
     \param maxLength Maximum name length
   */
   virtual void renameLongOccurrenceName(const CoreI::Int & maxLength) = 0;

   //! Replace a material by another everywhere it is used
   /*!
     \param originalMaterial The material to replace everywhere
     \param newMaterial The new material to set in place of originalMaterial
     \param occurrences The occurrences on which replacing the materials
   */
   virtual void replaceMaterial(const MaterialI::Material & originalMaterial, const MaterialI::Material & newMaterial, const OccurrenceList & occurrences = OccurrenceList(0)) = 0;

   //! Resizes the textures from a selection of occurrences (resizes all textures used by these occurrences), or from a selection of textures
   /*!
     \param inputMode Defines if the textures to resize are textures used by a selection of Occurrences, or a selection among the textures available in the scene
     \param resizeMode Defines if the textures are resized following a ratio or following a maximum size/resolution (only textures above the defined maximum are downsized)
     \param replaceTextures If True, overwrites textures from the selection
   */
   virtual void resizeTextures(const ResizeTexturesInputMode & inputMode, const ResizeTexturesResizeMode & resizeMode, const CoreI::Bool & replaceTextures) = 0;

   //! Move a component to an occurrence
   /*!
     \param component The component
     \param occurrence The occurrence
   */
   virtual void setComponentOccurrence(const Component & component, const Occurrence & occurrence) = 0;

   //! Set the default variant
   virtual void setDefaultVariant() = 0;

   //! Set the material on a occurrence
   /*!
     \param occurrence Occurrence to set the material
     \param material The new occurrence material
   */
   virtual void setOccurrenceMaterial(const Occurrence & occurrence, const MaterialI::Material & material) = 0;

   //! Returns the name of an occurrence
   /*!
     \param occurrence The occurrence to get the name
     \param name The occurrence name
   */
   virtual void setOccurrenceName(const Occurrence & occurrence, const CoreI::String & name) = 0;

   //! Show the given occurrence
   /*!
     \param occurrence The occurrence to show
   */
   virtual void show(const Occurrence & occurrence) = 0;

   //! Show only the given occurrence
   /*!
     \param occurrence The occurrence to show
   */
   virtual void showOnly(const Occurrence & occurrence) = 0;

   //! Set all materials on part occurrences
   /*!
     \param rootOccurrence Root occurrence
   */
   virtual void transferCADMaterialsOnPartOccurrences(const Occurrence & rootOccurrence = Occurrence()) = 0;

   //! Take the first instance material and set it one the mesh patches
   /*!
     \param rootOccurrence Root occurrence
   */
   virtual void transferMaterialsOnPatches(const Occurrence & rootOccurrence = Occurrence()) = 0;

   /*!
     \param eventType Type of change
     \param occurrence Occurrence the component belongs to
     \param component Component concerned by change
   */
   virtual CoreI::Ident addComponentChangedCallback(void(*fp)(void *, const ComponentChangeType &, const Occurrence &, const Component &), void * userdata = nullptr) = 0;
   void * removeComponentChangedCallback(CoreI::Ident id); 

   /*!
     \param eventType Type of change
     \param occurrence Occurrence concerned by change
     \param child Child occurrence for child insertion/removal
   */
   virtual CoreI::Ident addSceneChangedCallback(void(*fp)(void *, const SceneChangeType &, const Occurrence &, const Occurrence &), void * userdata = nullptr) = 0;
   void * removeSceneChangedCallback(CoreI::Ident id); 


   /**
    * \defgroup Create primitives 
    * @{
    */
   //! Create a new capsule
   /*!
     \param radius Radius of the Capsule
     \param height Height of the Capsule (excluding the two size of half spheres)
     \param subdivisionLatitude Subdivision of the Capsule on the Latitude
     \param subdivisionLongitude Subdivision of the Capsule (two half spheres) on the Longitude
     \param generateUV Generation of the UV
     \return occurrence The created Occurrence
   */
   virtual Occurrence createCapsule(const CoreI::Double & radius, const CoreI::Double & height, const CoreI::Int & subdivisionLatitude = 16, const CoreI::Int & subdivisionLongitude = 16, const CoreI::Boolean & generateUV = true) = 0;

   //! Create a new cone
   /*!
     \param bottomRadius Radius of the bottom of the cone 
     \param height Height of the cone
     \param sides Number of sides of the cone
     \param generateUV Generation of the UV
     \return occurrence The created Occurrence
   */
   virtual Occurrence createCone(const CoreI::Double & bottomRadius, const CoreI::Double & height, const CoreI::Int & sides = 16, const CoreI::Boolean & generateUV = true) = 0;

   //! Create a new cube
   /*!
     \param sizeX Size of the Cube on the x axis
     \param sizeY Size of the Cube on the y axis
     \param sizeZ Size of the Cube on the z axis
     \param subdivision Subdivision of the Cube on all the axis
     \param generateUV Generation of the UV
     \return occurrence The created Occurrence
   */
   virtual Occurrence createCube(const CoreI::Double & sizeX, const CoreI::Double & sizeY, const CoreI::Double & sizeZ, const CoreI::Int & subdivision = 1, const CoreI::Boolean & generateUV = true) = 0;

   //! Create a new cylinder
   /*!
     \param radius Radius of the Cylinder
     \param height Height of the Cylinder
     \param sides Number of Sides of the Cylinder
     \param generateUV Generation of the UV
     \return occurrence The created Occurrence
   */
   virtual Occurrence createCylinder(const CoreI::Double & radius, const CoreI::Double & height, const CoreI::Int & sides = 16, const CoreI::Boolean & generateUV = true) = 0;

   //! Create a new bagel klein
   /*!
     \param radius Radius of the Immersion
     \param subdivisionX Subdivision of the Immersion on the Latitude
     \param subdivisionY Subdivision of the Immersion on the Longitude
     \return occurrence The created Occurrence
   */
   virtual Occurrence createImmersion(const CoreI::Double & radius, const CoreI::Int & subdivisionX, const CoreI::Int & subdivisionY) = 0;

   //! Create a  new plane
   /*!
     \param sizeY Size of the Plane on the y axis
     \param sizeX Size of the Plane on the x axis
     \param subdivisionX Subdivision of the Plane on the x axis
     \param subdivisionY Subdivision of the Plane on the y axis
     \param generateUV Generation of the UV
     \return occurrence The created Occurrence
   */
   virtual Occurrence createPlane(const CoreI::Double & sizeY, const CoreI::Double & sizeX, const CoreI::Int & subdivisionX = 1, const CoreI::Int & subdivisionY = 1, const CoreI::Boolean & generateUV = true) = 0;

   //! Create a new sphere
   /*!
     \param radius Radius of the Sphere
     \param subdivisionLatitude Subdivision of the Sphere on the Latitude
     \param subdivisionLongitude Subdivision of the Sphere on the Longitude
     \param generateUV Generation of the UV
     \return occurrence The created Occurrence
   */
   virtual Occurrence createSphere(const CoreI::Double & radius, const CoreI::Int & subdivisionLatitude = 16, const CoreI::Int & subdivisionLongitude = 16, const CoreI::Boolean & generateUV = true) = 0;

   //! Create a new torus
   /*!
     \param majorRadius Major Radius
     \param minorRadius Minor Radius
     \param subdivisionLatitude Subdivision of the Torus on the Latitude
     \param subdivisionLongitude Subdivision of the Torus on the Longitude
     \param generateUV Generation of the UV
     \return occurrence The created Occurrence
   */
   virtual Occurrence createTorus(const CoreI::Double & majorRadius, const CoreI::Double & minorRadius, const CoreI::Int & subdivisionLatitude = 16, const CoreI::Int & subdivisionLongitude = 16, const CoreI::Boolean & generateUV = true) = 0;

   /**@}*/

   /**
    * \defgroup FindBy 
    * @{
    */
   //! Get duplicated parts
   /*!
     \param root Root occurrence for the process
     \param acceptVolumeRatio If the ratio of volumes of two part is lower than acceptVolumeRatio, they will be considered duplicated
     \param acceptPolycountRatio If the ratio of polygon counts of two part is lower than acceptPolycountRatio, they will be considered duplicated
     \param acceptAABBAxisRatio If the ratio of AABB axis of two part is lower than acceptAABBAxisRatio, they will be considered duplicated
     \param acceptAABBCenterDistance If the ratio of AABB centers of two part is lower than acceptAABBCenterRatio, they will be considered duplicated
     \return duplicatedPartOccurrences Duplicated part occurrences
   */
   virtual OccurrenceList findDuplicatedPartOccurrences(const Occurrence & root = 0, const CoreI::Real & acceptVolumeRatio = 0.01, const CoreI::Real & acceptPolycountRatio = 0.1, const CoreI::Real & acceptAABBAxisRatio = 0.01, const GeomI::Distance & acceptAABBCenterDistance = 0.1) = 0;

   //! get occurrences for which the property "Material" is the given material
   /*!
     \param material A material
     \return filtered The list of occurrences meeting the criteria
   */
   virtual OccurrenceList findOccurrencesByMaterial(const MaterialI::Material & material) = 0;

   //! Returns all occurrences which a metadata property value matches the given regular expression (ECMAScript)
   /*!
     \param property Property name
     \param regex Regular expression (ECMAScript)
     \param roots If specified, restrict the search from the given roots
     \param caseInsensitive If True, the regex will be insensitive to upper and lower cases
     \return occurrences Occurrences which matches the given regular expression
   */
   virtual OccurrenceList findOccurrencesByMetadata(const CoreI::String & property, const CoreI::Regex & regex, const OccurrenceList & roots = OccurrenceList(0), const CoreI::Bool & caseInsensitive = false) = 0;

   //! Returns all occurrences with a metadata value matching the given regular expression (ECMAScript)
   /*!
     \param regex Regular expression (ECMAScript)
     \param roots If specified, restrict the search from the given roots
     \param caseInsensitive If True, the regex will be insensitive to upper and lower cases
     \return occurrences Occurrences which matches the given regular expression
   */
   virtual OccurrenceList findOccurrencesByMetadataValue(const CoreI::Regex & regex, const OccurrenceList & roots = OccurrenceList(0), const CoreI::Bool & caseInsensitive = false) = 0;

   //! Returns all occurrences which a property value matches the given regular expression (ECMAScript)
   /*!
     \param property Property name
     \param regex Regular expression (ECMAScript)
     \param roots If specified, restrict the search from the given roots
     \param caseInsensitive If True, the regex will be insensitive to upper and lower cases
     \return occurrences Occurrences which matches the given regular expression
   */
   virtual OccurrenceList findOccurrencesByProperty(const CoreI::String & property, const CoreI::Regex & regex, const OccurrenceList & roots = OccurrenceList(0), const CoreI::Bool & caseInsensitive = false) = 0;

   //! Find all part occurrence with a given material as active material (i.e. as seen in the rendering)
   /*!
     \param material A material
     \param roots If specified, restrict the search from the given roots
     \return occurrence Occurrences of parts with the given material as active material
   */
   virtual OccurrenceList findPartOccurrencesByActiveMaterial(const MaterialI::Material & material, const OccurrenceList & roots = OccurrenceList(0)) = 0;

   //! Get part occurrences by size
   /*!
     \param roots Roots occurrences for the process
     \param maxDiagLength If the diagonal axis of the bounding box is less than maxDiagLength, part will be filtered. -1 to ignore
     \param maxSize If the longer axis of the box is less than maxLength, part will be filtered. -1 to ignore
     \param getHidden If true, hidden part occurrences meeting the criteria will be filtered as well
     \return filtered The list of occurrences meeting the criteria
   */
   virtual OccurrenceList findPartOccurrencesByMaximumSize(const OccurrenceList & roots, const GeomI::Distance & maxDiagLength, const GeomI::Distance & maxSize = -1, const CoreI::Boolean & getHidden = false) = 0;

   //! get part occurrences with more than "minInstanciationCount" occurrence on the scene
   /*!
     \param minInstanciationCount Min occurrence count
     \return filtered The list of occurrences meeting the criteria
   */
   virtual OccurrenceList findPartOccurrencesByMinimumNumberOfInstances(const CoreI::Int & minInstanciationCount) = 0;

   //! get part occurrences for which the given material is visible in the viewer
   /*!
     \param material A material
     \return filtered The list of occurrences meeting the criteria
   */
   virtual OccurrenceList findPartOccurrencesByVisibleMaterial(const MaterialI::Material & material) = 0;

   /**@}*/

   /**
    * \defgroup FindIn 
    * @{
    */
   //! find part occurrences in the scene in a given axis aligned bounding box
   /*!
     \param aabb The axis aligned bounding box
     \return occurrences Occurrences found in the given axis aligned bounded box
   */
   virtual OccurrenceList findPartOccurrencesInAABB(const GeomI::AABB & aabb) = 0;

   //! get part occurrences contained in a given box
   /*!
     \param box The extension box
     \param strictlyIncludes If false, parts only need to intersect the box to be selected
     \return occurrences Part occurrences contained in the box
   */
   virtual OccurrenceList findPartOccurrencesInBox(const GeomI::ExtendedBox & box, const CoreI::Boolean & strictlyIncludes) = 0;

   /**@}*/

   /**
    * \defgroup Hierarchy 
    * @{
    */
   //! Create a complete scene tree
   /*!
     \param tree 
     \param root Specify the root occurrence of the scene
     \param replaceRoot If true, the root occurrence will be replaced by the root of the given tree, else it will be added as a child
     \return occurrences Create occurrences (equivalent to tree.occurrences)
   */
   virtual OccurrenceList createSubTree(const PackedTree & tree, const Occurrence & root = 0, const CoreI::Bool & replaceRoot = true) = 0;

   //! Get the children of an occurrence
   /*!
     \param occurrence The occurrence
     \return children Children occurrences
   */
   virtual OccurrenceList getChildren(const Occurrence & occurrence) = 0;

   //! Get the current active root. Returns active variant's root if one or global root.
   /*!
     \return root The active variant root occurrence or global root if no active variant.
   */
   virtual Occurrence getCurrentVariantRoot() = 0;

   //! Get all ancestors from occurrence until root (occurrence is not included)
   /*!
     \param occurrence The occurrence to find ancestors
     \return ancestors List of ancestors (start with the root and end with occurrence parent). Empty if occurrence is a root
   */
   virtual OccurrenceList getOccurrenceAncestors(const Occurrence & occurrence) = 0;

   //! Batch version of getOccurrenceAncestors
   /*!
     \param occurrences The list of occurrences to find ancestors
     \return ancestorsList For each given occurrence, the list of ancestors (start with the root and end with occurrence parent). Empty if occurrence is a root
   */
   virtual OccurrenceListList getOccurrencesAncestors(const OccurrenceList & occurrences) = 0;

   //! Get the parent of an occurrence
   /*!
     \param occurrence The occurrence
     \return parent The parent occurrence
   */
   virtual Occurrence getParent(const Occurrence & occurrence) = 0;

   //! Get the root occurrence of the product structure
   /*!
     \return root The root occurrence
   */
   virtual Occurrence getRoot() = 0;

   //! Returns a packed version of the whole scene tree
   /*!
     \param root Specify the root of the returned scene
     \param visibilityMode The visibility mode
     \param depth Maximum depth
     \return tree 
   */
   virtual PackedTree getSubTree(const Occurrence & root = 0, const VisibilityMode & visibilityMode = VisibilityMode::Hide, const CoreI::Int & depth = -1) = 0;

   //! Move an occurrence, adjusting the transformation to keep objects at the same place in the world space
   /*!
     \param occurrences The occurrences to move
     \param destination Destination occurrence (the new parent)
     \param insertBefore Occurrence before witch to move, if null append to destination children
   */
   virtual void moveOccurrences(const OccurrenceList & occurrences, const Occurrence & destination, const Occurrence & insertBefore = 0) = 0;

   //! Set the parent of an occurrence
   /*!
     \param occurrence The occurrence
     \param parent The parent occurrence
     \param addInParentInstances If True, each occurrence whose prototype is the target parent will generate a child whose prototype is the occurrence itself
     \param insertBefore Add before this child occurrence in the children list of the parent occurrence
     \param worldPositionStays If true, the parent-relative position, scale and rotation are modified such that the object keeps the same world space position, rotation and scale as before.
   */
   virtual void setParent(const Occurrence & occurrence, const Occurrence & parent, const CoreI::Boolean & addInParentInstances = false, const Occurrence & insertBefore = Occurrence(), const CoreI::Boolean & worldPositionStays = false) = 0;

   /**@}*/

   /**
    * \defgroup Lights 
    * @{
    */
   //! Add a light component to an occurrence
   /*!
     \param occurrence The occurrence to add the new component
     \param lightType The type of the light
     \param color Color of the light
     \param power The power of the light
     \param cutOff The cutoff angle of the light
     \return component The new component added to occurrence
   */
   virtual Component addLightComponent(const Occurrence & occurrence, const LightType & lightType, const CoreI::Color & color, const CoreI::Double & power = 1.0, const GeomI::Angle & cutOff = 20.0) = 0;

   //! Create an occurrence with a light component
   /*!
     \param name Name of the light
     \param lightType The type of the light
     \param color Color of the light
     \param power The power of the light
     \param cutOff The cutoff angle of the light
     \param parent The parent of the light occurrence
     \return occurrence The light created
   */
   virtual Occurrence createLight(const CoreI::String & name, const LightType & lightType, const CoreI::Color & color, const CoreI::Double & power = 1.0, const GeomI::Angle & cutOff = 20.0, const Occurrence & parent = 0) = 0;

   /**@}*/

   /**
    * \defgroup Metadata 
    * @{
    */
   //! Add a new metadata property to a metadata component
   /*!
     \param metadata The metadata component
     \param name The new property name
     \param value The new property value
   */
   virtual void addMetadata(const Metadata & metadata, const CoreI::String & name, const CoreI::String & value) = 0;

   //! Add a new metadata property to a metadata component
   /*!
     \param metadata The metadata component
     \param names The new properties names
     \param values The new properties values
   */
   virtual void addMetadataBlock(const Metadata & metadata, const CoreI::StringList & names, const CoreI::StringList & values) = 0;

   //! Create Metadata components from definitions
   /*!
     \param occurrences List of occurrences to add the metadata components
     \param definitions List of metadata definition
     \return metadatas List of metadata components created from definitions (if definition is empty no component is created)
   */
   virtual MetadataList createMetadatasFromDefinitions(const OccurrenceList & occurrences, const MetadataDefinitionList & definitions) = 0;

   //! Get a metadata property value from a metadata component
   /*!
     \param metadata The metadata component
     \param name The metadata property name
     \return component The property value
   */
   virtual CoreI::String getMetadata(const Metadata & metadata, const CoreI::String & name) = 0;

   //! Returns definition of Metadata components
   /*!
     \param metadatas List of metadata component to retrieve definition
     \return definitions List of metadata definition for each given metadata component
   */
   virtual MetadataDefinitionList getMetadatasDefinitions(const MetadataList & metadatas) = 0;

   //! Remove a property from a metadata
   /*!
     \param metadata The occurrence
     \param name The name of the property
   */
   virtual void removeMetadata(const Metadata & metadata, const CoreI::String & name) = 0;

   /**@}*/

   /**
    * \defgroup Subpart materials 
    * @{
    */
   //! Get a subpart material assignment according to overrides on the scene tree with SubpartMaterial components
   /*!
     \param occurrence The Occurrence
     \param subpartIndex The subpart index
     \return material The assigned material
   */
   virtual MaterialI::Material getSubpartMaterial(const Occurrence & occurrence, const CoreI::UInt & subpartIndex) = 0;

   //! list all the materials used in the part shape
   /*!
     \param part The part which contains sub materials
     \return materials Used materials
   */
   virtual MaterialI::MaterialList listActiveShapeMaterials(const Part & part) = 0;

   //! list all the materials used in the part shape or overrided with a SubpartMaterial component
   /*!
     \param occurrence The occurrence which contains sub materials
     \return materials Used materials
   */
   virtual MaterialI::MaterialList listSubpartMaterials(const Occurrence & occurrence) = 0;

   //! list all the materials variants in subpart 
   /*!
     \param occurrence The occurrence which contains variants
     \return variantMaterials List of variant and materials
   */
   virtual VariantMaterialList listSubpartVariantMaterials(const Occurrence & occurrence) = 0;

   //! Set a subpart material assignment using a SubpartMaterial component
   /*!
     \param occurrence The Occurrence
     \param subpartIndex The subpart index
     \param material The material
   */
   virtual void setSubpartMaterial(const Occurrence & occurrence, const CoreI::UInt & subpartIndex, const MaterialI::Material & material) = 0;

   //! Set multiple subpart materials at once using a SubpartMaterial component
   /*!
     \param occurrence The Occurrence on which to apply the materials
     \param materials Materials to set
     \param startIndex The subpart start index
   */
   virtual void setSubpartMaterials(const Occurrence & occurrence, const MaterialI::MaterialList & materials, const CoreI::UInt & startIndex = 0) = 0;

   //! set materials in variant 
   /*!
     \param occurrence The occurrence which contains variants
     \param variantMaterials List of variant and materials
   */
   virtual void setSubpartVariantMaterials(const Occurrence & occurrence, const VariantMaterialList & variantMaterials) = 0;

   //! set all the materials list in variants 
   /*!
     \param variants The part which contains variants
     \param materialListList The part which contains the list of material variant list
     \return materialsVariant List of variant and materials
   */
   virtual VariantMaterialList setSubpartVariantMaterialsList(const VariantList & variants, const MaterialI::MaterialListList & materialListList) = 0;

   //! Assign SubpartMaterialComponent materials on the occurrence's part shapes. This might affect other Part in the scene if not singularized before.
   /*!
     \param occurrence The occurrence which has sub materials assigned
   */
   virtual void transferSubpartMaterialsOnPatches(const Occurrence & occurrence) = 0;

   /**@}*/

   /**
    * \defgroup alternative trees AlternativeTree related functions
    * @{
    */
   //! Create a new alternative tree
   /*!
     \param name The name of the new alternative tree
     \param root The root occurrence
     \return tree The new alternative tree
   */
   virtual AlternativeTree createAlternativeTree(const CoreI::String & name, const Occurrence & root = Occurrence()) = 0;

   //! Returns the root occurrence associated with the given AlternativeTree
   /*!
     \param tree Targeted alternative tree
     \return root The root occurrence
   */
   virtual Occurrence getAlternativeTreeRoot(const AlternativeTree & tree) = 0;

   //! Returns all the available alternative trees
   /*!
     \return trees All alternative trees
   */
   virtual AlternativeTreeList listAlternativeTrees() = 0;

   /**@}*/

   /**
    * \defgroup animations Animations related functions
    * @{
    */
   //! Add an animation in Animation library
   /*!
     \param animation Animation to add
   */
   virtual void addAnimation(const Animation & animation) = 0;

   //! Adds a keyframe in the curve
   /*!
     \param channel The channel one wants to add a keyframe in
     \param time The time
     \param value The value
     \return keyframe The corresponding keyframe
   */
   virtual Keyframe addKeyframe(const AnimChannel & channel, const AnimationTime & time, const CoreI::Double & value) = 0;

   //! Adds keyframes in a given AnimChannel based on current position
   /*!
     \param channel The channel one wants to add a keyframe in
     \param time The time
   */
   virtual void addKeyframeFromCurrentPosition(const AnimChannel & channel, const AnimationTime & time) = 0;

   //! Does this Animation animates this Occurrence - or one of its parents (thus animating it indirectly) ?
   /*!
     \param animation The Animation
     \param occurrence The supposedly animated occurrence
     \return isAnimated The answer to this question
   */
   virtual CoreI::Bool animatesThisOccurrence(const Animation & animation, const Occurrence & occurrence) = 0;

   //! Bake an animation. The values are now precalculated and no longer interpolated.
   /*!
     \param animation The Animation
     \param occurrence The occurrence
     \param end The parent occurrence
     \param interval The interval
   */
   virtual void bakeAnimation(const Animation & animation, const Occurrence & occurrence, const Occurrence & end, const AnimationTime & interval) = 0;

   //! Creates an animation, need to use addAnimation when animation is filled
   /*!
     \param name Name of the animation
     \return animation The created animation
   */
   virtual Animation createAnimation(const CoreI::String & name) = 0;

   //! Create a skeleton mesh from a joint component tree
   /*!
     \param root Root joint component node
     \return skeletonOcc New occurrence containing the skeleton mesh
   */
   virtual Occurrence createSkeletonMesh(const Occurrence & root) = 0;

   //! Decimates by segment a given AnimChannel
   /*!
     \param channel The channel
     \param precision The precision
   */
   virtual void decimateAnimChannelBySegment(const AnimChannel & channel, const CoreI::Double & precision) = 0;

   //! Deletes an animation
   /*!
     \param animation The created animation
   */
   virtual void deleteAnimation(const Animation & animation) = 0;

   //! Delete all animation that contain 0 keyframes
   virtual void deleteEmptyAnimation() = 0;

   //! Displays info on the selected AnimChannel
   /*!
     \param channel The channel
   */
   virtual void displayAllKeyframesFromAnimChannel(const AnimChannel & channel) = 0;

   //! Displays info on the selected animation
   /*!
     \param animation The animation
   */
   virtual void displayAllKeyframesFromAnimation(const Animation & animation) = 0;

   //! Displays the value
   /*!
     \param channel The channel
     \param time The time
     \param defaultValue Show default instead ?
   */
   virtual void displayValueFromAnimChannelAtTime(const AnimChannel & channel, const AnimationTime & time, const CoreI::Bool & defaultValue = false) = 0;

   //! Returns the main AnimChannel of an Occurrence according to a given Animation
   /*!
     \param animation The Animation
     \param occurrence The Occurrence
     \return channel The channel
   */
   virtual AnimChannel getAnimChannelIfExists(const Animation & animation, const Occurrence & occurrence) = 0;

   //! get an animation channel informations
   /*!
     \param channel Animation to get info of
     \return channelInfo 
   */
   virtual AnimChannelInfo getAnimChannelInfo(const AnimChannel & channel) = 0;

   //! Returns the Occurrence related to a given AnimChannel
   /*!
     \param channel The channel
     \return occurrence The corresponding occurrence
   */
   virtual Occurrence getAnimChannelOccurrence(const AnimChannel & channel) = 0;

   //! packs all animation-related info in an object
   /*!
     \param animationComponent Animation to get info of
     \return animPropertyBinderList 
   */
   virtual AnimPropertyBinderList getAnimationComponentPropertyBinderLists(const AnimationComponent & animationComponent) = 0;

   //! packs all animation-related info in an object
   /*!
     \param animation Animation to get info of
     \return animationInfo 
   */
   virtual AnimationInfo getAnimationInfo(const Animation & animation) = 0;

   //! packs all animation-related info in an object
   /*!
     \param animation Animation to get info of
     \return animPropertyBinderList 
   */
   virtual AnimPropertyBinderList getAnimationPropertyBinderLists(const Animation & animation) = 0;

   //! Get joint definition from id
   /*!
     \param joint Id of the joint
     \return jointDefinition The jointDefinition matching the id provided
   */
   virtual JointDefinition getJointDefinition(const PolygonalI::Joint & joint) = 0;

   //! Get joint definition from id
   /*!
     \param joints Ids of joints
     \return jointDefinitions An array of all jointDefinition matching joint provided
   */
   virtual JointDefinitionList getJointDefinitions(const PolygonalI::JointList & joints) = 0;

   //! Returns the parent AnimChannel of a given Keyframe
   /*!
     \param keyframe The keyframe one wants the parent of
     \return animChannel The Parent
   */
   virtual AnimChannel getKeyframeParentAnimChannel(const Keyframe & keyframe) = 0;

   //! Returns a list of all keyframes of a simple animChannel
   /*!
     \param channel The channel one wants to extract the keyframs from
     \return keyframelist The list of keyframes
   */
   virtual KeyframeList getKeyframes(const AnimChannel & channel) = 0;

   //! Returns the main AnimChannel of a given AnimChannel
   /*!
     \param channel The channel one wants the main of
     \return mainChannel The corresponding main Channel
   */
   virtual AnimChannel getMainChannel(const AnimChannel & channel) = 0;

   //! Returns the Joint assigned to an occurrence if any
   /*!
     \param occurrence The occurrence
     \return joint The joint assigned to the given occurrence
   */
   virtual PolygonalI::Joint getOccurrenceJoint(const Occurrence & occurrence) = 0;

   //! Returns (if exists) the parent AnimChannel of a given AnimChannel
   /*!
     \param channel The channel one wants the parent of
     \return parentChannel The corresponding parent Channel
   */
   virtual AnimChannel getParentChannel(const AnimChannel & channel) = 0;

   //! Returns the subchannel of a given name from an AnimChannel
   /*!
     \param channel The channel one wants the subchannel of
     \param name The name of the subchannel
     \return subChannel The corresponding subchannel
   */
   virtual AnimChannel getSubChannel(const AnimChannel & channel, const CoreI::String & name) = 0;

   //! Returns all the sub channel of an AnimChannel
   /*!
     \param channel The channel one wants the subchannel of
     \return subChannels The list of direct sub channels
   */
   virtual AnimChannelList getSubChannels(const AnimChannel & channel) = 0;

   //! Creates a Binder in an Animation stack to animate an entity's property
   /*!
     \param animation The Animation stack where to put a animated property
     \param entity The entity object to animate
     \param propertyName The name of the property to animate
     \return mainChannel The main channel of the binder
   */
   virtual AnimChannel linkPropertyToAnimation(const Animation & animation, const CoreI::Entity & entity, const CoreI::String & propertyName) = 0;

   //! List all Animations from the scene
   /*!
     \return animList The list containing animations
   */
   virtual AnimationList listAnimations() = 0;

   //! List all main AnimChannel from a given Animation
   /*!
     \param animation The Animation one wants to list the channels from
     \return channelList The list containing the AnimChannels
   */
   virtual AnimChannelList listMainChannels(const Animation & animation) = 0;

   //! Creates keyframes with the default values of the channel at time 0
   /*!
     \param channel The channel
   */
   virtual void makeDefaultKeyframe(const AnimChannel & channel) = 0;

   //! Moving animation
   /*!
     \param animation The Animation
     \param target The target occurrence
     \param newParent The new parent occurrence
     \param interval The interval
   */
   virtual void moveAnimation(const Animation & animation, const Occurrence & target, const Occurrence & newParent, const AnimationTime & interval) = 0;

   //! Removes a keyframe in the curve
   /*!
     \param channel The channel one wants to remove a keyframe from
     \param time The time
   */
   virtual void removeKeyframe(const AnimChannel & channel, const AnimationTime & time) = 0;

   //! Unlinks a binder
   /*!
     \param animation The Animation stack where to put a animated property
     \param entity The entity object to animate
     \param propertyName The name of the property to animate
   */
   virtual void unlinkPropertyToAnimation(const Animation & animation, const CoreI::Entity & entity, const CoreI::String & propertyName) = 0;

   /*!
     \param animation Added animation
   */
   virtual CoreI::Ident addAnimationAddedCallback(void(*fp)(void *, const Animation &), void * userdata = nullptr) = 0;
   void * removeAnimationAddedCallback(CoreI::Ident id); 

   /*!
     \param animation Changed Animation
   */
   virtual CoreI::Ident addAnimationChangedCallback(void(*fp)(void *, const Animation &), void * userdata = nullptr) = 0;
   void * removeAnimationChangedCallback(CoreI::Ident id); 

   //! Ebent sent when Animation library is cleared
   virtual CoreI::Ident addAnimationClearedCallback(void(*fp)(void *), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void * removeAnimationClearedCallback(CoreI::Ident id); 

   /*!
     \param animation Removed Animation
   */
   virtual CoreI::Ident addAnimationRemovedCallback(void(*fp)(void *, const Animation &), void * userdata = nullptr) = 0;
   void * removeAnimationRemovedCallback(CoreI::Ident id); 

   /**@}*/

   /**
    * \defgroup debug Debug functions
    * @{
    */
   //! Get BRep info
   /*!
     \return partCount The part count
     \return totalPartCount The total part count
     \return vertexCount The vertex count
     \return totalVertexCount The total vertex count
     \return edgeCount The edge count
     \return totalEdgeCount The total edge count
     \return openShellCount The open shell count
     \return totalOpenShellCount The total open shell count
     \return bodyCount The body count
     \return totalBodyCount The total body count
     \return area2Dsum The 2D area sum
     \return boundaryCount The boundary count
     \return boundaryEdgeCount The boundary edge count
   */
   virtual getBRepInfosReturn getBRepInfos() = 0;

   //! Get tessellation info
   /*!
     \param root Occurrence tree root
     \return partCount The part count
     \return totalPartCount The total part count
     \return vertexCount The vertex count
     \return totalVertexCount The total vertex count
     \return edgeCount The edge count
     \return totalEdgeCount The total edge count
     \return polygonCount The polygon count
     \return totalPolygonCount The total polygon count
     \return patchCount The patch count
     \return totalPatchCount The total patch count
     \return boundaryCount The boundary count
     \return boundaryEdgeCount The boundary edge count
     \return nonManifoldEdgeCount The non manifold edge count
   */
   virtual getTessellationInfosReturn getTessellationInfos(const Occurrence & root = 0) = 0;

   //! Get tessellation parameters
   /*!
     \param part The tessellated part
     \return maxSag The MaxSag value in mm
     \return maxLength The maximum length in mm
     \return maxAngle 
     \return createNormals Whether normals were created
     \return uvGenerationMode The uv generation mode
     \return uvChannel The UV channel
     \return uvPadding The UV padding
     \return createTangents Whether tangents were created
     \return createFreeEdges Whether free edges were created
   */
   virtual getTessellationParametersReturn getTessellationParameters(const Part & part) = 0;

   //! Print an occurrence tree on log
   /*!
     \param root Occurrence tree root
   */
   virtual void print(const Occurrence & root = 0) = 0;

   /**@}*/

   /**
    * \defgroup filters Scene filtering functions
    * @{
    */
   //! Add a filter to the filters library
   /*!
     \param name Name of the filter
     \param expr The filter expression
     \return filterId Identifier of the created filter
   */
   virtual CoreI::Ident addFilterToLibrary(const CoreI::String & name, const FilterExpression & expr) = 0;

   //! Evaluate the given filter expression
   /*!
     \param filter The filter expression
     \return result Result of the given expression
   */
   virtual CoreI::String evaluateExpression(const FilterExpression & filter) = 0;

   //! evaluate the given filter expression on all occurrences under the given occurrence and returns the result
   /*!
     \param occurrences Occurrences on which to evaluate the expression
     \param filter The filter expression
     \return evaluations The evaluation of the expression on the occurrence at the same index in given occurrences
   */
   virtual CoreI::StringList evaluateExpressionOnOccurrences(const OccurrenceList & occurrences, const FilterExpression & filter) = 0;

   //! evaluate the given filter expression on all occurrences under the given occurrence and returns the result
   /*!
     \param filter The filter expression
     \param fromOcc Source occurrence of the recursion
     \return occurrences 
     \return evaluations The evaluation of the expression on the occurrence at the same index in occurrences
   */
   virtual evaluateExpressionOnSubTreeReturn evaluateExpressionOnSubTree(const FilterExpression & filter, const Occurrence & fromOcc = Occurrence()) = 0;

   //! Export filters from a given file
   /*!
     \param file File path to export
   */
   virtual void exportFilterLibrary(const CoreI::FilePath & file) = 0;

   //! Returns the first filter in the filter library with the given name
   /*!
     \param name Name of the filter to retrieve (case sensitive)
     \return filter The retrieved filter
   */
   virtual Filter findFilterByName(const CoreI::String & name) = 0;

   //! Returns the filter expression (string) from a filter id stored in the library
   /*!
     \param filterId Identifier of the filter to fetch
     \return expr Filter expression
   */
   virtual FilterExpression getFilterExpression(const CoreI::Ident & filterId) = 0;

   //! Retrieve a filter from the library with its identifier
   /*!
     \param filterId Identifier of the filter to retrieve
     \return filter The retrieved filter
   */
   virtual Filter getFilterFromLibrary(const CoreI::Ident & filterId) = 0;

   //! Recursively get all the occurrences validating the given filter expression
   /*!
     \param filter The filter expression
     \param fromOcc Source occurrence of the recursion
     \return occurrences Result occurrences
   */
   virtual OccurrenceList getFilteredOccurrences(const FilterExpression & filter, const Occurrence & fromOcc = Occurrence()) = 0;

   //! Import filters from a given file
   /*!
     \param file File containing the filter library
   */
   virtual void importFilterLibrary(const CoreI::FilePath & file) = 0;

   //! Returns all the filter stored in the filter library
   /*!
     \return filters All the filters stored in the filter library
   */
   virtual FilterList listFilterLibrary() = 0;

   //! Remove a filter from the filters library
   /*!
     \param filterId Identifier of the filter to remove
   */
   virtual void removeFilterFromLibrary(const CoreI::Ident & filterId) = 0;

   /**@}*/

   /**
    * \defgroup isolate Isolate functions
    * @{
    */
   //! Enter isolate mode by isolating a subset of the scene for process, export, viewer, ...
   /*!
     \param occurrences Occurrences to isolate
   */
   virtual void isolate(const OccurrenceList & occurrences) = 0;

   //! Exit the isolate mode
   virtual void unisolate() = 0;

   /**@}*/

   /**
    * \defgroup merging Part merging related functions
    * @{
    */
   //! Find Part occurrences containing multiple unstitched openShell entities
   /*!
     \param root Root occurrence
     \return unstitchedFacesOccurrences Unstitched faces occurrences
   */
   virtual OccurrenceList findPartOccurrencesWithUnstitchedOpenShells(const Occurrence & root) = 0;

   //! Merge all parts over maxLevel level
   /*!
     \param roots Roots occurrences for the process
     \param maxLevel Maximum tree level
     \param mergeHiddenPartsMode Hidden parts handling mode, Destroy them, make visible or merge separately
   */
   virtual void mergeOccurrencesByTreeLevel(const OccurrenceList & roots, const CoreI::Int & maxLevel, const MergeHiddenPartsMode & mergeHiddenPartsMode = MergeHiddenPartsMode::MergeSeparately) = 0;

   //! Merge a set of parts
   /*!
     \param partOccurrences Occurrence of the parts to merge
     \param mergeHiddenPartsMode Hidden parts handling mode, Destroy them, make visible or merge separately
     \return mergedOccurrences Resulting merged occurrences
   */
   virtual OccurrenceList mergePartOccurrences(const OccurrenceList & partOccurrences, const MergeHiddenPartsMode & mergeHiddenPartsMode = MergeHiddenPartsMode::MergeSeparately) = 0;

   //! Merge all parts under each assembly together
   /*!
     \param roots Roots occurrences for the process (will not be removed)
     \param mergeHiddenPartsMode Hidden parts handling mode, Destroy them, make visible or merge separately
   */
   virtual void mergePartOccurrencesByAssemblies(const OccurrenceList & roots = OccurrenceList(0), const MergeHiddenPartsMode & mergeHiddenPartsMode = MergeHiddenPartsMode::MergeSeparately) = 0;

   //! Merge final level (occurrences with only occurrence with part component as children)
   /*!
     \param roots Roots occurrences for the process (will not be removed)
     \param mergeHiddenPartsMode Hidden parts handling mode, Destroy them, make visible or merge separately
     \param CollapseToParent If true, final level unique merged part will replace it's parent
   */
   virtual void mergePartOccurrencesByFinalAssemblies(const OccurrenceList & roots = OccurrenceList(0), const MergeHiddenPartsMode & mergeHiddenPartsMode = MergeHiddenPartsMode::Destroy, const CoreI::Boolean & CollapseToParent = true) = 0;

   //! Merge a set of parts by materials
   /*!
     \param partOccurrences Occurrence of the parts to merge
     \param mergeNoMaterials If true, merge all parts with no active material together, else do not merge them
     \param mergeHiddenPartsMode Hidden parts handling mode, Destroy them, make visible or merge separately
     \param combineMeshes If true, explode and remerge the input parts by visible materials
     \return mergedOccurrences Resulting merged occurrences
   */
   virtual OccurrenceList mergePartOccurrencesByMaterials(const OccurrenceList & partOccurrences, const CoreI::Boolean & mergeNoMaterials = true, const MergeHiddenPartsMode & mergeHiddenPartsMode = MergeHiddenPartsMode::MergeSeparately, const CoreI::Boolean & combineMeshes = true) = 0;

   //! Merge all parts by occurrences names
   /*!
     \param root Root occurrence of the subtree to process
     \param mergeHiddenPartsMode Hidden parts handling mode, Destroy them, make visible or merge separately
   */
   virtual void mergePartOccurrencesByName(const Occurrence & root = 0, const MergeHiddenPartsMode & mergeHiddenPartsMode = MergeHiddenPartsMode::MergeSeparately) = 0;

   //! Merge all parts within the same area.
   /*!
     \param roots Roots occurrences for the process (will not be removed)
     \param mergeBy Number: number of output parts (or regions of parts)\nSize: diagonal size of output regions
     \param strategy Choose the regions merging strategy
     \return mergedOccurrences Resulting merged occurrences
   */
   virtual OccurrenceList mergePartOccurrencesByRegions(const OccurrenceList & roots, const MergeByRegionsStrategy & mergeBy, const MergeStrategy & strategy) = 0;

   //! Merge Part occurrences containing a single openShell entity, by assemblies
   /*!
     \param root Root of the main assembly to merge
     \return mergedOccurrences List of the merged occurrence that contained only openShell
   */
   virtual OccurrenceList mergePartOccurrencesWithSingleOpenShellByAssemblies(const Occurrence & root) = 0;

   /**@}*/

   /**
    * \defgroup modification 
    * @{
    */
   //! apply a transformation to the local matrix of an occurrence
   /*!
     \param occurrence Occurrence to apply the matrix on
     \param matrix Transformation to matrix
   */
   virtual void applyTransformation(const Occurrence & occurrence, const GeomI::Matrix4 & matrix) = 0;

   //! Create symmetries from selection
   /*!
     \param occurrences Selection of occurrences
     \param plane Symmetry plane
   */
   virtual void createSymmetry(const OccurrenceList & occurrences, const GeomI::AxisPlane & plane) = 0;

   //! Modify the local matrix of the scene node to apply a rotation
   /*!
     \param occurrence Occurrence to rotate
     \param axis Axis of rotation
     \param angle Angle of rotation
   */
   virtual void rotate(const Occurrence & occurrence, const GeomI::Vector3 & axis, const GeomI::Angle & angle) = 0;

   //! change the local matrices on a list of occurrences
   /*!
     \param occurrencesIds List of occurrences on which to set the local matrices
     \param matrices The occurrences' new local matrices
     \param batchSize Number of matrices to be set per thread.
   */
   virtual void setLocalMatrices(const OccurrenceList & occurrencesIds, const GeomI::Matrix4List & matrices, const CoreI::UInt & batchSize) = 0;

   //! change the local matrix on an occurrence
   /*!
     \param occurrence Occurrence to set the local matrix
     \param matrix The new occurrence local matrix
   */
   virtual void setLocalMatrix(const Occurrence & occurrence, const GeomI::Matrix4 & matrix) = 0;

   /**@}*/

   /**
    * \defgroup part Part component functions
    * @{
    */
   //! Return the mesh of the TesselatedShape
   /*!
     \param part The part component
     \return mesh The mesh of the tessellated shape of the part
   */
   virtual PolygonalI::Mesh getPartMesh(const Part & part) = 0;

   //! Return the model of the BRepShape
   /*!
     \param part The part component
     \return model The model of the BRep shape of the part
   */
   virtual CADI::Model getPartModel(const Part & part) = 0;

   //! Return the meshes of the TesselatedShape for each given parts if any
   /*!
     \param parts The list of part component
     \return meshes The list of mesh of the tessellated shape of each part
   */
   virtual PolygonalI::MeshList getPartsMeshes(const PartList & parts) = 0;

   //! Return the models of the BRepShape for each given parts if any
   /*!
     \param parts The list of part component
     \return models The list of models of the BRep shape of each part
   */
   virtual CADI::ModelList getPartsModels(const PartList & parts) = 0;

   //! Returns the transform matrix of each given parts
   /*!
     \param parts The parts to retrieve transform
     \return transforms The transform matrix of each part
   */
   virtual GeomI::Matrix4List getPartsTransforms(const PartList & parts) = 0;

   //! Returns the transform matrix of each given parts (indexed mode)
   /*!
     \param parts The parts to retrieve transform
     \return indices The transform matrix index for each parts (0 for Identity)
     \return transforms The list of transform matrices (the first is always Identity)
   */
   virtual getPartsTransformsIndexedReturn getPartsTransformsIndexed(const PartList & parts) = 0;

   //! Add a mesh to a part (create a TessellatedShape on the part)
   /*!
     \param part The part component
     \param mesh The mesh to add to the part
   */
   virtual void setPartMesh(const Part & part, const PolygonalI::Mesh & mesh) = 0;

   //! Add a model to a part (create a BRepShape on the part)
   /*!
     \param part The part component
     \param model The model to add to the part
   */
   virtual void setPartModel(const Part & part, const CADI::Model & model) = 0;

   //! Set the transform matrix of each given parts
   /*!
     \param parts The parts to retrieve transform
     \param transforms The transform matrix of each part
   */
   virtual void setPartsTransforms(const PartList & parts, const GeomI::Matrix4List & transforms) = 0;

   //! Set the transform matrix of each given parts (indexed mode)
   /*!
     \param parts The parts to retrieve transform
     \param indices The transform matrix index for each parts
     \param transforms The list of transform matrices
   */
   virtual void setPartsTransformsIndexed(const PartList & parts, const CoreI::IntList & indices, const GeomI::Matrix4List & transforms) = 0;

   /**@}*/

   /**
    * \defgroup partialLoading 
    * @{
    */
   //! Get the current status of a partial loading component
   /*!
     \param component Referenced Data component
     \return status The current status
   */
   virtual PartialLoad_Status getPartialLoadingStatus(const ReferencedDataComponent & component) = 0;

   //! Defines which referenced data is parent to the given component
   /*!
     \param component The referenced data component to alter
     \param parent The parent
   */
   virtual void setReferencedDataComponentParent(const ReferencedDataComponent & component, const ReferencedDataComponent & parent) = 0;

   //! Defines which path the referenced data is at
   /*!
     \param component The referenced data component to alter
     \param filePath The filepath
   */
   virtual void setReferencedDataComponentPath(const ReferencedDataComponent & component, const CoreI::String & filePath) = 0;

   /**@}*/

   /**
    * \defgroup pivots Pivot moving functions
    * @{
    */
   //! Re-orient the Pivot Point straight to world origin (the grid)
   /*!
     \param occurrences The occurrences to modify
     \param applyToChildren If True, all the pivot of the descending occurrences from occurrence will be affected
   */
   virtual void alignPivotPointToWorld(const OccurrenceList & occurrences, const CoreI::Bool & applyToChildren) = 0;

   //! Move the pivot point of each occurrence listed in the function input, to the center of its bounding box (and of its children if the parameter is True)
   /*!
     \param occurrences Occurrences (or the roots occurrences if recursively=True)
     \param applyToChildren If True, all the pivot of the descending occurrences from occurrence will be affected
   */
   virtual void movePivotPointToOccurrenceCenter(const OccurrenceList & occurrences, const CoreI::Bool & applyToChildren) = 0;

   //! Move the pivot point of an occurrence (and its descendants if recursively) to the origin (0,0,0)
   /*!
     \param occurrence The occurrence (or the root occurrence if recursively=True)
     \param applyToChildren If True, all the pivot of the descending occurrences from occurrence will be affected
   */
   virtual void movePivotPointToOrigin(const Occurrence & occurrence, const CoreI::Bool & applyToChildren) = 0;

   //! Move the pivot point of all given occurrences to the center of all occurrences
   /*!
     \param occurrences The occurrences to modify
   */
   virtual void movePivotPointToSelectionCenter(const OccurrenceList & occurrences) = 0;

   //! Move the pivot point of each occurrence listed in the function input, to the center of the targeted occurrence Center (and of its children if the parameter is True)
   /*!
     \param occurrences The occurrence (or the root occurrence if recursively=True)
     \param target The target occurrence
     \param applyToChildren If True, all the pivot of the descending occurrences from occurrence will be affected
   */
   virtual void movePivotPointToTargetedOccurrenceCenter(const OccurrenceList & occurrences, const Occurrence & target, const CoreI::Bool & applyToChildren) = 0;

   //! Set the pivot of an occurrence to the given transformation matrix, the geometry will not be moved (warning: do not confuse with property Transform which actually move the occurrence)
   /*!
     \param occurrence The occurrence to move the pivot
     \param pivot The new transformation matrix for the occurrence (pivot)
   */
   virtual void setPivotOnly(const Occurrence & occurrence, const GeomI::Matrix4 & pivot) = 0;

   /**@}*/

   /**
    * \defgroup pmi 
    * @{
    */
   //! add a Annotation Group to the pmi component
   /*!
     \param component Component to add the Annotation Group
     \param name Name of the annotation group
     \return group Annotation group created
   */
   virtual AnnotationGroup addAnnotationGroup(const PMIComponent & component, const CoreI::String & name) = 0;

   //! add a mesh and its material to a annotation
   /*!
     \param annotation 
     \param material 
     \param staticmesh 
   */
   virtual void addMeshToAnnotation(const Annotation & annotation, const MaterialI::Material & material, const PolygonalI::StaticMesh & staticmesh) = 0;

   //! Convert each PMI component into a set of occurrences with mesh geometries
   /*!
     \param occurrences Occurrence selection
     \param convertVisibility If True, the visibility will be converted (useful to select a specific view/variant), else all occurrences will be visible
   */
   virtual void convertPMIToOccurrences(const OccurrenceList & occurrences, const CoreI::Boolean & convertVisibility = false) = 0;

   //! Create Annotation from definition
   /*!
     \param definition Annotation definition
     \return metadata Annotation created from definition
   */
   virtual Annotation createAnnotationFromDefinition(const AnnotationDefinition & definition) = 0;

   //! Convert a single annotation on an occurrence into an occurrence with mesh geometry
   /*!
     \param annotation Annotation that shall be converted to an occurrence with mesh geometry
     \param convertVisibility If True, the visibility will be converted (useful to select a specific view/variant), else all occurrences will be visible
     \return newOccurrence Annotation as occurrence with mesh geometry
   */
   virtual Occurrence createOccurrenceFromAnnotation(const Annotation & annotation, const CoreI::Boolean & convertVisibility = false) = 0;

   //! Create a productview from definition
   /*!
     \param definition 
     \return view The product view
   */
   virtual ProductView createProductView(const ProductViewDefinition & definition) = 0;

   //! get definition of given annotation
   /*!
     \param annotation 
     \return definition 
   */
   virtual AnnotationDefinition getAnnotationDefinition(const Annotation & annotation) = 0;

   //! Returns the list of the AnnotationGroup from a PMIComponent
   /*!
     \param pmiComponent The pmi component
     \return groups List of AnnotationGroup
   */
   virtual AnnotationGroupList getAnnotationGroups(const Component & pmiComponent) = 0;

   //! get the AABB of the annotation list
   /*!
     \param annotationList 
     \return aabb The axis aligned bounding box of the given annotation list
   */
   virtual GeomI::AABB getAnnotationListAABB(const AnnotationList & annotationList) = 0;

   //! Returns the list of the Annotation from a AnnotationGroup
   /*!
     \param group The AnnotationGroup
     \return annotations List of Annotation
   */
   virtual AnnotationList getAnnotations(const AnnotationGroup & group) = 0;

   //! get all annotations definition of given occurrence
   /*!
     \param occurrence 
     \return definitions 
   */
   virtual AnnotationDefinitionList getOccurrenceAnnotationDefinitions(const Occurrence & occurrence) = 0;

   //! get productview definition
   /*!
     \param view The product view
     \return definition 
   */
   virtual ProductViewDefinition getProductViewDefinition(const Variant & view) = 0;

   //! get all productviews definitions
   /*!
     \return definitions 
   */
   virtual ProductViewDefinitionList getProductViewDefinitions() = 0;

   //! set Annotation to a Annotation Group
   /*!
     \param annotation 
     \param group 
   */
   virtual void setAnnotationToGroup(const Annotation & annotation, const AnnotationGroup & group) = 0;

   /**@}*/

   /**
    * \defgroup prototype Prototyping related functions
    * @{
    */
   //! Clean prototypes and instances (lonely instances, overriding their prototypes hierarchies...).
   /*!
     \param removeUselessInstances Remove instances where they are not needed (prototype referenced once, ...)
     \param removeHierarchyOverridingInstances Remove instances overriding their prototypes sub-hierarchies.
     \param occurrence Root occurrence for the process
   */
   virtual void cleanInstances(const CoreI::Boolean & removeUselessInstances, const CoreI::Boolean & removeHierarchyOverridingInstances, const Occurrence & occurrence = 0) = 0;

   //! Returns all the occurrences prototyping the given occurrence
   /*!
     \param prototype The prototype occurrence
     \return instances The instances
   */
   virtual OccurrenceList getDirectInstances(const Occurrence & prototype) = 0;

   //! Get occurrences sharing the same prototype as the given one
   /*!
     \param occurrence Reference part occurrence
     \return instances The list of occurrences sharing the same prototype
   */
   virtual OccurrenceList getInstances(const Occurrence & occurrence) = 0;

   //! Returns the prototype of an occurrence
   /*!
     \param occurrence The occurrence
     \return prototype The prototype (if any)
   */
   virtual Occurrence getPrototype(const Occurrence & occurrence) = 0;

   //! Returns the prototype for each given occurrence
   /*!
     \param occurrences The occurrence
     \return prototypes The prototype of each occurrence
   */
   virtual OccurrenceList getPrototypes(const OccurrenceList & occurrences) = 0;

   //! Create occurrences that prototype the given occurrence and all its subtree
   /*!
     \param prototype The root occurrence of the sub-tree to prototype
     \return occurrence The root occurrence of the prototyped sub-tree
   */
   virtual Occurrence prototypeSubTree(const Occurrence & prototype) = 0;

   //! Sets the prototype of an occurrence
   /*!
     \param occurrence The occurrence
     \param prototype The prototype
   */
   virtual void setPrototype(const Occurrence & occurrence, const Occurrence & prototype) = 0;

   //! Sets the prototype for each given occurrence
   /*!
     \param occurrences The occurrences
     \param prototypes The prototypes
   */
   virtual void setPrototypes(const OccurrenceList & occurrences, const OccurrenceList & prototypes) = 0;

   //! Update children prototypes of the given occurrence
   /*!
     \param occurrence The occurrence
   */
   virtual void updateChildrenPrototypes(const Occurrence & occurrence) = 0;

   /**@}*/

   /**
    * \defgroup selection Selection related functions
    * @{
    */
   //! Clear the current selection
   virtual void clearSelection() = 0;

   //! Delete all selected occurrences, and/or sub-occurrence elements
   virtual void deleteSelection() = 0;

   //! For each occurrence, create a new occurrence with the selected sub-occurrence elements and remove them from the original occurrence
   virtual void explodeSelection() = 0;

   //! Returns all the selected occurrences
   /*!
     \param keepAncestors If True, occurrences with ancestors selected will be remove from the list
     \return selection The list of selected occurrences
   */
   virtual OccurrenceList getSelectedOccurrences(const CoreI::Boolean & keepAncestors = false) = 0;

   //! Returns the number of selected polygons
   /*!
     \return polygonCount Number of selected Polygons
   */
   virtual CoreI::ULong getSelectedPolygonCount() = 0;

   //! Invert the orientation of each selected item (occurrences and/or sub-occurrence elements
   virtual void invertOrientationSelection() = 0;

   //! Invert occurrences to selection
   /*!
     \param occurrence Occurrences to invert from the selection
   */
   virtual void invertSelect(const OccurrenceList & occurrence) = 0;

   //! Replace the selection by all unselected part occurrences
   virtual void invertSelection() = 0;

   //! Add occurrences to selection
   /*!
     \param occurrences Occurrences to add to the selection
   */
   virtual void select(const OccurrenceList & occurrences) = 0;

   //! Separate all polygons form their original parts into a new one
   /*!
     \return newOccurrence The new occurrence created
   */
   virtual Occurrence separateSelection() = 0;

   //! Remove occurrences to selection
   /*!
     \param occurrence Occurrences to remove from the selection
   */
   virtual void unselect(const OccurrenceList & occurrence) = 0;

   /*!
     \param type Type of change (CLEARED, ADDED or REMOVED)
     \param occurrences Only if type is ADDED or REMOVED, list of added or removed occurrences
   */
   virtual CoreI::Ident addSelectionChangedCallback(void(*fp)(void *, const SelectionChangeType &, const OccurrenceList &), void * userdata = nullptr) = 0;
   void * removeSelectionChangedCallback(CoreI::Ident id); 

   /*!
     \param type Type of change (ADDED, REMOVED, CURRENT_CHANGED)
     \param variant 
   */
   virtual CoreI::Ident addVariantChangedCallback(void(*fp)(void *, const VariantChangeType &, const Variant &), void * userdata = nullptr) = 0;
   void * removeVariantChangedCallback(CoreI::Ident id); 

   /**@}*/

   /**
    * \defgroup simplification Scene structure simplification functions
    * @{
    */
   //! Compress a sub-tree by removing occurrence containing only one Child or empty, and by removing useless instances (see removeUselessInstances)
   /*!
     \param occurrence Root occurrence for the process
     \return resultingOccurrences The resulting occurrences of compression
   */
   virtual Occurrence compress(const Occurrence & occurrence = 0) = 0;

   //! Modify the visible properties of the sub-tree to look like old school visibility (only hidden/inherited)
   /*!
     \param root Root occurrence
   */
   virtual void convertToOldSchoolVisibility(const Occurrence & root = 0) = 0;

   //! Get hidden part occurrences
   /*!
     \param roots Roots occurrences for the process
     \return filtered The list of hidden occurrences (visibility status)
   */
   virtual OccurrenceList getHiddenPartOccurrences(const OccurrenceList & roots = OccurrenceList(0)) = 0;

   //! Get visible part occurrences
   /*!
     \param roots Roots occurrences for the process
     \return filtered The list of visible part occurrences (visibility status)
   */
   virtual OccurrenceList getVisiblePartOccurrences(const OccurrenceList & roots = OccurrenceList(0)) = 0;

   //! Singularize all instances on the sub-tree of an occurrence
   /*!
     \param occurrences Root occurrence for the process
     \param keepOnlyPartInstances If true, instances of part will not be singularized
   */
   virtual void makeInstanceUnique(const OccurrenceList & occurrences = OccurrenceList(0), const CoreI::Boolean & keepOnlyPartInstances = false) = 0;

   //! Set the same parent to all descending parts (all parts will be singularized)
   /*!
     \param occurrence Root occurrence for the process
     \param keepInstances If false, the part will be singularized
   */
   virtual void rake(const Occurrence & occurrence = 0, const CoreI::Boolean & keepInstances = false) = 0;

   //! Remove symmetry matrices (apply matrices on geometries on nodes under an occurrence with a symmetry matrix
   /*!
     \param occurrence Root occurrence for the process
   */
   virtual void removeSymmetryMatrices(const Occurrence & occurrence = 0) = 0;

   //! Set all part transformation matrices to identity in a sub-tree, transformation will be applied to the shapes
   /*!
     \param root Root occurrence for the process
   */
   virtual void resetPartTransform(const Occurrence & root = 0) = 0;

   //! Set all transformation matrices to identity in a sub-tree.
   /*!
     \param root Root occurrence for the process
     \param recursive If False, transformation will be applied only on the root and its components
     \param keepInstantiation If False, all occurrences will be singularized
     \param keepPartTransform If False, transformation will be applied to the shapes (BRepShape points or TessellatedShape vertices)
   */
   virtual void resetTransform(const Occurrence & root, const CoreI::Boolean & recursive = true, const CoreI::Boolean & keepInstantiation = true, const CoreI::Boolean & keepPartTransform = false) = 0;

   /**@}*/

   /**
    * \defgroup spatialRequest 
    * @{
    */
   //! Creates a ray prober
   /*!
     \return id 
   */
   virtual CoreI::Ident createRayProber() = 0;

   //! Creates a sphere prober
   /*!
     \return id 
   */
   virtual CoreI::Ident createSphereProber() = 0;

   /*!
     \param ray The ray to cast
     \param root The root occurrence to cast from
     \return hit Information of the first ray hit
   */
   virtual RayHit rayCast(const GeomI::Ray & ray, const Occurrence & root) = 0;

   /*!
     \param ray The ray to cast
     \param root The root occurrence to cast from
     \return hits Information of the first ray hit
   */
   virtual RayHitList rayCastAll(const GeomI::Ray & ray, const Occurrence & root) = 0;

   //! Updates the designed ray prober
   /*!
     \param proberID The ray prober Id
     \param ray Update the prober's ray values
   */
   virtual void updateRayProber(const CoreI::Ident & proberID, const GeomI::Ray & ray) = 0;

   //! Updates the designed sphere prober
   /*!
     \param proberID The sphere prober Id
     \param sphereCenter The new prober center
     \param sphereRadius The new prober radius
   */
   virtual void updateSphereProber(const CoreI::Ident & proberID, const GeomI::Vector3 & sphereCenter, const CoreI::Double & sphereRadius) = 0;

   /*!
     \param proberID The ray propber ID
     \param proberInfo The prober's info
   */
   virtual CoreI::Ident addonRayProbeCallback(void(*fp)(void *, const CoreI::Ident &, const ProberInfo &), void * userdata = nullptr) = 0;
   void * removeonRayProbeCallback(CoreI::Ident id); 

   /*!
     \param proberID The sphere propber ID
     \param proberInfo The prober's info
   */
   virtual CoreI::Ident addonSphereProbeCallback(void(*fp)(void *, const CoreI::Ident &, const ProberInfo &), void * userdata = nullptr) = 0;
   void * removeonSphereProbeCallback(CoreI::Ident id); 

   /**@}*/

   /**
    * \defgroup userData 
    * @{
    */
   //! Batch version of getOccurrenceUserData
   /*!
     \param userDataId UserData identifier provided by subscribeToOccurrenceUserData
     \param occurrences Occurrences that store the user data
     \return userDataList User data stored for each given occurrence
   */
   virtual CoreI::PtrList getMultipleOccurrenceUserData(const OccurrenceUserData & userDataId, const OccurrenceList & occurrences) = 0;

   //! Set or replace a userdata stored on an occurrence
   /*!
     \param userDataId UserData identifier provided by subscribeToOccurrenceUserData
     \param occurrence Occurrence that store the user data
     \return userData User data stored in the given occurrence
   */
   virtual CoreI::Ptr getOccurrenceUserData(const OccurrenceUserData & userDataId, const Occurrence & occurrence) = 0;

   //! Batch version of hasOccurrenceUserData
   /*!
     \param userDataId UserData identifier provided by subscribeToOccurrenceUserData
     \param occurrences Occurrences that potentially store the user data
     \return results Returns an array of bool that are true if a userdata is stored on the occurrence at the same index for the given userDataId
   */
   virtual CoreI::BoolList hasMultipleOccurrenceUserData(const OccurrenceUserData & userDataId, const OccurrenceList & occurrences) = 0;

   //! Set or replace a userdata stored on an occurrence
   /*!
     \param userDataId UserData identifier provided by subscribeToOccurrenceUserData
     \param occurrence Occurrence that potentially store the user data
     \return result Returns true if a userdata is stored on this occurrence for the given userDataId
   */
   virtual CoreI::Bool hasOccurrenceUserData(const OccurrenceUserData & userDataId, const Occurrence & occurrence) = 0;

   //! Batch version of setOccurrenceUserData
   /*!
     \param userDataId UserData identifier provided by subscribeToOccurrenceUserData
     \param occurrences Occurrences that will store the user data
     \param userDataList User data to store on each occurrence
   */
   virtual void setMultipleOccurrenceUserData(const OccurrenceUserData & userDataId, const OccurrenceList & occurrences, const CoreI::PtrList & userDataList) = 0;

   //! Set or replace a userdata stored on an occurrence
   /*!
     \param userDataId UserData identifier provided by subscribeToOccurrenceUserData
     \param occurrence Occurrence that will store the user data
     \param userData User data to store in the given occurrence
   */
   virtual void setOccurrenceUserData(const OccurrenceUserData & userDataId, const Occurrence & occurrence, const CoreI::Ptr & userData) = 0;

   //! subscribe to occurrence user data. multiple different userdata can be stored on the same occurrences if subscribeToOccurrenceUserData is called multiple times
   /*!
     \return userDataId UserData identifier to pass to setUserData/getUserData functions
   */
   virtual OccurrenceUserData subscribeToOccurrenceUserData() = 0;

   //! Batch version of unsetOccurrenceUserData
   /*!
     \param userDataId UserData identifier provided by subscribeToOccurrenceUserData
     \param occurrences Occurrences that will store the user data
   */
   virtual void unsetMultipleOccurrenceUserData(const OccurrenceUserData & userDataId, const OccurrenceList & occurrences) = 0;

   //! Unset the userdata stored on an occurrence
   /*!
     \param userDataId UserData identifier provided by subscribeToOccurrenceUserData
     \param occurrence Occurrence that will store the user data
   */
   virtual void unsetOccurrenceUserData(const OccurrenceUserData & userDataId, const Occurrence & occurrence) = 0;

   /*!
     \param userDataId UserData identifier to unsubscribe
   */
   virtual void unsubscribeFromOccurrenceUserData(const OccurrenceUserData & userDataId) = 0;

   /**@}*/

   /**
    * \defgroup variant variant related functions
    * @{
    */
   //! Create a new variant
   /*!
     \param name The name of the new variant
     \return variant The new variant
   */
   virtual Variant addVariant(const CoreI::String & name) = 0;

   //! Create a new variant which is a copy of an existing variant
   /*!
     \param variant The variant to duplicated
     \param name Name of the new variant
     \return newVariant The created variant
   */
   virtual Variant duplicateVariant(const Variant & variant, const CoreI::String & name) = 0;

   //! Call this function to disable the modifications of all variants at the same time.
   virtual void endModifyAllVariants() = 0;

   //! Returns the definitions of multiple variant components
   /*!
     \param variantComponents The list of variant components to retrieve definitions
     \return definitions For each variant component, returns one list of variant definition (one by variant)
   */
   virtual VariantDefinitionListList getVariantComponentsDefinitions(const VariantComponentList & variantComponents) = 0;

   //! Get the alternative tree used by this variant
   /*!
     \param variant The variant
     \return tree The alternative tree used by this variant
   */
   virtual AlternativeTree getVariantTree(const Variant & variant) = 0;

   //! Returns all the available variants
   /*!
     \return variants All variants
   */
   virtual VariantList listVariants() = 0;

   //! Remove a variant
   /*!
     \param variant The variant to remove
   */
   virtual void removeVariant(const Variant & variant) = 0;

   //! Change the current variant used
   /*!
     \param variant The variant to enable (can be null)
   */
   virtual void setCurrentVariant(const Variant & variant = Variant()) = 0;

   //! Set the alternative tree to use for this variant
   /*!
     \param variant The variant to modify
     \param tree The alternative tree to use for this variant
   */
   virtual void setVariantTree(const Variant & variant, const AlternativeTree & tree) = 0;

   //! Call this function to to enable the modifications of all variants at the same time.
   virtual void startModifyAllVariants() = 0;

   /**@}*/

};

PXZ_MODULE_END



#endif
