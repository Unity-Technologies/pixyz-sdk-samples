#pragma warning disable CA2101

using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System;
using PiXYZAPI = UnityEngine.Pixyz.API.PiXYZAPI;

namespace UnityEngine.Pixyz.Algo {

	public class AlgoInterface : API.Interface {

		#region Types Init/Free Methods

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_MapTypeList_init(ref MapTypeList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_MapTypeList_free(ref MapTypeList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_UseColorOption_init(ref UseColorOption_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_UseColorOption_free(ref UseColorOption_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_BoxParameters_init(ref BoxParameters_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_BoxParameters_free(ref BoxParameters_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_SphereParameters_init(ref SphereParameters_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_SphereParameters_free(ref SphereParameters_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_FeatureInput_init(ref FeatureInput_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_FeatureInput_free(ref FeatureInput_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_FeatureInputList_init(ref FeatureInputList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_FeatureInputList_free(ref FeatureInputList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_Feature_init(ref Feature_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_Feature_free(ref Feature_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_LegoReturn_init(ref LegoReturn_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_LegoReturn_free(ref LegoReturn_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_CustomBakeMap_init(ref CustomBakeMap_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_CustomBakeMap_free(ref CustomBakeMap_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_CustomBakeMapList_init(ref CustomBakeMapList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_CustomBakeMapList_free(ref CustomBakeMapList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_PlaneParameters_init(ref PlaneParameters_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_PlaneParameters_free(ref PlaneParameters_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_CylinderParameters_init(ref CylinderParameters_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_CylinderParameters_free(ref CylinderParameters_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_ConeParameters_init(ref ConeParameters_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_ConeParameters_free(ref ConeParameters_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_CapsuleParameters_init(ref CapsuleParameters_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_CapsuleParameters_free(ref CapsuleParameters_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_PrimitiveShapeParameters_init(ref PrimitiveShapeParameters_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_PrimitiveShapeParameters_free(ref PrimitiveShapeParameters_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_DecimateOptionsSelector_init(ref DecimateOptionsSelector_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_DecimateOptionsSelector_free(ref DecimateOptionsSelector_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_getPixelValueList_init(ref getPixelValueList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_getPixelValueList_free(ref getPixelValueList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_ReplaceByOccurrenceOptions_init(ref ReplaceByOccurrenceOptions_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_ReplaceByOccurrenceOptions_free(ref ReplaceByOccurrenceOptions_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_FeatureList_init(ref FeatureList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_FeatureList_free(ref FeatureList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_ReplaceByPrimitiveOptions_init(ref ReplaceByPrimitiveOptions_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_ReplaceByPrimitiveOptions_free(ref ReplaceByPrimitiveOptions_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_ReplaceByOption_init(ref ReplaceByOption_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_ReplaceByOption_free(ref ReplaceByOption_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_HexahedronParameters_init(ref HexahedronParameters_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_HexahedronParameters_free(ref HexahedronParameters_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_Box_init(ref Box_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_Box_free(ref Box_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_BakeMap_init(ref BakeMap_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_BakeMap_free(ref BakeMap_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_BakeMapList_init(ref BakeMapList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_BakeMapList_free(ref BakeMapList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_OccurrenceFeatures_init(ref OccurrenceFeatures_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_OccurrenceFeatures_free(ref OccurrenceFeatures_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_OccurrenceFeaturesList_init(ref OccurrenceFeaturesList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_OccurrenceFeaturesList_free(ref OccurrenceFeaturesList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_Cylinder_init(ref Cylinder_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_Cylinder_free(ref Cylinder_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_BakeMaps_init(ref BakeMaps_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_BakeMaps_free(ref BakeMaps_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_Sphere_init(ref Sphere_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_Sphere_free(ref Sphere_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_OctahedralImpostor_init(ref OctahedralImpostor_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_OctahedralImpostor_free(ref OctahedralImpostor_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_BakeOption_init(ref BakeOption_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_BakeOption_free(ref BakeOption_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_Plane_init(ref Plane_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Algo_Plane_free(ref Plane_c str);

	internal static MapTypeList ConvertValue(ref MapTypeList_c s) {
		MapTypeList list = new MapTypeList((int)s.size);
		if (s.size==0) return list;

		int[] tab = new int[s.size];
		Marshal.Copy(s.ptr, tab, 0, (int)s.size);
		for (int i = 0; i < (int)s.size; ++i) {
			list.list[i] = (MapType)tab[i];
		}
		return list;
	}

	internal static MapTypeList_c ConvertValue(MapTypeList s, ref MapTypeList_c list) {
		Algo.AlgoInterface.Algo_MapTypeList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)s.list[i];
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static Core.Color ConvertValue(ref Core.Color_c s) {
		Core.Color ss = new Core.Color();
		ss.r = (System.Double)s.r;
		ss.g = (System.Double)s.g;
		ss.b = (System.Double)s.b;
		return ss;
	}

	internal static Core.Color_c ConvertValue(Core.Color s, ref Core.Color_c ss) {
		Core.CoreInterface.Core_Color_init(ref ss);
		ss.r = (System.Double)s.r;
		ss.g = (System.Double)s.g;
		ss.b = (System.Double)s.b;
		return ss;
	}

	internal static UseColorOption ConvertValue(ref UseColorOption_c s) {
		UseColorOption ss = new UseColorOption();
		ss._type = (UseColorOption.Type)s._type;
		switch(ss._type) {
			case UseColorOption.Type.UNKNOWN: break;
			case UseColorOption.Type.USELINESCOLOR: ss.UseLinesColor = (Int32)s.UseLinesColor; break;
			case UseColorOption.Type.CHOOSECOLOR: ss.ChooseColor = ConvertValue(ref s.ChooseColor); break;
		}
		return ss;
	}

	internal static UseColorOption_c ConvertValue(UseColorOption s, ref UseColorOption_c ss) {
		Algo.AlgoInterface.Algo_UseColorOption_init(ref ss);
		ss._type = (int)s._type;
		switch (ss._type) {
			case 0: break;
			case 1: ss.UseLinesColor = (Int32)s.UseLinesColor; break;
			case 2: ConvertValue(s.ChooseColor, ref ss.ChooseColor); break;
		}
		return ss;
	}

	internal static BoxParameters ConvertValue(ref BoxParameters_c s) {
		BoxParameters ss = new BoxParameters();
		ss.SizeX = (System.Double)s.SizeX;
		ss.SizeY = (System.Double)s.SizeY;
		ss.SizeZ = (System.Double)s.SizeZ;
		ss.Subdivision = (System.Int32)s.Subdivision;
		return ss;
	}

	internal static BoxParameters_c ConvertValue(BoxParameters s, ref BoxParameters_c ss) {
		Algo.AlgoInterface.Algo_BoxParameters_init(ref ss);
		ss.SizeX = (System.Double)s.SizeX;
		ss.SizeY = (System.Double)s.SizeY;
		ss.SizeZ = (System.Double)s.SizeZ;
		ss.Subdivision = (Int32)s.Subdivision;
		return ss;
	}

	internal static SphereParameters ConvertValue(ref SphereParameters_c s) {
		SphereParameters ss = new SphereParameters();
		ss.Radius = (System.Double)s.Radius;
		ss.Latitude = (System.Int32)s.Latitude;
		ss.Longitude = (System.Int32)s.Longitude;
		return ss;
	}

	internal static SphereParameters_c ConvertValue(SphereParameters s, ref SphereParameters_c ss) {
		Algo.AlgoInterface.Algo_SphereParameters_init(ref ss);
		ss.Radius = (System.Double)s.Radius;
		ss.Latitude = (Int32)s.Latitude;
		ss.Longitude = (Int32)s.Longitude;
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

	internal static FeatureInput ConvertValue(ref FeatureInput_c s) {
		FeatureInput ss = new FeatureInput();
		ss.position = Geom.GeomInterface.ConvertValue(ref s.position);
		ss.direction = Geom.GeomInterface.ConvertValue(ref s.direction);
		ss.diameter = (System.Double)s.diameter;
		return ss;
	}

	internal static FeatureInput_c ConvertValue(FeatureInput s, ref FeatureInput_c ss) {
		Algo.AlgoInterface.Algo_FeatureInput_init(ref ss);
		Geom.GeomInterface.ConvertValue(s.position, ref ss.position);
		Geom.GeomInterface.ConvertValue(s.direction, ref ss.direction);
		ss.diameter = (System.Double)s.diameter;
		return ss;
	}

	internal static FeatureInputList ConvertValue(ref FeatureInputList_c s) {
		FeatureInputList list = new FeatureInputList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(FeatureInput_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			FeatureInput_c value = (FeatureInput_c)Marshal.PtrToStructure(p, typeof(FeatureInput_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static FeatureInputList_c ConvertValue(FeatureInputList s, ref FeatureInputList_c list) {
		Algo.AlgoInterface.Algo_FeatureInputList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			FeatureInput_c elt = new FeatureInput_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(FeatureInput_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Feature ConvertValue(ref Feature_c s) {
		Feature ss = new Feature();
		ss.type = (FeatureType)s.type;
		ss.inputs = ConvertValue(ref s.inputs);
		return ss;
	}

	internal static Feature_c ConvertValue(Feature s, ref Feature_c ss) {
		Algo.AlgoInterface.Algo_Feature_init(ref ss);
		ss.type = (Int32)s.type;
		ConvertValue(s.inputs, ref ss.inputs);
		return ss;
	}

	internal static CAD.LegoBrickDefinition ConvertValue(ref CAD.LegoBrickDefinition_c s) {
		CAD.LegoBrickDefinition ss = new CAD.LegoBrickDefinition();
		ss.legoType = (CAD.LegoType)s.legoType;
		ss.length = (System.Int32)s.length;
		ss.width = (System.Int32)s.width;
		ss.fullHeight = ConvertValue(s.fullHeight);
		return ss;
	}

	internal static CAD.LegoBrickDefinition_c ConvertValue(CAD.LegoBrickDefinition s, ref CAD.LegoBrickDefinition_c ss) {
		CAD.CADInterface.CAD_LegoBrickDefinition_init(ref ss);
		ss.legoType = (Int32)s.legoType;
		ss.length = (Int32)s.length;
		ss.width = (Int32)s.width;
		ss.fullHeight = ConvertValue(s.fullHeight);
		return ss;
	}

	internal static CAD.LegoBrickDefinitionList ConvertValue(ref CAD.LegoBrickDefinitionList_c s) {
		CAD.LegoBrickDefinitionList list = new CAD.LegoBrickDefinitionList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(CAD.LegoBrickDefinition_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			CAD.LegoBrickDefinition_c value = (CAD.LegoBrickDefinition_c)Marshal.PtrToStructure(p, typeof(CAD.LegoBrickDefinition_c));
			list.list[i] = CAD.CADInterface.ConvertValue(ref value);
		}
		return list;
	}

	internal static CAD.LegoBrickDefinitionList_c ConvertValue(CAD.LegoBrickDefinitionList s, ref CAD.LegoBrickDefinitionList_c list) {
		CAD.CADInterface.CAD_LegoBrickDefinitionList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			CAD.LegoBrickDefinition_c elt = new CAD.LegoBrickDefinition_c();
			CAD.CADInterface.ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(CAD.LegoBrickDefinition_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static LegoReturn ConvertValue(ref LegoReturn_c s) {
		LegoReturn ss = new LegoReturn();
		ss.Root = (System.UInt32)s.Root;
		ss.Bricks = CAD.CADInterface.ConvertValue(ref s.Bricks);
		return ss;
	}

	internal static LegoReturn_c ConvertValue(LegoReturn s, ref LegoReturn_c ss) {
		Algo.AlgoInterface.Algo_LegoReturn_init(ref ss);
		ss.Root = (System.UInt32)s.Root;
		CAD.CADInterface.ConvertValue(s.Bricks, ref ss.Bricks);
		return ss;
	}

	internal static CustomBakeMap ConvertValue(ref CustomBakeMap_c s) {
		CustomBakeMap ss = new CustomBakeMap();
		ss.name = ConvertValue(s.name);
		ss.component = (System.Int32)s.component;
		return ss;
	}

	internal static CustomBakeMap_c ConvertValue(CustomBakeMap s, ref CustomBakeMap_c ss) {
		Algo.AlgoInterface.Algo_CustomBakeMap_init(ref ss);
		ss.name = ConvertValue(s.name);
		ss.component = (Int32)s.component;
		return ss;
	}

	internal static CustomBakeMapList ConvertValue(ref CustomBakeMapList_c s) {
		CustomBakeMapList list = new CustomBakeMapList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(CustomBakeMap_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			CustomBakeMap_c value = (CustomBakeMap_c)Marshal.PtrToStructure(p, typeof(CustomBakeMap_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static CustomBakeMapList_c ConvertValue(CustomBakeMapList s, ref CustomBakeMapList_c list) {
		Algo.AlgoInterface.Algo_CustomBakeMapList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			CustomBakeMap_c elt = new CustomBakeMap_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(CustomBakeMap_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static PlaneParameters ConvertValue(ref PlaneParameters_c s) {
		PlaneParameters ss = new PlaneParameters();
		ss.SizeX = (System.Double)s.SizeX;
		ss.SizeY = (System.Double)s.SizeY;
		ss.SubdivisionX = (System.Int32)s.SubdivisionX;
		ss.SubdivisionY = (System.Int32)s.SubdivisionY;
		return ss;
	}

	internal static PlaneParameters_c ConvertValue(PlaneParameters s, ref PlaneParameters_c ss) {
		Algo.AlgoInterface.Algo_PlaneParameters_init(ref ss);
		ss.SizeX = (System.Double)s.SizeX;
		ss.SizeY = (System.Double)s.SizeY;
		ss.SubdivisionX = (Int32)s.SubdivisionX;
		ss.SubdivisionY = (Int32)s.SubdivisionY;
		return ss;
	}

	internal static CylinderParameters ConvertValue(ref CylinderParameters_c s) {
		CylinderParameters ss = new CylinderParameters();
		ss.Radius = (System.Double)s.Radius;
		ss.Height = (System.Double)s.Height;
		ss.Sides = (System.Int32)s.Sides;
		return ss;
	}

	internal static CylinderParameters_c ConvertValue(CylinderParameters s, ref CylinderParameters_c ss) {
		Algo.AlgoInterface.Algo_CylinderParameters_init(ref ss);
		ss.Radius = (System.Double)s.Radius;
		ss.Height = (System.Double)s.Height;
		ss.Sides = (Int32)s.Sides;
		return ss;
	}

	internal static ConeParameters ConvertValue(ref ConeParameters_c s) {
		ConeParameters ss = new ConeParameters();
		ss.BottomRadius = (System.Double)s.BottomRadius;
		ss.Height = (System.Double)s.Height;
		ss.Sides = (System.Int32)s.Sides;
		return ss;
	}

	internal static ConeParameters_c ConvertValue(ConeParameters s, ref ConeParameters_c ss) {
		Algo.AlgoInterface.Algo_ConeParameters_init(ref ss);
		ss.BottomRadius = (System.Double)s.BottomRadius;
		ss.Height = (System.Double)s.Height;
		ss.Sides = (Int32)s.Sides;
		return ss;
	}

	internal static CapsuleParameters ConvertValue(ref CapsuleParameters_c s) {
		CapsuleParameters ss = new CapsuleParameters();
		ss.Radius = (System.Double)s.Radius;
		ss.Height = (System.Double)s.Height;
		ss.Latitude = (System.Int32)s.Latitude;
		ss.Longitude = (System.Int32)s.Longitude;
		return ss;
	}

	internal static CapsuleParameters_c ConvertValue(CapsuleParameters s, ref CapsuleParameters_c ss) {
		Algo.AlgoInterface.Algo_CapsuleParameters_init(ref ss);
		ss.Radius = (System.Double)s.Radius;
		ss.Height = (System.Double)s.Height;
		ss.Latitude = (Int32)s.Latitude;
		ss.Longitude = (Int32)s.Longitude;
		return ss;
	}

	internal static PrimitiveShapeParameters ConvertValue(ref PrimitiveShapeParameters_c s) {
		PrimitiveShapeParameters ss = new PrimitiveShapeParameters();
		ss._type = (PrimitiveShapeParameters.Type)s._type;
		switch(ss._type) {
			case PrimitiveShapeParameters.Type.UNKNOWN: break;
			case PrimitiveShapeParameters.Type.BOX: ss.Box = ConvertValue(ref s.Box); break;
			case PrimitiveShapeParameters.Type.PLANE: ss.Plane = ConvertValue(ref s.Plane); break;
			case PrimitiveShapeParameters.Type.SPHERE: ss.Sphere = ConvertValue(ref s.Sphere); break;
			case PrimitiveShapeParameters.Type.CYLINDER: ss.Cylinder = ConvertValue(ref s.Cylinder); break;
			case PrimitiveShapeParameters.Type.CONE: ss.Cone = ConvertValue(ref s.Cone); break;
			case PrimitiveShapeParameters.Type.CAPSULE: ss.Capsule = ConvertValue(ref s.Capsule); break;
		}
		return ss;
	}

	internal static PrimitiveShapeParameters_c ConvertValue(PrimitiveShapeParameters s, ref PrimitiveShapeParameters_c ss) {
		Algo.AlgoInterface.Algo_PrimitiveShapeParameters_init(ref ss);
		ss._type = (int)s._type;
		switch (ss._type) {
			case 0: break;
			case 1: ConvertValue(s.Box, ref ss.Box); break;
			case 2: ConvertValue(s.Plane, ref ss.Plane); break;
			case 3: ConvertValue(s.Sphere, ref ss.Sphere); break;
			case 4: ConvertValue(s.Cylinder, ref ss.Cylinder); break;
			case 5: ConvertValue(s.Cone, ref ss.Cone); break;
			case 6: ConvertValue(s.Capsule, ref ss.Capsule); break;
		}
		return ss;
	}

	internal static DecimateOptionsSelector ConvertValue(ref DecimateOptionsSelector_c s) {
		DecimateOptionsSelector ss = new DecimateOptionsSelector();
		ss._type = (DecimateOptionsSelector.Type)s._type;
		switch(ss._type) {
			case DecimateOptionsSelector.Type.UNKNOWN: break;
			case DecimateOptionsSelector.Type.TRIANGLECOUNT: ss.triangleCount = (System.UInt64)s.triangleCount; break;
			case DecimateOptionsSelector.Type.RATIO: ss.ratio = (System.Double)s.ratio; break;
		}
		return ss;
	}

	internal static DecimateOptionsSelector_c ConvertValue(DecimateOptionsSelector s, ref DecimateOptionsSelector_c ss) {
		Algo.AlgoInterface.Algo_DecimateOptionsSelector_init(ref ss);
		ss._type = (int)s._type;
		switch (ss._type) {
			case 0: break;
			case 1: ss.triangleCount = (System.UInt64)s.triangleCount; break;
			case 2: ss.ratio = (System.Double)s.ratio; break;
		}
		return ss;
	}

	private static Core.ColorAlpha_c getPixelValue_CS(Geom.Point3_c fromPos, Geom.Point2_c param, System.UInt64 polygonIndex, System.UInt32 occurrence, getPixelValue callback) {

		var retC = new Core.ColorAlpha_c();
		var retCS = callback(Geom.GeomInterface.ConvertValue(ref fromPos), Geom.GeomInterface.ConvertValue(ref param), (System.UInt64)(polygonIndex), (System.UInt32)(occurrence));
		Core.CoreInterface.ConvertValue(retCS, ref retC);
		return retC;
	}

	internal static getPixelValueList ConvertValue(ref getPixelValueList_c s) {
		getPixelValueList list = new getPixelValueList((int)s.size);
		if (s.size==0) return list;

		for (int i = 0; i < (int)s.size; ++i) {
			//TODO;
		}
		return list;
	}

	internal static getPixelValueList_c ConvertValue(getPixelValueList s, ref getPixelValueList_c list) {
		Algo.AlgoInterface.Algo_getPixelValueList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		IntPtr[] tab = new IntPtr[list.size];
		for(int i = 0; i < (int)list.size; ++i) {
			int index = i;
			getPixelValue_c callbackC = (fromPos, param, polygonIndex, occurrence) => {
				return getPixelValue_CS(fromPos, param, polygonIndex, occurrence, s.list[index]); 

			};
			tab[i] = Marshal.GetFunctionPointerForDelegate(callbackC);
		}
			Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static ReplaceByOccurrenceOptions ConvertValue(ref ReplaceByOccurrenceOptions_c s) {
		ReplaceByOccurrenceOptions ss = new ReplaceByOccurrenceOptions();
		ss.Occurrence = (System.UInt32)s.Occurrence;
		ss.Aligned = ConvertValue(s.Aligned);
		return ss;
	}

	internal static ReplaceByOccurrenceOptions_c ConvertValue(ReplaceByOccurrenceOptions s, ref ReplaceByOccurrenceOptions_c ss) {
		Algo.AlgoInterface.Algo_ReplaceByOccurrenceOptions_init(ref ss);
		ss.Occurrence = (System.UInt32)s.Occurrence;
		ss.Aligned = ConvertValue(s.Aligned);
		return ss;
	}

	internal static FeatureList ConvertValue(ref FeatureList_c s) {
		FeatureList list = new FeatureList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(Feature_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			Feature_c value = (Feature_c)Marshal.PtrToStructure(p, typeof(Feature_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static FeatureList_c ConvertValue(FeatureList s, ref FeatureList_c list) {
		Algo.AlgoInterface.Algo_FeatureList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Feature_c elt = new Feature_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Feature_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static ReplaceByPrimitiveOptions ConvertValue(ref ReplaceByPrimitiveOptions_c s) {
		ReplaceByPrimitiveOptions ss = new ReplaceByPrimitiveOptions();
		ss.Type = ConvertValue(ref s.Type);
		ss.Aligned = ConvertValue(s.Aligned);
		ss.GenerateUV = ConvertValue(s.GenerateUV);
		return ss;
	}

	internal static ReplaceByPrimitiveOptions_c ConvertValue(ReplaceByPrimitiveOptions s, ref ReplaceByPrimitiveOptions_c ss) {
		Algo.AlgoInterface.Algo_ReplaceByPrimitiveOptions_init(ref ss);
		ConvertValue(s.Type, ref ss.Type);
		ss.Aligned = ConvertValue(s.Aligned);
		ss.GenerateUV = ConvertValue(s.GenerateUV);
		return ss;
	}

	internal static ReplaceByOption ConvertValue(ref ReplaceByOption_c s) {
		ReplaceByOption ss = new ReplaceByOption();
		ss._type = (ReplaceByOption.Type)s._type;
		switch(ss._type) {
			case ReplaceByOption.Type.UNKNOWN: break;
			case ReplaceByOption.Type.OCCURRENCE: ss.Occurrence = ConvertValue(ref s.Occurrence); break;
			case ReplaceByOption.Type.BOUNDINGBOX: ss.BoundingBox = (ReplaceByBoxType)s.BoundingBox; break;
			case ReplaceByOption.Type.CONVEXHULL: ss.ConvexHull = (Int32)s.ConvexHull; break;
			case ReplaceByOption.Type.PRIMITIVE: ss.Primitive = ConvertValue(ref s.Primitive); break;
		}
		return ss;
	}

	internal static ReplaceByOption_c ConvertValue(ReplaceByOption s, ref ReplaceByOption_c ss) {
		Algo.AlgoInterface.Algo_ReplaceByOption_init(ref ss);
		ss._type = (int)s._type;
		switch (ss._type) {
			case 0: break;
			case 1: ConvertValue(s.Occurrence, ref ss.Occurrence); break;
			case 2: ss.BoundingBox = (Int32)s.BoundingBox; break;
			case 3: ss.ConvexHull = (Int32)s.ConvexHull; break;
			case 4: ConvertValue(s.Primitive, ref ss.Primitive); break;
		}
		return ss;
	}

	internal static HexahedronParameters ConvertValue(ref HexahedronParameters_c s) {
		HexahedronParameters ss = new HexahedronParameters();
		ss.XLength = (System.Double)s.XLength;
		ss.YLength = (System.Double)s.YLength;
		ss.ZLength = (System.Double)s.ZLength;
		return ss;
	}

	internal static HexahedronParameters_c ConvertValue(HexahedronParameters s, ref HexahedronParameters_c ss) {
		Algo.AlgoInterface.Algo_HexahedronParameters_init(ref ss);
		ss.XLength = (System.Double)s.XLength;
		ss.YLength = (System.Double)s.YLength;
		ss.ZLength = (System.Double)s.ZLength;
		return ss;
	}

	internal static Geom.Affine ConvertValue(ref Geom.Affine_c s) {
		Geom.Affine ss = new Geom.Affine();
		ss.origin = Geom.GeomInterface.ConvertValue(ref s.origin);
		ss.xAxis = Geom.GeomInterface.ConvertValue(ref s.xAxis);
		ss.yAxis = Geom.GeomInterface.ConvertValue(ref s.yAxis);
		ss.zAxis = Geom.GeomInterface.ConvertValue(ref s.zAxis);
		return ss;
	}

	internal static Geom.Affine_c ConvertValue(Geom.Affine s, ref Geom.Affine_c ss) {
		Geom.GeomInterface.Geom_Affine_init(ref ss);
		Geom.GeomInterface.ConvertValue(s.origin, ref ss.origin);
		Geom.GeomInterface.ConvertValue(s.xAxis, ref ss.xAxis);
		Geom.GeomInterface.ConvertValue(s.yAxis, ref ss.yAxis);
		Geom.GeomInterface.ConvertValue(s.zAxis, ref ss.zAxis);
		return ss;
	}

	internal static Box ConvertValue(ref Box_c s) {
		Box ss = new Box();
		ss.position = Geom.GeomInterface.ConvertValue(ref s.position);
		ss.length = (System.Double)s.length;
		ss.height = (System.Double)s.height;
		ss.depth = (System.Double)s.depth;
		return ss;
	}

	internal static Box_c ConvertValue(Box s, ref Box_c ss) {
		Algo.AlgoInterface.Algo_Box_init(ref ss);
		Geom.GeomInterface.ConvertValue(s.position, ref ss.position);
		ss.length = (System.Double)s.length;
		ss.height = (System.Double)s.height;
		ss.depth = (System.Double)s.depth;
		return ss;
	}

	internal static Scene.PropertyValue ConvertValue(ref Scene.PropertyValue_c s) {
		Scene.PropertyValue ss = new Scene.PropertyValue();
		ss.name = ConvertValue(s.name);
		ss.value = ConvertValue(s.value);
		return ss;
	}

	internal static Scene.PropertyValue_c ConvertValue(Scene.PropertyValue s, ref Scene.PropertyValue_c ss) {
		Scene.SceneInterface.Scene_PropertyValue_init(ref ss);
		ss.name = ConvertValue(s.name);
		ss.value = ConvertValue(s.value);
		return ss;
	}

	internal static Scene.PropertyValueList ConvertValue(ref Scene.PropertyValueList_c s) {
		Scene.PropertyValueList list = new Scene.PropertyValueList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(Scene.PropertyValue_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			Scene.PropertyValue_c value = (Scene.PropertyValue_c)Marshal.PtrToStructure(p, typeof(Scene.PropertyValue_c));
			list.list[i] = Scene.SceneInterface.ConvertValue(ref value);
		}
		return list;
	}

	internal static Scene.PropertyValueList_c ConvertValue(Scene.PropertyValueList s, ref Scene.PropertyValueList_c list) {
		Scene.SceneInterface.Scene_PropertyValueList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Scene.PropertyValue_c elt = new Scene.PropertyValue_c();
			Scene.SceneInterface.ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Scene.PropertyValue_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static BakeMap ConvertValue(ref BakeMap_c s) {
		BakeMap ss = new BakeMap();
		ss.type = (MapType)s.type;
		ss.properties = Scene.SceneInterface.ConvertValue(ref s.properties);
		return ss;
	}

	internal static BakeMap_c ConvertValue(BakeMap s, ref BakeMap_c ss) {
		Algo.AlgoInterface.Algo_BakeMap_init(ref ss);
		ss.type = (Int32)s.type;
		Scene.SceneInterface.ConvertValue(s.properties, ref ss.properties);
		return ss;
	}

	internal static BakeMapList ConvertValue(ref BakeMapList_c s) {
		BakeMapList list = new BakeMapList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(BakeMap_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			BakeMap_c value = (BakeMap_c)Marshal.PtrToStructure(p, typeof(BakeMap_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static BakeMapList_c ConvertValue(BakeMapList s, ref BakeMapList_c list) {
		Algo.AlgoInterface.Algo_BakeMapList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			BakeMap_c elt = new BakeMap_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(BakeMap_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static OccurrenceFeatures ConvertValue(ref OccurrenceFeatures_c s) {
		OccurrenceFeatures ss = new OccurrenceFeatures();
		ss.occurrence = (System.UInt32)s.occurrence;
		ss.features = ConvertValue(ref s.features);
		return ss;
	}

	internal static OccurrenceFeatures_c ConvertValue(OccurrenceFeatures s, ref OccurrenceFeatures_c ss) {
		Algo.AlgoInterface.Algo_OccurrenceFeatures_init(ref ss);
		ss.occurrence = (System.UInt32)s.occurrence;
		ConvertValue(s.features, ref ss.features);
		return ss;
	}

	internal static OccurrenceFeaturesList ConvertValue(ref OccurrenceFeaturesList_c s) {
		OccurrenceFeaturesList list = new OccurrenceFeaturesList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(OccurrenceFeatures_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			OccurrenceFeatures_c value = (OccurrenceFeatures_c)Marshal.PtrToStructure(p, typeof(OccurrenceFeatures_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static OccurrenceFeaturesList_c ConvertValue(OccurrenceFeaturesList s, ref OccurrenceFeaturesList_c list) {
		Algo.AlgoInterface.Algo_OccurrenceFeaturesList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			OccurrenceFeatures_c elt = new OccurrenceFeatures_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(OccurrenceFeatures_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Cylinder ConvertValue(ref Cylinder_c s) {
		Cylinder ss = new Cylinder();
		ss.position = Geom.GeomInterface.ConvertValue(ref s.position);
		ss.radius = (System.Double)s.radius;
		ss.length = (System.Double)s.length;
		return ss;
	}

	internal static Cylinder_c ConvertValue(Cylinder s, ref Cylinder_c ss) {
		Algo.AlgoInterface.Algo_Cylinder_init(ref ss);
		Geom.GeomInterface.ConvertValue(s.position, ref ss.position);
		ss.radius = (System.Double)s.radius;
		ss.length = (System.Double)s.length;
		return ss;
	}

	internal static BakeMaps ConvertValue(ref BakeMaps_c s) {
		BakeMaps ss = new BakeMaps();
		ss.diffuse = ConvertValue(s.diffuse);
		ss.normal = ConvertValue(s.normal);
		ss.roughness = ConvertValue(s.roughness);
		ss.metallic = ConvertValue(s.metallic);
		ss.opacity = ConvertValue(s.opacity);
		ss.ambientOcclusion = ConvertValue(s.ambientOcclusion);
		ss.emissive = ConvertValue(s.emissive);
		return ss;
	}

	internal static BakeMaps_c ConvertValue(BakeMaps s, ref BakeMaps_c ss) {
		Algo.AlgoInterface.Algo_BakeMaps_init(ref ss);
		ss.diffuse = ConvertValue(s.diffuse);
		ss.normal = ConvertValue(s.normal);
		ss.roughness = ConvertValue(s.roughness);
		ss.metallic = ConvertValue(s.metallic);
		ss.opacity = ConvertValue(s.opacity);
		ss.ambientOcclusion = ConvertValue(s.ambientOcclusion);
		ss.emissive = ConvertValue(s.emissive);
		return ss;
	}

	internal static Sphere ConvertValue(ref Sphere_c s) {
		Sphere ss = new Sphere();
		ss.position = Geom.GeomInterface.ConvertValue(ref s.position);
		ss.radius = (System.Double)s.radius;
		return ss;
	}

	internal static Sphere_c ConvertValue(Sphere s, ref Sphere_c ss) {
		Algo.AlgoInterface.Algo_Sphere_init(ref ss);
		Geom.GeomInterface.ConvertValue(s.position, ref ss.position);
		ss.radius = (System.Double)s.radius;
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

	internal static OctahedralImpostor ConvertValue(ref OctahedralImpostor_c s) {
		OctahedralImpostor ss = new OctahedralImpostor();
		ss.OctaTransform = Geom.GeomInterface.ConvertValue(ref s.OctaTransform);
		ss.Radius = (System.Double)s.Radius;
		ss.NormalMap = (System.UInt32)s.NormalMap;
		ss.DepthMap = (System.UInt32)s.DepthMap;
		ss.DiffuseMap = (System.UInt32)s.DiffuseMap;
		ss.MetallicMap = (System.UInt32)s.MetallicMap;
		ss.AOMap = (System.UInt32)s.AOMap;
		ss.RoughnessMap = (System.UInt32)s.RoughnessMap;
		return ss;
	}

	internal static OctahedralImpostor_c ConvertValue(OctahedralImpostor s, ref OctahedralImpostor_c ss) {
		Algo.AlgoInterface.Algo_OctahedralImpostor_init(ref ss);
		Geom.GeomInterface.ConvertValue(s.OctaTransform, ref ss.OctaTransform);
		ss.Radius = (System.Double)s.Radius;
		ss.NormalMap = (System.UInt32)s.NormalMap;
		ss.DepthMap = (System.UInt32)s.DepthMap;
		ss.DiffuseMap = (System.UInt32)s.DiffuseMap;
		ss.MetallicMap = (System.UInt32)s.MetallicMap;
		ss.AOMap = (System.UInt32)s.AOMap;
		ss.RoughnessMap = (System.UInt32)s.RoughnessMap;
		return ss;
	}

	internal static BakeOption ConvertValue(ref BakeOption_c s) {
		BakeOption ss = new BakeOption();
		ss.bakingMethod = (BakingMethod)s.bakingMethod;
		ss.resolution = (System.Int32)s.resolution;
		ss.padding = (System.Int32)s.padding;
		ss.textures = ConvertValue(ref s.textures);
		return ss;
	}

	internal static BakeOption_c ConvertValue(BakeOption s, ref BakeOption_c ss) {
		Algo.AlgoInterface.Algo_BakeOption_init(ref ss);
		ss.bakingMethod = (Int32)s.bakingMethod;
		ss.resolution = (Int32)s.resolution;
		ss.padding = (Int32)s.padding;
		ConvertValue(s.textures, ref ss.textures);
		return ss;
	}

	internal static Plane ConvertValue(ref Plane_c s) {
		Plane ss = new Plane();
		ss.position = Geom.GeomInterface.ConvertValue(ref s.position);
		ss.length = (System.Double)s.length;
		ss.height = (System.Double)s.height;
		return ss;
	}

	internal static Plane_c ConvertValue(Plane s, ref Plane_c ss) {
		Algo.AlgoInterface.Algo_Plane_init(ref ss);
		Geom.GeomInterface.ConvertValue(s.position, ref ss.position);
		ss.length = (System.Double)s.length;
		ss.height = (System.Double)s.height;
		return ss;
	}

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

	internal static Geom.Matrix4ListList ConvertValue(ref Geom.Matrix4ListList_c s) {
		Geom.Matrix4ListList list = new Geom.Matrix4ListList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(Geom.Matrix4List_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			Geom.Matrix4List_c value = (Geom.Matrix4List_c)Marshal.PtrToStructure(p, typeof(Geom.Matrix4List_c));
			list.list[i] = Geom.GeomInterface.ConvertValue(ref value);
		}
		return list;
	}

	internal static Geom.Matrix4ListList_c ConvertValue(Geom.Matrix4ListList s, ref Geom.Matrix4ListList_c list) {
		Geom.GeomInterface.Geom_Matrix4ListList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Geom.Matrix4List_c elt = new Geom.Matrix4List_c();
			Geom.GeomInterface.ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Geom.Matrix4List_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static GetAllAxisFromCADModelReturn ConvertValue(ref GetAllAxisFromCADModelReturn_c s) {
		GetAllAxisFromCADModelReturn ss = new GetAllAxisFromCADModelReturn();
		ss.occurrences = Scene.SceneInterface.ConvertValue(ref s.occurrences);
		ss.axis = Geom.GeomInterface.ConvertValue(ref s.axis);
		return ss;
	}

	internal static GetAllAxisFromCADModelReturn_c ConvertValue(GetAllAxisFromCADModelReturn s, ref GetAllAxisFromCADModelReturn_c ss) {
		Scene.SceneInterface.ConvertValue(s.occurrences, ref ss.occurrences);
		Geom.GeomInterface.ConvertValue(s.axis, ref ss.axis);
		return ss;
	}

	internal static GetVisibilityStatsReturn ConvertValue(ref GetVisibilityStatsReturn_c s) {
		GetVisibilityStatsReturn ss = new GetVisibilityStatsReturn();
		ss.visibleCountFront = (System.Int32)s.visibleCountFront;
		ss.visibleCountBack = (System.Int32)s.visibleCountBack;
		return ss;
	}

	internal static GetVisibilityStatsReturn_c ConvertValue(GetVisibilityStatsReturn s, ref GetVisibilityStatsReturn_c ss) {
		ss.visibleCountFront = (Int32)s.visibleCountFront;
		ss.visibleCountBack = (Int32)s.visibleCountBack;
		return ss;
	}

	internal static GetUVQualityMetricsReturn ConvertValue(ref GetUVQualityMetricsReturn_c s) {
		GetUVQualityMetricsReturn ss = new GetUVQualityMetricsReturn();
		ss.chartCount = (System.UInt32)s.chartCount;
		ss.area3D = (System.Double)s.area3D;
		ss.area2D = (System.Double)s.area2D;
		ss.occupancy = (System.Double)s.occupancy;
		ss.crumbliness = (System.Double)s.crumbliness;
		ss.samplingStd = (System.Double)s.samplingStd;
		return ss;
	}

	internal static GetUVQualityMetricsReturn_c ConvertValue(GetUVQualityMetricsReturn s, ref GetUVQualityMetricsReturn_c ss) {
		ss.chartCount = (System.UInt32)s.chartCount;
		ss.area3D = (System.Double)s.area3D;
		ss.area2D = (System.Double)s.area2D;
		ss.occupancy = (System.Double)s.occupancy;
		ss.crumbliness = (System.Double)s.crumbliness;
		ss.samplingStd = (System.Double)s.samplingStd;
		return ss;
	}

		#endregion

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Algo_getLastError();

		public static string GetLastError()
		{
			return ConvertValue(Algo_getLastError());
		}

		#region 

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_assembleCAD(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double tolerance, System.Byte removeDuplicatedFaces);
		/// <summary>
		/// Assemble faces of CAD shapes
		/// </summary>
		/// <param name="occurrences">Occurrences of components to assemble</param>
		/// <param name="tolerance">Assembling tolerance</param>
		/// <param name="removeDuplicatedFaces">If True, duplicated faces will be removed</param>
		public void AssembleCAD(Scene.OccurrenceList occurrences, System.Double tolerance, System.Boolean removeDuplicatedFaces = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_assembleCAD(api.Session, occurrences_c, tolerance, Convert.ToByte(removeDuplicatedFaces));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_backToInitialBRep(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Create the BRep shape from a Tessellated shape with Domain Patch Attributes (after tessellate)
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		public void BackToInitialBRep(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_backToInitialBRep(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OctahedralImpostor_c Algo_bakeImpostor(IntPtr _pxz_session_, System.UInt32 occurrence, Int32 XFrames, Int32 YFrames, System.Byte hemi, Int32 resolution, Int32 padding, System.Byte roughness, System.Byte metallic, System.Byte ao);
		/// <summary>
		/// bakes impostors textures
		/// </summary>
		/// <param name="occurrence"></param>
		/// <param name="XFrames"></param>
		/// <param name="YFrames"></param>
		/// <param name="hemi"></param>
		/// <param name="resolution"></param>
		/// <param name="padding"></param>
		/// <param name="roughness"></param>
		/// <param name="metallic"></param>
		/// <param name="ao"></param>
		public OctahedralImpostor BakeImpostor(System.UInt32 occurrence, System.Int32 XFrames, System.Int32 YFrames, System.Boolean hemi = false, System.Int32 resolution = 1024, System.Int32 padding = 0, System.Boolean roughness = false, System.Boolean metallic = false, System.Boolean ao = false) {
			var ret = Algo_bakeImpostor(api.Session, occurrence, XFrames, YFrames, Convert.ToByte(hemi), resolution, padding, Convert.ToByte(roughness), Convert.ToByte(metallic), Convert.ToByte(ao));
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Algo.AlgoInterface.Algo_OctahedralImpostor_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_bakeVertexAttributes(IntPtr _pxz_session_, Scene.OccurrenceList_c destinationOccurrences, Scene.OccurrenceList_c sourceOccurrences, System.Byte skinnedMesh, System.Byte positions, System.Byte useCurrentPositionAsTPose);
		/// <summary>
		/// Bake vertex attributes on meshes from other meshes
		/// </summary>
		/// <param name="destinationOccurrences">Occurrences of the meshes where to store the baked vertex attributes</param>
		/// <param name="sourceOccurrences">Occurrences of components from which to bake vertex attributes</param>
		/// <param name="skinnedMesh">Enabling skinned mesh baking (joint assignation for animation transfer)</param>
		/// <param name="positions">Enabling vertex position baking</param>
		/// <param name="useCurrentPositionAsTPose">Use the current position as the T-Pose</param>
		public void BakeVertexAttributes(Scene.OccurrenceList destinationOccurrences, Scene.OccurrenceList sourceOccurrences, System.Boolean skinnedMesh, System.Boolean positions, System.Boolean useCurrentPositionAsTPose = false) {
			var destinationOccurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)destinationOccurrences, ref destinationOccurrences_c);
			var sourceOccurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)sourceOccurrences, ref sourceOccurrences_c);
			Algo_bakeVertexAttributes(api.Session, destinationOccurrences_c, sourceOccurrences_c, Convert.ToByte(skinnedMesh), Convert.ToByte(positions), Convert.ToByte(useCurrentPositionAsTPose));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref destinationOccurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref sourceOccurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_calculateNormalsInPointClouds(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// calculate the normal of each point of a Point Cloud
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		public void CalculateNormalsInPointClouds(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_calculateNormalsInPointClouds(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Algo_checkTessellationFlags(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="occurrences">Occurrences of components to check</param>
		public System.Boolean CheckTessellationFlags(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_checkTessellationFlags(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Boolean)(0 != ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Scene.OccurrenceList_c Algo_combineMeshesByMaterials(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Byte mergeNoMaterials, Int32 mergeHiddenPartsMode);
		/// <summary>
		/// Explode and (re)merge a set of mesh parts by visible materials
		/// </summary>
		/// <param name="occurrences">Occurrences of the parts to merge</param>
		/// <param name="mergeNoMaterials">If true, merge all parts with no active material together, else do not merge them</param>
		/// <param name="mergeHiddenPartsMode">Hidden parts handling mode, Destroy them, make visible or merge separately</param>
		public Scene.OccurrenceList CombineMeshesByMaterials(Scene.OccurrenceList occurrences, System.Boolean mergeNoMaterials = true, Scene.MergeHiddenPartsMode mergeHiddenPartsMode = (Scene.MergeHiddenPartsMode)0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_combineMeshesByMaterials(api.Session, occurrences_c, Convert.ToByte(mergeNoMaterials), (int)mergeHiddenPartsMode);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Scene.SceneInterface.ConvertValue(ref ret);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_configureFunctionLogger(IntPtr _pxz_session_, string functionName, System.Byte enableFunction, System.Byte enableParameters, System.Byte enableExecutionTime);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="functionName"></param>
		/// <param name="enableFunction"></param>
		/// <param name="enableParameters"></param>
		/// <param name="enableExecutionTime"></param>
		public void ConfigureFunctionLogger(System.String functionName, System.Boolean enableFunction, System.Boolean enableParameters, System.Boolean enableExecutionTime) {
			Algo_configureFunctionLogger(api.Session, functionName, Convert.ToByte(enableFunction), Convert.ToByte(enableParameters), Convert.ToByte(enableExecutionTime));
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_convertCADtoNURBS(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Convert all CAD curves/surfaces to NURBS definition
		/// </summary>
		/// <param name="occurrences">Occurrences of components to convert</param>
		public void ConvertCADtoNURBS(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_convertCADtoNURBS(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_crackCADMoebiusStrip(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Detect Moebius strip and crack them if there is somme of them in the selection
		/// </summary>
		/// <param name="occurrences">Occurrences of components to check</param>
		public void CrackCADMoebiusStrip(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_crackCADMoebiusStrip(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_crackEdges(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Byte useAttributesFilter, System.Double sharpAngleFilter, System.Byte useNonManifoldFilter);
		/// <summary>
		/// crack polygonal edges according to given criteria (deprecated, use crackMeshEdges instead)
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="useAttributesFilter">Filters by attribute</param>
		/// <param name="sharpAngleFilter">Sharp angle in degree to filter by edges sharpness, if the angle is negative do not filter</param>
		/// <param name="useNonManifoldFilter">Filters by manifold-ness.</param>
		public void CrackEdges(Scene.OccurrenceList occurrences, System.Boolean useAttributesFilter = true, System.Double sharpAngleFilter = 45, System.Boolean useNonManifoldFilter = false) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_crackEdges(api.Session, occurrences_c, Convert.ToByte(useAttributesFilter), sharpAngleFilter, Convert.ToByte(useNonManifoldFilter));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_crackMeshEdges(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Byte normal, System.Byte uvs, Core.IntList_c uvChannels, System.Byte loi, System.Byte patches, System.Byte nman);
		/// <summary>
		/// crack polygonal edges according to given criteria
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="normal">Crack on sharp normals</param>
		/// <param name="uvs">Crack on UV seams</param>
		/// <param name="uvChannels">If empty and uvs=true, crack all UV channel, else only channel specified in the list</param>
		/// <param name="loi">Crack on identifier Lines of Interests</param>
		/// <param name="patches">Crack on patch borders</param>
		/// <param name="nman">Crack on non-manifolds</param>
		public void CrackMeshEdges(Scene.OccurrenceList occurrences, System.Boolean normal = false, System.Boolean uvs = false, Core.IntList uvChannels = null, System.Boolean loi = false, System.Boolean patches = false, System.Boolean nman = false) {
			uvChannels = uvChannels ?? new Core.IntList(new System.Int32[] {});
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var uvChannels_c = new Core.IntList_c();
			Core.CoreInterface.ConvertValue((Core.IntList)uvChannels, ref uvChannels_c);
			Algo_crackMeshEdges(api.Session, occurrences_c, Convert.ToByte(normal), Convert.ToByte(uvs), uvChannels_c, Convert.ToByte(loi), Convert.ToByte(patches), Convert.ToByte(nman));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Core.CoreInterface.Core_IntList_free(ref uvChannels_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_createFreeEdgesFromPatches(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Create free edges from patch borders
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		public void CreateFreeEdgesFromPatches(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_createFreeEdgesFromPatches(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_createIdentifiedPatchesFromPatches(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Create identified patch from existing patch (this is useful before cloning for baking)
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		public void CreateIdentifiedPatchesFromPatches(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_createIdentifiedPatchesFromPatches(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Algo_createIndexMapFromOccurrences(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 uvChannel, System.Byte createTexture1D);
		/// <summary>
		/// Create an IndexMap and add an UVSet so that each mesh will have UVs refering to one different pixel of the index map and that pixel will have the value i for occurrences[i]. Warning: all occurrences will be singularized
		/// </summary>
		/// <param name="occurrences"></param>
		/// <param name="uvChannel"></param>
		/// <param name="createTexture1D">If true, the texture will have a resolution of 1 x occurrences.size, else a square power of two image will be created to fit occurrences.size pixels</param>
		public System.UInt32 CreateIndexMapFromOccurrences(Scene.OccurrenceList occurrences, System.Int32 uvChannel, System.Boolean createTexture1D) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_createIndexMapFromOccurrences(api.Session, occurrences_c, uvChannel, Convert.ToByte(createTexture1D));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_createNormals(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double sharpEdge, System.Byte overriding, System.Byte useAreaWeighting);
		/// <summary>
		/// Create normal attributes on tessellations
		/// </summary>
		/// <param name="occurrences">Occurrences of components to create attributes</param>
		/// <param name="sharpEdge">Edges with an angle between their polygons greater than sharpEdge will be considered sharp. If negative, smooth normals only.</param>
		/// <param name="overriding">If true, override existing normals, else only create normals on meshes without normals</param>
		/// <param name="useAreaWeighting">If true, normal computation will be weighted using polygon areas</param>
		public void CreateNormals(Scene.OccurrenceList occurrences, System.Double sharpEdge = 45, System.Boolean overriding = true, System.Boolean useAreaWeighting = false) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_createNormals(api.Session, occurrences_c, sharpEdge, Convert.ToByte(overriding), Convert.ToByte(useAreaWeighting));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Algo_createPointCloudKDTree(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 depth, System.Byte addToScene);
		/// <summary>
		/// Create a KD-Tree from some point clouds occurrence, the given occurrences are deleted (even if they contains triangles) and the KD-Tree is represented in a new occurrence sub tree
		/// </summary>
		/// <param name="occurrences">Occurrences to process</param>
		/// <param name="depth">Kd tree depth</param>
		/// <param name="addToScene">Add the KD-Tree to the current scene</param>
		public System.UInt32 CreatePointCloudKDTree(Scene.OccurrenceList occurrences, System.Int32 depth, System.Boolean addToScene = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_createPointCloudKDTree(api.Session, occurrences_c, depth, Convert.ToByte(addToScene));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_createTangents(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 uvChannel, System.Byte overriding);
		/// <summary>
		/// Create tangent attributes on tessellations
		/// </summary>
		/// <param name="occurrences">Occurrences of components to create attributes</param>
		/// <param name="uvChannel">UV channel to use for the tangents creation</param>
		/// <param name="overriding">If true, override existing tangents, else only create tangents on meshes without tangents</param>
		public void CreateTangents(Scene.OccurrenceList occurrences, System.Int32 uvChannel = 0, System.Boolean overriding = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_createTangents(api.Session, occurrences_c, uvChannel, Convert.ToByte(overriding));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_createTextureAtlas(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Create a texture atlas from input occurrences textutes
		/// </summary>
		/// <param name="occurrences">Input occurrences</param>
		public void CreateTextureAtlas(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_createTextureAtlas(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_createVertexColorFromMaterials(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrenceList);
		/// <summary>
		/// Bake vertex colors using main material color. May duplicate some vertices
		/// </summary>
		/// <param name="occurrenceList"></param>
		public void CreateVertexColorFromMaterials(Scene.OccurrenceList occurrenceList) {
			var occurrenceList_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrenceList, ref occurrenceList_c);
			Algo_createVertexColorFromMaterials(api.Session, occurrenceList_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrenceList_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_createVisibilityPatchesFromPatch(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Create visibility patches from existing patches
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		public void CreateVisibilityPatchesFromPatch(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_createVisibilityPatchesFromPatch(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_debug(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Debug function
		/// </summary>
		/// <param name="occurrences">Occurrences of components to check</param>
		public void Debug(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_debug(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_debugSEH(IntPtr _pxz_session_, System.UInt32 occurrence);
		/// <summary>
		/// JaaJ
		/// </summary>
		/// <param name="occurrence">Input occurrence</param>
		public void DebugSEH(System.UInt32 occurrence) {
			Algo_debugSEH(api.Session, occurrence);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_decimate(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double surfacicTolerance, System.Double lineicTolerance, System.Double normalTolerance, System.Double texCoordTolerance, System.Byte releaseConstraintOnSmallArea);
		/// <summary>
		/// reduce the polygon count by removing some vertices
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="surfacicTolerance">Maximum distance between surfacic vertices and resulting simplified surfaces</param>
		/// <param name="lineicTolerance">Maximum distance between lineic vertices and resulting simplified lines</param>
		/// <param name="normalTolerance">Maximum angle between original normals and those interpolated on the simplified surface</param>
		/// <param name="texCoordTolerance">Maximum distance (in 3D space) between original texcoords and those interpolated on the simplified surface</param>
		/// <param name="releaseConstraintOnSmallArea">If True, release constraint of normal and/or texcoord tolerance on small areas (according to surfacicTolerance)</param>
		public void Decimate(Scene.OccurrenceList occurrences, System.Double surfacicTolerance, System.Double lineicTolerance = 0.1, System.Double normalTolerance = 5, System.Double texCoordTolerance = -1, System.Boolean releaseConstraintOnSmallArea = false) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_decimate(api.Session, occurrences_c, surfacicTolerance, lineicTolerance, normalTolerance, texCoordTolerance, Convert.ToByte(releaseConstraintOnSmallArea));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_decimateEdgeCollapse(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double surfacicTolerance, System.Double boundaryWeight, System.Double normalWeight, System.Double UVWeight, System.Double sharpNormalWeight, System.Double UVSeamWeight, System.Double normalMaxDeviation, System.Byte forbidUVOverlaps, System.Double UVMaxDeviation, System.Double UVSeamMaxDeviation, System.Byte protectTopology, Int32 qualityTradeoff);
		/// <summary>
		/// reduce the polygon count by collapsing some edges to obtain an simplified mesh
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="surfacicTolerance">Error max between the simplified mesh et the old one</param>
		/// <param name="boundaryWeight">Boundary importance during the decimation</param>
		/// <param name="normalWeight">Normal importance during the decimation</param>
		/// <param name="UVWeight">UV importance during the decimation</param>
		/// <param name="sharpNormalWeight">Importance of sharp edges during the decimation</param>
		/// <param name="UVSeamWeight">Importance of UV seams during the decimation</param>
		/// <param name="normalMaxDeviation">Constraint the normals deviation on decimated model</param>
		/// <param name="forbidUVOverlaps">Forbid UV to fold over and overlap during the decimation</param>
		/// <param name="UVMaxDeviation">Constraint the uv deviation on decimated model</param>
		/// <param name="UVSeamMaxDeviation">Constraint the uv seams deviation on decimated model</param>
		/// <param name="protectTopology">If false, the topology of the mesh can change and some edges can become non-manifold. But the visual quality will be better on model with complex topology</param>
		/// <param name="qualityTradeoff">For big models it is recommended to choose PreferSpeed tradeoff. In PreferSpeed mode, quadrics are computed only on position (and not on other vertex attributes)</param>
		public void DecimateEdgeCollapse(Scene.OccurrenceList occurrences, System.Double surfacicTolerance, System.Double boundaryWeight = 1, System.Double normalWeight = 1, System.Double UVWeight = 1, System.Double sharpNormalWeight = 1, System.Double UVSeamWeight = 10, System.Double normalMaxDeviation = -1, System.Boolean forbidUVOverlaps = true, System.Double UVMaxDeviation = -1, System.Double UVSeamMaxDeviation = -1, System.Boolean protectTopology = false, QualitySpeedTradeoff qualityTradeoff = (Algo.QualitySpeedTradeoff)0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_decimateEdgeCollapse(api.Session, occurrences_c, surfacicTolerance, boundaryWeight, normalWeight, UVWeight, sharpNormalWeight, UVSeamWeight, normalMaxDeviation, Convert.ToByte(forbidUVOverlaps), UVMaxDeviation, UVSeamMaxDeviation, Convert.ToByte(protectTopology), (int)qualityTradeoff);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_decimatePointClouds(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double tolerance);
		/// <summary>
		/// decimate Point Cloud Occurrences according to tolerance 
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="tolerance">Avarage distance between points</param>
		public void DecimatePointClouds(Scene.OccurrenceList occurrences, System.Double tolerance = 500) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_decimatePointClouds(api.Session, occurrences_c, tolerance);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_decimateTarget(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, DecimateOptionsSelector_c targetStrategy, Int32 UVImportance, System.Byte protectTopology, System.UInt64 iterativeThreshold, System.Byte processMeshIndependently);
		/// <summary>
		/// reduce the polygon count by collapsing some edges to obtain a target triangle count (iterative version that use less memory)
		/// </summary>
		/// <param name="occurrences">List of occurrences to process</param>
		/// <param name="targetStrategy">Select between targetCount or ratio to define the number of triangles left after the decimation process</param>
		/// <param name="UVImportance">Select importance of texture coordinates</param>
		/// <param name="protectTopology">If False, the topology of the mesh can change and some edges can become non-manifold</param>
		/// <param name="iterativeThreshold">Number of triangles above which the iterative algorithm is used to limit the memory usage (disabled if processMeshIndependently=True)</param>
		/// <param name="processMeshIndependently">If true, each mesh will be processed independently and the triangleCount or ratio will apply by mesh (disable iterative method)</param>
		public void DecimateTarget(Scene.OccurrenceList occurrences, DecimateOptionsSelector targetStrategy, UVImportanceEnum UVImportance = (Algo.UVImportanceEnum)0, System.Boolean protectTopology = false, System.UInt64 iterativeThreshold = 5000000, System.Boolean processMeshIndependently = false) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var targetStrategy_c = new Algo.DecimateOptionsSelector_c();
			ConvertValue((Algo.DecimateOptionsSelector)targetStrategy, ref targetStrategy_c);
			Algo_decimateTarget(api.Session, occurrences_c, targetStrategy_c, (int)UVImportance, Convert.ToByte(protectTopology), iterativeThreshold, Convert.ToByte(processMeshIndependently));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Algo.AlgoInterface.Algo_DecimateOptionsSelector_free(ref targetStrategy_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_decimateTargetOldSchool(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, DecimateOptionsSelector_c TargetStrategy, System.Double boundaryWeight, System.Double normalWeight, System.Double UVWeight, System.Double sharpNormalWeight, System.Double UVSeamWeight, System.Byte forbidUVFoldovers, System.Byte protectTopology, Int32 qualityTradeoff);
		/// <summary>
		/// reduce the polygon count by collapsing some edges to obtain a target triangle count
		/// </summary>
		/// <param name="occurrences">List of occurrences to process</param>
		/// <param name="TargetStrategy">Select between targetCount or ratio to define the number of triangles left after the decimation process</param>
		/// <param name="boundaryWeight">Defines how important the edges defining the mesh boundaries (free edges) are during the decimation process, to preserve them from distortion</param>
		/// <param name="normalWeight">Defines how important vertex normals are during the decimation process, to preserve the smoothing of the mesh from being damaged</param>
		/// <param name="UVWeight">Defines how important UVs (texture coordinates) are during the decimation process, to preserve them from being distorted (along with the textures using the UVs)</param>
		/// <param name="sharpNormalWeight">Defines how important sharp edges (or hard edges) are during the decimation process, to preserve them from being distorted</param>
		/// <param name="UVSeamWeight">Defines how important UV seams (UV islands contours) are during the decimation process, to preserve them from being distorted (along with the textures using the UVs)</param>
		/// <param name="forbidUVFoldovers">Forbids UVs to fold over and overlap each other during the decimation</param>
		/// <param name="protectTopology">If False, the topology of the mesh can change and some edges can become non-manifold; but the visual quality will be better on model with complex topology</param>
		/// <param name="qualityTradeoff">For big models it is recommended to choose PreferSpeed tradeoff. In PreferSpeed mode, quadrics are computed only on position (and not on other vertex attributes)</param>
		public void DecimateTargetOldSchool(Scene.OccurrenceList occurrences, DecimateOptionsSelector TargetStrategy, System.Double boundaryWeight = 1, System.Double normalWeight = 1, System.Double UVWeight = 1, System.Double sharpNormalWeight = 1, System.Double UVSeamWeight = 10, System.Boolean forbidUVFoldovers = true, System.Boolean protectTopology = false, QualitySpeedTradeoff qualityTradeoff = (Algo.QualitySpeedTradeoff)0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var TargetStrategy_c = new Algo.DecimateOptionsSelector_c();
			ConvertValue((Algo.DecimateOptionsSelector)TargetStrategy, ref TargetStrategy_c);
			Algo_decimateTargetOldSchool(api.Session, occurrences_c, TargetStrategy_c, boundaryWeight, normalWeight, UVWeight, sharpNormalWeight, UVSeamWeight, Convert.ToByte(forbidUVFoldovers), Convert.ToByte(protectTopology), (int)qualityTradeoff);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Algo.AlgoInterface.Algo_DecimateOptionsSelector_free(ref TargetStrategy_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_defeatureCAD(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double maxDiameter);
		/// <summary>
		/// Remove some features from brep
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="maxDiameter">Maximum diameter of the holes to be removed (-1=no max diameter)</param>
		public void DefeatureCAD(Scene.OccurrenceList occurrences, System.Double maxDiameter) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_defeatureCAD(api.Session, occurrences_c, maxDiameter);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_deleteAttibute(IntPtr _pxz_session_, System.UInt32 occurrence, Int32 type);
		/// <summary>
		/// Delete designed attribute on tessellations
		/// </summary>
		/// <param name="occurrence">Occurrence to detele attribute from</param>
		/// <param name="type">Attribute type</param>
		public void DeleteAttibute(System.UInt32 occurrence, AttributType type) {
			Algo_deleteAttibute(api.Session, occurrence, (int)type);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_deleteBRepShapes(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Byte onlyTessellated);
		/// <summary>
		/// Delete BRep representation on parts
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="onlyTessellated">If True, delete only BRep represensation on part with a tessellated shape</param>
		public void DeleteBRepShapes(Scene.OccurrenceList occurrences, System.Boolean onlyTessellated = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_deleteBRepShapes(api.Session, occurrences_c, Convert.ToByte(onlyTessellated));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_deleteFreeVertices(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Delete all free vertices of the mesh of given parts
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		public void DeleteFreeVertices(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_deleteFreeVertices(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_deleteLines(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Delete all free line of the mesh of given parts
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		public void DeleteLines(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_deleteLines(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_deleteNormals(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Remove normal attributes on tessellations
		/// </summary>
		/// <param name="occurrences">Occurrences of components to delete</param>
		public void DeleteNormals(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_deleteNormals(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_deletePatches(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Byte keepOnePatchByMaterial);
		/// <summary>
		/// Delete patches attributes on tessellations
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="keepOnePatchByMaterial">If set, one patch by material will be kept, else all patches will be deleted and materials on patches will be lost</param>
		public void DeletePatches(Scene.OccurrenceList occurrences, System.Boolean keepOnePatchByMaterial = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_deletePatches(api.Session, occurrences_c, Convert.ToByte(keepOnePatchByMaterial));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_deletePolygons(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Delete all polygons of the mesh of given parts
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		public void DeletePolygons(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_deletePolygons(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_deleteTangents(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Remove tangent attributes on tessellations
		/// </summary>
		/// <param name="occurrences">Occurrences of components to delete</param>
		public void DeleteTangents(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_deleteTangents(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_deleteTextureCoordinates(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 channel);
		/// <summary>
		/// Delete texture coordinates on tessellations
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="channel">Choose Texture coordinates channel to delete (-1 for all channels)</param>
		public void DeleteTextureCoordinates(Scene.OccurrenceList occurrences, System.Int32 channel = -1) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_deleteTextureCoordinates(api.Session, occurrences_c, channel);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_deleteVisibilityPatches(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// delete the visibility patches of given occurrences
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		public void DeleteVisibilityPatches(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_deleteVisibilityPatches(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Double Algo_evalDecimateErrorForTarget(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, DecimateOptionsSelector_c TargetStrategy, System.Double boundaryWeight, System.Double normalWeight, System.Double UVWeight, System.Double sharpNormalWeight, System.Double UVSeamWeight, System.Byte forbidUVFoldovers, System.Byte protectTopology);
		/// <summary>
		/// returns the max error to set to reach a given target
		/// </summary>
		/// <param name="occurrences">List of occurrences to process</param>
		/// <param name="TargetStrategy">Select between targetCount or ratio to define the number of triangles left after the decimation process</param>
		/// <param name="boundaryWeight">Defines how important the edges defining the mesh boundaries (free edges) are during the decimation process, to preserve them from distortion</param>
		/// <param name="normalWeight">Defines how important vertex normals are during the decimation process, to preserve the smoothing of the mesh from being damaged</param>
		/// <param name="UVWeight">Defines how important UVs (texture coordinates) are during the decimation process, to preserve them from being distorted (along with the textures using the UVs)</param>
		/// <param name="sharpNormalWeight">Defines how important sharp edges (or hard edges) are during the decimation process, to preserve them from being distorted</param>
		/// <param name="UVSeamWeight">Defines how important UV seams (UV islands contours) are during the decimation process, to preserve them from being distorted (along with the textures using the UVs)</param>
		/// <param name="forbidUVFoldovers">Forbids UVs to fold over and overlap each other during the decimation</param>
		/// <param name="protectTopology">If False, the topology of the mesh can change and some edges can become non-manifold; but the visual quality will be better on model with complex topology</param>
		public System.Double EvalDecimateErrorForTarget(Scene.OccurrenceList occurrences, DecimateOptionsSelector TargetStrategy, System.Double boundaryWeight = 1, System.Double normalWeight = 1, System.Double UVWeight = 1, System.Double sharpNormalWeight = 1, System.Double UVSeamWeight = 10, System.Boolean forbidUVFoldovers = true, System.Boolean protectTopology = false) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var TargetStrategy_c = new Algo.DecimateOptionsSelector_c();
			ConvertValue((Algo.DecimateOptionsSelector)TargetStrategy, ref TargetStrategy_c);
			var ret = Algo_evalDecimateErrorForTarget(api.Session, occurrences_c, TargetStrategy_c, boundaryWeight, normalWeight, UVWeight, sharpNormalWeight, UVSeamWeight, Convert.ToByte(forbidUVFoldovers), Convert.ToByte(protectTopology));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Algo.AlgoInterface.Algo_DecimateOptionsSelector_free(ref TargetStrategy_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Double)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_extractNeutralAxis(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double maxDiameter, System.Byte removeOriginalMesh);
		/// <summary>
		/// Extract neutral axis from tessellations
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="maxDiameter">Maximum diameter of beams</param>
		/// <param name="removeOriginalMesh">Remove or not the original mesh at the end of the algorithm</param>
		public void ExtractNeutralAxis(Scene.OccurrenceList occurrences, System.Double maxDiameter, System.Boolean removeOriginalMesh) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_extractNeutralAxis(api.Session, occurrences_c, maxDiameter, Convert.ToByte(removeOriginalMesh));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_filletMesh(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double value, Int32 filletingMode, Int32 subdivisionNb, System.Byte createFlatChamfer, System.UInt32 material);
		/// <summary>
		/// Fillet a mesh according to its Lines of Interest
		/// </summary>
		/// <param name="occurrences">Input occurrences</param>
		/// <param name="value">Value (mm)</param>
		/// <param name="filletingMode">Filleting mode</param>
		/// <param name="subdivisionNb">Number of subdivision</param>
		/// <param name="createFlatChamfer">If there is 0 subdivision, should the fillet be a planar flat chamfer?</param>
		/// <param name="material">Material to apply to created fillets. Default: use a random neighbor material</param>
		public void FilletMesh(Scene.OccurrenceList occurrences, System.Double value, FilletingMode filletingMode = (Algo.FilletingMode)0, System.Int32 subdivisionNb = 0, System.Boolean createFlatChamfer = false, System.UInt32 material = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_filletMesh(api.Session, occurrences_c, value, (int)filletingMode, subdivisionNb, Convert.ToByte(createFlatChamfer), material);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_filterHiddenPolygons(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double voxelSize);
		/// <summary>
		/// remove hidden polygons using voxels and cavities
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="voxelSize">Size of voxels</param>
		public void FilterHiddenPolygons(Scene.OccurrenceList occurrences, System.Double voxelSize) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_filterHiddenPolygons(api.Session, occurrences_c, voxelSize);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Geom.Matrix4_c Algo_findBestPivotBetweenOccurrences(IntPtr _pxz_session_, Scene.OccurrenceList_c assembly1, Scene.OccurrenceList_c assembly2, System.Double precision);
		/// <summary>
		/// Try to compute the pivot point between 2 sets of occurrences
		/// </summary>
		/// <param name="assembly1">Set occurrences 1</param>
		/// <param name="assembly2">Set occurrences 2</param>
		/// <param name="precision">Precision used to determine if elements are similar</param>
		public Geom.Matrix4 FindBestPivotBetweenOccurrences(Scene.OccurrenceList assembly1, Scene.OccurrenceList assembly2, System.Double precision = -1) {
			var assembly1_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)assembly1, ref assembly1_c);
			var assembly2_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)assembly2, ref assembly2_c);
			var ret = Algo_findBestPivotBetweenOccurrences(api.Session, assembly1_c, assembly2_c, precision);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref assembly1_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref assembly2_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Geom.GeomInterface.ConvertValue(ref ret);
			Geom.GeomInterface.Geom_Matrix4_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetAllAxisFromCADModelReturn_c Algo_getAllAxisFromCADModel(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Return all the main axis contained in the CAD models given
		/// </summary>
		/// <param name="occurrences">Occurrences of components to check</param>
		public Algo.GetAllAxisFromCADModelReturn GetAllAxisFromCADModel(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_getAllAxisFromCADModel(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			Algo.GetAllAxisFromCADModelReturn retStruct = new Algo.GetAllAxisFromCADModelReturn();
			retStruct.occurrences = ConvertValue(ref ret.occurrences);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref ret.occurrences);
			retStruct.axis = ConvertValue(ref ret.axis);
			Geom.GeomInterface.Geom_Matrix4ListList_free(ref ret.axis);
			return retStruct;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Int32 Algo_getOptimalTextureResolution(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double texelPerMm);
		/// <summary>
		/// Returns the optimal resolution based on a number of texels per 3D space units (e.g : mm)
		/// </summary>
		/// <param name="occurrences">Occurrences on which to compute optimal texture resolution</param>
		/// <param name="texelPerMm">Number of texel per millimeter in a 3D space</param>
		public System.Int32 GetOptimalTextureResolution(Scene.OccurrenceList occurrences, System.Double texelPerMm) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_getOptimalTextureResolution(api.Session, occurrences_c, texelPerMm);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Int32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Polygonal.TessellationList_c Algo_getTessellations(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// returns all the tessellation of the given occurrences (only returns editable mesh, see algo.toEditableMesh)
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		public Polygonal.TessellationList GetTessellations(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_getTessellations(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Polygonal.PolygonalInterface.ConvertValue(ref ret);
			Polygonal.PolygonalInterface.Polygonal_TessellationList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Double Algo_getUV3dRatio(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Returns the ratio of size between UV and 3D (max value, actually at the 90th percentil)
		/// </summary>
		/// <param name="occurrences">Occurrences on which to compute optimal texture resolution</param>
		public System.Double GetUV3dRatio(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_getUV3dRatio(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Double)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetVisibilityStatsReturn_c Algo_getVisibilityStats(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// returns the visibility statistics for some occurrences
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		public Algo.GetVisibilityStatsReturn GetVisibilityStats(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_getVisibilityStats(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			Algo.GetVisibilityStatsReturn retStruct = new Algo.GetVisibilityStatsReturn();
			retStruct.visibleCountFront = (System.Int32)ret.visibleCountFront;
			retStruct.visibleCountBack = (System.Int32)ret.visibleCountBack;
			return retStruct;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Algo_getVoxelTessellation(IntPtr _pxz_session_, Core.DoubleList_c voxels, System.Double threshold);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="voxels"></param>
		/// <param name="threshold"></param>
		public System.UInt32 GetVoxelTessellation(Core.DoubleList voxels, System.Double threshold = 0.99) {
			var voxels_c = new Core.DoubleList_c();
			Core.CoreInterface.ConvertValue((Core.DoubleList)voxels, ref voxels_c);
			var ret = Algo_getVoxelTessellation(api.Session, voxels_c, threshold);
			Core.CoreInterface.Core_DoubleList_free(ref voxels_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_identifyPatches(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Byte useAttributesFilter, System.Double sharpAngleFilter, System.Byte useBoundaryFilter, System.Byte useNonManifoldFilter, System.Byte useLineEdgeFilter, System.Byte useQuadLineFilter);
		/// <summary>
		/// Create cad patches on tessellation (needed by some functions)
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="useAttributesFilter">Filters by attributes</param>
		/// <param name="sharpAngleFilter">Sharp angle in degree to filter by edges sharpness, if the angle is negative do not filter</param>
		/// <param name="useBoundaryFilter">Filters by boundaries</param>
		/// <param name="useNonManifoldFilter">Filters by manifold-ness</param>
		/// <param name="useLineEdgeFilter">Filters by edge</param>
		/// <param name="useQuadLineFilter">Filters by quad lines</param>
		public void IdentifyPatches(Scene.OccurrenceList occurrences, System.Boolean useAttributesFilter = true, System.Double sharpAngleFilter = 45, System.Boolean useBoundaryFilter = true, System.Boolean useNonManifoldFilter = true, System.Boolean useLineEdgeFilter = true, System.Boolean useQuadLineFilter = false) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_identifyPatches(api.Session, occurrences_c, Convert.ToByte(useAttributesFilter), sharpAngleFilter, Convert.ToByte(useBoundaryFilter), Convert.ToByte(useNonManifoldFilter), Convert.ToByte(useLineEdgeFilter), Convert.ToByte(useQuadLineFilter));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_identifySharpEdges(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double minSharpAngle, System.Double maxSharpAngle, Int32 convexity, System.Byte onlyExplicitSharp);
		/// <summary>
		/// Mark as Lines Of Interest the sharp edges 
		/// </summary>
		/// <param name="occurrences">Input occurrences</param>
		/// <param name="minSharpAngle">The angle between the normals - all edges sharpest than this will be filleted</param>
		/// <param name="maxSharpAngle">All edges sharpest than this won't be filleted</param>
		/// <param name="convexity">Fillet sharp edges that are convex, concave or both</param>
		/// <param name="onlyExplicitSharp">If toggled, if the explicit normals of an edge says the transition is smooth, the edge won't be selected</param>
		public void IdentifySharpEdges(Scene.OccurrenceList occurrences, System.Double minSharpAngle, System.Double maxSharpAngle = 180, ConvexityFilter convexity = (Algo.ConvexityFilter)2, System.Boolean onlyExplicitSharp = false) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_identifySharpEdges(api.Session, occurrences_c, minSharpAngle, maxSharpAngle, (int)convexity, Convert.ToByte(onlyExplicitSharp));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_lineToCylinderCAD(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double radius);
		/// <summary>
		/// Change lines into cylinders
		/// </summary>
		/// <param name="occurrences">Occurrence of components to reverse</param>
		/// <param name="radius">Size of the radius of the cylinders</param>
		public void LineToCylinderCAD(Scene.OccurrenceList occurrences, System.Double radius) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_lineToCylinderCAD(api.Session, occurrences_c, radius);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_lineToTexture(IntPtr _pxz_session_, Scene.OccurrenceList_c lines, UseColorOption_c useColor, Int32 resolution, Int32 thickness);
		/// <summary>
		/// Generate a textured quadrangle over an existing mesh of coplanar lines
		/// </summary>
		/// <param name="lines">Lines to select</param>
		/// <param name="useColor">Set color policy.</param>
		/// <param name="resolution">Texture resolution</param>
		/// <param name="thickness">The thickness of the lines in pixels</param>
		public void LineToTexture(Scene.OccurrenceList lines, UseColorOption useColor, System.Int32 resolution = 512, System.Int32 thickness = 5) {
			var lines_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)lines, ref lines_c);
			var useColor_c = new Algo.UseColorOption_c();
			ConvertValue((Algo.UseColorOption)useColor, ref useColor_c);
			Algo_lineToTexture(api.Session, lines_c, useColor_c, resolution, thickness);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref lines_c);
			Algo.AlgoInterface.Algo_UseColorOption_free(ref useColor_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern OccurrenceFeaturesList_c Algo_listFeatures(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Byte throughHoles, System.Byte blindHoles, System.Double maxDiameter);
		/// <summary>
		/// List features from tessellations
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="throughHoles">List through holes</param>
		/// <param name="blindHoles">List blind holes</param>
		/// <param name="maxDiameter">Maximum diameter of the holes to be list (-1=no max diameter)</param>
		public OccurrenceFeaturesList ListFeatures(Scene.OccurrenceList occurrences, System.Boolean throughHoles = true, System.Boolean blindHoles = false, System.Double maxDiameter = -1) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_listFeatures(api.Session, occurrences_c, Convert.ToByte(throughHoles), Convert.ToByte(blindHoles), maxDiameter);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Algo.AlgoInterface.Algo_OccurrenceFeaturesList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_loopSubdivMesh(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 depth);
		/// <summary>
		/// Apply Loop Subdivision on Triangle-only Mesh
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="depth">Subdivision depth</param>
		public void LoopSubdivMesh(Scene.OccurrenceList occurrences, System.Int32 depth) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_loopSubdivMesh(api.Session, occurrences_c, depth);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_mergeVertices(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double maxDistance, Polygonal.TopologyCategoryMask_c mask);
		/// <summary>
		/// merge near vertices according to the given distance
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="maxDistance">Maximum distance between two vertex to merge</param>
		/// <param name="mask">Topological category of the vertices to merge</param>
		public void MergeVertices(Scene.OccurrenceList occurrences, System.Double maxDistance, Polygonal.TopologyCategoryMask mask) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var mask_c = new Polygonal.TopologyCategoryMask_c();
			Polygonal.PolygonalInterface.ConvertValue((Polygonal.TopologyCategoryMask)mask, ref mask_c);
			Algo_mergeVertices(api.Session, occurrences_c, maxDistance, mask_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Polygonal.PolygonalInterface.Polygonal_TopologyCategoryMask_free(ref mask_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Double Algo_meshComparison(IntPtr _pxz_session_, System.UInt32 mesh_1, System.UInt32 mesh_2);
		/// <summary>
		/// compare two meshes
		/// </summary>
		/// <param name="mesh_1"></param>
		/// <param name="mesh_2"></param>
		public System.Double MeshComparison(System.UInt32 mesh_1, System.UInt32 mesh_2) {
			var ret = Algo_meshComparison(api.Session, mesh_1, mesh_2);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Double)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Geom.DistanceList_c Algo_meshComparisonBatch(IntPtr _pxz_session_, Scene.OccurrenceList_c meshes1, Scene.OccurrenceList_c meshes2);
		/// <summary>
		/// compare each couple of meshes and returns the maximum for each couple
		/// </summary>
		/// <param name="meshes1"></param>
		/// <param name="meshes2"></param>
		public Geom.DistanceList MeshComparisonBatch(Scene.OccurrenceList meshes1, Scene.OccurrenceList meshes2) {
			var meshes1_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)meshes1, ref meshes1_c);
			var meshes2_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)meshes2, ref meshes2_c);
			var ret = Algo_meshComparisonBatch(api.Session, meshes1_c, meshes2_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref meshes1_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref meshes2_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Geom.GeomInterface.ConvertValue(ref ret);
			Geom.GeomInterface.Geom_DistanceList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Geom.Point3ListList_c Algo_meshIntersections(IntPtr _pxz_session_, System.UInt32 occurrence1, System.UInt32 occurrence2);
		/// <summary>
		/// Computes the intersections between the meshes of two occurrences
		/// </summary>
		/// <param name="occurrence1">First Occurrence</param>
		/// <param name="occurrence2">Second Occurrence</param>
		public Geom.Point3ListList MeshIntersections(System.UInt32 occurrence1, System.UInt32 occurrence2) {
			var ret = Algo_meshIntersections(api.Session, occurrence1, occurrence2);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Geom.GeomInterface.ConvertValue(ref ret);
			Geom.GeomInterface.Geom_Point3ListList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_noiseMesh(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double maxAmplitude);
		/// <summary>
		/// Apply noise to vertex positions along their normals
		/// </summary>
		/// <param name="occurrences">Part occurrencess to noise</param>
		/// <param name="maxAmplitude">Maximum distance between original vertex and noisy vertex</param>
		public void NoiseMesh(Scene.OccurrenceList occurrences, System.Double maxAmplitude) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_noiseMesh(api.Session, occurrences_c, maxAmplitude);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_optimizeCADLoops(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Optimize CAD Face loops by merging useless loop edges
		/// </summary>
		/// <param name="occurrences">Occurrences of components to optimize</param>
		public void OptimizeCADLoops(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_optimizeCADLoops(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_optimizeForRendering(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Optimize mesh for rendering (lossless, only reindexing)
		/// </summary>
		/// <param name="occurrences">Occurrences of components to optimize</param>
		public void OptimizeForRendering(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_optimizeForRendering(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_optimizeSubMeshes(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Sort sub meshes by materials
		/// </summary>
		/// <param name="occurrences">Part occurrencess to process</param>
		public void OptimizeSubMeshes(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_optimizeSubMeshes(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_optimizeTextureSize(IntPtr _pxz_session_, System.UInt32 root, System.Double texelPerMm);
		/// <summary>
		/// Resizes scene textures based on a number of texels per 3D space units (e.g: mm)
		/// </summary>
		/// <param name="root">Root from which texture resizing will process</param>
		/// <param name="texelPerMm">Number of texel per millimeter in a 3D space</param>
		public void OptimizeTextureSize(System.UInt32 root, System.Double texelPerMm) {
			Algo_optimizeTextureSize(api.Session, root, texelPerMm);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_printPivotPointAsDotFile(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="occurrences">Occurrences of components to check</param>
		public void PrintPivotPointAsDotFile(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_printPivotPointAsDotFile(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_removeHoles(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Byte throughHoles, System.Byte blindHoles, System.Byte surfacicHoles, System.Double maxDiameter, System.UInt32 fillWithMaterial);
		/// <summary>
		/// Remove some features from tessellations
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="throughHoles">Remove through holes</param>
		/// <param name="blindHoles">Remove blind holes</param>
		/// <param name="surfacicHoles">Remove surfacic holes</param>
		/// <param name="maxDiameter">Maximum diameter of the holes to be removed (-1=no max diameter)</param>
		/// <param name="fillWithMaterial">If set, the given material will be used to fill the holes</param>
		public void RemoveHoles(Scene.OccurrenceList occurrences, System.Boolean throughHoles, System.Boolean blindHoles, System.Boolean surfacicHoles, System.Double maxDiameter, System.UInt32 fillWithMaterial = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_removeHoles(api.Session, occurrences_c, Convert.ToByte(throughHoles), Convert.ToByte(blindHoles), Convert.ToByte(surfacicHoles), maxDiameter, fillWithMaterial);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_repairCAD(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double tolerance, System.Byte orient);
		/// <summary>
		/// Repair CAD shapes, assemble faces, remove duplicated faces, optimize loops and repair topology
		/// </summary>
		/// <param name="occurrences">Occurrences of components to clean</param>
		/// <param name="tolerance">Tolerance</param>
		/// <param name="orient">If true reorient the model</param>
		public void RepairCAD(Scene.OccurrenceList occurrences, System.Double tolerance, System.Boolean orient = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_repairCAD(api.Session, occurrences_c, tolerance, Convert.ToByte(orient));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_segmentByDistorsion(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double localThreshold, System.Double globalThreshold);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="localThreshold"></param>
		/// <param name="globalThreshold"></param>
		public void SegmentByDistorsion(Scene.OccurrenceList occurrences, System.Double localThreshold, System.Double globalThreshold) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_segmentByDistorsion(api.Session, occurrences_c, localThreshold, globalThreshold);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_setFeatureComponentMaxIndex(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 maxIndex);
		/// <summary>
		/// Remap Index map of each FeatureComponent of selected occurrences
		/// </summary>
		/// <param name="occurrences"></param>
		/// <param name="maxIndex"></param>
		public void SetFeatureComponentMaxIndex(Scene.OccurrenceList occurrences, System.Int32 maxIndex) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_setFeatureComponentMaxIndex(api.Session, occurrences_c, maxIndex);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_smoothMesh(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 mode, Int32 maxIterations, System.Byte lockSignificantEdges);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="mode">Computation of cost</param>
		/// <param name="maxIterations">Maximum number of swapping iteration</param>
		/// <param name="lockSignificantEdges">Forbid to swap significant edges (e.g. UV seams, sharp edges, patch borders, ...)</param>
		public void SmoothMesh(Scene.OccurrenceList occurrences, CostEvaluation mode, System.Int32 maxIterations = 100, System.Boolean lockSignificantEdges = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_smoothMesh(api.Session, occurrences_c, (int)mode, maxIterations, Convert.ToByte(lockSignificantEdges));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_splitUVForAtlas(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="occurrences">Input occurrences</param>
		public void SplitUVForAtlas(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_splitUVForAtlas(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_sweep(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double radius, Int32 sides, System.Byte createNormals, System.Byte keepLines, System.Byte generateUV);
		/// <summary>
		/// Extrudes a circular section along an underlying polyline (curve)
		/// </summary>
		/// <param name="occurrences">Occurrences of components to check</param>
		/// <param name="radius">Radius of cylinders</param>
		/// <param name="sides">Number of points to create cylinders</param>
		/// <param name="createNormals"></param>
		/// <param name="keepLines"></param>
		/// <param name="generateUV"></param>
		public void Sweep(Scene.OccurrenceList occurrences, System.Double radius, System.Int32 sides, System.Boolean createNormals, System.Boolean keepLines, System.Boolean generateUV) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_sweep(api.Session, occurrences_c, radius, sides, Convert.ToByte(createNormals), Convert.ToByte(keepLines), Convert.ToByte(generateUV));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_tessellate(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double maxSag, System.Double maxLength, System.Double maxAngle, System.Byte createNormals, Int32 uvMode, Int32 uvChannel, System.Double uvPadding, System.Byte createTangents, System.Byte createFreeEdges, System.Byte keepBRepShape, System.Byte overrideExistingTessellation);
		/// <summary>
		/// Create a tessellated representation from a CAD representation for each given part
		/// </summary>
		/// <param name="occurrences">Occurrences of components to tessellate</param>
		/// <param name="maxSag">Maximum distance between the geometry and the tessellation</param>
		/// <param name="maxLength">Maximum length of elements</param>
		/// <param name="maxAngle">Maximum angle between normals of two adjacent elements</param>
		/// <param name="createNormals">If true, normals will be generated</param>
		/// <param name="uvMode">Select the texture coordinates generation mode</param>
		/// <param name="uvChannel">The UV channel of the generated texture coordinates (if any)</param>
		/// <param name="uvPadding">The UV padding between UV island in UV coordinate space (between 0-1). This parameter is handled as an heuristic so it might not be respected</param>
		/// <param name="createTangents">If true, tangents will be generated</param>
		/// <param name="createFreeEdges">If true, free edges will be created for each patch borders</param>
		/// <param name="keepBRepShape">If true, BRep shapes will be kept for Back to Brep or Retessellate</param>
		/// <param name="overrideExistingTessellation">If true, already tessellated parts will be re-tessellated</param>
		public void Tessellate(Scene.OccurrenceList occurrences, System.Double maxSag, System.Double maxLength, System.Double maxAngle, System.Boolean createNormals = true, UVGenerationMode uvMode = (Algo.UVGenerationMode)0, System.Int32 uvChannel = 1, System.Double uvPadding = 0.0, System.Boolean createTangents = false, System.Boolean createFreeEdges = false, System.Boolean keepBRepShape = true, System.Boolean overrideExistingTessellation = false) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_tessellate(api.Session, occurrences_c, maxSag, maxLength, maxAngle, Convert.ToByte(createNormals), (int)uvMode, uvChannel, uvPadding, Convert.ToByte(createTangents), Convert.ToByte(createFreeEdges), Convert.ToByte(keepBRepShape), Convert.ToByte(overrideExistingTessellation));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_tessellatePointClouds(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 kNeighbors, System.Byte keepPoints, System.Byte colorize);
		/// <summary>
		/// Tessellate point clouds to replace the geometry with a polygonal connect mesh
		/// </summary>
		/// <param name="occurrences"></param>
		/// <param name="kNeighbors">The number of neighbor points used to compute normals</param>
		/// <param name="keepPoints">Keep points after meshing if enabled</param>
		/// <param name="colorize">If enabled, vertex colors will be generated on the resulting mesh</param>
		public void TessellatePointClouds(Scene.OccurrenceList occurrences, System.Int32 kNeighbors = 20, System.Boolean keepPoints = false, System.Boolean colorize = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_tessellatePointClouds(api.Session, occurrences_c, kNeighbors, Convert.ToByte(keepPoints), Convert.ToByte(colorize));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_tessellateRelativelyToAABB(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double maxSag, System.Double sagRatio, System.Double maxLength, System.Double maxAngle, System.Byte createNormals, Int32 uvMode, Int32 uvChannel, System.Double uvPadding, System.Byte createTangents, System.Byte createFreeEdges, System.Byte keepBRepShape, System.Byte overrideExistingTessellation);
		/// <summary>
		/// Creates a tessellated representation from a CAD representation for each given part. It multiplies the length of the diagonal of the bounding box by the sagRatio. If the output value is above maxSag, then maxSag is used as tessellation value. Else if the output value is below maxSag, it is used as tessellation value.
		/// </summary>
		/// <param name="occurrences">Occurrences of components to tessellate</param>
		/// <param name="maxSag">Maximum distance between the geometry and the tessellation</param>
		/// <param name="sagRatio">Maximum ratio distance between the geometry and the tessellation</param>
		/// <param name="maxLength">Maximum length of elements</param>
		/// <param name="maxAngle">Maximum angle between normals of two adjacent elements</param>
		/// <param name="createNormals">If true, normals will be generated</param>
		/// <param name="uvMode">Select the texture coordinates generation mode</param>
		/// <param name="uvChannel">The UV channel of the generated texture coordinates (if any)</param>
		/// <param name="uvPadding">The UV padding between UV island in UV coordinate space (between 0-1). This parameter is handled as an heuristic so it might not be respected</param>
		/// <param name="createTangents">If true, tangents will be generated</param>
		/// <param name="createFreeEdges">If true, free edges will be created for each patch borders</param>
		/// <param name="keepBRepShape">If true, BRep shapes will be kept for Back to Brep or Retessellate</param>
		/// <param name="overrideExistingTessellation">If true, already tessellated parts will be re-tessellated</param>
		public void TessellateRelativelyToAABB(Scene.OccurrenceList occurrences, System.Double maxSag, System.Double sagRatio, System.Double maxLength, System.Double maxAngle, System.Boolean createNormals = true, UVGenerationMode uvMode = (Algo.UVGenerationMode)0, System.Int32 uvChannel = 1, System.Double uvPadding = 0.0, System.Boolean createTangents = false, System.Boolean createFreeEdges = false, System.Boolean keepBRepShape = true, System.Boolean overrideExistingTessellation = false) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_tessellateRelativelyToAABB(api.Session, occurrences_c, maxSag, sagRatio, maxLength, maxAngle, Convert.ToByte(createNormals), (int)uvMode, uvChannel, uvPadding, Convert.ToByte(createTangents), Convert.ToByte(createFreeEdges), Convert.ToByte(keepBRepShape), Convert.ToByte(overrideExistingTessellation));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_voxelizePointClouds(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double voxelSize);
		/// <summary>
		/// Explode point clouds to voxels
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="voxelSize">Size of voxels</param>
		public void VoxelizePointClouds(Scene.OccurrenceList occurrences, System.Double voxelSize = 500) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_voxelizePointClouds(api.Session, occurrences_c, voxelSize);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region Baking

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_bakeUV(IntPtr _pxz_session_, System.UInt32 source, System.UInt32 destination, Int32 sourceChannel, Int32 destinationChannel, System.Double tolerance);
		/// <summary>
		/// Bake UV from a mesh to another mesh
		/// </summary>
		/// <param name="source">Occurrence of the source mesh</param>
		/// <param name="destination">Occurrence of the destination mesh</param>
		/// <param name="sourceChannel">Source UV channel to bake</param>
		/// <param name="destinationChannel">Destination UV channel to bake to</param>
		/// <param name="tolerance">Tolerance when point is projected on seam (if the model come from a decimation it is recommended to use the lineic tolerance here)</param>
		public void BakeUV(System.UInt32 source, System.UInt32 destination, System.Int32 sourceChannel = 0, System.Int32 destinationChannel = 0, System.Double tolerance = 0.001) {
			Algo_bakeUV(api.Session, source, destination, sourceChannel, destinationChannel, tolerance);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_combineMaterials(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, BakeOption_c bakingOptions, System.Byte overrideExistingUVs, System.Byte singularizeOnAO);
		/// <summary>
		/// Combine all given meshes to one mesh with one material (baked)
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="bakingOptions">Baking options</param>
		/// <param name="overrideExistingUVs">If True, override existing UVs on channel</param>
		/// <param name="singularizeOnAO">If true, singularize all instances in the selected subtree if we want to bake AO in the texture</param>
		public void CombineMaterials(Scene.OccurrenceList occurrences, BakeOption bakingOptions, System.Boolean overrideExistingUVs = true, System.Boolean singularizeOnAO = false) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var bakingOptions_c = new Algo.BakeOption_c();
			ConvertValue((Algo.BakeOption)bakingOptions, ref bakingOptions_c);
			Algo_combineMaterials(api.Session, occurrences_c, bakingOptions_c, Convert.ToByte(overrideExistingUVs), Convert.ToByte(singularizeOnAO));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Algo.AlgoInterface.Algo_BakeOption_free(ref bakingOptions_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Algo_combineMeshes(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, BakeOption_c bakingOptions, System.Byte overrideExistingUVs);
		/// <summary>
		/// Combine all given meshes to one mesh with one material (baked)
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="bakingOptions">Baking options</param>
		/// <param name="overrideExistingUVs">If True, override existing UVs on channel</param>
		public System.UInt32 CombineMeshes(Scene.OccurrenceList occurrences, BakeOption bakingOptions, System.Boolean overrideExistingUVs = false) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var bakingOptions_c = new Algo.BakeOption_c();
			ConvertValue((Algo.BakeOption)bakingOptions, ref bakingOptions_c);
			var ret = Algo_combineMeshes(api.Session, occurrences_c, bakingOptions_c, Convert.ToByte(overrideExistingUVs));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Algo.AlgoInterface.Algo_BakeOption_free(ref bakingOptions_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		#endregion

		#region Decomposition

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Scene.OccurrenceList_c Algo_convexDecomposition(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 maxCount, Int32 vertexCount, System.Byte approximate, Int32 resolution, System.Double concavity);
		/// <summary>
		/// Explode each mesh to approximated convex decomposition
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="maxCount">Maximum number of convex hull to generated</param>
		/// <param name="vertexCount">Maximum number of vertices per convex hull</param>
		/// <param name="approximate">Approximate method</param>
		/// <param name="resolution">Resolution</param>
		/// <param name="concavity">Concavity</param>
		public Scene.OccurrenceList ConvexDecomposition(Scene.OccurrenceList occurrences, System.Int32 maxCount, System.Int32 vertexCount, System.Boolean approximate, System.Int32 resolution = 100000, System.Double concavity = 0.001) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_convexDecomposition(api.Session, occurrences_c, maxCount, vertexCount, Convert.ToByte(approximate), resolution, concavity);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Scene.SceneInterface.ConvertValue(ref ret);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_explodeBodies(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Byte groupOpenShells);
		/// <summary>
		/// Explode all CAD Parts by body. New parts will be placed as children of input part occurrences.
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="groupOpenShells">Group all open shells in one part</param>
		public void ExplodeBodies(Scene.OccurrenceList occurrences, System.Boolean groupOpenShells = false) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_explodeBodies(api.Session, occurrences_c, Convert.ToByte(groupOpenShells));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_explodeByMaterials(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Explode all parts by material. New parts will be placed as children of input part occurrences.
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		public void ExplodeByMaterials(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_explodeByMaterials(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_explodeByVertexCount(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 maxVertexCount, Int32 maxTriangleCount, System.Byte countMergedVerticesOnce);
		/// <summary>
		/// Explode part occurrences to respect a maximum vertex count
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="maxVertexCount">The maximum number of vertices by part</param>
		/// <param name="maxTriangleCount">The maximum number of triangles by part (quadrangles count twice)</param>
		/// <param name="countMergedVerticesOnce">If true, one vertex used in several triangles with different normals will be counted once (for Unity must be False)</param>
		public void ExplodeByVertexCount(Scene.OccurrenceList occurrences, System.Int32 maxVertexCount, System.Int32 maxTriangleCount, System.Boolean countMergedVerticesOnce = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_explodeByVertexCount(api.Session, occurrences_c, maxVertexCount, maxTriangleCount, Convert.ToByte(countMergedVerticesOnce));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_explodeByVoxel(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double voxelSize);
		/// <summary>
		/// Explode parts by voxel. New parts will be placed as children of input part occurrences.
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="voxelSize">Voxel size</param>
		public void ExplodeByVoxel(Scene.OccurrenceList occurrences, System.Double voxelSize) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_explodeByVoxel(api.Session, occurrences_c, voxelSize);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_explodeConnectedMeshes(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Explode connected set of polygons to part occurrences. New parts will be placed as children of input part occurrences.
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		public void ExplodeConnectedMeshes(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_explodeConnectedMeshes(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_explodePatches(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Explode all parts by patch
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		public void ExplodePatches(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_explodePatches(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region Hackaton

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern LegoReturn_c Algo_legoDecomposition(IntPtr _pxz_session_, System.UInt32 root, CAD.LegoBrickDefinitionList_c bricks, Core.ColorList_c colors, Int32 density, System.Byte forceFillingWithSmallBricks);
		/// <summary>
		/// Decompose a model in a set of lego bricks
		/// </summary>
		/// <param name="root">The model root occurrence</param>
		/// <param name="bricks"></param>
		/// <param name="colors"></param>
		/// <param name="density"></param>
		/// <param name="forceFillingWithSmallBricks"></param>
		public LegoReturn LegoDecomposition(System.UInt32 root, CAD.LegoBrickDefinitionList bricks, Core.ColorList colors, System.Int32 density = 100, System.Boolean forceFillingWithSmallBricks = true) {
			var bricks_c = new CAD.LegoBrickDefinitionList_c();
			CAD.CADInterface.ConvertValue((CAD.LegoBrickDefinitionList)bricks, ref bricks_c);
			var colors_c = new Core.ColorList_c();
			Core.CoreInterface.ConvertValue((Core.ColorList)colors, ref colors_c);
			var ret = Algo_legoDecomposition(api.Session, root, bricks_c, colors_c, density, Convert.ToByte(forceFillingWithSmallBricks));
			CAD.CADInterface.CAD_LegoBrickDefinitionList_free(ref bricks_c);
			Core.CoreInterface.Core_ColorList_free(ref colors_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Algo.AlgoInterface.Algo_LegoReturn_free(ref ret);
			return convRet;
		}

		#endregion

		#region Hidden Detection

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_createVisibilityInformation(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 level, Int32 resolution, Int32 sphereCount, System.Double fovX, System.Byte considerTransparentOpaque, System.UInt32 root);
		/// <summary>
		/// Create visilibity information on part occurrences viewed from a set of camera automatically placed on a sphere around the scene
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="level">Level of geometries to remove : Parts, Patches or Polygons</param>
		/// <param name="resolution">Resolution of the visibility viewer</param>
		/// <param name="sphereCount">Segmentation of the sphere sphereCount x sphereCount</param>
		/// <param name="fovX">Horizontal field of view (in degree)</param>
		/// <param name="considerTransparentOpaque">If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque</param>
		/// <param name="root">Specify another root for occluder scene</param>
		public void CreateVisibilityInformation(Scene.OccurrenceList occurrences, SelectionLevel level, System.Int32 resolution, System.Int32 sphereCount, System.Double fovX = 90, System.Boolean considerTransparentOpaque = false, System.UInt32 root = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_createVisibilityInformation(api.Session, occurrences_c, (int)level, resolution, sphereCount, fovX, Convert.ToByte(considerTransparentOpaque), root);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_createVisibilityInformationAdvanced(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double voxelSize, System.Double minimumCavityVolume, Int32 resolution, Int32 mode, System.Byte considerTransparentOpaque, System.UInt32 root);
		/// <summary>
		/// Create visilibity information on part occurrences viewed from a set of voxel based view points.
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="voxelSize">Size of the voxels in mm (smaller it is, more viewpoints there are)</param>
		/// <param name="minimumCavityVolume">Minimum volume of a cavity in cubic meter (smaller it is, more viewpoints there are)</param>
		/// <param name="resolution">Resolution of the visibility viewer</param>
		/// <param name="mode">Select where to place camera (all cavities, only outer or only inner cavities)</param>
		/// <param name="considerTransparentOpaque">If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque</param>
		/// <param name="root">Specify another root for occluder scene</param>
		public void CreateVisibilityInformationAdvanced(Scene.OccurrenceList occurrences, System.Double voxelSize, System.Double minimumCavityVolume, System.Int32 resolution, InnerOuterOption mode = (Algo.InnerOuterOption)0, System.Boolean considerTransparentOpaque = false, System.UInt32 root = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_createVisibilityInformationAdvanced(api.Session, occurrences_c, voxelSize, minimumCavityVolume, resolution, (int)mode, Convert.ToByte(considerTransparentOpaque), root);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_createVisibilityInformationFromViewPoints(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Geom.Point3List_c cameraPositions, Geom.Point3List_c cameraDirections, Geom.Point3List_c cameraUps, Int32 resolution, System.Double fovX, System.Byte considerTransparentOpaque, System.UInt32 root);
		/// <summary>
		/// Create visilibity information on parts viewed from a given set of camera
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="cameraPositions">List of camera positions</param>
		/// <param name="cameraDirections">List of camera directions</param>
		/// <param name="cameraUps">List of camera up vectors</param>
		/// <param name="resolution">Resolution of the visibility viewer</param>
		/// <param name="fovX">Horizontal field of view (in degree)</param>
		/// <param name="considerTransparentOpaque">If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque</param>
		/// <param name="root">Specify another root for occluder scene</param>
		public void CreateVisibilityInformationFromViewPoints(Scene.OccurrenceList occurrences, Geom.Point3List cameraPositions, Geom.Point3List cameraDirections, Geom.Point3List cameraUps, System.Int32 resolution, System.Double fovX = 90, System.Boolean considerTransparentOpaque = false, System.UInt32 root = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var cameraPositions_c = new Geom.Point3List_c();
			Geom.GeomInterface.ConvertValue((Geom.Point3List)cameraPositions, ref cameraPositions_c);
			var cameraDirections_c = new Geom.Point3List_c();
			Geom.GeomInterface.ConvertValue((Geom.Point3List)cameraDirections, ref cameraDirections_c);
			var cameraUps_c = new Geom.Point3List_c();
			Geom.GeomInterface.ConvertValue((Geom.Point3List)cameraUps, ref cameraUps_c);
			Algo_createVisibilityInformationFromViewPoints(api.Session, occurrences_c, cameraPositions_c, cameraDirections_c, cameraUps_c, resolution, fovX, Convert.ToByte(considerTransparentOpaque), root);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Geom.GeomInterface.Geom_Point3List_free(ref cameraPositions_c);
			Geom.GeomInterface.Geom_Point3List_free(ref cameraDirections_c);
			Geom.GeomInterface.Geom_Point3List_free(ref cameraUps_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Scene.OccurrenceList_c Algo_findOccludedPartOccurrences(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 resolution, Int32 sphereCount, System.Double fovX, System.Byte considerTransparentOpaque, System.UInt32 root);
		/// <summary>
		/// get part occurrences viewed from a sphere around the scene
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="resolution">Resolution of the visibility viewer</param>
		/// <param name="sphereCount">Segmentation of the sphere sphereCount x sphereCount</param>
		/// <param name="fovX">Horizontal field of view (in degree)</param>
		/// <param name="considerTransparentOpaque">If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque</param>
		/// <param name="root">Specify another root for occluder scene</param>
		public Scene.OccurrenceList FindOccludedPartOccurrences(Scene.OccurrenceList occurrences, System.Int32 resolution, System.Int32 sphereCount, System.Double fovX = 90, System.Boolean considerTransparentOpaque = false, System.UInt32 root = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_findOccludedPartOccurrences(api.Session, occurrences_c, resolution, sphereCount, fovX, Convert.ToByte(considerTransparentOpaque), root);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Scene.SceneInterface.ConvertValue(ref ret);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Scene.OccurrenceList_c Algo_findOccludedPartOccurrencesAdvanced(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double voxelSize, System.Double minimumCavityVolume, Int32 resolution, Int32 mode, System.Byte considerTransparentOpaque, System.UInt32 root);
		/// <summary>
		/// get part occurrences viewed from a set of voxel based view points.
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="voxelSize">Size of the voxels in mm (smaller it is, more viewpoints there are)</param>
		/// <param name="minimumCavityVolume">Minimum volume of a cavity in cubic meter (smaller it is, more viewpoints there are)</param>
		/// <param name="resolution">Resolution of the visibility viewer</param>
		/// <param name="mode">Select where to place camera (all cavities, only outer or only inner cavities)</param>
		/// <param name="considerTransparentOpaque">If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque</param>
		/// <param name="root">Specify another root for occluder scene</param>
		public Scene.OccurrenceList FindOccludedPartOccurrencesAdvanced(Scene.OccurrenceList occurrences, System.Double voxelSize, System.Double minimumCavityVolume, System.Int32 resolution, InnerOuterOption mode = (Algo.InnerOuterOption)0, System.Boolean considerTransparentOpaque = false, System.UInt32 root = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_findOccludedPartOccurrencesAdvanced(api.Session, occurrences_c, voxelSize, minimumCavityVolume, resolution, (int)mode, Convert.ToByte(considerTransparentOpaque), root);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Scene.SceneInterface.ConvertValue(ref ret);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.BoolList_c Algo_removeOccludedGeometries(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 level, Int32 resolution, Int32 sphereCount, System.Double fovX, System.Byte considerTransparentOpaque, Int32 adjacencyDepth, System.UInt32 root);
		/// <summary>
		/// Delete part occurrences, patches or polygons not viewed from a sphere around the scene
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="level">Level of geometries to remove : Parts, Patches or Polygons</param>
		/// <param name="resolution">Resolution of the visibility viewer</param>
		/// <param name="sphereCount">Segmentation of the sphere sphereCount x sphereCount</param>
		/// <param name="fovX">Horizontal field of view (in degree)</param>
		/// <param name="considerTransparentOpaque">If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque</param>
		/// <param name="adjacencyDepth">Mark neighbors polygons as visible</param>
		/// <param name="root">Specify another root for occluder scene</param>
		public Core.BoolList RemoveOccludedGeometries(Scene.OccurrenceList occurrences, SelectionLevel level, System.Int32 resolution, System.Int32 sphereCount, System.Double fovX = 90, System.Boolean considerTransparentOpaque = false, System.Int32 adjacencyDepth = 1, System.UInt32 root = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_removeOccludedGeometries(api.Session, occurrences_c, (int)level, resolution, sphereCount, fovX, Convert.ToByte(considerTransparentOpaque), adjacencyDepth, root);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Core.CoreInterface.ConvertValue(ref ret);
			Core.CoreInterface.Core_BoolList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.BoolList_c Algo_removeOccludedGeometriesAdvanced(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 level, System.Double voxelSize, System.Double minimumCavityVolume, Int32 resolution, Int32 mode, System.Byte considerTransparentOpaque, Int32 adjacencyDepth, System.UInt32 root);
		/// <summary>
		/// Delete part occurrences, patches or polygons not seen from voxel based view points.
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="level">Level of geometries to remove : Parts, Patches or Polygons</param>
		/// <param name="voxelSize">Size of the voxels in mm (smaller it is, more viewpoints there are)</param>
		/// <param name="minimumCavityVolume">Minimum volume of a cavity in cubic meter (smaller it is, more viewpoints there are)</param>
		/// <param name="resolution">Resolution of the visibility viewer</param>
		/// <param name="mode">Select where to place camera (all cavities, only outer or only inner cavities)</param>
		/// <param name="considerTransparentOpaque">If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque</param>
		/// <param name="adjacencyDepth">Mark neighbors polygons as visible</param>
		/// <param name="root">Specify another root for occluder scene</param>
		public Core.BoolList RemoveOccludedGeometriesAdvanced(Scene.OccurrenceList occurrences, SelectionLevel level, System.Double voxelSize, System.Double minimumCavityVolume, System.Int32 resolution, InnerOuterOption mode = (Algo.InnerOuterOption)0, System.Boolean considerTransparentOpaque = false, System.Int32 adjacencyDepth = 1, System.UInt32 root = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_removeOccludedGeometriesAdvanced(api.Session, occurrences_c, (int)level, voxelSize, minimumCavityVolume, resolution, (int)mode, Convert.ToByte(considerTransparentOpaque), adjacencyDepth, root);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Core.CoreInterface.ConvertValue(ref ret);
			Core.CoreInterface.Core_BoolList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.BoolList_c Algo_removeOccludedGeometriesFromPoints(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 level, Geom.Point3List_c positions, Int32 resolution, Int32 sphereCount, System.Double fovX, System.Byte considerTransparentOpaque, Int32 adjacencyDepth, System.UInt32 root);
		/// <summary>
		/// Delete part occurrences, patches or polygons not viewed from spheres generated with a set of camera position
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="level">Level of parts to remove : Parts, Patches or Polygons</param>
		/// <param name="positions">List of positions</param>
		/// <param name="resolution">Resolution of the visibility viewer</param>
		/// <param name="sphereCount">Segmentation of the sphere sphereCount x sphereCount</param>
		/// <param name="fovX">Horizontal field of view (in degree)</param>
		/// <param name="considerTransparentOpaque">If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque</param>
		/// <param name="adjacencyDepth">Mark neighbors polygons as visible</param>
		/// <param name="root">Specify another root for occluder scene</param>
		public Core.BoolList RemoveOccludedGeometriesFromPoints(Scene.OccurrenceList occurrences, SelectionLevel level, Geom.Point3List positions, System.Int32 resolution, System.Int32 sphereCount, System.Double fovX = 90, System.Boolean considerTransparentOpaque = false, System.Int32 adjacencyDepth = 1, System.UInt32 root = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var positions_c = new Geom.Point3List_c();
			Geom.GeomInterface.ConvertValue((Geom.Point3List)positions, ref positions_c);
			var ret = Algo_removeOccludedGeometriesFromPoints(api.Session, occurrences_c, (int)level, positions_c, resolution, sphereCount, fovX, Convert.ToByte(considerTransparentOpaque), adjacencyDepth, root);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Geom.GeomInterface.Geom_Point3List_free(ref positions_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Core.CoreInterface.ConvertValue(ref ret);
			Core.CoreInterface.Core_BoolList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.BoolList_c Algo_removeOccludedGeometriesFromViewPoints(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 level, Geom.Point3List_c positions, Geom.Point3List_c directions, Geom.Point3List_c ups, Int32 resolution, System.Double fovX, System.Byte considerTransparentOpaque, Int32 adjacencyDepth, System.UInt32 root);
		/// <summary>
		/// Delete part occurrences, patches or polygons not viewed from a set of camera position/orientation
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="level">Level of geometries to remove : Parts, Patches or Polygons</param>
		/// <param name="positions">List of positions</param>
		/// <param name="directions">List of directions</param>
		/// <param name="ups">List of up vectors</param>
		/// <param name="resolution">Resolution of the visibility viewer</param>
		/// <param name="fovX">Horizontal field of view (in degree)</param>
		/// <param name="considerTransparentOpaque">If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque</param>
		/// <param name="adjacencyDepth">Mark neighbors polygons as visible</param>
		/// <param name="root">Specify another root for occluder scene</param>
		public Core.BoolList RemoveOccludedGeometriesFromViewPoints(Scene.OccurrenceList occurrences, SelectionLevel level, Geom.Point3List positions, Geom.Point3List directions, Geom.Point3List ups, System.Int32 resolution, System.Double fovX = 90, System.Boolean considerTransparentOpaque = false, System.Int32 adjacencyDepth = 1, System.UInt32 root = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var positions_c = new Geom.Point3List_c();
			Geom.GeomInterface.ConvertValue((Geom.Point3List)positions, ref positions_c);
			var directions_c = new Geom.Point3List_c();
			Geom.GeomInterface.ConvertValue((Geom.Point3List)directions, ref directions_c);
			var ups_c = new Geom.Point3List_c();
			Geom.GeomInterface.ConvertValue((Geom.Point3List)ups, ref ups_c);
			var ret = Algo_removeOccludedGeometriesFromViewPoints(api.Session, occurrences_c, (int)level, positions_c, directions_c, ups_c, resolution, fovX, Convert.ToByte(considerTransparentOpaque), adjacencyDepth, root);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Geom.GeomInterface.Geom_Point3List_free(ref positions_c);
			Geom.GeomInterface.Geom_Point3List_free(ref directions_c);
			Geom.GeomInterface.Geom_Point3List_free(ref ups_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Core.CoreInterface.ConvertValue(ref ret);
			Core.CoreInterface.Core_BoolList_free(ref ret);
			return convRet;
		}

		#endregion

		#region Reconstruction

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Algo_basicRetopologize(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 targetTriangleCount, System.Byte pureQuad, System.Byte pointCloud);
		/// <summary>
		/// Replace the tessellations of the selected parts by a retopology
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="targetTriangleCount">Target triangle count</param>
		/// <param name="pureQuad">Retopologize to a pure quad mesh if True, else the resulting mesh will be quad dominant but can contains triangles</param>
		/// <param name="pointCloud">Set to true if occurrences are point cloud, else False</param>
		public System.UInt32 BasicRetopologize(Scene.OccurrenceList occurrences, System.Int32 targetTriangleCount, System.Boolean pureQuad, System.Boolean pointCloud) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_basicRetopologize(api.Session, occurrences_c, targetTriangleCount, Convert.ToByte(pureQuad), Convert.ToByte(pointCloud));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Algo_createOcclusionMesh(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 type, System.Double voxelSize, Int32 gap);
		/// <summary>
		/// Compute an occluder or an occludee with the occurrences selected
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="type">Type of what we create</param>
		/// <param name="voxelSize">Size of voxels</param>
		/// <param name="gap">Dilation iterations on the voxel grid</param>
		public System.UInt32 CreateOcclusionMesh(Scene.OccurrenceList occurrences, CreateOccluder type, System.Double voxelSize, System.Int32 gap) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_createOcclusionMesh(api.Session, occurrences_c, (int)type, voxelSize, gap);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Algo_dualContouring(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 minFixedDepth, Int32 maxDepth, System.Double tolerance, System.Byte sameSizeOnAllAxis, Geom.AABB_c aabb);
		/// <summary>
		/// Replace the tessellations of the selected parts by a retopology based on a dual-contouring
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="minFixedDepth">Minimum depth of the octree for removing inside parts</param>
		/// <param name="maxDepth">Maximum depth of the octree for the dual-contouring (defines the minimum polygon size)</param>
		/// <param name="tolerance">Tolerance for the quadric error used for the simplification of the octree</param>
		/// <param name="sameSizeOnAllAxis">If true, use the maximum axis length of the AABB for all axis</param>
		/// <param name="aabb">AABB to use for the root of the octree</param>
		public System.UInt32 DualContouring(Scene.OccurrenceList occurrences, System.Int32 minFixedDepth, System.Int32 maxDepth, System.Double tolerance, System.Boolean sameSizeOnAllAxis, Geom.AABB aabb) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var aabb_c = new Geom.AABB_c();
			Geom.GeomInterface.ConvertValue((Geom.AABB)aabb, ref aabb_c);
			var ret = Algo_dualContouring(api.Session, occurrences_c, minFixedDepth, maxDepth, tolerance, Convert.ToByte(sameSizeOnAllAxis), aabb_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Geom.GeomInterface.Geom_AABB_free(ref aabb_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Algo_dualContouringTarget(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double filteringSize, System.Double voxelSize, System.Double tolerance, System.Byte sameSizeOnAllAxis);
		/// <summary>
		/// Replace the tessellations of the selected parts by a retopology based on a dual-contouring, controlled by a size in millimeter
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="filteringSize">Filtering size - must be a multiple of 2 of voxelSize</param>
		/// <param name="voxelSize">Voxel size used for the reconstruction</param>
		/// <param name="tolerance">Tolerance for the quadric error used for the simplification of the octree</param>
		/// <param name="sameSizeOnAllAxis">If true, use the maximum axis length of the AABB for all axis</param>
		public System.UInt32 DualContouringTarget(Scene.OccurrenceList occurrences, System.Double filteringSize, System.Double voxelSize, System.Double tolerance, System.Boolean sameSizeOnAllAxis) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_dualContouringTarget(api.Session, occurrences_c, filteringSize, voxelSize, tolerance, Convert.ToByte(sameSizeOnAllAxis));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Algo_marchingCubes(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double voxelSize, Int32 elements, Int32 dilation, System.Byte surfacic);
		/// <summary>
		/// Replace the tessellations of the selected parts by a marching cube representation
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="voxelSize">Size of voxels</param>
		/// <param name="elements">Type of elements used to detect the voxels, polygons or points or hybrid</param>
		/// <param name="dilation">Dilation iterations on the voxel grid (only if surfacic=false)</param>
		/// <param name="surfacic">Prefer this mode if the source is surfacic, the result is not guaranteed to be watertight</param>
		public System.UInt32 MarchingCubes(Scene.OccurrenceList occurrences, System.Double voxelSize, ElementFilter elements = (Algo.ElementFilter)0, System.Int32 dilation = 0, System.Boolean surfacic = false) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_marchingCubes(api.Session, occurrences_c, voxelSize, (int)elements, dilation, Convert.ToByte(surfacic));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Algo_proxyMesh(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double voxelSize, Int32 elements, Int32 dilation, System.Byte surfacic);
		/// <summary>
		/// Replace the tessellations of the selected parts by a proxy mesh based on a voxelization
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="voxelSize">Size of voxels</param>
		/// <param name="elements">Type of elements used to detect the voxels, polygons or points or hybrid</param>
		/// <param name="dilation">Dilation iterations on the voxel grid (only if surfacic=false)</param>
		/// <param name="surfacic">Prefer this mode if the source is surfacic, the result is not guaranteed to be watertight</param>
		public System.UInt32 ProxyMesh(Scene.OccurrenceList occurrences, System.Double voxelSize, ElementFilter elements = (Algo.ElementFilter)0, System.Int32 dilation = 0, System.Boolean surfacic = false) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_proxyMesh(api.Session, occurrences_c, voxelSize, (int)elements, dilation, Convert.ToByte(surfacic));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Algo_retopologize(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 targetTriangleCount, System.Byte pureQuad, System.Byte pointCloud, System.Double precision);
		/// <summary>
		/// Replace the tessellations of the selected parts by a retopology of the external hull
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="targetTriangleCount">Target triangle count</param>
		/// <param name="pureQuad">Retopologize to a pure quad mesh if True, else the resulting mesh will be quad dominant but can contains triangles</param>
		/// <param name="pointCloud">Set to true if occurrences are point cloud, else False</param>
		/// <param name="precision">If set, define the precision of the features to preserve</param>
		public System.UInt32 Retopologize(Scene.OccurrenceList occurrences, System.Int32 targetTriangleCount, System.Boolean pureQuad, System.Boolean pointCloud, System.Double precision = -1) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_retopologize(api.Session, occurrences_c, targetTriangleCount, Convert.ToByte(pureQuad), Convert.ToByte(pointCloud), precision);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Algo_retopologizeWithClusterQuadrics(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double voxelSize);
		/// <summary>
		/// Replace the tessellations of the selected parts by a retopology base on cluster quadrics
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="voxelSize">Size of voxels</param>
		public System.UInt32 RetopologizeWithClusterQuadrics(Scene.OccurrenceList occurrences, System.Double voxelSize) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_retopologizeWithClusterQuadrics(api.Session, occurrences_c, voxelSize);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Algo_voxelize(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double voxelSize, Int32 elements, Int32 dilation, System.Byte useCurrentAnimationPosition);
		/// <summary>
		/// Replace the tessellations of the selected parts by a voxelization of the external skin
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="voxelSize">Size of voxels</param>
		/// <param name="elements">Type of elements used to detect the voxels, polygons or points or hybrid</param>
		/// <param name="dilation">Dilation iterations on the voxel grid</param>
		/// <param name="useCurrentAnimationPosition">Use the current animation position instead of the t-pose</param>
		public System.UInt32 Voxelize(Scene.OccurrenceList occurrences, System.Double voxelSize, ElementFilter elements = (Algo.ElementFilter)0, System.Int32 dilation = 0, System.Boolean useCurrentAnimationPosition = false) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_voxelize(api.Session, occurrences_c, voxelSize, (int)elements, dilation, Convert.ToByte(useCurrentAnimationPosition));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		#endregion

		#region Replacement

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_replaceBy(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, ReplaceByOption_c replaceBy);
		/// <summary>
		/// Replace geometries by other shapes, or primitives
		/// </summary>
		/// <param name="occurrences">Occurrences of components to replace</param>
		/// <param name="replaceBy">Shape replacement option</param>
		public void ReplaceBy(Scene.OccurrenceList occurrences, ReplaceByOption replaceBy) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var replaceBy_c = new Algo.ReplaceByOption_c();
			ConvertValue((Algo.ReplaceByOption)replaceBy, ref replaceBy_c);
			Algo_replaceBy(api.Session, occurrences_c, replaceBy_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Algo.AlgoInterface.Algo_ReplaceByOption_free(ref replaceBy_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_replaceByBox(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 boxType);
		/// <summary>
		/// Replace objects by a bounding box
		/// </summary>
		/// <param name="occurrences">Occurrences of components to replace</param>
		/// <param name="boxType">Bounding box type, oriented, axis-aligned, ...</param>
		public void ReplaceByBox(Scene.OccurrenceList occurrences, ReplaceByBoxType boxType) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_replaceByBox(api.Session, occurrences_c, (int)boxType);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_replaceByConvexHull(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Replace objects by convex hull
		/// </summary>
		/// <param name="occurrences">Occurrences of components to replace</param>
		public void ReplaceByConvexHull(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_replaceByConvexHull(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_replaceByPrimitive(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, PrimitiveShapeParameters_c primitive, System.Byte generateUV);
		/// <summary>
		/// Replace objects by a primitive shapes
		/// </summary>
		/// <param name="occurrences">Occurrences of components to replace</param>
		/// <param name="primitive">Primitive type and parameters</param>
		/// <param name="generateUV">Primitive type and parameters</param>
		public void ReplaceByPrimitive(Scene.OccurrenceList occurrences, PrimitiveShapeParameters primitive, System.Boolean generateUV = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var primitive_c = new Algo.PrimitiveShapeParameters_c();
			ConvertValue((Algo.PrimitiveShapeParameters)primitive, ref primitive_c);
			Algo_replaceByPrimitive(api.Session, occurrences_c, primitive_c, Convert.ToByte(generateUV));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Algo.AlgoInterface.Algo_PrimitiveShapeParameters_free(ref primitive_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region Sawing

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_sawWithAABB(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Geom.AABB_c aabb, Int32 mode, string innerSuffix, string outerSuffix);
		/// <summary>
		/// Saw the mesh with an axis-aligned bounding box. New parts will be placed as children of input part occurrences.
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="aabb">Axis-Aligned Bounding Box</param>
		/// <param name="mode">The sawing mode</param>
		/// <param name="innerSuffix">Only if mode is set to SawAndSplit, set the suffix of the inner part</param>
		/// <param name="outerSuffix">Only if mode is set to SawAndSplit, set the suffix of the outer part</param>
		public void SawWithAABB(Scene.OccurrenceList occurrences, Geom.AABB aabb, SawingMode mode, System.String innerSuffix = "_inner", System.String outerSuffix = "_outer") {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var aabb_c = new Geom.AABB_c();
			Geom.GeomInterface.ConvertValue((Geom.AABB)aabb, ref aabb_c);
			Algo_sawWithAABB(api.Session, occurrences_c, aabb_c, (int)mode, innerSuffix, outerSuffix);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Geom.GeomInterface.Geom_AABB_free(ref aabb_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_sawWithOBB(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Geom.OBB_c obb, Int32 mode, string innerSuffix, string outerSuffix);
		/// <summary>
		/// Saw the mesh with an oriented bounding box. New parts will be placed as children of input part occurrences.
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="obb">Minimum Bounding Box</param>
		/// <param name="mode">The sawing mode</param>
		/// <param name="innerSuffix">Only if mode is set to SawAndSplit, set the suffix of the inner part</param>
		/// <param name="outerSuffix">Only if mode is set to SawAndSplit, set the suffix of the outer part</param>
		public void SawWithOBB(Scene.OccurrenceList occurrences, Geom.OBB obb, SawingMode mode, System.String innerSuffix = "_inner", System.String outerSuffix = "_outer") {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var obb_c = new Geom.OBB_c();
			Geom.GeomInterface.ConvertValue((Geom.OBB)obb, ref obb_c);
			Algo_sawWithOBB(api.Session, occurrences_c, obb_c, (int)mode, innerSuffix, outerSuffix);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Geom.GeomInterface.Geom_OBB_free(ref obb_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Algo_sawWithOctree(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Geom.AABB_c aabb, Int32 maxDepth, Int32 maxTrianglesByLeaf, System.Double sawTolerance);
		/// <summary>
		/// Saw and split the mesh with an octree. New parts will be placed as children of input part occurrences.
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="aabb">Octree Bounding Box</param>
		/// <param name="maxDepth">Depth of the octree</param>
		/// <param name="maxTrianglesByLeaf">Set the maximum triangle count on the leaf of the octree ( -1 to not use )</param>
		/// <param name="sawTolerance">Size in mm of the tolerance of the saw</param>
		public System.UInt32 SawWithOctree(Scene.OccurrenceList occurrences, Geom.AABB aabb, System.Int32 maxDepth, System.Int32 maxTrianglesByLeaf = -1, System.Double sawTolerance = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var aabb_c = new Geom.AABB_c();
			Geom.GeomInterface.ConvertValue((Geom.AABB)aabb, ref aabb_c);
			var ret = Algo_sawWithOctree(api.Session, occurrences_c, aabb_c, maxDepth, maxTrianglesByLeaf, sawTolerance);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Geom.GeomInterface.Geom_AABB_free(ref aabb_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_sawWithPlane(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Geom.Point3_c planeOrigin, Geom.Point3_c planeNormal, Int32 mode, string innerSuffix, string outerSuffix, System.Double tolerance);
		/// <summary>
		/// Saw the mesh with a plane. New parts will be placed as children of input part occurrences.
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="planeOrigin">The plane origin</param>
		/// <param name="planeNormal">The plane normal</param>
		/// <param name="mode">The sawing mode</param>
		/// <param name="innerSuffix">Only if mode is set to SawAndSplit, set the suffix of the inner part</param>
		/// <param name="outerSuffix">Only if mode is set to SawAndSplit, set the suffix of the outer part</param>
		/// <param name="tolerance">Set a tolerance to make the saw lose</param>
		public void SawWithPlane(Scene.OccurrenceList occurrences, Geom.Point3 planeOrigin, Geom.Point3 planeNormal, SawingMode mode, System.String innerSuffix = "_inner", System.String outerSuffix = "_outer", System.Double tolerance = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var planeOrigin_c = new Geom.Point3_c();
			Geom.GeomInterface.ConvertValue((Geom.Point3)planeOrigin, ref planeOrigin_c);
			var planeNormal_c = new Geom.Point3_c();
			Geom.GeomInterface.ConvertValue((Geom.Point3)planeNormal, ref planeNormal_c);
			Algo_sawWithPlane(api.Session, occurrences_c, planeOrigin_c, planeNormal_c, (int)mode, innerSuffix, outerSuffix, tolerance);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Geom.GeomInterface.Geom_Point3_free(ref planeOrigin_c);
			Geom.GeomInterface.Geom_Point3_free(ref planeNormal_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region Similarity detection

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_convertSimilarPartOccurrencesToInstances(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Byte checkMeshTopo, System.Byte checkVertexPositions, Int32 vertexPositionPrecision, System.Byte checkUVTopo, System.Byte checkUVVertexPositions, Int32 UVPositionprecision, System.Byte keepExistingPrototypes);
		/// <summary>
		/// Create instances from similar part occurrences with an accurate method based on topology checksums. This can be used to repair instances or to simplify a model that has similar parts that could be instantiated instead to reduce the number of unique meshes (reduces drawcalls, GPU memory usage and file size).
		/// </summary>
		/// <param name="occurrences">Occurrence for which we want to find similar parts and create instances using prototypes.</param>
		/// <param name="checkMeshTopo"></param>
		/// <param name="checkVertexPositions"></param>
		/// <param name="vertexPositionPrecision"></param>
		/// <param name="checkUVTopo"></param>
		/// <param name="checkUVVertexPositions"></param>
		/// <param name="UVPositionprecision"></param>
		/// <param name="keepExistingPrototypes"></param>
		public void ConvertSimilarPartOccurrencesToInstances(Scene.OccurrenceList occurrences, System.Boolean checkMeshTopo, System.Boolean checkVertexPositions, System.Int32 vertexPositionPrecision, System.Boolean checkUVTopo, System.Boolean checkUVVertexPositions, System.Int32 UVPositionprecision, System.Boolean keepExistingPrototypes) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_convertSimilarPartOccurrencesToInstances(api.Session, occurrences_c, Convert.ToByte(checkMeshTopo), Convert.ToByte(checkVertexPositions), vertexPositionPrecision, Convert.ToByte(checkUVTopo), Convert.ToByte(checkUVVertexPositions), UVPositionprecision, Convert.ToByte(keepExistingPrototypes));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_convertSimilarPartOccurrencesToInstancesFast(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double dimensionsSimilarity, System.Double polycountSimilarity, System.Byte ignoreSymmetry, System.Byte keepExistingPrototypes, System.Byte createNewOccurrencesForPrototypes);
		/// <summary>
		/// Create instances from similar part occurrences with a fast but approximate method. This can be used to repair instances or to simplify a model that has similar parts that could be instantiated instead to reduce the number of unique meshes (reduces drawcalls, GPU memory usage and file size). Using 1.0 (100%) in all similarity criteria is non destructive. Using lower values will help finding more similar parts, even if their polycount or dimensions varies a bit.
		/// </summary>
		/// <param name="occurrences">Root occurrences for which we want to find similar part occurrences and create instances using prototypes.</param>
		/// <param name="dimensionsSimilarity">The percentage of similarity on dimensions. A value of 1.0 (100%) will find parts that have exactly the same dimensions. A lower value will increase the likelihood to find similar parts, at the cost of precision.</param>
		/// <param name="polycountSimilarity">The percentage of similarity on polycount. A value of 1.0 (100%) will find parts that have exactly the same polycount. A lower value will increase the likelihood to find similar parts, at the cost of precision.</param>
		/// <param name="ignoreSymmetry">If True, symmetries will be ignored, otherwise negative scaling will be applied in the occurrence transformation.</param>
		/// <param name="keepExistingPrototypes">If True, existing prototypes will be kept. Otherwise, the selection will be singularized and instanced will be created from scratch.</param>
		/// <param name="createNewOccurrencesForPrototypes">If True, a new occurrence will be created for each prototype. Those occurrences won't appear in the hierarchy, and so deleting one of the part in the scene has no risks of singularizing. If set to False, an arbitrary occurrence will be used as the prototype for other similar occurrences, which is less safe but will result in less occurrences.</param>
		public void ConvertSimilarPartOccurrencesToInstancesFast(Scene.OccurrenceList occurrences, System.Double dimensionsSimilarity, System.Double polycountSimilarity, System.Boolean ignoreSymmetry, System.Boolean keepExistingPrototypes, System.Boolean createNewOccurrencesForPrototypes) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_convertSimilarPartOccurrencesToInstancesFast(api.Session, occurrences_c, dimensionsSimilarity, polycountSimilarity, Convert.ToByte(ignoreSymmetry), Convert.ToByte(keepExistingPrototypes), Convert.ToByte(createNewOccurrencesForPrototypes));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Scene.OccurrenceList_c Algo_findSimilarPartOccurrencesFast(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double dimensionsSimilarity, System.Double polycountSimilarity, System.Byte ignoreSymmetry);
		/// <summary>
		/// find part occurrences in the whole scene that are similar to the input part occurrences. If multiple part occurrences are passed as input, the output will contain similar part occurrences corresponding to each input part occurrence.
		/// </summary>
		/// <param name="occurrences">Occurrences for which we want to find similar part occurrences in the scene.</param>
		/// <param name="dimensionsSimilarity">The percentage of similarity on dimensions. A value of 1.0 (100%) will find parts that have exactly the same dimensions. A lower value will increase the likelihood to find similar parts, at the cost of precision.</param>
		/// <param name="polycountSimilarity">The percentage of similarity on polycount. A value of 1.0 (100%) will find parts that have exactly the same polycount. A lower value will increase the likelihood to find similar parts, at the cost of precision.</param>
		/// <param name="ignoreSymmetry">If True, symmetries will be ignored, otherwise negative scaling will be applied in the occurrence transformation.</param>
		public Scene.OccurrenceList FindSimilarPartOccurrencesFast(Scene.OccurrenceList occurrences, System.Double dimensionsSimilarity, System.Double polycountSimilarity, System.Boolean ignoreSymmetry) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_findSimilarPartOccurrencesFast(api.Session, occurrences_c, dimensionsSimilarity, polycountSimilarity, Convert.ToByte(ignoreSymmetry));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Scene.SceneInterface.ConvertValue(ref ret);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
			return convRet;
		}

		#endregion

		#region UV Mapping

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_alignUVIslands(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 channel, System.Double usePolygonsWeights, System.Double useVerticesWeights, Int32 alignmentMode);
		/// <summary>
		/// Align with the axes the UVs of the islands
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="channel">UV channel to merge</param>
		/// <param name="usePolygonsWeights">Use polygons weights to give more importance to what must be aligned</param>
		/// <param name="useVerticesWeights">Use vertices weights to give more importance to what must be aligned</param>
		/// <param name="alignmentMode">With which axis the UVs should be aligned</param>
		public void AlignUVIslands(Scene.OccurrenceList occurrences, System.Int32 channel = 0, System.Double usePolygonsWeights = 0, System.Double useVerticesWeights = 0, AlignmentMode alignmentMode = (Algo.AlignmentMode)0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_alignUVIslands(api.Session, occurrences_c, channel, usePolygonsWeights, useVerticesWeights, (int)alignmentMode);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_applyUvTransform(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Geom.Matrix4_c matrix, Int32 channel);
		/// <summary>
		/// Apply a transformation matrix on texture coordinates
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="matrix">Transformationmatrix</param>
		/// <param name="channel">UV channel to transform</param>
		public void ApplyUvTransform(Scene.OccurrenceList occurrences, Geom.Matrix4 matrix, System.Int32 channel = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var matrix_c = new Geom.Matrix4_c();
			Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
			Algo_applyUvTransform(api.Session, occurrences_c, matrix_c, channel);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_automaticUVMapping(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 channel, System.Double maxAngleDistorsion, System.Double maxAreaDistorsion, System.Byte sharpToSeam, System.Byte forbidOverlapping);
		/// <summary>
		/// Generates the texture coordinates and automatically cut
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="channel">The UV channel which will contains the texture coordinates</param>
		/// <param name="maxAngleDistorsion">Maximum angle distorsion |2PI-SumVtxAng|/2PI</param>
		/// <param name="maxAreaDistorsion">Maximum area distorsion before scale to 1. |2DArea-3DArea|/3DArea </param>
		/// <param name="sharpToSeam">If enabled, sharp edges are automatically considered as UV seams</param>
		/// <param name="forbidOverlapping">If enabled, UV cannot overlap</param>
		public void AutomaticUVMapping(Scene.OccurrenceList occurrences, System.Int32 channel = 0, System.Double maxAngleDistorsion = 0.5, System.Double maxAreaDistorsion = -1, System.Boolean sharpToSeam = true, System.Boolean forbidOverlapping = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_automaticUVMapping(api.Session, occurrences_c, channel, maxAngleDistorsion, maxAreaDistorsion, Convert.ToByte(sharpToSeam), Convert.ToByte(forbidOverlapping));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_copyUV(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 sourceChannel, Int32 destinationChannel);
		/// <summary>
		/// Copy an UV channel to another UV channel
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="sourceChannel">The source UV channel to copy</param>
		/// <param name="destinationChannel">The destination UV channel to copy into</param>
		public void CopyUV(Scene.OccurrenceList occurrences, System.Int32 sourceChannel = 0, System.Int32 destinationChannel = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_copyUV(api.Session, occurrences_c, sourceChannel, destinationChannel);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_defragmentUVIslands(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 channel, Int32 targetIslandCount, System.Double energyThreshold, System.Byte forceIsolatedFaces);
		/// <summary>
		/// Reduce the number of UV islands in a mesh parametrization by attempting to merge neighboring ones.
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="channel">UV channel to use</param>
		/// <param name="targetIslandCount">Target number of islands (zero means the algorithm runs until no more merging is possible)</param>
		/// <param name="energyThreshold">Max energy allowed during local reparametrization</param>
		/// <param name="forceIsolatedFaces">UV islands consisting in a single isolated face completely surrounded by another island are forced to be merged, without reparametrization.</param>
		public void DefragmentUVIslands(Scene.OccurrenceList occurrences, System.Int32 channel, System.Int32 targetIslandCount = 0, System.Double energyThreshold = 0.01, System.Boolean forceIsolatedFaces = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_defragmentUVIslands(api.Session, occurrences_c, channel, targetIslandCount, energyThreshold, Convert.ToByte(forceIsolatedFaces));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_deletePolygonalWeightAttribute(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Delete Polygonal Weight attributes on tessellations
		/// </summary>
		/// <param name="occurrences">Occurrences of components to delete attributes</param>
		public void DeletePolygonalWeightAttribute(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_deletePolygonalWeightAttribute(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_flattenUV(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 channel, Int32 iterations, System.Double newtonTolf, System.Double newtonTolx);
		/// <summary>
		/// Flatten the UVs on the occurrence
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="channel">UV channel to merge</param>
		/// <param name="iterations">Number of iterations to perform</param>
		/// <param name="newtonTolf">Threshold for gradient normals</param>
		/// <param name="newtonTolx">Threshold for gradient normals</param>
		public void FlattenUV(Scene.OccurrenceList occurrences, System.Int32 channel = 0, System.Int32 iterations = 1, System.Double newtonTolf = 1.0, System.Double newtonTolx = 1.0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_flattenUV(api.Session, occurrences_c, channel, iterations, newtonTolf, newtonTolx);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.DoubleList_c Algo_getRatioUV3D(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 ratioMode, Int32 channel);
		/// <summary>
		/// Compute the ratio between the UV and the 3D size
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="ratioMode">Choose how to compute the ratio</param>
		/// <param name="channel">UV channel to use</param>
		public Core.DoubleList GetRatioUV3D(Scene.OccurrenceList occurrences, RatioUV3DMode ratioMode, System.Int32 channel = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_getRatioUV3D(api.Session, occurrences_c, (int)ratioMode, channel);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Core.CoreInterface.ConvertValue(ref ret);
			Core.CoreInterface.Core_DoubleList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetUVQualityMetricsReturn_c Algo_getUVQualityMetrics(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.UInt32 channel);
		/// <summary>
		/// Compute UV mapping qualitative metrics.
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="channel">UV channel to use</param>
		public Algo.GetUVQualityMetricsReturn GetUVQualityMetrics(Scene.OccurrenceList occurrences, System.UInt32 channel) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_getUVQualityMetrics(api.Session, occurrences_c, channel);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			Algo.GetUVQualityMetricsReturn retStruct = new Algo.GetUVQualityMetricsReturn();
			retStruct.chartCount = (System.UInt32)ret.chartCount;
			retStruct.area3D = (System.Double)ret.area3D;
			retStruct.area2D = (System.Double)ret.area2D;
			retStruct.occupancy = (System.Double)ret.occupancy;
			retStruct.crumbliness = (System.Double)ret.crumbliness;
			retStruct.samplingStd = (System.Double)ret.samplingStd;
			return retStruct;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Geom.AABR_c Algo_getUvAabr(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 channel);
		/// <summary>
		/// Compute the UV AABR of the selected occurrences
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="channel">UV channel to transform</param>
		public Geom.AABR GetUvAabr(Scene.OccurrenceList occurrences, System.Int32 channel = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_getUvAabr(api.Session, occurrences_c, channel);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Geom.GeomInterface.ConvertValue(ref ret);
			Geom.GeomInterface.Geom_AABR_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_mapUvOnAABB(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Byte useLocalAABB, System.Double uv3dSize, Int32 channel, System.Byte overrideExistingUVs, System.Byte ignoreScale);
		/// <summary>
		/// Generate texture coordinates using the projection on object Axis Aligned Bounding Box
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="useLocalAABB">If enabled, uses part own bounding box, else use global one</param>
		/// <param name="uv3dSize">3D size of the UV space [0-1]</param>
		/// <param name="channel">The UV channel which will contains the texture coordinates</param>
		/// <param name="overrideExistingUVs">If True, override existing UVs on channel</param>
		/// <param name="ignoreScale">If this and useLocalAABB are true, ignore local scale</param>
		public void MapUvOnAABB(Scene.OccurrenceList occurrences, System.Boolean useLocalAABB, System.Double uv3dSize, System.Int32 channel = 0, System.Boolean overrideExistingUVs = true, System.Boolean ignoreScale = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_mapUvOnAABB(api.Session, occurrences_c, Convert.ToByte(useLocalAABB), uv3dSize, channel, Convert.ToByte(overrideExistingUVs), Convert.ToByte(ignoreScale));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_mapUvOnBox(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Box_c box, Int32 channel, System.Byte overrideExistingUVs);
		/// <summary>
		/// Generate texture coordinates using the projection on a box
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="box">Box definition</param>
		/// <param name="channel">The UV channel which will contains the texture coordinates</param>
		/// <param name="overrideExistingUVs">If True, override existing UVs on channel</param>
		public void MapUvOnBox(Scene.OccurrenceList occurrences, Box box, System.Int32 channel = 0, System.Boolean overrideExistingUVs = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var box_c = new Algo.Box_c();
			ConvertValue((Algo.Box)box, ref box_c);
			Algo_mapUvOnBox(api.Session, occurrences_c, box_c, channel, Convert.ToByte(overrideExistingUVs));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Algo.AlgoInterface.Algo_Box_free(ref box_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_mapUvOnCubicAABB(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double uv3dSize, Int32 channel, System.Byte overrideExistingUVs);
		/// <summary>
		/// Generate texture coordinates using the projection on object AABB, with same scale on each axis
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="uv3dSize">3D size of the UV space [0-1]</param>
		/// <param name="channel">The UV channel which will contains the texture coordinates</param>
		/// <param name="overrideExistingUVs">If True, override existing UVs on channel</param>
		public void MapUvOnCubicAABB(Scene.OccurrenceList occurrences, System.Double uv3dSize, System.Int32 channel = 0, System.Boolean overrideExistingUVs = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_mapUvOnCubicAABB(api.Session, occurrences_c, uv3dSize, channel, Convert.ToByte(overrideExistingUVs));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_mapUvOnCustomAABB(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Geom.AABB_c aabb, System.Double uv3dSize, Int32 channel, System.Byte overrideExistingUVs);
		/// <summary>
		/// Generate texture coordinates using the projection on custom AABB
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="aabb">Axis aligned bounding box to project on</param>
		/// <param name="uv3dSize">3D size of the UV space [0-1]</param>
		/// <param name="channel">The UV channel which will contains the texture coordinates</param>
		/// <param name="overrideExistingUVs">If True, override existing UVs on channel</param>
		public void MapUvOnCustomAABB(Scene.OccurrenceList occurrences, Geom.AABB aabb, System.Double uv3dSize, System.Int32 channel = 0, System.Boolean overrideExistingUVs = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var aabb_c = new Geom.AABB_c();
			Geom.GeomInterface.ConvertValue((Geom.AABB)aabb, ref aabb_c);
			Algo_mapUvOnCustomAABB(api.Session, occurrences_c, aabb_c, uv3dSize, channel, Convert.ToByte(overrideExistingUVs));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Geom.GeomInterface.Geom_AABB_free(ref aabb_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_mapUvOnCylinder(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Cylinder_c cylinder, Int32 channel, System.Byte overrideExistingUVs);
		/// <summary>
		/// Generate texture coordinates using the projection on a cylinder
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="cylinder">Cylinder definition</param>
		/// <param name="channel">The UV channel which will contains the texture coordinates</param>
		/// <param name="overrideExistingUVs">If True, override existing UVs on channel</param>
		public void MapUvOnCylinder(Scene.OccurrenceList occurrences, Cylinder cylinder, System.Int32 channel = 0, System.Boolean overrideExistingUVs = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var cylinder_c = new Algo.Cylinder_c();
			ConvertValue((Algo.Cylinder)cylinder, ref cylinder_c);
			Algo_mapUvOnCylinder(api.Session, occurrences_c, cylinder_c, channel, Convert.ToByte(overrideExistingUVs));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Algo.AlgoInterface.Algo_Cylinder_free(ref cylinder_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_mapUvOnFittingCylinder(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 channel, System.Byte overrideExistingUVs, System.Byte useAABB);
		/// <summary>
		/// Generate texture coordinates using the projection on a fitting cylinder
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="channel">The UV channel which will contains the texture coordinates</param>
		/// <param name="overrideExistingUVs">If True, override existing UVs on channel</param>
		/// <param name="useAABB">If true use for the fitting the global Axis Aligned Bounding Box (AABB), else use a Minimum Bounding Box (MBB only based on transformed AABB of occurrences)</param>
		public void MapUvOnFittingCylinder(Scene.OccurrenceList occurrences, System.Int32 channel = 0, System.Boolean overrideExistingUVs = true, System.Boolean useAABB = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_mapUvOnFittingCylinder(api.Session, occurrences_c, channel, Convert.ToByte(overrideExistingUVs), Convert.ToByte(useAABB));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_mapUvOnFittingSphere(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 channel, System.Byte overrideExistingUVs, System.Byte useAABB);
		/// <summary>
		/// Generate texture coordinates using the projection on a fitting sphere
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="channel">The UV channel which will contains the texture coordinates</param>
		/// <param name="overrideExistingUVs">If True, override existing UVs on channel</param>
		/// <param name="useAABB">If true use for the fitting the global Axis Aligned Bounding Box (AABB), else use a Minimum Bounding Box (MBB only based on transformed AABB of occurrences)</param>
		public void MapUvOnFittingSphere(Scene.OccurrenceList occurrences, System.Int32 channel = 0, System.Boolean overrideExistingUVs = true, System.Boolean useAABB = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_mapUvOnFittingSphere(api.Session, occurrences_c, channel, Convert.ToByte(overrideExistingUVs), Convert.ToByte(useAABB));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_mapUvOnMBB(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Byte useLocalMBB, System.Double uv3dSize, Int32 channel, System.Byte overrideExistingUVs);
		/// <summary>
		/// Generate texture coordinates using the projection on object Minimum Bounding Box
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="useLocalMBB">If enabled, uses part own bounding box, else use global one</param>
		/// <param name="uv3dSize">3D size of the UV space [0-1]</param>
		/// <param name="channel">The UV channel which will contains the texture coordinates</param>
		/// <param name="overrideExistingUVs">If True, override existing UVs on channel</param>
		public void MapUvOnMBB(Scene.OccurrenceList occurrences, System.Boolean useLocalMBB, System.Double uv3dSize, System.Int32 channel = 0, System.Boolean overrideExistingUVs = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_mapUvOnMBB(api.Session, occurrences_c, Convert.ToByte(useLocalMBB), uv3dSize, channel, Convert.ToByte(overrideExistingUVs));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_mapUvOnPlane(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Plane_c plane, Int32 channel, System.Byte overrideExistingUVs);
		/// <summary>
		/// Generate texture coordinates using the projection on a plane
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="plane">Plane definition</param>
		/// <param name="channel">The UV channel which will contains the texture coordinates</param>
		/// <param name="overrideExistingUVs">If True, override existing UVs on channel</param>
		public void MapUvOnPlane(Scene.OccurrenceList occurrences, Plane plane, System.Int32 channel = 0, System.Boolean overrideExistingUVs = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var plane_c = new Algo.Plane_c();
			ConvertValue((Algo.Plane)plane, ref plane_c);
			Algo_mapUvOnPlane(api.Session, occurrences_c, plane_c, channel, Convert.ToByte(overrideExistingUVs));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Algo.AlgoInterface.Algo_Plane_free(ref plane_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_mapUvOnSphere(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Sphere_c sphere, Int32 channel, System.Byte overrideExistingUVs);
		/// <summary>
		/// Generate texture coordinates using the projection on a sphere
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="sphere">Sphere definition</param>
		/// <param name="channel">The UV channel which will contains the texture coordinates</param>
		/// <param name="overrideExistingUVs">If True, override existing UVs on channel</param>
		public void MapUvOnSphere(Scene.OccurrenceList occurrences, Sphere sphere, System.Int32 channel = 0, System.Boolean overrideExistingUVs = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var sphere_c = new Algo.Sphere_c();
			ConvertValue((Algo.Sphere)sphere, ref sphere_c);
			Algo_mapUvOnSphere(api.Session, occurrences_c, sphere_c, channel, Convert.ToByte(overrideExistingUVs));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Algo.AlgoInterface.Algo_Sphere_free(ref sphere_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_mergeUVIslands(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 channel, System.Double scaleWeights, System.Double maxScaleVariationFactor, System.Double curvatureWeights, System.Double usePolygonsWeights, System.Double useVerticesWeights, Int32 maxTransformationType, System.Byte allowUVInversion);
		/// <summary>
		/// Minimizes the number of seams in the UV mapping
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="channel">UV channel to merge</param>
		/// <param name="scaleWeights">Weight to assign to scale for the merging priority</param>
		/// <param name="maxScaleVariationFactor">Maximum scaling factor allowed, -1 meaning no limits</param>
		/// <param name="curvatureWeights">Weight to assign to curvature for the merging priority</param>
		/// <param name="usePolygonsWeights">Use polygons weights to prioritize seams between polygons with less weight. The value represents the feature weight</param>
		/// <param name="useVerticesWeights">Use vertices weights to prioritize seams where vertices with less weight. The value represents the feature weight</param>
		/// <param name="maxTransformationType">Maximum transformation allowed: TRS only, affine and perspective</param>
		/// <param name="allowUVInversion">Allow merged UVs to be inverted</param>
		public void MergeUVIslands(Scene.OccurrenceList occurrences, System.Int32 channel = 0, System.Double scaleWeights = 0, System.Double maxScaleVariationFactor = 1.2, System.Double curvatureWeights = -1, System.Double usePolygonsWeights = 1, System.Double useVerticesWeights = -1, MaxTransformationType maxTransformationType = (Algo.MaxTransformationType)0, System.Boolean allowUVInversion = false) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_mergeUVIslands(api.Session, occurrences_c, channel, scaleWeights, maxScaleVariationFactor, curvatureWeights, usePolygonsWeights, useVerticesWeights, (int)maxTransformationType, Convert.ToByte(allowUVInversion));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_normalizeUV(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 sourceUVChannel, Int32 destinationUVChannel, System.Byte uniform, System.Byte sharedUVSpace, System.Byte ignoreNullIslands);
		/// <summary>
		/// Normalize UVs to fit in the [0-1] uv space
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="sourceUVChannel">UV Channel to normalize</param>
		/// <param name="destinationUVChannel">UV channel to store the normalized UV (if -1, sourceUVChannel will be replaced)</param>
		/// <param name="uniform">If true, the scale will be uniform. Else UV can be deformed with a non-uniform scale</param>
		/// <param name="sharedUVSpace">If true, all parts will be processed as if they were merged to avoid overlapping of their UV coordinates</param>
		/// <param name="ignoreNullIslands">If true, islands with null height and width will be ignored and their UV coordinates will be set to [0,0] (Slower if enabled)</param>
		public void NormalizeUV(Scene.OccurrenceList occurrences, System.Int32 sourceUVChannel, System.Int32 destinationUVChannel = -1, System.Boolean uniform = true, System.Boolean sharedUVSpace = true, System.Boolean ignoreNullIslands = false) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_normalizeUV(api.Session, occurrences_c, sourceUVChannel, destinationUVChannel, Convert.ToByte(uniform), Convert.ToByte(sharedUVSpace), Convert.ToByte(ignoreNullIslands));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_relaxUV(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 method, Int32 iterations, Int32 channel);
		/// <summary>
		/// Relax UVs
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="method">What the method used to relax is based on</param>
		/// <param name="iterations">Number of relax iterations</param>
		/// <param name="channel">The UV channel to repack</param>
		public void RelaxUV(Scene.OccurrenceList occurrences, RelaxUVMethod method, System.Int32 iterations = 100, System.Int32 channel = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_relaxUV(api.Session, occurrences_c, (int)method, iterations, channel);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_removeUV(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 channel);
		/// <summary>
		/// Remove one or all UV channel(s)
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="channel">The UV channel to remove (all if channel=-1)</param>
		public void RemoveUV(Scene.OccurrenceList occurrences, System.Int32 channel = -1) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_removeUV(api.Session, occurrences_c, channel);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Scene.OccurrenceList_c Algo_repackUV(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 channel, System.Byte shareMap, Int32 resolution, System.UInt32 padding, System.Byte uniformRatio, Int32 iterations, System.Byte removeOverlaps);
		/// <summary>
		/// Pack existing UV (create atlas)
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="channel">The UV channel to repack</param>
		/// <param name="shareMap">If True, the UV of all given parts will be packed together</param>
		/// <param name="resolution">Resolution wanted for the final map</param>
		/// <param name="padding">Set the padding (in pixels) between UV islands</param>
		/// <param name="uniformRatio">If true, UV of different part will have the same ratio</param>
		/// <param name="iterations">Fitting iterations</param>
		/// <param name="removeOverlaps">Remove overlaps to avoid multiple triangles UVs to share the same pixel</param>
		public Scene.OccurrenceList RepackUV(Scene.OccurrenceList occurrences, System.Int32 channel = 0, System.Boolean shareMap = true, System.Int32 resolution = 1024, System.UInt32 padding = 2, System.Boolean uniformRatio = false, System.Int32 iterations = 3, System.Boolean removeOverlaps = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_repackUV(api.Session, occurrences_c, channel, Convert.ToByte(shareMap), resolution, padding, Convert.ToByte(uniformRatio), iterations, Convert.ToByte(removeOverlaps));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Scene.SceneInterface.ConvertValue(ref ret);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_resizeUVsToTextureSize(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double TextureSize, Int32 channel);
		/// <summary>
		/// Rescale the UV coordinates to fit the input texture size
		/// </summary>
		/// <param name="occurrences">Occurrences to use for the rescaling</param>
		/// <param name="TextureSize">Texture size to use for the UV coordinates (in millimeters)</param>
		/// <param name="channel">UV channel to use</param>
		public void ResizeUVsToTextureSize(Scene.OccurrenceList occurrences, System.Double TextureSize, System.Int32 channel = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_resizeUVsToTextureSize(api.Session, occurrences_c, TextureSize, channel);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_scaleUV(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double scaleU, System.Double scaleV, Int32 channel);
		/// <summary>
		/// Apply a scale on texture coordinates
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="scaleU">Scale to apply to U coordinate</param>
		/// <param name="scaleV">Scale to apply to V coordinate</param>
		/// <param name="channel">UV channel to transform</param>
		public void ScaleUV(Scene.OccurrenceList occurrences, System.Double scaleU, System.Double scaleV, System.Int32 channel = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_scaleUV(api.Session, occurrences_c, scaleU, scaleV, channel);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_segmentDiskFront(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 method, System.Double threshold);
		/// <summary>
		/// Create UV patches with disk-like topology
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="method">Choose the method to drive the region growing</param>
		/// <param name="threshold">Threshold used by the method</param>
		public void SegmentDiskFront(Scene.OccurrenceList occurrences, DiskSegmentationMethod method, System.Double threshold) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_segmentDiskFront(api.Session, occurrences_c, (int)method, threshold);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_smoothUV(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 iterations, Int32 channel);
		/// <summary>
		/// Smooth texture coordinates
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="iterations">Number of smooth iterations</param>
		/// <param name="channel">The UV channel which will contains the texture coordinates to smooth</param>
		public void SmoothUV(Scene.OccurrenceList occurrences, System.Int32 iterations = 1, System.Int32 channel = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_smoothUV(api.Session, occurrences_c, iterations, channel);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_stitchUV(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 channel);
		/// <summary>
		/// Try to stitch existing UV islands
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="channel">The UV channel to repack</param>
		public void StitchUV(Scene.OccurrenceList occurrences, System.Int32 channel = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_stitchUV(api.Session, occurrences_c, channel);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_swapUvChannels(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 firstChannel, Int32 secondChannel);
		/// <summary>
		/// Swap two UV channels
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="firstChannel">First UV Channel to swap</param>
		/// <param name="secondChannel">Second UV Channel to swap</param>
		public void SwapUvChannels(Scene.OccurrenceList occurrences, System.Int32 firstChannel, System.Int32 secondChannel) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_swapUvChannels(api.Session, occurrences_c, firstChannel, secondChannel);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_transferVisibilityToPolygonalWeight(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 Mode);
		/// <summary>
		/// Set Polygonal Weight Attribute from Visibility Attribute
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="Mode">Mode used to compute visibility</param>
		public void TransferVisibilityToPolygonalWeight(Scene.OccurrenceList occurrences, VisibilityToWeightMode Mode) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_transferVisibilityToPolygonalWeight(api.Session, occurrences_c, (int)Mode);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_uvUnwrap(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 channel, System.Byte createSeamsFromLoI);
		/// <summary>
		/// Unwrap each Island
		/// </summary>
		/// <param name="occurrences">Part occurrences to process</param>
		/// <param name="channel">The UV channel which will contains the texture coordinates</param>
		/// <param name="createSeamsFromLoI">Use Lines of Interest to cut UVs (c.f segmentDiskFront)</param>
		public void UvUnwrap(Scene.OccurrenceList occurrences, System.Int32 channel = 0, System.Boolean createSeamsFromLoI = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_uvUnwrap(api.Session, occurrences_c, channel, Convert.ToByte(createSeamsFromLoI));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region fitting

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Geom.Affine_c Algo_getFittingCylinder(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Byte useAABB);
		/// <summary>
		/// Returns the fitting cylinder of a set of occurrences (based on MBB)
		/// </summary>
		/// <param name="occurrences">Occurrences to fit</param>
		/// <param name="useAABB">If true use the global Axis Aligned Bounding Box (AABB), else use a Minimum Bounding Box MBB only based on transformed AABB of occurrences)</param>
		public Geom.Affine GetFittingCylinder(Scene.OccurrenceList occurrences, System.Boolean useAABB = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_getFittingCylinder(api.Session, occurrences_c, Convert.ToByte(useAABB));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Geom.GeomInterface.ConvertValue(ref ret);
			Geom.GeomInterface.Geom_Affine_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Geom.Affine_c Algo_getFittingSphere(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Byte useAABB);
		/// <summary>
		/// Returns the fitting sphere of a set of occurrences
		/// </summary>
		/// <param name="occurrences">Occurrences to fit</param>
		/// <param name="useAABB">If true use the global Axis Aligned Bounding Box (AABB), else use a Minimum Bounding Box (MBB only based on transformed AABB of occurrences)</param>
		public Geom.Affine GetFittingSphere(Scene.OccurrenceList occurrences, System.Boolean useAABB = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_getFittingSphere(api.Session, occurrences_c, Convert.ToByte(useAABB));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Geom.GeomInterface.ConvertValue(ref ret);
			Geom.GeomInterface.Geom_Affine_free(ref ret);
			return convRet;
		}

		#endregion

		#region map_generation

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Material.ImageList_c Algo_bakeMaps(IntPtr _pxz_session_, Scene.OccurrenceList_c destinationOccurrences, Scene.OccurrenceList_c sourceOccurrences, BakeMapList_c mapsToBake, Int32 channel, Int32 resolution, Int32 padding, System.Byte shareMaps, string mapSuffix, CustomBakeMapList_c additionalCustomMaps, System.Double tolerance, Int32 method, System.Double opacityThreshold, System.Byte useCurrentPosition, System.Double offset, getPixelValueList_c callbackList, System.Byte oneToOne, Material.ImageList_c reuseMaps, System.Byte outputUsedMap);
		/// <summary>
		/// Bake texture maps on meshes from self or other meshes
		/// </summary>
		/// <param name="destinationOccurrences">Occurrences of the meshes where to store the baked map</param>
		/// <param name="sourceOccurrences">Occurrences of components from which to bake maps (if empty use destination)</param>
		/// <param name="mapsToBake">List of map to generate (Normal, Diffuse, ...)</param>
		/// <param name="channel">UV channel of destOccurrence to use for the map generation</param>
		/// <param name="resolution">Map resolution</param>
		/// <param name="padding">Add padding to the map. A negative value means that the texture will be filled, and the padding for uv island is the absolute value</param>
		/// <param name="shareMaps">If true, all the destinationOccurrences will share the same maps</param>
		/// <param name="mapSuffix">Add a suffix to the map names</param>
		/// <param name="additionalCustomMaps">Additional custom maps to bake</param>
		/// <param name="tolerance">Tolerance of projection for baking from source to destination</param>
		/// <param name="method">Method to find source color if source occurrences are different than destination occurrences (Prefer ProjOnly for point clouds and RayOnly for meshes)</param>
		/// <param name="opacityThreshold">If the opacity is under this threshold, considers as fully transparent and store the color behind the intersection</param>
		/// <param name="useCurrentPosition">Use the current position instead of the T-Pose of the input occurrence</param>
		/// <param name="offset">Offset from mesh</param>
		/// <param name="callbackList">Callbacks that returns a color</param>
		/// <param name="oneToOne">If true, each occurrence in sourceOccurrences will be baked to the occurrence in destinationOccurrences at the same index</param>
		/// <param name="reuseMaps">Allow to use existing image instead of creating new ones (override shareMaps=true) the maps must be in the same order than mapsToBake+additionalCustomMaps+callbackList + usedMap (see: outputUsedMap)</param>
		/// <param name="outputUsedMap">If True, an extra maps contained used pixels is output at the end of bakedMaps. It can be used by reuseMaps</param>
		public Material.ImageList BakeMaps(Scene.OccurrenceList destinationOccurrences, Scene.OccurrenceList sourceOccurrences, BakeMapList mapsToBake, System.Int32 channel = 0, System.Int32 resolution = 1024, System.Int32 padding = 1, System.Boolean shareMaps = true, System.String mapSuffix = "", CustomBakeMapList additionalCustomMaps = null, System.Double tolerance = -1, BakingMethod method = (Algo.BakingMethod)0, System.Double opacityThreshold = 0.1, System.Boolean useCurrentPosition = false, System.Double offset = 0, getPixelValueList callbackList = null, System.Boolean oneToOne = false, Material.ImageList reuseMaps = null, System.Boolean outputUsedMap = false) {
			additionalCustomMaps = additionalCustomMaps ?? new Algo.CustomBakeMapList(new Algo.CustomBakeMap[] {});
			callbackList = callbackList ?? new Algo.getPixelValueList(new Algo.getPixelValue[] {});
			reuseMaps = reuseMaps ?? new Material.ImageList(new System.UInt32[] {});
			var destinationOccurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)destinationOccurrences, ref destinationOccurrences_c);
			var sourceOccurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)sourceOccurrences, ref sourceOccurrences_c);
			var mapsToBake_c = new Algo.BakeMapList_c();
			ConvertValue((Algo.BakeMapList)mapsToBake, ref mapsToBake_c);
			var additionalCustomMaps_c = new Algo.CustomBakeMapList_c();
			ConvertValue((Algo.CustomBakeMapList)additionalCustomMaps, ref additionalCustomMaps_c);
			var callbackList_c = new Algo.getPixelValueList_c();
			ConvertValue((Algo.getPixelValueList)callbackList, ref callbackList_c);
			var reuseMaps_c = new Material.ImageList_c();
			Material.MaterialInterface.ConvertValue((Material.ImageList)reuseMaps, ref reuseMaps_c);
			var ret = Algo_bakeMaps(api.Session, destinationOccurrences_c, sourceOccurrences_c, mapsToBake_c, channel, resolution, padding, Convert.ToByte(shareMaps), mapSuffix, additionalCustomMaps_c, tolerance, (int)method, opacityThreshold, Convert.ToByte(useCurrentPosition), offset, callbackList_c, Convert.ToByte(oneToOne), reuseMaps_c, Convert.ToByte(outputUsedMap));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref destinationOccurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref sourceOccurrences_c);
			Algo.AlgoInterface.Algo_BakeMapList_free(ref mapsToBake_c);
			Algo.AlgoInterface.Algo_CustomBakeMapList_free(ref additionalCustomMaps_c);
			Algo.AlgoInterface.Algo_getPixelValueList_free(ref callbackList_c);
			Material.MaterialInterface.Material_ImageList_free(ref reuseMaps_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Material.MaterialInterface.ConvertValue(ref ret);
			Material.MaterialInterface.Material_ImageList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Algo_convertNormalMap(IntPtr _pxz_session_, Scene.OccurrenceList_c partOccurrences, System.UInt32 normalMap, Int32 uvChannel, System.Byte sourceIsObjectSpace, System.Byte destinationIsObjectSpace, System.Byte sourceIsRightHanded, System.Byte destinationIsRightHanded, System.Byte replaceMap, Int32 resolution, Int32 padding);
		/// <summary>
		/// Convert an existing normal map between Object-space and Tangent-space
		/// </summary>
		/// <param name="partOccurrences">Occurrences of components using the given map</param>
		/// <param name="normalMap">Source normal map to convert</param>
		/// <param name="uvChannel">UV channel used on the given map</param>
		/// <param name="sourceIsObjectSpace">If True, consider the given normalMap in Object-space representation, else Tangent-space</param>
		/// <param name="destinationIsObjectSpace">If True, convert the given normalMap to Object-space representation, else Tangent-space</param>
		/// <param name="sourceIsRightHanded">Considers source normal map as part of a right-handed coordinates system</param>
		/// <param name="destinationIsRightHanded">Generate destination normal map as part of a right-handed coordinates system</param>
		/// <param name="replaceMap">If true, the given normalMap will be replaced by the converted one</param>
		/// <param name="resolution">New map resolution (if replaceMap=false), if resolution=-1, the input resolution will be used</param>
		/// <param name="padding">Number of pixels to add for padding. A negative value means that the texture will be filled, and the padding for uv island is the absolute value</param>
		public System.UInt32 ConvertNormalMap(Scene.OccurrenceList partOccurrences, System.UInt32 normalMap, System.Int32 uvChannel = 0, System.Boolean sourceIsObjectSpace = true, System.Boolean destinationIsObjectSpace = false, System.Boolean sourceIsRightHanded = true, System.Boolean destinationIsRightHanded = true, System.Boolean replaceMap = true, System.Int32 resolution = -1, System.Int32 padding = 1) {
			var partOccurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)partOccurrences, ref partOccurrences_c);
			var ret = Algo_convertNormalMap(api.Session, partOccurrences_c, normalMap, uvChannel, Convert.ToByte(sourceIsObjectSpace), Convert.ToByte(destinationIsObjectSpace), Convert.ToByte(sourceIsRightHanded), Convert.ToByte(destinationIsRightHanded), Convert.ToByte(replaceMap), resolution, padding);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref partOccurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Algo_createBillboard(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 resolution, System.Byte XPositive, System.Byte XNegative, System.Byte YPositive, System.Byte YNegative, System.Byte ZPositive, System.Byte ZNegative, System.Byte moveFacesToCenter, System.Byte leftHandedNormalMap);
		/// <summary>
		/// Create a billboard imposter
		/// </summary>
		/// <param name="occurrences">Occurrences to bake in the billboard</param>
		/// <param name="resolution">Total resolution of the billboard (contains all wanted faces)</param>
		/// <param name="XPositive">Bake face facing X+</param>
		/// <param name="XNegative">Bake face facing X-</param>
		/// <param name="YPositive">Bake face facing Y+</param>
		/// <param name="YNegative">Bake face facing Y-</param>
		/// <param name="ZPositive">Bake face facing Z+</param>
		/// <param name="ZNegative">Bake face facing Z-</param>
		/// <param name="moveFacesToCenter">If true, all face are moved to the center of the AABB of the occurrences, else it will shape an AABB</param>
		/// <param name="leftHandedNormalMap">If true, a left handed normal map will be generated</param>
		public System.UInt32 CreateBillboard(Scene.OccurrenceList occurrences, System.Int32 resolution = 1024, System.Boolean XPositive = true, System.Boolean XNegative = true, System.Boolean YPositive = true, System.Boolean YNegative = true, System.Boolean ZPositive = true, System.Boolean ZNegative = true, System.Boolean moveFacesToCenter = true, System.Boolean leftHandedNormalMap = false) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_createBillboard(api.Session, occurrences_c, resolution, Convert.ToByte(XPositive), Convert.ToByte(XNegative), Convert.ToByte(YPositive), Convert.ToByte(YNegative), Convert.ToByte(ZPositive), Convert.ToByte(ZNegative), Convert.ToByte(moveFacesToCenter), Convert.ToByte(leftHandedNormalMap));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_fillNormalMap(IntPtr _pxz_session_, System.UInt32 normalMap);
		/// <summary>
		/// Fill normal map (useful after a decimation for example)
		/// </summary>
		/// <param name="normalMap">Source normal map to convert</param>
		public void FillNormalMap(System.UInt32 normalMap) {
			Algo_fillNormalMap(api.Session, normalMap);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_orientNormalMap(IntPtr _pxz_session_, System.UInt32 normalMap);
		/// <summary>
		/// Orient a tangent space normal map (all Z positive)
		/// </summary>
		/// <param name="normalMap">Normal map to orient</param>
		public void OrientNormalMap(System.UInt32 normalMap) {
			Algo_orientNormalMap(api.Session, normalMap);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region repair

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_barySmooth(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 iteration);
		/// <summary>
		/// Smooth the tessellations by moving the vertices to the barycenter of their neighbors
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="iteration">Number of iterations</param>
		public void BarySmooth(Scene.OccurrenceList occurrences, System.Int32 iteration) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_barySmooth(api.Session, occurrences_c, iteration);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_crackMoebiusStrips(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 maxEdgeCount);
		/// <summary>
		/// Remove moebius strip by topologically cracking them (make it orientable)
		/// </summary>
		/// <param name="occurrences">Occurrences of components to repair</param>
		/// <param name="maxEdgeCount">Maximum number of edges to crack to remove one moebius strip</param>
		public void CrackMoebiusStrips(Scene.OccurrenceList occurrences, System.Int32 maxEdgeCount = 3) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_crackMoebiusStrips(api.Session, occurrences_c, maxEdgeCount);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_crackNonManifoldVertices(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Splits non-manifold vertices
		/// </summary>
		/// <param name="occurrences">Occurrences of components to repair</param>
		public void CrackNonManifoldVertices(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_crackNonManifoldVertices(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Algo_createCavityOccurrences(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double voxelSize, System.Double minimumCavityVolume, Int32 mode, System.UInt32 parent);
		/// <summary>
		/// Identify cavities and create occurrences to show them
		/// </summary>
		/// <param name="occurrences">Occurrences set to identify cavities</param>
		/// <param name="voxelSize">Size of the voxels in mm</param>
		/// <param name="minimumCavityVolume">Minimum volume of a cavity in cubic meter</param>
		/// <param name="mode">Select where to place camera (all cavities, only outer or only inner cavities)</param>
		/// <param name="parent">The create occurrence root will be added under the parent if given, else it will be added under the deeper parent of given occurrences</param>
		public System.UInt32 CreateCavityOccurrences(Scene.OccurrenceList occurrences, System.Double voxelSize, System.Double minimumCavityVolume, InnerOuterOption mode = (Algo.InnerOuterOption)0, System.UInt32 parent = 0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_createCavityOccurrences(api.Session, occurrences_c, voxelSize, minimumCavityVolume, (int)mode, parent);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_invertPolygonFacesOrientation(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Invert the orientation of tessellation elements
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		public void InvertPolygonFacesOrientation(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_invertPolygonFacesOrientation(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_moebiusCracker(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Splits moebius ring
		/// </summary>
		/// <param name="occurrences">Occurrences of components to repair</param>
		public void MoebiusCracker(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_moebiusCracker(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_orientNormals(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Orient existing normal according to the polygons clockwise
		/// </summary>
		/// <param name="occurrences">Occurrences of components to orient normals</param>
		public void OrientNormals(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_orientNormals(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_remeshSurfacicHoles(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double maxDiameter);
		/// <summary>
		/// Resmesh surfacic holes of tessellations
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="maxDiameter">Maximum surfacic holes diameters</param>
		public void RemeshSurfacicHoles(Scene.OccurrenceList occurrences, System.Double maxDiameter) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_remeshSurfacicHoles(api.Session, occurrences_c, maxDiameter);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_removeDegeneratedPolygons(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double tolerance);
		/// <summary>
		/// Remove some kinds of degenerated polygons
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="tolerance">Degenerated tolerance</param>
		public void RemoveDegeneratedPolygons(Scene.OccurrenceList occurrences, System.Double tolerance) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_removeDegeneratedPolygons(api.Session, occurrences_c, tolerance);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_removeMultiplePolygon(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Remove multiple polygon
		/// </summary>
		/// <param name="occurrences">Occurrences of components to repair</param>
		public void RemoveMultiplePolygon(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_removeMultiplePolygon(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Double Algo_removeZFighting(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Remove Z-fighting (surfaces overlapping) by slightly shrinking the selected parts' surfaces
		/// </summary>
		/// <param name="occurrences">Occurrences to process</param>
		public System.Double RemoveZFighting(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var ret = Algo_removeZFighting(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Double)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_repairMesh(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double tolerance, System.Byte crackNonManifold, System.Byte orient);
		/// <summary>
		/// Launch the repair process to repair a disconnected or not clean tessellation
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="tolerance">Connection tolerance</param>
		/// <param name="crackNonManifold">At the end of the repair process, crack resulting non-manifold edges</param>
		/// <param name="orient">If true reorient the model</param>
		public void RepairMesh(Scene.OccurrenceList occurrences, System.Double tolerance, System.Boolean crackNonManifold = true, System.Boolean orient = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_repairMesh(api.Session, occurrences_c, tolerance, Convert.ToByte(crackNonManifold), Convert.ToByte(orient));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_repairNullNormals(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Create normal on an existing normal set when normal is null (polygons appears black)
		/// </summary>
		/// <param name="occurrences">Occurrences of components to repair null normals</param>
		public void RepairNullNormals(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_repairNullNormals(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_separateToManifold(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Remove non manifold edges and try to reconnect manifold groups of triangles
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		public void SeparateToManifold(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_separateToManifold(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_sewBoundary(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double maxDistance);
		/// <summary>
		/// Sew boundaries between them
		/// </summary>
		/// <param name="occurrences">Occurrences of components to repair</param>
		/// <param name="maxDistance">Maximum distance between bundaries</param>
		public void SewBoundary(Scene.OccurrenceList occurrences, System.Double maxDistance) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_sewBoundary(api.Session, occurrences_c, maxDistance);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_vertexOffset(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double offset);
		/// <summary>
		/// Move the vertices by the offsset along their normal
		/// </summary>
		/// <param name="occurrences">Occurrences to process</param>
		/// <param name="offset">Displacement</param>
		public void VertexOffset(Scene.OccurrenceList occurrences, System.Double offset) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_vertexOffset(api.Session, occurrences_c, offset);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region repair faces orientation

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_orientFromFace(IntPtr _pxz_session_);
		/// <summary>
		/// Orient all connected polygons in the same orientation of the polygon selectionned
		/// </summary>
		public void OrientFromFace() {
			Algo_orientFromFace(api.Session);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_orientPolygonFaces(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Byte makeOrientable, System.Byte useArea, Int32 orientStrategy);
		/// <summary>
		/// Orient tessellation elements
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="makeOrientable">Crack moebius strips to make the model orientable</param>
		/// <param name="useArea">Use the area instead of counting the number of triangle</param>
		/// <param name="orientStrategy">Strategy to adopt with this algorithm</param>
		public void OrientPolygonFaces(Scene.OccurrenceList occurrences, System.Boolean makeOrientable = true, System.Boolean useArea = false, OrientStrategy orientStrategy = (Algo.OrientStrategy)0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_orientPolygonFaces(api.Session, occurrences_c, Convert.ToByte(makeOrientable), Convert.ToByte(useArea), (int)orientStrategy);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_orientPolygonFacesAdvanced(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double voxelSize, System.Double minimumCavityVolume, Int32 resolution, Int32 mode, System.Byte considerTransparentOpaque, Int32 orientStrategy);
		/// <summary>
		/// Properly orient all polygons in the same direction, using voxel based view points placement.
		/// </summary>
		/// <param name="occurrences">Occurrences to orient</param>
		/// <param name="voxelSize">Size of the voxels in mm (smaller it is, more viewpoints there are)</param>
		/// <param name="minimumCavityVolume">Minimum volume of a cavity in cubic meter (smaller it is, more viewpoints there are)</param>
		/// <param name="resolution">Resolution of the visibility viewer</param>
		/// <param name="mode">Select where to place camera (all cavities, only outer or only inner cavities)</param>
		/// <param name="considerTransparentOpaque">If True, Parts, Patches or Polygons with a transparent appearance are considered as opaque</param>
		/// <param name="orientStrategy">Strategy to adopt with this algorithm</param>
		public void OrientPolygonFacesAdvanced(Scene.OccurrenceList occurrences, System.Double voxelSize, System.Double minimumCavityVolume, System.Int32 resolution, InnerOuterOption mode = (Algo.InnerOuterOption)0, System.Boolean considerTransparentOpaque = true, OrientStrategyAdvanced orientStrategy = (Algo.OrientStrategyAdvanced)0) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_orientPolygonFacesAdvanced(api.Session, occurrences_c, voxelSize, minimumCavityVolume, resolution, (int)mode, Convert.ToByte(considerTransparentOpaque), (int)orientStrategy);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_orientPolygonFacesFromCamera(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Geom.Point3_c cameraPosition, Geom.Point3_c cameraDirection, Geom.Point3_c cameraUp, Int32 resolution, System.Double fovX);
		/// <summary>
		/// Properly orient all polygons in the same direction, using a specified viewpoint
		/// </summary>
		/// <param name="occurrences">Occurrences to orient</param>
		/// <param name="cameraPosition">Camera position</param>
		/// <param name="cameraDirection">Camera direction</param>
		/// <param name="cameraUp">Camera up vector</param>
		/// <param name="resolution">Resolution of the visibility viewer</param>
		/// <param name="fovX">Horizontal field of view (in degree)</param>
		public void OrientPolygonFacesFromCamera(Scene.OccurrenceList occurrences, Geom.Point3 cameraPosition, Geom.Point3 cameraDirection, Geom.Point3 cameraUp, System.Int32 resolution, System.Double fovX = 90) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			var cameraPosition_c = new Geom.Point3_c();
			Geom.GeomInterface.ConvertValue((Geom.Point3)cameraPosition, ref cameraPosition_c);
			var cameraDirection_c = new Geom.Point3_c();
			Geom.GeomInterface.ConvertValue((Geom.Point3)cameraDirection, ref cameraDirection_c);
			var cameraUp_c = new Geom.Point3_c();
			Geom.GeomInterface.ConvertValue((Geom.Point3)cameraUp, ref cameraUp_c);
			Algo_orientPolygonFacesFromCamera(api.Session, occurrences_c, cameraPosition_c, cameraDirection_c, cameraUp_c, resolution, fovX);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			Geom.GeomInterface.Geom_Point3_free(ref cameraPosition_c);
			Geom.GeomInterface.Geom_Point3_free(ref cameraDirection_c);
			Geom.GeomInterface.Geom_Point3_free(ref cameraUp_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region tessellation conversion

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_equilateralize(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, Int32 maxIterations);
		/// <summary>
		/// Sswap edges to make triangles more equilateral
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="maxIterations">Maximum number of swapping iteration</param>
		public void Equilateralize(Scene.OccurrenceList occurrences, System.Int32 maxIterations = 1) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_equilateralize(api.Session, occurrences_c, maxIterations);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_quadify(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Merge all triangle polygons in the meshes to quadrangles
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		public void Quadify(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_quadify(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_requadify(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Byte forceFullQuad);
		/// <summary>
		/// Advanced function to requadify a triangle tessellation coming from full quad mesh
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="forceFullQuad">Force the results to be only full quad. It it's impossible, nothing is done</param>
		public void Requadify(Scene.OccurrenceList occurrences, System.Boolean forceFullQuad = true) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_requadify(api.Session, occurrences_c, Convert.ToByte(forceFullQuad));
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_toEditableMesh(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Convert all static mesh to editable mesh
		/// </summary>
		/// <param name="occurrences">Occurrences to convert to editable mesh</param>
		public void ToEditableMesh(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_toEditableMesh(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_toStaticMesh(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Convert all editable mesh to static mesh
		/// </summary>
		/// <param name="occurrences">Occurrences to convert to static mesh</param>
		public void ToStaticMesh(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_toStaticMesh(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_triangularize(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Split all non-triangle polygons in the meshes to triangles
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		public void Triangularize(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_triangularize(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region vertex weights

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_createVertexWeightsFromVertexColors(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double offset, System.Double scale);
		/// <summary>
		/// Use vertex colors attributes on meshes of the given occurrence to create vertex weights attributes used by the decimation functions, the finals weights will be computed with w = offset + (red - blue) * scale
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="offset">Offset value for weight computation</param>
		/// <param name="scale">Scale value for weight computation</param>
		public void CreateVertexWeightsFromVertexColors(Scene.OccurrenceList occurrences, System.Double offset = 0, System.Double scale = 1) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_createVertexWeightsFromVertexColors(api.Session, occurrences_c, offset, scale);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_createVertexWeightsFromVisibilityAttributes(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences, System.Double offset, System.Double scale);
		/// <summary>
		/// Use visibility attributes on meshes of the given occurrence to create vertex weights attributes used by the decimation functions. The finals weights will be computed with w = offset + (visibility/maxVisibility) * scale
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		/// <param name="offset">Offset value for weight computation</param>
		/// <param name="scale">Scale value for weight computation</param>
		public void CreateVertexWeightsFromVisibilityAttributes(Scene.OccurrenceList occurrences, System.Double offset = 0, System.Double scale = 1) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_createVertexWeightsFromVisibilityAttributes(api.Session, occurrences_c, offset, scale);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_deleteVertexWeights(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Remove any existing vertex weights attributes on given occurrences
		/// </summary>
		/// <param name="occurrences">Occurrences of components to process</param>
		public void DeleteVertexWeights(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_deleteVertexWeights(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region visibility

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_createVisibilityAttributes(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Create visibility attributes on tessellations
		/// </summary>
		/// <param name="occurrences">Occurrences of components to create attributes</param>
		public void CreateVisibilityAttributes(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_createVisibilityAttributes(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_deleteVisibilityAttributes(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Delete visibility attributes on tessellations
		/// </summary>
		/// <param name="occurrences">Occurrences of components to delete attributes</param>
		public void DeleteVisibilityAttributes(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_deleteVisibilityAttributes(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Algo_flagVisibilityAttributesOnTransparents(IntPtr _pxz_session_, Scene.OccurrenceList_c occurrences);
		/// <summary>
		/// Add one count to all visiblility attributes (poly and patch) on transparent patches
		/// </summary>
		/// <param name="occurrences">Occurrences of components to create attributes</param>
		public void FlagVisibilityAttributesOnTransparents(Scene.OccurrenceList occurrences) {
			var occurrences_c = new Scene.OccurrenceList_c();
			Scene.SceneInterface.ConvertValue((Scene.OccurrenceList)occurrences, ref occurrences_c);
			Algo_flagVisibilityAttributesOnTransparents(api.Session, occurrences_c);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref occurrences_c);
			System.String err = ConvertValue(Algo_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		private PiXYZAPI api;
		internal AlgoInterface(PiXYZAPI api)
		{
			this.api = api;
		}

	}
}
