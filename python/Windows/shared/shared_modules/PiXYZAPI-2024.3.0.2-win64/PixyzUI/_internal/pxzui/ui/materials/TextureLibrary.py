import threading

import numpy as np
import pxz
from OpenGL.GL import *


class TextureLibrary:
    def __init__(self, ui):
        self.ui = ui
        self._allImageDefinitions = {}
        self._imageChanges = []
        self._lock = threading.Lock()
        self.ui.window.callback_manager.addImageChangedCallback(self.onImageChanged)

    def __del__(self):
        self.ui.window.callback_manager.removeImageChangedCallback(self.onImageChanged)

    def updateIfNeeded(self):
        try:
            with self._lock:
                self.update()
        except Exception as inst:
            print(inst)

    def update(self):
        # apply all the async changes from onImageChanged
        while self._imageChanges:
            imageId, imageChangeType = self._imageChanges.pop()
            match imageChangeType:
                case pxz.material.ImageChangeType.ADDED:
                    imgDef = pxz.material.getImageDefinition(imageId)
                    glText = self.generateGlTextureId(imgDef)
                    if glText is None:
                        continue
                    self._allImageDefinitions[imageId] = {"definition": imgDef,
                                                          "glTextureId": glText}
                case pxz.material.ImageChangeType.REMOVED:
                    glDeleteTextures([self._allImageDefinitions[imageId]["glTextureId"]])
                    del self._allImageDefinitions[imageId]
            # other options currently unsupported
            """
            case pxz.material.ImageChangeType.CHANGED:
                raise NotImplementedError
            case pxz.material.ImageChangeType.RESET:
                raise NotImplementedError
            case pxz.material.ImageChangeType.REPLACED:
                raise NotImplementedError
            """

    def onImageChanged(self, imageChangeType, imageId):
        with self._lock:
            if imageChangeType == pxz.material.ImageChangeType.RESET and imageId == 0:
                # scene reset ---> removing everything
                for currentId in self._allImageDefinitions.keys():
                    self._imageChanges.insert(0, [currentId, pxz.material.ImageChangeType.REMOVED])
            else:
                self._imageChanges.insert(0, [imageId, imageChangeType])

    def generateGlTextureId(self, pxzImage):
        if pxzImage.width * pxzImage.height == 0:
            return None
        if (pxzImage.bitsPerComponent != 8) and (pxzImage.bitsPerComponent != 16):
            return None
        width = pxzImage.width
        height = pxzImage.height
        dtype = np.uint8 if pxzImage.bitsPerComponent == 8 else np.uint16
        textureDataRaw = np.frombuffer(pxzImage.data, dtype=dtype)
        pixels = width * height
        componentsPerPixel = textureDataRaw.size // pixels
        textureData = np.reshape(textureDataRaw, (pixels, 1, componentsPerPixel))
        texture = glGenTextures(1)
        glBindTexture(GL_TEXTURE_2D, texture)
        # Set texture filtering parameters
        glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_LINEAR)
        glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_LINEAR)
        # Set the texture wrapping parameters
        glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, GL_REPEAT)
        glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_T, GL_REPEAT)
        match componentsPerPixel:
            case 1:
                glFormat = GL_RED
            case 2:
                glFormat = GL_RG
            case 3:
                glFormat = GL_RGB
            case 4:
                glFormat = GL_RGBA
            case _:
                raise NotImplementedError("Texture format not supported!")
        glTexImage2D(GL_TEXTURE_2D, 0, glFormat, width, height, 0, glFormat, GL_UNSIGNED_BYTE, textureData)
        return texture

    def getGlId(self, imageId):
        with self._lock:
            if imageId not in self._allImageDefinitions.keys():
                return None
            return self._allImageDefinitions[imageId]["glTextureId"]

    def getName(self, imageId):
        with self._lock:
            if imageId not in self._allImageDefinitions.keys():
                return None
            return self._allImageDefinitions[imageId]["definition"].name

    def getImageListCopy(self):
        with self._lock:
            return list(self._allImageDefinitions.copy().values())

    def isEmpty(self):
        with self._lock:
            return list(self._allImageDefinitions.copy().values()) == []
