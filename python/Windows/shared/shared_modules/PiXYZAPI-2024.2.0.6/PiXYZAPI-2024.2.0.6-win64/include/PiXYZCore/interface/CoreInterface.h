// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_CORE_INTERFACE_COREINTERFACE_H_
#define _PXZ_CORE_INTERFACE_COREINTERFACE_H_

#include "CoreTypes.h"
#include <PiXYZCore/interface/ICoreInterface.h>

namespace PiXYZ { class PiXYZAPI; }


PXZ_MODULE_BEGIN(CoreI)

class PXZ_EXPORTED CoreInterface : public ICoreInterface
{
public:
   virtual ~CoreInterface() {}

   //! Clone an entity
   /*!
     \param entity The entity to clone
     \return clonedEntity The cloned entity
   */
   virtual Entity cloneEntity(const Entity & entity) final ;

   /*!
     \param functionName 
     \param enableFunction 
     \param enableParameters 
     \param enableExecutionTime 
   */
   virtual void configureFunctionLogger(const String & functionName, const Boolean & enableFunction, const Boolean & enableParameters, const Boolean & enableExecutionTime) final ;

   //! Create an entity
   /*!
     \param type The type of entity to create
     \return entity The created entity id
   */
   virtual Entity createEntity(const EntityType & type) final ;

   //! Delete a set of entities
   /*!
     \param entities List of entity to delete
   */
   virtual void deleteEntities(const EntityList & entities) final ;

   //! Clear all the current session (all unsaved work will be lost)
   virtual void resetSession() final ;

   //! Returns true if the user has made changes to the project
   /*!
     \return hasChanged Boolean checking if the project has been modified
   */
   virtual Bool unsavedUserChanges() final ;

   //! emitted after a property is changed
   /*!
     \param entity Entity changed
     \param property Property changed
     \param entityType Type of the entity changed
   */
   virtual CoreI::Ident addAfterEntityPropertyChangedCallback(void(*fp)(void *, const Entity &, const String &, const Int &), void * userdata = nullptr) final ;
   //! method to remove a callback event
   void removeAfterEntityPropertyChangedCallback(CoreI::Ident id); 

   //! emitted after a module is changed
   /*!
     \param module Module changed
     \param property Property changed
   */
   virtual CoreI::Ident addAfterModulePropertyChangedCallback(void(*fp)(void *, const String &, const String &), void * userdata = nullptr) final ;
   //! method to remove a callback event
   void removeAfterModulePropertyChangedCallback(CoreI::Ident id); 

   //! emitted when pixyz is closed
   virtual CoreI::Ident addAtExitCallback(void(*fp)(void *), void * userdata = nullptr) final ;
   //! method to remove a callback event
   void removeAtExitCallback(CoreI::Ident id); 

   //! emitted before a property is changed
   /*!
     \param entity Entity changed
     \param property Property changed
   */
   virtual CoreI::Ident addBeforeEntityPropertyChangedCallback(void(*fp)(void *, const Entity &, const String &), void * userdata = nullptr) final ;
   //! method to remove a callback event
   void removeBeforeEntityPropertyChangedCallback(CoreI::Ident id); 

   //! emitted before a module is changed
   /*!
     \param module Module changed
     \param property Property changed
   */
   virtual CoreI::Ident addBeforeModulePropertyChangedCallback(void(*fp)(void *, const String &, const String &), void * userdata = nullptr) final ;
   //! method to remove a callback event
   void removeBeforeModulePropertyChangedCallback(CoreI::Ident id); 

   //! emitted just before pixyz's session reset
   virtual CoreI::Ident addBeforeSessionResetCallback(void(*fp)(void *), void * userdata = nullptr) final ;
   //! method to remove a callback event
   void removeBeforeSessionResetCallback(CoreI::Ident id); 

   //! Current loaded file is modified
   virtual CoreI::Ident addCurrentFileChangedCallback(void(*fp)(void *), void * userdata = nullptr) final ;
   //! method to remove a callback event
   void removeCurrentFileChangedCallback(CoreI::Ident id); 

   //! emitted before entering the unsafe mode, during this step accesses to the scene may be unsafe
   virtual CoreI::Ident addEnteringUnsafeModeCallback(void(*fp)(void *), void * userdata = nullptr) final ;
   //! method to remove a callback event
   void removeEnteringUnsafeModeCallback(CoreI::Ident id); 

