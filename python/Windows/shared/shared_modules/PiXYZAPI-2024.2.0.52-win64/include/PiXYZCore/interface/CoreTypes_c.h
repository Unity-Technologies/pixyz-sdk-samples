// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_CORE_INTERFACE_CORETYPES_C_H_
#define _PXZ_CORE_INTERFACE_CORETYPES_C_H_

#include <string.h>
#include <PiXYZCore/interface/InterfaceBase_c.h>


typedef struct {
   Core_String alias;
} Core_AliasTypeDesc;

PXZ_EXPORTED void Core_AliasTypeDesc_init(Core_AliasTypeDesc * str);
PXZ_EXPORTED void Core_AliasTypeDesc_free(Core_AliasTypeDesc * str);
typedef struct {
   Core_String arrayType;
   Core_Int size;
} Core_ArrayTypeDesc;

PXZ_EXPORTED void Core_ArrayTypeDesc_init(Core_ArrayTypeDesc * str);
PXZ_EXPORTED void Core_ArrayTypeDesc_free(Core_ArrayTypeDesc * str);
typedef struct {
   Core_String key;
   Core_String value;
} Core_StringPair;

PXZ_EXPORTED void Core_StringPair_init(Core_StringPair * str);
PXZ_EXPORTED void Core_StringPair_free(Core_StringPair * str);
typedef struct {
   size_t size;
   Core_StringPair * list;
} Core_StringPairList;

PXZ_EXPORTED void Core_StringPairList_init(Core_StringPairList * list, size_t size = 0);
PXZ_EXPORTED void Core_StringPairList_free(Core_StringPairList * list);
typedef struct {
   Core_StringPairList values;
   Core_String message;
} Core_AutoValueReturn;

PXZ_EXPORTED void Core_AutoValueReturn_init(Core_AutoValueReturn * str);
PXZ_EXPORTED void Core_AutoValueReturn_free(Core_AutoValueReturn * str);
typedef struct {
   size_t size;
   Core_Bool * list;
} Core_BoolList;

PXZ_EXPORTED void Core_BoolList_init(Core_BoolList * list, size_t size = 0);
PXZ_EXPORTED void Core_BoolList_free(Core_BoolList * list);
typedef Core_Bool Core_Boolean;

typedef struct {
   Core_Int value;
   Core_Int min;
   Core_Int max;
} Core_BoundedInteger;

PXZ_EXPORTED void Core_BoundedInteger_init(Core_BoundedInteger * str);
PXZ_EXPORTED void Core_BoundedInteger_free(Core_BoundedInteger * str);
typedef struct {
   size_t size;
   Core_Byte * list;
} Core_ByteList;

PXZ_EXPORTED void Core_ByteList_init(Core_ByteList * list, size_t size = 0);
PXZ_EXPORTED void Core_ByteList_free(Core_ByteList * list);
typedef Core_ByteList (*Core_CaptchaCallback)(Core_String message, Core_ByteList key);

typedef Core_Double Core_Coeff;

typedef struct {
   Core_Double r;
   Core_Double g;
   Core_Double b;
} Core_Color;

PXZ_EXPORTED void Core_Color_init(Core_Color * str);
PXZ_EXPORTED void Core_Color_free(Core_Color * str);
typedef struct {
   Core_Double r;
   Core_Double g;
   Core_Double b;
   Core_Double a;
} Core_ColorAlpha;

PXZ_EXPORTED void Core_ColorAlpha_init(Core_ColorAlpha * str);
PXZ_EXPORTED void Core_ColorAlpha_free(Core_ColorAlpha * str);
typedef struct {
   size_t size;
   Core_ColorAlpha * list;
} Core_ColorAlphaList;

PXZ_EXPORTED void Core_ColorAlphaList_init(Core_ColorAlphaList * list, size_t size = 0);
PXZ_EXPORTED void Core_ColorAlphaList_free(Core_ColorAlphaList * list);
typedef struct {
   size_t size;
   Core_Color * list;
} Core_ColorList;

