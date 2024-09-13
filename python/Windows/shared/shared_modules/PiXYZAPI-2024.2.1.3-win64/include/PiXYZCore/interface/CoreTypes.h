// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_CORE_INTERFACE_CORETYPES_H_
#define _PXZ_CORE_INTERFACE_CORETYPES_H_

#include <PiXYZCore/interface/InterfaceBase.h>
#include <functional> 

PXZ_MODULE_BEGIN(CoreI)

struct AliasTypeDesc {
   String alias;
   explicit AliasTypeDesc(String _alias = "") : alias(_alias) {}
};

struct ArrayTypeDesc {
   String arrayType;
   Int size;
   explicit ArrayTypeDesc(String _arrayType = "", Int _size = 0) : arrayType(_arrayType), size(_size) {}
};

struct StringPair {
   String key;
   String value;
   explicit StringPair(String _key = "", String _value = "") : key(_key), value(_value) {}
};

typedef CoreI::List<StringPair> StringPairList;

struct AutoValueReturn {
   StringPairList values;
   String message;
   explicit AutoValueReturn(StringPairList _values = StringPairList(), String _message = "") : values(_values), message(_message) {}
};

typedef CoreI::List<Bool> BoolList;

typedef Bool Boolean;

struct BoundedInteger {
   Int value;
   Int min;
   Int max;
   explicit BoundedInteger(Int _value = 0, Int _min = 0, Int _max = 0) : value(_value), min(_min), max(_max) {}
};

typedef CoreI::List<Byte> ByteList;

typedef std::function<CoreI::ByteList(const String & message, const ByteList & key)> CaptchaCallback;

typedef Double Coeff;

struct Color {
   Double r;
   Double g;
   Double b;
   explicit Color(Double _r = 1, Double _g = 1, Double _b = 1) : r(_r), g(_g), b(_b) {}
};

struct ColorAlpha {
   Double r;
   Double g;
   Double b;
   Double a;
   explicit ColorAlpha(Double _r = 1, Double _g = 1, Double _b = 1, Double _a = 1) : r(_r), g(_g), b(_b), a(_a) {}
};

typedef CoreI::List<ColorAlpha> ColorAlphaList;

typedef CoreI::List<Color> ColorList;