   //! emitted when we leave the unsafe mode
   virtual CoreI::Ident addLeavingUnsafeModeCallback(void(*fp)(void *), void * userdata = nullptr) final ;
   //! method to remove a callback event
   void removeLeavingUnsafeModeCallback(CoreI::Ident id); 

   //! sends all Pixyz console message
   /*!
     \param text Message content
     \param verboseLevel Verbose level
   */
   virtual CoreI::Ident addOnConsoleMessageCallback(void(*fp)(void *, const String &, const Verbose &), void * userdata = nullptr) final ;
   //! method to remove a callback event
   void removeOnConsoleMessageCallback(CoreI::Ident id); 

   //! emitted when pixyz's session is reset
   virtual CoreI::Ident addOnSessionResetCallback(void(*fp)(void *), void * userdata = nullptr) final ;
   //! method to remove a callback event
   void removeOnSessionResetCallback(CoreI::Ident id); 

   //! emits the progress of the progress bar
   /*!
     \param progress Current progression
   */
   virtual CoreI::Ident addProgressChangedCallback(void(*fp)(void *, const Int &), void * userdata = nullptr) final ;
   //! method to remove a callback event
   void removeProgressChangedCallback(CoreI::Ident id); 

   //! emits the name of finished step
   virtual CoreI::Ident addProgressStepFinishedCallback(void(*fp)(void *), void * userdata = nullptr) final ;
   //! method to remove a callback event
   void removeProgressStepFinishedCallback(CoreI::Ident id); 

   //! emits the name of starting step
   /*!
     \param stepName Name of the started step
   */
   virtual CoreI::Ident addProgressStepStartCallback(void(*fp)(void *, const String &), void * userdata = nullptr) final ;
   //! method to remove a callback event
   void removeProgressStepStartCallback(CoreI::Ident id); 


   /**
    * \defgroup DebugMessage Debug messages, for dev only
    * @{
    */
   //! Special event for dev only
   /*!
     \param event_type The type of signal to emit
   */
   virtual CoreI::Ident addDebugEventCallback(void(*fp)(void *, const Int &), void * userdata = nullptr) final ;
   //! method to remove a callback event
   void removeDebugEventCallback(CoreI::Ident id); 

   /**@}*/

   /**
    * \defgroup Desc Desc functions
    * @{
    */
   //! get EventDesc of an event
   /*!
     \param moduleName Target module name
     \param eventName 
     \return event 
   */
   virtual EventDesc getEvent(const String & moduleName, const String & eventName) final ;

   //! get events of a group
   /*!
     \param moduleName Target module name
     \param groupName Target group name
     \return eventDescList 
   */
   virtual EventDescList getEvents(const String & moduleName, const String & groupName) final ;

   //! get FunctionDesc of a function
   /*!
     \param moduleName Target module name
     \param functionName Target function name
     \return functionDesc 
   */
   virtual FunctionDesc getFunction(const String & moduleName, const String & functionName) final ;

   //! get functions of a group
   /*!
     \param moduleName Target module name
     \param groupName Target group name
     \return functions 
   */
   virtual FunctionDescList getFunctions(const String & moduleName, const String & groupName) final ;

   //! get a group desc from a specific module
   /*!
     \param moduleName Target module name
     \param groupName Target group name
     \return group 
   */
   virtual GroupDesc getGroup(const String & moduleName, const String & groupName) final ;

   //! get all group desc of a module
   /*!
     \param moduleName Target module name
     \return groups 
   */
   virtual GroupDescList getGroups(const String & moduleName) final ;

   //! get TypeDescList from a module name
   /*!
     \param moduleName Target module name
     \return typeDescList 
   */
   virtual TypeDescList getModuleTypes(const String & moduleName) final ;

   //! get all modules desc
   /*!
     \return modules 
   */
   virtual ModuleDescList getModules() final ;

   //! get all modules name
   /*!
     \return modulesName 
   */
   virtual StringList getModulesName() final ;

   //! get TypeDesc from a type name
   /*!
     \param moduleName Target module name
     \param typeNameStr Target type name
     \return typeDesc 
   */
   virtual TypeDesc getType(const String & moduleName, const String & typeNameStr) final ;

