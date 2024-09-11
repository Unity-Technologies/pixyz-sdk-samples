#pragma warning disable CA2101

using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;
using PiXYZAPI = UnityEngine.Pixyz.API.PiXYZAPI;

namespace UnityEngine.Pixyz.View {

	public class ViewInterface : API.Interface {

		private PiXYZAPI api;
		internal ViewInterface(PiXYZAPI api)
		{
			this.api = api;
		}

		#region Types Init/Free Methods

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_StreamedViewerInfo_init(ref StreamedViewerInfo_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_StreamedViewerInfo_free(ref StreamedViewerInfo_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_GPUSceneList_init(ref GPUSceneList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_GPUSceneList_free(ref GPUSceneList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_WebRTCInfo_init(ref WebRTCInfo_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_WebRTCInfo_free(ref WebRTCInfo_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_GraphicsContext_init(ref GraphicsContext_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_GraphicsContext_free(ref GraphicsContext_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_QP_init(ref QP_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_QP_free(ref QP_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_EncoderSettings_init(ref EncoderSettings_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_EncoderSettings_free(ref EncoderSettings_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_AnimationPlayerInfo_init(ref AnimationPlayerInfo_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_AnimationPlayerInfo_free(ref AnimationPlayerInfo_c str);

	internal static StreamedViewerInfo ConvertValue(ref StreamedViewerInfo_c s) {
		StreamedViewerInfo ss = new StreamedViewerInfo();
		ss.host = ConvertValue(s.host);
		ss.port = (System.Int16)s.port;
		ss.viewer = (System.Int32)s.viewer;
		return ss;
	}

	internal static StreamedViewerInfo_c ConvertValue(StreamedViewerInfo s, ref StreamedViewerInfo_c ss) {
		View.ViewInterface.View_StreamedViewerInfo_init(ref ss);
		ss.host = ConvertValue(s.host);
		ss.port = (System.Int16)s.port;
		ss.viewer = (Int32)s.viewer;
		return ss;
	}

	internal static GPUSceneList ConvertValue(ref GPUSceneList_c s) {
		GPUSceneList list = new GPUSceneList((int)s.size);
		if (s.size > 0)
			Marshal.Copy(s.ptr, list.list, 0, (int)s.size);
		return list;
	}

	internal static GPUSceneList_c ConvertValue(GPUSceneList s, ref GPUSceneList_c list) {
		View.ViewInterface.View_GPUSceneList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size > 0)
			Marshal.Copy(s.list, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static WebRTCInfo ConvertValue(ref WebRTCInfo_c s) {
		WebRTCInfo ss = new WebRTCInfo();
		ss.signalingUrl = ConvertValue(s.signalingUrl);
		ss.stunServer = ConvertValue(s.stunServer);
		ss.udpPortRangeBegin = (System.UInt16)s.udpPortRangeBegin;
		ss.udpPortRangeEnd = (System.UInt16)s.udpPortRangeEnd;
		return ss;
	}

	internal static WebRTCInfo_c ConvertValue(WebRTCInfo s, ref WebRTCInfo_c ss) {
		View.ViewInterface.View_WebRTCInfo_init(ref ss);
		ss.signalingUrl = ConvertValue(s.signalingUrl);
		ss.stunServer = ConvertValue(s.stunServer);
		ss.udpPortRangeBegin = (System.UInt16)s.udpPortRangeBegin;
		ss.udpPortRangeEnd = (System.UInt16)s.udpPortRangeEnd;
		return ss;
	}

	internal static GraphicsContext ConvertValue(ref GraphicsContext_c s) {
		GraphicsContext ss = new GraphicsContext();
		ss.api = (GraphicAPI)s.api;
		ss.context = (System.IntPtr)s.context;
		return ss;
	}

	internal static GraphicsContext_c ConvertValue(GraphicsContext s, ref GraphicsContext_c ss) {
		View.ViewInterface.View_GraphicsContext_init(ref ss);
		ss.api = (Int32)s.api;
		ss.context = (System.IntPtr)s.context;
		return ss;
	}

	internal static QP ConvertValue(ref QP_c s) {
		QP ss = new QP();
		ss.qpInterP = (System.UInt32)s.qpInterP;
		ss.qpInterB = (System.UInt32)s.qpInterB;
		ss.qpIntra = (System.UInt32)s.qpIntra;
		return ss;
	}

	internal static QP_c ConvertValue(QP s, ref QP_c ss) {
		View.ViewInterface.View_QP_init(ref ss);
		ss.qpInterP = (System.UInt32)s.qpInterP;
		ss.qpInterB = (System.UInt32)s.qpInterB;
		ss.qpIntra = (System.UInt32)s.qpIntra;
		return ss;
	}

	internal static EncoderSettings ConvertValue(ref EncoderSettings_c s) {
		EncoderSettings ss = new EncoderSettings();
		ss.frameRate = (System.UInt32)s.frameRate;
		ss.averageBitRate = (System.UInt32)s.averageBitRate;
		ss.maxBitRate = (System.UInt32)s.maxBitRate;
		ss.rateControl = (RateControl)s.rateControl;
		ss.qp = ConvertValue(ref s.qp);
		ss.targetQuality = (System.UInt32)s.targetQuality;
		return ss;
	}

	internal static EncoderSettings_c ConvertValue(EncoderSettings s, ref EncoderSettings_c ss) {
		View.ViewInterface.View_EncoderSettings_init(ref ss);
		ss.frameRate = (System.UInt32)s.frameRate;
		ss.averageBitRate = (System.UInt32)s.averageBitRate;
		ss.maxBitRate = (System.UInt32)s.maxBitRate;
		ss.rateControl = (Int32)s.rateControl;
		ConvertValue(s.qp, ref ss.qp);
		ss.targetQuality = (System.UInt32)s.targetQuality;
		return ss;
	}

	internal static AnimationPlayerInfo ConvertValue(ref AnimationPlayerInfo_c s) {
		AnimationPlayerInfo ss = new AnimationPlayerInfo();
		ss.isPlaying = ConvertValue(s.isPlaying);
		ss.isLooping = ConvertValue(s.isLooping);
		ss.currentFrame = (System.UInt64)s.currentFrame;
		ss.speed = (System.Double)s.speed;
		return ss;
	}

	internal static AnimationPlayerInfo_c ConvertValue(AnimationPlayerInfo s, ref AnimationPlayerInfo_c ss) {
		View.ViewInterface.View_AnimationPlayerInfo_init(ref ss);
		ss.isPlaying = ConvertValue(s.isPlaying);
		ss.isLooping = ConvertValue(s.isLooping);
		ss.currentFrame = (System.UInt64)s.currentFrame;
		ss.speed = (System.Double)s.speed;
		return ss;
	}

	internal static GetViewerSizeReturn ConvertValue(ref GetViewerSizeReturn_c s) {
		GetViewerSizeReturn ss = new GetViewerSizeReturn();
		ss.width = (System.Int32)s.width;
		ss.height = (System.Int32)s.height;
		return ss;
	}

	internal static GetViewerSizeReturn_c ConvertValue(GetViewerSizeReturn s, ref GetViewerSizeReturn_c ss) {
		ss.width = (Int32)s.width;
		ss.height = (Int32)s.height;
		return ss;
	}

	internal static GetViewerStatsReturn ConvertValue(ref GetViewerStatsReturn_c s) {
		GetViewerStatsReturn ss = new GetViewerStatsReturn();
		ss.renderedOccurrences = (System.Int32)s.renderedOccurrences;
		ss.renderedTriangles = (System.Int32)s.renderedTriangles;
		return ss;
	}

	internal static GetViewerStatsReturn_c ConvertValue(GetViewerStatsReturn s, ref GetViewerStatsReturn_c ss) {
		ss.renderedOccurrences = (Int32)s.renderedOccurrences;
		ss.renderedTriangles = (Int32)s.renderedTriangles;
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

	internal static PickReturn ConvertValue(ref PickReturn_c s) {
		PickReturn ss = new PickReturn();
		ss.occurrence = (System.UInt32)s.occurrence;
		ss.position = Geom.GeomInterface.ConvertValue(ref s.position);
		ss.primitiveId = (System.UInt32)s.primitiveId;
		return ss;
	}

	internal static PickReturn_c ConvertValue(PickReturn s, ref PickReturn_c ss) {
		ss.occurrence = (System.UInt32)s.occurrence;
		Geom.GeomInterface.ConvertValue(s.position, ref ss.position);
		ss.primitiveId = (System.UInt32)s.primitiveId;
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

	internal static GetViewerMatricesReturn ConvertValue(ref GetViewerMatricesReturn_c s) {
		GetViewerMatricesReturn ss = new GetViewerMatricesReturn();
		ss.views = Geom.GeomInterface.ConvertValue(ref s.views);
		ss.projs = Geom.GeomInterface.ConvertValue(ref s.projs);
		ss.clipping = Geom.GeomInterface.ConvertValue(ref s.clipping);
		return ss;
	}

	internal static GetViewerMatricesReturn_c ConvertValue(GetViewerMatricesReturn s, ref GetViewerMatricesReturn_c ss) {
		Geom.GeomInterface.ConvertValue(s.views, ref ss.views);
		Geom.GeomInterface.ConvertValue(s.projs, ref ss.projs);
		Geom.GeomInterface.ConvertValue(s.clipping, ref ss.clipping);
		return ss;
	}

		#endregion

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr View_getLastError();

		public static string GetLastError()
		{
			return ConvertValue(View_getLastError());
		}

		#region 

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_configureFunctionLogger(IntPtr _pxz_session_, string functionName, System.Byte enableFunction, System.Byte enableParameters, System.Byte enableExecutionTime);

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
				View_configureFunctionLogger(api.Session, functionName, Convert.ToByte(enableFunction), Convert.ToByte(enableParameters), Convert.ToByte(enableExecutionTime));
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_destroyContext(IntPtr _pxz_session_);

		/// <summary>
		/// Destroy the Vulkan instance. All existing viewers and gpuScenes will also be destroyed and all view module properties will be reset
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void DestroyContext() {
			try {
				View_destroyContext(api.Session);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte View_suitableGPUAvailable(IntPtr _pxz_session_);

		/// <summary>
		/// returns true if a suitable device is found.
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean SuitableGPUAvailable() {
			try {
				var ret = View_suitableGPUAvailable(api.Session);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.Boolean)(0 != ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		private delegate void AfterFramebufferCreateDelegate_c(IntPtr userData, System.Int32 viewer);
		private static Dictionary<uint, AfterFramebufferCreateDelegate_c> m_AfterFramebufferCreateCallbacks = new Dictionary<uint, AfterFramebufferCreateDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 View_addAfterFramebufferCreateCallback(IntPtr _pxz_session_, AfterFramebufferCreateDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_removeAfterFramebufferCreateCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void AfterFramebufferCreateDelegate(IntPtr userData, System.Int32 viewer);

		public System.UInt32 AddAfterFramebufferCreateCallback(AfterFramebufferCreateDelegate callback, IntPtr userData) {
			AfterFramebufferCreateDelegate_c c = new AfterFramebufferCreateDelegate_c((System.IntPtr _pxz_session_, System.Int32 viewer) =>
			{
				var viewer_cs = (System.Int32)(viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, viewer_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = View_addAfterFramebufferCreateCallback(api.Session, c, userData);
			m_AfterFramebufferCreateCallbacks.Add(id, c);
			return id;
		}

		public void RemoveAfterFramebufferCreateCallback(System.UInt32 id) {
			View_removeAfterFramebufferCreateCallback(api.Session, id);
			m_AfterFramebufferCreateCallbacks.Remove(id);
		}

		private delegate void AfterViewerPropertyChangedDelegate_c(IntPtr userData, System.Int32 viewer, System.String property);
		private static Dictionary<uint, AfterViewerPropertyChangedDelegate_c> m_AfterViewerPropertyChangedCallbacks = new Dictionary<uint, AfterViewerPropertyChangedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 View_addAfterViewerPropertyChangedCallback(IntPtr _pxz_session_, AfterViewerPropertyChangedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_removeAfterViewerPropertyChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void AfterViewerPropertyChangedDelegate(IntPtr userData, System.Int32 viewer, System.String property);

		public System.UInt32 AddAfterViewerPropertyChangedCallback(AfterViewerPropertyChangedDelegate callback, IntPtr userData) {
			AfterViewerPropertyChangedDelegate_c c = new AfterViewerPropertyChangedDelegate_c((System.IntPtr _pxz_session_, System.Int32 viewer, System.String property) =>
			{
				var viewer_cs = (System.Int32)(viewer);
				var property_cs = (System.String)(property);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, viewer_cs, property_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = View_addAfterViewerPropertyChangedCallback(api.Session, c, userData);
			m_AfterViewerPropertyChangedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveAfterViewerPropertyChangedCallback(System.UInt32 id) {
			View_removeAfterViewerPropertyChangedCallback(api.Session, id);
			m_AfterViewerPropertyChangedCallbacks.Remove(id);
		}

		private delegate void BeforeFramebufferDeleteDelegate_c(IntPtr userData, System.Int32 viewer);
		private static Dictionary<uint, BeforeFramebufferDeleteDelegate_c> m_BeforeFramebufferDeleteCallbacks = new Dictionary<uint, BeforeFramebufferDeleteDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 View_addBeforeFramebufferDeleteCallback(IntPtr _pxz_session_, BeforeFramebufferDeleteDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_removeBeforeFramebufferDeleteCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void BeforeFramebufferDeleteDelegate(IntPtr userData, System.Int32 viewer);

		public System.UInt32 AddBeforeFramebufferDeleteCallback(BeforeFramebufferDeleteDelegate callback, IntPtr userData) {
			BeforeFramebufferDeleteDelegate_c c = new BeforeFramebufferDeleteDelegate_c((System.IntPtr _pxz_session_, System.Int32 viewer) =>
			{
				var viewer_cs = (System.Int32)(viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, viewer_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = View_addBeforeFramebufferDeleteCallback(api.Session, c, userData);
			m_BeforeFramebufferDeleteCallbacks.Add(id, c);
			return id;
		}

		public void RemoveBeforeFramebufferDeleteCallback(System.UInt32 id) {
			View_removeBeforeFramebufferDeleteCallback(api.Session, id);
			m_BeforeFramebufferDeleteCallbacks.Remove(id);
		}

		private delegate void BeforeViewerPropertyChangedDelegate_c(IntPtr userData, System.Int32 viewer, System.String property);
		private static Dictionary<uint, BeforeViewerPropertyChangedDelegate_c> m_BeforeViewerPropertyChangedCallbacks = new Dictionary<uint, BeforeViewerPropertyChangedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 View_addBeforeViewerPropertyChangedCallback(IntPtr _pxz_session_, BeforeViewerPropertyChangedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_removeBeforeViewerPropertyChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void BeforeViewerPropertyChangedDelegate(IntPtr userData, System.Int32 viewer, System.String property);

		public System.UInt32 AddBeforeViewerPropertyChangedCallback(BeforeViewerPropertyChangedDelegate callback, IntPtr userData) {
			BeforeViewerPropertyChangedDelegate_c c = new BeforeViewerPropertyChangedDelegate_c((System.IntPtr _pxz_session_, System.Int32 viewer, System.String property) =>
			{
				var viewer_cs = (System.Int32)(viewer);
				var property_cs = (System.String)(property);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, viewer_cs, property_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = View_addBeforeViewerPropertyChangedCallback(api.Session, c, userData);
			m_BeforeViewerPropertyChangedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveBeforeViewerPropertyChangedCallback(System.UInt32 id) {
			View_removeBeforeViewerPropertyChangedCallback(api.Session, id);
			m_BeforeViewerPropertyChangedCallbacks.Remove(id);
		}

		#endregion

		#region Animation Player

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_applyPlayingAnimations(IntPtr _pxz_session_, System.UInt64 time);

		/// <summary>
		/// WARNING: this function is tagged as 'EXPERIMENTAL'<br/>
		/// apply the animations
		/// </summary>
		/// <param name="time">Current time</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ApplyPlayingAnimations(System.UInt64 time) {
			try {
				View_applyPlayingAnimations(api.Session, time);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern AnimationPlayerInfo_c View_getAnimationPlayerInfo(IntPtr _pxz_session_, System.UInt32 animation);

		/// <summary>
		/// WARNING: this function is tagged as 'EXPERIMENTAL'<br/>
		/// packs all AnimationPlayer-related info about an animation in an object
		/// </summary>
		/// <param name="animation">Animation to get info of</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public AnimationPlayerInfo GetAnimationPlayerInfo(System.UInt32 animation) {
			try {
				var ret = View_getAnimationPlayerInfo(api.Session, animation);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				View.ViewInterface.View_AnimationPlayerInfo_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte View_isAnimationPlaying(IntPtr _pxz_session_, System.UInt32 animation);

		/// <summary>
		/// WARNING: this function is tagged as 'EXPERIMENTAL'<br/>
		/// is this animation playing?
		/// </summary>
		/// <param name="animation">Animation to check</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean IsAnimationPlaying(System.UInt32 animation) {
			try {
				var ret = View_isAnimationPlaying(api.Session, animation);
				System.String err = ConvertValue(View_getLastError());
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
		private static extern void View_pauseAllAnimation(IntPtr _pxz_session_);

		/// <summary>
		/// WARNING: this function is tagged as 'EXPERIMENTAL'<br/>
		/// pauses all animations
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void PauseAllAnimation() {
			try {
				View_pauseAllAnimation(api.Session);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_pauseAnimation(IntPtr _pxz_session_, System.UInt32 animation);

		/// <summary>
		/// WARNING: this function is tagged as 'EXPERIMENTAL'<br/>
		/// pauses an animation
		/// </summary>
		/// <param name="animation">Animation to pause</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void PauseAnimation(System.UInt32 animation) {
			try {
				View_pauseAnimation(api.Session, animation);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_playAnimation(IntPtr _pxz_session_, System.UInt32 animation, System.Double speed, System.Byte loop);

		/// <summary>
		/// WARNING: this function is tagged as 'EXPERIMENTAL'<br/>
		/// plays an animation
		/// </summary>
		/// <param name="animation">Animation to play</param>
		/// <param name="speed">Speed</param>
		/// <param name="loop">Should the animation loop?</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void PlayAnimation(System.UInt32 animation, System.Double speed = 1, System.Boolean loop = false) {
			try {
				View_playAnimation(api.Session, animation, speed, Convert.ToByte(loop));
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_resumeAllAnimation(IntPtr _pxz_session_);

		/// <summary>
		/// WARNING: this function is tagged as 'EXPERIMENTAL'<br/>
		/// resumes all animations
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ResumeAllAnimation() {
			try {
				View_resumeAllAnimation(api.Session);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_resumeAnimation(IntPtr _pxz_session_, System.UInt32 animation);

		/// <summary>
		/// WARNING: this function is tagged as 'EXPERIMENTAL'<br/>
		/// resumes an animation
		/// </summary>
		/// <param name="animation">Animation to resume</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ResumeAnimation(System.UInt32 animation) {
			try {
				View_resumeAnimation(api.Session, animation);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_setAnimationFrame(IntPtr _pxz_session_, System.UInt32 animation, System.UInt64 frame);

		/// <summary>
		/// WARNING: this function is tagged as 'EXPERIMENTAL'<br/>
		/// set animation's current frame
		/// </summary>
		/// <param name="animation">Animation to set frame</param>
		/// <param name="frame">Frame to set</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetAnimationFrame(System.UInt32 animation, System.UInt64 frame) {
			try {
				View_setAnimationFrame(api.Session, animation, frame);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_setAnimationLoop(IntPtr _pxz_session_, System.UInt32 animation, System.Byte loop);

		/// <summary>
		/// WARNING: this function is tagged as 'EXPERIMENTAL'<br/>
		/// set animation's looping status
		/// </summary>
		/// <param name="animation">Animation to set loop status</param>
		/// <param name="loop">Should the animation loop?</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetAnimationLoop(System.UInt32 animation, System.Boolean loop) {
			try {
				View_setAnimationLoop(api.Session, animation, Convert.ToByte(loop));
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_setAnimationSpeed(IntPtr _pxz_session_, System.UInt32 animation, System.Double speed);

		/// <summary>
		/// WARNING: this function is tagged as 'EXPERIMENTAL'<br/>
		/// set animation's playing speed
		/// </summary>
		/// <param name="animation">Animation to set speed</param>
		/// <param name="speed">The speed</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetAnimationSpeed(System.UInt32 animation, System.Double speed) {
			try {
				View_setAnimationSpeed(api.Session, animation, speed);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_stopAllAnimation(IntPtr _pxz_session_, System.Byte applyDefault);

		/// <summary>
		/// WARNING: this function is tagged as 'EXPERIMENTAL'<br/>
		/// stops all animations
		/// </summary>
		/// <param name="applyDefault">Should the default position be applied</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void StopAllAnimation(System.Boolean applyDefault = true) {
			try {
				View_stopAllAnimation(api.Session, Convert.ToByte(applyDefault));
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_stopAnimation(IntPtr _pxz_session_, System.UInt32 animation, System.Byte applyDefault);

		/// <summary>
		/// WARNING: this function is tagged as 'EXPERIMENTAL'<br/>
		/// stops an animation
		/// </summary>
		/// <param name="animation">Animation to stop</param>
		/// <param name="applyDefault">Should the default position be applied</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void StopAnimation(System.UInt32 animation, System.Boolean applyDefault = true) {
			try {
				View_stopAnimation(api.Session, animation, Convert.ToByte(applyDefault));
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		private delegate void AnimationPausedOrStoppedDelegate_c(IntPtr userData, System.UInt32 animation);
		private static Dictionary<uint, AnimationPausedOrStoppedDelegate_c> m_AnimationPausedOrStoppedCallbacks = new Dictionary<uint, AnimationPausedOrStoppedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 View_addAnimationPausedOrStoppedCallback(IntPtr _pxz_session_, AnimationPausedOrStoppedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_removeAnimationPausedOrStoppedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void AnimationPausedOrStoppedDelegate(IntPtr userData, System.UInt32 animation);

		public System.UInt32 AddAnimationPausedOrStoppedCallback(AnimationPausedOrStoppedDelegate callback, IntPtr userData) {
			AnimationPausedOrStoppedDelegate_c c = new AnimationPausedOrStoppedDelegate_c((System.IntPtr _pxz_session_, System.UInt32 animation) =>
			{
				var animation_cs = (System.UInt32)(animation);
				System.String err = ConvertValue(View_getLastError());
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
			uint id = View_addAnimationPausedOrStoppedCallback(api.Session, c, userData);
			m_AnimationPausedOrStoppedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveAnimationPausedOrStoppedCallback(System.UInt32 id) {
			View_removeAnimationPausedOrStoppedCallback(api.Session, id);
			m_AnimationPausedOrStoppedCallbacks.Remove(id);
		}

		private delegate void AnimationPlayedOrResumedDelegate_c(IntPtr userData, System.UInt32 animation);
		private static Dictionary<uint, AnimationPlayedOrResumedDelegate_c> m_AnimationPlayedOrResumedCallbacks = new Dictionary<uint, AnimationPlayedOrResumedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 View_addAnimationPlayedOrResumedCallback(IntPtr _pxz_session_, AnimationPlayedOrResumedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_removeAnimationPlayedOrResumedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void AnimationPlayedOrResumedDelegate(IntPtr userData, System.UInt32 animation);

		public System.UInt32 AddAnimationPlayedOrResumedCallback(AnimationPlayedOrResumedDelegate callback, IntPtr userData) {
			AnimationPlayedOrResumedDelegate_c c = new AnimationPlayedOrResumedDelegate_c((System.IntPtr _pxz_session_, System.UInt32 animation) =>
			{
				var animation_cs = (System.UInt32)(animation);
				System.String err = ConvertValue(View_getLastError());
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
			uint id = View_addAnimationPlayedOrResumedCallback(api.Session, c, userData);
			m_AnimationPlayedOrResumedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveAnimationPlayedOrResumedCallback(System.UInt32 id) {
			View_removeAnimationPlayedOrResumedCallback(api.Session, id);
			m_AnimationPlayedOrResumedCallbacks.Remove(id);
		}

		private delegate void AnimationPlayingStatusChangedDelegate_c(IntPtr userData, System.UInt32 animation, AnimationPlayerInfo_c playInfo);
		private static Dictionary<uint, AnimationPlayingStatusChangedDelegate_c> m_AnimationPlayingStatusChangedCallbacks = new Dictionary<uint, AnimationPlayingStatusChangedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 View_addAnimationPlayingStatusChangedCallback(IntPtr _pxz_session_, AnimationPlayingStatusChangedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_removeAnimationPlayingStatusChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void AnimationPlayingStatusChangedDelegate(IntPtr userData, System.UInt32 animation, AnimationPlayerInfo playInfo);

		public System.UInt32 AddAnimationPlayingStatusChangedCallback(AnimationPlayingStatusChangedDelegate callback, IntPtr userData) {
			AnimationPlayingStatusChangedDelegate_c c = new AnimationPlayingStatusChangedDelegate_c((System.IntPtr _pxz_session_, System.UInt32 animation, AnimationPlayerInfo_c playInfo) =>
			{
				var animation_cs = (System.UInt32)(animation);
				var playInfo_cs = View.ViewInterface.ConvertValue(ref playInfo);
				View.ViewInterface.View_AnimationPlayerInfo_free(ref playInfo);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, animation_cs, playInfo_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = View_addAnimationPlayingStatusChangedCallback(api.Session, c, userData);
			m_AnimationPlayingStatusChangedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveAnimationPlayingStatusChangedCallback(System.UInt32 id) {
			View_removeAnimationPlayingStatusChangedCallback(api.Session, id);
			m_AnimationPlayingStatusChangedCallbacks.Remove(id);
		}

		#endregion

		#region D3D11 interop

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr View_getD3D11Texture(IntPtr _pxz_session_, Int32 renderMap, Int32 viewer);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="renderMap"></param>
		/// <param name="viewer"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.IntPtr GetD3D11Texture(RenderMap renderMap, System.Int32 viewer = -1) {
			try {
				var ret = View_getD3D11Texture(api.Session, (int)renderMap, viewer);
				System.String err = ConvertValue(View_getLastError());
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

		#region OpenGL interop

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Int32 View_getGLTextureHandle(IntPtr _pxz_session_, Int32 renderMap, Int32 viewer);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="renderMap"></param>
		/// <param name="viewer"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Int32 GetGLTextureHandle(RenderMap renderMap, System.Int32 viewer = -1) {
			try {
				var ret = View_getGLTextureHandle(api.Session, (int)renderMap, viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.Int32)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region Vulkan interop

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr View_getVulkanTexture(IntPtr _pxz_session_, Int32 renderMap, Int32 viewer);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="renderMap"></param>
		/// <param name="viewer"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.IntPtr GetVulkanTexture(RenderMap renderMap, System.Int32 viewer = -1) {
			try {
				var ret = View_getVulkanTexture(api.Session, (int)renderMap, viewer);
				System.String err = ConvertValue(View_getLastError());
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

		#region gpu scene

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Int32 View_createGPUScene(IntPtr _pxz_session_, Scene.OccurrenceList_c roots, System.Byte constructEdges);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roots">Roots of the subtrees that will be uploaded to GPU</param>
		/// <param name="constructEdges">Construct buffer to render edges colored by topology (slower to construct)</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Int32 CreateGPUScene(Scene.OccurrenceList roots, System.Boolean constructEdges = false) {
			try {
				var roots_c = new Scene.OccurrenceList_c();
				Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)roots, ref roots_c);
				var ret = View_createGPUScene(api.Session, roots_c, Convert.ToByte(constructEdges));
				Scene.SceneInterface.Scene_OccurrenceList_free(ref roots_c);
				System.String err = ConvertValue(View_getLastError());
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
		private static extern void View_destroyGPUScene(IntPtr _pxz_session_, Int32 scene);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="scene">GPU Scene to destroy (previously created by createGPUScene)</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void DestroyGPUScene(System.Int32 scene) {
			try {
				View_destroyGPUScene(api.Session, scene);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Int32 View_getGlobalGPUScene(IntPtr _pxz_session_);

		/// <summary>
		/// Returns (and create if it does not exist) a global GPU scene (with the scene root) to be used commonly by several clients
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Int32 GetGlobalGPUScene() {
			try {
				var ret = View_getGlobalGPUScene(api.Session);
				System.String err = ConvertValue(View_getLastError());
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
		private static extern Geom.AABB_c View_getLastAABB(IntPtr _pxz_session_, Int32 scene, Int32 viewer);

		/// <summary>
		/// Return the lastAABB computed during a frame drawing, requires the viewer property ComputeLastAABB to be True
		/// </summary>
		/// <param name="scene">Identifier of the GPU scene to get the last AABB from</param>
		/// <param name="viewer"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.AABB GetLastAABB(System.Int32 scene, System.Int32 viewer) {
			try {
				var ret = View_getLastAABB(api.Session, scene, viewer);
				System.String err = ConvertValue(View_getLastError());
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
		private static extern System.UInt32 View_getOccurrenceIndex(IntPtr _pxz_session_, System.UInt32 occurrence, Int32 scene);

		/// <summary>
		/// Returns the occurrence index in the viewer buffers. Can be used for mapping an index retrieved in a GLTextureHandle id map.
		/// </summary>
		/// <param name="occurrence">Occurrence identifier</param>
		/// <param name="scene">Scene identifier</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetOccurrenceIndex(System.UInt32 occurrence, System.Int32 scene) {
			try {
				var ret = View_getOccurrenceIndex(api.Session, occurrence, scene);
				System.String err = ConvertValue(View_getLastError());
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
		private static extern System.UInt32 View_getSceneIndex(IntPtr _pxz_session_, Int32 scene, Int32 viewer);

		/// <summary>
		/// Returns the GPU scene index in the viewer buffers. Can be used for mapping an index retrieved in a GLTextureHandle id map.
		/// </summary>
		/// <param name="scene">GPU scene identifier</param>
		/// <param name="viewer">Viewer identifier</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 GetSceneIndex(System.Int32 scene, System.Int32 viewer) {
			try {
				var ret = View_getSceneIndex(api.Session, scene, viewer);
				System.String err = ConvertValue(View_getLastError());
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
		private static extern void View_lockGPUSceneUpdate(IntPtr _pxz_session_, Int32 scene);

		/// <summary>
		/// Lock the mutex that ensure no update of the gpu scene is done between lock/unlock
		/// </summary>
		/// <param name="scene">Identifier of the GPU scene to lock update for</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void LockGPUSceneUpdate(System.Int32 scene) {
			try {
				View_lockGPUSceneUpdate(api.Session, scene);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_lockGPUScenesUpdate(IntPtr _pxz_session_, GPUSceneList_c scenes);

		/// <summary>
		/// Lock the mutex that ensure no update of multiple gpu scenes is done between lock/unlock
		/// </summary>
		/// <param name="scenes">Identifiers of the GPU scenes to lock update for</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void LockGPUScenesUpdate(GPUSceneList scenes) {
			try {
				var scenes_c = new View.GPUSceneList_c();
				ConvertValue((View.GPUSceneList)scenes, ref scenes_c);
				View_lockGPUScenesUpdate(api.Session, scenes_c);
				View.ViewInterface.View_GPUSceneList_free(ref scenes_c);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte View_tryLockGPUSceneUpdate(IntPtr _pxz_session_, Int32 scene);

		/// <summary>
		/// Try to lock the mutex that ensure no update of the gpu scene is done between lock/unlock, returns true if the mutex has been locked, false if it was already locked
		/// </summary>
		/// <param name="scene">Identifier of the GPU scene to try to lock update for</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Boolean TryLockGPUSceneUpdate(System.Int32 scene) {
			try {
				var ret = View_tryLockGPUSceneUpdate(api.Session, scene);
				System.String err = ConvertValue(View_getLastError());
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
		private static extern Core.BoolList_c View_tryLockGPUScenesUpdate(IntPtr _pxz_session_, GPUSceneList_c scenes);

		/// <summary>
		/// Try to lock the mutex that ensure no update of multiple gpu scenes is done between lock/unlock, returns true if the mutex has been locked, false if it was already locked
		/// </summary>
		/// <param name="scenes">Identifiers of the GPU scenes to try to lock update for</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Core.BoolList TryLockGPUScenesUpdate(GPUSceneList scenes) {
			try {
				var scenes_c = new View.GPUSceneList_c();
				ConvertValue((View.GPUSceneList)scenes, ref scenes_c);
				var ret = View_tryLockGPUScenesUpdate(api.Session, scenes_c);
				View.ViewInterface.View_GPUSceneList_free(ref scenes_c);
				System.String err = ConvertValue(View_getLastError());
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
		private static extern void View_unlockGPUSceneUpdate(IntPtr _pxz_session_, Int32 scene);

		/// <summary>
		/// Unlock the mutex that ensure no update of the gpu scene is done between lock/unlock
		/// </summary>
		/// <param name="scene">Identifier of the GPU scene to unlock update for</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void UnlockGPUSceneUpdate(System.Int32 scene) {
			try {
				View_unlockGPUSceneUpdate(api.Session, scene);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_unlockGPUScenesUpdate(IntPtr _pxz_session_, GPUSceneList_c scenes);

		/// <summary>
		/// Unlock the mutex that ensure no update of multiple gpu scenes is done between lock/unlock
		/// </summary>
		/// <param name="scenes">Identifiers of the GPU scenes to unlock update for</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void UnlockGPUScenesUpdate(GPUSceneList scenes) {
			try {
				var scenes_c = new View.GPUSceneList_c();
				ConvertValue((View.GPUSceneList)scenes, ref scenes_c);
				View_unlockGPUScenesUpdate(api.Session, scenes_c);
				View.ViewInterface.View_GPUSceneList_free(ref scenes_c);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region offscreen

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_addGPUScene(IntPtr _pxz_session_, Int32 scene, Int32 viewer);

		/// <summary>
		/// Add a GPU scene to a viewer
		/// </summary>
		/// <param name="scene">GPU Scene to render in the viewer</param>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AddGPUScene(System.Int32 scene, System.Int32 viewer = -1) {
			try {
				View_addGPUScene(api.Session, scene, viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_captureNextFrame(IntPtr _pxz_session_, Int32 viewer);

		/// <summary>
		/// Debug: capture next frame with renderdoc (only if launched with renderdoc)
		/// </summary>
		/// <param name="viewer">Viewer to capture</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void CaptureNextFrame(System.Int32 viewer) {
			try {
				View_captureNextFrame(api.Session, viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Int32 View_createViewer(IntPtr _pxz_session_, Int32 width, Int32 height, GraphicsContext_c sharedContext, Int32 nbViews);

		/// <summary>
		/// Create a new viewer
		/// </summary>
		/// <param name="width">Width of the viewer framebuffer</param>
		/// <param name="height">Height of the viewer framebuffer</param>
		/// <param name="sharedContext">Interop context handle</param>
		/// <param name="nbViews">Nb views</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.Int32 CreateViewer(System.Int32 width, System.Int32 height, GraphicsContext sharedContext = null, System.Int32 nbViews = 1) {
			sharedContext = sharedContext ?? new View.GraphicsContext() {};
			try {
				var sharedContext_c = new View.GraphicsContext_c();
				ConvertValue((View.GraphicsContext)sharedContext, ref sharedContext_c);
				var ret = View_createViewer(api.Session, width, height, sharedContext_c, nbViews);
				View.ViewInterface.View_GraphicsContext_free(ref sharedContext_c);
				System.String err = ConvertValue(View_getLastError());
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
		private static extern void View_destroyViewer(IntPtr _pxz_session_, Int32 viewer);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="viewer">Viewer to destroy</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void DestroyViewer(System.Int32 viewer) {
			try {
				View_destroyViewer(api.Session, viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 View_drawCappingPlane(IntPtr _pxz_session_, System.UInt32 cuttingPlane);

		/// <summary>
		/// Create an occurrence that holds the mesh of the surfaces that have been cut by the cutting plane
		/// </summary>
		/// <param name="cuttingPlane">Cutting plane component for which we create the capping plane</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 DrawCappingPlane(System.UInt32 cuttingPlane) {
			try {
				var ret = View_drawCappingPlane(api.Session, cuttingPlane);
				System.String err = ConvertValue(View_getLastError());
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
		private static extern Geom.Point2_c View_getAutoClipping(IntPtr _pxz_session_, Int32 viewer, Geom.Point3_c cameraPos);

		/// <summary>
		/// Automatically compute the near and far planes depending on the scene
		/// </summary>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		/// <param name="cameraPos"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.Point2 GetAutoClipping(System.Int32 viewer, Geom.Point3 cameraPos) {
			try {
				var cameraPos_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)cameraPos, ref cameraPos_c);
				var ret = View_getAutoClipping(api.Session, viewer, cameraPos_c);
				Geom.GeomInterface.Geom_Point3_free(ref cameraPos_c);
				System.String err = ConvertValue(View_getLastError());
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
		private static extern Geom.Point3_c View_getCameraFrontAxis(IntPtr _pxz_session_, Int32 viewer, System.UInt32 matrixIndex);

		/// <summary>
		/// Get the front axis of the nth view matrix of a given viewer
		/// </summary>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		/// <param name="matrixIndex">Index of the view matrix to use.</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.Point3 GetCameraFrontAxis(System.Int32 viewer = -1, System.UInt32 matrixIndex = 0) {
			try {
				var ret = View_getCameraFrontAxis(api.Session, viewer, matrixIndex);
				System.String err = ConvertValue(View_getLastError());
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
		private static extern Geom.Point3_c View_getCameraPosition(IntPtr _pxz_session_, Int32 viewer, System.UInt32 matrixIndex);

		/// <summary>
		/// Get the position of the nth view matrix of a given viewer
		/// </summary>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		/// <param name="matrixIndex">Index of the view matrix to use.</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.Point3 GetCameraPosition(System.Int32 viewer = -1, System.UInt32 matrixIndex = 0) {
			try {
				var ret = View_getCameraPosition(api.Session, viewer, matrixIndex);
				System.String err = ConvertValue(View_getLastError());
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
		private static extern Geom.Point3_c View_getCameraRightAxis(IntPtr _pxz_session_, Int32 viewer, System.UInt32 matrixIndex);

		/// <summary>
		/// Get the right axis of the nth view matrix of a given viewer
		/// </summary>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		/// <param name="matrixIndex">Index of the view matrix to use.</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.Point3 GetCameraRightAxis(System.Int32 viewer = -1, System.UInt32 matrixIndex = 0) {
			try {
				var ret = View_getCameraRightAxis(api.Session, viewer, matrixIndex);
				System.String err = ConvertValue(View_getLastError());
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
		private static extern Geom.Point3_c View_getCameraUpAxis(IntPtr _pxz_session_, Int32 viewer, System.UInt32 matrixIndex);

		/// <summary>
		/// Get the up axis of the nth view matrix of a given viewer
		/// </summary>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		/// <param name="matrixIndex">Index of the view matrix to use.</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Geom.Point3 GetCameraUpAxis(System.Int32 viewer = -1, System.UInt32 matrixIndex = 0) {
			try {
				var ret = View_getCameraUpAxis(api.Session, viewer, matrixIndex);
				System.String err = ConvertValue(View_getLastError());
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
		private static extern IntPtr View_getViewerProperty(IntPtr _pxz_session_, string propertyName, Int32 viewer);

		/// <summary>
		/// Get a viewer property value
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String GetViewerProperty(System.String propertyName, System.Int32 viewer = -1) {
			try {
				var ret = View_getViewerProperty(api.Session, propertyName, viewer);
				System.String err = ConvertValue(View_getLastError());
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
		private static extern Core.PropertyInfo_c View_getViewerPropertyInfo(IntPtr _pxz_session_, string propertyName, Int32 viewer);

		/// <summary>
		/// Get a viewer property info
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Core.PropertyInfo GetViewerPropertyInfo(System.String propertyName, System.Int32 viewer = -1) {
			try {
				var ret = View_getViewerPropertyInfo(api.Session, propertyName, viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Core.CoreInterface.ConvertValue(ref ret);
				Core.CoreInterface.Core_PropertyInfo_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetViewerSizeReturn_c View_getViewerSize(IntPtr _pxz_session_, Int32 viewer);

		/// <summary>
		/// Retrieve the viewport size of a viewer
		/// </summary>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public View.GetViewerSizeReturn GetViewerSize(System.Int32 viewer = -1) {
			try {
				var ret = View_getViewerSize(api.Session, viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				View.GetViewerSizeReturn retStruct = new View.GetViewerSizeReturn();
				retStruct.width = (System.Int32)ret.width;
				retStruct.height = (System.Int32)ret.height;
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetViewerStatsReturn_c View_getViewerStats(IntPtr _pxz_session_, Int32 viewer);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public View.GetViewerStatsReturn GetViewerStats(System.Int32 viewer = -1) {
			try {
				var ret = View_getViewerStats(api.Session, viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				View.GetViewerStatsReturn retStruct = new View.GetViewerStatsReturn();
				retStruct.renderedOccurrences = (System.Int32)ret.renderedOccurrences;
				retStruct.renderedTriangles = (System.Int32)ret.renderedTriangles;
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.PropertyInfoList_c View_listViewerProperties(IntPtr _pxz_session_, Int32 viewer);

		/// <summary>
		/// Get the list of viewer properties
		/// </summary>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Core.PropertyInfoList ListViewerProperties(System.Int32 viewer = -1) {
			try {
				var ret = View_listViewerProperties(api.Session, viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Core.CoreInterface.ConvertValue(ref ret);
				Core.CoreInterface.Core_PropertyInfoList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern PickReturn_c View_pick(IntPtr _pxz_session_, Int32 x, Int32 y, Int32 viewer);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="viewer"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public View.PickReturn Pick(System.Int32 x, System.Int32 y, System.Int32 viewer = -1) {
			try {
				var ret = View_pick(api.Session, x, y, viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				View.PickReturn retStruct = new View.PickReturn();
				retStruct.occurrence = (System.UInt32)ret.occurrence;
				retStruct.position = ConvertValue(ref ret.position);
				Geom.GeomInterface.Geom_Point3_free(ref ret.position);
				retStruct.primitiveId = (System.UInt32)ret.primitiveId;
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Scene.OccurrenceList_c View_pickRectangle(IntPtr _pxz_session_, Int32 xMin, Int32 xMax, Int32 yMin, Int32 yMax, Int32 viewer, System.Byte inDepth);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="xMin"></param>
		/// <param name="xMax"></param>
		/// <param name="yMin"></param>
		/// <param name="yMax"></param>
		/// <param name="viewer"></param>
		/// <param name="inDepth"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Scene.OccurrenceList PickRectangle(System.Int32 xMin, System.Int32 xMax, System.Int32 yMin, System.Int32 yMax, System.Int32 viewer = -1, System.Boolean inDepth = false) {
			try {
				var ret = View_pickRectangle(api.Session, xMin, xMax, yMin, yMax, viewer, Convert.ToByte(inDepth));
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Scene.SceneInterface.ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_refreshViewer(IntPtr _pxz_session_, Int32 viewer);

		/// <summary>
		/// Refresh the viewer
		/// </summary>
		/// <param name="viewer">Viewer to refresh</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void RefreshViewer(System.Int32 viewer = -1) {
			try {
				View_refreshViewer(api.Session, viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_removeGPUScene(IntPtr _pxz_session_, Int32 scene, Int32 viewer);

		/// <summary>
		/// Remove a viewer root
		/// </summary>
		/// <param name="scene">GPU Scene to remove from the viewer</param>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void RemoveGPUScene(System.Int32 scene, System.Int32 viewer = -1) {
			try {
				View_removeGPUScene(api.Session, scene, viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_resizeViewer(IntPtr _pxz_session_, Int32 width, Int32 height, Int32 viewer);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="width">Width of the viewer framebuffer</param>
		/// <param name="height">Height of the viewer framebuffer</param>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ResizeViewer(System.Int32 width, System.Int32 height, System.Int32 viewer = -1) {
			try {
				View_resizeViewer(api.Session, width, height, viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_selectPrimitives(IntPtr _pxz_session_, Int32 xMin, Int32 xMax, Int32 yMin, Int32 yMax, Int32 primitiveType, Int32 viewer);

		/// <summary>
		/// Select the primitives (polygons, surfaces) contained in the given rectangle
		/// </summary>
		/// <param name="xMin"></param>
		/// <param name="xMax"></param>
		/// <param name="yMin"></param>
		/// <param name="yMax"></param>
		/// <param name="primitiveType"></param>
		/// <param name="viewer"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SelectPrimitives(System.Int32 xMin, System.Int32 xMax, System.Int32 yMin, System.Int32 yMax, PrimitiveSelectionType primitiveType, System.Int32 viewer = -1) {
			try {
				View_selectPrimitives(api.Session, xMin, xMax, yMin, yMax, (int)primitiveType, viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_setDefaultViewerId(IntPtr _pxz_session_, Int32 viewer);

		/// <summary>
		/// Set default viewer id. This viewer will be used in other functions taking a Viewer as a parameter. Useful if a viewer needs to be shared across different contexts.
		/// </summary>
		/// <param name="viewer"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetDefaultViewerId(System.Int32 viewer) {
			try {
				View_setDefaultViewerId(api.Session, viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_setViewerProperty(IntPtr _pxz_session_, string propertyName, string propertyValue, Int32 viewer);

		/// <summary>
		/// Set a viewer property value
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="propertyValue"></param>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetViewerProperty(System.String propertyName, System.String propertyValue, System.Int32 viewer = -1) {
			try {
				View_setViewerProperty(api.Session, propertyName, propertyValue, viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region raw images

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Material.ImageDefinition_c View_getCompositedImage(IntPtr _pxz_session_, Int32 viewer);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="viewer"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Material.ImageDefinition GetCompositedImage(System.Int32 viewer) {
			try {
				var ret = View_getCompositedImage(api.Session, viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Material.MaterialInterface.ConvertValue(ref ret);
				Material.MaterialInterface.Material_ImageDefinition_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Material.ImageDefinition_c View_getRenderMapImage(IntPtr _pxz_session_, Int32 viewer, Int32 renderMap);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="viewer"></param>
		/// <param name="renderMap"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Material.ImageDefinition GetRenderMapImage(System.Int32 viewer, RenderMap renderMap) {
			try {
				var ret = View_getRenderMapImage(api.Session, viewer, (int)renderMap);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Material.MaterialInterface.ConvertValue(ref ret);
				Material.MaterialInterface.Material_ImageDefinition_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_takeScreenshot(IntPtr _pxz_session_, string fileName, Int32 viewer);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="fileName">Path where to save the screenshot</param>
		/// <param name="viewer"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void TakeScreenshot(System.String fileName, System.Int32 viewer) {
			try {
				View_takeScreenshot(api.Session, fileName, viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region streaming

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern StreamedViewerInfo_c View_createStreamedViewer(IntPtr _pxz_session_, Int32 width, Int32 height, EncoderSettings_c encoderSettings, System.Byte useWebRTC, WebRTCInfo_c webRTCInfo);

		/// <summary>
		/// create a viewer for streaming
		/// </summary>
		/// <param name="width">Width of the viewer framebuffer</param>
		/// <param name="height">Height of the viewer framebuffer</param>
		/// <param name="encoderSettings">Settings used for the encoder</param>
		/// <param name="useWebRTC">Switch between raw websockets and webRTC</param>
		/// <param name="webRTCInfo">Info for web rtc signaling connection</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public StreamedViewerInfo CreateStreamedViewer(System.Int32 width, System.Int32 height, EncoderSettings encoderSettings = null, System.Boolean useWebRTC = false, WebRTCInfo? webRTCInfo = null) {
			encoderSettings = encoderSettings ?? new View.EncoderSettings() {};
			webRTCInfo = webRTCInfo ?? new View.WebRTCInfo() {};
			try {
				var encoderSettings_c = new View.EncoderSettings_c();
				ConvertValue((View.EncoderSettings)encoderSettings, ref encoderSettings_c);
				var webRTCInfo_c = new View.WebRTCInfo_c();
				ConvertValue((View.WebRTCInfo)webRTCInfo, ref webRTCInfo_c);
				var ret = View_createStreamedViewer(api.Session, width, height, encoderSettings_c, Convert.ToByte(useWebRTC), webRTCInfo_c);
				View.ViewInterface.View_EncoderSettings_free(ref encoderSettings_c);
				View.ViewInterface.View_WebRTCInfo_free(ref webRTCInfo_c);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				View.ViewInterface.View_StreamedViewerInfo_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_resizeStreamedViewer(IntPtr _pxz_session_, Int32 width, Int32 height, Int32 viewer, EncoderSettings_c encoderSettings);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="width">Width of the viewer framebuffer</param>
		/// <param name="height">Height of the viewer framebuffer</param>
		/// <param name="viewer"></param>
		/// <param name="encoderSettings">Settings used for the encoder</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ResizeStreamedViewer(System.Int32 width, System.Int32 height, System.Int32 viewer = -1, EncoderSettings encoderSettings = null) {
			encoderSettings = encoderSettings ?? new View.EncoderSettings() {};
			try {
				var encoderSettings_c = new View.EncoderSettings_c();
				ConvertValue((View.EncoderSettings)encoderSettings, ref encoderSettings_c);
				View_resizeStreamedViewer(api.Session, width, height, viewer, encoderSettings_c);
				View.ViewInterface.View_EncoderSettings_free(ref encoderSettings_c);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_startRecording(IntPtr _pxz_session_, string filePath, Int32 viewer, EncoderSettings_c encoderSettings);

		/// <summary>
		/// record viewer in a file
		/// </summary>
		/// <param name="filePath">File in which video while be saved</param>
		/// <param name="viewer">Viewer to use for recording video</param>
		/// <param name="encoderSettings">Settings used for the encoder</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void StartRecording(System.String filePath, System.Int32 viewer, EncoderSettings encoderSettings = null) {
			encoderSettings = encoderSettings ?? new View.EncoderSettings() {};
			try {
				var encoderSettings_c = new View.EncoderSettings_c();
				ConvertValue((View.EncoderSettings)encoderSettings, ref encoderSettings_c);
				View_startRecording(api.Session, filePath, viewer, encoderSettings_c);
				View.ViewInterface.View_EncoderSettings_free(ref encoderSettings_c);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_stopRecording(IntPtr _pxz_session_, Int32 viewer);

		/// <summary>
		/// stop recording video
		/// </summary>
		/// <param name="viewer">Viewer to use for recording video</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void StopRecording(System.Int32 viewer) {
			try {
				View_stopRecording(api.Session, viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region viewer matrices

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_fitCamera(IntPtr _pxz_session_, Geom.Point3_c direction, Int32 cameraType, System.Double fov, Int32 viewer, Scene.OccurrenceList_c fitToOccurrences);

		/// <summary>
		/// Set the viewer matrices to adjust the camera to the scene
		/// </summary>
		/// <param name="direction">Camera direction</param>
		/// <param name="cameraType">Camera type, Orthographic or Perspective</param>
		/// <param name="fov">Field of view (perspective mode only)</param>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		/// <param name="fitToOccurrences"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void FitCamera(Geom.Point3 direction, CameraType cameraType = (View.CameraType)1, System.Double fov = 90, System.Int32 viewer = -1, Scene.OccurrenceList fitToOccurrences = null) {
			fitToOccurrences = fitToOccurrences ?? new Scene.OccurrenceList(new System.UInt32[] {});
			try {
				var direction_c = new Geom.Point3_c();
				Geom.GeomInterface.ConvertValue((Geom.Point3)direction, ref direction_c);
				var fitToOccurrences_c = new Scene.OccurrenceList_c();
				Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)fitToOccurrences, ref fitToOccurrences_c);
				View_fitCamera(api.Session, direction_c, (int)cameraType, fov, viewer, fitToOccurrences_c);
				Geom.GeomInterface.Geom_Point3_free(ref direction_c);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref fitToOccurrences_c);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetViewerMatricesReturn_c View_getViewerMatrices(IntPtr _pxz_session_, Int32 viewer);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public View.GetViewerMatricesReturn GetViewerMatrices(System.Int32 viewer = -1) {
			try {
				var ret = View_getViewerMatrices(api.Session, viewer);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				View.GetViewerMatricesReturn retStruct = new View.GetViewerMatricesReturn();
				retStruct.views = ConvertValue(ref ret.views);
				Geom.GeomInterface.Geom_Matrix4List_free(ref ret.views);
				retStruct.projs = ConvertValue(ref ret.projs);
				Geom.GeomInterface.Geom_Matrix4List_free(ref ret.projs);
				retStruct.clipping = ConvertValue(ref ret.clipping);
				Geom.GeomInterface.Geom_Point2_free(ref ret.clipping);
				return retStruct;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_setViewerMatrices(IntPtr _pxz_session_, Geom.Matrix4List_c views, Geom.Matrix4List_c projs, Geom.Point2_c clipping, Int32 viewer);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="views"></param>
		/// <param name="projs"></param>
		/// <param name="clipping"></param>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetViewerMatrices(Geom.Matrix4List views, Geom.Matrix4List projs, Geom.Point2 clipping, System.Int32 viewer = -1) {
			try {
				var views_c = new Geom.Matrix4List_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4List)views, ref views_c);
				var projs_c = new Geom.Matrix4List_c();
				Geom.GeomInterface.ConvertValue((Geom.Matrix4List)projs, ref projs_c);
				var clipping_c = new Geom.Point2_c();
				Geom.GeomInterface.ConvertValue((Geom.Point2)clipping, ref clipping_c);
				View_setViewerMatrices(api.Session, views_c, projs_c, clipping_c, viewer);
				Geom.GeomInterface.Geom_Matrix4List_free(ref views_c);
				Geom.GeomInterface.Geom_Matrix4List_free(ref projs_c);
				Geom.GeomInterface.Geom_Point2_free(ref clipping_c);
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region visibility

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Scene.OccurrenceList_c View_visibilityShoot(IntPtr _pxz_session_, Int32 viewer, System.Byte parts, System.Byte patches, System.Byte polygons, System.Byte countOnce);

		/// <summary>
		/// Render one frame of the visibility session
		/// </summary>
		/// <param name="viewer">Viewer to use for the visibility shoot</param>
		/// <param name="parts">If false, optimize when parts seen are not wanted</param>
		/// <param name="patches">If false, optimize when patches seen are not wanted</param>
		/// <param name="polygons">If false, optimize when polygons seen are not wanted</param>
		/// <param name="countOnce">Optimize when it is not needed to count the numbers of pixels seen during the session</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Scene.OccurrenceList VisibilityShoot(System.Int32 viewer = -1, System.Boolean parts = true, System.Boolean patches = true, System.Boolean polygons = true, System.Boolean countOnce = false) {
			try {
				var ret = View_visibilityShoot(api.Session, viewer, Convert.ToByte(parts), Convert.ToByte(patches), Convert.ToByte(polygons), Convert.ToByte(countOnce));
				System.String err = ConvertValue(View_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Scene.SceneInterface.ConvertValue(ref ret);
				Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
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
