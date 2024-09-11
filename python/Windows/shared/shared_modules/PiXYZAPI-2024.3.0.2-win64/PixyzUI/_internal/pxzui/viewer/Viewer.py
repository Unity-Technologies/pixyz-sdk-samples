import time

from OpenGL.GL import *
from OpenGL.GL import shaders
import os
import pxz
from pxz import scene, view, geom
from pxzui.viewer.Camera import Camera
from imgui_bundle import imguizmo
import numpy as np
from pxzui.viewer.StreamDecoder import StreamDecoder
import glfw

class Viewer:
    def __init__(self, window, width, height, root=-1, previewViewer=False):
        if root < 0:
            root = scene.getRoot()
        self.window = window
        self.width = width
        self.height = height
        self.context = glfw.get_wgl_context(self.window.glfwWindow)
        self.vao = None
        self.enableGrid = True
        self.initProgram()
        # Create a dummy VAO
        self.vao = glGenVertexArrays(1)
        self.gpuScene = None
        self.camera = Camera(self)
        self.initPixyzViewer(root, previewViewer)
        self._startTime = int(time.time() * 1000)
        self.lastPrimitivePicked = 0
        self.lastOccurrencePicked = 0
        self.pickCallbackReceivers = []

    def __del__(self):
        if pxz.is_remote():
            self.decoder.stop()

    def initProgram(self):
        vertex = shaders.compileShader(open(os.path.dirname(__file__) + "/main.vertex.glsl",'r').read(), GL_VERTEX_SHADER)
        fragment = shaders.compileShader(open(os.path.dirname(__file__) + "/main.fragment.glsl",'r').read(), GL_FRAGMENT_SHADER)
        self.shader = shaders.compileProgram(vertex, fragment)

    def initPixyzViewer(self, root=None, previewViewer=False):
        print("Trying to create viewer for " + str(glGetString(GL_RENDERER)) + " ...")
        if pxz.is_remote():
            streamInfo = view.createStreamedViewer(self.width, self.height, pxz.view.EncoderSettings(30, 2500000, 2500000), False)
            self.viewer = streamInfo.viewer
            self.decoder = StreamDecoder(streamInfo)
            self.decoder.start()
        else:
            self.viewer = view.createViewer(self.width, self.height, view.GraphicsContext(view.GraphicAPI.OpenGL, self.context))
        #if previewViewer:
        pxz.core.lockEntityRegistration()
        self.hiddenOccurrence = scene.createOccurrence("Hidden");
        pxz.core.unlockEntityRegistration()
        self.gpuScene = view.createGPUScene([root, self.hiddenOccurrence], True)
        self.window.addUsedGPUScene(self.gpuScene)
        view.addGPUScene(self.gpuScene,  self.viewer)
        view.setViewerProperty("RenderComposited", "True", self.viewer)
        view.setViewerProperty("ShowBackground", "True" if not previewViewer else "False", self.viewer)
        self.currentTexture = view.RenderMap.Composited
        self.camera.setDirty(True)
        print("Viewer created successfully.")

    def recreateGPUScene(self, roots):
        if self.gpuScene != None:
            self.window.removeUsedGPUScene(self.gpuScene)
            pxz.view.removeGPUScene(self.gpuScene, self.viewer)
            pxz.view.destroyGPUScene(self.gpuScene)

        self.gpuScene = pxz.view.createGPUScene(roots + [self.hiddenOccurrence], True)
        self.window.addUsedGPUScene(self.gpuScene)
        pxz.view.addGPUScene(self.gpuScene, self.viewer)


    def submitCameraParameters(self):
        viewMatrix = self.camera.getViewMatrix().tolist()
        projMatrix = self.camera.getProjMatrix().tolist()
        clipping = geom.Point2(self.camera.getZNear(), self.camera.getZFar())
        view.setViewerMatrices([viewMatrix], [projMatrix], clipping, self.viewer)

    def resize(self, width, height):
        self.width = width
        self.height = height
        view.resizeViewer(width, height, self.viewer)
        # Update projection matrix if not minimized
        if width > 0 and height > 0:
            self.camera.setProjDirty(True)

    def refresh(self):
        if self.camera.needsUpdate:
            self.submitCameraParameters()
            self.camera.needsUpdate = False
        if pxz.is_remote():
            # no refresh in remote mode, the streaming produce frame according to the requested framerate
            return
        # Ask for a new frame on pixyz viewer
        view.refreshViewer(self.viewer)

    def pick(self, x, y):
        pickReturn = view.pick(x, self.height - y, self.viewer)
        if pickReturn["occurrence"] == 0:
            return
        self.lastPrimitivePicked = pickReturn["primitiveId"]
        self.lastOccurrencePicked = pickReturn["occurrence"]
        self.camera.setTarget(np.array([pickReturn["position"].x, pickReturn["position"].y, pickReturn["position"].z]))
        self.camera.setViewDirty(True)        
        
        for receiver in self.pickCallbackReceivers:
            try:
                receiver.onPick()
            except:                
                pass

    def draw(self):
        try:
            glUseProgram(self.shader)

            glUniform1i(glGetUniformLocation(self.shader, "CompositedTexture"), 0)
            glActiveTexture(GL_TEXTURE0)

            if not pxz.is_remote():            
                glBindTexture(GL_TEXTURE_2D, view.getGLTextureHandle(self.currentTexture, self.viewer))
            else:
                # TODO : bind decoded frame
                glBindTexture(GL_TEXTURE_2D, 0)

            glBindVertexArray(self.vao)
            glDrawArrays(GL_TRIANGLE_STRIP, 0, 4)
            glBindVertexArray(0)

            glUseProgram(0)

            if self.enableGrid:
                self.drawGrid()

            glFinish()
        except:
            pass

    def getCurrentTime(self):
        return int(time.time() * 1000) - self._startTime

    def aspect(self):
        if self.height == 0:
            return 1
        return self.width / self.height

    def drawGrid(self):
        #TODO
        pass

    def addPickCallbackReceiver(self, receiver):
        self.pickCallbackReceivers.append(receiver)

    def removePickCallbackReceiver(self, receiver):
        if receiver in self.pickCallbackReceivers:
            self.pickCallbackReceivers.remove(receiver)

    def getPickCallbackReceivers(self):
        return self.pickCallbackReceivers

    def saveState(self):
        state = {}
        state['tg'] = self.camera.getTarget()
        state['fw'] = self.camera.getForward()
        state['ds'] = self.camera.getDistance()
        state['up'] = self.camera.getUp()
        state['receivers'] = self.getPickCallbackReceivers()[:] # Do a copy of the returned list
        return state

    def restoreState(self, state):
        self.camera.setTarget(state['tg'])
        self.camera.setForward(state['fw'])
        self.camera.setDistance(state['ds'])
        self.camera.setUp(state['up'])
        for receiver in state['receivers']:
            if receiver:
                self.addPickCallbackReceiver(receiver)
