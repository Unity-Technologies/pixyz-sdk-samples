// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_RAYTRACE_INTERFACE_RAYTRACEINTERFACE_H_
#define _PXZ_RAYTRACE_INTERFACE_RAYTRACEINTERFACE_H_

#include "RaytraceTypes.h"
#include <PiXYZRaytrace/interface/IRaytraceInterface.h>

namespace PiXYZ { class PiXYZAPI; }


PXZ_MODULE_BEGIN(RaytraceI)

class PXZ_EXPORTED RaytraceInterface : public IRaytraceInterface
{
public:
   virtual ~RaytraceInterface() {}

   /*!
     \param functionName 
     \param enableFunction 
     \param enableParameters 
     \param enableExecutionTime 
   */
   virtual void configureFunctionLogger(const CoreI::String & functionName, const CoreI::Boolean & enableFunction, const CoreI::Boolean & enableParameters, const CoreI::Boolean & enableExecutionTime) final ;

   /*!
     \param width 
     \param height 
     \param camera 
     \param outputImagePath 
   */
   virtual void renderImage(const CoreI::Int & width, const CoreI::Int & height, const Camera & camera, const CoreI::OutputFilePath & outputImagePath) final ;


private:
   friend class PiXYZ::PiXYZAPI;
   RaytraceInterface(void * session);
   void * _session;
public:
   void * session() { return _session; }
};

PXZ_MODULE_END



#endif
