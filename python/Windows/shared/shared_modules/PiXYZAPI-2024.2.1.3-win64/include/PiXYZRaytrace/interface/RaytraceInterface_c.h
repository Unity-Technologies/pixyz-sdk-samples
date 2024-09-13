// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_RAYTRACE_INTERFACE_RAYTRACEINTERFACE_C_H_
#define _PXZ_RAYTRACE_INTERFACE_RAYTRACEINTERFACE_C_H_

#include "RaytraceTypes_c.h"

PXZ_EXPORTED char * Raytrace_getLastError();

PXZ_EXPORTED void Raytrace_configureFunctionLogger(Session * pxzSession, Core_String functionName, Core_Boolean enableFunction, Core_Boolean enableParameters, Core_Boolean enableExecutionTime);
PXZ_EXPORTED void Raytrace_renderImage(Session * pxzSession, Core_Int width, Core_Int height, Raytrace_Camera camera, Core_OutputFilePath outputImagePath);



#endif
