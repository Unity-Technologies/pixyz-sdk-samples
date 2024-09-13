#pragma warning disable CA2101

using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;
using PiXYZAPI = UnityEngine.Pixyz.API.PiXYZAPI;

namespace UnityEngine.Pixyz.Scene {

	public class SceneInterface : API.Interface {

		private PiXYZAPI api;
		internal SceneInterface(PiXYZAPI api)
		{
			this.api = api;
		}

		#region Types Init/Free Methods

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_PropertyValue_init(ref PropertyValue_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_PropertyValue_free(ref PropertyValue_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_PropertyValueList_init(ref PropertyValueList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_PropertyValueList_free(ref PropertyValueList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_VariantDefinition_init(ref VariantDefinition_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_VariantDefinition_free(ref VariantDefinition_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_VariantDefinitionList_init(ref VariantDefinitionList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_VariantDefinitionList_free(ref VariantDefinitionList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_VariantDefinitionListList_init(ref VariantDefinitionListList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_VariantDefinitionListList_free(ref VariantDefinitionListList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_TessellatedShapeList_init(ref TessellatedShapeList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_TessellatedShapeList_free(ref TessellatedShapeList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_ComponentList_init(ref ComponentList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_ComponentList_free(ref ComponentList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AnimChannelList_init(ref AnimChannelList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AnimChannelList_free(ref AnimChannelList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_MaterialCount_init(ref MaterialCount_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_MaterialCount_free(ref MaterialCount_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AlternativeTreeList_init(ref AlternativeTreeList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AlternativeTreeList_free(ref AlternativeTreeList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_VariantList_init(ref VariantList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_VariantList_free(ref VariantList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_VariantComponentList_init(ref VariantComponentList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_VariantComponentList_free(ref VariantComponentList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_MaterialCountList_init(ref MaterialCountList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_MaterialCountList_free(ref MaterialCountList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AnimChannelInfo_init(ref AnimChannelInfo_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AnimChannelInfo_free(ref AnimChannelInfo_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_OccurrenceList_init(ref OccurrenceList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_OccurrenceList_free(ref OccurrenceList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_KeyframeList_init(ref KeyframeList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_KeyframeList_free(ref KeyframeList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AnimationInfo_init(ref AnimationInfo_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AnimationInfo_free(ref AnimationInfo_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AnimPropertyBinder_init(ref AnimPropertyBinder_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AnimPropertyBinder_free(ref AnimPropertyBinder_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_LODList_init(ref LODList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_LODList_free(ref LODList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AnnotationGroupList_init(ref AnnotationGroupList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AnnotationGroupList_free(ref AnnotationGroupList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_OccurrenceListList_init(ref OccurrenceListList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_OccurrenceListList_free(ref OccurrenceListList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_LODComponentList_init(ref LODComponentList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_LODComponentList_free(ref LODComponentList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AnimationList_init(ref AnimationList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AnimationList_free(ref AnimationList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AnnotationList_init(ref AnnotationList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AnnotationList_free(ref AnnotationList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_PartList_init(ref PartList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_PartList_free(ref PartList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AnimPropertyBinderList_init(ref AnimPropertyBinderList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AnimPropertyBinderList_free(ref AnimPropertyBinderList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_MetadataList_init(ref MetadataList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_MetadataList_free(ref MetadataList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_RayHit_init(ref RayHit_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_RayHit_free(ref RayHit_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_Filter_init(ref Filter_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_Filter_free(ref Filter_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_JointDefinition_init(ref JointDefinition_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_JointDefinition_free(ref JointDefinition_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_JointDefinitionList_init(ref JointDefinitionList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_JointDefinitionList_free(ref JointDefinitionList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_VariantMaterials_init(ref VariantMaterials_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_VariantMaterials_free(ref VariantMaterials_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AnnotationDefinition_init(ref AnnotationDefinition_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AnnotationDefinition_free(ref AnnotationDefinition_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_ProberInfo_init(ref ProberInfo_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_ProberInfo_free(ref ProberInfo_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_ProductViewDefinition_init(ref ProductViewDefinition_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_ProductViewDefinition_free(ref ProductViewDefinition_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_ProductViewDefinitionList_init(ref ProductViewDefinitionList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_ProductViewDefinitionList_free(ref ProductViewDefinitionList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_ResizeByTexturesOptions_init(ref ResizeByTexturesOptions_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_ResizeByTexturesOptions_free(ref ResizeByTexturesOptions_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_MetadataDefinitionList_init(ref MetadataDefinitionList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_MetadataDefinitionList_free(ref MetadataDefinitionList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_VariantMaterialList_init(ref VariantMaterialList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_VariantMaterialList_free(ref VariantMaterialList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AnnotationDefinitionList_init(ref AnnotationDefinitionList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_AnnotationDefinitionList_free(ref AnnotationDefinitionList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_RayHitList_init(ref RayHitList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_RayHitList_free(ref RayHitList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_ResizeTexturesInputMode_init(ref ResizeTexturesInputMode_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_ResizeTexturesInputMode_free(ref ResizeTexturesInputMode_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_ResizeByMaximumSizeOptions_init(ref ResizeByMaximumSizeOptions_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_ResizeByMaximumSizeOptions_free(ref ResizeByMaximumSizeOptions_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_FilterList_init(ref FilterList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_FilterList_free(ref FilterList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_ResizeTexturesResizeMode_init(ref ResizeTexturesResizeMode_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_ResizeTexturesResizeMode_free(ref ResizeTexturesResizeMode_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_MergeByRegionsStrategy_init(ref MergeByRegionsStrategy_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_MergeByRegionsStrategy_free(ref MergeByRegionsStrategy_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_PackedTree_init(ref PackedTree_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Scene_PackedTree_free(ref PackedTree_c str);

	internal static PropertyValue ConvertValue(ref PropertyValue_c s) {
		PropertyValue ss = new PropertyValue();
		ss.name = ConvertValue(s.name);
		ss.value = ConvertValue(s.value);
		return ss;
	}

	internal static PropertyValue_c ConvertValue(PropertyValue s, ref PropertyValue_c ss) {
		Scene.SceneInterface.Scene_PropertyValue_init(ref ss);
		ss.name = ConvertValue(s.name);
		ss.value = ConvertValue(s.value);
		return ss;
	}

	internal static PropertyValueList ConvertValue(ref PropertyValueList_c s) {
		PropertyValueList list = new PropertyValueList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(PropertyValue_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			PropertyValue_c value = (PropertyValue_c)Marshal.PtrToStructure(p, typeof(PropertyValue_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static PropertyValueList_c ConvertValue(PropertyValueList s, ref PropertyValueList_c list) {
		Scene.SceneInterface.Scene_PropertyValueList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			PropertyValue_c elt = new PropertyValue_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(PropertyValue_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static VariantDefinition ConvertValue(ref VariantDefinition_c s) {
		VariantDefinition ss = new VariantDefinition();
		ss.variant = (System.UInt32)s.variant;
		ss.overridedProperties = ConvertValue(ref s.overridedProperties);
		return ss;
	}

	internal static VariantDefinition_c ConvertValue(VariantDefinition s, ref VariantDefinition_c ss) {
		Scene.SceneInterface.Scene_VariantDefinition_init(ref ss);
		ss.variant = (System.UInt32)s.variant;
		ConvertValue(s.overridedProperties, ref ss.overridedProperties);
		return ss;
	}

	internal static VariantDefinitionList ConvertValue(ref VariantDefinitionList_c s) {
		VariantDefinitionList list = new VariantDefinitionList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(VariantDefinition_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			VariantDefinition_c value = (VariantDefinition_c)Marshal.PtrToStructure(p, typeof(VariantDefinition_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static VariantDefinitionList_c ConvertValue(VariantDefinitionList s, ref VariantDefinitionList_c list) {
		Scene.SceneInterface.Scene_VariantDefinitionList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			VariantDefinition_c elt = new VariantDefinition_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(VariantDefinition_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static VariantDefinitionListList ConvertValue(ref VariantDefinitionListList_c s) {
		VariantDefinitionListList list = new VariantDefinitionListList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(VariantDefinitionList_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			VariantDefinitionList_c value = (VariantDefinitionList_c)Marshal.PtrToStructure(p, typeof(VariantDefinitionList_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static VariantDefinitionListList_c ConvertValue(VariantDefinitionListList s, ref VariantDefinitionListList_c list) {
		Scene.SceneInterface.Scene_VariantDefinitionListList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			VariantDefinitionList_c elt = new VariantDefinitionList_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(VariantDefinitionList_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static TessellatedShapeList ConvertValue(ref TessellatedShapeList_c s) {
		TessellatedShapeList list = new TessellatedShapeList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static TessellatedShapeList_c ConvertValue(TessellatedShapeList s, ref TessellatedShapeList_c list) {
		Scene.SceneInterface.Scene_TessellatedShapeList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static ComponentList ConvertValue(ref ComponentList_c s) {
		ComponentList list = new ComponentList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static ComponentList_c ConvertValue(ComponentList s, ref ComponentList_c list) {
		Scene.SceneInterface.Scene_ComponentList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static AnimChannelList ConvertValue(ref AnimChannelList_c s) {
		AnimChannelList list = new AnimChannelList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static AnimChannelList_c ConvertValue(AnimChannelList s, ref AnimChannelList_c list) {
		Scene.SceneInterface.Scene_AnimChannelList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static MaterialCount ConvertValue(ref MaterialCount_c s) {
		MaterialCount ss = new MaterialCount();
		ss.material = (System.UInt32)s.material;
		ss.count = (System.Int32)s.count;
		return ss;
	}

	internal static MaterialCount_c ConvertValue(MaterialCount s, ref MaterialCount_c ss) {
		Scene.SceneInterface.Scene_MaterialCount_init(ref ss);
		ss.material = (System.UInt32)s.material;
		ss.count = (Int32)s.count;
		return ss;
	}

	internal static AlternativeTreeList ConvertValue(ref AlternativeTreeList_c s) {
		AlternativeTreeList list = new AlternativeTreeList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static AlternativeTreeList_c ConvertValue(AlternativeTreeList s, ref AlternativeTreeList_c list) {
		Scene.SceneInterface.Scene_AlternativeTreeList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static VariantList ConvertValue(ref VariantList_c s) {
		VariantList list = new VariantList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static VariantList_c ConvertValue(VariantList s, ref VariantList_c list) {
		Scene.SceneInterface.Scene_VariantList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static VariantComponentList ConvertValue(ref VariantComponentList_c s) {
		VariantComponentList list = new VariantComponentList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static VariantComponentList_c ConvertValue(VariantComponentList s, ref VariantComponentList_c list) {
		Scene.SceneInterface.Scene_VariantComponentList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static MaterialCountList ConvertValue(ref MaterialCountList_c s) {
		MaterialCountList list = new MaterialCountList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<MaterialCount>(s.ptr, (int)s.size);
		return list;
	}

	internal static MaterialCountList_c ConvertValue(MaterialCountList s, ref MaterialCountList_c list) {
		Scene.SceneInterface.Scene_MaterialCountList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			MaterialCount_c elt = new MaterialCount_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(MaterialCount_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static AnimChannelInfo ConvertValue(ref AnimChannelInfo_c s) {
		AnimChannelInfo ss = new AnimChannelInfo();
		ss.name = ConvertValue(s.name);
		ss.type = (AnimChannelType)s.type;
		ss.mainPropertyBinder = (System.UInt32)s.mainPropertyBinder;
		ss.hasKeyFrames = ConvertValue(s.hasKeyFrames);
		return ss;
	}

	internal static AnimChannelInfo_c ConvertValue(AnimChannelInfo s, ref AnimChannelInfo_c ss) {
		Scene.SceneInterface.Scene_AnimChannelInfo_init(ref ss);
		ss.name = ConvertValue(s.name);
		ss.type = (Int32)s.type;
		ss.mainPropertyBinder = (System.UInt32)s.mainPropertyBinder;
		ss.hasKeyFrames = ConvertValue(s.hasKeyFrames);
		return ss;
	}

	internal static OccurrenceList ConvertValue(ref OccurrenceList_c s) {
		OccurrenceList list = new OccurrenceList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static OccurrenceList_c ConvertValue(OccurrenceList s, ref OccurrenceList_c list) {
		Scene.SceneInterface.Scene_OccurrenceList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static KeyframeList ConvertValue(ref KeyframeList_c s) {
		KeyframeList list = new KeyframeList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static KeyframeList_c ConvertValue(KeyframeList s, ref KeyframeList_c list) {
		Scene.SceneInterface.Scene_KeyframeList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static AnimationInfo ConvertValue(ref AnimationInfo_c s) {
		AnimationInfo ss = new AnimationInfo();
		ss.name = ConvertValue(s.name);
		ss.group = ConvertValue(s.group);
		ss.length = (System.UInt64)s.length;
		return ss;
	}

	internal static AnimationInfo_c ConvertValue(AnimationInfo s, ref AnimationInfo_c ss) {
		Scene.SceneInterface.Scene_AnimationInfo_init(ref ss);
		ss.name = ConvertValue(s.name);
		ss.group = ConvertValue(s.group);
		ss.length = (System.UInt64)s.length;
		return ss;
	}

	internal static AnimPropertyBinder ConvertValue(ref AnimPropertyBinder_c s) {
		AnimPropertyBinder ss = new AnimPropertyBinder();
		ss.occurrence = (System.UInt32)s.occurrence;
		ss.animation = (System.UInt32)s.animation;
		ss.mainChannel = (System.UInt32)s.mainChannel;
		return ss;
	}

	internal static AnimPropertyBinder_c ConvertValue(AnimPropertyBinder s, ref AnimPropertyBinder_c ss) {
		Scene.SceneInterface.Scene_AnimPropertyBinder_init(ref ss);
		ss.occurrence = (System.UInt32)s.occurrence;
		ss.animation = (System.UInt32)s.animation;
		ss.mainChannel = (System.UInt32)s.mainChannel;
		return ss;
	}

	internal static LODList ConvertValue(ref LODList_c s) {
		LODList list = new LODList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static LODList_c ConvertValue(LODList s, ref LODList_c list) {
		Scene.SceneInterface.Scene_LODList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static AnnotationGroupList ConvertValue(ref AnnotationGroupList_c s) {
		AnnotationGroupList list = new AnnotationGroupList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static AnnotationGroupList_c ConvertValue(AnnotationGroupList s, ref AnnotationGroupList_c list) {
		Scene.SceneInterface.Scene_AnnotationGroupList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static OccurrenceListList ConvertValue(ref OccurrenceListList_c s) {
		OccurrenceListList list = new OccurrenceListList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(OccurrenceList_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			OccurrenceList_c value = (OccurrenceList_c)Marshal.PtrToStructure(p, typeof(OccurrenceList_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static OccurrenceListList_c ConvertValue(OccurrenceListList s, ref OccurrenceListList_c list) {
		Scene.SceneInterface.Scene_OccurrenceListList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			OccurrenceList_c elt = new OccurrenceList_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(OccurrenceList_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static LODComponentList ConvertValue(ref LODComponentList_c s) {
		LODComponentList list = new LODComponentList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static LODComponentList_c ConvertValue(LODComponentList s, ref LODComponentList_c list) {
		Scene.SceneInterface.Scene_LODComponentList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static AnimationList ConvertValue(ref AnimationList_c s) {
		AnimationList list = new AnimationList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static AnimationList_c ConvertValue(AnimationList s, ref AnimationList_c list) {
		Scene.SceneInterface.Scene_AnimationList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static AnnotationList ConvertValue(ref AnnotationList_c s) {
		AnnotationList list = new AnnotationList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static AnnotationList_c ConvertValue(AnnotationList s, ref AnnotationList_c list) {
		Scene.SceneInterface.Scene_AnnotationList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static PartList ConvertValue(ref PartList_c s) {
		PartList list = new PartList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static PartList_c ConvertValue(PartList s, ref PartList_c list) {
		Scene.SceneInterface.Scene_PartList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static AnimPropertyBinderList ConvertValue(ref AnimPropertyBinderList_c s) {
		AnimPropertyBinderList list = new AnimPropertyBinderList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<AnimPropertyBinder>(s.ptr, (int)s.size);
		return list;
	}

	internal static AnimPropertyBinderList_c ConvertValue(AnimPropertyBinderList s, ref AnimPropertyBinderList_c list) {
		Scene.SceneInterface.Scene_AnimPropertyBinderList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			AnimPropertyBinder_c elt = new AnimPropertyBinder_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(AnimPropertyBinder_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static MetadataList ConvertValue(ref MetadataList_c s) {
		MetadataList list = new MetadataList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static MetadataList_c ConvertValue(MetadataList s, ref MetadataList_c list) {
		Scene.SceneInterface.Scene_MetadataList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static Geom.Point2 ConvertValue(ref Geom.Point2_c s) {
		Geom.Point2 ss = new Geom.Point2();
		ss.x = (System.Double)s.x;
		ss.y = (System.Double)s.y;
		return ss;
	}

	internal static Geom.Point2_c ConvertValue(Geom.Point2 s, ref Geom.Point2_c ss) {
		Geom.GeomInterface.Geom_Point2_init(ref ss);
		ss.x = (System.Double)s.x;
		ss.y = (System.Double)s.y;
		return ss;
	}

	internal static RayHit ConvertValue(ref RayHit_c s) {
		RayHit ss = new RayHit();
		ss.rayParam = (System.Double)s.rayParam;
		ss.occurrence = (System.UInt32)s.occurrence;
		ss.triangleIndex = (System.Int32)s.triangleIndex;
		ss.triangleParam = Geom.GeomInterface.ConvertValue(ref s.triangleParam);
		return ss;
	}

	internal static RayHit_c ConvertValue(RayHit s, ref RayHit_c ss) {
		Scene.SceneInterface.Scene_RayHit_init(ref ss);
		ss.rayParam = (System.Double)s.rayParam;
		ss.occurrence = (System.UInt32)s.occurrence;
		ss.triangleIndex = (Int32)s.triangleIndex;
		Geom.GeomInterface.ConvertValue(s.triangleParam, ref ss.triangleParam);
		return ss;
	}

	internal static Filter ConvertValue(ref Filter_c s) {
		Filter ss = new Filter();
		ss.id = (System.UInt32)s.id;
		ss.name = ConvertValue(s.name);
		ss.expr = ConvertValue(s.expr);
		return ss;
	}

	internal static Filter_c ConvertValue(Filter s, ref Filter_c ss) {
		Scene.SceneInterface.Scene_Filter_init(ref ss);
		ss.id = (System.UInt32)s.id;
		ss.name = ConvertValue(s.name);
		ss.expr = ConvertValue(s.expr);
		return ss;
	}

	internal static Polygonal.JointList ConvertValue(ref Polygonal.JointList_c s) {
		Polygonal.JointList list = new Polygonal.JointList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static Polygonal.JointList_c ConvertValue(Polygonal.JointList s, ref Polygonal.JointList_c list) {
		Polygonal.PolygonalInterface.Polygonal_JointList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static Geom.Array4 ConvertValue(ref Geom.Array4_c arr) {
		Geom.Array4 ss = new Geom.Array4();
		System.Double[] tab = new System.Double[4];
		Marshal.Copy(arr.tab, tab, 0, 4);
		for (int i = 0; i < 4; ++i)
			ss.tab[i] = tab[i];
		return ss;
	}

	internal static Geom.Array4_c ConvertValue(Geom.Array4 s, ref Geom.Array4_c list) {
		Geom.GeomInterface.Geom_Array4_init(ref list, (System.UInt64)4);
		var tab = new System.Double[4];
		for (int i=0; i < 4; ++i)
			tab[i] = s.tab[i];
		Marshal.Copy(tab, 0, list.tab, 4);
		return list;
	}

	internal static Geom.Matrix4 ConvertValue(ref Geom.Matrix4_c arr) {
		Geom.Matrix4 ss = new Geom.Matrix4();
		for (int i = 0; i < 4; ++i) {
			IntPtr p = new IntPtr(arr.tab.ToInt64() + i * Marshal.SizeOf(typeof(Geom.Array4_c)));
			Geom.Array4_c value = (Geom.Array4_c)Marshal.PtrToStructure(p, typeof(Geom.Array4_c));
			ss.tab[i] = Geom.GeomInterface.ConvertValue(ref value);
		}
		return ss;
	}

	internal static Geom.Matrix4_c ConvertValue(Geom.Matrix4 s, ref Geom.Matrix4_c list) {
		Geom.GeomInterface.Geom_Matrix4_init(ref list, (System.UInt64)4);
		for (int i = 0; i < 4; ++i) {
			Geom.Array4_c elt = new Geom.Array4_c();
			Geom.GeomInterface.ConvertValue(s.tab[i], ref elt);
			IntPtr p = new IntPtr(list.tab.ToInt64() + i * Marshal.SizeOf(typeof(Geom.Array4_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static JointDefinition ConvertValue(ref JointDefinition_c s) {
		JointDefinition ss = new JointDefinition();
		ss.id = (System.UInt32)s.id;
		ss.jointComponent = (System.UInt32)s.jointComponent;
		ss.isRoot = ConvertValue(s.isRoot);
		ss.rootJoint = (System.UInt32)s.rootJoint;
		ss.parent = (System.UInt32)s.parent;
		ss.children = Polygonal.PolygonalInterface.ConvertValue(ref s.children);
		ss.matrix = Geom.GeomInterface.ConvertValue(ref s.matrix);
		ss.gloablMatrix = Geom.GeomInterface.ConvertValue(ref s.gloablMatrix);
		return ss;
	}

	internal static JointDefinition_c ConvertValue(JointDefinition s, ref JointDefinition_c ss) {
		Scene.SceneInterface.Scene_JointDefinition_init(ref ss);
		ss.id = (System.UInt32)s.id;
		ss.jointComponent = (System.UInt32)s.jointComponent;
		ss.isRoot = ConvertValue(s.isRoot);
		ss.rootJoint = (System.UInt32)s.rootJoint;
		ss.parent = (System.UInt32)s.parent;
		Polygonal.PolygonalInterface.ConvertValue(s.children, ref ss.children);
		Geom.GeomInterface.ConvertValue(s.matrix, ref ss.matrix);
		Geom.GeomInterface.ConvertValue(s.gloablMatrix, ref ss.gloablMatrix);
		return ss;
	}

	internal static JointDefinitionList ConvertValue(ref JointDefinitionList_c s) {
		JointDefinitionList list = new JointDefinitionList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(JointDefinition_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			JointDefinition_c value = (JointDefinition_c)Marshal.PtrToStructure(p, typeof(JointDefinition_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static JointDefinitionList_c ConvertValue(JointDefinitionList s, ref JointDefinitionList_c list) {
		Scene.SceneInterface.Scene_JointDefinitionList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			JointDefinition_c elt = new JointDefinition_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(JointDefinition_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Material.MaterialList ConvertValue(ref Material.MaterialList_c s) {
		Material.MaterialList list = new Material.MaterialList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static Material.MaterialList_c ConvertValue(Material.MaterialList s, ref Material.MaterialList_c list) {
		Material.MaterialInterface.Material_MaterialList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static VariantMaterials ConvertValue(ref VariantMaterials_c s) {
		VariantMaterials ss = new VariantMaterials();
		ss.id = (System.UInt32)s.id;
		ss.materials = Material.MaterialInterface.ConvertValue(ref s.materials);
		return ss;
	}

	internal static VariantMaterials_c ConvertValue(VariantMaterials s, ref VariantMaterials_c ss) {
		Scene.SceneInterface.Scene_VariantMaterials_init(ref ss);
		ss.id = (System.UInt32)s.id;
		Material.MaterialInterface.ConvertValue(s.materials, ref ss.materials);
		return ss;
	}

	internal static AnnotationDefinition ConvertValue(ref AnnotationDefinition_c s) {
		AnnotationDefinition ss = new AnnotationDefinition();
		ss.id = (System.UInt32)s.id;
		ss.name = ConvertValue(s.name);
		ss.visible = ConvertValue(s.visible);
		ss.group = (System.UInt32)s.group;
		ss.shapes = ConvertValue(ref s.shapes);
		return ss;
	}

	internal static AnnotationDefinition_c ConvertValue(AnnotationDefinition s, ref AnnotationDefinition_c ss) {
		Scene.SceneInterface.Scene_AnnotationDefinition_init(ref ss);
		ss.id = (System.UInt32)s.id;
		ss.name = ConvertValue(s.name);
		ss.visible = ConvertValue(s.visible);
		ss.group = (System.UInt32)s.group;
		ConvertValue(s.shapes, ref ss.shapes);
		return ss;
	}

	internal static Geom.Point3 ConvertValue(ref Geom.Point3_c s) {
		Geom.Point3 ss = new Geom.Point3();
		ss.x = (System.Double)s.x;
		ss.y = (System.Double)s.y;
		ss.z = (System.Double)s.z;
		return ss;
	}

	internal static Geom.Point3_c ConvertValue(Geom.Point3 s, ref Geom.Point3_c ss) {
		Geom.GeomInterface.Geom_Point3_init(ref ss);
		ss.x = (System.Double)s.x;
		ss.y = (System.Double)s.y;
		ss.z = (System.Double)s.z;
		return ss;
	}

	internal static ProberInfo ConvertValue(ref ProberInfo_c s) {
		ProberInfo ss = new ProberInfo();
		ss.occurrence = (System.UInt32)s.occurrence;
		ss.position = Geom.GeomInterface.ConvertValue(ref s.position);
		return ss;
	}

	internal static ProberInfo_c ConvertValue(ProberInfo s, ref ProberInfo_c ss) {
		Scene.SceneInterface.Scene_ProberInfo_init(ref ss);
		ss.occurrence = (System.UInt32)s.occurrence;
		Geom.GeomInterface.ConvertValue(s.position, ref ss.position);
		return ss;
	}

	internal static ProductViewDefinition ConvertValue(ref ProductViewDefinition_c s) {
		ProductViewDefinition ss = new ProductViewDefinition();
		ss.id = (System.UInt32)s.id;
		ss.name = ConvertValue(s.name);
		ss.groupName = ConvertValue(s.groupName);
		ss.view = Geom.GeomInterface.ConvertValue(ref s.view);
		ss.viewIsSet = ConvertValue(s.viewIsSet);
		ss.viewIsOrtho = ConvertValue(s.viewIsOrtho);
		ss.viewFov = (System.Double)s.viewFov;
		ss.cuttingPlane = ConvertValue(s.cuttingPlane);
		ss.cuttingPlanePosition = Geom.GeomInterface.ConvertValue(ref s.cuttingPlanePosition);
		ss.cuttingPlaneNormal = Geom.GeomInterface.ConvertValue(ref s.cuttingPlaneNormal);
		ss.explodedViewFactor = (System.Double)s.explodedViewFactor;
		ss.explodedViewX = ConvertValue(s.explodedViewX);
		ss.explodedViewY = ConvertValue(s.explodedViewY);
		ss.explodedViewZ = ConvertValue(s.explodedViewZ);
		ss.annotations = ConvertValue(ref s.annotations);
		return ss;
	}

	internal static ProductViewDefinition_c ConvertValue(ProductViewDefinition s, ref ProductViewDefinition_c ss) {
		Scene.SceneInterface.Scene_ProductViewDefinition_init(ref ss);
		ss.id = (System.UInt32)s.id;
		ss.name = ConvertValue(s.name);
		ss.groupName = ConvertValue(s.groupName);
		Geom.GeomInterface.ConvertValue(s.view, ref ss.view);
		ss.viewIsSet = ConvertValue(s.viewIsSet);
		ss.viewIsOrtho = ConvertValue(s.viewIsOrtho);
		ss.viewFov = (System.Double)s.viewFov;
		ss.cuttingPlane = ConvertValue(s.cuttingPlane);
		Geom.GeomInterface.ConvertValue(s.cuttingPlanePosition, ref ss.cuttingPlanePosition);
		Geom.GeomInterface.ConvertValue(s.cuttingPlaneNormal, ref ss.cuttingPlaneNormal);
		ss.explodedViewFactor = (System.Double)s.explodedViewFactor;
		ss.explodedViewX = ConvertValue(s.explodedViewX);
		ss.explodedViewY = ConvertValue(s.explodedViewY);
		ss.explodedViewZ = ConvertValue(s.explodedViewZ);
		ConvertValue(s.annotations, ref ss.annotations);
		return ss;
	}

	internal static ProductViewDefinitionList ConvertValue(ref ProductViewDefinitionList_c s) {
		ProductViewDefinitionList list = new ProductViewDefinitionList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(ProductViewDefinition_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			ProductViewDefinition_c value = (ProductViewDefinition_c)Marshal.PtrToStructure(p, typeof(ProductViewDefinition_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static ProductViewDefinitionList_c ConvertValue(ProductViewDefinitionList s, ref ProductViewDefinitionList_c list) {
		Scene.SceneInterface.Scene_ProductViewDefinitionList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			ProductViewDefinition_c elt = new ProductViewDefinition_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(ProductViewDefinition_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Material.ImageList ConvertValue(ref Material.ImageList_c s) {
		Material.ImageList list = new Material.ImageList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static Material.ImageList_c ConvertValue(Material.ImageList s, ref Material.ImageList_c list) {
		Material.MaterialInterface.Material_ImageList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static ResizeByTexturesOptions ConvertValue(ref ResizeByTexturesOptions_c s) {
		ResizeByTexturesOptions ss = new ResizeByTexturesOptions();
		ss._type = (ResizeByTexturesOptions.Type)s._type;
		switch(ss._type) {
			case ResizeByTexturesOptions.Type.UNKNOWN: break;
			case ResizeByTexturesOptions.Type.ALLTEXTURES: ss.AllTextures = (Int32)s.AllTextures; break;
			case ResizeByTexturesOptions.Type.SELECTION: ss.Selection = ConvertValue(ref s.Selection); break;
		}
		return ss;
	}

	internal static ResizeByTexturesOptions_c ConvertValue(ResizeByTexturesOptions s, ref ResizeByTexturesOptions_c ss) {
		Scene.SceneInterface.Scene_ResizeByTexturesOptions_init(ref ss);
		ss._type = (int)s._type;
		switch (ss._type) {
			case 0: break;
			case 1: ss.AllTextures = (Int32)s.AllTextures; break;
			case 2: ConvertValue(s.Selection, ref ss.Selection); break;
		}
		return ss;
	}

	internal static MetadataDefinitionList ConvertValue(ref MetadataDefinitionList_c s) {
		MetadataDefinitionList list = new MetadataDefinitionList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(PropertyValueList_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			PropertyValueList_c value = (PropertyValueList_c)Marshal.PtrToStructure(p, typeof(PropertyValueList_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static MetadataDefinitionList_c ConvertValue(MetadataDefinitionList s, ref MetadataDefinitionList_c list) {
		Scene.SceneInterface.Scene_MetadataDefinitionList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			PropertyValueList_c elt = new PropertyValueList_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(PropertyValueList_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static VariantMaterialList ConvertValue(ref VariantMaterialList_c s) {
		VariantMaterialList list = new VariantMaterialList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(VariantMaterials_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			VariantMaterials_c value = (VariantMaterials_c)Marshal.PtrToStructure(p, typeof(VariantMaterials_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static VariantMaterialList_c ConvertValue(VariantMaterialList s, ref VariantMaterialList_c list) {
		Scene.SceneInterface.Scene_VariantMaterialList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			VariantMaterials_c elt = new VariantMaterials_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(VariantMaterials_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static AnnotationDefinitionList ConvertValue(ref AnnotationDefinitionList_c s) {
		AnnotationDefinitionList list = new AnnotationDefinitionList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(AnnotationDefinition_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			AnnotationDefinition_c value = (AnnotationDefinition_c)Marshal.PtrToStructure(p, typeof(AnnotationDefinition_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static AnnotationDefinitionList_c ConvertValue(AnnotationDefinitionList s, ref AnnotationDefinitionList_c list) {
		Scene.SceneInterface.Scene_AnnotationDefinitionList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			AnnotationDefinition_c elt = new AnnotationDefinition_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(AnnotationDefinition_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static RayHitList ConvertValue(ref RayHitList_c s) {
		RayHitList list = new RayHitList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(RayHit_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			RayHit_c value = (RayHit_c)Marshal.PtrToStructure(p, typeof(RayHit_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static RayHitList_c ConvertValue(RayHitList s, ref RayHitList_c list) {
		Scene.SceneInterface.Scene_RayHitList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			RayHit_c elt = new RayHit_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(RayHit_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static ResizeTexturesInputMode ConvertValue(ref ResizeTexturesInputMode_c s) {
		ResizeTexturesInputMode ss = new ResizeTexturesInputMode();
		ss._type = (ResizeTexturesInputMode.Type)s._type;
		switch(ss._type) {
			case ResizeTexturesInputMode.Type.UNKNOWN: break;
			case ResizeTexturesInputMode.Type.OCCURRENCES: ss.Occurrences = ConvertValue(ref s.Occurrences); break;
			case ResizeTexturesInputMode.Type.TEXTURES: ss.Textures = ConvertValue(ref s.Textures); break;
		}
		return ss;
	}

	internal static ResizeTexturesInputMode_c ConvertValue(ResizeTexturesInputMode s, ref ResizeTexturesInputMode_c ss) {
		Scene.SceneInterface.Scene_ResizeTexturesInputMode_init(ref ss);
		ss._type = (int)s._type;
		switch (ss._type) {
			case 0: break;
			case 1: ConvertValue(s.Occurrences, ref ss.Occurrences); break;
			case 2: ConvertValue(s.Textures, ref ss.Textures); break;
		}
		return ss;
	}

	internal static ResizeByMaximumSizeOptions ConvertValue(ref ResizeByMaximumSizeOptions_c s) {
		ResizeByMaximumSizeOptions ss = new ResizeByMaximumSizeOptions();
		ss.TextureSize = (System.Int32)s.TextureSize;
		ss.KeepTextureRatio = ConvertValue(s.KeepTextureRatio);
		return ss;
	}

	internal static ResizeByMaximumSizeOptions_c ConvertValue(ResizeByMaximumSizeOptions s, ref ResizeByMaximumSizeOptions_c ss) {
		Scene.SceneInterface.Scene_ResizeByMaximumSizeOptions_init(ref ss);
		ss.TextureSize = (Int32)s.TextureSize;
		ss.KeepTextureRatio = ConvertValue(s.KeepTextureRatio);
		return ss;
	}

	internal static FilterList ConvertValue(ref FilterList_c s) {
		FilterList list = new FilterList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(Filter_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			Filter_c value = (Filter_c)Marshal.PtrToStructure(p, typeof(Filter_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static FilterList_c ConvertValue(FilterList s, ref FilterList_c list) {
		Scene.SceneInterface.Scene_FilterList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Filter_c elt = new Filter_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Filter_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static ResizeTexturesResizeMode ConvertValue(ref ResizeTexturesResizeMode_c s) {
		ResizeTexturesResizeMode ss = new ResizeTexturesResizeMode();
		ss._type = (ResizeTexturesResizeMode.Type)s._type;
		switch(ss._type) {
			case ResizeTexturesResizeMode.Type.UNKNOWN: break;
			case ResizeTexturesResizeMode.Type.RATIO: ss.Ratio = (System.Double)s.Ratio; break;
			case ResizeTexturesResizeMode.Type.MAXIMUMSIZE: ss.MaximumSize = ConvertValue(ref s.MaximumSize); break;
		}
		return ss;
	}

	internal static ResizeTexturesResizeMode_c ConvertValue(ResizeTexturesResizeMode s, ref ResizeTexturesResizeMode_c ss) {
		Scene.SceneInterface.Scene_ResizeTexturesResizeMode_init(ref ss);
		ss._type = (int)s._type;
		switch (ss._type) {
			case 0: break;
			case 1: ss.Ratio = (System.Double)s.Ratio; break;
			case 2: ConvertValue(s.MaximumSize, ref ss.MaximumSize); break;
		}
		return ss;
	}

	internal static MergeByRegionsStrategy ConvertValue(ref MergeByRegionsStrategy_c s) {
		MergeByRegionsStrategy ss = new MergeByRegionsStrategy();
		ss._type = (MergeByRegionsStrategy.Type)s._type;
		switch(ss._type) {
			case MergeByRegionsStrategy.Type.UNKNOWN: break;
			case MergeByRegionsStrategy.Type.NUMBEROFREGIONS: ss.NumberOfRegions = (Int32)s.NumberOfRegions; break;
			case MergeByRegionsStrategy.Type.SIZEOFREGIONS: ss.SizeOfRegions = (System.Double)s.SizeOfRegions; break;
		}
		return ss;
	}

	internal static MergeByRegionsStrategy_c ConvertValue(MergeByRegionsStrategy s, ref MergeByRegionsStrategy_c ss) {
		Scene.SceneInterface.Scene_MergeByRegionsStrategy_init(ref ss);
		ss._type = (int)s._type;
		switch (ss._type) {
			case 0: break;
			case 1: ss.NumberOfRegions = (Int32)s.NumberOfRegions; break;
			case 2: ss.SizeOfRegions = (System.Double)s.SizeOfRegions; break;
		}
		return ss;
	}

	internal static Core.IntList ConvertValue(ref Core.IntList_c s) {
		Core.IntList list = new Core.IntList((int)s.size);
		if (s.size > 0)
			Marshal.Copy(s.ptr, list.list, 0, (int)s.size);
		return list;
	}

	internal static Core.IntList_c ConvertValue(Core.IntList s, ref Core.IntList_c list) {
		Core.CoreInterface.Core_IntList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size > 0)
			Marshal.Copy(s.list, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static Core.StringList ConvertValue(ref Core.StringList_c s) {
		Core.StringList list = new Core.StringList((int)s.size);
		if (s.size==0) return list;

		IntPtr[] tab = new IntPtr[s.size];
		Marshal.Copy(s.ptr, tab, 0, (int)s.size);
		for (int i = 0; i < (int)s.size; ++i) {
			list.list[i] = ConvertValue(tab[i]);
		}
		return list;
	}

	internal static Core.StringList_c ConvertValue(Core.StringList s, ref Core.StringList_c list) {
		Core.CoreInterface.Core_StringList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		IntPtr[] tab = new IntPtr[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = ConvertValue(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static Core.InheritableBoolList ConvertValue(ref Core.InheritableBoolList_c s) {
		Core.InheritableBoolList list = new Core.InheritableBoolList((int)s.size);
		if (s.size==0) return list;

		int[] tab = new int[s.size];
		Marshal.Copy(s.ptr, tab, 0, (int)s.size);
		for (int i = 0; i < (int)s.size; ++i) {
			list.list[i] = (Core.InheritableBool)tab[i];
		}
		return list;
	}

	internal static Core.InheritableBoolList_c ConvertValue(Core.InheritableBoolList s, ref Core.InheritableBoolList_c list) {
		Core.CoreInterface.Core_InheritableBoolList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)s.list[i];
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static Geom.Matrix4List ConvertValue(ref Geom.Matrix4List_c s) {
		Geom.Matrix4List list = new Geom.Matrix4List((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(Geom.Matrix4_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			Geom.Matrix4_c value = (Geom.Matrix4_c)Marshal.PtrToStructure(p, typeof(Geom.Matrix4_c));
			list.list[i] = Geom.GeomInterface.ConvertValue(ref value);
		}
		return list;
	}

	internal static Geom.Matrix4List_c ConvertValue(Geom.Matrix4List s, ref Geom.Matrix4List_c list) {
		Geom.GeomInterface.Geom_Matrix4List_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Geom.Matrix4_c elt = new Geom.Matrix4_c();
			Geom.GeomInterface.ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Geom.Matrix4_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Core.StringPair ConvertValue(ref Core.StringPair_c s) {
		Core.StringPair ss = new Core.StringPair();
		ss.key = ConvertValue(s.key);
		ss.value = ConvertValue(s.value);
		return ss;
	}

	internal static Core.StringPair_c ConvertValue(Core.StringPair s, ref Core.StringPair_c ss) {
		Core.CoreInterface.Core_StringPair_init(ref ss);
		ss.key = ConvertValue(s.key);
		ss.value = ConvertValue(s.value);
		return ss;
	}

	internal static Core.StringPairList ConvertValue(ref Core.StringPairList_c s) {
		Core.StringPairList list = new Core.StringPairList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(Core.StringPair_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			Core.StringPair_c value = (Core.StringPair_c)Marshal.PtrToStructure(p, typeof(Core.StringPair_c));
			list.list[i] = Core.CoreInterface.ConvertValue(ref value);
		}
		return list;
	}

	internal static Core.StringPairList_c ConvertValue(Core.StringPairList s, ref Core.StringPairList_c list) {
		Core.CoreInterface.Core_StringPairList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Core.StringPair_c elt = new Core.StringPair_c();
			Core.CoreInterface.ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Core.StringPair_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Core.StringPairListList ConvertValue(ref Core.StringPairListList_c s) {
		Core.StringPairListList list = new Core.StringPairListList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(Core.StringPairList_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			Core.StringPairList_c value = (Core.StringPairList_c)Marshal.PtrToStructure(p, typeof(Core.StringPairList_c));
			list.list[i] = Core.CoreInterface.ConvertValue(ref value);
		}
		return list;
	}

	internal static Core.StringPairListList_c ConvertValue(Core.StringPairListList s, ref Core.StringPairListList_c list) {
		Core.CoreInterface.Core_StringPairListList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Core.StringPairList_c elt = new Core.StringPairList_c();
			Core.CoreInterface.ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Core.StringPairList_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static PackedTree ConvertValue(ref PackedTree_c s) {
		PackedTree ss = new PackedTree();
		ss.occurrences = ConvertValue(ref s.occurrences);
		ss.parents = Core.CoreInterface.ConvertValue(ref s.parents);
		ss.names = Core.CoreInterface.ConvertValue(ref s.names);
		ss.visible = Core.CoreInterface.ConvertValue(ref s.visible);
		ss.materials = Material.MaterialInterface.ConvertValue(ref s.materials);
		ss.transformIndices = Core.CoreInterface.ConvertValue(ref s.transformIndices);
		ss.transformMatrices = Geom.GeomInterface.ConvertValue(ref s.transformMatrices);
		ss.customProperties = Core.CoreInterface.ConvertValue(ref s.customProperties);
		return ss;
	}

	internal static PackedTree_c ConvertValue(PackedTree s, ref PackedTree_c ss) {
		Scene.SceneInterface.Scene_PackedTree_init(ref ss);
		ConvertValue(s.occurrences, ref ss.occurrences);
		Core.CoreInterface.ConvertValue(s.parents, ref ss.parents);
		Core.CoreInterface.ConvertValue(s.names, ref ss.names);
		Core.CoreInterface.ConvertValue(s.visible, ref ss.visible);
		Material.MaterialInterface.ConvertValue(s.materials, ref ss.materials);
		Core.CoreInterface.ConvertValue(s.transformIndices, ref ss.transformIndices);
		Geom.GeomInterface.ConvertValue(s.transformMatrices, ref ss.transformMatrices);
		Core.CoreInterface.ConvertValue(s.customProperties, ref ss.customProperties);
		return ss;
	}

	internal static GetSubTreeStatsReturn ConvertValue(ref GetSubTreeStatsReturn_c s) {
		GetSubTreeStatsReturn ss = new GetSubTreeStatsReturn();
		ss.partCount = (System.UInt64)s.partCount;
		ss.partOccurrenceCount = (System.UInt64)s.partOccurrenceCount;
		ss.triangleCount = (System.UInt64)s.triangleCount;
		ss.triangleOccurrenceCount = (System.UInt64)s.triangleOccurrenceCount;
		ss.vertexCount = (System.UInt64)s.vertexCount;
		ss.vertexOccurrenceCount = (System.UInt64)s.vertexOccurrenceCount;
		ss.pointCount = (System.UInt64)s.pointCount;
		ss.pointOccurrenceCount = (System.UInt64)s.pointOccurrenceCount;
		ss.lineCount = (System.UInt64)s.lineCount;
		ss.lineOccurrenceCount = (System.UInt64)s.lineOccurrenceCount;
		ss.patchesCount = (System.UInt64)s.patchesCount;
		return ss;
	}

	internal static GetSubTreeStatsReturn_c ConvertValue(GetSubTreeStatsReturn s, ref GetSubTreeStatsReturn_c ss) {
		ss.partCount = (System.UInt64)s.partCount;
		ss.partOccurrenceCount = (System.UInt64)s.partOccurrenceCount;
		ss.triangleCount = (System.UInt64)s.triangleCount;
		ss.triangleOccurrenceCount = (System.UInt64)s.triangleOccurrenceCount;
		ss.vertexCount = (System.UInt64)s.vertexCount;
		ss.vertexOccurrenceCount = (System.UInt64)s.vertexOccurrenceCount;
		ss.pointCount = (System.UInt64)s.pointCount;
		ss.pointOccurrenceCount = (System.UInt64)s.pointOccurrenceCount;
		ss.lineCount = (System.UInt64)s.lineCount;
		ss.lineOccurrenceCount = (System.UInt64)s.lineOccurrenceCount;
		ss.patchesCount = (System.UInt64)s.patchesCount;
		return ss;
	}

	internal static Geom.Point3List ConvertValue(ref Geom.Point3List_c s) {
		Geom.Point3List list = new Geom.Point3List((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<Geom.Point3>(s.ptr, (int)s.size);
		return list;
	}

	internal static Geom.Point3List_c ConvertValue(Geom.Point3List s, ref Geom.Point3List_c list) {
		Geom.GeomInterface.Geom_Point3List_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Geom.Point3_c elt = new Geom.Point3_c();
			Geom.GeomInterface.ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Geom.Point3_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static GetViewpointsFromCavitiesReturn ConvertValue(ref GetViewpointsFromCavitiesReturn_c s) {
		GetViewpointsFromCavitiesReturn ss = new GetViewpointsFromCavitiesReturn();
		ss.positions = Geom.GeomInterface.ConvertValue(ref s.positions);
		ss.directions = Geom.GeomInterface.ConvertValue(ref s.directions);
		return ss;
	}

	internal static GetViewpointsFromCavitiesReturn_c ConvertValue(GetViewpointsFromCavitiesReturn s, ref GetViewpointsFromCavitiesReturn_c ss) {
		Geom.GeomInterface.ConvertValue(s.positions, ref ss.positions);
		Geom.GeomInterface.ConvertValue(s.directions, ref ss.directions);
		return ss;
	}

	internal static GetBRepInfosReturn ConvertValue(ref GetBRepInfosReturn_c s) {
		GetBRepInfosReturn ss = new GetBRepInfosReturn();
		ss.partCount = (System.Int32)s.partCount;
		ss.totalPartCount = (System.Int32)s.totalPartCount;
		ss.vertexCount = (System.Int32)s.vertexCount;
		ss.totalVertexCount = (System.Int32)s.totalVertexCount;
		ss.edgeCount = (System.Int32)s.edgeCount;
		ss.totalEdgeCount = (System.Int32)s.totalEdgeCount;
		ss.openShellCount = (System.Int32)s.openShellCount;
		ss.totalOpenShellCount = (System.Int32)s.totalOpenShellCount;
		ss.bodyCount = (System.Int32)s.bodyCount;
		ss.totalBodyCount = (System.Int32)s.totalBodyCount;
		ss.area2Dsum = (System.Double)s.area2Dsum;
		ss.boundaryCount = (System.Int32)s.boundaryCount;
		ss.boundaryEdgeCount = (System.Int32)s.boundaryEdgeCount;
		return ss;
	}

	internal static GetBRepInfosReturn_c ConvertValue(GetBRepInfosReturn s, ref GetBRepInfosReturn_c ss) {
		ss.partCount = (Int32)s.partCount;
		ss.totalPartCount = (Int32)s.totalPartCount;
		ss.vertexCount = (Int32)s.vertexCount;
		ss.totalVertexCount = (Int32)s.totalVertexCount;
		ss.edgeCount = (Int32)s.edgeCount;
		ss.totalEdgeCount = (Int32)s.totalEdgeCount;
		ss.openShellCount = (Int32)s.openShellCount;
		ss.totalOpenShellCount = (Int32)s.totalOpenShellCount;
		ss.bodyCount = (Int32)s.bodyCount;
		ss.totalBodyCount = (Int32)s.totalBodyCount;
		ss.area2Dsum = (System.Double)s.area2Dsum;
		ss.boundaryCount = (Int32)s.boundaryCount;
		ss.boundaryEdgeCount = (Int32)s.boundaryEdgeCount;
		return ss;
	}

	internal static GetTessellationInfosReturn ConvertValue(ref GetTessellationInfosReturn_c s) {
		GetTessellationInfosReturn ss = new GetTessellationInfosReturn();
		ss.partCount = (System.Int32)s.partCount;
		ss.totalPartCount = (System.Int32)s.totalPartCount;
		ss.vertexCount = (System.Int32)s.vertexCount;
		ss.totalVertexCount = (System.Int32)s.totalVertexCount;
		ss.edgeCount = (System.Int32)s.edgeCount;
		ss.totalEdgeCount = (System.Int32)s.totalEdgeCount;
		ss.polygonCount = (System.Int32)s.polygonCount;
		ss.totalPolygonCount = (System.Int32)s.totalPolygonCount;
		ss.patchCount = (System.Int32)s.patchCount;
		ss.totalPatchCount = (System.Int32)s.totalPatchCount;
		ss.boundaryCount = (System.Int32)s.boundaryCount;
		ss.boundaryEdgeCount = (System.Int32)s.boundaryEdgeCount;
		ss.nonManifoldEdgeCount = (System.Int32)s.nonManifoldEdgeCount;
		return ss;
	}

	internal static GetTessellationInfosReturn_c ConvertValue(GetTessellationInfosReturn s, ref GetTessellationInfosReturn_c ss) {
		ss.partCount = (Int32)s.partCount;
		ss.totalPartCount = (Int32)s.totalPartCount;
		ss.vertexCount = (Int32)s.vertexCount;
		ss.totalVertexCount = (Int32)s.totalVertexCount;
		ss.edgeCount = (Int32)s.edgeCount;
		ss.totalEdgeCount = (Int32)s.totalEdgeCount;
		ss.polygonCount = (Int32)s.polygonCount;
		ss.totalPolygonCount = (Int32)s.totalPolygonCount;
		ss.patchCount = (Int32)s.patchCount;
		ss.totalPatchCount = (Int32)s.totalPatchCount;
		ss.boundaryCount = (Int32)s.boundaryCount;
		ss.boundaryEdgeCount = (Int32)s.boundaryEdgeCount;
		ss.nonManifoldEdgeCount = (Int32)s.nonManifoldEdgeCount;
		return ss;
	}

	internal static GetTessellationParametersReturn ConvertValue(ref GetTessellationParametersReturn_c s) {
		GetTessellationParametersReturn ss = new GetTessellationParametersReturn();
		ss.maxSag = (System.Double)s.maxSag;
		ss.maxLength = (System.Double)s.maxLength;
		ss.maxAngle = (System.Double)s.maxAngle;
		ss.createNormals = ConvertValue(s.createNormals);
		ss.uvGenerationMode = (UVGenerationMode)s.uvGenerationMode;
		ss.uvChannel = (System.Int32)s.uvChannel;
		ss.uvPadding = (System.Double)s.uvPadding;
		ss.createTangents = ConvertValue(s.createTangents);
		ss.createFreeEdges = ConvertValue(s.createFreeEdges);
		return ss;
	}

	internal static GetTessellationParametersReturn_c ConvertValue(GetTessellationParametersReturn s, ref GetTessellationParametersReturn_c ss) {
		ss.maxSag = (System.Double)s.maxSag;
		ss.maxLength = (System.Double)s.maxLength;
		ss.maxAngle = (System.Double)s.maxAngle;
		ss.createNormals = ConvertValue(s.createNormals);
		ss.uvGenerationMode = (Int32)s.uvGenerationMode;
		ss.uvChannel = (Int32)s.uvChannel;
		ss.uvPadding = (System.Double)s.uvPadding;
		ss.createTangents = ConvertValue(s.createTangents);
		ss.createFreeEdges = ConvertValue(s.createFreeEdges);
		return ss;
	}

	internal static EvaluateExpressionOnSubTreeReturn ConvertValue(ref EvaluateExpressionOnSubTreeReturn_c s) {
		EvaluateExpressionOnSubTreeReturn ss = new EvaluateExpressionOnSubTreeReturn();
		ss.occurrences = ConvertValue(ref s.occurrences);
		ss.evaluations = Core.CoreInterface.ConvertValue(ref s.evaluations);
		return ss;
	}

	internal static EvaluateExpressionOnSubTreeReturn_c ConvertValue(EvaluateExpressionOnSubTreeReturn s, ref EvaluateExpressionOnSubTreeReturn_c ss) {
		ConvertValue(s.occurrences, ref ss.occurrences);
		Core.CoreInterface.ConvertValue(s.evaluations, ref ss.evaluations);
		return ss;
	}

	internal static GetPartsTransformsIndexedReturn ConvertValue(ref GetPartsTransformsIndexedReturn_c s) {
		GetPartsTransformsIndexedReturn ss = new GetPartsTransformsIndexedReturn();
		ss.indices = Core.CoreInterface.ConvertValue(ref s.indices);
		ss.transforms = Geom.GeomInterface.ConvertValue(ref s.transforms);
		return ss;
	}

	internal static GetPartsTransformsIndexedReturn_c ConvertValue(GetPartsTransformsIndexedReturn s, ref GetPartsTransformsIndexedReturn_c ss) {
		Core.CoreInterface.ConvertValue(s.indices, ref ss.indices);
		Geom.GeomInterface.ConvertValue(s.transforms, ref ss.transforms);
		return ss;
	}

		#endregion

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Scene_getLastError();

		public static string GetLastError()
		{
			return ConvertValue(Scene_getLastError());
		}

		#region 

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_addComponent(IntPtr _pxz_session_, System.UInt32 occurrence, Int32 componentType);

		/// <summary>
		/// Add a component to an occurrence
		/// </summary>
		/// <param name="occurrence">The occurrence to add the new component</param>
		/// <param name="componentType">Type of the component</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 AddComponent(System.UInt32 occurrence, ComponentType componentType) {
			try {
				var ret = Scene_addComponent(api.Session, occurrence, (int)componentType);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern ComponentList_c Scene_addComponents(IntPtr _pxz_session_, OccurrenceList_c occurrences, Int32 componentType);

		/// <summary>
		/// Add a components to each occurrence in the array
		/// </summary>
		/// <param name="occurrences">Occurrences that need the component to be added</param>
		/// <param name="componentType">Type of the component</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public ComponentList AddComponents(OccurrenceList occurrences, ComponentType componentType) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var ret = Scene_addComponents(api.Session, occurrences_c, (int)componentType);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_ComponentList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_addInParentInstances(IntPtr _pxz_session_, System.UInt32 root);

		/// <summary>
		/// Add an instance of prototype's child as child in current occurrence recursively
		/// </summary>
		/// <param name="root">The occurrence to test.</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AddInParentInstances(System.UInt32 root) {
			try {
				Scene_addInParentInstances(api.Session, root);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Int32 Scene_cleanUnusedImages(IntPtr _pxz_session_);

		/// <summary>
		/// Remove unused images from texture library
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Int32 CleanUnusedImages() {
			try {
				var ret = Scene_cleanUnusedImages(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.Int32)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Int32 Scene_cleanUnusedMaterials(IntPtr _pxz_session_, System.Byte cleanImages);

		/// <summary>
		/// Remove unused materials from material library
		/// </summary>
		/// <param name="cleanImages">Call cleanUnusedImages if true</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Int32 CleanUnusedMaterials(System.Boolean cleanImages = false) {
			try {
				var ret = Scene_cleanUnusedMaterials(api.Session, Convert.ToByte(cleanImages));
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.Int32)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Scene_computeSubTreeChecksum(IntPtr _pxz_session_, System.UInt32 root);

		/// <summary>
		/// Compute the checksum of a sub-tree
		/// </summary>
		/// <param name="root">Occurrence to compute</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String ComputeSubTreeChecksum(System.UInt32 root = 0) {
			try {
				var ret = Scene_computeSubTreeChecksum(api.Session, root);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern void Scene_configureFunctionLogger(IntPtr _pxz_session_, string functionName, System.Byte enableFunction, System.Byte enableParameters, System.Byte enableExecutionTime);

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
				Scene_configureFunctionLogger(api.Session, functionName, Convert.ToByte(enableFunction), Convert.ToByte(enableParameters), Convert.ToByte(enableExecutionTime));
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_convertMaterialsToColor(IntPtr _pxz_session_, Material.MaterialList_c materials);

		/// <summary>
		/// Convert all materials to materials with a color pattern, trying to keep the visual aspect as similar as possible
		/// </summary>
		/// <param name="materials">Materials to merge (merge all materials if empty)</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ConvertMaterialsToColor(Material.MaterialList materials = null) {
			materials = materials ?? new Material.MaterialList(new System.UInt32[] {});
			try {
				var materials_c = new Material.MaterialList_c();
				Material.MaterialInterface.ConvertValue((Material.MaterialList)materials, ref materials_c);
				Scene_convertMaterialsToColor(api.Session, materials_c);
				Material.MaterialInterface.Material_MaterialList_free(ref materials_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_convertMaterialsToPBR(IntPtr _pxz_session_, Material.MaterialList_c materials);

		/// <summary>
		/// Convert all materials to materials with a PBR pattern, trying to keep the visual aspect as similar as possible
		/// </summary>
		/// <param name="materials">Materials to merge (merge all materials if empty)</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ConvertMaterialsToPBR(Material.MaterialList materials = null) {
			materials = materials ?? new Material.MaterialList(new System.UInt32[] {});
			try {
				var materials_c = new Material.MaterialList_c();
				Material.MaterialInterface.ConvertValue((Material.MaterialList)materials, ref materials_c);
				Scene_convertMaterialsToPBR(api.Session, materials_c);
				Material.MaterialInterface.Material_MaterialList_free(ref materials_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_createHierarchicalClusters(IntPtr _pxz_session_, System.UInt32 root, Int32 childrenCountByNode, System.Double minFitting);

		/// <summary>
		/// Reorganize a sub tree with hierarchical clustering
		/// </summary>
		/// <param name="root">Root of the sub-tree to reorganize</param>
		/// <param name="childrenCountByNode">Order of the hierarchical tree</param>
		/// <param name="minFitting">Minimal fitting coefficient to allow 2 nodes to be merged/clustered</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateHierarchicalClusters(System.UInt32 root, System.Int32 childrenCountByNode = 2, System.Double minFitting = -1) {
			try {
				var ret = Scene_createHierarchicalClusters(api.Session, root, childrenCountByNode, minFitting);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_createOBBMesh(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="occurrence"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateOBBMesh(System.UInt32 occurrence) {
			try {
				var ret = Scene_createOBBMesh(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_createOccurrence(IntPtr _pxz_session_, string name, System.UInt32 parent);

		/// <summary>
		/// Create a new occurrence
		/// </summary>
		/// <param name="name">Name of the new occurrence</param>
		/// <param name="parent">Create the occurrence as a child of parent, if not set the parent will be root</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateOccurrence(System.String name, System.UInt32 parent = 0) {
			try {
				var ret = Scene_createOccurrence(api.Session, name, parent);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_createOccurrenceFromSelection(IntPtr _pxz_session_, string name, OccurrenceList_c children, System.UInt32 parent, System.Byte keepMaterialAssignment);

		/// <summary>
		/// Create a new occurrence and add the given occurrences as children
		/// </summary>
		/// <param name="name">Name of the new occurrence</param>
		/// <param name="children">Add given occurrence as children (if any)</param>
		/// <param name="parent">If defined, the new occurrence will be created as a child of this parent. Else if children are defined, the first common parent of children will be used as a parent for this new occurrence. Last resort will be to use the root as parent</param>
		/// <param name="keepMaterialAssignment">If defined, material assignation will be updated to keep the visual same aspect</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateOccurrenceFromSelection(System.String name, OccurrenceList children, System.UInt32 parent, System.Boolean keepMaterialAssignment = true) {
			try {
				var children_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)children, ref children_c);
				var ret = Scene_createOccurrenceFromSelection(api.Session, name, children_c, parent, Convert.ToByte(keepMaterialAssignment));
				Scene.SceneInterface.Scene_OccurrenceList_free(ref children_c);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_createOccurrenceFromText(IntPtr _pxz_session_, string text, string font, Int32 fontSize, Core.ColorAlpha_c color, System.Double heigth3D);

		/// <summary>
		/// Creates an occurrence from string
		/// </summary>
		/// <param name="text">The occurrence's name</param>
		/// <param name="font">The font to use</param>
		/// <param name="fontSize">The font size</param>
		/// <param name="color">The occurrence color</param>
		/// <param name="heigth3D">3D height of text</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateOccurrenceFromText(System.String text, System.String font = "ChicFont", System.Int32 fontSize = 64, Core.ColorAlpha? color = null, System.Double heigth3D = 40) {
			color = color ?? new Core.ColorAlpha() {};
			try {
				var color_c = new Core.ColorAlpha_c();
				Core.CoreInterface.ConvertValue((Core.ColorAlpha)color, ref color_c);
				var ret = Scene_createOccurrenceFromText(api.Session, text, font, fontSize, color_c, heigth3D);
				Core.CoreInterface.Core_ColorAlpha_free(ref color_c);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern OccurrenceList_c Scene_createOccurrences(IntPtr _pxz_session_, string name, OccurrenceList_c parents);

		/// <summary>
		/// Create one new occurrence under each given parent
		/// </summary>
		/// <param name="name">Name of the new occurrence</param>
		/// <param name="parents">Create the occurrences as a child of each parent. If empty, one occurrence will be created with root as parent</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList CreateOccurrences(System.String name, OccurrenceList parents = null) {
			parents = parents ?? new Scene.OccurrenceList(new System.UInt32[] {});
			try {
				var parents_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)parents, ref parents_c);
				var ret = Scene_createOccurrences(api.Session, name, parents_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref parents_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern PartList_c Scene_createPartsFromMeshes(IntPtr _pxz_session_, OccurrenceList_c occurrences, Polygonal.MeshList_c meshes);

		/// <summary>
		/// Create a set of Parts given meshes and occurrences
		/// </summary>
		/// <param name="occurrences">The occurrence which will contains the part component of the mesh at the same index</param>
		/// <param name="meshes">List of mesh to create part, if the mesh is invalid (e.g 0) no part will be created and 0 will be returned in the parts list at this index</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public PartList CreatePartsFromMeshes(OccurrenceList occurrences, Polygonal.MeshList meshes) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var meshes_c = new Polygonal.MeshList_c();
				Polygonal.PolygonalInterface.ConvertValue((Polygonal.MeshList)meshes, ref meshes_c);
				var ret = Scene_createPartsFromMeshes(api.Session, occurrences_c, meshes_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				Polygonal.PolygonalInterface.Polygonal_MeshList_free(ref meshes_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_PartList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_createSceneFromMeshes(IntPtr _pxz_session_, Polygonal.MeshList_c meshes, Geom.Matrix4List_c matrices, System.Byte centerPartPivots);

		/// <summary>
		/// Create a scene tree with a list of meshes, all meshes becomes part occurrences with the same root. The same mesh Id can be used several times to handle create instances (prototypes)
		/// </summary>
		/// <param name="meshes">List of input meshes</param>
		/// <param name="matrices">List of matrices of input meshes (if empty Identity will be used)</param>
		/// <param name="centerPartPivots">If True, the input meshes will be centered in their local coordinate system and the translation will be set as part matrix. If you want to rollback the meshes to their initial pivots use 'resetPartTransform' function</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateSceneFromMeshes(Polygonal.MeshList meshes, Geom.Matrix4List matrices, System.Boolean centerPartPivots = true) {
			try {
				var meshes_c = new Polygonal.MeshList_c();
				Polygonal.PolygonalInterface.ConvertValue((Polygonal.MeshList)meshes, ref meshes_c);
				var matrices_c = new Geom.Matrix4List_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4List)matrices, ref matrices_c);
				var ret = Scene_createSceneFromMeshes(api.Session, meshes_c, matrices_c, Convert.ToByte(centerPartPivots));
				Polygonal.PolygonalInterface.Polygonal_MeshList_free(ref meshes_c);
				Geom.GeomInterface.Geom_Matrix4List_free(ref matrices_c);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern void Scene_deleteComponentByType(IntPtr _pxz_session_, Int32 componentType, System.UInt32 occurrence, System.Byte followPrototypes);

		/// <summary>
		/// Delete component from type
		/// </summary>
		/// <param name="componentType">Type of the component</param>
		/// <param name="occurrence">The occurrence to remove components from</param>
		/// <param name="followPrototypes">If true and if the component is not set on the occurrence, try to find it on its prototyping chain</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void DeleteComponentByType(ComponentType componentType, System.UInt32 occurrence, System.Boolean followPrototypes = true) {
			try {
				Scene_deleteComponentByType(api.Session, (int)componentType, occurrence, Convert.ToByte(followPrototypes));
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_deleteComponentsByType(IntPtr _pxz_session_, Int32 componentType, System.UInt32 rootOccurrence);

		/// <summary>
		/// Delete all components on subtree from type
		/// </summary>
		/// <param name="componentType">Type of the component</param>
		/// <param name="rootOccurrence">The root occurrence to remove components from</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void DeleteComponentsByType(ComponentType componentType, System.UInt32 rootOccurrence = 0) {
			try {
				Scene_deleteComponentsByType(api.Session, (int)componentType, rootOccurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_deleteEmptyOccurrences(IntPtr _pxz_session_, System.UInt32 root);

		/// <summary>
		/// Delete all empty assemblies
		/// </summary>
		/// <param name="root">Root occurrence for the process</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void DeleteEmptyOccurrences(System.UInt32 root = 0) {
			try {
				Scene_deleteEmptyOccurrences(api.Session, root);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_deleteOccurrences(IntPtr _pxz_session_, OccurrenceList_c occurrences);

		/// <summary>
		/// Delete a liste of occurrences
		/// </summary>
		/// <param name="occurrences">Occurrences to delete</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void DeleteOccurrences(OccurrenceList occurrences) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				Scene_deleteOccurrences(api.Session, occurrences_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_generateOctaViews(IntPtr _pxz_session_, System.Double radius, Int32 XFrames, Int32 YFrames, System.Byte hemi);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="radius"></param>
		/// <param name="XFrames"></param>
		/// <param name="YFrames"></param>
		/// <param name="hemi"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GenerateOctaViews(System.Double radius, System.Int32 XFrames, System.Int32 YFrames, System.Boolean hemi = false) {
			try {
				var ret = Scene_generateOctaViews(api.Session, radius, XFrames, YFrames, Convert.ToByte(hemi));
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_generateOctree(IntPtr _pxz_session_, System.UInt32 occurrence, Int32 maxDepth, System.Double looseFactor);

		/// <summary>
		/// Generate a loose octree from the given sub-tree
		/// </summary>
		/// <param name="occurrence">Root occurrence of the sub-tree</param>
		/// <param name="maxDepth">Defines the depth maximum of the octree</param>
		/// <param name="looseFactor">Defines the loose factor of the octree</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GenerateOctree(System.UInt32 occurrence, System.Int32 maxDepth = 5, System.Double looseFactor = 2) {
			try {
				var ret = Scene_generateOctree(api.Session, occurrence, maxDepth, looseFactor);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern Geom.AABB_c Scene_getAABB(IntPtr _pxz_session_, OccurrenceList_c occurrences, System.Byte precise);

		/// <summary>
		/// Returns the axis aligned bounding box of a list of occurrences
		/// </summary>
		/// <param name="occurrences">List of occurrences to retrieve the AABB</param>
		/// <param name="precise">If true, will take more time but returns a true AABB. If false, fast but the AABB is approximated and multiple rotation matrices in the tree structure may extend it a lot</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.AABB GetAABB(OccurrenceList occurrences, System.Boolean precise = false) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var ret = Scene_getAABB(api.Session, occurrences_c, Convert.ToByte(precise));
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Geom.GeomInterface.ConvertValue(ref ret);
				Geom.GeomInterface.Geom_AABB_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_getActiveMaterial(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Get the active material on occurrence
		/// </summary>
		/// <param name="occurrence">The occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetActiveMaterial(System.UInt32 occurrence) {
			try {
				var ret = Scene_getActiveMaterial(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern Material.MaterialList_c Scene_getActiveMaterials(IntPtr _pxz_session_, OccurrenceList_c occurrences);

		/// <summary>
		/// Get the active materials on multiple occurrences
		/// </summary>
		/// <param name="occurrences">The occurrences to retrieve active material on</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Material.MaterialList GetActiveMaterials(OccurrenceList occurrences) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var ret = Scene_getActiveMaterials(api.Session, occurrences_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Material.MaterialInterface.ConvertValue(ref ret);
				Material.MaterialInterface.Material_MaterialList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Scene_getActivePropertyValue(IntPtr _pxz_session_, System.UInt32 occurrence, string propertyName, System.Byte cacheProperty);

		/// <summary>
		/// Get the value of a property on the first parent that own it
		/// </summary>
		/// <param name="occurrence">An occurrence</param>
		/// <param name="propertyName">Property name</param>
		/// <param name="cacheProperty">If true, the property will be copied on all ancestor of occurrence below the property owner to speed up future calls</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String GetActivePropertyValue(System.UInt32 occurrence, System.String propertyName, System.Boolean cacheProperty = false) {
			try {
				var ret = Scene_getActivePropertyValue(api.Session, occurrence, propertyName, Convert.ToByte(cacheProperty));
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern Core.StringList_c Scene_getActivePropertyValues(IntPtr _pxz_session_, OccurrenceList_c occurrences, string propertyName, System.Byte cacheProperty);

		/// <summary>
		/// Get the value of a property on the first parent that own it for each given occurrence
		/// </summary>
		/// <param name="occurrences">List of occurrences</param>
		/// <param name="propertyName">Property name</param>
		/// <param name="cacheProperty">If true, the property will be copied on all ancestor of occurrence below the property owner to speed up future calls</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Core.StringList GetActivePropertyValues(OccurrenceList occurrences, System.String propertyName, System.Boolean cacheProperty = false) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var ret = Scene_getActivePropertyValues(api.Session, occurrences_c, propertyName, Convert.ToByte(cacheProperty));
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Core.CoreInterface.ConvertValue(ref ret);
				Core.CoreInterface.Core_StringList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_getAncestors(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Returns the list of ancestors for one occurrence
		/// </summary>
		/// <param name="occurrence">The occurrence to test.</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList GetAncestors(System.UInt32 occurrence) {
			try {
				var ret = Scene_getAncestors(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_getBrepShape(IntPtr _pxz_session_, System.UInt32 part);

		/// <summary>
		/// Returns the Brep shape of a part
		/// </summary>
		/// <param name="part">The Part</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetBrepShape(System.UInt32 part) {
			try {
				var ret = Scene_getBrepShape(api.Session, part);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_getComponent(IntPtr _pxz_session_, System.UInt32 occurrence, Int32 componentType, System.Byte followPrototypes);

		/// <summary>
		/// Returns a component on an occurrence
		/// </summary>
		/// <param name="occurrence">The occurrence</param>
		/// <param name="componentType">Type of the component</param>
		/// <param name="followPrototypes">If true and if the component is not set on the occurrence, try to find it on its prototyping chain</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetComponent(System.UInt32 occurrence, ComponentType componentType, System.Boolean followPrototypes = true) {
			try {
				var ret = Scene_getComponent(api.Session, occurrence, (int)componentType, Convert.ToByte(followPrototypes));
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern ComponentList_c Scene_getComponentByOccurrence(IntPtr _pxz_session_, OccurrenceList_c occurrences, Int32 componentType, System.Byte followPrototypes);

		/// <summary>
		/// Returns one component of the specified type by occurrence if it exists
		/// </summary>
		/// <param name="occurrences">The occurrences list</param>
		/// <param name="componentType">Type of the component</param>
		/// <param name="followPrototypes">If true and if the component is not set on the occurrence, try to find it on its prototyping chain</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public ComponentList GetComponentByOccurrence(OccurrenceList occurrences, ComponentType componentType, System.Boolean followPrototypes = true) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var ret = Scene_getComponentByOccurrence(api.Session, occurrences_c, (int)componentType, Convert.ToByte(followPrototypes));
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_ComponentList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_getComponentOccurrence(IntPtr _pxz_session_, System.UInt32 component);

		/// <summary>
		/// Get the occurrence that own a component
		/// </summary>
		/// <param name="component">The component</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetComponentOccurrence(System.UInt32 component) {
			try {
				var ret = Scene_getComponentOccurrence(api.Session, component);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern Int32 Scene_getComponentType(IntPtr _pxz_session_, System.UInt32 component);

		/// <summary>
		/// Get the type of a component
		/// </summary>
		/// <param name="component">The component</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public ComponentType GetComponentType(System.UInt32 component) {
			try {
				var ret = Scene_getComponentType(api.Session, component);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (ComponentType)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Geom.Matrix4List_c Scene_getGlobalMatrices(IntPtr _pxz_session_, OccurrenceList_c occurrences);

		/// <summary>
		/// Returns the global matrix for each given occurrence
		/// </summary>
		/// <param name="occurrences">Nodes to get the local matrix</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.Matrix4List GetGlobalMatrices(OccurrenceList occurrences) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var ret = Scene_getGlobalMatrices(api.Session, occurrences_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Geom.GeomInterface.ConvertValue(ref ret);
				Geom.GeomInterface.Geom_Matrix4List_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Geom.Matrix4_c Scene_getGlobalMatrix(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Returns the global matrix on an occurrence
		/// </summary>
		/// <param name="occurrence">Occurrence to get the global matrix</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.Matrix4 GetGlobalMatrix(System.UInt32 occurrence) {
			try {
				var ret = Scene_getGlobalMatrix(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Geom.GeomInterface.ConvertValue(ref ret);
				Geom.GeomInterface.Geom_Matrix4_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Scene_getGlobalVisibility(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Returns the global visibility of a given occurrence
		/// </summary>
		/// <param name="occurrence">Occurrence to get the global visibility</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean GetGlobalVisibility(System.UInt32 occurrence) {
			try {
				var ret = Scene_getGlobalVisibility(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern Geom.Matrix4List_c Scene_getLocalMatrices(IntPtr _pxz_session_, OccurrenceList_c occurrences);

		/// <summary>
		/// Returns the local matrix for each given occurrence
		/// </summary>
		/// <param name="occurrences">Nodes to get the local matrix</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.Matrix4List GetLocalMatrices(OccurrenceList occurrences) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var ret = Scene_getLocalMatrices(api.Session, occurrences_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Geom.GeomInterface.ConvertValue(ref ret);
				Geom.GeomInterface.Geom_Matrix4List_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Geom.Matrix4_c Scene_getLocalMatrix(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Returns the local matrix on an occurrence
		/// </summary>
		/// <param name="occurrence">Node to get the local matrix</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.Matrix4 GetLocalMatrix(System.UInt32 occurrence) {
			try {
				var ret = Scene_getLocalMatrix(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Geom.GeomInterface.ConvertValue(ref ret);
				Geom.GeomInterface.Geom_Matrix4_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Geom.OBB_c Scene_getMBB(IntPtr _pxz_session_, OccurrenceList_c occurrences, Geom.Point3_c forcedAxis);

		/// <summary>
		/// Returns the Minimum Bounding Box of a list of occurrences
		/// </summary>
		/// <param name="occurrences">List of occurrences to retrieve the MBB</param>
		/// <param name="forcedAxis">Forced axis of the mbb</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.OBB GetMBB(OccurrenceList occurrences, Geom.Point3? forcedAxis = null) {
			forcedAxis = forcedAxis ?? new Geom.Point3() {x = 0, y = 0, z = 0};
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var forcedAxis_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)forcedAxis, ref forcedAxis_c);
				var ret = Scene_getMBB(api.Session, occurrences_c, forcedAxis_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				Geom.GeomInterface.Geom_Point3_free(ref forcedAxis_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Geom.GeomInterface.ConvertValue(ref ret);
				Geom.GeomInterface.Geom_OBB_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Material.MaterialList_c Scene_getMaterialsFromSubtree(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="occurrence">Root occurrence of the subtree on which to get the materials and images</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Material.MaterialList GetMaterialsFromSubtree(System.UInt32 occurrence) {
			try {
				var ret = Scene_getMaterialsFromSubtree(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Material.MaterialInterface.ConvertValue(ref ret);
				Material.MaterialInterface.Material_MaterialList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Geom.OBB_c Scene_getOBB(IntPtr _pxz_session_, OccurrenceList_c occurrences);

		/// <summary>
		/// Returns the Oriented Bounding Box of a list of occurrences (works only on meshes, fast method, not the Minimum Volume Box)
		/// </summary>
		/// <param name="occurrences">List of occurrences to retrieve the OBB</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.OBB GetOBB(OccurrenceList occurrences) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var ret = Scene_getOBB(api.Session, occurrences_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Geom.GeomInterface.ConvertValue(ref ret);
				Geom.GeomInterface.Geom_OBB_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_getOccurrenceActiveMaterial(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Returns the active material on a given occurrence
		/// </summary>
		/// <param name="occurrence">Occurrence to get the active material</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetOccurrenceActiveMaterial(System.UInt32 occurrence) {
			try {
				var ret = Scene_getOccurrenceActiveMaterial(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern IntPtr Scene_getOccurrenceName(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Returns the name of an occurrence
		/// </summary>
		/// <param name="occurrence">The occurrence to get the name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String GetOccurrenceName(System.UInt32 occurrence) {
			try {
				var ret = Scene_getOccurrenceName(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern OccurrenceList_c Scene_getOccurrencesWithComponent(IntPtr _pxz_session_, Int32 componentType, System.UInt32 fromOcc);

		/// <summary>
		/// Recursively get all the occurrences containing a component of the specified type
		/// </summary>
		/// <param name="componentType">The component type</param>
		/// <param name="fromOcc">Source occurrence of the recursion</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList GetOccurrencesWithComponent(ComponentType componentType, System.UInt32 fromOcc = 0) {
			try {
				var ret = Scene_getOccurrencesWithComponent(api.Session, (int)componentType, fromOcc);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_getPartActiveShape(IntPtr _pxz_session_, System.UInt32 part);

		/// <summary>
		/// Returns the active shape of a part
		/// </summary>
		/// <param name="part">The part</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetPartActiveShape(System.UInt32 part) {
			try {
				var ret = Scene_getPartActiveShape(api.Session, part);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern OccurrenceList_c Scene_getPartOccurrences(IntPtr _pxz_session_, System.UInt32 fromOcc);

		/// <summary>
		/// Recursively get all the occurrences containing a part component
		/// </summary>
		/// <param name="fromOcc">Source occurrence of the recursion</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList GetPartOccurrences(System.UInt32 fromOcc = 0) {
			try {
				var ret = Scene_getPartOccurrences(api.Session, fromOcc);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Int32 Scene_getPartShapeType(IntPtr _pxz_session_, System.UInt32 part);

		/// <summary>
		/// Get the part's shape type
		/// </summary>
		/// <param name="part">The part to test</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public ShapeType GetPartShapeType(System.UInt32 part) {
			try {
				var ret = Scene_getPartShapeType(api.Session, part);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (ShapeType)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt64 Scene_getPolygonCount(IntPtr _pxz_session_, OccurrenceList_c occurrences, System.Byte asTriangleCount, System.Byte countOnceEachInstance, System.Byte countHidden);

		/// <summary>
		/// Returns the number of polygon in the parts meshes
		/// </summary>
		/// <param name="occurrences">The part occurrences</param>
		/// <param name="asTriangleCount">If true count the equivalent of triangles for each polygon</param>
		/// <param name="countOnceEachInstance">If true ignore multiple instance of each tessellation</param>
		/// <param name="countHidden">If true, also count hidden components</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt64 GetPolygonCount(OccurrenceList occurrences, System.Boolean asTriangleCount = false, System.Boolean countOnceEachInstance = false, System.Boolean countHidden = false) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var ret = Scene_getPolygonCount(api.Session, occurrences_c, Convert.ToByte(asTriangleCount), Convert.ToByte(countOnceEachInstance), Convert.ToByte(countHidden));
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.UInt64)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetSubTreeStatsReturn_c Scene_getSubTreeStats(IntPtr _pxz_session_, OccurrenceList_c roots);

		/// <summary>
		/// Returns some stats of a sub tree
		/// </summary>
		/// <param name="roots">The root occurrences to get stats on.</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Scene.GetSubTreeStatsReturn GetSubTreeStats(OccurrenceList roots) {
			try {
				var roots_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)roots, ref roots_c);
				var ret = Scene_getSubTreeStats(api.Session, roots_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref roots_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				Scene.GetSubTreeStatsReturn retStruct = new Scene.GetSubTreeStatsReturn();
				retStruct.partCount = (System.UInt64)ret.partCount;
				retStruct.partOccurrenceCount = (System.UInt64)ret.partOccurrenceCount;
				retStruct.triangleCount = (System.UInt64)ret.triangleCount;
				retStruct.triangleOccurrenceCount = (System.UInt64)ret.triangleOccurrenceCount;
				retStruct.vertexCount = (System.UInt64)ret.vertexCount;
				retStruct.vertexOccurrenceCount = (System.UInt64)ret.vertexOccurrenceCount;
				retStruct.pointCount = (System.UInt64)ret.pointCount;
				retStruct.pointOccurrenceCount = (System.UInt64)ret.pointOccurrenceCount;
				retStruct.lineCount = (System.UInt64)ret.lineCount;
				retStruct.lineOccurrenceCount = (System.UInt64)ret.lineOccurrenceCount;
				retStruct.patchesCount = (System.UInt64)ret.patchesCount;
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt64 Scene_getVertexCount(IntPtr _pxz_session_, OccurrenceList_c occurrences, System.Byte countOnceEachInstance, System.Byte countHidden, System.Byte countPoints, System.Byte countMergedVertices);

		/// <summary>
		/// Returns the number of vertices in the parts meshes
		/// </summary>
		/// <param name="occurrences">The part occurrences</param>
		/// <param name="countOnceEachInstance">If true ignore multiple instance of each tessellation</param>
		/// <param name="countHidden">If true, also count hidden components</param>
		/// <param name="countPoints">If true, also count points (for points cloud)</param>
		/// <param name="countMergedVertices">If true count all merged vertices in each tessellation</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt64 GetVertexCount(OccurrenceList occurrences, System.Boolean countOnceEachInstance = false, System.Boolean countHidden = false, System.Boolean countPoints = false, System.Boolean countMergedVertices = false) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var ret = Scene_getVertexCount(api.Session, occurrences_c, Convert.ToByte(countOnceEachInstance), Convert.ToByte(countHidden), Convert.ToByte(countPoints), Convert.ToByte(countMergedVertices));
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.UInt64)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetViewpointsFromCavitiesReturn_c Scene_getViewpointsFromCavities(IntPtr _pxz_session_, System.Double voxelSize, System.Double minCavityVolume);

		/// <summary>
		/// Returns viewpoints from model cavities
		/// </summary>
		/// <param name="voxelSize">Precision for cavities detection</param>
		/// <param name="minCavityVolume">Minimum volume for a cavity to be returned</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Scene.GetViewpointsFromCavitiesReturn GetViewpointsFromCavities(System.Double voxelSize, System.Double minCavityVolume) {
			try {
				var ret = Scene_getViewpointsFromCavities(api.Session, voxelSize, minCavityVolume);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				Scene.GetViewpointsFromCavitiesReturn retStruct = new Scene.GetViewpointsFromCavitiesReturn();
				retStruct.positions = ConvertValue(ref ret.positions);
				Geom.GeomInterface.Geom_Point3List_free(ref ret.positions);
				retStruct.directions = ConvertValue(ref ret.directions);
				Geom.GeomInterface.Geom_Point3List_free(ref ret.directions);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Double Scene_getVolume(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Return the volume of the occurrence
		/// </summary>
		/// <param name="occurrence">Entry occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Double GetVolume(System.UInt32 occurrence) {
			try {
				var ret = Scene_getVolume(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.Double)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.DoubleList_c Scene_getVolumes(IntPtr _pxz_session_, OccurrenceList_c iRoots);

		/// <summary>
		/// Return the volume of a set of root occurrences
		/// </summary>
		/// <param name="iRoots">List of roots</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Core.DoubleList GetVolumes(OccurrenceList iRoots) {
			try {
				var iRoots_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)iRoots, ref iRoots_c);
				var ret = Scene_getVolumes(api.Session, iRoots_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref iRoots_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Core.CoreInterface.ConvertValue(ref ret);
				Core.CoreInterface.Core_DoubleList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Scene_hasComponent(IntPtr _pxz_session_, System.UInt32 occurrence, Int32 componentType, System.Byte followPrototypes);

		/// <summary>
		/// Returns True if the given occurrence has the given component type
		/// </summary>
		/// <param name="occurrence">The occurrence</param>
		/// <param name="componentType">Type of the component</param>
		/// <param name="followPrototypes">If true and if the component is not set on the occurrence, try to find it on its prototyping chain</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean HasComponent(System.UInt32 occurrence, ComponentType componentType, System.Boolean followPrototypes = true) {
			try {
				var ret = Scene_hasComponent(api.Session, occurrence, (int)componentType, Convert.ToByte(followPrototypes));
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern void Scene_hide(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Hide the given occurrence
		/// </summary>
		/// <param name="occurrence">The occurrence to hide</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void Hide(System.UInt32 occurrence) {
			try {
				Scene_hide(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_inverseVisibility(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Inverse the visibility of the given occurrence
		/// </summary>
		/// <param name="occurrence">The occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void InverseVisibility(System.UInt32 occurrence) {
			try {
				Scene_inverseVisibility(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Scene_isAncestorOf(IntPtr _pxz_session_, System.UInt32 maybeAncestor, System.UInt32 occurrence);

		/// <summary>
		/// Test if an occurrence is an ancestor of another one.
		/// </summary>
		/// <param name="maybeAncestor">The potential ancestor of the occurrence</param>
		/// <param name="occurrence">The occurrence to test</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean IsAncestorOf(System.UInt32 maybeAncestor, System.UInt32 occurrence) {
			try {
				var ret = Scene_isAncestorOf(api.Session, maybeAncestor, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern OccurrenceList_c Scene_keepAncestors(IntPtr _pxz_session_, OccurrenceList_c occurrences);

		/// <summary>
		/// Filter a list of occurrences by removing all occurrences which have an ancestor inside the list.
		/// </summary>
		/// <param name="occurrences">The list that shall be filtered.</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList KeepAncestors(OccurrenceList occurrences) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var ret = Scene_keepAncestors(api.Session, occurrences_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern ComponentList_c Scene_listComponent(IntPtr _pxz_session_, Int32 componentType);

		/// <summary>
		/// List all components on a type on the whole tree
		/// </summary>
		/// <param name="componentType">The component type</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public ComponentList ListComponent(ComponentType componentType) {
			try {
				var ret = Scene_listComponent(api.Session, (int)componentType);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_ComponentList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern ComponentList_c Scene_listComponents(IntPtr _pxz_session_, System.UInt32 occurrence, System.Byte followPrototypes);

		/// <summary>
		/// List all components on an occurrence
		/// </summary>
		/// <param name="occurrence">The occurrence to list the components</param>
		/// <param name="followPrototypes">If true list also components owned by the prototype</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public ComponentList ListComponents(System.UInt32 occurrence, System.Boolean followPrototypes = true) {
			try {
				var ret = Scene_listComponents(api.Session, occurrence, Convert.ToByte(followPrototypes));
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_ComponentList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Int32 Scene_mergeImages(IntPtr _pxz_session_, Material.ImageList_c images);

		/// <summary>
		/// Merge all equivalent images (i.e. with same pixels)
		/// </summary>
		/// <param name="images">Images to merge (merge all images if empty)</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Int32 MergeImages(Material.ImageList images = null) {
			images = images ?? new Material.ImageList(new System.UInt32[] {});
			try {
				var images_c = new Material.ImageList_c();
				Material.MaterialInterface.ConvertValue((Material.ImageList)images, ref images_c);
				var ret = Scene_mergeImages(api.Session, images_c);
				Material.MaterialInterface.Material_ImageList_free(ref images_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.Int32)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Int32 Scene_mergeMaterials(IntPtr _pxz_session_, Material.MaterialList_c materials, System.Byte evaluateNames);

		/// <summary>
		/// Merge all equivalent materials (i.e. with same appearance)
		/// </summary>
		/// <param name="materials">Materials to merge (merge all materials if empty)</param>
		/// <param name="evaluateNames">If true, materials names will be taken into consideration (on top of other properties). It means that materials having same properties but different names won't be merged together.</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Int32 MergeMaterials(Material.MaterialList materials = null, System.Boolean evaluateNames = false) {
			materials = materials ?? new Material.MaterialList(new System.UInt32[] {});
			try {
				var materials_c = new Material.MaterialList_c();
				Material.MaterialInterface.ConvertValue((Material.MaterialList)materials, ref materials_c);
				var ret = Scene_mergeMaterials(api.Session, materials_c, Convert.ToByte(evaluateNames));
				Material.MaterialInterface.Material_MaterialList_free(ref materials_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.Int32)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_removeMaterials(IntPtr _pxz_session_, OccurrenceList_c roots);

		/// <summary>
		/// Recursively remove all materials
		/// </summary>
		/// <param name="roots">If specified, remove materials only from the given occurrences and their descendants</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void RemoveMaterials(OccurrenceList roots = null) {
			roots = roots ?? new Scene.OccurrenceList(new System.UInt32[] {});
			try {
				var roots_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)roots, ref roots_c);
				Scene_removeMaterials(api.Session, roots_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref roots_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_renameLongOccurrenceName(IntPtr _pxz_session_, Int32 maxLength);

		/// <summary>
		/// truncate names of occurrence with too long names
		/// </summary>
		/// <param name="maxLength">Maximum name length</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void RenameLongOccurrenceName(System.Int32 maxLength) {
			try {
				Scene_renameLongOccurrenceName(api.Session, maxLength);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_replaceMaterial(IntPtr _pxz_session_, System.UInt32 originalMaterial, System.UInt32 newMaterial, OccurrenceList_c occurrences);

		/// <summary>
		/// Replace a material by another everywhere it is used
		/// </summary>
		/// <param name="originalMaterial">The material to replace everywhere</param>
		/// <param name="newMaterial">The new material to set in place of originalMaterial</param>
		/// <param name="occurrences">The occurrences on which replacing the materials</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ReplaceMaterial(System.UInt32 originalMaterial, System.UInt32 newMaterial, OccurrenceList occurrences = null) {
			occurrences = occurrences ?? new Scene.OccurrenceList(new System.UInt32[] {});
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				Scene_replaceMaterial(api.Session, originalMaterial, newMaterial, occurrences_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_resizeTextures(IntPtr _pxz_session_, ResizeTexturesInputMode_c inputMode, ResizeTexturesResizeMode_c resizeMode, System.Byte replaceTextures);

		/// <summary>
		/// Resizes the textures from a selection of occurrences (resizes all textures used by these occurrences), or from a selection of textures
		/// </summary>
		/// <param name="inputMode">Defines if the textures to resize are textures used by a selection of Occurrences, or a selection among the textures available in the scene</param>
		/// <param name="resizeMode">Defines if the textures are resized following a ratio or following a maximum size/resolution (only textures above the defined maximum are downsized)</param>
		/// <param name="replaceTextures">If True, overwrites textures from the selection</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ResizeTextures(ResizeTexturesInputMode inputMode, ResizeTexturesResizeMode resizeMode, System.Boolean replaceTextures) {
			try {
				var inputMode_c = new Scene.ResizeTexturesInputMode_c();
				ConvertValue((Scene.ResizeTexturesInputMode)inputMode, ref inputMode_c);
				var resizeMode_c = new Scene.ResizeTexturesResizeMode_c();
				ConvertValue((Scene.ResizeTexturesResizeMode)resizeMode, ref resizeMode_c);
				Scene_resizeTextures(api.Session, inputMode_c, resizeMode_c, Convert.ToByte(replaceTextures));
				Scene.SceneInterface.Scene_ResizeTexturesInputMode_free(ref inputMode_c);
				Scene.SceneInterface.Scene_ResizeTexturesResizeMode_free(ref resizeMode_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setComponentOccurrence(IntPtr _pxz_session_, System.UInt32 component, System.UInt32 occurrence);

		/// <summary>
		/// Move a component to an occurrence
		/// </summary>
		/// <param name="component">The component</param>
		/// <param name="occurrence">The occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetComponentOccurrence(System.UInt32 component, System.UInt32 occurrence) {
			try {
				Scene_setComponentOccurrence(api.Session, component, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setDefaultVariant(IntPtr _pxz_session_);

		/// <summary>
		/// Set the default variant
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetDefaultVariant() {
			try {
				Scene_setDefaultVariant(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setOccurrenceMaterial(IntPtr _pxz_session_, System.UInt32 occurrence, System.UInt32 material);

		/// <summary>
		/// Set the material on a occurrence
		/// </summary>
		/// <param name="occurrence">Occurrence to set the material</param>
		/// <param name="material">The new occurrence material</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetOccurrenceMaterial(System.UInt32 occurrence, System.UInt32 material) {
			try {
				Scene_setOccurrenceMaterial(api.Session, occurrence, material);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setOccurrenceName(IntPtr _pxz_session_, System.UInt32 occurrence, string name);

		/// <summary>
		/// Returns the name of an occurrence
		/// </summary>
		/// <param name="occurrence">The occurrence to get the name</param>
		/// <param name="name">The occurrence name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetOccurrenceName(System.UInt32 occurrence, System.String name) {
			try {
				Scene_setOccurrenceName(api.Session, occurrence, name);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_show(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Show the given occurrence
		/// </summary>
		/// <param name="occurrence">The occurrence to show</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void Show(System.UInt32 occurrence) {
			try {
				Scene_show(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_showOnly(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Show only the given occurrence
		/// </summary>
		/// <param name="occurrence">The occurrence to show</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ShowOnly(System.UInt32 occurrence) {
			try {
				Scene_showOnly(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_transferCADMaterialsOnPartOccurrences(IntPtr _pxz_session_, System.UInt32 rootOccurrence);

		/// <summary>
		/// Set all materials on part occurrences
		/// </summary>
		/// <param name="rootOccurrence">Root occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void TransferCADMaterialsOnPartOccurrences(System.UInt32 rootOccurrence = 0) {
			try {
				Scene_transferCADMaterialsOnPartOccurrences(api.Session, rootOccurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_transferMaterialsOnPatches(IntPtr _pxz_session_, System.UInt32 rootOccurrence);

		/// <summary>
		/// Take the first instance material and set it one the mesh patches
		/// </summary>
		/// <param name="rootOccurrence">Root occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void TransferMaterialsOnPatches(System.UInt32 rootOccurrence = 0) {
			try {
				Scene_transferMaterialsOnPatches(api.Session, rootOccurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		private delegate void ComponentChangedDelegate_c(IntPtr userData, ComponentChangeType eventType, System.UInt32 occurrence, System.UInt32 component);
		private static Dictionary<uint, ComponentChangedDelegate_c> m_ComponentChangedCallbacks = new Dictionary<uint, ComponentChangedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_addComponentChangedCallback(IntPtr _pxz_session_, ComponentChangedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_removeComponentChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void ComponentChangedDelegate(IntPtr userData, ComponentChangeType eventType, System.UInt32 occurrence, System.UInt32 component);

		public System.UInt32 AddComponentChangedCallback(ComponentChangedDelegate callback, IntPtr userData) {
			ComponentChangedDelegate_c c = new ComponentChangedDelegate_c((System.IntPtr _pxz_session_, ComponentChangeType eventType, System.UInt32 occurrence, System.UInt32 component) =>
			{
				var eventType_cs = (ComponentChangeType)eventType;
				var occurrence_cs = (System.UInt32)(occurrence);
				var component_cs = (System.UInt32)(component);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, eventType_cs, occurrence_cs, component_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Scene_addComponentChangedCallback(api.Session, c, userData);
			m_ComponentChangedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveComponentChangedCallback(System.UInt32 id) {
			Scene_removeComponentChangedCallback(api.Session, id);
			m_ComponentChangedCallbacks.Remove(id);
		}

		private delegate void SceneChangedDelegate_c(IntPtr userData, SceneChangeType eventType, System.UInt32 occurrence, System.UInt32 child);
		private static Dictionary<uint, SceneChangedDelegate_c> m_SceneChangedCallbacks = new Dictionary<uint, SceneChangedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_addSceneChangedCallback(IntPtr _pxz_session_, SceneChangedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_removeSceneChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void SceneChangedDelegate(IntPtr userData, SceneChangeType eventType, System.UInt32 occurrence, System.UInt32 child);

		public System.UInt32 AddSceneChangedCallback(SceneChangedDelegate callback, IntPtr userData) {
			SceneChangedDelegate_c c = new SceneChangedDelegate_c((System.IntPtr _pxz_session_, SceneChangeType eventType, System.UInt32 occurrence, System.UInt32 child) =>
			{
				var eventType_cs = (SceneChangeType)eventType;
				var occurrence_cs = (System.UInt32)(occurrence);
				var child_cs = (System.UInt32)(child);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, eventType_cs, occurrence_cs, child_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Scene_addSceneChangedCallback(api.Session, c, userData);
			m_SceneChangedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveSceneChangedCallback(System.UInt32 id) {
			Scene_removeSceneChangedCallback(api.Session, id);
			m_SceneChangedCallbacks.Remove(id);
		}

		#endregion

		#region Create primitives

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_createCapsule(IntPtr _pxz_session_, System.Double radius, System.Double height, Int32 subdivisionLatitude, Int32 subdivisionLongitude, System.Byte generateUV);

		/// <summary>
		/// Create a new capsule
		/// </summary>
		/// <param name="radius">Radius of the Capsule</param>
		/// <param name="height">Height of the Capsule (excluding the two size of half spheres)</param>
		/// <param name="subdivisionLatitude">Subdivision of the Capsule on the Latitude</param>
		/// <param name="subdivisionLongitude">Subdivision of the Capsule (two half spheres) on the Longitude</param>
		/// <param name="generateUV">Generation of the UV</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateCapsule(System.Double radius, System.Double height, System.Int32 subdivisionLatitude = 16, System.Int32 subdivisionLongitude = 16, System.Boolean generateUV = true) {
			try {
				var ret = Scene_createCapsule(api.Session, radius, height, subdivisionLatitude, subdivisionLongitude, Convert.ToByte(generateUV));
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_createCone(IntPtr _pxz_session_, System.Double bottomRadius, System.Double height, Int32 sides, System.Byte generateUV);

		/// <summary>
		/// Create a new cone
		/// </summary>
		/// <param name="bottomRadius">Radius of the bottom of the cone </param>
		/// <param name="height">Height of the cone</param>
		/// <param name="sides">Number of sides of the cone</param>
		/// <param name="generateUV">Generation of the UV</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateCone(System.Double bottomRadius, System.Double height, System.Int32 sides = 16, System.Boolean generateUV = true) {
			try {
				var ret = Scene_createCone(api.Session, bottomRadius, height, sides, Convert.ToByte(generateUV));
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_createCube(IntPtr _pxz_session_, System.Double sizeX, System.Double sizeY, System.Double sizeZ, Int32 subdivision, System.Byte generateUV);

		/// <summary>
		/// Create a new cube
		/// </summary>
		/// <param name="sizeX">Size of the Cube on the x axis</param>
		/// <param name="sizeY">Size of the Cube on the y axis</param>
		/// <param name="sizeZ">Size of the Cube on the z axis</param>
		/// <param name="subdivision">Subdivision of the Cube on all the axis</param>
		/// <param name="generateUV">Generation of the UV</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateCube(System.Double sizeX, System.Double sizeY, System.Double sizeZ, System.Int32 subdivision = 1, System.Boolean generateUV = true) {
			try {
				var ret = Scene_createCube(api.Session, sizeX, sizeY, sizeZ, subdivision, Convert.ToByte(generateUV));
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_createCylinder(IntPtr _pxz_session_, System.Double radius, System.Double height, Int32 sides, System.Byte generateUV);

		/// <summary>
		/// Create a new cylinder
		/// </summary>
		/// <param name="radius">Radius of the Cylinder</param>
		/// <param name="height">Height of the Cylinder</param>
		/// <param name="sides">Number of Sides of the Cylinder</param>
		/// <param name="generateUV">Generation of the UV</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateCylinder(System.Double radius, System.Double height, System.Int32 sides = 16, System.Boolean generateUV = true) {
			try {
				var ret = Scene_createCylinder(api.Session, radius, height, sides, Convert.ToByte(generateUV));
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_createImmersion(IntPtr _pxz_session_, System.Double radius, Int32 subdivisionX, Int32 subdivisionY);

		/// <summary>
		/// Create a new bagel klein
		/// </summary>
		/// <param name="radius">Radius of the Immersion</param>
		/// <param name="subdivisionX">Subdivision of the Immersion on the Latitude</param>
		/// <param name="subdivisionY">Subdivision of the Immersion on the Longitude</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateImmersion(System.Double radius, System.Int32 subdivisionX, System.Int32 subdivisionY) {
			try {
				var ret = Scene_createImmersion(api.Session, radius, subdivisionX, subdivisionY);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_createPlane(IntPtr _pxz_session_, System.Double sizeY, System.Double sizeX, Int32 subdivisionX, Int32 subdivisionY, System.Byte generateUV);

		/// <summary>
		/// Create a  new plane
		/// </summary>
		/// <param name="sizeY">Size of the Plane on the y axis</param>
		/// <param name="sizeX">Size of the Plane on the x axis</param>
		/// <param name="subdivisionX">Subdivision of the Plane on the x axis</param>
		/// <param name="subdivisionY">Subdivision of the Plane on the y axis</param>
		/// <param name="generateUV">Generation of the UV</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreatePlane(System.Double sizeY, System.Double sizeX, System.Int32 subdivisionX = 1, System.Int32 subdivisionY = 1, System.Boolean generateUV = true) {
			try {
				var ret = Scene_createPlane(api.Session, sizeY, sizeX, subdivisionX, subdivisionY, Convert.ToByte(generateUV));
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_createSphere(IntPtr _pxz_session_, System.Double radius, Int32 subdivisionLatitude, Int32 subdivisionLongitude, System.Byte generateUV);

		/// <summary>
		/// Create a new sphere
		/// </summary>
		/// <param name="radius">Radius of the Sphere</param>
		/// <param name="subdivisionLatitude">Subdivision of the Sphere on the Latitude</param>
		/// <param name="subdivisionLongitude">Subdivision of the Sphere on the Longitude</param>
		/// <param name="generateUV">Generation of the UV</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateSphere(System.Double radius, System.Int32 subdivisionLatitude = 16, System.Int32 subdivisionLongitude = 16, System.Boolean generateUV = true) {
			try {
				var ret = Scene_createSphere(api.Session, radius, subdivisionLatitude, subdivisionLongitude, Convert.ToByte(generateUV));
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_createTorus(IntPtr _pxz_session_, System.Double majorRadius, System.Double minorRadius, Int32 subdivisionLatitude, Int32 subdivisionLongitude, System.Byte generateUV);

		/// <summary>
		/// Create a new torus
		/// </summary>
		/// <param name="majorRadius">Major Radius</param>
		/// <param name="minorRadius">Minor Radius</param>
		/// <param name="subdivisionLatitude">Subdivision of the Torus on the Latitude</param>
		/// <param name="subdivisionLongitude">Subdivision of the Torus on the Longitude</param>
		/// <param name="generateUV">Generation of the UV</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateTorus(System.Double majorRadius, System.Double minorRadius, System.Int32 subdivisionLatitude = 16, System.Int32 subdivisionLongitude = 16, System.Boolean generateUV = true) {
			try {
				var ret = Scene_createTorus(api.Session, majorRadius, minorRadius, subdivisionLatitude, subdivisionLongitude, Convert.ToByte(generateUV));
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.UInt32)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region FindBy

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_findDuplicatedPartOccurrences(IntPtr _pxz_session_, System.UInt32 root, System.Double acceptVolumeRatio, System.Double acceptPolycountRatio, System.Double acceptAABBAxisRatio, System.Double acceptAABBCenterDistance);

		/// <summary>
		/// Get duplicated parts
		/// </summary>
		/// <param name="root">Root occurrence for the process</param>
		/// <param name="acceptVolumeRatio">If the ratio of volumes of two part is lower than acceptVolumeRatio, they will be considered duplicated</param>
		/// <param name="acceptPolycountRatio">If the ratio of polygon counts of two part is lower than acceptPolycountRatio, they will be considered duplicated</param>
		/// <param name="acceptAABBAxisRatio">If the ratio of AABB axis of two part is lower than acceptAABBAxisRatio, they will be considered duplicated</param>
		/// <param name="acceptAABBCenterDistance">If the ratio of AABB centers of two part is lower than acceptAABBCenterRatio, they will be considered duplicated</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList FindDuplicatedPartOccurrences(System.UInt32 root = 0, System.Double acceptVolumeRatio = 0.01, System.Double acceptPolycountRatio = 0.1, System.Double acceptAABBAxisRatio = 0.01, System.Double acceptAABBCenterDistance = 0.1) {
			try {
				var ret = Scene_findDuplicatedPartOccurrences(api.Session, root, acceptVolumeRatio, acceptPolycountRatio, acceptAABBAxisRatio, acceptAABBCenterDistance);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_findOccurrencesByMaterial(IntPtr _pxz_session_, System.UInt32 material);

		/// <summary>
		/// get occurrences for which the property "Material" is the given material
		/// </summary>
		/// <param name="material">A material</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList FindOccurrencesByMaterial(System.UInt32 material) {
			try {
				var ret = Scene_findOccurrencesByMaterial(api.Session, material);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_findOccurrencesByMetadata(IntPtr _pxz_session_, string property, string regex, OccurrenceList_c roots, System.Byte caseInsensitive);

		/// <summary>
		/// Returns all occurrences which a metadata property value matches the given regular expression (ECMAScript)
		/// </summary>
		/// <param name="property">Property name</param>
		/// <param name="regex">Regular expression (ECMAScript)</param>
		/// <param name="roots">If specified, restrict the search from the given roots</param>
		/// <param name="caseInsensitive">If True, the regex will be insensitive to upper and lower cases</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList FindOccurrencesByMetadata(System.String property, System.String regex, OccurrenceList roots = null, System.Boolean caseInsensitive = false) {
			roots = roots ?? new Scene.OccurrenceList(new System.UInt32[] {});
			try {
				var roots_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)roots, ref roots_c);
				var ret = Scene_findOccurrencesByMetadata(api.Session, property, regex, roots_c, Convert.ToByte(caseInsensitive));
				Scene.SceneInterface.Scene_OccurrenceList_free(ref roots_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_findOccurrencesByMetadataValue(IntPtr _pxz_session_, string regex, OccurrenceList_c roots, System.Byte caseInsensitive);

		/// <summary>
		/// Returns all occurrences with a metadata value matching the given regular expression (ECMAScript)
		/// </summary>
		/// <param name="regex">Regular expression (ECMAScript)</param>
		/// <param name="roots">If specified, restrict the search from the given roots</param>
		/// <param name="caseInsensitive">If True, the regex will be insensitive to upper and lower cases</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList FindOccurrencesByMetadataValue(System.String regex, OccurrenceList roots = null, System.Boolean caseInsensitive = false) {
			roots = roots ?? new Scene.OccurrenceList(new System.UInt32[] {});
			try {
				var roots_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)roots, ref roots_c);
				var ret = Scene_findOccurrencesByMetadataValue(api.Session, regex, roots_c, Convert.ToByte(caseInsensitive));
				Scene.SceneInterface.Scene_OccurrenceList_free(ref roots_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_findOccurrencesByProperty(IntPtr _pxz_session_, string property, string regex, OccurrenceList_c roots, System.Byte caseInsensitive);

		/// <summary>
		/// Returns all occurrences which a property value matches the given regular expression (ECMAScript)
		/// </summary>
		/// <param name="property">Property name</param>
		/// <param name="regex">Regular expression (ECMAScript)</param>
		/// <param name="roots">If specified, restrict the search from the given roots</param>
		/// <param name="caseInsensitive">If True, the regex will be insensitive to upper and lower cases</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList FindOccurrencesByProperty(System.String property, System.String regex, OccurrenceList roots = null, System.Boolean caseInsensitive = false) {
			roots = roots ?? new Scene.OccurrenceList(new System.UInt32[] {});
			try {
				var roots_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)roots, ref roots_c);
				var ret = Scene_findOccurrencesByProperty(api.Session, property, regex, roots_c, Convert.ToByte(caseInsensitive));
				Scene.SceneInterface.Scene_OccurrenceList_free(ref roots_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_findPartOccurrencesByActiveMaterial(IntPtr _pxz_session_, System.UInt32 material, OccurrenceList_c roots);

		/// <summary>
		/// Find all part occurrence with a given material as active material (i.e. as seen in the rendering)
		/// </summary>
		/// <param name="material">A material</param>
		/// <param name="roots">If specified, restrict the search from the given roots</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList FindPartOccurrencesByActiveMaterial(System.UInt32 material, OccurrenceList roots = null) {
			roots = roots ?? new Scene.OccurrenceList(new System.UInt32[] {});
			try {
				var roots_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)roots, ref roots_c);
				var ret = Scene_findPartOccurrencesByActiveMaterial(api.Session, material, roots_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref roots_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_findPartOccurrencesByMaximumSize(IntPtr _pxz_session_, OccurrenceList_c roots, System.Double maxDiagLength, System.Double maxSize, System.Byte getHidden);

		/// <summary>
		/// Get part occurrences by size
		/// </summary>
		/// <param name="roots">Roots occurrences for the process</param>
		/// <param name="maxDiagLength">If the diagonal axis of the bounding box is less than maxDiagLength, part will be filtered. -1 to ignore</param>
		/// <param name="maxSize">If the longer axis of the box is less than maxLength, part will be filtered. -1 to ignore</param>
		/// <param name="getHidden">If true, hidden part occurrences meeting the criteria will be filtered as well</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList FindPartOccurrencesByMaximumSize(OccurrenceList roots, System.Double maxDiagLength, System.Double maxSize = -1, System.Boolean getHidden = false) {
			try {
				var roots_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)roots, ref roots_c);
				var ret = Scene_findPartOccurrencesByMaximumSize(api.Session, roots_c, maxDiagLength, maxSize, Convert.ToByte(getHidden));
				Scene.SceneInterface.Scene_OccurrenceList_free(ref roots_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_findPartOccurrencesByMinimumNumberOfInstances(IntPtr _pxz_session_, Int32 minInstanciationCount);

		/// <summary>
		/// get part occurrences with more than "minInstanciationCount" occurrence on the scene
		/// </summary>
		/// <param name="minInstanciationCount">Min occurrence count</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList FindPartOccurrencesByMinimumNumberOfInstances(System.Int32 minInstanciationCount) {
			try {
				var ret = Scene_findPartOccurrencesByMinimumNumberOfInstances(api.Session, minInstanciationCount);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_findPartOccurrencesByVisibleMaterial(IntPtr _pxz_session_, System.UInt32 material);

		/// <summary>
		/// get part occurrences for which the given material is visible in the viewer
		/// </summary>
		/// <param name="material">A material</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList FindPartOccurrencesByVisibleMaterial(System.UInt32 material) {
			try {
				var ret = Scene_findPartOccurrencesByVisibleMaterial(api.Session, material);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region FindIn

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_findPartOccurrencesInAABB(IntPtr _pxz_session_, Geom.AABB_c aabb);

		/// <summary>
		/// find part occurrences in the scene in a given axis aligned bounding box
		/// </summary>
		/// <param name="aabb">The axis aligned bounding box</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList FindPartOccurrencesInAABB(Geom.AABB aabb) {
			try {
				var aabb_c = new Geom.AABB_c();
				Geom.GeomInterface.ConvertValue((Geom.AABB)aabb, ref aabb_c);
				var ret = Scene_findPartOccurrencesInAABB(api.Session, aabb_c);
				Geom.GeomInterface.Geom_AABB_free(ref aabb_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_findPartOccurrencesInBox(IntPtr _pxz_session_, Geom.ExtendedBox_c box, System.Byte strictlyIncludes);

		/// <summary>
		/// get part occurrences contained in a given box
		/// </summary>
		/// <param name="box">The extension box</param>
		/// <param name="strictlyIncludes">If false, parts only need to intersect the box to be selected</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList FindPartOccurrencesInBox(Geom.ExtendedBox box, System.Boolean strictlyIncludes) {
			try {
				var box_c = new Geom.ExtendedBox_c();
				Geom.GeomInterface.ConvertValue((Geom.ExtendedBox)box, ref box_c);
				var ret = Scene_findPartOccurrencesInBox(api.Session, box_c, Convert.ToByte(strictlyIncludes));
				Geom.GeomInterface.Geom_ExtendedBox_free(ref box_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region Hierarchy

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_createSubTree(IntPtr _pxz_session_, PackedTree_c tree, System.UInt32 root, System.Byte replaceRoot);

		/// <summary>
		/// Create a complete scene tree
		/// </summary>
		/// <param name="tree"></param>
		/// <param name="root">Specify the root occurrence of the scene</param>
		/// <param name="replaceRoot">If true, the root occurrence will be replaced by the root of the given tree, else it will be added as a child</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList CreateSubTree(PackedTree tree, System.UInt32 root = 0, System.Boolean replaceRoot = true) {
			try {
				var tree_c = new Scene.PackedTree_c();
				ConvertValue((Scene.PackedTree)tree, ref tree_c);
				var ret = Scene_createSubTree(api.Session, tree_c, root, Convert.ToByte(replaceRoot));
				Scene.SceneInterface.Scene_PackedTree_free(ref tree_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_getChildren(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Get the children of an occurrence
		/// </summary>
		/// <param name="occurrence">The occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList GetChildren(System.UInt32 occurrence) {
			try {
				var ret = Scene_getChildren(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_getCurrentVariantRoot(IntPtr _pxz_session_);

		/// <summary>
		/// Get the current active root. Returns active variant's root if one or global root.
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetCurrentVariantRoot() {
			try {
				var ret = Scene_getCurrentVariantRoot(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern OccurrenceList_c Scene_getOccurrenceAncestors(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Get all ancestors from occurrence until root (occurrence is not included)
		/// </summary>
		/// <param name="occurrence">The occurrence to find ancestors</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList GetOccurrenceAncestors(System.UInt32 occurrence) {
			try {
				var ret = Scene_getOccurrenceAncestors(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceListList_c Scene_getOccurrencesAncestors(IntPtr _pxz_session_, OccurrenceList_c occurrences);

		/// <summary>
		/// Batch version of getOccurrenceAncestors
		/// </summary>
		/// <param name="occurrences">The list of occurrences to find ancestors</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceListList GetOccurrencesAncestors(OccurrenceList occurrences) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var ret = Scene_getOccurrencesAncestors(api.Session, occurrences_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceListList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_getParent(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Get the parent of an occurrence
		/// </summary>
		/// <param name="occurrence">The occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetParent(System.UInt32 occurrence) {
			try {
				var ret = Scene_getParent(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_getRoot(IntPtr _pxz_session_);

		/// <summary>
		/// Get the root occurrence of the product structure
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetRoot() {
			try {
				var ret = Scene_getRoot(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern PackedTree_c Scene_getSubTree(IntPtr _pxz_session_, System.UInt32 root, Int32 visibilityMode, Int32 depth);

		/// <summary>
		/// Returns a packed version of the whole scene tree
		/// </summary>
		/// <param name="root">Specify the root of the returned scene</param>
		/// <param name="visibilityMode">The visibility mode</param>
		/// <param name="depth">Maximum depth</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public PackedTree GetSubTree(System.UInt32 root = 0, VisibilityMode visibilityMode = (Scene.VisibilityMode)1, System.Int32 depth = -1) {
			try {
				var ret = Scene_getSubTree(api.Session, root, (int)visibilityMode, depth);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_PackedTree_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_moveOccurrences(IntPtr _pxz_session_, OccurrenceList_c occurrences, System.UInt32 destination, System.UInt32 insertBefore);

		/// <summary>
		/// Move an occurrence, adjusting the transformation to keep objects at the same place in the world space
		/// </summary>
		/// <param name="occurrences">The occurrences to move</param>
		/// <param name="destination">Destination occurrence (the new parent)</param>
		/// <param name="insertBefore">Occurrence before witch to move, if null append to destination children</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void MoveOccurrences(OccurrenceList occurrences, System.UInt32 destination, System.UInt32 insertBefore = 0) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				Scene_moveOccurrences(api.Session, occurrences_c, destination, insertBefore);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setParent(IntPtr _pxz_session_, System.UInt32 occurrence, System.UInt32 parent, System.Byte addInParentInstances, System.UInt32 insertBefore, System.Byte worldPositionStays);

		/// <summary>
		/// Set the parent of an occurrence
		/// </summary>
		/// <param name="occurrence">The occurrence</param>
		/// <param name="parent">The parent occurrence</param>
		/// <param name="addInParentInstances">If True, each occurrence whose prototype is the target parent will generate a child whose prototype is the occurrence itself</param>
		/// <param name="insertBefore">Add before this child occurrence in the children list of the parent occurrence</param>
		/// <param name="worldPositionStays">If true, the parent-relative position, scale and rotation are modified such that the object keeps the same world space position, rotation and scale as before.</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetParent(System.UInt32 occurrence, System.UInt32 parent, System.Boolean addInParentInstances = false, System.UInt32 insertBefore = 0, System.Boolean worldPositionStays = false) {
			try {
				Scene_setParent(api.Session, occurrence, parent, Convert.ToByte(addInParentInstances), insertBefore, Convert.ToByte(worldPositionStays));
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region Lights

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_addLightComponent(IntPtr _pxz_session_, System.UInt32 occurrence, Int32 lightType, Core.Color_c color, System.Double power, System.Double cutOff);

		/// <summary>
		/// Add a light component to an occurrence
		/// </summary>
		/// <param name="occurrence">The occurrence to add the new component</param>
		/// <param name="lightType">The type of the light</param>
		/// <param name="color">Color of the light</param>
		/// <param name="power">The power of the light</param>
		/// <param name="cutOff">The cutoff angle of the light</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 AddLightComponent(System.UInt32 occurrence, LightType lightType, Core.Color color, System.Double power = 1.0, System.Double cutOff = 20.0) {
			try {
				var color_c = new Core.Color_c();
				Core.CoreInterface.ConvertValue((Core.Color)color, ref color_c);
				var ret = Scene_addLightComponent(api.Session, occurrence, (int)lightType, color_c, power, cutOff);
				Core.CoreInterface.Core_Color_free(ref color_c);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_createLight(IntPtr _pxz_session_, string name, Int32 lightType, Core.Color_c color, System.Double power, System.Double cutOff, System.UInt32 parent);

		/// <summary>
		/// Create an occurrence with a light component
		/// </summary>
		/// <param name="name">Name of the light</param>
		/// <param name="lightType">The type of the light</param>
		/// <param name="color">Color of the light</param>
		/// <param name="power">The power of the light</param>
		/// <param name="cutOff">The cutoff angle of the light</param>
		/// <param name="parent">The parent of the light occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateLight(System.String name, LightType lightType, Core.Color color, System.Double power = 1.0, System.Double cutOff = 20.0, System.UInt32 parent = 0) {
			try {
				var color_c = new Core.Color_c();
				Core.CoreInterface.ConvertValue((Core.Color)color, ref color_c);
				var ret = Scene_createLight(api.Session, name, (int)lightType, color_c, power, cutOff, parent);
				Core.CoreInterface.Core_Color_free(ref color_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.UInt32)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region Metadata

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_addMetadata(IntPtr _pxz_session_, System.UInt32 metadata, string name, string value);

		/// <summary>
		/// Add a new metadata property to a metadata component
		/// </summary>
		/// <param name="metadata">The metadata component</param>
		/// <param name="name">The new property name</param>
		/// <param name="value">The new property value</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AddMetadata(System.UInt32 metadata, System.String name, System.String value) {
			try {
				Scene_addMetadata(api.Session, metadata, name, value);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_addMetadataBlock(IntPtr _pxz_session_, System.UInt32 metadata, Core.StringList_c names, Core.StringList_c values);

		/// <summary>
		/// Add a new metadata property to a metadata component
		/// </summary>
		/// <param name="metadata">The metadata component</param>
		/// <param name="names">The new properties names</param>
		/// <param name="values">The new properties values</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AddMetadataBlock(System.UInt32 metadata, Core.StringList names, Core.StringList values) {
			try {
				var names_c = new Core.StringList_c();
				Core.CoreInterface.ConvertValue((Core.StringList)names, ref names_c);
				var values_c = new Core.StringList_c();
				Core.CoreInterface.ConvertValue((Core.StringList)values, ref values_c);
				Scene_addMetadataBlock(api.Session, metadata, names_c, values_c);
				Core.CoreInterface.Core_StringList_free(ref names_c);
				Core.CoreInterface.Core_StringList_free(ref values_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern MetadataList_c Scene_createMetadatasFromDefinitions(IntPtr _pxz_session_, OccurrenceList_c occurrences, MetadataDefinitionList_c definitions);

		/// <summary>
		/// Create Metadata components from definitions
		/// </summary>
		/// <param name="occurrences">List of occurrences to add the metadata components</param>
		/// <param name="definitions">List of metadata definition</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public MetadataList CreateMetadatasFromDefinitions(OccurrenceList occurrences, MetadataDefinitionList definitions) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var definitions_c = new Scene.MetadataDefinitionList_c();
				ConvertValue((Scene.MetadataDefinitionList)definitions, ref definitions_c);
				var ret = Scene_createMetadatasFromDefinitions(api.Session, occurrences_c, definitions_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				Scene.SceneInterface.Scene_MetadataDefinitionList_free(ref definitions_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_MetadataList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Scene_getMetadata(IntPtr _pxz_session_, System.UInt32 metadata, string name);

		/// <summary>
		/// Get a metadata property value from a metadata component
		/// </summary>
		/// <param name="metadata">The metadata component</param>
		/// <param name="name">The metadata property name</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String GetMetadata(System.UInt32 metadata, System.String name) {
			try {
				var ret = Scene_getMetadata(api.Session, metadata, name);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern MetadataDefinitionList_c Scene_getMetadatasDefinitions(IntPtr _pxz_session_, MetadataList_c metadatas);

		/// <summary>
		/// Returns definition of Metadata components
		/// </summary>
		/// <param name="metadatas">List of metadata component to retrieve definition</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public MetadataDefinitionList GetMetadatasDefinitions(MetadataList metadatas) {
			try {
				var metadatas_c = new Scene.MetadataList_c();
				ConvertValue((Scene.MetadataList)metadatas, ref metadatas_c);
				var ret = Scene_getMetadatasDefinitions(api.Session, metadatas_c);
				Scene.SceneInterface.Scene_MetadataList_free(ref metadatas_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_MetadataDefinitionList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_removeMetadata(IntPtr _pxz_session_, System.UInt32 metadata, string name);

		/// <summary>
		/// Remove a property from a metadata
		/// </summary>
		/// <param name="metadata">The occurrence</param>
		/// <param name="name">The name of the property</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void RemoveMetadata(System.UInt32 metadata, System.String name) {
			try {
				Scene_removeMetadata(api.Session, metadata, name);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region Subpart materials

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_getSubpartMaterial(IntPtr _pxz_session_, System.UInt32 occurrence, System.UInt32 subpartIndex);

		/// <summary>
		/// Get a subpart material assignment according to overrides on the scene tree with SubpartMaterial components
		/// </summary>
		/// <param name="occurrence">The Occurrence</param>
		/// <param name="subpartIndex">The subpart index</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetSubpartMaterial(System.UInt32 occurrence, System.UInt32 subpartIndex) {
			try {
				var ret = Scene_getSubpartMaterial(api.Session, occurrence, subpartIndex);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern Material.MaterialList_c Scene_listActiveShapeMaterials(IntPtr _pxz_session_, System.UInt32 part);

		/// <summary>
		/// list all the materials used in the part shape
		/// </summary>
		/// <param name="part">The part which contains sub materials</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Material.MaterialList ListActiveShapeMaterials(System.UInt32 part) {
			try {
				var ret = Scene_listActiveShapeMaterials(api.Session, part);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Material.MaterialInterface.ConvertValue(ref ret);
				Material.MaterialInterface.Material_MaterialList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Material.MaterialList_c Scene_listSubpartMaterials(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// list all the materials used in the part shape or overrided with a SubpartMaterial component
		/// </summary>
		/// <param name="occurrence">The occurrence which contains sub materials</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Material.MaterialList ListSubpartMaterials(System.UInt32 occurrence) {
			try {
				var ret = Scene_listSubpartMaterials(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Material.MaterialInterface.ConvertValue(ref ret);
				Material.MaterialInterface.Material_MaterialList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern VariantMaterialList_c Scene_listSubpartVariantMaterials(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// list all the materials variants in subpart 
		/// </summary>
		/// <param name="occurrence">The occurrence which contains variants</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public VariantMaterialList ListSubpartVariantMaterials(System.UInt32 occurrence) {
			try {
				var ret = Scene_listSubpartVariantMaterials(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_VariantMaterialList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setSubpartMaterial(IntPtr _pxz_session_, System.UInt32 occurrence, System.UInt32 subpartIndex, System.UInt32 material);

		/// <summary>
		/// Set a subpart material assignment using a SubpartMaterial component
		/// </summary>
		/// <param name="occurrence">The Occurrence</param>
		/// <param name="subpartIndex">The subpart index</param>
		/// <param name="material">The material</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetSubpartMaterial(System.UInt32 occurrence, System.UInt32 subpartIndex, System.UInt32 material) {
			try {
				Scene_setSubpartMaterial(api.Session, occurrence, subpartIndex, material);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setSubpartMaterials(IntPtr _pxz_session_, System.UInt32 occurrence, Material.MaterialList_c materials, System.UInt32 startIndex);

		/// <summary>
		/// Set multiple subpart materials at once using a SubpartMaterial component
		/// </summary>
		/// <param name="occurrence">The Occurrence on which to apply the materials</param>
		/// <param name="materials">Materials to set</param>
		/// <param name="startIndex">The subpart start index</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetSubpartMaterials(System.UInt32 occurrence, Material.MaterialList materials, System.UInt32 startIndex = 0) {
			try {
				var materials_c = new Material.MaterialList_c();
				Material.MaterialInterface.ConvertValue((Material.MaterialList)materials, ref materials_c);
				Scene_setSubpartMaterials(api.Session, occurrence, materials_c, startIndex);
				Material.MaterialInterface.Material_MaterialList_free(ref materials_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setSubpartVariantMaterials(IntPtr _pxz_session_, System.UInt32 occurrence, VariantMaterialList_c variantMaterials);

		/// <summary>
		/// set materials in variant 
		/// </summary>
		/// <param name="occurrence">The occurrence which contains variants</param>
		/// <param name="variantMaterials">List of variant and materials</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetSubpartVariantMaterials(System.UInt32 occurrence, VariantMaterialList variantMaterials) {
			try {
				var variantMaterials_c = new Scene.VariantMaterialList_c();
				ConvertValue((Scene.VariantMaterialList)variantMaterials, ref variantMaterials_c);
				Scene_setSubpartVariantMaterials(api.Session, occurrence, variantMaterials_c);
				Scene.SceneInterface.Scene_VariantMaterialList_free(ref variantMaterials_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern VariantMaterialList_c Scene_setSubpartVariantMaterialsList(IntPtr _pxz_session_, VariantList_c variants, Material.MaterialListList_c materialListList);

		/// <summary>
		/// set all the materials list in variants 
		/// </summary>
		/// <param name="variants">The part which contains variants</param>
		/// <param name="materialListList">The part which contains the list of material variant list</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public VariantMaterialList SetSubpartVariantMaterialsList(VariantList variants, Material.MaterialListList materialListList) {
			try {
				var variants_c = new Scene.VariantList_c();
				ConvertValue((Scene.VariantList)variants, ref variants_c);
				var materialListList_c = new Material.MaterialListList_c();
				Material.MaterialInterface.ConvertValue((Material.MaterialListList)materialListList, ref materialListList_c);
				var ret = Scene_setSubpartVariantMaterialsList(api.Session, variants_c, materialListList_c);
				Scene.SceneInterface.Scene_VariantList_free(ref variants_c);
				Material.MaterialInterface.Material_MaterialListList_free(ref materialListList_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_VariantMaterialList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_transferSubpartMaterialsOnPatches(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Assign SubpartMaterialComponent materials on the occurrence's part shapes. This might affect other Part in the scene if not singularized before.
		/// </summary>
		/// <param name="occurrence">The occurrence which has sub materials assigned</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void TransferSubpartMaterialsOnPatches(System.UInt32 occurrence) {
			try {
				Scene_transferSubpartMaterialsOnPatches(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region alternative trees

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_createAlternativeTree(IntPtr _pxz_session_, string name, System.UInt32 root);

		/// <summary>
		/// Create a new alternative tree
		/// </summary>
		/// <param name="name">The name of the new alternative tree</param>
		/// <param name="root">The root occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateAlternativeTree(System.String name, System.UInt32 root = 0) {
			try {
				var ret = Scene_createAlternativeTree(api.Session, name, root);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_getAlternativeTreeRoot(IntPtr _pxz_session_, System.UInt32 tree);

		/// <summary>
		/// Returns the root occurrence associated with the given AlternativeTree
		/// </summary>
		/// <param name="tree">Targeted alternative tree</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetAlternativeTreeRoot(System.UInt32 tree) {
			try {
				var ret = Scene_getAlternativeTreeRoot(api.Session, tree);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern AlternativeTreeList_c Scene_listAlternativeTrees(IntPtr _pxz_session_);

		/// <summary>
		/// Returns all the available alternative trees
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public AlternativeTreeList ListAlternativeTrees() {
			try {
				var ret = Scene_listAlternativeTrees(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_AlternativeTreeList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region animations

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_addAnimation(IntPtr _pxz_session_, System.UInt32 animation);

		/// <summary>
		/// Add an animation in Animation library
		/// </summary>
		/// <param name="animation">Animation to add</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AddAnimation(System.UInt32 animation) {
			try {
				Scene_addAnimation(api.Session, animation);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_addKeyframe(IntPtr _pxz_session_, System.UInt32 channel, System.UInt64 time, System.Double value);

		/// <summary>
		/// Adds a keyframe in the curve
		/// </summary>
		/// <param name="channel">The channel one wants to add a keyframe in</param>
		/// <param name="time">The time</param>
		/// <param name="value">The value</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 AddKeyframe(System.UInt32 channel, System.UInt64 time, System.Double value) {
			try {
				var ret = Scene_addKeyframe(api.Session, channel, time, value);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern void Scene_addKeyframeFromCurrentPosition(IntPtr _pxz_session_, System.UInt32 channel, System.UInt64 time);

		/// <summary>
		/// Adds keyframes in a given AnimChannel based on current position
		/// </summary>
		/// <param name="channel">The channel one wants to add a keyframe in</param>
		/// <param name="time">The time</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AddKeyframeFromCurrentPosition(System.UInt32 channel, System.UInt64 time) {
			try {
				Scene_addKeyframeFromCurrentPosition(api.Session, channel, time);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Scene_animatesThisOccurrence(IntPtr _pxz_session_, System.UInt32 animation, System.UInt32 occurrence);

		/// <summary>
		/// Does this Animation animates this Occurrence - or one of its parents (thus animating it indirectly) ?
		/// </summary>
		/// <param name="animation">The Animation</param>
		/// <param name="occurrence">The supposedly animated occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean AnimatesThisOccurrence(System.UInt32 animation, System.UInt32 occurrence) {
			try {
				var ret = Scene_animatesThisOccurrence(api.Session, animation, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern void Scene_bakeAnimation(IntPtr _pxz_session_, System.UInt32 animation, System.UInt32 occurrence, System.UInt32 end, System.UInt64 interval);

		/// <summary>
		/// WARNING: this function is tagged as 'EXPERIMENTAL'<br/>
		/// Bake an animation. The values are now precalculated and no longer interpolated.
		/// </summary>
		/// <param name="animation">The Animation</param>
		/// <param name="occurrence">The occurrence</param>
		/// <param name="end">The parent occurrence</param>
		/// <param name="interval">The interval</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void BakeAnimation(System.UInt32 animation, System.UInt32 occurrence, System.UInt32 end, System.UInt64 interval) {
			try {
				Scene_bakeAnimation(api.Session, animation, occurrence, end, interval);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_createAnimation(IntPtr _pxz_session_, string name);

		/// <summary>
		/// Creates an animation, need to use addAnimation when animation is filled
		/// </summary>
		/// <param name="name">Name of the animation</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateAnimation(System.String name) {
			try {
				var ret = Scene_createAnimation(api.Session, name);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_createSkeletonMesh(IntPtr _pxz_session_, System.UInt32 root);

		/// <summary>
		/// Create a skeleton mesh from a joint component tree
		/// </summary>
		/// <param name="root">Root joint component node</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateSkeletonMesh(System.UInt32 root) {
			try {
				var ret = Scene_createSkeletonMesh(api.Session, root);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern void Scene_decimateAnimChannelBySegment(IntPtr _pxz_session_, System.UInt32 channel, System.Double precision);

		/// <summary>
		/// Decimates by segment a given AnimChannel
		/// </summary>
		/// <param name="channel">The channel</param>
		/// <param name="precision">The precision</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void DecimateAnimChannelBySegment(System.UInt32 channel, System.Double precision) {
			try {
				Scene_decimateAnimChannelBySegment(api.Session, channel, precision);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_deleteAnimation(IntPtr _pxz_session_, System.UInt32 animation);

		/// <summary>
		/// Deletes an animation
		/// </summary>
		/// <param name="animation">The created animation</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void DeleteAnimation(System.UInt32 animation) {
			try {
				Scene_deleteAnimation(api.Session, animation);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_deleteEmptyAnimation(IntPtr _pxz_session_);

		/// <summary>
		/// Delete all animation that contain 0 keyframes
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void DeleteEmptyAnimation() {
			try {
				Scene_deleteEmptyAnimation(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_displayAllKeyframesFromAnimChannel(IntPtr _pxz_session_, System.UInt32 channel);

		/// <summary>
		/// Displays info on the selected AnimChannel
		/// </summary>
		/// <param name="channel">The channel</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void DisplayAllKeyframesFromAnimChannel(System.UInt32 channel) {
			try {
				Scene_displayAllKeyframesFromAnimChannel(api.Session, channel);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_displayAllKeyframesFromAnimation(IntPtr _pxz_session_, System.UInt32 animation);

		/// <summary>
		/// Displays info on the selected animation
		/// </summary>
		/// <param name="animation">The animation</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void DisplayAllKeyframesFromAnimation(System.UInt32 animation) {
			try {
				Scene_displayAllKeyframesFromAnimation(api.Session, animation);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_displayValueFromAnimChannelAtTime(IntPtr _pxz_session_, System.UInt32 channel, System.UInt64 time, System.Byte defaultValue);

		/// <summary>
		/// Displays the value
		/// </summary>
		/// <param name="channel">The channel</param>
		/// <param name="time">The time</param>
		/// <param name="defaultValue">Show default instead ?</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void DisplayValueFromAnimChannelAtTime(System.UInt32 channel, System.UInt64 time, System.Boolean defaultValue = false) {
			try {
				Scene_displayValueFromAnimChannelAtTime(api.Session, channel, time, Convert.ToByte(defaultValue));
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_getAnimChannelIfExists(IntPtr _pxz_session_, System.UInt32 animation, System.UInt32 occurrence);

		/// <summary>
		/// Returns the main AnimChannel of an Occurrence according to a given Animation
		/// </summary>
		/// <param name="animation">The Animation</param>
		/// <param name="occurrence">The Occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetAnimChannelIfExists(System.UInt32 animation, System.UInt32 occurrence) {
			try {
				var ret = Scene_getAnimChannelIfExists(api.Session, animation, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern AnimChannelInfo_c Scene_getAnimChannelInfo(IntPtr _pxz_session_, System.UInt32 channel);

		/// <summary>
		/// WARNING: this function is tagged as 'EXPERIMENTAL'<br/>
		/// get an animation channel informations
		/// </summary>
		/// <param name="channel">Animation to get info of</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public AnimChannelInfo GetAnimChannelInfo(System.UInt32 channel) {
			try {
				var ret = Scene_getAnimChannelInfo(api.Session, channel);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_AnimChannelInfo_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_getAnimChannelOccurrence(IntPtr _pxz_session_, System.UInt32 channel);

		/// <summary>
		/// Returns the Occurrence related to a given AnimChannel
		/// </summary>
		/// <param name="channel">The channel</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetAnimChannelOccurrence(System.UInt32 channel) {
			try {
				var ret = Scene_getAnimChannelOccurrence(api.Session, channel);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern AnimPropertyBinderList_c Scene_getAnimationComponentPropertyBinderLists(IntPtr _pxz_session_, System.UInt32 animationComponent);

		/// <summary>
		/// WARNING: this function is tagged as 'EXPERIMENTAL'<br/>
		/// packs all animation-related info in an object
		/// </summary>
		/// <param name="animationComponent">Animation to get info of</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public AnimPropertyBinderList GetAnimationComponentPropertyBinderLists(System.UInt32 animationComponent) {
			try {
				var ret = Scene_getAnimationComponentPropertyBinderLists(api.Session, animationComponent);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_AnimPropertyBinderList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern AnimationInfo_c Scene_getAnimationInfo(IntPtr _pxz_session_, System.UInt32 animation);

		/// <summary>
		/// WARNING: this function is tagged as 'EXPERIMENTAL'<br/>
		/// packs all animation-related info in an object
		/// </summary>
		/// <param name="animation">Animation to get info of</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public AnimationInfo GetAnimationInfo(System.UInt32 animation) {
			try {
				var ret = Scene_getAnimationInfo(api.Session, animation);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_AnimationInfo_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern AnimPropertyBinderList_c Scene_getAnimationPropertyBinderLists(IntPtr _pxz_session_, System.UInt32 animation);

		/// <summary>
		/// WARNING: this function is tagged as 'EXPERIMENTAL'<br/>
		/// packs all animation-related info in an object
		/// </summary>
		/// <param name="animation">Animation to get info of</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public AnimPropertyBinderList GetAnimationPropertyBinderLists(System.UInt32 animation) {
			try {
				var ret = Scene_getAnimationPropertyBinderLists(api.Session, animation);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_AnimPropertyBinderList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern JointDefinition_c Scene_getJointDefinition(IntPtr _pxz_session_, System.UInt32 joint);

		/// <summary>
		/// Get joint definition from id
		/// </summary>
		/// <param name="joint">Id of the joint</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public JointDefinition GetJointDefinition(System.UInt32 joint) {
			try {
				var ret = Scene_getJointDefinition(api.Session, joint);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_JointDefinition_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern JointDefinitionList_c Scene_getJointDefinitions(IntPtr _pxz_session_, Polygonal.JointList_c joints);

		/// <summary>
		/// Get joint definition from id
		/// </summary>
		/// <param name="joints">Ids of joints</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public JointDefinitionList GetJointDefinitions(Polygonal.JointList joints) {
			try {
				var joints_c = new Polygonal.JointList_c();
				Polygonal.PolygonalInterface.ConvertValue((Polygonal.JointList)joints, ref joints_c);
				var ret = Scene_getJointDefinitions(api.Session, joints_c);
				Polygonal.PolygonalInterface.Polygonal_JointList_free(ref joints_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_JointDefinitionList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_getKeyframeParentAnimChannel(IntPtr _pxz_session_, System.UInt32 keyframe);

		/// <summary>
		/// Returns the parent AnimChannel of a given Keyframe
		/// </summary>
		/// <param name="keyframe">The keyframe one wants the parent of</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetKeyframeParentAnimChannel(System.UInt32 keyframe) {
			try {
				var ret = Scene_getKeyframeParentAnimChannel(api.Session, keyframe);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern KeyframeList_c Scene_getKeyframes(IntPtr _pxz_session_, System.UInt32 channel);

		/// <summary>
		/// Returns a list of all keyframes of a simple animChannel
		/// </summary>
		/// <param name="channel">The channel one wants to extract the keyframs from</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public KeyframeList GetKeyframes(System.UInt32 channel) {
			try {
				var ret = Scene_getKeyframes(api.Session, channel);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_KeyframeList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_getMainChannel(IntPtr _pxz_session_, System.UInt32 channel);

		/// <summary>
		/// Returns the main AnimChannel of a given AnimChannel
		/// </summary>
		/// <param name="channel">The channel one wants the main of</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetMainChannel(System.UInt32 channel) {
			try {
				var ret = Scene_getMainChannel(api.Session, channel);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_getOccurrenceJoint(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Returns the Joint assigned to an occurrence if any
		/// </summary>
		/// <param name="occurrence">The occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetOccurrenceJoint(System.UInt32 occurrence) {
			try {
				var ret = Scene_getOccurrenceJoint(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_getParentChannel(IntPtr _pxz_session_, System.UInt32 channel);

		/// <summary>
		/// Returns (if exists) the parent AnimChannel of a given AnimChannel
		/// </summary>
		/// <param name="channel">The channel one wants the parent of</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetParentChannel(System.UInt32 channel) {
			try {
				var ret = Scene_getParentChannel(api.Session, channel);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_getSubChannel(IntPtr _pxz_session_, System.UInt32 channel, string name);

		/// <summary>
		/// Returns the subchannel of a given name from an AnimChannel
		/// </summary>
		/// <param name="channel">The channel one wants the subchannel of</param>
		/// <param name="name">The name of the subchannel</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetSubChannel(System.UInt32 channel, System.String name) {
			try {
				var ret = Scene_getSubChannel(api.Session, channel, name);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern AnimChannelList_c Scene_getSubChannels(IntPtr _pxz_session_, System.UInt32 channel);

		/// <summary>
		/// Returns all the sub channel of an AnimChannel
		/// </summary>
		/// <param name="channel">The channel one wants the subchannel of</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public AnimChannelList GetSubChannels(System.UInt32 channel) {
			try {
				var ret = Scene_getSubChannels(api.Session, channel);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_AnimChannelList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_linkPropertyToAnimation(IntPtr _pxz_session_, System.UInt32 animation, System.UInt32 entity, string propertyName);

		/// <summary>
		/// Creates a Binder in an Animation stack to animate an entity's property
		/// </summary>
		/// <param name="animation">The Animation stack where to put a animated property</param>
		/// <param name="entity">The entity object to animate</param>
		/// <param name="propertyName">The name of the property to animate</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 LinkPropertyToAnimation(System.UInt32 animation, System.UInt32 entity, System.String propertyName) {
			try {
				var ret = Scene_linkPropertyToAnimation(api.Session, animation, entity, propertyName);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern AnimationList_c Scene_listAnimations(IntPtr _pxz_session_);

		/// <summary>
		/// List all Animations from the scene
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public AnimationList ListAnimations() {
			try {
				var ret = Scene_listAnimations(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_AnimationList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern AnimChannelList_c Scene_listMainChannels(IntPtr _pxz_session_, System.UInt32 animation);

		/// <summary>
		/// List all main AnimChannel from a given Animation
		/// </summary>
		/// <param name="animation">The Animation one wants to list the channels from</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public AnimChannelList ListMainChannels(System.UInt32 animation) {
			try {
				var ret = Scene_listMainChannels(api.Session, animation);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_AnimChannelList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_makeDefaultKeyframe(IntPtr _pxz_session_, System.UInt32 channel);

		/// <summary>
		/// Creates keyframes with the default values of the channel at time 0
		/// </summary>
		/// <param name="channel">The channel</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void MakeDefaultKeyframe(System.UInt32 channel) {
			try {
				Scene_makeDefaultKeyframe(api.Session, channel);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_moveAnimation(IntPtr _pxz_session_, System.UInt32 animation, System.UInt32 target, System.UInt32 newParent, System.UInt64 interval);

		/// <summary>
		/// Moving animation
		/// </summary>
		/// <param name="animation">The Animation</param>
		/// <param name="target">The target occurrence</param>
		/// <param name="newParent">The new parent occurrence</param>
		/// <param name="interval">The interval</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void MoveAnimation(System.UInt32 animation, System.UInt32 target, System.UInt32 newParent, System.UInt64 interval) {
			try {
				Scene_moveAnimation(api.Session, animation, target, newParent, interval);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_removeKeyframe(IntPtr _pxz_session_, System.UInt32 channel, System.UInt64 time);

		/// <summary>
		/// Removes a keyframe in the curve
		/// </summary>
		/// <param name="channel">The channel one wants to remove a keyframe from</param>
		/// <param name="time">The time</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void RemoveKeyframe(System.UInt32 channel, System.UInt64 time) {
			try {
				Scene_removeKeyframe(api.Session, channel, time);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_unlinkPropertyToAnimation(IntPtr _pxz_session_, System.UInt32 animation, System.UInt32 entity, string propertyName);

		/// <summary>
		/// Unlinks a binder
		/// </summary>
		/// <param name="animation">The Animation stack where to put a animated property</param>
		/// <param name="entity">The entity object to animate</param>
		/// <param name="propertyName">The name of the property to animate</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void UnlinkPropertyToAnimation(System.UInt32 animation, System.UInt32 entity, System.String propertyName) {
			try {
				Scene_unlinkPropertyToAnimation(api.Session, animation, entity, propertyName);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		private delegate void AnimationAddedDelegate_c(IntPtr userData, System.UInt32 animation);
		private static Dictionary<uint, AnimationAddedDelegate_c> m_AnimationAddedCallbacks = new Dictionary<uint, AnimationAddedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_addAnimationAddedCallback(IntPtr _pxz_session_, AnimationAddedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_removeAnimationAddedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void AnimationAddedDelegate(IntPtr userData, System.UInt32 animation);

		public System.UInt32 AddAnimationAddedCallback(AnimationAddedDelegate callback, IntPtr userData) {
			AnimationAddedDelegate_c c = new AnimationAddedDelegate_c((System.IntPtr _pxz_session_, System.UInt32 animation) =>
			{
				var animation_cs = (System.UInt32)(animation);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, animation_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Scene_addAnimationAddedCallback(api.Session, c, userData);
			m_AnimationAddedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveAnimationAddedCallback(System.UInt32 id) {
			Scene_removeAnimationAddedCallback(api.Session, id);
			m_AnimationAddedCallbacks.Remove(id);
		}

		private delegate void AnimationChangedDelegate_c(IntPtr userData, System.UInt32 animation);
		private static Dictionary<uint, AnimationChangedDelegate_c> m_AnimationChangedCallbacks = new Dictionary<uint, AnimationChangedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_addAnimationChangedCallback(IntPtr _pxz_session_, AnimationChangedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_removeAnimationChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void AnimationChangedDelegate(IntPtr userData, System.UInt32 animation);

		public System.UInt32 AddAnimationChangedCallback(AnimationChangedDelegate callback, IntPtr userData) {
			AnimationChangedDelegate_c c = new AnimationChangedDelegate_c((System.IntPtr _pxz_session_, System.UInt32 animation) =>
			{
				var animation_cs = (System.UInt32)(animation);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, animation_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Scene_addAnimationChangedCallback(api.Session, c, userData);
			m_AnimationChangedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveAnimationChangedCallback(System.UInt32 id) {
			Scene_removeAnimationChangedCallback(api.Session, id);
			m_AnimationChangedCallbacks.Remove(id);
		}

		private delegate void AnimationClearedDelegate_c(IntPtr userData);
		private static Dictionary<uint, AnimationClearedDelegate_c> m_AnimationClearedCallbacks = new Dictionary<uint, AnimationClearedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_addAnimationClearedCallback(IntPtr _pxz_session_, AnimationClearedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_removeAnimationClearedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void AnimationClearedDelegate(IntPtr userData);

		public System.UInt32 AddAnimationClearedCallback(AnimationClearedDelegate callback, IntPtr userData) {
			AnimationClearedDelegate_c c = new AnimationClearedDelegate_c((System.IntPtr _pxz_session_) =>
			{
				System.String err = ConvertValue(Scene_getLastError());
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
			uint id = Scene_addAnimationClearedCallback(api.Session, c, userData);
			m_AnimationClearedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveAnimationClearedCallback(System.UInt32 id) {
			Scene_removeAnimationClearedCallback(api.Session, id);
			m_AnimationClearedCallbacks.Remove(id);
		}

		private delegate void AnimationRemovedDelegate_c(IntPtr userData, System.UInt32 animation);
		private static Dictionary<uint, AnimationRemovedDelegate_c> m_AnimationRemovedCallbacks = new Dictionary<uint, AnimationRemovedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_addAnimationRemovedCallback(IntPtr _pxz_session_, AnimationRemovedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_removeAnimationRemovedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void AnimationRemovedDelegate(IntPtr userData, System.UInt32 animation);

		public System.UInt32 AddAnimationRemovedCallback(AnimationRemovedDelegate callback, IntPtr userData) {
			AnimationRemovedDelegate_c c = new AnimationRemovedDelegate_c((System.IntPtr _pxz_session_, System.UInt32 animation) =>
			{
				var animation_cs = (System.UInt32)(animation);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, animation_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Scene_addAnimationRemovedCallback(api.Session, c, userData);
			m_AnimationRemovedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveAnimationRemovedCallback(System.UInt32 id) {
			Scene_removeAnimationRemovedCallback(api.Session, id);
			m_AnimationRemovedCallbacks.Remove(id);
		}

		#endregion

		#region debug

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetBRepInfosReturn_c Scene_getBRepInfos(IntPtr _pxz_session_);

		/// <summary>
		/// Get BRep info
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Scene.GetBRepInfosReturn GetBRepInfos() {
			try {
				var ret = Scene_getBRepInfos(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				Scene.GetBRepInfosReturn retStruct = new Scene.GetBRepInfosReturn();
				retStruct.partCount = (System.Int32)ret.partCount;
				retStruct.totalPartCount = (System.Int32)ret.totalPartCount;
				retStruct.vertexCount = (System.Int32)ret.vertexCount;
				retStruct.totalVertexCount = (System.Int32)ret.totalVertexCount;
				retStruct.edgeCount = (System.Int32)ret.edgeCount;
				retStruct.totalEdgeCount = (System.Int32)ret.totalEdgeCount;
				retStruct.openShellCount = (System.Int32)ret.openShellCount;
				retStruct.totalOpenShellCount = (System.Int32)ret.totalOpenShellCount;
				retStruct.bodyCount = (System.Int32)ret.bodyCount;
				retStruct.totalBodyCount = (System.Int32)ret.totalBodyCount;
				retStruct.area2Dsum = (System.Double)ret.area2Dsum;
				retStruct.boundaryCount = (System.Int32)ret.boundaryCount;
				retStruct.boundaryEdgeCount = (System.Int32)ret.boundaryEdgeCount;
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetTessellationInfosReturn_c Scene_getTessellationInfos(IntPtr _pxz_session_, System.UInt32 root);

		/// <summary>
		/// Get tessellation info
		/// </summary>
		/// <param name="root">Occurrence tree root</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Scene.GetTessellationInfosReturn GetTessellationInfos(System.UInt32 root = 0) {
			try {
				var ret = Scene_getTessellationInfos(api.Session, root);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				Scene.GetTessellationInfosReturn retStruct = new Scene.GetTessellationInfosReturn();
				retStruct.partCount = (System.Int32)ret.partCount;
				retStruct.totalPartCount = (System.Int32)ret.totalPartCount;
				retStruct.vertexCount = (System.Int32)ret.vertexCount;
				retStruct.totalVertexCount = (System.Int32)ret.totalVertexCount;
				retStruct.edgeCount = (System.Int32)ret.edgeCount;
				retStruct.totalEdgeCount = (System.Int32)ret.totalEdgeCount;
				retStruct.polygonCount = (System.Int32)ret.polygonCount;
				retStruct.totalPolygonCount = (System.Int32)ret.totalPolygonCount;
				retStruct.patchCount = (System.Int32)ret.patchCount;
				retStruct.totalPatchCount = (System.Int32)ret.totalPatchCount;
				retStruct.boundaryCount = (System.Int32)ret.boundaryCount;
				retStruct.boundaryEdgeCount = (System.Int32)ret.boundaryEdgeCount;
				retStruct.nonManifoldEdgeCount = (System.Int32)ret.nonManifoldEdgeCount;
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetTessellationParametersReturn_c Scene_getTessellationParameters(IntPtr _pxz_session_, System.UInt32 part);

		/// <summary>
		/// Get tessellation parameters
		/// </summary>
		/// <param name="part">The tessellated part</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Scene.GetTessellationParametersReturn GetTessellationParameters(System.UInt32 part) {
			try {
				var ret = Scene_getTessellationParameters(api.Session, part);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				Scene.GetTessellationParametersReturn retStruct = new Scene.GetTessellationParametersReturn();
				retStruct.maxSag = (System.Double)ret.maxSag;
				retStruct.maxLength = (System.Double)ret.maxLength;
				retStruct.maxAngle = (System.Double)ret.maxAngle;
				retStruct.createNormals = (0 != ret.createNormals);
				retStruct.uvGenerationMode = (UVGenerationMode)ret.uvGenerationMode;
				retStruct.uvChannel = (System.Int32)ret.uvChannel;
				retStruct.uvPadding = (System.Double)ret.uvPadding;
				retStruct.createTangents = (0 != ret.createTangents);
				retStruct.createFreeEdges = (0 != ret.createFreeEdges);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_print(IntPtr _pxz_session_, System.UInt32 root);

		/// <summary>
		/// Print an occurrence tree on log
		/// </summary>
		/// <param name="root">Occurrence tree root</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void Print(System.UInt32 root = 0) {
			try {
				Scene_print(api.Session, root);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region filters

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_addFilterToLibrary(IntPtr _pxz_session_, string name, string expr);

		/// <summary>
		/// Add a filter to the filters library
		/// </summary>
		/// <param name="name">Name of the filter</param>
		/// <param name="expr">The filter expression</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 AddFilterToLibrary(System.String name, System.String expr) {
			try {
				var ret = Scene_addFilterToLibrary(api.Session, name, expr);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern IntPtr Scene_evaluateExpression(IntPtr _pxz_session_, string filter);

		/// <summary>
		/// Evaluate the given filter expression
		/// </summary>
		/// <param name="filter">The filter expression</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String EvaluateExpression(System.String filter) {
			try {
				var ret = Scene_evaluateExpression(api.Session, filter);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern Core.StringList_c Scene_evaluateExpressionOnOccurrences(IntPtr _pxz_session_, OccurrenceList_c occurrences, string filter);

		/// <summary>
		/// evaluate the given filter expression on all occurrences under the given occurrence and returns the result
		/// </summary>
		/// <param name="occurrences">Occurrences on which to evaluate the expression</param>
		/// <param name="filter">The filter expression</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Core.StringList EvaluateExpressionOnOccurrences(OccurrenceList occurrences, System.String filter) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var ret = Scene_evaluateExpressionOnOccurrences(api.Session, occurrences_c, filter);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Core.CoreInterface.ConvertValue(ref ret);
				Core.CoreInterface.Core_StringList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern EvaluateExpressionOnSubTreeReturn_c Scene_evaluateExpressionOnSubTree(IntPtr _pxz_session_, string filter, System.UInt32 fromOcc);

		/// <summary>
		/// evaluate the given filter expression on all occurrences under the given occurrence and returns the result
		/// </summary>
		/// <param name="filter">The filter expression</param>
		/// <param name="fromOcc">Source occurrence of the recursion</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Scene.EvaluateExpressionOnSubTreeReturn EvaluateExpressionOnSubTree(System.String filter, System.UInt32 fromOcc = 0) {
			try {
				var ret = Scene_evaluateExpressionOnSubTree(api.Session, filter, fromOcc);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				Scene.EvaluateExpressionOnSubTreeReturn retStruct = new Scene.EvaluateExpressionOnSubTreeReturn();
				retStruct.occurrences = ConvertValue(ref ret.occurrences);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret.occurrences);
				retStruct.evaluations = ConvertValue(ref ret.evaluations);
				Core.CoreInterface.Core_StringList_free(ref ret.evaluations);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_exportFilterLibrary(IntPtr _pxz_session_, string file);

		/// <summary>
		/// Export filters from a given file
		/// </summary>
		/// <param name="file">File path to export</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ExportFilterLibrary(System.String file) {
			try {
				Scene_exportFilterLibrary(api.Session, file);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Filter_c Scene_findFilterByName(IntPtr _pxz_session_, string name);

		/// <summary>
		/// Returns the first filter in the filter library with the given name
		/// </summary>
		/// <param name="name">Name of the filter to retrieve (case sensitive)</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Filter FindFilterByName(System.String name) {
			try {
				var ret = Scene_findFilterByName(api.Session, name);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_Filter_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Scene_getFilterExpression(IntPtr _pxz_session_, System.UInt32 filterId);

		/// <summary>
		/// Returns the filter expression (string) from a filter id stored in the library
		/// </summary>
		/// <param name="filterId">Identifier of the filter to fetch</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String GetFilterExpression(System.UInt32 filterId) {
			try {
				var ret = Scene_getFilterExpression(api.Session, filterId);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern Filter_c Scene_getFilterFromLibrary(IntPtr _pxz_session_, System.UInt32 filterId);

		/// <summary>
		/// Retrieve a filter from the library with its identifier
		/// </summary>
		/// <param name="filterId">Identifier of the filter to retrieve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Filter GetFilterFromLibrary(System.UInt32 filterId) {
			try {
				var ret = Scene_getFilterFromLibrary(api.Session, filterId);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_Filter_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_getFilteredOccurrences(IntPtr _pxz_session_, string filter, System.UInt32 fromOcc);

		/// <summary>
		/// Recursively get all the occurrences validating the given filter expression
		/// </summary>
		/// <param name="filter">The filter expression</param>
		/// <param name="fromOcc">Source occurrence of the recursion</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList GetFilteredOccurrences(System.String filter, System.UInt32 fromOcc = 0) {
			try {
				var ret = Scene_getFilteredOccurrences(api.Session, filter, fromOcc);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_importFilterLibrary(IntPtr _pxz_session_, string file);

		/// <summary>
		/// Import filters from a given file
		/// </summary>
		/// <param name="file">File containing the filter library</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ImportFilterLibrary(System.String file) {
			try {
				Scene_importFilterLibrary(api.Session, file);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern FilterList_c Scene_listFilterLibrary(IntPtr _pxz_session_);

		/// <summary>
		/// Returns all the filter stored in the filter library
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public FilterList ListFilterLibrary() {
			try {
				var ret = Scene_listFilterLibrary(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_FilterList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_removeFilterFromLibrary(IntPtr _pxz_session_, System.UInt32 filterId);

		/// <summary>
		/// Remove a filter from the filters library
		/// </summary>
		/// <param name="filterId">Identifier of the filter to remove</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void RemoveFilterFromLibrary(System.UInt32 filterId) {
			try {
				Scene_removeFilterFromLibrary(api.Session, filterId);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region isolate

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_isolate(IntPtr _pxz_session_, OccurrenceList_c occurrences);

		/// <summary>
		/// Enter isolate mode by isolating a subset of the scene for process, export, viewer, ...
		/// </summary>
		/// <param name="occurrences">Occurrences to isolate</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void Isolate(OccurrenceList occurrences) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				Scene_isolate(api.Session, occurrences_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_unisolate(IntPtr _pxz_session_);

		/// <summary>
		/// Exit the isolate mode
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void Unisolate() {
			try {
				Scene_unisolate(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region merging

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_findPartOccurrencesWithUnstitchedOpenShells(IntPtr _pxz_session_, System.UInt32 root);

		/// <summary>
		/// Find Part occurrences containing multiple unstitched openShell entities
		/// </summary>
		/// <param name="root">Root occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList FindPartOccurrencesWithUnstitchedOpenShells(System.UInt32 root) {
			try {
				var ret = Scene_findPartOccurrencesWithUnstitchedOpenShells(api.Session, root);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_mergeOccurrencesByTreeLevel(IntPtr _pxz_session_, OccurrenceList_c roots, Int32 maxLevel, Int32 mergeHiddenPartsMode);

		/// <summary>
		/// Merge all parts over maxLevel level
		/// </summary>
		/// <param name="roots">Roots occurrences for the process</param>
		/// <param name="maxLevel">Maximum tree level</param>
		/// <param name="mergeHiddenPartsMode">Hidden parts handling mode, Destroy them, make visible or merge separately</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void MergeOccurrencesByTreeLevel(OccurrenceList roots, System.Int32 maxLevel, MergeHiddenPartsMode mergeHiddenPartsMode = (Scene.MergeHiddenPartsMode)2) {
			try {
				var roots_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)roots, ref roots_c);
				Scene_mergeOccurrencesByTreeLevel(api.Session, roots_c, maxLevel, (int)mergeHiddenPartsMode);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref roots_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_mergePartOccurrences(IntPtr _pxz_session_, OccurrenceList_c partOccurrences, Int32 mergeHiddenPartsMode);

		/// <summary>
		/// Merge a set of parts
		/// </summary>
		/// <param name="partOccurrences">Occurrence of the parts to merge</param>
		/// <param name="mergeHiddenPartsMode">Hidden parts handling mode, Destroy them, make visible or merge separately</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList MergePartOccurrences(OccurrenceList partOccurrences, MergeHiddenPartsMode mergeHiddenPartsMode = (Scene.MergeHiddenPartsMode)2) {
			try {
				var partOccurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)partOccurrences, ref partOccurrences_c);
				var ret = Scene_mergePartOccurrences(api.Session, partOccurrences_c, (int)mergeHiddenPartsMode);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref partOccurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_mergePartOccurrencesByAssemblies(IntPtr _pxz_session_, OccurrenceList_c roots, Int32 mergeHiddenPartsMode);

		/// <summary>
		/// Merge all parts under each assembly together
		/// </summary>
		/// <param name="roots">Roots occurrences for the process (will not be removed)</param>
		/// <param name="mergeHiddenPartsMode">Hidden parts handling mode, Destroy them, make visible or merge separately</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void MergePartOccurrencesByAssemblies(OccurrenceList roots = null, MergeHiddenPartsMode mergeHiddenPartsMode = (Scene.MergeHiddenPartsMode)2) {
			roots = roots ?? new Scene.OccurrenceList(new System.UInt32[] {});
			try {
				var roots_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)roots, ref roots_c);
				Scene_mergePartOccurrencesByAssemblies(api.Session, roots_c, (int)mergeHiddenPartsMode);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref roots_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_mergePartOccurrencesByFinalAssemblies(IntPtr _pxz_session_, OccurrenceList_c roots, Int32 mergeHiddenPartsMode, System.Byte CollapseToParent);

		/// <summary>
		/// Merge final level (occurrences with only occurrence with part component as children)
		/// </summary>
		/// <param name="roots">Roots occurrences for the process (will not be removed)</param>
		/// <param name="mergeHiddenPartsMode">Hidden parts handling mode, Destroy them, make visible or merge separately</param>
		/// <param name="CollapseToParent">If true, final level unique merged part will replace it's parent</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void MergePartOccurrencesByFinalAssemblies(OccurrenceList roots = null, MergeHiddenPartsMode mergeHiddenPartsMode = (Scene.MergeHiddenPartsMode)0, System.Boolean CollapseToParent = true) {
			roots = roots ?? new Scene.OccurrenceList(new System.UInt32[] {});
			try {
				var roots_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)roots, ref roots_c);
				Scene_mergePartOccurrencesByFinalAssemblies(api.Session, roots_c, (int)mergeHiddenPartsMode, Convert.ToByte(CollapseToParent));
				Scene.SceneInterface.Scene_OccurrenceList_free(ref roots_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_mergePartOccurrencesByMaterials(IntPtr _pxz_session_, OccurrenceList_c partOccurrences, System.Byte mergeNoMaterials, Int32 mergeHiddenPartsMode, System.Byte combineMeshes);

		/// <summary>
		/// Merge a set of parts by materials
		/// </summary>
		/// <param name="partOccurrences">Occurrence of the parts to merge</param>
		/// <param name="mergeNoMaterials">If true, merge all parts with no active material together, else do not merge them</param>
		/// <param name="mergeHiddenPartsMode">Hidden parts handling mode, Destroy them, make visible or merge separately</param>
		/// <param name="combineMeshes">If true, explode and remerge the input parts by visible materials</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList MergePartOccurrencesByMaterials(OccurrenceList partOccurrences, System.Boolean mergeNoMaterials = true, MergeHiddenPartsMode mergeHiddenPartsMode = (Scene.MergeHiddenPartsMode)2, System.Boolean combineMeshes = true) {
			try {
				var partOccurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)partOccurrences, ref partOccurrences_c);
				var ret = Scene_mergePartOccurrencesByMaterials(api.Session, partOccurrences_c, Convert.ToByte(mergeNoMaterials), (int)mergeHiddenPartsMode, Convert.ToByte(combineMeshes));
				Scene.SceneInterface.Scene_OccurrenceList_free(ref partOccurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_mergePartOccurrencesByName(IntPtr _pxz_session_, System.UInt32 root, Int32 mergeHiddenPartsMode);

		/// <summary>
		/// Merge all parts by occurrences names
		/// </summary>
		/// <param name="root">Root occurrence of the subtree to process</param>
		/// <param name="mergeHiddenPartsMode">Hidden parts handling mode, Destroy them, make visible or merge separately</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void MergePartOccurrencesByName(System.UInt32 root = 0, MergeHiddenPartsMode mergeHiddenPartsMode = (Scene.MergeHiddenPartsMode)2) {
			try {
				Scene_mergePartOccurrencesByName(api.Session, root, (int)mergeHiddenPartsMode);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_mergePartOccurrencesByRegions(IntPtr _pxz_session_, OccurrenceList_c roots, MergeByRegionsStrategy_c mergeBy, Int32 strategy);

		/// <summary>
		/// Merge all parts within the same area.
		/// </summary>
		/// <param name="roots">Roots occurrences for the process (will not be removed)</param>
		/// <param name="mergeBy">Number: number of output parts (or regions of parts)\nSize: diagonal size of output regions</param>
		/// <param name="strategy">Choose the regions merging strategy</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList MergePartOccurrencesByRegions(OccurrenceList roots, MergeByRegionsStrategy mergeBy, MergeStrategy strategy) {
			try {
				var roots_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)roots, ref roots_c);
				var mergeBy_c = new Scene.MergeByRegionsStrategy_c();
				ConvertValue((Scene.MergeByRegionsStrategy)mergeBy, ref mergeBy_c);
				var ret = Scene_mergePartOccurrencesByRegions(api.Session, roots_c, mergeBy_c, (int)strategy);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref roots_c);
				Scene.SceneInterface.Scene_MergeByRegionsStrategy_free(ref mergeBy_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_mergePartOccurrencesWithSingleOpenShellByAssemblies(IntPtr _pxz_session_, System.UInt32 root);

		/// <summary>
		/// Merge Part occurrences containing a single openShell entity, by assemblies
		/// </summary>
		/// <param name="root">Root of the main assembly to merge</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList MergePartOccurrencesWithSingleOpenShellByAssemblies(System.UInt32 root) {
			try {
				var ret = Scene_mergePartOccurrencesWithSingleOpenShellByAssemblies(api.Session, root);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region modification

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_applyTransformation(IntPtr _pxz_session_, System.UInt32 occurrence, Geom.Matrix4_c matrix);

		/// <summary>
		/// apply a transformation to the local matrix of an occurrence
		/// </summary>
		/// <param name="occurrence">Occurrence to apply the matrix on</param>
		/// <param name="matrix">Transformation to matrix</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ApplyTransformation(System.UInt32 occurrence, Geom.Matrix4 matrix) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				Scene_applyTransformation(api.Session, occurrence, matrix_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_createSymmetry(IntPtr _pxz_session_, OccurrenceList_c occurrences, Int32 plane);

		/// <summary>
		/// Create symmetries from selection
		/// </summary>
		/// <param name="occurrences">Selection of occurrences</param>
		/// <param name="plane">Symmetry plane</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void CreateSymmetry(OccurrenceList occurrences, Geom.AxisPlane plane) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				Scene_createSymmetry(api.Session, occurrences_c, (int)plane);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_rotate(IntPtr _pxz_session_, System.UInt32 occurrence, Geom.Point3_c axis, System.Double angle);

		/// <summary>
		/// Modify the local matrix of the scene node to apply a rotation
		/// </summary>
		/// <param name="occurrence">Occurrence to rotate</param>
		/// <param name="axis">Axis of rotation</param>
		/// <param name="angle">Angle of rotation</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void Rotate(System.UInt32 occurrence, Geom.Point3 axis, System.Double angle) {
			try {
				var axis_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)axis, ref axis_c);
				Scene_rotate(api.Session, occurrence, axis_c, angle);
				Geom.GeomInterface.Geom_Point3_free(ref axis_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setLocalMatrices(IntPtr _pxz_session_, OccurrenceList_c occurrencesIds, Geom.Matrix4List_c matrices, System.UInt32 batchSize);

		/// <summary>
		/// change the local matrices on a list of occurrences
		/// </summary>
		/// <param name="occurrencesIds">List of occurrences on which to set the local matrices</param>
		/// <param name="matrices">The occurrences' new local matrices</param>
		/// <param name="batchSize">Number of matrices to be set per thread.</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetLocalMatrices(OccurrenceList occurrencesIds, Geom.Matrix4List matrices, System.UInt32 batchSize) {
			try {
				var occurrencesIds_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrencesIds, ref occurrencesIds_c);
				var matrices_c = new Geom.Matrix4List_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4List)matrices, ref matrices_c);
				Scene_setLocalMatrices(api.Session, occurrencesIds_c, matrices_c, batchSize);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrencesIds_c);
				Geom.GeomInterface.Geom_Matrix4List_free(ref matrices_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setLocalMatrix(IntPtr _pxz_session_, System.UInt32 occurrence, Geom.Matrix4_c matrix);

		/// <summary>
		/// change the local matrix on an occurrence
		/// </summary>
		/// <param name="occurrence">Occurrence to set the local matrix</param>
		/// <param name="matrix">The new occurrence local matrix</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetLocalMatrix(System.UInt32 occurrence, Geom.Matrix4 matrix) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				Scene_setLocalMatrix(api.Session, occurrence, matrix_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region part

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_getPartMesh(IntPtr _pxz_session_, System.UInt32 part);

		/// <summary>
		/// Return the mesh of the TesselatedShape
		/// </summary>
		/// <param name="part">The part component</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetPartMesh(System.UInt32 part) {
			try {
				var ret = Scene_getPartMesh(api.Session, part);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_getPartModel(IntPtr _pxz_session_, System.UInt32 part);

		/// <summary>
		/// Return the model of the BRepShape
		/// </summary>
		/// <param name="part">The part component</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetPartModel(System.UInt32 part) {
			try {
				var ret = Scene_getPartModel(api.Session, part);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern Polygonal.MeshList_c Scene_getPartsMeshes(IntPtr _pxz_session_, PartList_c parts);

		/// <summary>
		/// Return the meshes of the TesselatedShape for each given parts if any
		/// </summary>
		/// <param name="parts">The list of part component</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Polygonal.MeshList GetPartsMeshes(PartList parts) {
			try {
				var parts_c = new Scene.PartList_c();
				ConvertValue((Scene.PartList)parts, ref parts_c);
				var ret = Scene_getPartsMeshes(api.Session, parts_c);
				Scene.SceneInterface.Scene_PartList_free(ref parts_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Polygonal.PolygonalInterface.ConvertValue(ref ret);
				Polygonal.PolygonalInterface.Polygonal_MeshList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern CAD.ModelList_c Scene_getPartsModels(IntPtr _pxz_session_, PartList_c parts);

		/// <summary>
		/// Return the models of the BRepShape for each given parts if any
		/// </summary>
		/// <param name="parts">The list of part component</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.ModelList GetPartsModels(PartList parts) {
			try {
				var parts_c = new Scene.PartList_c();
				ConvertValue((Scene.PartList)parts, ref parts_c);
				var ret = Scene_getPartsModels(api.Session, parts_c);
				Scene.SceneInterface.Scene_PartList_free(ref parts_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = CAD.CADInterface.ConvertValue(ref ret);
				CAD.CADInterface.CAD_ModelList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Geom.Matrix4List_c Scene_getPartsTransforms(IntPtr _pxz_session_, PartList_c parts);

		/// <summary>
		/// Returns the transform matrix of each given parts
		/// </summary>
		/// <param name="parts">The parts to retrieve transform</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.Matrix4List GetPartsTransforms(PartList parts) {
			try {
				var parts_c = new Scene.PartList_c();
				ConvertValue((Scene.PartList)parts, ref parts_c);
				var ret = Scene_getPartsTransforms(api.Session, parts_c);
				Scene.SceneInterface.Scene_PartList_free(ref parts_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Geom.GeomInterface.ConvertValue(ref ret);
				Geom.GeomInterface.Geom_Matrix4List_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetPartsTransformsIndexedReturn_c Scene_getPartsTransformsIndexed(IntPtr _pxz_session_, PartList_c parts);

		/// <summary>
		/// Returns the transform matrix of each given parts (indexed mode)
		/// </summary>
		/// <param name="parts">The parts to retrieve transform</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Scene.GetPartsTransformsIndexedReturn GetPartsTransformsIndexed(PartList parts) {
			try {
				var parts_c = new Scene.PartList_c();
				ConvertValue((Scene.PartList)parts, ref parts_c);
				var ret = Scene_getPartsTransformsIndexed(api.Session, parts_c);
				Scene.SceneInterface.Scene_PartList_free(ref parts_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				Scene.GetPartsTransformsIndexedReturn retStruct = new Scene.GetPartsTransformsIndexedReturn();
				retStruct.indices = ConvertValue(ref ret.indices);
				Core.CoreInterface.Core_IntList_free(ref ret.indices);
				retStruct.transforms = ConvertValue(ref ret.transforms);
				Geom.GeomInterface.Geom_Matrix4List_free(ref ret.transforms);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setPartMesh(IntPtr _pxz_session_, System.UInt32 part, System.UInt32 mesh);

		/// <summary>
		/// Add a mesh to a part (create a TessellatedShape on the part)
		/// </summary>
		/// <param name="part">The part component</param>
		/// <param name="mesh">The mesh to add to the part</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetPartMesh(System.UInt32 part, System.UInt32 mesh) {
			try {
				Scene_setPartMesh(api.Session, part, mesh);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setPartModel(IntPtr _pxz_session_, System.UInt32 part, System.UInt32 model);

		/// <summary>
		/// Add a model to a part (create a BRepShape on the part)
		/// </summary>
		/// <param name="part">The part component</param>
		/// <param name="model">The model to add to the part</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetPartModel(System.UInt32 part, System.UInt32 model) {
			try {
				Scene_setPartModel(api.Session, part, model);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setPartsTransforms(IntPtr _pxz_session_, PartList_c parts, Geom.Matrix4List_c transforms);

		/// <summary>
		/// Set the transform matrix of each given parts
		/// </summary>
		/// <param name="parts">The parts to retrieve transform</param>
		/// <param name="transforms">The transform matrix of each part</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetPartsTransforms(PartList parts, Geom.Matrix4List transforms) {
			try {
				var parts_c = new Scene.PartList_c();
				ConvertValue((Scene.PartList)parts, ref parts_c);
				var transforms_c = new Geom.Matrix4List_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4List)transforms, ref transforms_c);
				Scene_setPartsTransforms(api.Session, parts_c, transforms_c);
				Scene.SceneInterface.Scene_PartList_free(ref parts_c);
				Geom.GeomInterface.Geom_Matrix4List_free(ref transforms_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setPartsTransformsIndexed(IntPtr _pxz_session_, PartList_c parts, Core.IntList_c indices, Geom.Matrix4List_c transforms);

		/// <summary>
		/// Set the transform matrix of each given parts (indexed mode)
		/// </summary>
		/// <param name="parts">The parts to retrieve transform</param>
		/// <param name="indices">The transform matrix index for each parts</param>
		/// <param name="transforms">The list of transform matrices</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetPartsTransformsIndexed(PartList parts, Core.IntList indices, Geom.Matrix4List transforms) {
			try {
				var parts_c = new Scene.PartList_c();
				ConvertValue((Scene.PartList)parts, ref parts_c);
				var indices_c = new Core.IntList_c();
				Core.CoreInterface.ConvertValue((Core.IntList)indices, ref indices_c);
				var transforms_c = new Geom.Matrix4List_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4List)transforms, ref transforms_c);
				Scene_setPartsTransformsIndexed(api.Session, parts_c, indices_c, transforms_c);
				Scene.SceneInterface.Scene_PartList_free(ref parts_c);
				Core.CoreInterface.Core_IntList_free(ref indices_c);
				Geom.GeomInterface.Geom_Matrix4List_free(ref transforms_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region partialLoading

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Int32 Scene_getPartialLoadingStatus(IntPtr _pxz_session_, System.UInt32 component);

		/// <summary>
		/// Get the current status of a partial loading component
		/// </summary>
		/// <param name="component">Referenced Data component</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public PartialLoad_Status GetPartialLoadingStatus(System.UInt32 component) {
			try {
				var ret = Scene_getPartialLoadingStatus(api.Session, component);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (PartialLoad_Status)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setReferencedDataComponentParent(IntPtr _pxz_session_, System.UInt32 component, System.UInt32 parent);

		/// <summary>
		/// Defines which referenced data is parent to the given component
		/// </summary>
		/// <param name="component">The referenced data component to alter</param>
		/// <param name="parent">The parent</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetReferencedDataComponentParent(System.UInt32 component, System.UInt32 parent) {
			try {
				Scene_setReferencedDataComponentParent(api.Session, component, parent);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setReferencedDataComponentPath(IntPtr _pxz_session_, System.UInt32 component, string filePath);

		/// <summary>
		/// Defines which path the referenced data is at
		/// </summary>
		/// <param name="component">The referenced data component to alter</param>
		/// <param name="filePath">The filepath</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetReferencedDataComponentPath(System.UInt32 component, System.String filePath) {
			try {
				Scene_setReferencedDataComponentPath(api.Session, component, filePath);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region pivots

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_alignPivotPointToWorld(IntPtr _pxz_session_, OccurrenceList_c occurrences, System.Byte applyToChildren);

		/// <summary>
		/// Re-orient the Pivot Point straight to world origin (the grid)
		/// </summary>
		/// <param name="occurrences">The occurrences to modify</param>
		/// <param name="applyToChildren">If True, all the pivot of the descending occurrences from occurrence will be affected</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AlignPivotPointToWorld(OccurrenceList occurrences, System.Boolean applyToChildren) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				Scene_alignPivotPointToWorld(api.Session, occurrences_c, Convert.ToByte(applyToChildren));
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_movePivotPointToOccurrenceCenter(IntPtr _pxz_session_, OccurrenceList_c occurrences, System.Byte applyToChildren);

		/// <summary>
		/// Move the pivot point of each occurrence listed in the function input, to the center of its bounding box (and of its children if the parameter is True)
		/// </summary>
		/// <param name="occurrences">Occurrences (or the roots occurrences if recursively=True)</param>
		/// <param name="applyToChildren">If True, all the pivot of the descending occurrences from occurrence will be affected</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void MovePivotPointToOccurrenceCenter(OccurrenceList occurrences, System.Boolean applyToChildren) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				Scene_movePivotPointToOccurrenceCenter(api.Session, occurrences_c, Convert.ToByte(applyToChildren));
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_movePivotPointToOrigin(IntPtr _pxz_session_, System.UInt32 occurrence, System.Byte applyToChildren);

		/// <summary>
		/// Move the pivot point of an occurrence (and its descendants if recursively) to the origin (0,0,0)
		/// </summary>
		/// <param name="occurrence">The occurrence (or the root occurrence if recursively=True)</param>
		/// <param name="applyToChildren">If True, all the pivot of the descending occurrences from occurrence will be affected</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void MovePivotPointToOrigin(System.UInt32 occurrence, System.Boolean applyToChildren) {
			try {
				Scene_movePivotPointToOrigin(api.Session, occurrence, Convert.ToByte(applyToChildren));
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_movePivotPointToSelectionCenter(IntPtr _pxz_session_, OccurrenceList_c occurrences);

		/// <summary>
		/// Move the pivot point of all given occurrences to the center of all occurrences
		/// </summary>
		/// <param name="occurrences">The occurrences to modify</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void MovePivotPointToSelectionCenter(OccurrenceList occurrences) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				Scene_movePivotPointToSelectionCenter(api.Session, occurrences_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_movePivotPointToTargetedOccurrenceCenter(IntPtr _pxz_session_, OccurrenceList_c occurrences, System.UInt32 target, System.Byte applyToChildren);

		/// <summary>
		/// Move the pivot point of each occurrence listed in the function input, to the center of the targeted occurrence Center (and of its children if the parameter is True)
		/// </summary>
		/// <param name="occurrences">The occurrence (or the root occurrence if recursively=True)</param>
		/// <param name="target">The target occurrence</param>
		/// <param name="applyToChildren">If True, all the pivot of the descending occurrences from occurrence will be affected</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void MovePivotPointToTargetedOccurrenceCenter(OccurrenceList occurrences, System.UInt32 target, System.Boolean applyToChildren) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				Scene_movePivotPointToTargetedOccurrenceCenter(api.Session, occurrences_c, target, Convert.ToByte(applyToChildren));
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setPivotOnly(IntPtr _pxz_session_, System.UInt32 occurrence, Geom.Matrix4_c pivot);

		/// <summary>
		/// Set the pivot of an occurrence to the given transformation matrix, the geometry will not be moved (warning: do not confuse with property Transform which actually move the occurrence)
		/// </summary>
		/// <param name="occurrence">The occurrence to move the pivot</param>
		/// <param name="pivot">The new transformation matrix for the occurrence (pivot)</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetPivotOnly(System.UInt32 occurrence, Geom.Matrix4 pivot) {
			try {
				var pivot_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)pivot, ref pivot_c);
				Scene_setPivotOnly(api.Session, occurrence, pivot_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref pivot_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region pmi

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_addAnnotationGroup(IntPtr _pxz_session_, System.UInt32 component, string name);

		/// <summary>
		/// add a Annotation Group to the pmi component
		/// </summary>
		/// <param name="component">Component to add the Annotation Group</param>
		/// <param name="name">Name of the annotation group</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 AddAnnotationGroup(System.UInt32 component, System.String name) {
			try {
				var ret = Scene_addAnnotationGroup(api.Session, component, name);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern void Scene_addMeshToAnnotation(IntPtr _pxz_session_, System.UInt32 annotation, System.UInt32 material, System.UInt32 staticmesh);

		/// <summary>
		/// add a mesh and its material to a annotation
		/// </summary>
		/// <param name="annotation"></param>
		/// <param name="material"></param>
		/// <param name="staticmesh"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AddMeshToAnnotation(System.UInt32 annotation, System.UInt32 material, System.UInt32 staticmesh) {
			try {
				Scene_addMeshToAnnotation(api.Session, annotation, material, staticmesh);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_convertPMIToOccurrences(IntPtr _pxz_session_, OccurrenceList_c occurrences, System.Byte convertVisibility);

		/// <summary>
		/// Convert each PMI component into a set of occurrences with mesh geometries
		/// </summary>
		/// <param name="occurrences">Occurrence selection</param>
		/// <param name="convertVisibility">If True, the visibility will be converted (useful to select a specific view/variant), else all occurrences will be visible</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ConvertPMIToOccurrences(OccurrenceList occurrences, System.Boolean convertVisibility = false) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				Scene_convertPMIToOccurrences(api.Session, occurrences_c, Convert.ToByte(convertVisibility));
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_createAnnotationFromDefinition(IntPtr _pxz_session_, AnnotationDefinition_c definition);

		/// <summary>
		/// Create Annotation from definition
		/// </summary>
		/// <param name="definition">Annotation definition</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateAnnotationFromDefinition(AnnotationDefinition definition) {
			try {
				var definition_c = new Scene.AnnotationDefinition_c();
				ConvertValue((Scene.AnnotationDefinition)definition, ref definition_c);
				var ret = Scene_createAnnotationFromDefinition(api.Session, definition_c);
				Scene.SceneInterface.Scene_AnnotationDefinition_free(ref definition_c);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_createOccurrenceFromAnnotation(IntPtr _pxz_session_, System.UInt32 annotation, System.Byte convertVisibility);

		/// <summary>
		/// Convert a single annotation on an occurrence into an occurrence with mesh geometry
		/// </summary>
		/// <param name="annotation">Annotation that shall be converted to an occurrence with mesh geometry</param>
		/// <param name="convertVisibility">If True, the visibility will be converted (useful to select a specific view/variant), else all occurrences will be visible</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateOccurrenceFromAnnotation(System.UInt32 annotation, System.Boolean convertVisibility = false) {
			try {
				var ret = Scene_createOccurrenceFromAnnotation(api.Session, annotation, Convert.ToByte(convertVisibility));
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_createProductView(IntPtr _pxz_session_, ProductViewDefinition_c definition);

		/// <summary>
		/// Create a productview from definition
		/// </summary>
		/// <param name="definition"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateProductView(ProductViewDefinition definition) {
			try {
				var definition_c = new Scene.ProductViewDefinition_c();
				ConvertValue((Scene.ProductViewDefinition)definition, ref definition_c);
				var ret = Scene_createProductView(api.Session, definition_c);
				Scene.SceneInterface.Scene_ProductViewDefinition_free(ref definition_c);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern AnnotationDefinition_c Scene_getAnnotationDefinition(IntPtr _pxz_session_, System.UInt32 annotation);

		/// <summary>
		/// get definition of given annotation
		/// </summary>
		/// <param name="annotation"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public AnnotationDefinition GetAnnotationDefinition(System.UInt32 annotation) {
			try {
				var ret = Scene_getAnnotationDefinition(api.Session, annotation);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_AnnotationDefinition_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern AnnotationGroupList_c Scene_getAnnotationGroups(IntPtr _pxz_session_, System.UInt32 pmiComponent);

		/// <summary>
		/// Returns the list of the AnnotationGroup from a PMIComponent
		/// </summary>
		/// <param name="pmiComponent">The pmi component</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public AnnotationGroupList GetAnnotationGroups(System.UInt32 pmiComponent) {
			try {
				var ret = Scene_getAnnotationGroups(api.Session, pmiComponent);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_AnnotationGroupList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Geom.AABB_c Scene_getAnnotationListAABB(IntPtr _pxz_session_, AnnotationList_c annotationList);

		/// <summary>
		/// get the AABB of the annotation list
		/// </summary>
		/// <param name="annotationList"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.AABB GetAnnotationListAABB(AnnotationList annotationList) {
			try {
				var annotationList_c = new Scene.AnnotationList_c();
				ConvertValue((Scene.AnnotationList)annotationList, ref annotationList_c);
				var ret = Scene_getAnnotationListAABB(api.Session, annotationList_c);
				Scene.SceneInterface.Scene_AnnotationList_free(ref annotationList_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Geom.GeomInterface.ConvertValue(ref ret);
				Geom.GeomInterface.Geom_AABB_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern AnnotationList_c Scene_getAnnotations(IntPtr _pxz_session_, System.UInt32 group);

		/// <summary>
		/// Returns the list of the Annotation from a AnnotationGroup
		/// </summary>
		/// <param name="group">The AnnotationGroup</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public AnnotationList GetAnnotations(System.UInt32 group) {
			try {
				var ret = Scene_getAnnotations(api.Session, group);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_AnnotationList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern AnnotationDefinitionList_c Scene_getOccurrenceAnnotationDefinitions(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// get all annotations definition of given occurrence
		/// </summary>
		/// <param name="occurrence"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public AnnotationDefinitionList GetOccurrenceAnnotationDefinitions(System.UInt32 occurrence) {
			try {
				var ret = Scene_getOccurrenceAnnotationDefinitions(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_AnnotationDefinitionList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern ProductViewDefinition_c Scene_getProductViewDefinition(IntPtr _pxz_session_, System.UInt32 view);

		/// <summary>
		/// get productview definition
		/// </summary>
		/// <param name="view">The product view</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public ProductViewDefinition GetProductViewDefinition(System.UInt32 view) {
			try {
				var ret = Scene_getProductViewDefinition(api.Session, view);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_ProductViewDefinition_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern ProductViewDefinitionList_c Scene_getProductViewDefinitions(IntPtr _pxz_session_);

		/// <summary>
		/// get all productviews definitions
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public ProductViewDefinitionList GetProductViewDefinitions() {
			try {
				var ret = Scene_getProductViewDefinitions(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_ProductViewDefinitionList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setAnnotationToGroup(IntPtr _pxz_session_, System.UInt32 annotation, System.UInt32 group);

		/// <summary>
		/// set Annotation to a Annotation Group
		/// </summary>
		/// <param name="annotation"></param>
		/// <param name="group"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetAnnotationToGroup(System.UInt32 annotation, System.UInt32 group) {
			try {
				Scene_setAnnotationToGroup(api.Session, annotation, group);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region prototype

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_cleanInstances(IntPtr _pxz_session_, System.Byte removeUselessInstances, System.Byte removeHierarchyOverridingInstances, System.UInt32 occurrence);

		/// <summary>
		/// Clean prototypes and instances (lonely instances, overriding their prototypes hierarchies...).
		/// </summary>
		/// <param name="removeUselessInstances">Remove instances where they are not needed (prototype referenced once, ...)</param>
		/// <param name="removeHierarchyOverridingInstances">Remove instances overriding their prototypes sub-hierarchies.</param>
		/// <param name="occurrence">Root occurrence for the process</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void CleanInstances(System.Boolean removeUselessInstances, System.Boolean removeHierarchyOverridingInstances, System.UInt32 occurrence = 0) {
			try {
				Scene_cleanInstances(api.Session, Convert.ToByte(removeUselessInstances), Convert.ToByte(removeHierarchyOverridingInstances), occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_getDirectInstances(IntPtr _pxz_session_, System.UInt32 prototype);

		/// <summary>
		/// Returns all the occurrences prototyping the given occurrence
		/// </summary>
		/// <param name="prototype">The prototype occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList GetDirectInstances(System.UInt32 prototype) {
			try {
				var ret = Scene_getDirectInstances(api.Session, prototype);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_getInstances(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Get occurrences sharing the same prototype as the given one
		/// </summary>
		/// <param name="occurrence">Reference part occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList GetInstances(System.UInt32 occurrence) {
			try {
				var ret = Scene_getInstances(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_getPrototype(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Returns the prototype of an occurrence
		/// </summary>
		/// <param name="occurrence">The occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetPrototype(System.UInt32 occurrence) {
			try {
				var ret = Scene_getPrototype(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern OccurrenceList_c Scene_getPrototypes(IntPtr _pxz_session_, OccurrenceList_c occurrences);

		/// <summary>
		/// Returns the prototype for each given occurrence
		/// </summary>
		/// <param name="occurrences">The occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList GetPrototypes(OccurrenceList occurrences) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var ret = Scene_getPrototypes(api.Session, occurrences_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_prototypeSubTree(IntPtr _pxz_session_, System.UInt32 prototype);

		/// <summary>
		/// Create occurrences that prototype the given occurrence and all its subtree
		/// </summary>
		/// <param name="prototype">The root occurrence of the sub-tree to prototype</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 PrototypeSubTree(System.UInt32 prototype) {
			try {
				var ret = Scene_prototypeSubTree(api.Session, prototype);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern void Scene_setPrototype(IntPtr _pxz_session_, System.UInt32 occurrence, System.UInt32 prototype);

		/// <summary>
		/// Sets the prototype of an occurrence
		/// </summary>
		/// <param name="occurrence">The occurrence</param>
		/// <param name="prototype">The prototype</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetPrototype(System.UInt32 occurrence, System.UInt32 prototype) {
			try {
				Scene_setPrototype(api.Session, occurrence, prototype);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setPrototypes(IntPtr _pxz_session_, OccurrenceList_c occurrences, OccurrenceList_c prototypes);

		/// <summary>
		/// Sets the prototype for each given occurrence
		/// </summary>
		/// <param name="occurrences">The occurrences</param>
		/// <param name="prototypes">The prototypes</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetPrototypes(OccurrenceList occurrences, OccurrenceList prototypes) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var prototypes_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)prototypes, ref prototypes_c);
				Scene_setPrototypes(api.Session, occurrences_c, prototypes_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref prototypes_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_updateChildrenPrototypes(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Update children prototypes of the given occurrence
		/// </summary>
		/// <param name="occurrence">The occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void UpdateChildrenPrototypes(System.UInt32 occurrence) {
			try {
				Scene_updateChildrenPrototypes(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region selection

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_clearSelection(IntPtr _pxz_session_);

		/// <summary>
		/// Clear the current selection
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ClearSelection() {
			try {
				Scene_clearSelection(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_deleteSelection(IntPtr _pxz_session_);

		/// <summary>
		/// Delete all selected occurrences, and/or sub-occurrence elements
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void DeleteSelection() {
			try {
				Scene_deleteSelection(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_explodeSelection(IntPtr _pxz_session_);

		/// <summary>
		/// For each occurrence, create a new occurrence with the selected sub-occurrence elements and remove them from the original occurrence
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ExplodeSelection() {
			try {
				Scene_explodeSelection(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_getSelectedOccurrences(IntPtr _pxz_session_, System.Byte keepAncestors);

		/// <summary>
		/// Returns all the selected occurrences
		/// </summary>
		/// <param name="keepAncestors">If True, occurrences with ancestors selected will be remove from the list</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList GetSelectedOccurrences(System.Boolean keepAncestors = false) {
			try {
				var ret = Scene_getSelectedOccurrences(api.Session, Convert.ToByte(keepAncestors));
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt64 Scene_getSelectedPolygonCount(IntPtr _pxz_session_);

		/// <summary>
		/// Returns the number of selected polygons
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt64 GetSelectedPolygonCount() {
			try {
				var ret = Scene_getSelectedPolygonCount(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.UInt64)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_invertOrientationSelection(IntPtr _pxz_session_);

		/// <summary>
		/// Invert the orientation of each selected item (occurrences and/or sub-occurrence elements
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void InvertOrientationSelection() {
			try {
				Scene_invertOrientationSelection(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_invertSelect(IntPtr _pxz_session_, OccurrenceList_c occurrence);

		/// <summary>
		/// Invert occurrences to selection
		/// </summary>
		/// <param name="occurrence">Occurrences to invert from the selection</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void InvertSelect(OccurrenceList occurrence) {
			try {
				var occurrence_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrence, ref occurrence_c);
				Scene_invertSelect(api.Session, occurrence_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrence_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_invertSelection(IntPtr _pxz_session_);

		/// <summary>
		/// Replace the selection by all unselected part occurrences
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void InvertSelection() {
			try {
				Scene_invertSelection(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_select(IntPtr _pxz_session_, OccurrenceList_c occurrences);

		/// <summary>
		/// Add occurrences to selection
		/// </summary>
		/// <param name="occurrences">Occurrences to add to the selection</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void Select(OccurrenceList occurrences) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				Scene_select(api.Session, occurrences_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_separateSelection(IntPtr _pxz_session_);

		/// <summary>
		/// Separate all polygons form their original parts into a new one
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 SeparateSelection() {
			try {
				var ret = Scene_separateSelection(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern void Scene_unselect(IntPtr _pxz_session_, OccurrenceList_c occurrence);

		/// <summary>
		/// Remove occurrences to selection
		/// </summary>
		/// <param name="occurrence">Occurrences to remove from the selection</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void Unselect(OccurrenceList occurrence) {
			try {
				var occurrence_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrence, ref occurrence_c);
				Scene_unselect(api.Session, occurrence_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrence_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		private delegate void SelectionChangedDelegate_c(IntPtr userData, SelectionChangeType type, OccurrenceList_c occurrences);
		private static Dictionary<uint, SelectionChangedDelegate_c> m_SelectionChangedCallbacks = new Dictionary<uint, SelectionChangedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_addSelectionChangedCallback(IntPtr _pxz_session_, SelectionChangedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_removeSelectionChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void SelectionChangedDelegate(IntPtr userData, SelectionChangeType type, OccurrenceList occurrences);

		public System.UInt32 AddSelectionChangedCallback(SelectionChangedDelegate callback, IntPtr userData) {
			SelectionChangedDelegate_c c = new SelectionChangedDelegate_c((System.IntPtr _pxz_session_, SelectionChangeType type, OccurrenceList_c occurrences) =>
			{
				var type_cs = (SelectionChangeType)type;
				var occurrences_cs = Scene.SceneInterface.ConvertValue(ref occurrences);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, type_cs, occurrences_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Scene_addSelectionChangedCallback(api.Session, c, userData);
			m_SelectionChangedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveSelectionChangedCallback(System.UInt32 id) {
			Scene_removeSelectionChangedCallback(api.Session, id);
			m_SelectionChangedCallbacks.Remove(id);
		}

		private delegate void VariantChangedDelegate_c(IntPtr userData, VariantChangeType type, System.UInt32 variant);
		private static Dictionary<uint, VariantChangedDelegate_c> m_VariantChangedCallbacks = new Dictionary<uint, VariantChangedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_addVariantChangedCallback(IntPtr _pxz_session_, VariantChangedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_removeVariantChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void VariantChangedDelegate(IntPtr userData, VariantChangeType type, System.UInt32 variant);

		public System.UInt32 AddVariantChangedCallback(VariantChangedDelegate callback, IntPtr userData) {
			VariantChangedDelegate_c c = new VariantChangedDelegate_c((System.IntPtr _pxz_session_, VariantChangeType type, System.UInt32 variant) =>
			{
				var type_cs = (VariantChangeType)type;
				var variant_cs = (System.UInt32)(variant);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, type_cs, variant_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Scene_addVariantChangedCallback(api.Session, c, userData);
			m_VariantChangedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveVariantChangedCallback(System.UInt32 id) {
			Scene_removeVariantChangedCallback(api.Session, id);
			m_VariantChangedCallbacks.Remove(id);
		}

		#endregion

		#region simplification

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_compress(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Compress a sub-tree by removing occurrence containing only one Child or empty, and by removing useless instances (see removeUselessInstances)
		/// </summary>
		/// <param name="occurrence">Root occurrence for the process</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 Compress(System.UInt32 occurrence = 0) {
			try {
				var ret = Scene_compress(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern void Scene_convertToOldSchoolVisibility(IntPtr _pxz_session_, System.UInt32 root);

		/// <summary>
		/// Modify the visible properties of the sub-tree to look like old school visibility (only hidden/inherited)
		/// </summary>
		/// <param name="root">Root occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ConvertToOldSchoolVisibility(System.UInt32 root = 0) {
			try {
				Scene_convertToOldSchoolVisibility(api.Session, root);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_getHiddenPartOccurrences(IntPtr _pxz_session_, OccurrenceList_c roots);

		/// <summary>
		/// Get hidden part occurrences
		/// </summary>
		/// <param name="roots">Roots occurrences for the process</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList GetHiddenPartOccurrences(OccurrenceList roots = null) {
			roots = roots ?? new Scene.OccurrenceList(new System.UInt32[] {});
			try {
				var roots_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)roots, ref roots_c);
				var ret = Scene_getHiddenPartOccurrences(api.Session, roots_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref roots_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceList_c Scene_getVisiblePartOccurrences(IntPtr _pxz_session_, OccurrenceList_c roots);

		/// <summary>
		/// Get visible part occurrences
		/// </summary>
		/// <param name="roots">Roots occurrences for the process</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OccurrenceList GetVisiblePartOccurrences(OccurrenceList roots = null) {
			roots = roots ?? new Scene.OccurrenceList(new System.UInt32[] {});
			try {
				var roots_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)roots, ref roots_c);
				var ret = Scene_getVisiblePartOccurrences(api.Session, roots_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref roots_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_makeInstanceUnique(IntPtr _pxz_session_, OccurrenceList_c occurrences, System.Byte keepOnlyPartInstances);

		/// <summary>
		/// Singularize all instances on the sub-tree of an occurrence
		/// </summary>
		/// <param name="occurrences">Root occurrence for the process</param>
		/// <param name="keepOnlyPartInstances">If true, instances of part will not be singularized</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void MakeInstanceUnique(OccurrenceList occurrences = null, System.Boolean keepOnlyPartInstances = false) {
			occurrences = occurrences ?? new Scene.OccurrenceList(new System.UInt32[] {});
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				Scene_makeInstanceUnique(api.Session, occurrences_c, Convert.ToByte(keepOnlyPartInstances));
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_rake(IntPtr _pxz_session_, System.UInt32 occurrence, System.Byte keepInstances);

		/// <summary>
		/// Set the same parent to all descending parts (all parts will be singularized)
		/// </summary>
		/// <param name="occurrence">Root occurrence for the process</param>
		/// <param name="keepInstances">If false, the part will be singularized</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void Rake(System.UInt32 occurrence = 0, System.Boolean keepInstances = false) {
			try {
				Scene_rake(api.Session, occurrence, Convert.ToByte(keepInstances));
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_removeSymmetryMatrices(IntPtr _pxz_session_, System.UInt32 occurrence);

		/// <summary>
		/// Remove symmetry matrices (apply matrices on geometries on nodes under an occurrence with a symmetry matrix
		/// </summary>
		/// <param name="occurrence">Root occurrence for the process</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void RemoveSymmetryMatrices(System.UInt32 occurrence = 0) {
			try {
				Scene_removeSymmetryMatrices(api.Session, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_resetPartTransform(IntPtr _pxz_session_, System.UInt32 root);

		/// <summary>
		/// Set all part transformation matrices to identity in a sub-tree, transformation will be applied to the shapes
		/// </summary>
		/// <param name="root">Root occurrence for the process</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ResetPartTransform(System.UInt32 root = 0) {
			try {
				Scene_resetPartTransform(api.Session, root);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_resetTransform(IntPtr _pxz_session_, System.UInt32 root, System.Byte recursive, System.Byte keepInstantiation, System.Byte keepPartTransform);

		/// <summary>
		/// Set all transformation matrices to identity in a sub-tree.
		/// </summary>
		/// <param name="root">Root occurrence for the process</param>
		/// <param name="recursive">If False, transformation will be applied only on the root and its components</param>
		/// <param name="keepInstantiation">If False, all occurrences will be singularized</param>
		/// <param name="keepPartTransform">If False, transformation will be applied to the shapes (BRepShape points or TessellatedShape vertices)</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ResetTransform(System.UInt32 root, System.Boolean recursive = true, System.Boolean keepInstantiation = true, System.Boolean keepPartTransform = false) {
			try {
				Scene_resetTransform(api.Session, root, Convert.ToByte(recursive), Convert.ToByte(keepInstantiation), Convert.ToByte(keepPartTransform));
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region spatialRequest

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_createRayProber(IntPtr _pxz_session_);

		/// <summary>
		/// Creates a ray prober
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateRayProber() {
			try {
				var ret = Scene_createRayProber(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_createSphereProber(IntPtr _pxz_session_);

		/// <summary>
		/// Creates a sphere prober
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateSphereProber() {
			try {
				var ret = Scene_createSphereProber(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern RayHit_c Scene_rayCast(IntPtr _pxz_session_, Geom.Ray_c ray, System.UInt32 root);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ray">The ray to cast</param>
		/// <param name="root">The root occurrence to cast from</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public RayHit RayCast(Geom.Ray ray, System.UInt32 root) {
			try {
				var ray_c = new Geom.Ray_c();
				Geom.GeomInterface.ConvertValue((Geom.Ray)ray, ref ray_c);
				var ret = Scene_rayCast(api.Session, ray_c, root);
				Geom.GeomInterface.Geom_Ray_free(ref ray_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_RayHit_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern RayHitList_c Scene_rayCastAll(IntPtr _pxz_session_, Geom.Ray_c ray, System.UInt32 root);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ray">The ray to cast</param>
		/// <param name="root">The root occurrence to cast from</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public RayHitList RayCastAll(Geom.Ray ray, System.UInt32 root) {
			try {
				var ray_c = new Geom.Ray_c();
				Geom.GeomInterface.ConvertValue((Geom.Ray)ray, ref ray_c);
				var ret = Scene_rayCastAll(api.Session, ray_c, root);
				Geom.GeomInterface.Geom_Ray_free(ref ray_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_RayHitList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_updateRayProber(IntPtr _pxz_session_, System.UInt32 proberID, Geom.Ray_c ray);

		/// <summary>
		/// Updates the designed ray prober
		/// </summary>
		/// <param name="proberID">The ray prober Id</param>
		/// <param name="ray">Update the prober's ray values</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void UpdateRayProber(System.UInt32 proberID, Geom.Ray ray) {
			try {
				var ray_c = new Geom.Ray_c();
				Geom.GeomInterface.ConvertValue((Geom.Ray)ray, ref ray_c);
				Scene_updateRayProber(api.Session, proberID, ray_c);
				Geom.GeomInterface.Geom_Ray_free(ref ray_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_updateSphereProber(IntPtr _pxz_session_, System.UInt32 proberID, Geom.Point3_c sphereCenter, System.Double sphereRadius);

		/// <summary>
		/// Updates the designed sphere prober
		/// </summary>
		/// <param name="proberID">The sphere prober Id</param>
		/// <param name="sphereCenter">The new prober center</param>
		/// <param name="sphereRadius">The new prober radius</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void UpdateSphereProber(System.UInt32 proberID, Geom.Point3 sphereCenter, System.Double sphereRadius) {
			try {
				var sphereCenter_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)sphereCenter, ref sphereCenter_c);
				Scene_updateSphereProber(api.Session, proberID, sphereCenter_c, sphereRadius);
				Geom.GeomInterface.Geom_Point3_free(ref sphereCenter_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		private delegate void onRayProbeDelegate_c(IntPtr userData, System.UInt32 proberID, ProberInfo_c proberInfo);
		private static Dictionary<uint, onRayProbeDelegate_c> m_onRayProbeCallbacks = new Dictionary<uint, onRayProbeDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_addonRayProbeCallback(IntPtr _pxz_session_, onRayProbeDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_removeonRayProbeCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void onRayProbeDelegate(IntPtr userData, System.UInt32 proberID, ProberInfo proberInfo);

		public System.UInt32 AddonRayProbeCallback(onRayProbeDelegate callback, IntPtr userData) {
			onRayProbeDelegate_c c = new onRayProbeDelegate_c((System.IntPtr _pxz_session_, System.UInt32 proberID, ProberInfo_c proberInfo) =>
			{
				var proberID_cs = (System.UInt32)(proberID);
				var proberInfo_cs = Scene.SceneInterface.ConvertValue(ref proberInfo);
				Scene.SceneInterface.Scene_ProberInfo_free(ref proberInfo);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, proberID_cs, proberInfo_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Scene_addonRayProbeCallback(api.Session, c, userData);
			m_onRayProbeCallbacks.Add(id, c);
			return id;
		}

		public void RemoveonRayProbeCallback(System.UInt32 id) {
			Scene_removeonRayProbeCallback(api.Session, id);
			m_onRayProbeCallbacks.Remove(id);
		}

		private delegate void onSphereProbeDelegate_c(IntPtr userData, System.UInt32 proberID, ProberInfo_c proberInfo);
		private static Dictionary<uint, onSphereProbeDelegate_c> m_onSphereProbeCallbacks = new Dictionary<uint, onSphereProbeDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_addonSphereProbeCallback(IntPtr _pxz_session_, onSphereProbeDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_removeonSphereProbeCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void onSphereProbeDelegate(IntPtr userData, System.UInt32 proberID, ProberInfo proberInfo);

		public System.UInt32 AddonSphereProbeCallback(onSphereProbeDelegate callback, IntPtr userData) {
			onSphereProbeDelegate_c c = new onSphereProbeDelegate_c((System.IntPtr _pxz_session_, System.UInt32 proberID, ProberInfo_c proberInfo) =>
			{
				var proberID_cs = (System.UInt32)(proberID);
				var proberInfo_cs = Scene.SceneInterface.ConvertValue(ref proberInfo);
				Scene.SceneInterface.Scene_ProberInfo_free(ref proberInfo);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, proberID_cs, proberInfo_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Scene_addonSphereProbeCallback(api.Session, c, userData);
			m_onSphereProbeCallbacks.Add(id, c);
			return id;
		}

		public void RemoveonSphereProbeCallback(System.UInt32 id) {
			Scene_removeonSphereProbeCallback(api.Session, id);
			m_onSphereProbeCallbacks.Remove(id);
		}

		#endregion

		#region userData

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.PtrList_c Scene_getMultipleOccurrenceUserData(IntPtr _pxz_session_, System.UInt32 userDataId, OccurrenceList_c occurrences);

		/// <summary>
		/// Batch version of getOccurrenceUserData
		/// </summary>
		/// <param name="userDataId">UserData identifier provided by subscribeToOccurrenceUserData</param>
		/// <param name="occurrences">Occurrences that store the user data</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Core.PtrList GetMultipleOccurrenceUserData(System.UInt32 userDataId, OccurrenceList occurrences) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var ret = Scene_getMultipleOccurrenceUserData(api.Session, userDataId, occurrences_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Core.CoreInterface.ConvertValue(ref ret);
				Core.CoreInterface.Core_PtrList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Scene_getOccurrenceUserData(IntPtr _pxz_session_, System.UInt32 userDataId, System.UInt32 occurrence);

		/// <summary>
		/// Set or replace a userdata stored on an occurrence
		/// </summary>
		/// <param name="userDataId">UserData identifier provided by subscribeToOccurrenceUserData</param>
		/// <param name="occurrence">Occurrence that store the user data</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.IntPtr GetOccurrenceUserData(System.UInt32 userDataId, System.UInt32 occurrence) {
			try {
				var ret = Scene_getOccurrenceUserData(api.Session, userDataId, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.IntPtr)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.BoolList_c Scene_hasMultipleOccurrenceUserData(IntPtr _pxz_session_, System.UInt32 userDataId, OccurrenceList_c occurrences);

		/// <summary>
		/// Batch version of hasOccurrenceUserData
		/// </summary>
		/// <param name="userDataId">UserData identifier provided by subscribeToOccurrenceUserData</param>
		/// <param name="occurrences">Occurrences that potentially store the user data</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Core.BoolList HasMultipleOccurrenceUserData(System.UInt32 userDataId, OccurrenceList occurrences) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var ret = Scene_hasMultipleOccurrenceUserData(api.Session, userDataId, occurrences_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Core.CoreInterface.ConvertValue(ref ret);
				Core.CoreInterface.Core_BoolList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Scene_hasOccurrenceUserData(IntPtr _pxz_session_, System.UInt32 userDataId, System.UInt32 occurrence);

		/// <summary>
		/// Set or replace a userdata stored on an occurrence
		/// </summary>
		/// <param name="userDataId">UserData identifier provided by subscribeToOccurrenceUserData</param>
		/// <param name="occurrence">Occurrence that potentially store the user data</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean HasOccurrenceUserData(System.UInt32 userDataId, System.UInt32 occurrence) {
			try {
				var ret = Scene_hasOccurrenceUserData(api.Session, userDataId, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern void Scene_setMultipleOccurrenceUserData(IntPtr _pxz_session_, System.UInt32 userDataId, OccurrenceList_c occurrences, Core.PtrList_c userDataList);

		/// <summary>
		/// Batch version of setOccurrenceUserData
		/// </summary>
		/// <param name="userDataId">UserData identifier provided by subscribeToOccurrenceUserData</param>
		/// <param name="occurrences">Occurrences that will store the user data</param>
		/// <param name="userDataList">User data to store on each occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetMultipleOccurrenceUserData(System.UInt32 userDataId, OccurrenceList occurrences, Core.PtrList userDataList) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				var userDataList_c = new Core.PtrList_c();
				Core.CoreInterface.ConvertValue((Core.PtrList)userDataList, ref userDataList_c);
				Scene_setMultipleOccurrenceUserData(api.Session, userDataId, occurrences_c, userDataList_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				Core.CoreInterface.Core_PtrList_free(ref userDataList_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setOccurrenceUserData(IntPtr _pxz_session_, System.UInt32 userDataId, System.UInt32 occurrence, System.IntPtr userData);

		/// <summary>
		/// Set or replace a userdata stored on an occurrence
		/// </summary>
		/// <param name="userDataId">UserData identifier provided by subscribeToOccurrenceUserData</param>
		/// <param name="occurrence">Occurrence that will store the user data</param>
		/// <param name="userData">User data to store in the given occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetOccurrenceUserData(System.UInt32 userDataId, System.UInt32 occurrence, System.IntPtr userData) {
			try {
				Scene_setOccurrenceUserData(api.Session, userDataId, occurrence, userData);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_subscribeToOccurrenceUserData(IntPtr _pxz_session_);

		/// <summary>
		/// subscribe to occurrence user data. multiple different userdata can be stored on the same occurrences if subscribeToOccurrenceUserData is called multiple times
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 SubscribeToOccurrenceUserData() {
			try {
				var ret = Scene_subscribeToOccurrenceUserData(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern void Scene_unsetMultipleOccurrenceUserData(IntPtr _pxz_session_, System.UInt32 userDataId, OccurrenceList_c occurrences);

		/// <summary>
		/// Batch version of unsetOccurrenceUserData
		/// </summary>
		/// <param name="userDataId">UserData identifier provided by subscribeToOccurrenceUserData</param>
		/// <param name="occurrences">Occurrences that will store the user data</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void UnsetMultipleOccurrenceUserData(System.UInt32 userDataId, OccurrenceList occurrences) {
			try {
				var occurrences_c = new Scene.OccurrenceList_c();
				ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
				Scene_unsetMultipleOccurrenceUserData(api.Session, userDataId, occurrences_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_unsetOccurrenceUserData(IntPtr _pxz_session_, System.UInt32 userDataId, System.UInt32 occurrence);

		/// <summary>
		/// Unset the userdata stored on an occurrence
		/// </summary>
		/// <param name="userDataId">UserData identifier provided by subscribeToOccurrenceUserData</param>
		/// <param name="occurrence">Occurrence that will store the user data</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void UnsetOccurrenceUserData(System.UInt32 userDataId, System.UInt32 occurrence) {
			try {
				Scene_unsetOccurrenceUserData(api.Session, userDataId, occurrence);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_unsubscribeFromOccurrenceUserData(IntPtr _pxz_session_, System.UInt32 userDataId);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userDataId">UserData identifier to unsubscribe</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void UnsubscribeFromOccurrenceUserData(System.UInt32 userDataId) {
			try {
				Scene_unsubscribeFromOccurrenceUserData(api.Session, userDataId);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region variant

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_addVariant(IntPtr _pxz_session_, string name);

		/// <summary>
		/// Create a new variant
		/// </summary>
		/// <param name="name">The name of the new variant</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 AddVariant(System.String name) {
			try {
				var ret = Scene_addVariant(api.Session, name);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern System.UInt32 Scene_duplicateVariant(IntPtr _pxz_session_, System.UInt32 variant, string name);

		/// <summary>
		/// Create a new variant which is a copy of an existing variant
		/// </summary>
		/// <param name="variant">The variant to duplicated</param>
		/// <param name="name">Name of the new variant</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 DuplicateVariant(System.UInt32 variant, System.String name) {
			try {
				var ret = Scene_duplicateVariant(api.Session, variant, name);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern void Scene_endModifyAllVariants(IntPtr _pxz_session_);

		/// <summary>
		/// Call this function to disable the modifications of all variants at the same time.
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void EndModifyAllVariants() {
			try {
				Scene_endModifyAllVariants(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern VariantDefinitionListList_c Scene_getVariantComponentsDefinitions(IntPtr _pxz_session_, VariantComponentList_c variantComponents);

		/// <summary>
		/// Returns the definitions of multiple variant components
		/// </summary>
		/// <param name="variantComponents">The list of variant components to retrieve definitions</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public VariantDefinitionListList GetVariantComponentsDefinitions(VariantComponentList variantComponents) {
			try {
				var variantComponents_c = new Scene.VariantComponentList_c();
				ConvertValue((Scene.VariantComponentList)variantComponents, ref variantComponents_c);
				var ret = Scene_getVariantComponentsDefinitions(api.Session, variantComponents_c);
				Scene.SceneInterface.Scene_VariantComponentList_free(ref variantComponents_c);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_VariantDefinitionListList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Scene_getVariantTree(IntPtr _pxz_session_, System.UInt32 variant);

		/// <summary>
		/// Get the alternative tree used by this variant
		/// </summary>
		/// <param name="variant">The variant</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetVariantTree(System.UInt32 variant) {
			try {
				var ret = Scene_getVariantTree(api.Session, variant);
				System.String err = ConvertValue(Scene_getLastError());
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
		private static extern VariantList_c Scene_listVariants(IntPtr _pxz_session_);

		/// <summary>
		/// Returns all the available variants
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public VariantList ListVariants() {
			try {
				var ret = Scene_listVariants(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Scene.SceneInterface.Scene_VariantList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_removeVariant(IntPtr _pxz_session_, System.UInt32 variant);

		/// <summary>
		/// Remove a variant
		/// </summary>
		/// <param name="variant">The variant to remove</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void RemoveVariant(System.UInt32 variant) {
			try {
				Scene_removeVariant(api.Session, variant);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setCurrentVariant(IntPtr _pxz_session_, System.UInt32 variant);

		/// <summary>
		/// Change the current variant used
		/// </summary>
		/// <param name="variant">The variant to enable (can be null)</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetCurrentVariant(System.UInt32 variant = 0) {
			try {
				Scene_setCurrentVariant(api.Session, variant);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_setVariantTree(IntPtr _pxz_session_, System.UInt32 variant, System.UInt32 tree);

		/// <summary>
		/// Set the alternative tree to use for this variant
		/// </summary>
		/// <param name="variant">The variant to modify</param>
		/// <param name="tree">The alternative tree to use for this variant</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetVariantTree(System.UInt32 variant, System.UInt32 tree) {
			try {
				Scene_setVariantTree(api.Session, variant, tree);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Scene_startModifyAllVariants(IntPtr _pxz_session_);

		/// <summary>
		/// Call this function to to enable the modifications of all variants at the same time.
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void StartModifyAllVariants() {
			try {
				Scene_startModifyAllVariants(api.Session);
				System.String err = ConvertValue(Scene_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

	}
}
