#pragma warning disable CA2101

using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Pixyz.Raytrace {

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Camera
	{
		public Camera() {}
		public Camera(Camera o) {
			this.position = o.position;
			this.direction = o.direction;
			this.up = o.up;
			this.fov = o.fov;
		}
		public Geom.Point3 position;
		public Geom.Point3 direction;
		public Geom.Point3 up;
		public System.Double fov;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Camera_c
	{
		public Geom.Point3_c position;
		public Geom.Point3_c direction;
		public Geom.Point3_c up;
		public System.Double fov;
	}

}