PXZ_EXPORTED void Core_ColorList_init(Core_ColorList * list, size_t size = 0);
PXZ_EXPORTED void Core_ColorList_free(Core_ColorList * list);
typedef enum {
 Core_TypeDescType_UNKNOWN = 0,
 Core_TypeDescType_BASE = 1,
 Core_TypeDescType_ALIAS = 2,
 Core_TypeDescType_ENUM = 3,
 Core_TypeDescType_LIST = 4,
 Core_TypeDescType_STRUCT = 5,
 Core_TypeDescType_ARRAY = 6,
 Core_TypeDescType_SELECT = 7,
 Core_TypeDescType_FUNCPTR = 8,
} Core_TypeDescType;

typedef struct {
   size_t size;
   Core_Int * list;
} Core_IntList;

PXZ_EXPORTED void Core_IntList_init(Core_IntList * list, size_t size = 0);
PXZ_EXPORTED void Core_IntList_free(Core_IntList * list);
typedef struct {
   size_t size;
   Core_String * list;
} Core_StringList;

PXZ_EXPORTED void Core_StringList_init(Core_StringList * list, size_t size = 0);
PXZ_EXPORTED void Core_StringList_free(Core_StringList * list);
typedef struct {
   Core_IntList values;
   Core_StringList labels;
   Core_String valueType;
} Core_EnumTypeDesc;

PXZ_EXPORTED void Core_EnumTypeDesc_init(Core_EnumTypeDesc * str);
PXZ_EXPORTED void Core_EnumTypeDesc_free(Core_EnumTypeDesc * str);
typedef struct {
   Core_String listType;
} Core_ListTypeDesc;

PXZ_EXPORTED void Core_ListTypeDesc_init(Core_ListTypeDesc * str);
PXZ_EXPORTED void Core_ListTypeDesc_free(Core_ListTypeDesc * str);
typedef struct {
   Core_String name;
   Core_String type;
   Core_String module;
   Core_String defaultValue;
   Core_String description;
   Core_String disableValue;
   Core_StringPairList predefinedValues;
} Core_Field;

PXZ_EXPORTED void Core_Field_init(Core_Field * str);
PXZ_EXPORTED void Core_Field_free(Core_Field * str);
typedef struct {
   size_t size;
   Core_Field * list;
} Core_FieldList;

PXZ_EXPORTED void Core_FieldList_init(Core_FieldList * list, size_t size = 0);
PXZ_EXPORTED void Core_FieldList_free(Core_FieldList * list);
typedef struct {
   Core_FieldList fields;
} Core_StructTypeDesc;

PXZ_EXPORTED void Core_StructTypeDesc_init(Core_StructTypeDesc * str);
PXZ_EXPORTED void Core_StructTypeDesc_free(Core_StructTypeDesc * str);
typedef struct {
   Core_String name;
   Core_String type;
   Core_String defaultValue;
   Core_String description;
} Core_SelType;

PXZ_EXPORTED void Core_SelType_init(Core_SelType * str);
PXZ_EXPORTED void Core_SelType_free(Core_SelType * str);
typedef struct {
   size_t size;
   Core_SelType * list;
} Core_SelTypeList;

PXZ_EXPORTED void Core_SelTypeList_init(Core_SelTypeList * list, size_t size = 0);
PXZ_EXPORTED void Core_SelTypeList_free(Core_SelTypeList * list);
typedef struct {
   Core_SelTypeList types;
} Core_SelectTypeDesc;

PXZ_EXPORTED void Core_SelectTypeDesc_init(Core_SelectTypeDesc * str);
PXZ_EXPORTED void Core_SelectTypeDesc_free(Core_SelectTypeDesc * str);
struct Core_TypeDescDef {
   Core_None baseType;
   Core_AliasTypeDesc aliasType;
   Core_EnumTypeDesc enumType;
   Core_ListTypeDesc listType;
   Core_ArrayTypeDesc arrayType;
   Core_StructTypeDesc structType;
   Core_SelectTypeDesc selectType;
   typedef enum {
      UNKNOWN=0,
      BASETYPE,
      ALIASTYPE,
      ENUMTYPE,
      LISTTYPE,
      ARRAYTYPE,
      STRUCTTYPE,
      SELECTTYPE
   } Type;

   Type _type; 
};

