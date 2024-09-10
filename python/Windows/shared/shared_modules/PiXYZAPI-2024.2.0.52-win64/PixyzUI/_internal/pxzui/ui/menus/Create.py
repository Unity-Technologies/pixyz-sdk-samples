
from imgui_bundle import imgui
import pxz


class Create:
    def __init__(self, ui):
        self.ui = ui

    def draw(self):

        if imgui.begin_menu("Create", True):
            if imgui.menu_item("Empty Occurrence", "", False, True)[0]:
                self.createEmptyOccurrence()
            if imgui.menu_item("Occurrence From Selection", "", False, True)[0]:
                self.createOccurrenceFromSelection()
            imgui.separator()
            if imgui.begin_menu("Create Light"):
                if imgui.menu_item("Directional Light", "", False, True)[0]:
                    self.createDirectionalLight()
                if imgui.menu_item("Point Light", "", False, True)[0]:
                    self.createPointLight()
                if imgui.menu_item("Spot Light", "", False, True)[0]:
                    self.createSpotLight()
                imgui.end_menu()
            imgui.separator()
            if imgui.begin_menu("Primitive"):
                if imgui.menu_item("Cone", "", False, True)[0]:
                    self.createCone()
                if imgui.menu_item("Cube", "", False, True)[0]:
                    self.createCube()
                if imgui.menu_item("Cylinder", "", False, True)[0]:
                    self.createCylinder()
                if imgui.menu_item("Plane", "", False, True)[0]:
                    self.createPlane()
                if imgui.menu_item("Sphere", "", False, True)[0]:
                    self.createSphere()
                if imgui.menu_item("Torus", "", False, True)[0]:
                    self.createTorus()
                imgui.end_menu()
            imgui.end_menu()

    # region Empty Occurrences
    def doCreateEmptyOccurrence(self):
        pxz.scene.createOccurrence("Empty Occurrence", pxz.scene.getRoot())

    def createEmptyOccurrence(self):
        self.ui.processQueue.enqueue(self.doCreateEmptyOccurrence)

    def doCreateOccurrenceFromSelection(self):
        pxz.scene.createOccurrenceFromSelection("Occurrence From Selection", pxz.scene.getSelectedOccurrences(), pxz.scene.getRoot())

    def createOccurrenceFromSelection(self):
        self.ui.processQueue.enqueue(self.doCreateOccurrenceFromSelection)
    # endregion

    #region Lights
    def doCreateDirectionalLight(self):
        pxz.scene.createLight(name="Directional Light",lightType=pxz.scene.LightType.DirectionalLight,color=[1.0, 1.0, 1.0], parent=pxz.scene.getRoot())

    def createDirectionalLight(self):
        self.ui.processQueue.enqueue(self.doCreateDirectionalLight)


    def doCreatePointLight(self):
        pxz.scene.createLight(name="Point Light",lightType=pxz.scene.LightType.PositionalLight,color=[1.0, 1.0, 1.0], parent=pxz.scene.getRoot())

    def createPointLight(self):
        self.ui.processQueue.enqueue(self.doCreatePointLight)

    def doCreateSpotLight(self):
        pxz.scene.createLight(name="Spot Light",lightType=pxz.scene.LightType.SpotLight,color=[1.0, 1.0, 1.0], parent=pxz.scene.getRoot())

    def createSpotLight(self):
        self.ui.processQueue.enqueue(self.doCreateSpotLight)
    #endregion

    #region Primitives
    def doCreateCone(self):
        parameters = self.ui.functionLibrary.getDefaultParameters("Scene", "createCone")
        cone = int(eval("pxz.scene.createCone(" + parameters["bottomRadius"] + " , " + parameters["height"] + ")"))
        pxz.scene.setParent(cone, pxz.scene.getRoot())

    def createCone(self):
        self.ui.processQueue.enqueue(self.doCreateCone)

    def doCreateCube(self):
        parameters = self.ui.functionLibrary.getDefaultParameters("Scene", "createCube")
        cube = int(eval("pxz.scene.createCube(" + parameters["sizeX"] + " , " + parameters["sizeY"] + ", " + parameters["sizeZ"] + ", " + parameters["subdivision"] + ")"))
        pxz.scene.setParent(cube, pxz.scene.getRoot())

    def createCube(self):
        self.ui.processQueue.enqueue(self.doCreateCube)

    def doCreateCylinder(self):
        parameters = self.ui.functionLibrary.getDefaultParameters("Scene", "createCylinder")
        cylinder = int(eval("pxz.scene.createCylinder(" + parameters["radius"] + " , " + parameters["height"] + ")"))
        pxz.scene.setParent(cylinder, pxz.scene.getRoot())

    def createCylinder(self):
        self.ui.processQueue.enqueue(self.doCreateCylinder)

    def doCreatePlane(self):
        parameters = self.ui.functionLibrary.getDefaultParameters("Scene", "createPlane")
        plane = int(eval("pxz.scene.createPlane(" + parameters["sizeX"] + " , " + parameters["sizeY"] + ")"))
        pxz.scene.setParent(plane, pxz.scene.getRoot())

    def createPlane(self):
        self.ui.processQueue.enqueue(self.doCreatePlane)

    def doCreateSphere(self):
        parameters = self.ui.functionLibrary.getDefaultParameters("Scene", "createSphere")
        sphere = int(eval("pxz.scene.createSphere(" + parameters["radius"] + ")"))
        pxz.scene.setParent(sphere, pxz.scene.getRoot())

    def createSphere(self):
        self.ui.processQueue.enqueue(self.doCreateSphere)

    def doCreateTorus(self):
        parameters = self.ui.functionLibrary.getDefaultParameters("Scene", "createTorus")
        torus = int(eval("pxz.scene.createTorus(" + parameters["majorRadius"] + " , " + parameters["minorRadius"] + " , " + parameters["subdivisionLatitude"] + " , " + parameters["subdivisionLongitude"] + ")"))
        pxz.scene.setParent(torus, pxz.scene.getRoot())

    def createTorus(self):
        self.ui.processQueue.enqueue(self.doCreateTorus)

    #endregion
