#pragma warning disable CA2101

using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System;
using PiXYZAPI = UnityEngine.Pixyz.API.PiXYZAPI;

namespace UnityEngine.Pixyz.Raytrace {

	public class RaytraceInterface : API.Interface {

		#region Types Init/Free Methods

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Raytrace_Camera_init(ref Camera_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Raytrace_Camera_free(ref Camera_c str);

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

	internal static Camera ConvertValue(ref Camera_c s) {
		Camera ss = new Camera();
		ss.position = Geom.GeomInterface.ConvertValue(ref s.position);
		ss.direction = Geom.GeomInterface.ConvertValue(ref s.direction);
		ss.up = Geom.GeomInterface.ConvertValue(ref s.up);
		ss.fov = (System.Double)s.fov;
		return ss;
	}

	internal static Camera_c ConvertValue(Camera s, ref Camera_c ss) {
		Raytrace.RaytraceInterface.Raytrace_Camera_init(ref ss);
		Geom.GeomInterface.ConvertValue(s.position, ref ss.position);
		Geom.GeomInterface.ConvertValue(s.direction, ref ss.direction);
		Geom.GeomInterface.ConvertValue(s.up, ref ss.up);
		ss.fov = (System.Double)s.fov;
		return ss;
	}

		#endregion

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Raytrace_getLastError();

		public static string GetLastError()
		{
			return ConvertValue(Raytrace_getLastError());
		}

		#region 

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Raytrace_configureFunctionLogger(IntPtr _pxz_session_, string functionName, System.Byte enableFunction, System.Byte enableParameters, System.Byte enableExecutionTime);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="functionName"></param>
		/// <param name="enableFunction"></param>
		/// <param name="enableParameters"></param>
		/// <param name="enableExecutionTime"></param>
		public void ConfigureFunctionLogger(System.String functionName, System.Boolean enableFunction, System.Boolean enableParameters, System.Boolean enableExecutionTime) {
			Raytrace_configureFunctionLogger(api.Session, functionName, Convert.ToByte(enableFunction), Convert.ToByte(enableParameters), Convert.ToByte(enableExecutionTime));
			System.String err = ConvertValue(Raytrace_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Raytrace_renderImage(IntPtr _pxz_session_, Int32 width, Int32 height, Camera_c camera, string outputImagePath);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <param name="camera"></param>
		/// <param name="outputImagePath"></param>
		public void RenderImage(System.Int32 width, System.Int32 height, Camera camera, System.String outputImagePath) {
			var camera_c = new Raytrace.Camera_c();
			ConvertValue((Raytrace.Camera)camera, ref camera_c);
			Raytrace_renderImage(api.Session, width, height, camera_c, outputImagePath);
			Raytrace.RaytraceInterface.Raytrace_Camera_free(ref camera_c);
			System.String err = ConvertValue(Raytrace_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		private PiXYZAPI api;
		internal RaytraceInterface(PiXYZAPI api)
		{
			this.api = api;
		}

	}
}
