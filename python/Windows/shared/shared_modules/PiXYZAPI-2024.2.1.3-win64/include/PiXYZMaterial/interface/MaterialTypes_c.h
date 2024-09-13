// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_MATERIAL_INTERFACE_MATERIALTYPES_C_H_
#define _PXZ_MATERIAL_INTERFACE_MATERIALTYPES_C_H_

#include <string.h>
#include <PiXYZCore/interface/InterfaceBase_c.h>
#include <PiXYZCore/interface/CoreTypes_c.h>
#include <PiXYZGeom/interface/GeomTypes_c.h>


typedef Core_Entity Material_Image;

typedef struct {
   Material_Image image;
   Core_Int channel;
   Geom_Point2 offset;
   Geom_Point2 tilling;
} Material_Texture;

PXZ_EXPORTED void Material_Texture_init(Material_Texture * str);
PXZ_EXPORTED void Material_Texture_free(Material_Texture * str);
struct Material_CoeffOrTexture {
   Core_Coeff coeff;
   Material_Texture texture;
   typedef enum {
      UNKNOWN=0,
      COEFF,
      TEXTURE
   } Type;

   Type _type; 
};

PXZ_EXPORTED void Material_CoeffOrTexture_init(Material_CoeffOrTexture * sel);
PXZ_EXPORTED void Material_CoeffOrTexture_free(Material_CoeffOrTexture * sel);

typedef struct {
   Core_String name;
   Core_ColorAlpha color;
} Material_ColorMaterialInfos;

PXZ_EXPORTED void Material_ColorMaterialInfos_init(Material_ColorMaterialInfos * str);
PXZ_EXPORTED void Material_ColorMaterialInfos_free(Material_ColorMaterialInfos * str);
struct Material_ColorOrTexture {
   Core_Color color;
   Material_Texture texture;
   typedef enum {
      UNKNOWN=0,
      COLOR,
      TEXTURE
   } Type;

   Type _type; 
};

PXZ_EXPORTED void Material_ColorOrTexture_init(Material_ColorOrTexture * sel);
PXZ_EXPORTED void Material_ColorOrTexture_free(Material_ColorOrTexture * sel);

typedef Core_Entity Material_CustomMaterialPattern;

typedef enum {
 Material_ImageChangeType_ADDED = 0,
 Material_ImageChangeType_REMOVED = 1,
 Material_ImageChangeType_CHANGED = 2,
 Material_ImageChangeType_RESET = 3,
 Material_ImageChangeType_REPLACED = 4,
} Material_ImageChangeType;

typedef struct {
   Material_Image id;
   Core_String name;
   Core_Int width;
   Core_Int height;
   Core_Int bitsPerComponent;
   Core_Int componentsCount;
   Core_ByteList data;
} Material_ImageDefinition;

PXZ_EXPORTED void Material_ImageDefinition_init(Material_ImageDefinition * str);
PXZ_EXPORTED void Material_ImageDefinition_free(Material_ImageDefinition * str);
typedef struct {
   size_t size;
   Material_ImageDefinition * list;
} Material_ImageDefinitionList;

PXZ_EXPORTED void Material_ImageDefinitionList_init(Material_ImageDefinitionList * list, size_t size = 0);
PXZ_EXPORTED void Material_ImageDefinitionList_free(Material_ImageDefinitionList * list);
typedef struct {
   size_t size;
   Material_Image * list;
} Material_ImageList;

PXZ_EXPORTED void Material_ImageList_init(Material_ImageList * list, size_t size = 0);
PXZ_EXPORTED void Material_ImageList_free(Material_ImageList * list);
typedef struct {
   Core_String name;
   Material_ColorOrTexture albedo;
   Material_ColorOrTexture normal;
   Material_CoeffOrTexture roughness;
   Material_CoeffOrTexture ao;
   Material_CoeffOrTexture depth;
   Core_Int nbFrames;
   Core_Boolean fullOcta;
   Core_Double octaDiameter;
   Core_Int linearSteps;
   Core_Int binarySteps;
} Material_ImpostorMaterialInfos;

PXZ_EXPORTED void Material_ImpostorMaterialInfos_init(Material_ImpostorMaterialInfos * str);
PXZ_EXPORTED void Material_ImpostorMaterialInfos_free(Material_ImpostorMaterialInfos * str);
typedef Core_Entity Material_Material;

typedef enum {
 Material_MaterialChangeType_CHANGED = 0,
 Material_MaterialChangeType_PATTERN_CHANGED = 1,
 Material_MaterialChangeType_RELOAD = 2,
 Material_MaterialChangeType_DESTROYED = 3,
 Material_MaterialChangeType_ICON_CHANGED = 4,
 Material_MaterialChangeType_ADDED = 5,
 Material_MaterialChangeType_REMOVED = 6,
} Material_MaterialChangeType;

