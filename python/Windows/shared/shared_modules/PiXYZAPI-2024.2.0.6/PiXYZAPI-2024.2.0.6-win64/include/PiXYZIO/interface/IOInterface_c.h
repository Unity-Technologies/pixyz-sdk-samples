// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_IO_INTERFACE_IOINTERFACE_C_H_
#define _PXZ_IO_INTERFACE_IOINTERFACE_C_H_

#include "IOTypes_c.h"

PXZ_EXPORTED char * IO_getLastError();

PXZ_EXPORTED void IO_configureFunctionLogger(Session * pxzSession, Core_String functionName, Core_Boolean enableFunction, Core_Boolean enableParameters, Core_Boolean enableExecutionTime);

// ----------------------------------------------------
// Cloud
// ----------------------------------------------------

// Export current scene to a local directory
PXZ_EXPORTED void IO_exportSceneToDTPlatform(Session * pxzSession, Scene_Occurrence root, Core_String directory);
// Export current scene to a reflect project
PXZ_EXPORTED void IO_exportSceneToReflect(Session * pxzSession, Scene_Occurrence root, Core_String sourceName, Core_String uid, Core_Boolean keepHierarchy, Core_FilePath configFile, Core_Boolean disableDecimation);
// Import scene from a local directory
PXZ_EXPORTED void IO_importSceneFromDTPlatform(Session * pxzSession, Core_DirectoryPath directory, Scene_Occurrence root);

// ----------------------------------------------------
// Debug
// ----------------------------------------------------


// ----------------------------------------------------
// Import/Export
// external format import/export
// ----------------------------------------------------

// Export a file
PXZ_EXPORTED void IO_exportScene(Session * pxzSession, Core_OutputFilePath fileName, Scene_Occurrence root);
// Export the selection to a file
PXZ_EXPORTED void IO_exportSelection(Session * pxzSession, Core_OutputFilePath fileName, Core_Boolean keepIntermediaryNodes);
// Give all the format name and their extensions that can be exported in Pixyz
PXZ_EXPORTED Core_FormatList IO_getExportFormats(Session * pxzSession);
// Give all the format name and their extensions that can be imported in Pixyz
PXZ_EXPORTED Core_FormatList IO_getImportFormats(Session * pxzSession);
// Import files
PXZ_EXPORTED Scene_OccurrenceList IO_importFiles(Session * pxzSession, IO_FilesList fileNames, Scene_Occurrence root);
// Imports a picture and applies is at as a texture on a 3D plane created in the scene.
PXZ_EXPORTED Scene_Occurrence IO_importPicture(Session * pxzSession, Core_FilePath filename, Scene_Occurrence root);
// Import a remote 3mx file
PXZ_EXPORTED Scene_Occurrence IO_importRemote3mxFile(Session * pxzSession, Core_String filePath, Core_String origin, Scene_Occurrence root);
// Import a file
PXZ_EXPORTED Scene_Occurrence IO_importScene(Session * pxzSession, Core_FilePath fileName, Scene_Occurrence root);
// List all variants if file
PXZ_EXPORTED IO_VariantNameList IO_listVariants(Session * pxzSession, Core_FilePath fileName);
PXZ_EXPORTED void IO_loadReferencedData(Session * pxzSession, Scene_ReferencedDataComponent component, Core_Bool recursively);

// ----------------------------------------------------
// ImportCallbacks
// add callback for homemade importers
// ----------------------------------------------------

// add new homade importer
PXZ_EXPORTED void IO_registerImportCallback(Session * pxzSession, Core_String name, Core_StringList extensions, IO_importFileCallback callback);

// ----------------------------------------------------
// Point Cloud
// Massive point cloud functions
// ----------------------------------------------------

PXZ_EXPORTED void IO_splitPointCloud(Session * pxzSession, Core_FilePathList files, Core_OutputDirectoryPath outputDirectory, Core_Double minVoxSize, Core_Boolean useKDTree, Geom_AABB aabb, Core_Double density);



#endif
