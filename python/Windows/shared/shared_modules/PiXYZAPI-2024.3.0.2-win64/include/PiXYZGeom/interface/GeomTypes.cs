#pragma warning disable CA2101

using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Pixyz.Geom {

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Point3
	{
		public Point3(Point3 o) {
			this.x = o.x;
			this.y = o.y;
			this.z = o.z;
		}
		public System.Double x;
		public System.Double y;
		public System.Double z;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Point3_c
	{
		public System.Double x;
		public System.Double y;
		public System.Double z;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class AABB
	{
		public AABB() {}
		public AABB(AABB o) {
			this.low = o.low;
			this.high = o.high;
		}
		public Point3 low;
		public Point3 high;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct AABB_c
	{
		public Point3_c low;
		public Point3_c high;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Point2
	{
		public Point2(Point2 o) {
			this.x = o.x;
			this.y = o.y;
		}
		public System.Double x;
		public System.Double y;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Point2_c
	{
		public System.Double x;
		public System.Double y;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class AABR
	{
		public AABR() {}
		public AABR(AABR o) {
			this.low = o.low;
			this.high = o.high;
		}
		public Point2 low;
		public Point2 high;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct AABR_c
	{
		public Point2_c low;
		public Point2_c high;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Vector3 {
		public Vector3(Point3 value) { this._base = value; }
		public static implicit operator Point3(Vector3 v) { return v._base; }
		public static implicit operator Vector3(Point3 v) { return new Vector3(v); }
		public Point3 _base;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Affine
	{
		public Affine() {}
		public Affine(Affine o) {
			this.origin = o.origin;
			this.xAxis = o.xAxis;
			this.yAxis = o.yAxis;
			this.zAxis = o.zAxis;
		}
		public Point3 origin;
		public Point3 xAxis;
		public Point3 yAxis;
		public Point3 zAxis;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Affine_c
	{
		public Point3_c origin;
		public Point3_c xAxis;
		public Point3_c yAxis;
		public Point3_c zAxis;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Array3
	{
		public Double[] tab = new Double[3];
		public Array3() {}
		public Array3(Double[] t) { tab = t; }
		public static implicit operator Double[](Array3 o) { return o.tab; }
		public Double this[int index] {
			get{ return tab[index]; }
			set{ tab[index] = value; }
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Array3_c
	{
		public IntPtr tab;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Array4
	{
		public Double[] tab = new Double[4];
		public Array4() {}
		public Array4(Double[] t) { tab = t; }
		public static implicit operator Double[](Array4 o) { return o.tab; }
		public Double this[int index] {
			get{ return tab[index]; }
			set{ tab[index] = value; }
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Array4_c
	{
		public IntPtr tab;
	}

	public enum Axis
	{
		X = 0,
		Y = 1,
		Z = 2,
	}

	public enum AxisPlane
	{
		YZ = 0,
		ZX = 1,
		XY = 2,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct CameraCalibration
	{
		public CameraCalibration(CameraCalibration o) {
			this.radial1 = o.radial1;
			this.radial2 = o.radial2;
			this.radial3 = o.radial3;
			this.tangential1 = o.tangential1;
			this.tangential2 = o.tangential2;
			this.focalX = o.focalX;
			this.focalY = o.focalY;
			this.centerX = o.centerX;
			this.centerY = o.centerY;
			this.skew = o.skew;
		}
		public System.Double radial1;
		public System.Double radial2;
		public System.Double radial3;
		public System.Double tangential1;
		public System.Double tangential2;
		public System.Double focalX;
		public System.Double focalY;
		public System.Double centerX;
		public System.Double centerY;
		public System.Double skew;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct CameraCalibration_c
	{
		public System.Double radial1;
		public System.Double radial2;
		public System.Double radial3;
		public System.Double tangential1;
		public System.Double tangential2;
		public System.Double focalX;
		public System.Double focalY;
		public System.Double centerX;
		public System.Double centerY;
		public System.Double skew;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Curvatures
	{
		public Curvatures() {}
		public Curvatures(Curvatures o) {
			this.k1 = o.k1;
			this.k2 = o.k2;
			this.v1 = o.v1;
			this.v2 = o.v2;
		}
		public System.Double k1;
		public System.Double k2;
		public Point3 v1;
		public Point3 v2;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Curvatures_c
	{
		public System.Double k1;
		public System.Double k2;
		public Point3_c v1;
		public Point3_c v2;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class CurvaturesList {
		public Geom.Curvatures[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public CurvaturesList(Geom.Curvatures[] tab) { list = tab; }
		public static implicit operator Geom.Curvatures[](CurvaturesList o) { return o.list; }
		public Geom.Curvatures this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public CurvaturesList(int size) { list = new Geom.Curvatures[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct CurvaturesList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class DistanceList {
		public System.Double[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public DistanceList() {}
		public DistanceList(System.Double[] tab) { list = tab; }
		public static implicit operator System.Double[](DistanceList o) { return o.list; }
		public System.Double this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public DistanceList(int size) { list = new System.Double[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct DistanceList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ExtendedBox
	{
		public ExtendedBox() {}
		public ExtendedBox(ExtendedBox o) {
			this.position = o.position;
			this.extentX = o.extentX;
			this.extentY = o.extentY;
			this.extentZ = o.extentZ;
		}
		public Point3 position;
		public System.Double extentX;
		public System.Double extentY;
		public System.Double extentZ;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ExtendedBox_c
	{
		public Point3_c position;
		public System.Double extentX;
		public System.Double extentY;
		public System.Double extentZ;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class OBB
	{
		public OBB() {}
		public OBB(OBB o) {
			this.corner = o.corner;
			this.xAxis = o.xAxis;
			this.yAxis = o.yAxis;
			this.zAxis = o.zAxis;
		}
		public Point3 corner;
		public Point3 xAxis;
		public Point3 yAxis;
		public Point3 zAxis;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct OBB_c
	{
		public Point3_c corner;
		public Point3_c xAxis;
		public Point3_c yAxis;
		public Point3_c zAxis;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct MBB {
		public MBB(OBB value) { this._base = value; }
		public static implicit operator OBB(MBB v) { return v._base; }
		public static implicit operator MBB(OBB v) { return new MBB(v); }
		public OBB _base;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Matrix3
	{
		public Array3[] tab = new Array3[3];
		public Matrix3() {
			for (int i = 0; i < 3; i++) {
				tab[i] = new Array3();
			}
		}
		public Matrix3(Array3[] t) { tab = t; }
		public static implicit operator Array3[](Matrix3 o) { return o.tab; }
		public Array3 this[int index] {
			get{ return tab[index]; }
			set{ tab[index] = value; }
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Matrix3_c
	{
		public IntPtr tab;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Matrix4
	{
		public Array4[] tab = new Array4[4];
		public Matrix4() {
			for (int i = 0; i < 4; i++) {
				tab[i] = new Array4();
			}
		}
		public Matrix4(Array4[] t) { tab = t; }
		public static implicit operator Array4[](Matrix4 o) { return o.tab; }
		public Array4 this[int index] {
			get{ return tab[index]; }
			set{ tab[index] = value; }
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Matrix4_c
	{
		public IntPtr tab;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Matrix4List {
		public Geom.Matrix4[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public Matrix4List(Geom.Matrix4[] tab) { list = tab; }
		public static implicit operator Geom.Matrix4[](Matrix4List o) { return o.list; }
		public Geom.Matrix4 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public Matrix4List(int size) { list = new Geom.Matrix4[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Matrix4List_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Matrix4ListList {
		public Geom.Matrix4List[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public Matrix4ListList(Geom.Matrix4List[] tab) { list = tab; }
		public static implicit operator Geom.Matrix4List[](Matrix4ListList o) { return o.list; }
		public Geom.Matrix4List this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public Matrix4ListList(int size) { list = new Geom.Matrix4List[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Matrix4ListList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class OrientationList {
		public System.Boolean[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public OrientationList() {}
		public OrientationList(System.Boolean[] tab) { list = tab; }
		public static implicit operator System.Boolean[](OrientationList o) { return o.list; }
		public System.Boolean this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public OrientationList(int size) { list = new System.Boolean[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct OrientationList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Point2List {
		public Geom.Point2[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public Point2List(Geom.Point2[] tab) { list = tab; }
		public static implicit operator Geom.Point2[](Point2List o) { return o.list; }
		public Geom.Point2 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public Point2List(int size) { list = new Geom.Point2[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Point2List_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Point2ListList {
		public Geom.Point2List[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public Point2ListList(Geom.Point2List[] tab) { list = tab; }
		public static implicit operator Geom.Point2List[](Point2ListList o) { return o.list; }
		public Geom.Point2List this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public Point2ListList(int size) { list = new Geom.Point2List[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Point2ListList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Point3List {
		public Geom.Point3[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public Point3List(Geom.Point3[] tab) { list = tab; }
		public static implicit operator Geom.Point3[](Point3List o) { return o.list; }
		public Geom.Point3 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public Point3List(int size) { list = new Geom.Point3[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Point3List_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Point3ListList {
		public Geom.Point3List[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public Point3ListList(Geom.Point3List[] tab) { list = tab; }
		public static implicit operator Geom.Point3List[](Point3ListList o) { return o.list; }
		public Geom.Point3List this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public Point3ListList(int size) { list = new Geom.Point3List[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Point3ListList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Point4
	{
		public Point4(Point4 o) {
			this.x = o.x;
			this.y = o.y;
			this.z = o.z;
			this.w = o.w;
		}
		public System.Double x;
		public System.Double y;
		public System.Double z;
		public System.Double w;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Point4_c
	{
		public System.Double x;
		public System.Double y;
		public System.Double z;
		public System.Double w;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Point4List {
		public Geom.Point4[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public Point4List(Geom.Point4[] tab) { list = tab; }
		public static implicit operator Geom.Point4[](Point4List o) { return o.list; }
		public Geom.Point4 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public Point4List(int size) { list = new Geom.Point4[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Point4List_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Ray
	{
		public Ray() {}
		public Ray(Ray o) {
			this.origin = o.origin;
			this.direction = o.direction;
		}
		public Point3 origin;
		public Point3 direction;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Ray_c
	{
		public Point3_c origin;
		public Point3_c direction;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Vector2 {
		public Vector2(Point2 value) { this._base = value; }
		public static implicit operator Point2(Vector2 v) { return v._base; }
		public static implicit operator Vector2(Point2 v) { return new Vector2(v); }
		public Point2 _base;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Vector3List {
		public Geom.Vector3[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public Vector3List(Geom.Vector3[] tab) { list = tab; }
		public static implicit operator Geom.Vector3[](Vector3List o) { return o.list; }
		public Geom.Vector3 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public Vector3List(int size) { list = new Geom.Vector3[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Vector3List_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Vector4 {
		public Vector4(Point4 value) { this._base = value; }
		public static implicit operator Point4(Vector4 v) { return v._base; }
		public static implicit operator Vector4(Point4 v) { return new Vector4(v); }
		public Point4 _base;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Vector4I
	{
		public Vector4I(Vector4I o) {
			this.x = o.x;
			this.y = o.y;
			this.z = o.z;
			this.w = o.w;
		}
		public System.Int32 x;
		public System.Int32 y;
		public System.Int32 z;
		public System.Int32 w;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Vector4I_c
	{
		public Int32 x;
		public Int32 y;
		public Int32 z;
		public Int32 w;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Vector4IList {
		public Geom.Vector4I[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public Vector4IList(Geom.Vector4I[] tab) { list = tab; }
		public static implicit operator Geom.Vector4I[](Vector4IList o) { return o.list; }
		public Geom.Vector4I this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public Vector4IList(int size) { list = new Geom.Vector4I[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Vector4IList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Vector4List {
		public Geom.Vector4[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public Vector4List(Geom.Vector4[] tab) { list = tab; }
		public static implicit operator Geom.Vector4[](Vector4List o) { return o.list; }
		public Geom.Vector4 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public Vector4List(int size) { list = new Geom.Vector4[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Vector4List_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class FromLookAtMatrixReturn
	{
		public FromLookAtMatrixReturn() {}
		public FromLookAtMatrixReturn(FromLookAtMatrixReturn o) {
			this.position = o.position;
			this.up = o.up;
			this.target = o.target;
		}
		public Point3 position;
		public Point3 up;
		public Point3 target;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct FromLookAtMatrixReturn_c
	{
		public Point3_c position;
		public Point3_c up;
		public Point3_c target;
	}

}
