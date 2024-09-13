#pragma warning disable CA2101

using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Pixyz.View {

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct AnimationPlayerInfo
	{
		public AnimationPlayerInfo(AnimationPlayerInfo o) {
			this.isPlaying = o.isPlaying;
			this.isLooping = o.isLooping;
			this.currentFrame = o.currentFrame;
			this.speed = o.speed;
		}
		public System.Boolean isPlaying;
		public System.Boolean isLooping;
		public System.UInt64 currentFrame;
		public System.Double speed;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct AnimationPlayerInfo_c
	{
		public System.Byte isPlaying;
		public System.Byte isLooping;
		public System.UInt64 currentFrame;
		public System.Double speed;
	}

	public enum CameraType
	{
		Perspective = 0,
		Orthographic = 1,
	}

	public enum RateControl
	{
		CONSTQP = 0,
		CBR = 1,
		VBR = 2,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct QP
	{
		public QP(QP o) {
			this.qpInterP = o.qpInterP;
			this.qpInterB = o.qpInterB;
			this.qpIntra = o.qpIntra;
		}
		public System.UInt32 qpInterP;
		public System.UInt32 qpInterB;
		public System.UInt32 qpIntra;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct QP_c
	{
		public System.UInt32 qpInterP;
		public System.UInt32 qpInterB;
		public System.UInt32 qpIntra;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class EncoderSettings
	{
		public EncoderSettings() {}
		public EncoderSettings(EncoderSettings o) {
			this.frameRate = o.frameRate;
			this.averageBitRate = o.averageBitRate;
			this.maxBitRate = o.maxBitRate;
			this.rateControl = o.rateControl;
			this.qp = o.qp;
			this.targetQuality = o.targetQuality;
		}
		public System.UInt32 frameRate;
		public System.UInt32 averageBitRate;
		public System.UInt32 maxBitRate;
		public RateControl rateControl;
		public QP qp;
		public System.UInt32 targetQuality;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct EncoderSettings_c
	{
		public System.UInt32 frameRate;
		public System.UInt32 averageBitRate;
		public System.UInt32 maxBitRate;
		public Int32 rateControl;
		public QP_c qp;
		public System.UInt32 targetQuality;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GPUSceneList {
		public System.Int32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public GPUSceneList() {}
		public GPUSceneList(System.Int32[] tab) { list = tab; }
		public static implicit operator System.Int32[](GPUSceneList o) { return o.list; }
		public System.Int32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public GPUSceneList(int size) { list = new System.Int32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GPUSceneList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	public enum GraphicAPI
	{
		None = 0,
		OpenGL = 1,
		D3D11 = 2,
		Vulkan = 3,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GraphicsContext
	{
		public GraphicsContext() {}
		public GraphicsContext(GraphicsContext o) {
			this.api = o.api;
			this.context = o.context;
		}
		public GraphicAPI api;
		public System.IntPtr context;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GraphicsContext_c
	{
		public Int32 api;
		public System.IntPtr context;
	}

	public enum PrimitiveSelectionType
	{
		Polygon = 0,
		Patch = 1,
		ConnectedMesh = 2,
	}

	public enum RenderMap
	{
		Composited = 0,
		AlbedoOpacity = 1,
		Normal = 2,
		Depth = 3,
		MetallicRoughnessAOMisc = 4,
		Emissive = 5,
		ObjectIdPrimitiveId = 6,
		UVs = 7,
		SSAO = 8,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct StreamedViewerInfo
	{
		public StreamedViewerInfo(StreamedViewerInfo o) {
			this.host = o.host;
			this.port = o.port;
			this.viewer = o.viewer;
		}
		public System.String host;
		public System.Int16 port;
		public System.Int32 viewer;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct StreamedViewerInfo_c
	{
		public IntPtr host;
		public System.Int16 port;
		public Int32 viewer;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct WebRTCInfo
	{
		public WebRTCInfo(WebRTCInfo o) {
			this.signalingUrl = o.signalingUrl;
			this.stunServer = o.stunServer;
			this.udpPortRangeBegin = o.udpPortRangeBegin;
			this.udpPortRangeEnd = o.udpPortRangeEnd;
		}
		public System.String signalingUrl;
		public System.String stunServer;
		public System.UInt16 udpPortRangeBegin;
		public System.UInt16 udpPortRangeEnd;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct WebRTCInfo_c
	{
		public IntPtr signalingUrl;
		public IntPtr stunServer;
		public System.UInt16 udpPortRangeBegin;
		public System.UInt16 udpPortRangeEnd;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct GetViewerSizeReturn
	{
		public GetViewerSizeReturn(GetViewerSizeReturn o) {
			this.width = o.width;
			this.height = o.height;
		}
		public System.Int32 width;
		public System.Int32 height;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetViewerSizeReturn_c
	{
		public Int32 width;
		public Int32 height;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct GetViewerStatsReturn
	{
		public GetViewerStatsReturn(GetViewerStatsReturn o) {
			this.renderedOccurrences = o.renderedOccurrences;
			this.renderedTriangles = o.renderedTriangles;
		}
		public System.Int32 renderedOccurrences;
		public System.Int32 renderedTriangles;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetViewerStatsReturn_c
	{
		public Int32 renderedOccurrences;
		public Int32 renderedTriangles;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class PickReturn
	{
		public PickReturn() {}
		public PickReturn(PickReturn o) {
			this.occurrence = o.occurrence;
			this.position = o.position;
			this.primitiveId = o.primitiveId;
		}
		public System.UInt32 occurrence;
		public Geom.Point3 position;
		public System.UInt32 primitiveId;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct PickReturn_c
	{
		public System.UInt32 occurrence;
		public Geom.Point3_c position;
		public System.UInt32 primitiveId;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetViewerMatricesReturn
	{
		public GetViewerMatricesReturn() {}
		public GetViewerMatricesReturn(GetViewerMatricesReturn o) {
			this.views = o.views;
			this.projs = o.projs;
			this.clipping = o.clipping;
		}
		public Geom.Matrix4List views;
		public Geom.Matrix4List projs;
		public Geom.Point2 clipping;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetViewerMatricesReturn_c
	{
		public Geom.Matrix4List_c views;
		public Geom.Matrix4List_c projs;
		public Geom.Point2_c clipping;
	}

}
