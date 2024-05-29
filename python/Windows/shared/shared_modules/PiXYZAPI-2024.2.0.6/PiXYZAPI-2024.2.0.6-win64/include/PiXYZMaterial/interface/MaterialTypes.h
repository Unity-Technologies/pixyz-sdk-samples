// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_MATERIAL_INTERFACE_MATERIALTYPES_H_
#define _PXZ_MATERIAL_INTERFACE_MATERIALTYPES_H_

#include <PiXYZCore/interface/InterfaceBase.h>
#include <PiXYZCore/interface/CoreTypes.h>
#include <PiXYZGeom/interface/GeomTypes.h>
#include <functional> 

PXZ_MODULE_BEGIN(MaterialI)

typedef CoreI::Entity Image;

PXZ_EXPORTED extern const CoreI::EntityType ImageEntityType;

struct Texture {
   Image image;
   CoreI::Int channel;
   GeomI::Point2 offset;
   GeomI::Point2 tilling;
   Texture(Image _image = 0, CoreI::Int _channel = 0, GeomI::Point2 _offset = GeomI::Point2(), GeomI::Point2 _tilling = GeomI::Point2()) : image(_image), channel(_channel), offset(_offset), tilling(_tilling) {}
};

struct CoeffOrTexture {
   typedef enum {
      UNKNOWN=0,
      COEFF,
      TEXTURE
   } Type;
   Type _type; 
   CoreI::Coeff coeff;
   Texture texture;
   CoeffOrTexture() : _type(UNKNOWN) {}
   CoeffOrTexture(const CoreI::Coeff & v) : _type(COEFF), coeff(v) {}
   CoeffOrTexture(const Texture & v) : _type(TEXTURE), texture(v) {}
};
struct ColorMaterialInfos {
   CoreI::String name;
   CoreI::ColorAlpha color;
   ColorMaterialInfos(CoreI::String _name = "", CoreI::ColorAlpha _color = CoreI::ColorAlpha()) : name(_name), color(_color) {}
};

struct ColorOrTexture {
   typedef enum {
      UNKNOWN=0,
      COLOR,
      TEXTURE
   } Type;
   Type _type; 
   CoreI::Color color;
   Texture texture;
   ColorOrTexture() : _type(UNKNOWN) {}
   ColorOrTexture(const CoreI::Color & v) : _type(COLOR), color(v) {}
   ColorOrTexture(const Texture & v) : _type(TEXTURE), texture(v) {}
};
typedef CoreI::Entity CustomMaterialPattern;

PXZ_EXPORTED extern const CoreI::EntityType CustomMaterialPatternEntityType;

