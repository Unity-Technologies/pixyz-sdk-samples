#pragma warning disable CA2101

using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;
using PiXYZAPI = UnityEngine.Pixyz.API.PiXYZAPI;

namespace UnityEngine.Pixyz.Unity {

	public class UnityInterface : API.Interface {

		private PiXYZAPI api;
		internal UnityInterface(PiXYZAPI api)
		{
			this.api = api;
		}

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
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ConfigureFunctionLogger(System.String functionName, System.Boolean enableFunction, System.Boolean enableParameters, System.Boolean enableExecutionTime) {
			try {
				Unity_configureFunctionLogger(api.Session, functionName, Convert.ToByte(enableFunction), Convert.ToByte(enableParameters), Convert.ToByte(enableExecutionTime));
				System.String err = ConvertValue(Unity_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region Direct3D

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Unity_getD3D11Device(IntPtr _pxz_session_);

		/// <summary>
		/// 
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.IntPtr GetD3D11Device() {
			try {
				var ret = Unity_getD3D11Device(api.Session);
				System.String err = ConvertValue(Unity_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.IntPtr)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Unity_getD3D11RenderTargetViewFromRenderBuffer(IntPtr _pxz_session_, System.IntPtr surface);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="surface"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.IntPtr GetD3D11RenderTargetViewFromRenderBuffer(System.IntPtr surface) {
			try {
				var ret = Unity_getD3D11RenderTargetViewFromRenderBuffer(api.Session, surface);
				System.String err = ConvertValue(Unity_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.IntPtr)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Unity_getD3D11ShaderResourceViewFromNativeTexture(IntPtr _pxz_session_, System.UInt32 texture);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="texture"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.IntPtr GetD3D11ShaderResourceViewFromNativeTexture(System.UInt32 texture) {
			try {
				var ret = Unity_getD3D11ShaderResourceViewFromNativeTexture(api.Session, texture);
				System.String err = ConvertValue(Unity_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.IntPtr)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Unity_getD3D11TextureFromNativeTexture(IntPtr _pxz_session_, System.UInt32 texture);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="texture"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.IntPtr GetD3D11TextureFromNativeTexture(System.UInt32 texture) {
			try {
				var ret = Unity_getD3D11TextureFromNativeTexture(api.Session, texture);
				System.String err = ConvertValue(Unity_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.IntPtr)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Unity_getD3D11TextureFromRenderBuffer(IntPtr _pxz_session_, System.IntPtr buffer);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="buffer"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.IntPtr GetD3D11TextureFromRenderBuffer(System.IntPtr buffer) {
			try {
				var ret = Unity_getD3D11TextureFromRenderBuffer(api.Session, buffer);
				System.String err = ConvertValue(Unity_getLastError());
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

		#region Unity Pugin Event Functions

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Unity_getDestroyFunction(IntPtr _pxz_session_);

		/// <summary>
		/// 
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.IntPtr GetDestroyFunction() {
			try {
				var ret = Unity_getDestroyFunction(api.Session);
				System.String err = ConvertValue(Unity_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.IntPtr)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Unity_getDrawFunction(IntPtr _pxz_session_);

		/// <summary>
		/// 
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.IntPtr GetDrawFunction() {
			try {
				var ret = Unity_getDrawFunction(api.Session);
				System.String err = ConvertValue(Unity_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.IntPtr)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Unity_getInitFunction(IntPtr _pxz_session_);

		/// <summary>
		/// 
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.IntPtr GetInitFunction() {
			try {
				var ret = Unity_getInitFunction(api.Session);
				System.String err = ConvertValue(Unity_getLastError());
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

		#region Unity View Session

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Unity_asyncPick(IntPtr _pxz_session_, System.UInt32 session, Int32 x, Int32 y);

		/// <summary>
		/// Asynchronous function to pick in the current viewer
		/// </summary>
		/// <param name="session"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AsyncPick(System.UInt32 session, System.Int32 x, System.Int32 y) {
			try {
				Unity_asyncPick(api.Session, session, x, y);
				System.String err = ConvertValue(Unity_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Unity_asyncResize(IntPtr _pxz_session_, System.UInt32 session, Int32 width, Int32 height);

		/// <summary>
		/// call this function when the texture has to be resized. the resize will take effect during the next render. This will send a ViewSessionResized event when done
		/// </summary>
		/// <param name="session"></param>
		/// <param name="width">Viewer width</param>
		/// <param name="height">Viewer height</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AsyncResize(System.UInt32 session, System.Int32 width, System.Int32 height) {
			try {
				Unity_asyncResize(api.Session, session, width, height);
				System.String err = ConvertValue(Unity_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
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
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 CreateUnityViewSession(System.Int32 width, System.Int32 height, View.GraphicAPI graphicAPI, System.Int32 nbViews = 1) {
			try {
				var ret = Unity_createUnityViewSession(api.Session, width, height, (int)graphicAPI, nbViews);
				System.String err = ConvertValue(Unity_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.UInt32)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		private delegate void UnityViewSessionDestroyedDelegate_c(IntPtr userData, System.UInt32 session);
		private static Dictionary<uint, UnityViewSessionDestroyedDelegate_c> m_UnityViewSessionDestroyedCallbacks = new Dictionary<uint, UnityViewSessionDestroyedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Unity_addUnityViewSessionDestroyedCallback(IntPtr _pxz_session_, UnityViewSessionDestroyedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Unity_removeUnityViewSessionDestroyedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void UnityViewSessionDestroyedDelegate(IntPtr userData, System.UInt32 session);

		public System.UInt32 AddUnityViewSessionDestroyedCallback(UnityViewSessionDestroyedDelegate callback, IntPtr userData) {
			UnityViewSessionDestroyedDelegate_c c = new UnityViewSessionDestroyedDelegate_c((System.IntPtr _pxz_session_, System.UInt32 session) =>
			{
				var session_cs = (System.UInt32)(session);
				System.String err = ConvertValue(Unity_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, session_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Unity_addUnityViewSessionDestroyedCallback(api.Session, c, userData);
			m_UnityViewSessionDestroyedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveUnityViewSessionDestroyedCallback(System.UInt32 id) {
			Unity_removeUnityViewSessionDestroyedCallback(api.Session, id);
			m_UnityViewSessionDestroyedCallbacks.Remove(id);
		}

		private delegate void UnityViewSessionHasPickedDelegate_c(IntPtr userData, PickResult_c result, System.UInt32 session);
		private static Dictionary<uint, UnityViewSessionHasPickedDelegate_c> m_UnityViewSessionHasPickedCallbacks = new Dictionary<uint, UnityViewSessionHasPickedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Unity_addUnityViewSessionHasPickedCallback(IntPtr _pxz_session_, UnityViewSessionHasPickedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Unity_removeUnityViewSessionHasPickedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void UnityViewSessionHasPickedDelegate(IntPtr userData, PickResult result, System.UInt32 session);

		public System.UInt32 AddUnityViewSessionHasPickedCallback(UnityViewSessionHasPickedDelegate callback, IntPtr userData) {
			UnityViewSessionHasPickedDelegate_c c = new UnityViewSessionHasPickedDelegate_c((System.IntPtr _pxz_session_, PickResult_c result, System.UInt32 session) =>
			{
				var result_cs = Unity.UnityInterface.ConvertValue(ref result);
				Unity.UnityInterface.Unity_PickResult_free(ref result);
				var session_cs = (System.UInt32)(session);
				System.String err = ConvertValue(Unity_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, result_cs, session_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Unity_addUnityViewSessionHasPickedCallback(api.Session, c, userData);
			m_UnityViewSessionHasPickedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveUnityViewSessionHasPickedCallback(System.UInt32 id) {
			Unity_removeUnityViewSessionHasPickedCallback(api.Session, id);
			m_UnityViewSessionHasPickedCallbacks.Remove(id);
		}

		private delegate void UnityViewSessionInitializedDelegate_c(IntPtr userData, System.UInt32 session, System.Int32 viewer, System.Int32 gpuScene);
		private static Dictionary<uint, UnityViewSessionInitializedDelegate_c> m_UnityViewSessionInitializedCallbacks = new Dictionary<uint, UnityViewSessionInitializedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Unity_addUnityViewSessionInitializedCallback(IntPtr _pxz_session_, UnityViewSessionInitializedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Unity_removeUnityViewSessionInitializedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void UnityViewSessionInitializedDelegate(IntPtr userData, System.UInt32 session, System.Int32 viewer, System.Int32 gpuScene);

		public System.UInt32 AddUnityViewSessionInitializedCallback(UnityViewSessionInitializedDelegate callback, IntPtr userData) {
			UnityViewSessionInitializedDelegate_c c = new UnityViewSessionInitializedDelegate_c((System.IntPtr _pxz_session_, System.UInt32 session, System.Int32 viewer, System.Int32 gpuScene) =>
			{
				var session_cs = (System.UInt32)(session);
				var viewer_cs = (System.Int32)(viewer);
				var gpuScene_cs = (System.Int32)(gpuScene);
				System.String err = ConvertValue(Unity_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, session_cs, viewer_cs, gpuScene_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Unity_addUnityViewSessionInitializedCallback(api.Session, c, userData);
			m_UnityViewSessionInitializedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveUnityViewSessionInitializedCallback(System.UInt32 id) {
			Unity_removeUnityViewSessionInitializedCallback(api.Session, id);
			m_UnityViewSessionInitializedCallbacks.Remove(id);
		}

		private delegate void UnityViewSessionResizedDelegate_c(IntPtr userData, System.UInt32 session);
		private static Dictionary<uint, UnityViewSessionResizedDelegate_c> m_UnityViewSessionResizedCallbacks = new Dictionary<uint, UnityViewSessionResizedDelegate_c>();

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Unity_addUnityViewSessionResizedCallback(IntPtr _pxz_session_, UnityViewSessionResizedDelegate_c callback, System.IntPtr userData);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Unity_removeUnityViewSessionResizedCallback(IntPtr _pxz_session_, System.UInt32 id);

		public delegate void UnityViewSessionResizedDelegate(IntPtr userData, System.UInt32 session);

		public System.UInt32 AddUnityViewSessionResizedCallback(UnityViewSessionResizedDelegate callback, IntPtr userData) {
			UnityViewSessionResizedDelegate_c c = new UnityViewSessionResizedDelegate_c((System.IntPtr _pxz_session_, System.UInt32 session) =>
			{
				var session_cs = (System.UInt32)(session);
				System.String err = ConvertValue(Unity_getLastError());
				if(!System.String.IsNullOrEmpty(err))

					throw new Exception(err);
				try {
					callback?.Invoke(userData, session_cs);
				} catch (Exception e) {
#if UNITY_EDITOR || UNITY_ENGINE
					Debug.LogError($"{e.Message}: {e.StackTrace}");
#else
					Console.WriteLine(e.Message);
#endif
					throw e;
				}
			});
			uint id = Unity_addUnityViewSessionResizedCallback(api.Session, c, userData);
			m_UnityViewSessionResizedCallbacks.Add(id, c);
			return id;
		}

		public void RemoveUnityViewSessionResizedCallback(System.UInt32 id) {
			Unity_removeUnityViewSessionResizedCallback(api.Session, id);
			m_UnityViewSessionResizedCallbacks.Remove(id);
		}

		#endregion

		#region Vulkan

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Unity_getVulkanDevice(IntPtr _pxz_session_);

		/// <summary>
		/// 
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.IntPtr GetVulkanDevice() {
			try {
				var ret = Unity_getVulkanDevice(api.Session);
				System.String err = ConvertValue(Unity_getLastError());
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

	}
}
