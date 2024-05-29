#ifndef _PXZ_PiXYZAPI_H_
#define _PXZ_PiXYZAPI_H_

#include "IPiXYZAPI.h"
#include <PiXYZCore/interface/CoreInterface.h>
#include <PiXYZGeom/interface/GeomInterface.h>
#include <PiXYZMaterial/interface/MaterialInterface.h>
#include <PiXYZPolygonal/interface/PolygonalInterface.h>
#include <PiXYZCAD/interface/CADInterface.h>
#ifdef CLOUD_MODULE
#include <PiXYZCloud/interface/CloudInterface.h>
#endif
#include <PiXYZAlgo/interface/AlgoInterface.h>
#include <PiXYZScene/interface/SceneInterface.h>
#include <PiXYZRaytrace/interface/RaytraceInterface.h>
#include <PiXYZView/interface/ViewInterface.h>
#include <PiXYZUnity/interface/UnityInterface.h>
#include <PiXYZIO/interface/IOInterface.h>

PXZ_NS_BEGIN

class PXZ_EXPORTED PiXYZAPI : public IPiXYZAPI
{
public:
   static PiXYZAPI* initialize(const CoreI::String& productName, const CoreI::String& validationKey, const CoreI::String& license = "");

   void startServer(const CoreI::String& host, const CoreI::Short& port);
   void startClient(const CoreI::String& host, const CoreI::Short& port);

   static CoreI::List<PiXYZAPI*> activeSessions();

   void release();

   bool isRemote();

   CoreI::Ident sessionId() const { return _sessionId; }

   virtual CoreI::CoreInterface* Core() final { return _core; }
   virtual GeomI::GeomInterface* Geom() final { return _geom; }
   virtual MaterialI::MaterialInterface* Material() final { return _material; }
   virtual PolygonalI::PolygonalInterface* Polygonal() final { return _polygonal; }
   virtual CADI::CADInterface* CAD() final { return _cad; }
#ifdef CLOUD_MODULE
   virtual CloudI::CloudInterface* Cloud() final { return _cloud; }
#endif
   virtual AlgoI::AlgoInterface* Algo() final { return _algo; }
   virtual SceneI::SceneInterface* Scene() final { return _scene; }
   virtual RaytraceI::RaytraceInterface* Raytrace() final { return _raytrace; }
   virtual ViewI::ViewInterface* View() final { return _view; }
   virtual IOI::IOInterface* IO() final { return _io; }
   virtual UnityI::UnityInterface* Unity() final { return _unity; }

protected:
   virtual ~PiXYZAPI() {}

private:
   PiXYZAPI();
   

   CoreI::Ident _sessionId;

   CoreI::CoreInterface* _core;
   GeomI::GeomInterface* _geom;
   MaterialI::MaterialInterface* _material;
   PolygonalI::PolygonalInterface* _polygonal;
   CADI::CADInterface* _cad;
#ifdef CLOUD_MODULE
   CloudI::CloudInterface* _cloud;
#endif
   AlgoI::AlgoInterface* _algo;
   SceneI::SceneInterface* _scene;
   RaytraceI::RaytraceInterface* _raytrace;
   ViewI::ViewInterface* _view;
   IOI::IOInterface* _io;
   UnityI::UnityInterface* _unity;

   static void installApplicationSignals();
};

PXZ_NS_END

#endif