PXZ_EXPORTED void Core_TypeDescDef_init(Core_TypeDescDef * sel);
PXZ_EXPORTED void Core_TypeDescDef_free(Core_TypeDescDef * sel);

typedef struct {
   Core_String name;
   Core_String module;
   Core_TypeDescType type;
   Core_String description;
   Core_TypeDescDef definition;
} Core_TypeDesc;

PXZ_EXPORTED void Core_TypeDesc_init(Core_TypeDesc * str);
PXZ_EXPORTED void Core_TypeDesc_free(Core_TypeDesc * str);
typedef struct {
   Core_String name;
   Core_String value;
   Core_TypeDesc type;
   Core_String description;
} Core_ConstantDesc;

PXZ_EXPORTED void Core_ConstantDesc_init(Core_ConstantDesc * str);
PXZ_EXPORTED void Core_ConstantDesc_free(Core_ConstantDesc * str);
typedef struct {
   size_t size;
   Core_ConstantDesc * list;
} Core_ConstantDescList;

PXZ_EXPORTED void Core_ConstantDescList_init(Core_ConstantDescList * list, size_t size = 0);
PXZ_EXPORTED void Core_ConstantDescList_free(Core_ConstantDescList * list);
typedef struct {
   Core_Int year;
   Core_Int month;
   Core_Int day;
} Core_Date;

PXZ_EXPORTED void Core_Date_init(Core_Date * str);
PXZ_EXPORTED void Core_Date_free(Core_Date * str);
typedef Core_String Core_DirectoryPath;

typedef struct {
   size_t size;
   Core_Double * list;
} Core_DoubleList;

PXZ_EXPORTED void Core_DoubleList_init(Core_DoubleList * list, size_t size = 0);
PXZ_EXPORTED void Core_DoubleList_free(Core_DoubleList * list);
typedef struct {
   size_t size;
   Core_DoubleList * list;
} Core_DoubleListList;

PXZ_EXPORTED void Core_DoubleListList_init(Core_DoubleListList * list, size_t size = 0);
PXZ_EXPORTED void Core_DoubleListList_free(Core_DoubleListList * list);
typedef Core_Ident Core_Entity;

typedef struct {
   size_t size;
   Core_Entity * list;
} Core_EntityList;

PXZ_EXPORTED void Core_EntityList_init(Core_EntityList * list, size_t size = 0);
PXZ_EXPORTED void Core_EntityList_free(Core_EntityList * list);
typedef struct {
   size_t size;
   Core_EntityList * list;
} Core_EntityListList;

PXZ_EXPORTED void Core_EntityListList_init(Core_EntityListList * list, size_t size = 0);
PXZ_EXPORTED void Core_EntityListList_free(Core_EntityListList * list);
typedef Core_UInt Core_EntityType;

typedef struct {
   Core_String name;
   Core_IntList values;
   Core_StringList labels;
} Core_EnumPropertyInfo;

PXZ_EXPORTED void Core_EnumPropertyInfo_init(Core_EnumPropertyInfo * str);
PXZ_EXPORTED void Core_EnumPropertyInfo_free(Core_EnumPropertyInfo * str);
typedef struct {
   Core_String name;
   Core_TypeDesc type;
   Core_String description;
   Core_Bool optional;
   Core_String defaultValue;
   Core_String disableValue;
   Core_StringPairList attributes;
   Core_StringPairList predefinedValues;
} Core_ParameterDesc;

PXZ_EXPORTED void Core_ParameterDesc_init(Core_ParameterDesc * str);
PXZ_EXPORTED void Core_ParameterDesc_free(Core_ParameterDesc * str);
typedef struct {
   size_t size;
   Core_ParameterDesc * list;
} Core_ParameterDescList;

PXZ_EXPORTED void Core_ParameterDescList_init(Core_ParameterDescList * list, size_t size = 0);
PXZ_EXPORTED void Core_ParameterDescList_free(Core_ParameterDescList * list);
typedef struct {
   Core_String module;
   Core_String name;
   Core_String description;
   Core_ParameterDescList parameters;
} Core_EventDesc;

PXZ_EXPORTED void Core_EventDesc_init(Core_EventDesc * str);
PXZ_EXPORTED void Core_EventDesc_free(Core_EventDesc * str);
typedef struct {
   size_t size;
   Core_EventDesc * list;
} Core_EventDescList;

