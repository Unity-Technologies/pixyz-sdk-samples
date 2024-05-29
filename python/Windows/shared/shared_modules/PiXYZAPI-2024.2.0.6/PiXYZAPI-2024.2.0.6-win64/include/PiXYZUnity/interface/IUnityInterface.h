// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_UNITY_INTERFACE_IUNITYINTERFACE_H_
#define _PXZ_UNITY_INTERFACE_IUNITYINTERFACE_H_

#include "UnityTypes.h"

namespace PiXYZ { class PiXYZAPI; }


PXZ_MODULE_BEGIN(UnityI)

class PXZ_EXPORTED IUnityInterface
{
public:
   virtual ~IUnityInterface() {}

   /*!
     \param functionName 
     \param enableFunction 
     \param enableParameters 
     \param enableExecutionTime 
   */
   virtual void configureFunctionLogger(const CoreI::String & functionName, const CoreI::Boolean & enableFunction, const CoreI::Boolean & enableParameters, const CoreI::Boolean & enableExecutionTime) = 0;


   /**
    * \defgroup Direct3D 
    * @{
    */
   /*!
     \return device 
   */
   virtual ID3D11Device getD3D11Device() = 0;

   /*!
     \param surface 
     \return rtv 
   */
   virtual ID3D11RenderTargetView getD3D11RenderTargetViewFromRenderBuffer(const UnityRenderBuffer & surface) = 0;

   /*!
     \param texture 
     \return srv 
   */
   virtual ID3D11ShaderResourceView getD3D11ShaderResourceViewFromNativeTexture(const UnityTextureID & texture) = 0;

   /*!
     \param texture 
     \return dxTexture 
   */
   virtual ID3D11Resource getD3D11TextureFromNativeTexture(const UnityTextureID & texture) = 0;

   /*!
     \param buffer 
     \return dxTexture 
   */
   virtual ID3D11Resource getD3D11TextureFromRenderBuffer(const UnityRenderBuffer & buffer) = 0;

   /**@}*/

   /**
    * \defgroup Unity Pugin Event Functions 
    * @{
    */
   /*!
     \return destroyFunction 
   */
   virtual UnityRenderingEvent getDestroyFunction() = 0;

   /*!
     \return drawFunction 
   */
   virtual UnityRenderingEventAndData getDrawFunction() = 0;

   /*!
     \return initFunction 
   */
   virtual UnityRenderingEvent getInitFunction() = 0;

   /**@}*/

   /**
    * \defgroup Unity View Session 
    * @{
    */
   //! Asynchronous function to pick in the current viewer
   /*!
     \param session 
     \param x 
     \param y 
   */
   virtual void asyncPick(const UnityViewSession & session, const CoreI::Int & x, const CoreI::Int & y) = 0;

   //! call this function when the texture has to be resized. the resize will take effect during the next render. This will send a ViewSessionResized event when done
   /*!
     \param session 
     \param width Viewer width
     \param height Viewer height
   */
   virtual void asyncResize(const UnityViewSession & session, const CoreI::Int & width, const CoreI::Int & height) = 0;

   /*!
     \param width Viewer width
     \param height Viewer height
     \param graphicAPI Graphic api used by Unity
     \param nbViews Nb views
     \return session 
   */
   virtual UnityViewSession createUnityViewSession(const CoreI::Int & width, const CoreI::Int & height, const ViewI::GraphicAPI & graphicAPI, const CoreI::Int & nbViews = 1) = 0;

   //! Returns the underlying viewer of the given view session
   /*!
     \param session 
     \return viewer 
   */
   virtual ViewI::Viewer getUnityViewSessionViewer(const UnityViewSession & session) = 0;

   //! Emitted when a session is destroyed (via getDestroyFunction unity plugin event)
   /*!
     \param session View session
   */
   virtual CoreI::Ident addUnityViewSessionDestroyedCallback(void(*fp)(void *, const UnityViewSession &), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void removeUnityViewSessionDestroyedCallback(CoreI::Ident id); 

   //! emited when a pick was performed (after asyncPick) and there is a result to share
   /*!
     \param result Result of the picking
     \param session View session
   */
   virtual CoreI::Ident addUnityViewSessionHasPickedCallback(void(*fp)(void *, const PickResult &, const UnityViewSession &), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void removeUnityViewSessionHasPickedCallback(CoreI::Ident id); 

   //! Emitted when a session created with CreateUnityViewSession is initialized (via getInitfunction unity plugin event)
   /*!
     \param session View session
   */
   virtual CoreI::Ident addUnityViewSessionInitializedCallback(void(*fp)(void *, const UnityViewSession &), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void removeUnityViewSessionInitializedCallback(CoreI::Ident id); 

   //! emits when a view session is done resizing
   /*!
     \param session View session
   */
   virtual CoreI::Ident addUnityViewSessionResizedCallback(void(*fp)(void *, const UnityViewSession &), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void removeUnityViewSessionResizedCallback(CoreI::Ident id); 

   /**@}*/

   /**
    * \defgroup Vulkan 
    * @{
    */
   /*!
     \return vkDevice 
   */
   virtual VulkanDevice getVulkanDevice() = 0;

   /**@}*/

};

PXZ_MODULE_END



#endif
