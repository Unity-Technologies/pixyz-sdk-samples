#pragma warning disable CA2101

using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Pixyz.Polygonal {

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class JointList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public JointList() {}
		public JointList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](JointList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public JointList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct JointList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Submesh
	{
		public Submesh(Submesh o) {
			this.material = o.material;
			this.firstTri = o.firstTri;
			this.triCount = o.triCount;
			this.firstQuad = o.firstQuad;
			this.quadCount = o.quadCount;
			this.externalId = o.externalId;
		}
		public System.UInt32 material;
		public System.Int32 firstTri;
		public System.Int32 triCount;
		public System.Int32 firstQuad;
		public System.Int32 quadCount;
		public System.UInt32 externalId;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Submesh_c
	{
		public System.UInt32 material;
		public Int32 firstTri;
		public Int32 triCount;
		public Int32 firstQuad;
		public Int32 quadCount;
		public System.UInt32 externalId;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class SubmeshList {
		public Polygonal.Submesh[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public SubmeshList(Polygonal.Submesh[] tab) { list = tab; }
		public static implicit operator Polygonal.Submesh[](SubmeshList o) { return o.list; }
		public Polygonal.Submesh this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public SubmeshList(int size) { list = new Polygonal.Submesh[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct SubmeshList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class StylizedLine
	{
		public StylizedLine() {}
		public StylizedLine(StylizedLine o) {
			this.lineVertexIndices = o.lineVertexIndices;
			this.material = o.material;
			this.externalId = o.externalId;
		}
		public Core.IntList lineVertexIndices;
		public System.UInt32 material;
		public System.UInt32 externalId;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct StylizedLine_c
	{
		public Core.IntList_c lineVertexIndices;
		public System.UInt32 material;
		public System.UInt32 externalId;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class StylizedLineList {
		public Polygonal.StylizedLine[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public StylizedLineList(Polygonal.StylizedLine[] tab) { list = tab; }
		public static implicit operator Polygonal.StylizedLine[](StylizedLineList o) { return o.list; }
		public Polygonal.StylizedLine this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public StylizedLineList(int size) { list = new Polygonal.StylizedLine[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct StylizedLineList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class MeshDefinition
	{
		public MeshDefinition() {}
		public MeshDefinition(MeshDefinition o) {
			this.id = o.id;
			this.externalId = o.externalId;
			this.vertices = o.vertices;
			this.normals = o.normals;
			this.tangents = o.tangents;
			this.uvChannels = o.uvChannels;
			this.uvs = o.uvs;
			this.vertexColors = o.vertexColors;
			this.curvatures = o.curvatures;
			this.triangles = o.triangles;
			this.quadrangles = o.quadrangles;
			this.vertexMerged = o.vertexMerged;
			this.submeshes = o.submeshes;
			this.linesVertices = o.linesVertices;
			this.lines = o.lines;
			this.points = o.points;
			this.pointsColors = o.pointsColors;
			this.joints = o.joints;
			this.inverseBindMatrices = o.inverseBindMatrices;
			this.jointWeights = o.jointWeights;
			this.jointIndices = o.jointIndices;
		}
		public System.UInt32 id;
		public System.UInt32 externalId;
		public Geom.Point3List vertices;
		public Geom.Vector3List normals;
		public Geom.Vector4List tangents;
		public Core.IntList uvChannels;
		public Geom.Point2ListList uvs;
		public Core.ColorAlphaList vertexColors;
		public Geom.CurvaturesList curvatures;
		public Core.IntList triangles;
		public Core.IntList quadrangles;
		public Core.IntList vertexMerged;
		public SubmeshList submeshes;
		public Geom.Point3List linesVertices;
		public StylizedLineList lines;
		public Geom.Point3List points;
		public Geom.Vector3List pointsColors;
		public JointList joints;
		public Geom.Matrix4List inverseBindMatrices;
		public Geom.Vector4List jointWeights;
		public Geom.Vector4IList jointIndices;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct MeshDefinition_c
	{
		public System.UInt32 id;
		public System.UInt32 externalId;
		public Geom.Point3List_c vertices;
		public Geom.Vector3List_c normals;
		public Geom.Vector4List_c tangents;
		public Core.IntList_c uvChannels;
		public Geom.Point2ListList_c uvs;
		public Core.ColorAlphaList_c vertexColors;
		public Geom.CurvaturesList_c curvatures;
		public Core.IntList_c triangles;
		public Core.IntList_c quadrangles;
		public Core.IntList_c vertexMerged;
		public SubmeshList_c submeshes;
		public Geom.Point3List_c linesVertices;
		public StylizedLineList_c lines;
		public Geom.Point3List_c points;
		public Geom.Vector3List_c pointsColors;
		public JointList_c joints;
		public Geom.Matrix4List_c inverseBindMatrices;
		public Geom.Vector4List_c jointWeights;
		public Geom.Vector4IList_c jointIndices;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class MeshDefinitionList {
		public Polygonal.MeshDefinition[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public MeshDefinitionList(Polygonal.MeshDefinition[] tab) { list = tab; }
		public static implicit operator Polygonal.MeshDefinition[](MeshDefinitionList o) { return o.list; }
		public Polygonal.MeshDefinition this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public MeshDefinitionList(int size) { list = new Polygonal.MeshDefinition[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct MeshDefinitionList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class MeshList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public MeshList() {}
		public MeshList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](MeshList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public MeshList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct MeshList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class PlaceholderJointList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public PlaceholderJointList() {}
		public PlaceholderJointList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](PlaceholderJointList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public PlaceholderJointList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct PlaceholderJointList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	public enum StyleType
	{
		NORMAL = 0,
		STIPPLE = 1,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class TessellationList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public TessellationList() {}
		public TessellationList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](TessellationList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public TessellationList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct TessellationList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	public enum TopologyDimensionMask
	{
		NONE = 0,
		VERTEX = 1,
		LINE = 2,
		FACE = 4,
		ALL = 7,
	}

	public enum TopologyConnectivityMask
	{
		NONE = 0,
		MANIFOLD = 1,
		BOUNDARY = 2,
		NONMANIFOLD = 4,
		BOUNDARY_NONMANIFOLD = 6,
		FREE = 8,
		ALL = 15,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class TopologyCategoryMask
	{
		public TopologyCategoryMask() {}
		public TopologyCategoryMask(TopologyCategoryMask o) {
			this.dimension = o.dimension;
			this.connectivity = o.connectivity;
		}
		public TopologyDimensionMask dimension;
		public TopologyConnectivityMask connectivity;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct TopologyCategoryMask_c
	{
		public Int32 dimension;
		public Int32 connectivity;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class DracoEncodeReturn
	{
		public DracoEncodeReturn() {}
		public DracoEncodeReturn(DracoEncodeReturn o) {
			this.buffer = o.buffer;
			this.jointIndicesId = o.jointIndicesId;
			this.jointWeightsId = o.jointWeightsId;
		}
		public Core.ByteList buffer;
		public System.Int32 jointIndicesId;
		public System.Int32 jointWeightsId;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct DracoEncodeReturn_c
	{
		public Core.ByteList_c buffer;
		public Int32 jointIndicesId;
		public Int32 jointWeightsId;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct CreateMeshFromTextReturn
	{
		public CreateMeshFromTextReturn(CreateMeshFromTextReturn o) {
			this.mesh = o.mesh;
			this.material = o.material;
		}
		public System.UInt32 mesh;
		public System.UInt32 material;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct CreateMeshFromTextReturn_c
	{
		public System.UInt32 mesh;
		public System.UInt32 material;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetMeshSkinningReturn
	{
		public GetMeshSkinningReturn() {}
		public GetMeshSkinningReturn(GetMeshSkinningReturn o) {
			this.joints = o.joints;
			this.IBMs = o.IBMs;
		}
		public JointList joints;
		public Geom.Matrix4List IBMs;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetMeshSkinningReturn_c
	{
		public JointList_c joints;
		public Geom.Matrix4List_c IBMs;
	}

}