typedef struct {
   Core_String name;
   Material_Material id;
   Material_ColorOrTexture albedo;
   Material_ColorOrTexture normal;
   Material_CoeffOrTexture metallic;
   Material_CoeffOrTexture roughness;
   Material_CoeffOrTexture ao;
   Material_CoeffOrTexture opacity;
   Material_ColorOrTexture emissive;
} Material_MaterialDefinition;

PXZ_EXPORTED void Material_MaterialDefinition_init(Material_MaterialDefinition * str);
PXZ_EXPORTED void Material_MaterialDefinition_free(Material_MaterialDefinition * str);
typedef struct {
   size_t size;
   Material_MaterialDefinition * list;
} Material_MaterialDefinitionList;

PXZ_EXPORTED void Material_MaterialDefinitionList_init(Material_MaterialDefinitionList * list, size_t size = 0);
PXZ_EXPORTED void Material_MaterialDefinitionList_free(Material_MaterialDefinitionList * list);
typedef struct {
   Core_Int importedTextureCount;
   Core_Int createdMaterialCount;
   Core_Int updatedMaterialCount;
} Material_MaterialFromMapsReturn;

PXZ_EXPORTED void Material_MaterialFromMapsReturn_init(Material_MaterialFromMapsReturn * str);
PXZ_EXPORTED void Material_MaterialFromMapsReturn_free(Material_MaterialFromMapsReturn * str);
typedef struct {
   size_t size;
   Material_Material * list;
} Material_MaterialList;

PXZ_EXPORTED void Material_MaterialList_init(Material_MaterialList * list, size_t size = 0);
PXZ_EXPORTED void Material_MaterialList_free(Material_MaterialList * list);
typedef struct {
   size_t size;
   Material_MaterialList * list;
} Material_MaterialListList;

PXZ_EXPORTED void Material_MaterialListList_init(Material_MaterialListList * list, size_t size = 0);
PXZ_EXPORTED void Material_MaterialListList_free(Material_MaterialListList * list);
typedef enum {
 Material_MaterialPatternType_CUSTOM = 0,
 Material_MaterialPatternType_COLOR = 1,
 Material_MaterialPatternType_STANDARD = 2,
 Material_MaterialPatternType_UNLIT_TEXTURE = 3,
 Material_MaterialPatternType_PBR = 4,
 Material_MaterialPatternType_IMPOSTOR = 5,
 Material_MaterialPatternType_LINE = 6,
} Material_MaterialPatternType;

typedef Core_Ident Material_MaterialUserData;

typedef struct {
   Core_String name;
   Material_ColorOrTexture albedo;
   Material_ColorOrTexture normal;
   Material_CoeffOrTexture metallic;
   Material_CoeffOrTexture roughness;
   Material_CoeffOrTexture ao;
   Material_CoeffOrTexture opacity;
} Material_PBRMaterialInfos;

PXZ_EXPORTED void Material_PBRMaterialInfos_init(Material_PBRMaterialInfos * str);
PXZ_EXPORTED void Material_PBRMaterialInfos_free(Material_PBRMaterialInfos * str);
typedef enum {
 Material_ResizeFilterMethod_DEFAULT = 0,
 Material_ResizeFilterMethod_BOX = 1,
 Material_ResizeFilterMethod_TRIANGLE = 2,
 Material_ResizeFilterMethod_CUBICBSPLINE = 3,
 Material_ResizeFilterMethod_CATMULLROM = 4,
 Material_ResizeFilterMethod_MITCHELL = 5,
} Material_ResizeFilterMethod;

typedef enum {
 Material_ShaderUniformType_INTEGER = 2,
 Material_ShaderUniformType_BOOLEAN = 9,
 Material_ShaderUniformType_REAL = 11,
 Material_ShaderUniformType_COEFF = 13,
 Material_ShaderUniformType_POINT3 = 23,
 Material_ShaderUniformType_POINT2 = 22,
 Material_ShaderUniformType_COLOR = 15,
 Material_ShaderUniformType_COLOR_ALPHA = 16,
 Material_ShaderUniformType_TEXTURE = 34,
 Material_ShaderUniformType_COLORORTEXTURE = 35,
 Material_ShaderUniformType_COEFFORTEXTURE = 36,
} Material_ShaderUniformType;

typedef struct {
   Core_String name;
   Material_ColorOrTexture diffuse;
   Material_ColorOrTexture specular;
   Material_ColorOrTexture ambient;
   Material_ColorOrTexture emissive;
   Core_Coeff shininess;
   Core_Coeff transparency;
} Material_StandardMaterialInfos;

PXZ_EXPORTED void Material_StandardMaterialInfos_init(Material_StandardMaterialInfos * str);
PXZ_EXPORTED void Material_StandardMaterialInfos_free(Material_StandardMaterialInfos * str);
typedef struct {
   Core_String name;
   Material_Texture texture;
} Material_UnlitTextureMaterialInfos;

PXZ_EXPORTED void Material_UnlitTextureMaterialInfos_init(Material_UnlitTextureMaterialInfos * str);
PXZ_EXPORTED void Material_UnlitTextureMaterialInfos_free(Material_UnlitTextureMaterialInfos * str);


#endif
