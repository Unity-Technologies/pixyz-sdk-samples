// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_MATERIAL_INTERFACE_MATERIALINTERFACE_C_H_
#define _PXZ_MATERIAL_INTERFACE_MATERIALINTERFACE_C_H_

#include "MaterialTypes_c.h"

PXZ_EXPORTED char * Material_getLastError();

// Add a shader uniform parameter to the given custom pattern
PXZ_EXPORTED void Material_addUniformProperty(Session * pxzSession, Material_CustomMaterialPattern pattern, Core_String name, Material_ShaderUniformType type);
// Remove and delete all the materials
PXZ_EXPORTED void Material_clearAllMaterials(Session * pxzSession);
PXZ_EXPORTED void Material_configureFunctionLogger(Session * pxzSession, Core_String functionName, Core_Boolean enableFunction, Core_Boolean enableParameters, Core_Boolean enableExecutionTime);
// Returns a new image from the given converter from 32bits float to a 8Bits (e.g. depth render map)
PXZ_EXPORTED Material_Image Material_convertFloat32To8BitsImage(Session * pxzSession, Material_Image image32F, Core_Double minValue, Core_Double maxValue);
// Convert a height map to a normal map
PXZ_EXPORTED Material_Image Material_convertHeightMapToNormalMap(Session * pxzSession, Material_Image hmap, Core_Double height);
// copies a material
PXZ_EXPORTED Material_Material Material_copyMaterial(Session * pxzSession, Material_Material toCopy, Core_Boolean addToMaterialLibrary);
// Create a new custom material pattern
PXZ_EXPORTED Material_CustomMaterialPattern Material_createCustomMaterialPattern(Session * pxzSession, Core_String name);
// Import an image from its raw data
PXZ_EXPORTED Material_Image Material_createImageFromDefinition(Session * pxzSession, Material_ImageDefinition imageDefinition);
// Import images from their raw data
PXZ_EXPORTED Material_ImageList Material_createImagesFromDefinitions(Session * pxzSession, Material_ImageDefinitionList imageDefinitions);
// Create a new material from pattern
PXZ_EXPORTED Material_Material Material_createMaterial(Session * pxzSession, Core_String name, Core_String pattern, Core_Boolean addToMaterialLibrary);
// Create PBR material from a material definition
PXZ_EXPORTED Material_Material Material_createMaterialFromDefinition(Session * pxzSession, Material_MaterialDefinition materialDefinition);
// Create PBR materials from material definitions
PXZ_EXPORTED Material_MaterialList Material_createMaterialsFromDefinitions(Session * pxzSession, Material_MaterialDefinitionList materialDefinitions);
// Automatically creates PBR materials when importing PBR texture maps from a folder
PXZ_EXPORTED void Material_createMaterialsFromMaps(Session * pxzSession, Core_DirectoryPath directory);
// Export an image
PXZ_EXPORTED void Material_exportImage(Session * pxzSession, Material_Image image, Core_OutputFilePath filename);
// Fill unused pixels by propagating and averaging used pixels
PXZ_EXPORTED Material_Image Material_fillUnusedPixels(Session * pxzSession, Material_Image image, Core_ColorAlpha unusedColor);
// Filter an AO map using ATrous method
PXZ_EXPORTED Material_Image Material_filterAO(Session * pxzSession, Material_Image aoMap, Material_Image normalMap, Core_Double sigmaPos, Core_Double sigmaValue, Core_Double sigmaNormal, Core_Int levelCount, Core_Boolean filterLowValues, Core_Double lowValueThreshold);
// Returns the material pattern which has the given name
PXZ_EXPORTED Material_CustomMaterialPattern Material_findCustomMaterialPatternByName(Session * pxzSession, Core_String name);
// Returns all materials using the given pattern
PXZ_EXPORTED Material_MaterialList Material_findMaterialsByPattern(Session * pxzSession, Core_String pattern);
// Returns all materials which match a given property value
PXZ_EXPORTED Material_MaterialList Material_findMaterialsByProperty(Session * pxzSession, Core_String propertyName, Core_Regex propertyValue, Core_Bool caseInsensitive);
// Returns all the images loaded in the current session or from a list of materials
PXZ_EXPORTED Material_ImageList Material_getAllImages(Session * pxzSession, Material_MaterialList materials);
// Returns all the material patterns in the current session
PXZ_EXPORTED Core_StringList Material_getAllMaterialPatterns(Session * pxzSession);
// Retrieve the list of all the materials in the material library
PXZ_EXPORTED Material_MaterialList Material_getAllMaterials(Session * pxzSession);
// Get color material properties
PXZ_EXPORTED Material_ColorMaterialInfos Material_getColorMaterialInfos(Session * pxzSession, Material_Material material);
// Returns the custom material pattern associated to the custom material
PXZ_EXPORTED Material_CustomMaterialPattern Material_getCustomMaterialPattern(Session * pxzSession, Material_Material material);
// Returns the raw data of an image
PXZ_EXPORTED Material_ImageDefinition Material_getImageDefinition(Session * pxzSession, Material_Image image);
// Returns the raw data of a set of images
PXZ_EXPORTED Material_ImageDefinitionList Material_getImageDefinitions(Session * pxzSession, Material_ImageList images);
// Returns the size of an image
typedef struct {
   Core_Int width;
   Core_Int height;
} Material_getImageSizeReturn;
PXZ_EXPORTED Material_getImageSizeReturn Material_getImageSize(Session * pxzSession, Material_Image image);
// Give all the image format name and their extensions that can be imported in Pixyz
PXZ_EXPORTED Core_FormatList Material_getImportImageFormats(Session * pxzSession);
// Get impostor texture material properties
PXZ_EXPORTED Material_ImpostorMaterialInfos Material_getImpostorMaterialInfos(Session * pxzSession, Material_Material material);
// Returns the properties of a PBR Material
PXZ_EXPORTED Material_MaterialDefinition Material_getMaterialDefinition(Session * pxzSession, Material_Material material);
// Returns the properties of a set of PBR Materials
PXZ_EXPORTED Material_MaterialDefinitionList Material_getMaterialDefinitions(Session * pxzSession, Material_MaterialList materials);
// Get the main color on any material pattern type
PXZ_EXPORTED Core_ColorAlpha Material_getMaterialMainColor(Session * pxzSession, Material_Material material);
// Gets the MaterialPattern name of the material
PXZ_EXPORTED Core_String Material_getMaterialPattern(Session * pxzSession, Material_Material material);
// Returns the MaterialPatternType name of the material
PXZ_EXPORTED Material_MaterialPatternType Material_getMaterialPatternType(Session * pxzSession, Material_Material material);
// Get PBR  material properties
PXZ_EXPORTED Material_PBRMaterialInfos Material_getPBRMaterialInfos(Session * pxzSession, Material_Material material);
// Returns list of 3D Points and a material from a string and fontname
typedef struct {
   Geom_Point3List points;
   Geom_Point2List uvs;
   Geom_Vector3 normal;
   Material_Material material;
   Core_Double offset;
} Material_getPointsAndMaterialFromTextReturn;
PXZ_EXPORTED Material_getPointsAndMaterialFromTextReturn Material_getPointsAndMaterialFromText(Session * pxzSession, Core_String text, Core_String fontName, Core_Int fontSize, Geom_Matrix4 matrix, Core_Color colorInput, Core_Double offset, Core_Double height3D);
// Get standard material properties
PXZ_EXPORTED Material_StandardMaterialInfos Material_getStandardMaterialInfos(Session * pxzSession, Material_Material material);
// Get a shader uniform shader property type
PXZ_EXPORTED Material_ShaderUniformType Material_getUniformPropertyType(Session * pxzSession, Material_CustomMaterialPattern pattern, Core_String name);
// Get unlit texture material properties
PXZ_EXPORTED Material_UnlitTextureMaterialInfos Material_getUnlitTextureMaterialInfos(Session * pxzSession, Material_Material material);
// Import an image
PXZ_EXPORTED Material_Image Material_importImage(Session * pxzSession, Core_FilePath filename);
// Check if material is opaque
PXZ_EXPORTED Core_Boolean Material_isOpaque(Session * pxzSession, Material_Material material);
// Rename materials to have a unique name for each one
PXZ_EXPORTED void Material_makeMaterialNamesUnique(Session * pxzSession, Material_MaterialList materials);
// create remapped versions of index maps
typedef struct {
   Material_ImageList mappedMaps;
   Core_IntListList newToOldMapIndices;
} Material_remapIndexMapReturn;
PXZ_EXPORTED Material_remapIndexMapReturn Material_remapIndexMap(Session * pxzSession, Material_ImageList maps, Core_Int maxIndices);
// Resize an image
PXZ_EXPORTED void Material_resizeImage(Session * pxzSession, Material_Image image, Core_Int width, Core_Int height);
// Set the fragment shader of a custom pattern
PXZ_EXPORTED void Material_setFragmentShader(Session * pxzSession, Material_CustomMaterialPattern pattern, Core_String code);
// Set the main color on any material pattern type
PXZ_EXPORTED void Material_setMaterialMainColor(Session * pxzSession, Material_Material material, Core_ColorAlpha color);
// Sets the MaterialPattern name of the material
PXZ_EXPORTED void Material_setMaterialPattern(Session * pxzSession, Material_Material material, Core_String pattern);
// Set PBR  material properties
PXZ_EXPORTED void Material_setPBRMaterialInfos(Session * pxzSession, Material_Material material, Material_PBRMaterialInfos infos);
// Set the vertex shader of a custom pattern
PXZ_EXPORTED void Material_setVertexShader(Session * pxzSession, Material_CustomMaterialPattern pattern, Core_String code);
// Update an image from its raw data
PXZ_EXPORTED void Material_updateImageFromDefinition(Session * pxzSession, Material_Image image, Material_ImageDefinition imageDefinition);
// Update images from their raw data
PXZ_EXPORTED void Material_updateImagesFromDefinitions(Session * pxzSession, Material_ImageList image, Material_ImageDefinitionList imageDefinitions);
   /*!
     \param type Type of image change
     \param image Image changed
   */
