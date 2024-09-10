// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_IO_INTERFACE_IIOINTERFACE_H_
#define _PXZ_IO_INTERFACE_IIOINTERFACE_H_

#include "IOTypes.h"

namespace PiXYZ { class PiXYZAPI; }


PXZ_MODULE_BEGIN(IOI)

class PXZ_EXPORTED IIOInterface
{
public:
   virtual ~IIOInterface() {}

   /*!
     \param functionName 
     \param enableFunction 
     \param enableParameters 
     \param enableExecutionTime 
   */
   virtual void configureFunctionLogger(const CoreI::String & functionName, const CoreI::Boolean & enableFunction, const CoreI::Boolean & enableParameters, const CoreI::Boolean & enableExecutionTime) = 0;


   /**
    * \defgroup Asset paths asset paths management
    * @{
    */
   //! add directory paths to search assets in
   /*!
     \param path The paths to add
   */
   virtual void addAssetPaths(const CoreI::StringList & path) = 0;

   //! clear all asset paths
   virtual void clearAssetPaths() = 0;

   //! find the final path. This will search for the file in asset paths
   /*!
     \param filePath The (relative) file path to search for
     \return finalPath The returned final path
   */
   virtual CoreI::String findInDirectories(const CoreI::String & filePath) = 0;

   //! get user defined paths to find assets
   /*!
     \return assetPaths The asset paths
   */
   virtual CoreI::StringList getAssetPaths() = 0;

   //! replace paths to find assets
   /*!
     \param assetPaths The asset paths
   */
   virtual void setAssetPaths(const CoreI::StringList & assetPaths) = 0;

   /**@}*/

   /**
    * \defgroup Debug 
    * @{
    */
   /**@}*/

   /**
    * \defgroup Import/Export external format import/export
    * @{
    */
   //! Handle auto tessellate options on given part, need to be complete
   /*!
     \param part Part to be auto tessellated
   */
   virtual void applyAutoTessellate(const SceneI::Part & part) = 0;

   //! Export a file
   /*!
     \param fileName Path of the file to export
     \param root Identifier of the root occurrence to export
   */
   virtual void exportScene(const CoreI::OutputFilePath & fileName, const SceneI::Occurrence & root = 1) = 0;

   //! Export the selection to a file
   /*!
     \param fileName Path of the file to export
     \param keepIntermediaryNodes If true, intermerdiary hierarchy is kept
   */
   virtual void exportSelection(const CoreI::OutputFilePath & fileName, const CoreI::Boolean & keepIntermediaryNodes = false) = 0;

   //! Give all the format name and their extensions that can be exported in Pixyz
   /*!
     \return formats Formats that can be exported in Pixyz
   */
   virtual CoreI::FormatList getExportFormats() = 0;

   //! Give all the format name and their extensions that can be imported in Pixyz
   /*!
     \return formats Formats that can be imported in Pixyz
   */
   virtual CoreI::FormatList getImportFormats() = 0;

   //! Import files
   /*!
     \param fileNames List of files's paths to import
     \param root Identifier of the destination occurrence
     \return dest The root occurrences of each imported file
   */
   virtual SceneI::OccurrenceList importFiles(const FilesList & fileNames, const SceneI::Occurrence & root = 0) = 0;

   //! Imports a picture and applies is at as a texture on a 3D plane created in the scene.
   /*!
     \param filename Path of the file to import
     \param root Identifier of the destination occurrence
     \return dest The root occurrence if defined, otherwise a new occurrence created by the importer
   */
   virtual SceneI::Occurrence importPicture(const CoreI::FilePath & filename, const SceneI::Occurrence & root = 0) = 0;

   //! Import a remote 3mx file
   /*!
     \param filePath The path of the temp file
     \param origin Remote origin of the file
     \param root Identifier of the destination occurrence
     \return dest The root occurrence if defined, otherwise a new occurrence created by the importer
   */
   virtual SceneI::Occurrence importRemote3mxFile(const CoreI::String & filePath, const CoreI::String & origin = "", const SceneI::Occurrence & root = 0) = 0;

   //! Import a file
   /*!
     \param fileName Path of the file to import
     \param root Identifier of the destination occurrence
     \return dest The root occurrence if defined, otherwise a new occurrence created by the importer
   */
   virtual SceneI::Occurrence importScene(const CoreI::FilePath & fileName, const SceneI::Occurrence & root = 0) = 0;

   //! List all variants if file
   /*!
     \param fileName Path of the file to import
     \return variants List all variants
   */
   virtual VariantNameList listVariants(const CoreI::FilePath & fileName) = 0;

   //! Load partial model
   /*!
     \param component The component to load
     \param recursively Load it recursively or not
   */
   virtual void loadReferencedData(const SceneI::ReferencedDataComponent & component, const CoreI::Bool & recursively) = 0;

   /**@}*/

   /**
    * \defgroup ImportCallbacks add callback for homemade importers
    * @{
    */
   //! Register import and export callbacks
   /*!
     \param name Callback name
     \param importCallback Callback that import a file
     \param exportCallback Callback that exports to a file
     \param fileFormats Gives the extension and parameters to Import/Export
   */
   virtual void registerIOCallbacks(const CoreI::String & name, importFileCallback importCallback, exportFileCallback exportCallback, const FileFormatList & fileFormats) = 0;

   /**@}*/

   /**
    * \defgroup Point Cloud Massive point cloud functions
    * @{
    */
   /*!
     \param files Path of the point cloud files to process
     \param outputDirectory Output directory
     \param minVoxSize Size of minimum leaves (mm)
     \param useKDTree If true, uses a kd_tree, otherwise, uses an octree
     \param aabb Global scene aabb
     \param density Point cloud density (-1 to compute)
   */
   virtual void splitPointCloud(const CoreI::FilePathList & files, const CoreI::OutputDirectoryPath & outputDirectory, const CoreI::Double & minVoxSize, const CoreI::Boolean & useKDTree, const GeomI::AABB & aabb = GeomI::AABB(), const CoreI::Double & density = -1) = 0;

   /**@}*/

   /**
    * \defgroup Priorities extension priorities
    * @{
    */
   //! get the priority of an extension from the pixyz importer
   /*!
     \param extensionName The name of the extension
     \return priority The level of priority of the extension
   */
   virtual PriorityImportLevel getExtensionPriority(const CoreI::String & extensionName) = 0;

   /**@}*/

};

PXZ_MODULE_END



#endif
