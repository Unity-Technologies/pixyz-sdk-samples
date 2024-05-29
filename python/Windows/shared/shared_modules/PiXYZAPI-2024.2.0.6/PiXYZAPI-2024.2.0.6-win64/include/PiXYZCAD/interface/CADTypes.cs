#pragma warning disable CA2101

using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Pixyz.CAD {

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class BodyList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public BodyList() {}
		public BodyList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](BodyList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public BodyList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct BodyList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Bounds1D
	{
		public Bounds1D(Bounds1D o) {
			this.min = o.min;
			this.max = o.max;
		}
		public System.Double min;
		public System.Double max;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Bounds1D_c
	{
		public System.Double min;
		public System.Double max;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Bounds2D
	{
		public Bounds2D() {}
		public Bounds2D(Bounds2D o) {
			this.u = o.u;
			this.v = o.v;
		}
		public Bounds1D u;
		public Bounds1D v;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Bounds2D_c
	{
		public Bounds1D_c u;
		public Bounds1D_c v;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ClosedShellList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public ClosedShellList() {}
		public ClosedShellList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](ClosedShellList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public ClosedShellList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ClosedShellList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class CoEdgeList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public CoEdgeList() {}
		public CoEdgeList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](CoEdgeList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public CoEdgeList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct CoEdgeList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class CurveList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public CurveList() {}
		public CurveList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](CurveList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public CurveList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct CurveList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class EdgeList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public EdgeList() {}
		public EdgeList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](EdgeList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public EdgeList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct EdgeList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class EdgeListList {
		public CAD.EdgeList[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public EdgeListList(CAD.EdgeList[] tab) { list = tab; }
		public static implicit operator CAD.EdgeList[](EdgeListList o) { return o.list; }
		public CAD.EdgeList this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public EdgeListList(int size) { list = new CAD.EdgeList[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct EdgeListList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class EdgeStyle
	{
		public EdgeStyle() {}
		public EdgeStyle(EdgeStyle o) {
			this.color = o.color;
			this.width = o.width;
			this.pattern = o.pattern;
		}
		public Core.ColorAlpha color;
		public System.Double width;
		public System.Int16 pattern;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct EdgeStyle_c
	{
		public Core.ColorAlpha_c color;
		public System.Double width;
		public System.Int16 pattern;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class FaceList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public FaceList() {}
		public FaceList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](FaceList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public FaceList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct FaceList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	public enum LegoType
	{
		Rectangle = 0,
		CornerLeft = 1,
		CornerRight = 2,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class LegoBrickDefinition
	{
		public LegoBrickDefinition() {}
		public LegoBrickDefinition(LegoBrickDefinition o) {
			this.legoType = o.legoType;
			this.length = o.length;
			this.width = o.width;
			this.fullHeight = o.fullHeight;
		}
		public LegoType legoType;
		public System.Int32 length;
		public System.Int32 width;
		public System.Boolean fullHeight;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct LegoBrickDefinition_c
	{
		public Int32 legoType;
		public Int32 length;
		public Int32 width;
		public System.Byte fullHeight;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class LegoBrickDefinitionList {
		public CAD.LegoBrickDefinition[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public LegoBrickDefinitionList(CAD.LegoBrickDefinition[] tab) { list = tab; }
		public static implicit operator CAD.LegoBrickDefinition[](LegoBrickDefinitionList o) { return o.list; }
		public CAD.LegoBrickDefinition this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public LegoBrickDefinitionList(int size) { list = new CAD.LegoBrickDefinition[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct LegoBrickDefinitionList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class LoopList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public LoopList() {}
		public LoopList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](LoopList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public LoopList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct LoopList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ModelList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public ModelList() {}
		public ModelList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](ModelList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public ModelList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ModelList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class OpenShellList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public OpenShellList() {}
		public OpenShellList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](OpenShellList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public OpenShellList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct OpenShellList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct OrientedEdge
	{
		public OrientedEdge(OrientedEdge o) {
			this.edge = o.edge;
			this.orientation = o.orientation;
		}
		public System.UInt32 edge;
		public System.Boolean orientation;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct OrientedEdge_c
	{
		public System.UInt32 edge;
		public System.Byte orientation;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class OrientedEdgeList {
		public CAD.OrientedEdge[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public OrientedEdgeList(CAD.OrientedEdge[] tab) { list = tab; }
		public static implicit operator CAD.OrientedEdge[](OrientedEdgeList o) { return o.list; }
		public CAD.OrientedEdge this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public OrientedEdgeList(int size) { list = new CAD.OrientedEdge[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct OrientedEdgeList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct OrientedFace
	{
		public OrientedFace(OrientedFace o) {
			this.face = o.face;
			this.orientation = o.orientation;
		}
		public System.UInt32 face;
		public System.Boolean orientation;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct OrientedFace_c
	{
		public System.UInt32 face;
		public System.Byte orientation;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class OrientedFaceList {
		public CAD.OrientedFace[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public OrientedFaceList(CAD.OrientedFace[] tab) { list = tab; }
		public static implicit operator CAD.OrientedFace[](OrientedFaceList o) { return o.list; }
		public CAD.OrientedFace this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public OrientedFaceList(int size) { list = new CAD.OrientedFace[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct OrientedFaceList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class SplittedEdge
	{
		public SplittedEdge() {}
		public SplittedEdge(SplittedEdge o) {
			this.oldEdge = o.oldEdge;
			this.newEdges = o.newEdges;
		}
		public System.UInt32 oldEdge;
		public EdgeList newEdges;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct SplittedEdge_c
	{
		public System.UInt32 oldEdge;
		public EdgeList_c newEdges;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class SplittedEdgeList {
		public CAD.SplittedEdge[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public SplittedEdgeList(CAD.SplittedEdge[] tab) { list = tab; }
		public static implicit operator CAD.SplittedEdge[](SplittedEdgeList o) { return o.list; }
		public CAD.SplittedEdge this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public SplittedEdgeList(int size) { list = new CAD.SplittedEdge[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct SplittedEdgeList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	public enum TorusType
	{
		Donut = 0,
		Vortex = 1,
		Apple = 2,
		Lemon = 3,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class VertexList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public VertexList() {}
		public VertexList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](VertexList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public VertexList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct VertexList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class BuildFacesReturn
	{
		public BuildFacesReturn() {}
		public BuildFacesReturn(BuildFacesReturn o) {
			this.faces = o.faces;
			this.splittingInfo = o.splittingInfo;
		}
		public FaceList faces;
		public SplittedEdgeList splittingInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct BuildFacesReturn_c
	{
		public FaceList_c faces;
		public SplittedEdgeList_c splittingInfo;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class EvalOnCurveReturn
	{
		public EvalOnCurveReturn() {}
		public EvalOnCurveReturn(EvalOnCurveReturn o) {
			this.d0 = o.d0;
			this.du = o.du;
			this.d2u = o.d2u;
		}
		public Geom.Point3 d0;
		public Geom.Point3 du;
		public Geom.Point3 d2u;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct EvalOnCurveReturn_c
	{
		public Geom.Point3_c d0;
		public Geom.Point3_c du;
		public Geom.Point3_c d2u;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class EvalOnSurfaceReturn
	{
		public EvalOnSurfaceReturn() {}
		public EvalOnSurfaceReturn(EvalOnSurfaceReturn o) {
			this.d0 = o.d0;
			this.du = o.du;
			this.dv = o.dv;
			this.d2u = o.d2u;
			this.d2v = o.d2v;
			this.duv = o.duv;
		}
		public Geom.Point3 d0;
		public Geom.Point3 du;
		public Geom.Point3 dv;
		public Geom.Point3 d2u;
		public Geom.Point3 d2v;
		public Geom.Point3 duv;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct EvalOnSurfaceReturn_c
	{
		public Geom.Point3_c d0;
		public Geom.Point3_c du;
		public Geom.Point3_c dv;
		public Geom.Point3_c d2u;
		public Geom.Point3_c d2v;
		public Geom.Point3_c duv;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetCircleCurveDefinitionReturn
	{
		public GetCircleCurveDefinitionReturn() {}
		public GetCircleCurveDefinitionReturn(GetCircleCurveDefinitionReturn o) {
			this.radius = o.radius;
			this.matrix = o.matrix;
		}
		public System.Double radius;
		public Geom.Matrix4 matrix;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetCircleCurveDefinitionReturn_c
	{
		public System.Double radius;
		public Geom.Matrix4_c matrix;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct GetCoEdgeDefinitionReturn
	{
		public GetCoEdgeDefinitionReturn(GetCoEdgeDefinitionReturn o) {
			this.edge = o.edge;
			this.edgeOrientation = o.edgeOrientation;
			this.loop = o.loop;
			this.surface = o.surface;
			this.parametricCurve = o.parametricCurve;
		}
		public System.UInt32 edge;
		public System.Boolean edgeOrientation;
		public System.UInt32 loop;
		public System.UInt32 surface;
		public System.UInt32 parametricCurve;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetCoEdgeDefinitionReturn_c
	{
		public System.UInt32 edge;
		public System.Byte edgeOrientation;
		public System.UInt32 loop;
		public System.UInt32 surface;
		public System.UInt32 parametricCurve;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetCompositeCurveDefinitionReturn
	{
		public GetCompositeCurveDefinitionReturn() {}
		public GetCompositeCurveDefinitionReturn(GetCompositeCurveDefinitionReturn o) {
			this.curves = o.curves;
			this.parameters = o.parameters;
		}
		public CurveList curves;
		public Core.DoubleList parameters;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetCompositeCurveDefinitionReturn_c
	{
		public CurveList_c curves;
		public Core.DoubleList_c parameters;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetConeSurfaceDefinitionReturn
	{
		public GetConeSurfaceDefinitionReturn() {}
		public GetConeSurfaceDefinitionReturn(GetConeSurfaceDefinitionReturn o) {
			this.radius = o.radius;
			this.semiAngle = o.semiAngle;
			this.matrix = o.matrix;
		}
		public System.Double radius;
		public System.Double semiAngle;
		public Geom.Matrix4 matrix;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetConeSurfaceDefinitionReturn_c
	{
		public System.Double radius;
		public System.Double semiAngle;
		public Geom.Matrix4_c matrix;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct GetCurveExtrusionSurfaceDefinitionReturn
	{
		public GetCurveExtrusionSurfaceDefinitionReturn(GetCurveExtrusionSurfaceDefinitionReturn o) {
			this.generatrixCurve = o.generatrixCurve;
			this.directrixCruve = o.directrixCruve;
			this.surfaceReference = o.surfaceReference;
		}
		public System.UInt32 generatrixCurve;
		public System.UInt32 directrixCruve;
		public System.UInt32 surfaceReference;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetCurveExtrusionSurfaceDefinitionReturn_c
	{
		public System.UInt32 generatrixCurve;
		public System.UInt32 directrixCruve;
		public System.UInt32 surfaceReference;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetCylinderSurfaceDefinitionReturn
	{
		public GetCylinderSurfaceDefinitionReturn() {}
		public GetCylinderSurfaceDefinitionReturn(GetCylinderSurfaceDefinitionReturn o) {
			this.radius = o.radius;
			this.matrix = o.matrix;
		}
		public System.Double radius;
		public Geom.Matrix4 matrix;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetCylinderSurfaceDefinitionReturn_c
	{
		public System.Double radius;
		public Geom.Matrix4_c matrix;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetEdgeDefinitionReturn
	{
		public GetEdgeDefinitionReturn() {}
		public GetEdgeDefinitionReturn(GetEdgeDefinitionReturn o) {
			this.vertex1 = o.vertex1;
			this.vertex2 = o.vertex2;
			this.curve = o.curve;
			this.bounds = o.bounds;
		}
		public System.UInt32 vertex1;
		public System.UInt32 vertex2;
		public System.UInt32 curve;
		public Bounds1D bounds;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetEdgeDefinitionReturn_c
	{
		public System.UInt32 vertex1;
		public System.UInt32 vertex2;
		public System.UInt32 curve;
		public Bounds1D_c bounds;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetEllipseCurveDefinitionReturn
	{
		public GetEllipseCurveDefinitionReturn() {}
		public GetEllipseCurveDefinitionReturn(GetEllipseCurveDefinitionReturn o) {
			this.radius1 = o.radius1;
			this.radius2 = o.radius2;
			this.matrix = o.matrix;
		}
		public System.Double radius1;
		public System.Double radius2;
		public Geom.Matrix4 matrix;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetEllipseCurveDefinitionReturn_c
	{
		public System.Double radius1;
		public System.Double radius2;
		public Geom.Matrix4_c matrix;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetEllipticConeSurfaceDefinitionReturn
	{
		public GetEllipticConeSurfaceDefinitionReturn() {}
		public GetEllipticConeSurfaceDefinitionReturn(GetEllipticConeSurfaceDefinitionReturn o) {
			this.radius1 = o.radius1;
			this.radius2 = o.radius2;
			this.semiAngle = o.semiAngle;
			this.matrix = o.matrix;
		}
		public System.Double radius1;
		public System.Double radius2;
		public System.Double semiAngle;
		public Geom.Matrix4 matrix;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetEllipticConeSurfaceDefinitionReturn_c
	{
		public System.Double radius1;
		public System.Double radius2;
		public System.Double semiAngle;
		public Geom.Matrix4_c matrix;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetFaceDefinitionReturn
	{
		public GetFaceDefinitionReturn() {}
		public GetFaceDefinitionReturn(GetFaceDefinitionReturn o) {
			this.surface = o.surface;
			this.loops = o.loops;
			this.orientation = o.orientation;
			this.limits = o.limits;
		}
		public System.UInt32 surface;
		public LoopList loops;
		public System.Boolean orientation;
		public Bounds2D limits;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetFaceDefinitionReturn_c
	{
		public System.UInt32 surface;
		public LoopList_c loops;
		public System.Byte orientation;
		public Bounds2D_c limits;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetHelixCurveDefinitionReturn
	{
		public GetHelixCurveDefinitionReturn() {}
		public GetHelixCurveDefinitionReturn(GetHelixCurveDefinitionReturn o) {
			this.radius = o.radius;
			this.matrix = o.matrix;
			this.trigonometricOrientation = o.trigonometricOrientation;
		}
		public System.Double radius;
		public Geom.Matrix4 matrix;
		public System.Boolean trigonometricOrientation;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetHelixCurveDefinitionReturn_c
	{
		public System.Double radius;
		public Geom.Matrix4_c matrix;
		public System.Byte trigonometricOrientation;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetHermiteCurveDefinitionReturn
	{
		public GetHermiteCurveDefinitionReturn() {}
		public GetHermiteCurveDefinitionReturn(GetHermiteCurveDefinitionReturn o) {
			this.firstPoint = o.firstPoint;
			this.secondPoint = o.secondPoint;
			this.firstTangent = o.firstTangent;
			this.secondTangent = o.secondTangent;
		}
		public Geom.Point3 firstPoint;
		public Geom.Point3 secondPoint;
		public Geom.Point3 firstTangent;
		public Geom.Point3 secondTangent;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetHermiteCurveDefinitionReturn_c
	{
		public Geom.Point3_c firstPoint;
		public Geom.Point3_c secondPoint;
		public Geom.Point3_c firstTangent;
		public Geom.Point3_c secondTangent;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetHyperbolaCurveDefinitionReturn
	{
		public GetHyperbolaCurveDefinitionReturn() {}
		public GetHyperbolaCurveDefinitionReturn(GetHyperbolaCurveDefinitionReturn o) {
			this.radius1 = o.radius1;
			this.radius2 = o.radius2;
			this.matrix = o.matrix;
		}
		public System.Double radius1;
		public System.Double radius2;
		public Geom.Matrix4 matrix;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetHyperbolaCurveDefinitionReturn_c
	{
		public System.Double radius1;
		public System.Double radius2;
		public Geom.Matrix4_c matrix;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetIntersectionCurveDefinitionReturn
	{
		public GetIntersectionCurveDefinitionReturn() {}
		public GetIntersectionCurveDefinitionReturn(GetIntersectionCurveDefinitionReturn o) {
			this.surface1 = o.surface1;
			this.surface2 = o.surface2;
			this.chart = o.chart;
			this.bounds = o.bounds;
		}
		public System.UInt32 surface1;
		public System.UInt32 surface2;
		public System.UInt32 chart;
		public Bounds1D bounds;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetIntersectionCurveDefinitionReturn_c
	{
		public System.UInt32 surface1;
		public System.UInt32 surface2;
		public System.UInt32 chart;
		public Bounds1D_c bounds;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetLineCurveDefinitionReturn
	{
		public GetLineCurveDefinitionReturn() {}
		public GetLineCurveDefinitionReturn(GetLineCurveDefinitionReturn o) {
			this.origin = o.origin;
			this.direction = o.direction;
		}
		public Geom.Point3 origin;
		public Geom.Point3 direction;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetLineCurveDefinitionReturn_c
	{
		public Geom.Point3_c origin;
		public Geom.Point3_c direction;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetNURBSCurveDefinitionReturn
	{
		public GetNURBSCurveDefinitionReturn() {}
		public GetNURBSCurveDefinitionReturn(GetNURBSCurveDefinitionReturn o) {
			this.degree = o.degree;
			this.knots = o.knots;
			this.poles = o.poles;
			this.weights = o.weights;
		}
		public System.Int32 degree;
		public Core.DoubleList knots;
		public Geom.Point3List poles;
		public Core.DoubleList weights;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetNURBSCurveDefinitionReturn_c
	{
		public Int32 degree;
		public Core.DoubleList_c knots;
		public Geom.Point3List_c poles;
		public Core.DoubleList_c weights;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetNURBSSurfaceDefinitionReturn
	{
		public GetNURBSSurfaceDefinitionReturn() {}
		public GetNURBSSurfaceDefinitionReturn(GetNURBSSurfaceDefinitionReturn o) {
			this.degreeU = o.degreeU;
			this.degreeV = o.degreeV;
			this.knotsU = o.knotsU;
			this.knotsV = o.knotsV;
			this.poles = o.poles;
			this.weights = o.weights;
		}
		public System.Int32 degreeU;
		public System.Int32 degreeV;
		public Core.DoubleList knotsU;
		public Core.DoubleList knotsV;
		public Geom.Point3ListList poles;
		public Core.DoubleListList weights;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetNURBSSurfaceDefinitionReturn_c
	{
		public Int32 degreeU;
		public Int32 degreeV;
		public Core.DoubleList_c knotsU;
		public Core.DoubleList_c knotsV;
		public Geom.Point3ListList_c poles;
		public Core.DoubleListList_c weights;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetOffsetCurveDefinitionReturn
	{
		public GetOffsetCurveDefinitionReturn() {}
		public GetOffsetCurveDefinitionReturn(GetOffsetCurveDefinitionReturn o) {
			this.curve = o.curve;
			this.direction = o.direction;
			this.distance = o.distance;
			this.surfaceReference = o.surfaceReference;
		}
		public System.UInt32 curve;
		public Geom.Point3 direction;
		public System.Double distance;
		public System.UInt32 surfaceReference;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetOffsetCurveDefinitionReturn_c
	{
		public System.UInt32 curve;
		public Geom.Point3_c direction;
		public System.Double distance;
		public System.UInt32 surfaceReference;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct GetOffsetSurfaceDefinitionReturn
	{
		public GetOffsetSurfaceDefinitionReturn(GetOffsetSurfaceDefinitionReturn o) {
			this.baseSurface = o.baseSurface;
			this.distance = o.distance;
		}
		public System.UInt32 baseSurface;
		public System.Double distance;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetOffsetSurfaceDefinitionReturn_c
	{
		public System.UInt32 baseSurface;
		public System.Double distance;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetParabolaCurveDefinitionReturn
	{
		public GetParabolaCurveDefinitionReturn() {}
		public GetParabolaCurveDefinitionReturn(GetParabolaCurveDefinitionReturn o) {
			this.focalLength = o.focalLength;
			this.matrix = o.matrix;
		}
		public System.Double focalLength;
		public Geom.Matrix4 matrix;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetParabolaCurveDefinitionReturn_c
	{
		public System.Double focalLength;
		public Geom.Matrix4_c matrix;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetPolylineCurveDefinitionReturn
	{
		public GetPolylineCurveDefinitionReturn() {}
		public GetPolylineCurveDefinitionReturn(GetPolylineCurveDefinitionReturn o) {
			this.points = o.points;
			this.parameters = o.parameters;
		}
		public Geom.Point3List points;
		public Core.DoubleList parameters;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetPolylineCurveDefinitionReturn_c
	{
		public Geom.Point3List_c points;
		public Core.DoubleList_c parameters;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetRevolutionSurfaceDefinitionReturn
	{
		public GetRevolutionSurfaceDefinitionReturn() {}
		public GetRevolutionSurfaceDefinitionReturn(GetRevolutionSurfaceDefinitionReturn o) {
			this.generatricCurve = o.generatricCurve;
			this.axisOrigin = o.axisOrigin;
			this.axisDirection = o.axisDirection;
			this.startAngle = o.startAngle;
			this.endAngle = o.endAngle;
		}
		public System.UInt32 generatricCurve;
		public Geom.Point3 axisOrigin;
		public Geom.Point3 axisDirection;
		public System.Double startAngle;
		public System.Double endAngle;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetRevolutionSurfaceDefinitionReturn_c
	{
		public System.UInt32 generatricCurve;
		public Geom.Point3_c axisOrigin;
		public Geom.Point3_c axisDirection;
		public System.Double startAngle;
		public System.Double endAngle;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct GetRuledSurfaceDefinitionReturn
	{
		public GetRuledSurfaceDefinitionReturn(GetRuledSurfaceDefinitionReturn o) {
			this.firstCurve = o.firstCurve;
			this.secondCurve = o.secondCurve;
		}
		public System.UInt32 firstCurve;
		public System.UInt32 secondCurve;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetRuledSurfaceDefinitionReturn_c
	{
		public System.UInt32 firstCurve;
		public System.UInt32 secondCurve;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetSegmentCurveDefinitionReturn
	{
		public GetSegmentCurveDefinitionReturn() {}
		public GetSegmentCurveDefinitionReturn(GetSegmentCurveDefinitionReturn o) {
			this.startPoint = o.startPoint;
			this.endPoint = o.endPoint;
		}
		public Geom.Point3 startPoint;
		public Geom.Point3 endPoint;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetSegmentCurveDefinitionReturn_c
	{
		public Geom.Point3_c startPoint;
		public Geom.Point3_c endPoint;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetSphereSurfaceDefinitionReturn
	{
		public GetSphereSurfaceDefinitionReturn() {}
		public GetSphereSurfaceDefinitionReturn(GetSphereSurfaceDefinitionReturn o) {
			this.radius = o.radius;
			this.matrix = o.matrix;
		}
		public System.Double radius;
		public Geom.Matrix4 matrix;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetSphereSurfaceDefinitionReturn_c
	{
		public System.Double radius;
		public Geom.Matrix4_c matrix;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct GetSurfacicCurveDefinitionReturn
	{
		public GetSurfacicCurveDefinitionReturn(GetSurfacicCurveDefinitionReturn o) {
			this.surface = o.surface;
			this.curve2D = o.curve2D;
		}
		public System.UInt32 surface;
		public System.UInt32 curve2D;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetSurfacicCurveDefinitionReturn_c
	{
		public System.UInt32 surface;
		public System.UInt32 curve2D;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetTabulatedCylinderSurfaceDefinitionReturn
	{
		public GetTabulatedCylinderSurfaceDefinitionReturn() {}
		public GetTabulatedCylinderSurfaceDefinitionReturn(GetTabulatedCylinderSurfaceDefinitionReturn o) {
			this.directrixCurve = o.directrixCurve;
			this.generatrixLine = o.generatrixLine;
			this.range = o.range;
		}
		public System.UInt32 directrixCurve;
		public Geom.Point3 generatrixLine;
		public Bounds1D range;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetTabulatedCylinderSurfaceDefinitionReturn_c
	{
		public System.UInt32 directrixCurve;
		public Geom.Point3_c generatrixLine;
		public Bounds1D_c range;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetTorusSurfaceDefinitionReturn
	{
		public GetTorusSurfaceDefinitionReturn() {}
		public GetTorusSurfaceDefinitionReturn(GetTorusSurfaceDefinitionReturn o) {
			this.majorRadius = o.majorRadius;
			this.minorRadius = o.minorRadius;
			this.matrix = o.matrix;
			this.type = o.type;
		}
		public System.Double majorRadius;
		public System.Double minorRadius;
		public Geom.Matrix4 matrix;
		public System.Int32 type;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetTorusSurfaceDefinitionReturn_c
	{
		public System.Double majorRadius;
		public System.Double minorRadius;
		public Geom.Matrix4_c matrix;
		public Int32 type;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetTransformedCurveDefinitionReturn
	{
		public GetTransformedCurveDefinitionReturn() {}
		public GetTransformedCurveDefinitionReturn(GetTransformedCurveDefinitionReturn o) {
			this.curve = o.curve;
			this.matrix = o.matrix;
		}
		public System.UInt32 curve;
		public Geom.Matrix4 matrix;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetTransformedCurveDefinitionReturn_c
	{
		public System.UInt32 curve;
		public Geom.Matrix4_c matrix;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct IsCurvePeriodicReturn
	{
		public IsCurvePeriodicReturn(IsCurvePeriodicReturn o) {
			this.periodic = o.periodic;
			this.period = o.period;
		}
		public System.Boolean periodic;
		public System.Double period;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct IsCurvePeriodicReturn_c
	{
		public System.Byte periodic;
		public System.Double period;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct IsSurfaceClosedReturn
	{
		public IsSurfaceClosedReturn(IsSurfaceClosedReturn o) {
			this.closedU = o.closedU;
			this.closedV = o.closedV;
		}
		public System.Boolean closedU;
		public System.Boolean closedV;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct IsSurfaceClosedReturn_c
	{
		public System.Byte closedU;
		public System.Byte closedV;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct IsSurfacePeriodicReturn
	{
		public IsSurfacePeriodicReturn(IsSurfacePeriodicReturn o) {
			this.periodicU = o.periodicU;
			this.periodicV = o.periodicV;
			this.periodU = o.periodU;
			this.periodV = o.periodV;
		}
		public System.Boolean periodicU;
		public System.Boolean periodicV;
		public System.Double periodU;
		public System.Double periodV;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct IsSurfacePeriodicReturn_c
	{
		public System.Byte periodicU;
		public System.Byte periodicV;
		public System.Double periodU;
		public System.Double periodV;
	}

}
