#pragma warning disable CA2101

using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;
using PiXYZAPI = UnityEngine.Pixyz.API.PiXYZAPI;

namespace UnityEngine.Pixyz.CAD {

	public class CADInterface : API.Interface {

		private PiXYZAPI api;
		internal CADInterface(PiXYZAPI api)
		{
			this.api = api;
		}

		#region Types Init/Free Methods

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_OrientedFace_init(ref OrientedFace_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_OrientedFace_free(ref OrientedFace_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_CoEdgeList_init(ref CoEdgeList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_CoEdgeList_free(ref CoEdgeList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_EdgeList_init(ref EdgeList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_EdgeList_free(ref EdgeList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_OrientedEdge_init(ref OrientedEdge_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_OrientedEdge_free(ref OrientedEdge_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_CurveList_init(ref CurveList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_CurveList_free(ref CurveList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_OrientedEdgeList_init(ref OrientedEdgeList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_OrientedEdgeList_free(ref OrientedEdgeList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_OrientedFaceList_init(ref OrientedFaceList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_OrientedFaceList_free(ref OrientedFaceList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_BodyList_init(ref BodyList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_BodyList_free(ref BodyList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_ModelList_init(ref ModelList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_ModelList_free(ref ModelList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_ProfileLoop_init(ref ProfileLoop_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_ProfileLoop_free(ref ProfileLoop_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_SplittedEdge_init(ref SplittedEdge_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_SplittedEdge_free(ref SplittedEdge_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_SplittedEdgeList_init(ref SplittedEdgeList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_SplittedEdgeList_free(ref SplittedEdgeList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_ProfileBase_init(ref ProfileBase_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_ProfileBase_free(ref ProfileBase_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_FaceList_init(ref FaceList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_FaceList_free(ref FaceList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_Bounds1D_init(ref Bounds1D_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_Bounds1D_free(ref Bounds1D_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_Bounds2D_init(ref Bounds2D_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_Bounds2D_free(ref Bounds2D_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_ProfileBaseList_init(ref ProfileBaseList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_ProfileBaseList_free(ref ProfileBaseList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_BrickDefinition_init(ref BrickDefinition_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_BrickDefinition_free(ref BrickDefinition_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_OpenShellList_init(ref OpenShellList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_OpenShellList_free(ref OpenShellList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_LoopList_init(ref LoopList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_LoopList_free(ref LoopList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_VertexList_init(ref VertexList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_VertexList_free(ref VertexList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_EdgeListList_init(ref EdgeListList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_EdgeListList_free(ref EdgeListList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_ClosedShellList_init(ref ClosedShellList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_ClosedShellList_free(ref ClosedShellList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_CurveListList_init(ref CurveListList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_CurveListList_free(ref CurveListList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_BrickDefinitionList_init(ref BrickDefinitionList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void CAD_BrickDefinitionList_free(ref BrickDefinitionList_c list);

	internal static OrientedFace ConvertValue(ref OrientedFace_c s) {
		OrientedFace ss = new OrientedFace();
		ss.face = (System.UInt32)s.face;
		ss.orientation = ConvertValue(s.orientation);
		return ss;
	}

	internal static OrientedFace_c ConvertValue(OrientedFace s, ref OrientedFace_c ss) {
		CAD.CADInterface.CAD_OrientedFace_init(ref ss);
		ss.face = (System.UInt32)s.face;
		ss.orientation = ConvertValue(s.orientation);
		return ss;
	}

	internal static CoEdgeList ConvertValue(ref CoEdgeList_c s) {
		CoEdgeList list = new CoEdgeList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static CoEdgeList_c ConvertValue(CoEdgeList s, ref CoEdgeList_c list) {
		CAD.CADInterface.CAD_CoEdgeList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static EdgeList ConvertValue(ref EdgeList_c s) {
		EdgeList list = new EdgeList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static EdgeList_c ConvertValue(EdgeList s, ref EdgeList_c list) {
		CAD.CADInterface.CAD_EdgeList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static OrientedEdge ConvertValue(ref OrientedEdge_c s) {
		OrientedEdge ss = new OrientedEdge();
		ss.edge = (System.UInt32)s.edge;
		ss.orientation = ConvertValue(s.orientation);
		return ss;
	}

	internal static OrientedEdge_c ConvertValue(OrientedEdge s, ref OrientedEdge_c ss) {
		CAD.CADInterface.CAD_OrientedEdge_init(ref ss);
		ss.edge = (System.UInt32)s.edge;
		ss.orientation = ConvertValue(s.orientation);
		return ss;
	}

	internal static CurveList ConvertValue(ref CurveList_c s) {
		CurveList list = new CurveList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static CurveList_c ConvertValue(CurveList s, ref CurveList_c list) {
		CAD.CADInterface.CAD_CurveList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static OrientedEdgeList ConvertValue(ref OrientedEdgeList_c s) {
		OrientedEdgeList list = new OrientedEdgeList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<OrientedEdge>(s.ptr, (int)s.size);
		return list;
	}

	internal static OrientedEdgeList_c ConvertValue(OrientedEdgeList s, ref OrientedEdgeList_c list) {
		CAD.CADInterface.CAD_OrientedEdgeList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			OrientedEdge_c elt = new OrientedEdge_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(OrientedEdge_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static OrientedFaceList ConvertValue(ref OrientedFaceList_c s) {
		OrientedFaceList list = new OrientedFaceList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<OrientedFace>(s.ptr, (int)s.size);
		return list;
	}

	internal static OrientedFaceList_c ConvertValue(OrientedFaceList s, ref OrientedFaceList_c list) {
		CAD.CADInterface.CAD_OrientedFaceList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			OrientedFace_c elt = new OrientedFace_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(OrientedFace_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static BodyList ConvertValue(ref BodyList_c s) {
		BodyList list = new BodyList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static BodyList_c ConvertValue(BodyList s, ref BodyList_c list) {
		CAD.CADInterface.CAD_BodyList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static ModelList ConvertValue(ref ModelList_c s) {
		ModelList list = new ModelList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static ModelList_c ConvertValue(ModelList s, ref ModelList_c list) {
		CAD.CADInterface.CAD_ModelList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static ProfileLoop ConvertValue(ref ProfileLoop_c s) {
		ProfileLoop ss = new ProfileLoop();
		ss.edges = ConvertValue(ref s.edges);
		ss.isOuter = ConvertValue(s.isOuter);
		return ss;
	}

	internal static ProfileLoop_c ConvertValue(ProfileLoop s, ref ProfileLoop_c ss) {
		CAD.CADInterface.CAD_ProfileLoop_init(ref ss);
		ConvertValue(s.edges, ref ss.edges);
		ss.isOuter = ConvertValue(s.isOuter);
		return ss;
	}

	internal static SplittedEdge ConvertValue(ref SplittedEdge_c s) {
		SplittedEdge ss = new SplittedEdge();
		ss.oldEdge = (System.UInt32)s.oldEdge;
		ss.newEdges = ConvertValue(ref s.newEdges);
		return ss;
	}

	internal static SplittedEdge_c ConvertValue(SplittedEdge s, ref SplittedEdge_c ss) {
		CAD.CADInterface.CAD_SplittedEdge_init(ref ss);
		ss.oldEdge = (System.UInt32)s.oldEdge;
		ConvertValue(s.newEdges, ref ss.newEdges);
		return ss;
	}

	internal static SplittedEdgeList ConvertValue(ref SplittedEdgeList_c s) {
		SplittedEdgeList list = new SplittedEdgeList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(SplittedEdge_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			SplittedEdge_c value = (SplittedEdge_c)Marshal.PtrToStructure(p, typeof(SplittedEdge_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static SplittedEdgeList_c ConvertValue(SplittedEdgeList s, ref SplittedEdgeList_c list) {
		CAD.CADInterface.CAD_SplittedEdgeList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			SplittedEdge_c elt = new SplittedEdge_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(SplittedEdge_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static ProfileBase ConvertValue(ref ProfileBase_c s) {
		ProfileBase list = new ProfileBase((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(ProfileLoop_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			ProfileLoop_c value = (ProfileLoop_c)Marshal.PtrToStructure(p, typeof(ProfileLoop_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static ProfileBase_c ConvertValue(ProfileBase s, ref ProfileBase_c list) {
		CAD.CADInterface.CAD_ProfileBase_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			ProfileLoop_c elt = new ProfileLoop_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(ProfileLoop_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static FaceList ConvertValue(ref FaceList_c s) {
		FaceList list = new FaceList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static FaceList_c ConvertValue(FaceList s, ref FaceList_c list) {
		CAD.CADInterface.CAD_FaceList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static Bounds1D ConvertValue(ref Bounds1D_c s) {
		Bounds1D ss = new Bounds1D();
		ss.min = (System.Double)s.min;
		ss.max = (System.Double)s.max;
		return ss;
	}

	internal static Bounds1D_c ConvertValue(Bounds1D s, ref Bounds1D_c ss) {
		CAD.CADInterface.CAD_Bounds1D_init(ref ss);
		ss.min = (System.Double)s.min;
		ss.max = (System.Double)s.max;
		return ss;
	}

	internal static Bounds2D ConvertValue(ref Bounds2D_c s) {
		Bounds2D ss = new Bounds2D();
		ss.u = ConvertValue(ref s.u);
		ss.v = ConvertValue(ref s.v);
		return ss;
	}

	internal static Bounds2D_c ConvertValue(Bounds2D s, ref Bounds2D_c ss) {
		CAD.CADInterface.CAD_Bounds2D_init(ref ss);
		ConvertValue(s.u, ref ss.u);
		ConvertValue(s.v, ref ss.v);
		return ss;
	}

	internal static ProfileBaseList ConvertValue(ref ProfileBaseList_c s) {
		ProfileBaseList list = new ProfileBaseList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(ProfileBase_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			ProfileBase_c value = (ProfileBase_c)Marshal.PtrToStructure(p, typeof(ProfileBase_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static ProfileBaseList_c ConvertValue(ProfileBaseList s, ref ProfileBaseList_c list) {
		CAD.CADInterface.CAD_ProfileBaseList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			ProfileBase_c elt = new ProfileBase_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(ProfileBase_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static BrickDefinition ConvertValue(ref BrickDefinition_c s) {
		BrickDefinition ss = new BrickDefinition();
		ss.type = (BrickType)s.type;
		ss.length = (System.Int32)s.length;
		ss.width = (System.Int32)s.width;
		ss.fullHeight = ConvertValue(s.fullHeight);
		return ss;
	}

	internal static BrickDefinition_c ConvertValue(BrickDefinition s, ref BrickDefinition_c ss) {
		CAD.CADInterface.CAD_BrickDefinition_init(ref ss);
		ss.type = (Int32)s.type;
		ss.length = (Int32)s.length;
		ss.width = (Int32)s.width;
		ss.fullHeight = ConvertValue(s.fullHeight);
		return ss;
	}

	internal static OpenShellList ConvertValue(ref OpenShellList_c s) {
		OpenShellList list = new OpenShellList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static OpenShellList_c ConvertValue(OpenShellList s, ref OpenShellList_c list) {
		CAD.CADInterface.CAD_OpenShellList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static LoopList ConvertValue(ref LoopList_c s) {
		LoopList list = new LoopList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static LoopList_c ConvertValue(LoopList s, ref LoopList_c list) {
		CAD.CADInterface.CAD_LoopList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static VertexList ConvertValue(ref VertexList_c s) {
		VertexList list = new VertexList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static VertexList_c ConvertValue(VertexList s, ref VertexList_c list) {
		CAD.CADInterface.CAD_VertexList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static EdgeListList ConvertValue(ref EdgeListList_c s) {
		EdgeListList list = new EdgeListList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(EdgeList_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			EdgeList_c value = (EdgeList_c)Marshal.PtrToStructure(p, typeof(EdgeList_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static EdgeListList_c ConvertValue(EdgeListList s, ref EdgeListList_c list) {
		CAD.CADInterface.CAD_EdgeListList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			EdgeList_c elt = new EdgeList_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(EdgeList_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static ClosedShellList ConvertValue(ref ClosedShellList_c s) {
		ClosedShellList list = new ClosedShellList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static ClosedShellList_c ConvertValue(ClosedShellList s, ref ClosedShellList_c list) {
		CAD.CADInterface.CAD_ClosedShellList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static CurveListList ConvertValue(ref CurveListList_c s) {
		CurveListList list = new CurveListList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(CurveList_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			CurveList_c value = (CurveList_c)Marshal.PtrToStructure(p, typeof(CurveList_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static CurveListList_c ConvertValue(CurveListList s, ref CurveListList_c list) {
		CAD.CADInterface.CAD_CurveListList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			CurveList_c elt = new CurveList_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(CurveList_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static BrickDefinitionList ConvertValue(ref BrickDefinitionList_c s) {
		BrickDefinitionList list = new BrickDefinitionList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(BrickDefinition_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			BrickDefinition_c value = (BrickDefinition_c)Marshal.PtrToStructure(p, typeof(BrickDefinition_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static BrickDefinitionList_c ConvertValue(BrickDefinitionList s, ref BrickDefinitionList_c list) {
		CAD.CADInterface.CAD_BrickDefinitionList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			BrickDefinition_c elt = new BrickDefinition_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(BrickDefinition_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static BuildFacesReturn ConvertValue(ref BuildFacesReturn_c s) {
		BuildFacesReturn ss = new BuildFacesReturn();
		ss.faces = ConvertValue(ref s.faces);
		ss.splittingInfo = ConvertValue(ref s.splittingInfo);
		return ss;
	}

	internal static BuildFacesReturn_c ConvertValue(BuildFacesReturn s, ref BuildFacesReturn_c ss) {
		ConvertValue(s.faces, ref ss.faces);
		ConvertValue(s.splittingInfo, ref ss.splittingInfo);
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

	internal static EvalOnCurveReturn ConvertValue(ref EvalOnCurveReturn_c s) {
		EvalOnCurveReturn ss = new EvalOnCurveReturn();
		ss.d0 = Geom.GeomInterface.ConvertValue(ref s.d0);
		ss.du = Geom.GeomInterface.ConvertValue(ref s.du);
		ss.d2u = Geom.GeomInterface.ConvertValue(ref s.d2u);
		return ss;
	}

	internal static EvalOnCurveReturn_c ConvertValue(EvalOnCurveReturn s, ref EvalOnCurveReturn_c ss) {
		Geom.GeomInterface.ConvertValue(s.d0, ref ss.d0);
		Geom.GeomInterface.ConvertValue(s.du, ref ss.du);
		Geom.GeomInterface.ConvertValue(s.d2u, ref ss.d2u);
		return ss;
	}

	internal static EvalOnSurfaceReturn ConvertValue(ref EvalOnSurfaceReturn_c s) {
		EvalOnSurfaceReturn ss = new EvalOnSurfaceReturn();
		ss.d0 = Geom.GeomInterface.ConvertValue(ref s.d0);
		ss.du = Geom.GeomInterface.ConvertValue(ref s.du);
		ss.dv = Geom.GeomInterface.ConvertValue(ref s.dv);
		ss.d2u = Geom.GeomInterface.ConvertValue(ref s.d2u);
		ss.d2v = Geom.GeomInterface.ConvertValue(ref s.d2v);
		ss.duv = Geom.GeomInterface.ConvertValue(ref s.duv);
		return ss;
	}

	internal static EvalOnSurfaceReturn_c ConvertValue(EvalOnSurfaceReturn s, ref EvalOnSurfaceReturn_c ss) {
		Geom.GeomInterface.ConvertValue(s.d0, ref ss.d0);
		Geom.GeomInterface.ConvertValue(s.du, ref ss.du);
		Geom.GeomInterface.ConvertValue(s.dv, ref ss.dv);
		Geom.GeomInterface.ConvertValue(s.d2u, ref ss.d2u);
		Geom.GeomInterface.ConvertValue(s.d2v, ref ss.d2v);
		Geom.GeomInterface.ConvertValue(s.duv, ref ss.duv);
		return ss;
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

	internal static GetCircleCurveDefinitionReturn ConvertValue(ref GetCircleCurveDefinitionReturn_c s) {
		GetCircleCurveDefinitionReturn ss = new GetCircleCurveDefinitionReturn();
		ss.radius = (System.Double)s.radius;
		ss.matrix = Geom.GeomInterface.ConvertValue(ref s.matrix);
		return ss;
	}

	internal static GetCircleCurveDefinitionReturn_c ConvertValue(GetCircleCurveDefinitionReturn s, ref GetCircleCurveDefinitionReturn_c ss) {
		ss.radius = (System.Double)s.radius;
		Geom.GeomInterface.ConvertValue(s.matrix, ref ss.matrix);
		return ss;
	}

	internal static GetCoEdgeDefinitionReturn ConvertValue(ref GetCoEdgeDefinitionReturn_c s) {
		GetCoEdgeDefinitionReturn ss = new GetCoEdgeDefinitionReturn();
		ss.edge = (System.UInt32)s.edge;
		ss.edgeOrientation = ConvertValue(s.edgeOrientation);
		ss.loop = (System.UInt32)s.loop;
		ss.surface = (System.UInt32)s.surface;
		ss.parametricCurve = (System.UInt32)s.parametricCurve;
		return ss;
	}

	internal static GetCoEdgeDefinitionReturn_c ConvertValue(GetCoEdgeDefinitionReturn s, ref GetCoEdgeDefinitionReturn_c ss) {
		ss.edge = (System.UInt32)s.edge;
		ss.edgeOrientation = ConvertValue(s.edgeOrientation);
		ss.loop = (System.UInt32)s.loop;
		ss.surface = (System.UInt32)s.surface;
		ss.parametricCurve = (System.UInt32)s.parametricCurve;
		return ss;
	}

	internal static Core.DoubleList ConvertValue(ref Core.DoubleList_c s) {
		Core.DoubleList list = new Core.DoubleList((int)s.size);
		if (s.size > 0)
			Marshal.Copy(s.ptr, list.list, 0, (int)s.size);
		return list;
	}

	internal static Core.DoubleList_c ConvertValue(Core.DoubleList s, ref Core.DoubleList_c list) {
		Core.CoreInterface.Core_DoubleList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size > 0)
			Marshal.Copy(s.list, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static GetCompositeCurveDefinitionReturn ConvertValue(ref GetCompositeCurveDefinitionReturn_c s) {
		GetCompositeCurveDefinitionReturn ss = new GetCompositeCurveDefinitionReturn();
		ss.curves = ConvertValue(ref s.curves);
		ss.parameters = Core.CoreInterface.ConvertValue(ref s.parameters);
		return ss;
	}

	internal static GetCompositeCurveDefinitionReturn_c ConvertValue(GetCompositeCurveDefinitionReturn s, ref GetCompositeCurveDefinitionReturn_c ss) {
		ConvertValue(s.curves, ref ss.curves);
		Core.CoreInterface.ConvertValue(s.parameters, ref ss.parameters);
		return ss;
	}

	internal static GetConeSurfaceDefinitionReturn ConvertValue(ref GetConeSurfaceDefinitionReturn_c s) {
		GetConeSurfaceDefinitionReturn ss = new GetConeSurfaceDefinitionReturn();
		ss.radius = (System.Double)s.radius;
		ss.semiAngle = (System.Double)s.semiAngle;
		ss.matrix = Geom.GeomInterface.ConvertValue(ref s.matrix);
		return ss;
	}

	internal static GetConeSurfaceDefinitionReturn_c ConvertValue(GetConeSurfaceDefinitionReturn s, ref GetConeSurfaceDefinitionReturn_c ss) {
		ss.radius = (System.Double)s.radius;
		ss.semiAngle = (System.Double)s.semiAngle;
		Geom.GeomInterface.ConvertValue(s.matrix, ref ss.matrix);
		return ss;
	}

	internal static GetCurveExtrusionSurfaceDefinitionReturn ConvertValue(ref GetCurveExtrusionSurfaceDefinitionReturn_c s) {
		GetCurveExtrusionSurfaceDefinitionReturn ss = new GetCurveExtrusionSurfaceDefinitionReturn();
		ss.generatrixCurve = (System.UInt32)s.generatrixCurve;
		ss.directrixCruve = (System.UInt32)s.directrixCruve;
		ss.surfaceReference = (System.UInt32)s.surfaceReference;
		return ss;
	}

	internal static GetCurveExtrusionSurfaceDefinitionReturn_c ConvertValue(GetCurveExtrusionSurfaceDefinitionReturn s, ref GetCurveExtrusionSurfaceDefinitionReturn_c ss) {
		ss.generatrixCurve = (System.UInt32)s.generatrixCurve;
		ss.directrixCruve = (System.UInt32)s.directrixCruve;
		ss.surfaceReference = (System.UInt32)s.surfaceReference;
		return ss;
	}

	internal static GetCylinderSurfaceDefinitionReturn ConvertValue(ref GetCylinderSurfaceDefinitionReturn_c s) {
		GetCylinderSurfaceDefinitionReturn ss = new GetCylinderSurfaceDefinitionReturn();
		ss.radius = (System.Double)s.radius;
		ss.matrix = Geom.GeomInterface.ConvertValue(ref s.matrix);
		return ss;
	}

	internal static GetCylinderSurfaceDefinitionReturn_c ConvertValue(GetCylinderSurfaceDefinitionReturn s, ref GetCylinderSurfaceDefinitionReturn_c ss) {
		ss.radius = (System.Double)s.radius;
		Geom.GeomInterface.ConvertValue(s.matrix, ref ss.matrix);
		return ss;
	}

	internal static GetEdgeDefinitionReturn ConvertValue(ref GetEdgeDefinitionReturn_c s) {
		GetEdgeDefinitionReturn ss = new GetEdgeDefinitionReturn();
		ss.vertex1 = (System.UInt32)s.vertex1;
		ss.vertex2 = (System.UInt32)s.vertex2;
		ss.curve = (System.UInt32)s.curve;
		ss.bounds = ConvertValue(ref s.bounds);
		return ss;
	}

	internal static GetEdgeDefinitionReturn_c ConvertValue(GetEdgeDefinitionReturn s, ref GetEdgeDefinitionReturn_c ss) {
		ss.vertex1 = (System.UInt32)s.vertex1;
		ss.vertex2 = (System.UInt32)s.vertex2;
		ss.curve = (System.UInt32)s.curve;
		ConvertValue(s.bounds, ref ss.bounds);
		return ss;
	}

	internal static GetEllipseCurveDefinitionReturn ConvertValue(ref GetEllipseCurveDefinitionReturn_c s) {
		GetEllipseCurveDefinitionReturn ss = new GetEllipseCurveDefinitionReturn();
		ss.radius1 = (System.Double)s.radius1;
		ss.radius2 = (System.Double)s.radius2;
		ss.matrix = Geom.GeomInterface.ConvertValue(ref s.matrix);
		return ss;
	}

	internal static GetEllipseCurveDefinitionReturn_c ConvertValue(GetEllipseCurveDefinitionReturn s, ref GetEllipseCurveDefinitionReturn_c ss) {
		ss.radius1 = (System.Double)s.radius1;
		ss.radius2 = (System.Double)s.radius2;
		Geom.GeomInterface.ConvertValue(s.matrix, ref ss.matrix);
		return ss;
	}

	internal static GetEllipticConeSurfaceDefinitionReturn ConvertValue(ref GetEllipticConeSurfaceDefinitionReturn_c s) {
		GetEllipticConeSurfaceDefinitionReturn ss = new GetEllipticConeSurfaceDefinitionReturn();
		ss.radius1 = (System.Double)s.radius1;
		ss.radius2 = (System.Double)s.radius2;
		ss.semiAngle = (System.Double)s.semiAngle;
		ss.matrix = Geom.GeomInterface.ConvertValue(ref s.matrix);
		return ss;
	}

	internal static GetEllipticConeSurfaceDefinitionReturn_c ConvertValue(GetEllipticConeSurfaceDefinitionReturn s, ref GetEllipticConeSurfaceDefinitionReturn_c ss) {
		ss.radius1 = (System.Double)s.radius1;
		ss.radius2 = (System.Double)s.radius2;
		ss.semiAngle = (System.Double)s.semiAngle;
		Geom.GeomInterface.ConvertValue(s.matrix, ref ss.matrix);
		return ss;
	}

	internal static GetFaceDefinitionReturn ConvertValue(ref GetFaceDefinitionReturn_c s) {
		GetFaceDefinitionReturn ss = new GetFaceDefinitionReturn();
		ss.surface = (System.UInt32)s.surface;
		ss.loops = ConvertValue(ref s.loops);
		ss.orientation = ConvertValue(s.orientation);
		ss.limits = ConvertValue(ref s.limits);
		return ss;
	}

	internal static GetFaceDefinitionReturn_c ConvertValue(GetFaceDefinitionReturn s, ref GetFaceDefinitionReturn_c ss) {
		ss.surface = (System.UInt32)s.surface;
		ConvertValue(s.loops, ref ss.loops);
		ss.orientation = ConvertValue(s.orientation);
		ConvertValue(s.limits, ref ss.limits);
		return ss;
	}

	internal static GetHelixCurveDefinitionReturn ConvertValue(ref GetHelixCurveDefinitionReturn_c s) {
		GetHelixCurveDefinitionReturn ss = new GetHelixCurveDefinitionReturn();
		ss.radius = (System.Double)s.radius;
		ss.matrix = Geom.GeomInterface.ConvertValue(ref s.matrix);
		ss.trigonometricOrientation = ConvertValue(s.trigonometricOrientation);
		return ss;
	}

	internal static GetHelixCurveDefinitionReturn_c ConvertValue(GetHelixCurveDefinitionReturn s, ref GetHelixCurveDefinitionReturn_c ss) {
		ss.radius = (System.Double)s.radius;
		Geom.GeomInterface.ConvertValue(s.matrix, ref ss.matrix);
		ss.trigonometricOrientation = ConvertValue(s.trigonometricOrientation);
		return ss;
	}

	internal static GetHermiteCurveDefinitionReturn ConvertValue(ref GetHermiteCurveDefinitionReturn_c s) {
		GetHermiteCurveDefinitionReturn ss = new GetHermiteCurveDefinitionReturn();
		ss.firstPoint = Geom.GeomInterface.ConvertValue(ref s.firstPoint);
		ss.secondPoint = Geom.GeomInterface.ConvertValue(ref s.secondPoint);
		ss.firstTangent = Geom.GeomInterface.ConvertValue(ref s.firstTangent);
		ss.secondTangent = Geom.GeomInterface.ConvertValue(ref s.secondTangent);
		return ss;
	}

	internal static GetHermiteCurveDefinitionReturn_c ConvertValue(GetHermiteCurveDefinitionReturn s, ref GetHermiteCurveDefinitionReturn_c ss) {
		Geom.GeomInterface.ConvertValue(s.firstPoint, ref ss.firstPoint);
		Geom.GeomInterface.ConvertValue(s.secondPoint, ref ss.secondPoint);
		Geom.GeomInterface.ConvertValue(s.firstTangent, ref ss.firstTangent);
		Geom.GeomInterface.ConvertValue(s.secondTangent, ref ss.secondTangent);
		return ss;
	}

	internal static GetHyperbolaCurveDefinitionReturn ConvertValue(ref GetHyperbolaCurveDefinitionReturn_c s) {
		GetHyperbolaCurveDefinitionReturn ss = new GetHyperbolaCurveDefinitionReturn();
		ss.radius1 = (System.Double)s.radius1;
		ss.radius2 = (System.Double)s.radius2;
		ss.matrix = Geom.GeomInterface.ConvertValue(ref s.matrix);
		return ss;
	}

	internal static GetHyperbolaCurveDefinitionReturn_c ConvertValue(GetHyperbolaCurveDefinitionReturn s, ref GetHyperbolaCurveDefinitionReturn_c ss) {
		ss.radius1 = (System.Double)s.radius1;
		ss.radius2 = (System.Double)s.radius2;
		Geom.GeomInterface.ConvertValue(s.matrix, ref ss.matrix);
		return ss;
	}

	internal static GetIntersectionCurveDefinitionReturn ConvertValue(ref GetIntersectionCurveDefinitionReturn_c s) {
		GetIntersectionCurveDefinitionReturn ss = new GetIntersectionCurveDefinitionReturn();
		ss.surface1 = (System.UInt32)s.surface1;
		ss.surface2 = (System.UInt32)s.surface2;
		ss.chart = (System.UInt32)s.chart;
		ss.bounds = ConvertValue(ref s.bounds);
		return ss;
	}

	internal static GetIntersectionCurveDefinitionReturn_c ConvertValue(GetIntersectionCurveDefinitionReturn s, ref GetIntersectionCurveDefinitionReturn_c ss) {
		ss.surface1 = (System.UInt32)s.surface1;
		ss.surface2 = (System.UInt32)s.surface2;
		ss.chart = (System.UInt32)s.chart;
		ConvertValue(s.bounds, ref ss.bounds);
		return ss;
	}

	internal static GetLineCurveDefinitionReturn ConvertValue(ref GetLineCurveDefinitionReturn_c s) {
		GetLineCurveDefinitionReturn ss = new GetLineCurveDefinitionReturn();
		ss.origin = Geom.GeomInterface.ConvertValue(ref s.origin);
		ss.direction = Geom.GeomInterface.ConvertValue(ref s.direction);
		return ss;
	}

	internal static GetLineCurveDefinitionReturn_c ConvertValue(GetLineCurveDefinitionReturn s, ref GetLineCurveDefinitionReturn_c ss) {
		Geom.GeomInterface.ConvertValue(s.origin, ref ss.origin);
		Geom.GeomInterface.ConvertValue(s.direction, ref ss.direction);
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

	internal static GetNURBSCurveDefinitionReturn ConvertValue(ref GetNURBSCurveDefinitionReturn_c s) {
		GetNURBSCurveDefinitionReturn ss = new GetNURBSCurveDefinitionReturn();
		ss.degree = (System.Int32)s.degree;
		ss.knots = Core.CoreInterface.ConvertValue(ref s.knots);
		ss.poles = Geom.GeomInterface.ConvertValue(ref s.poles);
		ss.weights = Core.CoreInterface.ConvertValue(ref s.weights);
		return ss;
	}

	internal static GetNURBSCurveDefinitionReturn_c ConvertValue(GetNURBSCurveDefinitionReturn s, ref GetNURBSCurveDefinitionReturn_c ss) {
		ss.degree = (Int32)s.degree;
		Core.CoreInterface.ConvertValue(s.knots, ref ss.knots);
		Geom.GeomInterface.ConvertValue(s.poles, ref ss.poles);
		Core.CoreInterface.ConvertValue(s.weights, ref ss.weights);
		return ss;
	}

	internal static Geom.Point3ListList ConvertValue(ref Geom.Point3ListList_c s) {
		Geom.Point3ListList list = new Geom.Point3ListList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(Geom.Point3List_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			Geom.Point3List_c value = (Geom.Point3List_c)Marshal.PtrToStructure(p, typeof(Geom.Point3List_c));
			list.list[i] = Geom.GeomInterface.ConvertValue(ref value);
		}
		return list;
	}

	internal static Geom.Point3ListList_c ConvertValue(Geom.Point3ListList s, ref Geom.Point3ListList_c list) {
		Geom.GeomInterface.Geom_Point3ListList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Geom.Point3List_c elt = new Geom.Point3List_c();
			Geom.GeomInterface.ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Geom.Point3List_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Core.DoubleListList ConvertValue(ref Core.DoubleListList_c s) {
		Core.DoubleListList list = new Core.DoubleListList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(Core.DoubleList_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			Core.DoubleList_c value = (Core.DoubleList_c)Marshal.PtrToStructure(p, typeof(Core.DoubleList_c));
			list.list[i] = Core.CoreInterface.ConvertValue(ref value);
		}
		return list;
	}

	internal static Core.DoubleListList_c ConvertValue(Core.DoubleListList s, ref Core.DoubleListList_c list) {
		Core.CoreInterface.Core_DoubleListList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Core.DoubleList_c elt = new Core.DoubleList_c();
			Core.CoreInterface.ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Core.DoubleList_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static GetNURBSSurfaceDefinitionReturn ConvertValue(ref GetNURBSSurfaceDefinitionReturn_c s) {
		GetNURBSSurfaceDefinitionReturn ss = new GetNURBSSurfaceDefinitionReturn();
		ss.degreeU = (System.Int32)s.degreeU;
		ss.degreeV = (System.Int32)s.degreeV;
		ss.knotsU = Core.CoreInterface.ConvertValue(ref s.knotsU);
		ss.knotsV = Core.CoreInterface.ConvertValue(ref s.knotsV);
		ss.poles = Geom.GeomInterface.ConvertValue(ref s.poles);
		ss.weights = Core.CoreInterface.ConvertValue(ref s.weights);
		return ss;
	}

	internal static GetNURBSSurfaceDefinitionReturn_c ConvertValue(GetNURBSSurfaceDefinitionReturn s, ref GetNURBSSurfaceDefinitionReturn_c ss) {
		ss.degreeU = (Int32)s.degreeU;
		ss.degreeV = (Int32)s.degreeV;
		Core.CoreInterface.ConvertValue(s.knotsU, ref ss.knotsU);
		Core.CoreInterface.ConvertValue(s.knotsV, ref ss.knotsV);
		Geom.GeomInterface.ConvertValue(s.poles, ref ss.poles);
		Core.CoreInterface.ConvertValue(s.weights, ref ss.weights);
		return ss;
	}

	internal static GetOffsetCurveDefinitionReturn ConvertValue(ref GetOffsetCurveDefinitionReturn_c s) {
		GetOffsetCurveDefinitionReturn ss = new GetOffsetCurveDefinitionReturn();
		ss.curve = (System.UInt32)s.curve;
		ss.direction = Geom.GeomInterface.ConvertValue(ref s.direction);
		ss.distance = (System.Double)s.distance;
		ss.surfaceReference = (System.UInt32)s.surfaceReference;
		return ss;
	}

	internal static GetOffsetCurveDefinitionReturn_c ConvertValue(GetOffsetCurveDefinitionReturn s, ref GetOffsetCurveDefinitionReturn_c ss) {
		ss.curve = (System.UInt32)s.curve;
		Geom.GeomInterface.ConvertValue(s.direction, ref ss.direction);
		ss.distance = (System.Double)s.distance;
		ss.surfaceReference = (System.UInt32)s.surfaceReference;
		return ss;
	}

	internal static GetOffsetSurfaceDefinitionReturn ConvertValue(ref GetOffsetSurfaceDefinitionReturn_c s) {
		GetOffsetSurfaceDefinitionReturn ss = new GetOffsetSurfaceDefinitionReturn();
		ss.baseSurface = (System.UInt32)s.baseSurface;
		ss.distance = (System.Double)s.distance;
		return ss;
	}

	internal static GetOffsetSurfaceDefinitionReturn_c ConvertValue(GetOffsetSurfaceDefinitionReturn s, ref GetOffsetSurfaceDefinitionReturn_c ss) {
		ss.baseSurface = (System.UInt32)s.baseSurface;
		ss.distance = (System.Double)s.distance;
		return ss;
	}

	internal static GetParabolaCurveDefinitionReturn ConvertValue(ref GetParabolaCurveDefinitionReturn_c s) {
		GetParabolaCurveDefinitionReturn ss = new GetParabolaCurveDefinitionReturn();
		ss.focalLength = (System.Double)s.focalLength;
		ss.matrix = Geom.GeomInterface.ConvertValue(ref s.matrix);
		return ss;
	}

	internal static GetParabolaCurveDefinitionReturn_c ConvertValue(GetParabolaCurveDefinitionReturn s, ref GetParabolaCurveDefinitionReturn_c ss) {
		ss.focalLength = (System.Double)s.focalLength;
		Geom.GeomInterface.ConvertValue(s.matrix, ref ss.matrix);
		return ss;
	}

	internal static GetPolylineCurveDefinitionReturn ConvertValue(ref GetPolylineCurveDefinitionReturn_c s) {
		GetPolylineCurveDefinitionReturn ss = new GetPolylineCurveDefinitionReturn();
		ss.points = Geom.GeomInterface.ConvertValue(ref s.points);
		ss.parameters = Core.CoreInterface.ConvertValue(ref s.parameters);
		return ss;
	}

	internal static GetPolylineCurveDefinitionReturn_c ConvertValue(GetPolylineCurveDefinitionReturn s, ref GetPolylineCurveDefinitionReturn_c ss) {
		Geom.GeomInterface.ConvertValue(s.points, ref ss.points);
		Core.CoreInterface.ConvertValue(s.parameters, ref ss.parameters);
		return ss;
	}

	internal static GetRevolutionSurfaceDefinitionReturn ConvertValue(ref GetRevolutionSurfaceDefinitionReturn_c s) {
		GetRevolutionSurfaceDefinitionReturn ss = new GetRevolutionSurfaceDefinitionReturn();
		ss.generatricCurve = (System.UInt32)s.generatricCurve;
		ss.axisOrigin = Geom.GeomInterface.ConvertValue(ref s.axisOrigin);
		ss.axisDirection = Geom.GeomInterface.ConvertValue(ref s.axisDirection);
		ss.startAngle = (System.Double)s.startAngle;
		ss.endAngle = (System.Double)s.endAngle;
		return ss;
	}

	internal static GetRevolutionSurfaceDefinitionReturn_c ConvertValue(GetRevolutionSurfaceDefinitionReturn s, ref GetRevolutionSurfaceDefinitionReturn_c ss) {
		ss.generatricCurve = (System.UInt32)s.generatricCurve;
		Geom.GeomInterface.ConvertValue(s.axisOrigin, ref ss.axisOrigin);
		Geom.GeomInterface.ConvertValue(s.axisDirection, ref ss.axisDirection);
		ss.startAngle = (System.Double)s.startAngle;
		ss.endAngle = (System.Double)s.endAngle;
		return ss;
	}

	internal static GetRuledSurfaceDefinitionReturn ConvertValue(ref GetRuledSurfaceDefinitionReturn_c s) {
		GetRuledSurfaceDefinitionReturn ss = new GetRuledSurfaceDefinitionReturn();
		ss.firstCurve = (System.UInt32)s.firstCurve;
		ss.secondCurve = (System.UInt32)s.secondCurve;
		return ss;
	}

	internal static GetRuledSurfaceDefinitionReturn_c ConvertValue(GetRuledSurfaceDefinitionReturn s, ref GetRuledSurfaceDefinitionReturn_c ss) {
		ss.firstCurve = (System.UInt32)s.firstCurve;
		ss.secondCurve = (System.UInt32)s.secondCurve;
		return ss;
	}

	internal static GetSegmentCurveDefinitionReturn ConvertValue(ref GetSegmentCurveDefinitionReturn_c s) {
		GetSegmentCurveDefinitionReturn ss = new GetSegmentCurveDefinitionReturn();
		ss.startPoint = Geom.GeomInterface.ConvertValue(ref s.startPoint);
		ss.endPoint = Geom.GeomInterface.ConvertValue(ref s.endPoint);
		return ss;
	}

	internal static GetSegmentCurveDefinitionReturn_c ConvertValue(GetSegmentCurveDefinitionReturn s, ref GetSegmentCurveDefinitionReturn_c ss) {
		Geom.GeomInterface.ConvertValue(s.startPoint, ref ss.startPoint);
		Geom.GeomInterface.ConvertValue(s.endPoint, ref ss.endPoint);
		return ss;
	}

	internal static GetSphereSurfaceDefinitionReturn ConvertValue(ref GetSphereSurfaceDefinitionReturn_c s) {
		GetSphereSurfaceDefinitionReturn ss = new GetSphereSurfaceDefinitionReturn();
		ss.radius = (System.Double)s.radius;
		ss.matrix = Geom.GeomInterface.ConvertValue(ref s.matrix);
		return ss;
	}

	internal static GetSphereSurfaceDefinitionReturn_c ConvertValue(GetSphereSurfaceDefinitionReturn s, ref GetSphereSurfaceDefinitionReturn_c ss) {
		ss.radius = (System.Double)s.radius;
		Geom.GeomInterface.ConvertValue(s.matrix, ref ss.matrix);
		return ss;
	}

	internal static GetSurfacicCurveDefinitionReturn ConvertValue(ref GetSurfacicCurveDefinitionReturn_c s) {
		GetSurfacicCurveDefinitionReturn ss = new GetSurfacicCurveDefinitionReturn();
		ss.surface = (System.UInt32)s.surface;
		ss.curve2D = (System.UInt32)s.curve2D;
		return ss;
	}

	internal static GetSurfacicCurveDefinitionReturn_c ConvertValue(GetSurfacicCurveDefinitionReturn s, ref GetSurfacicCurveDefinitionReturn_c ss) {
		ss.surface = (System.UInt32)s.surface;
		ss.curve2D = (System.UInt32)s.curve2D;
		return ss;
	}

	internal static GetTabulatedCylinderSurfaceDefinitionReturn ConvertValue(ref GetTabulatedCylinderSurfaceDefinitionReturn_c s) {
		GetTabulatedCylinderSurfaceDefinitionReturn ss = new GetTabulatedCylinderSurfaceDefinitionReturn();
		ss.directrixCurve = (System.UInt32)s.directrixCurve;
		ss.generatrixLine = Geom.GeomInterface.ConvertValue(ref s.generatrixLine);
		ss.range = ConvertValue(ref s.range);
		return ss;
	}

	internal static GetTabulatedCylinderSurfaceDefinitionReturn_c ConvertValue(GetTabulatedCylinderSurfaceDefinitionReturn s, ref GetTabulatedCylinderSurfaceDefinitionReturn_c ss) {
		ss.directrixCurve = (System.UInt32)s.directrixCurve;
		Geom.GeomInterface.ConvertValue(s.generatrixLine, ref ss.generatrixLine);
		ConvertValue(s.range, ref ss.range);
		return ss;
	}

	internal static GetTorusSurfaceDefinitionReturn ConvertValue(ref GetTorusSurfaceDefinitionReturn_c s) {
		GetTorusSurfaceDefinitionReturn ss = new GetTorusSurfaceDefinitionReturn();
		ss.majorRadius = (System.Double)s.majorRadius;
		ss.minorRadius = (System.Double)s.minorRadius;
		ss.matrix = Geom.GeomInterface.ConvertValue(ref s.matrix);
		ss.type = (System.Int32)s.type;
		return ss;
	}

	internal static GetTorusSurfaceDefinitionReturn_c ConvertValue(GetTorusSurfaceDefinitionReturn s, ref GetTorusSurfaceDefinitionReturn_c ss) {
		ss.majorRadius = (System.Double)s.majorRadius;
		ss.minorRadius = (System.Double)s.minorRadius;
		Geom.GeomInterface.ConvertValue(s.matrix, ref ss.matrix);
		ss.type = (Int32)s.type;
		return ss;
	}

	internal static GetTransformedCurveDefinitionReturn ConvertValue(ref GetTransformedCurveDefinitionReturn_c s) {
		GetTransformedCurveDefinitionReturn ss = new GetTransformedCurveDefinitionReturn();
		ss.curve = (System.UInt32)s.curve;
		ss.matrix = Geom.GeomInterface.ConvertValue(ref s.matrix);
		return ss;
	}

	internal static GetTransformedCurveDefinitionReturn_c ConvertValue(GetTransformedCurveDefinitionReturn s, ref GetTransformedCurveDefinitionReturn_c ss) {
		ss.curve = (System.UInt32)s.curve;
		Geom.GeomInterface.ConvertValue(s.matrix, ref ss.matrix);
		return ss;
	}

	internal static IsCurvePeriodicReturn ConvertValue(ref IsCurvePeriodicReturn_c s) {
		IsCurvePeriodicReturn ss = new IsCurvePeriodicReturn();
		ss.periodic = ConvertValue(s.periodic);
		ss.period = (System.Double)s.period;
		return ss;
	}

	internal static IsCurvePeriodicReturn_c ConvertValue(IsCurvePeriodicReturn s, ref IsCurvePeriodicReturn_c ss) {
		ss.periodic = ConvertValue(s.periodic);
		ss.period = (System.Double)s.period;
		return ss;
	}

	internal static IsSurfaceClosedReturn ConvertValue(ref IsSurfaceClosedReturn_c s) {
		IsSurfaceClosedReturn ss = new IsSurfaceClosedReturn();
		ss.closedU = ConvertValue(s.closedU);
		ss.closedV = ConvertValue(s.closedV);
		return ss;
	}

	internal static IsSurfaceClosedReturn_c ConvertValue(IsSurfaceClosedReturn s, ref IsSurfaceClosedReturn_c ss) {
		ss.closedU = ConvertValue(s.closedU);
		ss.closedV = ConvertValue(s.closedV);
		return ss;
	}

	internal static IsSurfacePeriodicReturn ConvertValue(ref IsSurfacePeriodicReturn_c s) {
		IsSurfacePeriodicReturn ss = new IsSurfacePeriodicReturn();
		ss.periodicU = ConvertValue(s.periodicU);
		ss.periodicV = ConvertValue(s.periodicV);
		ss.periodU = (System.Double)s.periodU;
		ss.periodV = (System.Double)s.periodV;
		return ss;
	}

	internal static IsSurfacePeriodicReturn_c ConvertValue(IsSurfacePeriodicReturn s, ref IsSurfacePeriodicReturn_c ss) {
		ss.periodicU = ConvertValue(s.periodicU);
		ss.periodicV = ConvertValue(s.periodicV);
		ss.periodU = (System.Double)s.periodU;
		ss.periodV = (System.Double)s.periodV;
		return ss;
	}

		#endregion

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr CAD_getLastError();

		public static string GetLastError()
		{
			return ConvertValue(CAD_getLastError());
		}

		#region 

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void CAD_configureFunctionLogger(IntPtr _pxz_session_, string functionName, System.Byte enableFunction, System.Byte enableParameters, System.Byte enableExecutionTime);

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
				CAD_configureFunctionLogger(api.Session, functionName, Convert.ToByte(enableFunction), Convert.ToByte(enableParameters), Convert.ToByte(enableExecutionTime));
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Double CAD_getPrecision(IntPtr _pxz_session_);

		/// <summary>
		/// Get the CAD precision
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Double GetPrecision() {
			try {
				var ret = CAD_getPrecision(api.Session);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern void CAD_setUnitLength(IntPtr _pxz_session_, System.Double precision);

		/// <summary>
		/// Set the CAD unity length property
		/// </summary>
		/// <param name="precision">Unit length</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetUnitLength(System.Double precision) {
			try {
				CAD_setUnitLength(api.Session, precision);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region Boolean Operators

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern BodyList_c CAD_solidIntersection(IntPtr _pxz_session_, System.UInt32 A, System.UInt32 B);

		/// <summary>
		/// perform boolean operation intersection on two bodies (A ^ B)
		/// </summary>
		/// <param name="A">The first body</param>
		/// <param name="B">The second body</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public BodyList SolidIntersection(System.UInt32 A, System.UInt32 B) {
			try {
				var ret = CAD_solidIntersection(api.Session, A, B);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				CAD.CADInterface.CAD_BodyList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern BodyList_c CAD_solidSubtraction(IntPtr _pxz_session_, System.UInt32 A, System.UInt32 B);

		/// <summary>
		/// perform boolean operation subtraction on two bodies (A - B)
		/// </summary>
		/// <param name="A">The first body</param>
		/// <param name="B">The second body</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public BodyList SolidSubtraction(System.UInt32 A, System.UInt32 B) {
			try {
				var ret = CAD_solidSubtraction(api.Session, A, B);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				CAD.CADInterface.CAD_BodyList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern BodyList_c CAD_solidUnion(IntPtr _pxz_session_, System.UInt32 A, System.UInt32 B);

		/// <summary>
		/// perform boolean operation union on two bodies (A + B)
		/// </summary>
		/// <param name="A">The first body</param>
		/// <param name="B">The second body</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public BodyList SolidUnion(System.UInt32 A, System.UInt32 B) {
			try {
				var ret = CAD_solidUnion(api.Session, A, B);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				CAD.CADInterface.CAD_BodyList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region curves

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 CAD_createBezierCurve(IntPtr _pxz_session_, Geom.Point3List_c poles);

		/// <summary>
		/// Create a Bezier curve
		/// </summary>
		/// <param name="poles">Poles list</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateBezierCurve(Geom.Point3List poles) {
			try {
				var poles_c = new Geom.Point3List_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3List)poles, ref poles_c);
				var ret = CAD_createBezierCurve(api.Session, poles_c);
				Geom.GeomInterface.Geom_Point3List_free(ref poles_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createCircleCurve(IntPtr _pxz_session_, System.Double radius, Geom.Matrix4_c matrix);

		/// <summary>
		/// Create a new circle
		/// </summary>
		/// <param name="radius">Circle radius</param>
		/// <param name="matrix">Transformation matrix</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateCircleCurve(System.Double radius, Geom.Matrix4 matrix) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				var ret = CAD_createCircleCurve(api.Session, radius, matrix_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createCompositeCurve(IntPtr _pxz_session_, CurveList_c CurveList);

		/// <summary>
		/// Create a composite curve from a list of limited curves
		/// </summary>
		/// <param name="CurveList">List of limited curves</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateCompositeCurve(CurveList CurveList) {
			try {
				var CurveList_c = new CAD.CurveList_c();
				ConvertValue((CAD.CurveList)CurveList, ref CurveList_c);
				var ret = CAD_createCompositeCurve(api.Session, CurveList_c);
				CAD.CADInterface.CAD_CurveList_free(ref CurveList_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createCosinusCurve(IntPtr _pxz_session_, System.Double Amplitude, System.Double Offset, System.Double Period, Geom.Matrix4_c matrix);

		/// <summary>
		/// Create a cosinus curve
		/// </summary>
		/// <param name="Amplitude">Cosinus amplitude</param>
		/// <param name="Offset">Cosinus offset</param>
		/// <param name="Period">Cosinus period</param>
		/// <param name="matrix">Transformation matrix</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateCosinusCurve(System.Double Amplitude, System.Double Offset, System.Double Period, Geom.Matrix4 matrix) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				var ret = CAD_createCosinusCurve(api.Session, Amplitude, Offset, Period, matrix_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createEllipseCurve(IntPtr _pxz_session_, System.Double URadius, System.Double VRadius, Geom.Matrix4_c matrix);

		/// <summary>
		/// Create an ellipse curve
		/// </summary>
		/// <param name="URadius">Ellipse radius in u direction</param>
		/// <param name="VRadius">Ellipse radius in v direction</param>
		/// <param name="matrix">Transformation matrix</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateEllipseCurve(System.Double URadius, System.Double VRadius, Geom.Matrix4 matrix) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				var ret = CAD_createEllipseCurve(api.Session, URadius, VRadius, matrix_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createHelixCurve(IntPtr _pxz_session_, System.Double radius, System.Double pitch, Geom.Matrix4_c matrix, System.Byte trigonometrixOrientation);

		/// <summary>
		/// Create an helix curve
		/// </summary>
		/// <param name="radius">Radius of the helix</param>
		/// <param name="pitch">Height of one revolution</param>
		/// <param name="matrix">Transformation matrix</param>
		/// <param name="trigonometrixOrientation">Orientation of the rotation</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateHelixCurve(System.Double radius, System.Double pitch, Geom.Matrix4 matrix, System.Boolean trigonometrixOrientation = true) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				var ret = CAD_createHelixCurve(api.Session, radius, pitch, matrix_c, Convert.ToByte(trigonometrixOrientation));
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createHermiteCurve(IntPtr _pxz_session_, Geom.Point3_c FirstPoint, Geom.Point3_c FirstTangent, Geom.Point3_c SecondPoint, Geom.Point3_c SecondTangent);

		/// <summary>
		/// Create a Hermite Curve
		/// </summary>
		/// <param name="FirstPoint">Starting point of the curve</param>
		/// <param name="FirstTangent">Tangent of the starting point</param>
		/// <param name="SecondPoint">Ending point of the curve</param>
		/// <param name="SecondTangent">Tangent of the ending point</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateHermiteCurve(Geom.Point3 FirstPoint, Geom.Point3 FirstTangent, Geom.Point3 SecondPoint, Geom.Point3 SecondTangent) {
			try {
				var FirstPoint_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)FirstPoint, ref FirstPoint_c);
				var FirstTangent_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)FirstTangent, ref FirstTangent_c);
				var SecondPoint_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)SecondPoint, ref SecondPoint_c);
				var SecondTangent_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)SecondTangent, ref SecondTangent_c);
				var ret = CAD_createHermiteCurve(api.Session, FirstPoint_c, FirstTangent_c, SecondPoint_c, SecondTangent_c);
				Geom.GeomInterface.Geom_Point3_free(ref FirstPoint_c);
				Geom.GeomInterface.Geom_Point3_free(ref FirstTangent_c);
				Geom.GeomInterface.Geom_Point3_free(ref SecondPoint_c);
				Geom.GeomInterface.Geom_Point3_free(ref SecondTangent_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createHyperbolaCurve(IntPtr _pxz_session_, System.Double URadius, System.Double VRadius, Geom.Matrix4_c matrix);

		/// <summary>
		/// Create an hyperBola curve
		/// </summary>
		/// <param name="URadius">Hyperbola radius in u direction</param>
		/// <param name="VRadius">Hyperbola radius in v direction</param>
		/// <param name="matrix">Transformation matrix</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateHyperbolaCurve(System.Double URadius, System.Double VRadius, Geom.Matrix4 matrix) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				var ret = CAD_createHyperbolaCurve(api.Session, URadius, VRadius, matrix_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createIntersectionCurve(IntPtr _pxz_session_, System.UInt32 firstSurface, System.UInt32 secondSurface, System.UInt32 chart, System.Double minBounds, System.Double maxBounds);

		/// <summary>
		/// Create a Intersection Curve
		/// </summary>
		/// <param name="firstSurface">First surface of the intersection curve</param>
		/// <param name="secondSurface">Second surface of the intersection curve</param>
		/// <param name="chart">Direction curve of the intersection curve</param>
		/// <param name="minBounds">Minimum value of the bounds of the intersection curve</param>
		/// <param name="maxBounds">Maximum value of the bounds of the intersection curve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateIntersectionCurve(System.UInt32 firstSurface, System.UInt32 secondSurface, System.UInt32 chart, System.Double minBounds, System.Double maxBounds) {
			try {
				var ret = CAD_createIntersectionCurve(api.Session, firstSurface, secondSurface, chart, minBounds, maxBounds);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createLineCurve(IntPtr _pxz_session_, Geom.Point3_c OriginPt, Geom.Point3_c DirectionPt);

		/// <summary>
		/// Create a Line Curve
		/// </summary>
		/// <param name="OriginPt">Orinin point of the line curve</param>
		/// <param name="DirectionPt">Direction vector of the line curve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateLineCurve(Geom.Point3 OriginPt, Geom.Point3 DirectionPt) {
			try {
				var OriginPt_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)OriginPt, ref OriginPt_c);
				var DirectionPt_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)DirectionPt, ref DirectionPt_c);
				var ret = CAD_createLineCurve(api.Session, OriginPt_c, DirectionPt_c);
				Geom.GeomInterface.Geom_Point3_free(ref OriginPt_c);
				Geom.GeomInterface.Geom_Point3_free(ref DirectionPt_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createNURBSCurve(IntPtr _pxz_session_, Int32 degree, Core.DoubleList_c knots, Geom.Point3List_c poles, Core.DoubleList_c weights);

		/// <summary>
		/// Create a NURBS curve
		/// </summary>
		/// <param name="degree">Degree of the curve</param>
		/// <param name="knots">Knots of the curve</param>
		/// <param name="poles">Poles list</param>
		/// <param name="weights">Weight list</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateNURBSCurve(System.Int32 degree, Core.DoubleList knots, Geom.Point3List poles, Core.DoubleList weights = null) {
			weights = weights ?? new Core.DoubleList(new System.Double[] {});
			try {
				var knots_c = new Core.DoubleList_c();
				Core.CoreInterface.ConvertValue((Core.DoubleList)knots, ref knots_c);
				var poles_c = new Geom.Point3List_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3List)poles, ref poles_c);
				var weights_c = new Core.DoubleList_c();
				Core.CoreInterface.ConvertValue((Core.DoubleList)weights, ref weights_c);
				var ret = CAD_createNURBSCurve(api.Session, degree, knots_c, poles_c, weights_c);
				Core.CoreInterface.Core_DoubleList_free(ref knots_c);
				Geom.GeomInterface.Geom_Point3List_free(ref poles_c);
				Core.CoreInterface.Core_DoubleList_free(ref weights_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createParabolaCurve(IntPtr _pxz_session_, System.Double focalLength, Geom.Matrix4_c matrix);

		/// <summary>
		/// Create an parabola curve
		/// </summary>
		/// <param name="focalLength">Focal lecngth of the parabola</param>
		/// <param name="matrix">Transformation matrix</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateParabolaCurve(System.Double focalLength, Geom.Matrix4 matrix) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				var ret = CAD_createParabolaCurve(api.Session, focalLength, matrix_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createPolylineCurve(IntPtr _pxz_session_, Geom.Point3List_c points, Core.DoubleList_c parameters);

		/// <summary>
		/// Create a Polyline curve
		/// </summary>
		/// <param name="points">Points of polyline curve</param>
		/// <param name="parameters">Params of polyline curve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreatePolylineCurve(Geom.Point3List points, Core.DoubleList parameters = null) {
			parameters = parameters ?? new Core.DoubleList(new System.Double[] {});
			try {
				var points_c = new Geom.Point3List_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3List)points, ref points_c);
				var parameters_c = new Core.DoubleList_c();
				Core.CoreInterface.ConvertValue((Core.DoubleList)parameters, ref parameters_c);
				var ret = CAD_createPolylineCurve(api.Session, points_c, parameters_c);
				Geom.GeomInterface.Geom_Point3List_free(ref points_c);
				Core.CoreInterface.Core_DoubleList_free(ref parameters_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createSegmentCurve(IntPtr _pxz_session_, Geom.Point3_c firstPoint, Geom.Point3_c secondPoint);

		/// <summary>
		/// Create a segment curve from two given points
		/// </summary>
		/// <param name="firstPoint">First point</param>
		/// <param name="secondPoint">Second point</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateSegmentCurve(Geom.Point3 firstPoint, Geom.Point3 secondPoint) {
			try {
				var firstPoint_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)firstPoint, ref firstPoint_c);
				var secondPoint_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)secondPoint, ref secondPoint_c);
				var ret = CAD_createSegmentCurve(api.Session, firstPoint_c, secondPoint_c);
				Geom.GeomInterface.Geom_Point3_free(ref firstPoint_c);
				Geom.GeomInterface.Geom_Point3_free(ref secondPoint_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createSurfacicCurve(IntPtr _pxz_session_, System.UInt32 surface, System.UInt32 curve2D);

		/// <summary>
		/// Create a curve from a surface
		/// </summary>
		/// <param name="surface">Surface to bound</param>
		/// <param name="curve2D">Curve to project</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateSurfacicCurve(System.UInt32 surface, System.UInt32 curve2D) {
			try {
				var ret = CAD_createSurfacicCurve(api.Session, surface, curve2D);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createTransformedCurve(IntPtr _pxz_session_, System.UInt32 curve, Geom.Matrix4_c matrix);

		/// <summary>
		/// Create a curve from a surface
		/// </summary>
		/// <param name="curve">Curve to transform</param>
		/// <param name="matrix">Matrix of the transformation</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateTransformedCurve(System.UInt32 curve, Geom.Matrix4 matrix) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				var ret = CAD_createTransformedCurve(api.Session, curve, matrix_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_invertCurve(IntPtr _pxz_session_, System.UInt32 curve, System.Double precision);

		/// <summary>
		/// Invert a curve parametricaly
		/// </summary>
		/// <param name="curve">The curve to invert</param>
		/// <param name="precision">The precision used to invert the curve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 InvertCurve(System.UInt32 curve, System.Double precision) {
			try {
				var ret = CAD_invertCurve(api.Session, curve, precision);
				System.String err = ConvertValue(CAD_getLastError());
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

		#region extrusion creation

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 CAD_createBoundedLinearExtrusionBody(IntPtr _pxz_session_, ProfileBase_c profileBase, Geom.Point3_c direction, Geom.Point3_c planeOrigin, Geom.Point3_c planeNormal, Geom.Point3_c startTangent, Int32 boundaryType, ProfileBase_c profileEnd);

		/// <summary>
		/// create a linear extrusion body
		/// </summary>
		/// <param name="profileBase">Profile loops to revolve</param>
		/// <param name="direction">The profile curves will be extruded in this direction</param>
		/// <param name="planeOrigin">The origin of the plane that bound the extrusion</param>
		/// <param name="planeNormal">The normal of the plane that bound the extrusion</param>
		/// <param name="startTangent">The starting tangent corresponding of the normal of the plane in which all profile lie</param>
		/// <param name="boundaryType">If the profile curves define an area or not</param>
		/// <param name="profileEnd">The end profile of the extrusion</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateBoundedLinearExtrusionBody(ProfileBase profileBase, Geom.Point3 direction, Geom.Point3 planeOrigin, Geom.Point3 planeNormal, Geom.Point3 startTangent, ExtrusionBoundaryType boundaryType = (CAD.ExtrusionBoundaryType)0, ProfileBase profileEnd = null) {
			profileEnd = profileEnd ?? new CAD.ProfileBase(new CAD.ProfileLoop[] {});
			try {
				var profileBase_c = new CAD.ProfileBase_c();
				ConvertValue((CAD.ProfileBase)profileBase, ref profileBase_c);
				var direction_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)direction, ref direction_c);
				var planeOrigin_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)planeOrigin, ref planeOrigin_c);
				var planeNormal_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)planeNormal, ref planeNormal_c);
				var startTangent_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)startTangent, ref startTangent_c);
				var profileEnd_c = new CAD.ProfileBase_c();
				ConvertValue((CAD.ProfileBase)profileEnd, ref profileEnd_c);
				var ret = CAD_createBoundedLinearExtrusionBody(api.Session, profileBase_c, direction_c, planeOrigin_c, planeNormal_c, startTangent_c, (int)boundaryType, profileEnd_c);
				CAD.CADInterface.CAD_ProfileBase_free(ref profileBase_c);
				Geom.GeomInterface.Geom_Point3_free(ref direction_c);
				Geom.GeomInterface.Geom_Point3_free(ref planeOrigin_c);
				Geom.GeomInterface.Geom_Point3_free(ref planeNormal_c);
				Geom.GeomInterface.Geom_Point3_free(ref startTangent_c);
				CAD.CADInterface.CAD_ProfileBase_free(ref profileEnd_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createCurveExtrusionBody(IntPtr _pxz_session_, ProfileBase_c profileBase, System.UInt32 curve, Geom.Point3_c startTangent, Int32 boundaryType, ProfileBase_c profileEnd);

		/// <summary>
		/// create a curve extrusion body
		/// </summary>
		/// <param name="profileBase">Profile loops to revolve</param>
		/// <param name="curve">The profile curves will be extruded along this curve</param>
		/// <param name="startTangent">The starting tangent corresponding of the normal of the plane in which all profile lie</param>
		/// <param name="boundaryType">If the profile curves define an area or not</param>
		/// <param name="profileEnd">The end profile of the extrusion</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateCurveExtrusionBody(ProfileBase profileBase, System.UInt32 curve, Geom.Point3 startTangent, ExtrusionBoundaryType boundaryType = (CAD.ExtrusionBoundaryType)0, ProfileBase profileEnd = null) {
			profileEnd = profileEnd ?? new CAD.ProfileBase(new CAD.ProfileLoop[] {});
			try {
				var profileBase_c = new CAD.ProfileBase_c();
				ConvertValue((CAD.ProfileBase)profileBase, ref profileBase_c);
				var startTangent_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)startTangent, ref startTangent_c);
				var profileEnd_c = new CAD.ProfileBase_c();
				ConvertValue((CAD.ProfileBase)profileEnd, ref profileEnd_c);
				var ret = CAD_createCurveExtrusionBody(api.Session, profileBase_c, curve, startTangent_c, (int)boundaryType, profileEnd_c);
				CAD.CADInterface.CAD_ProfileBase_free(ref profileBase_c);
				Geom.GeomInterface.Geom_Point3_free(ref startTangent_c);
				CAD.CADInterface.CAD_ProfileBase_free(ref profileEnd_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createLinearExtrusionBody(IntPtr _pxz_session_, ProfileBase_c profileBase, Geom.Point3_c direction, System.Double depth, Geom.Point3_c startTangent, Int32 boundaryType, ProfileBase_c profileEnd);

		/// <summary>
		/// create a linear extrusion body
		/// </summary>
		/// <param name="profileBase">Profile loops to revolve</param>
		/// <param name="direction">The profile curves will be extruded in this direction</param>
		/// <param name="depth">The extrusion will stop at the defined depth</param>
		/// <param name="startTangent">The starting tangent corresponding of the normal of the plane in which all profile lie</param>
		/// <param name="boundaryType">If the profile curves define an area or not</param>
		/// <param name="profileEnd">The end profile of the extrusion</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateLinearExtrusionBody(ProfileBase profileBase, Geom.Point3 direction, System.Double depth, Geom.Point3 startTangent, ExtrusionBoundaryType boundaryType = (CAD.ExtrusionBoundaryType)0, ProfileBase profileEnd = null) {
			profileEnd = profileEnd ?? new CAD.ProfileBase(new CAD.ProfileLoop[] {});
			try {
				var profileBase_c = new CAD.ProfileBase_c();
				ConvertValue((CAD.ProfileBase)profileBase, ref profileBase_c);
				var direction_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)direction, ref direction_c);
				var startTangent_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)startTangent, ref startTangent_c);
				var profileEnd_c = new CAD.ProfileBase_c();
				ConvertValue((CAD.ProfileBase)profileEnd, ref profileEnd_c);
				var ret = CAD_createLinearExtrusionBody(api.Session, profileBase_c, direction_c, depth, startTangent_c, (int)boundaryType, profileEnd_c);
				CAD.CADInterface.CAD_ProfileBase_free(ref profileBase_c);
				Geom.GeomInterface.Geom_Point3_free(ref direction_c);
				Geom.GeomInterface.Geom_Point3_free(ref startTangent_c);
				CAD.CADInterface.CAD_ProfileBase_free(ref profileEnd_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createMultiExtrusionBody(IntPtr _pxz_session_, ProfileBaseList_c profileBaseList, CurveListList_c profileExtrusionList, Int32 boundaryType);

		/// <summary>
		/// create a linear extrusion body
		/// </summary>
		/// <param name="profileBaseList">Profile loops to be extruded</param>
		/// <param name="profileExtrusionList">Extrusion profiles</param>
		/// <param name="boundaryType">If the profile curves define an area or not</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateMultiExtrusionBody(ProfileBaseList profileBaseList, CurveListList profileExtrusionList, ExtrusionBoundaryType boundaryType = (CAD.ExtrusionBoundaryType)0) {
			try {
				var profileBaseList_c = new CAD.ProfileBaseList_c();
				ConvertValue((CAD.ProfileBaseList)profileBaseList, ref profileBaseList_c);
				var profileExtrusionList_c = new CAD.CurveListList_c();
				ConvertValue((CAD.CurveListList)profileExtrusionList, ref profileExtrusionList_c);
				var ret = CAD_createMultiExtrusionBody(api.Session, profileBaseList_c, profileExtrusionList_c, (int)boundaryType);
				CAD.CADInterface.CAD_ProfileBaseList_free(ref profileBaseList_c);
				CAD.CADInterface.CAD_CurveListList_free(ref profileExtrusionList_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createRevolveExtrusionBody(IntPtr _pxz_session_, ProfileBase_c profileBase, Geom.Point3_c center, Geom.Point3_c axis, System.Double angle, Geom.Point3_c startTangent, Int32 boundaryType, ProfileBase_c profileEnd);

		/// <summary>
		/// create a revolved extrusion body
		/// </summary>
		/// <param name="profileBase">Profile loops to revolve</param>
		/// <param name="center">The center of revolution</param>
		/// <param name="axis">The profile curves will be revolved around this axis</param>
		/// <param name="angle">The revolution will stop at the defined angle</param>
		/// <param name="startTangent">The starting tangent corresponding of the normal of the plane in which all profile lie</param>
		/// <param name="boundaryType">If the profile curves define an area or not</param>
		/// <param name="profileEnd">The end profile of the extrusion</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateRevolveExtrusionBody(ProfileBase profileBase, Geom.Point3 center, Geom.Point3 axis, System.Double angle, Geom.Point3 startTangent, ExtrusionBoundaryType boundaryType = (CAD.ExtrusionBoundaryType)0, ProfileBase profileEnd = null) {
			profileEnd = profileEnd ?? new CAD.ProfileBase(new CAD.ProfileLoop[] {});
			try {
				var profileBase_c = new CAD.ProfileBase_c();
				ConvertValue((CAD.ProfileBase)profileBase, ref profileBase_c);
				var center_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)center, ref center_c);
				var axis_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)axis, ref axis_c);
				var startTangent_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)startTangent, ref startTangent_c);
				var profileEnd_c = new CAD.ProfileBase_c();
				ConvertValue((CAD.ProfileBase)profileEnd, ref profileEnd_c);
				var ret = CAD_createRevolveExtrusionBody(api.Session, profileBase_c, center_c, axis_c, angle, startTangent_c, (int)boundaryType, profileEnd_c);
				CAD.CADInterface.CAD_ProfileBase_free(ref profileBase_c);
				Geom.GeomInterface.Geom_Point3_free(ref center_c);
				Geom.GeomInterface.Geom_Point3_free(ref axis_c);
				Geom.GeomInterface.Geom_Point3_free(ref startTangent_c);
				CAD.CADInterface.CAD_ProfileBase_free(ref profileEnd_c);
				System.String err = ConvertValue(CAD_getLastError());
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

		#region material

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 CAD_getFaceMaterial(IntPtr _pxz_session_, System.UInt32 face);

		/// <summary>
		/// get the material on a face
		/// </summary>
		/// <param name="face">The face</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetFaceMaterial(System.UInt32 face) {
			try {
				var ret = CAD_getFaceMaterial(api.Session, face);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern void CAD_setFaceMaterial(IntPtr _pxz_session_, System.UInt32 face, System.UInt32 material);

		/// <summary>
		/// set the material on a face
		/// </summary>
		/// <param name="face">The face</param>
		/// <param name="material">The material</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetFaceMaterial(System.UInt32 face, System.UInt32 material) {
			try {
				CAD_setFaceMaterial(api.Session, face, material);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region model management

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void CAD_addBodyToModel(IntPtr _pxz_session_, System.UInt32 body, System.UInt32 model);

		/// <summary>
		/// Add a body to the model
		/// </summary>
		/// <param name="body">Body added to the model</param>
		/// <param name="model">Model</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AddBodyToModel(System.UInt32 body, System.UInt32 model) {
			try {
				CAD_addBodyToModel(api.Session, body, model);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void CAD_addEdgeToModel(IntPtr _pxz_session_, System.UInt32 edge, System.UInt32 model);

		/// <summary>
		/// Add an edge to the model
		/// </summary>
		/// <param name="edge">Edge added to the model</param>
		/// <param name="model">Model</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AddEdgeToModel(System.UInt32 edge, System.UInt32 model) {
			try {
				CAD_addEdgeToModel(api.Session, edge, model);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void CAD_addOpenShellToModel(IntPtr _pxz_session_, System.UInt32 shell, System.UInt32 model);

		/// <summary>
		/// Add an open shell to the model
		/// </summary>
		/// <param name="shell">Open shell added to the model</param>
		/// <param name="model">Model</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AddOpenShellToModel(System.UInt32 shell, System.UInt32 model) {
			try {
				CAD_addOpenShellToModel(api.Session, shell, model);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void CAD_addVertexToModel(IntPtr _pxz_session_, System.UInt32 vtx, System.UInt32 model);

		/// <summary>
		/// Add a vertex to the model
		/// </summary>
		/// <param name="vtx">Vertex added to the model</param>
		/// <param name="model">Model</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AddVertexToModel(System.UInt32 vtx, System.UInt32 model) {
			try {
				CAD_addVertexToModel(api.Session, vtx, model);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern BuildFacesReturn_c CAD_buildFaces(IntPtr _pxz_session_, System.UInt32 surface, LoopList_c loopList);

		/// <summary>
		/// Build faces from a surface and a set of loop
		/// </summary>
		/// <param name="surface">Surface used to build the faces</param>
		/// <param name="loopList">List of Loops used to build the faces</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.BuildFacesReturn BuildFaces(System.UInt32 surface, LoopList loopList) {
			try {
				var loopList_c = new CAD.LoopList_c();
				ConvertValue((CAD.LoopList)loopList, ref loopList_c);
				var ret = CAD_buildFaces(api.Session, surface, loopList_c);
				CAD.CADInterface.CAD_LoopList_free(ref loopList_c);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.BuildFacesReturn retStruct = new CAD.BuildFacesReturn();
				retStruct.faces = ConvertValue(ref ret.faces);
				CAD.CADInterface.CAD_FaceList_free(ref ret.faces);
				retStruct.splittingInfo = ConvertValue(ref ret.splittingInfo);
				CAD.CADInterface.CAD_SplittedEdgeList_free(ref ret.splittingInfo);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 CAD_createModel(IntPtr _pxz_session_, System.Double precision);

		/// <summary>
		/// Create a new model
		/// </summary>
		/// <param name="precision">CAD precision for this model</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateModel(System.Double precision = -1) {
			try {
				var ret = CAD_createModel(api.Session, precision);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern void CAD_endThreadBrepSession(IntPtr _pxz_session_);

		/// <summary>
		/// Create a new BrepSession on current thread
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void EndThreadBrepSession() {
			try {
				CAD_endThreadBrepSession(api.Session);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern FaceList_c CAD_getAllModelFaces(IntPtr _pxz_session_, System.UInt32 model);

		/// <summary>
		/// Get all the face of a model recursively
		/// </summary>
		/// <param name="model">Model</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public FaceList GetAllModelFaces(System.UInt32 model) {
			try {
				var ret = CAD_getAllModelFaces(api.Session, model);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				CAD.CADInterface.CAD_FaceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern BodyList_c CAD_getModelBodies(IntPtr _pxz_session_, System.UInt32 model);

		/// <summary>
		/// Get the list of bodies contained in a model
		/// </summary>
		/// <param name="model">Model</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public BodyList GetModelBodies(System.UInt32 model) {
			try {
				var ret = CAD_getModelBodies(api.Session, model);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				CAD.CADInterface.CAD_BodyList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern EdgeListList_c CAD_getModelBoundaries(IntPtr _pxz_session_, System.UInt32 model);

		/// <summary>
		/// Get boundary edges of a model grouped by cycles
		/// </summary>
		/// <param name="model">Model</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public EdgeListList GetModelBoundaries(System.UInt32 model) {
			try {
				var ret = CAD_getModelBoundaries(api.Session, model);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				CAD.CADInterface.CAD_EdgeListList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern EdgeList_c CAD_getModelEdges(IntPtr _pxz_session_, System.UInt32 model);

		/// <summary>
		/// Get the list of free edges contained in a model
		/// </summary>
		/// <param name="model">Model</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public EdgeList GetModelEdges(System.UInt32 model) {
			try {
				var ret = CAD_getModelEdges(api.Session, model);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				CAD.CADInterface.CAD_EdgeList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OpenShellList_c CAD_getModelOpenShells(IntPtr _pxz_session_, System.UInt32 model);

		/// <summary>
		/// Get the list of open shells contained in a model
		/// </summary>
		/// <param name="model">Model</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OpenShellList GetModelOpenShells(System.UInt32 model) {
			try {
				var ret = CAD_getModelOpenShells(api.Session, model);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				CAD.CADInterface.CAD_OpenShellList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Double CAD_getModelPrecision(IntPtr _pxz_session_, System.UInt32 model);

		/// <summary>
		/// Get the precision used in a model
		/// </summary>
		/// <param name="model">Model</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Double GetModelPrecision(System.UInt32 model) {
			try {
				var ret = CAD_getModelPrecision(api.Session, model);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern VertexList_c CAD_getModelVertices(IntPtr _pxz_session_, System.UInt32 model);

		/// <summary>
		/// Get the list of free vertices contained in a model
		/// </summary>
		/// <param name="model">Model</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public VertexList GetModelVertices(System.UInt32 model) {
			try {
				var ret = CAD_getModelVertices(api.Session, model);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				CAD.CADInterface.CAD_VertexList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.EntityList_c CAD_getReferencers(IntPtr _pxz_session_, System.UInt32 entity);

		/// <summary>
		/// Returns the entities referencing a given CAD entity
		/// </summary>
		/// <param name="entity">CAD entity to get the referencers</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Core.EntityList GetReferencers(System.UInt32 entity) {
			try {
				var ret = CAD_getReferencers(api.Session, entity);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Core.CoreInterface.ConvertValue(ref ret);
				Core.CoreInterface.Core_EntityList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void CAD_startThreadBrepSession(IntPtr _pxz_session_, System.Double precision);

		/// <summary>
		/// Create a new BrepSession on current thread
		/// </summary>
		/// <param name="precision">CAD precision for this model</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void StartThreadBrepSession(System.Double precision) {
			try {
				CAD_startThreadBrepSession(api.Session, precision);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region primitives

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 CAD_createBRepCone(IntPtr _pxz_session_, System.Double radius, System.Double height, Geom.Matrix4_c matrix);

		/// <summary>
		/// Creates a BRep Cone whose axis is the Z axis centered on O
		/// </summary>
		/// <param name="radius">Cone radius</param>
		/// <param name="height">Cone height</param>
		/// <param name="matrix">Positionning matrix of the Cone</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateBRepCone(System.Double radius, System.Double height, Geom.Matrix4 matrix = null) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				var ret = CAD_createBRepCone(api.Session, radius, height, matrix_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createBRepCube(IntPtr _pxz_session_, System.Double size, Geom.Matrix4_c matrix);

		/// <summary>
		/// Creates a BRep Cube
		/// </summary>
		/// <param name="size">Side length</param>
		/// <param name="matrix">Positionning matrix of the Cube</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateBRepCube(System.Double size, Geom.Matrix4 matrix = null) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				var ret = CAD_createBRepCube(api.Session, size, matrix_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createBRepCylinder(IntPtr _pxz_session_, System.Double radius, System.Double length, Geom.Matrix4_c matrix);

		/// <summary>
		/// Creates a BRep Cylinder aligned on the Z axis centered on O
		/// </summary>
		/// <param name="radius">Cylinder radius</param>
		/// <param name="length">Cylinder length</param>
		/// <param name="matrix">Positionning matrix of the Cylinder</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateBRepCylinder(System.Double radius, System.Double length, Geom.Matrix4 matrix = null) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				var ret = CAD_createBRepCylinder(api.Session, radius, length, matrix_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createBRepPlane(IntPtr _pxz_session_, System.Double length, System.Double width, Geom.Matrix4_c matrix);

		/// <summary>
		/// Creates a BRep Plane whose normal is the Z axis centered on O
		/// </summary>
		/// <param name="length">Plane length (X axis)</param>
		/// <param name="width">Plane width (Y axis)</param>
		/// <param name="matrix">Positionning matrix of the Plane</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateBRepPlane(System.Double length, System.Double width, Geom.Matrix4 matrix = null) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				var ret = CAD_createBRepPlane(api.Session, length, width, matrix_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createBRepSphere(IntPtr _pxz_session_, System.Double radius, Geom.Matrix4_c matrix);

		/// <summary>
		/// Creates a BRep Sphere centered on O and whose singularities are on the Z axis
		/// </summary>
		/// <param name="radius">Sphere radius</param>
		/// <param name="matrix">Positionning matrix of the Sphere</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateBRepSphere(System.Double radius, Geom.Matrix4 matrix = null) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				var ret = CAD_createBRepSphere(api.Session, radius, matrix_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createBRepTorus(IntPtr _pxz_session_, System.Double majorRadius, System.Double minorRadius, Geom.Matrix4_c matrix);

		/// <summary>
		/// Creates a BRep Torus whose axis is the Z axis centered on O
		/// </summary>
		/// <param name="majorRadius">Major radius</param>
		/// <param name="minorRadius">Minor radius</param>
		/// <param name="matrix">Positionning matrix of the Torus</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateBRepTorus(System.Double majorRadius, System.Double minorRadius, Geom.Matrix4 matrix = null) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				var ret = CAD_createBRepTorus(api.Session, majorRadius, minorRadius, matrix_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(CAD_getLastError());
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

		#region structure access

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Double CAD_evalCurvatureOnCurve(IntPtr _pxz_session_, System.UInt32 curve, System.Double parameter);

		/// <summary>
		/// evaluate curvature on a curve
		/// </summary>
		/// <param name="curve">The curve</param>
		/// <param name="parameter">Parameter to evaluate</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Double EvalCurvatureOnCurve(System.UInt32 curve, System.Double parameter) {
			try {
				var ret = CAD_evalCurvatureOnCurve(api.Session, curve, parameter);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern Geom.Curvatures_c CAD_evalCurvatureOnSurface(IntPtr _pxz_session_, System.UInt32 surface, Geom.Point2_c parameter);

		/// <summary>
		/// evaluate main curvatures on a surface
		/// </summary>
		/// <param name="surface">The surface</param>
		/// <param name="parameter">Parameter to evaluate</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.Curvatures EvalCurvatureOnSurface(System.UInt32 surface, Geom.Point2 parameter) {
			try {
				var parameter_c = new Geom.Point2_c();
				Geom.GeomInterface.ConvertValue((Geom.Point2)parameter, ref parameter_c);
				var ret = CAD_evalCurvatureOnSurface(api.Session, surface, parameter_c);
				Geom.GeomInterface.Geom_Point2_free(ref parameter_c);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Geom.GeomInterface.ConvertValue(ref ret);
				Geom.GeomInterface.Geom_Curvatures_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern EvalOnCurveReturn_c CAD_evalOnCurve(IntPtr _pxz_session_, System.UInt32 curve, System.Double parameter, Int32 derivation);

		/// <summary>
		/// evaluate a point and derivatives on a curve
		/// </summary>
		/// <param name="curve">The curve</param>
		/// <param name="parameter">Parameter to evaluate</param>
		/// <param name="derivation">Derivation level (0,1,2)</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.EvalOnCurveReturn EvalOnCurve(System.UInt32 curve, System.Double parameter, System.Int32 derivation = 0) {
			try {
				var ret = CAD_evalOnCurve(api.Session, curve, parameter, derivation);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.EvalOnCurveReturn retStruct = new CAD.EvalOnCurveReturn();
				retStruct.d0 = ConvertValue(ref ret.d0);
				Geom.GeomInterface.Geom_Point3_free(ref ret.d0);
				retStruct.du = ConvertValue(ref ret.du);
				Geom.GeomInterface.Geom_Point3_free(ref ret.du);
				retStruct.d2u = ConvertValue(ref ret.d2u);
				Geom.GeomInterface.Geom_Point3_free(ref ret.d2u);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern EvalOnSurfaceReturn_c CAD_evalOnSurface(IntPtr _pxz_session_, System.UInt32 surface, Geom.Point2_c parameter, Int32 derivation);

		/// <summary>
		/// evaluate a point and derivatives on a surface
		/// </summary>
		/// <param name="surface">The surface</param>
		/// <param name="parameter">Parameter to evaluate</param>
		/// <param name="derivation">Derivation level (0,1,2)</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.EvalOnSurfaceReturn EvalOnSurface(System.UInt32 surface, Geom.Point2 parameter, System.Int32 derivation = 0) {
			try {
				var parameter_c = new Geom.Point2_c();
				Geom.GeomInterface.ConvertValue((Geom.Point2)parameter, ref parameter_c);
				var ret = CAD_evalOnSurface(api.Session, surface, parameter_c, derivation);
				Geom.GeomInterface.Geom_Point2_free(ref parameter_c);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.EvalOnSurfaceReturn retStruct = new CAD.EvalOnSurfaceReturn();
				retStruct.d0 = ConvertValue(ref ret.d0);
				Geom.GeomInterface.Geom_Point3_free(ref ret.d0);
				retStruct.du = ConvertValue(ref ret.du);
				Geom.GeomInterface.Geom_Point3_free(ref ret.du);
				retStruct.dv = ConvertValue(ref ret.dv);
				Geom.GeomInterface.Geom_Point3_free(ref ret.dv);
				retStruct.d2u = ConvertValue(ref ret.d2u);
				Geom.GeomInterface.Geom_Point3_free(ref ret.d2u);
				retStruct.d2v = ConvertValue(ref ret.d2v);
				Geom.GeomInterface.Geom_Point3_free(ref ret.d2v);
				retStruct.duv = ConvertValue(ref ret.duv);
				Geom.GeomInterface.Geom_Point3_free(ref ret.duv);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern ClosedShellList_c CAD_getBodyClosedShells(IntPtr _pxz_session_, System.UInt32 body);

		/// <summary>
		/// get all closedShells contain in the body
		/// </summary>
		/// <param name="body">The body</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public ClosedShellList GetBodyClosedShells(System.UInt32 body) {
			try {
				var ret = CAD_getBodyClosedShells(api.Session, body);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				CAD.CADInterface.CAD_ClosedShellList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetCircleCurveDefinitionReturn_c CAD_getCircleCurveDefinition(IntPtr _pxz_session_, System.UInt32 circleCurve);

		/// <summary>
		/// get all parameters contained in the circleCurve
		/// </summary>
		/// <param name="circleCurve">The circleCurve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetCircleCurveDefinitionReturn GetCircleCurveDefinition(System.UInt32 circleCurve) {
			try {
				var ret = CAD_getCircleCurveDefinition(api.Session, circleCurve);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetCircleCurveDefinitionReturn retStruct = new CAD.GetCircleCurveDefinitionReturn();
				retStruct.radius = (System.Double)ret.radius;
				retStruct.matrix = ConvertValue(ref ret.matrix);
				Geom.GeomInterface.Geom_Matrix4_free(ref ret.matrix);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OrientedFaceList_c CAD_getClosedShellOrientedFaces(IntPtr _pxz_session_, System.UInt32 closedShell);

		/// <summary>
		/// get all orienteFaces contain in the closedShell
		/// </summary>
		/// <param name="closedShell">The closedShell</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OrientedFaceList GetClosedShellOrientedFaces(System.UInt32 closedShell) {
			try {
				var ret = CAD_getClosedShellOrientedFaces(api.Session, closedShell);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				CAD.CADInterface.CAD_OrientedFaceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetCoEdgeDefinitionReturn_c CAD_getCoEdgeDefinition(IntPtr _pxz_session_, System.UInt32 coEdge);

		/// <summary>
		/// get all parameters contained in the coEdge
		/// </summary>
		/// <param name="coEdge">The coEdge</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetCoEdgeDefinitionReturn GetCoEdgeDefinition(System.UInt32 coEdge) {
			try {
				var ret = CAD_getCoEdgeDefinition(api.Session, coEdge);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetCoEdgeDefinitionReturn retStruct = new CAD.GetCoEdgeDefinitionReturn();
				retStruct.edge = (System.UInt32)ret.edge;
				retStruct.edgeOrientation = (0 != ret.edgeOrientation);
				retStruct.loop = (System.UInt32)ret.loop;
				retStruct.surface = (System.UInt32)ret.surface;
				retStruct.parametricCurve = (System.UInt32)ret.parametricCurve;
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetCompositeCurveDefinitionReturn_c CAD_getCompositeCurveDefinition(IntPtr _pxz_session_, System.UInt32 compositeCurve);

		/// <summary>
		/// get all parameters contained in the compositeCurve
		/// </summary>
		/// <param name="compositeCurve">The compositeCurve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetCompositeCurveDefinitionReturn GetCompositeCurveDefinition(System.UInt32 compositeCurve) {
			try {
				var ret = CAD_getCompositeCurveDefinition(api.Session, compositeCurve);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetCompositeCurveDefinitionReturn retStruct = new CAD.GetCompositeCurveDefinitionReturn();
				retStruct.curves = ConvertValue(ref ret.curves);
				CAD.CADInterface.CAD_CurveList_free(ref ret.curves);
				retStruct.parameters = ConvertValue(ref ret.parameters);
				Core.CoreInterface.Core_DoubleList_free(ref ret.parameters);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetConeSurfaceDefinitionReturn_c CAD_getConeSurfaceDefinition(IntPtr _pxz_session_, System.UInt32 coneSurface);

		/// <summary>
		/// get all parameters contained in the coneSurface
		/// </summary>
		/// <param name="coneSurface">The coneSurface</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetConeSurfaceDefinitionReturn GetConeSurfaceDefinition(System.UInt32 coneSurface) {
			try {
				var ret = CAD_getConeSurfaceDefinition(api.Session, coneSurface);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetConeSurfaceDefinitionReturn retStruct = new CAD.GetConeSurfaceDefinitionReturn();
				retStruct.radius = (System.Double)ret.radius;
				retStruct.semiAngle = (System.Double)ret.semiAngle;
				retStruct.matrix = ConvertValue(ref ret.matrix);
				Geom.GeomInterface.Geom_Matrix4_free(ref ret.matrix);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetCurveExtrusionSurfaceDefinitionReturn_c CAD_getCurveExtrusionSurfaceDefinition(IntPtr _pxz_session_, System.UInt32 curveExtrusionSurface);

		/// <summary>
		/// get all parameters contained in the curveExtrusionSurface
		/// </summary>
		/// <param name="curveExtrusionSurface">The curveExtrusionSurface</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetCurveExtrusionSurfaceDefinitionReturn GetCurveExtrusionSurfaceDefinition(System.UInt32 curveExtrusionSurface) {
			try {
				var ret = CAD_getCurveExtrusionSurfaceDefinition(api.Session, curveExtrusionSurface);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetCurveExtrusionSurfaceDefinitionReturn retStruct = new CAD.GetCurveExtrusionSurfaceDefinitionReturn();
				retStruct.generatrixCurve = (System.UInt32)ret.generatrixCurve;
				retStruct.directrixCruve = (System.UInt32)ret.directrixCruve;
				retStruct.surfaceReference = (System.UInt32)ret.surfaceReference;
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Double CAD_getCurveLength(IntPtr _pxz_session_, System.UInt32 curve);

		/// <summary>
		/// returns the length of the curve
		/// </summary>
		/// <param name="curve">The curve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Double GetCurveLength(System.UInt32 curve) {
			try {
				var ret = CAD_getCurveLength(api.Session, curve);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern Bounds1D_c CAD_getCurveLimits(IntPtr _pxz_session_, System.UInt32 curve);

		/// <summary>
		/// get the parametric space limits of a curve
		/// </summary>
		/// <param name="curve">The curve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Bounds1D GetCurveLimits(System.UInt32 curve) {
			try {
				var ret = CAD_getCurveLimits(api.Session, curve);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				CAD.CADInterface.CAD_Bounds1D_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetCylinderSurfaceDefinitionReturn_c CAD_getCylinderSurfaceDefinition(IntPtr _pxz_session_, System.UInt32 cylinderSurface);

		/// <summary>
		/// get all parameters contained in the cylinderSurface
		/// </summary>
		/// <param name="cylinderSurface">The cylinderSurface</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetCylinderSurfaceDefinitionReturn GetCylinderSurfaceDefinition(System.UInt32 cylinderSurface) {
			try {
				var ret = CAD_getCylinderSurfaceDefinition(api.Session, cylinderSurface);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetCylinderSurfaceDefinitionReturn retStruct = new CAD.GetCylinderSurfaceDefinitionReturn();
				retStruct.radius = (System.Double)ret.radius;
				retStruct.matrix = ConvertValue(ref ret.matrix);
				Geom.GeomInterface.Geom_Matrix4_free(ref ret.matrix);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetEdgeDefinitionReturn_c CAD_getEdgeDefinition(IntPtr _pxz_session_, System.UInt32 edge);

		/// <summary>
		/// get all parameters contained in the edge
		/// </summary>
		/// <param name="edge">The edge</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetEdgeDefinitionReturn GetEdgeDefinition(System.UInt32 edge) {
			try {
				var ret = CAD_getEdgeDefinition(api.Session, edge);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetEdgeDefinitionReturn retStruct = new CAD.GetEdgeDefinitionReturn();
				retStruct.vertex1 = (System.UInt32)ret.vertex1;
				retStruct.vertex2 = (System.UInt32)ret.vertex2;
				retStruct.curve = (System.UInt32)ret.curve;
				retStruct.bounds = ConvertValue(ref ret.bounds);
				CAD.CADInterface.CAD_Bounds1D_free(ref ret.bounds);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Double CAD_getEdgeLength(IntPtr _pxz_session_, System.UInt32 edge);

		/// <summary>
		/// returns the length of the edge
		/// </summary>
		/// <param name="edge">The edge</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Double GetEdgeLength(System.UInt32 edge) {
			try {
				var ret = CAD_getEdgeLength(api.Session, edge);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_getEdgeMaterial(IntPtr _pxz_session_, System.UInt32 edge);

		/// <summary>
		/// Get the material of the edge, if any
		/// </summary>
		/// <param name="edge"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetEdgeMaterial(System.UInt32 edge) {
			try {
				var ret = CAD_getEdgeMaterial(api.Session, edge);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern GetEllipseCurveDefinitionReturn_c CAD_getEllipseCurveDefinition(IntPtr _pxz_session_, System.UInt32 ellipseCurve);

		/// <summary>
		/// get all parameters contained in the ellipseCurve
		/// </summary>
		/// <param name="ellipseCurve">The ellipseCurve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetEllipseCurveDefinitionReturn GetEllipseCurveDefinition(System.UInt32 ellipseCurve) {
			try {
				var ret = CAD_getEllipseCurveDefinition(api.Session, ellipseCurve);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetEllipseCurveDefinitionReturn retStruct = new CAD.GetEllipseCurveDefinitionReturn();
				retStruct.radius1 = (System.Double)ret.radius1;
				retStruct.radius2 = (System.Double)ret.radius2;
				retStruct.matrix = ConvertValue(ref ret.matrix);
				Geom.GeomInterface.Geom_Matrix4_free(ref ret.matrix);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetEllipticConeSurfaceDefinitionReturn_c CAD_getEllipticConeSurfaceDefinition(IntPtr _pxz_session_, System.UInt32 ellipticConeSurface);

		/// <summary>
		/// get all parameters contained in the ellipticConeSurface
		/// </summary>
		/// <param name="ellipticConeSurface">The EllipticConeSurface</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetEllipticConeSurfaceDefinitionReturn GetEllipticConeSurfaceDefinition(System.UInt32 ellipticConeSurface) {
			try {
				var ret = CAD_getEllipticConeSurfaceDefinition(api.Session, ellipticConeSurface);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetEllipticConeSurfaceDefinitionReturn retStruct = new CAD.GetEllipticConeSurfaceDefinitionReturn();
				retStruct.radius1 = (System.Double)ret.radius1;
				retStruct.radius2 = (System.Double)ret.radius2;
				retStruct.semiAngle = (System.Double)ret.semiAngle;
				retStruct.matrix = ConvertValue(ref ret.matrix);
				Geom.GeomInterface.Geom_Matrix4_free(ref ret.matrix);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetFaceDefinitionReturn_c CAD_getFaceDefinition(IntPtr _pxz_session_, System.UInt32 face);

		/// <summary>
		/// get all parameters contain in the face
		/// </summary>
		/// <param name="face">The face</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetFaceDefinitionReturn GetFaceDefinition(System.UInt32 face) {
			try {
				var ret = CAD_getFaceDefinition(api.Session, face);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetFaceDefinitionReturn retStruct = new CAD.GetFaceDefinitionReturn();
				retStruct.surface = (System.UInt32)ret.surface;
				retStruct.loops = ConvertValue(ref ret.loops);
				CAD.CADInterface.CAD_LoopList_free(ref ret.loops);
				retStruct.orientation = (0 != ret.orientation);
				retStruct.limits = ConvertValue(ref ret.limits);
				CAD.CADInterface.CAD_Bounds2D_free(ref ret.limits);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Geom.Point2ListList_c CAD_getFaceParametricBoundaries(IntPtr _pxz_session_, System.UInt32 face);

		/// <summary>
		/// get parametric definition of each face loop
		/// </summary>
		/// <param name="face">The face</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.Point2ListList GetFaceParametricBoundaries(System.UInt32 face) {
			try {
				var ret = CAD_getFaceParametricBoundaries(api.Session, face);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Geom.GeomInterface.ConvertValue(ref ret);
				Geom.GeomInterface.Geom_Point2ListList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetHelixCurveDefinitionReturn_c CAD_getHelixCurveDefinition(IntPtr _pxz_session_, System.UInt32 helixCurve);

		/// <summary>
		/// get all parameters contained in the helixCurve
		/// </summary>
		/// <param name="helixCurve">The helixCurve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetHelixCurveDefinitionReturn GetHelixCurveDefinition(System.UInt32 helixCurve) {
			try {
				var ret = CAD_getHelixCurveDefinition(api.Session, helixCurve);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetHelixCurveDefinitionReturn retStruct = new CAD.GetHelixCurveDefinitionReturn();
				retStruct.radius = (System.Double)ret.radius;
				retStruct.matrix = ConvertValue(ref ret.matrix);
				Geom.GeomInterface.Geom_Matrix4_free(ref ret.matrix);
				retStruct.trigonometricOrientation = (0 != ret.trigonometricOrientation);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetHermiteCurveDefinitionReturn_c CAD_getHermiteCurveDefinition(IntPtr _pxz_session_, System.UInt32 hermiteCurve);

		/// <summary>
		/// get all parameters contained in the hermiteCurve
		/// </summary>
		/// <param name="hermiteCurve">The HermiteCurve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetHermiteCurveDefinitionReturn GetHermiteCurveDefinition(System.UInt32 hermiteCurve) {
			try {
				var ret = CAD_getHermiteCurveDefinition(api.Session, hermiteCurve);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetHermiteCurveDefinitionReturn retStruct = new CAD.GetHermiteCurveDefinitionReturn();
				retStruct.firstPoint = ConvertValue(ref ret.firstPoint);
				Geom.GeomInterface.Geom_Point3_free(ref ret.firstPoint);
				retStruct.secondPoint = ConvertValue(ref ret.secondPoint);
				Geom.GeomInterface.Geom_Point3_free(ref ret.secondPoint);
				retStruct.firstTangent = ConvertValue(ref ret.firstTangent);
				Geom.GeomInterface.Geom_Point3_free(ref ret.firstTangent);
				retStruct.secondTangent = ConvertValue(ref ret.secondTangent);
				Geom.GeomInterface.Geom_Point3_free(ref ret.secondTangent);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetHyperbolaCurveDefinitionReturn_c CAD_getHyperbolaCurveDefinition(IntPtr _pxz_session_, System.UInt32 hyperbolaCurve);

		/// <summary>
		/// get all parameters contained in the hyperbolaCurve
		/// </summary>
		/// <param name="hyperbolaCurve">The hyperbolaCurve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetHyperbolaCurveDefinitionReturn GetHyperbolaCurveDefinition(System.UInt32 hyperbolaCurve) {
			try {
				var ret = CAD_getHyperbolaCurveDefinition(api.Session, hyperbolaCurve);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetHyperbolaCurveDefinitionReturn retStruct = new CAD.GetHyperbolaCurveDefinitionReturn();
				retStruct.radius1 = (System.Double)ret.radius1;
				retStruct.radius2 = (System.Double)ret.radius2;
				retStruct.matrix = ConvertValue(ref ret.matrix);
				Geom.GeomInterface.Geom_Matrix4_free(ref ret.matrix);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetIntersectionCurveDefinitionReturn_c CAD_getIntersectionCurveDefinition(IntPtr _pxz_session_, System.UInt32 intersectionCurve);

		/// <summary>
		/// get all parameters contained in the intersectionCurve
		/// </summary>
		/// <param name="intersectionCurve">The intersectionCurve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetIntersectionCurveDefinitionReturn GetIntersectionCurveDefinition(System.UInt32 intersectionCurve) {
			try {
				var ret = CAD_getIntersectionCurveDefinition(api.Session, intersectionCurve);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetIntersectionCurveDefinitionReturn retStruct = new CAD.GetIntersectionCurveDefinitionReturn();
				retStruct.surface1 = (System.UInt32)ret.surface1;
				retStruct.surface2 = (System.UInt32)ret.surface2;
				retStruct.chart = (System.UInt32)ret.chart;
				retStruct.bounds = ConvertValue(ref ret.bounds);
				CAD.CADInterface.CAD_Bounds1D_free(ref ret.bounds);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetLineCurveDefinitionReturn_c CAD_getLineCurveDefinition(IntPtr _pxz_session_, System.UInt32 lineCurve);

		/// <summary>
		/// get all parameters contain in the lineCurve
		/// </summary>
		/// <param name="lineCurve">The lineCurve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetLineCurveDefinitionReturn GetLineCurveDefinition(System.UInt32 lineCurve) {
			try {
				var ret = CAD_getLineCurveDefinition(api.Session, lineCurve);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetLineCurveDefinitionReturn retStruct = new CAD.GetLineCurveDefinitionReturn();
				retStruct.origin = ConvertValue(ref ret.origin);
				Geom.GeomInterface.Geom_Point3_free(ref ret.origin);
				retStruct.direction = ConvertValue(ref ret.direction);
				Geom.GeomInterface.Geom_Point3_free(ref ret.direction);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern CoEdgeList_c CAD_getLoopCoEdges(IntPtr _pxz_session_, System.UInt32 loop);

		/// <summary>
		/// get all coEdges contain in the loop
		/// </summary>
		/// <param name="loop">The loop</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CoEdgeList GetLoopCoEdges(System.UInt32 loop) {
			try {
				var ret = CAD_getLoopCoEdges(api.Session, loop);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				CAD.CADInterface.CAD_CoEdgeList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetNURBSCurveDefinitionReturn_c CAD_getNURBSCurveDefinition(IntPtr _pxz_session_, System.UInt32 nurbsCurve);

		/// <summary>
		/// get all parameters contained in the nurbsCurve
		/// </summary>
		/// <param name="nurbsCurve">The nurbsCurve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetNURBSCurveDefinitionReturn GetNURBSCurveDefinition(System.UInt32 nurbsCurve) {
			try {
				var ret = CAD_getNURBSCurveDefinition(api.Session, nurbsCurve);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetNURBSCurveDefinitionReturn retStruct = new CAD.GetNURBSCurveDefinitionReturn();
				retStruct.degree = (System.Int32)ret.degree;
				retStruct.knots = ConvertValue(ref ret.knots);
				Core.CoreInterface.Core_DoubleList_free(ref ret.knots);
				retStruct.poles = ConvertValue(ref ret.poles);
				Geom.GeomInterface.Geom_Point3List_free(ref ret.poles);
				retStruct.weights = ConvertValue(ref ret.weights);
				Core.CoreInterface.Core_DoubleList_free(ref ret.weights);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetNURBSSurfaceDefinitionReturn_c CAD_getNURBSSurfaceDefinition(IntPtr _pxz_session_, System.UInt32 nurbsSurface);

		/// <summary>
		/// get all parameters contained in the nurbsSurface
		/// </summary>
		/// <param name="nurbsSurface">The nurbsSurface</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetNURBSSurfaceDefinitionReturn GetNURBSSurfaceDefinition(System.UInt32 nurbsSurface) {
			try {
				var ret = CAD_getNURBSSurfaceDefinition(api.Session, nurbsSurface);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetNURBSSurfaceDefinitionReturn retStruct = new CAD.GetNURBSSurfaceDefinitionReturn();
				retStruct.degreeU = (System.Int32)ret.degreeU;
				retStruct.degreeV = (System.Int32)ret.degreeV;
				retStruct.knotsU = ConvertValue(ref ret.knotsU);
				Core.CoreInterface.Core_DoubleList_free(ref ret.knotsU);
				retStruct.knotsV = ConvertValue(ref ret.knotsV);
				Core.CoreInterface.Core_DoubleList_free(ref ret.knotsV);
				retStruct.poles = ConvertValue(ref ret.poles);
				Geom.GeomInterface.Geom_Point3ListList_free(ref ret.poles);
				retStruct.weights = ConvertValue(ref ret.weights);
				Core.CoreInterface.Core_DoubleListList_free(ref ret.weights);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetOffsetCurveDefinitionReturn_c CAD_getOffsetCurveDefinition(IntPtr _pxz_session_, System.UInt32 offsetCurve);

		/// <summary>
		/// get all parameters contained in the offsetCurve
		/// </summary>
		/// <param name="offsetCurve">The offsetCurve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetOffsetCurveDefinitionReturn GetOffsetCurveDefinition(System.UInt32 offsetCurve) {
			try {
				var ret = CAD_getOffsetCurveDefinition(api.Session, offsetCurve);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetOffsetCurveDefinitionReturn retStruct = new CAD.GetOffsetCurveDefinitionReturn();
				retStruct.curve = (System.UInt32)ret.curve;
				retStruct.direction = ConvertValue(ref ret.direction);
				Geom.GeomInterface.Geom_Point3_free(ref ret.direction);
				retStruct.distance = (System.Double)ret.distance;
				retStruct.surfaceReference = (System.UInt32)ret.surfaceReference;
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetOffsetSurfaceDefinitionReturn_c CAD_getOffsetSurfaceDefinition(IntPtr _pxz_session_, System.UInt32 offsetSurface);

		/// <summary>
		/// get all parameters contained in the offsetSurface
		/// </summary>
		/// <param name="offsetSurface">The offsetSurface</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetOffsetSurfaceDefinitionReturn GetOffsetSurfaceDefinition(System.UInt32 offsetSurface) {
			try {
				var ret = CAD_getOffsetSurfaceDefinition(api.Session, offsetSurface);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetOffsetSurfaceDefinitionReturn retStruct = new CAD.GetOffsetSurfaceDefinitionReturn();
				retStruct.baseSurface = (System.UInt32)ret.baseSurface;
				retStruct.distance = (System.Double)ret.distance;
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OrientedFaceList_c CAD_getOpenShellOrientedFaces(IntPtr _pxz_session_, System.UInt32 openShell);

		/// <summary>
		/// get all orienteFaces contain in the openShell
		/// </summary>
		/// <param name="openShell">The openShell</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public OrientedFaceList GetOpenShellOrientedFaces(System.UInt32 openShell) {
			try {
				var ret = CAD_getOpenShellOrientedFaces(api.Session, openShell);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				CAD.CADInterface.CAD_OrientedFaceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetParabolaCurveDefinitionReturn_c CAD_getParabolaCurveDefinition(IntPtr _pxz_session_, System.UInt32 parabolaCurve);

		/// <summary>
		/// get all parameters contained in the parabolaCurve
		/// </summary>
		/// <param name="parabolaCurve">The parabolaCurve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetParabolaCurveDefinitionReturn GetParabolaCurveDefinition(System.UInt32 parabolaCurve) {
			try {
				var ret = CAD_getParabolaCurveDefinition(api.Session, parabolaCurve);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetParabolaCurveDefinitionReturn retStruct = new CAD.GetParabolaCurveDefinitionReturn();
				retStruct.focalLength = (System.Double)ret.focalLength;
				retStruct.matrix = ConvertValue(ref ret.matrix);
				Geom.GeomInterface.Geom_Matrix4_free(ref ret.matrix);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Double CAD_getParametricPrecisionOnSurface(IntPtr _pxz_session_, System.UInt32 surface, System.Double precision);

		/// <summary>
		/// returns the parametric precision of a surface from the input precision
		/// </summary>
		/// <param name="surface">The surface</param>
		/// <param name="precision">Input precision</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Double GetParametricPrecisionOnSurface(System.UInt32 surface, System.Double precision) {
			try {
				var ret = CAD_getParametricPrecisionOnSurface(api.Session, surface, precision);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern Geom.Matrix4_c CAD_getPlaneSurfaceDefinition(IntPtr _pxz_session_, System.UInt32 planeSurface);

		/// <summary>
		/// get all parameters contained in the planeSurface
		/// </summary>
		/// <param name="planeSurface">The planeSurface</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.Matrix4 GetPlaneSurfaceDefinition(System.UInt32 planeSurface) {
			try {
				var ret = CAD_getPlaneSurfaceDefinition(api.Session, planeSurface);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern GetPolylineCurveDefinitionReturn_c CAD_getPolylineCurveDefinition(IntPtr _pxz_session_, System.UInt32 polylineCurve);

		/// <summary>
		/// get all parameters contained in the polylinCurve
		/// </summary>
		/// <param name="polylineCurve">The polylineCurve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetPolylineCurveDefinitionReturn GetPolylineCurveDefinition(System.UInt32 polylineCurve) {
			try {
				var ret = CAD_getPolylineCurveDefinition(api.Session, polylineCurve);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetPolylineCurveDefinitionReturn retStruct = new CAD.GetPolylineCurveDefinitionReturn();
				retStruct.points = ConvertValue(ref ret.points);
				Geom.GeomInterface.Geom_Point3List_free(ref ret.points);
				retStruct.parameters = ConvertValue(ref ret.parameters);
				Core.CoreInterface.Core_DoubleList_free(ref ret.parameters);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetRevolutionSurfaceDefinitionReturn_c CAD_getRevolutionSurfaceDefinition(IntPtr _pxz_session_, System.UInt32 revolutionSurface);

		/// <summary>
		/// get all parameters contained in the revolutionSurface
		/// </summary>
		/// <param name="revolutionSurface">The revolutionSurface</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetRevolutionSurfaceDefinitionReturn GetRevolutionSurfaceDefinition(System.UInt32 revolutionSurface) {
			try {
				var ret = CAD_getRevolutionSurfaceDefinition(api.Session, revolutionSurface);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetRevolutionSurfaceDefinitionReturn retStruct = new CAD.GetRevolutionSurfaceDefinitionReturn();
				retStruct.generatricCurve = (System.UInt32)ret.generatricCurve;
				retStruct.axisOrigin = ConvertValue(ref ret.axisOrigin);
				Geom.GeomInterface.Geom_Point3_free(ref ret.axisOrigin);
				retStruct.axisDirection = ConvertValue(ref ret.axisDirection);
				Geom.GeomInterface.Geom_Point3_free(ref ret.axisDirection);
				retStruct.startAngle = (System.Double)ret.startAngle;
				retStruct.endAngle = (System.Double)ret.endAngle;
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetRuledSurfaceDefinitionReturn_c CAD_getRuledSurfaceDefinition(IntPtr _pxz_session_, System.UInt32 ruledSurface);

		/// <summary>
		/// get all parameters contained in the ruledSurface
		/// </summary>
		/// <param name="ruledSurface">The ruledSurface</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetRuledSurfaceDefinitionReturn GetRuledSurfaceDefinition(System.UInt32 ruledSurface) {
			try {
				var ret = CAD_getRuledSurfaceDefinition(api.Session, ruledSurface);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetRuledSurfaceDefinitionReturn retStruct = new CAD.GetRuledSurfaceDefinitionReturn();
				retStruct.firstCurve = (System.UInt32)ret.firstCurve;
				retStruct.secondCurve = (System.UInt32)ret.secondCurve;
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetSegmentCurveDefinitionReturn_c CAD_getSegmentCurveDefinition(IntPtr _pxz_session_, System.UInt32 segmentCurve);

		/// <summary>
		/// get all parameters contained in the segmentCurve
		/// </summary>
		/// <param name="segmentCurve">The segmentCurve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetSegmentCurveDefinitionReturn GetSegmentCurveDefinition(System.UInt32 segmentCurve) {
			try {
				var ret = CAD_getSegmentCurveDefinition(api.Session, segmentCurve);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetSegmentCurveDefinitionReturn retStruct = new CAD.GetSegmentCurveDefinitionReturn();
				retStruct.startPoint = ConvertValue(ref ret.startPoint);
				Geom.GeomInterface.Geom_Point3_free(ref ret.startPoint);
				retStruct.endPoint = ConvertValue(ref ret.endPoint);
				Geom.GeomInterface.Geom_Point3_free(ref ret.endPoint);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetSphereSurfaceDefinitionReturn_c CAD_getSphereSurfaceDefinition(IntPtr _pxz_session_, System.UInt32 sphereSurface);

		/// <summary>
		/// get all parameters contained in the sphereSurface
		/// </summary>
		/// <param name="sphereSurface">The sphereSurface</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetSphereSurfaceDefinitionReturn GetSphereSurfaceDefinition(System.UInt32 sphereSurface) {
			try {
				var ret = CAD_getSphereSurfaceDefinition(api.Session, sphereSurface);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetSphereSurfaceDefinitionReturn retStruct = new CAD.GetSphereSurfaceDefinitionReturn();
				retStruct.radius = (System.Double)ret.radius;
				retStruct.matrix = ConvertValue(ref ret.matrix);
				Geom.GeomInterface.Geom_Matrix4_free(ref ret.matrix);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Bounds2D_c CAD_getSurfaceLimits(IntPtr _pxz_session_, System.UInt32 surface);

		/// <summary>
		/// get the parametric space limits of a surface
		/// </summary>
		/// <param name="surface">The surface</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Bounds2D GetSurfaceLimits(System.UInt32 surface) {
			try {
				var ret = CAD_getSurfaceLimits(api.Session, surface);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				CAD.CADInterface.CAD_Bounds2D_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetSurfacicCurveDefinitionReturn_c CAD_getSurfacicCurveDefinition(IntPtr _pxz_session_, System.UInt32 surfacicCurve);

		/// <summary>
		/// get all parameters contained in the surfacicCurve
		/// </summary>
		/// <param name="surfacicCurve">The surfacicCurve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetSurfacicCurveDefinitionReturn GetSurfacicCurveDefinition(System.UInt32 surfacicCurve) {
			try {
				var ret = CAD_getSurfacicCurveDefinition(api.Session, surfacicCurve);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetSurfacicCurveDefinitionReturn retStruct = new CAD.GetSurfacicCurveDefinitionReturn();
				retStruct.surface = (System.UInt32)ret.surface;
				retStruct.curve2D = (System.UInt32)ret.curve2D;
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetTabulatedCylinderSurfaceDefinitionReturn_c CAD_getTabulatedCylinderSurfaceDefinition(IntPtr _pxz_session_, System.UInt32 tabulatedCylinderSurface);

		/// <summary>
		/// get all parameters contained in the TabulatedCylinderSurface
		/// </summary>
		/// <param name="tabulatedCylinderSurface">The tabulatedCylinderSurface</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetTabulatedCylinderSurfaceDefinitionReturn GetTabulatedCylinderSurfaceDefinition(System.UInt32 tabulatedCylinderSurface) {
			try {
				var ret = CAD_getTabulatedCylinderSurfaceDefinition(api.Session, tabulatedCylinderSurface);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetTabulatedCylinderSurfaceDefinitionReturn retStruct = new CAD.GetTabulatedCylinderSurfaceDefinitionReturn();
				retStruct.directrixCurve = (System.UInt32)ret.directrixCurve;
				retStruct.generatrixLine = ConvertValue(ref ret.generatrixLine);
				Geom.GeomInterface.Geom_Point3_free(ref ret.generatrixLine);
				retStruct.range = ConvertValue(ref ret.range);
				CAD.CADInterface.CAD_Bounds1D_free(ref ret.range);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetTorusSurfaceDefinitionReturn_c CAD_getTorusSurfaceDefinition(IntPtr _pxz_session_, System.UInt32 torusSurface);

		/// <summary>
		/// get all parameters contained in the torusSurface
		/// </summary>
		/// <param name="torusSurface">The torusSurface</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetTorusSurfaceDefinitionReturn GetTorusSurfaceDefinition(System.UInt32 torusSurface) {
			try {
				var ret = CAD_getTorusSurfaceDefinition(api.Session, torusSurface);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetTorusSurfaceDefinitionReturn retStruct = new CAD.GetTorusSurfaceDefinitionReturn();
				retStruct.majorRadius = (System.Double)ret.majorRadius;
				retStruct.minorRadius = (System.Double)ret.minorRadius;
				retStruct.matrix = ConvertValue(ref ret.matrix);
				Geom.GeomInterface.Geom_Matrix4_free(ref ret.matrix);
				retStruct.type = (System.Int32)ret.type;
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetTransformedCurveDefinitionReturn_c CAD_getTransformedCurveDefinition(IntPtr _pxz_session_, System.UInt32 transformedCurve);

		/// <summary>
		/// get all parameters contained in the transformedCurve
		/// </summary>
		/// <param name="transformedCurve">The transformedCurve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.GetTransformedCurveDefinitionReturn GetTransformedCurveDefinition(System.UInt32 transformedCurve) {
			try {
				var ret = CAD_getTransformedCurveDefinition(api.Session, transformedCurve);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.GetTransformedCurveDefinitionReturn retStruct = new CAD.GetTransformedCurveDefinitionReturn();
				retStruct.curve = (System.UInt32)ret.curve;
				retStruct.matrix = ConvertValue(ref ret.matrix);
				Geom.GeomInterface.Geom_Matrix4_free(ref ret.matrix);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Geom.Point3_c CAD_getVertexPosition(IntPtr _pxz_session_, System.UInt32 vertex);

		/// <summary>
		/// get the position of the vertex
		/// </summary>
		/// <param name="vertex">The vertex</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.Point3 GetVertexPosition(System.UInt32 vertex) {
			try {
				var ret = CAD_getVertexPosition(api.Session, vertex);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Geom.GeomInterface.ConvertValue(ref ret);
				Geom.GeomInterface.Geom_Point3_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Double CAD_invertOnCurve(IntPtr _pxz_session_, System.UInt32 curve, Geom.Point3_c point, System.Double precision);

		/// <summary>
		/// invert a point to a curve
		/// </summary>
		/// <param name="curve">The curve</param>
		/// <param name="point">The point to invert</param>
		/// <param name="precision">Inversion precision</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Double InvertOnCurve(System.UInt32 curve, Geom.Point3 point, System.Double precision = -1) {
			try {
				var point_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)point, ref point_c);
				var ret = CAD_invertOnCurve(api.Session, curve, point_c, precision);
				Geom.GeomInterface.Geom_Point3_free(ref point_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern Geom.Point2_c CAD_invertOnSurface(IntPtr _pxz_session_, System.UInt32 surface, Geom.Point3_c point, System.Double precision);

		/// <summary>
		/// invert a point to a surface
		/// </summary>
		/// <param name="surface">The surface</param>
		/// <param name="point">The point to invert</param>
		/// <param name="precision">Inversion precision</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.Point2 InvertOnSurface(System.UInt32 surface, Geom.Point3 point, System.Double precision = -1) {
			try {
				var point_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)point, ref point_c);
				var ret = CAD_invertOnSurface(api.Session, surface, point_c, precision);
				Geom.GeomInterface.Geom_Point3_free(ref point_c);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Geom.GeomInterface.ConvertValue(ref ret);
				Geom.GeomInterface.Geom_Point2_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte CAD_isCurveClosed(IntPtr _pxz_session_, System.UInt32 curve);

		/// <summary>
		/// if the curve is closed, return true, return false otherwise
		/// </summary>
		/// <param name="curve">The curve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean IsCurveClosed(System.UInt32 curve) {
			try {
				var ret = CAD_isCurveClosed(api.Session, curve);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.Byte CAD_isCurveFinite(IntPtr _pxz_session_, System.UInt32 curve);

		/// <summary>
		/// if the curve is finite return true, return false otherwise
		/// </summary>
		/// <param name="curve">The curve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean IsCurveFinite(System.UInt32 curve) {
			try {
				var ret = CAD_isCurveFinite(api.Session, curve);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern IsCurvePeriodicReturn_c CAD_isCurvePeriodic(IntPtr _pxz_session_, System.UInt32 curve);

		/// <summary>
		/// if the curve is periodic return true, return false otherwise
		/// </summary>
		/// <param name="curve">The curve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.IsCurvePeriodicReturn IsCurvePeriodic(System.UInt32 curve) {
			try {
				var ret = CAD_isCurvePeriodic(api.Session, curve);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.IsCurvePeriodicReturn retStruct = new CAD.IsCurvePeriodicReturn();
				retStruct.periodic = (0 != ret.periodic);
				retStruct.period = (System.Double)ret.period;
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IsSurfaceClosedReturn_c CAD_isSurfaceClosed(IntPtr _pxz_session_, System.UInt32 surface);

		/// <summary>
		/// return if the surface is closed on U or on V
		/// </summary>
		/// <param name="surface">The surface</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.IsSurfaceClosedReturn IsSurfaceClosed(System.UInt32 surface) {
			try {
				var ret = CAD_isSurfaceClosed(api.Session, surface);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.IsSurfaceClosedReturn retStruct = new CAD.IsSurfaceClosedReturn();
				retStruct.closedU = (0 != ret.closedU);
				retStruct.closedV = (0 != ret.closedV);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IsSurfacePeriodicReturn_c CAD_isSurfacePeriodic(IntPtr _pxz_session_, System.UInt32 surface);

		/// <summary>
		/// return if the surface is periodic on U or on V
		/// </summary>
		/// <param name="surface">The surface</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public CAD.IsSurfacePeriodicReturn IsSurfacePeriodic(System.UInt32 surface) {
			try {
				var ret = CAD_isSurfacePeriodic(api.Session, surface);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				CAD.IsSurfacePeriodicReturn retStruct = new CAD.IsSurfacePeriodicReturn();
				retStruct.periodicU = (0 != ret.periodicU);
				retStruct.periodicV = (0 != ret.periodicV);
				retStruct.periodU = (System.Double)ret.periodU;
				retStruct.periodV = (System.Double)ret.periodV;
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte CAD_needTorusShapeCheck(IntPtr _pxz_session_, System.UInt32 surface, Geom.Point3List_c points);

		/// <summary>
		/// Returns true if the torus has a shape (lemon or apple) corresponding to the provided points
		/// </summary>
		/// <param name="surface">The surface</param>
		/// <param name="points">List of points to check the surface</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean NeedTorusShapeCheck(System.UInt32 surface, Geom.Point3List points) {
			try {
				var points_c = new Geom.Point3List_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3List)points, ref points_c);
				var ret = CAD_needTorusShapeCheck(api.Session, surface, points_c);
				Geom.GeomInterface.Geom_Point3List_free(ref points_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.Double CAD_projectOnCurve(IntPtr _pxz_session_, System.UInt32 curve, Geom.Point3_c point, System.Double precision);

		/// <summary>
		/// project a point to a curve
		/// </summary>
		/// <param name="curve">The curve</param>
		/// <param name="point">The point to project</param>
		/// <param name="precision">Projection precision</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Double ProjectOnCurve(System.UInt32 curve, Geom.Point3 point, System.Double precision = -1) {
			try {
				var point_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)point, ref point_c);
				var ret = CAD_projectOnCurve(api.Session, curve, point_c, precision);
				Geom.GeomInterface.Geom_Point3_free(ref point_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern Geom.Point2_c CAD_projectOnSurface(IntPtr _pxz_session_, System.UInt32 surface, Geom.Point3_c point, System.Double precision);

		/// <summary>
		/// project a point to a surface
		/// </summary>
		/// <param name="surface">The surface</param>
		/// <param name="point">The point to project</param>
		/// <param name="precision">Projection precision</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.Point2 ProjectOnSurface(System.UInt32 surface, Geom.Point3 point, System.Double precision = -1) {
			try {
				var point_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)point, ref point_c);
				var ret = CAD_projectOnSurface(api.Session, surface, point_c, precision);
				Geom.GeomInterface.Geom_Point3_free(ref point_c);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Geom.GeomInterface.ConvertValue(ref ret);
				Geom.GeomInterface.Geom_Point2_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void CAD_setCoEdgeCurve2D(IntPtr _pxz_session_, System.UInt32 coEdge, System.UInt32 curve2D);

		/// <summary>
		/// Set the curve 2D value of a coEdge
		/// </summary>
		/// <param name="coEdge">The coEdge</param>
		/// <param name="curve2D">The new curve 2D</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetCoEdgeCurve2D(System.UInt32 coEdge, System.UInt32 curve2D) {
			try {
				CAD_setCoEdgeCurve2D(api.Session, coEdge, curve2D);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void CAD_setCoEdgeSurface(IntPtr _pxz_session_, System.UInt32 coEdge, System.UInt32 surface);

		/// <summary>
		/// Set the surface value of a coEdge
		/// </summary>
		/// <param name="coEdge">The coEdge</param>
		/// <param name="surface">The new surface</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetCoEdgeSurface(System.UInt32 coEdge, System.UInt32 surface) {
			try {
				CAD_setCoEdgeSurface(api.Session, coEdge, surface);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void CAD_setCurveLimits(IntPtr _pxz_session_, System.UInt32 curve, Bounds1D_c limits);

		/// <summary>
		/// set the parametric space limits of a curve
		/// </summary>
		/// <param name="curve">The curve</param>
		/// <param name="limits">Curve limits</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetCurveLimits(System.UInt32 curve, Bounds1D limits) {
			try {
				var limits_c = new CAD.Bounds1D_c();
				ConvertValue((CAD.Bounds1D)limits, ref limits_c);
				CAD_setCurveLimits(api.Session, curve, limits_c);
				CAD.CADInterface.CAD_Bounds1D_free(ref limits_c);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void CAD_setEdgeMaterial(IntPtr _pxz_session_, System.UInt32 edge, System.UInt32 material);

		/// <summary>
		/// Define an edge's material
		/// </summary>
		/// <param name="edge">The edge to apply to style to</param>
		/// <param name="material">The material to apply</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetEdgeMaterial(System.UInt32 edge, System.UInt32 material) {
			try {
				CAD_setEdgeMaterial(api.Session, edge, material);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region structure creation

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 CAD_createBody(IntPtr _pxz_session_, System.UInt32 outerShell, ClosedShellList_c innerShells);

		/// <summary>
		/// Create a body from a surface
		/// </summary>
		/// <param name="outerShell">ClosedShell used to create the body</param>
		/// <param name="innerShells">List of closedShell used to create the body</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateBody(System.UInt32 outerShell, ClosedShellList innerShells = null) {
			innerShells = innerShells ?? new CAD.ClosedShellList(new System.UInt32[] {});
			try {
				var innerShells_c = new CAD.ClosedShellList_c();
				ConvertValue((CAD.ClosedShellList)innerShells, ref innerShells_c);
				var ret = CAD_createBody(api.Session, outerShell, innerShells_c);
				CAD.CADInterface.CAD_ClosedShellList_free(ref innerShells_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createClosedShell(IntPtr _pxz_session_, FaceList_c faces, Geom.OrientationList_c orientations);

		/// <summary>
		/// Create a closedShell from a set of faces of a set of orientations
		/// </summary>
		/// <param name="faces">List of faces composing the closedShell</param>
		/// <param name="orientations">List of orientations for each face</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateClosedShell(FaceList faces, Geom.OrientationList orientations) {
			try {
				var faces_c = new CAD.FaceList_c();
				ConvertValue((CAD.FaceList)faces, ref faces_c);
				var orientations_c = new Geom.OrientationList_c();
				Geom.GeomInterface.ConvertValue((Geom.OrientationList)orientations, ref orientations_c);
				var ret = CAD_createClosedShell(api.Session, faces_c, orientations_c);
				CAD.CADInterface.CAD_FaceList_free(ref faces_c);
				Geom.GeomInterface.Geom_OrientationList_free(ref orientations_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createCoEdge(IntPtr _pxz_session_, System.UInt32 edge, System.Byte orientation, System.UInt32 surface, System.UInt32 curve2D, System.Byte computeGateway);

		/// <summary>
		/// Create an coEdge with a edge and an orientation
		/// </summary>
		/// <param name="edge">Edge used to create the coEdge</param>
		/// <param name="orientation">Orientation of the edge regarding the loop</param>
		/// <param name="surface">The surface trimmed by the edge</param>
		/// <param name="curve2D">Surfacic curve of the edge on the surface trimmed</param>
		/// <param name="computeGateway">Needed if 3d curve and 2d curve have different parametrization</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateCoEdge(System.UInt32 edge, System.Boolean orientation, System.UInt32 surface = 0, System.UInt32 curve2D = 0, System.Boolean computeGateway = false) {
			try {
				var ret = CAD_createCoEdge(api.Session, edge, Convert.ToByte(orientation), surface, curve2D, Convert.ToByte(computeGateway));
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createEdge(IntPtr _pxz_session_, System.UInt32 curve, System.UInt32 startVertex, System.UInt32 endVertex);

		/// <summary>
		/// Create an edge with a curve an extremity vertices
		/// </summary>
		/// <param name="curve">Curve used to create the edge</param>
		/// <param name="startVertex">The start vertex</param>
		/// <param name="endVertex">The end vertex</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateEdge(System.UInt32 curve, System.UInt32 startVertex, System.UInt32 endVertex) {
			try {
				var ret = CAD_createEdge(api.Session, curve, startVertex, endVertex);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createEdgeFromCurve(IntPtr _pxz_session_, System.UInt32 curve);

		/// <summary>
		/// Create an edge from a limited curve
		/// </summary>
		/// <param name="curve">Limited curve used to create the edge</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateEdgeFromCurve(System.UInt32 curve) {
			try {
				var ret = CAD_createEdgeFromCurve(api.Session, curve);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createEdgeWithBounds(IntPtr _pxz_session_, System.UInt32 curve, System.UInt32 startVertex, System.UInt32 endVertex, Bounds1D_c bounds);

		/// <summary>
		/// Create an edge with a curve an extremity vertices and a given boundary
		/// </summary>
		/// <param name="curve">Curve used to create the edge</param>
		/// <param name="startVertex">The start vertex</param>
		/// <param name="endVertex">The end vertex</param>
		/// <param name="bounds">The parametrization boundary</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateEdgeWithBounds(System.UInt32 curve, System.UInt32 startVertex, System.UInt32 endVertex, Bounds1D bounds) {
			try {
				var bounds_c = new CAD.Bounds1D_c();
				ConvertValue((CAD.Bounds1D)bounds, ref bounds_c);
				var ret = CAD_createEdgeWithBounds(api.Session, curve, startVertex, endVertex, bounds_c);
				CAD.CADInterface.CAD_Bounds1D_free(ref bounds_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createFace(IntPtr _pxz_session_, System.UInt32 surface, LoopList_c loopList, System.Byte useSurfaceOrientation);

		/// <summary>
		/// Create a face from a surface
		/// </summary>
		/// <param name="surface">Surface used to create the face</param>
		/// <param name="loopList">List of Loops used to create the face</param>
		/// <param name="useSurfaceOrientation">If True, the face will have the same orientation than the surface and loops will be inverted if they are inconsistent</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateFace(System.UInt32 surface, LoopList loopList = null, System.Boolean useSurfaceOrientation = false) {
			loopList = loopList ?? new CAD.LoopList(new System.UInt32[] {});
			try {
				var loopList_c = new CAD.LoopList_c();
				ConvertValue((CAD.LoopList)loopList, ref loopList_c);
				var ret = CAD_createFace(api.Session, surface, loopList_c, Convert.ToByte(useSurfaceOrientation));
				CAD.CADInterface.CAD_LoopList_free(ref loopList_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createLoop(IntPtr _pxz_session_, CoEdgeList_c coEdges, System.Byte check, System.Byte deleteIsolatedVertices);

		/// <summary>
		/// Create a loop from a set of edges of a set of orientations
		/// </summary>
		/// <param name="coEdges">List of coEdges composing the loop</param>
		/// <param name="check">If true, the loop check if edges are well connected or not</param>
		/// <param name="deleteIsolatedVertices">If true, this will merge isolated vertices in the loop</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateLoop(CoEdgeList coEdges, System.Boolean check = true, System.Boolean deleteIsolatedVertices = true) {
			try {
				var coEdges_c = new CAD.CoEdgeList_c();
				ConvertValue((CAD.CoEdgeList)coEdges, ref coEdges_c);
				var ret = CAD_createLoop(api.Session, coEdges_c, Convert.ToByte(check), Convert.ToByte(deleteIsolatedVertices));
				CAD.CADInterface.CAD_CoEdgeList_free(ref coEdges_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createLoopFromCurve(IntPtr _pxz_session_, System.UInt32 curve);

		/// <summary>
		/// Create a loop from a finite curve
		/// </summary>
		/// <param name="curve">The curve to create the loop with</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateLoopFromCurve(System.UInt32 curve) {
			try {
				var ret = CAD_createLoopFromCurve(api.Session, curve);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createOpenShell(IntPtr _pxz_session_, FaceList_c faces, Geom.OrientationList_c orientations);

		/// <summary>
		/// Create a openShell from a set of faces of a set of orientations and set of loops
		/// </summary>
		/// <param name="faces">List of faces composing the openShell</param>
		/// <param name="orientations">List of orientations for each face</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateOpenShell(FaceList faces, Geom.OrientationList orientations) {
			try {
				var faces_c = new CAD.FaceList_c();
				ConvertValue((CAD.FaceList)faces, ref faces_c);
				var orientations_c = new Geom.OrientationList_c();
				Geom.GeomInterface.ConvertValue((Geom.OrientationList)orientations, ref orientations_c);
				var ret = CAD_createOpenShell(api.Session, faces_c, orientations_c);
				CAD.CADInterface.CAD_FaceList_free(ref faces_c);
				Geom.GeomInterface.Geom_OrientationList_free(ref orientations_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createVertex(IntPtr _pxz_session_, Geom.Point3_c position);

		/// <summary>
		/// Create a vertex from a position
		/// </summary>
		/// <param name="position">Vertex position</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateVertex(Geom.Point3 position) {
			try {
				var position_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)position, ref position_c);
				var ret = CAD_createVertex(api.Session, position_c);
				Geom.GeomInterface.Geom_Point3_free(ref position_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern void CAD_invertCoEdge(IntPtr _pxz_session_, System.UInt32 coedge);

		/// <summary>
		/// Invert a coedge
		/// </summary>
		/// <param name="coedge">The coedge to invert</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void InvertCoEdge(System.UInt32 coedge) {
			try {
				CAD_invertCoEdge(api.Session, coedge);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void CAD_invertFaces(IntPtr _pxz_session_, FaceList_c faces, System.Byte invertLoops);

		/// <summary>
		/// Invert faces
		/// </summary>
		/// <param name="faces">The faces to invert</param>
		/// <param name="invertLoops">If true, invert loops orientation</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void InvertFaces(FaceList faces, System.Boolean invertLoops = true) {
			try {
				var faces_c = new CAD.FaceList_c();
				ConvertValue((CAD.FaceList)faces, ref faces_c);
				CAD_invertFaces(api.Session, faces_c, Convert.ToByte(invertLoops));
				CAD.CADInterface.CAD_FaceList_free(ref faces_c);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void CAD_invertLoop(IntPtr _pxz_session_, System.UInt32 loop);

		/// <summary>
		/// Invert a loop
		/// </summary>
		/// <param name="loop">The loop to invert</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void InvertLoop(System.UInt32 loop) {
			try {
				CAD_invertLoop(api.Session, loop);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte CAD_isSurfaceFinite(IntPtr _pxz_session_, System.UInt32 surface);

		/// <summary>
		/// return if the surface is finite
		/// </summary>
		/// <param name="surface">The surface</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean IsSurfaceFinite(System.UInt32 surface) {
			try {
				var ret = CAD_isSurfaceFinite(api.Session, surface);
				System.String err = ConvertValue(CAD_getLastError());
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

		#region surfaces

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void CAD_addPrecisionArea(IntPtr _pxz_session_, System.UInt32 surface, Geom.AABR_c aabr);

		/// <summary>
		/// Define a working area on the 2D projection of the surface to define a parametric precision
		/// </summary>
		/// <param name="surface">Surface on which the precision area will be set</param>
		/// <param name="aabr">2D area defining the working area</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AddPrecisionArea(System.UInt32 surface, Geom.AABR aabr) {
			try {
				var aabr_c = new Geom.AABR_c();
				Geom.GeomInterface.ConvertValue((Geom.AABR)aabr, ref aabr_c);
				CAD_addPrecisionArea(api.Session, surface, aabr_c);
				Geom.GeomInterface.Geom_AABR_free(ref aabr_c);
				System.String err = ConvertValue(CAD_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 CAD_createBezierSurface(IntPtr _pxz_session_, Int32 degreeU, Int32 degreeV, Geom.Point3List_c poles);

		/// <summary>
		/// Create a new bezier surface
		/// </summary>
		/// <param name="degreeU">U degree</param>
		/// <param name="degreeV">V degree</param>
		/// <param name="poles">Poles list</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateBezierSurface(System.Int32 degreeU, System.Int32 degreeV, Geom.Point3List poles) {
			try {
				var poles_c = new Geom.Point3List_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3List)poles, ref poles_c);
				var ret = CAD_createBezierSurface(api.Session, degreeU, degreeV, poles_c);
				Geom.GeomInterface.Geom_Point3List_free(ref poles_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createConeSurface(IntPtr _pxz_session_, System.Double radius, System.Double semiAngle, Geom.Matrix4_c matrix);

		/// <summary>
		/// Create a new cone surface
		/// </summary>
		/// <param name="radius">Radius of the cone at origin</param>
		/// <param name="semiAngle">Semi-angle of the cone (in rad)</param>
		/// <param name="matrix">Positionning matrix of the cone</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateConeSurface(System.Double radius, System.Double semiAngle, Geom.Matrix4 matrix = null) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				var ret = CAD_createConeSurface(api.Session, radius, semiAngle, matrix_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createCurveExtrusionSurface(IntPtr _pxz_session_, System.UInt32 generatrixCurve, System.UInt32 directrixCurve, System.UInt32 refSurface);

		/// <summary>
		/// Create a new curveExtrusion surface
		/// </summary>
		/// <param name="generatrixCurve">The generatrix curve</param>
		/// <param name="directrixCurve">The directrix curve</param>
		/// <param name="refSurface">The reference surface</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateCurveExtrusionSurface(System.UInt32 generatrixCurve, System.UInt32 directrixCurve, System.UInt32 refSurface = 0) {
			try {
				var ret = CAD_createCurveExtrusionSurface(api.Session, generatrixCurve, directrixCurve, refSurface);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createCylinderSurface(IntPtr _pxz_session_, System.Double radius, Geom.Matrix4_c matrix);

		/// <summary>
		/// Create a new cylinder surface
		/// </summary>
		/// <param name="radius">Radius of the cylinder</param>
		/// <param name="matrix">Positionning matrix of the cylinder</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateCylinderSurface(System.Double radius, Geom.Matrix4 matrix = null) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				var ret = CAD_createCylinderSurface(api.Session, radius, matrix_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createEllipticConeSurface(IntPtr _pxz_session_, System.Double radius1, System.Double radius2, System.Double semiAngle, Geom.Matrix4_c matrix);

		/// <summary>
		/// Create a new elliptic cone surface
		/// </summary>
		/// <param name="radius1">Radius of the cone at origin on the X axis</param>
		/// <param name="radius2">Radius of the cone at origin on the Y axis</param>
		/// <param name="semiAngle">Semi-angle of the cone (in rad)</param>
		/// <param name="matrix">Positionning matrix of the cone</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateEllipticConeSurface(System.Double radius1, System.Double radius2, System.Double semiAngle, Geom.Matrix4 matrix = null) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				var ret = CAD_createEllipticConeSurface(api.Session, radius1, radius2, semiAngle, matrix_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createNURBSSurface(IntPtr _pxz_session_, Int32 degreeU, Int32 degreeV, Core.DoubleList_c knotsU, Core.DoubleList_c knotsV, Geom.Point3List_c poles, Core.DoubleList_c weights);

		/// <summary>
		/// Create a new NURBS surface
		/// </summary>
		/// <param name="degreeU">U degree</param>
		/// <param name="degreeV">V degree</param>
		/// <param name="knotsU">Knots on U</param>
		/// <param name="knotsV">Knots on V</param>
		/// <param name="poles">Poles list</param>
		/// <param name="weights">Weights list</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateNURBSSurface(System.Int32 degreeU, System.Int32 degreeV, Core.DoubleList knotsU, Core.DoubleList knotsV, Geom.Point3List poles, Core.DoubleList weights = null) {
			weights = weights ?? new Core.DoubleList(new System.Double[] {});
			try {
				var knotsU_c = new Core.DoubleList_c();
				Core.CoreInterface.ConvertValue((Core.DoubleList)knotsU, ref knotsU_c);
				var knotsV_c = new Core.DoubleList_c();
				Core.CoreInterface.ConvertValue((Core.DoubleList)knotsV, ref knotsV_c);
				var poles_c = new Geom.Point3List_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3List)poles, ref poles_c);
				var weights_c = new Core.DoubleList_c();
				Core.CoreInterface.ConvertValue((Core.DoubleList)weights, ref weights_c);
				var ret = CAD_createNURBSSurface(api.Session, degreeU, degreeV, knotsU_c, knotsV_c, poles_c, weights_c);
				Core.CoreInterface.Core_DoubleList_free(ref knotsU_c);
				Core.CoreInterface.Core_DoubleList_free(ref knotsV_c);
				Geom.GeomInterface.Geom_Point3List_free(ref poles_c);
				Core.CoreInterface.Core_DoubleList_free(ref weights_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createOffsetSurface(IntPtr _pxz_session_, System.UInt32 baseSurface, System.Double distance);

		/// <summary>
		/// Create a new offset surface
		/// </summary>
		/// <param name="baseSurface">The base surface</param>
		/// <param name="distance">The offset distance</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateOffsetSurface(System.UInt32 baseSurface, System.Double distance) {
			try {
				var ret = CAD_createOffsetSurface(api.Session, baseSurface, distance);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createPlaneSurface(IntPtr _pxz_session_, Geom.Matrix4_c matrix);

		/// <summary>
		/// Create a new plane surface
		/// </summary>
		/// <param name="matrix">Positionning matrix of the plane</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreatePlaneSurface(Geom.Matrix4 matrix = null) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				var ret = CAD_createPlaneSurface(api.Session, matrix_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createRevolutionSurface(IntPtr _pxz_session_, System.UInt32 generatrixCurve, Geom.Point3_c axisOrigin, Geom.Point3_c axisDirection, System.Double startParam, System.Double endParam);

		/// <summary>
		/// Create a new revolution surface
		/// </summary>
		/// <param name="generatrixCurve">Generatrix curve rotated to create the revolution surface</param>
		/// <param name="axisOrigin">Axis origin point</param>
		/// <param name="axisDirection">Axis direction vector</param>
		/// <param name="startParam">Start angle of the revolution surface (in rad)</param>
		/// <param name="endParam">End angle of the revolution surface (in rad)</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateRevolutionSurface(System.UInt32 generatrixCurve, Geom.Point3 axisOrigin, Geom.Point3 axisDirection, System.Double startParam = 0, System.Double endParam = Core.CoreInterface.TwoPi) {
			try {
				var axisOrigin_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)axisOrigin, ref axisOrigin_c);
				var axisDirection_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)axisDirection, ref axisDirection_c);
				var ret = CAD_createRevolutionSurface(api.Session, generatrixCurve, axisOrigin_c, axisDirection_c, startParam, endParam);
				Geom.GeomInterface.Geom_Point3_free(ref axisOrigin_c);
				Geom.GeomInterface.Geom_Point3_free(ref axisDirection_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createRuledSurface(IntPtr _pxz_session_, System.UInt32 firstCurve, System.UInt32 secondCurve);

		/// <summary>
		/// Create a new ruled surface
		/// </summary>
		/// <param name="firstCurve">First Curve</param>
		/// <param name="secondCurve">Seconde Curve</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateRuledSurface(System.UInt32 firstCurve, System.UInt32 secondCurve) {
			try {
				var ret = CAD_createRuledSurface(api.Session, firstCurve, secondCurve);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createSphereSurface(IntPtr _pxz_session_, System.Double radius, Geom.Matrix4_c matrix);

		/// <summary>
		/// Create a new sphere surface
		/// </summary>
		/// <param name="radius">Radius of the sphere</param>
		/// <param name="matrix">Positionning matrix of the sphere</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateSphereSurface(System.Double radius, Geom.Matrix4 matrix = null) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				var ret = CAD_createSphereSurface(api.Session, radius, matrix_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createTabulatedCylinderSurface(IntPtr _pxz_session_, System.UInt32 directrixCurve, Geom.Point3_c GeneratixLine, System.Double minRange, System.Double maxRange);

		/// <summary>
		/// Create a new tabulated cylinder surface
		/// </summary>
		/// <param name="directrixCurve">Directrix Curve</param>
		/// <param name="GeneratixLine">Generatrix Line</param>
		/// <param name="minRange">Minimimum value of the range</param>
		/// <param name="maxRange">Maximum value of the range</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateTabulatedCylinderSurface(System.UInt32 directrixCurve, Geom.Point3 GeneratixLine, System.Double minRange, System.Double maxRange) {
			try {
				var GeneratixLine_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)GeneratixLine, ref GeneratixLine_c);
				var ret = CAD_createTabulatedCylinderSurface(api.Session, directrixCurve, GeneratixLine_c, minRange, maxRange);
				Geom.GeomInterface.Geom_Point3_free(ref GeneratixLine_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.UInt32 CAD_createTorusSurface(IntPtr _pxz_session_, System.Double radiusMax, System.Double radiusMin, Geom.Matrix4_c matrix);

		/// <summary>
		/// Create a new torus surface
		/// </summary>
		/// <param name="radiusMax">Major radius </param>
		/// <param name="radiusMin">Minor radius </param>
		/// <param name="matrix">Positionning matrix of the sphere</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateTorusSurface(System.Double radiusMax, System.Double radiusMin, Geom.Matrix4 matrix = null) {
			try {
				var matrix_c = new Geom.Matrix4_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
				var ret = CAD_createTorusSurface(api.Session, radiusMax, radiusMin, matrix_c);
				Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
				System.String err = ConvertValue(CAD_getLastError());
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
		private static extern System.Byte CAD_needPrecisionArea(IntPtr _pxz_session_, System.UInt32 surface);

		/// <summary>
		/// tells if it needs a working area on the surface
		/// </summary>
		/// <param name="surface">Surface to check if it needs precision area</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean NeedPrecisionArea(System.UInt32 surface) {
			try {
				var ret = CAD_needPrecisionArea(api.Session, surface);
				System.String err = ConvertValue(CAD_getLastError());
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

	}
}
