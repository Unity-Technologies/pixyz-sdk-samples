// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_UNITY_INTERFACE_UNITYTYPES_H_
#define _PXZ_UNITY_INTERFACE_UNITYTYPES_H_

#include <PiXYZCore/interface/InterfaceBase.h>
#include <PiXYZCore/interface/CoreTypes.h>
#include <PiXYZView/interface/ViewTypes.h>
#include <functional> 

PXZ_MODULE_BEGIN(UnityI)

typedef CoreI::Ptr ID3D11Device;

typedef CoreI::Ptr ID3D11RenderTargetView;

typedef CoreI::Ptr ID3D11Resource;

typedef CoreI::Ptr ID3D11ShaderResourceView;

struct PickResult {
   SceneI::OccurrenceList occurrences;
   GeomI::Point3List positions;
   PickResult(SceneI::OccurrenceList _occurrences = SceneI::OccurrenceList(), GeomI::Point3List _positions = GeomI::Point3List()) : occurrences(_occurrences), positions(_positions) {}
};

typedef CoreI::Ptr UnityRenderBuffer;

typedef CoreI::Ptr UnityRenderingEvent;

typedef CoreI::Ptr UnityRenderingEventAndData;

typedef CoreI::UInt UnityTextureID;

typedef CoreI::Ident UnityViewSession;

typedef CoreI::Ptr VulkanDevice;


PXZ_MODULE_END

#endif
