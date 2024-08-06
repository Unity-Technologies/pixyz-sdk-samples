#pragma warning disable CA2101

using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Pixyz.Unity {

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class PickResult
	{
		public PickResult() {}
		public PickResult(PickResult o) {
			this.occurrences = o.occurrences;
			this.positions = o.positions;
		}
		public Scene.OccurrenceList occurrences;
		public Geom.Point3List positions;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct PickResult_c
	{
		public Scene.OccurrenceList_c occurrences;
		public Geom.Point3List_c positions;
	}

}
