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
        if not propertyInfo.editable:
            imgui.begin_disabled()
        # ret is a tuple : (changed, newStringValue)
        ret = self.widgets[propertyInfo.name].draw()
        if not propertyInfo.editable:
            imgui.end_disabled()
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


def onPropertyChange(object, property, userdata):
    userdata.onPropertyChange(object, property)

def onEntityPropertyChange(entity, property, entityType, userdata):
    userdata.onPropertyChange(entity, property)

class ViewerProperties(Properties):
    def __init__(self, ui, viewerId):
        self.viewerId = viewerId
        Properties.__init__(self, ui, pxz.view.listViewerProperties(viewerId))
        pxz.view.addAfterViewerPropertyChangedCallback(onPropertyChange, self)

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
        pxz.core.addAfterEntityPropertyChangedCallback(onEntityPropertyChange, self)

    def setProperty(self, propertyName, value):
        print("Setting Entity(" + str(self.entityId) + ") property : \"" + propertyName + "\", value : " + value)
        pxz.core.setProperty(self.entityId, propertyName, value)

    def onPropertyChange(self, entity, property):
        if entity == self.entityId:
            self.widgets[property].setValue(pxz.core.getProperty(entity, property))

class ModuleProperties(Properties):
    def __init__(self, ui, moduleName):
        self.moduleName = moduleName
        Properties.__init__(self, ui, pxz.core.listModuleProperties(moduleName))
        pxz.core.addAfterModulePropertyChangedCallback(onPropertyChange, self)

    def setProperty(self, propertyName, value):
        print("Setting Module(" + str(self.moduleName) + ") property : \"" + propertyName + "\", value : " + value)
        pxz.core.setModuleProperty(self.moduleName, propertyName, value)

    def onPropertyChange(self, module, property):
        if module == self.moduleName:
            self.widgets[property].setValue(pxz.core.getModuleProperty(module, property))