   //! get attributes TypeDesc from a type name
   /*!
     \param moduleName Target module name
     \param typeNameStr Target type name
     \return attributes 
   */
   virtual StringPairList getTypeAttributes(const String & moduleName, const String & typeNameStr) final ;

   //! Ask the async EventManager to join the main thread, enableEventManagerAsync must be enable
   virtual void softStopAsyncEventManager() final ;

   /**@}*/

   /**
    * \defgroup Processing locker Set of functions to handle processing lock. It will lock a global mutex to ensure that all internal functions that need to access or modify current session entities will be locked
    * @{
    */
   //! Lock the mutex that ensure no processing is done between lock/unlock
   virtual void lockProcessing() final ;

   //! Try to lock the mutex that ensure no processing is done between lock/unlock, returns true if the mutex has been locked, false if it was already locked
   /*!
     \return locked True if the mutex has been successfully locked
   */
   virtual Bool tryLockProcessing() final ;

   //! Unlock the mutex that ensure no processing is done between lock/unlock
   virtual void unlockProcessing() final ;

   /**@}*/

   /**
    * \defgroup UI User Interface functions
    * @{
    */
   //! Invite the user to enter a string
   /*!
     \param msg Message to display
     \param defaultValue Message to display
     \return text The string entered by the user
   */
   virtual String askString(const String & msg, const String & defaultValue = "") final ;

   //! Ask a question which need a Yes/No answer
   /*!
     \param question Question to display
     \param defaultValue Default value (if interfactive mode is disabled)
     \return answer True if the user say Yes, else False
   */
   virtual Boolean askYesNo(const String & question, const Boolean & defaultValue = false) final ;

   //! Invite the user to choose one value between multiple choice
   /*!
     \param message Message to display
     \param values Possible values to choose
     \param defaultValue Default value index
     \return choice Index of the chosen value in the values list
   */
   virtual Int choose(const String & message, const StringList & values, const Int & defaultValue = 0) final ;

   //! Define a callback function to customize the captha which unlock automated functions in interactive products
   /*!
     \param callback The callback function
   */
   virtual void defineCaptchaCallback(CaptchaCallback callback) final ;

   //! Returns True if the script is in interactive mode, else returns false
   /*!
     \return interactive True if interactive, else false
   */
   virtual Boolean isInteractiveMode() final ;

   //! Display a message (or a MessageBox in GUI)
   /*!
     \param msg Message to display
   */
   virtual void message(const String & msg) final ;

   //! Switch between interactive mode and non-interactive mode, UI functions will no ask user on non-interactive mode and will return default values
   /*!
     \param interactive True if you want to enter interactive mode, else False
   */
   virtual void setInteractiveMode(const Boolean & interactive = true) final ;

   /**@}*/

   /**
    * \defgroup database 
    * @{
    */
   /*!
     \param entity The wanted entity
     \return exists True if it exists.
   */
   virtual Boolean entityExists(const Entity & entity) final ;

   //! returns all the entities on the database
   /*!
     \return entities All entities
   */
   virtual EntityList getAllEntities() final ;

   //! Get current (loaded) Pixyz file path
   /*!
     \return fileName The current Pixyz file
   */
   virtual FilePath getCurrentPiXYZFile() final ;

   //! returns the type id of the entity
   /*!
     \param entity The wanted entity
     \return type Type type of the entity
   */
   virtual EntityType getEntityType(const Entity & entity) final ;

   //! returns the type name of the entity
   /*!
     \param entity The wanted entity
     \return type Name of the entity type
   */
   virtual String getEntityTypeString(const Entity & entity) final ;

   //! Get the database stats
   /*!
     \return stats 
   */
   virtual IntListList getTypeStats() final ;

   //! Return true, if the current (loaded) file has been modified since last load or save
   /*!
     \return modified True if the file is modified
   */
   virtual Boolean isCurrentPiXYZFileModified() final ;

   //! Load a new scene
   /*!
     \param fileName Path to load the file
   */
   virtual void load(const FilePath & fileName) final ;

   //! Lock Entity registration, use with Caution. All entities created after this call will not be saved on .pxz file and will not be listed as existing entities on the Database. Be careful to not references these entities with other registered entities
   virtual void lockEntityRegistration() final ;

   //! Save the scene
   /*!
     \param fileName Path to save the file
   */
   virtual void save(const OutputFilePath & fileName) final ;

