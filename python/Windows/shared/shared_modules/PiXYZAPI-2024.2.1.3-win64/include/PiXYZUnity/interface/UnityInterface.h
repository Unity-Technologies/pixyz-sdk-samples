// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_UNITY_INTERFACE_UNITYINTERFACE_H_
#define _PXZ_UNITY_INTERFACE_UNITYINTERFACE_H_

#include "UnityTypes.h"
#include <PiXYZUnity/interface/IUnityInterface.h>

namespace PiXYZ { class PiXYZAPI; }


PXZ_MODULE_BEGIN(UnityI)

class PXZ_EXPORTED UnityInterface : public IUnityInterface
{
public:
   virtual ~UnityInterface() {}

   /*!
     \param functionName 
     \param enableFunction 
     \param enableParameters 
     \param enableExecutionTime 
   */
   virtual void configureFunctionLogger(const CoreI::String & functionName, const CoreI::Boolean & enableFunction, const CoreI::Boolean & enableParameters, const CoreI::Boolean & enableExecutionTime) final ;


   /**
    * \defgroup Direct3D 
    * @{
    */
   /*!
     \return device 
   */
   virtual ID3D11Device getD3D11Device() final ;

   /*!
     \param surface 
     \return rtv 
   */
   virtual ID3D11RenderTargetView getD3D11RenderTargetViewFromRenderBuffer(const UnityRenderBuffer & surface) final ;

   /*!
     \param texture 
     \return srv 
   */
   virtual ID3D11ShaderResourceView getD3D11ShaderResourceViewFromNativeTexture(const UnityTextureID & texture) final ;

   /*!
     \param texture 
     \return dxTexture 
   */
   virtual ID3D11Resource getD3D11TextureFromNativeTexture(const UnityTextureID & texture) final ;

   /*!
     \param buffer 
     \return dxTexture 
   */
   virtual ID3D11Resource getD3D11TextureFromRenderBuffer(const UnityRenderBuffer & buffer) final ;

   /**@}*/

   /**
    * \defgroup Unity Pugin Event Functions 
    * @{
    */
   /*!
     \return destroyFunction 
   */
   virtual UnityRenderingEvent getDestroyFunction() final ;

   /*!
     \return drawFunction 
   */
   virtual UnityRenderingEventAndData getDrawFunction() final ;

   /*!
     \return initFunction 
   */
   virtual UnityRenderingEvent getInitFunction() final ;

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
   virtual void asyncPick(const UnityViewSession & session, const CoreI::Int & x, const CoreI::Int & y) final ;

   //! call this function when the texture has to be resized. the resize will take effect during the next render. This will send a ViewSessionResized event when done
   /*!
     \param session 
     \param width Viewer width
     \param height Viewer height
   */
   virtual void asyncResize(const UnityViewSession & session, const CoreI::Int & width, const CoreI::Int & height) final ;

   /*!
     \param width Viewer width
     \param height Viewer height
     \param graphicAPI Graphic api used by Unity
     \param nbViews Nb views
     \return session 
   */
   virtual UnityViewSession createUnityViewSession(const CoreI::Int & width, const CoreI::Int & height, const ViewI::GraphicAPI & graphicAPI, const CoreI::Int & nbViews = 1) final ;

   //! Emitted when a session is destroyed (via getDestroyFunction unity plugin event)
   /*!
     \param session View session
   */
   virtual CoreI::Ident addUnityViewSessionDestroyedCallback(void(*fp)(void *, const UnityViewSession &), void * userdata = nullptr) final ;
   //! method to remove a callback event
   void * removeUnityViewSessionDestroyedCallback(CoreI::Ident id); 

   //! emited when a pick was performed (after asyncPick) and there is a result to share
   /*!
     \param result Result of the picking
     \param session View session
   */
   virtual CoreI::Ident addUnityViewSessionHasPickedCallback(void(*fp)(void *, const PickResult &, const UnityViewSession &), void * userdata = nullptr) final ;
   //! method to remove a callback event
   void * removeUnityViewSessionHasPickedCallback(CoreI::Ident id); 

   //! Emitted when a session created with CreateUnityViewSession is initialized (via getInitfunction unity plugin event)
   /*!
     \param session View session
     \param viewer Underlying viewer of the initialized view session
     \param gpuScene Underlying GPU scene of the initialized view session
   */
   virtual CoreI::Ident addUnityViewSessionInitializedCallback(void(*fp)(void *, const UnityViewSession &, const ViewI::Viewer &, const ViewI::GPUScene &), void * userdata = nullptr) final ;
   //! method to remove a callback event
   void * removeUnityViewSessionInitializedCallback(CoreI::Ident id); 

   //! emits when a view session is done resizing
   /*!
     \param session View session
   */
   virtual CoreI::Ident addUnityViewSessionResizedCallback(void(*fp)(void *, const UnityViewSession &), void * userdata = nullptr) final ;
   //! method to remove a callback event
   void * removeUnityViewSessionResizedCallback(CoreI::Ident id); 

   /**@}*/

   /**
    * \defgroup Vulkan 
    * @{
    */
   /*!
     \return vkDevice 
   */
   virtual VulkanDevice getVulkanDevice() final ;

   /**@}*/

private:
   friend class PiXYZ::PiXYZAPI;
   UnityInterface(void * session);
   void * _session;
public:
   void * session() { return _session; }
};

PXZ_MODULE_END



#endif
