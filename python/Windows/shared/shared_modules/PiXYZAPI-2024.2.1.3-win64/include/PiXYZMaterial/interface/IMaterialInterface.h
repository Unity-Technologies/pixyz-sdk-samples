// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_MATERIAL_INTERFACE_IMATERIALINTERFACE_H_
#define _PXZ_MATERIAL_INTERFACE_IMATERIALINTERFACE_H_

#include "MaterialTypes.h"

namespace PiXYZ { class PiXYZAPI; }


PXZ_MODULE_BEGIN(MaterialI)

class PXZ_EXPORTED IMaterialInterface
{
public:
   virtual ~IMaterialInterface() {}

   //! Add a shader uniform parameter to the given custom pattern
   /*!
     \param pattern The custom pattern to edit
     \param name Name of the new property
     \param type Type of the new uniform
   */
   virtual void addUniformProperty(const CustomMaterialPattern & pattern, const CoreI::String & name, const ShaderUniformType & type) = 0;

   //! Check if some materials are opaques. Function will return 'False' for each material if:\n- The 'Opacity' Coeff is not 1.0\n- The 'Opacity' property is a Texture\n- The 'Albedo' property is a Texture and at least one pixel of the texture has an alpha value
   /*!
     \param materials Materials to check opacity
     \return opaques For each given material, returns True if opaque or False if transparent
   */
   virtual CoreI::BoolList areOpaques(const MaterialList & materials) = 0;

   //! Remove and delete all the materials
   virtual void clearAllMaterials() = 0;

   /*!
     \param functionName 
     \param enableFunction 
     \param enableParameters 
     \param enableExecutionTime 
   */
   virtual void configureFunctionLogger(const CoreI::String & functionName, const CoreI::Boolean & enableFunction, const CoreI::Boolean & enableParameters, const CoreI::Boolean & enableExecutionTime) = 0;

   //! Returns a new image from the given converter from 32bits float to a 8Bits (e.g. depth render map)
   /*!
     \param image32F Image to convert
     \param minValue Minimal value of the floats (will be 0 in 8bits)
     \param maxValue Minimal value of the floats (will be 255 in 8bits)
     \return image8U The new 8bits image
   */
   virtual Image convertFloat32To8BitsImage(const Image & image32F, const CoreI::Double & minValue = -1, const CoreI::Double & maxValue = 1) = 0;

   //! Convert a height map to a normal map
   /*!
     \param hmap Height map reference
     \param height Maximum height
     \return nmap Normal map
   */
   virtual Image convertHeightMapToNormalMap(const Image & hmap, const CoreI::Double & height = 0.5) = 0;

   //! copies a material
   /*!
     \param toCopy Material to copy
     \param addToMaterialLibrary Add to material library
     \return material The copied material
   */
   virtual Material copyMaterial(const Material & toCopy, const CoreI::Boolean & addToMaterialLibrary) = 0;

   //! Create a new custom material pattern
   /*!
     \param name Name of the pattern
     \return pattern The created material pattern
   */
   virtual CustomMaterialPattern createCustomMaterialPattern(const CoreI::String & name) = 0;

   //! Import an Image from only its data
   /*!
     \param data The raw data as input
     \param name If need of a name
     \return image The created Image
   */
   virtual Image createImageFromData(const CoreI::ByteList & data, const CoreI::String & name = "img") = 0;

   //! Import an image from its raw data
   /*!
     \param imageDefinition The image definition
     \return image The created image
   */
   virtual Image createImageFromDefinition(const ImageDefinition & imageDefinition) = 0;

   //! Import images from their raw data
   /*!
     \param imageDefinitions The image definitions
     \return images The created images
   */
   virtual ImageList createImagesFromDefinitions(const ImageDefinitionList & imageDefinitions) = 0;

   //! Create a new material from pattern
   /*!
     \param name Name of the material
     \param pattern Name of the pattern
     \param addToMaterialLibrary Name of the pattern
     \return material The created material
   */
   virtual Material createMaterial(const CoreI::String & name, const CoreI::String & pattern, const CoreI::Boolean & addToMaterialLibrary = true) = 0;

   //! Create PBR material from a material definition
   /*!
     \param materialDefinition The structure containing all the PBR material information
     \return material The created material
   */
   virtual Material createMaterialFromDefinition(const MaterialDefinition & materialDefinition) = 0;

