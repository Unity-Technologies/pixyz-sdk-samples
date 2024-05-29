// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_IO_INTERFACE_IOTYPES_C_H_
#define _PXZ_IO_INTERFACE_IOTYPES_C_H_

#include <string.h>
#include <PiXYZCore/interface/InterfaceBase_c.h>
#include <PiXYZCore/interface/CoreTypes_c.h>
#include <PiXYZScene/interface/SceneTypes_c.h>


typedef struct {
   Core_DirectoryPath path;
} IO_LocalDirectoryAccess;

PXZ_EXPORTED void IO_LocalDirectoryAccess_init(IO_LocalDirectoryAccess * str);
PXZ_EXPORTED void IO_LocalDirectoryAccess_free(IO_LocalDirectoryAccess * str);
typedef struct {
   Core_String path;
   Core_String authUrl;
   Core_String region;
   Core_String user;
   Core_Password password;
   Core_String domainId;
   Core_String projectId;
   Core_String container;
   Core_String objectStore;
} IO_OpenStackAccess;

PXZ_EXPORTED void IO_OpenStackAccess_init(IO_OpenStackAccess * str);
PXZ_EXPORTED void IO_OpenStackAccess_free(IO_OpenStackAccess * str);
typedef struct {
   Core_String path;
   Core_String token;
} IO_DropBoxAccess;

PXZ_EXPORTED void IO_DropBoxAccess_init(IO_DropBoxAccess * str);
PXZ_EXPORTED void IO_DropBoxAccess_free(IO_DropBoxAccess * str);
typedef struct {
   Core_String path;
   Core_String authUrl;
   Core_String user;
   Core_Password password;
} IO_OwnCloudAccess;

PXZ_EXPORTED void IO_OwnCloudAccess_init(IO_OwnCloudAccess * str);
PXZ_EXPORTED void IO_OwnCloudAccess_free(IO_OwnCloudAccess * str);
typedef enum {
 IO_Protocol_HTTP = 1,
 IO_Protocol_HTTPS = 2,
} IO_Protocol;

typedef struct {
   Core_String path;
   Core_String host;
   Core_UShort port;
   IO_Protocol protocol;
   Core_String user;
   Core_Password password;
   Core_String url;
} IO_WebDAVAccess;

PXZ_EXPORTED void IO_WebDAVAccess_init(IO_WebDAVAccess * str);
PXZ_EXPORTED void IO_WebDAVAccess_free(IO_WebDAVAccess * str);
struct IO_CloudDirectory {
   IO_LocalDirectoryAccess local;
   IO_OpenStackAccess openStack;
   IO_DropBoxAccess dropBox;
   IO_OwnCloudAccess ownCloud;
   IO_WebDAVAccess webDAV;
   typedef enum {
      UNKNOWN=0,
      LOCAL,
      OPENSTACK,
      DROPBOX,
      OWNCLOUD,
      WEBDAV
   } Type;

   Type _type; 
};

PXZ_EXPORTED void IO_CloudDirectory_init(IO_CloudDirectory * sel);
PXZ_EXPORTED void IO_CloudDirectory_free(IO_CloudDirectory * sel);

typedef struct {
   Core_FilePath path;
} IO_LocalFileAccess;

PXZ_EXPORTED void IO_LocalFileAccess_init(IO_LocalFileAccess * str);
PXZ_EXPORTED void IO_LocalFileAccess_free(IO_LocalFileAccess * str);
struct IO_CloudFile {
   IO_LocalFileAccess local;
   IO_OpenStackAccess openStack;
   IO_DropBoxAccess dropBox;
   IO_OwnCloudAccess ownCloud;
   IO_WebDAVAccess webDAV;
   typedef enum {
      UNKNOWN=0,
      LOCAL,
      OPENSTACK,
      DROPBOX,
      OWNCLOUD,
      WEBDAV
   } Type;

   Type _type; 
};

PXZ_EXPORTED void IO_CloudFile_init(IO_CloudFile * sel);
PXZ_EXPORTED void IO_CloudFile_free(IO_CloudFile * sel);

typedef Core_OutputFilePath IO_ExportFilePath;

typedef struct {
   size_t size;
   IO_ExportFilePath * list;
} IO_ExportFilePathList;

PXZ_EXPORTED void IO_ExportFilePathList_init(IO_ExportFilePathList * list, size_t size = 0);
PXZ_EXPORTED void IO_ExportFilePathList_free(IO_ExportFilePathList * list);
typedef struct {
   size_t size;
   Core_FilePath * list;
} IO_FilesList;

PXZ_EXPORTED void IO_FilesList_init(IO_FilesList * list, size_t size = 0);
PXZ_EXPORTED void IO_FilesList_free(IO_FilesList * list);
typedef Core_FilePath IO_ImportFilePath;

typedef struct {
   size_t size;
   IO_ImportFilePath * list;
} IO_ImportFilePathList;

PXZ_EXPORTED void IO_ImportFilePathList_init(IO_ImportFilePathList * list, size_t size = 0);
PXZ_EXPORTED void IO_ImportFilePathList_free(IO_ImportFilePathList * list);
typedef struct {
   size_t size;
   Core_String * list;
} IO_VariantNameList;

PXZ_EXPORTED void IO_VariantNameList_init(IO_VariantNameList * list, size_t size = 0);
PXZ_EXPORTED void IO_VariantNameList_free(IO_VariantNameList * list);
typedef void (*IO_importFileCallback)(Core_FilePath filename, Scene_Occurrence rootOccurrence);



#endif