PXZ_EXPORTED Core_Ident Material_addImageChangedCallback(Session * pxzSession, void(*fp)(void *, Material_ImageChangeType, Material_Image), void * userdata = nullptr);
PXZ_EXPORTED void Material_removeImageChangedCallback(Session * pxzSession, Core_Ident id);

   /*!
     \param type Type of material change
     \param material Material changed
   */
PXZ_EXPORTED Core_Ident Material_addMaterialChangedCallback(Session * pxzSession, void(*fp)(void *, Material_MaterialChangeType, Material_Material), void * userdata = nullptr);
PXZ_EXPORTED void Material_removeMaterialChangedCallback(Session * pxzSession, Core_Ident id);


// ----------------------------------------------------
// userData
// ----------------------------------------------------

// Set or replace a userdata stored on an material
PXZ_EXPORTED Core_Ptr Material_getMaterialUserData(Session * pxzSession, Material_MaterialUserData userDataId, Material_Material material);
// Batch version of getMaterialUserData
PXZ_EXPORTED Core_PtrList Material_getMultipleMaterialUserData(Session * pxzSession, Material_MaterialUserData userDataId, Material_MaterialList materials);
// Set or replace a userdata stored on an material
PXZ_EXPORTED Core_Bool Material_hasMaterialUserData(Session * pxzSession, Material_MaterialUserData userDataId, Material_Material material);
// Batch version of hasMaterialUserData
PXZ_EXPORTED Core_BoolList Material_hasMultipleMaterialUserData(Session * pxzSession, Material_MaterialUserData userDataId, Material_MaterialList materials);
// Set or replace a userdata stored on an material
PXZ_EXPORTED void Material_setMaterialUserData(Session * pxzSession, Material_MaterialUserData userDataId, Material_Material material, Core_Ptr userData);
// Batch version of setMaterialUserData
PXZ_EXPORTED void Material_setMultipleMaterialUserData(Session * pxzSession, Material_MaterialUserData userDataId, Material_MaterialList materials, Core_PtrList userDataList);
// subscribe to material user data. multiple different userdata can be stored on the same materials if subscribeToMaterialUserData is called multiple times
PXZ_EXPORTED Material_MaterialUserData Material_subscribeToMaterialUserData(Session * pxzSession);
// Unset the userdata stored on an material
PXZ_EXPORTED void Material_unsetMaterialUserData(Session * pxzSession, Material_MaterialUserData userDataId, Material_Material material);
// Batch version of unsetMaterialUserData
PXZ_EXPORTED void Material_unsetMultipleMaterialUserData(Session * pxzSession, Material_MaterialUserData userDataId, Material_MaterialList materials);
PXZ_EXPORTED void Material_unsubscribeFromMaterialUserData(Session * pxzSession, Material_MaterialUserData userDataId);



#endif