   //! Create PBR materials from material definitions
   /*!
     \param materialDefinitions Material definitions containing properties for each given material
     \return materials The created materials
   */
   virtual MaterialList createMaterialsFromDefinitions(const MaterialDefinitionList & materialDefinitions) = 0;

   //! Automatically creates PBR materials when importing PBR texture maps from a folder
   /*!
     \param directory Directory path
     \return result Results of the createMaterialsFromMaps function
   */
   virtual MaterialFromMapsReturn createMaterialsFromMaps(const CoreI::DirectoryPath & directory) = 0;

   //! Export an image
   /*!
     \param image Identifier of the image to export
     \param filename Filename of the file to export
   */
   virtual void exportImage(const Image & image, const CoreI::OutputFilePath & filename) = 0;

   //! Fill unused pixels by propagating and averaging used pixels
   /*!
     \param image Image to process
     \param unusedColor Color used to identify unused pixels
     \return filledImage Resulting image with filled pixels
   */
   virtual Image fillUnusedPixels(const Image & image, const CoreI::ColorAlpha & unusedColor) = 0;

   //! Filter an AO map using ATrous method
   /*!
     \param aoMap Input AO Map (the alpha component must be set to 0 for unused pixels)
     \param normalMap Input Normal Map (preferable to use a World space normal map, but an Object space normal map can be used)
     \param sigmaPos ATrous Sigma pos
     \param sigmaValue ATrous Sigma value
     \param sigmaNormal ATrous Sigma normal
     \param levelCount Atrous #Levels
     \param filterLowValues Remove low values from the filtering (see: lowValuesThreshold parameter)
     \param lowValueThreshold Threshold used if filterLowValues is enabled
     \return filterAOMap The filtered AO Map
   */
   virtual Image filterAO(const Image & aoMap, const Image & normalMap, const CoreI::Double & sigmaPos = 10, const CoreI::Double & sigmaValue = 0.1, const CoreI::Double & sigmaNormal = 0.01, const CoreI::Int & levelCount = 4, const CoreI::Boolean & filterLowValues = true, const CoreI::Double & lowValueThreshold = 0.01) = 0;

   //! Returns the material pattern which has the given name
   /*!
     \param name The name of the material pattern
     \return pattern The material pattern
   */
   virtual CustomMaterialPattern findCustomMaterialPatternByName(const CoreI::String & name) = 0;

   //! Returns all materials using the given pattern
   /*!
     \param pattern A material pattern
     \return materials Materials using the pattern
   */
   virtual MaterialList findMaterialsByPattern(const CoreI::String & pattern) = 0;

   //! Returns all materials which match a given property value
   /*!
     \param propertyName Name of the property to match
     \param propertyValue Regular expression to match for the property value
     \param caseInsensitive If True, the regex will be insensitive to upper and lower cases
     \return materials Materials matching the property value
   */
   virtual MaterialList findMaterialsByProperty(const CoreI::String & propertyName, const CoreI::Regex & propertyValue, const CoreI::Bool & caseInsensitive = false) = 0;

   //! Returns all the images loaded in the current session or from a list of materials
   /*!
     \param materials Materials to retrieve the images from (returns all images loaded in the current session if empty)
     \return images A list containing all images identifiers
   */
   virtual ImageList getAllImages(const MaterialList & materials = MaterialList(0)) = 0;

   //! Returns all the material patterns in the current session
   /*!
     \return shaders A list containing all material patterns
   */
   virtual CoreI::StringList getAllMaterialPatterns() = 0;

   //! Retrieve the list of all the materials in the material library
   /*!
     \return materials List of materials in the material library
   */
   virtual MaterialList getAllMaterials() = 0;

   //! Get color material properties
   /*!
     \param material The material to get properties
     \return infos The ColorMaterialInfos properties
   */
   virtual ColorMaterialInfos getColorMaterialInfos(const Material & material) = 0;

   //! Returns the custom material pattern associated to the custom material
   /*!
     \param material Custom material to get the pattern from
     \return pattern The custom material pattern
   */
   virtual CustomMaterialPattern getCustomMaterialPattern(const Material & material) = 0;

