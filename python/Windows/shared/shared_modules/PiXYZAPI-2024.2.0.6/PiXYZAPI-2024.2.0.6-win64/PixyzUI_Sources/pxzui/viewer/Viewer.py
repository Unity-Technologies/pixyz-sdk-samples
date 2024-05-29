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

class Viewer:
    def __init__(self, width, height, context, root=scene.getRoot(), previewViewer=False):
        self.width = width
        self.height = height
        self.context = context
        self.vao = None
        self.enableGrid = True
        self.camera = Camera(self)
        self.initProgram()
        # Create a dummy VAO
        self.vao = glGenVertexArrays(1)
        self.gpuScene = None
        self.initPixyzViewer(root, previewViewer)
        self._startTime = int(time.time() * 1000)

    def __del__(self):
        if pxz.is_remote():
            self.decoder.stop()

    def initProgram(self):
        vertex = shaders.compileShader(open(os.path.dirname(__file__) + "/main.vertex.glsl",'r').read(), GL_VERTEX_SHADER)
        fragment = shaders.compileShader(open(os.path.dirname(__file__) + "/main.fragment.glsl",'r').read(), GL_FRAGMENT_SHADER)
        self.shader = shaders.compileProgram(vertex, fragment)

    def initPixyzViewer(self, root=None, previewViewer=False):
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
        #else:
        #    self.gpuScene = view.getGlobalGPUScene()
        view.addGPUScene(self.gpuScene,  self.viewer)
        view.setViewerProperty("RenderComposited", "True", self.viewer)
        view.setViewerProperty("ShowBackground", "True" if not previewViewer else "False", self.viewer)
        self.currentTexture = view.RenderMap.Composited
        self.camera.setDirty(True)

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
        self.camera.setTarget(np.array([pickReturn["position"].x, pickReturn["position"].y, pickReturn["position"].z]))
        self.camera.setViewDirty(True)

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
        return self.width / self.height

    def drawGrid(self):
        #TODO
        pass

    def destroy(self):
        pxz.view.removeGPUScene(self.gpuScene, self.viewer)
        pxz.view.destroyGPUScene(self.gpuScene)
        pxz.view.destroyViewer(self.viewer)
        pxz.scene.deleteOccurrences(self.hiddenOccurrence)
