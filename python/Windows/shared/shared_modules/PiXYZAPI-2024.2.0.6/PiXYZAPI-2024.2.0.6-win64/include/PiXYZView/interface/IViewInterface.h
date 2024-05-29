// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_VIEW_INTERFACE_IVIEWINTERFACE_H_
#define _PXZ_VIEW_INTERFACE_IVIEWINTERFACE_H_

#include "ViewTypes.h"

namespace PiXYZ { class PiXYZAPI; }


PXZ_MODULE_BEGIN(ViewI)

class PXZ_EXPORTED IViewInterface
{
public:
   virtual ~IViewInterface() {}

   /*!
     \param functionName 
     \param enableFunction 
     \param enableParameters 
     \param enableExecutionTime 
   */
   virtual void configureFunctionLogger(const CoreI::String & functionName, const CoreI::Boolean & enableFunction, const CoreI::Boolean & enableParameters, const CoreI::Boolean & enableExecutionTime) = 0;

   //! returns true if a suitable device is found.
   /*!
     \return found True if a suitable device was found.
   */
   virtual CoreI::Bool suitableGPUAvailable() = 0;

   //! event emited once the frame buffer is created
   /*!
     \param viewer 
   */
   virtual CoreI::Ident addAfterFramebufferCreateCallback(void(*fp)(void *, const Viewer &), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void removeAfterFramebufferCreateCallback(CoreI::Ident id); 

   //! emitted after a viewer's property is changed
   /*!
     \param viewer Viewer id
     \param property Property changed
   */
   virtual CoreI::Ident addAfterViewerPropertyChangedCallback(void(*fp)(void *, const Viewer &, const CoreI::String &), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void removeAfterViewerPropertyChangedCallback(CoreI::Ident id); 

   //! event emited before the frame buffer is deleted
   /*!
     \param viewer 
   */
   virtual CoreI::Ident addBeforeFramebufferDeleteCallback(void(*fp)(void *, const Viewer &), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void removeBeforeFramebufferDeleteCallback(CoreI::Ident id); 

   //! emitted before a viewer's property is changed
   /*!
     \param viewer Viewer id
     \param property Property changed
   */
   virtual CoreI::Ident addBeforeViewerPropertyChangedCallback(void(*fp)(void *, const Viewer &, const CoreI::String &), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void removeBeforeViewerPropertyChangedCallback(CoreI::Ident id); 


   /**
    * \defgroup Animation Player Animation Player related functions
    * @{
    */
   //! apply the animations
   /*!
     \param time Current time
   */
   virtual void applyPlayingAnimations(const SceneI::AnimationTime & time) = 0;

   //! packs all AnimationPlayer-related info about an animation in an object
   /*!
     \param animation Animation to get info of
     \return animationPlayerInfo 
   */
   virtual AnimationPlayerInfo getAnimationPlayerInfo(const SceneI::Animation & animation) = 0;

   //! is this animation playing?
   /*!
     \param animation Animation to check
     \return playingValue 
   */
   virtual CoreI::Bool isAnimationPlaying(const SceneI::Animation & animation) = 0;

   //! pauses all animations
   virtual void pauseAllAnimation() = 0;

   //! pauses an animation
   /*!
     \param animation Animation to pause
   */
   virtual void pauseAnimation(const SceneI::Animation & animation) = 0;

   //! plays an animation
   /*!
     \param animation Animation to play
     \param speed Speed
     \param loop Should the animation loop?
   */
   virtual void playAnimation(const SceneI::Animation & animation, const CoreI::Double & speed = 1, const CoreI::Boolean & loop = false) = 0;

   //! resumes all animations
   virtual void resumeAllAnimation() = 0;

   //! resumes an animation
   /*!
     \param animation Animation to resume
   */
   virtual void resumeAnimation(const SceneI::Animation & animation) = 0;

   //! set animation's current frame
   /*!
     \param animation Animation to set frame
     \param frame Frame to set
   */
   virtual void setAnimationFrame(const SceneI::Animation & animation, const SceneI::AnimationTime & frame) = 0;

   //! set animation's looping status
   /*!
     \param animation Animation to set loop status
     \param loop Should the animation loop?
   */
   virtual void setAnimationLoop(const SceneI::Animation & animation, const CoreI::Boolean & loop) = 0;

   //! set animation's playing speed
   /*!
     \param animation Animation to set speed
     \param speed The speed
   */
   virtual void setAnimationSpeed(const SceneI::Animation & animation, const CoreI::Double & speed) = 0;

   //! stops all animations
   /*!
     \param applyDefault Should the default position be applied
   */
   virtual void stopAllAnimation(const CoreI::Bool & applyDefault = true) = 0;

   //! stops an animation
   /*!
     \param animation Animation to stop
     \param applyDefault Should the default position be applied
   */
   virtual void stopAnimation(const SceneI::Animation & animation, const CoreI::Bool & applyDefault = true) = 0;

   /*!
     \param animation Paused or stopped animation
   */
   virtual CoreI::Ident addAnimationPausedOrStoppedCallback(void(*fp)(void *, const SceneI::Animation &), void * userdata = nullptr) = 0;
   void removeAnimationPausedOrStoppedCallback(CoreI::Ident id); 

   /*!
     \param animation Played or resumed animation
   */
   virtual CoreI::Ident addAnimationPlayedOrResumedCallback(void(*fp)(void *, const SceneI::Animation &), void * userdata = nullptr) = 0;
   void removeAnimationPlayedOrResumedCallback(CoreI::Ident id); 

   /*!
     \param animation Paused or stopped animation
     \param playInfo Animation info
   */
   virtual CoreI::Ident addAnimationPlayingStatusChangedCallback(void(*fp)(void *, const SceneI::Animation &, const AnimationPlayerInfo &), void * userdata = nullptr) = 0;
   void removeAnimationPlayingStatusChangedCallback(CoreI::Ident id); 

   /**@}*/

   /**
    * \defgroup D3D11 interop 
    * @{
    */
   /*!
     \param renderMap 
     \param viewer 
     \return handle 
   */
   virtual D3D11Texture getD3D11Texture(const RenderMap & renderMap, const Viewer & viewer = -1) = 0;

   /**@}*/

   /**
    * \defgroup OpenGL interop 
    * @{
    */
   /*!
     \param renderMap 
     \param viewer 
     \return handle 
   */
   virtual GLTextureHandle getGLTextureHandle(const RenderMap & renderMap, const Viewer & viewer = -1) = 0;

   /**@}*/

   /**
    * \defgroup Vulkan interop 
    * @{
    */
   /*!
     \param renderMap 
     \param viewer 
     \return handle 
   */
   virtual VulkanTexture getVulkanTexture(const RenderMap & renderMap, const Viewer & viewer = -1) = 0;

   /**@}*/

   /**
    * \defgroup gpu scene 
    * @{
    */
   /*!
     \param roots Roots of the subtrees that will be uploaded to GPU
     \param constructEdges Construct buffer to render edges colored by topology (slower to construct)
     \return scene Identifier of the newly created GPU Scene
   */
   virtual GPUScene createGPUScene(const SceneI::OccurrenceList & roots, const CoreI::Bool & constructEdges = false) = 0;

   /*!
     \param scene GPU Scene to destroy (previously created by createGPUScene)
   */
   virtual void destroyGPUScene(const GPUScene & scene) = 0;

   //! Returns (and create if it does not exist) a global GPU scene (with the scene root) to be used commonly by several clients
   /*!
     \return scene Identifier of the global GPU Scene
   */
   virtual GPUScene getGlobalGPUScene() = 0;

   //! Returns the occurrence index in the viewer buffers. Can be used for mapping an index retrieved in a GLTextureHandle id map.
   /*!
     \param occurrence Occurrence identifier
     \param scene Scene identifier
     \return index Occurrence index
   */
   virtual CoreI::UInt getOccurrenceIndex(const SceneI::Occurrence & occurrence, const GPUScene & scene) = 0;

   //! Returns the GPU scene index in the viewer buffers. Can be used for mapping an index retrieved in a GLTextureHandle id map.
   /*!
     \param scene GPU scene identifier
     \param viewer Viewer identifier
     \return index GPU scene index
   */
   virtual CoreI::UInt getSceneIndex(const GPUScene & scene, const Viewer & viewer) = 0;

   /**@}*/

   /**
    * \defgroup offscreen 
    * @{
    */
   //! Add a GPU scene to a viewer
   /*!
     \param scene GPU Scene to render in the viewer
     \param viewer Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
   */
   virtual void addGPUScene(const GPUScene & scene, const Viewer & viewer = -1) = 0;

   //! Debug: capture next frame with renderdoc (only if launched with renderdoc)
   /*!
     \param viewer Viewer to capture
   */
   virtual void captureNextFrame(const Viewer & viewer) = 0;

   //! Create a new viewer
   /*!
     \param width Width of the viewer framebuffer
     \param height Height of the viewer framebuffer
     \param sharedContext Interop context handle
     \param nbViews Nb views
     \return viewer 
   */
   virtual Viewer createViewer(const CoreI::Int & width, const CoreI::Int & height, const GraphicsContext & sharedContext = GraphicsContext(), const CoreI::Int & nbViews = 1) = 0;

   /*!
     \param viewer Viewer to destroy
   */
   virtual void destroyViewer(const Viewer & viewer) = 0;

   //! Create an occurrence that holds the mesh of the surfaces that have been cut by the cutting plane
   /*!
     \param cuttingPlane Cutting plane component for which we create the capping plane
     \return root The created occurrence
   */
   virtual SceneI::Occurrence drawCappingPlane(const SceneI::Component & cuttingPlane) = 0;

   //! Automatically compute the near and far planes depending on the scene
   /*!
     \param viewer Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
     \param cameraPos 
     \return clipping 
   */
   virtual GeomI::Vector2 getAutoClipping(const Viewer & viewer, const GeomI::Vector3 & cameraPos) = 0;

   //! Get a viewer property value
   /*!
     \param propertyName 
     \param viewer Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
     \return propertyValue 
   */
   virtual CoreI::String getViewerProperty(const CoreI::String & propertyName, const Viewer & viewer = -1) = 0;

   //! Get a viewer property info
   /*!
     \param propertyName 
     \param viewer Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
     \return propertyInfo 
   */
   virtual CoreI::PropertyInfo getViewerPropertyInfo(const CoreI::String & propertyName, const Viewer & viewer = -1) = 0;

   //! Retrieve the viewport size of a viewer
   /*!
     \param viewer Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
     \return width 
     \return height 
   */
   virtual getViewerSizeReturn getViewerSize(const Viewer & viewer = -1) = 0;

   /*!
     \param viewer Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
     \return renderedOccurrences Number of rendered occurrences
     \return renderedTriangles Number of rendered triangles
   */
   virtual getViewerStatsReturn getViewerStats(const Viewer & viewer = -1) = 0;

   //! Get the list of viewer properties
   /*!
     \param viewer Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
     \return properties 
   */
   virtual CoreI::PropertyInfoList listViewerProperties(const Viewer & viewer = -1) = 0;

   /*!
     \param x 
     \param y 
     \param viewer 
     \return occurrence Picked occurrence, 0 if not occurrence picked
     \return position World space position of the picking point
     \return primitiveId Depending of the Part shape representation, it can be a triangle/quadrangle index (Mesh) or a Face identifier (BRep)
   */
   virtual pickReturn pick(const CoreI::Int & x, const CoreI::Int & y, const Viewer & viewer = -1) = 0;

   /*!
     \param xMin 
     \param xMax 
     \param yMin 
     \param yMax 
     \param viewer 
     \param inDepth 
     \return occurrences List of picked occurrences
   */
   virtual SceneI::OccurrenceList pickRectangle(const CoreI::Int & xMin, const CoreI::Int & xMax, const CoreI::Int & yMin, const CoreI::Int & yMax, const Viewer & viewer = -1, const CoreI::Bool & inDepth = false) = 0;

   //! Refresh the viewer
   /*!
     \param viewer Viewer to refresh
     \param frameCount Number of frames to render
     \param forceUpdate Force the viewer to update pending modification on the geometry. By default this is disabled while running process
   */
   virtual void refreshViewer(const Viewer & viewer = -1, const CoreI::Int & frameCount = 1, const CoreI::Boolean & forceUpdate = false) = 0;

   //! Remove a viewer root
   /*!
     \param scene GPU Scene to remove from the viewer
     \param viewer Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
   */
   virtual void removeGPUScene(const GPUScene & scene, const Viewer & viewer = -1) = 0;

   /*!
     \param width Width of the viewer framebuffer
     \param height Height of the viewer framebuffer
     \param viewer Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
   */
   virtual void resizeViewer(const CoreI::Int & width, const CoreI::Int & height, const Viewer & viewer = -1) = 0;

   //! Select the primitives (polygons, surfaces) contained in the given rectangle
   /*!
     \param xMin 
     \param xMax 
     \param yMin 
     \param yMax 
     \param primitiveType 
     \param viewer 
   */
   virtual void selectPrimitives(const CoreI::Int & xMin, const CoreI::Int & xMax, const CoreI::Int & yMin, const CoreI::Int & yMax, const PrimitiveSelectionType & primitiveType, const Viewer & viewer = -1) = 0;

   //! Set default viewer id. This viewer will be used in other functions taking a Viewer as a parameter. Usefull if a viewer needs to be shared across different contexts.
   /*!
     \param viewer 
   */
   virtual void setDefaultViewerId(const Viewer & viewer) = 0;

   //! Set a viewer property value
   /*!
     \param propertyName 
     \param propertyValue 
     \param viewer Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
   */
   virtual void setViewerProperty(const CoreI::String & propertyName, const CoreI::String & propertyValue, const Viewer & viewer = -1) = 0;

   /**@}*/

   /**
    * \defgroup raw images 
    * @{
    */
   /*!
     \param viewer 
     \return image Returned composited image
   */
   virtual MaterialI::ImageDefinition getCompositedImage(const Viewer & viewer) = 0;

   /*!
     \param viewer 
     \param renderMap 
     \return image Returned composited image
   */
   virtual MaterialI::ImageDefinition getRenderMapImage(const Viewer & viewer, const RenderMap & renderMap) = 0;

   /*!
     \param fileName Path where to save the screenshot
     \param viewer 
   */
   virtual void takeScreenshot(const CoreI::OutputFilePath & fileName, const Viewer & viewer) = 0;

   /**@}*/

   /**
    * \defgroup streaming 
    * @{
    */
   //! create a viewer for streaming
   /*!
     \param width Width of the viewer framebuffer
     \param height Height of the viewer framebuffer
     \param encoderSettings Settings used for the encoder
     \param useWebRTC Switch between raw websockets and webRTC
     \param webRTCInfo Info for web rtc signaling connection
     \return streamedViewerInfo Port and host for stream connection
   */
   virtual StreamedViewerInfo createStreamedViewer(const CoreI::Int & width, const CoreI::Int & height, const EncoderSettings & encoderSettings = EncoderSettings(), const CoreI::Boolean & useWebRTC = false, const WebRTCInfo & webRTCInfo = WebRTCInfo()) = 0;

   /*!
     \param width Width of the viewer framebuffer
     \param height Height of the viewer framebuffer
     \param viewer 
     \param encoderSettings Settings used for the encoder
   */
   virtual void resizeStreamedViewer(const CoreI::Int & width, const CoreI::Int & height, const Viewer & viewer = -1, const EncoderSettings & encoderSettings = EncoderSettings()) = 0;

   //! record viewer in a file
   /*!
     \param filePath File in which video while be saved
     \param viewer Viewer to use for recording video
     \param encoderSettings Settings used for the encoder
   */
   virtual void startRecording(const CoreI::String & filePath, const Viewer & viewer, const EncoderSettings & encoderSettings = EncoderSettings()) = 0;

   //! stop recording video
   /*!
     \param viewer Viewer to use for recording video
   */
   virtual void stopRecording(const Viewer & viewer) = 0;

   /**@}*/

   /**
    * \defgroup viewer matrices 
    * @{
    */
   //! Set the viewer matrices to adjust the camera to the scene
   /*!
     \param direction Camera direction
     \param cameraType Camera type, Orthographic or Perspective
     \param fov Field of view (perspective mode only)
     \param viewer Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
     \param fitToOccurrence 
   */
   virtual void fitCamera(const GeomI::Vector3 & direction, const CameraType & cameraType, const GeomI::Angle & fov, const Viewer & viewer = -1, const SceneI::Occurrence & fitToOccurrence = 0) = 0;

   /*!
     \param viewer Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
     \return views 
     \return projs 
     \return clipping 
   */
   virtual getViewerMatricesReturn getViewerMatrices(const Viewer & viewer = -1) = 0;

   /*!
     \param views 
     \param projs 
     \param clipping 
     \param viewer Viewer id returned by the createViewer function. -1 uses the default viewer id (see setDefaultViewerId).
   */
   virtual void setViewerMatrices(const GeomI::Matrix4List & views, const GeomI::Matrix4List & projs, const GeomI::Vector2 & clipping, const Viewer & viewer = -1) = 0;

   /**@}*/

   /**
    * \defgroup visibility Visibility functions
    * @{
    */
   //! Render one frame of the visibility session
   /*!
     \param viewer Viewer to use for the visibility shoot
     \param parts If false, optimize when parts seen are not wanted
     \param patches If false, optimize when patches seen are not wanted
     \param polygons If false, optimize when polygons seen are not wanted
     \param countOnce Optimize when it is not needed to count the numbers of pixels seen during the session
     \return sceneOccurrences The list of scene paths seen from this shoot
   */
   virtual SceneI::OccurrenceList visibilityShoot(const Viewer & viewer = -1, const CoreI::Bool & parts = true, const CoreI::Bool & patches = true, const CoreI::Bool & polygons = true, const CoreI::Bool & countOnce = false) = 0;

   /**@}*/

};

PXZ_MODULE_END



#endif
