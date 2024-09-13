#pragma warning disable CA2101

using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;
using PiXYZAPI = UnityEngine.Pixyz.API.PiXYZAPI;

namespace UnityEngine.Pixyz.IO {

	public class IOInterface : API.Interface {

		private PiXYZAPI api;
		internal IOInterface(PiXYZAPI api)
		{
			this.api = api;
		}

		#region Types Init/Free Methods

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_LocalDirectoryAccess_init(ref LocalDirectoryAccess_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_LocalDirectoryAccess_free(ref LocalDirectoryAccess_c str);

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
		internal static extern void IO_WebDAVAccess_init(ref WebDAVAccess_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_WebDAVAccess_free(ref WebDAVAccess_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_CloudDirectory_init(ref CloudDirectory_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_CloudDirectory_free(ref CloudDirectory_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_ImportFilePathList_init(ref ImportFilePathList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_ImportFilePathList_free(ref ImportFilePathList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_FilesList_init(ref FilesList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_FilesList_free(ref FilesList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_LocalFileAccess_init(ref LocalFileAccess_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_LocalFileAccess_free(ref LocalFileAccess_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_CloudFile_init(ref CloudFile_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_CloudFile_free(ref CloudFile_c sel);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_FileFormat_init(ref FileFormat_c str);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_FileFormat_free(ref FileFormat_c str);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_VariantNameList_init(ref VariantNameList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_VariantNameList_free(ref VariantNameList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_ExportFilePathList_init(ref ExportFilePathList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_ExportFilePathList_free(ref ExportFilePathList_c list);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_FileFormatList_init(ref FileFormatList_c list, UInt64 size);
		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		internal static extern void IO_FileFormatList_free(ref FileFormatList_c list);

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

	internal static FileFormat ConvertValue(ref FileFormat_c s) {
		FileFormat ss = new FileFormat();
		ss.extension = ConvertValue(s.extension);
		ss.priority = (PriorityImportLevel)s.priority;
		ss.read = ConvertValue(s.read);
		ss.write = ConvertValue(s.write);
		ss.product = ConvertValue(s.product);
		return ss;
	}

	internal static FileFormat_c ConvertValue(FileFormat s, ref FileFormat_c ss) {
		IO.IOInterface.IO_FileFormat_init(ref ss);
		ss.extension = ConvertValue(s.extension);
		ss.priority = (Int32)s.priority;
		ss.read = ConvertValue(s.read);
		ss.write = ConvertValue(s.write);
		ss.product = ConvertValue(s.product);
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

	internal static FileFormatList ConvertValue(ref FileFormatList_c s) {
		FileFormatList list = new FileFormatList((int)s.size);
		if (s.size==0) return list;

		int size = Marshal.SizeOf(typeof(FileFormat_c));

		for (int i = 0; i < (int)s.size; ++i) {
			IntPtr p = new IntPtr(s.ptr.ToInt64() + i * size);
			FileFormat_c value = (FileFormat_c)Marshal.PtrToStructure(p, typeof(FileFormat_c));
			list.list[i] = ConvertValue(ref value);
		}
		return list;
	}

	internal static FileFormatList_c ConvertValue(FileFormatList s, ref FileFormatList_c list) {
		IO.IOInterface.IO_FileFormatList_init(ref list, s == null ? 0 : (System.UInt64)s.length);
		if(list.size == 0) return list;
		for(int i = 0; i < (int)list.size; ++i) {
			FileFormat_c elt = new FileFormat_c();
			ConvertValue(s.list[i], ref elt);
			IntPtr p = new IntPtr(list.ptr.ToInt64() + i * Marshal.SizeOf(typeof(FileFormat_c)));
			Marshal.StructureToPtr(elt, p, true);
		}
		return list;
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
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ConfigureFunctionLogger(System.String functionName, System.Boolean enableFunction, System.Boolean enableParameters, System.Boolean enableExecutionTime) {
			try {
				IO_configureFunctionLogger(api.Session, functionName, Convert.ToByte(enableFunction), Convert.ToByte(enableParameters), Convert.ToByte(enableExecutionTime));
				System.String err = ConvertValue(IO_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region Asset paths

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void IO_addAssetPaths(IntPtr _pxz_session_, Core.StringList_c path);

		/// <summary>
		/// add directory paths to search assets in
		/// </summary>
		/// <param name="path">The paths to add</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void AddAssetPaths(Core.StringList path) {
			try {
				var path_c = new Core.StringList_c();
				Core.CoreInterface.ConvertValue((Core.StringList)path, ref path_c);
				IO_addAssetPaths(api.Session, path_c);
				Core.CoreInterface.Core_StringList_free(ref path_c);
				System.String err = ConvertValue(IO_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void IO_clearAssetPaths(IntPtr _pxz_session_);

		/// <summary>
		/// clear all asset paths
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ClearAssetPaths() {
			try {
				IO_clearAssetPaths(api.Session);
				System.String err = ConvertValue(IO_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern IntPtr IO_findInDirectories(IntPtr _pxz_session_, string filePath);

		/// <summary>
		/// find the final path. This will search for the file in asset paths
		/// </summary>
		/// <param name="filePath">The (relative) file path to search for</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.String FindInDirectories(System.String filePath) {
			try {
				var ret = IO_findInDirectories(api.Session, filePath);
				System.String err = ConvertValue(IO_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return ConvertValue(ret);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.StringList_c IO_getAssetPaths(IntPtr _pxz_session_);

		/// <summary>
		/// get user defined paths to find assets
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Core.StringList GetAssetPaths() {
			try {
				var ret = IO_getAssetPaths(api.Session);
				System.String err = ConvertValue(IO_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Core.CoreInterface.ConvertValue(ref ret);
				Core.CoreInterface.Core_StringList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void IO_setAssetPaths(IntPtr _pxz_session_, Core.StringList_c assetPaths);

		/// <summary>
		/// replace paths to find assets
		/// </summary>
		/// <param name="assetPaths">The asset paths</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SetAssetPaths(Core.StringList assetPaths) {
			try {
				var assetPaths_c = new Core.StringList_c();
				Core.CoreInterface.ConvertValue((Core.StringList)assetPaths, ref assetPaths_c);
				IO_setAssetPaths(api.Session, assetPaths_c);
				Core.CoreInterface.Core_StringList_free(ref assetPaths_c);
				System.String err = ConvertValue(IO_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region Debug

		#endregion

		#region Import/Export

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void IO_applyAutoTessellate(IntPtr _pxz_session_, System.UInt32 part);

		/// <summary>
		/// Handle auto tessellate options on given part, need to be complete
		/// </summary>
		/// <param name="part">Part to be auto tessellated</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ApplyAutoTessellate(System.UInt32 part) {
			try {
				IO_applyAutoTessellate(api.Session, part);
				System.String err = ConvertValue(IO_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void IO_exportScene(IntPtr _pxz_session_, string fileName, System.UInt32 root);

		/// <summary>
		/// Export a file
		/// </summary>
		/// <param name="fileName">Path of the file to export</param>
		/// <param name="root">Identifier of the root occurrence to export</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ExportScene(System.String fileName, System.UInt32 root = 1) {
			try {
				IO_exportScene(api.Session, fileName, root);
				System.String err = ConvertValue(IO_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void IO_exportSelection(IntPtr _pxz_session_, string fileName, System.Byte keepIntermediaryNodes);

		/// <summary>
		/// Export the selection to a file
		/// </summary>
		/// <param name="fileName">Path of the file to export</param>
		/// <param name="keepIntermediaryNodes">If true, intermerdiary hierarchy is kept</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void ExportSelection(System.String fileName, System.Boolean keepIntermediaryNodes = false) {
			try {
				IO_exportSelection(api.Session, fileName, Convert.ToByte(keepIntermediaryNodes));
				System.String err = ConvertValue(IO_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.FormatList_c IO_getExportFormats(IntPtr _pxz_session_);

		/// <summary>
		/// Give all the format name and their extensions that can be exported in Pixyz
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Core.FormatList GetExportFormats() {
			try {
				var ret = IO_getExportFormats(api.Session);
				System.String err = ConvertValue(IO_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Core.CoreInterface.ConvertValue(ref ret);
				Core.CoreInterface.Core_FormatList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Core.FormatList_c IO_getImportFormats(IntPtr _pxz_session_);

		/// <summary>
		/// Give all the format name and their extensions that can be imported in Pixyz
		/// </summary>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Core.FormatList GetImportFormats() {
			try {
				var ret = IO_getImportFormats(api.Session);
				System.String err = ConvertValue(IO_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = Core.CoreInterface.ConvertValue(ref ret);
				Core.CoreInterface.Core_FormatList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Scene.OccurrenceList_c IO_importFiles(IntPtr _pxz_session_, FilesList_c fileNames, System.UInt32 root);

		/// <summary>
		/// Import files
		/// </summary>
		/// <param name="fileNames">List of files's paths to import</param>
		/// <param name="root">Identifier of the destination occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public Scene.OccurrenceList ImportFiles(FilesList fileNames, System.UInt32 root = 0) {
			try {
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
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 IO_importPicture(IntPtr _pxz_session_, string filename, System.UInt32 root);

		/// <summary>
		/// Imports a picture and applies is at as a texture on a 3D plane created in the scene.
		/// </summary>
		/// <param name="filename">Path of the file to import</param>
		/// <param name="root">Identifier of the destination occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 ImportPicture(System.String filename, System.UInt32 root = 0) {
			try {
				var ret = IO_importPicture(api.Session, filename, root);
				System.String err = ConvertValue(IO_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.UInt32)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 IO_importRemote3mxFile(IntPtr _pxz_session_, string filePath, string origin, System.UInt32 root);

		/// <summary>
		/// Import a remote 3mx file
		/// </summary>
		/// <param name="filePath">The path of the temp file</param>
		/// <param name="origin">Remote origin of the file</param>
		/// <param name="root">Identifier of the destination occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 ImportRemote3mxFile(System.String filePath, System.String origin = "", System.UInt32 root = 0) {
			try {
				var ret = IO_importRemote3mxFile(api.Session, filePath, origin, root);
				System.String err = ConvertValue(IO_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.UInt32)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern System.UInt32 IO_importScene(IntPtr _pxz_session_, string fileName, System.UInt32 root);

		/// <summary>
		/// Import a file
		/// </summary>
		/// <param name="fileName">Path of the file to import</param>
		/// <param name="root">Identifier of the destination occurrence</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public System.UInt32 ImportScene(System.String fileName, System.UInt32 root = 0) {
			try {
				var ret = IO_importScene(api.Session, fileName, root);
				System.String err = ConvertValue(IO_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (System.UInt32)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern VariantNameList_c IO_listVariants(IntPtr _pxz_session_, string fileName);

		/// <summary>
		/// List all variants if file
		/// </summary>
		/// <param name="fileName">Path of the file to import</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public VariantNameList ListVariants(System.String fileName) {
			try {
				var ret = IO_listVariants(api.Session, fileName);
				System.String err = ConvertValue(IO_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				var convRet = ConvertValue(ref ret);
				IO.IOInterface.IO_VariantNameList_free(ref ret);
				return convRet;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void IO_loadReferencedData(IntPtr _pxz_session_, System.UInt32 component, System.Byte recursively);

		/// <summary>
		/// Load partial model
		/// </summary>
		/// <param name="component">The component to load</param>
		/// <param name="recursively">Load it recursively or not</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void LoadReferencedData(System.UInt32 component, System.Boolean recursively) {
			try {
				IO_loadReferencedData(api.Session, component, Convert.ToByte(recursively));
				System.String err = ConvertValue(IO_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void IO_unloadReferencedData(IntPtr _pxz_session_, System.UInt32 component);

		/// <summary>
		/// Unload partial model
		/// </summary>
		/// <param name="component">The component to unload</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void UnloadReferencedData(System.UInt32 component) {
			try {
				IO_unloadReferencedData(api.Session, component);
				System.String err = ConvertValue(IO_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region ImportCallbacks

		// C# delegate
		public delegate void importFileCallback(System.String filename, System.UInt32 rootOccurrence);

		// C delegate
		internal delegate void importFileCallback_c(System.String filename, System.UInt32 rootOccurrence);

		// C# delegate
		public delegate void exportFileCallback(System.UInt32 rootOccurrence, System.String filename);

		// C delegate
		internal delegate void exportFileCallback_c(System.UInt32 rootOccurrence, System.String filename);

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern void IO_registerIOCallbacks(IntPtr _pxz_session_, string name, importFileCallback_c importCallback, exportFileCallback_c exportCallback, FileFormatList_c fileFormats);

		private static void importFileCallback_CS(string filename, System.UInt32 rootOccurrence, importFileCallback callback) {
			callback((System.String)(filename), (System.UInt32)(rootOccurrence));
		}

		private static void exportFileCallback_CS(System.UInt32 rootOccurrence, string filename, exportFileCallback callback) {
			callback((System.UInt32)(rootOccurrence), (System.String)(filename));
		}

		/// <summary>
		/// Register import and export callbacks
		/// </summary>
		/// <param name="name">Callback name</param>
		/// <param name="importCallback">Callback that import a file</param>
		/// <param name="exportCallback">Callback that exports to a file</param>
		/// <param name="fileFormats">Gives the extension and parameters to Import/Export</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void RegisterIOCallbacks(System.String name, importFileCallback importCallback, exportFileCallback exportCallback, FileFormatList fileFormats) {
			try {
				var fileFormats_c = new IO.FileFormatList_c();
				ConvertValue((IO.FileFormatList)fileFormats, ref fileFormats_c);
				IO_registerIOCallbacks(api.Session, name, (filename, rootOccurrence) => { 
				importFileCallback_CS(filename, rootOccurrence, importCallback);
			}, (rootOccurrence, filename) => { 
				exportFileCallback_CS(rootOccurrence, filename, exportCallback);
			}, fileFormats_c);
				IO.IOInterface.IO_FileFormatList_free(ref fileFormats_c);
				System.String err = ConvertValue(IO_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
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
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public void SplitPointCloud(Core.FilePathList files, System.String outputDirectory, System.Double minVoxSize, System.Boolean useKDTree, Geom.AABB aabb = null, System.Double density = -1) {
			aabb = aabb ?? new Geom.AABB() {};
			try {
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
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

		#region Priorities

		[DllImport(PiXYZAPI.PiXYZAPI_dll)]
		private static extern Int32 IO_getExtensionPriority(IntPtr _pxz_session_, string extensionName);

		/// <summary>
		/// get the priority of an extension from the pixyz importer
		/// </summary>
		/// <param name="extensionName">The name of the extension</param>
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		public PriorityImportLevel GetExtensionPriority(System.String extensionName) {
			try {
				var ret = IO_getExtensionPriority(api.Session, extensionName);
				System.String err = ConvertValue(IO_getLastError());
				if(!System.String.IsNullOrEmpty(err))
					throw new Exception(err);
				return (PriorityImportLevel)ret;
			}
			catch (System.AccessViolationException e) {
				api.Release();
				throw e;
			}
		}

		#endregion

	}
}