   //! Unlock Entity registration
   virtual void unlockEntityRegistration() final ;

   /**@}*/

   /**
    * \defgroup license license utils functions
    * @{
    */
   //! Add a license token to the list of wanted optional tokens
   /*!
     \param tokenName Wanted token
   */
   virtual void addWantedToken(const String & tokenName) final ;

   //! check the current license
   /*!
     \return valid 
   */
   virtual Boolean checkLicense() final ;

   //! Check if authentification on the Web license API is sucessfull
   /*!
     \param login WEB account login
     \param password WEB account password
     \return valid 
   */
   virtual Boolean checkWebLogin(const String & login, const Password & password) final ;

   //! Configure the license server to use to get floating licenses
   /*!
     \param address Server address
     \param port Server port
     \param flexLM Enable FlexLM license server
   */
   virtual void configureLicenseServer(const String & address, const UShort & port, const Boolean & flexLM = true) final ;

   //! Create an activation code to generate an offline license
   /*!
     \param filePath Path to write the activation code
   */
   virtual void generateActivationCode(const OutputFilePath & filePath) final ;

   //! Create an deactivation code to release the license from this machine
   /*!
     \param filePath Path to write the deactivation code
   */
   virtual void generateDeactivationCode(const OutputFilePath & filePath) final ;

   //! get information on current installed license
   /*!
     \return licenseInfos 
   */
   virtual LicenseInfos getCurrentLicenseInfos() final ;

   //! Get current license server
   /*!
     \return serverHost Server host name or IP
     \return serverPort Server port
     \return useFlexLM Set to true if flexLM server
   */
   virtual getLicenseServerReturn getLicenseServer() final ;

   //! install a new license
   /*!
     \param licensePath Path of the license file
   */
   virtual void installLicense(const FilePath & licensePath) final ;

   //! Get the list of actually owned license tokens
   /*!
     \return ownedTokens Owned token list
   */
   virtual StringList listOwnedTokens() final ;

   //! Get the list of license tokens for this product
   /*!
     \param onlyMandatory If True, optional tokens will not be returned
     \return tokens Token list
   */
   virtual StringList listTokens(const Bool & onlyMandatory = false) final ;

   //! Get the list of license token configured to be requested at initialization
   /*!
     \return tokens Token list
   */
   virtual StringList listWantedTokens() final ;

   //! Ensure that a license token is available, useful to be sure to own floatting licence tokens
   /*!
     \param tokenName Token name
   */
   virtual void needToken(const String & tokenName) final ;

   //! Returns True if we own a token, without requesting it
   /*!
     \param tokenName Token name
     \return owned True if the token is owned
   */
   virtual Boolean ownToken(const String & tokenName) final ;

   //! Release an optional license token
   /*!
     \param tokenName Token name
   */
   virtual void releaseToken(const String & tokenName) final ;

   //! release License owned by user WEB account
   /*!
     \param login WEB account login
     \param password WEB account password
     \param id WEB license id
   */
   virtual void releaseWebLicense(const String & login, const Password & password, const Ident & id) final ;

   //! remove a license token from the list of wanted optional tokens
   /*!
     \param tokenName Unwanted token
   */
   virtual void removeWantedToken(const String & tokenName) final ;

   //! request License owned by user WEB account
   /*!
     \param login WEB account login
     \param password WEB account password
     \param id WEB license id
   */
   virtual void requestWebLicense(const String & login, const Password & password, const Ident & id) final ;

   //! Retrieves License owned by user WEB account
   /*!
     \param login WEB account login
     \param password WEB account password
     \return licenses 
   */
   virtual WebLicenseInfoList retrieveWebLicenses(const String & login, const Password & password) final ;

   //! Returns True if a token is owned by the product, request will be done if missing
   /*!
     \param tokenName Token name
     \return valid 
   */
   virtual Bool tokenValid(const String & tokenName) final ;

   /**@}*/

   /**
    * \defgroup parallel Parallel job function
    * @{
    */
   //! Add a job to a parallel session
   /*!
     \param session 
     \param jobCallback 
     \param data 
   */
   virtual void parallelAddJob(const ParallelSession & session, ParallelCallback jobCallback, const Ptr & data) final ;

   //! Ends a parallel session after waiting for all jobs to finish
   /*!
     \param session 
   */
   virtual void parallelFinish(const ParallelSession & session) final ;

