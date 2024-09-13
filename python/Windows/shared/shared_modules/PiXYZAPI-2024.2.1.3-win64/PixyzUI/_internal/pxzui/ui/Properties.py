import pxz
from imgui_bundle import imgui

from pxzui.ui.WindowBase import WindowBase
from pxzui.ui.widgets.Utility import Utility


class PropertyWindow(WindowBase):
    def __init__(self, ui):
        super().__init__(name="Properties")
        self.moduleProperties = []
        for module in ["Core", "IO", "Material", "CAD", "Tessellate", "Algo", "View"]:
            self.moduleProperties.append(ModuleProperties(ui, module))

    def draw(self):
        for module in self.moduleProperties:
            if imgui.collapsing_header(module.moduleName):
                module.draw()

    def restoreModulesConfig(self, config):
        for module in self.moduleProperties:
            module.restoreConfig(config[module.moduleName])

    def saveModulesConfig(self):
        modules = {}
        for module in self.moduleProperties:
            modules[module.moduleName] = {k: v.getValue() for k, v in module.widgets.items()}
        return modules


class Properties:
    def __init__(self, ui, propertiesInfos):
        self.ui = ui
        self.widgets = {}
        self.propertiesByGroups = {}
        for propertyInfo in propertiesInfos:
            self.widgets[propertyInfo.name] = Utility.createPropertyWidget(self.ui, propertyInfo)
            if not propertyInfo.group in self.propertiesByGroups:
                self.propertiesByGroups[propertyInfo.group] = []
            self.propertiesByGroups[propertyInfo.group].append(propertyInfo)

    def draw(self):
        for group in self.propertiesByGroups:
            if group != "":
                if imgui.tree_node(group):
                    self.drawGroup(group)
                    imgui.tree_pop()
            else:
                self.drawGroup(group)

    def drawGroup(self, group):
        if imgui.begin_table("##PropertyTable" + group, 2):
            for propertyInfo in self.propertiesByGroups[group]:
                imgui.table_next_row()
                imgui.table_next_column()
                imgui.text(propertyInfo.name)
                imgui.table_next_column()
                imgui.set_next_item_width(imgui.get_content_region_avail()[0])
                self.drawPropertyWidget(propertyInfo)
            imgui.end_table()

    def drawPropertyWidget(self, propertyInfo):
        # ret is a tuple : (changed, newStringValue)
        ret = self.widgets[propertyInfo.name].draw()
        # Update modified property
        if ret[0]:
            try:
                # Setting the property
                self.setProperty(propertyInfo.name, str(ret[1]))
            except Exception as e:
                print("Exception : " + str(e))

    def restoreConfig(self, config):
        for property in config.keys():
            if self.widgets[property].getValue() != config[property]:
                self.setProperty(property, config[property])
                self.widgets[property].setValue(config[property])

    def setProperty(self, propertyName, value):
        # overwritten in derived classes
        raise NotImplementedError


class ViewerProperties(Properties):
    def __init__(self, ui, viewerId):
        self.viewerId = viewerId
        Properties.__init__(self, ui, pxz.view.listViewerProperties(viewerId))
        self.ui.window.callback_manager.addAfterViewerPropertyChangedCallback(self.onPropertyChange)
        self.has_callback = True
    def __del__(self):
        self.detach()
    def detach(self):
        if self.has_callback:
            self.ui.window.callback_manager.removeAfterViewerPropertyChangedCallback(self.onPropertyChange)
            self.has_callback = False

    def setProperty(self, propertyName, value):
        print("Setting Viewer(" + str(self.viewerId) + ") property : \"" + propertyName + "\", value : " + value)
        pxz.view.setViewerProperty(propertyName, value, self.viewerId)

    def onPropertyChange(self, viewer, property):
        if viewer == self.viewerId:
            self.widgets[property].setValue(pxz.view.getViewerProperty(property, viewer))


class EntityProperties(Properties):
    def __init__(self, ui, entityId):
        self.entityId = entityId
        Properties.__init__(self, ui, pxz.core.listProperties(entityId))
        self.ui.window.callback_manager.addAfterEntityPropertyChangedCallback(self.onEntityPropertyChange)
        self.has_callback = True
    def __del__(self):
        self.detach()
    def detach(self):
        if self.has_callback:
            self.ui.window.callback_manager.removeAfterEntityPropertyChangedCallback(self.onEntityPropertyChange)
            self.has_callback = False

    def setProperty(self, propertyName, value):
        print("Setting Entity(" + str(self.entityId) + ") property : \"" + propertyName + "\", value : " + value)
        pxz.core.setProperty(self.entityId, propertyName, value)

    def onEntityPropertyChange(self, entity, property, entityType):
        if entity == self.entityId:
            self.widgets[property].setValue(pxz.core.getProperty(entity, property))


class SubpartMaterialProperties(EntityProperties):
    def __init__(self, ui, entityId, occurrenceId):
        EntityProperties.__init__(self, ui, entityId)
        materials = pxz.scene.listSubpartMaterials(occurrenceId)
        self.occurrenceId = occurrenceId
        self.materialsWidgets = list()
        for material in materials:
            matName = "[Empty]"
            if material != 0:
                matName = pxz.core.getProperty(material, "Name")
            from pxzui.ui.widgets.entityWidgets.MaterialWidget import MaterialWidget
            materialWidget = MaterialWidget(ui, matName, str(material), True)
            self.materialsWidgets.append(materialWidget)

    def draw(self):
        EntityProperties.draw(self)
        index = 0
        for materialWidget in self.materialsWidgets:
            changed, newValue = materialWidget.draw()
            if changed:
                pxz.scene.setSubpartMaterial(self.occurrenceId, index, int(newValue))
            index += 1


class PartProperties(EntityProperties):
    def __init__(self, ui, entityId, occurrenceId):
        EntityProperties.__init__(self, ui, entityId)
        materials = pxz.scene.listSubpartMaterials(occurrenceId)
        self.materialsWidgets = list()
        for material in materials:
            matName = "[Empty]"
            if material != 0:
                matName = pxz.core.getProperty(material, "Name")
            from pxzui.ui.widgets.entityWidgets.MaterialWidget import MaterialWidget
            materialWidget = MaterialWidget(ui, matName, str(material), False)
            self.materialsWidgets.append(materialWidget)

    def draw(self):
        EntityProperties.draw(self)

        if imgui.collapsing_header("Submeshes " + str(len(self.materialsWidgets))):
            for materialWidget in self.materialsWidgets:
                materialWidget.draw()

class ModuleProperties(Properties):
    def __init__(self, ui, moduleName):
        self.moduleName = moduleName
        Properties.__init__(self, ui, pxz.core.listModuleProperties(moduleName))
        self.ui.window.callback_manager.addAfterModulePropertyChangedCallback(self.onModulePropertyChange)
        self.has_callback = True
    def __del__(self):
        self.detach()
    def detach(self):
        if self.has_callback:
            self.ui.window.callback_manager.removeAfterModulePropertyChangedCallback(self.onModulePropertyChange)
            self.has_callback = False

    def setProperty(self, propertyName, value):
        print("Setting Module(" + str(self.moduleName) + ") property : \"" + propertyName + "\", value : " + value)
        pxz.core.setModuleProperty(self.moduleName, propertyName, value)

    def onModulePropertyChange(self, module, property):
        if module == self.moduleName:
            self.widgets[property].setValue(pxz.core.getModuleProperty(module, property))
