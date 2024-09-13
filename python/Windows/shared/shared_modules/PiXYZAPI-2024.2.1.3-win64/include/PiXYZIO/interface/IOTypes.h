// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_IO_INTERFACE_IOTYPES_H_
#define _PXZ_IO_INTERFACE_IOTYPES_H_

#include <PiXYZCore/interface/InterfaceBase.h>
#include <PiXYZCore/interface/CoreTypes.h>
#include <PiXYZScene/interface/SceneTypes.h>
#include <functional> 

PXZ_MODULE_BEGIN(IOI)

struct LocalDirectoryAccess {
   CoreI::DirectoryPath path;
   explicit LocalDirectoryAccess(CoreI::DirectoryPath _path = "") : path(_path) {}
};

struct OpenStackAccess {
   CoreI::String path;
   CoreI::String authUrl;
   CoreI::String region;
   CoreI::String user;
   CoreI::Password password;
   CoreI::String domainId;
   CoreI::String projectId;
   CoreI::String container;
   CoreI::String objectStore;
   explicit OpenStackAccess(CoreI::String _path = "", CoreI::String _authUrl = "", CoreI::String _region = "", CoreI::String _user = "", CoreI::Password _password = "", CoreI::String _domainId = "", CoreI::String _projectId = "", CoreI::String _container = "", CoreI::String _objectStore = "swift") : path(_path), authUrl(_authUrl), region(_region), user(_user), password(_password), domainId(_domainId), projectId(_projectId), container(_container), objectStore(_objectStore) {}
};

struct DropBoxAccess {
   CoreI::String path;
   CoreI::String token;
   explicit DropBoxAccess(CoreI::String _path = "", CoreI::String _token = "") : path(_path), token(_token) {}
};

struct OwnCloudAccess {
   CoreI::String path;
   CoreI::String authUrl;
   CoreI::String user;
   CoreI::Password password;
   explicit OwnCloudAccess(CoreI::String _path = "", CoreI::String _authUrl = "", CoreI::String _user = "", CoreI::Password _password = "") : path(_path), authUrl(_authUrl), user(_user), password(_password) {}
};

class Protocol {
public:
   typedef enum {
   HTTP = 1,
   HTTPS = 2
   } Type;
private:
   Type _value;
public:
   Protocol(Type val = HTTP) : _value(val) {}
   Protocol & operator=(Type val) { _value = val; return *this; }
   Protocol(const CoreI::Int& val) : _value((Type)val) {}
   Protocol & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct WebDAVAccess {
   CoreI::String path;
   CoreI::String host;
   CoreI::UShort port;
   Protocol protocol;
   CoreI::String user;
   CoreI::Password password;
   CoreI::String url;
   explicit WebDAVAccess(CoreI::String _path = "", CoreI::String _host = "", CoreI::UShort _port = 0, Protocol _protocol = Protocol::HTTP, CoreI::String _user = "", CoreI::Password _password = "", CoreI::String _url = "") : path(_path), host(_host), port(_port), protocol(_protocol), user(_user), password(_password), url(_url) {}
};

struct CloudDirectory {
   typedef enum {
      UNKNOWN=0,
      LOCAL,
      OPENSTACK,
      DROPBOX,
      OWNCLOUD,
      WEBDAV
   } Type;
   Type _type; 
   LocalDirectoryAccess local;
   OpenStackAccess openStack;
   DropBoxAccess dropBox;
   OwnCloudAccess ownCloud;
   WebDAVAccess webDAV;
   CloudDirectory() : _type(UNKNOWN) {}
   CloudDirectory(const LocalDirectoryAccess & v) : _type(LOCAL), local(v) {}
   CloudDirectory(const OpenStackAccess & v) : _type(OPENSTACK), openStack(v) {}
   CloudDirectory(const DropBoxAccess & v) : _type(DROPBOX), dropBox(v) {}
   CloudDirectory(const OwnCloudAccess & v) : _type(OWNCLOUD), ownCloud(v) {}
   CloudDirectory(const WebDAVAccess & v) : _type(WEBDAV), webDAV(v) {}
};
struct LocalFileAccess {
   CoreI::FilePath path;
   explicit LocalFileAccess(CoreI::FilePath _path = "") : path(_path) {}
};

struct CloudFile {
   typedef enum {
      UNKNOWN=0,
      LOCAL,
      OPENSTACK,
      DROPBOX,
      OWNCLOUD,
      WEBDAV
   } Type;
   Type _type; 
   LocalFileAccess local;
   OpenStackAccess openStack;
   DropBoxAccess dropBox;
   OwnCloudAccess ownCloud;
   WebDAVAccess webDAV;
   CloudFile() : _type(UNKNOWN) {}
   CloudFile(const LocalFileAccess & v) : _type(LOCAL), local(v) {}
   CloudFile(const OpenStackAccess & v) : _type(OPENSTACK), openStack(v) {}
   CloudFile(const DropBoxAccess & v) : _type(DROPBOX), dropBox(v) {}
   CloudFile(const OwnCloudAccess & v) : _type(OWNCLOUD), ownCloud(v) {}
   CloudFile(const WebDAVAccess & v) : _type(WEBDAV), webDAV(v) {}
};
typedef CoreI::OutputFilePath ExportFilePath;

typedef CoreI::List<ExportFilePath> ExportFilePathList;

class PriorityImportLevel {
public:
   typedef enum {
   unavailable = 0,
   Priority_1 = 1,
   Priority_2 = 2,
   Priority_3 = 3,
   Priority_4 = 4,
   Priority_5 = 5,
   Priority_6 = 6,
   Priority_7 = 7,
   Priority_8 = 8,
   Priority_9 = 9,
   Priority_10 = 10
   } Type;
private:
   Type _value;
public:
   PriorityImportLevel(Type val = unavailable) : _value(val) {}
   PriorityImportLevel & operator=(Type val) { _value = val; return *this; }
   PriorityImportLevel(const CoreI::Int& val) : _value((Type)val) {}
   PriorityImportLevel & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct FileFormat {
   CoreI::String extension;
   PriorityImportLevel priority;
   CoreI::Boolean read;
   CoreI::Boolean write;
   CoreI::String product;
   explicit FileFormat(CoreI::String _extension = "", PriorityImportLevel _priority = PriorityImportLevel::Priority_1, CoreI::Boolean _read = false, CoreI::Boolean _write = false, CoreI::String _product = "") : extension(_extension), priority(_priority), read(_read), write(_write), product(_product) {}
};

typedef CoreI::List<FileFormat> FileFormatList;

typedef CoreI::List<CoreI::FilePath> FilesList;

typedef CoreI::FilePath ImportFilePath;

typedef CoreI::List<ImportFilePath> ImportFilePathList;

typedef CoreI::List<CoreI::String> VariantNameList;

typedef std::function<void(const SceneI::Occurrence & rootOccurrence, const CoreI::FilePath & filename)> exportFileCallback;

typedef std::function<void(const CoreI::FilePath & filename, const SceneI::Occurrence & rootOccurrence)> importFileCallback;


PXZ_MODULE_END

#endif