   //! Starts a new parallel session
   /*!
     \param progression Enable progression for the parallel session
     \param name Name of the parallel session
     \param jobCount Count of parallel jobs if known (for progression)
     \return session 
   */
   virtual ParallelSession parallelStart(const Boolean & progression = false, const String & name = "Parallel session", const Int & jobCount = -1) final ;

   /**@}*/

   /**
    * \defgroup pipeline pipeline functions
    * @{
    */
   //! Return a complete output file path for Pixyz Pipeline, this function is useful for online usage when you know where is the output directory
   /*!
     \param fileName The desired file name (suffix of the path)
     \param data Optional data associated with file
     \return filePath The complete generated file path
   */
   virtual OutputFilePath getOutputFilePath(const String & fileName, const String & data = "none") final ;

   /**@}*/

   /**
    * \defgroup plugins plugins utils functions
    * @{
    */
   //! Generate a ModuleDesc from an .xml description
   /*!
     \param xmlPath .xml file path
     \param addToModules 
     \return description 
   */
   virtual ModuleDesc getModuleDescFromXML(const FilePath & xmlPath, const Boolean & addToModules) final ;

   //! Remove a module added via getModuleDescFromXML
   /*!
     \param module Module name
   */
   virtual void removeModule(const String & module) final ;

   /**@}*/

   /**
    * \defgroup progress Progress bar tools
    * @{
    */
   //! Leave current progression level
   virtual void popProgression() final ;

   //! Create a new progression level
   /*!
     \param stepCount Step count
     \param progressName Name of the progression step
   */
   virtual void pushProgression(const Int & stepCount, const String & progressName = "") final ;

   //! Add a step to current progression level
   /*!
     \param stepCount Step count
   */
   virtual void stepProgression(const Int & stepCount = 1) final ;

   /**@}*/

   /**
    * \defgroup properties properties related function
    * @{
    */
   //! Add a custom property to an entity that support custom properties
   /*!
     \param entity An entity that support custom properties
     \param name Name of the custom property
     \param value Value of the custom property
     \param type Type of the custom property
   */
   virtual void addCustomProperty(const Entity & entity, const String & name, const String & value = "", const PropertyType & type = PropertyType::STRING) final ;

   //! Returns the value of a module property
   /*!
     \param module Name of the module
     \param propertyName The property name
     \return propertyValue The property value
   */
   virtual String getModuleProperty(const String & module, const String & propertyName) final ;

   //! Returns the value of a module property
   /*!
     \param module Name of the module
     \param propertyName The property name
     \return propertyInfo The property info
   */
   virtual PropertyInfo getModulePropertyInfo(const String & module, const String & propertyName) final ;

   //! Get the property value on entities (if the property is not set on an entity, defaultValue is returned)
   /*!
     \param entities List of entities
     \param propertyName The property name
     \param defaultValue Default value to return if the property does not exist on an entity
     \return values Property value on each entity
   */
   virtual StringList getProperties(const EntityList & entities, const String & propertyName, const String & defaultValue = "") final ;

   //! Get a property value as String on an entity (error if the property does not exist on the entity)
   /*!
     \param entity The entity
     \param propertyName The property name
     \return value The property value as String
   */
   virtual String getProperty(const Entity & entity, const String & propertyName) final ;

   //! Get a property info on an entity (error if the property does not exist on the entity)
   /*!
     \param entity The entity
     \param propertyName The property name
     \return propertyInfo The property info
   */
   virtual PropertyInfo getPropertyInfo(const Entity & entity, const String & propertyName) final ;

   /*!
     \param entityId An entity that support properties
     \param customPropertyName Name of the custom property
     \return propertyFound True if the enity has the custom propery, else False
   */
   virtual Boolean hasCustomProperty(const Entity & entityId, const String & customPropertyName) final ;

   //! Return true if the property was found on the occurrence, will not throw any exception except if the entity does not exist.
   /*!
     \param entity An entity that support properties
     \param propertyName Name of the property
     \return propertyFound True if the entity has the property asked, else False
   */
   virtual Boolean hasProperty(const Entity & entity, const String & propertyName) final ;

   //! Returns the informations of a module property
   /*!
     \param enumType The real enum type number (ie. The one return in subtype of PropertyInfo)
     \return enumPropertyInfo The enum property info
   */
   virtual EnumPropertyInfo listEnumLabels(const Int & enumType) final ;

