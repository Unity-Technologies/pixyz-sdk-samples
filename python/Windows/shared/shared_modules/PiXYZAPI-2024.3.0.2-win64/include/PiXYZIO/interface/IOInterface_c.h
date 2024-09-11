// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_IO_INTERFACE_IOINTERFACE_C_H_
#define _PXZ_IO_INTERFACE_IOINTERFACE_C_H_

#include "IOTypes_c.h"

PXZ_EXPORTED char * IO_getLastError();

PXZ_EXPORTED void IO_configureFunctionLogger(Session * pxzSession, Core_String functionName, Core_Boolean enableFunction, Core_Boolean enableParameters, Core_Boolean enableExecutionTime);

// ----------------------------------------------------
// Asset paths
// asset paths management
// ----------------------------------------------------

// add directory paths to search assets in
PXZ_EXPORTED void IO_addAssetPaths(Session * pxzSession, Core_StringList path);
// clear all asset paths
PXZ_EXPORTED void IO_clearAssetPaths(Session * pxzSession);
// find the final path. This will search for the file in asset paths
PXZ_EXPORTED Core_String IO_findInDirectories(Session * pxzSession, Core_String filePath);
// get user defined paths to find assets
PXZ_EXPORTED Core_StringList IO_getAssetPaths(Session * pxzSession);
// replace paths to find assets
PXZ_EXPORTED void IO_setAssetPaths(Session * pxzSession, Core_StringList assetPaths);

// ----------------------------------------------------
// Debug
// ----------------------------------------------------


// ----------------------------------------------------
// Import/Export
// external format import/export
// ----------------------------------------------------

// Handle auto tessellate options on given part, need to be complete
PXZ_EXPORTED void IO_applyAutoTessellate(Session * pxzSession, Scene_Part part);
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
// Load partial model
PXZ_EXPORTED void IO_loadReferencedData(Session * pxzSession, Scene_ReferencedDataComponent component, Core_Bool recursively);
// Unload partial model
PXZ_EXPORTED void IO_unloadReferencedData(Session * pxzSession, Scene_ReferencedDataComponent component);

// ----------------------------------------------------
// ImportCallbacks
// add callback for homemade importers
// ----------------------------------------------------

// Register import and export callbacks
PXZ_EXPORTED void IO_registerIOCallbacks(Session * pxzSession, Core_String name, IO_importFileCallback importCallback, IO_exportFileCallback exportCallback, IO_FileFormatList fileFormats);

// ----------------------------------------------------
// Point Cloud
// Massive point cloud functions
// ----------------------------------------------------

PXZ_EXPORTED void IO_splitPointCloud(Session * pxzSession, Core_FilePathList files, Core_OutputDirectoryPath outputDirectory, Core_Double minVoxSize, Core_Boolean useKDTree, Geom_AABB aabb, Core_Double density);

// ----------------------------------------------------
// Priorities
// extension priorities
// ----------------------------------------------------

// get the priority of an extension from the pixyz importer
PXZ_EXPORTED IO_PriorityImportLevel IO_getExtensionPriority(Session * pxzSession, Core_String extensionName);



#endif
