// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_CORE_INTERFACE_COREINTERFACE_C_H_
#define _PXZ_CORE_INTERFACE_COREINTERFACE_C_H_

#include "CoreTypes_c.h"

PXZ_EXPORTED char * Core_getLastError();

// Clone an entity
PXZ_EXPORTED Core_Entity Core_cloneEntity(Session * pxzSession, Core_Entity entity);
PXZ_EXPORTED void Core_configureFunctionLogger(Session * pxzSession, Core_String functionName, Core_Boolean enableFunction, Core_Boolean enableParameters, Core_Boolean enableExecutionTime);
// Create an entity
PXZ_EXPORTED Core_Entity Core_createEntity(Session * pxzSession, Core_EntityType type);
// Delete a set of entities
PXZ_EXPORTED void Core_deleteEntities(Session * pxzSession, Core_EntityList entities);
// Clear all the current session (all unsaved work will be lost)
PXZ_EXPORTED void Core_resetSession(Session * pxzSession);
// Returns true if the user has made changes to the project
PXZ_EXPORTED Core_Bool Core_unsavedUserChanges(Session * pxzSession);
// emitted after a property is changed
   /*!
     \param entity Entity changed
     \param property Property changed
     \param entityType Type of the entity changed
   */
PXZ_EXPORTED Core_Ident Core_addAfterEntityPropertyChangedCallback(Session * pxzSession, void(*fp)(void *, Core_Entity, Core_String, Core_Int), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Core_removeAfterEntityPropertyChangedCallback(Session * pxzSession, Core_Ident id);

// emitted after a module is changed
   /*!
     \param module Module changed
     \param property Property changed
   */
PXZ_EXPORTED Core_Ident Core_addAfterModulePropertyChangedCallback(Session * pxzSession, void(*fp)(void *, Core_String, Core_String), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Core_removeAfterModulePropertyChangedCallback(Session * pxzSession, Core_Ident id);

// emitted when pixyz is closed
PXZ_EXPORTED Core_Ident Core_addAtExitCallback(Session * pxzSession, void(*fp)(void *), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Core_removeAtExitCallback(Session * pxzSession, Core_Ident id);

// emitted before a property is changed
   /*!
     \param entity Entity changed
     \param property Property changed
   */
PXZ_EXPORTED Core_Ident Core_addBeforeEntityPropertyChangedCallback(Session * pxzSession, void(*fp)(void *, Core_Entity, Core_String), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Core_removeBeforeEntityPropertyChangedCallback(Session * pxzSession, Core_Ident id);

// emitted before a module is changed
   /*!
     \param module Module changed
     \param property Property changed
   */
PXZ_EXPORTED Core_Ident Core_addBeforeModulePropertyChangedCallback(Session * pxzSession, void(*fp)(void *, Core_String, Core_String), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Core_removeBeforeModulePropertyChangedCallback(Session * pxzSession, Core_Ident id);

// emitted just before pixyz's session reset
PXZ_EXPORTED Core_Ident Core_addBeforeSessionResetCallback(Session * pxzSession, void(*fp)(void *), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Core_removeBeforeSessionResetCallback(Session * pxzSession, Core_Ident id);

// Current loaded file is modified
PXZ_EXPORTED Core_Ident Core_addCurrentFileChangedCallback(Session * pxzSession, void(*fp)(void *), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Core_removeCurrentFileChangedCallback(Session * pxzSession, Core_Ident id);

// emitted before entering the unsafe mode, during this step accesses to the scene may be unsafe
PXZ_EXPORTED Core_Ident Core_addEnteringUnsafeModeCallback(Session * pxzSession, void(*fp)(void *), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Core_removeEnteringUnsafeModeCallback(Session * pxzSession, Core_Ident id);

// emitted when we leave the unsafe mode
PXZ_EXPORTED Core_Ident Core_addLeavingUnsafeModeCallback(Session * pxzSession, void(*fp)(void *), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Core_removeLeavingUnsafeModeCallback(Session * pxzSession, Core_Ident id);

// sends all Pixyz console message
   /*!
     \param text Message content
     \param verboseLevel Verbose level
   */
PXZ_EXPORTED Core_Ident Core_addOnConsoleMessageCallback(Session * pxzSession, void(*fp)(void *, Core_String, Core_Verbose), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Core_removeOnConsoleMessageCallback(Session * pxzSession, Core_Ident id);

// emitted when pixyz's session is reset
PXZ_EXPORTED Core_Ident Core_addOnSessionResetCallback(Session * pxzSession, void(*fp)(void *), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Core_removeOnSessionResetCallback(Session * pxzSession, Core_Ident id);

// emits the progress of the progress bar
   /*!
     \param progress Current progression
   */
PXZ_EXPORTED Core_Ident Core_addProgressChangedCallback(Session * pxzSession, void(*fp)(void *, Core_Int), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Core_removeProgressChangedCallback(Session * pxzSession, Core_Ident id);

// emits the name of finished step
PXZ_EXPORTED Core_Ident Core_addProgressStepFinishedCallback(Session * pxzSession, void(*fp)(void *), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Core_removeProgressStepFinishedCallback(Session * pxzSession, Core_Ident id);

// emits the name of starting step
   /*!
     \param stepName Name of the started step
   */
PXZ_EXPORTED Core_Ident Core_addProgressStepStartCallback(Session * pxzSession, void(*fp)(void *, Core_String), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Core_removeProgressStepStartCallback(Session * pxzSession, Core_Ident id);


// ----------------------------------------------------
// DebugMessage
// Debug messages, for dev only
// ----------------------------------------------------

// Special event for dev only
   /*!
     \param event_type The type of signal to emit
   */
PXZ_EXPORTED Core_Ident Core_addDebugEventCallback(Session * pxzSession, void(*fp)(void *, Core_Int), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Core_removeDebugEventCallback(Session * pxzSession, Core_Ident id);


// ----------------------------------------------------
// Desc
// Desc functions
// ----------------------------------------------------

// get EventDesc of an event
PXZ_EXPORTED Core_EventDesc Core_getEvent(Session * pxzSession, Core_String moduleName, Core_String eventName);
// get events of a group
PXZ_EXPORTED Core_EventDescList Core_getEvents(Session * pxzSession, Core_String moduleName, Core_String groupName);
// get FunctionDesc of a function
PXZ_EXPORTED Core_FunctionDesc Core_getFunction(Session * pxzSession, Core_String moduleName, Core_String functionName);
// get functions of a group
PXZ_EXPORTED Core_FunctionDescList Core_getFunctions(Session * pxzSession, Core_String moduleName, Core_String groupName);
// get a group desc from a specific module
PXZ_EXPORTED Core_GroupDesc Core_getGroup(Session * pxzSession, Core_String moduleName, Core_String groupName);
// get all group desc of a module
PXZ_EXPORTED Core_GroupDescList Core_getGroups(Session * pxzSession, Core_String moduleName);
// get TypeDescList from a module name
PXZ_EXPORTED Core_TypeDescList Core_getModuleTypes(Session * pxzSession, Core_String moduleName);
// get all modules desc
PXZ_EXPORTED Core_ModuleDescList Core_getModules(Session * pxzSession);
// get all modules name
PXZ_EXPORTED Core_StringList Core_getModulesName(Session * pxzSession);
// get TypeDesc from a type name
PXZ_EXPORTED Core_TypeDesc Core_getType(Session * pxzSession, Core_String moduleName, Core_String typeNameStr);
// get attributes TypeDesc from a type name
PXZ_EXPORTED Core_StringPairList Core_getTypeAttributes(Session * pxzSession, Core_String moduleName, Core_String typeNameStr);
// Ask the async EventManager to join the main thread, enableEventManagerAsync must be enable
PXZ_EXPORTED void Core_softStopAsyncEventManager(Session * pxzSession);

// ----------------------------------------------------
// Processing locker
// Set of functions to handle processing lock. It will lock a global mutex to ensure that all internal functions that need to access or modify current session entities will be locked
// ----------------------------------------------------

// Lock the mutex that ensure no processing is done between lock/unlock
PXZ_EXPORTED void Core_lockProcessing(Session * pxzSession);
// Try to lock the mutex that ensure no processing is done between lock/unlock, returns true if the mutex has been locked, false if it was already locked
PXZ_EXPORTED Core_Bool Core_tryLockProcessing(Session * pxzSession);
// Unlock the mutex that ensure no processing is done between lock/unlock
PXZ_EXPORTED void Core_unlockProcessing(Session * pxzSession);

// ----------------------------------------------------
// UI
// User Interface functions
// ----------------------------------------------------

// Invite the user to enter a string
PXZ_EXPORTED Core_String Core_askString(Session * pxzSession, Core_String msg, Core_String defaultValue);
// Ask a question which need a Yes/No answer
PXZ_EXPORTED Core_Boolean Core_askYesNo(Session * pxzSession, Core_String question, Core_Boolean defaultValue);
// Invite the user to choose one value between multiple choice
PXZ_EXPORTED Core_Int Core_choose(Session * pxzSession, Core_String message, Core_StringList values, Core_Int defaultValue);
// Define a callback function to customize the captha which unlock automated functions in interactive products
PXZ_EXPORTED void Core_defineCaptchaCallback(Session * pxzSession, Core_CaptchaCallback callback);
// Returns True if the script is in interactive mode, else returns false
PXZ_EXPORTED Core_Boolean Core_isInteractiveMode(Session * pxzSession);
// Display a message (or a MessageBox in GUI)
PXZ_EXPORTED void Core_message(Session * pxzSession, Core_String msg);
// Switch between interactive mode and non-interactive mode, UI functions will no ask user on non-interactive mode and will return default values
PXZ_EXPORTED void Core_setInteractiveMode(Session * pxzSession, Core_Boolean interactive);

// ----------------------------------------------------
// database
// ----------------------------------------------------

PXZ_EXPORTED Core_Boolean Core_entityExists(Session * pxzSession, Core_Entity entity);
// returns all the entities on the database
PXZ_EXPORTED Core_EntityList Core_getAllEntities(Session * pxzSession);
// Get current (loaded) Pixyz file path
PXZ_EXPORTED Core_FilePath Core_getCurrentPiXYZFile(Session * pxzSession);
// returns the type id of the entity
PXZ_EXPORTED Core_EntityType Core_getEntityType(Session * pxzSession, Core_Entity entity);
// returns the type name of the entity
PXZ_EXPORTED Core_String Core_getEntityTypeString(Session * pxzSession, Core_Entity entity);
// Get the database stats
PXZ_EXPORTED Core_IntListList Core_getTypeStats(Session * pxzSession);
// Return true, if the current (loaded) file has been modified since last load or save
PXZ_EXPORTED Core_Boolean Core_isCurrentPiXYZFileModified(Session * pxzSession);
// Load a new scene
PXZ_EXPORTED void Core_load(Session * pxzSession, Core_FilePath fileName);
// Lock Entity registration, use with Caution. All entities created after this call will not be saved on .pxz file and will not be listed as existing entities on the Database. Be careful to not references these entities with other registered entities
PXZ_EXPORTED void Core_lockEntityRegistration(Session * pxzSession);
// Save the scene
PXZ_EXPORTED void Core_save(Session * pxzSession, Core_OutputFilePath fileName);
// Unlock Entity registration
PXZ_EXPORTED void Core_unlockEntityRegistration(Session * pxzSession);

// ----------------------------------------------------
// license
// license utils functions
// ----------------------------------------------------

// Add a license token to the list of wanted optional tokens
PXZ_EXPORTED void Core_addWantedToken(Session * pxzSession, Core_String tokenName);
// check the current license
PXZ_EXPORTED Core_Boolean Core_checkLicense(Session * pxzSession);
// Check if authentification on the Web license API is sucessfull
PXZ_EXPORTED Core_Boolean Core_checkWebLogin(Session * pxzSession, Core_String login, Core_Password password);
// Configure the license server to use to get floating licenses
PXZ_EXPORTED void Core_configureLicenseServer(Session * pxzSession, Core_String address, Core_UShort port, Core_Boolean flexLM);
// Create an activation code to generate an offline license
PXZ_EXPORTED void Core_generateActivationCode(Session * pxzSession, Core_OutputFilePath filePath);
// Create an deactivation code to release the license from this machine
PXZ_EXPORTED void Core_generateDeactivationCode(Session * pxzSession, Core_OutputFilePath filePath);
// get information on current installed license
PXZ_EXPORTED Core_LicenseInfos Core_getCurrentLicenseInfos(Session * pxzSession);
// Get current license server
typedef struct {
   Core_String serverHost;
   Core_UShort serverPort;
   Core_Bool useFlexLM;
} Core_getLicenseServerReturn;
PXZ_EXPORTED Core_getLicenseServerReturn Core_getLicenseServer(Session * pxzSession);
// install a new license
PXZ_EXPORTED void Core_installLicense(Session * pxzSession, Core_FilePath licensePath);
// Get the list of actually owned license tokens
PXZ_EXPORTED Core_StringList Core_listOwnedTokens(Session * pxzSession);
// Get the list of license tokens for this product
PXZ_EXPORTED Core_StringList Core_listTokens(Session * pxzSession, Core_Bool onlyMandatory);
// Get the list of license token configured to be requested at initialization
PXZ_EXPORTED Core_StringList Core_listWantedTokens(Session * pxzSession);
// Ensure that a license token is available, useful to be sure to own floatting licence tokens
PXZ_EXPORTED void Core_needToken(Session * pxzSession, Core_String tokenName);
// Returns True if we own a token, without requesting it
PXZ_EXPORTED Core_Boolean Core_ownToken(Session * pxzSession, Core_String tokenName);
// Release an optional license token
PXZ_EXPORTED void Core_releaseToken(Session * pxzSession, Core_String tokenName);
// release License owned by user WEB account
PXZ_EXPORTED void Core_releaseWebLicense(Session * pxzSession, Core_String login, Core_Password password, Core_Ident id);
// remove a license token from the list of wanted optional tokens
PXZ_EXPORTED void Core_removeWantedToken(Session * pxzSession, Core_String tokenName);
// request License owned by user WEB account
PXZ_EXPORTED void Core_requestWebLicense(Session * pxzSession, Core_String login, Core_Password password, Core_Ident id);
// Retrieves License owned by user WEB account
PXZ_EXPORTED Core_WebLicenseInfoList Core_retrieveWebLicenses(Session * pxzSession, Core_String login, Core_Password password);
// Returns True if a token is owned by the product, request will be done if missing
PXZ_EXPORTED Core_Bool Core_tokenValid(Session * pxzSession, Core_String tokenName);

// ----------------------------------------------------
// parallel
// Parallel job function
// ----------------------------------------------------

// Add a job to a parallel session
PXZ_EXPORTED void Core_parallelAddJob(Session * pxzSession, Core_ParallelSession session, Core_ParallelCallback jobCallback, Core_Ptr data);
// Ends a parallel session after waiting for all jobs to finish
PXZ_EXPORTED void Core_parallelFinish(Session * pxzSession, Core_ParallelSession session);
// Starts a new parallel session
PXZ_EXPORTED Core_ParallelSession Core_parallelStart(Session * pxzSession, Core_Boolean progression, Core_String name, Core_Int jobCount);

// ----------------------------------------------------
// pipeline
// pipeline functions
// ----------------------------------------------------

// Return a complete output file path for Pixyz Pipeline, this function is useful for online usage when you know where is the output directory
PXZ_EXPORTED Core_OutputFilePath Core_getOutputFilePath(Session * pxzSession, Core_String fileName, Core_String data);

// ----------------------------------------------------
// plugins
// plugins utils functions
// ----------------------------------------------------

// Generate a ModuleDesc from an .xml description
PXZ_EXPORTED Core_ModuleDesc Core_getModuleDescFromXML(Session * pxzSession, Core_FilePath xmlPath, Core_Boolean addToModules);
// Remove a module added via getModuleDescFromXML
PXZ_EXPORTED void Core_removeModule(Session * pxzSession, Core_String module);

// ----------------------------------------------------
// progress
// Progress bar tools
// ----------------------------------------------------

// Leave current progression level
PXZ_EXPORTED void Core_popProgression(Session * pxzSession);
// Create a new progression level
PXZ_EXPORTED void Core_pushProgression(Session * pxzSession, Core_Int stepCount, Core_String progressName);
// Add a step to current progression level
PXZ_EXPORTED void Core_stepProgression(Session * pxzSession, Core_Int stepCount);

// ----------------------------------------------------
// properties
// properties related function
// ----------------------------------------------------

// Add a custom property to an entity that support custom properties
PXZ_EXPORTED void Core_addCustomProperty(Session * pxzSession, Core_Entity entity, Core_String name, Core_String value, Core_PropertyType type);
// Returns the value of a module property
PXZ_EXPORTED Core_String Core_getModuleProperty(Session * pxzSession, Core_String module, Core_String propertyName);
// Returns the value of a module property
PXZ_EXPORTED Core_PropertyInfo Core_getModulePropertyInfo(Session * pxzSession, Core_String module, Core_String propertyName);
// Get the property value on entities (if the property is not set on an entity, defaultValue is returned)
PXZ_EXPORTED Core_StringList Core_getProperties(Session * pxzSession, Core_EntityList entities, Core_String propertyName, Core_String defaultValue);
// Get a property value as String on an entity (error if the property does not exist on the entity)
PXZ_EXPORTED Core_String Core_getProperty(Session * pxzSession, Core_Entity entity, Core_String propertyName);
// Get a property info on an entity (error if the property does not exist on the entity)
PXZ_EXPORTED Core_PropertyInfo Core_getPropertyInfo(Session * pxzSession, Core_Entity entity, Core_String propertyName);
PXZ_EXPORTED Core_Boolean Core_hasCustomProperty(Session * pxzSession, Core_Entity entityId, Core_String customPropertyName);
// Return true if the property was found on the occurrence, will not throw any exception except if the entity does not exist.
PXZ_EXPORTED Core_Boolean Core_hasProperty(Session * pxzSession, Core_Entity entity, Core_String propertyName);
// Returns the informations of a module property
PXZ_EXPORTED Core_EnumPropertyInfo Core_listEnumLabels(Session * pxzSession, Core_Int enumType);
// Returns all the properties in the given module
PXZ_EXPORTED Core_PropertyInfoList Core_listModuleProperties(Session * pxzSession, Core_String module);
// Returns the names and values of the properties available on an entity
PXZ_EXPORTED Core_PropertyInfoList Core_listProperties(Session * pxzSession, Core_Entity entity);
// Returns the names and values of the properties available on multiple entities
PXZ_EXPORTED Core_PropertyInfoListList Core_listPropertiesBatch(Session * pxzSession, Core_EntityList entities);
// Remove a custom property from an entity that support custom properties
PXZ_EXPORTED void Core_removeCustomProperty(Session * pxzSession, Core_Entity entity, Core_String name);
// Restore the default value of a module property
PXZ_EXPORTED Core_String Core_restoreModulePropertyDefaultValue(Session * pxzSession, Core_String module, Core_String propertyName);
// Set the value of a module property
PXZ_EXPORTED Core_String Core_setModuleProperty(Session * pxzSession, Core_String module, Core_String propertyName, Core_String propertyValue);
// Set a property value on an entity
PXZ_EXPORTED Core_String Core_setProperty(Session * pxzSession, Core_Entity entity, Core_String propertyName, Core_String propertyValue);
// Return true if an entity support custom properties
PXZ_EXPORTED Core_Boolean Core_supportCustomProperties(Session * pxzSession, Core_Entity entity);
// Unset an entity's property
PXZ_EXPORTED void Core_unsetProperty(Session * pxzSession, Core_Entity entity, Core_String propertyName);

// ----------------------------------------------------
// system
// System utility functions
// ----------------------------------------------------

// returns available memory
typedef struct {
   Core_Long availVirt;
   Core_Long totalVirt;
   Core_Long availPhys;
   Core_Long totalPhys;
} Core_availableMemoryReturn;
PXZ_EXPORTED Core_availableMemoryReturn Core_availableMemory(Session * pxzSession);
// check for software update
typedef struct {
   Core_Bool newVersionAvailable;
   Core_String newVersion;
   Core_String newVersionLink;
} Core_checkForUpdatesReturn;
PXZ_EXPORTED Core_checkForUpdatesReturn Core_checkForUpdates(Session * pxzSession);
// remove all other session temporary directories (warning: make sure that no other instance of pixyz is running
PXZ_EXPORTED void Core_clearOtherTemporaryDirectories(Session * pxzSession);
// get the Pixyz custom version tag
PXZ_EXPORTED Core_String Core_getCustomVersionTag(Session * pxzSession);
// Returns the memory usage peak of the current process in MB ( only available on windows yet )
PXZ_EXPORTED Core_Long Core_getMemoryUsagePeak(Session * pxzSession);
// get the Pixyz website URL
PXZ_EXPORTED Core_String Core_getPixyzWebsiteURL(Session * pxzSession);
// get the Pixyz product name
PXZ_EXPORTED Core_String Core_getProductName(Session * pxzSession);
// get the Pixyz temp directory (server side directory in case of remote access)
PXZ_EXPORTED Core_String Core_getTempDirectory(Session * pxzSession);
// get the Pixyz product version
PXZ_EXPORTED Core_String Core_getVersion(Session * pxzSession);
// push custom analytic event (Only for authorized products)
PXZ_EXPORTED void Core_pushAnalytic(Session * pxzSession, Core_String name, Core_String data);
// Remove a directory and all its contents
PXZ_EXPORTED void Core_removeDirectory(Session * pxzSession, Core_DirectoryPath path);
// Set the process thread. Use this function when you want to get progress changed callbacks from another thread as the one you initialized Pixyz on.
PXZ_EXPORTED void Core_setCurrentThreadAsProcessThread(Session * pxzSession);

// ----------------------------------------------------
// undo/redo
// Undo/redo functions
// ----------------------------------------------------

// Clear undo/redo history
PXZ_EXPORTED void Core_clearUndoRedo(Session * pxzSession);
// End current undo/redo step
PXZ_EXPORTED void Core_endUndoRedoStep(Session * pxzSession);
// Get the history of actions stack
PXZ_EXPORTED Core_StringList Core_getRedoStack(Session * pxzSession);
// Get the history of actions stack
PXZ_EXPORTED Core_StringList Core_getUndoStack(Session * pxzSession);
// Has recording step
PXZ_EXPORTED Core_Boolean Core_hasRecordingStep(Session * pxzSession);
// redo some steps
PXZ_EXPORTED void Core_redo(Session * pxzSession, Core_UInt count);
// Start a new undo/redo step
PXZ_EXPORTED void Core_startUndoRedoStep(Session * pxzSession, Core_String stepName);
// Stop process (works if there is recording step)
PXZ_EXPORTED void Core_stopProcess(Session * pxzSession);
// Toggle undo/redo
PXZ_EXPORTED void Core_toggleUndoRedo(Session * pxzSession);
// undo some steps
PXZ_EXPORTED void Core_undo(Session * pxzSession, Core_UInt count);
// emitted when the undo/redo stack has changed, basically when a step recording is finished or when an undo or redo is performed
PXZ_EXPORTED Core_Ident Core_addUndoRedoStackChangedCallback(Session * pxzSession, void(*fp)(void *), void * userdata = nullptr);
   //! method to remove a callback event
PXZ_EXPORTED void Core_removeUndoRedoStackChangedCallback(Session * pxzSession, Core_Ident id);


// ----------------------------------------------------
// utils
// Utils functions
// ----------------------------------------------------

// Returns a unique color associated with an index
PXZ_EXPORTED Core_Color Core_getColorFromIndex(Session * pxzSession, Core_Int index);

// ----------------------------------------------------
// verbose
// verbose functions
// ----------------------------------------------------

// add a console verbose level
PXZ_EXPORTED void Core_addConsoleVerbose(Session * pxzSession, Core_Verbose level);
// add a log file verbose level
PXZ_EXPORTED void Core_addLogFileVerbose(Session * pxzSession, Core_Verbose level);
// add a session log file (lastSession.log) verbose level
PXZ_EXPORTED void Core_addSessionLogFileVerbose(Session * pxzSession, Core_Verbose level);
// Set new configuration for the Interface Logger
PXZ_EXPORTED void Core_configureInterfaceLogger(Session * pxzSession, Core_Boolean enableFunction, Core_Boolean enableParameters, Core_Boolean enableExecutionTime);
// Get the current Interface Logger configuration
typedef struct {
   Core_Boolean functionEnabled;
   Core_Boolean parametersEnabled;
   Core_Boolean executionTimeEnabled;
} Core_getInterfaceLoggerConfigurationReturn;
PXZ_EXPORTED Core_getInterfaceLoggerConfigurationReturn Core_getInterfaceLoggerConfiguration(Session * pxzSession);
// get the path of the log file
PXZ_EXPORTED Core_OutputFilePath Core_getLogFile(Session * pxzSession);
// log a message to Pixyz output
PXZ_EXPORTED void Core_log(Session * pxzSession, Core_String message, Core_Verbose level);
// remove a console verbose level
PXZ_EXPORTED void Core_removeConsoleVerbose(Session * pxzSession, Core_Verbose level);
// remove a log file verbose level
PXZ_EXPORTED void Core_removeLogFileVerbose(Session * pxzSession, Core_Verbose level);
// remove a session log file (lastSession.log) verbose level
PXZ_EXPORTED void Core_removeSessionLogFileVerbose(Session * pxzSession, Core_Verbose level);
// set the path of the core dump file that will be written when a crash occurs (default=none)
PXZ_EXPORTED void Core_setCoreDumpFile(Session * pxzSession, Core_OutputFilePath path);
// set the path of the log file
PXZ_EXPORTED void Core_setLogFile(Session * pxzSession, Core_OutputFilePath path);



#endif
