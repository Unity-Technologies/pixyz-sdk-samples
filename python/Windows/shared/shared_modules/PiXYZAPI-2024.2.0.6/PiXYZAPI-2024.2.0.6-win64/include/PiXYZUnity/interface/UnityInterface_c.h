// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_UNITY_INTERFACE_UNITYINTERFACE_C_H_
#define _PXZ_UNITY_INTERFACE_UNITYINTERFACE_C_H_

#include "UnityTypes_c.h"

PXZ_EXPORTED char * Unity_getLastError();

PXZ_EXPORTED void Unity_configureFunctionLogger(Session * pxzSession, Core_String functionName, Core_Boolean enableFunction, Core_Boolean enableParameters, Core_Boolean enableExecutionTime);

// ----------------------------------------------------
// Direct3D
// ----------------------------------------------------

PXZ_EXPORTED Unity_ID3D11Device Unity_getD3D11Device(Session * pxzSession);
PXZ_EXPORTED Unity_ID3D11RenderTargetView Unity_getD3D11RenderTargetViewFromRenderBuffer(Session * pxzSession, Unity_UnityRenderBuffer surface);
PXZ_EXPORTED Unity_ID3D11ShaderResourceView Unity_getD3D11ShaderResourceViewFromNativeTexture(Session * pxzSession, Unity_UnityTextureID texture);
PXZ_EXPORTED Unity_ID3D11Resource Unity_getD3D11TextureFromNativeTexture(Session * pxzSession, Unity_UnityTextureID texture);
PXZ_EXPORTED Unity_ID3D11Resource Unity_getD3D11TextureFromRenderBuffer(Session * pxzSession, Unity_UnityRenderBuffer buffer);

// ----------------------------------------------------
// Unity Pugin Event Functions
// ----------------------------------------------------

PXZ_EXPORTED Unity_UnityRenderingEvent Unity_getDestroyFunction(Session * pxzSession);
PXZ_EXPORTED Unity_UnityRenderingEventAndData Unity_getDrawFunction(Session * pxzSession);
PXZ_EXPORTED Unity_UnityRenderingEvent Unity_getInitFunction(Session * pxzSession);

// ----------------------------------------------------
// Unity View Session
// ----------------------------------------------------

// Asynchronous function to pick in the current viewer
PXZ_EXPORTED void Unity_asyncPick(Session * pxzSession, Unity_UnityViewSession session, Core_Int x, Core_Int y);
// call this function when the texture has to be resized. the resize will take effect during the next render. This will send a ViewSessionResized event when done
PXZ_EXPORTED void Unity_asyncResize(Session * pxzSession, Unity_UnityViewSession session, Core_Int width, Core_Int height);
PXZ_EXPORTED Unity_UnityViewSession Unity_createUnityViewSession(Session * pxzSession, Core_Int width, Core_Int height, View_GraphicAPI graphicAPI, Core_Int nbViews);
// Returns the underlying viewer of the given view session
PXZ_EXPORTED View_Viewer Unity_getUnityViewSessionViewer(Session * pxzSession, Unity_UnityViewSession session);
// Emitted when a session is destroyed (via getDestroyFunction unity plugin event)
   /*!
     \param session View session
   */
PXZ_EXPORTED Core_Ident Unity_addUnityViewSessionDestroyedCallback(Session * pxzSession, void(*fp)(void *, Unity_UnityViewSession), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Unity_removeUnityViewSessionDestroyedCallback(Session * pxzSession, Core_Ident id);

// emited when a pick was performed (after asyncPick) and there is a result to share
   /*!
     \param result Result of the picking
     \param session View session
   */
PXZ_EXPORTED Core_Ident Unity_addUnityViewSessionHasPickedCallback(Session * pxzSession, void(*fp)(void *, Unity_PickResult, Unity_UnityViewSession), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Unity_removeUnityViewSessionHasPickedCallback(Session * pxzSession, Core_Ident id);

// Emitted when a session created with CreateUnityViewSession is initialized (via getInitfunction unity plugin event)
   /*!
     \param session View session
   */
PXZ_EXPORTED Core_Ident Unity_addUnityViewSessionInitializedCallback(Session * pxzSession, void(*fp)(void *, Unity_UnityViewSession), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Unity_removeUnityViewSessionInitializedCallback(Session * pxzSession, Core_Ident id);

// emits when a view session is done resizing
   /*!
     \param session View session
   */
PXZ_EXPORTED Core_Ident Unity_addUnityViewSessionResizedCallback(Session * pxzSession, void(*fp)(void *, Unity_UnityViewSession), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Unity_removeUnityViewSessionResizedCallback(Session * pxzSession, Core_Ident id);


// ----------------------------------------------------
// Vulkan
// ----------------------------------------------------

PXZ_EXPORTED Unity_VulkanDevice Unity_getVulkanDevice(Session * pxzSession);



#endif
