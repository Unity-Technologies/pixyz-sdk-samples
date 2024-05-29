#pragma warning disable CA2101

using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System;
using PiXYZAPI = UnityEngine.Pixyz.API.PiXYZAPI;

namespace UnityEngine.Pixyz.Geom {

	public class GeomInterface : API.Interface {

		#region Types Init/Free Methods

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_OrientationList_init(ref OrientationList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_OrientationList_free(ref OrientationList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Array4_init(ref Array4_c arr, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Array4_free(ref Array4_c arr);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Point4_init(ref Point4_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Point4_free(ref Point4_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Point2_init(ref Point2_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Point2_free(ref Point2_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Point3_init(ref Point3_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Point3_free(ref Point3_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_ExtendedBox_init(ref ExtendedBox_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_ExtendedBox_free(ref ExtendedBox_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_OBB_init(ref OBB_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_OBB_free(ref OBB_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Affine_init(ref Affine_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Affine_free(ref Affine_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Vector4I_init(ref Vector4I_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Vector4I_free(ref Vector4I_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_AABR_init(ref AABR_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_AABR_free(ref AABR_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_AABB_init(ref AABB_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_AABB_free(ref AABB_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Matrix4_init(ref Matrix4_c arr, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Matrix4_free(ref Matrix4_c arr);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Array3_init(ref Array3_c arr, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Array3_free(ref Array3_c arr);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Matrix3_init(ref Matrix3_c arr, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Matrix3_free(ref Matrix3_c arr);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Point2List_init(ref Point2List_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Point2List_free(ref Point2List_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Curvatures_init(ref Curvatures_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Curvatures_free(ref Curvatures_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_CurvaturesList_init(ref CurvaturesList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_CurvaturesList_free(ref CurvaturesList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Matrix4List_init(ref Matrix4List_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Matrix4List_free(ref Matrix4List_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Matrix4ListList_init(ref Matrix4ListList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Matrix4ListList_free(ref Matrix4ListList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Point4List_init(ref Point4List_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Point4List_free(ref Point4List_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Point2ListList_init(ref Point2ListList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Point2ListList_free(ref Point2ListList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Vector4IList_init(ref Vector4IList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Vector4IList_free(ref Vector4IList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Ray_init(ref Ray_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Ray_free(ref Ray_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Point3List_init(ref Point3List_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Point3List_free(ref Point3List_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Point3ListList_init(ref Point3ListList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Point3ListList_free(ref Point3ListList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_CameraCalibration_init(ref CameraCalibration_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_CameraCalibration_free(ref CameraCalibration_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Vector3List_init(ref Vector3List_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Vector3List_free(ref Vector3List_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Vector4List_init(ref Vector4List_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_Vector4List_free(ref Vector4List_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_DistanceList_init(ref DistanceList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Geom_DistanceList_free(ref DistanceList_c list);

	internal static OrientationList ConvertValue(ref OrientationList_c s) {
		OrientationList list = new OrientationList((int)s.size);
		if (s.size==0) return list;

		int[] tab = new int[s.size];
		Marshal.Copy(s.ptr, tab, 0, (int)s.size);
			list.list = CopyMemory<System.Boolean>(s.ptr, (int)s.size);
		return list;
	}

	internal static OrientationList_c ConvertValue(OrientationList s, ref OrientationList_c list) {
		Geom.GeomInterface.Geom_OrientationList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = ConvertValue(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static Array4 ConvertValue(ref Array4_c arr) {
		Array4 ss = new Array4();
		System.Double[] tab = new System.Double[4];
		Marshal.Copy(arr.tab, tab, 0, 4);
		for (int i = 0; i < 4; ++i)
			ss.tab[i] = tab[i];
		return ss;
	}

	internal static Array4_c ConvertValue(Array4 s, ref Array4_c list) {
		Geom.GeomInterface.Geom_Array4_init(ref list, (System.UInt64)4);
		var tab = new System.Double[4];
		for (int i=0; i < 4; ++i)
			tab[i] = s.tab[i];
		Marshal.Copy(tab, 0, list.tab, 4);
		return list;
	}

	internal static Point4 ConvertValue(ref Point4_c s) {
		Point4 ss = new Point4();
		ss.x = (System.Double)s.x;
		ss.y = (System.Double)s.y;
		ss.z = (System.Double)s.z;
		ss.w = (System.Double)s.w;
		return ss;
	}

	internal static Point4_c ConvertValue(Point4 s, ref Point4_c ss) {
		Geom.GeomInterface.Geom_Point4_init(ref ss);
		ss.x = (System.Double)s.x;
		ss.y = (System.Double)s.y;
		ss.z = (System.Double)s.z;
		ss.w = (System.Double)s.w;
		return ss;
	}

	internal static Point2 ConvertValue(ref Point2_c s) {
		Point2 ss = new Point2();
		ss.x = (System.Double)s.x;
		ss.y = (System.Double)s.y;
		return ss;
	}

	internal static Point2_c ConvertValue(Point2 s, ref Point2_c ss) {
		Geom.GeomInterface.Geom_Point2_init(ref ss);
		ss.x = (System.Double)s.x;
		ss.y = (System.Double)s.y;
		return ss;
	}

	internal static Point3 ConvertValue(ref Point3_c s) {
		Point3 ss = new Point3();
		ss.x = (System.Double)s.x;
		ss.y = (System.Double)s.y;
		ss.z = (System.Double)s.z;
		return ss;
	}

	internal static Point3_c ConvertValue(Point3 s, ref Point3_c ss) {
		Geom.GeomInterface.Geom_Point3_init(ref ss);
		ss.x = (System.Double)s.x;
		ss.y = (System.Double)s.y;
		ss.z = (System.Double)s.z;
		return ss;
	}

	internal static ExtendedBox ConvertValue(ref ExtendedBox_c s) {
		ExtendedBox ss = new ExtendedBox();
		ss.position = ConvertValue(ref s.position);
		ss.extentX = (System.Double)s.extentX;
		ss.extentY = (System.Double)s.extentY;
		ss.extentZ = (System.Double)s.extentZ;
		return ss;
	}

	internal static ExtendedBox_c ConvertValue(ExtendedBox s, ref ExtendedBox_c ss) {
		Geom.GeomInterface.Geom_ExtendedBox_init(ref ss);
		ConvertValue(s.position, ref ss.position);
		ss.extentX = (System.Double)s.extentX;
		ss.extentY = (System.Double)s.extentY;
		ss.extentZ = (System.Double)s.extentZ;
		return ss;
	}

	internal static OBB ConvertValue(ref OBB_c s) {
		OBB ss = new OBB();
		ss.corner = ConvertValue(ref s.corner);
		ss.xAxis = ConvertValue(ref s.xAxis);
		ss.yAxis = ConvertValue(ref s.yAxis);
		ss.zAxis = ConvertValue(ref s.zAxis);
		return ss;
	}

	internal static OBB_c ConvertValue(OBB s, ref OBB_c ss) {
		Geom.GeomInterface.Geom_OBB_init(ref ss);
		ConvertValue(s.corner, ref ss.corner);
		ConvertValue(s.xAxis, ref ss.xAxis);
		ConvertValue(s.yAxis, ref ss.yAxis);
		ConvertValue(s.zAxis, ref ss.zAxis);
		return ss;
	}

	internal static Affine ConvertValue(ref Affine_c s) {
		Affine ss = new Affine();
		ss.origin = ConvertValue(ref s.origin);
		ss.xAxis = ConvertValue(ref s.xAxis);
		ss.yAxis = ConvertValue(ref s.yAxis);
		ss.zAxis = ConvertValue(ref s.zAxis);
		return ss;
	}

	internal static Affine_c ConvertValue(Affine s, ref Affine_c ss) {
		Geom.GeomInterface.Geom_Affine_init(ref ss);
		ConvertValue(s.origin, ref ss.origin);
		ConvertValue(s.xAxis, ref ss.xAxis);
		ConvertValue(s.yAxis, ref ss.yAxis);
		ConvertValue(s.zAxis, ref ss.zAxis);
		return ss;
	}

	internal static Vector4I ConvertValue(ref Vector4I_c s) {
		Vector4I ss = new Vector4I();
		ss.x = (System.Int32)s.x;
		ss.y = (System.Int32)s.y;
		ss.z = (System.Int32)s.z;
		ss.w = (System.Int32)s.w;
		return ss;
	}

	internal static Vector4I_c ConvertValue(Vector4I s, ref Vector4I_c ss) {
		Geom.GeomInterface.Geom_Vector4I_init(ref ss);
		ss.x = (Int32)s.x;
		ss.y = (Int32)s.y;
		ss.z = (Int32)s.z;
		ss.w = (Int32)s.w;
		return ss;
	}

	internal static AABR ConvertValue(ref AABR_c s) {
		AABR ss = new AABR();
		ss.low = ConvertValue(ref s.low);
		ss.high = ConvertValue(ref s.high);
		return ss;
	}

	internal static AABR_c ConvertValue(AABR s, ref AABR_c ss) {
		Geom.GeomInterface.Geom_AABR_init(ref ss);
		ConvertValue(s.low, ref ss.low);
		ConvertValue(s.high, ref ss.high);
		return ss;
	}

	internal static AABB ConvertValue(ref AABB_c s) {
		AABB ss = new AABB();
		ss.low = ConvertValue(ref s.low);
		ss.high = ConvertValue(ref s.high);
		return ss;
	}

	internal static AABB_c ConvertValue(AABB s, ref AABB_c ss) {
		Geom.GeomInterface.Geom_AABB_init(ref ss);
		ConvertValue(s.low, ref ss.low);
		ConvertValue(s.high, ref ss.high);
		return ss;
	}

	internal static Matrix4 ConvertValue(ref Matrix4_c arr) {
		Matrix4 ss = new Matrix4();
		for (int i = 0; i < 4; ++i) {
			IntPtr p = new IntPtr(arr.tab.ToInt64() + i * Marshal.SizeOf(typeof(Array4_c)));
			Array4_c value = (Array4_c)Marshal.PtrToStructure(p, typeof(Array4_c));
			ss.tab[i] = ConvertValue(ref value);
		}
		return ss;
	}

	internal static Matrix4_c ConvertValue(Matrix4 s, ref Matrix4_c list) {
		Geom.GeomInterface.Geom_Matrix4_init(ref list, (System.UInt64)4);
		for (int i = 0; i < 4; ++i) {
			Array4_c elt = new Array4_c();
			ConvertValue(s.tab[i], ref elt);
			IntPtr p = new IntPtr(list.tab.ToInt64() + i * Marshal.SizeOf(typeof(Array4_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Array3 ConvertValue(ref Array3_c arr) {
		Array3 ss = new Array3();
		System.Double[] tab = new System.Double[3];
		Marshal.Copy(arr.tab, tab, 0, 3);
		for (int i = 0; i < 3; ++i)
			ss.tab[i] = tab[i];
		return ss;
	}

	internal static Array3_c ConvertValue(Array3 s, ref Array3_c list) {
		Geom.GeomInterface.Geom_Array3_init(ref list, (System.UInt64)3);
		var tab = new System.Double[4];
		for (int i=0; i < 4; ++i)
			tab[i] = s.tab[i];
		Marshal.Copy(tab, 0, list.tab, 3);
		return list;
	}

	internal static Matrix3 ConvertValue(ref Matrix3_c arr) {
		Matrix3 ss = new Matrix3();
		for (int i = 0; i < 3; ++i) {
			IntPtr p = new IntPtr(arr.tab.ToInt64() + i * Marshal.SizeOf(typeof(Array3_c)));
			Array3_c value = (Array3_c)Marshal.PtrToStructure(p, typeof(Array3_c));
			ss.tab[i] = ConvertValue(ref value);
		}
		return ss;
	}

	internal static Matrix3_c ConvertValue(Matrix3 s, ref Matrix3_c list) {
		Geom.GeomInterface.Geom_Matrix3_init(ref list, (System.UInt64)3);
		for (int i = 0; i < 3; ++i) {
			Array3_c elt = new Array3_c();
			ConvertValue(s.tab[i], ref elt);
			IntPtr p = new IntPtr(list.tab.ToInt64() + i * Marshal.SizeOf(typeof(Array3_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Point2List ConvertValue(ref Point2List_c s) {
		Point2List list = new Point2List((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<Point2>(s.ptr, (int)s.size);
		return list;
	}

	internal static Point2List_c ConvertValue(Point2List s, ref Point2List_c list) {
		Geom.GeomInterface.Geom_Point2List_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Point2_c elt = new Point2_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Point2_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Curvatures ConvertValue(ref Curvatures_c s) {
		Curvatures ss = new Curvatures();
		ss.k1 = (System.Double)s.k1;
		ss.k2 = (System.Double)s.k2;
		ss.v1 = ConvertValue(ref s.v1);
		ss.v2 = ConvertValue(ref s.v2);
		return ss;
	}

	internal static Curvatures_c ConvertValue(Curvatures s, ref Curvatures_c ss) {
		Geom.GeomInterface.Geom_Curvatures_init(ref ss);
		ss.k1 = (System.Double)s.k1;
		ss.k2 = (System.Double)s.k2;
		ConvertValue(s.v1, ref ss.v1);
		ConvertValue(s.v2, ref ss.v2);
		return ss;
	}

	internal static CurvaturesList ConvertValue(ref CurvaturesList_c s) {
		CurvaturesList list = new CurvaturesList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(Curvatures_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			Curvatures_c value = (Curvatures_c)Marshal.PtrToStructure(p, typeof(Curvatures_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static CurvaturesList_c ConvertValue(CurvaturesList s, ref CurvaturesList_c list) {
		Geom.GeomInterface.Geom_CurvaturesList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Curvatures_c elt = new Curvatures_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Curvatures_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Matrix4List ConvertValue(ref Matrix4List_c s) {
		Matrix4List list = new Matrix4List((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(Matrix4_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			Matrix4_c value = (Matrix4_c)Marshal.PtrToStructure(p, typeof(Matrix4_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static Matrix4List_c ConvertValue(Matrix4List s, ref Matrix4List_c list) {
		Geom.GeomInterface.Geom_Matrix4List_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Matrix4_c elt = new Matrix4_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Matrix4_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Matrix4ListList ConvertValue(ref Matrix4ListList_c s) {
		Matrix4ListList list = new Matrix4ListList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(Matrix4List_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			Matrix4List_c value = (Matrix4List_c)Marshal.PtrToStructure(p, typeof(Matrix4List_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static Matrix4ListList_c ConvertValue(Matrix4ListList s, ref Matrix4ListList_c list) {
		Geom.GeomInterface.Geom_Matrix4ListList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Matrix4List_c elt = new Matrix4List_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Matrix4List_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Point4List ConvertValue(ref Point4List_c s) {
		Point4List list = new Point4List((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<Point4>(s.ptr, (int)s.size);
		return list;
	}

	internal static Point4List_c ConvertValue(Point4List s, ref Point4List_c list) {
		Geom.GeomInterface.Geom_Point4List_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Point4_c elt = new Point4_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Point4_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Point2ListList ConvertValue(ref Point2ListList_c s) {
		Point2ListList list = new Point2ListList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(Point2List_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			Point2List_c value = (Point2List_c)Marshal.PtrToStructure(p, typeof(Point2List_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static Point2ListList_c ConvertValue(Point2ListList s, ref Point2ListList_c list) {
		Geom.GeomInterface.Geom_Point2ListList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Point2List_c elt = new Point2List_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Point2List_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Vector4IList ConvertValue(ref Vector4IList_c s) {
		Vector4IList list = new Vector4IList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<Vector4I>(s.ptr, (int)s.size);
		return list;
	}

	internal static Vector4IList_c ConvertValue(Vector4IList s, ref Vector4IList_c list) {
		Geom.GeomInterface.Geom_Vector4IList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Vector4I_c elt = new Vector4I_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Vector4I_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Ray ConvertValue(ref Ray_c s) {
		Ray ss = new Ray();
		ss.origin = ConvertValue(ref s.origin);
		ss.direction = ConvertValue(ref s.direction);
		return ss;
	}

	internal static Ray_c ConvertValue(Ray s, ref Ray_c ss) {
		Geom.GeomInterface.Geom_Ray_init(ref ss);
		ConvertValue(s.origin, ref ss.origin);
		ConvertValue(s.direction, ref ss.direction);
		return ss;
	}

	internal static Point3List ConvertValue(ref Point3List_c s) {
		Point3List list = new Point3List((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<Point3>(s.ptr, (int)s.size);
		return list;
	}

	internal static Point3List_c ConvertValue(Point3List s, ref Point3List_c list) {
		Geom.GeomInterface.Geom_Point3List_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Point3_c elt = new Point3_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Point3_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Point3ListList ConvertValue(ref Point3ListList_c s) {
		Point3ListList list = new Point3ListList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(Point3List_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			Point3List_c value = (Point3List_c)Marshal.PtrToStructure(p, typeof(Point3List_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static Point3ListList_c ConvertValue(Point3ListList s, ref Point3ListList_c list) {
		Geom.GeomInterface.Geom_Point3ListList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Point3List_c elt = new Point3List_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Point3List_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static CameraCalibration ConvertValue(ref CameraCalibration_c s) {
		CameraCalibration ss = new CameraCalibration();
		ss.radial1 = (System.Double)s.radial1;
		ss.radial2 = (System.Double)s.radial2;
		ss.radial3 = (System.Double)s.radial3;
		ss.tangential1 = (System.Double)s.tangential1;
		ss.tangential2 = (System.Double)s.tangential2;
		ss.focalX = (System.Double)s.focalX;
		ss.focalY = (System.Double)s.focalY;
		ss.centerX = (System.Double)s.centerX;
		ss.centerY = (System.Double)s.centerY;
		ss.skew = (System.Double)s.skew;
		return ss;
	}

	internal static CameraCalibration_c ConvertValue(CameraCalibration s, ref CameraCalibration_c ss) {
		Geom.GeomInterface.Geom_CameraCalibration_init(ref ss);
		ss.radial1 = (System.Double)s.radial1;
		ss.radial2 = (System.Double)s.radial2;
		ss.radial3 = (System.Double)s.radial3;
		ss.tangential1 = (System.Double)s.tangential1;
		ss.tangential2 = (System.Double)s.tangential2;
		ss.focalX = (System.Double)s.focalX;
		ss.focalY = (System.Double)s.focalY;
		ss.centerX = (System.Double)s.centerX;
		ss.centerY = (System.Double)s.centerY;
		ss.skew = (System.Double)s.skew;
		return ss;
	}

	internal static Vector3List ConvertValue(ref Vector3List_c s) {
		Vector3List list = new Vector3List((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<Vector3>(s.ptr, (int)s.size);
		return list;
	}

	internal static Vector3List_c ConvertValue(Vector3List s, ref Vector3List_c list) {
		Geom.GeomInterface.Geom_Vector3List_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Point3_c elt = new Point3_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Point3_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Vector4List ConvertValue(ref Vector4List_c s) {
		Vector4List list = new Vector4List((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<Vector4>(s.ptr, (int)s.size);
		return list;
	}

	internal static Vector4List_c ConvertValue(Vector4List s, ref Vector4List_c list) {
		Geom.GeomInterface.Geom_Vector4List_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Point4_c elt = new Point4_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Point4_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static DistanceList ConvertValue(ref DistanceList_c s) {
		DistanceList list = new DistanceList((int)s.size);
		if (s.size > 0)
			Marshal.Copy(s.ptr, list.list, 0, (int)s.size);
		return list;
	}

	internal static DistanceList_c ConvertValue(DistanceList s, ref DistanceList_c list) {
		Geom.GeomInterface.Geom_DistanceList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size > 0)
			Marshal.Copy(s.list, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static FromLookAtMatrixReturn ConvertValue(ref FromLookAtMatrixReturn_c s) {
		FromLookAtMatrixReturn ss = new FromLookAtMatrixReturn();
		ss.position = ConvertValue(ref s.position);
		ss.up = ConvertValue(ref s.up);
		ss.target = ConvertValue(ref s.target);
		return ss;
	}

	internal static FromLookAtMatrixReturn_c ConvertValue(FromLookAtMatrixReturn s, ref FromLookAtMatrixReturn_c ss) {
		ConvertValue(s.position, ref ss.position);
		ConvertValue(s.up, ref ss.up);
		ConvertValue(s.target, ref ss.target);
		return ss;
	}

		#endregion

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Geom_getLastError();

		public static string GetLastError()
		{
			return ConvertValue(Geom_getLastError());
		}

		#region 

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Geom_applyTransform(IntPtr _pxz_session_, System.UInt32 entity, Matrix4_c matrix);
		/// <summary>
		/// Apply a transformation matrix to a geometrical entity
		/// </summary>
		/// <param name="entity">The geometric entity</param>
		/// <param name="matrix">The transformation matrix</param>
		public void ApplyTransform(System.UInt32 entity, Matrix4 matrix) {
			var matrix_c = new Geom.Matrix4_c();
			ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
			Geom_applyTransform(api.Session, entity, matrix_c);
			Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
			System.String err = ConvertValue(Geom_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Geom_configureFunctionLogger(IntPtr _pxz_session_, string functionName, System.Byte enableFunction, System.Byte enableParameters, System.Byte enableExecutionTime);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="functionName"></param>
		/// <param name="enableFunction"></param>
		/// <param name="enableParameters"></param>
		/// <param name="enableExecutionTime"></param>
		public void ConfigureFunctionLogger(System.String functionName, System.Boolean enableFunction, System.Boolean enableParameters, System.Boolean enableExecutionTime) {
			Geom_configureFunctionLogger(api.Session, functionName, Convert.ToByte(enableFunction), Convert.ToByte(enableParameters), Convert.ToByte(enableExecutionTime));
			System.String err = ConvertValue(Geom_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Geom_drawDebug(IntPtr _pxz_session_, System.UInt32 entity);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="entity">The geometric entity to draw in debug mode</param>
		public void DrawDebug(System.UInt32 entity) {
			Geom_drawDebug(api.Session, entity);
			System.String err = ConvertValue(Geom_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern AABB_c Geom_getEntityAABB(IntPtr _pxz_session_, System.UInt32 entity);
		/// <summary>
		/// Retrieve the Axis-Aligned Bounded Box of a geometric entity
		/// </summary>
		/// <param name="entity">The geometric entity</param>
		public AABB GetEntityAABB(System.UInt32 entity) {
			var ret = Geom_getEntityAABB(api.Session, entity);
			System.String err = ConvertValue(Geom_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Geom.GeomInterface.Geom_AABB_free(ref ret);
			return convRet;
		}

		#endregion

		#region Math

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Matrix4_c Geom_changeOfBasisMatrix(IntPtr _pxz_session_, Point3_c origin, Point3_c x, Point3_c y, Point3_c z);
		/// <summary>
		/// Construct a Change of Basis Matrix (e.g multiplying the point [0,0,0] will result to the point origin)
		/// </summary>
		/// <param name="origin">Origin of the new basis</param>
		/// <param name="x">X axis of the new basis</param>
		/// <param name="y">Y axis of the new basis</param>
		/// <param name="z">Z axis of the new basis</param>
		public Matrix4 ChangeOfBasisMatrix(Point3 origin, Point3 x, Point3 y, Point3 z) {
			var origin_c = new Geom.Point3_c();
			ConvertValue((Geom.Point3)origin, ref origin_c);
			var x_c = new Geom.Point3_c();
			ConvertValue((Geom.Point3)x, ref x_c);
			var y_c = new Geom.Point3_c();
			ConvertValue((Geom.Point3)y, ref y_c);
			var z_c = new Geom.Point3_c();
			ConvertValue((Geom.Point3)z, ref z_c);
			var ret = Geom_changeOfBasisMatrix(api.Session, origin_c, x_c, y_c, z_c);
			Geom.GeomInterface.Geom_Point3_free(ref origin_c);
			Geom.GeomInterface.Geom_Point3_free(ref x_c);
			Geom.GeomInterface.Geom_Point3_free(ref y_c);
			Geom.GeomInterface.Geom_Point3_free(ref z_c);
			System.String err = ConvertValue(Geom_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Geom.GeomInterface.Geom_Matrix4_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Matrix4_c Geom_fromAffine(IntPtr _pxz_session_, Affine_c affine);
		/// <summary>
		/// Create a Matrix from an Affine
		/// </summary>
		/// <param name="affine">The affine</param>
		public Matrix4 FromAffine(Affine affine) {
			var affine_c = new Geom.Affine_c();
			ConvertValue((Geom.Affine)affine, ref affine_c);
			var ret = Geom_fromAffine(api.Session, affine_c);
			Geom.GeomInterface.Geom_Affine_free(ref affine_c);
			System.String err = ConvertValue(Geom_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Geom.GeomInterface.Geom_Matrix4_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern FromLookAtMatrixReturn_c Geom_fromLookAtMatrix(IntPtr _pxz_session_, Matrix4_c matrix, System.Double distanceFromTarget);
		/// <summary>
		/// Get camera position, up and target vectors
		/// </summary>
		/// <param name="matrix">The created Matrix</param>
		/// <param name="distanceFromTarget"></param>
		public Geom.FromLookAtMatrixReturn FromLookAtMatrix(Matrix4 matrix, System.Double distanceFromTarget = 1) {
			var matrix_c = new Geom.Matrix4_c();
			ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
			var ret = Geom_fromLookAtMatrix(api.Session, matrix_c, distanceFromTarget);
			Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
			System.String err = ConvertValue(Geom_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			Geom.FromLookAtMatrixReturn retStruct = new Geom.FromLookAtMatrixReturn();
			retStruct.position = ConvertValue(ref ret.position);
			Geom.GeomInterface.Geom_Point3_free(ref ret.position);
			retStruct.up = ConvertValue(ref ret.up);
			Geom.GeomInterface.Geom_Point3_free(ref ret.up);
			retStruct.target = ConvertValue(ref ret.target);
			Geom.GeomInterface.Geom_Point3_free(ref ret.target);
			return retStruct;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Matrix4_c Geom_fromOriginNormal(IntPtr _pxz_session_, Point3_c origin, Point3_c normal);
		/// <summary>
		/// Create a Matrix from an origin and a normal vector
		/// </summary>
		/// <param name="origin">The origin point</param>
		/// <param name="normal">The normal vector</param>
		public Matrix4 FromOriginNormal(Point3 origin, Point3 normal) {
			var origin_c = new Geom.Point3_c();
			ConvertValue((Geom.Point3)origin, ref origin_c);
			var normal_c = new Geom.Point3_c();
			ConvertValue((Geom.Point3)normal, ref normal_c);
			var ret = Geom_fromOriginNormal(api.Session, origin_c, normal_c);
			Geom.GeomInterface.Geom_Point3_free(ref origin_c);
			Geom.GeomInterface.Geom_Point3_free(ref normal_c);
			System.String err = ConvertValue(Geom_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Geom.GeomInterface.Geom_Matrix4_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Matrix4_c Geom_fromTRS(IntPtr _pxz_session_, Point3_c T, Point3_c R, Point3_c S);
		/// <summary>
		/// Create a Matrix from translation, rotation and scaling vectors
		/// </summary>
		/// <param name="T">The translation vector</param>
		/// <param name="R">The rotations vector</param>
		/// <param name="S">The scaling vector</param>
		public Matrix4 FromTRS(Point3 T, Point3 R, Point3 S) {
			var T_c = new Geom.Point3_c();
			ConvertValue((Geom.Point3)T, ref T_c);
			var R_c = new Geom.Point3_c();
			ConvertValue((Geom.Point3)R, ref R_c);
			var S_c = new Geom.Point3_c();
			ConvertValue((Geom.Point3)S, ref S_c);
			var ret = Geom_fromTRS(api.Session, T_c, R_c, S_c);
			Geom.GeomInterface.Geom_Point3_free(ref T_c);
			Geom.GeomInterface.Geom_Point3_free(ref R_c);
			Geom.GeomInterface.Geom_Point3_free(ref S_c);
			System.String err = ConvertValue(Geom_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Geom.GeomInterface.Geom_Matrix4_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Matrix4_c Geom_invertMatrix(IntPtr _pxz_session_, Matrix4_c matrix);
		/// <summary>
		/// Invert a matrix
		/// </summary>
		/// <param name="matrix">The matrix to invert</param>
		public Matrix4 InvertMatrix(Matrix4 matrix) {
			var matrix_c = new Geom.Matrix4_c();
			ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
			var ret = Geom_invertMatrix(api.Session, matrix_c);
			Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
			System.String err = ConvertValue(Geom_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Geom.GeomInterface.Geom_Matrix4_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Matrix4_c Geom_lookAtMatrix(IntPtr _pxz_session_, Point3_c position, Point3_c up, Point3_c target);
		/// <summary>
		/// Create a matrix from a camera position, up and target
		/// </summary>
		/// <param name="position">The camera position</param>
		/// <param name="up">The up vector</param>
		/// <param name="target">The target position</param>
		public Matrix4 LookAtMatrix(Point3 position, Point3 up, Point3 target) {
			var position_c = new Geom.Point3_c();
			ConvertValue((Geom.Point3)position, ref position_c);
			var up_c = new Geom.Point3_c();
			ConvertValue((Geom.Point3)up, ref up_c);
			var target_c = new Geom.Point3_c();
			ConvertValue((Geom.Point3)target, ref target_c);
			var ret = Geom_lookAtMatrix(api.Session, position_c, up_c, target_c);
			Geom.GeomInterface.Geom_Point3_free(ref position_c);
			Geom.GeomInterface.Geom_Point3_free(ref up_c);
			Geom.GeomInterface.Geom_Point3_free(ref target_c);
			System.String err = ConvertValue(Geom_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Geom.GeomInterface.Geom_Matrix4_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Matrix4_c Geom_multiplyMatrices(IntPtr _pxz_session_, Matrix4_c left, Matrix4_c right);
		/// <summary>
		/// Multiply two matrices, returns left*right
		/// </summary>
		/// <param name="left">Left side matrix</param>
		/// <param name="right">Right side matrix</param>
		public Matrix4 MultiplyMatrices(Matrix4 left, Matrix4 right) {
			var left_c = new Geom.Matrix4_c();
			ConvertValue((Geom.Matrix4)left, ref left_c);
			var right_c = new Geom.Matrix4_c();
			ConvertValue((Geom.Matrix4)right, ref right_c);
			var ret = Geom_multiplyMatrices(api.Session, left_c, right_c);
			Geom.GeomInterface.Geom_Matrix4_free(ref left_c);
			Geom.GeomInterface.Geom_Matrix4_free(ref right_c);
			System.String err = ConvertValue(Geom_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Geom.GeomInterface.Geom_Matrix4_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Point3_c Geom_multiplyMatrixPoint(IntPtr _pxz_session_, Matrix4_c matrix, Point3_c point);
		/// <summary>
		/// Multiply a point by a matrix (i.e apply the matrix to a point)
		/// </summary>
		/// <param name="matrix">The matrix to apply</param>
		/// <param name="point">The point to multiply</param>
		public Point3 MultiplyMatrixPoint(Matrix4 matrix, Point3 point) {
			var matrix_c = new Geom.Matrix4_c();
			ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
			var point_c = new Geom.Point3_c();
			ConvertValue((Geom.Point3)point, ref point_c);
			var ret = Geom_multiplyMatrixPoint(api.Session, matrix_c, point_c);
			Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
			Geom.GeomInterface.Geom_Point3_free(ref point_c);
			System.String err = ConvertValue(Geom_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Geom.GeomInterface.Geom_Point3_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Point3_c Geom_multiplyMatrixVector(IntPtr _pxz_session_, Matrix4_c matrix, Point3_c vector);
		/// <summary>
		/// Multiply a vector by a matrix (i.e apply the matrix to a vector)
		/// </summary>
		/// <param name="matrix">The matrix to apply</param>
		/// <param name="vector">The vector to multiply</param>
		public Point3 MultiplyMatrixVector(Matrix4 matrix, Point3 vector) {
			var matrix_c = new Geom.Matrix4_c();
			ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
			var vector_c = new Geom.Point3_c();
			ConvertValue((Geom.Point3)vector, ref vector_c);
			var ret = Geom_multiplyMatrixVector(api.Session, matrix_c, vector_c);
			Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
			Geom.GeomInterface.Geom_Point3_free(ref vector_c);
			System.String err = ConvertValue(Geom_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Geom.GeomInterface.Geom_Point3_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Matrix4_c Geom_orthographicMatrix(IntPtr _pxz_session_, System.Double width3D, System.Double height3D, System.Double nearClipDistance, System.Double farClipDistance);
		/// <summary>
		/// Create an orthographic matrix from a 3D width, a 3D height, a near, and a far clipping distance
		/// </summary>
		/// <param name="width3D">The 3D width to consider</param>
		/// <param name="height3D">The 3D height to consider</param>
		/// <param name="nearClipDistance">The near clipping distance</param>
		/// <param name="farClipDistance">The far clipping distance</param>
		public Matrix4 OrthographicMatrix(System.Double width3D, System.Double height3D, System.Double nearClipDistance, System.Double farClipDistance) {
			var ret = Geom_orthographicMatrix(api.Session, width3D, height3D, nearClipDistance, farClipDistance);
			System.String err = ConvertValue(Geom_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Geom.GeomInterface.Geom_Matrix4_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Matrix4_c Geom_perspectiveMatrix(IntPtr _pxz_session_, System.Double fovX, System.Double aspectRatio, System.Double nearClipDistance, System.Double farClipDistance);
		/// <summary>
		/// Create a perspective matrix from a fovX, an aspect ratio, a near, and a far clipping distance
		/// </summary>
		/// <param name="fovX">The field of view on the x axis</param>
		/// <param name="aspectRatio">The aspect ratio foxX/fovY</param>
		/// <param name="nearClipDistance">The near clipping distance</param>
		/// <param name="farClipDistance">The far clipping distance</param>
		public Matrix4 PerspectiveMatrix(System.Double fovX, System.Double aspectRatio, System.Double nearClipDistance, System.Double farClipDistance) {
			var ret = Geom_perspectiveMatrix(api.Session, fovX, aspectRatio, nearClipDistance, farClipDistance);
			System.String err = ConvertValue(Geom_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Geom.GeomInterface.Geom_Matrix4_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Vector3List_c Geom_toTRS(IntPtr _pxz_session_, Matrix4_c matrix);
		/// <summary>
		/// Decompose a Matrix into translation, rotation and scaling vectors
		/// </summary>
		/// <param name="matrix">The Matrix to be decomposed</param>
		public Vector3List ToTRS(Matrix4 matrix) {
			var matrix_c = new Geom.Matrix4_c();
			ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
			var ret = Geom_toTRS(api.Session, matrix_c);
			Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
			System.String err = ConvertValue(Geom_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Geom.GeomInterface.Geom_Vector3List_free(ref ret);
			return convRet;
		}

		#endregion

		private PiXYZAPI api;
		internal GeomInterface(PiXYZAPI api)
		{
			this.api = api;
		}

	}
}