PXZ_EXPORTED void Core_EventDescList_init(Core_EventDescList * list, size_t size = 0);
PXZ_EXPORTED void Core_EventDescList_free(Core_EventDescList * list);
typedef Core_String Core_FilePath;

typedef struct {
   size_t size;
   Core_FilePath * list;
} Core_FilePathList;

PXZ_EXPORTED void Core_FilePathList_init(Core_FilePathList * list, size_t size = 0);
PXZ_EXPORTED void Core_FilePathList_free(Core_FilePathList * list);
typedef struct {
   Core_String name;
   Core_StringList extensions;
} Core_Format;

PXZ_EXPORTED void Core_Format_init(Core_Format * str);
PXZ_EXPORTED void Core_Format_free(Core_Format * str);
typedef struct {
   size_t size;
   Core_Format * list;
} Core_FormatList;

PXZ_EXPORTED void Core_FormatList_init(Core_FormatList * list, size_t size = 0);
PXZ_EXPORTED void Core_FormatList_free(Core_FormatList * list);
typedef enum {
 Core_Stability_DEVELOPMENT = 0,
 Core_Stability_EXPERIMENTAL = 1,
 Core_Stability_BETA = 2,
 Core_Stability_STABLE = 3,
 Core_Stability_DEPRECATED = 4,
 Core_Stability_OBSOLETE = 5,
} Core_Stability;

typedef struct {
   Core_String name;
   Core_String module;
   Core_ParameterDescList parameters;
   Core_ParameterDescList returns;
   Core_String description;
   Core_Stability stability;
} Core_FunctionDesc;

PXZ_EXPORTED void Core_FunctionDesc_init(Core_FunctionDesc * str);
PXZ_EXPORTED void Core_FunctionDesc_free(Core_FunctionDesc * str);
typedef struct {
   size_t size;
   Core_FunctionDesc * list;
} Core_FunctionDescList;

PXZ_EXPORTED void Core_FunctionDescList_init(Core_FunctionDescList * list, size_t size = 0);
PXZ_EXPORTED void Core_FunctionDescList_free(Core_FunctionDescList * list);
typedef struct {
   Core_String name;
   Core_String description;
   Core_FunctionDescList functions;
} Core_GroupDesc;

PXZ_EXPORTED void Core_GroupDesc_init(Core_GroupDesc * str);
PXZ_EXPORTED void Core_GroupDesc_free(Core_GroupDesc * str);
typedef struct {
   size_t size;
   Core_GroupDesc * list;
} Core_GroupDescList;

PXZ_EXPORTED void Core_GroupDescList_init(Core_GroupDescList * list, size_t size = 0);
PXZ_EXPORTED void Core_GroupDescList_free(Core_GroupDescList * list);
typedef struct {
   Core_Ident key;
   Core_Ident value;
} Core_IdentPair;

PXZ_EXPORTED void Core_IdentPair_init(Core_IdentPair * str);
PXZ_EXPORTED void Core_IdentPair_free(Core_IdentPair * str);
typedef struct {
   size_t size;
   Core_IdentPair * list;
} Core_IdentPairList;

PXZ_EXPORTED void Core_IdentPairList_init(Core_IdentPairList * list, size_t size = 0);
PXZ_EXPORTED void Core_IdentPairList_free(Core_IdentPairList * list);
typedef enum {
 Core_InheritableBool_False = 0,
 Core_InheritableBool_True = 1,
 Core_InheritableBool_Inherited = 2,
} Core_InheritableBool;

typedef struct {
   size_t size;
   Core_InheritableBool * list;
} Core_InheritableBoolList;

PXZ_EXPORTED void Core_InheritableBoolList_init(Core_InheritableBoolList * list, size_t size = 0);
PXZ_EXPORTED void Core_InheritableBoolList_free(Core_InheritableBoolList * list);
typedef struct {
   size_t size;
   Core_IntList * list;
} Core_IntListList;

