#pragma warning disable CA2101

using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;
using PiXYZAPI = UnityEngine.Pixyz.API.PiXYZAPI;

namespace UnityEngine.Pixyz.Core {

	public class CoreInterface : API.Interface {

		private PiXYZAPI api;
		internal CoreInterface(PiXYZAPI api)
		{
			this.api = api;
		}

		#region Types Init/Free Methods

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_DoubleList_init(ref DoubleList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_DoubleList_free(ref DoubleList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_PropertyInfo_init(ref PropertyInfo_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_PropertyInfo_free(ref PropertyInfo_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_PropertyTypeList_init(ref PropertyTypeList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_PropertyTypeList_free(ref PropertyTypeList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EntityList_init(ref EntityList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EntityList_free(ref EntityList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ULongList_init(ref ULongList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ULongList_free(ref ULongList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_DoubleListList_init(ref DoubleListList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_DoubleListList_free(ref DoubleListList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_Color_init(ref Color_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_Color_free(ref Color_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ColorAlpha_init(ref ColorAlpha_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ColorAlpha_free(ref ColorAlpha_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_Date_init(ref Date_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_Date_free(ref Date_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_StringList_init(ref StringList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_StringList_free(ref StringList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_LicenseInfos_init(ref LicenseInfos_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_LicenseInfos_free(ref LicenseInfos_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ColorAlphaList_init(ref ColorAlphaList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ColorAlphaList_free(ref ColorAlphaList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_WebLicenseInfo_init(ref WebLicenseInfo_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_WebLicenseInfo_free(ref WebLicenseInfo_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_StringPair_init(ref StringPair_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_StringPair_free(ref StringPair_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EntityListList_init(ref EntityListList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EntityListList_free(ref EntityListList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_PropertyInfoList_init(ref PropertyInfoList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_PropertyInfoList_free(ref PropertyInfoList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_IdentPair_init(ref IdentPair_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_IdentPair_free(ref IdentPair_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_IdentPairList_init(ref IdentPairList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_IdentPairList_free(ref IdentPairList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_IntList_init(ref IntList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_IntList_free(ref IntList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_InheritableBoolList_init(ref InheritableBoolList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_InheritableBoolList_free(ref InheritableBoolList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_StringPairList_init(ref StringPairList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_StringPairList_free(ref StringPairList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EnumPropertyInfo_init(ref EnumPropertyInfo_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EnumPropertyInfo_free(ref EnumPropertyInfo_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ColorList_init(ref ColorList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ColorList_free(ref ColorList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_FilePathList_init(ref FilePathList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_FilePathList_free(ref FilePathList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_AutoValueReturn_init(ref AutoValueReturn_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_AutoValueReturn_free(ref AutoValueReturn_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_PropertyInfoListList_init(ref PropertyInfoListList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_PropertyInfoListList_free(ref PropertyInfoListList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_AliasTypeDesc_init(ref AliasTypeDesc_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_AliasTypeDesc_free(ref AliasTypeDesc_c str);

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
		internal static extern void Core_BoolList_init(ref BoolList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_BoolList_free(ref BoolList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_IntListList_init(ref IntListList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_IntListList_free(ref IntListList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ModuleDescList_init(ref ModuleDescList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ModuleDescList_free(ref ModuleDescList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_PtrList_init(ref PtrList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_PtrList_free(ref PtrList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_StringPairListList_init(ref StringPairListList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_StringPairListList_free(ref StringPairListList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_BoundedInteger_init(ref BoundedInteger_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_BoundedInteger_free(ref BoundedInteger_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_WebLicenseInfoList_init(ref WebLicenseInfoList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_WebLicenseInfoList_free(ref WebLicenseInfoList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ByteList_init(ref ByteList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_ByteList_free(ref ByteList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_Format_init(ref Format_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_Format_free(ref Format_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EventDesc_init(ref EventDesc_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EventDesc_free(ref EventDesc_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_FormatList_init(ref FormatList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_FormatList_free(ref FormatList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EventDescList_init(ref EventDescList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Core_EventDescList_free(ref EventDescList_c list);

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

	internal static PropertyTypeList ConvertValue(ref PropertyTypeList_c s) {
		PropertyTypeList list = new PropertyTypeList((int)s.size);
		if (s.size==0) return list;

		int[] tab = new int[s.size];
		Marshal.Copy(s.ptr, tab, 0, (int)s.size);
		for (int i = 0; i < (int)s.size; ++i) {
			list.list[i] = (PropertyType)tab[i];
		}
		return list;
	}

	internal static PropertyTypeList_c ConvertValue(PropertyTypeList s, ref PropertyTypeList_c list) {
		Core.CoreInterface.Core_PropertyTypeList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)s.list[i];
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
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
		ss.predefinedValues = ConvertValue(ref s.predefinedValues);
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
		ConvertValue(s.predefinedValues, ref ss.predefinedValues);
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
		ss.htmlInfo = ConvertValue(s.htmlInfo);
		return ss;
	}

	internal static CheckForUpdatesReturn_c ConvertValue(CheckForUpdatesReturn s, ref CheckForUpdatesReturn_c ss) {
		ss.newVersionAvailable = ConvertValue(s.newVersionAvailable);
		ss.newVersion = ConvertValue(s.newVersion);
		ss.newVersionLink = ConvertValue(s.newVersionLink);
		ss.htmlInfo = ConvertValue(s.htmlInfo);
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
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CloneEntity(System.UInt32 entity) {
			try {
				var ret = Core_cloneEntity(api.Session, entity);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.UInt32)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
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
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ConfigureFunctionLogger(System.String functionName, System.Boolean enableFunction, System.Boolean enableParameters, System.Boolean enableExecutionTime) {
			try {
				Core_configureFunctionLogger(api.Session, functionName, Convert.ToByte(enableFunction), Convert.ToByte(enableParameters), Convert.ToByte(enableExecutionTime));
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_createEntity(IntPtr _pxz_session_, System.UInt32 type);

		/// <summary>
		/// Create an entity
		/// </summary>
		/// <param name="type">The type of entity to create</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateEntity(System.UInt32 type) {
			try {
				var ret = Core_createEntity(api.Session, type);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.UInt32)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_deleteEntities(IntPtr _pxz_session_, EntityList_c entities);

		/// <summary>
		/// Delete a set of entities
		/// </summary>
		/// <param name="entities">List of entity to delete</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void DeleteEntities(EntityList entities) {
			try {
				var entities_c = new Core.EntityList_c();
				ConvertValue((Core.EntityList)entities, ref entities_c);
				Core_deleteEntities(api.Session, entities_c);
				Core.CoreInterface.Core_EntityList_free(ref entities_c);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern EntityList_c Core_getEntitiesByType(IntPtr _pxz_session_, System.UInt32 type, System.Byte includeUnsubscribed);

		/// <summary>
		/// get all entities of a given type
		/// </summary>
		/// <param name="type">The type of entities to retrieve</param>
		/// <param name="includeUnsubscribed">Include unsubscribed entities</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public EntityList GetEntitiesByType(System.UInt32 type, System.Boolean includeUnsubscribed) {
			try {
				var ret = Core_getEntitiesByType(api.Session, type, Convert.ToByte(includeUnsubscribed));
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_EntityList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_resetSession(IntPtr _pxz_session_);

		/// <summary>
		/// Clear all the current session (all unsaved work will be lost)
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ResetSession() {
			try {
				Core_resetSession(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_unsavedUserChanges(IntPtr _pxz_session_);

		/// <summary>
		/// Returns true if the user has made changes to the project
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean UnsavedUserChanges() {
			try {
				var ret = Core_unsavedUserChanges(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.Boolean)(0 != ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		private delegate void AfterEntityPropertyChangedDelegate_c(IntPtr userData, System.UInt32 entity, System.String property, System.Int32 entityType);
		private static Dictionary<uint, AfterEntityPropertyChangedDelegate_c> m_AfterEntityPropertyChangedCallbacks = new Dictionary<uint, AfterEntityPropertyChangedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addAfterEntityPropertyChangedCallback(IntPtr _pxz_session_, AfterEntityPropertyChangedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeAfterEntityPropertyChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void AfterEntityPropertyChangedDelegate(IntPtr userData, System.UInt32 entity, System.String property, System.Int32 entityType);

		public System.UInt32 AddAfterEntityPropertyChangedCallback(AfterEntityPropertyChangedDelegate callback, IntPtr userData) {
			AfterEntityPropertyChangedDelegate_c c = new AfterEntityPropertyChangedDelegate_c((System.IntPtr _pxz_session_, System.UInt32 entity, System.String property, System.Int32 entityType) =>
			{
				var entity_cs = (System.UInt32)(entity);
				var property_cs = (System.String)(property);
				var entityType_cs = (System.Int32)(entityType);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, entity_cs, property_cs, entityType_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Core_addAfterEntityPropertyChangedCallback(api.Session, c, userData);
			m_AfterEntityPropertyChangedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveAfterEntityPropertyChangedCallback(System.UInt32 id) {
			Core_removeAfterEntityPropertyChangedCallback(api.Session, id);
			m_AfterEntityPropertyChangedCallbacks.Remove(id);
		}

		private delegate void AfterModulePropertyChangedDelegate_c(IntPtr userData, System.String module, System.String property);
		private static Dictionary<uint, AfterModulePropertyChangedDelegate_c> m_AfterModulePropertyChangedCallbacks = new Dictionary<uint, AfterModulePropertyChangedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addAfterModulePropertyChangedCallback(IntPtr _pxz_session_, AfterModulePropertyChangedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeAfterModulePropertyChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void AfterModulePropertyChangedDelegate(IntPtr userData, System.String module, System.String property);

		public System.UInt32 AddAfterModulePropertyChangedCallback(AfterModulePropertyChangedDelegate callback, IntPtr userData) {
			AfterModulePropertyChangedDelegate_c c = new AfterModulePropertyChangedDelegate_c((System.IntPtr _pxz_session_, System.String module, System.String property) =>
			{
				var module_cs = (System.String)(module);
				var property_cs = (System.String)(property);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, module_cs, property_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Core_addAfterModulePropertyChangedCallback(api.Session, c, userData);
			m_AfterModulePropertyChangedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveAfterModulePropertyChangedCallback(System.UInt32 id) {
			Core_removeAfterModulePropertyChangedCallback(api.Session, id);
			m_AfterModulePropertyChangedCallbacks.Remove(id);
		}

		private delegate void AfterUndoRedoDelegate_c(IntPtr userData);
		private static Dictionary<uint, AfterUndoRedoDelegate_c> m_AfterUndoRedoCallbacks = new Dictionary<uint, AfterUndoRedoDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addAfterUndoRedoCallback(IntPtr _pxz_session_, AfterUndoRedoDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeAfterUndoRedoCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void AfterUndoRedoDelegate(IntPtr userData);

		public System.UInt32 AddAfterUndoRedoCallback(AfterUndoRedoDelegate callback, IntPtr userData) {
			AfterUndoRedoDelegate_c c = new AfterUndoRedoDelegate_c((System.IntPtr _pxz_session_) =>
			{
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Core_addAfterUndoRedoCallback(api.Session, c, userData);
			m_AfterUndoRedoCallbacks.Add(id, c);
			return id;
		}

		public void RemoveAfterUndoRedoCallback(System.UInt32 id) {
			Core_removeAfterUndoRedoCallback(api.Session, id);
			m_AfterUndoRedoCallbacks.Remove(id);
		}

		private delegate void AtExitDelegate_c(IntPtr userData);
		private static Dictionary<uint, AtExitDelegate_c> m_AtExitCallbacks = new Dictionary<uint, AtExitDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addAtExitCallback(IntPtr _pxz_session_, AtExitDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeAtExitCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void AtExitDelegate(IntPtr userData);

		public System.UInt32 AddAtExitCallback(AtExitDelegate callback, IntPtr userData) {
			AtExitDelegate_c c = new AtExitDelegate_c((System.IntPtr _pxz_session_) =>
			{
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Core_addAtExitCallback(api.Session, c, userData);
			m_AtExitCallbacks.Add(id, c);
			return id;
		}

		public void RemoveAtExitCallback(System.UInt32 id) {
			Core_removeAtExitCallback(api.Session, id);
			m_AtExitCallbacks.Remove(id);
		}

		private delegate void BeforeEntityPropertyChangedDelegate_c(IntPtr userData, System.UInt32 entity, System.String property);
		private static Dictionary<uint, BeforeEntityPropertyChangedDelegate_c> m_BeforeEntityPropertyChangedCallbacks = new Dictionary<uint, BeforeEntityPropertyChangedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addBeforeEntityPropertyChangedCallback(IntPtr _pxz_session_, BeforeEntityPropertyChangedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeBeforeEntityPropertyChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void BeforeEntityPropertyChangedDelegate(IntPtr userData, System.UInt32 entity, System.String property);

		public System.UInt32 AddBeforeEntityPropertyChangedCallback(BeforeEntityPropertyChangedDelegate callback, IntPtr userData) {
			BeforeEntityPropertyChangedDelegate_c c = new BeforeEntityPropertyChangedDelegate_c((System.IntPtr _pxz_session_, System.UInt32 entity, System.String property) =>
			{
				var entity_cs = (System.UInt32)(entity);
				var property_cs = (System.String)(property);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, entity_cs, property_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Core_addBeforeEntityPropertyChangedCallback(api.Session, c, userData);
			m_BeforeEntityPropertyChangedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveBeforeEntityPropertyChangedCallback(System.UInt32 id) {
			Core_removeBeforeEntityPropertyChangedCallback(api.Session, id);
			m_BeforeEntityPropertyChangedCallbacks.Remove(id);
		}

		private delegate void BeforeModulePropertyChangedDelegate_c(IntPtr userData, System.String module, System.String property);
		private static Dictionary<uint, BeforeModulePropertyChangedDelegate_c> m_BeforeModulePropertyChangedCallbacks = new Dictionary<uint, BeforeModulePropertyChangedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addBeforeModulePropertyChangedCallback(IntPtr _pxz_session_, BeforeModulePropertyChangedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeBeforeModulePropertyChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void BeforeModulePropertyChangedDelegate(IntPtr userData, System.String module, System.String property);

		public System.UInt32 AddBeforeModulePropertyChangedCallback(BeforeModulePropertyChangedDelegate callback, IntPtr userData) {
			BeforeModulePropertyChangedDelegate_c c = new BeforeModulePropertyChangedDelegate_c((System.IntPtr _pxz_session_, System.String module, System.String property) =>
			{
				var module_cs = (System.String)(module);
				var property_cs = (System.String)(property);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, module_cs, property_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Core_addBeforeModulePropertyChangedCallback(api.Session, c, userData);
			m_BeforeModulePropertyChangedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveBeforeModulePropertyChangedCallback(System.UInt32 id) {
			Core_removeBeforeModulePropertyChangedCallback(api.Session, id);
			m_BeforeModulePropertyChangedCallbacks.Remove(id);
		}

		private delegate void BeforeSessionResetDelegate_c(IntPtr userData);
		private static Dictionary<uint, BeforeSessionResetDelegate_c> m_BeforeSessionResetCallbacks = new Dictionary<uint, BeforeSessionResetDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addBeforeSessionResetCallback(IntPtr _pxz_session_, BeforeSessionResetDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeBeforeSessionResetCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void BeforeSessionResetDelegate(IntPtr userData);

		public System.UInt32 AddBeforeSessionResetCallback(BeforeSessionResetDelegate callback, IntPtr userData) {
			BeforeSessionResetDelegate_c c = new BeforeSessionResetDelegate_c((System.IntPtr _pxz_session_) =>
			{
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Core_addBeforeSessionResetCallback(api.Session, c, userData);
			m_BeforeSessionResetCallbacks.Add(id, c);
			return id;
		}

		public void RemoveBeforeSessionResetCallback(System.UInt32 id) {
			Core_removeBeforeSessionResetCallback(api.Session, id);
			m_BeforeSessionResetCallbacks.Remove(id);
		}

		private delegate void BeforeUndoRedoDelegate_c(IntPtr userData);
		private static Dictionary<uint, BeforeUndoRedoDelegate_c> m_BeforeUndoRedoCallbacks = new Dictionary<uint, BeforeUndoRedoDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addBeforeUndoRedoCallback(IntPtr _pxz_session_, BeforeUndoRedoDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeBeforeUndoRedoCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void BeforeUndoRedoDelegate(IntPtr userData);

		public System.UInt32 AddBeforeUndoRedoCallback(BeforeUndoRedoDelegate callback, IntPtr userData) {
			BeforeUndoRedoDelegate_c c = new BeforeUndoRedoDelegate_c((System.IntPtr _pxz_session_) =>
			{
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Core_addBeforeUndoRedoCallback(api.Session, c, userData);
			m_BeforeUndoRedoCallbacks.Add(id, c);
			return id;
		}

		public void RemoveBeforeUndoRedoCallback(System.UInt32 id) {
			Core_removeBeforeUndoRedoCallback(api.Session, id);
			m_BeforeUndoRedoCallbacks.Remove(id);
		}

		private delegate void CurrentFileChangedDelegate_c(IntPtr userData);
		private static Dictionary<uint, CurrentFileChangedDelegate_c> m_CurrentFileChangedCallbacks = new Dictionary<uint, CurrentFileChangedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addCurrentFileChangedCallback(IntPtr _pxz_session_, CurrentFileChangedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeCurrentFileChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void CurrentFileChangedDelegate(IntPtr userData);

		public System.UInt32 AddCurrentFileChangedCallback(CurrentFileChangedDelegate callback, IntPtr userData) {
			CurrentFileChangedDelegate_c c = new CurrentFileChangedDelegate_c((System.IntPtr _pxz_session_) =>
			{
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Core_addCurrentFileChangedCallback(api.Session, c, userData);
			m_CurrentFileChangedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveCurrentFileChangedCallback(System.UInt32 id) {
			Core_removeCurrentFileChangedCallback(api.Session, id);
			m_CurrentFileChangedCallbacks.Remove(id);
		}

		private delegate void EnteringUnsafeModeDelegate_c(IntPtr userData);
		private static Dictionary<uint, EnteringUnsafeModeDelegate_c> m_EnteringUnsafeModeCallbacks = new Dictionary<uint, EnteringUnsafeModeDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addEnteringUnsafeModeCallback(IntPtr _pxz_session_, EnteringUnsafeModeDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeEnteringUnsafeModeCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void EnteringUnsafeModeDelegate(IntPtr userData);

		public System.UInt32 AddEnteringUnsafeModeCallback(EnteringUnsafeModeDelegate callback, IntPtr userData) {
			EnteringUnsafeModeDelegate_c c = new EnteringUnsafeModeDelegate_c((System.IntPtr _pxz_session_) =>
			{
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Core_addEnteringUnsafeModeCallback(api.Session, c, userData);
			m_EnteringUnsafeModeCallbacks.Add(id, c);
			return id;
		}

		public void RemoveEnteringUnsafeModeCallback(System.UInt32 id) {
			Core_removeEnteringUnsafeModeCallback(api.Session, id);
			m_EnteringUnsafeModeCallbacks.Remove(id);
		}

		private delegate void LeavingUnsafeModeDelegate_c(IntPtr userData);
		private static Dictionary<uint, LeavingUnsafeModeDelegate_c> m_LeavingUnsafeModeCallbacks = new Dictionary<uint, LeavingUnsafeModeDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addLeavingUnsafeModeCallback(IntPtr _pxz_session_, LeavingUnsafeModeDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeLeavingUnsafeModeCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void LeavingUnsafeModeDelegate(IntPtr userData);

		public System.UInt32 AddLeavingUnsafeModeCallback(LeavingUnsafeModeDelegate callback, IntPtr userData) {
			LeavingUnsafeModeDelegate_c c = new LeavingUnsafeModeDelegate_c((System.IntPtr _pxz_session_) =>
			{
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Core_addLeavingUnsafeModeCallback(api.Session, c, userData);
			m_LeavingUnsafeModeCallbacks.Add(id, c);
			return id;
		}

		public void RemoveLeavingUnsafeModeCallback(System.UInt32 id) {
			Core_removeLeavingUnsafeModeCallback(api.Session, id);
			m_LeavingUnsafeModeCallbacks.Remove(id);
		}

		private delegate void OnConsoleMessageDelegate_c(IntPtr userData, System.String text, Verbose verboseLevel);
		private static Dictionary<uint, OnConsoleMessageDelegate_c> m_OnConsoleMessageCallbacks = new Dictionary<uint, OnConsoleMessageDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addOnConsoleMessageCallback(IntPtr _pxz_session_, OnConsoleMessageDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeOnConsoleMessageCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void OnConsoleMessageDelegate(IntPtr userData, System.String text, Verbose verboseLevel);

		public System.UInt32 AddOnConsoleMessageCallback(OnConsoleMessageDelegate callback, IntPtr userData) {
			OnConsoleMessageDelegate_c c = new OnConsoleMessageDelegate_c((System.IntPtr _pxz_session_, System.String text, Verbose verboseLevel) =>
			{
				var text_cs = (System.String)(text);
				var verboseLevel_cs = (Verbose)verboseLevel;
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, text_cs, verboseLevel_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Core_addOnConsoleMessageCallback(api.Session, c, userData);
			m_OnConsoleMessageCallbacks.Add(id, c);
			return id;
		}

		public void RemoveOnConsoleMessageCallback(System.UInt32 id) {
			Core_removeOnConsoleMessageCallback(api.Session, id);
			m_OnConsoleMessageCallbacks.Remove(id);
		}

		private delegate void OnSessionResetDelegate_c(IntPtr userData);
		private static Dictionary<uint, OnSessionResetDelegate_c> m_OnSessionResetCallbacks = new Dictionary<uint, OnSessionResetDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addOnSessionResetCallback(IntPtr _pxz_session_, OnSessionResetDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeOnSessionResetCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void OnSessionResetDelegate(IntPtr userData);

		public System.UInt32 AddOnSessionResetCallback(OnSessionResetDelegate callback, IntPtr userData) {
			OnSessionResetDelegate_c c = new OnSessionResetDelegate_c((System.IntPtr _pxz_session_) =>
			{
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Core_addOnSessionResetCallback(api.Session, c, userData);
			m_OnSessionResetCallbacks.Add(id, c);
			return id;
		}

		public void RemoveOnSessionResetCallback(System.UInt32 id) {
			Core_removeOnSessionResetCallback(api.Session, id);
			m_OnSessionResetCallbacks.Remove(id);
		}

		private delegate void ProgressChangedDelegate_c(IntPtr userData, System.Int32 progress);
		private static Dictionary<uint, ProgressChangedDelegate_c> m_ProgressChangedCallbacks = new Dictionary<uint, ProgressChangedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addProgressChangedCallback(IntPtr _pxz_session_, ProgressChangedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeProgressChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void ProgressChangedDelegate(IntPtr userData, System.Int32 progress);

		public System.UInt32 AddProgressChangedCallback(ProgressChangedDelegate callback, IntPtr userData) {
			ProgressChangedDelegate_c c = new ProgressChangedDelegate_c((System.IntPtr _pxz_session_, System.Int32 progress) =>
			{
				var progress_cs = (System.Int32)(progress);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, progress_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Core_addProgressChangedCallback(api.Session, c, userData);
			m_ProgressChangedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveProgressChangedCallback(System.UInt32 id) {
			Core_removeProgressChangedCallback(api.Session, id);
			m_ProgressChangedCallbacks.Remove(id);
		}

		private delegate void ProgressStepFinishedDelegate_c(IntPtr userData);
		private static Dictionary<uint, ProgressStepFinishedDelegate_c> m_ProgressStepFinishedCallbacks = new Dictionary<uint, ProgressStepFinishedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addProgressStepFinishedCallback(IntPtr _pxz_session_, ProgressStepFinishedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeProgressStepFinishedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void ProgressStepFinishedDelegate(IntPtr userData);

		public System.UInt32 AddProgressStepFinishedCallback(ProgressStepFinishedDelegate callback, IntPtr userData) {
			ProgressStepFinishedDelegate_c c = new ProgressStepFinishedDelegate_c((System.IntPtr _pxz_session_) =>
			{
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Core_addProgressStepFinishedCallback(api.Session, c, userData);
			m_ProgressStepFinishedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveProgressStepFinishedCallback(System.UInt32 id) {
			Core_removeProgressStepFinishedCallback(api.Session, id);
			m_ProgressStepFinishedCallbacks.Remove(id);
		}

		private delegate void ProgressStepStartDelegate_c(IntPtr userData, System.String stepName);
		private static Dictionary<uint, ProgressStepStartDelegate_c> m_ProgressStepStartCallbacks = new Dictionary<uint, ProgressStepStartDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addProgressStepStartCallback(IntPtr _pxz_session_, ProgressStepStartDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeProgressStepStartCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void ProgressStepStartDelegate(IntPtr userData, System.String stepName);

		public System.UInt32 AddProgressStepStartCallback(ProgressStepStartDelegate callback, IntPtr userData) {
			ProgressStepStartDelegate_c c = new ProgressStepStartDelegate_c((System.IntPtr _pxz_session_, System.String stepName) =>
			{
				var stepName_cs = (System.String)(stepName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, stepName_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Core_addProgressStepStartCallback(api.Session, c, userData);
			m_ProgressStepStartCallbacks.Add(id, c);
			return id;
		}

		public void RemoveProgressStepStartCallback(System.UInt32 id) {
			Core_removeProgressStepStartCallback(api.Session, id);
			m_ProgressStepStartCallbacks.Remove(id);
		}

		#endregion

		#region DebugMessage

		private delegate void DebugEventDelegate_c(IntPtr userData, System.Int32 event_type);
		private static Dictionary<uint, DebugEventDelegate_c> m_DebugEventCallbacks = new Dictionary<uint, DebugEventDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addDebugEventCallback(IntPtr _pxz_session_, DebugEventDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeDebugEventCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void DebugEventDelegate(IntPtr userData, System.Int32 event_type);

		public System.UInt32 AddDebugEventCallback(DebugEventDelegate callback, IntPtr userData) {
			DebugEventDelegate_c c = new DebugEventDelegate_c((System.IntPtr _pxz_session_, System.Int32 event_type) =>
			{
				var event_type_cs = (System.Int32)(event_type);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, event_type_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Core_addDebugEventCallback(api.Session, c, userData);
			m_DebugEventCallbacks.Add(id, c);
			return id;
		}

		public void RemoveDebugEventCallback(System.UInt32 id) {
			Core_removeDebugEventCallback(api.Session, id);
			m_DebugEventCallbacks.Remove(id);
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
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public EventDesc GetEvent(System.String moduleName, System.String eventName) {
			try {
				var ret = Core_getEvent(api.Session, moduleName, eventName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_EventDesc_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern EventDescList_c Core_getEvents(IntPtr _pxz_session_, string moduleName, string groupName);

		/// <summary>
		/// get events of a group
		/// </summary>
		/// <param name="moduleName">Target module name</param>
		/// <param name="groupName">Target group name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public EventDescList GetEvents(System.String moduleName, System.String groupName) {
			try {
				var ret = Core_getEvents(api.Session, moduleName, groupName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_EventDescList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern FunctionDesc_c Core_getFunction(IntPtr _pxz_session_, string moduleName, string functionName);

		/// <summary>
		/// get FunctionDesc of a function
		/// </summary>
		/// <param name="moduleName">Target module name</param>
		/// <param name="functionName">Target function name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public FunctionDesc GetFunction(System.String moduleName, System.String functionName) {
			try {
				var ret = Core_getFunction(api.Session, moduleName, functionName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_FunctionDesc_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern FunctionDescList_c Core_getFunctions(IntPtr _pxz_session_, string moduleName, string groupName);

		/// <summary>
		/// get functions of a group
		/// </summary>
		/// <param name="moduleName">Target module name</param>
		/// <param name="groupName">Target group name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public FunctionDescList GetFunctions(System.String moduleName, System.String groupName) {
			try {
				var ret = Core_getFunctions(api.Session, moduleName, groupName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_FunctionDescList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GroupDesc_c Core_getGroup(IntPtr _pxz_session_, string moduleName, string groupName);

		/// <summary>
		/// get a group desc from a specific module
		/// </summary>
		/// <param name="moduleName">Target module name</param>
		/// <param name="groupName">Target group name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public GroupDesc GetGroup(System.String moduleName, System.String groupName) {
			try {
				var ret = Core_getGroup(api.Session, moduleName, groupName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_GroupDesc_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GroupDescList_c Core_getGroups(IntPtr _pxz_session_, string moduleName);

		/// <summary>
		/// get all group desc of a module
		/// </summary>
		/// <param name="moduleName">Target module name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public GroupDescList GetGroups(System.String moduleName) {
			try {
				var ret = Core_getGroups(api.Session, moduleName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_GroupDescList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern TypeDescList_c Core_getModuleTypes(IntPtr _pxz_session_, string moduleName);

		/// <summary>
		/// get TypeDescList from a module name
		/// </summary>
		/// <param name="moduleName">Target module name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public TypeDescList GetModuleTypes(System.String moduleName) {
			try {
				var ret = Core_getModuleTypes(api.Session, moduleName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_TypeDescList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern ModuleDescList_c Core_getModules(IntPtr _pxz_session_);

		/// <summary>
		/// get all modules desc
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public ModuleDescList GetModules() {
			try {
				var ret = Core_getModules(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_ModuleDescList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern StringList_c Core_getModulesName(IntPtr _pxz_session_);

		/// <summary>
		/// get all modules name
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public StringList GetModulesName() {
			try {
				var ret = Core_getModulesName(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_StringList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern TypeDesc_c Core_getType(IntPtr _pxz_session_, string moduleName, string typeNameStr);

		/// <summary>
		/// get TypeDesc from a type name
		/// </summary>
		/// <param name="moduleName">Target module name</param>
		/// <param name="typeNameStr">Target type name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public TypeDesc GetType(System.String moduleName, System.String typeNameStr) {
			try {
				var ret = Core_getType(api.Session, moduleName, typeNameStr);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_TypeDesc_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern StringPairList_c Core_getTypeAttributes(IntPtr _pxz_session_, string moduleName, string typeNameStr);

		/// <summary>
		/// get attributes TypeDesc from a type name
		/// </summary>
		/// <param name="moduleName">Target module name</param>
		/// <param name="typeNameStr">Target type name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public StringPairList GetTypeAttributes(System.String moduleName, System.String typeNameStr) {
			try {
				var ret = Core_getTypeAttributes(api.Session, moduleName, typeNameStr);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_StringPairList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region UI

		// C# delegate
		public delegate ByteList CaptchaCallback(System.String message, ByteList key);

		// C delegate
		internal delegate ByteList_c CaptchaCallback_c(System.String message, ByteList key);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_defineCaptchaCallback(IntPtr _pxz_session_, CaptchaCallback_c callback);

		private static ByteList_c CaptchaCallback_CS(string message, ByteList_c key, CaptchaCallback callback) {
			var retC = new Core.ByteList_c();
			var retCS = callback((System.String)(message), Core.CoreInterface.ConvertValue(ref key));
			ConvertValue(retCS, ref retC);
			return retC;
		}

		/// <summary>
		/// Define a callback function to customize the captha which unlock automated functions in interactive products
		/// </summary>
		/// <param name="callback">The callback function</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void DefineCaptchaCallback(CaptchaCallback callback) {
			try {
				Core_defineCaptchaCallback(api.Session, (message, key) => { 
					var key_c = new Core.ByteList_c();
					ConvertValue((Core.ByteList)key, ref key_c);
				return CaptchaCallback_CS(message, key_c, callback);
			});
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_isInteractiveMode(IntPtr _pxz_session_);

		/// <summary>
		/// Returns True if the script is in interactive mode, else returns false
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean IsInteractiveMode() {
			try {
				var ret = Core_isInteractiveMode(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.Boolean)(0 != ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_setInteractiveMode(IntPtr _pxz_session_, System.Byte interactive);

		/// <summary>
		/// Switch between interactive mode and non-interactive mode, UI functions will no ask user on non-interactive mode and will return default values
		/// </summary>
		/// <param name="interactive">True if you want to enter interactive mode, else False</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetInteractiveMode(System.Boolean interactive = true) {
			try {
				Core_setInteractiveMode(api.Session, Convert.ToByte(interactive));
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region database

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_entityExists(IntPtr _pxz_session_, System.UInt32 entity);

		/// <summary>
		/// returns true if the entity exists
		/// </summary>
		/// <param name="entity">The wanted entity</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean EntityExists(System.UInt32 entity) {
			try {
				var ret = Core_entityExists(api.Session, entity);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.Boolean)(0 != ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern EntityList_c Core_getAllEntities(IntPtr _pxz_session_);

		/// <summary>
		/// returns all the entities on the database
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public EntityList GetAllEntities() {
			try {
				var ret = Core_getAllEntities(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_EntityList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getCurrentPiXYZFile(IntPtr _pxz_session_);

		/// <summary>
		/// Get current (loaded) Pixyz file path
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String GetCurrentPiXYZFile() {
			try {
				var ret = Core_getCurrentPiXYZFile(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return ConvertValue(ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_getEntityType(IntPtr _pxz_session_, System.UInt32 entity);

		/// <summary>
		/// returns the type id of the entity
		/// </summary>
		/// <param name="entity">The wanted entity</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetEntityType(System.UInt32 entity) {
			try {
				var ret = Core_getEntityType(api.Session, entity);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.UInt32)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getEntityTypeString(IntPtr _pxz_session_, System.UInt32 entity);

		/// <summary>
		/// returns the type name of the entity
		/// </summary>
		/// <param name="entity">The wanted entity</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String GetEntityTypeString(System.UInt32 entity) {
			try {
				var ret = Core_getEntityTypeString(api.Session, entity);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return ConvertValue(ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntListList_c Core_getTypeStats(IntPtr _pxz_session_);

		/// <summary>
		/// Get the database stats
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public IntListList GetTypeStats() {
			try {
				var ret = Core_getTypeStats(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_IntListList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_isCurrentPiXYZFileModified(IntPtr _pxz_session_);

		/// <summary>
		/// Return true, if the current (loaded) file has been modified since last load or save
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean IsCurrentPiXYZFileModified() {
			try {
				var ret = Core_isCurrentPiXYZFileModified(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.Boolean)(0 != ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_load(IntPtr _pxz_session_, string fileName);

		/// <summary>
		/// Load a new scene
		/// </summary>
		/// <param name="fileName">Path to load the file</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void Load(System.String fileName) {
			try {
				Core_load(api.Session, fileName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_lockEntityRegistration(IntPtr _pxz_session_);

		/// <summary>
		/// Lock Entity registration, use with Caution. All entities created after this call will not be saved on .pxz file and will not be listed as existing entities on the Database. Be careful to not references these entities with other registered entities
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void LockEntityRegistration() {
			try {
				Core_lockEntityRegistration(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_save(IntPtr _pxz_session_, string fileName);

		/// <summary>
		/// Save the scene
		/// </summary>
		/// <param name="fileName">Path to save the file</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void Save(System.String fileName) {
			try {
				Core_save(api.Session, fileName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_unlockEntityRegistration(IntPtr _pxz_session_);

		/// <summary>
		/// Unlock Entity registration
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void UnlockEntityRegistration() {
			try {
				Core_unlockEntityRegistration(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region license

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_addWantedToken(IntPtr _pxz_session_, string tokenName);

		/// <summary>
		/// Add a license token to the list of wanted tokens. The wanted tokens list is saved on disk in program data and is used at initialization. Prefer using 'core.needToken' instead.
		/// </summary>
		/// <param name="tokenName">Wanted token</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AddWantedToken(System.String tokenName) {
			try {
				Core_addWantedToken(api.Session, tokenName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_checkLicense(IntPtr _pxz_session_);

		/// <summary>
		/// check the current license
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean CheckLicense() {
			try {
				var ret = Core_checkLicense(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.Boolean)(0 != ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_checkWebLogin(IntPtr _pxz_session_, string login, string password);

		/// <summary>
		/// Check if authentification on the Web license API is sucessfull
		/// </summary>
		/// <param name="login">WEB account login</param>
		/// <param name="password">WEB account password</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean CheckWebLogin(System.String login, System.String password) {
			try {
				var ret = Core_checkWebLogin(api.Session, login, password);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.Boolean)(0 != ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_configureLicenseServer(IntPtr _pxz_session_, string address, System.UInt16 port, System.Byte flexLM);

		/// <summary>
		/// Configure the license server to use to get floating licenses
		/// </summary>
		/// <param name="address">Server address</param>
		/// <param name="port">Server port</param>
		/// <param name="flexLM">Enable FlexLM license server</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ConfigureLicenseServer(System.String address, System.UInt16 port, System.Boolean flexLM = true) {
			try {
				Core_configureLicenseServer(api.Session, address, port, Convert.ToByte(flexLM));
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_generateActivationCode(IntPtr _pxz_session_, string filePath);

		/// <summary>
		/// Create an activation code to generate an offline license
		/// </summary>
		/// <param name="filePath">Path to write the activation code</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void GenerateActivationCode(System.String filePath) {
			try {
				Core_generateActivationCode(api.Session, filePath);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_generateDeactivationCode(IntPtr _pxz_session_, string filePath);

		/// <summary>
		/// Create an deactivation code to release the license from this machine
		/// </summary>
		/// <param name="filePath">Path to write the deactivation code</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void GenerateDeactivationCode(System.String filePath) {
			try {
				Core_generateDeactivationCode(api.Session, filePath);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern LicenseInfos_c Core_getCurrentLicenseInfos(IntPtr _pxz_session_);

		/// <summary>
		/// get information on current installed license
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public LicenseInfos GetCurrentLicenseInfos() {
			try {
				var ret = Core_getCurrentLicenseInfos(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_LicenseInfos_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetLicenseServerReturn_c Core_getLicenseServer(IntPtr _pxz_session_);

		/// <summary>
		/// Get current license server
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Core.GetLicenseServerReturn GetLicenseServer() {
			try {
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
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_installLicense(IntPtr _pxz_session_, string licensePath);

		/// <summary>
		/// install a new license
		/// </summary>
		/// <param name="licensePath">Path of the license file</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void InstallLicense(System.String licensePath) {
			try {
				Core_installLicense(api.Session, licensePath);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern StringList_c Core_listOwnedTokens(IntPtr _pxz_session_);

		/// <summary>
		/// Get the list of actually owned license tokens
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public StringList ListOwnedTokens() {
			try {
				var ret = Core_listOwnedTokens(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_StringList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern StringList_c Core_listTokens(IntPtr _pxz_session_, System.Byte onlyMandatory);

		/// <summary>
		/// Get the list of license tokens for this product
		/// </summary>
		/// <param name="onlyMandatory">If True, optional tokens will not be returned</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public StringList ListTokens(System.Boolean onlyMandatory = false) {
			try {
				var ret = Core_listTokens(api.Session, Convert.ToByte(onlyMandatory));
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_StringList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern StringList_c Core_listWantedTokens(IntPtr _pxz_session_);

		/// <summary>
		/// Get the list of license token configured to be requested at initialization
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public StringList ListWantedTokens() {
			try {
				var ret = Core_listWantedTokens(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_StringList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_needToken(IntPtr _pxz_session_, string tokenName);

		/// <summary>
		/// Requests a license token for the current session. This step should be done after configuring license server. Throws an exception if the token is not available.
		/// </summary>
		/// <param name="tokenName">Token name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void NeedToken(System.String tokenName) {
			try {
				Core_needToken(api.Session, tokenName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_ownToken(IntPtr _pxz_session_, string tokenName);

		/// <summary>
		/// Returns True if we own a token, without requesting it
		/// </summary>
		/// <param name="tokenName">Token name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean OwnToken(System.String tokenName) {
			try {
				var ret = Core_ownToken(api.Session, tokenName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.Boolean)(0 != ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_releaseToken(IntPtr _pxz_session_, string tokenName);

		/// <summary>
		/// Release an optional license token
		/// </summary>
		/// <param name="tokenName">Token name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ReleaseToken(System.String tokenName) {
			try {
				Core_releaseToken(api.Session, tokenName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_releaseWebLicense(IntPtr _pxz_session_, string login, string password, System.UInt32 id);

		/// <summary>
		/// release License owned by user WEB account
		/// </summary>
		/// <param name="login">WEB account login</param>
		/// <param name="password">WEB account password</param>
		/// <param name="id">WEB license id</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ReleaseWebLicense(System.String login, System.String password, System.UInt32 id) {
			try {
				Core_releaseWebLicense(api.Session, login, password, id);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeWantedToken(IntPtr _pxz_session_, string tokenName);

		/// <summary>
		/// remove a license token from the list of wanted optional tokens
		/// </summary>
		/// <param name="tokenName">Unwanted token</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void RemoveWantedToken(System.String tokenName) {
			try {
				Core_removeWantedToken(api.Session, tokenName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_requestWebLicense(IntPtr _pxz_session_, string login, string password, System.UInt32 id);

		/// <summary>
		/// request License owned by user WEB account
		/// </summary>
		/// <param name="login">WEB account login</param>
		/// <param name="password">WEB account password</param>
		/// <param name="id">WEB license id</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void RequestWebLicense(System.String login, System.String password, System.UInt32 id) {
			try {
				Core_requestWebLicense(api.Session, login, password, id);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern WebLicenseInfoList_c Core_retrieveWebLicenses(IntPtr _pxz_session_, string login, string password);

		/// <summary>
		/// Retrieves License owned by user WEB account
		/// </summary>
		/// <param name="login">WEB account login</param>
		/// <param name="password">WEB account password</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public WebLicenseInfoList RetrieveWebLicenses(System.String login, System.String password) {
			try {
				var ret = Core_retrieveWebLicenses(api.Session, login, password);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_WebLicenseInfoList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_tokenValid(IntPtr _pxz_session_, string tokenName);

		/// <summary>
		/// Returns True if a token is owned by the product, request will be done if missing
		/// </summary>
		/// <param name="tokenName">Token name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean TokenValid(System.String tokenName) {
			try {
				var ret = Core_tokenValid(api.Session, tokenName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.Boolean)(0 != ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region parallel

		// C# delegate
		public delegate void ParallelCallback(System.IntPtr data);

		// C delegate
		internal delegate void ParallelCallback_c(System.IntPtr data);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_parallelAddJob(IntPtr _pxz_session_, System.IntPtr session, ParallelCallback_c jobCallback, System.IntPtr dataPtr);

		private static void ParallelCallback_CS(System.IntPtr data, ParallelCallback callback) {
			callback((System.IntPtr)(data));
		}

		/// <summary>
		/// Add a job to a parallel session
		/// </summary>
		/// <param name="session"></param>
		/// <param name="jobCallback"></param>
		/// <param name="dataPtr"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ParallelAddJob(System.IntPtr session, ParallelCallback jobCallback, System.IntPtr dataPtr) {
			try {
				Core_parallelAddJob(api.Session, session, (data) => { 
				ParallelCallback_CS(data, jobCallback);
			}, dataPtr);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_parallelFinish(IntPtr _pxz_session_, System.IntPtr session);

		/// <summary>
		/// Ends a parallel session after waiting for all jobs to finish
		/// </summary>
		/// <param name="session"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ParallelFinish(System.IntPtr session) {
			try {
				Core_parallelFinish(api.Session, session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Core_parallelStart(IntPtr _pxz_session_, System.Byte progression, string name, Int32 jobCount);

		/// <summary>
		/// Starts a new parallel session
		/// </summary>
		/// <param name="progression">Enable progression for the parallel session</param>
		/// <param name="name">Name of the parallel session</param>
		/// <param name="jobCount">Count of parallel jobs if known (for progression)</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.IntPtr ParallelStart(System.Boolean progression = false, System.String name = "Parallel session", System.Int32 jobCount = -1) {
			try {
				var ret = Core_parallelStart(api.Session, Convert.ToByte(progression), name, jobCount);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.IntPtr)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
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
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public ModuleDesc GetModuleDescFromXML(System.String xmlPath, System.Boolean addToModules) {
			try {
				var ret = Core_getModuleDescFromXML(api.Session, xmlPath, Convert.ToByte(addToModules));
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_ModuleDesc_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeModule(IntPtr _pxz_session_, string module);

		/// <summary>
		/// Remove a module added via getModuleDescFromXML
		/// </summary>
		/// <param name="module">Module name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void RemoveModule(System.String module) {
			try {
				Core_removeModule(api.Session, module);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region progress

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_popProgression(IntPtr _pxz_session_);

		/// <summary>
		/// Leave current progression level
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void PopProgression() {
			try {
				Core_popProgression(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_pushProgression(IntPtr _pxz_session_, Int32 stepCount, string progressName);

		/// <summary>
		/// Create a new progression level
		/// </summary>
		/// <param name="stepCount">Step count</param>
		/// <param name="progressName">Name of the progression step</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void PushProgression(System.Int32 stepCount, System.String progressName = "") {
			try {
				Core_pushProgression(api.Session, stepCount, progressName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_stepProgression(IntPtr _pxz_session_, Int32 stepCount);

		/// <summary>
		/// Add a step to current progression level
		/// </summary>
		/// <param name="stepCount">Step count</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void StepProgression(System.Int32 stepCount = 1) {
			try {
				Core_stepProgression(api.Session, stepCount);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region properties

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_addCustomProperties(IntPtr _pxz_session_, EntityList_c entities, StringList_c names, StringList_c values, PropertyTypeList_c types);

		/// <summary>
		/// Add multiple custom property to entities that support custom properties
		/// </summary>
		/// <param name="entities">Entities that support custom properties</param>
		/// <param name="names">Name of the custom property for each entity</param>
		/// <param name="values">Value of the custom property for each entity</param>
		/// <param name="types">Type of the custom property for each entity</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AddCustomProperties(EntityList entities, StringList names, StringList values = null, PropertyTypeList types = null) {
			values = values ?? new Core.StringList(new System.String[] {});
			types = types ?? new Core.PropertyTypeList(new Core.PropertyType[] {});
			try {
				var entities_c = new Core.EntityList_c();
				ConvertValue((Core.EntityList)entities, ref entities_c);
				var names_c = new Core.StringList_c();
				ConvertValue((Core.StringList)names, ref names_c);
				var values_c = new Core.StringList_c();
				ConvertValue((Core.StringList)values, ref values_c);
				var types_c = new Core.PropertyTypeList_c();
				ConvertValue((Core.PropertyTypeList)types, ref types_c);
				Core_addCustomProperties(api.Session, entities_c, names_c, values_c, types_c);
				Core.CoreInterface.Core_EntityList_free(ref entities_c);
				Core.CoreInterface.Core_StringList_free(ref names_c);
				Core.CoreInterface.Core_StringList_free(ref values_c);
				Core.CoreInterface.Core_PropertyTypeList_free(ref types_c);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_addCustomProperty(IntPtr _pxz_session_, System.UInt32 entity, string name, string value, Int32 type);

		/// <summary>
		/// Add a custom property to an entity that support custom properties
		/// </summary>
		/// <param name="entity">An entity that support custom properties</param>
		/// <param name="name">Name of the custom property</param>
		/// <param name="value">Value of the custom property</param>
		/// <param name="type">Type of the custom property</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AddCustomProperty(System.UInt32 entity, System.String name, System.String value = "", PropertyType type = (Core.PropertyType)0) {
			try {
				Core_addCustomProperty(api.Session, entity, name, value, (int)type);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getModuleProperty(IntPtr _pxz_session_, string module, string propertyName);

		/// <summary>
		/// Returns the value of a module property
		/// </summary>
		/// <param name="module">Name of the module</param>
		/// <param name="propertyName">The property name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String GetModuleProperty(System.String module, System.String propertyName) {
			try {
				var ret = Core_getModuleProperty(api.Session, module, propertyName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return ConvertValue(ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern PropertyInfo_c Core_getModulePropertyInfo(IntPtr _pxz_session_, string module, string propertyName);

		/// <summary>
		/// Returns the value of a module property
		/// </summary>
		/// <param name="module">Name of the module</param>
		/// <param name="propertyName">The property name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public PropertyInfo GetModulePropertyInfo(System.String module, System.String propertyName) {
			try {
				var ret = Core_getModulePropertyInfo(api.Session, module, propertyName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_PropertyInfo_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern StringList_c Core_getProperties(IntPtr _pxz_session_, EntityList_c entities, string propertyName, string defaultValue);

		/// <summary>
		/// Get the property value on entities (if the property is not set on an entity, defaultValue is returned)
		/// </summary>
		/// <param name="entities">List of entities</param>
		/// <param name="propertyName">The property name</param>
		/// <param name="defaultValue">Default value to return if the property does not exist on an entity</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public StringList GetProperties(EntityList entities, System.String propertyName, System.String defaultValue = "") {
			try {
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
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getProperty(IntPtr _pxz_session_, System.UInt32 entity, string propertyName);

		/// <summary>
		/// Get a property value as String on an entity (error if the property does not exist on the entity)
		/// </summary>
		/// <param name="entity">The entity</param>
		/// <param name="propertyName">The property name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String GetProperty(System.UInt32 entity, System.String propertyName) {
			try {
				var ret = Core_getProperty(api.Session, entity, propertyName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return ConvertValue(ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern PropertyInfo_c Core_getPropertyInfo(IntPtr _pxz_session_, System.UInt32 entity, string propertyName);

		/// <summary>
		/// Get a property info on an entity (error if the property does not exist on the entity)
		/// </summary>
		/// <param name="entity">The entity</param>
		/// <param name="propertyName">The property name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public PropertyInfo GetPropertyInfo(System.UInt32 entity, System.String propertyName) {
			try {
				var ret = Core_getPropertyInfo(api.Session, entity, propertyName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_PropertyInfo_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_hasCustomProperty(IntPtr _pxz_session_, System.UInt32 entityId, string customPropertyName);

		/// <summary>
		/// Return true if the custom property was found on the occurrence
		/// </summary>
		/// <param name="entityId">An entity that support properties</param>
		/// <param name="customPropertyName">Name of the custom property</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean HasCustomProperty(System.UInt32 entityId, System.String customPropertyName) {
			try {
				var ret = Core_hasCustomProperty(api.Session, entityId, customPropertyName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.Boolean)(0 != ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_hasProperty(IntPtr _pxz_session_, System.UInt32 entity, string propertyName);

		/// <summary>
		/// Return true if the property was found on the occurrence, will not throw any exception except if the entity does not exist.
		/// </summary>
		/// <param name="entity">An entity that support properties</param>
		/// <param name="propertyName">Name of the property</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean HasProperty(System.UInt32 entity, System.String propertyName) {
			try {
				var ret = Core_hasProperty(api.Session, entity, propertyName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.Boolean)(0 != ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern EnumPropertyInfo_c Core_listEnumLabels(IntPtr _pxz_session_, Int32 enumType);

		/// <summary>
		/// Returns the informations of a module property
		/// </summary>
		/// <param name="enumType">The real enum type number (ie. The one return in subtype of PropertyInfo)</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public EnumPropertyInfo ListEnumLabels(System.Int32 enumType) {
			try {
				var ret = Core_listEnumLabels(api.Session, enumType);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_EnumPropertyInfo_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern PropertyInfoList_c Core_listModuleProperties(IntPtr _pxz_session_, string module);

		/// <summary>
		/// Returns all the properties in the given module
		/// </summary>
		/// <param name="module">Name of the module</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public PropertyInfoList ListModuleProperties(System.String module) {
			try {
				var ret = Core_listModuleProperties(api.Session, module);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_PropertyInfoList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern PropertyInfoList_c Core_listProperties(IntPtr _pxz_session_, System.UInt32 entity);

		/// <summary>
		/// Returns the names and values of the properties available on an entity
		/// </summary>
		/// <param name="entity">Entity to list</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public PropertyInfoList ListProperties(System.UInt32 entity) {
			try {
				var ret = Core_listProperties(api.Session, entity);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_PropertyInfoList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern PropertyInfoListList_c Core_listPropertiesBatch(IntPtr _pxz_session_, EntityList_c entities);

		/// <summary>
		/// Returns the names and values of the properties available on multiple entities
		/// </summary>
		/// <param name="entities">Entities to list</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public PropertyInfoListList ListPropertiesBatch(EntityList entities) {
			try {
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
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeCustomProperty(IntPtr _pxz_session_, System.UInt32 entity, string name);

		/// <summary>
		/// Remove a custom property from an entity that support custom properties
		/// </summary>
		/// <param name="entity">An entity that support custom properties</param>
		/// <param name="name">Name of the custom property</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void RemoveCustomProperty(System.UInt32 entity, System.String name) {
			try {
				Core_removeCustomProperty(api.Session, entity, name);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_restoreModulePropertyDefaultValue(IntPtr _pxz_session_, string module, string propertyName);

		/// <summary>
		/// Restore the default value of a module property
		/// </summary>
		/// <param name="module">Name of the module</param>
		/// <param name="propertyName">The property name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String RestoreModulePropertyDefaultValue(System.String module, System.String propertyName) {
			try {
				var ret = Core_restoreModulePropertyDefaultValue(api.Session, module, propertyName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return ConvertValue(ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_setModuleProperty(IntPtr _pxz_session_, string module, string propertyName, string propertyValue);

		/// <summary>
		/// Set the value of a module property
		/// </summary>
		/// <param name="module">Name of the module</param>
		/// <param name="propertyName">The property name</param>
		/// <param name="propertyValue">The property value</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String SetModuleProperty(System.String module, System.String propertyName, System.String propertyValue) {
			try {
				var ret = Core_setModuleProperty(api.Session, module, propertyName, propertyValue);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return ConvertValue(ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_setProperties(IntPtr _pxz_session_, EntityList_c entities, StringList_c propertyNames, StringList_c propertyValues);

		/// <summary>
		/// Set multiple properties values on entities
		/// </summary>
		/// <param name="entities">List of entities</param>
		/// <param name="propertyNames">The property name for each entity</param>
		/// <param name="propertyValues">The property value for each entity</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetProperties(EntityList entities, StringList propertyNames, StringList propertyValues) {
			try {
				var entities_c = new Core.EntityList_c();
				ConvertValue((Core.EntityList)entities, ref entities_c);
				var propertyNames_c = new Core.StringList_c();
				ConvertValue((Core.StringList)propertyNames, ref propertyNames_c);
				var propertyValues_c = new Core.StringList_c();
				ConvertValue((Core.StringList)propertyValues, ref propertyValues_c);
				Core_setProperties(api.Session, entities_c, propertyNames_c, propertyValues_c);
				Core.CoreInterface.Core_EntityList_free(ref entities_c);
				Core.CoreInterface.Core_StringList_free(ref propertyNames_c);
				Core.CoreInterface.Core_StringList_free(ref propertyValues_c);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_setProperty(IntPtr _pxz_session_, System.UInt32 entity, string propertyName, string propertyValue);

		/// <summary>
		/// Set a property value on an entity
		/// </summary>
		/// <param name="entity">The entity</param>
		/// <param name="propertyName">The property name</param>
		/// <param name="propertyValue">The property value</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String SetProperty(System.UInt32 entity, System.String propertyName, System.String propertyValue) {
			try {
				var ret = Core_setProperty(api.Session, entity, propertyName, propertyValue);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return ConvertValue(ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_supportCustomProperties(IntPtr _pxz_session_, System.UInt32 entity);

		/// <summary>
		/// Return true if an entity support custom properties
		/// </summary>
		/// <param name="entity">An entity</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean SupportCustomProperties(System.UInt32 entity) {
			try {
				var ret = Core_supportCustomProperties(api.Session, entity);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.Boolean)(0 != ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_unsetProperty(IntPtr _pxz_session_, System.UInt32 entity, string propertyName);

		/// <summary>
		/// Unset an entity's property
		/// </summary>
		/// <param name="entity">The entity</param>
		/// <param name="propertyName">The property name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void UnsetProperty(System.UInt32 entity, System.String propertyName) {
			try {
				Core_unsetProperty(api.Session, entity, propertyName);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		private delegate void AfterCustomPropertyAddedDelegate_c(IntPtr userData, System.UInt32 entity, System.String property, System.Int32 entityType);
		private static Dictionary<uint, AfterCustomPropertyAddedDelegate_c> m_AfterCustomPropertyAddedCallbacks = new Dictionary<uint, AfterCustomPropertyAddedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addAfterCustomPropertyAddedCallback(IntPtr _pxz_session_, AfterCustomPropertyAddedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeAfterCustomPropertyAddedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void AfterCustomPropertyAddedDelegate(IntPtr userData, System.UInt32 entity, System.String property, System.Int32 entityType);

		public System.UInt32 AddAfterCustomPropertyAddedCallback(AfterCustomPropertyAddedDelegate callback, IntPtr userData) {
			AfterCustomPropertyAddedDelegate_c c = new AfterCustomPropertyAddedDelegate_c((System.IntPtr _pxz_session_, System.UInt32 entity, System.String property, System.Int32 entityType) =>
			{
				var entity_cs = (System.UInt32)(entity);
				var property_cs = (System.String)(property);
				var entityType_cs = (System.Int32)(entityType);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, entity_cs, property_cs, entityType_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Core_addAfterCustomPropertyAddedCallback(api.Session, c, userData);
			m_AfterCustomPropertyAddedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveAfterCustomPropertyAddedCallback(System.UInt32 id) {
			Core_removeAfterCustomPropertyAddedCallback(api.Session, id);
			m_AfterCustomPropertyAddedCallbacks.Remove(id);
		}

		#endregion

		#region system

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern AvailableMemoryReturn_c Core_availableMemory(IntPtr _pxz_session_);

		/// <summary>
		/// returns available memory
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Core.AvailableMemoryReturn AvailableMemory() {
			try {
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
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern CheckForUpdatesReturn_c Core_checkForUpdates(IntPtr _pxz_session_);

		/// <summary>
		/// check for software update
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Core.CheckForUpdatesReturn CheckForUpdates() {
			try {
				var ret = Core_checkForUpdates(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				Core.CheckForUpdatesReturn retStruct = new Core.CheckForUpdatesReturn();
				retStruct.newVersionAvailable = (0 != ret.newVersionAvailable);
				retStruct.newVersion = ConvertValue(ret.newVersion);
				retStruct.newVersionLink = ConvertValue(ret.newVersionLink);
				retStruct.htmlInfo = ConvertValue(ret.htmlInfo);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_clearOtherTemporaryDirectories(IntPtr _pxz_session_);

		/// <summary>
		/// remove all other session temporary directories (warning: make sure that no other instance of pixyz is running
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ClearOtherTemporaryDirectories() {
			try {
				Core_clearOtherTemporaryDirectories(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getCustomVersionTag(IntPtr _pxz_session_);

		/// <summary>
		/// get the Pixyz custom version tag
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String GetCustomVersionTag() {
			try {
				var ret = Core_getCustomVersionTag(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return ConvertValue(ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Int64 Core_getMemoryUsagePeak(IntPtr _pxz_session_);

		/// <summary>
		/// Returns the memory usage peak of the current process in MB ( only available on windows yet )
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Int64 GetMemoryUsagePeak() {
			try {
				var ret = Core_getMemoryUsagePeak(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.Int64)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getPixyzWebsiteURL(IntPtr _pxz_session_);

		/// <summary>
		/// get the Pixyz website URL
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String GetPixyzWebsiteURL() {
			try {
				var ret = Core_getPixyzWebsiteURL(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return ConvertValue(ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getProductName(IntPtr _pxz_session_);

		/// <summary>
		/// get the Pixyz product name
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String GetProductName() {
			try {
				var ret = Core_getProductName(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return ConvertValue(ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getTempDirectory(IntPtr _pxz_session_);

		/// <summary>
		/// get the Pixyz temp directory (server side directory in case of remote access)
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String GetTempDirectory() {
			try {
				var ret = Core_getTempDirectory(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return ConvertValue(ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getVersion(IntPtr _pxz_session_);

		/// <summary>
		/// get the Pixyz product version
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String GetVersion() {
			try {
				var ret = Core_getVersion(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return ConvertValue(ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_pushAnalytic(IntPtr _pxz_session_, string name, string data);

		/// <summary>
		/// push custom analytic event (Only for authorized products)
		/// </summary>
		/// <param name="name">Analytic event name</param>
		/// <param name="data">Analytic event data</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void PushAnalytic(System.String name, System.String data = "") {
			try {
				Core_pushAnalytic(api.Session, name, data);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_setCurrentThreadAsProcessThread(IntPtr _pxz_session_);

		/// <summary>
		/// Set the process thread. Use this function when you want to get progress changed callbacks from another thread as the one you initialized Pixyz on.
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetCurrentThreadAsProcessThread() {
			try {
				Core_setCurrentThreadAsProcessThread(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region undo/redo

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_clearUndoRedo(IntPtr _pxz_session_);

		/// <summary>
		/// Clear undo/redo history
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ClearUndoRedo() {
			try {
				Core_clearUndoRedo(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_endUndoRedoStep(IntPtr _pxz_session_, System.Byte deleteIfEmpty);

		/// <summary>
		/// End current undo/redo step
		/// </summary>
		/// <param name="deleteIfEmpty">If True, empty step with no modification will be deleted from the stack at the end</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void EndUndoRedoStep(System.Boolean deleteIfEmpty = true) {
			try {
				Core_endUndoRedoStep(api.Session, Convert.ToByte(deleteIfEmpty));
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern StringList_c Core_getRedoStack(IntPtr _pxz_session_);

		/// <summary>
		/// Get the history of actions stack
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public StringList GetRedoStack() {
			try {
				var ret = Core_getRedoStack(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_StringList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getRedoStepUserData(IntPtr _pxz_session_, System.UInt32 index);

		/// <summary>
		/// Get user data for undo step #index
		/// </summary>
		/// <param name="index"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String GetRedoStepUserData(System.UInt32 index) {
			try {
				var ret = Core_getRedoStepUserData(api.Session, index);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return ConvertValue(ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern StringList_c Core_getUndoStack(IntPtr _pxz_session_);

		/// <summary>
		/// Get the history of actions stack
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public StringList GetUndoStack() {
			try {
				var ret = Core_getUndoStack(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Core.CoreInterface.Core_StringList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getUndoStepUserData(IntPtr _pxz_session_, System.UInt32 index);

		/// <summary>
		/// Get user data for undo step #index
		/// </summary>
		/// <param name="index"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String GetUndoStepUserData(System.UInt32 index) {
			try {
				var ret = Core_getUndoStepUserData(api.Session, index);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return ConvertValue(ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Core_hasRecordingStep(IntPtr _pxz_session_);

		/// <summary>
		/// Has recording step
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean HasRecordingStep() {
			try {
				var ret = Core_hasRecordingStep(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.Boolean)(0 != ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_redo(IntPtr _pxz_session_, System.UInt32 count);

		/// <summary>
		/// redo some steps
		/// </summary>
		/// <param name="count"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void Redo(System.UInt32 count = 1) {
			try {
				Core_redo(api.Session, count);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_startUndoRedoStep(IntPtr _pxz_session_, string stepName, string userData);

		/// <summary>
		/// Start a new undo/redo step
		/// </summary>
		/// <param name="stepName"></param>
		/// <param name="userData"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void StartUndoRedoStep(System.String stepName, System.String userData = "") {
			try {
				Core_startUndoRedoStep(api.Session, stepName, userData);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_stopProcess(IntPtr _pxz_session_);

		/// <summary>
		/// Stop process (works if there is recording step)
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void StopProcess() {
			try {
				Core_stopProcess(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_toggleUndoRedo(IntPtr _pxz_session_);

		/// <summary>
		/// Toggle undo/redo
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ToggleUndoRedo() {
			try {
				Core_toggleUndoRedo(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_undo(IntPtr _pxz_session_, System.UInt32 count);

		/// <summary>
		/// undo some steps
		/// </summary>
		/// <param name="count"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void Undo(System.UInt32 count = 1) {
			try {
				Core_undo(api.Session, count);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		private delegate void UndoRedoStackChangedDelegate_c(IntPtr userData);
		private static Dictionary<uint, UndoRedoStackChangedDelegate_c> m_UndoRedoStackChangedCallbacks = new Dictionary<uint, UndoRedoStackChangedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Core_addUndoRedoStackChangedCallback(IntPtr _pxz_session_, UndoRedoStackChangedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeUndoRedoStackChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void UndoRedoStackChangedDelegate(IntPtr userData);

		public System.UInt32 AddUndoRedoStackChangedCallback(UndoRedoStackChangedDelegate callback, IntPtr userData) {
			UndoRedoStackChangedDelegate_c c = new UndoRedoStackChangedDelegate_c((System.IntPtr _pxz_session_) =>
			{
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Core_addUndoRedoStackChangedCallback(api.Session, c, userData);
			m_UndoRedoStackChangedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveUndoRedoStackChangedCallback(System.UInt32 id) {
			Core_removeUndoRedoStackChangedCallback(api.Session, id);
			m_UndoRedoStackChangedCallbacks.Remove(id);
		}

		#endregion

		#region verbose

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_addConsoleVerbose(IntPtr _pxz_session_, Int32 level);

		/// <summary>
		/// add a console verbose level
		/// </summary>
		/// <param name="level">Verbose level</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AddConsoleVerbose(Verbose level) {
			try {
				Core_addConsoleVerbose(api.Session, (int)level);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_addLogFileVerbose(IntPtr _pxz_session_, Int32 level);

		/// <summary>
		/// add a log file verbose level
		/// </summary>
		/// <param name="level">Verbose level</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AddLogFileVerbose(Verbose level) {
			try {
				Core_addLogFileVerbose(api.Session, (int)level);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_addSessionLogFileVerbose(IntPtr _pxz_session_, Int32 level);

		/// <summary>
		/// add a session log file (lastSession{Id}.log) verbose level
		/// </summary>
		/// <param name="level">Verbose level</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AddSessionLogFileVerbose(Verbose level) {
			try {
				Core_addSessionLogFileVerbose(api.Session, (int)level);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_configureInterfaceLogger(IntPtr _pxz_session_, System.Byte enableFunction, System.Byte enableParameters, System.Byte enableExecutionTime);

		/// <summary>
		/// Set new configuration for the Interface Logger
		/// </summary>
		/// <param name="enableFunction">If true, the called function names will be print</param>
		/// <param name="enableParameters">If true, the called function parameters will be print (only if enableFunction=true too)</param>
		/// <param name="enableExecutionTime">If true, the called functions execution times will be print</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ConfigureInterfaceLogger(System.Boolean enableFunction, System.Boolean enableParameters, System.Boolean enableExecutionTime) {
			try {
				Core_configureInterfaceLogger(api.Session, Convert.ToByte(enableFunction), Convert.ToByte(enableParameters), Convert.ToByte(enableExecutionTime));
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetInterfaceLoggerConfigurationReturn_c Core_getInterfaceLoggerConfiguration(IntPtr _pxz_session_);

		/// <summary>
		/// Get the current Interface Logger configuration
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Core.GetInterfaceLoggerConfigurationReturn GetInterfaceLoggerConfiguration() {
			try {
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
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Core_getLogFile(IntPtr _pxz_session_);

		/// <summary>
		/// get the path of the log file
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String GetLogFile() {
			try {
				var ret = Core_getLogFile(api.Session);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return ConvertValue(ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_log(IntPtr _pxz_session_, string message, Int32 level);

		/// <summary>
		/// log a message to Pixyz output
		/// </summary>
		/// <param name="message">Message to log</param>
		/// <param name="level">Verbose level</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void Log(System.String message, Verbose level) {
			try {
				Core_log(api.Session, message, (int)level);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeConsoleVerbose(IntPtr _pxz_session_, Int32 level);

		/// <summary>
		/// remove a console verbose level
		/// </summary>
		/// <param name="level">Verbose level</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void RemoveConsoleVerbose(Verbose level) {
			try {
				Core_removeConsoleVerbose(api.Session, (int)level);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeLogFileVerbose(IntPtr _pxz_session_, Int32 level);

		/// <summary>
		/// remove a log file verbose level
		/// </summary>
		/// <param name="level">Verbose level</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void RemoveLogFileVerbose(Verbose level) {
			try {
				Core_removeLogFileVerbose(api.Session, (int)level);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_removeSessionLogFileVerbose(IntPtr _pxz_session_, Int32 level);

		/// <summary>
		/// remove a session log file (lastSession{Id}.log) verbose level
		/// </summary>
		/// <param name="level">Verbose level</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void RemoveSessionLogFileVerbose(Verbose level) {
			try {
				Core_removeSessionLogFileVerbose(api.Session, (int)level);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_setCoreDumpFile(IntPtr _pxz_session_, string path);

		/// <summary>
		/// WARNING: this function is tagged as 'EXPERIMENTAL'<br/>
		/// set the path of the core dump file that will be written when a crash occurs (default=none)
		/// </summary>
		/// <param name="path">Path of the core dump file</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetCoreDumpFile(System.String path) {
			try {
				Core_setCoreDumpFile(api.Session, path);
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Core_setLogFile(IntPtr _pxz_session_, string path, System.Byte keepHistory);

		/// <summary>
		/// set the path of the log file
		/// </summary>
		/// <param name="path">Path of the log file</param>
		/// <param name="keepHistory">Keep session log history in new log file.</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetLogFile(System.String path, System.Boolean keepHistory = false) {
			try {
				Core_setLogFile(api.Session, path, Convert.ToByte(keepHistory));
				System.String err = ConvertValue(Core_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		public const System.Double Epsilon = 1e-6;
		public const System.Double EpsilonSquare = 1e-12;
		public const System.Double HalfPi = 1.5707963267948966192313215;
		public const System.Double Infinity = 1e12;
		public const System.Double OneDegree = 0.017453292519943295769236907684886;
		public const System.Double Pi = 3.141592653589793238462643;
		public const System.Double TwoPi = 6.283185307179586476925286;
	}
}
