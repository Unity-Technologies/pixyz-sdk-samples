#pragma warning disable CA2101

#if UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN
#define PXZ_OS_WIN
#endif

#if UNITY_EDITOR_LINUX || UNITY_STANDALONE_LINUX
#define PXZ_OS_LINUX
#endif

#if UNITY_EDITOR_OSX || UNITY_STANDALONE_OSX
#define PXZ_OS_OSX
#endif

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnityEngine.Pixyz.API
{
	public class PiXYZAPI : Interface
	{
		[StructLayout(LayoutKind.Sequential)]
		private struct SessionList_c
		{
			public System.UInt64 size;
			public IntPtr ptr;
		}
		
#if PXZ_OS_LINUX || PXZ_OS_OSX
		internal const string PiXYZAPI_dll = "libPiXYZAPI";
		internal const string memcpy_dll = "libc.so.6";
#elif PXZ_OS_WIN
		internal const string PiXYZAPI_dll = "PiXYZAPI";
		internal const string memcpy_dll = "msvcrt.dll";
#else
		internal const string PiXYZAPI_dll = "undefined";
		internal const string memcpy_dll = "undefined";
#endif
		private IntPtr _session;
		private string _productName;
		private Core.CoreInterface _core;
		private Geom.GeomInterface _geom;
		private Material.MaterialInterface _material;
		private Polygonal.PolygonalInterface _polygonal;
		private CAD.CADInterface _CAD;
		private Algo.AlgoInterface _algo;
		private Scene.SceneInterface _scene;
		private View.ViewInterface _view;
		private IO.IOInterface _IO;
		private Unity.UnityInterface _unity;

		public IntPtr Session => _session;
		public string ProductName => _productName;
		public Core.CoreInterface Core => _core;
		public Geom.GeomInterface Geom => _geom;
		public Material.MaterialInterface Material => _material;
		public Polygonal.PolygonalInterface Polygonal => _polygonal;
		public CAD.CADInterface CAD => _CAD;
        public Algo.AlgoInterface Algo => _algo;
		public Scene.SceneInterface Scene => _scene;
		public View.ViewInterface View => _view;
		public IO.IOInterface IO => _IO;
		public Unity.UnityInterface Unity => _unity;

		[DllImport(PiXYZAPI_dll)]
		private static extern IntPtr API_getLastError();

		public static string GetLastError()
		{
			return ConvertValue(API_getLastError());
		}

		[DllImport(PiXYZAPI_dll)]
		private static extern IntPtr PiXYZ_API_Initialize(string productName, string validationKey, string license);

		/// <summary>
		/// Initialize Pixyz API and create a new session
		/// </summary>
		/// <param name="productName">Product name</param>
		/// <param name="validationKey">Product validation key</param>
		/// <param name="license">License file (content)</param>
		public static PiXYZAPI Initialize(String productName = "", String validationKey = "", String license = "")
		{
			IntPtr session = PiXYZ_API_Initialize(productName, validationKey, license);

			string err = GetLastError();
			if (!System.String.IsNullOrEmpty(err))
				throw new Exception(err);

			return new PiXYZAPI(session);
		}

		[DllImport(PiXYZAPI_dll)]
		private static extern void PiXYZ_API_Release(IntPtr session);

		/// <summary>
		/// Release Pixyz API and clear the session
		/// </summary>
		public void Release()
		{
			PiXYZ_API_Release(_session);
			string err = GetLastError();
			if (!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI_dll)]
		private static extern void SessionList_free(ref SessionList_c list);


		[DllImport(PiXYZAPI_dll)]
		private static extern SessionList_c PiXYZ_API_ActiveSessions();

		/// <summary>
		/// List all active sessions
		/// </summary>
		public static List<PiXYZAPI> ActiveSessions()
		{
			SessionList_c sessions = PiXYZ_API_ActiveSessions();

			string err = GetLastError();
			if (!System.String.IsNullOrEmpty(err))
				throw new Exception(err);

			//IntPtr[] sessionPtr = Interface.CopyMemory<IntPtr>(sessions.ptr, (int)sessions.size);

			List<PiXYZAPI> list = new List<PiXYZAPI>();
			IntPtr[] sessionPtr = new IntPtr[sessions.size];

			if (sessions.size > 0)
				Marshal.Copy(sessions.ptr, sessionPtr, 0, (int)sessions.size);

			for (int index = 0; index < sessionPtr.Length; ++index)
				list.Add(new PiXYZAPI(sessionPtr[index]));

			SessionList_free(ref sessions);

			return list;
		}

		public PiXYZAPI(IntPtr session)
		{
			_session = session;
			_core = new Pixyz.Core.CoreInterface(this);
			_geom = new Pixyz.Geom.GeomInterface(this);
			_material = new Pixyz.Material.MaterialInterface(this);
			_polygonal = new Pixyz.Polygonal.PolygonalInterface(this);
			_CAD = new Pixyz.CAD.CADInterface(this);
            _algo = new Pixyz.Algo.AlgoInterface(this);
			_scene = new Pixyz.Scene.SceneInterface(this);
			_view = new Pixyz.View.ViewInterface(this);
			_IO = new Pixyz.IO.IOInterface(this);
			_unity = new Pixyz.Unity.UnityInterface(this);
			_productName = _core.GetProductName();
		}
	}
}
