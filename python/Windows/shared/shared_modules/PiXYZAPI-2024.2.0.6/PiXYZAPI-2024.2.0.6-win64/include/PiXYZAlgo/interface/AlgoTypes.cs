#pragma warning disable CA2101

using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Pixyz.Algo {

	public enum AlignmentMode
	{
		Auto = 0,
		Portrait = 1,
		Landscape = 2,
	}

	public enum AttributType
	{
		Patches = 4020,
		PatchMaterials = 4021,
		PatchBoundaries = 4022,
		UVs = 4035,
		Normals = 4036,
		Tangents = 4037,
		Binormals = 4038,
	}

	public enum MapType
	{
		Diffuse = 0,
		Normal = 1,
		Opacity = 2,
		Roughness = 3,
		Specular = 4,
		Metallic = 5,
		AO = 6,
		Emissive = 7,
		PartId = 8,
		MaterialId = 9,
		ComputeAO = 10,
		Bent = 11,
		UV = 12,
		Displacement = 13,
		LocalPosition = 14,
		GlobalPosition = 15,
		Depth = 16,
		OccurrenceProperty = 17,
		Feature = 18,
		VertexColor = 19,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class BakeMap
	{
		public BakeMap() {}
		public BakeMap(BakeMap o) {
			this.type = o.type;
			this.properties = o.properties;
		}
		public MapType type;
		public Scene.PropertyValueList properties;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct BakeMap_c
	{
		public Int32 type;
		public Scene.PropertyValueList_c properties;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class BakeMapList {
		public Algo.BakeMap[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public BakeMapList(Algo.BakeMap[] tab) { list = tab; }
		public static implicit operator Algo.BakeMap[](BakeMapList o) { return o.list; }
		public Algo.BakeMap this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public BakeMapList(int size) { list = new Algo.BakeMap[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct BakeMapList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct BakeMaps
	{
		public BakeMaps(BakeMaps o) {
			this.diffuse = o.diffuse;
			this.normal = o.normal;
			this.roughness = o.roughness;
			this.metallic = o.metallic;
			this.opacity = o.opacity;
			this.ambientOcclusion = o.ambientOcclusion;
			this.emissive = o.emissive;
		}
		public System.Boolean diffuse;
		public System.Boolean normal;
		public System.Boolean roughness;
		public System.Boolean metallic;
		public System.Boolean opacity;
		public System.Boolean ambientOcclusion;
		public System.Boolean emissive;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct BakeMaps_c
	{
		public System.Byte diffuse;
		public System.Byte normal;
		public System.Byte roughness;
		public System.Byte metallic;
		public System.Byte opacity;
		public System.Byte ambientOcclusion;
		public System.Byte emissive;
	}

	public enum BakingMethod
	{
		RayOnly = 0,
		ProjOnly = 1,
		RayAndProj = 2,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class BakeOption
	{
		public BakeOption() {}
		public BakeOption(BakeOption o) {
			this.bakingMethod = o.bakingMethod;
			this.resolution = o.resolution;
			this.padding = o.padding;
			this.textures = o.textures;
		}
		public BakingMethod bakingMethod;
		public System.Int32 resolution;
		public System.Int32 padding;
		public BakeMaps textures;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct BakeOption_c
	{
		public Int32 bakingMethod;
		public Int32 resolution;
		public Int32 padding;
		public BakeMaps_c textures;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Box
	{
		public Box() {}
		public Box(Box o) {
			this.position = o.position;
			this.length = o.length;
			this.height = o.height;
			this.depth = o.depth;
		}
		public Geom.Affine position;
		public System.Double length;
		public System.Double height;
		public System.Double depth;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Box_c
	{
		public Geom.Affine_c position;
		public System.Double length;
		public System.Double height;
		public System.Double depth;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct BoxParameters
	{
		public BoxParameters(BoxParameters o) {
			this.SizeX = o.SizeX;
			this.SizeY = o.SizeY;
			this.SizeZ = o.SizeZ;
			this.Subdivision = o.Subdivision;
		}
		public System.Double SizeX;
		public System.Double SizeY;
		public System.Double SizeZ;
		public System.Int32 Subdivision;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct BoxParameters_c
	{
		public System.Double SizeX;
		public System.Double SizeY;
		public System.Double SizeZ;
		public Int32 Subdivision;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct CapsuleParameters
	{
		public CapsuleParameters(CapsuleParameters o) {
			this.Radius = o.Radius;
			this.Height = o.Height;
			this.Latitude = o.Latitude;
			this.Longitude = o.Longitude;
		}
		public System.Double Radius;
		public System.Double Height;
		public System.Int32 Latitude;
		public System.Int32 Longitude;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct CapsuleParameters_c
	{
		public System.Double Radius;
		public System.Double Height;
		public Int32 Latitude;
		public Int32 Longitude;
	}

	public enum ComputingQuality
	{
		High = 0,
		Medium = 1,
		Low = 2,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct ConeParameters
	{
		public ConeParameters(ConeParameters o) {
			this.BottomRadius = o.BottomRadius;
			this.Height = o.Height;
			this.Sides = o.Sides;
		}
		public System.Double BottomRadius;
		public System.Double Height;
		public System.Int32 Sides;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ConeParameters_c
	{
		public System.Double BottomRadius;
		public System.Double Height;
		public Int32 Sides;
	}

	public enum ConvexityFilter
	{
		OnConvex = 0,
		OnConcave = 1,
		OnConvexAndConcave = 2,
	}

	public enum CostEvaluation
	{
		SumEvaluation = 0,
		MaxEvaluation = 1,
		AverageEvaluation = 2,
	}

	public enum CreateOccluder
	{
		Occludee = 0,
		Occluder = 1,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct CustomBakeMap
	{
		public CustomBakeMap(CustomBakeMap o) {
			this.name = o.name;
			this.component = o.component;
		}
		public System.String name;
		public System.Int32 component;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct CustomBakeMap_c
	{
		public IntPtr name;
		public Int32 component;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class CustomBakeMapList {
		public Algo.CustomBakeMap[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public CustomBakeMapList(Algo.CustomBakeMap[] tab) { list = tab; }
		public static implicit operator Algo.CustomBakeMap[](CustomBakeMapList o) { return o.list; }
		public Algo.CustomBakeMap this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public CustomBakeMapList(int size) { list = new Algo.CustomBakeMap[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct CustomBakeMapList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Cylinder
	{
		public Cylinder() {}
		public Cylinder(Cylinder o) {
			this.position = o.position;
			this.radius = o.radius;
			this.length = o.length;
		}
		public Geom.Affine position;
		public System.Double radius;
		public System.Double length;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Cylinder_c
	{
		public Geom.Affine_c position;
		public System.Double radius;
		public System.Double length;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct CylinderParameters
	{
		public CylinderParameters(CylinderParameters o) {
			this.Radius = o.Radius;
			this.Height = o.Height;
			this.Sides = o.Sides;
		}
		public System.Double Radius;
		public System.Double Height;
		public System.Int32 Sides;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct CylinderParameters_c
	{
		public System.Double Radius;
		public System.Double Height;
		public Int32 Sides;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct DecimateOptionsSelector
	{
		public enum Type
		{
			UNKNOWN = 0,
			TRIANGLECOUNT = 1,
			RATIO = 2,
		}
		public System.UInt64 triangleCount;
		public System.Double ratio;
		public Type _type;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct DecimateOptionsSelector_c
	{
		public System.UInt64 triangleCount;
		public System.Double ratio;
		public int _type;
	}

	public enum DiskSegmentationMethod
	{
		Perimeter = 0,
		GaussianCurvature = 1,
	}

	public enum ElementFilter
	{
		Polygons = 0,
		Points = 1,
		Hybrid = 2,
	}

	public enum FeatureType
	{
		Unknown = 0,
		ThroughHole = 1,
		BlindHole = 2,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class FeatureInput
	{
		public FeatureInput() {}
		public FeatureInput(FeatureInput o) {
			this.position = o.position;
			this.direction = o.direction;
			this.diameter = o.diameter;
		}
		public Geom.Point3 position;
		public Geom.Point3 direction;
		public System.Double diameter;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct FeatureInput_c
	{
		public Geom.Point3_c position;
		public Geom.Point3_c direction;
		public System.Double diameter;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class FeatureInputList {
		public Algo.FeatureInput[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public FeatureInputList(Algo.FeatureInput[] tab) { list = tab; }
		public static implicit operator Algo.FeatureInput[](FeatureInputList o) { return o.list; }
		public Algo.FeatureInput this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public FeatureInputList(int size) { list = new Algo.FeatureInput[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct FeatureInputList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Feature
	{
		public Feature() {}
		public Feature(Feature o) {
			this.type = o.type;
			this.inputs = o.inputs;
		}
		public FeatureType type;
		public FeatureInputList inputs;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Feature_c
	{
		public Int32 type;
		public FeatureInputList_c inputs;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class FeatureList {
		public Algo.Feature[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public FeatureList(Algo.Feature[] tab) { list = tab; }
		public static implicit operator Algo.Feature[](FeatureList o) { return o.list; }
		public Algo.Feature this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public FeatureList(int size) { list = new Algo.Feature[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct FeatureList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	public enum FilletingMode
	{
		Width = 0,
		Distance = 1,
		Depth = 2,
		Radius = 3,
	}

	public enum FlatteningStopCondition
	{
		MEAN_DEFORMATION = 0,
		ABSOLUTE_DEFORMATION = 1,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct HexahedronParameters
	{
		public HexahedronParameters(HexahedronParameters o) {
			this.XLength = o.XLength;
			this.YLength = o.YLength;
			this.ZLength = o.ZLength;
		}
		public System.Double XLength;
		public System.Double YLength;
		public System.Double ZLength;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct HexahedronParameters_c
	{
		public System.Double XLength;
		public System.Double YLength;
		public System.Double ZLength;
	}

	public enum InnerOuterOption
	{
		All = 0,
		OnlyOuter = 1,
		OnlyInners = 2,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class LegoReturn
	{
		public LegoReturn() {}
		public LegoReturn(LegoReturn o) {
			this.Root = o.Root;
			this.Bricks = o.Bricks;
		}
		public System.UInt32 Root;
		public CAD.LegoBrickDefinitionList Bricks;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct LegoReturn_c
	{
		public System.UInt32 Root;
		public CAD.LegoBrickDefinitionList_c Bricks;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class MapTypeList {
		public Algo.MapType[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public MapTypeList(Algo.MapType[] tab) { list = tab; }
		public static implicit operator Algo.MapType[](MapTypeList o) { return o.list; }
		public Algo.MapType this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public MapTypeList(int size) { list = new Algo.MapType[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct MapTypeList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	public enum MaxTransformationType
	{
		Similarity = 0,
		Affine = 1,
		Homography = 2,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class OccurrenceFeatures
	{
		public OccurrenceFeatures() {}
		public OccurrenceFeatures(OccurrenceFeatures o) {
			this.occurrence = o.occurrence;
			this.features = o.features;
		}
		public System.UInt32 occurrence;
		public FeatureList features;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct OccurrenceFeatures_c
	{
		public System.UInt32 occurrence;
		public FeatureList_c features;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class OccurrenceFeaturesList {
		public Algo.OccurrenceFeatures[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public OccurrenceFeaturesList(Algo.OccurrenceFeatures[] tab) { list = tab; }
		public static implicit operator Algo.OccurrenceFeatures[](OccurrenceFeaturesList o) { return o.list; }
		public Algo.OccurrenceFeatures this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public OccurrenceFeaturesList(int size) { list = new Algo.OccurrenceFeatures[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct OccurrenceFeaturesList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class OctahedralImpostor
	{
		public OctahedralImpostor() {}
		public OctahedralImpostor(OctahedralImpostor o) {
			this.OctaTransform = o.OctaTransform;
			this.Radius = o.Radius;
			this.NormalMap = o.NormalMap;
			this.DepthMap = o.DepthMap;
			this.DiffuseMap = o.DiffuseMap;
			this.MetallicMap = o.MetallicMap;
			this.AOMap = o.AOMap;
			this.RoughnessMap = o.RoughnessMap;
		}
		public Geom.Matrix4 OctaTransform;
		public System.Double Radius;
		public System.UInt32 NormalMap;
		public System.UInt32 DepthMap;
		public System.UInt32 DiffuseMap;
		public System.UInt32 MetallicMap;
		public System.UInt32 AOMap;
		public System.UInt32 RoughnessMap;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct OctahedralImpostor_c
	{
		public Geom.Matrix4_c OctaTransform;
		public System.Double Radius;
		public System.UInt32 NormalMap;
		public System.UInt32 DepthMap;
		public System.UInt32 DiffuseMap;
		public System.UInt32 MetallicMap;
		public System.UInt32 AOMap;
		public System.UInt32 RoughnessMap;
	}

	public enum OrientStrategy
	{
		ExteriorOnly = 0,
		VisibilityOrExterior = 1,
		VisibilityByConnected = 2,
		VisibilityByPolygon = 3,
		ConformToMajority = 4,
	}

	public enum OrientStrategyAdvanced
	{
		VisibilityByConnected = 0,
		VisibilityByPolygon = 1,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Plane
	{
		public Plane() {}
		public Plane(Plane o) {
			this.position = o.position;
			this.length = o.length;
			this.height = o.height;
		}
		public Geom.Affine position;
		public System.Double length;
		public System.Double height;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Plane_c
	{
		public Geom.Affine_c position;
		public System.Double length;
		public System.Double height;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct PlaneParameters
	{
		public PlaneParameters(PlaneParameters o) {
			this.SizeX = o.SizeX;
			this.SizeY = o.SizeY;
			this.SubdivisionX = o.SubdivisionX;
			this.SubdivisionY = o.SubdivisionY;
		}
		public System.Double SizeX;
		public System.Double SizeY;
		public System.Int32 SubdivisionX;
		public System.Int32 SubdivisionY;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct PlaneParameters_c
	{
		public System.Double SizeX;
		public System.Double SizeY;
		public Int32 SubdivisionX;
		public Int32 SubdivisionY;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct SphereParameters
	{
		public SphereParameters(SphereParameters o) {
			this.Radius = o.Radius;
			this.Latitude = o.Latitude;
			this.Longitude = o.Longitude;
		}
		public System.Double Radius;
		public System.Int32 Latitude;
		public System.Int32 Longitude;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct SphereParameters_c
	{
		public System.Double Radius;
		public Int32 Latitude;
		public Int32 Longitude;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct PrimitiveShapeParameters
	{
		public enum Type
		{
			UNKNOWN = 0,
			BOX = 1,
			PLANE = 2,
			SPHERE = 3,
			CYLINDER = 4,
			CONE = 5,
			CAPSULE = 6,
		}
		public BoxParameters Box;
		public PlaneParameters Plane;
		public SphereParameters Sphere;
		public CylinderParameters Cylinder;
		public ConeParameters Cone;
		public CapsuleParameters Capsule;
		public Type _type;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct PrimitiveShapeParameters_c
	{
		public BoxParameters_c Box;
		public PlaneParameters_c Plane;
		public SphereParameters_c Sphere;
		public CylinderParameters_c Cylinder;
		public ConeParameters_c Cone;
		public CapsuleParameters_c Capsule;
		public int _type;
	}

	public enum QualityMemoryTradeoff
	{
		PreferQuality = 0,
		PreferMemory = 1,
	}

	public enum QualitySpeedTradeoff
	{
		PreferQuality = 0,
		PreferSpeed = 1,
	}

	public enum RatioUV3DMode
	{
		SmallestRatio = 0,
		HighestRatio = 1,
		AverageRatio = 2,
		MedianRatio = 3,
	}

	public enum RelaxUVMethod
	{
		Angle = 0,
		Edge = 1,
	}

	public enum ReplaceByBoxType
	{
		Minimum = 0,
		LocallyAligned = 1,
	}

	public enum ReplaceByMode
	{
		ByOccurrence = 0,
		All = 1,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct ReplaceByOccurrenceOptions
	{
		public ReplaceByOccurrenceOptions(ReplaceByOccurrenceOptions o) {
			this.Occurrence = o.Occurrence;
			this.Aligned = o.Aligned;
		}
		public System.UInt32 Occurrence;
		public System.Boolean Aligned;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ReplaceByOccurrenceOptions_c
	{
		public System.UInt32 Occurrence;
		public System.Byte Aligned;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ReplaceByPrimitiveOptions
	{
		public ReplaceByPrimitiveOptions() {}
		public ReplaceByPrimitiveOptions(ReplaceByPrimitiveOptions o) {
			this.Type = o.Type;
			this.Aligned = o.Aligned;
			this.GenerateUV = o.GenerateUV;
		}
		public PrimitiveShapeParameters Type;
		public System.Boolean Aligned;
		public System.Boolean GenerateUV;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ReplaceByPrimitiveOptions_c
	{
		public PrimitiveShapeParameters_c Type;
		public System.Byte Aligned;
		public System.Byte GenerateUV;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct ReplaceByOption
	{
		public enum Type
		{
			UNKNOWN = 0,
			OCCURRENCE = 1,
			BOUNDINGBOX = 2,
			CONVEXHULL = 3,
			PRIMITIVE = 4,
		}
		public ReplaceByOccurrenceOptions Occurrence;
		public ReplaceByBoxType BoundingBox;
		public System.Int32 ConvexHull;
		public ReplaceByPrimitiveOptions Primitive;
		public Type _type;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ReplaceByOption_c
	{
		public ReplaceByOccurrenceOptions_c Occurrence;
		public Int32 BoundingBox;
		public Int32 ConvexHull;
		public ReplaceByPrimitiveOptions_c Primitive;
		public int _type;
	}

	public enum SawingMode
	{
		SawOnly = 0,
		SawAndSplit = 1,
		KeepInside = 2,
		KeepOutside = 3,
	}

	public enum SelectionLevel
	{
		Parts = 0,
		Patches = 1,
		Polygons = 2,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Sphere
	{
		public Sphere() {}
		public Sphere(Sphere o) {
			this.position = o.position;
			this.radius = o.radius;
		}
		public Geom.Affine position;
		public System.Double radius;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Sphere_c
	{
		public Geom.Affine_c position;
		public System.Double radius;
	}

	public enum UVGenerationMode
	{
		NoUV = 0,
		IntrinsicUV = 1,
		ConformalScaledUV = 2,
	}

	public enum UVImportanceEnum
	{
		PreserveSeamsAndReduceDeformation = 0,
		PreserveSeams = 1,
		IgnoreUV = 2,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct UseColorOption
	{
		public enum Type
		{
			UNKNOWN = 0,
			USELINESCOLOR = 1,
			CHOOSECOLOR = 2,
		}
		public System.Int32 UseLinesColor;
		public Core.Color ChooseColor;
		public Type _type;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct UseColorOption_c
	{
		public Int32 UseLinesColor;
		public Core.Color_c ChooseColor;
		public int _type;
	}

	public enum VisibilityToWeightMode
	{
		FrontCountOnly = 0,
		FrontAndBackCount = 1,
		FrontCountOnlyAreaWeighted = 2,
		FrontAndBackCountAreaWeighted = 3,
	}

	//C# delegate
	public delegate Core.ColorAlpha getPixelValue(Geom.Point3 fromPos, Geom.Point2 param, System.UInt64 polygonIndex, System.UInt32 occurrence);

	//C delegate
	internal delegate Core.ColorAlpha_c getPixelValue_c(Geom.Point3_c fromPos, Geom.Point2_c param, System.UInt64 polygonIndex, System.UInt32 occurrence);

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class getPixelValueList {
		public Algo.getPixelValue[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public getPixelValueList(Algo.getPixelValue[] tab) { list = tab; }
		public static implicit operator Algo.getPixelValue[](getPixelValueList o) { return o.list; }
		public Algo.getPixelValue this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public getPixelValueList(int size) { list = new Algo.getPixelValue[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct getPixelValueList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetAllAxisFromCADModelReturn
	{
		public GetAllAxisFromCADModelReturn() {}
		public GetAllAxisFromCADModelReturn(GetAllAxisFromCADModelReturn o) {
			this.occurrences = o.occurrences;
			this.axis = o.axis;
		}
		public Scene.OccurrenceList occurrences;
		public Geom.Matrix4ListList axis;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetAllAxisFromCADModelReturn_c
	{
		public Scene.OccurrenceList_c occurrences;
		public Geom.Matrix4ListList_c axis;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct GetVisibilityStatsReturn
	{
		public GetVisibilityStatsReturn(GetVisibilityStatsReturn o) {
			this.visibleCountFront = o.visibleCountFront;
			this.visibleCountBack = o.visibleCountBack;
		}
		public System.Int32 visibleCountFront;
		public System.Int32 visibleCountBack;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetVisibilityStatsReturn_c
	{
		public Int32 visibleCountFront;
		public Int32 visibleCountBack;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct GetUVQualityMetricsReturn
	{
		public GetUVQualityMetricsReturn(GetUVQualityMetricsReturn o) {
			this.chartCount = o.chartCount;
			this.area3D = o.area3D;
			this.area2D = o.area2D;
			this.occupancy = o.occupancy;
			this.crumbliness = o.crumbliness;
			this.samplingStd = o.samplingStd;
		}
		public System.UInt32 chartCount;
		public System.Double area3D;
		public System.Double area2D;
		public System.Double occupancy;
		public System.Double crumbliness;
		public System.Double samplingStd;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetUVQualityMetricsReturn_c
	{
		public System.UInt32 chartCount;
		public System.Double area3D;
		public System.Double area2D;
		public System.Double occupancy;
		public System.Double crumbliness;
		public System.Double samplingStd;
	}

}
