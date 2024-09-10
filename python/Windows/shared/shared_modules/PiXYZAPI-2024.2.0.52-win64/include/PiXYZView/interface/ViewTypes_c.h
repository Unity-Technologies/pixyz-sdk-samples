// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_VIEW_INTERFACE_VIEWTYPES_C_H_
#define _PXZ_VIEW_INTERFACE_VIEWTYPES_C_H_

#include <string.h>
#include <PiXYZCore/interface/InterfaceBase_c.h>
#include <PiXYZCore/interface/CoreTypes_c.h>
#include <PiXYZGeom/interface/GeomTypes_c.h>
#include <PiXYZScene/interface/SceneTypes_c.h>


typedef struct {
   Core_Bool isPlaying;
   Core_Bool isLooping;
   Scene_AnimationTime currentFrame;
   Core_Double speed;
} View_AnimationPlayerInfo;

PXZ_EXPORTED void View_AnimationPlayerInfo_init(View_AnimationPlayerInfo * str);
PXZ_EXPORTED void View_AnimationPlayerInfo_free(View_AnimationPlayerInfo * str);
typedef enum {
 View_CameraType_Perspective = 0,
 View_CameraType_Orthographic = 1,
} View_CameraType;

typedef Core_Ptr View_D3D11Texture;

typedef enum {
 View_RateControl_CONSTQP = 0,
 View_RateControl_CBR = 1,
 View_RateControl_VBR = 2,
} View_RateControl;

typedef struct {
   Core_UInt qpInterP;
   Core_UInt qpInterB;
   Core_UInt qpIntra;
} View_QP;

PXZ_EXPORTED void View_QP_init(View_QP * str);
PXZ_EXPORTED void View_QP_free(View_QP * str);
typedef struct {
   Core_UInt frameRate;
   Core_UInt averageBitRate;
   Core_UInt maxBitRate;
   View_RateControl rateControl;
   View_QP qp;
   Core_UInt targetQuality;
} View_EncoderSettings;

PXZ_EXPORTED void View_EncoderSettings_init(View_EncoderSettings * str);
PXZ_EXPORTED void View_EncoderSettings_free(View_EncoderSettings * str);
typedef Core_Int View_GLTextureHandle;

typedef Core_Int View_GPUScene;

typedef struct {
   size_t size;
   View_GPUScene * list;
} View_GPUSceneList;

PXZ_EXPORTED void View_GPUSceneList_init(View_GPUSceneList * list, size_t size = 0);
PXZ_EXPORTED void View_GPUSceneList_free(View_GPUSceneList * list);
typedef enum {
 View_GraphicAPI_None = 0,
 View_GraphicAPI_OpenGL = 1,
 View_GraphicAPI_D3D11 = 2,
 View_GraphicAPI_Vulkan = 3,
} View_GraphicAPI;

typedef struct {
   View_GraphicAPI api;
   Core_Ptr context;
} View_GraphicsContext;

PXZ_EXPORTED void View_GraphicsContext_init(View_GraphicsContext * str);
PXZ_EXPORTED void View_GraphicsContext_free(View_GraphicsContext * str);
typedef enum {
 View_PrimitiveSelectionType_Polygon = 0,
 View_PrimitiveSelectionType_Patch = 1,
 View_PrimitiveSelectionType_ConnectedMesh = 2,
} View_PrimitiveSelectionType;

typedef enum {
 View_RenderMap_Composited = 0,
 View_RenderMap_AlbedoOpacity = 1,
 View_RenderMap_Normal = 2,
 View_RenderMap_Depth = 3,
 View_RenderMap_MetallicRoughnessAOMisc = 4,
 View_RenderMap_Emissive = 5,
 View_RenderMap_ObjectIdPrimitiveId = 6,
 View_RenderMap_UVs = 7,
 View_RenderMap_SSAO = 8,
} View_RenderMap;

typedef Core_Int View_Viewer;

typedef struct {
   Core_String host;
   Core_Short port;
   View_Viewer viewer;
} View_StreamedViewerInfo;

PXZ_EXPORTED void View_StreamedViewerInfo_init(View_StreamedViewerInfo * str);
PXZ_EXPORTED void View_StreamedViewerInfo_free(View_StreamedViewerInfo * str);
typedef Core_Ptr View_VulkanTexture;

typedef struct {
   Core_String signalingUrl;
   Core_String stunServer;
   Core_UShort udpPortRangeBegin;
   Core_UShort udpPortRangeEnd;
} View_WebRTCInfo;

PXZ_EXPORTED void View_WebRTCInfo_init(View_WebRTCInfo * str);
PXZ_EXPORTED void View_WebRTCInfo_free(View_WebRTCInfo * str);


#endif
