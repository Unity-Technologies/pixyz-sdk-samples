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
   LocalDirectoryAccess(CoreI::DirectoryPath _path = "") : path(_path) {}
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
   OpenStackAccess(CoreI::String _path = "", CoreI::String _authUrl = "", CoreI::String _region = "", CoreI::String _user = "", CoreI::Password _password = "", CoreI::String _domainId = "", CoreI::String _projectId = "", CoreI::String _container = "", CoreI::String _objectStore = "swift") : path(_path), authUrl(_authUrl), region(_region), user(_user), password(_password), domainId(_domainId), projectId(_projectId), container(_container), objectStore(_objectStore) {}
};

struct DropBoxAccess {
   CoreI::String path;
   CoreI::String token;
   DropBoxAccess(CoreI::String _path = "", CoreI::String _token = "") : path(_path), token(_token) {}
};

struct OwnCloudAccess {
   CoreI::String path;
   CoreI::String authUrl;
   CoreI::String user;
   CoreI::Password password;
   OwnCloudAccess(CoreI::String _path = "", CoreI::String _authUrl = "", CoreI::String _user = "", CoreI::Password _password = "") : path(_path), authUrl(_authUrl), user(_user), password(_password) {}
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
   WebDAVAccess(CoreI::String _path = "", CoreI::String _host = "", CoreI::UShort _port = 0, Protocol _protocol = Protocol::HTTP, CoreI::String _user = "", CoreI::Password _password = "", CoreI::String _url = "") : path(_path), host(_host), port(_port), protocol(_protocol), user(_user), password(_password), url(_url) {}
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
   LocalFileAccess(CoreI::FilePath _path = "") : path(_path) {}
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

typedef CoreI::List<CoreI::FilePath> FilesList;

typedef CoreI::FilePath ImportFilePath;

typedef CoreI::List<ImportFilePath> ImportFilePathList;

typedef CoreI::List<CoreI::String> VariantNameList;

typedef std::function<void(const CoreI::FilePath & filename, const SceneI::Occurrence & rootOccurrence)> importFileCallback;


PXZ_MODULE_END

#endif
