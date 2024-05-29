// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_IO_INTERFACE_IOINTERFACE_H_
#define _PXZ_IO_INTERFACE_IOINTERFACE_H_

#include "IOTypes.h"
#include <PiXYZIO/interface/IIOInterface.h>

namespace PiXYZ { class PiXYZAPI; }


PXZ_MODULE_BEGIN(IOI)

class PXZ_EXPORTED IOInterface : public IIOInterface
{
public:
   virtual ~IOInterface() {}

   /*!
     \param functionName 
     \param enableFunction 
     \param enableParameters 
     \param enableExecutionTime 
   */
   virtual void configureFunctionLogger(const CoreI::String & functionName, const CoreI::Boolean & enableFunction, const CoreI::Boolean & enableParameters, const CoreI::Boolean & enableExecutionTime) final ;


   /**
    * \defgroup Cloud 
    * @{
    */
   //! Export current scene to a local directory
   /*!
     \param root Identifier of the destination occurrence
     \param directory Directory to export in
   */
   virtual void exportSceneToDTPlatform(const SceneI::Occurrence & root, const CoreI::String & directory) final ;

   //! Export current scene to a reflect project
   /*!
     \param root Identifier of the destination occurrence
     \param sourceName Push source name
     \param uid UID of the push, overwrite old push if it's same UID
     \param keepHierarchy Keep hierarchy or rake tree
     \param configFile Use existing JSON config file, discard reflect UI prompt
     \param disableDecimation Forces to disable the decimation applied on SyncObjectInstances on Reflect Server side
   */
   virtual void exportSceneToReflect(const SceneI::Occurrence & root = 1, const CoreI::String & sourceName = "", const CoreI::String & uid = "", const CoreI::Boolean & keepHierarchy = false, const CoreI::FilePath & configFile = "", const CoreI::Boolean & disableDecimation = true) final ;

   //! Import scene from a local directory
   /*!
     \param directory Directory to import from
     \param root Identifier of the destination occurrence
   */
   virtual void importSceneFromDTPlatform(const CoreI::DirectoryPath & directory, const SceneI::Occurrence & root = 0) final ;

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
   //! Export a file
   /*!
     \param fileName Path of the file to export
     \param root Identifier of the root occurrence to export
   */
   virtual void exportScene(const CoreI::OutputFilePath & fileName, const SceneI::Occurrence & root = 0) final ;

   //! Export the selection to a file
   /*!
     \param fileName Path of the file to export
     \param keepIntermediaryNodes If true, intermerdiary hierarchy is kept
   */
   virtual void exportSelection(const CoreI::OutputFilePath & fileName, const CoreI::Boolean & keepIntermediaryNodes = false) final ;

   //! Give all the format name and their extensions that can be exported in Pixyz
   /*!
     \return formats Formats that can be exported in Pixyz
   */
   virtual CoreI::FormatList getExportFormats() final ;

   //! Give all the format name and their extensions that can be imported in Pixyz
   /*!
     \return formats Formats that can be imported in Pixyz
   */
   virtual CoreI::FormatList getImportFormats() final ;

   //! Import files
   /*!
     \param fileNames List of files's paths to import
     \param root Identifier of the destination occurrence
     \return dest The root occurrences of each imported file
   */
   virtual SceneI::OccurrenceList importFiles(const FilesList & fileNames, const SceneI::Occurrence & root = 0) final ;

   //! Imports a picture and applies is at as a texture on a 3D plane created in the scene.
   /*!
     \param filename Path of the file to import
     \param root Identifier of the destination occurrence
     \return dest The root occurrence if defined, otherwise a new occurrence created by the importer
   */
   virtual SceneI::Occurrence importPicture(const CoreI::FilePath & filename, const SceneI::Occurrence & root = 0) final ;

   //! Import a remote 3mx file
   /*!
     \param filePath The path of the temp file
     \param origin Remote origin of the file
     \param root Identifier of the destination occurrence
     \return dest The root occurrence if defined, otherwise a new occurrence created by the importer
   */
   virtual SceneI::Occurrence importRemote3mxFile(const CoreI::String & filePath, const CoreI::String & origin = "", const SceneI::Occurrence & root = 0) final ;

   //! Import a file
   /*!
     \param fileName Path of the file to import
     \param root Identifier of the destination occurrence
     \return dest The root occurrence if defined, otherwise a new occurrence created by the importer
   */
   virtual SceneI::Occurrence importScene(const CoreI::FilePath & fileName, const SceneI::Occurrence & root = 0) final ;

   //! List all variants if file
   /*!
     \param fileName Path of the file to import
     \return variants List all variants
   */
   virtual VariantNameList listVariants(const CoreI::FilePath & fileName) final ;

   /*!
     \param component The component to load
     \param recursively Load it recursively or not
   */
   virtual void loadReferencedData(const SceneI::ReferencedDataComponent & component, const CoreI::Bool & recursively) final ;

   /**@}*/

   /**
    * \defgroup ImportCallbacks add callback for homemade importers
    * @{
    */
   //! add new homade importer
   /*!
     \param name Callback name
     \param extensions Handled extensions
     \param callback Callback that import a file
   */
   virtual void registerImportCallback(const CoreI::String & name, const CoreI::StringList & extensions, importFileCallback callback) final ;

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
   virtual void splitPointCloud(const CoreI::FilePathList & files, const CoreI::OutputDirectoryPath & outputDirectory, const CoreI::Double & minVoxSize, const CoreI::Boolean & useKDTree, const GeomI::AABB & aabb = GeomI::AABB(), const CoreI::Double & density = -1) final ;

   /**@}*/

private:
   friend class PiXYZ::PiXYZAPI;
   IOInterface(void * session);
   void * _session;
};

PXZ_MODULE_END



#endif
