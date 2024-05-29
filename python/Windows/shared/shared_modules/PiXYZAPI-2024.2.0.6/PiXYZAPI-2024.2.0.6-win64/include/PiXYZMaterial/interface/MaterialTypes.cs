#pragma warning disable CA2101

using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Pixyz.Material {

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Texture
	{
		public Texture() {}
		public Texture(Texture o) {
			this.image = o.image;
			this.channel = o.channel;
			this.offset = o.offset;
			this.tilling = o.tilling;
		}
		public System.UInt32 image;
		public System.Int32 channel;
		public Geom.Point2 offset;
		public Geom.Point2 tilling;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Texture_c
	{
		public System.UInt32 image;
		public Int32 channel;
		public Geom.Point2_c offset;
		public Geom.Point2_c tilling;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct CoeffOrTexture
	{
		public enum Type
		{
			UNKNOWN = 0,
			COEFF = 1,
			TEXTURE = 2,
		}
		public System.Double coeff;
		public Texture texture;
		public Type _type;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct CoeffOrTexture_c
	{
		public System.Double coeff;
		public Texture_c texture;
		public int _type;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ColorMaterialInfos
	{
		public ColorMaterialInfos() {}
		public ColorMaterialInfos(ColorMaterialInfos o) {
			this.name = o.name;
			this.color = o.color;
		}
		public System.String name;
		public Core.ColorAlpha color;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ColorMaterialInfos_c
	{
		public IntPtr name;
		public Core.ColorAlpha_c color;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct ColorOrTexture
	{
		public enum Type
		{
			UNKNOWN = 0,
			COLOR = 1,
			TEXTURE = 2,
		}
		public Core.Color color;
		public Texture texture;
		public Type _type;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ColorOrTexture_c
	{
		public Core.Color_c color;
		public Texture_c texture;
		public int _type;
	}

	public enum ImageChangeType
	{
		ADDED = 0,
		REMOVED = 1,
		CHANGED = 2,
		RESET = 3,
		REPLACED = 4,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ImageDefinition
	{
		public ImageDefinition() {}
		public ImageDefinition(ImageDefinition o) {
			this.id = o.id;
			this.name = o.name;
			this.width = o.width;
			this.height = o.height;
			this.bitsPerComponent = o.bitsPerComponent;
			this.componentsCount = o.componentsCount;
			this.data = o.data;
		}
		public System.UInt32 id;
		public System.String name;
		public System.Int32 width;
		public System.Int32 height;
		public System.Int32 bitsPerComponent;
		public System.Int32 componentsCount;
		public Core.ByteList data;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ImageDefinition_c
	{
		public System.UInt32 id;
		public IntPtr name;
		public Int32 width;
		public Int32 height;
		public Int32 bitsPerComponent;
		public Int32 componentsCount;
		public Core.ByteList_c data;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ImageDefinitionList {
		public Material.ImageDefinition[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public ImageDefinitionList(Material.ImageDefinition[] tab) { list = tab; }
		public static implicit operator Material.ImageDefinition[](ImageDefinitionList o) { return o.list; }
		public Material.ImageDefinition this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public ImageDefinitionList(int size) { list = new Material.ImageDefinition[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ImageDefinitionList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ImageList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public ImageList() {}
		public ImageList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](ImageList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public ImageList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ImageList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ImpostorMaterialInfos
	{
		public ImpostorMaterialInfos() {}
		public ImpostorMaterialInfos(ImpostorMaterialInfos o) {
			this.name = o.name;
			this.albedo = o.albedo;
			this.normal = o.normal;
			this.roughness = o.roughness;
			this.ao = o.ao;
			this.depth = o.depth;
			this.nbFrames = o.nbFrames;
			this.fullOcta = o.fullOcta;
			this.octaDiameter = o.octaDiameter;
			this.linearSteps = o.linearSteps;
			this.binarySteps = o.binarySteps;
		}
		public System.String name;
		public ColorOrTexture albedo;
		public ColorOrTexture normal;
		public CoeffOrTexture roughness;
		public CoeffOrTexture ao;
		public CoeffOrTexture depth;
		public System.Int32 nbFrames;
		public System.Boolean fullOcta;
		public System.Double octaDiameter;
		public System.Int32 linearSteps;
		public System.Int32 binarySteps;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ImpostorMaterialInfos_c
	{
		public IntPtr name;
		public ColorOrTexture_c albedo;
		public ColorOrTexture_c normal;
		public CoeffOrTexture_c roughness;
		public CoeffOrTexture_c ao;
		public CoeffOrTexture_c depth;
		public Int32 nbFrames;
		public System.Byte fullOcta;
		public System.Double octaDiameter;
		public Int32 linearSteps;
		public Int32 binarySteps;
	}

	public enum MaterialChangeType
	{
		CHANGED = 0,
		PATTERN_CHANGED = 1,
		RELOAD = 2,
		DESTROYED = 3,
		ICON_CHANGED = 4,
		ADDED = 5,
		REMOVED = 6,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class MaterialDefinition
	{
		public MaterialDefinition() {}
		public MaterialDefinition(MaterialDefinition o) {
			this.name = o.name;
			this.id = o.id;
			this.albedo = o.albedo;
			this.normal = o.normal;
			this.metallic = o.metallic;
			this.roughness = o.roughness;
			this.ao = o.ao;
			this.opacity = o.opacity;
			this.emissive = o.emissive;
		}
		public System.String name;
		public System.UInt32 id;
		public ColorOrTexture albedo;
		public ColorOrTexture normal;
		public CoeffOrTexture metallic;
		public CoeffOrTexture roughness;
		public CoeffOrTexture ao;
		public CoeffOrTexture opacity;
		public ColorOrTexture emissive;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct MaterialDefinition_c
	{
		public IntPtr name;
		public System.UInt32 id;
		public ColorOrTexture_c albedo;
		public ColorOrTexture_c normal;
		public CoeffOrTexture_c metallic;
		public CoeffOrTexture_c roughness;
		public CoeffOrTexture_c ao;
		public CoeffOrTexture_c opacity;
		public ColorOrTexture_c emissive;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class MaterialDefinitionList {
		public Material.MaterialDefinition[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public MaterialDefinitionList(Material.MaterialDefinition[] tab) { list = tab; }
		public static implicit operator Material.MaterialDefinition[](MaterialDefinitionList o) { return o.list; }
		public Material.MaterialDefinition this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public MaterialDefinitionList(int size) { list = new Material.MaterialDefinition[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct MaterialDefinitionList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class MaterialList {
		public System.UInt32[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public MaterialList() {}
		public MaterialList(System.UInt32[] tab) { list = tab; }
		public static implicit operator System.UInt32[](MaterialList o) { return o.list; }
		public System.UInt32 this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public MaterialList(int size) { list = new System.UInt32[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct MaterialList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class MaterialListList {
		public Material.MaterialList[] list;
		public int length { get { return (list != null) ? list.Length : 0; } }
		public MaterialListList(Material.MaterialList[] tab) { list = tab; }
		public static implicit operator Material.MaterialList[](MaterialListList o) { return o.list; }
		public Material.MaterialList this[int index] {
			get { return list[index]; }
			set { list[index] = value; }
		}
		public MaterialListList(int size) { list = new Material.MaterialList[size]; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct MaterialListList_c
	{
		public System.UInt64 size;
		public IntPtr ptr;
	}

	public enum MaterialPatternType
	{
		CUSTOM = 0,
		COLOR = 1,
		STANDARD = 2,
		UNLIT_TEXTURE = 3,
		PBR = 4,
		IMPOSTOR = 5,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class PBRMaterialInfos
	{
		public PBRMaterialInfos() {}
		public PBRMaterialInfos(PBRMaterialInfos o) {
			this.name = o.name;
			this.albedo = o.albedo;
			this.normal = o.normal;
			this.metallic = o.metallic;
			this.roughness = o.roughness;
			this.ao = o.ao;
			this.opacity = o.opacity;
		}
		public System.String name;
		public ColorOrTexture albedo;
		public ColorOrTexture normal;
		public CoeffOrTexture metallic;
		public CoeffOrTexture roughness;
		public CoeffOrTexture ao;
		public CoeffOrTexture opacity;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct PBRMaterialInfos_c
	{
		public IntPtr name;
		public ColorOrTexture_c albedo;
		public ColorOrTexture_c normal;
		public CoeffOrTexture_c metallic;
		public CoeffOrTexture_c roughness;
		public CoeffOrTexture_c ao;
		public CoeffOrTexture_c opacity;
	}

	public enum ShaderUniformType
	{
		INTEGER = 2,
		BOOLEAN = 9,
		REAL = 11,
		COEFF = 13,
		POINT3 = 23,
		POINT2 = 22,
		COLOR = 15,
		COLOR_ALPHA = 16,
		TEXTURE = 34,
		COLORORTEXTURE = 35,
		COEFFORTEXTURE = 36,
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class StandardMaterialInfos
	{
		public StandardMaterialInfos() {}
		public StandardMaterialInfos(StandardMaterialInfos o) {
			this.name = o.name;
			this.diffuse = o.diffuse;
			this.specular = o.specular;
			this.ambient = o.ambient;
			this.emissive = o.emissive;
			this.shininess = o.shininess;
			this.transparency = o.transparency;
		}
		public System.String name;
		public ColorOrTexture diffuse;
		public ColorOrTexture specular;
		public ColorOrTexture ambient;
		public ColorOrTexture emissive;
		public System.Double shininess;
		public System.Double transparency;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct StandardMaterialInfos_c
	{
		public IntPtr name;
		public ColorOrTexture_c diffuse;
		public ColorOrTexture_c specular;
		public ColorOrTexture_c ambient;
		public ColorOrTexture_c emissive;
		public System.Double shininess;
		public System.Double transparency;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class UnlitTextureMaterialInfos
	{
		public UnlitTextureMaterialInfos() {}
		public UnlitTextureMaterialInfos(UnlitTextureMaterialInfos o) {
			this.name = o.name;
			this.texture = o.texture;
		}
		public System.String name;
		public Texture texture;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct UnlitTextureMaterialInfos_c
	{
		public IntPtr name;
		public Texture_c texture;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct GetImageSizeReturn
	{
		public GetImageSizeReturn(GetImageSizeReturn o) {
			this.width = o.width;
			this.height = o.height;
		}
		public System.Int32 width;
		public System.Int32 height;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetImageSizeReturn_c
	{
		public Int32 width;
		public Int32 height;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GetPointsAndMaterialFromTextReturn
	{
		public GetPointsAndMaterialFromTextReturn() {}
		public GetPointsAndMaterialFromTextReturn(GetPointsAndMaterialFromTextReturn o) {
			this.points = o.points;
			this.uvs = o.uvs;
			this.normal = o.normal;
			this.material = o.material;
			this.offset = o.offset;
		}
		public Geom.Point3List points;
		public Geom.Point2List uvs;
		public Geom.Point3 normal;
		public System.UInt32 material;
		public System.Double offset;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetPointsAndMaterialFromTextReturn_c
	{
		public Geom.Point3List_c points;
		public Geom.Point2List_c uvs;
		public Geom.Point3_c normal;
		public System.UInt32 material;
		public System.Double offset;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class RemapIndexMapReturn
	{
		public RemapIndexMapReturn() {}
		public RemapIndexMapReturn(RemapIndexMapReturn o) {
			this.mappedMaps = o.mappedMaps;
			this.newToOldMapIndices = o.newToOldMapIndices;
		}
		public ImageList mappedMaps;
		public Core.IntListList newToOldMapIndices;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct RemapIndexMapReturn_c
	{
		public ImageList_c mappedMaps;
		public Core.IntListList_c newToOldMapIndices;
	}

}
