// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_CORE_INTERFACE_ICOREINTERFACE_H_
#define _PXZ_CORE_INTERFACE_ICOREINTERFACE_H_

#include "CoreTypes.h"

namespace PiXYZ { class PiXYZAPI; }


PXZ_MODULE_BEGIN(CoreI)

class PXZ_EXPORTED ICoreInterface
{
public:
   virtual ~ICoreInterface() {}

   //! Clone an entity
   /*!
     \param entity The entity to clone
     \return clonedEntity The cloned entity
   */
   virtual Entity cloneEntity(const Entity & entity) = 0;

   /*!
     \param functionName 
     \param enableFunction 
     \param enableParameters 
     \param enableExecutionTime 
   */
   virtual void configureFunctionLogger(const String & functionName, const Boolean & enableFunction, const Boolean & enableParameters, const Boolean & enableExecutionTime) = 0;

   //! Create an entity
   /*!
     \param type The type of entity to create
     \return entity The created entity id
   */
   virtual Entity createEntity(const EntityType & type) = 0;

   //! Delete a set of entities
   /*!
     \param entities List of entity to delete
   */
   virtual void deleteEntities(const EntityList & entities) = 0;

   //! get all entities of a given type
   /*!
     \param type The type of entities to retrieve
     \param includeUnsubscribed Include unsubscribed entities
     \return entities The returned entity list
   */
   virtual EntityList getEntitiesByType(const EntityType & type, const Boolean & includeUnsubscribed) = 0;

   //! Clear all the current session (all unsaved work will be lost)
   virtual void resetSession() = 0;

   //! Returns true if the user has made changes to the project
   /*!
     \return hasChanged Boolean checking if the project has been modified
   */
   virtual Bool unsavedUserChanges() = 0;

