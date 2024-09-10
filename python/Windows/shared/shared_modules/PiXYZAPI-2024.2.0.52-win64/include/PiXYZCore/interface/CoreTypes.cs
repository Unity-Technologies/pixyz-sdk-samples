#pragma warning disable CA2101

using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Pixyz.Core {

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct AliasTypeDesc
	{
		public AliasTypeDesc(AliasTypeDesc o) {
			this.alias = o.alias;
		}
		public System.String alias;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct AliasTypeDesc_c
	{
		public IntPtr alias;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct ArrayTypeDesc
	{
		public ArrayTypeDesc(ArrayTypeDesc o) {
			this.arrayType = o.arrayType;
			this.size = o.size;
		}
		public System.String arrayType;
		public System.Int32 size;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ArrayTypeDesc_c
	{
		public IntPtr arrayType;
		public Int32 size;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct StringPair
	{
		public StringPair(StringPair o) {
			this.key = o.key;
			this.value = o.value;
		}
		public System.String key;
		public System.String value;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct StringPair_c
	{
		public IntPtr key;
		public IntPtr value;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class StringPairList {
		public Core.StringPair[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public StringPairList(Core.StringPair[] tab) { list = tab; }
		public static implicit operator Core.StringPair[](StringPairList o) { return o.list; }
		public Core.StringPair this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public StringPairList(int size) { list = new Core.StringPair[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct StringPairList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class AutoValueReturn
	{
		public AutoValueReturn() {}
		public AutoValueReturn(AutoValueReturn o) {
			this.values = o.values;
			this.message = o.message;
		}
		public StringPairList values;
		public System.String message;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct AutoValueReturn_c
	{
		public StringPairList_c values;
		public IntPtr message;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class BoolList {
		public System.Boolean[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public BoolList() {}
		public BoolList(System.Boolean[] tab) { list = tab; }
		public static implicit operator System.Boolean[](BoolList o) { return o.list; }
		public System.Boolean this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public BoolList(int size) { list = new System.Boolean[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct BoolList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct BoundedInteger
	{
		public BoundedInteger(BoundedInteger o) {
			this.value = o.value;
			this.min = o.min;
			this.max = o.max;
		}
		public System.Int32 value;
		public System.Int32 min;
		public System.Int32 max;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct BoundedInteger_c
	{
		public Int32 value;
		public Int32 min;
		public Int32 max;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ByteList {
		public System.Byte[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public ByteList() {}
		public ByteList(System.Byte[] tab) { list = tab; }
		public static implicit operator System.Byte[](ByteList o) { return o.list; }
		public System.Byte this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public ByteList(int size) { list = new System.Byte[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ByteList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	// C# delegate
	public delegate ByteList CaptchaCallback(System.String message, ByteList key);

	// C delegate
	internal delegate ByteList_c CaptchaCallback_c(string message, ByteList_c key);

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Color
	{
		public Color(Color o) {
			this.r = o.r;
			this.g = o.g;
			this.b = o.b;
		}
		public System.Double r;
		public System.Double g;
		public System.Double b;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Color_c
	{
		public System.Double r;
		public System.Double g;
		public System.Double b;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct ColorAlpha
	{
		public ColorAlpha(ColorAlpha o) {
			this.r = o.r;
			this.g = o.g;
			this.b = o.b;
			this.a = o.a;
		}
		public System.Double r;
		public System.Double g;
		public System.Double b;
		public System.Double a;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ColorAlpha_c
	{
		public System.Double r;
		public System.Double g;
		public System.Double b;
		public System.Double a;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ColorAlphaList {
		public Core.ColorAlpha[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public ColorAlphaList(Core.ColorAlpha[] tab) { list = tab; }
		public static implicit operator Core.ColorAlpha[](ColorAlphaList o) { return o.list; }
		public Core.ColorAlpha this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public ColorAlphaList(int size) { list = new Core.ColorAlpha[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ColorAlphaList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ColorList {
		public Core.Color[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public ColorList(Core.Color[] tab) { list = tab; }
		public static implicit operator Core.Color[](ColorList o) { return o.list; }
		public Core.Color this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public ColorList(int size) { list = new Core.Color[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ColorList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	public enum TypeDescType
	{
		UNKNOWN = 0,
		BASE = 1,
		ALIAS = 2,
		ENUM = 3,
		LIST = 4,
		STRUCT = 5,
		ARRAY = 6,
		SELECT = 7,
		FUNCPTR = 8,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class IntList {
		public System.Int32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public IntList() {}
		public IntList(System.Int32[] tab) { list = tab; }
		public static implicit operator System.Int32[](IntList o) { return o.list; }
		public System.Int32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public IntList(int size) { list = new System.Int32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct IntList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class StringList {
		public System.String[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public StringList() {}
		public StringList(System.String[] tab) { list = tab; }
		public static implicit operator System.String[](StringList o) { return o.list; }
		public System.String this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public StringList(int size) { list = new System.String[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct StringList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class EnumTypeDesc
	{
		public EnumTypeDesc() {}
		public EnumTypeDesc(EnumTypeDesc o) {
			this.values = o.values;
			this.labels = o.labels;
			this.valueType = o.valueType;
		}
		public IntList values;
		public StringList labels;
		public System.String valueType;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct EnumTypeDesc_c
	{
		public IntList_c values;
		public StringList_c labels;
		public IntPtr valueType;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct ListTypeDesc
	{
		public ListTypeDesc(ListTypeDesc o) {
			this.listType = o.listType;
		}
		public System.String listType;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ListTypeDesc_c
	{
		public IntPtr listType;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Field
	{
		public Field() {}
		public Field(Field o) {
			this.name = o.name;
			this.type = o.type;
			this.module = o.module;
			this.defaultValue = o.defaultValue;
			this.description = o.description;
			this.disableValue = o.disableValue;
			this.predefinedValues = o.predefinedValues;
		}
		public System.String name;
		public System.String type;
		public System.String module;
		public System.String defaultValue;
		public System.String description;
		public System.String disableValue;
		public StringPairList predefinedValues;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Field_c
	{
		public IntPtr name;
		public IntPtr type;
		public IntPtr module;
		public IntPtr defaultValue;
		public IntPtr description;
		public IntPtr disableValue;
		public StringPairList_c predefinedValues;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class FieldList {
		public Core.Field[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public FieldList(Core.Field[] tab) { list = tab; }
		public static implicit operator Core.Field[](FieldList o) { return o.list; }
		public Core.Field this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public FieldList(int size) { list = new Core.Field[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct FieldList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class StructTypeDesc
	{
		public StructTypeDesc() {}
		public StructTypeDesc(StructTypeDesc o) {
			this.fields = o.fields;
		}
		public FieldList fields;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct StructTypeDesc_c
	{
		public FieldList_c fields;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct SelType
	{
		public SelType(SelType o) {
			this.name = o.name;
			this.type = o.type;
			this.defaultValue = o.defaultValue;
			this.description = o.description;
		}
		public System.String name;
		public System.String type;
		public System.String defaultValue;
		public System.String description;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct SelType_c
	{
		public IntPtr name;
		public IntPtr type;
		public IntPtr defaultValue;
		public IntPtr description;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class SelTypeList {
		public Core.SelType[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public SelTypeList(Core.SelType[] tab) { list = tab; }
		public static implicit operator Core.SelType[](SelTypeList o) { return o.list; }
		public Core.SelType this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public SelTypeList(int size) { list = new Core.SelType[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct SelTypeList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class SelectTypeDesc
	{
		public SelectTypeDesc() {}
		public SelectTypeDesc(SelectTypeDesc o) {
			this.types = o.types;
		}
		public SelTypeList types;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct SelectTypeDesc_c
	{
		public SelTypeList_c types;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct TypeDescDef
	{
		public enum Type
		{
			UNKNOWN = 0,
			BASETYPE = 1,
			ALIASTYPE = 2,
			ENUMTYPE = 3,
			LISTTYPE = 4,
			ARRAYTYPE = 5,
			STRUCTTYPE = 6,
			SELECTTYPE = 7,
		}
		public System.Int32 baseType;
		public AliasTypeDesc aliasType;
		public EnumTypeDesc enumType;
		public ListTypeDesc listType;
		public ArrayTypeDesc arrayType;
		public StructTypeDesc structType;
		public SelectTypeDesc selectType;
		public Type _type;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct TypeDescDef_c
	{
		public Int32 baseType;
		public AliasTypeDesc_c aliasType;
		public EnumTypeDesc_c enumType;
		public ListTypeDesc_c listType;
		public ArrayTypeDesc_c arrayType;
		public StructTypeDesc_c structType;
		public SelectTypeDesc_c selectType;
		public int _type;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class TypeDesc
	{
		public TypeDesc() {}
		public TypeDesc(TypeDesc o) {
			this.name = o.name;
			this.module = o.module;
			this.type = o.type;
			this.description = o.description;
			this.definition = o.definition;
		}
		public System.String name;
		public System.String module;
		public TypeDescType type;
		public System.String description;
		public TypeDescDef definition;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct TypeDesc_c
	{
		public IntPtr name;
		public IntPtr module;
		public Int32 type;
		public IntPtr description;
		public TypeDescDef_c definition;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ConstantDesc
	{
		public ConstantDesc() {}
		public ConstantDesc(ConstantDesc o) {
			this.name = o.name;
			this.value = o.value;
			this.type = o.type;
			this.description = o.description;
		}
		public System.String name;
		public System.String value;
		public TypeDesc type;
		public System.String description;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ConstantDesc_c
	{
		public IntPtr name;
		public IntPtr value;
		public TypeDesc_c type;
		public IntPtr description;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ConstantDescList {
		public Core.ConstantDesc[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public ConstantDescList(Core.ConstantDesc[] tab) { list = tab; }
		public static implicit operator Core.ConstantDesc[](ConstantDescList o) { return o.list; }
		public Core.ConstantDesc this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public ConstantDescList(int size) { list = new Core.ConstantDesc[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ConstantDescList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Date
	{
		public Date(Date o) {
			this.year = o.year;
			this.month = o.month;
			this.day = o.day;
		}
		public System.Int32 year;
		public System.Int32 month;
		public System.Int32 day;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Date_c
	{
		public Int32 year;
		public Int32 month;
		public Int32 day;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class DoubleList {
		public System.Double[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public DoubleList() {}
		public DoubleList(System.Double[] tab) { list = tab; }
		public static implicit operator System.Double[](DoubleList o) { return o.list; }
		public System.Double this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public DoubleList(int size) { list = new System.Double[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct DoubleList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class DoubleListList {
		public Core.DoubleList[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public DoubleListList(Core.DoubleList[] tab) { list = tab; }
		public static implicit operator Core.DoubleList[](DoubleListList o) { return o.list; }
		public Core.DoubleList this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public DoubleListList(int size) { list = new Core.DoubleList[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct DoubleListList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class EntityList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public EntityList() {}
		public EntityList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](EntityList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public EntityList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct EntityList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class EntityListList {
		public Core.EntityList[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public EntityListList(Core.EntityList[] tab) { list = tab; }
		public static implicit operator Core.EntityList[](EntityListList o) { return o.list; }
		public Core.EntityList this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public EntityListList(int size) { list = new Core.EntityList[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct EntityListList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class EnumPropertyInfo
	{
		public EnumPropertyInfo() {}
		public EnumPropertyInfo(EnumPropertyInfo o) {
			this.name = o.name;
			this.values = o.values;
			this.labels = o.labels;
		}
		public System.String name;
		public IntList values;
		public StringList labels;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct EnumPropertyInfo_c
	{
		public IntPtr name;
		public IntList_c values;
		public StringList_c labels;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ParameterDesc
	{
		public ParameterDesc() {}
		public ParameterDesc(ParameterDesc o) {
			this.name = o.name;
			this.type = o.type;
			this.description = o.description;
			this.optional = o.optional;
			this.defaultValue = o.defaultValue;
			this.disableValue = o.disableValue;
			this.attributes = o.attributes;
			this.predefinedValues = o.predefinedValues;
		}
		public System.String name;
		public TypeDesc type;
		public System.String description;
		public System.Boolean optional;
		public System.String defaultValue;
		public System.String disableValue;
		public StringPairList attributes;
		public StringPairList predefinedValues;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ParameterDesc_c
	{
		public IntPtr name;
		public TypeDesc_c type;
		public IntPtr description;
		public System.Byte optional;
		public IntPtr defaultValue;
		public IntPtr disableValue;
		public StringPairList_c attributes;
		public StringPairList_c predefinedValues;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ParameterDescList {
		public Core.ParameterDesc[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public ParameterDescList(Core.ParameterDesc[] tab) { list = tab; }
		public static implicit operator Core.ParameterDesc[](ParameterDescList o) { return o.list; }
		public Core.ParameterDesc this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public ParameterDescList(int size) { list = new Core.ParameterDesc[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ParameterDescList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class EventDesc
	{
		public EventDesc() {}
		public EventDesc(EventDesc o) {
			this.module = o.module;
			this.name = o.name;
			this.description = o.description;
			this.parameters = o.parameters;
		}
		public System.String module;
		public System.String name;
		public System.String description;
		public ParameterDescList parameters;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct EventDesc_c
	{
		public IntPtr module;
		public IntPtr name;
		public IntPtr description;
		public ParameterDescList_c parameters;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class EventDescList {
		public Core.EventDesc[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public EventDescList(Core.EventDesc[] tab) { list = tab; }
		public static implicit operator Core.EventDesc[](EventDescList o) { return o.list; }
		public Core.EventDesc this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public EventDescList(int size) { list = new Core.EventDesc[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct EventDescList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class FilePathList {
		public System.String[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public FilePathList() {}
		public FilePathList(System.String[] tab) { list = tab; }
		public static implicit operator System.String[](FilePathList o) { return o.list; }
		public System.String this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public FilePathList(int size) { list = new System.String[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct FilePathList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Format
	{
		public Format() {}
		public Format(Format o) {
			this.name = o.name;
			this.extensions = o.extensions;
		}
		public System.String name;
		public StringList extensions;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Format_c
	{
		public IntPtr name;
		public StringList_c extensions;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class FormatList {
		public Core.Format[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public FormatList(Core.Format[] tab) { list = tab; }
		public static implicit operator Core.Format[](FormatList o) { return o.list; }
		public Core.Format this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public FormatList(int size) { list = new Core.Format[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct FormatList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	public enum Stability
	{
		DEVELOPMENT = 0,
		EXPERIMENTAL = 1,
		BETA = 2,
		STABLE = 3,
		DEPRECATED = 4,
		OBSOLETE = 5,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class FunctionDesc
	{
		public FunctionDesc() {}
		public FunctionDesc(FunctionDesc o) {
			this.name = o.name;
			this.module = o.module;
			this.parameters = o.parameters;
			this.returns = o.returns;
			this.description = o.description;
			this.stability = o.stability;
		}
		public System.String name;
		public System.String module;
		public ParameterDescList parameters;
		public ParameterDescList returns;
		public System.String description;
		public Stability stability;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct FunctionDesc_c
	{
		public IntPtr name;
		public IntPtr module;
		public ParameterDescList_c parameters;
		public ParameterDescList_c returns;
		public IntPtr description;
		public Int32 stability;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class FunctionDescList {
		public Core.FunctionDesc[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public FunctionDescList(Core.FunctionDesc[] tab) { list = tab; }
		public static implicit operator Core.FunctionDesc[](FunctionDescList o) { return o.list; }
		public Core.FunctionDesc this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public FunctionDescList(int size) { list = new Core.FunctionDesc[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct FunctionDescList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GroupDesc
	{
		public GroupDesc() {}
		public GroupDesc(GroupDesc o) {
			this.name = o.name;
			this.description = o.description;
			this.functions = o.functions;
		}
		public System.String name;
		public System.String description;
		public FunctionDescList functions;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GroupDesc_c
	{
		public IntPtr name;
		public IntPtr description;
		public FunctionDescList_c functions;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GroupDescList {
		public Core.GroupDesc[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public GroupDescList(Core.GroupDesc[] tab) { list = tab; }
		public static implicit operator Core.GroupDesc[](GroupDescList o) { return o.list; }
		public Core.GroupDesc this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public GroupDescList(int size) { list = new Core.GroupDesc[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GroupDescList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct IdentPair
	{
		public IdentPair(IdentPair o) {
			this.key = o.key;
			this.value = o.value;
		}
		public System.UInt32 key;
		public System.UInt32 value;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct IdentPair_c
	{
		public System.UInt32 key;
		public System.UInt32 value;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class IdentPairList {
		public Core.IdentPair[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public IdentPairList(Core.IdentPair[] tab) { list = tab; }
		public static implicit operator Core.IdentPair[](IdentPairList o) { return o.list; }
		public Core.IdentPair this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public IdentPairList(int size) { list = new Core.IdentPair[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct IdentPairList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	public enum InheritableBool
	{
		False = 0,
		True = 1,
		Inherited = 2,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class InheritableBoolList {
		public Core.InheritableBool[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public InheritableBoolList(Core.InheritableBool[] tab) { list = tab; }
		public static implicit operator Core.InheritableBool[](InheritableBoolList o) { return o.list; }
		public Core.InheritableBool this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public InheritableBoolList(int size) { list = new Core.InheritableBool[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct InheritableBoolList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class IntListList {
		public Core.IntList[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public IntListList(Core.IntList[] tab) { list = tab; }
		public static implicit operator Core.IntList[](IntListList o) { return o.list; }
		public Core.IntList this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public IntListList(int size) { list = new Core.IntList[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct IntListList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class LicenseInfos
	{
		public LicenseInfos() {}
		public LicenseInfos(LicenseInfos o) {
			this.version = o.version;
			this.customerName = o.customerName;
			this.customerCompany = o.customerCompany;
			this.customerEmail = o.customerEmail;
			this.isFloating = o.isFloating;
			this.isRevocable = o.isRevocable;
			this.startDate = o.startDate;
			this.endDate = o.endDate;
			this.invalidReasons = o.invalidReasons;
		}
		public System.String version;
		public System.String customerName;
		public System.String customerCompany;
		public System.String customerEmail;
		public System.Boolean isFloating;
		public System.Boolean isRevocable;
		public Date startDate;
		public Date endDate;
		public StringList invalidReasons;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct LicenseInfos_c
	{
		public IntPtr version;
		public IntPtr customerName;
		public IntPtr customerCompany;
		public IntPtr customerEmail;
		public System.Byte isFloating;
		public System.Byte isRevocable;
		public Date_c startDate;
		public Date_c endDate;
		public StringList_c invalidReasons;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class TypeDescList {
		public Core.TypeDesc[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public TypeDescList(Core.TypeDesc[] tab) { list = tab; }
		public static implicit operator Core.TypeDesc[](TypeDescList o) { return o.list; }
		public Core.TypeDesc this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public TypeDescList(int size) { list = new Core.TypeDesc[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct TypeDescList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ModuleDesc
	{
		public ModuleDesc() {}
		public ModuleDesc(ModuleDesc o) {
			this.name = o.name;
			this.description = o.description;
			this.author = o.author;
			this.groups = o.groups;
			this.types = o.types;
			this.constants = o.constants;
			this.dependencies = o.dependencies;
			this.stability = o.stability;
		}
		public System.String name;
		public System.String description;
		public System.String author;
		public GroupDescList groups;
		public TypeDescList types;
		public ConstantDescList constants;
		public StringList dependencies;
		public Stability stability;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ModuleDesc_c
	{
		public IntPtr name;
		public IntPtr description;
		public IntPtr author;
		public GroupDescList_c groups;
		public TypeDescList_c types;
		public ConstantDescList_c constants;
		public StringList_c dependencies;
		public Int32 stability;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ModuleDescList {
		public Core.ModuleDesc[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public ModuleDescList(Core.ModuleDesc[] tab) { list = tab; }
		public static implicit operator Core.ModuleDesc[](ModuleDescList o) { return o.list; }
		public Core.ModuleDesc this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public ModuleDescList(int size) { list = new Core.ModuleDesc[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ModuleDescList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	// C# delegate
	public delegate void ParallelCallback(System.IntPtr data);

	// C delegate
	internal delegate void ParallelCallback_c(System.IntPtr data);

	public enum PropertyType
	{
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
		UNKNOWN = 40,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class PropertyInfo
	{
		public PropertyInfo() {}
		public PropertyInfo(PropertyInfo o) {
			this.name = o.name;
			this.type = o.type;
			this.subType = o.subType;
			this.value = o.value;
			this.user = o.user;
			this.defaultValue = o.defaultValue;
			this.editable = o.editable;
			this.isSet = o.isSet;
			this.delegated = o.delegated;
			this.delegatedOwnerEntity = o.delegatedOwnerEntity;
			this.group = o.group;
			this.description = o.description;
		}
		public System.String name;
		public PropertyType type;
		public System.Int32 subType;
		public System.String value;
		public System.Boolean user;
		public System.String defaultValue;
		public System.Boolean editable;
		public System.Boolean isSet;
		public System.Boolean delegated;
		public System.UInt32 delegatedOwnerEntity;
		public System.String group;
		public System.String description;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct PropertyInfo_c
	{
		public IntPtr name;
		public Int32 type;
		public Int32 subType;
		public IntPtr value;
		public System.Byte user;
		public IntPtr defaultValue;
		public System.Byte editable;
		public System.Byte isSet;
		public System.Byte delegated;
		public System.UInt32 delegatedOwnerEntity;
		public IntPtr group;
		public IntPtr description;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class PropertyInfoList {
		public Core.PropertyInfo[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public PropertyInfoList(Core.PropertyInfo[] tab) { list = tab; }
		public static implicit operator Core.PropertyInfo[](PropertyInfoList o) { return o.list; }
		public Core.PropertyInfo this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public PropertyInfoList(int size) { list = new Core.PropertyInfo[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct PropertyInfoList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class PropertyInfoListList {
		public Core.PropertyInfoList[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public PropertyInfoListList(Core.PropertyInfoList[] tab) { list = tab; }
		public static implicit operator Core.PropertyInfoList[](PropertyInfoListList o) { return o.list; }
		public Core.PropertyInfoList this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public PropertyInfoListList(int size) { list = new Core.PropertyInfoList[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct PropertyInfoListList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class PropertyTypeList {
		public Core.PropertyType[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public PropertyTypeList(Core.PropertyType[] tab) { list = tab; }
		public static implicit operator Core.PropertyType[](PropertyTypeList o) { return o.list; }
		public Core.PropertyType this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public PropertyTypeList(int size) { list = new Core.PropertyType[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct PropertyTypeList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class PtrList {
		public System.IntPtr[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public PtrList() {}
		public PtrList(System.IntPtr[] tab) { list = tab; }
		public static implicit operator System.IntPtr[](PtrList o) { return o.list; }
		public System.IntPtr this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public PtrList(int size) { list = new System.IntPtr[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct PtrList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class StringPairListList {
		public Core.StringPairList[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public StringPairListList(Core.StringPairList[] tab) { list = tab; }
		public static implicit operator Core.StringPairList[](StringPairListList o) { return o.list; }
		public Core.StringPairList this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public StringPairListList(int size) { list = new Core.StringPairList[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct StringPairListList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ULongList {
		public System.UInt64[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public ULongList() {}
		public ULongList(System.UInt64[] tab) { list = tab; }
		public static implicit operator System.UInt64[](ULongList o) { return o.list; }
		public System.UInt64 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public ULongList(int size) { list = new System.UInt64[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ULongList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	public enum Verbose
	{
		ERR = 0,
		WARNING = 1,
		INFO = 2,
		SCRIPT = 5,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class WebLicenseInfo
	{
		public WebLicenseInfo() {}
		public WebLicenseInfo(WebLicenseInfo o) {
			this.id = o.id;
			this.product = o.product;
			this.validity = o.validity;
			this.count = o.count;
			this.inUse = o.inUse;
			this.revoke = o.revoke;
			this.description = o.description;
			this.onMachine = o.onMachine;
			this.current = o.current;
		}
		public System.UInt32 id;
		public System.String product;
		public Date validity;
		public System.Int32 count;
		public System.Int32 inUse;
		public System.Int32 revoke;
		public System.String description;
		public System.Boolean onMachine;
		public System.Boolean current;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct WebLicenseInfo_c
	{
		public System.UInt32 id;
		public IntPtr product;
		public Date_c validity;
		public Int32 count;
		public Int32 inUse;
		public Int32 revoke;
		public IntPtr description;
		public System.Byte onMachine;
		public System.Byte current;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class WebLicenseInfoList {
		public Core.WebLicenseInfo[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public WebLicenseInfoList(Core.WebLicenseInfo[] tab) { list = tab; }
		public static implicit operator Core.WebLicenseInfo[](WebLicenseInfoList o) { return o.list; }
		public Core.WebLicenseInfo this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public WebLicenseInfoList(int size) { list = new Core.WebLicenseInfo[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct WebLicenseInfoList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct GetLicenseServerReturn
	{
		public GetLicenseServerReturn(GetLicenseServerReturn o) {
			this.serverHost = o.serverHost;
			this.serverPort = o.serverPort;
			this.useFlexLM = o.useFlexLM;
		}
		public System.String serverHost;
		public System.UInt16 serverPort;
		public System.Boolean useFlexLM;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetLicenseServerReturn_c
	{
		public IntPtr serverHost;
		public System.UInt16 serverPort;
		public System.Byte useFlexLM;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct AvailableMemoryReturn
	{
		public AvailableMemoryReturn(AvailableMemoryReturn o) {
			this.availVirt = o.availVirt;
			this.totalVirt = o.totalVirt;
			this.availPhys = o.availPhys;
			this.totalPhys = o.totalPhys;
		}
		public System.Int64 availVirt;
		public System.Int64 totalVirt;
		public System.Int64 availPhys;
		public System.Int64 totalPhys;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct AvailableMemoryReturn_c
	{
		public System.Int64 availVirt;
		public System.Int64 totalVirt;
		public System.Int64 availPhys;
		public System.Int64 totalPhys;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct CheckForUpdatesReturn
	{
		public CheckForUpdatesReturn(CheckForUpdatesReturn o) {
			this.newVersionAvailable = o.newVersionAvailable;
			this.newVersion = o.newVersion;
			this.newVersionLink = o.newVersionLink;
			this.htmlInfo = o.htmlInfo;
		}
		public System.Boolean newVersionAvailable;
		public System.String newVersion;
		public System.String newVersionLink;
		public System.String htmlInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct CheckForUpdatesReturn_c
	{
		public System.Byte newVersionAvailable;
		public IntPtr newVersion;
		public IntPtr newVersionLink;
		public IntPtr htmlInfo;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct GetInterfaceLoggerConfigurationReturn
	{
		public GetInterfaceLoggerConfigurationReturn(GetInterfaceLoggerConfigurationReturn o) {
			this.functionEnabled = o.functionEnabled;
			this.parametersEnabled = o.parametersEnabled;
			this.executionTimeEnabled = o.executionTimeEnabled;
		}
		public System.Boolean functionEnabled;
		public System.Boolean parametersEnabled;
		public System.Boolean executionTimeEnabled;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetInterfaceLoggerConfigurationReturn_c
	{
		public System.Byte functionEnabled;
		public System.Byte parametersEnabled;
		public System.Byte executionTimeEnabled;
	}

}
