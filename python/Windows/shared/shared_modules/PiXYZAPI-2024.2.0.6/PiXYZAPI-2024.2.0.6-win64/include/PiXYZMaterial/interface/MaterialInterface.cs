#pragma warning disable CA2101

using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System;
using PiXYZAPI = UnityEngine.Pixyz.API.PiXYZAPI;

namespace UnityEngine.Pixyz.Material {

	public class MaterialInterface : API.Interface {

		#region Types Init/Free Methods

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_ImageDefinition_init(ref ImageDefinition_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_ImageDefinition_free(ref ImageDefinition_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_ImageDefinitionList_init(ref ImageDefinitionList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_ImageDefinitionList_free(ref ImageDefinitionList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_Texture_init(ref Texture_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_Texture_free(ref Texture_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_CoeffOrTexture_init(ref CoeffOrTexture_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_CoeffOrTexture_free(ref CoeffOrTexture_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_ColorOrTexture_init(ref ColorOrTexture_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_ColorOrTexture_free(ref ColorOrTexture_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_ImpostorMaterialInfos_init(ref ImpostorMaterialInfos_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_ImpostorMaterialInfos_free(ref ImpostorMaterialInfos_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_MaterialDefinition_init(ref MaterialDefinition_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_MaterialDefinition_free(ref MaterialDefinition_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_MaterialDefinitionList_init(ref MaterialDefinitionList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_MaterialDefinitionList_free(ref MaterialDefinitionList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_PBRMaterialInfos_init(ref PBRMaterialInfos_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_PBRMaterialInfos_free(ref PBRMaterialInfos_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_ImageList_init(ref ImageList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_ImageList_free(ref ImageList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_ColorMaterialInfos_init(ref ColorMaterialInfos_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_ColorMaterialInfos_free(ref ColorMaterialInfos_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_MaterialList_init(ref MaterialList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_MaterialList_free(ref MaterialList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_MaterialListList_init(ref MaterialListList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_MaterialListList_free(ref MaterialListList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_StandardMaterialInfos_init(ref StandardMaterialInfos_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_StandardMaterialInfos_free(ref StandardMaterialInfos_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_UnlitTextureMaterialInfos_init(ref UnlitTextureMaterialInfos_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void Material_UnlitTextureMaterialInfos_free(ref UnlitTextureMaterialInfos_c str);

	internal static Core.ByteList ConvertValue(ref Core.ByteList_c s) {
		Core.ByteList list = new Core.ByteList((int)s.size);
		if (s.size > 0)
			Marshal.Copy(s.ptr, list.list, 0, (int)s.size);
		return list;
	}

	internal static Core.ByteList_c ConvertValue(Core.ByteList s, ref Core.ByteList_c list) {
		Core.CoreInterface.Core_ByteList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size > 0)
			Marshal.Copy(s.list, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static ImageDefinition ConvertValue(ref ImageDefinition_c s) {
		ImageDefinition ss = new ImageDefinition();
		ss.id = (System.UInt32)s.id;
		ss.name = ConvertValue(s.name);
		ss.width = (System.Int32)s.width;
		ss.height = (System.Int32)s.height;
		ss.bitsPerComponent = (System.Int32)s.bitsPerComponent;
		ss.componentsCount = (System.Int32)s.componentsCount;
		ss.data = Core.CoreInterface.ConvertValue(ref s.data);
		return ss;
	}

	internal static ImageDefinition_c ConvertValue(ImageDefinition s, ref ImageDefinition_c ss) {
		Material.MaterialInterface.Material_ImageDefinition_init(ref ss);
		ss.id = (System.UInt32)s.id;
		ss.name = ConvertValue(s.name);
		ss.width = (Int32)s.width;
		ss.height = (Int32)s.height;
		ss.bitsPerComponent = (Int32)s.bitsPerComponent;
		ss.componentsCount = (Int32)s.componentsCount;
		Core.CoreInterface.ConvertValue(s.data, ref ss.data);
		return ss;
	}

	internal static ImageDefinitionList ConvertValue(ref ImageDefinitionList_c s) {
		ImageDefinitionList list = new ImageDefinitionList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(ImageDefinition_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			ImageDefinition_c value = (ImageDefinition_c)Marshal.PtrToStructure(p, typeof(ImageDefinition_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static ImageDefinitionList_c ConvertValue(ImageDefinitionList s, ref ImageDefinitionList_c list) {
		Material.MaterialInterface.Material_ImageDefinitionList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			ImageDefinition_c elt = new ImageDefinition_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(ImageDefinition_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static Geom.Point2 ConvertValue(ref Geom.Point2_c s) {
		Geom.Point2 ss = new Geom.Point2();
		ss.x = (System.Double)s.x;
		ss.y = (System.Double)s.y;
		return ss;
	}

	internal static Geom.Point2_c ConvertValue(Geom.Point2 s, ref Geom.Point2_c ss) {
		Geom.GeomInterface.Geom_Point2_init(ref ss);
		ss.x = (System.Double)s.x;
		ss.y = (System.Double)s.y;
		return ss;
	}

	internal static Texture ConvertValue(ref Texture_c s) {
		Texture ss = new Texture();
		ss.image = (System.UInt32)s.image;
		ss.channel = (System.Int32)s.channel;
		ss.offset = Geom.GeomInterface.ConvertValue(ref s.offset);
		ss.tilling = Geom.GeomInterface.ConvertValue(ref s.tilling);
		return ss;
	}

	internal static Texture_c ConvertValue(Texture s, ref Texture_c ss) {
		Material.MaterialInterface.Material_Texture_init(ref ss);
		ss.image = (System.UInt32)s.image;
		ss.channel = (Int32)s.channel;
		Geom.GeomInterface.ConvertValue(s.offset, ref ss.offset);
		Geom.GeomInterface.ConvertValue(s.tilling, ref ss.tilling);
		return ss;
	}

	internal static CoeffOrTexture ConvertValue(ref CoeffOrTexture_c s) {
		CoeffOrTexture ss = new CoeffOrTexture();
		ss._type = (CoeffOrTexture.Type)s._type;
		switch(ss._type) {
			case CoeffOrTexture.Type.UNKNOWN: break;
			case CoeffOrTexture.Type.COEFF: ss.coeff = (System.Double)s.coeff; break;
			case CoeffOrTexture.Type.TEXTURE: ss.texture = ConvertValue(ref s.texture); break;
		}
		return ss;
	}

	internal static CoeffOrTexture_c ConvertValue(CoeffOrTexture s, ref CoeffOrTexture_c ss) {
		Material.MaterialInterface.Material_CoeffOrTexture_init(ref ss);
		ss._type = (int)s._type;
		switch (ss._type) {
			case 0: break;
			case 1: ss.coeff = (System.Double)s.coeff; break;
			case 2: ConvertValue(s.texture, ref ss.texture); break;
		}
		return ss;
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

	internal static ColorOrTexture ConvertValue(ref ColorOrTexture_c s) {
		ColorOrTexture ss = new ColorOrTexture();
		ss._type = (ColorOrTexture.Type)s._type;
		switch(ss._type) {
			case ColorOrTexture.Type.UNKNOWN: break;
			case ColorOrTexture.Type.COLOR: ss.color = ConvertValue(ref s.color); break;
			case ColorOrTexture.Type.TEXTURE: ss.texture = ConvertValue(ref s.texture); break;
		}
		return ss;
	}

	internal static ColorOrTexture_c ConvertValue(ColorOrTexture s, ref ColorOrTexture_c ss) {
		Material.MaterialInterface.Material_ColorOrTexture_init(ref ss);
		ss._type = (int)s._type;
		switch (ss._type) {
			case 0: break;
			case 1: ConvertValue(s.color, ref ss.color); break;
			case 2: ConvertValue(s.texture, ref ss.texture); break;
		}
		return ss;
	}

	internal static ImpostorMaterialInfos ConvertValue(ref ImpostorMaterialInfos_c s) {
		ImpostorMaterialInfos ss = new ImpostorMaterialInfos();
		ss.name = ConvertValue(s.name);
		ss.albedo = ConvertValue(ref s.albedo);
		ss.normal = ConvertValue(ref s.normal);
		ss.roughness = ConvertValue(ref s.roughness);
		ss.ao = ConvertValue(ref s.ao);
		ss.depth = ConvertValue(ref s.depth);
		ss.nbFrames = (System.Int32)s.nbFrames;
		ss.fullOcta = ConvertValue(s.fullOcta);
		ss.octaDiameter = (System.Double)s.octaDiameter;
		ss.linearSteps = (System.Int32)s.linearSteps;
		ss.binarySteps = (System.Int32)s.binarySteps;
		return ss;
	}

	internal static ImpostorMaterialInfos_c ConvertValue(ImpostorMaterialInfos s, ref ImpostorMaterialInfos_c ss) {
		Material.MaterialInterface.Material_ImpostorMaterialInfos_init(ref ss);
		ss.name = ConvertValue(s.name);
		ConvertValue(s.albedo, ref ss.albedo);
		ConvertValue(s.normal, ref ss.normal);
		ConvertValue(s.roughness, ref ss.roughness);
		ConvertValue(s.ao, ref ss.ao);
		ConvertValue(s.depth, ref ss.depth);
		ss.nbFrames = (Int32)s.nbFrames;
		ss.fullOcta = ConvertValue(s.fullOcta);
		ss.octaDiameter = (System.Double)s.octaDiameter;
		ss.linearSteps = (Int32)s.linearSteps;
		ss.binarySteps = (Int32)s.binarySteps;
		return ss;
	}

	internal static MaterialDefinition ConvertValue(ref MaterialDefinition_c s) {
		MaterialDefinition ss = new MaterialDefinition();
		ss.name = ConvertValue(s.name);
		ss.id = (System.UInt32)s.id;
		ss.albedo = ConvertValue(ref s.albedo);
		ss.normal = ConvertValue(ref s.normal);
		ss.metallic = ConvertValue(ref s.metallic);
		ss.roughness = ConvertValue(ref s.roughness);
		ss.ao = ConvertValue(ref s.ao);
		ss.opacity = ConvertValue(ref s.opacity);
		ss.emissive = ConvertValue(ref s.emissive);
		return ss;
	}

	internal static MaterialDefinition_c ConvertValue(MaterialDefinition s, ref MaterialDefinition_c ss) {
		Material.MaterialInterface.Material_MaterialDefinition_init(ref ss);
		ss.name = ConvertValue(s.name);
		ss.id = (System.UInt32)s.id;
		ConvertValue(s.albedo, ref ss.albedo);
		ConvertValue(s.normal, ref ss.normal);
		ConvertValue(s.metallic, ref ss.metallic);
		ConvertValue(s.roughness, ref ss.roughness);
		ConvertValue(s.ao, ref ss.ao);
		ConvertValue(s.opacity, ref ss.opacity);
		ConvertValue(s.emissive, ref ss.emissive);
		return ss;
	}

	internal static MaterialDefinitionList ConvertValue(ref MaterialDefinitionList_c s) {
		MaterialDefinitionList list = new MaterialDefinitionList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(MaterialDefinition_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			MaterialDefinition_c value = (MaterialDefinition_c)Marshal.PtrToStructure(p, typeof(MaterialDefinition_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static MaterialDefinitionList_c ConvertValue(MaterialDefinitionList s, ref MaterialDefinitionList_c list) {
		Material.MaterialInterface.Material_MaterialDefinitionList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			MaterialDefinition_c elt = new MaterialDefinition_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(MaterialDefinition_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static PBRMaterialInfos ConvertValue(ref PBRMaterialInfos_c s) {
		PBRMaterialInfos ss = new PBRMaterialInfos();
		ss.name = ConvertValue(s.name);
		ss.albedo = ConvertValue(ref s.albedo);
		ss.normal = ConvertValue(ref s.normal);
		ss.metallic = ConvertValue(ref s.metallic);
		ss.roughness = ConvertValue(ref s.roughness);
		ss.ao = ConvertValue(ref s.ao);
		ss.opacity = ConvertValue(ref s.opacity);
		return ss;
	}

	internal static PBRMaterialInfos_c ConvertValue(PBRMaterialInfos s, ref PBRMaterialInfos_c ss) {
		Material.MaterialInterface.Material_PBRMaterialInfos_init(ref ss);
		ss.name = ConvertValue(s.name);
		ConvertValue(s.albedo, ref ss.albedo);
		ConvertValue(s.normal, ref ss.normal);
		ConvertValue(s.metallic, ref ss.metallic);
		ConvertValue(s.roughness, ref ss.roughness);
		ConvertValue(s.ao, ref ss.ao);
		ConvertValue(s.opacity, ref ss.opacity);
		return ss;
	}

	internal static ImageList ConvertValue(ref ImageList_c s) {
		ImageList list = new ImageList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static ImageList_c ConvertValue(ImageList s, ref ImageList_c list) {
		Material.MaterialInterface.Material_ImageList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static Core.ColorAlpha ConvertValue(ref Core.ColorAlpha_c s) {
		Core.ColorAlpha ss = new Core.ColorAlpha();
		ss.r = (System.Double)s.r;
		ss.g = (System.Double)s.g;
		ss.b = (System.Double)s.b;
		ss.a = (System.Double)s.a;
		return ss;
	}

	internal static Core.ColorAlpha_c ConvertValue(Core.ColorAlpha s, ref Core.ColorAlpha_c ss) {
		Core.CoreInterface.Core_ColorAlpha_init(ref ss);
		ss.r = (System.Double)s.r;
		ss.g = (System.Double)s.g;
		ss.b = (System.Double)s.b;
		ss.a = (System.Double)s.a;
		return ss;
	}

	internal static ColorMaterialInfos ConvertValue(ref ColorMaterialInfos_c s) {
		ColorMaterialInfos ss = new ColorMaterialInfos();
		ss.name = ConvertValue(s.name);
		ss.color = Core.CoreInterface.ConvertValue(ref s.color);
		return ss;
	}

	internal static ColorMaterialInfos_c ConvertValue(ColorMaterialInfos s, ref ColorMaterialInfos_c ss) {
		Material.MaterialInterface.Material_ColorMaterialInfos_init(ref ss);
		ss.name = ConvertValue(s.name);
		Core.CoreInterface.ConvertValue(s.color, ref ss.color);
		return ss;
	}

	internal static MaterialList ConvertValue(ref MaterialList_c s) {
		MaterialList list = new MaterialList((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<System.UInt32>(s.ptr, (int)s.size);
		return list;
	}

	internal static MaterialList_c ConvertValue(MaterialList s, ref MaterialList_c list) {
		Material.MaterialInterface.Material_MaterialList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		int[] tab = new int[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = (int)(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static MaterialListList ConvertValue(ref MaterialListList_c s) {
		MaterialListList list = new MaterialListList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(MaterialList_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			MaterialList_c value = (MaterialList_c)Marshal.PtrToStructure(p, typeof(MaterialList_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static MaterialListList_c ConvertValue(MaterialListList s, ref MaterialListList_c list) {
		Material.MaterialInterface.Material_MaterialListList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			MaterialList_c elt = new MaterialList_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(MaterialList_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static StandardMaterialInfos ConvertValue(ref StandardMaterialInfos_c s) {
		StandardMaterialInfos ss = new StandardMaterialInfos();
		ss.name = ConvertValue(s.name);
		ss.diffuse = ConvertValue(ref s.diffuse);
		ss.specular = ConvertValue(ref s.specular);
		ss.ambient = ConvertValue(ref s.ambient);
		ss.emissive = ConvertValue(ref s.emissive);
		ss.shininess = (System.Double)s.shininess;
		ss.transparency = (System.Double)s.transparency;
		return ss;
	}

	internal static StandardMaterialInfos_c ConvertValue(StandardMaterialInfos s, ref StandardMaterialInfos_c ss) {
		Material.MaterialInterface.Material_StandardMaterialInfos_init(ref ss);
		ss.name = ConvertValue(s.name);
		ConvertValue(s.diffuse, ref ss.diffuse);
		ConvertValue(s.specular, ref ss.specular);
		ConvertValue(s.ambient, ref ss.ambient);
		ConvertValue(s.emissive, ref ss.emissive);
		ss.shininess = (System.Double)s.shininess;
		ss.transparency = (System.Double)s.transparency;
		return ss;
	}

	internal static UnlitTextureMaterialInfos ConvertValue(ref UnlitTextureMaterialInfos_c s) {
		UnlitTextureMaterialInfos ss = new UnlitTextureMaterialInfos();
		ss.name = ConvertValue(s.name);
		ss.texture = ConvertValue(ref s.texture);
		return ss;
	}

	internal static UnlitTextureMaterialInfos_c ConvertValue(UnlitTextureMaterialInfos s, ref UnlitTextureMaterialInfos_c ss) {
		Material.MaterialInterface.Material_UnlitTextureMaterialInfos_init(ref ss);
		ss.name = ConvertValue(s.name);
		ConvertValue(s.texture, ref ss.texture);
		return ss;
	}

	internal static GetImageSizeReturn ConvertValue(ref GetImageSizeReturn_c s) {
		GetImageSizeReturn ss = new GetImageSizeReturn();
		ss.width = (System.Int32)s.width;
		ss.height = (System.Int32)s.height;
		return ss;
	}

	internal static GetImageSizeReturn_c ConvertValue(GetImageSizeReturn s, ref GetImageSizeReturn_c ss) {
		ss.width = (Int32)s.width;
		ss.height = (Int32)s.height;
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

	internal static Geom.Point2List ConvertValue(ref Geom.Point2List_c s) {
		Geom.Point2List list = new Geom.Point2List((int)s.size);
		if (s.size==0) return list;

			list.list = CopyMemory<Geom.Point2>(s.ptr, (int)s.size);
		return list;
	}

	internal static Geom.Point2List_c ConvertValue(Geom.Point2List s, ref Geom.Point2List_c list) {
		Geom.GeomInterface.Geom_Point2List_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Geom.Point2_c elt = new Geom.Point2_c();
			Geom.GeomInterface.ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Geom.Point2_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static GetPointsAndMaterialFromTextReturn ConvertValue(ref GetPointsAndMaterialFromTextReturn_c s) {
		GetPointsAndMaterialFromTextReturn ss = new GetPointsAndMaterialFromTextReturn();
		ss.points = Geom.GeomInterface.ConvertValue(ref s.points);
		ss.uvs = Geom.GeomInterface.ConvertValue(ref s.uvs);
		ss.normal = Geom.GeomInterface.ConvertValue(ref s.normal);
		ss.material = (System.UInt32)s.material;
		ss.offset = (System.Double)s.offset;
		return ss;
	}

	internal static GetPointsAndMaterialFromTextReturn_c ConvertValue(GetPointsAndMaterialFromTextReturn s, ref GetPointsAndMaterialFromTextReturn_c ss) {
		Geom.GeomInterface.ConvertValue(s.points, ref ss.points);
		Geom.GeomInterface.ConvertValue(s.uvs, ref ss.uvs);
		Geom.GeomInterface.ConvertValue(s.normal, ref ss.normal);
		ss.material = (System.UInt32)s.material;
		ss.offset = (System.Double)s.offset;
		return ss;
	}

	internal static Core.IntList ConvertValue(ref Core.IntList_c s) {
		Core.IntList list = new Core.IntList((int)s.size);
		if (s.size > 0)
			Marshal.Copy(s.ptr, list.list, 0, (int)s.size);
		return list;
	}

	internal static Core.IntList_c ConvertValue(Core.IntList s, ref Core.IntList_c list) {
		Core.CoreInterface.Core_IntList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size > 0)
			Marshal.Copy(s.list, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static Core.IntListList ConvertValue(ref Core.IntListList_c s) {
		Core.IntListList list = new Core.IntListList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(Core.IntList_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			Core.IntList_c value = (Core.IntList_c)Marshal.PtrToStructure(p, typeof(Core.IntList_c));
			list.list[i] = Core.CoreInterface.ConvertValue(ref value);
		}
		return list;
	}

	internal static Core.IntListList_c ConvertValue(Core.IntListList s, ref Core.IntListList_c list) {
		Core.CoreInterface.Core_IntListList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			Core.IntList_c elt = new Core.IntList_c();
			Core.CoreInterface.ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(Core.IntList_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
	}

	internal static RemapIndexMapReturn ConvertValue(ref RemapIndexMapReturn_c s) {
		RemapIndexMapReturn ss = new RemapIndexMapReturn();
		ss.mappedMaps = ConvertValue(ref s.mappedMaps);
		ss.newToOldMapIndices = Core.CoreInterface.ConvertValue(ref s.newToOldMapIndices);
		return ss;
	}

	internal static RemapIndexMapReturn_c ConvertValue(RemapIndexMapReturn s, ref RemapIndexMapReturn_c ss) {
		ConvertValue(s.mappedMaps, ref ss.mappedMaps);
		Core.CoreInterface.ConvertValue(s.newToOldMapIndices, ref ss.newToOldMapIndices);
		return ss;
	}

		#endregion

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Material_getLastError();

		public static string GetLastError()
		{
			return ConvertValue(Material_getLastError());
		}

		#region 

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_addUniformProperty(IntPtr _pxz_session_, System.UInt32 pattern, string name, Int32 type);
		/// <summary>
		/// Add a shader uniform parameter to the given custom pattern
		/// </summary>
		/// <param name="pattern">The custom pattern to edit</param>
		/// <param name="name">Name of the new property</param>
		/// <param name="type">Type of the new uniform</param>
		public void AddUniformProperty(System.UInt32 pattern, System.String name, ShaderUniformType type) {
			Material_addUniformProperty(api.Session, pattern, name, (int)type);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_clearAllMaterials(IntPtr _pxz_session_);
		/// <summary>
		/// Remove and delete all the materials
		/// </summary>
		public void ClearAllMaterials() {
			Material_clearAllMaterials(api.Session);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_configureFunctionLogger(IntPtr _pxz_session_, string functionName, System.Byte enableFunction, System.Byte enableParameters, System.Byte enableExecutionTime);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="functionName"></param>
		/// <param name="enableFunction"></param>
		/// <param name="enableParameters"></param>
		/// <param name="enableExecutionTime"></param>
		public void ConfigureFunctionLogger(System.String functionName, System.Boolean enableFunction, System.Boolean enableParameters, System.Boolean enableExecutionTime) {
			Material_configureFunctionLogger(api.Session, functionName, Convert.ToByte(enableFunction), Convert.ToByte(enableParameters), Convert.ToByte(enableExecutionTime));
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Material_convertFloat32To8BitsImage(IntPtr _pxz_session_, System.UInt32 image32F, System.Double minValue, System.Double maxValue);
		/// <summary>
		/// Returns a new image from the given converter from 32bits float to a 8Bits (e.g. depth render map)
		/// </summary>
		/// <param name="image32F">Image to convert</param>
		/// <param name="minValue">Minimal value of the floats (will be 0 in 8bits)</param>
		/// <param name="maxValue">Minimal value of the floats (will be 255 in 8bits)</param>
		public System.UInt32 ConvertFloat32To8BitsImage(System.UInt32 image32F, System.Double minValue = -1, System.Double maxValue = 1) {
			var ret = Material_convertFloat32To8BitsImage(api.Session, image32F, minValue, maxValue);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Material_convertHeightMapToNormalMap(IntPtr _pxz_session_, System.UInt32 hmap, System.Double height);
		/// <summary>
		/// Convert a height map to a normal map
		/// </summary>
		/// <param name="hmap">Height map reference</param>
		/// <param name="height">Maximum height</param>
		public System.UInt32 ConvertHeightMapToNormalMap(System.UInt32 hmap, System.Double height = 0.5) {
			var ret = Material_convertHeightMapToNormalMap(api.Session, hmap, height);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Material_convertNormalMapToHeightMap(IntPtr _pxz_session_, System.UInt32 nmap, System.Double height);
		/// <summary>
		/// Convert a normal map to a height map
		/// </summary>
		/// <param name="nmap">Normal map reference</param>
		/// <param name="height">Maximum height</param>
		public System.UInt32 ConvertNormalMapToHeightMap(System.UInt32 nmap, System.Double height = 0.5) {
			var ret = Material_convertNormalMapToHeightMap(api.Session, nmap, height);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Material_copyMaterial(IntPtr _pxz_session_, System.UInt32 toCopy, System.Byte addToMaterialLibrary);
		/// <summary>
		/// copies a material
		/// </summary>
		/// <param name="toCopy">Material to copy</param>
		/// <param name="addToMaterialLibrary">Add to material library</param>
		public System.UInt32 CopyMaterial(System.UInt32 toCopy, System.Boolean addToMaterialLibrary) {
			var ret = Material_copyMaterial(api.Session, toCopy, Convert.ToByte(addToMaterialLibrary));
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Material_createCustomMaterialPattern(IntPtr _pxz_session_, string name);
		/// <summary>
		/// Create a new custom material pattern
		/// </summary>
		/// <param name="name">Name of the pattern</param>
		public System.UInt32 CreateCustomMaterialPattern(System.String name) {
			var ret = Material_createCustomMaterialPattern(api.Session, name);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Material_createImageFromDefinition(IntPtr _pxz_session_, ImageDefinition_c imageDefinition);
		/// <summary>
		/// Import an image from its raw data
		/// </summary>
		/// <param name="imageDefinition">The image definition</param>
		public System.UInt32 CreateImageFromDefinition(ImageDefinition imageDefinition) {
			var imageDefinition_c = new Material.ImageDefinition_c();
			ConvertValue((Material.ImageDefinition)imageDefinition, ref imageDefinition_c);
			var ret = Material_createImageFromDefinition(api.Session, imageDefinition_c);
			Material.MaterialInterface.Material_ImageDefinition_free(ref imageDefinition_c);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern ImageList_c Material_createImagesFromDefinitions(IntPtr _pxz_session_, ImageDefinitionList_c imageDefinitions);
		/// <summary>
		/// Import images from their raw data
		/// </summary>
		/// <param name="imageDefinitions">The image definitions</param>
		public ImageList CreateImagesFromDefinitions(ImageDefinitionList imageDefinitions) {
			var imageDefinitions_c = new Material.ImageDefinitionList_c();
			ConvertValue((Material.ImageDefinitionList)imageDefinitions, ref imageDefinitions_c);
			var ret = Material_createImagesFromDefinitions(api.Session, imageDefinitions_c);
			Material.MaterialInterface.Material_ImageDefinitionList_free(ref imageDefinitions_c);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Material.MaterialInterface.Material_ImageList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Material_createMaterial(IntPtr _pxz_session_, string name, string pattern, System.Byte addToMaterialLibrary);
		/// <summary>
		/// Create a new material from pattern
		/// </summary>
		/// <param name="name">Name of the material</param>
		/// <param name="pattern">Name of the pattern</param>
		/// <param name="addToMaterialLibrary">Name of the pattern</param>
		public System.UInt32 CreateMaterial(System.String name, System.String pattern, System.Boolean addToMaterialLibrary = true) {
			var ret = Material_createMaterial(api.Session, name, pattern, Convert.ToByte(addToMaterialLibrary));
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Material_createMaterialFromDefinition(IntPtr _pxz_session_, MaterialDefinition_c materialDefinition);
		/// <summary>
		/// Create PBR material from a material definition
		/// </summary>
		/// <param name="materialDefinition">The structure containing all the PBR material information</param>
		public System.UInt32 CreateMaterialFromDefinition(MaterialDefinition materialDefinition) {
			var materialDefinition_c = new Material.MaterialDefinition_c();
			ConvertValue((Material.MaterialDefinition)materialDefinition, ref materialDefinition_c);
			var ret = Material_createMaterialFromDefinition(api.Session, materialDefinition_c);
			Material.MaterialInterface.Material_MaterialDefinition_free(ref materialDefinition_c);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern MaterialList_c Material_createMaterialsFromDefinitions(IntPtr _pxz_session_, MaterialDefinitionList_c materialDefinitions);
		/// <summary>
		/// Create PBR materials from material definitions
		/// </summary>
		/// <param name="materialDefinitions">Material definitions containing properties for each given material</param>
		public MaterialList CreateMaterialsFromDefinitions(MaterialDefinitionList materialDefinitions) {
			var materialDefinitions_c = new Material.MaterialDefinitionList_c();
			ConvertValue((Material.MaterialDefinitionList)materialDefinitions, ref materialDefinitions_c);
			var ret = Material_createMaterialsFromDefinitions(api.Session, materialDefinitions_c);
			Material.MaterialInterface.Material_MaterialDefinitionList_free(ref materialDefinitions_c);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Material.MaterialInterface.Material_MaterialList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_createMaterialsFromMaps(IntPtr _pxz_session_, string directory);
		/// <summary>
		/// Automatically creates PBR materials when importing PBR texture maps from a folder
		/// </summary>
		/// <param name="directory">Directory path</param>
		public void CreateMaterialsFromMaps(System.String directory) {
			Material_createMaterialsFromMaps(api.Session, directory);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_exportImage(IntPtr _pxz_session_, System.UInt32 image, string filename);
		/// <summary>
		/// Export an image
		/// </summary>
		/// <param name="image">Identifier of the image to export</param>
		/// <param name="filename">Filename of the file to export</param>
		public void ExportImage(System.UInt32 image, System.String filename) {
			Material_exportImage(api.Session, image, filename);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Material_fillUnusedPixels(IntPtr _pxz_session_, System.UInt32 image, Core.ColorAlpha_c unusedColor);
		/// <summary>
		/// Fill unused pixels by propagating and averaging used pixels
		/// </summary>
		/// <param name="image">Image to process</param>
		/// <param name="unusedColor">Color used to identify unused pixels</param>
		public System.UInt32 FillUnusedPixels(System.UInt32 image, Core.ColorAlpha unusedColor) {
			var unusedColor_c = new Core.ColorAlpha_c();
			Core.CoreInterface.ConvertValue((Core.ColorAlpha)unusedColor, ref unusedColor_c);
			var ret = Material_fillUnusedPixels(api.Session, image, unusedColor_c);
			Core.CoreInterface.Core_ColorAlpha_free(ref unusedColor_c);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Material_filterAO(IntPtr _pxz_session_, System.UInt32 aoMap, System.UInt32 normalMap, System.Double sigmaPos, System.Double sigmaValue, System.Double sigmaNormal, Int32 levelCount, System.Byte filterLowValues, System.Double lowValueThreshold);
		/// <summary>
		/// Filter an AO map using ATrous method
		/// </summary>
		/// <param name="aoMap">Input AO Map (the alpha component must be set to 0 for unused pixels)</param>
		/// <param name="normalMap">Input Normal Map (preferable to use a World space normal map, but an Object space normal map can be used)</param>
		/// <param name="sigmaPos">ATrous Sigma pos</param>
		/// <param name="sigmaValue">ATrous Sigma value</param>
		/// <param name="sigmaNormal">ATrous Sigma normal</param>
		/// <param name="levelCount">Atrous #Levels</param>
		/// <param name="filterLowValues">Remove low values from the filtering (see: lowValuesThreshold parameter)</param>
		/// <param name="lowValueThreshold">Threshold used if filterLowValues is enabled</param>
		public System.UInt32 FilterAO(System.UInt32 aoMap, System.UInt32 normalMap, System.Double sigmaPos = 10, System.Double sigmaValue = 0.1, System.Double sigmaNormal = 0.01, System.Int32 levelCount = 4, System.Boolean filterLowValues = true, System.Double lowValueThreshold = 0.01) {
			var ret = Material_filterAO(api.Session, aoMap, normalMap, sigmaPos, sigmaValue, sigmaNormal, levelCount, Convert.ToByte(filterLowValues), lowValueThreshold);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Material_findCustomMaterialPatternByName(IntPtr _pxz_session_, string name);
		/// <summary>
		/// Returns the material pattern which has the given name
		/// </summary>
		/// <param name="name">The name of the material pattern</param>
		public System.UInt32 FindCustomMaterialPatternByName(System.String name) {
			var ret = Material_findCustomMaterialPatternByName(api.Session, name);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern MaterialList_c Material_findMaterialsByPattern(IntPtr _pxz_session_, string pattern);
		/// <summary>
		/// Returns all materials using the given pattern
		/// </summary>
		/// <param name="pattern">A material pattern</param>
		public MaterialList FindMaterialsByPattern(System.String pattern) {
			var ret = Material_findMaterialsByPattern(api.Session, pattern);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Material.MaterialInterface.Material_MaterialList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern MaterialList_c Material_findMaterialsByProperty(IntPtr _pxz_session_, string propertyName, string propertyValue, System.Byte caseInsensitive);
		/// <summary>
		/// Returns all materials which match a given property value
		/// </summary>
		/// <param name="propertyName">Name of the property to match</param>
		/// <param name="propertyValue">Regular expression to match for the property value</param>
		/// <param name="caseInsensitive">If True, the regex will be insensitive to upper and lower cases</param>
		public MaterialList FindMaterialsByProperty(System.String propertyName, System.String propertyValue, System.Boolean caseInsensitive = false) {
			var ret = Material_findMaterialsByProperty(api.Session, propertyName, propertyValue, Convert.ToByte(caseInsensitive));
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Material.MaterialInterface.Material_MaterialList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern ImageList_c Material_getAllImages(IntPtr _pxz_session_, MaterialList_c materials);
		/// <summary>
		/// Returns all the images loaded in the current session or from a list of materials
		/// </summary>
		/// <param name="materials">Materials to retrieve the images from (returns all images loaded in the current session if empty)</param>
		public ImageList GetAllImages(MaterialList materials = null) {
			materials = materials ?? new Material.MaterialList(new System.UInt32[] {});
			var materials_c = new Material.MaterialList_c();
			ConvertValue((Material.MaterialList)materials, ref materials_c);
			var ret = Material_getAllImages(api.Session, materials_c);
			Material.MaterialInterface.Material_MaterialList_free(ref materials_c);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Material.MaterialInterface.Material_ImageList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.StringList_c Material_getAllMaterialPatterns(IntPtr _pxz_session_);
		/// <summary>
		/// Returns all the material patterns in the current session
		/// </summary>
		public Core.StringList GetAllMaterialPatterns() {
			var ret = Material_getAllMaterialPatterns(api.Session);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Core.CoreInterface.ConvertValue(ref ret);
			Core.CoreInterface.Core_StringList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern MaterialList_c Material_getAllMaterials(IntPtr _pxz_session_);
		/// <summary>
		/// Retrieve the list of all the materials in the material library
		/// </summary>
		public MaterialList GetAllMaterials() {
			var ret = Material_getAllMaterials(api.Session);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Material.MaterialInterface.Material_MaterialList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern ColorMaterialInfos_c Material_getColorMaterialInfos(IntPtr _pxz_session_, System.UInt32 material);
		/// <summary>
		/// Get color material properties
		/// </summary>
		/// <param name="material">The material to get properties</param>
		public ColorMaterialInfos GetColorMaterialInfos(System.UInt32 material) {
			var ret = Material_getColorMaterialInfos(api.Session, material);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Material.MaterialInterface.Material_ColorMaterialInfos_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Material_getCustomMaterialPattern(IntPtr _pxz_session_, System.UInt32 material);
		/// <summary>
		/// Returns the custom material pattern associated to the custom material
		/// </summary>
		/// <param name="material">Custom material to get the pattern from</param>
		public System.UInt32 GetCustomMaterialPattern(System.UInt32 material) {
			var ret = Material_getCustomMaterialPattern(api.Session, material);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern ImageDefinition_c Material_getImageDefinition(IntPtr _pxz_session_, System.UInt32 image);
		/// <summary>
		/// Returns the raw data of an image
		/// </summary>
		/// <param name="image">Image's definition</param>
		public ImageDefinition GetImageDefinition(System.UInt32 image) {
			var ret = Material_getImageDefinition(api.Session, image);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Material.MaterialInterface.Material_ImageDefinition_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern ImageDefinitionList_c Material_getImageDefinitions(IntPtr _pxz_session_, ImageList_c images);
		/// <summary>
		/// Returns the raw data of a set of images
		/// </summary>
		/// <param name="images">The images</param>
		public ImageDefinitionList GetImageDefinitions(ImageList images) {
			var images_c = new Material.ImageList_c();
			ConvertValue((Material.ImageList)images, ref images_c);
			var ret = Material_getImageDefinitions(api.Session, images_c);
			Material.MaterialInterface.Material_ImageList_free(ref images_c);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Material.MaterialInterface.Material_ImageDefinitionList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetImageSizeReturn_c Material_getImageSize(IntPtr _pxz_session_, System.UInt32 image);
		/// <summary>
		/// Returns the size of an image
		/// </summary>
		/// <param name="image">The image to get the size from</param>
		public Material.GetImageSizeReturn GetImageSize(System.UInt32 image) {
			var ret = Material_getImageSize(api.Session, image);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			Material.GetImageSizeReturn retStruct = new Material.GetImageSizeReturn();
			retStruct.width = (System.Int32)ret.width;
			retStruct.height = (System.Int32)ret.height;
			return retStruct;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.FormatList_c Material_getImportImageFormats(IntPtr _pxz_session_);
		/// <summary>
		/// Give all the image format name and their extensions that can be imported in Pixyz
		/// </summary>
		public Core.FormatList GetImportImageFormats() {
			var ret = Material_getImportImageFormats(api.Session);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Core.CoreInterface.ConvertValue(ref ret);
			Core.CoreInterface.Core_FormatList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern ImpostorMaterialInfos_c Material_getImpostorMaterialInfos(IntPtr _pxz_session_, System.UInt32 material);
		/// <summary>
		/// Get impostor texture material properties
		/// </summary>
		/// <param name="material">The material to get properties</param>
		public ImpostorMaterialInfos GetImpostorMaterialInfos(System.UInt32 material) {
			var ret = Material_getImpostorMaterialInfos(api.Session, material);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Material.MaterialInterface.Material_ImpostorMaterialInfos_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern MaterialDefinition_c Material_getMaterialDefinition(IntPtr _pxz_session_, System.UInt32 material);
		/// <summary>
		/// Returns the properties of a PBR Material
		/// </summary>
		/// <param name="material">The PBR Material</param>
		public MaterialDefinition GetMaterialDefinition(System.UInt32 material) {
			var ret = Material_getMaterialDefinition(api.Session, material);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Material.MaterialInterface.Material_MaterialDefinition_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern MaterialDefinitionList_c Material_getMaterialDefinitions(IntPtr _pxz_session_, MaterialList_c materials);
		/// <summary>
		/// Returns the properties of a set of PBR Materials
		/// </summary>
		/// <param name="materials">The PBR Materials</param>
		public MaterialDefinitionList GetMaterialDefinitions(MaterialList materials) {
			var materials_c = new Material.MaterialList_c();
			ConvertValue((Material.MaterialList)materials, ref materials_c);
			var ret = Material_getMaterialDefinitions(api.Session, materials_c);
			Material.MaterialInterface.Material_MaterialList_free(ref materials_c);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Material.MaterialInterface.Material_MaterialDefinitionList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.ColorAlpha_c Material_getMaterialMainColor(IntPtr _pxz_session_, System.UInt32 material);
		/// <summary>
		/// Get the main color on any material pattern type
		/// </summary>
		/// <param name="material">The material</param>
		public Core.ColorAlpha GetMaterialMainColor(System.UInt32 material) {
			var ret = Material_getMaterialMainColor(api.Session, material);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Core.CoreInterface.ConvertValue(ref ret);
			Core.CoreInterface.Core_ColorAlpha_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr Material_getMaterialPattern(IntPtr _pxz_session_, System.UInt32 material);
		/// <summary>
		/// Gets the MaterialPattern name of the material
		/// </summary>
		/// <param name="material">The material to find the pattern</param>
		public System.String GetMaterialPattern(System.UInt32 material) {
			var ret = Material_getMaterialPattern(api.Session, material);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return ConvertValue(ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Int32 Material_getMaterialPatternType(IntPtr _pxz_session_, System.UInt32 material);
		/// <summary>
		/// Returns the MaterialPatternType name of the material
		/// </summary>
		/// <param name="material">The material to find the pattern</param>
		public MaterialPatternType GetMaterialPatternType(System.UInt32 material) {
			var ret = Material_getMaterialPatternType(api.Session, material);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (MaterialPatternType)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern PBRMaterialInfos_c Material_getPBRMaterialInfos(IntPtr _pxz_session_, System.UInt32 material);
		/// <summary>
		/// Get PBR  material properties
		/// </summary>
		/// <param name="material">The material to get properties</param>
		public PBRMaterialInfos GetPBRMaterialInfos(System.UInt32 material) {
			var ret = Material_getPBRMaterialInfos(api.Session, material);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Material.MaterialInterface.Material_PBRMaterialInfos_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern GetPointsAndMaterialFromTextReturn_c Material_getPointsAndMaterialFromText(IntPtr _pxz_session_, string text, string fontName, Int32 fontSize, Geom.Matrix4_c matrix, Core.Color_c colorInput, System.Double offset, System.Double height3D);
		/// <summary>
		/// Returns list of 3D Points and a material from a string and fontname
		/// </summary>
		/// <param name="text">Input text</param>
		/// <param name="fontName">Fontname</param>
		/// <param name="fontSize">FontSize</param>
		/// <param name="matrix">Input matrix for the text</param>
		/// <param name="colorInput">Color of the font needed</param>
		/// <param name="offset">Input offset for the text</param>
		/// <param name="height3D">Input height in 3D which will be a ratio from the textSize</param>
		public Material.GetPointsAndMaterialFromTextReturn GetPointsAndMaterialFromText(System.String text, System.String fontName, System.Int32 fontSize, Geom.Matrix4 matrix, Core.Color colorInput, System.Double offset = 0.0, System.Double height3D = 0.0) {
			var matrix_c = new Geom.Matrix4_c();
			Geom.GeomInterface.ConvertValue((Geom.Matrix4)matrix, ref matrix_c);
			var colorInput_c = new Core.Color_c();
			Core.CoreInterface.ConvertValue((Core.Color)colorInput, ref colorInput_c);
			var ret = Material_getPointsAndMaterialFromText(api.Session, text, fontName, fontSize, matrix_c, colorInput_c, offset, height3D);
			Geom.GeomInterface.Geom_Matrix4_free(ref matrix_c);
			Core.CoreInterface.Core_Color_free(ref colorInput_c);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			Material.GetPointsAndMaterialFromTextReturn retStruct = new Material.GetPointsAndMaterialFromTextReturn();
			retStruct.points = ConvertValue(ref ret.points);
			Geom.GeomInterface.Geom_Point3List_free(ref ret.points);
			retStruct.uvs = ConvertValue(ref ret.uvs);
			Geom.GeomInterface.Geom_Point2List_free(ref ret.uvs);
			retStruct.normal = ConvertValue(ref ret.normal);
			Geom.GeomInterface.Geom_Point3_free(ref ret.normal);
			retStruct.material = (System.UInt32)ret.material;
			retStruct.offset = (System.Double)ret.offset;
			return retStruct;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern StandardMaterialInfos_c Material_getStandardMaterialInfos(IntPtr _pxz_session_, System.UInt32 material);
		/// <summary>
		/// Get standard material properties
		/// </summary>
		/// <param name="material">The material to get properties</param>
		public StandardMaterialInfos GetStandardMaterialInfos(System.UInt32 material) {
			var ret = Material_getStandardMaterialInfos(api.Session, material);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Material.MaterialInterface.Material_StandardMaterialInfos_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Int32 Material_getUniformPropertyType(IntPtr _pxz_session_, System.UInt32 pattern, string name);
		/// <summary>
		/// Get a shader uniform shader property type
		/// </summary>
		/// <param name="pattern">The custom pattern</param>
		/// <param name="name">Name of the property to get the type from</param>
		public ShaderUniformType GetUniformPropertyType(System.UInt32 pattern, System.String name) {
			var ret = Material_getUniformPropertyType(api.Session, pattern, name);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (ShaderUniformType)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern UnlitTextureMaterialInfos_c Material_getUnlitTextureMaterialInfos(IntPtr _pxz_session_, System.UInt32 material);
		/// <summary>
		/// Get unlit texture material properties
		/// </summary>
		/// <param name="material">The material to get properties</param>
		public UnlitTextureMaterialInfos GetUnlitTextureMaterialInfos(System.UInt32 material) {
			var ret = Material_getUnlitTextureMaterialInfos(api.Session, material);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			Material.MaterialInterface.Material_UnlitTextureMaterialInfos_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Material_importImage(IntPtr _pxz_session_, string filename);
		/// <summary>
		/// Import an image
		/// </summary>
		/// <param name="filename">Filename of the image to import</param>
		public System.UInt32 ImportImage(System.String filename) {
			var ret = Material_importImage(api.Session, filename);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Material_isOpaque(IntPtr _pxz_session_, System.UInt32 material);
		/// <summary>
		/// Check if material is opaque
		/// </summary>
		/// <param name="material">Material to check opacity</param>
		public System.Boolean IsOpaque(System.UInt32 material) {
			var ret = Material_isOpaque(api.Session, material);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Boolean)(0 != ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_makeMaterialNamesUnique(IntPtr _pxz_session_, MaterialList_c materials);
		/// <summary>
		/// Rename materials to have a unique name for each one
		/// </summary>
		/// <param name="materials">Materials to rename (rename all materials if empty)</param>
		public void MakeMaterialNamesUnique(MaterialList materials = null) {
			materials = materials ?? new Material.MaterialList(new System.UInt32[] {});
			var materials_c = new Material.MaterialList_c();
			ConvertValue((Material.MaterialList)materials, ref materials_c);
			Material_makeMaterialNamesUnique(api.Session, materials_c);
			Material.MaterialInterface.Material_MaterialList_free(ref materials_c);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern RemapIndexMapReturn_c Material_remapIndexMap(IntPtr _pxz_session_, ImageList_c maps, Int32 maxIndices);
		/// <summary>
		/// create remapped versions of index maps
		/// </summary>
		/// <param name="maps">Input Images</param>
		/// <param name="maxIndices">Number max of indices remapped</param>
		public Material.RemapIndexMapReturn RemapIndexMap(ImageList maps, System.Int32 maxIndices) {
			var maps_c = new Material.ImageList_c();
			ConvertValue((Material.ImageList)maps, ref maps_c);
			var ret = Material_remapIndexMap(api.Session, maps_c, maxIndices);
			Material.MaterialInterface.Material_ImageList_free(ref maps_c);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			Material.RemapIndexMapReturn retStruct = new Material.RemapIndexMapReturn();
			retStruct.mappedMaps = ConvertValue(ref ret.mappedMaps);
			Material.MaterialInterface.Material_ImageList_free(ref ret.mappedMaps);
			retStruct.newToOldMapIndices = ConvertValue(ref ret.newToOldMapIndices);
			Core.CoreInterface.Core_IntListList_free(ref ret.newToOldMapIndices);
			return retStruct;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_resizeImage(IntPtr _pxz_session_, System.UInt32 image, Int32 width, Int32 height);
		/// <summary>
		/// Resize an image
		/// </summary>
		/// <param name="image">Image to be resize</param>
		/// <param name="width">New image width</param>
		/// <param name="height">New image height</param>
		public void ResizeImage(System.UInt32 image, System.Int32 width, System.Int32 height) {
			Material_resizeImage(api.Session, image, width, height);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_setFragmentShader(IntPtr _pxz_session_, System.UInt32 pattern, string code);
		/// <summary>
		/// Set the fragment shader of a custom pattern
		/// </summary>
		/// <param name="pattern">The custom pattern to edit</param>
		/// <param name="code">The GLSL code of the fragment shader</param>
		public void SetFragmentShader(System.UInt32 pattern, System.String code) {
			Material_setFragmentShader(api.Session, pattern, code);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_setMaterialMainColor(IntPtr _pxz_session_, System.UInt32 material, Core.ColorAlpha_c color);
		/// <summary>
		/// Set the main color on any material pattern type
		/// </summary>
		/// <param name="material">The material to apply the color on</param>
		/// <param name="color">The color to apply</param>
		public void SetMaterialMainColor(System.UInt32 material, Core.ColorAlpha color) {
			var color_c = new Core.ColorAlpha_c();
			Core.CoreInterface.ConvertValue((Core.ColorAlpha)color, ref color_c);
			Material_setMaterialMainColor(api.Session, material, color_c);
			Core.CoreInterface.Core_ColorAlpha_free(ref color_c);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_setMaterialPattern(IntPtr _pxz_session_, System.UInt32 material, string pattern);
		/// <summary>
		/// Sets the MaterialPattern name of the material
		/// </summary>
		/// <param name="material">The material to find the pattern</param>
		/// <param name="pattern">The pattern of the material</param>
		public void SetMaterialPattern(System.UInt32 material, System.String pattern) {
			Material_setMaterialPattern(api.Session, material, pattern);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_setPBRMaterialInfos(IntPtr _pxz_session_, System.UInt32 material, PBRMaterialInfos_c infos);
		/// <summary>
		/// Set PBR  material properties
		/// </summary>
		/// <param name="material">The material to set properties</param>
		/// <param name="infos">The PBRMaterialInfos properties</param>
		public void SetPBRMaterialInfos(System.UInt32 material, PBRMaterialInfos infos) {
			var infos_c = new Material.PBRMaterialInfos_c();
			ConvertValue((Material.PBRMaterialInfos)infos, ref infos_c);
			Material_setPBRMaterialInfos(api.Session, material, infos_c);
			Material.MaterialInterface.Material_PBRMaterialInfos_free(ref infos_c);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_setVertexShader(IntPtr _pxz_session_, System.UInt32 pattern, string code);
		/// <summary>
		/// Set the vertex shader of a custom pattern
		/// </summary>
		/// <param name="pattern">The custom pattern to edit</param>
		/// <param name="code">The GLSL code of the vertex shader</param>
		public void SetVertexShader(System.UInt32 pattern, System.String code) {
			Material_setVertexShader(api.Session, pattern, code);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_updateImageFromDefinition(IntPtr _pxz_session_, System.UInt32 image, ImageDefinition_c imageDefinition);
		/// <summary>
		/// Update an image from its raw data
		/// </summary>
		/// <param name="image">The image to update</param>
		/// <param name="imageDefinition">The new data to apply</param>
		public void UpdateImageFromDefinition(System.UInt32 image, ImageDefinition imageDefinition) {
			var imageDefinition_c = new Material.ImageDefinition_c();
			ConvertValue((Material.ImageDefinition)imageDefinition, ref imageDefinition_c);
			Material_updateImageFromDefinition(api.Session, image, imageDefinition_c);
			Material.MaterialInterface.Material_ImageDefinition_free(ref imageDefinition_c);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_updateImagesFromDefinitions(IntPtr _pxz_session_, ImageList_c image, ImageDefinitionList_c imageDefinitions);
		/// <summary>
		/// Update images from their raw data
		/// </summary>
		/// <param name="image">The image to update</param>
		/// <param name="imageDefinitions">The new data to apply</param>
		public void UpdateImagesFromDefinitions(ImageList image, ImageDefinitionList imageDefinitions) {
			var image_c = new Material.ImageList_c();
			ConvertValue((Material.ImageList)image, ref image_c);
			var imageDefinitions_c = new Material.ImageDefinitionList_c();
			ConvertValue((Material.ImageDefinitionList)imageDefinitions, ref imageDefinitions_c);
			Material_updateImagesFromDefinitions(api.Session, image_c, imageDefinitions_c);
			Material.MaterialInterface.Material_ImageList_free(ref image_c);
			Material.MaterialInterface.Material_ImageDefinitionList_free(ref imageDefinitions_c);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		private delegate void ImageChangedDelegate(System.IntPtr userdata, ImageChangeType type, System.UInt32 image);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Material_addImageChangedCallback(IntPtr _pxz_session_, ImageChangedDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_removeImageChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addImageChangedCallback(ImageChangedDelegate callback, System.IntPtr userdata) {
			return Material_addImageChangedCallback(api.Session, callback, userdata);
		}

		private void removeImageChangedCallback(System.UInt32 id) {
			Material_removeImageChangedCallback(api.Session, id);
		}

		public class ImageChangedTask : PixyzCallbackTask
		{
			public struct Params
			{
				public ImageChangeType type;
				public System.UInt32 image;

				public Params(ImageChangeType type, System.UInt32 image)
				{
					this.type = type;
					this.image = image;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private MaterialInterface iface;

				public Execution(MaterialInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					ImageChangedDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addImageChangedCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeImageChangedCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, ImageChangeType type, System.UInt32 image)
				{
					try
					{
						_params.Enqueue(new Params(type, image));

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
		public Task<ImageChangedTask.Params> WaitImageChanged(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new ImageChangedTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnImageChanged(Action<ImageChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			ImageChangedTask.Execution task = new ImageChangedTask.Execution(this, cancelSource);
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

		public void OnImageChanged(Action<ImageChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnImageChanged(action, cancelSource);
		}
		private delegate void MaterialChangedDelegate(System.IntPtr userdata, MaterialChangeType type, System.UInt32 material);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Material_addMaterialChangedCallback(IntPtr _pxz_session_, MaterialChangedDelegate callback, System.IntPtr userdata);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_removeMaterialChangedCallback(IntPtr _pxz_session_, System.UInt32 id);

		private System.UInt32 addMaterialChangedCallback(MaterialChangedDelegate callback, System.IntPtr userdata) {
			return Material_addMaterialChangedCallback(api.Session, callback, userdata);
		}

		private void removeMaterialChangedCallback(System.UInt32 id) {
			Material_removeMaterialChangedCallback(api.Session, id);
		}

		public class MaterialChangedTask : PixyzCallbackTask
		{
			public struct Params
			{
				public MaterialChangeType type;
				public System.UInt32 material;

				public Params(MaterialChangeType type, System.UInt32 material)
				{
					this.type = type;
					this.material = material;
				}
			}

			public class Execution : BaseTaskExecution<Params>
			{
				private MaterialInterface iface;

				public Execution(MaterialInterface iface, CancellationTokenSource cancelTokenSource = null) : base(cancelTokenSource)
				{
					this.iface = iface;
				}

				protected override void AttachCallback()
				{
					MaterialChangedDelegate callback = Updated;

					_delegatePtr = GCHandle.Alloc(callback, GCHandleType.Pinned);
					_callbackId = iface.addMaterialChangedCallback(callback, IntPtr.Zero);

				}

				protected override void DetachCallback()
				{
					if (_callbackId == 0)
						return;

					iface.removeMaterialChangedCallback(_callbackId);
					_callbackId = 0;
				}

				private void Updated(System.IntPtr userdata, MaterialChangeType type, System.UInt32 material)
				{
					try
					{
						_params.Enqueue(new Params(type, material));

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
		public Task<MaterialChangedTask.Params> WaitMaterialChanged(CancellationTokenSource cancelSource = null)
		{
			return Task.Run(new MaterialChangedTask.Execution(this, cancelSource).RunOnce);
		}

		private async Task AsyncOnMaterialChanged(Action<MaterialChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			MaterialChangedTask.Execution task = new MaterialChangedTask.Execution(this, cancelSource);
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

		public void OnMaterialChanged(Action<MaterialChangedTask.Params> action, CancellationTokenSource cancelSource = null)
		{
			_ = AsyncOnMaterialChanged(action, cancelSource);
		}
		#endregion

		#region userData

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.IntPtr Material_getMaterialUserData(IntPtr _pxz_session_, System.UInt32 userDataId, System.UInt32 material);
		/// <summary>
		/// Set or replace a userdata stored on an material
		/// </summary>
		/// <param name="userDataId">UserData identifier provided by subscribeToMaterialUserData</param>
		/// <param name="material">Material that store the user data</param>
		public System.IntPtr GetMaterialUserData(System.UInt32 userDataId, System.UInt32 material) {
			var ret = Material_getMaterialUserData(api.Session, userDataId, material);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.IntPtr)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.PtrList_c Material_getMultipleMaterialUserData(IntPtr _pxz_session_, System.UInt32 userDataId, MaterialList_c materials);
		/// <summary>
		/// Batch version of getMaterialUserData
		/// </summary>
		/// <param name="userDataId">UserData identifier provided by subscribeToMaterialUserData</param>
		/// <param name="materials">Materials that store the user data</param>
		public Core.PtrList GetMultipleMaterialUserData(System.UInt32 userDataId, MaterialList materials) {
			var materials_c = new Material.MaterialList_c();
			ConvertValue((Material.MaterialList)materials, ref materials_c);
			var ret = Material_getMultipleMaterialUserData(api.Session, userDataId, materials_c);
			Material.MaterialInterface.Material_MaterialList_free(ref materials_c);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Core.CoreInterface.ConvertValue(ref ret);
			Core.CoreInterface.Core_PtrList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.Byte Material_hasMaterialUserData(IntPtr _pxz_session_, System.UInt32 userDataId, System.UInt32 material);
		/// <summary>
		/// Set or replace a userdata stored on an material
		/// </summary>
		/// <param name="userDataId">UserData identifier provided by subscribeToMaterialUserData</param>
		/// <param name="material">Material that potentially store the user data</param>
		public System.Boolean HasMaterialUserData(System.UInt32 userDataId, System.UInt32 material) {
			var ret = Material_hasMaterialUserData(api.Session, userDataId, material);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.Boolean)(0 != ret);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.BoolList_c Material_hasMultipleMaterialUserData(IntPtr _pxz_session_, System.UInt32 userDataId, MaterialList_c materials);
		/// <summary>
		/// Batch version of hasMaterialUserData
		/// </summary>
		/// <param name="userDataId">UserData identifier provided by subscribeToMaterialUserData</param>
		/// <param name="materials">Materials that potentially store the user data</param>
		public Core.BoolList HasMultipleMaterialUserData(System.UInt32 userDataId, MaterialList materials) {
			var materials_c = new Material.MaterialList_c();
			ConvertValue((Material.MaterialList)materials, ref materials_c);
			var ret = Material_hasMultipleMaterialUserData(api.Session, userDataId, materials_c);
			Material.MaterialInterface.Material_MaterialList_free(ref materials_c);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Core.CoreInterface.ConvertValue(ref ret);
			Core.CoreInterface.Core_BoolList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_setMaterialUserData(IntPtr _pxz_session_, System.UInt32 userDataId, System.UInt32 material, System.IntPtr userData);
		/// <summary>
		/// Set or replace a userdata stored on an material
		/// </summary>
		/// <param name="userDataId">UserData identifier provided by subscribeToMaterialUserData</param>
		/// <param name="material">Material that will store the user data</param>
		/// <param name="userData">User data to store in the given material</param>
		public void SetMaterialUserData(System.UInt32 userDataId, System.UInt32 material, System.IntPtr userData) {
			Material_setMaterialUserData(api.Session, userDataId, material, userData);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_setMultipleMaterialUserData(IntPtr _pxz_session_, System.UInt32 userDataId, MaterialList_c materials, Core.PtrList_c userDataList);
		/// <summary>
		/// Batch version of setMaterialUserData
		/// </summary>
		/// <param name="userDataId">UserData identifier provided by subscribeToMaterialUserData</param>
		/// <param name="materials">Materials that will store the user data</param>
		/// <param name="userDataList">User data to store on each material</param>
		public void SetMultipleMaterialUserData(System.UInt32 userDataId, MaterialList materials, Core.PtrList userDataList) {
			var materials_c = new Material.MaterialList_c();
			ConvertValue((Material.MaterialList)materials, ref materials_c);
			var userDataList_c = new Core.PtrList_c();
			Core.CoreInterface.ConvertValue((Core.PtrList)userDataList, ref userDataList_c);
			Material_setMultipleMaterialUserData(api.Session, userDataId, materials_c, userDataList_c);
			Material.MaterialInterface.Material_MaterialList_free(ref materials_c);
			Core.CoreInterface.Core_PtrList_free(ref userDataList_c);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 Material_subscribeToMaterialUserData(IntPtr _pxz_session_);
		/// <summary>
		/// subscribe to material user data. multiple different userdata can be stored on the same materials if subscribeToMaterialUserData is called multiple times
		/// </summary>
		public System.UInt32 SubscribeToMaterialUserData() {
			var ret = Material_subscribeToMaterialUserData(api.Session);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_unsetMaterialUserData(IntPtr _pxz_session_, System.UInt32 userDataId, System.UInt32 material);
		/// <summary>
		/// Unset the userdata stored on an material
		/// </summary>
		/// <param name="userDataId">UserData identifier provided by subscribeToMaterialUserData</param>
		/// <param name="material">Material that will store the user data</param>
		public void UnsetMaterialUserData(System.UInt32 userDataId, System.UInt32 material) {
			Material_unsetMaterialUserData(api.Session, userDataId, material);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_unsetMultipleMaterialUserData(IntPtr _pxz_session_, System.UInt32 userDataId, MaterialList_c materials);
		/// <summary>
		/// Batch version of unsetMaterialUserData
		/// </summary>
		/// <param name="userDataId">UserData identifier provided by subscribeToMaterialUserData</param>
		/// <param name="materials">Materials that will store the user data</param>
		public void UnsetMultipleMaterialUserData(System.UInt32 userDataId, MaterialList materials) {
			var materials_c = new Material.MaterialList_c();
			ConvertValue((Material.MaterialList)materials, ref materials_c);
			Material_unsetMultipleMaterialUserData(api.Session, userDataId, materials_c);
			Material.MaterialInterface.Material_MaterialList_free(ref materials_c);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void Material_unsubscribeFromMaterialUserData(IntPtr _pxz_session_, System.UInt32 userDataId);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="userDataId">UserData identifier to unsubscribe</param>
		public void UnsubscribeFromMaterialUserData(System.UInt32 userDataId) {
			Material_unsubscribeFromMaterialUserData(api.Session, userDataId);
			System.String err = ConvertValue(Material_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		private PiXYZAPI api;
		internal MaterialInterface(PiXYZAPI api)
		{
			this.api = api;
		}

	}
}