class TypeDescType {
public:
   typedef enum {
   UNKNOWN = 0,
   BASE = 1,
   ALIAS = 2,
   ENUM = 3,
   LIST = 4,
   STRUCT = 5,
   ARRAY = 6,
   SELECT = 7,
   FUNCPTR = 8
   } Type;
private:
   Type _value;
public:
   TypeDescType(Type val = UNKNOWN) : _value(val) {}
   TypeDescType & operator=(Type val) { _value = val; return *this; }
   TypeDescType(const CoreI::Int& val) : _value((Type)val) {}
   TypeDescType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
typedef CoreI::List<Int> IntList;

typedef CoreI::List<String> StringList;

struct EnumTypeDesc {
   IntList values;
   StringList labels;
   String valueType;
   explicit EnumTypeDesc(IntList _values = IntList(), StringList _labels = StringList(), String _valueType = "") : values(_values), labels(_labels), valueType(_valueType) {}
};

struct ListTypeDesc {
   String listType;
   explicit ListTypeDesc(String _listType = "") : listType(_listType) {}
};

struct Field {
   String name;
   String type;
   String module;
   String defaultValue;
   String description;
   String disableValue;
   StringPairList predefinedValues;
   explicit Field(String _name = "", String _type = "", String _module = "", String _defaultValue = "", String _description = "", String _disableValue = "", StringPairList _predefinedValues = StringPairList()) : name(_name), type(_type), module(_module), defaultValue(_defaultValue), description(_description), disableValue(_disableValue), predefinedValues(_predefinedValues) {}
};

typedef CoreI::List<Field> FieldList;

struct StructTypeDesc {
   FieldList fields;
   explicit StructTypeDesc(FieldList _fields = FieldList()) : fields(_fields) {}
};

struct SelType {
   String name;
   String type;
   String defaultValue;
   String description;
   explicit SelType(String _name = "", String _type = "", String _defaultValue = "", String _description = "") : name(_name), type(_type), defaultValue(_defaultValue), description(_description) {}
};

typedef CoreI::List<SelType> SelTypeList;

struct SelectTypeDesc {
   SelTypeList types;
   explicit SelectTypeDesc(SelTypeList _types = SelTypeList()) : types(_types) {}
};

struct TypeDescDef {
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
   None baseType;
   AliasTypeDesc aliasType;
   EnumTypeDesc enumType;
   ListTypeDesc listType;
   ArrayTypeDesc arrayType;
   StructTypeDesc structType;
   SelectTypeDesc selectType;
   TypeDescDef() : _type(UNKNOWN) {}
   TypeDescDef(const None & v) : _type(BASETYPE), baseType(v) {}
   TypeDescDef(const AliasTypeDesc & v) : _type(ALIASTYPE), aliasType(v) {}
   TypeDescDef(const EnumTypeDesc & v) : _type(ENUMTYPE), enumType(v) {}
   TypeDescDef(const ListTypeDesc & v) : _type(LISTTYPE), listType(v) {}
   TypeDescDef(const ArrayTypeDesc & v) : _type(ARRAYTYPE), arrayType(v) {}
   TypeDescDef(const StructTypeDesc & v) : _type(STRUCTTYPE), structType(v) {}
   TypeDescDef(const SelectTypeDesc & v) : _type(SELECTTYPE), selectType(v) {}
};
struct TypeDesc {
   String name;
   String module;
   TypeDescType type;
   String description;
   TypeDescDef definition;
   explicit TypeDesc(String _name = "", String _module = "", TypeDescType _type = TypeDescType::UNKNOWN, String _description = "", TypeDescDef _definition = TypeDescDef()) : name(_name), module(_module), type(_type), description(_description), definition(_definition) {}
};

struct ConstantDesc {
   String name;
   String value;
   TypeDesc type;
   String description;
   explicit ConstantDesc(String _name = "", String _value = "", TypeDesc _type = TypeDesc(), String _description = "") : name(_name), value(_value), type(_type), description(_description) {}
};

typedef CoreI::List<ConstantDesc> ConstantDescList;

struct Date {
   Int year;
   Int month;
   Int day;
   explicit Date(Int _year = 2015, Int _month = 1, Int _day = 1) : year(_year), month(_month), day(_day) {}
};

typedef String DirectoryPath;

typedef CoreI::List<Double> DoubleList;

typedef CoreI::List<DoubleList> DoubleListList;

typedef UInt EntityType;

typedef Ident Entity;

PXZ_EXPORTED extern const CoreI::EntityType EntityEntityType;

typedef CoreI::List<Entity> EntityList;

typedef CoreI::List<EntityList> EntityListList;

struct EnumPropertyInfo {
   String name;
   IntList values;
   StringList labels;
   explicit EnumPropertyInfo(String _name = "", IntList _values = IntList(), StringList _labels = StringList()) : name(_name), values(_values), labels(_labels) {}
};

struct ParameterDesc {
   String name;
   TypeDesc type;
   String description;
   Bool optional;
   String defaultValue;
   String disableValue;
   StringPairList attributes;
   StringPairList predefinedValues;
   explicit ParameterDesc(String _name = "", TypeDesc _type = TypeDesc(), String _description = "", Bool _optional = false, String _defaultValue = "", String _disableValue = "", StringPairList _attributes = StringPairList(), StringPairList _predefinedValues = StringPairList()) : name(_name), type(_type), description(_description), optional(_optional), defaultValue(_defaultValue), disableValue(_disableValue), attributes(_attributes), predefinedValues(_predefinedValues) {}
};

typedef CoreI::List<ParameterDesc> ParameterDescList;

struct EventDesc {
   String module;
   String name;
   String description;
   ParameterDescList parameters;
   explicit EventDesc(String _module = "", String _name = "", String _description = "", ParameterDescList _parameters = ParameterDescList()) : module(_module), name(_name), description(_description), parameters(_parameters) {}
};

typedef CoreI::List<EventDesc> EventDescList;

typedef String FilePath;

typedef CoreI::List<FilePath> FilePathList;

struct Format {
   String name;
   StringList extensions;
   explicit Format(String _name = "", StringList _extensions = StringList()) : name(_name), extensions(_extensions) {}
};

typedef CoreI::List<Format> FormatList;

class Stability {
public:
   typedef enum {
   DEVELOPMENT = 0,
   EXPERIMENTAL = 1,
   BETA = 2,
   STABLE = 3,
   DEPRECATED = 4,
   OBSOLETE = 5
   } Type;
private:
   Type _value;
public:
   Stability(Type val = DEVELOPMENT) : _value(val) {}
   Stability & operator=(Type val) { _value = val; return *this; }
   Stability(const CoreI::Int& val) : _value((Type)val) {}
   Stability & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct FunctionDesc {
   String name;
   String module;
   ParameterDescList parameters;
   ParameterDescList returns;
   String description;
   Stability stability;
   explicit FunctionDesc(String _name = "", String _module = "", ParameterDescList _parameters = ParameterDescList(), ParameterDescList _returns = ParameterDescList(), String _description = "", Stability _stability = Stability::STABLE) : name(_name), module(_module), parameters(_parameters), returns(_returns), description(_description), stability(_stability) {}
};

typedef CoreI::List<FunctionDesc> FunctionDescList;

struct GroupDesc {
   String name;
   String description;
   FunctionDescList functions;
   explicit GroupDesc(String _name = "", String _description = "", FunctionDescList _functions = FunctionDescList()) : name(_name), description(_description), functions(_functions) {}
};

typedef CoreI::List<GroupDesc> GroupDescList;

struct IdentPair {
   Ident key;
   Ident value;
   explicit IdentPair(Ident _key = 0, Ident _value = 0) : key(_key), value(_value) {}
};

typedef CoreI::List<IdentPair> IdentPairList;

class InheritableBool {
public:
   typedef enum {
   False = 0,
   True = 1,
   Inherited = 2
   } Type;
private:
   Type _value;
public:
   InheritableBool(Type val = False) : _value(val) {}
   InheritableBool & operator=(Type val) { _value = val; return *this; }
   InheritableBool(const CoreI::Int& val) : _value((Type)val) {}
   InheritableBool & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
typedef CoreI::List<InheritableBool> InheritableBoolList;

typedef CoreI::List<IntList> IntListList;

struct LicenseInfos {
   String version;
   String customerName;
   String customerCompany;
   String customerEmail;
   Boolean isFloating;
   Boolean isRevocable;
   Date startDate;
   Date endDate;
   StringList invalidReasons;
   explicit LicenseInfos(String _version = "", String _customerName = "", String _customerCompany = "", String _customerEmail = "", Boolean _isFloating = false, Boolean _isRevocable = false, Date _startDate = Date(), Date _endDate = Date(), StringList _invalidReasons = StringList()) : version(_version), customerName(_customerName), customerCompany(_customerCompany), customerEmail(_customerEmail), isFloating(_isFloating), isRevocable(_isRevocable), startDate(_startDate), endDate(_endDate), invalidReasons(_invalidReasons) {}
};

typedef CoreI::List<TypeDesc> TypeDescList;

struct ModuleDesc {
   String name;
   String description;
   String author;
   GroupDescList groups;
   TypeDescList types;
   ConstantDescList constants;
   StringList dependencies;
   Stability stability;
   explicit ModuleDesc(String _name = "", String _description = "", String _author = "", GroupDescList _groups = GroupDescList(), TypeDescList _types = TypeDescList(), ConstantDescList _constants = ConstantDescList(), StringList _dependencies = StringList(), Stability _stability = Stability::STABLE) : name(_name), description(_description), author(_author), groups(_groups), types(_types), constants(_constants), dependencies(_dependencies), stability(_stability) {}
};

typedef CoreI::List<ModuleDesc> ModuleDescList;

typedef DirectoryPath OutputDirectoryPath;

typedef FilePath OutputFilePath;

typedef std::function<void(const Ptr & data)> ParallelCallback;

typedef Ptr ParallelSession;

typedef String Password;

typedef Double Percent;

class PropertyType {
public:
   typedef enum {
   STRING = 0,
   STRINGLIST = 1,
   INTEGER = 2,
   BOUNDED_INTEGER = 3,
   UNSIGNED_INTEGER = 4,
   SHORT = 5,
   UNSIGNED_SHORT = 6,
   IDENTIFIER = 7,
   IDENTIFIERLIST = 8,
   BOOLEAN = 9,
   INHERITABLEBOOL = 10,
   REAL = 11,
   REALLIST = 12,
   COEFF = 13,
   PERCENT = 14,
   COLOR = 15,
   COLOR_ALPHA = 16,
   DATE = 17,
   ANGLE = 18,
   DISTANCE = 19,
   MACHINEID = 20,
   MACHINEIDLIST = 21,
   SOCKET_PROTOCOL = 22,
   POINT2 = 23,
   POINT3 = 24,
   AXIS3 = 25,
   VECTOR3 = 26,
   POINT3LIST = 27,
   POINT4 = 28,
   POINT4LIST = 29,
   MATRIX4 = 30,
   QUATERNION = 31,
   BOUNDS1D = 32,
   BOUNDS2D = 33,
   TEXTUREDEF = 34,
   COLORORTEXTURE = 35,
   COEFFORTEXTURE = 36,
   ENTITY = 37,
   FILEPATH = 38,
   ENUM = 39,
   UNKNOWN = 40
   } Type;
private:
   Type _value;
public:
   PropertyType(Type val = STRING) : _value(val) {}
   PropertyType & operator=(Type val) { _value = val; return *this; }
   PropertyType(const CoreI::Int& val) : _value((Type)val) {}
   PropertyType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct PropertyInfo {
   String name;
   PropertyType type;
   //! the sub type in only filled when type is 'ENTITY' or 'ENUM'
   Int subType;
   String value;
   Boolean user;
   String defaultValue;
   Boolean editable;
   Boolean isSet;
   Boolean delegated;
   Entity delegatedOwnerEntity;
   String group;
   String description;
   explicit PropertyInfo(String _name = "", PropertyType _type = PropertyType::UNKNOWN, Int _subType = 0, String _value = "", Boolean _user = false, String _defaultValue = "", Boolean _editable = true, Boolean _isSet = false, Boolean _delegated = false, Entity _delegatedOwnerEntity = false, String _group = "", String _description = "") : name(_name), type(_type), subType(_subType), value(_value), user(_user), defaultValue(_defaultValue), editable(_editable), isSet(_isSet), delegated(_delegated), delegatedOwnerEntity(_delegatedOwnerEntity), group(_group), description(_description) {}
};

typedef CoreI::List<PropertyInfo> PropertyInfoList;

typedef CoreI::List<PropertyInfoList> PropertyInfoListList;

typedef CoreI::List<PropertyType> PropertyTypeList;

typedef CoreI::List<Ptr> PtrList;

typedef Double Real;

typedef String Regex;

typedef CoreI::List<StringPairList> StringPairListList;

typedef CoreI::List<ULong> ULongList;

class Verbose {
public:
   typedef enum {
   ERR = 0,
   WARNING = 1,
   INFO = 2,
   SCRIPT = 5
   } Type;
private:
   Type _value;
public:
   Verbose(Type val = ERR) : _value(val) {}
   Verbose & operator=(Type val) { _value = val; return *this; }
   Verbose(const CoreI::Int& val) : _value((Type)val) {}
   Verbose & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct WebLicenseInfo {
   Ident id;
   String product;
   Date validity;
   Int count;
   Int inUse;
   Int revoke;
   String description;
   Bool onMachine;
   Bool current;
   explicit WebLicenseInfo(Ident _id = 0, String _product = "", Date _validity = Date(), Int _count = 0, Int _inUse = 0, Int _revoke = -1, String _description = "", Bool _onMachine = false, Bool _current = false) : id(_id), product(_product), validity(_validity), count(_count), inUse(_inUse), revoke(_revoke), description(_description), onMachine(_onMachine), current(_current) {}
};

typedef CoreI::List<WebLicenseInfo> WebLicenseInfoList;

typedef struct {
   Boolean valid;
   String reasons;
} getLicenseErrorReturn;

typedef struct {
   String serverHost;
   UShort serverPort;
   Bool useFlexLM;
} getLicenseServerReturn;

typedef struct {
   Long availVirt;
   Long totalVirt;
   Long availPhys;
   Long totalPhys;
} availableMemoryReturn;

typedef struct {
   Bool newVersionAvailable;
   String newVersion;
   String newVersionLink;
   String htmlInfo;
} checkForUpdatesReturn;

typedef struct {
   Boolean functionEnabled;
   Boolean parametersEnabled;
   Boolean executionTimeEnabled;
} getInterfaceLoggerConfigurationReturn;

// ----------------------------------------------------
// Constants
// ----------------------------------------------------

inline Double Epsilon() { return 1e-6; }
inline Double EpsilonSquare() { return 1e-12; }
inline Double HalfPi() { return 1.5707963267948966192313215; }
inline Double Infinity() { return 1e12; }
inline Double OneDegree() { return 0.017453292519943295769236907684886; }
inline Double Pi() { return 3.141592653589793238462643; }
inline Double TwoPi() { return 6.283185307179586476925286; }

PXZ_MODULE_END

#endif
