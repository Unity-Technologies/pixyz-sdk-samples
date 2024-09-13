// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_VIEW_INTERFACE_VIEWINTERFACE_C_H_
#define _PXZ_VIEW_INTERFACE_VIEWINTERFACE_C_H_

#include "ViewTypes_c.h"

PXZ_EXPORTED char * View_getLastError();

PXZ_EXPORTED void View_configureFunctionLogger(Session * pxzSession, Core_String functionName, Core_Boolean enableFunction, Core_Boolean enableParameters, Core_Boolean enableExecutionTime);
// Destroy the Vulkan instance. All existing viewers and gpuScenes will also be destroyed and all view module properties will be reset
PXZ_EXPORTED void View_destroyContext(Session * pxzSession);
// returns true if a suitable device is found.
PXZ_EXPORTED Core_Bool View_suitableGPUAvailable(Session * pxzSession);
// event emited once the frame buffer is created
   /*!
     \param viewer 
   */
PXZ_EXPORTED Core_Ident View_addAfterFramebufferCreateCallback(Session * pxzSession, void(*fp)(void *, View_Viewer), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void View_removeAfterFramebufferCreateCallback(Session * pxzSession, Core_Ident id);

// emitted after a viewer's property is changed
   /*!
     \param viewer Viewer id
     \param property Property changed
   */
PXZ_EXPORTED Core_Ident View_addAfterViewerPropertyChangedCallback(Session * pxzSession, void(*fp)(void *, View_Viewer, Core_String), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void View_removeAfterViewerPropertyChangedCallback(Session * pxzSession, Core_Ident id);

// event emited before the frame buffer is deleted
   /*!
     \param viewer 
   */
PXZ_EXPORTED Core_Ident View_addBeforeFramebufferDeleteCallback(Session * pxzSession, void(*fp)(void *, View_Viewer), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void View_removeBeforeFramebufferDeleteCallback(Session * pxzSession, Core_Ident id);

// emitted before a viewer's property is changed
   /*!
     \param viewer Viewer id
     \param property Property changed
   */
PXZ_EXPORTED Core_Ident View_addBeforeViewerPropertyChangedCallback(Session * pxzSession, void(*fp)(void *, View_Viewer, Core_String), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void View_removeBeforeViewerPropertyChangedCallback(Session * pxzSession, Core_Ident id);


// ----------------------------------------------------
// Animation Player
// Animation Player related functions
// ----------------------------------------------------

// apply the animations
PXZ_EXPORTED void View_applyPlayingAnimations(Session * pxzSession, Scene_AnimationTime time);
// packs all AnimationPlayer-related info about an animation in an object
PXZ_EXPORTED View_AnimationPlayerInfo View_getAnimationPlayerInfo(Session * pxzSession, Scene_Animation animation);
// is this animation playing?
PXZ_EXPORTED Core_Bool View_isAnimationPlaying(Session * pxzSession, Scene_Animation animation);
// pauses all animations
PXZ_EXPORTED void View_pauseAllAnimation(Session * pxzSession);
// pauses an animation
PXZ_EXPORTED void View_pauseAnimation(Session * pxzSession, Scene_Animation animation);
// plays an animation
PXZ_EXPORTED void View_playAnimation(Session * pxzSession, Scene_Animation animation, Core_Double speed, Core_Boolean loop);
// resumes all animations
PXZ_EXPORTED void View_resumeAllAnimation(Session * pxzSession);
// resumes an animation
PXZ_EXPORTED void View_resumeAnimation(Session * pxzSession, Scene_Animation animation);
// set animation's current frame
PXZ_EXPORTED void View_setAnimationFrame(Session * pxzSession, Scene_Animation animation, Scene_AnimationTime frame);
// set animation's looping status
PXZ_EXPORTED void View_setAnimationLoop(Session * pxzSession, Scene_Animation animation, Core_Boolean loop);
// set animation's playing speed
PXZ_EXPORTED void View_setAnimationSpeed(Session * pxzSession, Scene_Animation animation, Core_Double speed);
// stops all animations
PXZ_EXPORTED void View_stopAllAnimation(Session * pxzSession, Core_Bool applyDefault);
// stops an animation
PXZ_EXPORTED void View_stopAnimation(Session * pxzSession, Scene_Animation animation, Core_Bool applyDefault);
   /*!
     \param animation Paused or stopped animation
   */
PXZ_EXPORTED Core_Ident View_addAnimationPausedOrStoppedCallback(Session * pxzSession, void(*fp)(void *, Scene_Animation), void * userdata = nullptr);
PXZ_EXPORTED void View_removeAnimationPausedOrStoppedCallback(Session * pxzSession, Core_Ident id);

   /*!
     \param animation Played or resumed animation
   */
PXZ_EXPORTED Core_Ident View_addAnimationPlayedOrResumedCallback(Session * pxzSession, void(*fp)(void *, Scene_Animation), void * userdata = nullptr);
PXZ_EXPORTED void View_removeAnimationPlayedOrResumedCallback(Session * pxzSession, Core_Ident id);

   /*!
     \param animation Paused or stopped animation
     \param playInfo Animation info
   */
PXZ_EXPORTED Core_Ident View_addAnimationPlayingStatusChangedCallback(Session * pxzSession, void(*fp)(void *, Scene_Animation, View_AnimationPlayerInfo), void * userdata = nullptr);
PXZ_EXPORTED void View_removeAnimationPlayingStatusChangedCallback(Session * pxzSession, Core_Ident id);


// ----------------------------------------------------
// D3D11 interop
// ----------------------------------------------------

PXZ_EXPORTED View_D3D11Texture View_getD3D11Texture(Session * pxzSession, View_RenderMap renderMap, View_Viewer viewer);

// ----------------------------------------------------
// OpenGL interop
// ----------------------------------------------------

PXZ_EXPORTED View_GLTextureHandle View_getGLTextureHandle(Session * pxzSession, View_RenderMap renderMap, View_Viewer viewer);

// ----------------------------------------------------
// Vulkan interop
// ----------------------------------------------------

PXZ_EXPORTED View_VulkanTexture View_getVulkanTexture(Session * pxzSession, View_RenderMap renderMap, View_Viewer viewer);

// ----------------------------------------------------
// gpu scene
// ----------------------------------------------------

PXZ_EXPORTED View_GPUScene View_createGPUScene(Session * pxzSession, Scene_OccurrenceList roots, Core_Bool constructEdges);
PXZ_EXPORTED void View_destroyGPUScene(Session * pxzSession, View_GPUScene scene);
// Returns (and create if it does not exist) a global GPU scene (with the scene root) to be used commonly by several clients
PXZ_EXPORTED View_GPUScene View_getGlobalGPUScene(Session * pxzSession);
// Return the lastAABB computed during a frame drawing, requires the viewer property ComputeLastAABB to be True
PXZ_EXPORTED Geom_AABB View_getLastAABB(Session * pxzSession, View_GPUScene scene, View_Viewer viewer);
// Returns the occurrence index in the viewer buffers. Can be used for mapping an index retrieved in a GLTextureHandle id map.
PXZ_EXPORTED Core_UInt View_getOccurrenceIndex(Session * pxzSession, Scene_Occurrence occurrence, View_GPUScene scene);
// Returns the GPU scene index in the viewer buffers. Can be used for mapping an index retrieved in a GLTextureHandle id map.
PXZ_EXPORTED Core_UInt View_getSceneIndex(Session * pxzSession, View_GPUScene scene, View_Viewer viewer);
// Lock the mutex that ensure no update of the gpu scene is done between lock/unlock
PXZ_EXPORTED void View_lockGPUSceneUpdate(Session * pxzSession, View_GPUScene scene);
// Lock the mutex that ensure no update of multiple gpu scenes is done between lock/unlock
PXZ_EXPORTED void View_lockGPUScenesUpdate(Session * pxzSession, View_GPUSceneList scenes);
// Try to lock the mutex that ensure no update of the gpu scene is done between lock/unlock, returns true if the mutex has been locked, false if it was already locked
PXZ_EXPORTED Core_Bool View_tryLockGPUSceneUpdate(Session * pxzSession, View_GPUScene scene);
// Try to lock the mutex that ensure no update of multiple gpu scenes is done between lock/unlock, returns true if the mutex has been locked, false if it was already locked
PXZ_EXPORTED Core_BoolList View_tryLockGPUScenesUpdate(Session * pxzSession, View_GPUSceneList scenes);
// Unlock the mutex that ensure no update of the gpu scene is done between lock/unlock
PXZ_EXPORTED void View_unlockGPUSceneUpdate(Session * pxzSession, View_GPUScene scene);
// Unlock the mutex that ensure no update of multiple gpu scenes is done between lock/unlock
PXZ_EXPORTED void View_unlockGPUScenesUpdate(Session * pxzSession, View_GPUSceneList scenes);

// ----------------------------------------------------
// offscreen
// ----------------------------------------------------

// Add a GPU scene to a viewer
PXZ_EXPORTED void View_addGPUScene(Session * pxzSession, View_GPUScene scene, View_Viewer viewer);
// Debug: capture next frame with renderdoc (only if launched with renderdoc)
PXZ_EXPORTED void View_captureNextFrame(Session * pxzSession, View_Viewer viewer);
// Create a new viewer
PXZ_EXPORTED View_Viewer View_createViewer(Session * pxzSession, Core_Int width, Core_Int height, View_GraphicsContext sharedContext, Core_Int nbViews);
PXZ_EXPORTED void View_destroyViewer(Session * pxzSession, View_Viewer viewer);
// Create an occurrence that holds the mesh of the surfaces that have been cut by the cutting plane
PXZ_EXPORTED Scene_Occurrence View_drawCappingPlane(Session * pxzSession, Scene_Component cuttingPlane);
// Automatically compute the near and far planes depending on the scene
PXZ_EXPORTED Geom_Vector2 View_getAutoClipping(Session * pxzSession, View_Viewer viewer, Geom_Vector3 cameraPos);
// Get the front axis of the nth view matrix of a given viewer
PXZ_EXPORTED Geom_Vector3 View_getCameraFrontAxis(Session * pxzSession, View_Viewer viewer, Core_UInt matrixIndex);
// Get the position of the nth view matrix of a given viewer
PXZ_EXPORTED Geom_Vector3 View_getCameraPosition(Session * pxzSession, View_Viewer viewer, Core_UInt matrixIndex);
// Get the right axis of the nth view matrix of a given viewer
PXZ_EXPORTED Geom_Vector3 View_getCameraRightAxis(Session * pxzSession, View_Viewer viewer, Core_UInt matrixIndex);
// Get the up axis of the nth view matrix of a given viewer
PXZ_EXPORTED Geom_Vector3 View_getCameraUpAxis(Session * pxzSession, View_Viewer viewer, Core_UInt matrixIndex);
// Get a viewer property value
PXZ_EXPORTED Core_String View_getViewerProperty(Session * pxzSession, Core_String propertyName, View_Viewer viewer);
// Get a viewer property info
PXZ_EXPORTED Core_PropertyInfo View_getViewerPropertyInfo(Session * pxzSession, Core_String propertyName, View_Viewer viewer);
// Retrieve the viewport size of a viewer
typedef struct {
   Core_Int width;
   Core_Int height;
} View_getViewerSizeReturn;
PXZ_EXPORTED View_getViewerSizeReturn View_getViewerSize(Session * pxzSession, View_Viewer viewer);
typedef struct {
   Core_Int renderedOccurrences;
   Core_Int renderedTriangles;
} View_getViewerStatsReturn;
PXZ_EXPORTED View_getViewerStatsReturn View_getViewerStats(Session * pxzSession, View_Viewer viewer);
// Get the list of viewer properties
PXZ_EXPORTED Core_PropertyInfoList View_listViewerProperties(Session * pxzSession, View_Viewer viewer);
typedef struct {
   Scene_Occurrence occurrence;
   Geom_Point3 position;
   Core_Ident primitiveId;
} View_pickReturn;
PXZ_EXPORTED View_pickReturn View_pick(Session * pxzSession, Core_Int x, Core_Int y, View_Viewer viewer);
PXZ_EXPORTED Scene_OccurrenceList View_pickRectangle(Session * pxzSession, Core_Int xMin, Core_Int xMax, Core_Int yMin, Core_Int yMax, View_Viewer viewer, Core_Bool inDepth);
// Refresh the viewer
PXZ_EXPORTED void View_refreshViewer(Session * pxzSession, View_Viewer viewer);
// Remove a viewer root
PXZ_EXPORTED void View_removeGPUScene(Session * pxzSession, View_GPUScene scene, View_Viewer viewer);
PXZ_EXPORTED void View_resizeViewer(Session * pxzSession, Core_Int width, Core_Int height, View_Viewer viewer);
// Select the primitives (polygons, surfaces) contained in the given rectangle
PXZ_EXPORTED void View_selectPrimitives(Session * pxzSession, Core_Int xMin, Core_Int xMax, Core_Int yMin, Core_Int yMax, View_PrimitiveSelectionType primitiveType, View_Viewer viewer);
// Set default viewer id. This viewer will be used in other functions taking a Viewer as a parameter. Useful if a viewer needs to be shared across different contexts.
PXZ_EXPORTED void View_setDefaultViewerId(Session * pxzSession, View_Viewer viewer);
// Set a viewer property value
PXZ_EXPORTED void View_setViewerProperty(Session * pxzSession, Core_String propertyName, Core_String propertyValue, View_Viewer viewer);

// ----------------------------------------------------
// raw images
// ----------------------------------------------------

PXZ_EXPORTED Material_ImageDefinition View_getCompositedImage(Session * pxzSession, View_Viewer viewer);
PXZ_EXPORTED Material_ImageDefinition View_getRenderMapImage(Session * pxzSession, View_Viewer viewer, View_RenderMap renderMap);
PXZ_EXPORTED void View_takeScreenshot(Session * pxzSession, Core_OutputFilePath fileName, View_Viewer viewer);

// ----------------------------------------------------
// streaming
// ----------------------------------------------------

// create a viewer for streaming
PXZ_EXPORTED View_StreamedViewerInfo View_createStreamedViewer(Session * pxzSession, Core_Int width, Core_Int height, View_EncoderSettings encoderSettings, Core_Boolean useWebRTC, View_WebRTCInfo webRTCInfo);
PXZ_EXPORTED void View_resizeStreamedViewer(Session * pxzSession, Core_Int width, Core_Int height, View_Viewer viewer, View_EncoderSettings encoderSettings);
// record viewer in a file
PXZ_EXPORTED void View_startRecording(Session * pxzSession, Core_String filePath, View_Viewer viewer, View_EncoderSettings encoderSettings);
// stop recording video
PXZ_EXPORTED void View_stopRecording(Session * pxzSession, View_Viewer viewer);

// ----------------------------------------------------
// viewer matrices
// ----------------------------------------------------

// Set the viewer matrices to adjust the camera to the scene
PXZ_EXPORTED void View_fitCamera(Session * pxzSession, Geom_Vector3 direction, View_CameraType cameraType, Geom_Angle fov, View_Viewer viewer, Scene_OccurrenceList fitToOccurrences);
typedef struct {
   Geom_Matrix4List views;
   Geom_Matrix4List projs;
   Geom_Vector2 clipping;
} View_getViewerMatricesReturn;
PXZ_EXPORTED View_getViewerMatricesReturn View_getViewerMatrices(Session * pxzSession, View_Viewer viewer);
PXZ_EXPORTED void View_setViewerMatrices(Session * pxzSession, Geom_Matrix4List views, Geom_Matrix4List projs, Geom_Vector2 clipping, View_Viewer viewer);

// ----------------------------------------------------
// visibility
// Visibility functions
// ----------------------------------------------------

// Render one frame of the visibility session
PXZ_EXPORTED Scene_OccurrenceList View_visibilityShoot(Session * pxzSession, View_Viewer viewer, Core_Bool parts, Core_Bool patches, Core_Bool polygons, Core_Bool countOnce);



#endif
