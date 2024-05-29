#pragma warning disable CA2101

using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System;
using PiXYZAPI = UnityEngine.Pixyz.API.PiXYZAPI;

namespace UnityEngine.Pixyz.View {

	public class ViewInterface : API.Interface {

		#region Types Init/Free Methods

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_GraphicsContext_init(ref GraphicsContext_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_GraphicsContext_free(ref GraphicsContext_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_StreamedViewerInfo_init(ref StreamedViewerInfo_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_StreamedViewerInfo_free(ref StreamedViewerInfo_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_WebRTCInfo_init(ref WebRTCInfo_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_WebRTCInfo_free(ref WebRTCInfo_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_QP_init(ref QP_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_QP_free(ref QP_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_AnimationPlayerInfo_init(ref AnimationPlayerInfo_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_AnimationPlayerInfo_free(ref AnimationPlayerInfo_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_EncoderSettings_init(ref EncoderSettings_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void View_EncoderSettings_free(ref EncoderSettings_c str);

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
		public void ConfigureFunctionLogger(System.String functionName, System.Boolean enableFunction, System.Boolean enableParameters, System.Boolean enableExecutionTime) {
			View_configureFunctionLogger(api.Session, functionName, Convert.ToByte(enableFunction), Convert.ToByte(enableParameters), Convert.ToByte(enableExecutionTime));
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte View_suitableGPUAvailable(IntPtr _pxz_session_);
		/// <summary>
		/// returns true if a suitable device is found.
		/// </summary>
		public System.Boolean SuitableGPUAvailable() {
			var ret = View_suitableGPUAvailable(api.Session);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Boolean)(0 != ret);
		}

		private delegate void AfterFramebufferCreateDelegate(System.IntPtr userdata, System.Int32 viewer);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 View_addAfterFramebufferCreateCallback(IntPtr _pxz_session_, AfterFramebufferCreateDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_removeAfterFramebufferCreateCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addAfterFramebufferCreateCallback(AfterFramebufferCreateDelegate callback, System.IntPtr userdata) {
			return View_addAfterFramebufferCreateCallback(api.Session, callback, userdata);
		}

		private void removeAfterFramebufferCreateCallback(System.UInt32 id) {
			View_removeAfterFramebufferCreateCallback(api.Session, id);
		}

		public class AfterFramebufferCreateTask : PixyzCallbackTask
		{
			public struct Params
			{
				public System.Int32 viewer;

				public Params(System.Int32 viewer)
				{
					this.viewer = viewer;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private ViewInterface iface;

				public Execution(ViewInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					AfterFramebufferCreateDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addAfterFramebufferCreateCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeAfterFramebufferCreateCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, System.Int32 viewer)
				{
					try
					{
						_params.Enqueue(new Params(viewer));

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<AfterFramebufferCreateTask.Params> WaitAfterFramebufferCreate(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new AfterFramebufferCreateTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnAfterFramebufferCreate(Action<AfterFramebufferCreateTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			AfterFramebufferCreateTask.Execution task = new AfterFramebufferCreateTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnAfterFramebufferCreate(Action<AfterFramebufferCreateTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnAfterFramebufferCreate(action, cancelSource);
		}
		private delegate void AfterViewerPropertyChangedDelegate(System.IntPtr userdata, System.Int32 viewer, System.String property);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 View_addAfterViewerPropertyChangedCallback(IntPtr _pxz_session_, AfterViewerPropertyChangedDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_removeAfterViewerPropertyChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addAfterViewerPropertyChangedCallback(AfterViewerPropertyChangedDelegate callback, System.IntPtr userdata) {
			return View_addAfterViewerPropertyChangedCallback(api.Session, callback, userdata);
		}

		private void removeAfterViewerPropertyChangedCallback(System.UInt32 id) {
			View_removeAfterViewerPropertyChangedCallback(api.Session, id);
		}

		public class AfterViewerPropertyChangedTask : PixyzCallbackTask
		{
			public struct Params
			{
				public System.Int32 viewer;
				public System.String property;

				public Params(System.Int32 viewer, System.String property)
				{
					this.viewer = viewer;
					this.property = property;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private ViewInterface iface;

				public Execution(ViewInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					AfterViewerPropertyChangedDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addAfterViewerPropertyChangedCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeAfterViewerPropertyChangedCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, System.Int32 viewer, System.String property)
				{
					try
					{
						_params.Enqueue(new Params(viewer, property));

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<AfterViewerPropertyChangedTask.Params> WaitAfterViewerPropertyChanged(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new AfterViewerPropertyChangedTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnAfterViewerPropertyChanged(Action<AfterViewerPropertyChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			AfterViewerPropertyChangedTask.Execution task = new AfterViewerPropertyChangedTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnAfterViewerPropertyChanged(Action<AfterViewerPropertyChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnAfterViewerPropertyChanged(action, cancelSource);
		}
		private delegate void BeforeFramebufferDeleteDelegate(System.IntPtr userdata, System.Int32 viewer);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 View_addBeforeFramebufferDeleteCallback(IntPtr _pxz_session_, BeforeFramebufferDeleteDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_removeBeforeFramebufferDeleteCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addBeforeFramebufferDeleteCallback(BeforeFramebufferDeleteDelegate callback, System.IntPtr userdata) {
			return View_addBeforeFramebufferDeleteCallback(api.Session, callback, userdata);
		}

		private void removeBeforeFramebufferDeleteCallback(System.UInt32 id) {
			View_removeBeforeFramebufferDeleteCallback(api.Session, id);
		}

		public class BeforeFramebufferDeleteTask : PixyzCallbackTask
		{
			public struct Params
			{
				public System.Int32 viewer;

				public Params(System.Int32 viewer)
				{
					this.viewer = viewer;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private ViewInterface iface;

				public Execution(ViewInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					BeforeFramebufferDeleteDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addBeforeFramebufferDeleteCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeBeforeFramebufferDeleteCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, System.Int32 viewer)
				{
					try
					{
						_params.Enqueue(new Params(viewer));

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<BeforeFramebufferDeleteTask.Params> WaitBeforeFramebufferDelete(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new BeforeFramebufferDeleteTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnBeforeFramebufferDelete(Action<BeforeFramebufferDeleteTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			BeforeFramebufferDeleteTask.Execution task = new BeforeFramebufferDeleteTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnBeforeFramebufferDelete(Action<BeforeFramebufferDeleteTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnBeforeFramebufferDelete(action, cancelSource);
		}
		private delegate void BeforeViewerPropertyChangedDelegate(System.IntPtr userdata, System.Int32 viewer, System.String property);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 View_addBeforeViewerPropertyChangedCallback(IntPtr _pxz_session_, BeforeViewerPropertyChangedDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_removeBeforeViewerPropertyChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addBeforeViewerPropertyChangedCallback(BeforeViewerPropertyChangedDelegate callback, System.IntPtr userdata) {
			return View_addBeforeViewerPropertyChangedCallback(api.Session, callback, userdata);
		}

		private void removeBeforeViewerPropertyChangedCallback(System.UInt32 id) {
			View_removeBeforeViewerPropertyChangedCallback(api.Session, id);
		}

		public class BeforeViewerPropertyChangedTask : PixyzCallbackTask
		{
			public struct Params
			{
				public System.Int32 viewer;
				public System.String property;

				public Params(System.Int32 viewer, System.String property)
				{
					this.viewer = viewer;
					this.property = property;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private ViewInterface iface;

				public Execution(ViewInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					BeforeViewerPropertyChangedDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addBeforeViewerPropertyChangedCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeBeforeViewerPropertyChangedCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, System.Int32 viewer, System.String property)
				{
					try
					{
						_params.Enqueue(new Params(viewer, property));

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<BeforeViewerPropertyChangedTask.Params> WaitBeforeViewerPropertyChanged(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new BeforeViewerPropertyChangedTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnBeforeViewerPropertyChanged(Action<BeforeViewerPropertyChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			BeforeViewerPropertyChangedTask.Execution task = new BeforeViewerPropertyChangedTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnBeforeViewerPropertyChanged(Action<BeforeViewerPropertyChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnBeforeViewerPropertyChanged(action, cancelSource);
		}
		#endregion

		#region Animation Player

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_applyPlayingAnimations(IntPtr _pxz_session_, System.UInt64 time);
		/// <summary>
		/// apply the animations
		/// </summary>
		/// <param name="time">Current time</param>
		public void ApplyPlayingAnimations(System.UInt64 time) {
			View_applyPlayingAnimations(api.Session, time);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_debugAnimation(IntPtr _pxz_session_, System.UInt32 animation);
		/// <summary>
		/// jaaj
		/// </summary>
		/// <param name="animation">Animation to debug</param>
		public void DebugAnimation(System.UInt32 animation) {
			View_debugAnimation(api.Session, animation);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern AnimationPlayerInfo_c View_getAnimationPlayerInfo(IntPtr _pxz_session_, System.UInt32 animation);
		/// <summary>
		/// packs all AnimationPlayer-related info about an animation in an object
		/// </summary>
		/// <param name="animation">Animation to get info of</param>
		public AnimationPlayerInfo GetAnimationPlayerInfo(System.UInt32 animation) {
			var ret = View_getAnimationPlayerInfo(api.Session, animation);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			View.ViewInterface.View_AnimationPlayerInfo_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte View_isAnimationPlaying(IntPtr _pxz_session_, System.UInt32 animation);
		/// <summary>
		/// is this animation playing?
		/// </summary>
		/// <param name="animation">Animation to check</param>
		public System.Boolean IsAnimationPlaying(System.UInt32 animation) {
			var ret = View_isAnimationPlaying(api.Session, animation);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Boolean)(0 != ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_pauseAllAnimation(IntPtr _pxz_session_);
		/// <summary>
		/// pauses all animations
		/// </summary>
		public void PauseAllAnimation() {
			View_pauseAllAnimation(api.Session);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_pauseAnimation(IntPtr _pxz_session_, System.UInt32 animation);
		/// <summary>
		/// pauses an animation
		/// </summary>
		/// <param name="animation">Animation to pause</param>
		public void PauseAnimation(System.UInt32 animation) {
			View_pauseAnimation(api.Session, animation);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_playAnimation(IntPtr _pxz_session_, System.UInt32 animation, System.Double speed, System.Byte loop);
		/// <summary>
		/// plays an animation
		/// </summary>
		/// <param name="animation">Animation to play</param>
		/// <param name="speed">Speed</param>
		/// <param name="loop">Should the animation loop?</param>
		public void PlayAnimation(System.UInt32 animation, System.Double speed = 1, System.Boolean loop = false) {
			View_playAnimation(api.Session, animation, speed, Convert.ToByte(loop));
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_resumeAllAnimation(IntPtr _pxz_session_);
		/// <summary>
		/// resumes all animations
		/// </summary>
		public void ResumeAllAnimation() {
			View_resumeAllAnimation(api.Session);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_resumeAnimation(IntPtr _pxz_session_, System.UInt32 animation);
		/// <summary>
		/// resumes an animation
		/// </summary>
		/// <param name="animation">Animation to resume</param>
		public void ResumeAnimation(System.UInt32 animation) {
			View_resumeAnimation(api.Session, animation);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_setAnimationFrame(IntPtr _pxz_session_, System.UInt32 animation, System.UInt64 frame);
		/// <summary>
		/// set animation's current frame
		/// </summary>
		/// <param name="animation">Animation to set frame</param>
		/// <param name="frame">Frame to set</param>
		public void SetAnimationFrame(System.UInt32 animation, System.UInt64 frame) {
			View_setAnimationFrame(api.Session, animation, frame);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_setAnimationLoop(IntPtr _pxz_session_, System.UInt32 animation, System.Byte loop);
		/// <summary>
		/// set animation's looping status
		/// </summary>
		/// <param name="animation">Animation to set loop status</param>
		/// <param name="loop">Should the animation loop?</param>
		public void SetAnimationLoop(System.UInt32 animation, System.Boolean loop) {
			View_setAnimationLoop(api.Session, animation, Convert.ToByte(loop));
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_setAnimationSpeed(IntPtr _pxz_session_, System.UInt32 animation, System.Double speed);
		/// <summary>
		/// set animation's playing speed
		/// </summary>
		/// <param name="animation">Animation to set speed</param>
		/// <param name="speed">The speed</param>
		public void SetAnimationSpeed(System.UInt32 animation, System.Double speed) {
			View_setAnimationSpeed(api.Session, animation, speed);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_stopAllAnimation(IntPtr _pxz_session_, System.Byte applyDefault);
		/// <summary>
		/// stops all animations
		/// </summary>
		/// <param name="applyDefault">Should the default position be applied</param>
		public void StopAllAnimation(System.Boolean applyDefault = true) {
			View_stopAllAnimation(api.Session, Convert.ToByte(applyDefault));
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_stopAnimation(IntPtr _pxz_session_, System.UInt32 animation, System.Byte applyDefault);
		/// <summary>
		/// stops an animation
		/// </summary>
		/// <param name="animation">Animation to stop</param>
		/// <param name="applyDefault">Should the default position be applied</param>
		public void StopAnimation(System.UInt32 animation, System.Boolean applyDefault = true) {
			View_stopAnimation(api.Session, animation, Convert.ToByte(applyDefault));
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		private delegate void AnimationPausedOrStoppedDelegate(System.IntPtr userdata, System.UInt32 animation);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 View_addAnimationPausedOrStoppedCallback(IntPtr _pxz_session_, AnimationPausedOrStoppedDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_removeAnimationPausedOrStoppedCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addAnimationPausedOrStoppedCallback(AnimationPausedOrStoppedDelegate callback, System.IntPtr userdata) {
			return View_addAnimationPausedOrStoppedCallback(api.Session, callback, userdata);
		}

		private void removeAnimationPausedOrStoppedCallback(System.UInt32 id) {
			View_removeAnimationPausedOrStoppedCallback(api.Session, id);
		}

		public class AnimationPausedOrStoppedTask : PixyzCallbackTask
		{
			public struct Params
			{
				public System.UInt32 animation;

				public Params(System.UInt32 animation)
				{
					this.animation = animation;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private ViewInterface iface;

				public Execution(ViewInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					AnimationPausedOrStoppedDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addAnimationPausedOrStoppedCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeAnimationPausedOrStoppedCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, System.UInt32 animation)
				{
					try
					{
						_params.Enqueue(new Params(animation));

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<AnimationPausedOrStoppedTask.Params> WaitAnimationPausedOrStopped(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new AnimationPausedOrStoppedTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnAnimationPausedOrStopped(Action<AnimationPausedOrStoppedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			AnimationPausedOrStoppedTask.Execution task = new AnimationPausedOrStoppedTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnAnimationPausedOrStopped(Action<AnimationPausedOrStoppedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnAnimationPausedOrStopped(action, cancelSource);
		}
		private delegate void AnimationPlayedOrResumedDelegate(System.IntPtr userdata, System.UInt32 animation);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 View_addAnimationPlayedOrResumedCallback(IntPtr _pxz_session_, AnimationPlayedOrResumedDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_removeAnimationPlayedOrResumedCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addAnimationPlayedOrResumedCallback(AnimationPlayedOrResumedDelegate callback, System.IntPtr userdata) {
			return View_addAnimationPlayedOrResumedCallback(api.Session, callback, userdata);
		}

		private void removeAnimationPlayedOrResumedCallback(System.UInt32 id) {
			View_removeAnimationPlayedOrResumedCallback(api.Session, id);
		}

		public class AnimationPlayedOrResumedTask : PixyzCallbackTask
		{
			public struct Params
			{
				public System.UInt32 animation;

				public Params(System.UInt32 animation)
				{
					this.animation = animation;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private ViewInterface iface;

				public Execution(ViewInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					AnimationPlayedOrResumedDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addAnimationPlayedOrResumedCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeAnimationPlayedOrResumedCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, System.UInt32 animation)
				{
					try
					{
						_params.Enqueue(new Params(animation));

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<AnimationPlayedOrResumedTask.Params> WaitAnimationPlayedOrResumed(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new AnimationPlayedOrResumedTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnAnimationPlayedOrResumed(Action<AnimationPlayedOrResumedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			AnimationPlayedOrResumedTask.Execution task = new AnimationPlayedOrResumedTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnAnimationPlayedOrResumed(Action<AnimationPlayedOrResumedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnAnimationPlayedOrResumed(action, cancelSource);
		}
		private delegate void AnimationPlayingStatusChangedDelegate(System.IntPtr userdata, System.UInt32 animation, AnimationPlayerInfo_c playInfo);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 View_addAnimationPlayingStatusChangedCallback(IntPtr _pxz_session_, AnimationPlayingStatusChangedDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_removeAnimationPlayingStatusChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addAnimationPlayingStatusChangedCallback(AnimationPlayingStatusChangedDelegate callback, System.IntPtr userdata) {
			return View_addAnimationPlayingStatusChangedCallback(api.Session, callback, userdata);
		}

		private void removeAnimationPlayingStatusChangedCallback(System.UInt32 id) {
			View_removeAnimationPlayingStatusChangedCallback(api.Session, id);
		}

		public class AnimationPlayingStatusChangedTask : PixyzCallbackTask
		{
			public struct Params
			{
				public System.UInt32 animation;
				public AnimationPlayerInfo playInfo;

				public Params(System.UInt32 animation, AnimationPlayerInfo playInfo)
				{
					this.animation = animation;
					this.playInfo = playInfo;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private ViewInterface iface;

				public Execution(ViewInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					AnimationPlayingStatusChangedDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addAnimationPlayingStatusChangedCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeAnimationPlayingStatusChangedCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, System.UInt32 animation, AnimationPlayerInfo_c playInfo)
				{
					try
					{
						_params.Enqueue(new Params(animation, ConvertValue(ref playInfo)));

						if (_isContiniuous)
						{
							_isUpdated.Release();
						}
						else
						{
							DetachCallback();
							_isCompleted.Release();
						}
					}
					catch(System.Exception)
					{
							DetachCallback();
						_isCompleted.Release();
					}
				}
			}
		}
		public Task<AnimationPlayingStatusChangedTask.Params> WaitAnimationPlayingStatusChanged(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new AnimationPlayingStatusChangedTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnAnimationPlayingStatusChanged(Action<AnimationPlayingStatusChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			AnimationPlayingStatusChangedTask.Execution task = new AnimationPlayingStatusChangedTask.Execution(this, cancelSource);
			_ = task.RunContiniuous();
			while (!cancelSource.IsCancellationRequested)
			{
				var parameters = await task.WaitNewValue();
				if (cancelSource.IsCancellationRequested)
					break;
				try {
					action.Invoke(parameters);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					UnityEngine.Debug.LogError($"{e.Message}{e.StackTrace}");
#else
					Console.WriteLine($"{e.Message}{e.StackTrace}");
#endif
					throw e;
				}
				
			}
		}

		public void OnAnimationPlayingStatusChanged(Action<AnimationPlayingStatusChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnAnimationPlayingStatusChanged(action, cancelSource);
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
		public System.IntPtr GetD3D11Texture(RenderMap renderMap, System.Int32 viewer = -1) {
			var ret = View_getD3D11Texture(api.Session, (int)renderMap, viewer);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.IntPtr)ret;
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
		public System.Int32 GetGLTextureHandle(RenderMap renderMap, System.Int32 viewer = -1) {
			var ret = View_getGLTextureHandle(api.Session, (int)renderMap, viewer);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Int32)ret;
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
		public System.IntPtr GetVulkanTexture(RenderMap renderMap, System.Int32 viewer = -1) {
			var ret = View_getVulkanTexture(api.Session, (int)renderMap, viewer);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.IntPtr)ret;
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
		public System.Int32 CreateGPUScene(Scene.OccurrenceList roots, System.Boolean constructEdges = false) {
			var roots_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)roots, ref roots_c);
			var ret = View_createGPUScene(api.Session, roots_c, Convert.ToByte(constructEdges));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref roots_c);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Int32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_destroyGPUScene(IntPtr _pxz_session_, Int32 scene);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="scene">GPU Scene to destroy (previously created by createGPUScene)</param>
		public void DestroyGPUScene(System.Int32 scene) {
			View_destroyGPUScene(api.Session, scene);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Int32 View_getGlobalGPUScene(IntPtr _pxz_session_);
		/// <summary>
		/// Returns (and create if it does not exist) a global GPU scene (with the scene root) to be used commonly by several clients
		/// </summary>
		public System.Int32 GetGlobalGPUScene() {
			var ret = View_getGlobalGPUScene(api.Session);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Int32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 View_getOccurrenceIndex(IntPtr _pxz_session_, System.UInt32 occurrence, Int32 scene);
		/// <summary>
		/// Returns the occurrence index in the viewer buffers. Can be used for mapping an index retrieved in a GLTextureHandle id map.
		/// </summary>
		/// <param name="occurrence">Occurrence identifier</param>
		/// <param name="scene">Scene identifier</param>
		public System.UInt32 GetOccurrenceIndex(System.UInt32 occurrence, System.Int32 scene) {
			var ret = View_getOccurrenceIndex(api.Session, occurrence, scene);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 View_getSceneIndex(IntPtr _pxz_session_, Int32 scene, Int32 viewer);
		/// <summary>
		/// Returns the GPU scene index in the viewer buffers. Can be used for mapping an index retrieved in a GLTextureHandle id map.
		/// </summary>
		/// <param name="scene">GPU scene identifier</param>
		/// <param name="viewer">Viewer identifier</param>
		public System.UInt32 GetSceneIndex(System.Int32 scene, System.Int32 viewer) {
			var ret = View_getSceneIndex(api.Session, scene, viewer);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
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
		public void AddGPUScene(System.Int32 scene, System.Int32 viewer = -1) {
			View_addGPUScene(api.Session, scene, viewer);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_captureNextFrame(IntPtr _pxz_session_, Int32 viewer);
		/// <summary>
		/// Debug: capture next frame with renderdoc (only if launched with renderdoc)
		/// </summary>
		/// <param name="viewer">Viewer to capture</param>
		public void CaptureNextFrame(System.Int32 viewer) {
			View_captureNextFrame(api.Session, viewer);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
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
		public System.Int32 CreateViewer(System.Int32 width, System.Int32 height, GraphicsContext sharedContext = null, System.Int32 nbViews = 1) {
			sharedContext = sharedContext ?? new View.GraphicsContext() {};
			var sharedContext_c = new View.GraphicsContext_c();
			ConvertValue((View.GraphicsContext)sharedContext, ref sharedContext_c);
			var ret = View_createViewer(api.Session, width, height, sharedContext_c, nbViews);
			View.ViewInterface.View_GraphicsContext_free(ref sharedContext_c);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Int32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_destroyViewer(IntPtr _pxz_session_, Int32 viewer);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="viewer">Viewer to destroy</param>
		public void DestroyViewer(System.Int32 viewer) {
			View_destroyViewer(api.Session, viewer);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 View_drawCappingPlane(IntPtr _pxz_session_, System.UInt32 cuttingPlane);
		/// <summary>
		/// Create an occurrence that holds the mesh of the surfaces that have been cut by the cutting plane
		/// </summary>
		/// <param name="cuttingPlane">Cutting plane component for which we create the capping plane</param>
		public System.UInt32 DrawCappingPlane(System.UInt32 cuttingPlane) {
			var ret = View_drawCappingPlane(api.Session, cuttingPlane);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Geom.Point2_c View_getAutoClipping(IntPtr _pxz_session_, Int32 viewer, Geom.Point3_c cameraPos);
		/// <summary>
		/// Automatically compute the near and far planes depending on the scene
		/// </summary>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		/// <param name="cameraPos"></param>
		public Geom.Point2 GetAutoClipping(System.Int32 viewer, Geom.Point3 cameraPos) {
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

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr View_getViewerProperty(IntPtr _pxz_session_, string propertyName, Int32 viewer);
		/// <summary>
		/// Get a viewer property value
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		public System.String GetViewerProperty(System.String propertyName, System.Int32 viewer = -1) {
			var ret = View_getViewerProperty(api.Session, propertyName, viewer);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return ConvertValue(ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.PropertyInfo_c View_getViewerPropertyInfo(IntPtr _pxz_session_, string propertyName, Int32 viewer);
		/// <summary>
		/// Get a viewer property info
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		public Core.PropertyInfo GetViewerPropertyInfo(System.String propertyName, System.Int32 viewer = -1) {
			var ret = View_getViewerPropertyInfo(api.Session, propertyName, viewer);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Core.CoreInterface.ConvertValue(ref ret);
			Core.CoreInterface.Core_PropertyInfo_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetViewerSizeReturn_c View_getViewerSize(IntPtr _pxz_session_, Int32 viewer);
		/// <summary>
		/// Retrieve the viewport size of a viewer
		/// </summary>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		public View.GetViewerSizeReturn GetViewerSize(System.Int32 viewer = -1) {
			var ret = View_getViewerSize(api.Session, viewer);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			View.GetViewerSizeReturn retStruct = new View.GetViewerSizeReturn();
			retStruct.width = (System.Int32)ret.width;
			retStruct.height = (System.Int32)ret.height;
			return retStruct;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetViewerStatsReturn_c View_getViewerStats(IntPtr _pxz_session_, Int32 viewer);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		public View.GetViewerStatsReturn GetViewerStats(System.Int32 viewer = -1) {
			var ret = View_getViewerStats(api.Session, viewer);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			View.GetViewerStatsReturn retStruct = new View.GetViewerStatsReturn();
			retStruct.renderedOccurrences = (System.Int32)ret.renderedOccurrences;
			retStruct.renderedTriangles = (System.Int32)ret.renderedTriangles;
			return retStruct;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.PropertyInfoList_c View_listViewerProperties(IntPtr _pxz_session_, Int32 viewer);
		/// <summary>
		/// Get the list of viewer properties
		/// </summary>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		public Core.PropertyInfoList ListViewerProperties(System.Int32 viewer = -1) {
			var ret = View_listViewerProperties(api.Session, viewer);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Core.CoreInterface.ConvertValue(ref ret);
			Core.CoreInterface.Core_PropertyInfoList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern PickReturn_c View_pick(IntPtr _pxz_session_, Int32 x, Int32 y, Int32 viewer);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="viewer"></param>
		public View.PickReturn Pick(System.Int32 x, System.Int32 y, System.Int32 viewer = -1) {
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
		public Scene.OccurrenceList PickRectangle(System.Int32 xMin, System.Int32 xMax, System.Int32 yMin, System.Int32 yMax, System.Int32 viewer = -1, System.Boolean inDepth = false) {
			var ret = View_pickRectangle(api.Session, xMin, xMax, yMin, yMax, viewer, Convert.ToByte(inDepth));
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Scene.SceneInterface.ConvertValue(ref ret);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_refreshViewer(IntPtr _pxz_session_, Int32 viewer, Int32 frameCount, System.Byte forceUpdate);
		/// <summary>
		/// Refresh the viewer
		/// </summary>
		/// <param name="viewer">Viewer to refresh</param>
		/// <param name="frameCount">Number of frames to render</param>
		/// <param name="forceUpdate">Force the viewer to update pending modification on the geometry. By default this is disabled while running process</param>
		public void RefreshViewer(System.Int32 viewer = -1, System.Int32 frameCount = 1, System.Boolean forceUpdate = false) {
			View_refreshViewer(api.Session, viewer, frameCount, Convert.ToByte(forceUpdate));
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_removeGPUScene(IntPtr _pxz_session_, Int32 scene, Int32 viewer);
		/// <summary>
		/// Remove a viewer root
		/// </summary>
		/// <param name="scene">GPU Scene to remove from the viewer</param>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		public void RemoveGPUScene(System.Int32 scene, System.Int32 viewer = -1) {
			View_removeGPUScene(api.Session, scene, viewer);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_resizeViewer(IntPtr _pxz_session_, Int32 width, Int32 height, Int32 viewer);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="width">Width of the viewer framebuffer</param>
		/// <param name="height">Height of the viewer framebuffer</param>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		public void ResizeViewer(System.Int32 width, System.Int32 height, System.Int32 viewer = -1) {
			View_resizeViewer(api.Session, width, height, viewer);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
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
		public void SelectPrimitives(System.Int32 xMin, System.Int32 xMax, System.Int32 yMin, System.Int32 yMax, PrimitiveSelectionType primitiveType, System.Int32 viewer = -1) {
			View_selectPrimitives(api.Session, xMin, xMax, yMin, yMax, (int)primitiveType, viewer);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_setDefaultViewerId(IntPtr _pxz_session_, Int32 viewer);
		/// <summary>
		/// Set default viewer id. This viewer will be used in other functions taking a Viewer as a parameter. Usefull if a viewer needs to be shared across different contexts.
		/// </summary>
		/// <param name="viewer"></param>
		public void SetDefaultViewerId(System.Int32 viewer) {
			View_setDefaultViewerId(api.Session, viewer);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_setViewerProperty(IntPtr _pxz_session_, string propertyName, string propertyValue, Int32 viewer);
		/// <summary>
		/// Set a viewer property value
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="propertyValue"></param>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		public void SetViewerProperty(System.String propertyName, System.String propertyValue, System.Int32 viewer = -1) {
			View_setViewerProperty(api.Session, propertyName, propertyValue, viewer);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region raw images

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Material.ImageDefinition_c View_getCompositedImage(IntPtr _pxz_session_, Int32 viewer);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="viewer"></param>
		public Material.ImageDefinition GetCompositedImage(System.Int32 viewer) {
			var ret = View_getCompositedImage(api.Session, viewer);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Material.MaterialInterface.ConvertValue(ref ret);
			Material.MaterialInterface.Material_ImageDefinition_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Material.ImageDefinition_c View_getRenderMapImage(IntPtr _pxz_session_, Int32 viewer, Int32 renderMap);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="viewer"></param>
		/// <param name="renderMap"></param>
		public Material.ImageDefinition GetRenderMapImage(System.Int32 viewer, RenderMap renderMap) {
			var ret = View_getRenderMapImage(api.Session, viewer, (int)renderMap);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Material.MaterialInterface.ConvertValue(ref ret);
			Material.MaterialInterface.Material_ImageDefinition_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_takeScreenshot(IntPtr _pxz_session_, string fileName, Int32 viewer);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="fileName">Path where to save the screenshot</param>
		/// <param name="viewer"></param>
		public void TakeScreenshot(System.String fileName, System.Int32 viewer) {
			View_takeScreenshot(api.Session, fileName, viewer);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
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
		public StreamedViewerInfo CreateStreamedViewer(System.Int32 width, System.Int32 height, EncoderSettings encoderSettings = null, System.Boolean useWebRTC = false, WebRTCInfo? webRTCInfo = null) {
			encoderSettings = encoderSettings ?? new View.EncoderSettings() {};
			webRTCInfo = webRTCInfo ?? new View.WebRTCInfo() {};
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

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_resizeStreamedViewer(IntPtr _pxz_session_, Int32 width, Int32 height, Int32 viewer, EncoderSettings_c encoderSettings);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="width">Width of the viewer framebuffer</param>
		/// <param name="height">Height of the viewer framebuffer</param>
		/// <param name="viewer"></param>
		/// <param name="encoderSettings">Settings used for the encoder</param>
		public void ResizeStreamedViewer(System.Int32 width, System.Int32 height, System.Int32 viewer = -1, EncoderSettings encoderSettings = null) {
			encoderSettings = encoderSettings ?? new View.EncoderSettings() {};
			var encoderSettings_c = new View.EncoderSettings_c();
			ConvertValue((View.EncoderSettings)encoderSettings, ref encoderSettings_c);
			View_resizeStreamedViewer(api.Session, width, height, viewer, encoderSettings_c);
			View.ViewInterface.View_EncoderSettings_free(ref encoderSettings_c);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_startRecording(IntPtr _pxz_session_, string filePath, Int32 viewer, EncoderSettings_c encoderSettings);
		/// <summary>
		/// record viewer in a file
		/// </summary>
		/// <param name="filePath">File in which video while be saved</param>
		/// <param name="viewer">Viewer to use for recording video</param>
		/// <param name="encoderSettings">Settings used for the encoder</param>
		public void StartRecording(System.String filePath, System.Int32 viewer, EncoderSettings encoderSettings = null) {
			encoderSettings = encoderSettings ?? new View.EncoderSettings() {};
			var encoderSettings_c = new View.EncoderSettings_c();
			ConvertValue((View.EncoderSettings)encoderSettings, ref encoderSettings_c);
			View_startRecording(api.Session, filePath, viewer, encoderSettings_c);
			View.ViewInterface.View_EncoderSettings_free(ref encoderSettings_c);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_stopRecording(IntPtr _pxz_session_, Int32 viewer);
		/// <summary>
		/// stop recording video
		/// </summary>
		/// <param name="viewer">Viewer to use for recording video</param>
		public void StopRecording(System.Int32 viewer) {
			View_stopRecording(api.Session, viewer);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region viewer matrices

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_fitCamera(IntPtr _pxz_session_, Geom.Point3_c direction, Int32 cameraType, System.Double fov, Int32 viewer, System.UInt32 fitToOccurrence);
		/// <summary>
		/// Set the viewer matrices to adjust the camera to the scene
		/// </summary>
		/// <param name="direction">Camera direction</param>
		/// <param name="cameraType">Camera type, Orthographic or Perspective</param>
		/// <param name="fov">Field of view (perspective mode only)</param>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		/// <param name="fitToOccurrence"></param>
		public void FitCamera(Geom.Point3 direction, CameraType cameraType, System.Double fov, System.Int32 viewer = -1, System.UInt32 fitToOccurrence = 0) {
			var direction_c = new Geom.Point3_c();
			Geom.GeomInterface.ConvertValue((Geom.Point3)direction, ref direction_c);
			View_fitCamera(api.Session, direction_c, (int)cameraType, fov, viewer, fitToOccurrence);
			Geom.GeomInterface.Geom_Point3_free(ref direction_c);
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetViewerMatricesReturn_c View_getViewerMatrices(IntPtr _pxz_session_, Int32 viewer);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		public View.GetViewerMatricesReturn GetViewerMatrices(System.Int32 viewer = -1) {
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

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void View_setViewerMatrices(IntPtr _pxz_session_, Geom.Matrix4List_c views, Geom.Matrix4List_c projs, Geom.Point2_c clipping, Int32 viewer);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="views"></param>
		/// <param name="projs"></param>
		/// <param name="clipping"></param>
		/// <param name="viewer">Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).</param>
		public void SetViewerMatrices(Geom.Matrix4List views, Geom.Matrix4List projs, Geom.Point2 clipping, System.Int32 viewer = -1) {
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
		public Scene.OccurrenceList VisibilityShoot(System.Int32 viewer = -1, System.Boolean parts = true, System.Boolean patches = true, System.Boolean polygons = true, System.Boolean countOnce = false) {
			var ret = View_visibilityShoot(api.Session, viewer, Convert.ToByte(parts), Convert.ToByte(patches), Convert.ToByte(polygons), Convert.ToByte(countOnce));
			System.String err = ConvertValue(View_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Scene.SceneInterface.ConvertValue(ref ret);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
			return convRet;
		}

		#endregion

		private PiXYZAPI api;
		internal ViewInterface(PiXYZAPI api)
		{
			this.api = api;
		}

	}
}