   //! emitted after a property is changed
   /*!
     \param entity Entity changed
     \param property Property changed
     \param entityType Type of the entity changed
   */
   virtual CoreI::Ident addAfterEntityPropertyChangedCallback(void(*fp)(void *, const Entity &, const String &, const Int &), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void * removeAfterEntityPropertyChangedCallback(CoreI::Ident id); 

   //! emitted after a module is changed
   /*!
     \param module Module changed
     \param property Property changed
   */
   virtual CoreI::Ident addAfterModulePropertyChangedCallback(void(*fp)(void *, const String &, const String &), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void * removeAfterModulePropertyChangedCallback(CoreI::Ident id); 

   //! emitted just after an undo or redo operation
   virtual CoreI::Ident addAfterUndoRedoCallback(void(*fp)(void *), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void * removeAfterUndoRedoCallback(CoreI::Ident id); 

   //! emitted when pixyz is closed
   virtual CoreI::Ident addAtExitCallback(void(*fp)(void *), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void * removeAtExitCallback(CoreI::Ident id); 

   //! emitted before a property is changed
   /*!
     \param entity Entity changed
     \param property Property changed
   */
   virtual CoreI::Ident addBeforeEntityPropertyChangedCallback(void(*fp)(void *, const Entity &, const String &), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void * removeBeforeEntityPropertyChangedCallback(CoreI::Ident id); 

   //! emitted before a module is changed
   /*!
     \param module Module changed
     \param property Property changed
   */
   virtual CoreI::Ident addBeforeModulePropertyChangedCallback(void(*fp)(void *, const String &, const String &), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void * removeBeforeModulePropertyChangedCallback(CoreI::Ident id); 

   //! emitted just before pixyz's session reset
   virtual CoreI::Ident addBeforeSessionResetCallback(void(*fp)(void *), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void * removeBeforeSessionResetCallback(CoreI::Ident id); 

   //! emitted just before an undo or redo operation
   virtual CoreI::Ident addBeforeUndoRedoCallback(void(*fp)(void *), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void * removeBeforeUndoRedoCallback(CoreI::Ident id); 

   //! Current loaded file is modified
   virtual CoreI::Ident addCurrentFileChangedCallback(void(*fp)(void *), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void * removeCurrentFileChangedCallback(CoreI::Ident id); 

   //! emitted before entering the unsafe mode, during this step accesses to the scene may be unsafe
   virtual CoreI::Ident addEnteringUnsafeModeCallback(void(*fp)(void *), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void * removeEnteringUnsafeModeCallback(CoreI::Ident id); 

   //! emitted when we leave the unsafe mode
   virtual CoreI::Ident addLeavingUnsafeModeCallback(void(*fp)(void *), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void * removeLeavingUnsafeModeCallback(CoreI::Ident id); 

   //! sends all Pixyz console message
   /*!
     \param text Message content
     \param verboseLevel Verbose level
   */
   virtual CoreI::Ident addOnConsoleMessageCallback(void(*fp)(void *, const String &, const Verbose &), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void * removeOnConsoleMessageCallback(CoreI::Ident id); 

   //! emitted when pixyz's session is reset
   virtual CoreI::Ident addOnSessionResetCallback(void(*fp)(void *), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void * removeOnSessionResetCallback(CoreI::Ident id); 

   //! emits the progress of the progress bar
   /*!
     \param progress Current progression
   */
   virtual CoreI::Ident addProgressChangedCallback(void(*fp)(void *, const Int &), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void * removeProgressChangedCallback(CoreI::Ident id); 

   //! emits the name of finished step
   virtual CoreI::Ident addProgressStepFinishedCallback(void(*fp)(void *), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void * removeProgressStepFinishedCallback(CoreI::Ident id); 

   //! emits the name of starting step
   /*!
     \param stepName Name of the started step
   */
   virtual CoreI::Ident addProgressStepStartCallback(void(*fp)(void *, const String &), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void * removeProgressStepStartCallback(CoreI::Ident id); 


   /**
    * \defgroup DebugMessage Debug messages, for dev only
    * @{
    */
   //! Special event for dev only
   /*!
     \param event_type The type of signal to emit
   */
   virtual CoreI::Ident addDebugEventCallback(void(*fp)(void *, const Int &), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void * removeDebugEventCallback(CoreI::Ident id); 

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
   virtual EventDesc getEvent(const String & moduleName, const String & eventName) = 0;

   //! get events of a group
   /*!
     \param moduleName Target module name
     \param groupName Target group name
     \return eventDescList 
   */
   virtual EventDescList getEvents(const String & moduleName, const String & groupName) = 0;

   //! get FunctionDesc of a function
   /*!
     \param moduleName Target module name
     \param functionName Target function name
     \return functionDesc 
   */
   virtual FunctionDesc getFunction(const String & moduleName, const String & functionName) = 0;

   //! get functions of a group
   /*!
     \param moduleName Target module name
     \param groupName Target group name
     \return functions 
   */
   virtual FunctionDescList getFunctions(const String & moduleName, const String & groupName) = 0;

   //! get a group desc from a specific module
   /*!
     \param moduleName Target module name
     \param groupName Target group name
     \return group 
   */
   virtual GroupDesc getGroup(const String & moduleName, const String & groupName) = 0;

   //! get all group desc of a module
   /*!
     \param moduleName Target module name
     \return groups 
   */
   virtual GroupDescList getGroups(const String & moduleName) = 0;

   //! get TypeDescList from a module name
   /*!
     \param moduleName Target module name
     \return typeDescList 
   */
   virtual TypeDescList getModuleTypes(const String & moduleName) = 0;

   //! get all modules desc
   /*!
     \return modules 
   */
   virtual ModuleDescList getModules() = 0;

   //! get all modules name
   /*!
     \return modulesName 
   */
   virtual StringList getModulesName() = 0;

   //! get TypeDesc from a type name
   /*!
     \param moduleName Target module name
     \param typeNameStr Target type name
     \return typeDesc 
   */
   virtual TypeDesc getType(const String & moduleName, const String & typeNameStr) = 0;

   //! get attributes TypeDesc from a type name
   /*!
     \param moduleName Target module name
     \param typeNameStr Target type name
     \return attributes 
   */
   virtual StringPairList getTypeAttributes(const String & moduleName, const String & typeNameStr) = 0;

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
   virtual String askString(const String & msg, const String & defaultValue = "") = 0;

   //! Ask a question which need a Yes/No answer
   /*!
     \param question Question to display
     \param defaultValue Default value (if interfactive mode is disabled)
     \return answer True if the user say Yes, else False
   */
   virtual Boolean askYesNo(const String & question, const Boolean & defaultValue = false) = 0;

   //! Invite the user to choose one value between multiple choice
   /*!
     \param message Message to display
     \param values Possible values to choose
     \param defaultValue Default value index
     \return choice Index of the chosen value in the values list
   */
   virtual Int choose(const String & message, const StringList & values, const Int & defaultValue = 0) = 0;

   //! Define a callback function to customize the captha which unlock automated functions in interactive products
   /*!
     \param callback The callback function
   */
   virtual void defineCaptchaCallback(CaptchaCallback callback) = 0;

   //! Returns True if the script is in interactive mode, else returns false
   /*!
     \return interactive True if interactive, else false
   */
   virtual Boolean isInteractiveMode() = 0;

   //! Display a message (or a MessageBox in GUI)
   /*!
     \param msg Message to display
   */
   virtual void message(const String & msg) = 0;

   //! Switch between interactive mode and non-interactive mode, UI functions will no ask user on non-interactive mode and will return default values
   /*!
     \param interactive True if you want to enter interactive mode, else False
   */
   virtual void setInteractiveMode(const Boolean & interactive = true) = 0;

   /**@}*/

   /**
    * \defgroup database 
    * @{
    */
   //! returns true if the entity exists
   /*!
     \param entity The wanted entity
     \return exists True if it exists.
   */
   virtual Boolean entityExists(const Entity & entity) = 0;

   //! returns all the entities on the database
   /*!
     \return entities All entities
   */
   virtual EntityList getAllEntities() = 0;

   //! Get current (loaded) Pixyz file path
   /*!
     \return fileName The current Pixyz file
   */
   virtual FilePath getCurrentPiXYZFile() = 0;

   //! returns the type id of the entity
   /*!
     \param entity The wanted entity
     \return type Type type of the entity
   */
   virtual EntityType getEntityType(const Entity & entity) = 0;

   //! returns the type name of the entity
   /*!
     \param entity The wanted entity
     \return type Name of the entity type
   */
   virtual String getEntityTypeString(const Entity & entity) = 0;

   //! Get the database stats
   /*!
     \return stats 
   */
   virtual IntListList getTypeStats() = 0;

   //! Return true, if the current (loaded) file has been modified since last load or save
   /*!
     \return modified True if the file is modified
   */
   virtual Boolean isCurrentPiXYZFileModified() = 0;

   //! Load a new scene
   /*!
     \param fileName Path to load the file
   */
   virtual void load(const FilePath & fileName) = 0;

   //! Lock Entity registration, use with Caution. All entities created after this call will not be saved on .pxz file and will not be listed as existing entities on the Database. Be careful to not references these entities with other registered entities
   virtual void lockEntityRegistration() = 0;

   //! Save the scene
   /*!
     \param fileName Path to save the file
   */
   virtual void save(const OutputFilePath & fileName) = 0;

   //! Unlock Entity registration
   virtual void unlockEntityRegistration() = 0;

   /**@}*/

   /**
    * \defgroup license license utils functions
    * @{
    */
   //! Add a license token to the list of wanted tokens. The wanted tokens list is saved on disk in program data and is used at initialization. Prefer using 'core.needToken' instead.
   /*!
     \param tokenName Wanted token
   */
   virtual void addWantedToken(const String & tokenName) = 0;

   //! check the current license
   /*!
     \return valid 
   */
   virtual Boolean checkLicense() = 0;

   //! Check if authentification on the Web license API is sucessfull
   /*!
     \param login WEB account login
     \param password WEB account password
     \return valid 
   */
   virtual Boolean checkWebLogin(const String & login, const Password & password) = 0;

   //! Configure the license server to use to get floating licenses
   /*!
     \param address Server address
     \param port Server port
     \param flexLM Enable FlexLM license server
   */
   virtual void configureLicenseServer(const String & address, const UShort & port, const Boolean & flexLM = true) = 0;

   //! Create an activation code to generate an offline license
   /*!
     \param filePath Path to write the activation code
   */
   virtual void generateActivationCode(const OutputFilePath & filePath) = 0;

   //! Create an deactivation code to release the license from this machine
   /*!
     \param filePath Path to write the deactivation code
   */
   virtual void generateDeactivationCode(const OutputFilePath & filePath) = 0;

   //! get information on current installed license
   /*!
     \return licenseInfos 
   */
   virtual LicenseInfos getCurrentLicenseInfos() = 0;

   //! Get current license server
   /*!
     \return serverHost Server host name or IP
     \return serverPort Server port
     \return useFlexLM Set to true if flexLM server
   */
   virtual getLicenseServerReturn getLicenseServer() = 0;

   //! install a new license
   /*!
     \param licensePath Path of the license file
   */
   virtual void installLicense(const FilePath & licensePath) = 0;

   //! Get the list of actually owned license tokens
   /*!
     \return ownedTokens Owned token list
   */
   virtual StringList listOwnedTokens() = 0;

   //! Get the list of license tokens for this product
   /*!
     \param onlyMandatory If True, optional tokens will not be returned
     \return tokens Token list
   */
   virtual StringList listTokens(const Bool & onlyMandatory = false) = 0;

   //! Get the list of license token configured to be requested at initialization
   /*!
     \return tokens Token list
   */
   virtual StringList listWantedTokens() = 0;

   //! Requests a license token for the current session. This step should be done after configuring license server. Throws an exception if the token is not available.
   /*!
     \param tokenName Token name
   */
   virtual void needToken(const String & tokenName) = 0;

   //! Returns True if we own a token, without requesting it
   /*!
     \param tokenName Token name
     \return owned True if the token is owned
   */
   virtual Boolean ownToken(const String & tokenName) = 0;

   //! Release an optional license token
   /*!
     \param tokenName Token name
   */
   virtual void releaseToken(const String & tokenName) = 0;

   //! release License owned by user WEB account
   /*!
     \param login WEB account login
     \param password WEB account password
     \param id WEB license id
   */
   virtual void releaseWebLicense(const String & login, const Password & password, const Ident & id) = 0;

   //! remove a license token from the list of wanted optional tokens
   /*!
     \param tokenName Unwanted token
   */
   virtual void removeWantedToken(const String & tokenName) = 0;

   //! request License owned by user WEB account
   /*!
     \param login WEB account login
     \param password WEB account password
     \param id WEB license id
   */
   virtual void requestWebLicense(const String & login, const Password & password, const Ident & id) = 0;

   //! Retrieves License owned by user WEB account
   /*!
     \param login WEB account login
     \param password WEB account password
     \return licenses 
   */
   virtual WebLicenseInfoList retrieveWebLicenses(const String & login, const Password & password) = 0;

   //! Returns True if a token is owned by the product, request will be done if missing
   /*!
     \param tokenName Token name
     \return valid 
   */
   virtual Bool tokenValid(const String & tokenName) = 0;

   /**@}*/

   /**
    * \defgroup parallel Parallel job function
    * @{
    */
   //! Add a job to a parallel session
   /*!
     \param session 
     \param jobCallback 
     \param dataPtr 
   */
   virtual void parallelAddJob(const ParallelSession & session, ParallelCallback jobCallback, const Ptr & dataPtr) = 0;

   //! Ends a parallel session after waiting for all jobs to finish
   /*!
     \param session 
   */
   virtual void parallelFinish(const ParallelSession & session) = 0;

   //! Starts a new parallel session
   /*!
     \param progression Enable progression for the parallel session
     \param name Name of the parallel session
     \param jobCount Count of parallel jobs if known (for progression)
     \return session 
   */
   virtual ParallelSession parallelStart(const Boolean & progression = false, const String & name = "Parallel session", const Int & jobCount = -1) = 0;

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
   virtual ModuleDesc getModuleDescFromXML(const FilePath & xmlPath, const Boolean & addToModules) = 0;

   //! Remove a module added via getModuleDescFromXML
   /*!
     \param module Module name
   */
   virtual void removeModule(const String & module) = 0;

   /**@}*/

   /**
    * \defgroup progress Progress bar tools
    * @{
    */
   //! Leave current progression level
   virtual void popProgression() = 0;

   //! Create a new progression level
   /*!
     \param stepCount Step count
     \param progressName Name of the progression step
   */
   virtual void pushProgression(const Int & stepCount, const String & progressName = "") = 0;

   //! Add a step to current progression level
   /*!
     \param stepCount Step count
   */
   virtual void stepProgression(const Int & stepCount = 1) = 0;

   /**@}*/

   /**
    * \defgroup properties properties related function
    * @{
    */
   //! Add multiple custom property to entities that support custom properties
   /*!
     \param entities Entities that support custom properties
     \param names Name of the custom property for each entity
     \param values Value of the custom property for each entity
     \param types Type of the custom property for each entity
   */
   virtual void addCustomProperties(const EntityList & entities, const StringList & names, const StringList & values = StringList(0), const PropertyTypeList & types = PropertyTypeList(0)) = 0;

   //! Add a custom property to an entity that support custom properties
   /*!
     \param entity An entity that support custom properties
     \param name Name of the custom property
     \param value Value of the custom property
     \param type Type of the custom property
   */
   virtual void addCustomProperty(const Entity & entity, const String & name, const String & value = "", const PropertyType & type = PropertyType::STRING) = 0;

   //! Returns the value of a module property
   /*!
     \param module Name of the module
     \param propertyName The property name
     \return propertyValue The property value
   */
   virtual String getModuleProperty(const String & module, const String & propertyName) = 0;

   //! Returns the value of a module property
   /*!
     \param module Name of the module
     \param propertyName The property name
     \return propertyInfo The property info
   */
   virtual PropertyInfo getModulePropertyInfo(const String & module, const String & propertyName) = 0;

   //! Get the property value on entities (if the property is not set on an entity, defaultValue is returned)
   /*!
     \param entities List of entities
     \param propertyName The property name
     \param defaultValue Default value to return if the property does not exist on an entity
     \return values Property value on each entity
   */
   virtual StringList getProperties(const EntityList & entities, const String & propertyName, const String & defaultValue = "") = 0;

   //! Get a property value as String on an entity (error if the property does not exist on the entity)
   /*!
     \param entity The entity
     \param propertyName The property name
     \return value The property value as String
   */
   virtual String getProperty(const Entity & entity, const String & propertyName) = 0;

   //! Get a property info on an entity (error if the property does not exist on the entity)
   /*!
     \param entity The entity
     \param propertyName The property name
     \return propertyInfo The property info
   */
   virtual PropertyInfo getPropertyInfo(const Entity & entity, const String & propertyName) = 0;

   //! Return true if the custom property was found on the occurrence
   /*!
     \param entityId An entity that support properties
     \param customPropertyName Name of the custom property
     \return propertyFound True if the enity has the custom propery, else False
   */
   virtual Boolean hasCustomProperty(const Entity & entityId, const String & customPropertyName) = 0;

   //! Return true if the property was found on the occurrence, will not throw any exception except if the entity does not exist.
   /*!
     \param entity An entity that support properties
     \param propertyName Name of the property
     \return propertyFound True if the entity has the property asked, else False
   */
   virtual Boolean hasProperty(const Entity & entity, const String & propertyName) = 0;

   //! Returns the informations of a module property
   /*!
     \param enumType The real enum type number (ie. The one return in subtype of PropertyInfo)
     \return enumPropertyInfo The enum property info
   */
   virtual EnumPropertyInfo listEnumLabels(const Int & enumType) = 0;

   //! Returns all the properties in the given module
   /*!
     \param module Name of the module
     \return properties List of module properties info
   */
   virtual PropertyInfoList listModuleProperties(const String & module) = 0;

   //! Returns the names and values of the properties available on an entity
   /*!
     \param entity Entity to list
     \return properties List of available properties info
   */
   virtual PropertyInfoList listProperties(const Entity & entity) = 0;

   //! Returns the names and values of the properties available on multiple entities
   /*!
     \param entities Entities to list
     \return properties List of available properties info
   */
   virtual PropertyInfoListList listPropertiesBatch(const EntityList & entities) = 0;

   //! Remove a custom property from an entity that support custom properties
   /*!
     \param entity An entity that support custom properties
     \param name Name of the custom property
   */
   virtual void removeCustomProperty(const Entity & entity, const String & name) = 0;

   //! Restore the default value of a module property
   /*!
     \param module Name of the module
     \param propertyName The property name
     \return value The property value as String
   */
   virtual String restoreModulePropertyDefaultValue(const String & module, const String & propertyName) = 0;

   //! Set the value of a module property
   /*!
     \param module Name of the module
     \param propertyName The property name
     \param propertyValue The property value
     \return value The property value as String
   */
   virtual String setModuleProperty(const String & module, const String & propertyName, const String & propertyValue) = 0;

   //! Set multiple properties values on entities
   /*!
     \param entities List of entities
     \param propertyNames The property name for each entity
     \param propertyValues The property value for each entity
   */
   virtual void setProperties(const EntityList & entities, const StringList & propertyNames, const StringList & propertyValues) = 0;

   //! Set a property value on an entity
   /*!
     \param entity The entity
     \param propertyName The property name
     \param propertyValue The property value
     \return value The property value as String
   */
   virtual String setProperty(const Entity & entity, const String & propertyName, const String & propertyValue) = 0;

   //! Return true if an entity support custom properties
   /*!
     \param entity An entity
     \return support True if the entity support custom properties, else False
   */
   virtual Boolean supportCustomProperties(const Entity & entity) = 0;

   //! Unset an entity's property
   /*!
     \param entity The entity
     \param propertyName The property name
   */
   virtual void unsetProperty(const Entity & entity, const String & propertyName) = 0;

   //! emitted after a custom property is added to an entity
   /*!
     \param entity Entity with custom property
     \param property Custom property that has been added
     \param entityType Type of the entity
   */
   virtual CoreI::Ident addAfterCustomPropertyAddedCallback(void(*fp)(void *, const Entity &, const String &, const Int &), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void * removeAfterCustomPropertyAddedCallback(CoreI::Ident id); 

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
   virtual availableMemoryReturn availableMemory() = 0;

   //! check for software update
   /*!
     \return newVersionAvailable True if there is a new version available of this product
     \return newVersion New version value
     \return newVersionLink Link to download the new version
     \return htmlInfo Html info associated with the new version
   */
   virtual checkForUpdatesReturn checkForUpdates() = 0;

   //! remove all other session temporary directories (warning: make sure that no other instance of pixyz is running
   virtual void clearOtherTemporaryDirectories() = 0;

   //! get the Pixyz custom version tag
   /*!
     \return customVersionTag 
   */
   virtual String getCustomVersionTag() = 0;

   //! Returns the memory usage peak of the current process in MB ( only available on windows yet )
   /*!
     \return peakWorkingSet Maximum physical memory used by the process until now (in MB)
   */
   virtual Long getMemoryUsagePeak() = 0;

   //! get the Pixyz website URL
   /*!
     \return url 
   */
   virtual String getPixyzWebsiteURL() = 0;

   //! get the Pixyz product name
   /*!
     \return productName 
   */
   virtual String getProductName() = 0;

   //! get the Pixyz temp directory (server side directory in case of remote access)
   /*!
     \return tmpDir 
   */
   virtual String getTempDirectory() = 0;

   //! get the Pixyz product version
   /*!
     \return version 
   */
   virtual String getVersion() = 0;

   //! push custom analytic event (Only for authorized products)
   /*!
     \param name Analytic event name
     \param data Analytic event data
   */
   virtual void pushAnalytic(const String & name, const String & data = "") = 0;

   //! Set the process thread. Use this function when you want to get progress changed callbacks from another thread as the one you initialized Pixyz on.
   virtual void setCurrentThreadAsProcessThread() = 0;

   /**@}*/

   /**
    * \defgroup undo/redo Undo/redo functions
    * @{
    */
   //! Clear undo/redo history
   virtual void clearUndoRedo() = 0;

   //! End current undo/redo step
   /*!
     \param deleteIfEmpty If True, empty step with no modification will be deleted from the stack at the end
   */
   virtual void endUndoRedoStep(const Boolean & deleteIfEmpty = true) = 0;

   //! Get the history of actions stack
   /*!
     \return redoStack 
   */
   virtual StringList getRedoStack() = 0;

   //! Get user data for undo step #index
   /*!
     \param index 
     \return userData 
   */
   virtual String getRedoStepUserData(const UInt & index) = 0;

   //! Get the history of actions stack
   /*!
     \return undoStack 
   */
   virtual StringList getUndoStack() = 0;

   //! Get user data for undo step #index
   /*!
     \param index 
     \return userData 
   */
   virtual String getUndoStepUserData(const UInt & index) = 0;

   //! Has recording step
   /*!
     \return hasRecordingStep True if there is recoding step, else False
   */
   virtual Boolean hasRecordingStep() = 0;

   //! redo some steps
   /*!
     \param count 
   */
   virtual void redo(const UInt & count = 1) = 0;

   //! Start a new undo/redo step
   /*!
     \param stepName 
     \param userData 
   */
   virtual void startUndoRedoStep(const String & stepName, const String & userData = "") = 0;

   //! Stop process (works if there is recording step)
   virtual void stopProcess() = 0;

   //! Toggle undo/redo
   virtual void toggleUndoRedo() = 0;

   //! undo some steps
   /*!
     \param count 
   */
   virtual void undo(const UInt & count = 1) = 0;

   //! emitted when the undo/redo stack has changed, basically when a step recording is finished or when an undo or redo is performed
   virtual CoreI::Ident addUndoRedoStackChangedCallback(void(*fp)(void *), void * userdata = nullptr) = 0;
   //! method to remove a callback event
   void * removeUndoRedoStackChangedCallback(CoreI::Ident id); 

   /**@}*/

   /**
    * \defgroup verbose verbose functions
    * @{
    */
   //! add a console verbose level
   /*!
     \param level Verbose level
   */
   virtual void addConsoleVerbose(const Verbose & level) = 0;

   //! add a log file verbose level
   /*!
     \param level Verbose level
   */
   virtual void addLogFileVerbose(const Verbose & level) = 0;

   //! add a session log file (lastSession{Id}.log) verbose level
   /*!
     \param level Verbose level
   */
   virtual void addSessionLogFileVerbose(const Verbose & level) = 0;

   //! Set new configuration for the Interface Logger
   /*!
     \param enableFunction If true, the called function names will be print
     \param enableParameters If true, the called function parameters will be print (only if enableFunction=true too)
     \param enableExecutionTime If true, the called functions execution times will be print
   */
   virtual void configureInterfaceLogger(const Boolean & enableFunction, const Boolean & enableParameters, const Boolean & enableExecutionTime) = 0;

   //! Get the current Interface Logger configuration
   /*!
     \return functionEnabled True if the called function names are printed
     \return parametersEnabled True if the called function parameters are printed
     \return executionTimeEnabled True if the called functions execution times are printed
   */
   virtual getInterfaceLoggerConfigurationReturn getInterfaceLoggerConfiguration() = 0;

   //! get the path of the log file
   /*!
     \return path Path of the log file
   */
   virtual OutputFilePath getLogFile() = 0;

   //! log a message to Pixyz output
   /*!
     \param message Message to log
     \param level Verbose level
   */
   virtual void log(const String & message, const Verbose & level) = 0;

   //! remove a console verbose level
   /*!
     \param level Verbose level
   */
   virtual void removeConsoleVerbose(const Verbose & level) = 0;

   //! remove a log file verbose level
   /*!
     \param level Verbose level
   */
   virtual void removeLogFileVerbose(const Verbose & level) = 0;

   //! remove a session log file (lastSession{Id}.log) verbose level
   /*!
     \param level Verbose level
   */
   virtual void removeSessionLogFileVerbose(const Verbose & level) = 0;

   //! set the path of the core dump file that will be written when a crash occurs (default=none)
   /*!
     \param path Path of the core dump file
   */
   virtual void setCoreDumpFile(const OutputFilePath & path) = 0;

   //! set the path of the log file
   /*!
     \param path Path of the log file
   */
   virtual void setLogFile(const OutputFilePath & path) = 0;

   /**@}*/

};

PXZ_MODULE_END



#endif