PXZ_EXPORTED void Core_IntListList_init(Core_IntListList * list, size_t size = 0);
PXZ_EXPORTED void Core_IntListList_free(Core_IntListList * list);
typedef struct {
   Core_String version;
   Core_String customerName;
   Core_String customerCompany;
   Core_String customerEmail;
   Core_Boolean isFloating;
   Core_Boolean isRevocable;
   Core_Date startDate;
   Core_Date endDate;
   Core_StringList invalidReasons;
} Core_LicenseInfos;

PXZ_EXPORTED void Core_LicenseInfos_init(Core_LicenseInfos * str);
PXZ_EXPORTED void Core_LicenseInfos_free(Core_LicenseInfos * str);
typedef struct {
   size_t size;
   Core_TypeDesc * list;
} Core_TypeDescList;

PXZ_EXPORTED void Core_TypeDescList_init(Core_TypeDescList * list, size_t size = 0);
PXZ_EXPORTED void Core_TypeDescList_free(Core_TypeDescList * list);
typedef struct {
   Core_String name;
   Core_String description;
   Core_String author;
   Core_GroupDescList groups;
   Core_TypeDescList types;
   Core_ConstantDescList constants;
   Core_StringList dependencies;
   Core_Stability stability;
} Core_ModuleDesc;

PXZ_EXPORTED void Core_ModuleDesc_init(Core_ModuleDesc * str);
PXZ_EXPORTED void Core_ModuleDesc_free(Core_ModuleDesc * str);
typedef struct {
   size_t size;
   Core_ModuleDesc * list;
} Core_ModuleDescList;

PXZ_EXPORTED void Core_ModuleDescList_init(Core_ModuleDescList * list, size_t size = 0);
PXZ_EXPORTED void Core_ModuleDescList_free(Core_ModuleDescList * list);
typedef Core_DirectoryPath Core_OutputDirectoryPath;

typedef Core_FilePath Core_OutputFilePath;

typedef void (*Core_ParallelCallback)(Core_Ptr data);

typedef Core_Ptr Core_ParallelSession;

typedef Core_String Core_Password;

typedef Core_Double Core_Percent;

typedef enum {
 Core_PropertyType_STRING = 0,
 Core_PropertyType_STRINGLIST = 1,
 Core_PropertyType_INTEGER = 2,
 Core_PropertyType_BOUNDED_INTEGER = 3,
 Core_PropertyType_UNSIGNED_INTEGER = 4,
 Core_PropertyType_SHORT = 5,
 Core_PropertyType_UNSIGNED_SHORT = 6,
 Core_PropertyType_IDENTIFIER = 7,
 Core_PropertyType_IDENTIFIERLIST = 8,
 Core_PropertyType_BOOLEAN = 9,
 Core_PropertyType_INHERITABLEBOOL = 10,
 Core_PropertyType_REAL = 11,
 Core_PropertyType_REALLIST = 12,
 Core_PropertyType_COEFF = 13,
 Core_PropertyType_PERCENT = 14,
 Core_PropertyType_COLOR = 15,
 Core_PropertyType_COLOR_ALPHA = 16,
 Core_PropertyType_DATE = 17,
 Core_PropertyType_ANGLE = 18,
 Core_PropertyType_DISTANCE = 19,
 Core_PropertyType_MACHINEID = 20,
 Core_PropertyType_MACHINEIDLIST = 21,
 Core_PropertyType_SOCKET_PROTOCOL = 22,
 Core_PropertyType_POINT2 = 23,
 Core_PropertyType_POINT3 = 24,
 Core_PropertyType_AXIS3 = 25,
 Core_PropertyType_VECTOR3 = 26,
 Core_PropertyType_POINT3LIST = 27,
 Core_PropertyType_POINT4 = 28,
 Core_PropertyType_POINT4LIST = 29,
 Core_PropertyType_MATRIX4 = 30,
 Core_PropertyType_QUATERNION = 31,
 Core_PropertyType_BOUNDS1D = 32,
 Core_PropertyType_BOUNDS2D = 33,
 Core_PropertyType_TEXTUREDEF = 34,
 Core_PropertyType_COLORORTEXTURE = 35,
 Core_PropertyType_COEFFORTEXTURE = 36,
 Core_PropertyType_ENTITY = 37,
 Core_PropertyType_FILEPATH = 38,
 Core_PropertyType_ENUM = 39,
 Core_PropertyType_UNKNOWN = 40,
} Core_PropertyType;

