// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_UNITY_INTERFACE_UNITYTYPES_C_H_
#define _PXZ_UNITY_INTERFACE_UNITYTYPES_C_H_

#include <string.h>
#include <PiXYZCore/interface/InterfaceBase_c.h>
#include <PiXYZCore/interface/CoreTypes_c.h>
#include <PiXYZView/interface/ViewTypes_c.h>


typedef Core_Ptr Unity_ID3D11Device;

typedef Core_Ptr Unity_ID3D11RenderTargetView;

typedef Core_Ptr Unity_ID3D11Resource;

typedef Core_Ptr Unity_ID3D11ShaderResourceView;

typedef struct {
   Scene_OccurrenceList occurrences;
   Geom_Point3List positions;
} Unity_PickResult;

PXZ_EXPORTED void Unity_PickResult_init(Unity_PickResult * str);
PXZ_EXPORTED void Unity_PickResult_free(Unity_PickResult * str);
typedef Core_Ptr Unity_UnityRenderBuffer;

typedef Core_Ptr Unity_UnityRenderingEvent;

typedef Core_Ptr Unity_UnityRenderingEventAndData;

typedef Core_UInt Unity_UnityTextureID;

typedef Core_Ident Unity_UnityViewSession;

typedef Core_Ptr Unity_VulkanDevice;



#endif
