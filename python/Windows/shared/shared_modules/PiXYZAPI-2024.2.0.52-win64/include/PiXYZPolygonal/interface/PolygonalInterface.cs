#pragma warning disable CA2101

using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;
using PiXYZAPI = UnityEngine.Pixyz.API.PiXYZAPI;

namespace UnityEngine.Pixyz.Polygonal {

	public class PolygonalInterface : API.Interface {

		private PiXYZAPI api;
		internal PolygonalInterface(PiXYZAPI api)
		{
			this.api = api;
		}

		#region Types Init/Free Methods

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_Submesh_init(ref Submesh_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_Submesh_free(ref Submesh_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_SubmeshList_init(ref SubmeshList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_SubmeshList_free(ref SubmeshList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_MeshList_init(ref MeshList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_MeshList_free(ref MeshList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_TopologyCategoryMask_init(ref TopologyCategoryMask_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_TopologyCategoryMask_free(ref TopologyCategoryMask_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_TessellationList_init(ref TessellationList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_TessellationList_free(ref TessellationList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_StylizedLine_init(ref StylizedLine_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_StylizedLine_free(ref StylizedLine_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_StylizedLineList_init(ref StylizedLineList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_StylizedLineList_free(ref StylizedLineList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_JointList_init(ref JointList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_JointList_free(ref JointList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_MeshDefinition_init(ref MeshDefinition_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_MeshDefinition_free(ref MeshDefinition_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_PlaceholderJointList_init(ref PlaceholderJointList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_PlaceholderJointList_free(ref PlaceholderJointList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_MeshDefinitionList_init(ref MeshDefinitionList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Polygonal_MeshDefinitionList_free(ref MeshDefinitionList_c list);

	internal static Submesh ConvertValue(ref Submesh_c s) {
		Submesh ss = new Submesh();
		ss.material = (System.UInt32)s.material;
		ss.firstTri = (System.Int32)s.firstTri;
		ss.triCount = (System.Int32)s.triCount;
		ss.firstQuad = (System.Int32)s.firstQuad;
		ss.quadCount = (System.Int32)s.quadCount;
		ss.externalId = (System.UInt32)s.externalId;
		return ss;
	}

	internal static Submesh_c ConvertValue(Submesh s, ref Submesh_c ss) {
		Polygonal.PolygonalInterface.Polygonal_Submesh_init(ref ss);
		ss.material = (System.UInt32)s.material;
		ss.firstTri = (Int32)s.firstTri;
		ss.triCount = (Int32)s.triCount;
		ss.firstQuad = (Int32)s.firstQuad;
		ss.quadCount = (Int32)s.quadCount;
		ss.externalId = (System.UInt32)s.externalId;
		return ss;
	}

	internal static SubmeshList ConvertValue(ref SubmeshList_c s) {
		SubmeshList list = new SubmeshList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<Submesh>(s.ptr, (int)s.size);
		return list;
	}

	internal static SubmeshList_c ConvertValue(SubmeshList s, ref SubmeshList_c list) {
		Polygonal.PolygonalInterface.Polygonal_SubmeshList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Submesh_c elt = new Submesh_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Submesh_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static MeshList ConvertValue(ref MeshList_c s) {
		MeshList list = new MeshList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static MeshList_c ConvertValue(MeshList s, ref MeshList_c list) {
		Polygonal.PolygonalInterface.Polygonal_MeshList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static TopologyCategoryMask ConvertValue(ref TopologyCategoryMask_c s) {
		TopologyCategoryMask ss = new TopologyCategoryMask();
		ss.dimension = (TopologyDimensionMask)s.dimension;
		ss.connectivity = (TopologyConnectivityMask)s.connectivity;
		return ss;
	}

	internal static TopologyCategoryMask_c ConvertValue(TopologyCategoryMask s, ref TopologyCategoryMask_c ss) {
		Polygonal.PolygonalInterface.Polygonal_TopologyCategoryMask_init(ref ss);
		ss.dimension = (Int32)s.dimension;
		ss.connectivity = (Int32)s.connectivity;
		return ss;
	}

	internal static TessellationList ConvertValue(ref TessellationList_c s) {
		TessellationList list = new TessellationList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static TessellationList_c ConvertValue(TessellationList s, ref TessellationList_c list) {
		Polygonal.PolygonalInterface.Polygonal_TessellationList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
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

	internal static StylizedLine ConvertValue(ref StylizedLine_c s) {
		StylizedLine ss = new StylizedLine();
		ss.lineVertexIndices = Core.CoreInterface.ConvertValue(ref s.lineVertexIndices);
		ss.material = (System.UInt32)s.material;
		ss.externalId = (System.UInt32)s.externalId;
		return ss;
	}

	internal static StylizedLine_c ConvertValue(StylizedLine s, ref StylizedLine_c ss) {
		Polygonal.PolygonalInterface.Polygonal_StylizedLine_init(ref ss);
		Core.CoreInterface.ConvertValue(s.lineVertexIndices, ref ss.lineVertexIndices);
		ss.material = (System.UInt32)s.material;
		ss.externalId = (System.UInt32)s.externalId;
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

	internal static Geom.Vector3List ConvertValue(ref Geom.Vector3List_c s) {
		Geom.Vector3List list = new Geom.Vector3List((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<Geom.Vector3>(s.ptr, (int)s.size);
		return list;
	}

	internal static Geom.Vector3List_c ConvertValue(Geom.Vector3List s, ref Geom.Vector3List_c list) {
		Geom.GeomInterface.Geom_Vector3List_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Geom.Point3_c elt = new Geom.Point3_c();
			Geom.GeomInterface.ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Geom.Point3_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Geom.Vector4List ConvertValue(ref Geom.Vector4List_c s) {
		Geom.Vector4List list = new Geom.Vector4List((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<Geom.Vector4>(s.ptr, (int)s.size);
		return list;
	}

	internal static Geom.Vector4List_c ConvertValue(Geom.Vector4List s, ref Geom.Vector4List_c list) {
		Geom.GeomInterface.Geom_Vector4List_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Geom.Point4_c elt = new Geom.Point4_c();
			Geom.GeomInterface.ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Geom.Point4_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
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

	internal static Geom.Point2List ConvertValue(ref Geom.Point2List_c s) {
		Geom.Point2List list = new Geom.Point2List((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<Geom.Point2>(s.ptr, (int)s.size);
		return list;
	}

	internal static Geom.Point2List_c ConvertValue(Geom.Point2List s, ref Geom.Point2List_c list) {
		Geom.GeomInterface.Geom_Point2List_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Geom.Point2_c elt = new Geom.Point2_c();
			Geom.GeomInterface.ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Geom.Point2_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Geom.Point2ListList ConvertValue(ref Geom.Point2ListList_c s) {
		Geom.Point2ListList list = new Geom.Point2ListList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(Geom.Point2List_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			Geom.Point2List_c value = (Geom.Point2List_c)Marshal.PtrToStructure(p, typeof(Geom.Point2List_c));
			list.list[i] = Geom.GeomInterface.ConvertValue(ref value);
		}
		return list;
	}

	internal static Geom.Point2ListList_c ConvertValue(Geom.Point2ListList s, ref Geom.Point2ListList_c list) {
		Geom.GeomInterface.Geom_Point2ListList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Geom.Point2List_c elt = new Geom.Point2List_c();
			Geom.GeomInterface.ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Geom.Point2List_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Core.ColorAlpha ConvertValue(ref Core.ColorAlpha_c s) {
		Core.ColorAlpha ss = new Core.ColorAlpha();
		ss.r = (System.Double)s.r;
		ss.g = (System.Double)s.g;
		ss.b = (System.Double)s.b;
		ss.a = (System.Double)s.a;
		return ss;
	}

	internal static Core.ColorAlpha_c ConvertValue(Core.ColorAlpha s, ref Core.ColorAlpha_c ss) {
		Core.CoreInterface.Core_ColorAlpha_init(ref ss);
		ss.r = (System.Double)s.r;
		ss.g = (System.Double)s.g;
		ss.b = (System.Double)s.b;
		ss.a = (System.Double)s.a;
		return ss;
	}

	internal static Core.ColorAlphaList ConvertValue(ref Core.ColorAlphaList_c s) {
		Core.ColorAlphaList list = new Core.ColorAlphaList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<Core.ColorAlpha>(s.ptr, (int)s.size);
		return list;
	}

	internal static Core.ColorAlphaList_c ConvertValue(Core.ColorAlphaList s, ref Core.ColorAlphaList_c list) {
		Core.CoreInterface.Core_ColorAlphaList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Core.ColorAlpha_c elt = new Core.ColorAlpha_c();
			Core.CoreInterface.ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Core.ColorAlpha_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Geom.Curvatures ConvertValue(ref Geom.Curvatures_c s) {
		Geom.Curvatures ss = new Geom.Curvatures();
		ss.k1 = (System.Double)s.k1;
		ss.k2 = (System.Double)s.k2;
		ss.v1 = Geom.GeomInterface.ConvertValue(ref s.v1);
		ss.v2 = Geom.GeomInterface.ConvertValue(ref s.v2);
		return ss;
	}

	internal static Geom.Curvatures_c ConvertValue(Geom.Curvatures s, ref Geom.Curvatures_c ss) {
		Geom.GeomInterface.Geom_Curvatures_init(ref ss);
		ss.k1 = (System.Double)s.k1;
		ss.k2 = (System.Double)s.k2;
		Geom.GeomInterface.ConvertValue(s.v1, ref ss.v1);
		Geom.GeomInterface.ConvertValue(s.v2, ref ss.v2);
		return ss;
	}

	internal static Geom.CurvaturesList ConvertValue(ref Geom.CurvaturesList_c s) {
		Geom.CurvaturesList list = new Geom.CurvaturesList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(Geom.Curvatures_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			Geom.Curvatures_c value = (Geom.Curvatures_c)Marshal.PtrToStructure(p, typeof(Geom.Curvatures_c));
			list.list[i] = Geom.GeomInterface.ConvertValue(ref value);
		}
		return list;
	}

	internal static Geom.CurvaturesList_c ConvertValue(Geom.CurvaturesList s, ref Geom.CurvaturesList_c list) {
		Geom.GeomInterface.Geom_CurvaturesList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Geom.Curvatures_c elt = new Geom.Curvatures_c();
			Geom.GeomInterface.ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Geom.Curvatures_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static StylizedLineList ConvertValue(ref StylizedLineList_c s) {
		StylizedLineList list = new StylizedLineList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(StylizedLine_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			StylizedLine_c value = (StylizedLine_c)Marshal.PtrToStructure(p, typeof(StylizedLine_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static StylizedLineList_c ConvertValue(StylizedLineList s, ref StylizedLineList_c list) {
		Polygonal.PolygonalInterface.Polygonal_StylizedLineList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			StylizedLine_c elt = new StylizedLine_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(StylizedLine_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static JointList ConvertValue(ref JointList_c s) {
		JointList list = new JointList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static JointList_c ConvertValue(JointList s, ref JointList_c list) {
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

	internal static Geom.Vector4I ConvertValue(ref Geom.Vector4I_c s) {
		Geom.Vector4I ss = new Geom.Vector4I();
		ss.x = (System.Int32)s.x;
		ss.y = (System.Int32)s.y;
		ss.z = (System.Int32)s.z;
		ss.w = (System.Int32)s.w;
		return ss;
	}

	internal static Geom.Vector4I_c ConvertValue(Geom.Vector4I s, ref Geom.Vector4I_c ss) {
		Geom.GeomInterface.Geom_Vector4I_init(ref ss);
		ss.x = (Int32)s.x;
		ss.y = (Int32)s.y;
		ss.z = (Int32)s.z;
		ss.w = (Int32)s.w;
		return ss;
	}

	internal static Geom.Vector4IList ConvertValue(ref Geom.Vector4IList_c s) {
		Geom.Vector4IList list = new Geom.Vector4IList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<Geom.Vector4I>(s.ptr, (int)s.size);
		return list;
	}

	internal static Geom.Vector4IList_c ConvertValue(Geom.Vector4IList s, ref Geom.Vector4IList_c list) {
		Geom.GeomInterface.Geom_Vector4IList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Geom.Vector4I_c elt = new Geom.Vector4I_c();
			Geom.GeomInterface.ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Geom.Vector4I_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static MeshDefinition ConvertValue(ref MeshDefinition_c s) {
		MeshDefinition ss = new MeshDefinition();
		ss.id = (System.UInt32)s.id;
		ss.externalId = (System.UInt32)s.externalId;
		ss.vertices = Geom.GeomInterface.ConvertValue(ref s.vertices);
		ss.normals = Geom.GeomInterface.ConvertValue(ref s.normals);
		ss.tangents = Geom.GeomInterface.ConvertValue(ref s.tangents);
		ss.uvChannels = Core.CoreInterface.ConvertValue(ref s.uvChannels);
		ss.uvs = Geom.GeomInterface.ConvertValue(ref s.uvs);
		ss.vertexColors = Core.CoreInterface.ConvertValue(ref s.vertexColors);
		ss.curvatures = Geom.GeomInterface.ConvertValue(ref s.curvatures);
		ss.triangles = Core.CoreInterface.ConvertValue(ref s.triangles);
		ss.quadrangles = Core.CoreInterface.ConvertValue(ref s.quadrangles);
		ss.vertexMerged = Core.CoreInterface.ConvertValue(ref s.vertexMerged);
		ss.submeshes = ConvertValue(ref s.submeshes);
		ss.linesVertices = Geom.GeomInterface.ConvertValue(ref s.linesVertices);
		ss.lines = ConvertValue(ref s.lines);
		ss.points = Geom.GeomInterface.ConvertValue(ref s.points);
		ss.pointsColors = Geom.GeomInterface.ConvertValue(ref s.pointsColors);
		ss.joints = ConvertValue(ref s.joints);
		ss.inverseBindMatrices = Geom.GeomInterface.ConvertValue(ref s.inverseBindMatrices);
		ss.jointWeights = Geom.GeomInterface.ConvertValue(ref s.jointWeights);
		ss.jointIndices = Geom.GeomInterface.ConvertValue(ref s.jointIndices);
		return ss;
	}

	internal static MeshDefinition_c ConvertValue(MeshDefinition s, ref MeshDefinition_c ss) {
		Polygonal.PolygonalInterface.Polygonal_MeshDefinition_init(ref ss);
		ss.id = (System.UInt32)s.id;
		ss.externalId = (System.UInt32)s.externalId;
		Geom.GeomInterface.ConvertValue(s.vertices, ref ss.vertices);
		Geom.GeomInterface.ConvertValue(s.normals, ref ss.normals);
		Geom.GeomInterface.ConvertValue(s.tangents, ref ss.tangents);
		Core.CoreInterface.ConvertValue(s.uvChannels, ref ss.uvChannels);
		Geom.GeomInterface.ConvertValue(s.uvs, ref ss.uvs);
		Core.CoreInterface.ConvertValue(s.vertexColors, ref ss.vertexColors);
		Geom.GeomInterface.ConvertValue(s.curvatures, ref ss.curvatures);
		Core.CoreInterface.ConvertValue(s.triangles, ref ss.triangles);
		Core.CoreInterface.ConvertValue(s.quadrangles, ref ss.quadrangles);
		Core.CoreInterface.ConvertValue(s.vertexMerged, ref ss.vertexMerged);
		ConvertValue(s.submeshes, ref ss.submeshes);
		Geom.GeomInterface.ConvertValue(s.linesVertices, ref ss.linesVertices);
		ConvertValue(s.lines, ref ss.lines);
		Geom.GeomInterface.ConvertValue(s.points, ref ss.points);
		Geom.GeomInterface.ConvertValue(s.pointsColors, ref ss.pointsColors);
		ConvertValue(s.joints, ref ss.joints);
		Geom.GeomInterface.ConvertValue(s.inverseBindMatrices, ref ss.inverseBindMatrices);
		Geom.GeomInterface.ConvertValue(s.jointWeights, ref ss.jointWeights);
		Geom.GeomInterface.ConvertValue(s.jointIndices, ref ss.jointIndices);
		return ss;
	}

	internal static PlaceholderJointList ConvertValue(ref PlaceholderJointList_c s) {
		PlaceholderJointList list = new PlaceholderJointList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static PlaceholderJointList_c ConvertValue(PlaceholderJointList s, ref PlaceholderJointList_c list) {
		Polygonal.PolygonalInterface.Polygonal_PlaceholderJointList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static MeshDefinitionList ConvertValue(ref MeshDefinitionList_c s) {
		MeshDefinitionList list = new MeshDefinitionList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(MeshDefinition_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			MeshDefinition_c value = (MeshDefinition_c)Marshal.PtrToStructure(p, typeof(MeshDefinition_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static MeshDefinitionList_c ConvertValue(MeshDefinitionList s, ref MeshDefinitionList_c list) {
		Polygonal.PolygonalInterface.Polygonal_MeshDefinitionList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			MeshDefinition_c elt = new MeshDefinition_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(MeshDefinition_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Core.ByteList ConvertValue(ref Core.ByteList_c s) {
		Core.ByteList list = new Core.ByteList((int)s.size);
		if (s.size > 0)
			Marshal.Copy(s.ptr, list.list, 0, (int)s.size);
		return list;
	}

	internal static Core.ByteList_c ConvertValue(Core.ByteList s, ref Core.ByteList_c list) {
		Core.CoreInterface.Core_ByteList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size > 0)
			Marshal.Copy(s.list, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static DracoEncodeReturn ConvertValue(ref DracoEncodeReturn_c s) {
		DracoEncodeReturn ss = new DracoEncodeReturn();
		ss.buffer = Core.CoreInterface.ConvertValue(ref s.buffer);
		ss.jointIndicesId = (System.Int32)s.jointIndicesId;
		ss.jointWeightsId = (System.Int32)s.jointWeightsId;
		return ss;
	}

	internal static DracoEncodeReturn_c ConvertValue(DracoEncodeReturn s, ref DracoEncodeReturn_c ss) {
		Core.CoreInterface.ConvertValue(s.buffer, ref ss.buffer);
		ss.jointIndicesId = (Int32)s.jointIndicesId;
		ss.jointWeightsId = (Int32)s.jointWeightsId;
		return ss;
	}

	internal static CreateMeshFromTextReturn ConvertValue(ref CreateMeshFromTextReturn_c s) {
		CreateMeshFromTextReturn ss = new CreateMeshFromTextReturn();
		ss.mesh = (System.UInt32)s.mesh;
		ss.material = (System.UInt32)s.material;
		return ss;
	}

	internal static CreateMeshFromTextReturn_c ConvertValue(CreateMeshFromTextReturn s, ref CreateMeshFromTextReturn_c ss) {
		ss.mesh = (System.UInt32)s.mesh;
		ss.material = (System.UInt32)s.material;
		return ss;
	}

	internal static GetMeshSkinningReturn ConvertValue(ref GetMeshSkinningReturn_c s) {
		GetMeshSkinningReturn ss = new GetMeshSkinningReturn();
		ss.joints = ConvertValue(ref s.joints);
		ss.IBMs = Geom.GeomInterface.ConvertValue(ref s.IBMs);
		return ss;
	}

	internal static GetMeshSkinningReturn_c ConvertValue(GetMeshSkinningReturn s, ref GetMeshSkinningReturn_c ss) {
		ConvertValue(s.joints, ref ss.joints);
		Geom.GeomInterface.ConvertValue(s.IBMs, ref ss.IBMs);
		return ss;
	}

		#endregion

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Polygonal_getLastError();

		public static string GetLastError()
		{
			return ConvertValue(Polygonal_getLastError());
		}

		#region 

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Polygonal_configureFunctionLogger(IntPtr _pxz_session_, string functionName, System.Byte enableFunction, System.Byte enableParameters, System.Byte enableExecutionTime);

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
				Polygonal_configureFunctionLogger(api.Session, functionName, Convert.ToByte(enableFunction), Convert.ToByte(enableParameters), Convert.ToByte(enableExecutionTime));
				System.String err = ConvertValue(Polygonal_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region checksum

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Polygonal_computeMeshTopoChecksum(IntPtr _pxz_session_, System.UInt32 mesh);

		/// <summary>
		/// Compute a checksum of the mesh topology, connectivity
		/// </summary>
		/// <param name="mesh">The mesh</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String ComputeMeshTopoChecksum(System.UInt32 mesh) {
			try {
				var ret = Polygonal_computeMeshTopoChecksum(api.Session, mesh);
				System.String err = ConvertValue(Polygonal_getLastError());
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
		private static extern IntPtr Polygonal_computeMeshVertexPositionsChecksum(IntPtr _pxz_session_, System.UInt32 mesh, Int32 precisionFloat);

		/// <summary>
		/// Compute a checksum of the mesh vertices positions
		/// </summary>
		/// <param name="mesh">The mesh</param>
		/// <param name="precisionFloat">Floating point precision [1..24], number of significant numbers kept. -1 means no rounded will be applied</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String ComputeMeshVertexPositionsChecksum(System.UInt32 mesh, System.Int32 precisionFloat = -1) {
			try {
				var ret = Polygonal_computeMeshVertexPositionsChecksum(api.Session, mesh, precisionFloat);
				System.String err = ConvertValue(Polygonal_getLastError());
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
		private static extern IntPtr Polygonal_computeUVTopoChecksum(IntPtr _pxz_session_, System.UInt32 mesh, Int32 uvChannel);

		/// <summary>
		/// Compute a checksum of the uvs topology, connectivity
		/// </summary>
		/// <param name="mesh">The mesh</param>
		/// <param name="uvChannel">The uv channel</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String ComputeUVTopoChecksum(System.UInt32 mesh, System.Int32 uvChannel) {
			try {
				var ret = Polygonal_computeUVTopoChecksum(api.Session, mesh, uvChannel);
				System.String err = ConvertValue(Polygonal_getLastError());
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
		private static extern IntPtr Polygonal_computeUVVertexPositionsChecksum(IntPtr _pxz_session_, System.UInt32 mesh, Int32 uvChannel, Int32 precisionFloat);

		/// <summary>
		/// Compute a checksum of the vertices positions in uv space
		/// </summary>
		/// <param name="mesh">The mesh</param>
		/// <param name="uvChannel">The uv channel</param>
		/// <param name="precisionFloat">Floating point precision [1..24], number of significant numbers kept. -1 means no rounded will be applied</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String ComputeUVVertexPositionsChecksum(System.UInt32 mesh, System.Int32 uvChannel, System.Int32 precisionFloat = -1) {
			try {
				var ret = Polygonal_computeUVVertexPositionsChecksum(api.Session, mesh, uvChannel, precisionFloat);
				System.String err = ConvertValue(Polygonal_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return ConvertValue(ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region draco

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Polygonal_dracoDecode(IntPtr _pxz_session_, Core.ByteList_c buffer, Int32 jointIndicesId, Int32 jointWeightsId);

		/// <summary>
		/// decode a mesh using draco
		/// </summary>
		/// <param name="buffer"></param>
		/// <param name="jointIndicesId">Unique ID of Generic attribute encoding joint indices</param>
		/// <param name="jointWeightsId">Unique ID of Generic attribute encoding joint weights</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 DracoDecode(Core.ByteList buffer, System.Int32 jointIndicesId = -1, System.Int32 jointWeightsId = -1) {
			try {
				var buffer_c = new Core.ByteList_c();
				Core.CoreInterface.ConvertValue((Core.ByteList)buffer, ref buffer_c);
				var ret = Polygonal_dracoDecode(api.Session, buffer_c, jointIndicesId, jointWeightsId);
				Core.CoreInterface.Core_ByteList_free(ref buffer_c);
				System.String err = ConvertValue(Polygonal_getLastError());
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
		private static extern DracoEncodeReturn_c Polygonal_dracoEncode(IntPtr _pxz_session_, System.UInt32 mesh, Int32 compressionLevel, Int32 quantizationPosition, Int32 quantizationNormal, Int32 quantizationTexCoord);

		/// <summary>
		/// encode a mesh using draco
		/// </summary>
		/// <param name="mesh"></param>
		/// <param name="compressionLevel">0=faster but the worst compression, 10=slower but the best compression</param>
		/// <param name="quantizationPosition">Number of quantization bits used for position attributes</param>
		/// <param name="quantizationNormal">Number of quantization bits used for normal attributes</param>
		/// <param name="quantizationTexCoord">Number of quantization bits used for texture coordinates attributes</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Polygonal.DracoEncodeReturn DracoEncode(System.UInt32 mesh, System.Int32 compressionLevel = 7, System.Int32 quantizationPosition = -1, System.Int32 quantizationNormal = -1, System.Int32 quantizationTexCoord = -1) {
			try {
				var ret = Polygonal_dracoEncode(api.Session, mesh, compressionLevel, quantizationPosition, quantizationNormal, quantizationTexCoord);
				System.String err = ConvertValue(Polygonal_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				Polygonal.DracoEncodeReturn retStruct = new Polygonal.DracoEncodeReturn();
				retStruct.buffer = ConvertValue(ref ret.buffer);
				Core.CoreInterface.Core_ByteList_free(ref ret.buffer);
				retStruct.jointIndicesId = (System.Int32)ret.jointIndicesId;
				retStruct.jointWeightsId = (System.Int32)ret.jointWeightsId;
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region geometry access

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern PlaceholderJointList_c Polygonal_createJointPlaceholders(IntPtr _pxz_session_, Core.ULongList_c data, Geom.Matrix4List_c worldMatrices);

		/// <summary>
		/// Create fake joint to store in mesh definitions. Thus we can retrieve stored data from getJointPlaceholders
		/// </summary>
		/// <param name="data">Create as much joints as there are data, each joint store one data</param>
		/// <param name="worldMatrices">World matrix for each joints</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public PlaceholderJointList CreateJointPlaceholders(Core.ULongList data, Geom.Matrix4List worldMatrices) {
			try {
				var data_c = new Core.ULongList_c();
				Core.CoreInterface.ConvertValue((Core.ULongList)data, ref data_c);
				var worldMatrices_c = new Geom.Matrix4List_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4List)worldMatrices, ref worldMatrices_c);
				var ret = Polygonal_createJointPlaceholders(api.Session, data_c, worldMatrices_c);
				Core.CoreInterface.Core_ULongList_free(ref data_c);
				Geom.GeomInterface.Geom_Matrix4List_free(ref worldMatrices_c);
				System.String err = ConvertValue(Polygonal_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Polygonal.PolygonalInterface.Polygonal_PlaceholderJointList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Polygonal_createMeshFromDefinition(IntPtr _pxz_session_, MeshDefinition_c meshDefinition);

		/// <summary>
		/// Create a new mesh with the given MeshDefinition
		/// </summary>
		/// <param name="meshDefinition">Mesh definition</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateMeshFromDefinition(MeshDefinition meshDefinition) {
			try {
				var meshDefinition_c = new Polygonal.MeshDefinition_c();
				ConvertValue((Polygonal.MeshDefinition)meshDefinition, ref meshDefinition_c);
				var ret = Polygonal_createMeshFromDefinition(api.Session, meshDefinition_c);
				Polygonal.PolygonalInterface.Polygonal_MeshDefinition_free(ref meshDefinition_c);
				System.String err = ConvertValue(Polygonal_getLastError());
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
		private static extern System.UInt32 Polygonal_createMeshFromDefinitions(IntPtr _pxz_session_, MeshDefinitionList_c meshDefinition);

		/// <summary>
		/// Create a new mesh from multiple MeshDefinition
		/// </summary>
		/// <param name="meshDefinition">The MeshDefinitions</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateMeshFromDefinitions(MeshDefinitionList meshDefinition) {
			try {
				var meshDefinition_c = new Polygonal.MeshDefinitionList_c();
				ConvertValue((Polygonal.MeshDefinitionList)meshDefinition, ref meshDefinition_c);
				var ret = Polygonal_createMeshFromDefinitions(api.Session, meshDefinition_c);
				Polygonal.PolygonalInterface.Polygonal_MeshDefinitionList_free(ref meshDefinition_c);
				System.String err = ConvertValue(Polygonal_getLastError());
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
		private static extern CreateMeshFromTextReturn_c Polygonal_createMeshFromText(IntPtr _pxz_session_, string text, Geom.Matrix4_c matrix, string font, Int32 fontSize, Core.ColorAlpha_c color, System.Double heigth3D);

		/// <summary>
		/// Creates an occurrence from string
		/// </summary>
		/// <param name="text">Text to create</param>
		/// <param name="matrix">A matrix to apply on mesh</param>
		/// <param name="font">The font to use</param>
		/// <param name="fontSize">The font size</param>
		/// <param name="color">The occurrence color</param>
		/// <param name="heigth3D">3D height of text</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Polygonal.CreateMeshFromTextReturn CreateMeshFromText(System.String text, Geom.Matrix4 matrix, System.String font = "ChicFont", System.Int32 fontSize = 64, Core.ColorAlpha? color = null, System.Double heigth3D = 40) {
			color = color ?? new Core.ColorAlpha() {};
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				var color_c = new Core.ColorAlpha_c();
				Core.CoreInterface.ConvertValue((Core.ColorAlpha)color, ref color_c);
				var ret = Polygonal_createMeshFromText(api.Session, text, matrix_c, font, fontSize, color_c, heigth3D);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				Core.CoreInterface.Core_ColorAlpha_free(ref color_c);
				System.String err = ConvertValue(Polygonal_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				Polygonal.CreateMeshFromTextReturn retStruct = new Polygonal.CreateMeshFromTextReturn();
				retStruct.mesh = (System.UInt32)ret.mesh;
				retStruct.material = (System.UInt32)ret.material;
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern MeshList_c Polygonal_createMeshesFromDefinitions(IntPtr _pxz_session_, MeshDefinitionList_c meshDefinitions);

		/// <summary>
		/// Create new meshes with the given MeshDefinitions
		/// </summary>
		/// <param name="meshDefinitions">The MeshDefinitions</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public MeshList CreateMeshesFromDefinitions(MeshDefinitionList meshDefinitions) {
			try {
				var meshDefinitions_c = new Polygonal.MeshDefinitionList_c();
				ConvertValue((Polygonal.MeshDefinitionList)meshDefinitions, ref meshDefinitions_c);
				var ret = Polygonal_createMeshesFromDefinitions(api.Session, meshDefinitions_c);
				Polygonal.PolygonalInterface.Polygonal_MeshDefinitionList_free(ref meshDefinitions_c);
				System.String err = ConvertValue(Polygonal_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Polygonal.PolygonalInterface.Polygonal_MeshList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.ULongList_c Polygonal_getJointPlaceholders(IntPtr _pxz_session_, PlaceholderJointList_c joints);

		/// <summary>
		/// Get data stored in joint placeholders
		/// </summary>
		/// <param name="joints">Placeholder joints to get data from</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Core.ULongList GetJointPlaceholders(PlaceholderJointList joints) {
			try {
				var joints_c = new Polygonal.PlaceholderJointList_c();
				ConvertValue((Polygonal.PlaceholderJointList)joints, ref joints_c);
				var ret = Polygonal_getJointPlaceholders(api.Session, joints_c);
				Polygonal.PolygonalInterface.Polygonal_PlaceholderJointList_free(ref joints_c);
				System.String err = ConvertValue(Polygonal_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Core.CoreInterface.ConvertValue(ref ret);
				Core.CoreInterface.Core_ULongList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern MeshDefinition_c Polygonal_getMeshDefinition(IntPtr _pxz_session_, System.UInt32 mesh);

		/// <summary>
		/// Returns the definition
		/// </summary>
		/// <param name="mesh">The mesh to get definition</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public MeshDefinition GetMeshDefinition(System.UInt32 mesh) {
			try {
				var ret = Polygonal_getMeshDefinition(api.Session, mesh);
				System.String err = ConvertValue(Polygonal_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Polygonal.PolygonalInterface.Polygonal_MeshDefinition_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern MeshDefinitionList_c Polygonal_getMeshDefinitions(IntPtr _pxz_session_, MeshList_c meshes);

		/// <summary>
		/// Returns the definition
		/// </summary>
		/// <param name="meshes">The meshes to get definitions</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public MeshDefinitionList GetMeshDefinitions(MeshList meshes) {
			try {
				var meshes_c = new Polygonal.MeshList_c();
				ConvertValue((Polygonal.MeshList)meshes, ref meshes_c);
				var ret = Polygonal_getMeshDefinitions(api.Session, meshes_c);
				Polygonal.PolygonalInterface.Polygonal_MeshList_free(ref meshes_c);
				System.String err = ConvertValue(Polygonal_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				Polygonal.PolygonalInterface.Polygonal_MeshDefinitionList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetMeshSkinningReturn_c Polygonal_getMeshSkinning(IntPtr _pxz_session_, System.UInt32 mesh);

		/// <summary>
		/// Returns the joints/IBMs list of a given mesh (those referenced by jointIndices)
		/// </summary>
		/// <param name="mesh"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Polygonal.GetMeshSkinningReturn GetMeshSkinning(System.UInt32 mesh) {
			try {
				var ret = Polygonal_getMeshSkinning(api.Session, mesh);
				System.String err = ConvertValue(Polygonal_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				Polygonal.GetMeshSkinningReturn retStruct = new Polygonal.GetMeshSkinningReturn();
				retStruct.joints = ConvertValue(ref ret.joints);
				Polygonal.PolygonalInterface.Polygonal_JointList_free(ref ret.joints);
				retStruct.IBMs = ConvertValue(ref ret.IBMs);
				Geom.GeomInterface.Geom_Matrix4List_free(ref ret.IBMs);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Polygonal_hasMeshJoints(IntPtr _pxz_session_, System.UInt32 mesh);

		/// <summary>
		/// Check if the mesh has joints
		/// </summary>
		/// <param name="mesh">The Mesh</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean HasMeshJoints(System.UInt32 mesh) {
			try {
				var ret = Polygonal_hasMeshJoints(api.Session, mesh);
				System.String err = ConvertValue(Polygonal_getLastError());
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
		private static extern void Polygonal_setMeshSkinning(IntPtr _pxz_session_, System.UInt32 mesh, JointList_c joints, Geom.Matrix4List_c IBMs);

		/// <summary>
		/// Set/Replace the list of joints/IBMs of a given mesh (those referenced by jointIndices)
		/// </summary>
		/// <param name="mesh"></param>
		/// <param name="joints"></param>
		/// <param name="IBMs">Inverse Bind Matrices</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetMeshSkinning(System.UInt32 mesh, JointList joints, Geom.Matrix4List IBMs) {
			try {
				var joints_c = new Polygonal.JointList_c();
				ConvertValue((Polygonal.JointList)joints, ref joints_c);
				var IBMs_c = new Geom.Matrix4List_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4List)IBMs, ref IBMs_c);
				Polygonal_setMeshSkinning(api.Session, mesh, joints_c, IBMs_c);
				Polygonal.PolygonalInterface.Polygonal_JointList_free(ref joints_c);
				Geom.GeomInterface.Geom_Matrix4List_free(ref IBMs_c);
				System.String err = ConvertValue(Polygonal_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region modification

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.IntList_c Polygonal_usePointGapFillerNormal(IntPtr _pxz_session_, Geom.Point3List_c points, Geom.Vector3List_c normals);

		/// <summary>
		/// This triangulates a set of points and normals
		/// </summary>
		/// <param name="points">The set of points to triangulate</param>
		/// <param name="normals">The normals associated to the points to triangulate. This can be empty</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Core.IntList UsePointGapFillerNormal(Geom.Point3List points, Geom.Vector3List normals) {
			try {
				var points_c = new Geom.Point3List_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3List)points, ref points_c);
				var normals_c = new Geom.Vector3List_c();
				Geom.GeomInterface.ConvertValue((Geom.Vector3List)normals, ref normals_c);
				var ret = Polygonal_usePointGapFillerNormal(api.Session, points_c, normals_c);
				Geom.GeomInterface.Geom_Point3List_free(ref points_c);
				Geom.GeomInterface.Geom_Vector3List_free(ref normals_c);
				System.String err = ConvertValue(Polygonal_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Core.CoreInterface.ConvertValue(ref ret);
				Core.CoreInterface.Core_IntList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

	}
}
