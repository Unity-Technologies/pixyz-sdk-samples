// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_VIEW_INTERFACE_VIEWTYPES_H_
#define _PXZ_VIEW_INTERFACE_VIEWTYPES_H_

#include <PiXYZCore/interface/InterfaceBase.h>
#include <PiXYZCore/interface/CoreTypes.h>
#include <PiXYZGeom/interface/GeomTypes.h>
#include <PiXYZScene/interface/SceneTypes.h>
#include <functional> 

PXZ_MODULE_BEGIN(ViewI)

struct AnimationPlayerInfo {
   CoreI::Bool isPlaying;
   CoreI::Bool isLooping;
   SceneI::AnimationTime currentFrame;
   CoreI::Double speed;
   explicit AnimationPlayerInfo(CoreI::Bool _isPlaying = false, CoreI::Bool _isLooping = false, SceneI::AnimationTime _currentFrame = 0, CoreI::Double _speed = 0.) : isPlaying(_isPlaying), isLooping(_isLooping), currentFrame(_currentFrame), speed(_speed) {}
};

class CameraType {
public:
   typedef enum {
   Perspective = 0,
   Orthographic = 1
   } Type;
private:
   Type _value;
public:
   CameraType(Type val = Perspective) : _value(val) {}
   CameraType & operator=(Type val) { _value = val; return *this; }
   CameraType(const CoreI::Int& val) : _value((Type)val) {}
   CameraType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
typedef CoreI::Ptr D3D11Texture;

class RateControl {
public:
   typedef enum {
   CONSTQP = 0,
   CBR = 1,
   VBR = 2
   } Type;
private:
   Type _value;
public:
   RateControl(Type val = CONSTQP) : _value(val) {}
   RateControl & operator=(Type val) { _value = val; return *this; }
   RateControl(const CoreI::Int& val) : _value((Type)val) {}
   RateControl & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct QP {
   //! Specifies QP value for P-frame.
   CoreI::UInt qpInterP;
   //! Specifies QP value for B-frame.
   CoreI::UInt qpInterB;
   //! Specifies QP value Intra Frame.
   CoreI::UInt qpIntra;
   explicit QP(CoreI::UInt _qpInterP = 28, CoreI::UInt _qpInterB = 31, CoreI::UInt _qpIntra = 25) : qpInterP(_qpInterP), qpInterB(_qpInterB), qpIntra(_qpIntra) {}
};

struct EncoderSettings {
   //! Specifies the frame rate used for encoding in frames per second.
   CoreI::UInt frameRate;
   //! Specifies the average bitrate(in bits/sec) used for encoding.
   CoreI::UInt averageBitRate;
   //! Specifies the maximum bitrate for the encoded output. This is used for VBR and ignored for CBR mode.
   CoreI::UInt maxBitRate;
   //! Specifies the rate control mode. (Constant QP Mode, Constant bitrate mode, Variable bitrate mode.
   RateControl rateControl;
   //! Specifies the initial QP to be used for encoding, these values would be used for all frames if in Constant QP mode.
   QP qp;
   //! Target CQ (Constant Quality) level for VBR mode (range 0-51 with 0-automatic).
   CoreI::UInt targetQuality;
   explicit EncoderSettings(CoreI::UInt _frameRate = 30, CoreI::UInt _averageBitRate = 2500000, CoreI::UInt _maxBitRate = 2500000, RateControl _rateControl = RateControl::CONSTQP, QP _qp = QP(), CoreI::UInt _targetQuality = 0) : frameRate(_frameRate), averageBitRate(_averageBitRate), maxBitRate(_maxBitRate), rateControl(_rateControl), qp(_qp), targetQuality(_targetQuality) {}
};

typedef CoreI::Int GLTextureHandle;

typedef CoreI::Int GPUScene;

typedef CoreI::List<GPUScene> GPUSceneList;

class GraphicAPI {
public:
   typedef enum {
   None = 0,
   OpenGL = 1,
   D3D11 = 2,
   Vulkan = 3
   } Type;
private:
   Type _value;
public:
   GraphicAPI(Type val = None) : _value(val) {}
   GraphicAPI & operator=(Type val) { _value = val; return *this; }
   GraphicAPI(const CoreI::Int& val) : _value((Type)val) {}
   GraphicAPI & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
struct GraphicsContext {
   GraphicAPI api;
   CoreI::Ptr context;
   explicit GraphicsContext(GraphicAPI _api = GraphicAPI::None, CoreI::Ptr _context = nullptr) : api(_api), context(_context) {}
};

class PrimitiveSelectionType {
public:
   typedef enum {
   Polygon = 0,
   Patch = 1,
   ConnectedMesh = 2
   } Type;
private:
   Type _value;
public:
   PrimitiveSelectionType(Type val = Polygon) : _value(val) {}
   PrimitiveSelectionType & operator=(Type val) { _value = val; return *this; }
   PrimitiveSelectionType(const CoreI::Int& val) : _value((Type)val) {}
   PrimitiveSelectionType & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
class RenderMap {
public:
   typedef enum {
   Composited = 0,
   AlbedoOpacity = 1,
   Normal = 2,
   Depth = 3,
   MetallicRoughnessAOMisc = 4,
   Emissive = 5,
   ObjectIdPrimitiveId = 6,
   UVs = 7,
   SSAO = 8
   } Type;
private:
   Type _value;
public:
   RenderMap(Type val = Composited) : _value(val) {}
   RenderMap & operator=(Type val) { _value = val; return *this; }
   RenderMap(const CoreI::Int& val) : _value((Type)val) {}
   RenderMap & operator=(const CoreI::Int& val) { _value = (Type)val; return *this; }
   Type value() const { return _value; }
   operator Type() const { return _value; }
};
typedef CoreI::Int Viewer;

struct StreamedViewerInfo {
   CoreI::String host;
   CoreI::Short port;
   Viewer viewer;
   explicit StreamedViewerInfo(CoreI::String _host = "", CoreI::Short _port = 0, Viewer _viewer = -1) : host(_host), port(_port), viewer(_viewer) {}
};

typedef CoreI::Ptr VulkanTexture;

struct WebRTCInfo {
   CoreI::String signalingUrl;
   CoreI::String stunServer;
   CoreI::UShort udpPortRangeBegin;
   CoreI::UShort udpPortRangeEnd;
   explicit WebRTCInfo(CoreI::String _signalingUrl = "127.0.0.1:8090", CoreI::String _stunServer = "stun:stun.l.google.com:19302", CoreI::UShort _udpPortRangeBegin = 1024, CoreI::UShort _udpPortRangeEnd = 65535) : signalingUrl(_signalingUrl), stunServer(_stunServer), udpPortRangeBegin(_udpPortRangeBegin), udpPortRangeEnd(_udpPortRangeEnd) {}
};

typedef struct {
   CoreI::Int width;
   CoreI::Int height;
} getViewerSizeReturn;

typedef struct {
   CoreI::Int renderedOccurrences;
   CoreI::Int renderedTriangles;
} getViewerStatsReturn;

typedef struct {
   SceneI::Occurrence occurrence;
   GeomI::Point3 position;
   CoreI::Ident primitiveId;
} pickReturn;

typedef struct {
   GeomI::Matrix4List views;
   GeomI::Matrix4List projs;
   GeomI::Vector2 clipping;
} getViewerMatricesReturn;


PXZ_MODULE_END

#endif