   //! Returns all the properties in the given module
   /*!
     \param module Name of the module
     \return properties List of module properties info
   */
   virtual PropertyInfoList listModuleProperties(const String & module) final ;

   //! Returns the names and values of the properties available on an entity
   /*!
     \param entity Entity to list
     \return properties List of available properties info
   */
   virtual PropertyInfoList listProperties(const Entity & entity) final ;

   //! Returns the names and values of the properties available on multiple entities
   /*!
     \param entities Entities to list
     \return properties List of available properties info
   */
   virtual PropertyInfoListList listPropertiesBatch(const EntityList & entities) final ;

   //! Remove a custom property from an entity that support custom properties
   /*!
     \param entity An entity that support custom properties
     \param name Name of the custom property
   */
   virtual void removeCustomProperty(const Entity & entity, const String & name) final ;

   //! Restore the default value of a module property
   /*!
     \param module Name of the module
     \param propertyName The property name
     \return value The property value as String
   */
   virtual String restoreModulePropertyDefaultValue(const String & module, const String & propertyName) final ;

   //! Set the value of a module property
   /*!
     \param module Name of the module
     \param propertyName The property name
     \param propertyValue The property value
     \return value The property value as String
   */
   virtual String setModuleProperty(const String & module, const String & propertyName, const String & propertyValue) final ;

   //! Set a property value on an entity
   /*!
     \param entity The entity
     \param propertyName The property name
     \param propertyValue The property value
     \return value The property value as String
   */
   virtual String setProperty(const Entity & entity, const String & propertyName, const String & propertyValue) final ;

   //! Return true if an entity support custom properties
   /*!
     \param entity An entity
     \return support True if the entity support custom properties, else False
   */
   virtual Boolean supportCustomProperties(const Entity & entity) final ;

   //! Unset an entity's property
   /*!
     \param entity The entity
     \param propertyName The property name
   */
   virtual void unsetProperty(const Entity & entity, const String & propertyName) final ;

   /**@}*/

   /**
    * \defgroup system System utility functions
    * @{
    */
   //! returns available memory
   /*!
     \return availVirt Available virtual memory in bytes
     \return totalVirt Total virtual memory in bytes
     \return availPhys Available physical memory in bytes
     \return totalPhys Total physical memory in bytes
   */
   virtual availableMemoryReturn availableMemory() final ;

   //! check for software update
   /*!
     \return newVersionAvailable True if there is a new version available of this product
     \return newVersion New version value
     \return newVersionLink Link to download the new version
   */
   virtual checkForUpdatesReturn checkForUpdates() final ;

   //! remove all other session temporary directories (warning: make sure that no other instance of pixyz is running
   virtual void clearOtherTemporaryDirectories() final ;

   //! get the Pixyz custom version tag
   /*!
     \return customVersionTag 
   */
   virtual String getCustomVersionTag() final ;

   //! Returns the memory usage peak of the current process in MB ( only available on windows yet )
   /*!
     \return peakWorkingSet Maximum physical memory used by the process until now (in MB)
   */
   virtual Long getMemoryUsagePeak() final ;

   //! get the Pixyz website URL
   /*!
     \return url 
   */
   virtual String getPixyzWebsiteURL() final ;

   //! get the Pixyz product name
   /*!
     \return productName 
   */
   virtual String getProductName() final ;

   //! get the Pixyz temp directory (server side directory in case of remote access)
   /*!
     \return tmpDir 
   */
   virtual String getTempDirectory() final ;

   //! get the Pixyz product version
   /*!
     \return version 
   */
   virtual String getVersion() final ;

   //! push custom analytic event (Only for authorized products)
   /*!
     \param name Analytic event name
     \param data Analytic event data
   */
   virtual void pushAnalytic(const String & name, const String & data = "") final ;

   //! Remove a directory and all its contents
   /*!
     \param path Path to the directory to remove
   */
   virtual void removeDirectory(const DirectoryPath & path) final ;

   //! Set the process thread. Use this function when you want to get progress changed callbacks from another thread as the one you initialized Pixyz on.
   virtual void setCurrentThreadAsProcessThread() final ;

   /**@}*/

