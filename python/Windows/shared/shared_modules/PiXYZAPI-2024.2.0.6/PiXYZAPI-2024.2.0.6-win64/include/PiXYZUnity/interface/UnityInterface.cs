#pragma warning disable CA2101

using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System;
using PiXYZAPI = UnityEngine.Pixyz.API.PiXYZAPI;

namespace UnityEngine.Pixyz.Unity {

	public class UnityInterface : API.Interface {

		#region Types Init/Free Methods

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Unity_PickResult_init(ref PickResult_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Unity_PickResult_free(ref PickResult_c str);

	internal static Scene.OccurrenceList ConvertValue(ref Scene.OccurrenceList_c s) {
		Scene.OccurrenceList list = new Scene.OccurrenceList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static Scene.OccurrenceList_c ConvertValue(Scene.OccurrenceList s, ref Scene.OccurrenceList_c list) {
		Scene.SceneInterface.Scene_OccurrenceList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
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

	internal static PickResult ConvertValue(ref PickResult_c s) {
		PickResult ss = new PickResult();
		ss.occurrences = Scene.SceneInterface.ConvertValue(ref s.occurrences);
		ss.positions = Geom.GeomInterface.ConvertValue(ref s.positions);
		return ss;
	}

	internal static PickResult_c ConvertValue(PickResult s, ref PickResult_c ss) {
		Unity.UnityInterface.Unity_PickResult_init(ref ss);
		Scene.SceneInterface.ConvertValue(s.occurrences, ref ss.occurrences);
		Geom.GeomInterface.ConvertValue(s.positions, ref ss.positions);
		return ss;
	}

		#endregion

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Unity_getLastError();

		public static string GetLastError()
		{
			return ConvertValue(Unity_getLastError());
		}

		#region 

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Unity_configureFunctionLogger(IntPtr _pxz_session_, string functionName, System.Byte enableFunction, System.Byte enableParameters, System.Byte enableExecutionTime);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="functionName"></param>
		/// <param name="enableFunction"></param>
		/// <param name="enableParameters"></param>
		/// <param name="enableExecutionTime"></param>
		public void ConfigureFunctionLogger(System.String functionName, System.Boolean enableFunction, System.Boolean enableParameters, System.Boolean enableExecutionTime) {
			Unity_configureFunctionLogger(api.Session, functionName, Convert.ToByte(enableFunction), Convert.ToByte(enableParameters), Convert.ToByte(enableExecutionTime));
			System.String err = ConvertValue(Unity_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region Direct3D

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Unity_getD3D11Device(IntPtr _pxz_session_);
		/// <summary>
		/// 
		/// </summary>
		public System.IntPtr GetD3D11Device() {
			var ret = Unity_getD3D11Device(api.Session);
			System.String err = ConvertValue(Unity_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.IntPtr)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Unity_getD3D11RenderTargetViewFromRenderBuffer(IntPtr _pxz_session_, System.IntPtr surface);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="surface"></param>
		public System.IntPtr GetD3D11RenderTargetViewFromRenderBuffer(System.IntPtr surface) {
			var ret = Unity_getD3D11RenderTargetViewFromRenderBuffer(api.Session, surface);
			System.String err = ConvertValue(Unity_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.IntPtr)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Unity_getD3D11ShaderResourceViewFromNativeTexture(IntPtr _pxz_session_, System.UInt32 texture);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="texture"></param>
		public System.IntPtr GetD3D11ShaderResourceViewFromNativeTexture(System.UInt32 texture) {
			var ret = Unity_getD3D11ShaderResourceViewFromNativeTexture(api.Session, texture);
			System.String err = ConvertValue(Unity_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.IntPtr)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Unity_getD3D11TextureFromNativeTexture(IntPtr _pxz_session_, System.UInt32 texture);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="texture"></param>
		public System.IntPtr GetD3D11TextureFromNativeTexture(System.UInt32 texture) {
			var ret = Unity_getD3D11TextureFromNativeTexture(api.Session, texture);
			System.String err = ConvertValue(Unity_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.IntPtr)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Unity_getD3D11TextureFromRenderBuffer(IntPtr _pxz_session_, System.IntPtr buffer);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="buffer"></param>
		public System.IntPtr GetD3D11TextureFromRenderBuffer(System.IntPtr buffer) {
			var ret = Unity_getD3D11TextureFromRenderBuffer(api.Session, buffer);
			System.String err = ConvertValue(Unity_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.IntPtr)ret;
		}

		#endregion

		#region Unity Pugin Event Functions

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Unity_getDestroyFunction(IntPtr _pxz_session_);
		/// <summary>
		/// 
		/// </summary>
		public System.IntPtr GetDestroyFunction() {
			var ret = Unity_getDestroyFunction(api.Session);
			System.String err = ConvertValue(Unity_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.IntPtr)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Unity_getDrawFunction(IntPtr _pxz_session_);
		/// <summary>
		/// 
		/// </summary>
		public System.IntPtr GetDrawFunction() {
			var ret = Unity_getDrawFunction(api.Session);
			System.String err = ConvertValue(Unity_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.IntPtr)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Unity_getInitFunction(IntPtr _pxz_session_);
		/// <summary>
		/// 
		/// </summary>
		public System.IntPtr GetInitFunction() {
			var ret = Unity_getInitFunction(api.Session);
			System.String err = ConvertValue(Unity_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.IntPtr)ret;
		}

		#endregion

		#region Unity View Session

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Unity_asyncPick(IntPtr _pxz_session_, System.UInt32 session, Int32 x, Int32 y);
		/// <summary>
		/// Asynchronous function to pick in the current viewer
		/// </summary>
		/// <param name="session"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public void AsyncPick(System.UInt32 session, System.Int32 x, System.Int32 y) {
			Unity_asyncPick(api.Session, session, x, y);
			System.String err = ConvertValue(Unity_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Unity_asyncResize(IntPtr _pxz_session_, System.UInt32 session, Int32 width, Int32 height);
		/// <summary>
		/// call this function when the texture has to be resized. the resize will take effect during the next render. This will send a ViewSessionResized event when done
		/// </summary>
		/// <param name="session"></param>
		/// <param name="width">Viewer width</param>
		/// <param name="height">Viewer height</param>
		public void AsyncResize(System.UInt32 session, System.Int32 width, System.Int32 height) {
			Unity_asyncResize(api.Session, session, width, height);
			System.String err = ConvertValue(Unity_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Unity_createUnityViewSession(IntPtr _pxz_session_, Int32 width, Int32 height, Int32 graphicAPI, Int32 nbViews);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="width">Viewer width</param>
		/// <param name="height">Viewer height</param>
		/// <param name="graphicAPI">Graphic api used by Unity</param>
		/// <param name="nbViews">Nb views</param>
		public System.UInt32 CreateUnityViewSession(System.Int32 width, System.Int32 height, View.GraphicAPI graphicAPI, System.Int32 nbViews = 1) {
			var ret = Unity_createUnityViewSession(api.Session, width, height, (int)graphicAPI, nbViews);
			System.String err = ConvertValue(Unity_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Int32 Unity_getUnityViewSessionViewer(IntPtr _pxz_session_, System.UInt32 session);
		/// <summary>
		/// Returns the underlying viewer of the given view session
		/// </summary>
		/// <param name="session"></param>
		public System.Int32 GetUnityViewSessionViewer(System.UInt32 session) {
			var ret = Unity_getUnityViewSessionViewer(api.Session, session);
			System.String err = ConvertValue(Unity_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Int32)ret;
		}

		private delegate void UnityViewSessionDestroyedDelegate(System.IntPtr userdata, System.UInt32 session);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Unity_addUnityViewSessionDestroyedCallback(IntPtr _pxz_session_, UnityViewSessionDestroyedDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Unity_removeUnityViewSessionDestroyedCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addUnityViewSessionDestroyedCallback(UnityViewSessionDestroyedDelegate callback, System.IntPtr userdata) {
			return Unity_addUnityViewSessionDestroyedCallback(api.Session, callback, userdata);
		}

		private void removeUnityViewSessionDestroyedCallback(System.UInt32 id) {
			Unity_removeUnityViewSessionDestroyedCallback(api.Session, id);
		}

		public class UnityViewSessionDestroyedTask : PixyzCallbackTask
		{
			public struct Params
			{
				public System.UInt32 session;

				public Params(System.UInt32 session)
				{
					this.session = session;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private UnityInterface iface;

				public Execution(UnityInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					UnityViewSessionDestroyedDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addUnityViewSessionDestroyedCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeUnityViewSessionDestroyedCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, System.UInt32 session)
				{
					try
					{
						_params.Enqueue(new Params(session));

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
		public Task<UnityViewSessionDestroyedTask.Params> WaitUnityViewSessionDestroyed(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new UnityViewSessionDestroyedTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnUnityViewSessionDestroyed(Action<UnityViewSessionDestroyedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			UnityViewSessionDestroyedTask.Execution task = new UnityViewSessionDestroyedTask.Execution(this, cancelSource);
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

		public void OnUnityViewSessionDestroyed(Action<UnityViewSessionDestroyedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnUnityViewSessionDestroyed(action, cancelSource);
		}
		private delegate void UnityViewSessionHasPickedDelegate(System.IntPtr userdata, PickResult_c result, System.UInt32 session);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Unity_addUnityViewSessionHasPickedCallback(IntPtr _pxz_session_, UnityViewSessionHasPickedDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Unity_removeUnityViewSessionHasPickedCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addUnityViewSessionHasPickedCallback(UnityViewSessionHasPickedDelegate callback, System.IntPtr userdata) {
			return Unity_addUnityViewSessionHasPickedCallback(api.Session, callback, userdata);
		}

		private void removeUnityViewSessionHasPickedCallback(System.UInt32 id) {
			Unity_removeUnityViewSessionHasPickedCallback(api.Session, id);
		}

		public class UnityViewSessionHasPickedTask : PixyzCallbackTask
		{
			public struct Params
			{
				public PickResult result;
				public System.UInt32 session;

				public Params(PickResult result, System.UInt32 session)
				{
					this.result = result;
					this.session = session;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private UnityInterface iface;

				public Execution(UnityInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					UnityViewSessionHasPickedDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addUnityViewSessionHasPickedCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeUnityViewSessionHasPickedCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, PickResult_c result, System.UInt32 session)
				{
					try
					{
						_params.Enqueue(new Params(ConvertValue(ref result), session));

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
		public Task<UnityViewSessionHasPickedTask.Params> WaitUnityViewSessionHasPicked(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new UnityViewSessionHasPickedTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnUnityViewSessionHasPicked(Action<UnityViewSessionHasPickedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			UnityViewSessionHasPickedTask.Execution task = new UnityViewSessionHasPickedTask.Execution(this, cancelSource);
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

		public void OnUnityViewSessionHasPicked(Action<UnityViewSessionHasPickedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnUnityViewSessionHasPicked(action, cancelSource);
		}
		private delegate void UnityViewSessionInitializedDelegate(System.IntPtr userdata, System.UInt32 session);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Unity_addUnityViewSessionInitializedCallback(IntPtr _pxz_session_, UnityViewSessionInitializedDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Unity_removeUnityViewSessionInitializedCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addUnityViewSessionInitializedCallback(UnityViewSessionInitializedDelegate callback, System.IntPtr userdata) {
			return Unity_addUnityViewSessionInitializedCallback(api.Session, callback, userdata);
		}

		private void removeUnityViewSessionInitializedCallback(System.UInt32 id) {
			Unity_removeUnityViewSessionInitializedCallback(api.Session, id);
		}

		public class UnityViewSessionInitializedTask : PixyzCallbackTask
		{
			public struct Params
			{
				public System.UInt32 session;

				public Params(System.UInt32 session)
				{
					this.session = session;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private UnityInterface iface;

				public Execution(UnityInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					UnityViewSessionInitializedDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addUnityViewSessionInitializedCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeUnityViewSessionInitializedCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, System.UInt32 session)
				{
					try
					{
						_params.Enqueue(new Params(session));

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
		public Task<UnityViewSessionInitializedTask.Params> WaitUnityViewSessionInitialized(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new UnityViewSessionInitializedTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnUnityViewSessionInitialized(Action<UnityViewSessionInitializedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			UnityViewSessionInitializedTask.Execution task = new UnityViewSessionInitializedTask.Execution(this, cancelSource);
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

		public void OnUnityViewSessionInitialized(Action<UnityViewSessionInitializedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnUnityViewSessionInitialized(action, cancelSource);
		}
		private delegate void UnityViewSessionResizedDelegate(System.IntPtr userdata, System.UInt32 session);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Unity_addUnityViewSessionResizedCallback(IntPtr _pxz_session_, UnityViewSessionResizedDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Unity_removeUnityViewSessionResizedCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addUnityViewSessionResizedCallback(UnityViewSessionResizedDelegate callback, System.IntPtr userdata) {
			return Unity_addUnityViewSessionResizedCallback(api.Session, callback, userdata);
		}

		private void removeUnityViewSessionResizedCallback(System.UInt32 id) {
			Unity_removeUnityViewSessionResizedCallback(api.Session, id);
		}

		public class UnityViewSessionResizedTask : PixyzCallbackTask
		{
			public struct Params
			{
				public System.UInt32 session;

				public Params(System.UInt32 session)
				{
					this.session = session;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private UnityInterface iface;

				public Execution(UnityInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					UnityViewSessionResizedDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addUnityViewSessionResizedCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeUnityViewSessionResizedCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, System.UInt32 session)
				{
					try
					{
						_params.Enqueue(new Params(session));

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
		public Task<UnityViewSessionResizedTask.Params> WaitUnityViewSessionResized(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new UnityViewSessionResizedTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnUnityViewSessionResized(Action<UnityViewSessionResizedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			UnityViewSessionResizedTask.Execution task = new UnityViewSessionResizedTask.Execution(this, cancelSource);
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

		public void OnUnityViewSessionResized(Action<UnityViewSessionResizedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnUnityViewSessionResized(action, cancelSource);
		}
		#endregion

		#region Vulkan

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Unity_getVulkanDevice(IntPtr _pxz_session_);
		/// <summary>
		/// 
		/// </summary>
		public System.IntPtr GetVulkanDevice() {
			var ret = Unity_getVulkanDevice(api.Session);
			System.String err = ConvertValue(Unity_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.IntPtr)ret;
		}

		#endregion

		private PiXYZAPI api;
		internal UnityInterface(PiXYZAPI api)
		{
			this.api = api;
		}

	}
}