   //! Returns image format names and extensions which can be exported in Pixyz
   /*!
     \return formats Image formats that can be exported
   */
   virtual CoreI::FormatList getExportImageFormats() = 0;

   //! Returns the raw data of an image
   /*!
     \param image Image's definition
     \return imageDefinition Definition of the image
   */
   virtual ImageDefinition getImageDefinition(const Image & image) = 0;

   //! Returns the raw data of a set of images
   /*!
     \param images The images
     \return imageDefinitions Images's definitions
   */
   virtual ImageDefinitionList getImageDefinitions(const ImageList & images) = 0;

   //! Returns the color of a given pixel in an image
   /*!
     \param image The image to get the pixel from
     \param x The x pixel coordinates
     \param y The y pixel coordinates
     \return color The color of the pixel at the x,y position
   */
   virtual CoreI::ColorAlpha getImagePixelColor(const Image & image, const CoreI::Int & x, const CoreI::Int & y) = 0;

   //! Returns the size of an image
   /*!
     \param image The image to get the size from
     \return width The width of the image in pixels
     \return height The height of the image in pixels
   */
   virtual getImageSizeReturn getImageSize(const Image & image) = 0;

   //! Returns the sizes of multiple images
   /*!
     \param images The image to get the size from
     \return widths The widths of the images in pixels
     \return heights The heights of the images in pixels
   */
   virtual getImagesSizesReturn getImagesSizes(const ImageList & images) = 0;

   //! Returns the image format names and extensions which can be imported in Pixyz
   /*!
     \return formats Image formats that can be imported
   */
   virtual CoreI::FormatList getImportImageFormats() = 0;

   //! Get impostor texture material properties
   /*!
     \param material The material to get properties
     \return infos The getImpostorMaterialInfos properties
   */
   virtual ImpostorMaterialInfos getImpostorMaterialInfos(const Material & material) = 0;

   //! Returns the properties of a PBR Material
   /*!
     \param material The PBR Material
     \return materialDefinition The PBR material definition
   */
   virtual MaterialDefinition getMaterialDefinition(const Material & material) = 0;

   //! Returns the properties of a set of PBR Materials
   /*!
     \param materials The PBR Materials
     \return materialDefinitions The PBR Material definitions
   */
   virtual MaterialDefinitionList getMaterialDefinitions(const MaterialList & materials) = 0;

   //! Get the main color on any material pattern type
   /*!
     \param material The material
     \return color The main color
   */
   virtual CoreI::ColorAlpha getMaterialMainColor(const Material & material) = 0;

   //! Gets the MaterialPattern name of the material
   /*!
     \param material The material to find the pattern
     \return pattern The pattern of the material
   */
   virtual CoreI::String getMaterialPattern(const Material & material) = 0;

   //! Returns the MaterialPatternType name of the material
   /*!
     \param material The material to find the pattern
     \return patternType The pattern type of the material
   */
   virtual MaterialPatternType getMaterialPatternType(const Material & material) = 0;

   //! Get PBR  material properties
   /*!
     \param material The material to get properties
     \return infos The PBRMaterialInfos properties
   */
   virtual PBRMaterialInfos getPBRMaterialInfos(const Material & material) = 0;

   //! Returns a list of 3D Points and a material from a string and a fontname
   /*!
     \param text Input text
     \param fontName Fontname
     \param fontSize FontSize
     \param matrix Input matrix for the text
     \param colorInput Color of the font needed
     \param offset Input offset for the text
     \param height3D Input height in 3D which will be a ratio from the textSize
     \return points 
     \return uvs 
     \return normal 
     \return material 
     \return offset Offset given by the text
   */
   virtual getPointsAndMaterialFromTextReturn getPointsAndMaterialFromText(const CoreI::String & text, const CoreI::String & fontName, const CoreI::Int & fontSize, const GeomI::Matrix4 & matrix, const CoreI::Color & colorInput, const CoreI::Double & offset = 0.0, const CoreI::Double & height3D = 0.0) = 0;

   //! Get standard material properties
   /*!
     \param material The material to get properties
     \return infos The StandardMaterialInfos properties
   */
   virtual StandardMaterialInfos getStandardMaterialInfos(const Material & material) = 0;