class ImageChangeType {
public:
   typedef enum {
   ADDED = 0,
   REMOVED = 1,
   CHANGED = 2,
   RESET = 3,
   REPLACED = 4
   } Type;
private:
   Type _value;
public:
   ImageChangeType(Type val = ADDED) : _value(val) {}
   ImageChangeType & operator=(Type val) { _value = val; return *this; }
   ImageChangeType(const CoreI::Int& val) : _value((Type)val) {}
   ImageChangeType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct ImageDefinition {
   Image id;
   CoreI::String name;
   CoreI::Int width;
   CoreI::Int height;
   CoreI::Int bitsPerComponent;
   CoreI::Int componentsCount;
   CoreI::ByteList data;
   ImageDefinition(Image _id = 0, CoreI::String _name = "", CoreI::Int _width = 0, CoreI::Int _height = 0, CoreI::Int _bitsPerComponent = 0, CoreI::Int _componentsCount = 0, CoreI::ByteList _data = CoreI::ByteList()) : id(_id), name(_name), width(_width), height(_height), bitsPerComponent(_bitsPerComponent), componentsCount(_componentsCount), data(_data) {}
};

typedef CoreI::List<ImageDefinition> ImageDefinitionList;

typedef CoreI::List<Image> ImageList;

struct ImpostorMaterialInfos {
   CoreI::String name;
   ColorOrTexture albedo;
   ColorOrTexture normal;
   CoeffOrTexture roughness;
   CoeffOrTexture ao;
   CoeffOrTexture depth;
   CoreI::Int nbFrames;
   CoreI::Boolean fullOcta;
   CoreI::Double octaDiameter;
   CoreI::Int linearSteps;
   CoreI::Int binarySteps;
   ImpostorMaterialInfos(CoreI::String _name = "", ColorOrTexture _albedo = ColorOrTexture(), ColorOrTexture _normal = ColorOrTexture(), CoeffOrTexture _roughness = CoeffOrTexture(), CoeffOrTexture _ao = CoeffOrTexture(), CoeffOrTexture _depth = CoeffOrTexture(), CoreI::Int _nbFrames = 0, CoreI::Boolean _fullOcta = 1, CoreI::Double _octaDiameter = 1.0, CoreI::Int _linearSteps = 30, CoreI::Int _binarySteps = 1) : name(_name), albedo(_albedo), normal(_normal), roughness(_roughness), ao(_ao), depth(_depth), nbFrames(_nbFrames), fullOcta(_fullOcta), octaDiameter(_octaDiameter), linearSteps(_linearSteps), binarySteps(_binarySteps) {}
};

typedef CoreI::Entity Material;

PXZ_EXPORTED extern const CoreI::EntityType MaterialEntityType;

class MaterialChangeType {
public:
   typedef enum {
   CHANGED = 0,
   PATTERN_CHANGED = 1,
   RELOAD = 2,
   DESTROYED = 3,
   ICON_CHANGED = 4,
   ADDED = 5,
   REMOVED = 6
   } Type;
private:
   Type _value;
public:
   MaterialChangeType(Type val = CHANGED) : _value(val) {}
   MaterialChangeType & operator=(Type val) { _value = val; return *this; }
   MaterialChangeType(const CoreI::Int& val) : _value((Type)val) {}
   MaterialChangeType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct MaterialDefinition {
   CoreI::String name;
   Material id;
   ColorOrTexture albedo;
   ColorOrTexture normal;
   CoeffOrTexture metallic;
   CoeffOrTexture roughness;
   CoeffOrTexture ao;
   CoeffOrTexture opacity;
   ColorOrTexture emissive;
   MaterialDefinition(CoreI::String _name = "", Material _id = 0, ColorOrTexture _albedo = ColorOrTexture(), ColorOrTexture _normal = ColorOrTexture(), CoeffOrTexture _metallic = CoeffOrTexture(), CoeffOrTexture _roughness = CoeffOrTexture(), CoeffOrTexture _ao = CoeffOrTexture(), CoeffOrTexture _opacity = CoeffOrTexture(), ColorOrTexture _emissive = ColorOrTexture()) : name(_name), id(_id), albedo(_albedo), normal(_normal), metallic(_metallic), roughness(_roughness), ao(_ao), opacity(_opacity), emissive(_emissive) {}
};

typedef CoreI::List<MaterialDefinition> MaterialDefinitionList;

typedef CoreI::List<Material> MaterialList;

typedef CoreI::List<MaterialList> MaterialListList;

class MaterialPatternType {
public:
   typedef enum {
   CUSTOM = 0,
   COLOR = 1,
   STANDARD = 2,
   UNLIT_TEXTURE = 3,
   PBR = 4,
   IMPOSTOR = 5
   } Type;
private:
   Type _value;
public:
   MaterialPatternType(Type val = CUSTOM) : _value(val) {}
   MaterialPatternType & operator=(Type val) { _value = val; return *this; }
   MaterialPatternType(const CoreI::Int& val) : _value((Type)val) {}
   MaterialPatternType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
typedef CoreI::Ident MaterialUserData;

struct PBRMaterialInfos {
   CoreI::String name;
   ColorOrTexture albedo;
   ColorOrTexture normal;
   CoeffOrTexture metallic;
   CoeffOrTexture roughness;
   CoeffOrTexture ao;
   CoeffOrTexture opacity;
   PBRMaterialInfos(CoreI::String _name = "", ColorOrTexture _albedo = ColorOrTexture(), ColorOrTexture _normal = ColorOrTexture(), CoeffOrTexture _metallic = CoeffOrTexture(), CoeffOrTexture _roughness = CoeffOrTexture(), CoeffOrTexture _ao = CoeffOrTexture(), CoeffOrTexture _opacity = CoeffOrTexture()) : name(_name), albedo(_albedo), normal(_normal), metallic(_metallic), roughness(_roughness), ao(_ao), opacity(_opacity) {}
};

class ShaderUniformType {
public:
   typedef enum {
   INTEGER = 2,
   BOOLEAN = 9,
   REAL = 11,
   COEFF = 13,
   POINT3 = 23,
   POINT2 = 22,
   COLOR = 15,
   COLOR_ALPHA = 16,
   TEXTURE = 34,
   COLORORTEXTURE = 35,
   COEFFORTEXTURE = 36
   } Type;
private:
   Type _value;
public:
   ShaderUniformType(Type val = INTEGER) : _value(val) {}
   ShaderUniformType & operator=(Type val) { _value = val; return *this; }
   ShaderUniformType(const CoreI::Int& val) : _value((Type)val) {}
   ShaderUniformType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct StandardMaterialInfos {
   CoreI::String name;
   ColorOrTexture diffuse;
   ColorOrTexture specular;
   ColorOrTexture ambient;
   ColorOrTexture emissive;
   CoreI::Coeff shininess;
   CoreI::Coeff transparency;
   StandardMaterialInfos(CoreI::String _name = "", ColorOrTexture _diffuse = ColorOrTexture(), ColorOrTexture _specular = ColorOrTexture(), ColorOrTexture _ambient = ColorOrTexture(), ColorOrTexture _emissive = ColorOrTexture(), CoreI::Coeff _shininess = 0.0, CoreI::Coeff _transparency = 0.0) : name(_name), diffuse(_diffuse), specular(_specular), ambient(_ambient), emissive(_emissive), shininess(_shininess), transparency(_transparency) {}
};

struct UnlitTextureMaterialInfos {
   CoreI::String name;
   Texture texture;
   UnlitTextureMaterialInfos(CoreI::String _name = "", Texture _texture = Texture()) : name(_name), texture(_texture) {}
};

typedef struct {
   CoreI::Int width;
   CoreI::Int height;
} getImageSizeReturn;

typedef struct {
   GeomI::Point3List points;
   GeomI::Point2List uvs;
   GeomI::Vector3 normal;
   Material material;
   CoreI::Double offset;
} getPointsAndMaterialFromTextReturn;

typedef struct {
   ImageList mappedMaps;
   CoreI::IntListList newToOldMapIndices;
} remapIndexMapReturn;


PXZ_MODULE_END

#endif
