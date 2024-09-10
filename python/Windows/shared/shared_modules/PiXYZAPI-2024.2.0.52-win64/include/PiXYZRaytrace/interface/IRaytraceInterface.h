// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_RAYTRACE_INTERFACE_IRAYTRACEINTERFACE_H_
#define _PXZ_RAYTRACE_INTERFACE_IRAYTRACEINTERFACE_H_

#include "RaytraceTypes.h"

namespace PiXYZ { class PiXYZAPI; }


PXZ_MODULE_BEGIN(RaytraceI)

class PXZ_EXPORTED IRaytraceInterface
{
public:
   virtual ~IRaytraceInterface() {}

   /*!
     \param functionName 
     \param enableFunction 
     \param enableParameters 
     \param enableExecutionTime 
   */
   virtual void configureFunctionLogger(const CoreI::String & functionName, const CoreI::Boolean & enableFunction, const CoreI::Boolean & enableParameters, const CoreI::Boolean & enableExecutionTime) = 0;

   /*!
     \param width 
     \param height 
     \param camera 
     \param outputImagePath 
   */
   virtual void renderImage(const CoreI::Int & width, const CoreI::Int & height, const Camera & camera, const CoreI::OutputFilePath & outputImagePath) = 0;


};

PXZ_MODULE_END



#endif