   //! Get a shader uniform shader property type
   /*!
     \param pattern The custom pattern
     \param name Name of the property to get the type from
     \return type Type of the uniform property
   */
   virtual ShaderUniformType getUniformPropertyType(const CustomMaterialPattern & pattern, const CoreI::String & name) = 0;

   //! Get unlit texture material properties
   /*!
     \param material The material to get properties
     \return infos The UnlitTextureMaterialInfos properties
   */
   virtual UnlitTextureMaterialInfos getUnlitTextureMaterialInfos(const Material & material) = 0;

   //! Import an image
   /*!
     \param filename Filename of the image to import
     \return image Identifier of the imported image
   */
   virtual Image importImage(const CoreI::FilePath & filename) = 0;

   //! Check if material is opaque. Function will return 'False' if:\n- The 'Opacity' Coeff is not 1.0\n- The 'Opacity' property is a Texture\n- The 'Albedo' property is a Texture and at least one pixel of the texture has an alpha value
   /*!
     \param material Material to check opacity
     \return opaque Returns True if opaque or False if transparent
   */
   virtual CoreI::Boolean isOpaque(const Material & material) = 0;

   //! Rename materials to have a unique name for each one
   /*!
     \param materials Materials to rename (rename all materials if empty)
   */
   virtual void makeMaterialNamesUnique(const MaterialList & materials = MaterialList(0)) = 0;

   //! create remapped versions of index maps
   /*!
     \param maps Input Images
     \param maxIndices Number max of indices remapped
     \return mappedMaps Output maps remapped
     \return newToOldMapIndices New index to old index for each map
   */
   virtual remapIndexMapReturn remapIndexMap(const ImageList & maps, const CoreI::Int & maxIndices) = 0;

   //! Resize an image
   /*!
     \param image Image to be resize
     \param width New image width
     \param height New image height
     \param filteringMethod Filtering method for image resizing
   */
   virtual void resizeImage(const Image & image, const CoreI::Int & width, const CoreI::Int & height, const ResizeFilterMethod & filteringMethod = ResizeFilterMethod::DEFAULT) = 0;

   //! Set a CoeffOrTexture property
   /*!
     \param material The material to apply the color on
     \param name The property to set
     \param coeffOrTexture The CoeffOrTexture to apply
   */
   virtual void setCoeffOrTextureProperty(const Material & material, const CoreI::String & name, const CoeffOrTexture & coeffOrTexture) = 0;

   //! Set a ColorAlpha property
   /*!
     \param material The material to apply the color on
     \param name The property to set
     \param color The color to apply
   */
   virtual void setColorAlphaProperty(const Material & material, const CoreI::String & name, const CoreI::ColorAlpha & color) = 0;

   //! Set a ColorOrTexture property
   /*!
     \param material The material to apply the color on
     \param name The property to set
     \param colorOrTexture The ColorOrTexture to apply
   */
   virtual void setColorOrTextureProperty(const Material & material, const CoreI::String & name, const ColorOrTexture & colorOrTexture) = 0;

   //! Set the fragment shader of a custom pattern
   /*!
     \param pattern The custom pattern to edit
     \param code The GLSL code of the fragment shader
   */
   virtual void setFragmentShader(const CustomMaterialPattern & pattern, const CoreI::String & code) = 0;

   //! Set the main color on any material pattern type
   /*!
     \param material The material to apply the color on
     \param color The color to apply
   */
   virtual void setMaterialMainColor(const Material & material, const CoreI::ColorAlpha & color) = 0;

   //! Sets the MaterialPattern name of the material
   /*!
     \param material The material to find the pattern
     \param pattern The pattern of the material
   */
   virtual void setMaterialPattern(const Material & material, const CoreI::String & pattern) = 0;

   //! Set PBR  material properties
   /*!
     \param material The material to set properties
     \param infos The PBRMaterialInfos properties
   */
   virtual void setPBRMaterialInfos(const Material & material, const PBRMaterialInfos & infos) = 0;

   //! Set the vertex shader of a custom pattern
   /*!
     \param pattern The custom pattern to edit
     \param code The GLSL code of the vertex shader
   */
   virtual void setVertexShader(const CustomMaterialPattern & pattern, const CoreI::String & code) = 0;

   //! Update an image from its raw data
   /*!
     \param image The image to update
     \param imageDefinition The new data to apply
   */
   virtual void updateImageFromDefinition(const Image & image, const ImageDefinition & imageDefinition) = 0;

