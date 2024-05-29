#pragma warning disable CA2101

using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System;
using PiXYZAPI = UnityEngine.Pixyz.API.PiXYZAPI;

namespace UnityEngine.Pixyz.Core {

	public class CoreInterface : API.Interface {

		#region Types Init/Free Methods

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_InheritableBoolList_init(ref InheritableBoolList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_InheritableBoolList_free(ref InheritableBoolList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_AliasTypeDesc_init(ref AliasTypeDesc_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_AliasTypeDesc_free(ref AliasTypeDesc_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_IntList_init(ref IntList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_IntList_free(ref IntList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_StringList_init(ref StringList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_StringList_free(ref StringList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EnumTypeDesc_init(ref EnumTypeDesc_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EnumTypeDesc_free(ref EnumTypeDesc_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ListTypeDesc_init(ref ListTypeDesc_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ListTypeDesc_free(ref ListTypeDesc_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ArrayTypeDesc_init(ref ArrayTypeDesc_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ArrayTypeDesc_free(ref ArrayTypeDesc_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_StringPair_init(ref StringPair_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_StringPair_free(ref StringPair_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_StringPairList_init(ref StringPairList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_StringPairList_free(ref StringPairList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_Field_init(ref Field_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_Field_free(ref Field_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_FieldList_init(ref FieldList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_FieldList_free(ref FieldList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_StructTypeDesc_init(ref StructTypeDesc_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_StructTypeDesc_free(ref StructTypeDesc_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_SelType_init(ref SelType_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_SelType_free(ref SelType_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_SelTypeList_init(ref SelTypeList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_SelTypeList_free(ref SelTypeList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_SelectTypeDesc_init(ref SelectTypeDesc_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_SelectTypeDesc_free(ref SelectTypeDesc_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_TypeDescDef_init(ref TypeDescDef_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_TypeDescDef_free(ref TypeDescDef_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_TypeDesc_init(ref TypeDesc_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_TypeDesc_free(ref TypeDesc_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ParameterDesc_init(ref ParameterDesc_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ParameterDesc_free(ref ParameterDesc_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ParameterDescList_init(ref ParameterDescList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ParameterDescList_free(ref ParameterDescList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_FunctionDesc_init(ref FunctionDesc_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_FunctionDesc_free(ref FunctionDesc_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_FunctionDescList_init(ref FunctionDescList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_FunctionDescList_free(ref FunctionDescList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_GroupDesc_init(ref GroupDesc_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_GroupDesc_free(ref GroupDesc_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_GroupDescList_init(ref GroupDescList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_GroupDescList_free(ref GroupDescList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_TypeDescList_init(ref TypeDescList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_TypeDescList_free(ref TypeDescList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ConstantDesc_init(ref ConstantDesc_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ConstantDesc_free(ref ConstantDesc_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ConstantDescList_init(ref ConstantDescList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ConstantDescList_free(ref ConstantDescList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ModuleDesc_init(ref ModuleDesc_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ModuleDesc_free(ref ModuleDesc_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ModuleDescList_init(ref ModuleDescList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ModuleDescList_free(ref ModuleDescList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_PropertyInfo_init(ref PropertyInfo_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_PropertyInfo_free(ref PropertyInfo_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_PropertyInfoList_init(ref PropertyInfoList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_PropertyInfoList_free(ref PropertyInfoList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_PropertyInfoListList_init(ref PropertyInfoListList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_PropertyInfoListList_free(ref PropertyInfoListList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_FilePathList_init(ref FilePathList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_FilePathList_free(ref FilePathList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_Date_init(ref Date_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_Date_free(ref Date_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_DoubleList_init(ref DoubleList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_DoubleList_free(ref DoubleList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_DoubleListList_init(ref DoubleListList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_DoubleListList_free(ref DoubleListList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_LicenseInfos_init(ref LicenseInfos_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_LicenseInfos_free(ref LicenseInfos_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_BoolList_init(ref BoolList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_BoolList_free(ref BoolList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EventDesc_init(ref EventDesc_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EventDesc_free(ref EventDesc_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EventDescList_init(ref EventDescList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EventDescList_free(ref EventDescList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EntityList_init(ref EntityList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EntityList_free(ref EntityList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EntityListList_init(ref EntityListList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EntityListList_free(ref EntityListList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ULongList_init(ref ULongList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ULongList_free(ref ULongList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ByteList_init(ref ByteList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ByteList_free(ref ByteList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_WebLicenseInfo_init(ref WebLicenseInfo_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_WebLicenseInfo_free(ref WebLicenseInfo_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_WebLicenseInfoList_init(ref WebLicenseInfoList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_WebLicenseInfoList_free(ref WebLicenseInfoList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_IntListList_init(ref IntListList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_IntListList_free(ref IntListList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_Format_init(ref Format_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_Format_free(ref Format_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_FormatList_init(ref FormatList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_FormatList_free(ref FormatList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_AutoValueReturn_init(ref AutoValueReturn_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_AutoValueReturn_free(ref AutoValueReturn_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_Color_init(ref Color_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_Color_free(ref Color_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ColorList_init(ref ColorList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ColorList_free(ref ColorList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_PtrList_init(ref PtrList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_PtrList_free(ref PtrList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ColorAlpha_init(ref ColorAlpha_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ColorAlpha_free(ref ColorAlpha_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ColorAlphaList_init(ref ColorAlphaList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ColorAlphaList_free(ref ColorAlphaList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_BoundedInteger_init(ref BoundedInteger_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_BoundedInteger_free(ref BoundedInteger_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_IdentPair_init(ref IdentPair_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_IdentPair_free(ref IdentPair_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EnumPropertyInfo_init(ref EnumPropertyInfo_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EnumPropertyInfo_free(ref EnumPropertyInfo_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_IdentPairList_init(ref IdentPairList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_IdentPairList_free(ref IdentPairList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_StringPairListList_init(ref StringPairListList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_StringPairListList_free(ref StringPairListList_c list);

	internal static InheritableBoolList ConvertValue(ref InheritableBoolList_c s) {
		InheritableBoolList list = new InheritableBoolList((int)s.size);
		if (s.size==0) return list;

		int[] tab = new int[s.size];
		Marshal.Copy(s.ptr, tab, 0, (int)s.size);
		for (int i = 0; i < (int)s.size; ++i) {
			list.list[i] = (InheritableBool)tab[i];
		}
		return list;
	}

	internal static InheritableBoolList_c ConvertValue(InheritableBoolList s, ref InheritableBoolList_c list) {
		Core.CoreInterface.Core_InheritableBoolList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)s.list[i];
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static AliasTypeDesc ConvertValue(ref AliasTypeDesc_c s) {
		AliasTypeDesc ss = new AliasTypeDesc();
		ss.alias = ConvertValue(s.alias);
		return ss;
	}

	internal static AliasTypeDesc_c ConvertValue(AliasTypeDesc s, ref AliasTypeDesc_c ss) {
		Core.CoreInterface.Core_AliasTypeDesc_init(ref ss);
		ss.alias = ConvertValue(s.alias);
		return ss;
	}

	internal static IntList ConvertValue(ref IntList_c s) {
		IntList list = new IntList((int)s.size);
		if (s.size > 0)
			Marshal.Copy(s.ptr, list.list, 0, (int)s.size);
		return list;
	}

	internal static IntList_c ConvertValue(IntList s, ref IntList_c list) {
		Core.CoreInterface.Core_IntList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size > 0)
			Marshal.Copy(s.list, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static StringList ConvertValue(ref StringList_c s) {
		StringList list = new StringList((int)s.size);
		if (s.size==0) return list;

		IntPtr[] tab = new IntPtr[s.size];
		Marshal.Copy(s.ptr, tab, 0, (int)s.size);
		for (int i = 0; i < (int)s.size; ++i) {
			list.list[i] = ConvertValue(tab[i]);
		}
		return list;
	}

	internal static StringList_c ConvertValue(StringList s, ref StringList_c list) {
		Core.CoreInterface.Core_StringList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		IntPtr[] tab = new IntPtr[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = ConvertValue(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static EnumTypeDesc ConvertValue(ref EnumTypeDesc_c s) {
		EnumTypeDesc ss = new EnumTypeDesc();
		ss.values = ConvertValue(ref s.values);
		ss.labels = ConvertValue(ref s.labels);
		ss.valueType = ConvertValue(s.valueType);
		return ss;
	}

	internal static EnumTypeDesc_c ConvertValue(EnumTypeDesc s, ref EnumTypeDesc_c ss) {
		Core.CoreInterface.Core_EnumTypeDesc_init(ref ss);
		ConvertValue(s.values, ref ss.values);
		ConvertValue(s.labels, ref ss.labels);
		ss.valueType = ConvertValue(s.valueType);
		return ss;
	}

	internal static ListTypeDesc ConvertValue(ref ListTypeDesc_c s) {
		ListTypeDesc ss = new ListTypeDesc();
		ss.listType = ConvertValue(s.listType);
		return ss;
	}

	internal static ListTypeDesc_c ConvertValue(ListTypeDesc s, ref ListTypeDesc_c ss) {
		Core.CoreInterface.Core_ListTypeDesc_init(ref ss);
		ss.listType = ConvertValue(s.listType);
		return ss;
	}

	internal static ArrayTypeDesc ConvertValue(ref ArrayTypeDesc_c s) {
		ArrayTypeDesc ss = new ArrayTypeDesc();
		ss.arrayType = ConvertValue(s.arrayType);
		ss.size = (System.Int32)s.size;
		return ss;
	}

	internal static ArrayTypeDesc_c ConvertValue(ArrayTypeDesc s, ref ArrayTypeDesc_c ss) {
		Core.CoreInterface.Core_ArrayTypeDesc_init(ref ss);
		ss.arrayType = ConvertValue(s.arrayType);
		ss.size = (Int32)s.size;
		return ss;
	}

	internal static StringPair ConvertValue(ref StringPair_c s) {
		StringPair ss = new StringPair();
		ss.key = ConvertValue(s.key);
		ss.value = ConvertValue(s.value);
		return ss;
	}

	internal static StringPair_c ConvertValue(StringPair s, ref StringPair_c ss) {
		Core.CoreInterface.Core_StringPair_init(ref ss);
		ss.key = ConvertValue(s.key);
		ss.value = ConvertValue(s.value);
		return ss;
	}

	internal static StringPairList ConvertValue(ref StringPairList_c s) {
		StringPairList list = new StringPairList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(StringPair_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			StringPair_c value = (StringPair_c)Marshal.PtrToStructure(p, typeof(StringPair_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static StringPairList_c ConvertValue(StringPairList s, ref StringPairList_c list) {
		Core.CoreInterface.Core_StringPairList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			StringPair_c elt = new StringPair_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(StringPair_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Field ConvertValue(ref Field_c s) {
		Field ss = new Field();
		ss.name = ConvertValue(s.name);
		ss.type = ConvertValue(s.type);
		ss.module = ConvertValue(s.module);
		ss.defaultValue = ConvertValue(s.defaultValue);
		ss.description = ConvertValue(s.description);
		ss.disableValue = ConvertValue(s.disableValue);
		ss.predefinedValues = ConvertValue(ref s.predefinedValues);
		return ss;
	}

	internal static Field_c ConvertValue(Field s, ref Field_c ss) {
		Core.CoreInterface.Core_Field_init(ref ss);
		ss.name = ConvertValue(s.name);
		ss.type = ConvertValue(s.type);
		ss.module = ConvertValue(s.module);
		ss.defaultValue = ConvertValue(s.defaultValue);
		ss.description = ConvertValue(s.description);
		ss.disableValue = ConvertValue(s.disableValue);
		ConvertValue(s.predefinedValues, ref ss.predefinedValues);
		return ss;
	}

	internal static FieldList ConvertValue(ref FieldList_c s) {
		FieldList list = new FieldList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(Field_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			Field_c value = (Field_c)Marshal.PtrToStructure(p, typeof(Field_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static FieldList_c ConvertValue(FieldList s, ref FieldList_c list) {
		Core.CoreInterface.Core_FieldList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Field_c elt = new Field_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Field_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static StructTypeDesc ConvertValue(ref StructTypeDesc_c s) {
		StructTypeDesc ss = new StructTypeDesc();
		ss.fields = ConvertValue(ref s.fields);
		return ss;
	}

	internal static StructTypeDesc_c ConvertValue(StructTypeDesc s, ref StructTypeDesc_c ss) {
		Core.CoreInterface.Core_StructTypeDesc_init(ref ss);
		ConvertValue(s.fields, ref ss.fields);
		return ss;
	}

	internal static SelType ConvertValue(ref SelType_c s) {
		SelType ss = new SelType();
		ss.name = ConvertValue(s.name);
		ss.type = ConvertValue(s.type);
		ss.defaultValue = ConvertValue(s.defaultValue);
		ss.description = ConvertValue(s.description);
		return ss;
	}

	internal static SelType_c ConvertValue(SelType s, ref SelType_c ss) {
		Core.CoreInterface.Core_SelType_init(ref ss);
		ss.name = ConvertValue(s.name);
		ss.type = ConvertValue(s.type);
		ss.defaultValue = ConvertValue(s.defaultValue);
		ss.description = ConvertValue(s.description);
		return ss;
	}

	internal static SelTypeList ConvertValue(ref SelTypeList_c s) {
		SelTypeList list = new SelTypeList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(SelType_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			SelType_c value = (SelType_c)Marshal.PtrToStructure(p, typeof(SelType_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static SelTypeList_c ConvertValue(SelTypeList s, ref SelTypeList_c list) {
		Core.CoreInterface.Core_SelTypeList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			SelType_c elt = new SelType_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(SelType_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static SelectTypeDesc ConvertValue(ref SelectTypeDesc_c s) {
		SelectTypeDesc ss = new SelectTypeDesc();
		ss.types = ConvertValue(ref s.types);
		return ss;
	}

	internal static SelectTypeDesc_c ConvertValue(SelectTypeDesc s, ref SelectTypeDesc_c ss) {
		Core.CoreInterface.Core_SelectTypeDesc_init(ref ss);
		ConvertValue(s.types, ref ss.types);
		return ss;
	}

	internal static TypeDescDef ConvertValue(ref TypeDescDef_c s) {
		TypeDescDef ss = new TypeDescDef();
		ss._type = (TypeDescDef.Type)s._type;
		switch(ss._type) {
			case TypeDescDef.Type.UNKNOWN: break;
			case TypeDescDef.Type.BASETYPE: ss.baseType = (Int32)s.baseType; break;
			case TypeDescDef.Type.ALIASTYPE: ss.aliasType = ConvertValue(ref s.aliasType); break;
			case TypeDescDef.Type.ENUMTYPE: ss.enumType = ConvertValue(ref s.enumType); break;
			case TypeDescDef.Type.LISTTYPE: ss.listType = ConvertValue(ref s.listType); break;
			case TypeDescDef.Type.ARRAYTYPE: ss.arrayType = ConvertValue(ref s.arrayType); break;
			case TypeDescDef.Type.STRUCTTYPE: ss.structType = ConvertValue(ref s.structType); break;
			case TypeDescDef.Type.SELECTTYPE: ss.selectType = ConvertValue(ref s.selectType); break;
		}
		return ss;
	}

	internal static TypeDescDef_c ConvertValue(TypeDescDef s, ref TypeDescDef_c ss) {
		Core.CoreInterface.Core_TypeDescDef_init(ref ss);
		ss._type = (int)s._type;
		switch (ss._type) {
			case 0: break;
			case 1: ss.baseType = (Int32)s.baseType; break;
			case 2: ConvertValue(s.aliasType, ref ss.aliasType); break;
			case 3: ConvertValue(s.enumType, ref ss.enumType); break;
			case 4: ConvertValue(s.listType, ref ss.listType); break;
			case 5: ConvertValue(s.arrayType, ref ss.arrayType); break;
			case 6: ConvertValue(s.structType, ref ss.structType); break;
			case 7: ConvertValue(s.selectType, ref ss.selectType); break;
		}
		return ss;
	}

	internal static TypeDesc ConvertValue(ref TypeDesc_c s) {
		TypeDesc ss = new TypeDesc();
		ss.name = ConvertValue(s.name);
		ss.module = ConvertValue(s.module);
		ss.type = (TypeDescType)s.type;
		ss.description = ConvertValue(s.description);
		ss.definition = ConvertValue(ref s.definition);
		return ss;
	}

	internal static TypeDesc_c ConvertValue(TypeDesc s, ref TypeDesc_c ss) {
		Core.CoreInterface.Core_TypeDesc_init(ref ss);
		ss.name = ConvertValue(s.name);
		ss.module = ConvertValue(s.module);
		ss.type = (Int32)s.type;
		ss.description = ConvertValue(s.description);
		ConvertValue(s.definition, ref ss.definition);
		return ss;
	}

	internal static ParameterDesc ConvertValue(ref ParameterDesc_c s) {
		ParameterDesc ss = new ParameterDesc();
		ss.name = ConvertValue(s.name);
		ss.type = ConvertValue(ref s.type);
		ss.description = ConvertValue(s.description);
		ss.optional = ConvertValue(s.optional);
		ss.defaultValue = ConvertValue(s.defaultValue);
		ss.disableValue = ConvertValue(s.disableValue);
		ss.attributes = ConvertValue(ref s.attributes);
		return ss;
	}

	internal static ParameterDesc_c ConvertValue(ParameterDesc s, ref ParameterDesc_c ss) {
		Core.CoreInterface.Core_ParameterDesc_init(ref ss);
		ss.name = ConvertValue(s.name);
		ConvertValue(s.type, ref ss.type);
		ss.description = ConvertValue(s.description);
		ss.optional = ConvertValue(s.optional);
		ss.defaultValue = ConvertValue(s.defaultValue);
		ss.disableValue = ConvertValue(s.disableValue);
		ConvertValue(s.attributes, ref ss.attributes);
		return ss;
	}

	internal static ParameterDescList ConvertValue(ref ParameterDescList_c s) {
		ParameterDescList list = new ParameterDescList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(ParameterDesc_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			ParameterDesc_c value = (ParameterDesc_c)Marshal.PtrToStructure(p, typeof(ParameterDesc_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static ParameterDescList_c ConvertValue(ParameterDescList s, ref ParameterDescList_c list) {
		Core.CoreInterface.Core_ParameterDescList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			ParameterDesc_c elt = new ParameterDesc_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(ParameterDesc_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static FunctionDesc ConvertValue(ref FunctionDesc_c s) {
		FunctionDesc ss = new FunctionDesc();
		ss.name = ConvertValue(s.name);
		ss.module = ConvertValue(s.module);
		ss.parameters = ConvertValue(ref s.parameters);
		ss.returns = ConvertValue(ref s.returns);
		ss.description = ConvertValue(s.description);
		ss.stability = (Stability)s.stability;
		return ss;
	}

	internal static FunctionDesc_c ConvertValue(FunctionDesc s, ref FunctionDesc_c ss) {
		Core.CoreInterface.Core_FunctionDesc_init(ref ss);
		ss.name = ConvertValue(s.name);
		ss.module = ConvertValue(s.module);
		ConvertValue(s.parameters, ref ss.parameters);
		ConvertValue(s.returns, ref ss.returns);
		ss.description = ConvertValue(s.description);
		ss.stability = (Int32)s.stability;
		return ss;
	}

	internal static FunctionDescList ConvertValue(ref FunctionDescList_c s) {
		FunctionDescList list = new FunctionDescList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(FunctionDesc_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			FunctionDesc_c value = (FunctionDesc_c)Marshal.PtrToStructure(p, typeof(FunctionDesc_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static FunctionDescList_c ConvertValue(FunctionDescList s, ref FunctionDescList_c list) {
		Core.CoreInterface.Core_FunctionDescList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			FunctionDesc_c elt = new FunctionDesc_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(FunctionDesc_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static GroupDesc ConvertValue(ref GroupDesc_c s) {
		GroupDesc ss = new GroupDesc();
		ss.name = ConvertValue(s.name);
		ss.description = ConvertValue(s.description);
		ss.functions = ConvertValue(ref s.functions);
		return ss;
	}

	internal static GroupDesc_c ConvertValue(GroupDesc s, ref GroupDesc_c ss) {
		Core.CoreInterface.Core_GroupDesc_init(ref ss);
		ss.name = ConvertValue(s.name);
		ss.description = ConvertValue(s.description);
		ConvertValue(s.functions, ref ss.functions);
		return ss;
	}

	internal static GroupDescList ConvertValue(ref GroupDescList_c s) {
		GroupDescList list = new GroupDescList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(GroupDesc_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			GroupDesc_c value = (GroupDesc_c)Marshal.PtrToStructure(p, typeof(GroupDesc_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static GroupDescList_c ConvertValue(GroupDescList s, ref GroupDescList_c list) {
		Core.CoreInterface.Core_GroupDescList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			GroupDesc_c elt = new GroupDesc_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(GroupDesc_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static TypeDescList ConvertValue(ref TypeDescList_c s) {
		TypeDescList list = new TypeDescList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(TypeDesc_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			TypeDesc_c value = (TypeDesc_c)Marshal.PtrToStructure(p, typeof(TypeDesc_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static TypeDescList_c ConvertValue(TypeDescList s, ref TypeDescList_c list) {
		Core.CoreInterface.Core_TypeDescList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			TypeDesc_c elt = new TypeDesc_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(TypeDesc_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static ConstantDesc ConvertValue(ref ConstantDesc_c s) {
		ConstantDesc ss = new ConstantDesc();
		ss.name = ConvertValue(s.name);
		ss.value = ConvertValue(s.value);
		ss.type = ConvertValue(ref s.type);
		ss.description = ConvertValue(s.description);
		return ss;
	}

	internal static ConstantDesc_c ConvertValue(ConstantDesc s, ref ConstantDesc_c ss) {
		Core.CoreInterface.Core_ConstantDesc_init(ref ss);
		ss.name = ConvertValue(s.name);
		ss.value = ConvertValue(s.value);
		ConvertValue(s.type, ref ss.type);
		ss.description = ConvertValue(s.description);
		return ss;
	}

	internal static ConstantDescList ConvertValue(ref ConstantDescList_c s) {
		ConstantDescList list = new ConstantDescList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(ConstantDesc_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			ConstantDesc_c value = (ConstantDesc_c)Marshal.PtrToStructure(p, typeof(ConstantDesc_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static ConstantDescList_c ConvertValue(ConstantDescList s, ref ConstantDescList_c list) {
		Core.CoreInterface.Core_ConstantDescList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			ConstantDesc_c elt = new ConstantDesc_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(ConstantDesc_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static ModuleDesc ConvertValue(ref ModuleDesc_c s) {
		ModuleDesc ss = new ModuleDesc();
		ss.name = ConvertValue(s.name);
		ss.description = ConvertValue(s.description);
		ss.author = ConvertValue(s.author);
		ss.groups = ConvertValue(ref s.groups);
		ss.types = ConvertValue(ref s.types);
		ss.constants = ConvertValue(ref s.constants);
		ss.dependencies = ConvertValue(ref s.dependencies);
		ss.stability = (Stability)s.stability;
		return ss;
	}

	internal static ModuleDesc_c ConvertValue(ModuleDesc s, ref ModuleDesc_c ss) {
		Core.CoreInterface.Core_ModuleDesc_init(ref ss);
		ss.name = ConvertValue(s.name);
		ss.description = ConvertValue(s.description);
		ss.author = ConvertValue(s.author);
		ConvertValue(s.groups, ref ss.groups);
		ConvertValue(s.types, ref ss.types);
		ConvertValue(s.constants, ref ss.constants);
		ConvertValue(s.dependencies, ref ss.dependencies);
		ss.stability = (Int32)s.stability;
		return ss;
	}

	internal static ModuleDescList ConvertValue(ref ModuleDescList_c s) {
		ModuleDescList list = new ModuleDescList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(ModuleDesc_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			ModuleDesc_c value = (ModuleDesc_c)Marshal.PtrToStructure(p, typeof(ModuleDesc_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static ModuleDescList_c ConvertValue(ModuleDescList s, ref ModuleDescList_c list) {
		Core.CoreInterface.Core_ModuleDescList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			ModuleDesc_c elt = new ModuleDesc_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(ModuleDesc_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static PropertyInfo ConvertValue(ref PropertyInfo_c s) {
		PropertyInfo ss = new PropertyInfo();
		ss.name = ConvertValue(s.name);
		ss.type = (PropertyType)s.type;
		ss.subType = (System.Int32)s.subType;
		ss.value = ConvertValue(s.value);
		ss.user = ConvertValue(s.user);
		ss.defaultValue = ConvertValue(s.defaultValue);
		ss.editable = ConvertValue(s.editable);
		ss.isSet = ConvertValue(s.isSet);
		ss.delegated = ConvertValue(s.delegated);
		ss.delegatedOwnerEntity = (System.UInt32)s.delegatedOwnerEntity;
		ss.group = ConvertValue(s.group);
		ss.description = ConvertValue(s.description);
		return ss;
	}

	internal static PropertyInfo_c ConvertValue(PropertyInfo s, ref PropertyInfo_c ss) {
		Core.CoreInterface.Core_PropertyInfo_init(ref ss);
		ss.name = ConvertValue(s.name);
		ss.type = (Int32)s.type;
		ss.subType = (Int32)s.subType;
		ss.value = ConvertValue(s.value);
		ss.user = ConvertValue(s.user);
		ss.defaultValue = ConvertValue(s.defaultValue);
		ss.editable = ConvertValue(s.editable);
		ss.isSet = ConvertValue(s.isSet);
		ss.delegated = ConvertValue(s.delegated);
		ss.delegatedOwnerEntity = (System.UInt32)s.delegatedOwnerEntity;
		ss.group = ConvertValue(s.group);
		ss.description = ConvertValue(s.description);
		return ss;
	}

	internal static PropertyInfoList ConvertValue(ref PropertyInfoList_c s) {
		PropertyInfoList list = new PropertyInfoList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(PropertyInfo_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			PropertyInfo_c value = (PropertyInfo_c)Marshal.PtrToStructure(p, typeof(PropertyInfo_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static PropertyInfoList_c ConvertValue(PropertyInfoList s, ref PropertyInfoList_c list) {
		Core.CoreInterface.Core_PropertyInfoList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			PropertyInfo_c elt = new PropertyInfo_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(PropertyInfo_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static PropertyInfoListList ConvertValue(ref PropertyInfoListList_c s) {
		PropertyInfoListList list = new PropertyInfoListList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(PropertyInfoList_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			PropertyInfoList_c value = (PropertyInfoList_c)Marshal.PtrToStructure(p, typeof(PropertyInfoList_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static PropertyInfoListList_c ConvertValue(PropertyInfoListList s, ref PropertyInfoListList_c list) {
		Core.CoreInterface.Core_PropertyInfoListList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			PropertyInfoList_c elt = new PropertyInfoList_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(PropertyInfoList_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static FilePathList ConvertValue(ref FilePathList_c s) {
		FilePathList list = new FilePathList((int)s.size);
		if (s.size==0) return list;

		IntPtr[] tab = new IntPtr[s.size];
		Marshal.Copy(s.ptr, tab, 0, (int)s.size);
		for (int i = 0; i < (int)s.size; ++i) {
			list.list[i] = ConvertValue(tab[i]);
		}
		return list;
	}

	internal static FilePathList_c ConvertValue(FilePathList s, ref FilePathList_c list) {
		Core.CoreInterface.Core_FilePathList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		IntPtr[] tab = new IntPtr[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = ConvertValue(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static Date ConvertValue(ref Date_c s) {
		Date ss = new Date();
		ss.year = (System.Int32)s.year;
		ss.month = (System.Int32)s.month;
		ss.day = (System.Int32)s.day;
		return ss;
	}

	internal static Date_c ConvertValue(Date s, ref Date_c ss) {
		Core.CoreInterface.Core_Date_init(ref ss);
		ss.year = (Int32)s.year;
		ss.month = (Int32)s.month;
		ss.day = (Int32)s.day;
		return ss;
	}

	internal static DoubleList ConvertValue(ref DoubleList_c s) {
		DoubleList list = new DoubleList((int)s.size);
		if (s.size > 0)
			Marshal.Copy(s.ptr, list.list, 0, (int)s.size);
		return list;
	}

	internal static DoubleList_c ConvertValue(DoubleList s, ref DoubleList_c list) {
		Core.CoreInterface.Core_DoubleList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size > 0)
			Marshal.Copy(s.list, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static DoubleListList ConvertValue(ref DoubleListList_c s) {
		DoubleListList list = new DoubleListList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(DoubleList_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			DoubleList_c value = (DoubleList_c)Marshal.PtrToStructure(p, typeof(DoubleList_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static DoubleListList_c ConvertValue(DoubleListList s, ref DoubleListList_c list) {
		Core.CoreInterface.Core_DoubleListList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			DoubleList_c elt = new DoubleList_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(DoubleList_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static LicenseInfos ConvertValue(ref LicenseInfos_c s) {
		LicenseInfos ss = new LicenseInfos();
		ss.version = ConvertValue(s.version);
		ss.customerName = ConvertValue(s.customerName);
		ss.customerCompany = ConvertValue(s.customerCompany);
		ss.customerEmail = ConvertValue(s.customerEmail);
		ss.isFloating = ConvertValue(s.isFloating);
		ss.isRevocable = ConvertValue(s.isRevocable);
		ss.startDate = ConvertValue(ref s.startDate);
		ss.endDate = ConvertValue(ref s.endDate);
		ss.invalidReasons = ConvertValue(ref s.invalidReasons);
		return ss;
	}

	internal static LicenseInfos_c ConvertValue(LicenseInfos s, ref LicenseInfos_c ss) {
		Core.CoreInterface.Core_LicenseInfos_init(ref ss);
		ss.version = ConvertValue(s.version);
		ss.customerName = ConvertValue(s.customerName);
		ss.customerCompany = ConvertValue(s.customerCompany);
		ss.customerEmail = ConvertValue(s.customerEmail);
		ss.isFloating = ConvertValue(s.isFloating);
		ss.isRevocable = ConvertValue(s.isRevocable);
		ConvertValue(s.startDate, ref ss.startDate);
		ConvertValue(s.endDate, ref ss.endDate);
		ConvertValue(s.invalidReasons, ref ss.invalidReasons);
		return ss;
	}

	internal static BoolList ConvertValue(ref BoolList_c s) {
		BoolList list = new BoolList((int)s.size);
		if (s.size==0) return list;

		int[] tab = new int[s.size];
		Marshal.Copy(s.ptr, tab, 0, (int)s.size);
			list.list = CopyMemory<System.Boolean>(s.ptr, (int)s.size);
		return list;
	}

	internal static BoolList_c ConvertValue(BoolList s, ref BoolList_c list) {
		Core.CoreInterface.Core_BoolList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = ConvertValue(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static EventDesc ConvertValue(ref EventDesc_c s) {
		EventDesc ss = new EventDesc();
		ss.module = ConvertValue(s.module);
		ss.name = ConvertValue(s.name);
		ss.description = ConvertValue(s.description);
		ss.parameters = ConvertValue(ref s.parameters);
		return ss;
	}

	internal static EventDesc_c ConvertValue(EventDesc s, ref EventDesc_c ss) {
		Core.CoreInterface.Core_EventDesc_init(ref ss);
		ss.module = ConvertValue(s.module);
		ss.name = ConvertValue(s.name);
		ss.description = ConvertValue(s.description);
		ConvertValue(s.parameters, ref ss.parameters);
		return ss;
	}

	internal static EventDescList ConvertValue(ref EventDescList_c s) {
		EventDescList list = new EventDescList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(EventDesc_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			EventDesc_c value = (EventDesc_c)Marshal.PtrToStructure(p, typeof(EventDesc_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static EventDescList_c ConvertValue(EventDescList s, ref EventDescList_c list) {
		Core.CoreInterface.Core_EventDescList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			EventDesc_c elt = new EventDesc_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(EventDesc_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static EntityList ConvertValue(ref EntityList_c s) {
		EntityList list = new EntityList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static EntityList_c ConvertValue(EntityList s, ref EntityList_c list) {
		Core.CoreInterface.Core_EntityList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static EntityListList ConvertValue(ref EntityListList_c s) {
		EntityListList list = new EntityListList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(EntityList_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			EntityList_c value = (EntityList_c)Marshal.PtrToStructure(p, typeof(EntityList_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static EntityListList_c ConvertValue(EntityListList s, ref EntityListList_c list) {
		Core.CoreInterface.Core_EntityListList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			EntityList_c elt = new EntityList_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(EntityList_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static ULongList ConvertValue(ref ULongList_c s) {
		ULongList list = new ULongList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt64>(s.ptr, (int)s.size);
		return list;
	}

	internal static ULongList_c ConvertValue(ULongList s, ref ULongList_c list) {
		Core.CoreInterface.Core_ULongList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		long[] tab = new long[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (long)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static ByteList ConvertValue(ref ByteList_c s) {
		ByteList list = new ByteList((int)s.size);
		if (s.size > 0)
			Marshal.Copy(s.ptr, list.list, 0, (int)s.size);
		return list;
	}

	internal static ByteList_c ConvertValue(ByteList s, ref ByteList_c list) {
		Core.CoreInterface.Core_ByteList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size > 0)
			Marshal.Copy(s.list, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static WebLicenseInfo ConvertValue(ref WebLicenseInfo_c s) {
		WebLicenseInfo ss = new WebLicenseInfo();
		ss.id = (System.UInt32)s.id;
		ss.product = ConvertValue(s.product);
		ss.validity = ConvertValue(ref s.validity);
		ss.count = (System.Int32)s.count;
		ss.inUse = (System.Int32)s.inUse;
		ss.revoke = (System.Int32)s.revoke;
		ss.description = ConvertValue(s.description);
		ss.onMachine = ConvertValue(s.onMachine);
		ss.current = ConvertValue(s.current);
		return ss;
	}

	internal static WebLicenseInfo_c ConvertValue(WebLicenseInfo s, ref WebLicenseInfo_c ss) {
		Core.CoreInterface.Core_WebLicenseInfo_init(ref ss);
		ss.id = (System.UInt32)s.id;
		ss.product = ConvertValue(s.product);
		ConvertValue(s.validity, ref ss.validity);
		ss.count = (Int32)s.count;
		ss.inUse = (Int32)s.inUse;
		ss.revoke = (Int32)s.revoke;
		ss.description = ConvertValue(s.description);
		ss.onMachine = ConvertValue(s.onMachine);
		ss.current = ConvertValue(s.current);
		return ss;
	}

	internal static WebLicenseInfoList ConvertValue(ref WebLicenseInfoList_c s) {
		WebLicenseInfoList list = new WebLicenseInfoList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(WebLicenseInfo_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			WebLicenseInfo_c value = (WebLicenseInfo_c)Marshal.PtrToStructure(p, typeof(WebLicenseInfo_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static WebLicenseInfoList_c ConvertValue(WebLicenseInfoList s, ref WebLicenseInfoList_c list) {
		Core.CoreInterface.Core_WebLicenseInfoList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			WebLicenseInfo_c elt = new WebLicenseInfo_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(WebLicenseInfo_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static IntListList ConvertValue(ref IntListList_c s) {
		IntListList list = new IntListList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(IntList_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			IntList_c value = (IntList_c)Marshal.PtrToStructure(p, typeof(IntList_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static IntListList_c ConvertValue(IntListList s, ref IntListList_c list) {
		Core.CoreInterface.Core_IntListList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			IntList_c elt = new IntList_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(IntList_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Format ConvertValue(ref Format_c s) {
		Format ss = new Format();
		ss.name = ConvertValue(s.name);
		ss.extensions = ConvertValue(ref s.extensions);
		return ss;
	}

	internal static Format_c ConvertValue(Format s, ref Format_c ss) {
		Core.CoreInterface.Core_Format_init(ref ss);
		ss.name = ConvertValue(s.name);
		ConvertValue(s.extensions, ref ss.extensions);
		return ss;
	}

	internal static FormatList ConvertValue(ref FormatList_c s) {
		FormatList list = new FormatList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(Format_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			Format_c value = (Format_c)Marshal.PtrToStructure(p, typeof(Format_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static FormatList_c ConvertValue(FormatList s, ref FormatList_c list) {
		Core.CoreInterface.Core_FormatList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Format_c elt = new Format_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Format_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static AutoValueReturn ConvertValue(ref AutoValueReturn_c s) {
		AutoValueReturn ss = new AutoValueReturn();
		ss.values = ConvertValue(ref s.values);
		ss.message = ConvertValue(s.message);
		return ss;
	}

	internal static AutoValueReturn_c ConvertValue(AutoValueReturn s, ref AutoValueReturn_c ss) {
		Core.CoreInterface.Core_AutoValueReturn_init(ref ss);
		ConvertValue(s.values, ref ss.values);
		ss.message = ConvertValue(s.message);
		return ss;
	}

	internal static Color ConvertValue(ref Color_c s) {
		Color ss = new Color();
		ss.r = (System.Double)s.r;
		ss.g = (System.Double)s.g;
		ss.b = (System.Double)s.b;
		return ss;
	}

	internal static Color_c ConvertValue(Color s, ref Color_c ss) {
		Core.CoreInterface.Core_Color_init(ref ss);
		ss.r = (System.Double)s.r;
		ss.g = (System.Double)s.g;
		ss.b = (System.Double)s.b;
		return ss;
	}

	internal static ColorList ConvertValue(ref ColorList_c s) {
		ColorList list = new ColorList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<Color>(s.ptr, (int)s.size);
		return list;
	}

	internal static ColorList_c ConvertValue(ColorList s, ref ColorList_c list) {
		Core.CoreInterface.Core_ColorList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Color_c elt = new Color_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Color_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static PtrList ConvertValue(ref PtrList_c s) {
		PtrList list = new PtrList((int)s.size);
		if (s.size > 0)
			Marshal.Copy(s.ptr, list.list, 0, (int)s.size);
		return list;
	}

	internal static PtrList_c ConvertValue(PtrList s, ref PtrList_c list) {
		Core.CoreInterface.Core_PtrList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size > 0)
			Marshal.Copy(s.list, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static ColorAlpha ConvertValue(ref ColorAlpha_c s) {
		ColorAlpha ss = new ColorAlpha();
		ss.r = (System.Double)s.r;
		ss.g = (System.Double)s.g;
		ss.b = (System.Double)s.b;
		ss.a = (System.Double)s.a;
		return ss;
	}

	internal static ColorAlpha_c ConvertValue(ColorAlpha s, ref ColorAlpha_c ss) {
		Core.CoreInterface.Core_ColorAlpha_init(ref ss);
		ss.r = (System.Double)s.r;
		ss.g = (System.Double)s.g;
		ss.b = (System.Double)s.b;
		ss.a = (System.Double)s.a;
		return ss;
	}

	internal static ColorAlphaList ConvertValue(ref ColorAlphaList_c s) {
		ColorAlphaList list = new ColorAlphaList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<ColorAlpha>(s.ptr, (int)s.size);
		return list;
	}

	internal static ColorAlphaList_c ConvertValue(ColorAlphaList s, ref ColorAlphaList_c list) {
		Core.CoreInterface.Core_ColorAlphaList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			ColorAlpha_c elt = new ColorAlpha_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(ColorAlpha_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static BoundedInteger ConvertValue(ref BoundedInteger_c s) {
		BoundedInteger ss = new BoundedInteger();
		ss.value = (System.Int32)s.value;
		ss.min = (System.Int32)s.min;
		ss.max = (System.Int32)s.max;
		return ss;
	}

	internal static BoundedInteger_c ConvertValue(BoundedInteger s, ref BoundedInteger_c ss) {
		Core.CoreInterface.Core_BoundedInteger_init(ref ss);
		ss.value = (Int32)s.value;
		ss.min = (Int32)s.min;
		ss.max = (Int32)s.max;
		return ss;
	}

	internal static IdentPair ConvertValue(ref IdentPair_c s) {
		IdentPair ss = new IdentPair();
		ss.key = (System.UInt32)s.key;
		ss.value = (System.UInt32)s.value;
		return ss;
	}

	internal static IdentPair_c ConvertValue(IdentPair s, ref IdentPair_c ss) {
		Core.CoreInterface.Core_IdentPair_init(ref ss);
		ss.key = (System.UInt32)s.key;
		ss.value = (System.UInt32)s.value;
		return ss;
	}

	internal static EnumPropertyInfo ConvertValue(ref EnumPropertyInfo_c s) {
		EnumPropertyInfo ss = new EnumPropertyInfo();
		ss.name = ConvertValue(s.name);
		ss.values = ConvertValue(ref s.values);
		ss.labels = ConvertValue(ref s.labels);
		return ss;
	}

	internal static EnumPropertyInfo_c ConvertValue(EnumPropertyInfo s, ref EnumPropertyInfo_c ss) {
		Core.CoreInterface.Core_EnumPropertyInfo_init(ref ss);
		ss.name = ConvertValue(s.name);
		ConvertValue(s.values, ref ss.values);
		ConvertValue(s.labels, ref ss.labels);
		return ss;
	}

	internal static IdentPairList ConvertValue(ref IdentPairList_c s) {
		IdentPairList list = new IdentPairList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<IdentPair>(s.ptr, (int)s.size);
		return list;
	}

	internal static IdentPairList_c ConvertValue(IdentPairList s, ref IdentPairList_c list) {
		Core.CoreInterface.Core_IdentPairList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			IdentPair_c elt = new IdentPair_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(IdentPair_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static StringPairListList ConvertValue(ref StringPairListList_c s) {
		StringPairListList list = new StringPairListList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(StringPairList_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			StringPairList_c value = (StringPairList_c)Marshal.PtrToStructure(p, typeof(StringPairList_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static StringPairListList_c ConvertValue(StringPairListList s, ref StringPairListList_c list) {
		Core.CoreInterface.Core_StringPairListList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			StringPairList_c elt = new StringPairList_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(StringPairList_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static GetLicenseServerReturn ConvertValue(ref GetLicenseServerReturn_c s) {
		GetLicenseServerReturn ss = new GetLicenseServerReturn();
		ss.serverHost = ConvertValue(s.serverHost);
		ss.serverPort = (System.UInt16)s.serverPort;
		ss.useFlexLM = ConvertValue(s.useFlexLM);
		return ss;
	}

	internal static GetLicenseServerReturn_c ConvertValue(GetLicenseServerReturn s, ref GetLicenseServerReturn_c ss) {
		ss.serverHost = ConvertValue(s.serverHost);
		ss.serverPort = (System.UInt16)s.serverPort;
		ss.useFlexLM = ConvertValue(s.useFlexLM);
		return ss;
	}

	internal static AvailableMemoryReturn ConvertValue(ref AvailableMemoryReturn_c s) {
		AvailableMemoryReturn ss = new AvailableMemoryReturn();
		ss.availVirt = (System.Int64)s.availVirt;
		ss.totalVirt = (System.Int64)s.totalVirt;
		ss.availPhys = (System.Int64)s.availPhys;
		ss.totalPhys = (System.Int64)s.totalPhys;
		return ss;
	}

	internal static AvailableMemoryReturn_c ConvertValue(AvailableMemoryReturn s, ref AvailableMemoryReturn_c ss) {
		ss.availVirt = (System.Int64)s.availVirt;
		ss.totalVirt = (System.Int64)s.totalVirt;
		ss.availPhys = (System.Int64)s.availPhys;
		ss.totalPhys = (System.Int64)s.totalPhys;
		return ss;
	}

	internal static CheckForUpdatesReturn ConvertValue(ref CheckForUpdatesReturn_c s) {
		CheckForUpdatesReturn ss = new CheckForUpdatesReturn();
		ss.newVersionAvailable = ConvertValue(s.newVersionAvailable);
		ss.newVersion = ConvertValue(s.newVersion);
		ss.newVersionLink = ConvertValue(s.newVersionLink);
		return ss;
	}

	internal static CheckForUpdatesReturn_c ConvertValue(CheckForUpdatesReturn s, ref CheckForUpdatesReturn_c ss) {
		ss.newVersionAvailable = ConvertValue(s.newVersionAvailable);
		ss.newVersion = ConvertValue(s.newVersion);
		ss.newVersionLink = ConvertValue(s.newVersionLink);
		return ss;
	}

	internal static GetInterfaceLoggerConfigurationReturn ConvertValue(ref GetInterfaceLoggerConfigurationReturn_c s) {
		GetInterfaceLoggerConfigurationReturn ss = new GetInterfaceLoggerConfigurationReturn();
		ss.functionEnabled = ConvertValue(s.functionEnabled);
		ss.parametersEnabled = ConvertValue(s.parametersEnabled);
		ss.executionTimeEnabled = ConvertValue(s.executionTimeEnabled);
		return ss;
	}

	internal static GetInterfaceLoggerConfigurationReturn_c ConvertValue(GetInterfaceLoggerConfigurationReturn s, ref GetInterfaceLoggerConfigurationReturn_c ss) {
		ss.functionEnabled = ConvertValue(s.functionEnabled);
		ss.parametersEnabled = ConvertValue(s.parametersEnabled);
		ss.executionTimeEnabled = ConvertValue(s.executionTimeEnabled);
		return ss;
	}

		#endregion

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getLastError();

		public static string GetLastError()
		{
			return ConvertValue(Core_getLastError());
		}

		#region 

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_cloneEntity(IntPtr _pxz_session_, System.UInt32 entity);
		/// <summary>
		/// Clone an entity
		/// </summary>
		/// <param name="entity">The entity to clone</param>
		public System.UInt32 CloneEntity(System.UInt32 entity) {
			var ret = Core_cloneEntity(api.Session, entity);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_configureFunctionLogger(IntPtr _pxz_session_, string functionName, System.Byte enableFunction, System.Byte enableParameters, System.Byte enableExecutionTime);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="functionName"></param>
		/// <param name="enableFunction"></param>
		/// <param name="enableParameters"></param>
		/// <param name="enableExecutionTime"></param>
		public void ConfigureFunctionLogger(System.String functionName, System.Boolean enableFunction, System.Boolean enableParameters, System.Boolean enableExecutionTime) {
			Core_configureFunctionLogger(api.Session, functionName, Convert.ToByte(enableFunction), Convert.ToByte(enableParameters), Convert.ToByte(enableExecutionTime));
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_crash(IntPtr _pxz_session_);
		/// <summary>
		/// The only function in Pixyz to crash except undo/redo
		/// </summary>
		public void Crash() {
			Core_crash(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_createEntity(IntPtr _pxz_session_, System.UInt32 type);
		/// <summary>
		/// Create an entity
		/// </summary>
		/// <param name="type">The type of entity to create</param>
		public System.UInt32 CreateEntity(System.UInt32 type) {
			var ret = Core_createEntity(api.Session, type);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_deleteEntities(IntPtr _pxz_session_, EntityList_c entities);
		/// <summary>
		/// Delete a set of entities
		/// </summary>
		/// <param name="entities">List of entity to delete</param>
		public void DeleteEntities(EntityList entities) {
			var entities_c = new Core.EntityList_c();
			ConvertValue((Core.EntityList)entities, ref entities_c);
			Core_deleteEntities(api.Session, entities_c);
			Core.CoreInterface.Core_EntityList_free(ref entities_c);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_resetSession(IntPtr _pxz_session_);
		/// <summary>
		/// Clear all the current session (all unsaved work will be lost)
		/// </summary>
		public void ResetSession() {
			Core_resetSession(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_unsavedUserChanges(IntPtr _pxz_session_);
		/// <summary>
		/// Returns true if the user has made changes to the project
		/// </summary>
		public System.Boolean UnsavedUserChanges() {
			var ret = Core_unsavedUserChanges(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Boolean)(0 != ret);
		}

		private delegate void AfterEntityPropertyChangedDelegate(System.IntPtr userdata, System.UInt32 entity, System.String property, System.Int32 entityType);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addAfterEntityPropertyChangedCallback(IntPtr _pxz_session_, AfterEntityPropertyChangedDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeAfterEntityPropertyChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addAfterEntityPropertyChangedCallback(AfterEntityPropertyChangedDelegate callback, System.IntPtr userdata) {
			return Core_addAfterEntityPropertyChangedCallback(api.Session, callback, userdata);
		}

		private void removeAfterEntityPropertyChangedCallback(System.UInt32 id) {
			Core_removeAfterEntityPropertyChangedCallback(api.Session, id);
		}

		public class AfterEntityPropertyChangedTask : PixyzCallbackTask
		{
			public struct Params
			{
				public System.UInt32 entity;
				public System.String property;
				public System.Int32 entityType;

				public Params(System.UInt32 entity, System.String property, System.Int32 entityType)
				{
					this.entity = entity;
					this.property = property;
					this.entityType = entityType;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private CoreInterface iface;

				public Execution(CoreInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					AfterEntityPropertyChangedDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addAfterEntityPropertyChangedCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeAfterEntityPropertyChangedCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, System.UInt32 entity, System.String property, System.Int32 entityType)
				{
					try
					{
						_params.Enqueue(new Params(entity, property, entityType));

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<AfterEntityPropertyChangedTask.Params> WaitAfterEntityPropertyChanged(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new AfterEntityPropertyChangedTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnAfterEntityPropertyChanged(Action<AfterEntityPropertyChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			AfterEntityPropertyChangedTask.Execution task = new AfterEntityPropertyChangedTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnAfterEntityPropertyChanged(Action<AfterEntityPropertyChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnAfterEntityPropertyChanged(action, cancelSource);
		}
		private delegate void AfterModulePropertyChangedDelegate(System.IntPtr userdata, System.String module, System.String property);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addAfterModulePropertyChangedCallback(IntPtr _pxz_session_, AfterModulePropertyChangedDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeAfterModulePropertyChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addAfterModulePropertyChangedCallback(AfterModulePropertyChangedDelegate callback, System.IntPtr userdata) {
			return Core_addAfterModulePropertyChangedCallback(api.Session, callback, userdata);
		}

		private void removeAfterModulePropertyChangedCallback(System.UInt32 id) {
			Core_removeAfterModulePropertyChangedCallback(api.Session, id);
		}

		public class AfterModulePropertyChangedTask : PixyzCallbackTask
		{
			public struct Params
			{
				public System.String module;
				public System.String property;

				public Params(System.String module, System.String property)
				{
					this.module = module;
					this.property = property;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private CoreInterface iface;

				public Execution(CoreInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					AfterModulePropertyChangedDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addAfterModulePropertyChangedCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeAfterModulePropertyChangedCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, System.String module, System.String property)
				{
					try
					{
						_params.Enqueue(new Params(module, property));

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<AfterModulePropertyChangedTask.Params> WaitAfterModulePropertyChanged(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new AfterModulePropertyChangedTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnAfterModulePropertyChanged(Action<AfterModulePropertyChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			AfterModulePropertyChangedTask.Execution task = new AfterModulePropertyChangedTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnAfterModulePropertyChanged(Action<AfterModulePropertyChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnAfterModulePropertyChanged(action, cancelSource);
		}
		private delegate void AtExitDelegate(System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addAtExitCallback(IntPtr _pxz_session_, AtExitDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeAtExitCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addAtExitCallback(AtExitDelegate callback, System.IntPtr userdata) {
			return Core_addAtExitCallback(api.Session, callback, userdata);
		}

		private void removeAtExitCallback(System.UInt32 id) {
			Core_removeAtExitCallback(api.Session, id);
		}

		public class AtExitTask : PixyzCallbackTask
		{
			public struct Params
			{
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private CoreInterface iface;

				public Execution(CoreInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					AtExitDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addAtExitCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeAtExitCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata)
				{
					try
					{
						_params.Enqueue(new Params());

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<AtExitTask.Params> WaitAtExit(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new AtExitTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnAtExit(Action<AtExitTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			AtExitTask.Execution task = new AtExitTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnAtExit(Action<AtExitTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnAtExit(action, cancelSource);
		}
		private delegate void BeforeEntityPropertyChangedDelegate(System.IntPtr userdata, System.UInt32 entity, System.String property);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addBeforeEntityPropertyChangedCallback(IntPtr _pxz_session_, BeforeEntityPropertyChangedDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeBeforeEntityPropertyChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addBeforeEntityPropertyChangedCallback(BeforeEntityPropertyChangedDelegate callback, System.IntPtr userdata) {
			return Core_addBeforeEntityPropertyChangedCallback(api.Session, callback, userdata);
		}

		private void removeBeforeEntityPropertyChangedCallback(System.UInt32 id) {
			Core_removeBeforeEntityPropertyChangedCallback(api.Session, id);
		}

		public class BeforeEntityPropertyChangedTask : PixyzCallbackTask
		{
			public struct Params
			{
				public System.UInt32 entity;
				public System.String property;

				public Params(System.UInt32 entity, System.String property)
				{
					this.entity = entity;
					this.property = property;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private CoreInterface iface;

				public Execution(CoreInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					BeforeEntityPropertyChangedDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addBeforeEntityPropertyChangedCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeBeforeEntityPropertyChangedCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, System.UInt32 entity, System.String property)
				{
					try
					{
						_params.Enqueue(new Params(entity, property));

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<BeforeEntityPropertyChangedTask.Params> WaitBeforeEntityPropertyChanged(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new BeforeEntityPropertyChangedTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnBeforeEntityPropertyChanged(Action<BeforeEntityPropertyChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			BeforeEntityPropertyChangedTask.Execution task = new BeforeEntityPropertyChangedTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnBeforeEntityPropertyChanged(Action<BeforeEntityPropertyChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnBeforeEntityPropertyChanged(action, cancelSource);
		}
		private delegate void BeforeModulePropertyChangedDelegate(System.IntPtr userdata, System.String module, System.String property);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addBeforeModulePropertyChangedCallback(IntPtr _pxz_session_, BeforeModulePropertyChangedDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeBeforeModulePropertyChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addBeforeModulePropertyChangedCallback(BeforeModulePropertyChangedDelegate callback, System.IntPtr userdata) {
			return Core_addBeforeModulePropertyChangedCallback(api.Session, callback, userdata);
		}

		private void removeBeforeModulePropertyChangedCallback(System.UInt32 id) {
			Core_removeBeforeModulePropertyChangedCallback(api.Session, id);
		}

		public class BeforeModulePropertyChangedTask : PixyzCallbackTask
		{
			public struct Params
			{
				public System.String module;
				public System.String property;

				public Params(System.String module, System.String property)
				{
					this.module = module;
					this.property = property;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private CoreInterface iface;

				public Execution(CoreInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					BeforeModulePropertyChangedDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addBeforeModulePropertyChangedCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeBeforeModulePropertyChangedCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, System.String module, System.String property)
				{
					try
					{
						_params.Enqueue(new Params(module, property));

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<BeforeModulePropertyChangedTask.Params> WaitBeforeModulePropertyChanged(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new BeforeModulePropertyChangedTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnBeforeModulePropertyChanged(Action<BeforeModulePropertyChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			BeforeModulePropertyChangedTask.Execution task = new BeforeModulePropertyChangedTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnBeforeModulePropertyChanged(Action<BeforeModulePropertyChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnBeforeModulePropertyChanged(action, cancelSource);
		}
		private delegate void BeforeSessionResetDelegate(System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addBeforeSessionResetCallback(IntPtr _pxz_session_, BeforeSessionResetDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeBeforeSessionResetCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addBeforeSessionResetCallback(BeforeSessionResetDelegate callback, System.IntPtr userdata) {
			return Core_addBeforeSessionResetCallback(api.Session, callback, userdata);
		}

		private void removeBeforeSessionResetCallback(System.UInt32 id) {
			Core_removeBeforeSessionResetCallback(api.Session, id);
		}

		public class BeforeSessionResetTask : PixyzCallbackTask
		{
			public struct Params
			{
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private CoreInterface iface;

				public Execution(CoreInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					BeforeSessionResetDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addBeforeSessionResetCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeBeforeSessionResetCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata)
				{
					try
					{
						_params.Enqueue(new Params());

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<BeforeSessionResetTask.Params> WaitBeforeSessionReset(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new BeforeSessionResetTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnBeforeSessionReset(Action<BeforeSessionResetTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			BeforeSessionResetTask.Execution task = new BeforeSessionResetTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnBeforeSessionReset(Action<BeforeSessionResetTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnBeforeSessionReset(action, cancelSource);
		}
		private delegate void CurrentFileChangedDelegate(System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addCurrentFileChangedCallback(IntPtr _pxz_session_, CurrentFileChangedDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeCurrentFileChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addCurrentFileChangedCallback(CurrentFileChangedDelegate callback, System.IntPtr userdata) {
			return Core_addCurrentFileChangedCallback(api.Session, callback, userdata);
		}

		private void removeCurrentFileChangedCallback(System.UInt32 id) {
			Core_removeCurrentFileChangedCallback(api.Session, id);
		}

		public class CurrentFileChangedTask : PixyzCallbackTask
		{
			public struct Params
			{
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private CoreInterface iface;

				public Execution(CoreInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					CurrentFileChangedDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addCurrentFileChangedCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeCurrentFileChangedCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata)
				{
					try
					{
						_params.Enqueue(new Params());

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<CurrentFileChangedTask.Params> WaitCurrentFileChanged(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new CurrentFileChangedTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnCurrentFileChanged(Action<CurrentFileChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			CurrentFileChangedTask.Execution task = new CurrentFileChangedTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnCurrentFileChanged(Action<CurrentFileChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnCurrentFileChanged(action, cancelSource);
		}
		private delegate void EnteringUnsafeModeDelegate(System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addEnteringUnsafeModeCallback(IntPtr _pxz_session_, EnteringUnsafeModeDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeEnteringUnsafeModeCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addEnteringUnsafeModeCallback(EnteringUnsafeModeDelegate callback, System.IntPtr userdata) {
			return Core_addEnteringUnsafeModeCallback(api.Session, callback, userdata);
		}

		private void removeEnteringUnsafeModeCallback(System.UInt32 id) {
			Core_removeEnteringUnsafeModeCallback(api.Session, id);
		}

		public class EnteringUnsafeModeTask : PixyzCallbackTask
		{
			public struct Params
			{
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private CoreInterface iface;

				public Execution(CoreInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					EnteringUnsafeModeDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addEnteringUnsafeModeCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeEnteringUnsafeModeCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata)
				{
					try
					{
						_params.Enqueue(new Params());

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<EnteringUnsafeModeTask.Params> WaitEnteringUnsafeMode(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new EnteringUnsafeModeTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnEnteringUnsafeMode(Action<EnteringUnsafeModeTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			EnteringUnsafeModeTask.Execution task = new EnteringUnsafeModeTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnEnteringUnsafeMode(Action<EnteringUnsafeModeTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnEnteringUnsafeMode(action, cancelSource);
		}
		private delegate void LeavingUnsafeModeDelegate(System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addLeavingUnsafeModeCallback(IntPtr _pxz_session_, LeavingUnsafeModeDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeLeavingUnsafeModeCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addLeavingUnsafeModeCallback(LeavingUnsafeModeDelegate callback, System.IntPtr userdata) {
			return Core_addLeavingUnsafeModeCallback(api.Session, callback, userdata);
		}

		private void removeLeavingUnsafeModeCallback(System.UInt32 id) {
			Core_removeLeavingUnsafeModeCallback(api.Session, id);
		}

		public class LeavingUnsafeModeTask : PixyzCallbackTask
		{
			public struct Params
			{
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private CoreInterface iface;

				public Execution(CoreInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					LeavingUnsafeModeDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addLeavingUnsafeModeCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeLeavingUnsafeModeCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata)
				{
					try
					{
						_params.Enqueue(new Params());

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<LeavingUnsafeModeTask.Params> WaitLeavingUnsafeMode(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new LeavingUnsafeModeTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnLeavingUnsafeMode(Action<LeavingUnsafeModeTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			LeavingUnsafeModeTask.Execution task = new LeavingUnsafeModeTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnLeavingUnsafeMode(Action<LeavingUnsafeModeTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnLeavingUnsafeMode(action, cancelSource);
		}
		private delegate void OnConsoleMessageDelegate(System.IntPtr userdata, System.String text, Verbose verboseLevel);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addOnConsoleMessageCallback(IntPtr _pxz_session_, OnConsoleMessageDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeOnConsoleMessageCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addOnConsoleMessageCallback(OnConsoleMessageDelegate callback, System.IntPtr userdata) {
			return Core_addOnConsoleMessageCallback(api.Session, callback, userdata);
		}

		private void removeOnConsoleMessageCallback(System.UInt32 id) {
			Core_removeOnConsoleMessageCallback(api.Session, id);
		}

		public class OnConsoleMessageTask : PixyzCallbackTask
		{
			public struct Params
			{
				public System.String text;
				public Verbose verboseLevel;

				public Params(System.String text, Verbose verboseLevel)
				{
					this.text = text;
					this.verboseLevel = verboseLevel;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private CoreInterface iface;

				public Execution(CoreInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					OnConsoleMessageDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addOnConsoleMessageCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeOnConsoleMessageCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, System.String text, Verbose verboseLevel)
				{
					try
					{
						_params.Enqueue(new Params(text, verboseLevel));

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<OnConsoleMessageTask.Params> WaitOnConsoleMessage(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new OnConsoleMessageTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnOnConsoleMessage(Action<OnConsoleMessageTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			OnConsoleMessageTask.Execution task = new OnConsoleMessageTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnOnConsoleMessage(Action<OnConsoleMessageTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnOnConsoleMessage(action, cancelSource);
		}
		private delegate void OnSessionResetDelegate(System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addOnSessionResetCallback(IntPtr _pxz_session_, OnSessionResetDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeOnSessionResetCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addOnSessionResetCallback(OnSessionResetDelegate callback, System.IntPtr userdata) {
			return Core_addOnSessionResetCallback(api.Session, callback, userdata);
		}

		private void removeOnSessionResetCallback(System.UInt32 id) {
			Core_removeOnSessionResetCallback(api.Session, id);
		}

		public class OnSessionResetTask : PixyzCallbackTask
		{
			public struct Params
			{
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private CoreInterface iface;

				public Execution(CoreInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					OnSessionResetDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addOnSessionResetCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeOnSessionResetCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata)
				{
					try
					{
						_params.Enqueue(new Params());

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<OnSessionResetTask.Params> WaitOnSessionReset(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new OnSessionResetTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnOnSessionReset(Action<OnSessionResetTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			OnSessionResetTask.Execution task = new OnSessionResetTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnOnSessionReset(Action<OnSessionResetTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnOnSessionReset(action, cancelSource);
		}
		private delegate void ProgressChangedDelegate(System.IntPtr userdata, System.Int32 progress);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addProgressChangedCallback(IntPtr _pxz_session_, ProgressChangedDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeProgressChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addProgressChangedCallback(ProgressChangedDelegate callback, System.IntPtr userdata) {
			return Core_addProgressChangedCallback(api.Session, callback, userdata);
		}

		private void removeProgressChangedCallback(System.UInt32 id) {
			Core_removeProgressChangedCallback(api.Session, id);
		}

		public class ProgressChangedTask : PixyzCallbackTask
		{
			public struct Params
			{
				public System.Int32 progress;

				public Params(System.Int32 progress)
				{
					this.progress = progress;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private CoreInterface iface;

				public Execution(CoreInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					ProgressChangedDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addProgressChangedCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeProgressChangedCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, System.Int32 progress)
				{
					try
					{
						_params.Enqueue(new Params(progress));

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<ProgressChangedTask.Params> WaitProgressChanged(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new ProgressChangedTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnProgressChanged(Action<ProgressChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			ProgressChangedTask.Execution task = new ProgressChangedTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnProgressChanged(Action<ProgressChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnProgressChanged(action, cancelSource);
		}
		private delegate void ProgressStepFinishedDelegate(System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addProgressStepFinishedCallback(IntPtr _pxz_session_, ProgressStepFinishedDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeProgressStepFinishedCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addProgressStepFinishedCallback(ProgressStepFinishedDelegate callback, System.IntPtr userdata) {
			return Core_addProgressStepFinishedCallback(api.Session, callback, userdata);
		}

		private void removeProgressStepFinishedCallback(System.UInt32 id) {
			Core_removeProgressStepFinishedCallback(api.Session, id);
		}

		public class ProgressStepFinishedTask : PixyzCallbackTask
		{
			public struct Params
			{
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private CoreInterface iface;

				public Execution(CoreInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					ProgressStepFinishedDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addProgressStepFinishedCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeProgressStepFinishedCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata)
				{
					try
					{
						_params.Enqueue(new Params());

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<ProgressStepFinishedTask.Params> WaitProgressStepFinished(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new ProgressStepFinishedTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnProgressStepFinished(Action<ProgressStepFinishedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			ProgressStepFinishedTask.Execution task = new ProgressStepFinishedTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnProgressStepFinished(Action<ProgressStepFinishedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnProgressStepFinished(action, cancelSource);
		}
		private delegate void ProgressStepStartDelegate(System.IntPtr userdata, System.String stepName);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addProgressStepStartCallback(IntPtr _pxz_session_, ProgressStepStartDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeProgressStepStartCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addProgressStepStartCallback(ProgressStepStartDelegate callback, System.IntPtr userdata) {
			return Core_addProgressStepStartCallback(api.Session, callback, userdata);
		}

		private void removeProgressStepStartCallback(System.UInt32 id) {
			Core_removeProgressStepStartCallback(api.Session, id);
		}

		public class ProgressStepStartTask : PixyzCallbackTask
		{
			public struct Params
			{
				public System.String stepName;

				public Params(System.String stepName)
				{
					this.stepName = stepName;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private CoreInterface iface;

				public Execution(CoreInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					ProgressStepStartDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addProgressStepStartCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeProgressStepStartCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, System.String stepName)
				{
					try
					{
						_params.Enqueue(new Params(stepName));

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<ProgressStepStartTask.Params> WaitProgressStepStart(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new ProgressStepStartTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnProgressStepStart(Action<ProgressStepStartTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			ProgressStepStartTask.Execution task = new ProgressStepStartTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnProgressStepStart(Action<ProgressStepStartTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnProgressStepStart(action, cancelSource);
		}
		#endregion

		#region DebugMessage

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_sendDebugMessage(IntPtr _pxz_session_, Int32 event_type);
		/// <summary>
		/// Sends a debug event
		/// </summary>
		/// <param name="event_type">The type of signal to emit</param>
		public void SendDebugMessage(System.Int32 event_type) {
			Core_sendDebugMessage(api.Session, event_type);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		private delegate void DebugEventDelegate(System.IntPtr userdata, System.Int32 event_type);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addDebugEventCallback(IntPtr _pxz_session_, DebugEventDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeDebugEventCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addDebugEventCallback(DebugEventDelegate callback, System.IntPtr userdata) {
			return Core_addDebugEventCallback(api.Session, callback, userdata);
		}

		private void removeDebugEventCallback(System.UInt32 id) {
			Core_removeDebugEventCallback(api.Session, id);
		}

		public class DebugEventTask : PixyzCallbackTask
		{
			public struct Params
			{
				public System.Int32 event_type;

				public Params(System.Int32 event_type)
				{
					this.event_type = event_type;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private CoreInterface iface;

				public Execution(CoreInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					DebugEventDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addDebugEventCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeDebugEventCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, System.Int32 event_type)
				{
					try
					{
						_params.Enqueue(new Params(event_type));

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<DebugEventTask.Params> WaitDebugEvent(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new DebugEventTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnDebugEvent(Action<DebugEventTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			DebugEventTask.Execution task = new DebugEventTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnDebugEvent(Action<DebugEventTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnDebugEvent(action, cancelSource);
		}
		#endregion

		#region Desc

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern EventDesc_c Core_getEvent(IntPtr _pxz_session_, string moduleName, string eventName);
		/// <summary>
		/// get EventDesc of an event
		/// </summary>
		/// <param name="moduleName">Target module name</param>
		/// <param name="eventName"></param>
		public EventDesc GetEvent(System.String moduleName, System.String eventName) {
			var ret = Core_getEvent(api.Session, moduleName, eventName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_EventDesc_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern EventDescList_c Core_getEvents(IntPtr _pxz_session_, string moduleName, string groupName);
		/// <summary>
		/// get events of a group
		/// </summary>
		/// <param name="moduleName">Target module name</param>
		/// <param name="groupName">Target group name</param>
		public EventDescList GetEvents(System.String moduleName, System.String groupName) {
			var ret = Core_getEvents(api.Session, moduleName, groupName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_EventDescList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern FunctionDesc_c Core_getFunction(IntPtr _pxz_session_, string moduleName, string functionName);
		/// <summary>
		/// get FunctionDesc of a function
		/// </summary>
		/// <param name="moduleName">Target module name</param>
		/// <param name="functionName">Target function name</param>
		public FunctionDesc GetFunction(System.String moduleName, System.String functionName) {
			var ret = Core_getFunction(api.Session, moduleName, functionName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_FunctionDesc_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern FunctionDescList_c Core_getFunctions(IntPtr _pxz_session_, string moduleName, string groupName);
		/// <summary>
		/// get functions of a group
		/// </summary>
		/// <param name="moduleName">Target module name</param>
		/// <param name="groupName">Target group name</param>
		public FunctionDescList GetFunctions(System.String moduleName, System.String groupName) {
			var ret = Core_getFunctions(api.Session, moduleName, groupName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_FunctionDescList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GroupDesc_c Core_getGroup(IntPtr _pxz_session_, string moduleName, string groupName);
		/// <summary>
		/// get a group desc from a specific module
		/// </summary>
		/// <param name="moduleName">Target module name</param>
		/// <param name="groupName">Target group name</param>
		public GroupDesc GetGroup(System.String moduleName, System.String groupName) {
			var ret = Core_getGroup(api.Session, moduleName, groupName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_GroupDesc_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GroupDescList_c Core_getGroups(IntPtr _pxz_session_, string moduleName);
		/// <summary>
		/// get all group desc of a module
		/// </summary>
		/// <param name="moduleName">Target module name</param>
		public GroupDescList GetGroups(System.String moduleName) {
			var ret = Core_getGroups(api.Session, moduleName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_GroupDescList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern TypeDescList_c Core_getModuleTypes(IntPtr _pxz_session_, string moduleName);
		/// <summary>
		/// get TypeDescList from a module name
		/// </summary>
		/// <param name="moduleName">Target module name</param>
		public TypeDescList GetModuleTypes(System.String moduleName) {
			var ret = Core_getModuleTypes(api.Session, moduleName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_TypeDescList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern ModuleDescList_c Core_getModules(IntPtr _pxz_session_);
		/// <summary>
		/// get all modules desc
		/// </summary>
		public ModuleDescList GetModules() {
			var ret = Core_getModules(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_ModuleDescList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern StringList_c Core_getModulesName(IntPtr _pxz_session_);
		/// <summary>
		/// get all modules name
		/// </summary>
		public StringList GetModulesName() {
			var ret = Core_getModulesName(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_StringList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern TypeDesc_c Core_getType(IntPtr _pxz_session_, string moduleName, string typeNameStr);
		/// <summary>
		/// get TypeDesc from a type name
		/// </summary>
		/// <param name="moduleName">Target module name</param>
		/// <param name="typeNameStr">Target type name</param>
		public TypeDesc GetType(System.String moduleName, System.String typeNameStr) {
			var ret = Core_getType(api.Session, moduleName, typeNameStr);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_TypeDesc_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern StringPairList_c Core_getTypeAttributes(IntPtr _pxz_session_, string moduleName, string typeNameStr);
		/// <summary>
		/// get attributes TypeDesc from a type name
		/// </summary>
		/// <param name="moduleName">Target module name</param>
		/// <param name="typeNameStr">Target type name</param>
		public StringPairList GetTypeAttributes(System.String moduleName, System.String typeNameStr) {
			var ret = Core_getTypeAttributes(api.Session, moduleName, typeNameStr);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_StringPairList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_softStopAsyncEventManager(IntPtr _pxz_session_);
		/// <summary>
		/// Ask the async EventManager to join the main thread, enableEventManagerAsync must be enable
		/// </summary>
		public void SoftStopAsyncEventManager() {
			Core_softStopAsyncEventManager(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region Processing locker

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_lockProcessing(IntPtr _pxz_session_);
		/// <summary>
		/// Lock the mutex that ensure no processing is done between lock/unlock
		/// </summary>
		public void LockProcessing() {
			Core_lockProcessing(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_tryLockProcessing(IntPtr _pxz_session_);
		/// <summary>
		/// Try to lock the mutex that ensure no processing is done between lock/unlock, returns true if the mutex has been locked, false if it was already locked
		/// </summary>
		public System.Boolean TryLockProcessing() {
			var ret = Core_tryLockProcessing(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Boolean)(0 != ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_unlockProcessing(IntPtr _pxz_session_);
		/// <summary>
		/// Unlock the mutex that ensure no processing is done between lock/unlock
		/// </summary>
		public void UnlockProcessing() {
			Core_unlockProcessing(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region UI

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_askString(IntPtr _pxz_session_, string msg, string defaultValue);
		/// <summary>
		/// Invite the user to enter a string
		/// </summary>
		/// <param name="msg">Message to display</param>
		/// <param name="defaultValue">Message to display</param>
		public System.String AskString(System.String msg, System.String defaultValue = "") {
			var ret = Core_askString(api.Session, msg, defaultValue);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return ConvertValue(ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_askYesNo(IntPtr _pxz_session_, string question, System.Byte defaultValue);
		/// <summary>
		/// Ask a question which need a Yes/No answer
		/// </summary>
		/// <param name="question">Question to display</param>
		/// <param name="defaultValue">Default value (if interfactive mode is disabled)</param>
		public System.Boolean AskYesNo(System.String question, System.Boolean defaultValue = false) {
			var ret = Core_askYesNo(api.Session, question, Convert.ToByte(defaultValue));
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Boolean)(0 != ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Int32 Core_choose(IntPtr _pxz_session_, string message, StringList_c values, Int32 defaultValue);
		/// <summary>
		/// Invite the user to choose one value between multiple choice
		/// </summary>
		/// <param name="message">Message to display</param>
		/// <param name="values">Possible values to choose</param>
		/// <param name="defaultValue">Default value index</param>
		public System.Int32 Choose(System.String message, StringList values, System.Int32 defaultValue = 0) {
			var values_c = new Core.StringList_c();
			ConvertValue((Core.StringList)values, ref values_c);
			var ret = Core_choose(api.Session, message, values_c, defaultValue);
			Core.CoreInterface.Core_StringList_free(ref values_c);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Int32)ret;
		}

		//C# delegate
		public delegate ByteList CaptchaCallback(System.String message, ByteList key);

		//C delegate
		public delegate ByteList_c CaptchaCallback_c(System.String message, ByteList key);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_defineCaptchaCallback(IntPtr _pxz_session_, CaptchaCallback_c callback);
		/// <summary>
		/// Define a callback function to customize the captha which unlock automated functions in interactive products
		/// </summary>
		/// <param name="callback">The callback function</param>
	private static ByteList_c CaptchaCallback_CS(string message, ByteList_c key, CaptchaCallback callback) {

		var retC = new Core.ByteList_c();
		var retCS = callback((System.String)(message), Core.CoreInterface.ConvertValue(ref key));
		ConvertValue(retCS, ref retC);
		return retC;
	}

		public void DefineCaptchaCallback(CaptchaCallback callback) {
			Core_defineCaptchaCallback(api.Session, (message, key) => { 
				return CaptchaCallback_CS(message, key, callback);
			});
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_isInteractiveMode(IntPtr _pxz_session_);
		/// <summary>
		/// Returns True if the script is in interactive mode, else returns false
		/// </summary>
		public System.Boolean IsInteractiveMode() {
			var ret = Core_isInteractiveMode(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Boolean)(0 != ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_message(IntPtr _pxz_session_, string msg);
		/// <summary>
		/// Display a message (or a MessageBox in GUI)
		/// </summary>
		/// <param name="msg">Message to display</param>
		public void Message(System.String msg) {
			Core_message(api.Session, msg);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_setInteractiveMode(IntPtr _pxz_session_, System.Byte interactive);
		/// <summary>
		/// Switch between interactive mode and non-interactive mode, UI functions will no ask user on non-interactive mode and will return default values
		/// </summary>
		/// <param name="interactive">True if you want to enter interactive mode, else False</param>
		public void SetInteractiveMode(System.Boolean interactive = true) {
			Core_setInteractiveMode(api.Session, Convert.ToByte(interactive));
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region database

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_entityExists(IntPtr _pxz_session_, System.UInt32 entity);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="entity">The wanted entity</param>
		public System.Boolean EntityExists(System.UInt32 entity) {
			var ret = Core_entityExists(api.Session, entity);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Boolean)(0 != ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern EntityList_c Core_getAllEntities(IntPtr _pxz_session_);
		/// <summary>
		/// returns all the entities on the database
		/// </summary>
		public EntityList GetAllEntities() {
			var ret = Core_getAllEntities(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_EntityList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getCurrentPiXYZFile(IntPtr _pxz_session_);
		/// <summary>
		/// Get current (loaded) Pixyz file path
		/// </summary>
		public System.String GetCurrentPiXYZFile() {
			var ret = Core_getCurrentPiXYZFile(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return ConvertValue(ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_getEntityType(IntPtr _pxz_session_, System.UInt32 entity);
		/// <summary>
		/// returns the type id of the entity
		/// </summary>
		/// <param name="entity">The wanted entity</param>
		public System.UInt32 GetEntityType(System.UInt32 entity) {
			var ret = Core_getEntityType(api.Session, entity);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getEntityTypeString(IntPtr _pxz_session_, System.UInt32 entity);
		/// <summary>
		/// returns the type name of the entity
		/// </summary>
		/// <param name="entity">The wanted entity</param>
		public System.String GetEntityTypeString(System.UInt32 entity) {
			var ret = Core_getEntityTypeString(api.Session, entity);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return ConvertValue(ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntListList_c Core_getTypeStats(IntPtr _pxz_session_);
		/// <summary>
		/// Get the database stats
		/// </summary>
		public IntListList GetTypeStats() {
			var ret = Core_getTypeStats(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_IntListList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_isCurrentPiXYZFileModified(IntPtr _pxz_session_);
		/// <summary>
		/// Return true, if the current (loaded) file has been modified since last load or save
		/// </summary>
		public System.Boolean IsCurrentPiXYZFileModified() {
			var ret = Core_isCurrentPiXYZFileModified(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Boolean)(0 != ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_load(IntPtr _pxz_session_, string fileName);
		/// <summary>
		/// Load a new scene
		/// </summary>
		/// <param name="fileName">Path to load the file</param>
		public void Load(System.String fileName) {
			Core_load(api.Session, fileName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_lockEntityRegistration(IntPtr _pxz_session_);
		/// <summary>
		/// Lock Entity registration, use with Caution. All entities created after this call will not be saved on .pxz file and will not be listed as existing entities on the Database. Be careful to not references these entities with other registered entities
		/// </summary>
		public void LockEntityRegistration() {
			Core_lockEntityRegistration(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_save(IntPtr _pxz_session_, string fileName);
		/// <summary>
		/// Save the scene
		/// </summary>
		/// <param name="fileName">Path to save the file</param>
		public void Save(System.String fileName) {
			Core_save(api.Session, fileName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_unlockEntityRegistration(IntPtr _pxz_session_);
		/// <summary>
		/// Unlock Entity registration
		/// </summary>
		public void UnlockEntityRegistration() {
			Core_unlockEntityRegistration(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region license

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_addWantedToken(IntPtr _pxz_session_, string tokenName);
		/// <summary>
		/// Add a license token to the list of wanted optional tokens
		/// </summary>
		/// <param name="tokenName">Wanted token</param>
		public void AddWantedToken(System.String tokenName) {
			Core_addWantedToken(api.Session, tokenName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_checkLicense(IntPtr _pxz_session_);
		/// <summary>
		/// check the current license
		/// </summary>
		public System.Boolean CheckLicense() {
			var ret = Core_checkLicense(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Boolean)(0 != ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_checkWebLogin(IntPtr _pxz_session_, string login, string password);
		/// <summary>
		/// Check if authentification on the Web license API is sucessfull
		/// </summary>
		/// <param name="login">WEB account login</param>
		/// <param name="password">WEB account password</param>
		public System.Boolean CheckWebLogin(System.String login, System.String password) {
			var ret = Core_checkWebLogin(api.Session, login, password);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Boolean)(0 != ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_configureLicenseServer(IntPtr _pxz_session_, string address, System.UInt16 port, System.Byte flexLM);
		/// <summary>
		/// Configure the license server to use to get floating licenses
		/// </summary>
		/// <param name="address">Server address</param>
		/// <param name="port">Server port</param>
		/// <param name="flexLM">Enable FlexLM license server</param>
		public void ConfigureLicenseServer(System.String address, System.UInt16 port, System.Boolean flexLM = true) {
			Core_configureLicenseServer(api.Session, address, port, Convert.ToByte(flexLM));
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_generateActivationCode(IntPtr _pxz_session_, string filePath);
		/// <summary>
		/// Create an activation code to generate an offline license
		/// </summary>
		/// <param name="filePath">Path to write the activation code</param>
		public void GenerateActivationCode(System.String filePath) {
			Core_generateActivationCode(api.Session, filePath);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_generateDeactivationCode(IntPtr _pxz_session_, string filePath);
		/// <summary>
		/// Create an deactivation code to release the license from this machine
		/// </summary>
		/// <param name="filePath">Path to write the deactivation code</param>
		public void GenerateDeactivationCode(System.String filePath) {
			Core_generateDeactivationCode(api.Session, filePath);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern LicenseInfos_c Core_getCurrentLicenseInfos(IntPtr _pxz_session_);
		/// <summary>
		/// get information on current installed license
		/// </summary>
		public LicenseInfos GetCurrentLicenseInfos() {
			var ret = Core_getCurrentLicenseInfos(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_LicenseInfos_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetLicenseServerReturn_c Core_getLicenseServer(IntPtr _pxz_session_);
		/// <summary>
		/// Get current license server
		/// </summary>
		public Core.GetLicenseServerReturn GetLicenseServer() {
			var ret = Core_getLicenseServer(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			Core.GetLicenseServerReturn retStruct = new Core.GetLicenseServerReturn();
			retStruct.serverHost = ConvertValue(ret.serverHost);
			retStruct.serverPort = (System.UInt16)ret.serverPort;
			retStruct.useFlexLM = (0 != ret.useFlexLM);
			return retStruct;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_installLicense(IntPtr _pxz_session_, string licensePath);
		/// <summary>
		/// install a new license
		/// </summary>
		/// <param name="licensePath">Path of the license file</param>
		public void InstallLicense(System.String licensePath) {
			Core_installLicense(api.Session, licensePath);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern StringList_c Core_listOwnedTokens(IntPtr _pxz_session_);
		/// <summary>
		/// Get the list of actually owned license tokens
		/// </summary>
		public StringList ListOwnedTokens() {
			var ret = Core_listOwnedTokens(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_StringList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern StringList_c Core_listTokens(IntPtr _pxz_session_, System.Byte onlyMandatory);
		/// <summary>
		/// Get the list of license tokens for this product
		/// </summary>
		/// <param name="onlyMandatory">If True, optional tokens will not be returned</param>
		public StringList ListTokens(System.Boolean onlyMandatory = false) {
			var ret = Core_listTokens(api.Session, Convert.ToByte(onlyMandatory));
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_StringList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern StringList_c Core_listWantedTokens(IntPtr _pxz_session_);
		/// <summary>
		/// Get the list of license token configured to be requested at initialization
		/// </summary>
		public StringList ListWantedTokens() {
			var ret = Core_listWantedTokens(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_StringList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_needToken(IntPtr _pxz_session_, string tokenName);
		/// <summary>
		/// Ensure that a license token is available, useful to be sure to own floatting licence tokens
		/// </summary>
		/// <param name="tokenName">Token name</param>
		public void NeedToken(System.String tokenName) {
			Core_needToken(api.Session, tokenName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_ownToken(IntPtr _pxz_session_, string tokenName);
		/// <summary>
		/// Returns True if we own a token, without requesting it
		/// </summary>
		/// <param name="tokenName">Token name</param>
		public System.Boolean OwnToken(System.String tokenName) {
			var ret = Core_ownToken(api.Session, tokenName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Boolean)(0 != ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_releaseToken(IntPtr _pxz_session_, string tokenName);
		/// <summary>
		/// Release an optional license token
		/// </summary>
		/// <param name="tokenName">Token name</param>
		public void ReleaseToken(System.String tokenName) {
			Core_releaseToken(api.Session, tokenName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_releaseWebLicense(IntPtr _pxz_session_, string login, string password, System.UInt32 id);
		/// <summary>
		/// release License owned by user WEB account
		/// </summary>
		/// <param name="login">WEB account login</param>
		/// <param name="password">WEB account password</param>
		/// <param name="id">WEB license id</param>
		public void ReleaseWebLicense(System.String login, System.String password, System.UInt32 id) {
			Core_releaseWebLicense(api.Session, login, password, id);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeWantedToken(IntPtr _pxz_session_, string tokenName);
		/// <summary>
		/// remove a license token from the list of wanted optional tokens
		/// </summary>
		/// <param name="tokenName">Unwanted token</param>
		public void RemoveWantedToken(System.String tokenName) {
			Core_removeWantedToken(api.Session, tokenName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_requestWebLicense(IntPtr _pxz_session_, string login, string password, System.UInt32 id);
		/// <summary>
		/// request License owned by user WEB account
		/// </summary>
		/// <param name="login">WEB account login</param>
		/// <param name="password">WEB account password</param>
		/// <param name="id">WEB license id</param>
		public void RequestWebLicense(System.String login, System.String password, System.UInt32 id) {
			Core_requestWebLicense(api.Session, login, password, id);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern WebLicenseInfoList_c Core_retrieveWebLicenses(IntPtr _pxz_session_, string login, string password);
		/// <summary>
		/// Retrieves License owned by user WEB account
		/// </summary>
		/// <param name="login">WEB account login</param>
		/// <param name="password">WEB account password</param>
		public WebLicenseInfoList RetrieveWebLicenses(System.String login, System.String password) {
			var ret = Core_retrieveWebLicenses(api.Session, login, password);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_WebLicenseInfoList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_tokenValid(IntPtr _pxz_session_, string tokenName);
		/// <summary>
		/// Returns True if a token is owned by the product, request will be done if missing
		/// </summary>
		/// <param name="tokenName">Token name</param>
		public System.Boolean TokenValid(System.String tokenName) {
			var ret = Core_tokenValid(api.Session, tokenName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Boolean)(0 != ret);
		}

		#endregion

		#region parallel

		//C# delegate
		public delegate void ParallelCallback(System.IntPtr data);

		//C delegate
		public delegate void ParallelCallback_c(System.IntPtr data);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_parallelAddJob(IntPtr _pxz_session_, System.IntPtr session, ParallelCallback_c jobCallback, System.IntPtr data);
		/// <summary>
		/// Add a job to a parallel session
		/// </summary>
		/// <param name="session"></param>
		/// <param name="jobCallback"></param>
		/// <param name="data"></param>
	private static void ParallelCallback_CS(System.IntPtr data, ParallelCallback callback) {

			callback((System.IntPtr)(data));
	}

		public void ParallelAddJob(System.IntPtr session, ParallelCallback jobCallback, System.IntPtr data) {
			Core_parallelAddJob(api.Session, session, (data) => { 
				ParallelCallback_CS(data, jobCallback);
			}, data);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_parallelFinish(IntPtr _pxz_session_, System.IntPtr session);
		/// <summary>
		/// Ends a parallel session after waiting for all jobs to finish
		/// </summary>
		/// <param name="session"></param>
		public void ParallelFinish(System.IntPtr session) {
			Core_parallelFinish(api.Session, session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Core_parallelStart(IntPtr _pxz_session_, System.Byte progression, string name, Int32 jobCount);
		/// <summary>
		/// Starts a new parallel session
		/// </summary>
		/// <param name="progression">Enable progression for the parallel session</param>
		/// <param name="name">Name of the parallel session</param>
		/// <param name="jobCount">Count of parallel jobs if known (for progression)</param>
		public System.IntPtr ParallelStart(System.Boolean progression = false, System.String name = "Parallel session", System.Int32 jobCount = -1) {
			var ret = Core_parallelStart(api.Session, Convert.ToByte(progression), name, jobCount);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.IntPtr)ret;
		}

		#endregion

		#region pipeline

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getOutputFilePath(IntPtr _pxz_session_, string fileName, string data);
		/// <summary>
		/// Return a complete output file path for Pixyz Pipeline, this function is useful for online usage when you know where is the output directory
		/// </summary>
		/// <param name="fileName">The desired file name (suffix of the path)</param>
		/// <param name="data">Optional data associated with file</param>
		public System.String GetOutputFilePath(System.String fileName, System.String data = "none") {
			var ret = Core_getOutputFilePath(api.Session, fileName, data);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return ConvertValue(ret);
		}

		#endregion

		#region plugins

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern ModuleDesc_c Core_getModuleDescFromXML(IntPtr _pxz_session_, string xmlPath, System.Byte addToModules);
		/// <summary>
		/// Generate a ModuleDesc from an .xml description
		/// </summary>
		/// <param name="xmlPath">.xml file path</param>
		/// <param name="addToModules"></param>
		public ModuleDesc GetModuleDescFromXML(System.String xmlPath, System.Boolean addToModules) {
			var ret = Core_getModuleDescFromXML(api.Session, xmlPath, Convert.ToByte(addToModules));
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_ModuleDesc_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeModule(IntPtr _pxz_session_, string module);
		/// <summary>
		/// Remove a module added via getModuleDescFromXML
		/// </summary>
		/// <param name="module">Module name</param>
		public void RemoveModule(System.String module) {
			Core_removeModule(api.Session, module);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region progress

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_popProgression(IntPtr _pxz_session_);
		/// <summary>
		/// Leave current progression level
		/// </summary>
		public void PopProgression() {
			Core_popProgression(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_pushProgression(IntPtr _pxz_session_, Int32 stepCount, string progressName);
		/// <summary>
		/// Create a new progression level
		/// </summary>
		/// <param name="stepCount">Step count</param>
		/// <param name="progressName">Name of the progression step</param>
		public void PushProgression(System.Int32 stepCount, System.String progressName = "") {
			Core_pushProgression(api.Session, stepCount, progressName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_stepProgression(IntPtr _pxz_session_, Int32 stepCount);
		/// <summary>
		/// Add a step to current progression level
		/// </summary>
		/// <param name="stepCount">Step count</param>
		public void StepProgression(System.Int32 stepCount = 1) {
			Core_stepProgression(api.Session, stepCount);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region properties

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_addCustomProperty(IntPtr _pxz_session_, System.UInt32 entity, string name, string value, Int32 type);
		/// <summary>
		/// Add a custom property to an entity that support custom properties
		/// </summary>
		/// <param name="entity">An entity that support custom properties</param>
		/// <param name="name">Name of the custom property</param>
		/// <param name="value">Value of the custom property</param>
		/// <param name="type">Type of the custom property</param>
		public void AddCustomProperty(System.UInt32 entity, System.String name, System.String value = "", PropertyType type = (Core.PropertyType)0) {
			Core_addCustomProperty(api.Session, entity, name, value, (int)type);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getModuleProperty(IntPtr _pxz_session_, string module, string propertyName);
		/// <summary>
		/// Returns the value of a module property
		/// </summary>
		/// <param name="module">Name of the module</param>
		/// <param name="propertyName">The property name</param>
		public System.String GetModuleProperty(System.String module, System.String propertyName) {
			var ret = Core_getModuleProperty(api.Session, module, propertyName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return ConvertValue(ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern PropertyInfo_c Core_getModulePropertyInfo(IntPtr _pxz_session_, string module, string propertyName);
		/// <summary>
		/// Returns the value of a module property
		/// </summary>
		/// <param name="module">Name of the module</param>
		/// <param name="propertyName">The property name</param>
		public PropertyInfo GetModulePropertyInfo(System.String module, System.String propertyName) {
			var ret = Core_getModulePropertyInfo(api.Session, module, propertyName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_PropertyInfo_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern StringList_c Core_getProperties(IntPtr _pxz_session_, EntityList_c entities, string propertyName, string defaultValue);
		/// <summary>
		/// Get the property value on entities (if the property is not set on an entity, defaultValue is returned)
		/// </summary>
		/// <param name="entities">List of entities</param>
		/// <param name="propertyName">The property name</param>
		/// <param name="defaultValue">Default value to return if the property does not exist on an entity</param>
		public StringList GetProperties(EntityList entities, System.String propertyName, System.String defaultValue = "") {
			var entities_c = new Core.EntityList_c();
			ConvertValue((Core.EntityList)entities, ref entities_c);
			var ret = Core_getProperties(api.Session, entities_c, propertyName, defaultValue);
			Core.CoreInterface.Core_EntityList_free(ref entities_c);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_StringList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getProperty(IntPtr _pxz_session_, System.UInt32 entity, string propertyName);
		/// <summary>
		/// Get a property value as String on an entity (error if the property does not exist on the entity)
		/// </summary>
		/// <param name="entity">The entity</param>
		/// <param name="propertyName">The property name</param>
		public System.String GetProperty(System.UInt32 entity, System.String propertyName) {
			var ret = Core_getProperty(api.Session, entity, propertyName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return ConvertValue(ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern PropertyInfo_c Core_getPropertyInfo(IntPtr _pxz_session_, System.UInt32 entity, string propertyName);
		/// <summary>
		/// Get a property info on an entity (error if the property does not exist on the entity)
		/// </summary>
		/// <param name="entity">The entity</param>
		/// <param name="propertyName">The property name</param>
		public PropertyInfo GetPropertyInfo(System.UInt32 entity, System.String propertyName) {
			var ret = Core_getPropertyInfo(api.Session, entity, propertyName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_PropertyInfo_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_hasCustomProperty(IntPtr _pxz_session_, System.UInt32 entityId, string customPropertyName);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="entityId">An entity that support properties</param>
		/// <param name="customPropertyName">Name of the custom property</param>
		public System.Boolean HasCustomProperty(System.UInt32 entityId, System.String customPropertyName) {
			var ret = Core_hasCustomProperty(api.Session, entityId, customPropertyName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Boolean)(0 != ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_hasProperty(IntPtr _pxz_session_, System.UInt32 entity, string propertyName);
		/// <summary>
		/// Return true if the property was found on the occurrence, will not throw any exception except if the entity does not exist.
		/// </summary>
		/// <param name="entity">An entity that support properties</param>
		/// <param name="propertyName">Name of the property</param>
		public System.Boolean HasProperty(System.UInt32 entity, System.String propertyName) {
			var ret = Core_hasProperty(api.Session, entity, propertyName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Boolean)(0 != ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern EnumPropertyInfo_c Core_listEnumLabels(IntPtr _pxz_session_, Int32 enumType);
		/// <summary>
		/// Returns the informations of a module property
		/// </summary>
		/// <param name="enumType">The real enum type number (ie. The one return in subtype of PropertyInfo)</param>
		public EnumPropertyInfo ListEnumLabels(System.Int32 enumType) {
			var ret = Core_listEnumLabels(api.Session, enumType);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_EnumPropertyInfo_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern PropertyInfoList_c Core_listModuleProperties(IntPtr _pxz_session_, string module);
		/// <summary>
		/// Returns all the properties in the given module
		/// </summary>
		/// <param name="module">Name of the module</param>
		public PropertyInfoList ListModuleProperties(System.String module) {
			var ret = Core_listModuleProperties(api.Session, module);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_PropertyInfoList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern PropertyInfoList_c Core_listProperties(IntPtr _pxz_session_, System.UInt32 entity);
		/// <summary>
		/// Returns the names and values of the properties available on an entity
		/// </summary>
		/// <param name="entity">Entity to list</param>
		public PropertyInfoList ListProperties(System.UInt32 entity) {
			var ret = Core_listProperties(api.Session, entity);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_PropertyInfoList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern PropertyInfoListList_c Core_listPropertiesBatch(IntPtr _pxz_session_, EntityList_c entities);
		/// <summary>
		/// Returns the names and values of the properties available on multiple entities
		/// </summary>
		/// <param name="entities">Entities to list</param>
		public PropertyInfoListList ListPropertiesBatch(EntityList entities) {
			var entities_c = new Core.EntityList_c();
			ConvertValue((Core.EntityList)entities, ref entities_c);
			var ret = Core_listPropertiesBatch(api.Session, entities_c);
			Core.CoreInterface.Core_EntityList_free(ref entities_c);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_PropertyInfoListList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeCustomProperty(IntPtr _pxz_session_, System.UInt32 entity, string name);
		/// <summary>
		/// Remove a custom property from an entity that support custom properties
		/// </summary>
		/// <param name="entity">An entity that support custom properties</param>
		/// <param name="name">Name of the custom property</param>
		public void RemoveCustomProperty(System.UInt32 entity, System.String name) {
			Core_removeCustomProperty(api.Session, entity, name);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_restoreModulePropertyDefaultValue(IntPtr _pxz_session_, string module, string propertyName);
		/// <summary>
		/// Restore the default value of a module property
		/// </summary>
		/// <param name="module">Name of the module</param>
		/// <param name="propertyName">The property name</param>
		public System.String RestoreModulePropertyDefaultValue(System.String module, System.String propertyName) {
			var ret = Core_restoreModulePropertyDefaultValue(api.Session, module, propertyName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return ConvertValue(ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_setModuleProperty(IntPtr _pxz_session_, string module, string propertyName, string propertyValue);
		/// <summary>
		/// Set the value of a module property
		/// </summary>
		/// <param name="module">Name of the module</param>
		/// <param name="propertyName">The property name</param>
		/// <param name="propertyValue">The property value</param>
		public System.String SetModuleProperty(System.String module, System.String propertyName, System.String propertyValue) {
			var ret = Core_setModuleProperty(api.Session, module, propertyName, propertyValue);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return ConvertValue(ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_setProperty(IntPtr _pxz_session_, System.UInt32 entity, string propertyName, string propertyValue);
		/// <summary>
		/// Set a property value on an entity
		/// </summary>
		/// <param name="entity">The entity</param>
		/// <param name="propertyName">The property name</param>
		/// <param name="propertyValue">The property value</param>
		public System.String SetProperty(System.UInt32 entity, System.String propertyName, System.String propertyValue) {
			var ret = Core_setProperty(api.Session, entity, propertyName, propertyValue);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return ConvertValue(ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_supportCustomProperties(IntPtr _pxz_session_, System.UInt32 entity);
		/// <summary>
		/// Return true if an entity support custom properties
		/// </summary>
		/// <param name="entity">An entity</param>
		public System.Boolean SupportCustomProperties(System.UInt32 entity) {
			var ret = Core_supportCustomProperties(api.Session, entity);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Boolean)(0 != ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_unsetProperty(IntPtr _pxz_session_, System.UInt32 entity, string propertyName);
		/// <summary>
		/// Unset an entity's property
		/// </summary>
		/// <param name="entity">The entity</param>
		/// <param name="propertyName">The property name</param>
		public void UnsetProperty(System.UInt32 entity, System.String propertyName) {
			Core_unsetProperty(api.Session, entity, propertyName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region system

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern AvailableMemoryReturn_c Core_availableMemory(IntPtr _pxz_session_);
		/// <summary>
		/// returns available memory
		/// </summary>
		public Core.AvailableMemoryReturn AvailableMemory() {
			var ret = Core_availableMemory(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			Core.AvailableMemoryReturn retStruct = new Core.AvailableMemoryReturn();
			retStruct.availVirt = (System.Int64)ret.availVirt;
			retStruct.totalVirt = (System.Int64)ret.totalVirt;
			retStruct.availPhys = (System.Int64)ret.availPhys;
			retStruct.totalPhys = (System.Int64)ret.totalPhys;
			return retStruct;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern CheckForUpdatesReturn_c Core_checkForUpdates(IntPtr _pxz_session_);
		/// <summary>
		/// check for software update
		/// </summary>
		public Core.CheckForUpdatesReturn CheckForUpdates() {
			var ret = Core_checkForUpdates(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			Core.CheckForUpdatesReturn retStruct = new Core.CheckForUpdatesReturn();
			retStruct.newVersionAvailable = (0 != ret.newVersionAvailable);
			retStruct.newVersion = ConvertValue(ret.newVersion);
			retStruct.newVersionLink = ConvertValue(ret.newVersionLink);
			return retStruct;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_clearOtherTemporaryDirectories(IntPtr _pxz_session_);
		/// <summary>
		/// remove all other session temporary directories (warning: make sure that no other instance of pixyz is running
		/// </summary>
		public void ClearOtherTemporaryDirectories() {
			Core_clearOtherTemporaryDirectories(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getCustomVersionTag(IntPtr _pxz_session_);
		/// <summary>
		/// get the Pixyz custom version tag
		/// </summary>
		public System.String GetCustomVersionTag() {
			var ret = Core_getCustomVersionTag(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return ConvertValue(ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Int64 Core_getMemoryUsagePeak(IntPtr _pxz_session_);
		/// <summary>
		/// Returns the memory usage peak of the current process in MB ( only available on windows yet )
		/// </summary>
		public System.Int64 GetMemoryUsagePeak() {
			var ret = Core_getMemoryUsagePeak(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Int64)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getPixyzWebsiteURL(IntPtr _pxz_session_);
		/// <summary>
		/// get the Pixyz website URL
		/// </summary>
		public System.String GetPixyzWebsiteURL() {
			var ret = Core_getPixyzWebsiteURL(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return ConvertValue(ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getProductName(IntPtr _pxz_session_);
		/// <summary>
		/// get the Pixyz product name
		/// </summary>
		public System.String GetProductName() {
			var ret = Core_getProductName(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return ConvertValue(ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getTempDirectory(IntPtr _pxz_session_);
		/// <summary>
		/// get the Pixyz temp directory (server side directory in case of remote access)
		/// </summary>
		public System.String GetTempDirectory() {
			var ret = Core_getTempDirectory(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return ConvertValue(ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getVersion(IntPtr _pxz_session_);
		/// <summary>
		/// get the Pixyz product version
		/// </summary>
		public System.String GetVersion() {
			var ret = Core_getVersion(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return ConvertValue(ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_pushAnalytic(IntPtr _pxz_session_, string name, string data);
		/// <summary>
		/// push custom analytic event (Only for authorized products)
		/// </summary>
		/// <param name="name">Analytic event name</param>
		/// <param name="data">Analytic event data</param>
		public void PushAnalytic(System.String name, System.String data = "") {
			Core_pushAnalytic(api.Session, name, data);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeDirectory(IntPtr _pxz_session_, string path);
		/// <summary>
		/// Remove a directory and all its contents
		/// </summary>
		/// <param name="path">Path to the directory to remove</param>
		public void RemoveDirectory(System.String path) {
			Core_removeDirectory(api.Session, path);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_setCurrentThreadAsProcessThread(IntPtr _pxz_session_);
		/// <summary>
		/// Set the process thread. Use this function when you want to get progress changed callbacks from another thread as the one you initialized Pixyz on.
		/// </summary>
		public void SetCurrentThreadAsProcessThread() {
			Core_setCurrentThreadAsProcessThread(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region undo/redo

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_clearUndoRedo(IntPtr _pxz_session_);
		/// <summary>
		/// Clear undo/redo history
		/// </summary>
		public void ClearUndoRedo() {
			Core_clearUndoRedo(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_endUndoRedoStep(IntPtr _pxz_session_);
		/// <summary>
		/// End current undo/redo step
		/// </summary>
		public void EndUndoRedoStep() {
			Core_endUndoRedoStep(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern StringList_c Core_getRedoStack(IntPtr _pxz_session_);
		/// <summary>
		/// Get the history of actions stack
		/// </summary>
		public StringList GetRedoStack() {
			var ret = Core_getRedoStack(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_StringList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern StringList_c Core_getUndoStack(IntPtr _pxz_session_);
		/// <summary>
		/// Get the history of actions stack
		/// </summary>
		public StringList GetUndoStack() {
			var ret = Core_getUndoStack(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_StringList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_hasRecordingStep(IntPtr _pxz_session_);
		/// <summary>
		/// Has recording step
		/// </summary>
		public System.Boolean HasRecordingStep() {
			var ret = Core_hasRecordingStep(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Boolean)(0 != ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_redo(IntPtr _pxz_session_, System.UInt32 count);
		/// <summary>
		/// redo some steps
		/// </summary>
		/// <param name="count"></param>
		public void Redo(System.UInt32 count = 1) {
			Core_redo(api.Session, count);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_startUndoRedoStep(IntPtr _pxz_session_, string stepName);
		/// <summary>
		/// Start a new undo/redo step
		/// </summary>
		/// <param name="stepName"></param>
		public void StartUndoRedoStep(System.String stepName) {
			Core_startUndoRedoStep(api.Session, stepName);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_stopProcess(IntPtr _pxz_session_);
		/// <summary>
		/// Stop process (works if there is recording step)
		/// </summary>
		public void StopProcess() {
			Core_stopProcess(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_toggleUndoRedo(IntPtr _pxz_session_);
		/// <summary>
		/// Toggle undo/redo
		/// </summary>
		public void ToggleUndoRedo() {
			Core_toggleUndoRedo(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_undo(IntPtr _pxz_session_, System.UInt32 count);
		/// <summary>
		/// undo some steps
		/// </summary>
		/// <param name="count"></param>
		public void Undo(System.UInt32 count = 1) {
			Core_undo(api.Session, count);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		private delegate void UndoRedoStackChangedDelegate(System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addUndoRedoStackChangedCallback(IntPtr _pxz_session_, UndoRedoStackChangedDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeUndoRedoStackChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addUndoRedoStackChangedCallback(UndoRedoStackChangedDelegate callback, System.IntPtr userdata) {
			return Core_addUndoRedoStackChangedCallback(api.Session, callback, userdata);
		}

		private void removeUndoRedoStackChangedCallback(System.UInt32 id) {
			Core_removeUndoRedoStackChangedCallback(api.Session, id);
		}

		public class UndoRedoStackChangedTask : PixyzCallbackTask
		{
			public struct Params
			{
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private CoreInterface iface;

				public Execution(CoreInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					UndoRedoStackChangedDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addUndoRedoStackChangedCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeUndoRedoStackChangedCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata)
				{
					try
					{
						_params.Enqueue(new Params());

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<UndoRedoStackChangedTask.Params> WaitUndoRedoStackChanged(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new UndoRedoStackChangedTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnUndoRedoStackChanged(Action<UndoRedoStackChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			UndoRedoStackChangedTask.Execution task = new UndoRedoStackChangedTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnUndoRedoStackChanged(Action<UndoRedoStackChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnUndoRedoStackChanged(action, cancelSource);
		}
		#endregion

		#region utils

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Color_c Core_getColorFromIndex(IntPtr _pxz_session_, Int32 index);
		/// <summary>
		/// Returns a unique color associated with an index
		/// </summary>
		/// <param name="index">Index of the color (index must be less than 2^24)</param>
		public Color GetColorFromIndex(System.Int32 index) {
			var ret = Core_getColorFromIndex(api.Session, index);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Core.CoreInterface.Core_Color_free(ref ret);
			return convRet;
		}

		#endregion

		#region verbose

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_addConsoleVerbose(IntPtr _pxz_session_, Int32 level);
		/// <summary>
		/// add a console verbose level
		/// </summary>
		/// <param name="level">Verbose level</param>
		public void AddConsoleVerbose(Verbose level) {
			Core_addConsoleVerbose(api.Session, (int)level);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_addLogFileVerbose(IntPtr _pxz_session_, Int32 level);
		/// <summary>
		/// add a log file verbose level
		/// </summary>
		/// <param name="level">Verbose level</param>
		public void AddLogFileVerbose(Verbose level) {
			Core_addLogFileVerbose(api.Session, (int)level);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_addSessionLogFileVerbose(IntPtr _pxz_session_, Int32 level);
		/// <summary>
		/// add a session log file (lastSession.log) verbose level
		/// </summary>
		/// <param name="level">Verbose level</param>
		public void AddSessionLogFileVerbose(Verbose level) {
			Core_addSessionLogFileVerbose(api.Session, (int)level);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_configureInterfaceLogger(IntPtr _pxz_session_, System.Byte enableFunction, System.Byte enableParameters, System.Byte enableExecutionTime);
		/// <summary>
		/// Set new configuration for the Interface Logger
		/// </summary>
		/// <param name="enableFunction">If true, the called function names will be print</param>
		/// <param name="enableParameters">If true, the called function parameters will be print (only if enableFunction=true too)</param>
		/// <param name="enableExecutionTime">If true, the called functions execution times will be print</param>
		public void ConfigureInterfaceLogger(System.Boolean enableFunction, System.Boolean enableParameters, System.Boolean enableExecutionTime) {
			Core_configureInterfaceLogger(api.Session, Convert.ToByte(enableFunction), Convert.ToByte(enableParameters), Convert.ToByte(enableExecutionTime));
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetInterfaceLoggerConfigurationReturn_c Core_getInterfaceLoggerConfiguration(IntPtr _pxz_session_);
		/// <summary>
		/// Get the current Interface Logger configuration
		/// </summary>
		public Core.GetInterfaceLoggerConfigurationReturn GetInterfaceLoggerConfiguration() {
			var ret = Core_getInterfaceLoggerConfiguration(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			Core.GetInterfaceLoggerConfigurationReturn retStruct = new Core.GetInterfaceLoggerConfigurationReturn();
			retStruct.functionEnabled = (0 != ret.functionEnabled);
			retStruct.parametersEnabled = (0 != ret.parametersEnabled);
			retStruct.executionTimeEnabled = (0 != ret.executionTimeEnabled);
			return retStruct;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getLogFile(IntPtr _pxz_session_);
		/// <summary>
		/// get the path of the log file
		/// </summary>
		public System.String GetLogFile() {
			var ret = Core_getLogFile(api.Session);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return ConvertValue(ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_log(IntPtr _pxz_session_, string message, Int32 level);
		/// <summary>
		/// log a message to Pixyz output
		/// </summary>
		/// <param name="message">Message to log</param>
		/// <param name="level">Verbose level</param>
		public void Log(System.String message, Verbose level) {
			Core_log(api.Session, message, (int)level);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeConsoleVerbose(IntPtr _pxz_session_, Int32 level);
		/// <summary>
		/// remove a console verbose level
		/// </summary>
		/// <param name="level">Verbose level</param>
		public void RemoveConsoleVerbose(Verbose level) {
			Core_removeConsoleVerbose(api.Session, (int)level);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeLogFileVerbose(IntPtr _pxz_session_, Int32 level);
		/// <summary>
		/// remove a log file verbose level
		/// </summary>
		/// <param name="level">Verbose level</param>
		public void RemoveLogFileVerbose(Verbose level) {
			Core_removeLogFileVerbose(api.Session, (int)level);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeSessionLogFileVerbose(IntPtr _pxz_session_, Int32 level);
		/// <summary>
		/// remove a session log file (lastSession.log) verbose level
		/// </summary>
		/// <param name="level">Verbose level</param>
		public void RemoveSessionLogFileVerbose(Verbose level) {
			Core_removeSessionLogFileVerbose(api.Session, (int)level);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_setCoreDumpFile(IntPtr _pxz_session_, string path);
		/// <summary>
		/// set the path of the core dump file that will be written when a crash occurs (default=none)
		/// </summary>
		/// <param name="path">Path of the core dump file</param>
		public void SetCoreDumpFile(System.String path) {
			Core_setCoreDumpFile(api.Session, path);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_setLogFile(IntPtr _pxz_session_, string path);
		/// <summary>
		/// set the path of the log file
		/// </summary>
		/// <param name="path">Path of the log file</param>
		public void SetLogFile(System.String path) {
			Core_setLogFile(api.Session, path);
			System.String err = ConvertValue(Core_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		private PiXYZAPI api;
		internal CoreInterface(PiXYZAPI api)
		{
			this.api = api;
		}

	}
}
