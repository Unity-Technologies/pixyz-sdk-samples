#pragma warning disable CA2101

using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Pixyz.Scene {

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class AlternativeTreeList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public AlternativeTreeList() {}
		public AlternativeTreeList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](AlternativeTreeList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public AlternativeTreeList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct AlternativeTreeList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	public enum AnimChannelType
	{
		SIMPLE = 0,
		VECTOR3 = 1,
		QUATERNION = 2,
		MATRIX4 = 3,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class AnimChannelInfo
	{
		public AnimChannelInfo() {}
		public AnimChannelInfo(AnimChannelInfo o) {
			this.name = o.name;
			this.type = o.type;
			this.mainPropertyBinder = o.mainPropertyBinder;
			this.hasKeyFrames = o.hasKeyFrames;
		}
		public System.String name;
		public AnimChannelType type;
		public System.UInt32 mainPropertyBinder;
		public System.Boolean hasKeyFrames;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct AnimChannelInfo_c
	{
		public IntPtr name;
		public Int32 type;
		public System.UInt32 mainPropertyBinder;
		public System.Byte hasKeyFrames;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class AnimChannelList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public AnimChannelList() {}
		public AnimChannelList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](AnimChannelList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public AnimChannelList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct AnimChannelList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct AnimPropertyBinder
	{
		public AnimPropertyBinder(AnimPropertyBinder o) {
			this.occurrence = o.occurrence;
			this.animation = o.animation;
			this.mainChannel = o.mainChannel;
		}
		public System.UInt32 occurrence;
		public System.UInt32 animation;
		public System.UInt32 mainChannel;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct AnimPropertyBinder_c
	{
		public System.UInt32 occurrence;
		public System.UInt32 animation;
		public System.UInt32 mainChannel;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class AnimPropertyBinderList {
		public Scene.AnimPropertyBinder[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public AnimPropertyBinderList(Scene.AnimPropertyBinder[] tab) { list = tab; }
		public static implicit operator Scene.AnimPropertyBinder[](AnimPropertyBinderList o) { return o.list; }
		public Scene.AnimPropertyBinder this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public AnimPropertyBinderList(int size) { list = new Scene.AnimPropertyBinder[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct AnimPropertyBinderList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct AnimationInfo
	{
		public AnimationInfo(AnimationInfo o) {
			this.name = o.name;
			this.group = o.group;
			this.length = o.length;
		}
		public System.String name;
		public System.String group;
		public System.UInt64 length;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct AnimationInfo_c
	{
		public IntPtr name;
		public IntPtr group;
		public System.UInt64 length;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class AnimationList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public AnimationList() {}
		public AnimationList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](AnimationList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public AnimationList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct AnimationList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class TessellatedShapeList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public TessellatedShapeList() {}
		public TessellatedShapeList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](TessellatedShapeList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public TessellatedShapeList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct TessellatedShapeList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class AnnotationDefinition
	{
		public AnnotationDefinition() {}
		public AnnotationDefinition(AnnotationDefinition o) {
			this.id = o.id;
			this.name = o.name;
			this.visible = o.visible;
			this.group = o.group;
			this.shapes = o.shapes;
		}
		public System.UInt32 id;
		public System.String name;
		public System.Boolean visible;
		public System.UInt32 group;
		public TessellatedShapeList shapes;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct AnnotationDefinition_c
	{
		public System.UInt32 id;
		public IntPtr name;
		public System.Byte visible;
		public System.UInt32 group;
		public TessellatedShapeList_c shapes;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class AnnotationDefinitionList {
		public Scene.AnnotationDefinition[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public AnnotationDefinitionList(Scene.AnnotationDefinition[] tab) { list = tab; }
		public static implicit operator Scene.AnnotationDefinition[](AnnotationDefinitionList o) { return o.list; }
		public Scene.AnnotationDefinition this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public AnnotationDefinitionList(int size) { list = new Scene.AnnotationDefinition[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct AnnotationDefinitionList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class AnnotationGroupList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public AnnotationGroupList() {}
		public AnnotationGroupList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](AnnotationGroupList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public AnnotationGroupList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct AnnotationGroupList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class AnnotationList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public AnnotationList() {}
		public AnnotationList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](AnnotationList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public AnnotationList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct AnnotationList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ComponentList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public ComponentList() {}
		public ComponentList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](ComponentList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public ComponentList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ComponentList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	public enum ComponentType
	{
		Part = 0,
		PMI = 1,
		Light = 2,
		VisualBehavior = 3,
		InteractionBehavior = 4,
		Metadata = 5,
		Variant = 6,
		Animation = 7,
		Joint = 8,
		Widget = 9,
		OoCComponent = 10,
		LODComponent = 11,
		ExternalDataComponent = 12,
		HLODComponent = 13,
		CuttingPlaneComponent = 14,
		ReferencedDataComponent = 15,
		CameraComponent = 16,
		FeatureComponent = 17,
		SubpartMaterial = 18,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Filter
	{
		public Filter(Filter o) {
			this.id = o.id;
			this.name = o.name;
			this.expr = o.expr;
		}
		public System.UInt32 id;
		public System.String name;
		public System.String expr;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Filter_c
	{
		public System.UInt32 id;
		public IntPtr name;
		public IntPtr expr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class FilterList {
		public Scene.Filter[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public FilterList(Scene.Filter[] tab) { list = tab; }
		public static implicit operator Scene.Filter[](FilterList o) { return o.list; }
		public Scene.Filter this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public FilterList(int size) { list = new Scene.Filter[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct FilterList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class JointDefinition
	{
		public JointDefinition() {}
		public JointDefinition(JointDefinition o) {
			this.id = o.id;
			this.jointComponent = o.jointComponent;
			this.isRoot = o.isRoot;
			this.rootJoint = o.rootJoint;
			this.parent = o.parent;
			this.children = o.children;
			this.matrix = o.matrix;
			this.gloablMatrix = o.gloablMatrix;
		}
		public System.UInt32 id;
		public System.UInt32 jointComponent;
		public System.Boolean isRoot;
		public System.UInt32 rootJoint;
		public System.UInt32 parent;
		public Polygonal.JointList children;
		public Geom.Matrix4 matrix;
		public Geom.Matrix4 gloablMatrix;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct JointDefinition_c
	{
		public System.UInt32 id;
		public System.UInt32 jointComponent;
		public System.Byte isRoot;
		public System.UInt32 rootJoint;
		public System.UInt32 parent;
		public Polygonal.JointList_c children;
		public Geom.Matrix4_c matrix;
		public Geom.Matrix4_c gloablMatrix;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class JointDefinitionList {
		public Scene.JointDefinition[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public JointDefinitionList(Scene.JointDefinition[] tab) { list = tab; }
		public static implicit operator Scene.JointDefinition[](JointDefinitionList o) { return o.list; }
		public Scene.JointDefinition this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public JointDefinitionList(int size) { list = new Scene.JointDefinition[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct JointDefinitionList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class KeyframeList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public KeyframeList() {}
		public KeyframeList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](KeyframeList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public KeyframeList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct KeyframeList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class LODComponentList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public LODComponentList() {}
		public LODComponentList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](LODComponentList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public LODComponentList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct LODComponentList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class LODList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public LODList() {}
		public LODList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](LODList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public LODList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct LODList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	public enum LightType
	{
		DirectionalLight = 0,
		PositionalLight = 1,
		SpotLight = 2,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct MaterialCount
	{
		public MaterialCount(MaterialCount o) {
			this.material = o.material;
			this.count = o.count;
		}
		public System.UInt32 material;
		public System.Int32 count;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct MaterialCount_c
	{
		public System.UInt32 material;
		public Int32 count;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class MaterialCountList {
		public Scene.MaterialCount[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public MaterialCountList(Scene.MaterialCount[] tab) { list = tab; }
		public static implicit operator Scene.MaterialCount[](MaterialCountList o) { return o.list; }
		public Scene.MaterialCount this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public MaterialCountList(int size) { list = new Scene.MaterialCount[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct MaterialCountList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct MergeByRegionsStrategy
	{
		public enum Type
		{
			UNKNOWN = 0,
			NUMBEROFREGIONS = 1,
			SIZEOFREGIONS = 2,
		}
		public System.Int32 NumberOfRegions;
		public System.Double SizeOfRegions;
		public Type _type;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct MergeByRegionsStrategy_c
	{
		public Int32 NumberOfRegions;
		public System.Double SizeOfRegions;
		public int _type;
	}

	public enum MergeHiddenPartsMode
	{
		Destroy = 0,
		MakeVisible = 1,
		MergeSeparately = 2,
	}

	public enum MergeStrategy
	{
		mergePartOccurrences = 0,
		MergeByMaterials = 1,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct PropertyValue
	{
		public PropertyValue(PropertyValue o) {
			this.name = o.name;
			this.value = o.value;
		}
		public System.String name;
		public System.String value;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct PropertyValue_c
	{
		public IntPtr name;
		public IntPtr value;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class PropertyValueList {
		public Scene.PropertyValue[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public PropertyValueList(Scene.PropertyValue[] tab) { list = tab; }
		public static implicit operator Scene.PropertyValue[](PropertyValueList o) { return o.list; }
		public Scene.PropertyValue this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public PropertyValueList(int size) { list = new Scene.PropertyValue[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct PropertyValueList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct MetadataDefinition {
		public MetadataDefinition(PropertyValueList value) { this._base = value; }
		public static implicit operator PropertyValueList(MetadataDefinition v) { return v._base; }
		public static implicit operator MetadataDefinition(PropertyValueList v) { return new MetadataDefinition(v); }
		public PropertyValueList _base;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class MetadataDefinitionList {
		public Scene.MetadataDefinition[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public MetadataDefinitionList(Scene.MetadataDefinition[] tab) { list = tab; }
		public static implicit operator Scene.MetadataDefinition[](MetadataDefinitionList o) { return o.list; }
		public Scene.MetadataDefinition this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public MetadataDefinitionList(int size) { list = new Scene.MetadataDefinition[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct MetadataDefinitionList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class MetadataList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public MetadataList() {}
		public MetadataList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](MetadataList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public MetadataList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct MetadataList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class OccurrenceList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public OccurrenceList() {}
		public OccurrenceList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](OccurrenceList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public OccurrenceList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct OccurrenceList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class OccurrenceListList {
		public Scene.OccurrenceList[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public OccurrenceListList(Scene.OccurrenceList[] tab) { list = tab; }
		public static implicit operator Scene.OccurrenceList[](OccurrenceListList o) { return o.list; }
		public Scene.OccurrenceList this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public OccurrenceListList(int size) { list = new Scene.OccurrenceList[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct OccurrenceListList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class PackedTree
	{
		public PackedTree() {}
		public PackedTree(PackedTree o) {
			this.occurrences = o.occurrences;
			this.parents = o.parents;
			this.names = o.names;
			this.visible = o.visible;
			this.materials = o.materials;
			this.transformIndices = o.transformIndices;
			this.transformMatrices = o.transformMatrices;
			this.customProperties = o.customProperties;
		}
		public OccurrenceList occurrences;
		public Core.IntList parents;
		public Core.StringList names;
		public Core.InheritableBoolList visible;
		public Material.MaterialList materials;
		public Core.IntList transformIndices;
		public Geom.Matrix4List transformMatrices;
		public Core.StringPairListList customProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct PackedTree_c
	{
		public OccurrenceList_c occurrences;
		public Core.IntList_c parents;
		public Core.StringList_c names;
		public Core.InheritableBoolList_c visible;
		public Material.MaterialList_c materials;
		public Core.IntList_c transformIndices;
		public Geom.Matrix4List_c transformMatrices;
		public Core.StringPairListList_c customProperties;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class PartList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public PartList() {}
		public PartList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](PartList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public PartList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct PartList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	public enum PartialLoad_Status
	{
		NOT_LOADED = 0,
		LOADED = 1,
		LOADING = 2,
		LOADING_ALL = 3,
	}

	public enum Primitive_Type
	{
		CUBE = 0,
		SPHERE = 1,
		PLAN = 2,
		CONE = 3,
		ARROW = 4,
		CYLINDER = 5,
		CAPSULE = 6,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ProberInfo
	{
		public ProberInfo() {}
		public ProberInfo(ProberInfo o) {
			this.occurrence = o.occurrence;
			this.position = o.position;
		}
		public System.UInt32 occurrence;
		public Geom.Point3 position;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ProberInfo_c
	{
		public System.UInt32 occurrence;
		public Geom.Point3_c position;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ProductViewDefinition
	{
		public ProductViewDefinition() {}
		public ProductViewDefinition(ProductViewDefinition o) {
			this.id = o.id;
			this.name = o.name;
			this.groupName = o.groupName;
			this.view = o.view;
			this.viewIsSet = o.viewIsSet;
			this.viewIsOrtho = o.viewIsOrtho;
			this.viewFov = o.viewFov;
			this.cuttingPlane = o.cuttingPlane;
			this.cuttingPlanePosition = o.cuttingPlanePosition;
			this.cuttingPlaneNormal = o.cuttingPlaneNormal;
			this.explodedViewFactor = o.explodedViewFactor;
			this.explodedViewX = o.explodedViewX;
			this.explodedViewY = o.explodedViewY;
			this.explodedViewZ = o.explodedViewZ;
			this.annotations = o.annotations;
		}
		public System.UInt32 id;
		public System.String name;
		public System.String groupName;
		public Geom.Matrix4 view;
		public System.Boolean viewIsSet;
		public System.Boolean viewIsOrtho;
		public System.Double viewFov;
		public System.Boolean cuttingPlane;
		public Geom.Point3 cuttingPlanePosition;
		public Geom.Point3 cuttingPlaneNormal;
		public System.Double explodedViewFactor;
		public System.Boolean explodedViewX;
		public System.Boolean explodedViewY;
		public System.Boolean explodedViewZ;
		public AnnotationList annotations;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ProductViewDefinition_c
	{
		public System.UInt32 id;
		public IntPtr name;
		public IntPtr groupName;
		public Geom.Matrix4_c view;
		public System.Byte viewIsSet;
		public System.Byte viewIsOrtho;
		public System.Double viewFov;
		public System.Byte cuttingPlane;
		public Geom.Point3_c cuttingPlanePosition;
		public Geom.Point3_c cuttingPlaneNormal;
		public System.Double explodedViewFactor;
		public System.Byte explodedViewX;
		public System.Byte explodedViewY;
		public System.Byte explodedViewZ;
		public AnnotationList_c annotations;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ProductViewDefinitionList {
		public Scene.ProductViewDefinition[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public ProductViewDefinitionList(Scene.ProductViewDefinition[] tab) { list = tab; }
		public static implicit operator Scene.ProductViewDefinition[](ProductViewDefinitionList o) { return o.list; }
		public Scene.ProductViewDefinition this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public ProductViewDefinitionList(int size) { list = new Scene.ProductViewDefinition[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ProductViewDefinitionList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class RayHit
	{
		public RayHit() {}
		public RayHit(RayHit o) {
			this.rayParam = o.rayParam;
			this.occurrence = o.occurrence;
			this.triangleIndex = o.triangleIndex;
			this.triangleParam = o.triangleParam;
		}
		public System.Double rayParam;
		public System.UInt32 occurrence;
		public System.Int32 triangleIndex;
		public Geom.Point2 triangleParam;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct RayHit_c
	{
		public System.Double rayParam;
		public System.UInt32 occurrence;
		public Int32 triangleIndex;
		public Geom.Point2_c triangleParam;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class RayHitList {
		public Scene.RayHit[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public RayHitList(Scene.RayHit[] tab) { list = tab; }
		public static implicit operator Scene.RayHit[](RayHitList o) { return o.list; }
		public Scene.RayHit this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public RayHitList(int size) { list = new Scene.RayHit[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct RayHitList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct ResizeByMaximumSizeOptions
	{
		public ResizeByMaximumSizeOptions(ResizeByMaximumSizeOptions o) {
			this.TextureSize = o.TextureSize;
			this.KeepTextureRatio = o.KeepTextureRatio;
		}
		public System.Int32 TextureSize;
		public System.Boolean KeepTextureRatio;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ResizeByMaximumSizeOptions_c
	{
		public Int32 TextureSize;
		public System.Byte KeepTextureRatio;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct ResizeByTexturesOptions
	{
		public enum Type
		{
			UNKNOWN = 0,
			ALLTEXTURES = 1,
			SELECTION = 2,
		}
		public System.Int32 AllTextures;
		public Material.ImageList Selection;
		public Type _type;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ResizeByTexturesOptions_c
	{
		public Int32 AllTextures;
		public Material.ImageList_c Selection;
		public int _type;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct ResizeTexturesInputMode
	{
		public enum Type
		{
			UNKNOWN = 0,
			OCCURRENCES = 1,
			TEXTURES = 2,
		}
		public OccurrenceList Occurrences;
		public ResizeByTexturesOptions Textures;
		public Type _type;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ResizeTexturesInputMode_c
	{
		public OccurrenceList_c Occurrences;
		public ResizeByTexturesOptions_c Textures;
		public int _type;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct ResizeTexturesResizeMode
	{
		public enum Type
		{
			UNKNOWN = 0,
			RATIO = 1,
			MAXIMUMSIZE = 2,
		}
		public System.Double Ratio;
		public ResizeByMaximumSizeOptions MaximumSize;
		public Type _type;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ResizeTexturesResizeMode_c
	{
		public System.Double Ratio;
		public ResizeByMaximumSizeOptions_c MaximumSize;
		public int _type;
	}

	public enum SceneChangeType
	{
		CHILD_INSERTED = 0,
		CHILD_REMOVED = 1,
		PROPERTY_CHANGED = 2,
		COMPLETE_CHANGE = 3,
	}

	public enum SelectionChangeType
	{
		CLEARED = 0,
		ADDED = 1,
		REMOVED = 2,
	}

	public enum ShapeType
	{
		TESSELLATED = 0,
		CAD = 1,
		JOINT = 2,
	}

	public enum VariantChangeType
	{
		ADDED = 0,
		REMOVED = 1,
		CURRENT_CHANGED = 2,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class VariantComponentList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public VariantComponentList() {}
		public VariantComponentList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](VariantComponentList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public VariantComponentList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct VariantComponentList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class VariantDefinition
	{
		public VariantDefinition() {}
		public VariantDefinition(VariantDefinition o) {
			this.variant = o.variant;
			this.overridedProperties = o.overridedProperties;
		}
		public System.UInt32 variant;
		public PropertyValueList overridedProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct VariantDefinition_c
	{
		public System.UInt32 variant;
		public PropertyValueList_c overridedProperties;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class VariantDefinitionList {
		public Scene.VariantDefinition[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public VariantDefinitionList(Scene.VariantDefinition[] tab) { list = tab; }
		public static implicit operator Scene.VariantDefinition[](VariantDefinitionList o) { return o.list; }
		public Scene.VariantDefinition this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public VariantDefinitionList(int size) { list = new Scene.VariantDefinition[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct VariantDefinitionList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class VariantDefinitionListList {
		public Scene.VariantDefinitionList[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public VariantDefinitionListList(Scene.VariantDefinitionList[] tab) { list = tab; }
		public static implicit operator Scene.VariantDefinitionList[](VariantDefinitionListList o) { return o.list; }
		public Scene.VariantDefinitionList this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public VariantDefinitionListList(int size) { list = new Scene.VariantDefinitionList[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct VariantDefinitionListList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class VariantList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public VariantList() {}
		public VariantList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](VariantList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public VariantList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct VariantList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class VariantMaterials
	{
		public VariantMaterials() {}
		public VariantMaterials(VariantMaterials o) {
			this.id = o.id;
			this.materials = o.materials;
		}
		public System.UInt32 id;
		public Material.MaterialList materials;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct VariantMaterials_c
	{
		public System.UInt32 id;
		public Material.MaterialList_c materials;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class VariantMaterialList {
		public Scene.VariantMaterials[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public VariantMaterialList(Scene.VariantMaterials[] tab) { list = tab; }
		public static implicit operator Scene.VariantMaterials[](VariantMaterialList o) { return o.list; }
		public Scene.VariantMaterials this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public VariantMaterialList(int size) { list = new Scene.VariantMaterials[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct VariantMaterialList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	public enum VisibilityMode
	{
		Inherited = 0,
		Hide = 1,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct GetSubTreeStatsReturn
	{
		public GetSubTreeStatsReturn(GetSubTreeStatsReturn o) {
			this.partCount = o.partCount;
			this.partOccurrenceCount = o.partOccurrenceCount;
			this.triangleCount = o.triangleCount;
			this.triangleOccurrenceCount = o.triangleOccurrenceCount;
			this.vertexCount = o.vertexCount;
			this.vertexOccurrenceCount = o.vertexOccurrenceCount;
			this.pointCount = o.pointCount;
			this.pointOccurrenceCount = o.pointOccurrenceCount;
			this.lineCount = o.lineCount;
			this.lineOccurrenceCount = o.lineOccurrenceCount;
		}
		public System.UInt64 partCount;
		public System.UInt64 partOccurrenceCount;
		public System.UInt64 triangleCount;
		public System.UInt64 triangleOccurrenceCount;
		public System.UInt64 vertexCount;
		public System.UInt64 vertexOccurrenceCount;
		public System.UInt64 pointCount;
		public System.UInt64 pointOccurrenceCount;
		public System.UInt64 lineCount;
		public System.UInt64 lineOccurrenceCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetSubTreeStatsReturn_c
	{
		public System.UInt64 partCount;
		public System.UInt64 partOccurrenceCount;
		public System.UInt64 triangleCount;
		public System.UInt64 triangleOccurrenceCount;
		public System.UInt64 vertexCount;
		public System.UInt64 vertexOccurrenceCount;
		public System.UInt64 pointCount;
		public System.UInt64 pointOccurrenceCount;
		public System.UInt64 lineCount;
		public System.UInt64 lineOccurrenceCount;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetViewpointsFromCavitiesReturn
	{
		public GetViewpointsFromCavitiesReturn() {}
		public GetViewpointsFromCavitiesReturn(GetViewpointsFromCavitiesReturn o) {
			this.positions = o.positions;
			this.directions = o.directions;
		}
		public Geom.Point3List positions;
		public Geom.Point3List directions;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetViewpointsFromCavitiesReturn_c
	{
		public Geom.Point3List_c positions;
		public Geom.Point3List_c directions;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct GetOoCConfigurationReturn
	{
		public GetOoCConfigurationReturn(GetOoCConfigurationReturn o) {
			this.implementationType = o.implementationType;
			this.implementationParameters = o.implementationParameters;
		}
		public System.String implementationType;
		public System.String implementationParameters;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetOoCConfigurationReturn_c
	{
		public IntPtr implementationType;
		public IntPtr implementationParameters;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct GetBRepInfosReturn
	{
		public GetBRepInfosReturn(GetBRepInfosReturn o) {
			this.partCount = o.partCount;
			this.totalPartCount = o.totalPartCount;
			this.vertexCount = o.vertexCount;
			this.totalVertexCount = o.totalVertexCount;
			this.edgeCount = o.edgeCount;
			this.totalEdgeCount = o.totalEdgeCount;
			this.openShellCount = o.openShellCount;
			this.totalOpenShellCount = o.totalOpenShellCount;
			this.bodyCount = o.bodyCount;
			this.totalBodyCount = o.totalBodyCount;
			this.area2Dsum = o.area2Dsum;
			this.boundaryCount = o.boundaryCount;
			this.boundaryEdgeCount = o.boundaryEdgeCount;
		}
		public System.Int32 partCount;
		public System.Int32 totalPartCount;
		public System.Int32 vertexCount;
		public System.Int32 totalVertexCount;
		public System.Int32 edgeCount;
		public System.Int32 totalEdgeCount;
		public System.Int32 openShellCount;
		public System.Int32 totalOpenShellCount;
		public System.Int32 bodyCount;
		public System.Int32 totalBodyCount;
		public System.Double area2Dsum;
		public System.Int32 boundaryCount;
		public System.Int32 boundaryEdgeCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetBRepInfosReturn_c
	{
		public Int32 partCount;
		public Int32 totalPartCount;
		public Int32 vertexCount;
		public Int32 totalVertexCount;
		public Int32 edgeCount;
		public Int32 totalEdgeCount;
		public Int32 openShellCount;
		public Int32 totalOpenShellCount;
		public Int32 bodyCount;
		public Int32 totalBodyCount;
		public System.Double area2Dsum;
		public Int32 boundaryCount;
		public Int32 boundaryEdgeCount;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct GetTessellationInfosReturn
	{
		public GetTessellationInfosReturn(GetTessellationInfosReturn o) {
			this.partCount = o.partCount;
			this.totalPartCount = o.totalPartCount;
			this.vertexCount = o.vertexCount;
			this.totalVertexCount = o.totalVertexCount;
			this.edgeCount = o.edgeCount;
			this.totalEdgeCount = o.totalEdgeCount;
			this.polygonCount = o.polygonCount;
			this.totalPolygonCount = o.totalPolygonCount;
			this.patchCount = o.patchCount;
			this.totalPatchCount = o.totalPatchCount;
			this.boundaryCount = o.boundaryCount;
			this.boundaryEdgeCount = o.boundaryEdgeCount;
			this.nonManifoldEdgeCount = o.nonManifoldEdgeCount;
		}
		public System.Int32 partCount;
		public System.Int32 totalPartCount;
		public System.Int32 vertexCount;
		public System.Int32 totalVertexCount;
		public System.Int32 edgeCount;
		public System.Int32 totalEdgeCount;
		public System.Int32 polygonCount;
		public System.Int32 totalPolygonCount;
		public System.Int32 patchCount;
		public System.Int32 totalPatchCount;
		public System.Int32 boundaryCount;
		public System.Int32 boundaryEdgeCount;
		public System.Int32 nonManifoldEdgeCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetTessellationInfosReturn_c
	{
		public Int32 partCount;
		public Int32 totalPartCount;
		public Int32 vertexCount;
		public Int32 totalVertexCount;
		public Int32 edgeCount;
		public Int32 totalEdgeCount;
		public Int32 polygonCount;
		public Int32 totalPolygonCount;
		public Int32 patchCount;
		public Int32 totalPatchCount;
		public Int32 boundaryCount;
		public Int32 boundaryEdgeCount;
		public Int32 nonManifoldEdgeCount;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class EvaluateExpressionOnSubTreeReturn
	{
		public EvaluateExpressionOnSubTreeReturn() {}
		public EvaluateExpressionOnSubTreeReturn(EvaluateExpressionOnSubTreeReturn o) {
			this.occurrences = o.occurrences;
			this.evaluations = o.evaluations;
		}
		public OccurrenceList occurrences;
		public Core.StringList evaluations;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct EvaluateExpressionOnSubTreeReturn_c
	{
		public OccurrenceList_c occurrences;
		public Core.StringList_c evaluations;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetPartsTransformsIndexedReturn
	{
		public GetPartsTransformsIndexedReturn() {}
		public GetPartsTransformsIndexedReturn(GetPartsTransformsIndexedReturn o) {
			this.indices = o.indices;
			this.transforms = o.transforms;
		}
		public Core.IntList indices;
		public Geom.Matrix4List transforms;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetPartsTransformsIndexedReturn_c
	{
		public Core.IntList_c indices;
		public Geom.Matrix4List_c transforms;
	}

}