   //! Update images from their raw data
   /*!
     \param image The image to update
     \param imageDefinitions The new data to apply
   */
   virtual void updateImagesFromDefinitions(const ImageList & image, const ImageDefinitionList & imageDefinitions) = 0;

   /*!
     \param type Type of image change
     \param image Image changed
   */
   virtual CoreI::Ident addImageChangedCallback(void(*fp)(void *, const ImageChangeType &, const Image &), void * userdata = nullptr) = 0;
   void * removeImageChangedCallback(CoreI::Ident id); 

   /*!
     \param type Type of material change
     \param material Material changed
   */
   virtual CoreI::Ident addMaterialChangedCallback(void(*fp)(void *, const MaterialChangeType &, const Material &), void * userdata = nullptr) = 0;
   void * removeMaterialChangedCallback(CoreI::Ident id); 


   /**
    * \defgroup userData 
    * @{
    */
   //! Set or replace a userdata stored on an material
   /*!
     \param userDataId UserData identifier provided by subscribeToMaterialUserData
     \param material Material that store the user data
     \return userData User data stored in the given material
   */
   virtual CoreI::Ptr getMaterialUserData(const MaterialUserData & userDataId, const Material & material) = 0;

   //! Batch version of getMaterialUserData
   /*!
     \param userDataId UserData identifier provided by subscribeToMaterialUserData
     \param materials Materials that store the user data
     \return userDataList User data stored for each given material
   */
   virtual CoreI::PtrList getMultipleMaterialUserData(const MaterialUserData & userDataId, const MaterialList & materials) = 0;

   //! Set or replace a userdata stored on an material
   /*!
     \param userDataId UserData identifier provided by subscribeToMaterialUserData
     \param material Material that potentially store the user data
     \return result Returns true if a userdata is stored on this material for the given userDataId
   */
   virtual CoreI::Bool hasMaterialUserData(const MaterialUserData & userDataId, const Material & material) = 0;

   //! Batch version of hasMaterialUserData
   /*!
     \param userDataId UserData identifier provided by subscribeToMaterialUserData
     \param materials Materials that potentially store the user data
     \return results Returns an array of bool that are true if a userdata is stored on the material at the same index for the given userDataId
   */
   virtual CoreI::BoolList hasMultipleMaterialUserData(const MaterialUserData & userDataId, const MaterialList & materials) = 0;

   //! Set or replace a userdata stored on an material
   /*!
     \param userDataId UserData identifier provided by subscribeToMaterialUserData
     \param material Material that will store the user data
     \param userData User data to store in the given material
   */
   virtual void setMaterialUserData(const MaterialUserData & userDataId, const Material & material, const CoreI::Ptr & userData) = 0;

   //! Batch version of setMaterialUserData
   /*!
     \param userDataId UserData identifier provided by subscribeToMaterialUserData
     \param materials Materials that will store the user data
     \param userDataList User data to store on each material
   */
   virtual void setMultipleMaterialUserData(const MaterialUserData & userDataId, const MaterialList & materials, const CoreI::PtrList & userDataList) = 0;

   //! subscribe to material user data. multiple different userdata can be stored on the same materials if subscribeToMaterialUserData is called multiple times
   /*!
     \return userDataId UserData identifier to pass to setUserData/getUserData functions
   */
   virtual MaterialUserData subscribeToMaterialUserData() = 0;

   //! Unset the userdata stored on an material
   /*!
     \param userDataId UserData identifier provided by subscribeToMaterialUserData
     \param material Material that will store the user data
   */
   virtual void unsetMaterialUserData(const MaterialUserData & userDataId, const Material & material) = 0;

   //! Batch version of unsetMaterialUserData
   /*!
     \param userDataId UserData identifier provided by subscribeToMaterialUserData
     \param materials Materials that will store the user data
   */
   virtual void unsetMultipleMaterialUserData(const MaterialUserData & userDataId, const MaterialList & materials) = 0;

   /*!
     \param userDataId UserData identifier to unsubscribe
   */
   virtual void unsubscribeFromMaterialUserData(const MaterialUserData & userDataId) = 0;

   /**@}*/

};

PXZ_MODULE_END



#endif