typedef struct {
   Core_String name;
   Core_PropertyType type;
   Core_Int subType;
   Core_String value;
   Core_Boolean user;
   Core_String defaultValue;
   Core_Boolean editable;
   Core_Boolean isSet;
   Core_Boolean delegated;
   Core_Entity delegatedOwnerEntity;
   Core_String group;
   Core_String description;
} Core_PropertyInfo;

PXZ_EXPORTED void Core_PropertyInfo_init(Core_PropertyInfo * str);
PXZ_EXPORTED void Core_PropertyInfo_free(Core_PropertyInfo * str);
typedef struct {
   size_t size;
   Core_PropertyInfo * list;
} Core_PropertyInfoList;

PXZ_EXPORTED void Core_PropertyInfoList_init(Core_PropertyInfoList * list, size_t size = 0);
PXZ_EXPORTED void Core_PropertyInfoList_free(Core_PropertyInfoList * list);
typedef struct {
   size_t size;
   Core_PropertyInfoList * list;
} Core_PropertyInfoListList;

PXZ_EXPORTED void Core_PropertyInfoListList_init(Core_PropertyInfoListList * list, size_t size = 0);
PXZ_EXPORTED void Core_PropertyInfoListList_free(Core_PropertyInfoListList * list);
typedef struct {
   size_t size;
   Core_PropertyType * list;
} Core_PropertyTypeList;

PXZ_EXPORTED void Core_PropertyTypeList_init(Core_PropertyTypeList * list, size_t size = 0);
PXZ_EXPORTED void Core_PropertyTypeList_free(Core_PropertyTypeList * list);
typedef struct {
   size_t size;
   Core_Ptr * list;
} Core_PtrList;

PXZ_EXPORTED void Core_PtrList_init(Core_PtrList * list, size_t size = 0);
PXZ_EXPORTED void Core_PtrList_free(Core_PtrList * list);
typedef Core_Double Core_Real;

typedef Core_String Core_Regex;

typedef struct {
   size_t size;
   Core_StringPairList * list;
} Core_StringPairListList;

PXZ_EXPORTED void Core_StringPairListList_init(Core_StringPairListList * list, size_t size = 0);
PXZ_EXPORTED void Core_StringPairListList_free(Core_StringPairListList * list);
typedef struct {
   size_t size;
   Core_ULong * list;
} Core_ULongList;

PXZ_EXPORTED void Core_ULongList_init(Core_ULongList * list, size_t size = 0);
PXZ_EXPORTED void Core_ULongList_free(Core_ULongList * list);
typedef enum {
 Core_Verbose_ERR = 0,
 Core_Verbose_WARNING = 1,
 Core_Verbose_INFO = 2,
 Core_Verbose_SCRIPT = 5,
} Core_Verbose;

typedef struct {
   Core_Ident id;
   Core_String product;
   Core_Date validity;
   Core_Int count;
   Core_Int inUse;
   Core_Int revoke;
   Core_String description;
   Core_Bool onMachine;
   Core_Bool current;
} Core_WebLicenseInfo;

PXZ_EXPORTED void Core_WebLicenseInfo_init(Core_WebLicenseInfo * str);
PXZ_EXPORTED void Core_WebLicenseInfo_free(Core_WebLicenseInfo * str);
typedef struct {
   size_t size;
   Core_WebLicenseInfo * list;
} Core_WebLicenseInfoList;

PXZ_EXPORTED void Core_WebLicenseInfoList_init(Core_WebLicenseInfoList * list, size_t size = 0);
PXZ_EXPORTED void Core_WebLicenseInfoList_free(Core_WebLicenseInfoList * list);
// ----------------------------------------------------
// Constants
// ----------------------------------------------------

inline Core_Double Epsilon() { return 0; }
inline Core_Double EpsilonSquare() { return 0; }
inline Core_Double HalfPi() { return 0; }
inline Core_Double Infinity() { return 0; }
inline Core_Double OneDegree() { return 0; }
inline Core_Double Pi() { return 0; }
inline Core_Double TwoPi() { return 0; }


#endif
