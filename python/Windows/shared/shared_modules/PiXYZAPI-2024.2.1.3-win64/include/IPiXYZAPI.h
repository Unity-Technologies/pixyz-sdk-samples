#ifndef _PXZ_IPiXYZAPI_H_
#define _PXZ_IPiXYZAPI_H_

#include <PiXYZCore/interface/ICoreInterface.h>
#include <PiXYZGeom/interface/IGeomInterface.h>
#include <PiXYZMaterial/interface/IMaterialInterface.h>
#include <PiXYZPolygonal/interface/IPolygonalInterface.h>
#include <PiXYZCAD/interface/ICADInterface.h>
#ifdef CLOUD_MODULE
#include <PiXYZCloud/interface/ICloudInterface.h>
#endif
#include <PiXYZAlgo/interface/IAlgoInterface.h>
#include <PiXYZScene/interface/ISceneInterface.h>
#include <PiXYZRaytrace/interface/IRaytraceInterface.h>
#include <PiXYZView/interface/IViewInterface.h>
#include <PiXYZUnity/interface/IUnityInterface.h>
#include <PiXYZIO/interface/IIOInterface.h>

PXZ_NS_BEGIN

class PXZ_EXPORTED IPiXYZAPI
{
protected:
   virtual ~IPiXYZAPI() {}

public:
   virtual CoreI::ICoreInterface* Core() = 0;
   virtual GeomI::IGeomInterface* Geom() = 0;
   virtual MaterialI::IMaterialInterface* Material() = 0;
   virtual PolygonalI::IPolygonalInterface* Polygonal() = 0;
   virtual CADI::ICADInterface* CAD() = 0;
#ifdef CLOUD_MODULE
   virtual CloudI::ICloudInterface* Cloud() = 0;
#endif
   virtual AlgoI::IAlgoInterface* Algo() = 0;
   virtual SceneI::ISceneInterface* Scene() = 0;
   virtual RaytraceI::IRaytraceInterface* Raytrace() = 0;
   virtual ViewI::IViewInterface* View() = 0;
   virtual IOI::IIOInterface* IO() = 0;
   virtual UnityI::IUnityInterface* Unity() = 0;
};

PXZ_NS_END

#endif
