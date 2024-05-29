#pragma warning disable CA2101

using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System;
using PiXYZAPI = UnityEngine.Pixyz.API.PiXYZAPI;

namespace UnityEngine.Pixyz.IO {

	public class IOInterface : API.Interface {

		#region Types Init/Free Methods

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_FilesList_init(ref FilesList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_FilesList_free(ref FilesList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_OpenStackAccess_init(ref OpenStackAccess_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_OpenStackAccess_free(ref OpenStackAccess_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_DropBoxAccess_init(ref DropBoxAccess_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_DropBoxAccess_free(ref DropBoxAccess_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_OwnCloudAccess_init(ref OwnCloudAccess_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_OwnCloudAccess_free(ref OwnCloudAccess_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_LocalFileAccess_init(ref LocalFileAccess_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_LocalFileAccess_free(ref LocalFileAccess_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_WebDAVAccess_init(ref WebDAVAccess_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_WebDAVAccess_free(ref WebDAVAccess_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_CloudFile_init(ref CloudFile_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_CloudFile_free(ref CloudFile_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_VariantNameList_init(ref VariantNameList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_VariantNameList_free(ref VariantNameList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_ImportFilePathList_init(ref ImportFilePathList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_ImportFilePathList_free(ref ImportFilePathList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_ExportFilePathList_init(ref ExportFilePathList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_ExportFilePathList_free(ref ExportFilePathList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_LocalDirectoryAccess_init(ref LocalDirectoryAccess_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_LocalDirectoryAccess_free(ref LocalDirectoryAccess_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_CloudDirectory_init(ref CloudDirectory_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_CloudDirectory_free(ref CloudDirectory_c sel);

	internal static FilesList ConvertValue(ref FilesList_c s) {
		FilesList list = new FilesList((int)s.size);
		if (s.size==0) return list;

		IntPtr[] tab = new IntPtr[s.size];
		Marshal.Copy(s.ptr, tab, 0, (int)s.size);
		for (int i = 0; i < (int)s.size; ++i) {
			list.list[i] = ConvertValue(tab[i]);
		}
		return list;
	}

	internal static FilesList_c ConvertValue(FilesList s, ref FilesList_c list) {
		IO.IOInterface.IO_FilesList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		IntPtr[] tab = new IntPtr[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = ConvertValue(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static OpenStackAccess ConvertValue(ref OpenStackAccess_c s) {
		OpenStackAccess ss = new OpenStackAccess();
		ss.path = ConvertValue(s.path);
		ss.authUrl = ConvertValue(s.authUrl);
		ss.region = ConvertValue(s.region);
		ss.user = ConvertValue(s.user);
		ss.password = ConvertValue(s.password);
		ss.domainId = ConvertValue(s.domainId);
		ss.projectId = ConvertValue(s.projectId);
		ss.container = ConvertValue(s.container);
		ss.objectStore = ConvertValue(s.objectStore);
		return ss;
	}

	internal static OpenStackAccess_c ConvertValue(OpenStackAccess s, ref OpenStackAccess_c ss) {
		IO.IOInterface.IO_OpenStackAccess_init(ref ss);
		ss.path = ConvertValue(s.path);
		ss.authUrl = ConvertValue(s.authUrl);
		ss.region = ConvertValue(s.region);
		ss.user = ConvertValue(s.user);
		ss.password = ConvertValue(s.password);
		ss.domainId = ConvertValue(s.domainId);
		ss.projectId = ConvertValue(s.projectId);
		ss.container = ConvertValue(s.container);
		ss.objectStore = ConvertValue(s.objectStore);
		return ss;
	}

	internal static DropBoxAccess ConvertValue(ref DropBoxAccess_c s) {
		DropBoxAccess ss = new DropBoxAccess();
		ss.path = ConvertValue(s.path);
		ss.token = ConvertValue(s.token);
		return ss;
	}

	internal static DropBoxAccess_c ConvertValue(DropBoxAccess s, ref DropBoxAccess_c ss) {
		IO.IOInterface.IO_DropBoxAccess_init(ref ss);
		ss.path = ConvertValue(s.path);
		ss.token = ConvertValue(s.token);
		return ss;
	}

	internal static OwnCloudAccess ConvertValue(ref OwnCloudAccess_c s) {
		OwnCloudAccess ss = new OwnCloudAccess();
		ss.path = ConvertValue(s.path);
		ss.authUrl = ConvertValue(s.authUrl);
		ss.user = ConvertValue(s.user);
		ss.password = ConvertValue(s.password);
		return ss;
	}

	internal static OwnCloudAccess_c ConvertValue(OwnCloudAccess s, ref OwnCloudAccess_c ss) {
		IO.IOInterface.IO_OwnCloudAccess_init(ref ss);
		ss.path = ConvertValue(s.path);
		ss.authUrl = ConvertValue(s.authUrl);
		ss.user = ConvertValue(s.user);
		ss.password = ConvertValue(s.password);
		return ss;
	}

	internal static LocalFileAccess ConvertValue(ref LocalFileAccess_c s) {
		LocalFileAccess ss = new LocalFileAccess();
		ss.path = ConvertValue(s.path);
		return ss;
	}

	internal static LocalFileAccess_c ConvertValue(LocalFileAccess s, ref LocalFileAccess_c ss) {
		IO.IOInterface.IO_LocalFileAccess_init(ref ss);
		ss.path = ConvertValue(s.path);
		return ss;
	}

	internal static WebDAVAccess ConvertValue(ref WebDAVAccess_c s) {
		WebDAVAccess ss = new WebDAVAccess();
		ss.path = ConvertValue(s.path);
		ss.host = ConvertValue(s.host);
		ss.port = (System.UInt16)s.port;
		ss.protocol = (Protocol)s.protocol;
		ss.user = ConvertValue(s.user);
		ss.password = ConvertValue(s.password);
		ss.url = ConvertValue(s.url);
		return ss;
	}

	internal static WebDAVAccess_c ConvertValue(WebDAVAccess s, ref WebDAVAccess_c ss) {
		IO.IOInterface.IO_WebDAVAccess_init(ref ss);
		ss.path = ConvertValue(s.path);
		ss.host = ConvertValue(s.host);
		ss.port = (System.UInt16)s.port;
		ss.protocol = (Int32)s.protocol;
		ss.user = ConvertValue(s.user);
		ss.password = ConvertValue(s.password);
		ss.url = ConvertValue(s.url);
		return ss;
	}

	internal static CloudFile ConvertValue(ref CloudFile_c s) {
		CloudFile ss = new CloudFile();
		ss._type = (CloudFile.Type)s._type;
		switch(ss._type) {
			case CloudFile.Type.UNKNOWN: break;
			case CloudFile.Type.LOCAL: ss.local = ConvertValue(ref s.local); break;
			case CloudFile.Type.OPENSTACK: ss.openStack = ConvertValue(ref s.openStack); break;
			case CloudFile.Type.DROPBOX: ss.dropBox = ConvertValue(ref s.dropBox); break;
			case CloudFile.Type.OWNCLOUD: ss.ownCloud = ConvertValue(ref s.ownCloud); break;
			case CloudFile.Type.WEBDAV: ss.webDAV = ConvertValue(ref s.webDAV); break;
		}
		return ss;
	}

	internal static CloudFile_c ConvertValue(CloudFile s, ref CloudFile_c ss) {
		IO.IOInterface.IO_CloudFile_init(ref ss);
		ss._type = (int)s._type;
		switch (ss._type) {
			case 0: break;
			case 1: ConvertValue(s.local, ref ss.local); break;
			case 2: ConvertValue(s.openStack, ref ss.openStack); break;
			case 3: ConvertValue(s.dropBox, ref ss.dropBox); break;
			case 4: ConvertValue(s.ownCloud, ref ss.ownCloud); break;
			case 5: ConvertValue(s.webDAV, ref ss.webDAV); break;
		}
		return ss;
	}

	internal static VariantNameList ConvertValue(ref VariantNameList_c s) {
		VariantNameList list = new VariantNameList((int)s.size);
		if (s.size==0) return list;

		IntPtr[] tab = new IntPtr[s.size];
		Marshal.Copy(s.ptr, tab, 0, (int)s.size);
		for (int i = 0; i < (int)s.size; ++i) {
			list.list[i] = ConvertValue(tab[i]);
		}
		return list;
	}

	internal static VariantNameList_c ConvertValue(VariantNameList s, ref VariantNameList_c list) {
		IO.IOInterface.IO_VariantNameList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		IntPtr[] tab = new IntPtr[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = ConvertValue(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static ImportFilePathList ConvertValue(ref ImportFilePathList_c s) {
		ImportFilePathList list = new ImportFilePathList((int)s.size);
		if (s.size==0) return list;

		IntPtr[] tab = new IntPtr[s.size];
		Marshal.Copy(s.ptr, tab, 0, (int)s.size);
		for (int i = 0; i < (int)s.size; ++i) {
			list.list[i] = ConvertValue(tab[i]);
		}
		return list;
	}

	internal static ImportFilePathList_c ConvertValue(ImportFilePathList s, ref ImportFilePathList_c list) {
		IO.IOInterface.IO_ImportFilePathList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		IntPtr[] tab = new IntPtr[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = ConvertValue(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static ExportFilePathList ConvertValue(ref ExportFilePathList_c s) {
		ExportFilePathList list = new ExportFilePathList((int)s.size);
		if (s.size==0) return list;

		IntPtr[] tab = new IntPtr[s.size];
		Marshal.Copy(s.ptr, tab, 0, (int)s.size);
		for (int i = 0; i < (int)s.size; ++i) {
			list.list[i] = ConvertValue(tab[i]);
		}
		return list;
	}

	internal static ExportFilePathList_c ConvertValue(ExportFilePathList s, ref ExportFilePathList_c list) {
		IO.IOInterface.IO_ExportFilePathList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		IntPtr[] tab = new IntPtr[list.size];
		for (int i = 0; i < (int)list.size; ++i)
			tab[i] = ConvertValue(s.list[i]);
		Marshal.Copy(tab, 0, list.ptr, (int)list.size);
		return list;
	}

	internal static LocalDirectoryAccess ConvertValue(ref LocalDirectoryAccess_c s) {
		LocalDirectoryAccess ss = new LocalDirectoryAccess();
		ss.path = ConvertValue(s.path);
		return ss;
	}

	internal static LocalDirectoryAccess_c ConvertValue(LocalDirectoryAccess s, ref LocalDirectoryAccess_c ss) {
		IO.IOInterface.IO_LocalDirectoryAccess_init(ref ss);
		ss.path = ConvertValue(s.path);
		return ss;
	}

	internal static CloudDirectory ConvertValue(ref CloudDirectory_c s) {
		CloudDirectory ss = new CloudDirectory();
		ss._type = (CloudDirectory.Type)s._type;
		switch(ss._type) {
			case CloudDirectory.Type.UNKNOWN: break;
			case CloudDirectory.Type.LOCAL: ss.local = ConvertValue(ref s.local); break;
			case CloudDirectory.Type.OPENSTACK: ss.openStack = ConvertValue(ref s.openStack); break;
			case CloudDirectory.Type.DROPBOX: ss.dropBox = ConvertValue(ref s.dropBox); break;
			case CloudDirectory.Type.OWNCLOUD: ss.ownCloud = ConvertValue(ref s.ownCloud); break;
			case CloudDirectory.Type.WEBDAV: ss.webDAV = ConvertValue(ref s.webDAV); break;
		}
		return ss;
	}

	internal static CloudDirectory_c ConvertValue(CloudDirectory s, ref CloudDirectory_c ss) {
		IO.IOInterface.IO_CloudDirectory_init(ref ss);
		ss._type = (int)s._type;
		switch (ss._type) {
			case 0: break;
			case 1: ConvertValue(s.local, ref ss.local); break;
			case 2: ConvertValue(s.openStack, ref ss.openStack); break;
			case 3: ConvertValue(s.dropBox, ref ss.dropBox); break;
			case 4: ConvertValue(s.ownCloud, ref ss.ownCloud); break;
			case 5: ConvertValue(s.webDAV, ref ss.webDAV); break;
		}
		return ss;
	}

		#endregion

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr IO_getLastError();

		public static string GetLastError()
		{
			return ConvertValue(IO_getLastError());
		}

		#region 

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void IO_configureFunctionLogger(IntPtr _pxz_session_, string functionName, System.Byte enableFunction, System.Byte enableParameters, System.Byte enableExecutionTime);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="functionName"></param>
		/// <param name="enableFunction"></param>
		/// <param name="enableParameters"></param>
		/// <param name="enableExecutionTime"></param>
		public void ConfigureFunctionLogger(System.String functionName, System.Boolean enableFunction, System.Boolean enableParameters, System.Boolean enableExecutionTime) {
			IO_configureFunctionLogger(api.Session, functionName, Convert.ToByte(enableFunction), Convert.ToByte(enableParameters), Convert.ToByte(enableExecutionTime));
			System.String err = ConvertValue(IO_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region Cloud

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void IO_exportSceneToDTPlatform(IntPtr _pxz_session_, System.UInt32 root, string directory);
		/// <summary>
		/// Export current scene to a local directory
		/// </summary>
		/// <param name="root">Identifier of the destination occurrence</param>
		/// <param name="directory">Directory to export in</param>
		public void ExportSceneToDTPlatform(System.UInt32 root, System.String directory) {
			IO_exportSceneToDTPlatform(api.Session, root, directory);
			System.String err = ConvertValue(IO_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void IO_exportSceneToReflect(IntPtr _pxz_session_, System.UInt32 root, string sourceName, string uid, System.Byte keepHierarchy, string configFile, System.Byte disableDecimation);
		/// <summary>
		/// Export current scene to a reflect project
		/// </summary>
		/// <param name="root">Identifier of the destination occurrence</param>
		/// <param name="sourceName">Push source name</param>
		/// <param name="uid">UID of the push, overwrite old push if it's same UID</param>
		/// <param name="keepHierarchy">Keep hierarchy or rake tree</param>
		/// <param name="configFile">Use existing JSON config file, discard reflect UI prompt</param>
		/// <param name="disableDecimation">Forces to disable the decimation applied on SyncObjectInstances on Reflect Server side</param>
		public void ExportSceneToReflect(System.UInt32 root = 1, System.String sourceName = "", System.String uid = "", System.Boolean keepHierarchy = false, System.String configFile = "", System.Boolean disableDecimation = true) {
			IO_exportSceneToReflect(api.Session, root, sourceName, uid, Convert.ToByte(keepHierarchy), configFile, Convert.ToByte(disableDecimation));
			System.String err = ConvertValue(IO_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void IO_importSceneFromDTPlatform(IntPtr _pxz_session_, string directory, System.UInt32 root);
		/// <summary>
		/// Import scene from a local directory
		/// </summary>
		/// <param name="directory">Directory to import from</param>
		/// <param name="root">Identifier of the destination occurrence</param>
		public void ImportSceneFromDTPlatform(System.String directory, System.UInt32 root = 0) {
			IO_importSceneFromDTPlatform(api.Session, directory, root);
			System.String err = ConvertValue(IO_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region Debug

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void IO_debug(IntPtr _pxz_session_, CloudFile_c cloudFile);
		/// <summary>
		/// for debugging purpose only
		/// </summary>
		/// <param name="cloudFile">File to import</param>
		public void Debug(CloudFile cloudFile) {
			var cloudFile_c = new IO.CloudFile_c();
			ConvertValue((IO.CloudFile)cloudFile, ref cloudFile_c);
			IO_debug(api.Session, cloudFile_c);
			IO.IOInterface.IO_CloudFile_free(ref cloudFile_c);
			System.String err = ConvertValue(IO_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void IO_importDebugTessellation(IntPtr _pxz_session_, string filename);
		/// <summary>
		/// for debugging purpose only
		/// </summary>
		/// <param name="filename">Path of the file to import</param>
		public void ImportDebugTessellation(System.String filename) {
			IO_importDebugTessellation(api.Session, filename);
			System.String err = ConvertValue(IO_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region Import/Export

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void IO_exportScene(IntPtr _pxz_session_, string fileName, System.UInt32 root);
		/// <summary>
		/// Export a file
		/// </summary>
		/// <param name="fileName">Path of the file to export</param>
		/// <param name="root">Identifier of the root occurrence to export</param>
		public void ExportScene(System.String fileName, System.UInt32 root = 0) {
			IO_exportScene(api.Session, fileName, root);
			System.String err = ConvertValue(IO_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void IO_exportSelection(IntPtr _pxz_session_, string fileName, System.Byte keepIntermediaryNodes);
		/// <summary>
		/// Export the selection to a file
		/// </summary>
		/// <param name="fileName">Path of the file to export</param>
		/// <param name="keepIntermediaryNodes">If true, intermerdiary hierarchy is kept</param>
		public void ExportSelection(System.String fileName, System.Boolean keepIntermediaryNodes = false) {
			IO_exportSelection(api.Session, fileName, Convert.ToByte(keepIntermediaryNodes));
			System.String err = ConvertValue(IO_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.FormatList_c IO_getExportFormats(IntPtr _pxz_session_);
		/// <summary>
		/// Give all the format name and their extensions that can be exported in Pixyz
		/// </summary>
		public Core.FormatList GetExportFormats() {
			var ret = IO_getExportFormats(api.Session);
			System.String err = ConvertValue(IO_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Core.CoreInterface.ConvertValue(ref ret);
			Core.CoreInterface.Core_FormatList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.FormatList_c IO_getImportFormats(IntPtr _pxz_session_);
		/// <summary>
		/// Give all the format name and their extensions that can be imported in Pixyz
		/// </summary>
		public Core.FormatList GetImportFormats() {
			var ret = IO_getImportFormats(api.Session);
			System.String err = ConvertValue(IO_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Core.CoreInterface.ConvertValue(ref ret);
			Core.CoreInterface.Core_FormatList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Scene.OccurrenceList_c IO_importFiles(IntPtr _pxz_session_, FilesList_c fileNames, System.UInt32 root);
		/// <summary>
		/// Import files
		/// </summary>
		/// <param name="fileNames">List of files's paths to import</param>
		/// <param name="root">Identifier of the destination occurrence</param>
		public Scene.OccurrenceList ImportFiles(FilesList fileNames, System.UInt32 root = 0) {
			var fileNames_c = new IO.FilesList_c();
			ConvertValue((IO.FilesList)fileNames, ref fileNames_c);
			var ret = IO_importFiles(api.Session, fileNames_c, root);
			IO.IOInterface.IO_FilesList_free(ref fileNames_c);
			System.String err = ConvertValue(IO_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = Scene.SceneInterface.ConvertValue(ref ret);
			Scene.SceneInterface.Scene_OccurrenceList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 IO_importPicture(IntPtr _pxz_session_, string filename, System.UInt32 root);
		/// <summary>
		/// Imports a picture and applies is at as a texture on a 3D plane created in the scene.
		/// </summary>
		/// <param name="filename">Path of the file to import</param>
		/// <param name="root">Identifier of the destination occurrence</param>
		public System.UInt32 ImportPicture(System.String filename, System.UInt32 root = 0) {
			var ret = IO_importPicture(api.Session, filename, root);
			System.String err = ConvertValue(IO_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 IO_importRemote3mxFile(IntPtr _pxz_session_, string filePath, string origin, System.UInt32 root);
		/// <summary>
		/// Import a remote 3mx file
		/// </summary>
		/// <param name="filePath">The path of the temp file</param>
		/// <param name="origin">Remote origin of the file</param>
		/// <param name="root">Identifier of the destination occurrence</param>
		public System.UInt32 ImportRemote3mxFile(System.String filePath, System.String origin = "", System.UInt32 root = 0) {
			var ret = IO_importRemote3mxFile(api.Session, filePath, origin, root);
			System.String err = ConvertValue(IO_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 IO_importScene(IntPtr _pxz_session_, string fileName, System.UInt32 root);
		/// <summary>
		/// Import a file
		/// </summary>
		/// <param name="fileName">Path of the file to import</param>
		/// <param name="root">Identifier of the destination occurrence</param>
		public System.UInt32 ImportScene(System.String fileName, System.UInt32 root = 0) {
			var ret = IO_importScene(api.Session, fileName, root);
			System.String err = ConvertValue(IO_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			return (System.UInt32)ret;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern VariantNameList_c IO_listVariants(IntPtr _pxz_session_, string fileName);
		/// <summary>
		/// List all variants if file
		/// </summary>
		/// <param name="fileName">Path of the file to import</param>
		public VariantNameList ListVariants(System.String fileName) {
			var ret = IO_listVariants(api.Session, fileName);
			System.String err = ConvertValue(IO_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
			var convRet = ConvertValue(ref ret);
			IO.IOInterface.IO_VariantNameList_free(ref ret);
			return convRet;
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void IO_loadReferencedData(IntPtr _pxz_session_, System.UInt32 component, System.Byte recursively);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="component">The component to load</param>
		/// <param name="recursively">Load it recursively or not</param>
		public void LoadReferencedData(System.UInt32 component, System.Boolean recursively) {
			IO_loadReferencedData(api.Session, component, Convert.ToByte(recursively));
			System.String err = ConvertValue(IO_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region ImportCallbacks

		//C# delegate
		public delegate void importFileCallback(System.String filename, System.UInt32 rootOccurrence);

		//C delegate
		public delegate void importFileCallback_c(System.String filename, System.UInt32 rootOccurrence);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void IO_registerImportCallback(IntPtr _pxz_session_, string name, Core.StringList_c extensions, importFileCallback_c callback);
		/// <summary>
		/// add new homade importer
		/// </summary>
		/// <param name="name">Callback name</param>
		/// <param name="extensions">Handled extensions</param>
		/// <param name="callback">Callback that import a file</param>
	private static void importFileCallback_CS(string filename, System.UInt32 rootOccurrence, importFileCallback callback) {

			callback((System.String)(filename), (System.UInt32)(rootOccurrence));
	}

		public void RegisterImportCallback(System.String name, Core.StringList extensions, importFileCallback callback) {
			var extensions_c = new Core.StringList_c();
			Core.CoreInterface.ConvertValue((Core.StringList)extensions, ref extensions_c);
			IO_registerImportCallback(api.Session, name, extensions_c, (filename, rootOccurrence) => { 
				importFileCallback_CS(filename, rootOccurrence, callback);
			});
			Core.CoreInterface.Core_StringList_free(ref extensions_c);
			System.String err = ConvertValue(IO_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		#region Point Cloud

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void IO_splitPointCloud(IntPtr _pxz_session_, Core.FilePathList_c files, string outputDirectory, System.Double minVoxSize, System.Byte useKDTree, Geom.AABB_c aabb, System.Double density);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="files">Path of the point cloud files to process</param>
		/// <param name="outputDirectory">Output directory</param>
		/// <param name="minVoxSize">Size of minimum leaves (mm)</param>
		/// <param name="useKDTree">If true, uses a kd_tree, otherwise, uses an octree</param>
		/// <param name="aabb">Global scene aabb</param>
		/// <param name="density">Point cloud density (-1 to compute)</param>
		public void SplitPointCloud(Core.FilePathList files, System.String outputDirectory, System.Double minVoxSize, System.Boolean useKDTree, Geom.AABB aabb = null, System.Double density = -1) {
			aabb = aabb ?? new Geom.AABB() {};
			var files_c = new Core.FilePathList_c();
			Core.CoreInterface.ConvertValue((Core.FilePathList)files, ref files_c);
			var aabb_c = new Geom.AABB_c();
			Geom.GeomInterface.ConvertValue((Geom.AABB)aabb, ref aabb_c);
			IO_splitPointCloud(api.Session, files_c, outputDirectory, minVoxSize, Convert.ToByte(useKDTree), aabb_c, density);
			Core.CoreInterface.Core_FilePathList_free(ref files_c);
			Geom.GeomInterface.Geom_AABB_free(ref aabb_c);
			System.String err = ConvertValue(IO_getLastError());
			if(!System.String.IsNullOrEmpty(err))
				throw new Exception(err);
		}

		#endregion

		private PiXYZAPI api;
		internal IOInterface(PiXYZAPI api)
		{
			this.api = api;
		}

	}
}