   /**
    * \defgroup undo/redo Undo/redo functions
    * @{
    */
   //! Clear undo/redo history
   virtual void clearUndoRedo() final ;

   //! End current undo/redo step
   virtual void endUndoRedoStep() final ;

   //! Get the history of actions stack
   /*!
     \return redoStack 
   */
   virtual StringList getRedoStack() final ;

   //! Get the history of actions stack
   /*!
     \return undoStack 
   */
   virtual StringList getUndoStack() final ;

   //! Has recording step
   /*!
     \return hasRecordingStep True if there is recoding step, else False
   */
   virtual Boolean hasRecordingStep() final ;

   //! redo some steps
   /*!
     \param count 
   */
   virtual void redo(const UInt & count = 1) final ;

   //! Start a new undo/redo step
   /*!
     \param stepName 
   */
   virtual void startUndoRedoStep(const String & stepName) final ;

   //! Stop process (works if there is recording step)
   virtual void stopProcess() final ;

   //! Toggle undo/redo
   virtual void toggleUndoRedo() final ;

   //! undo some steps
   /*!
     \param count 
   */
   virtual void undo(const UInt & count = 1) final ;

   //! emitted when the undo/redo stack has changed, basically when a step recording is finished or when an undo or redo is performed
   virtual CoreI::Ident addUndoRedoStackChangedCallback(void(*fp)(void *), void * userdata = nullptr) final ;
   //! method to remove a callback event
   void removeUndoRedoStackChangedCallback(CoreI::Ident id); 

   /**@}*/

   /**
    * \defgroup utils Utils functions
    * @{
    */
   //! Returns a unique color associated with an index
   /*!
     \param index Index of the color (index must be less than 2^24)
     \return color The unique color associated to the given index
   */
   virtual Color getColorFromIndex(const Int & index) final ;

   /**@}*/

   /**
    * \defgroup verbose verbose functions
    * @{
    */
   //! add a console verbose level
   /*!
     \param level Verbose level
   */
   virtual void addConsoleVerbose(const Verbose & level) final ;

   //! add a log file verbose level
   /*!
     \param level Verbose level
   */
   virtual void addLogFileVerbose(const Verbose & level) final ;

   //! add a session log file (lastSession.log) verbose level
   /*!
     \param level Verbose level
   */
   virtual void addSessionLogFileVerbose(const Verbose & level) final ;

   //! Set new configuration for the Interface Logger
   /*!
     \param enableFunction If true, the called function names will be print
     \param enableParameters If true, the called function parameters will be print (only if enableFunction=true too)
     \param enableExecutionTime If true, the called functions execution times will be print
   */
   virtual void configureInterfaceLogger(const Boolean & enableFunction, const Boolean & enableParameters, const Boolean & enableExecutionTime) final ;

   //! Get the current Interface Logger configuration
   /*!
     \return functionEnabled True if the called function names are printed
     \return parametersEnabled True if the called function parameters are printed
     \return executionTimeEnabled True if the called functions execution times are printed
   */
   virtual getInterfaceLoggerConfigurationReturn getInterfaceLoggerConfiguration() final ;

   //! get the path of the log file
   /*!
     \return path Path of the log file
   */
   virtual OutputFilePath getLogFile() final ;

   //! log a message to Pixyz output
   /*!
     \param message Message to log
     \param level Verbose level
   */
   virtual void log(const String & message, const Verbose & level) final ;

   //! remove a console verbose level
   /*!
     \param level Verbose level
   */
   virtual void removeConsoleVerbose(const Verbose & level) final ;

   //! remove a log file verbose level
   /*!
     \param level Verbose level
   */
   virtual void removeLogFileVerbose(const Verbose & level) final ;

   //! remove a session log file (lastSession.log) verbose level
   /*!
     \param level Verbose level
   */
   virtual void removeSessionLogFileVerbose(const Verbose & level) final ;

   //! set the path of the core dump file that will be written when a crash occurs (default=none)
   /*!
     \param path Path of the core dump file
   */
   virtual void setCoreDumpFile(const OutputFilePath & path) final ;

   //! set the path of the log file
   /*!
     \param path Path of the log file
   */
   virtual void setLogFile(const OutputFilePath & path) final ;

   /**@}*/

private:
   friend class PiXYZ::PiXYZAPI;
   CoreInterface(void * session);
   void * _session;
};

PXZ_MODULE_END



#endif
