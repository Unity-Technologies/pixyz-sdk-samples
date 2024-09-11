import numpy as np
import math
from pxzui.utils.Quaternion import *
import pxz

class Camera:
    def __init__(self, viewer):
        self.viewer = viewer
        self.needsUpdate = True
        self._target = np.array([0, 0, 0])
        self._forward = np.array([0, 0, -1])
        self._up = np.array([0, 1, 0])
        self._distance = 1000
        self._fovX = 90
        self._orthographic = False
        self._autoClipping = True
        self._orthographicSize = 10000
        self._zNear = 1
        self._zFar = 1000000
        self._isUpDownInverted = False
        self._viewDirty = True
        self._projDirty = True
        self._viewMatrix = self._computeViewMatrix()
        self._projMatrix = self._computeProjMatrix()

    def lookAt(self, cameraPosition, target, up):
        f = target - cameraPosition
        f = f / np.linalg.norm(f)
        s = np.cross(f, up)
        s = s / np.linalg.norm(s)
        u = np.cross(s, f)
        u = u / np.linalg.norm(u)
        m = np.zeros((4, 4))
        m[0, :-1] = s
        m[1, :-1] = u
        m[2, :-1] = -f
        m[0, 3] = -np.dot(s, cameraPosition)
        m[1, 3] = -np.dot(u, cameraPosition)
        m[2, 3] = np.dot(f, cameraPosition)
        m[3, 3] = 1.
        return m

    def right(self):
        return np.cross(self.getForward(), self.getUp())

    def rotate(self, dx, dy):
        axis = -dy * self.right() - dx * self._up
        angle = np.linalg.norm(axis)
        if angle < 0.0001:
            return
        axis = axis / angle
        x = axis[0] * math.sin(angle / 2.)
        y = axis[1] * math.sin(angle / 2.)
        z = axis[2] * math.sin(angle / 2.)
        w = math.cos(angle / 2.)
        q = w,x,y,z
        forward = qv_mult(q, self._forward)
        self._forward = forward / np.linalg.norm(forward)
        up = qv_mult(q, self._up)
        self._up = up / np.linalg.norm(up)
        self.setViewDirty(True)

    def zoom(self, factor):
        minDist = 0.0001
        self._distance *= factor
        if self._distance < minDist:
            self._distance = minDist
        self.setDirty(True)

    def pan(self, x, y):
        self.setTarget(self._target + self.right() * x + self._up * y)

    def fit(self, occurrences=None):
        aabb = pxz.geom.AABB(pxz.geom.Point3(1, 0, 0), pxz.geom.Point3(0, 0, 0))
        if occurrences is not None:
            if len(occurrences) == 0:
                occurrences = [pxz.scene.getRoot()]
            aabb = pxz.scene.getAABB(occurrences)
        if aabb.low.x > aabb.high.x:
            #invalid AABB
            return
        center = (np.array([aabb.low.x, aabb.low.y, aabb.low.z]) + np.array([aabb.high.x, aabb.high.y, aabb.high.z])) * 0.5
        radius = np.linalg.norm(np.array([aabb.high.x, aabb.high.y, aabb.high.z]) - np.array([aabb.low.x, aabb.low.y, aabb.low.z])) / 2
        self._target = center
        distX = radius / math.sin(math.radians(self.getFovX() / 2))
        distY = radius / math.sin(math.radians(self.getFovY() / 2))
        self._distance = max(distX, distY)
        self.setViewDirty(True)

    def setViewMatrix(self, viewMatrix):
        self._viewMatrix = viewMatrix
        self.setViewDirty(True)
    
    def setProjMatrix(self, projMatrix):
        self._projMatrix = projMatrix
        self.setProjDirty(True)

    def autoClipping(self):
        return self._autoClipping

    def setAutoClipping(self, autoClipping):
        self._autoClipping = autoClipping
        if self._autoClipping:
            self.setProjDirty(True)

    def isOrthographic(self):
        return self._orthographic

    def setOrthographic(self, orthographic):
        self._orthographic = orthographic
        self.setProjDirty(True)

    def getFovY(self):
        # https://wiki.panotools.org/Field_of_View
        return math.degrees(2 * math.atan(math.tan(math.radians(self.getFovX()) / 2) / self.viewer.aspect()))

    def getFovX(self):
        return self._fovX

    def setFovX(self, fovX):
        self._fovX = fovX
        self.setProjDirty(True)

    def getOrthographicSize(self):
        return self._orthographicSize

    def setOrthographicSize(self, orthographicSize, overrideFov = True):
        self._orthographicSize = orthographicSize
        if (overrideFov):
            self.setFovX(2.0 * math.degrees(math.atan(orthographicSize / (2.0 * self._distance))))
        self.setProjDirty(True)

    def getZNear(self):
        return self._zNear

    def setZNear(self, zNear):
        self._zNear = zNear
        self.setProjDirty(True)

    def getZFar(self):
        return self._zFar

    def setZFar(self, zFar):
        self._zFar = zFar
        self.setProjDirty(True)

    def setDirty(self, dirty=True):
        self.setViewDirty(dirty)
        self.setProjDirty(dirty)

    def isDirty(self):
        return self.isViewDirty() or self.isProjDirty()

    def isViewDirty(self):
        return self._viewDirty

    def setViewDirty(self, dirty=True):
        self._viewDirty = dirty

    def isProjDirty(self):
        return self._projDirty

    def setProjDirty(self, dirty=True):
        self._projDirty = dirty

    def setUp(self, up):
        self._up = up
        self.setViewDirty(True)

    def getUp(self):
        return self._up

    def getForward(self):
        return self._forward

    def setForward(self, forward):
        self._forward = forward
        self.setViewDirty(True)

    def getTarget(self):
        return self._target

    def setTarget(self, target):
        self._target = target
        self.setViewDirty(True)

    def getDistance(self):
        return self._distance

    def setDistance(self, distance):
        self._distance = distance
        self.setViewDirty(True)

    def isUpDownInverted(self):
        return self._isUpDownInverted

    def setUpDownInverted(self, inverted):
        self._isUpDownInverted = inverted
        self.setProjDirty(True)

    def getViewMatrix(self):
        if self.isViewDirty():
            self._viewMatrix = self._computeViewMatrix()
            #Necessary for the auto near far plane computation
            if self._autoClipping:
                self._projMatrix = self._computeProjMatrix()
                self.setProjDirty(False)
            self.setViewDirty(False)
            self.needsUpdate = True
        return self._viewMatrix

    def getProjMatrix(self):
        if self.isProjDirty():
            self._projMatrix = self._computeProjMatrix()
            self.setProjDirty(False)
            self.needsUpdate = True
        return self._projMatrix

    def _computeViewMatrix(self):
        cameraPosition = self._target - (self._forward * self._distance)
        return self.lookAt(cameraPosition, self._target, self._up)

    def computeNearFar(self):
        if self.viewer.gpuScene == None or not self._autoClipping:
            return
        sceneAABB = pxz.view.getLastAABB(self.viewer.gpuScene, self.viewer.viewer)
        if sceneAABB.low.x > sceneAABB.high.x:#requires to compute the AABB
            self.setProjDirty()
            self.needsUpdate = True
            return
        cameraPosition = self._target - (self._forward * self._distance)

        sceneAABBLow = np.array([sceneAABB.low.x, sceneAABB.low.y, sceneAABB.low.z])
        sceneAABBHigh = np.array([sceneAABB.high.x, sceneAABB.high.y, sceneAABB.high.z])
        aabbCenter = (sceneAABBLow + sceneAABBHigh) * 0.5

        distToCenter = np.dot(self._forward, aabbCenter - cameraPosition)
        halfDiag = np.linalg.norm(sceneAABBHigh - sceneAABBLow) * 0.5
        if distToCenter < halfDiag:
            self._zNear = halfDiag * 0.00001
        else:
            self._zNear = max(distToCenter - halfDiag * 1.1, halfDiag * 0.00001)
        self._zFar = distToCenter + halfDiag * 1.1

    def _computeProjMatrix(self):
        self.computeNearFar()
        if self.isOrthographic():
            #ensure consistency with perspective view
            self.setOrthographicSize(2.0 * self._distance * math.tan(math.radians(self.getFovX()) * 0.5), False)

            width3d = self.getOrthographicSize()
            height3d = self.getOrthographicSize() /  self.viewer.aspect()
            if self.isUpDownInverted():
                height3d *= -1
            return np.array(pxz.geom.orthographicMatrix(width3d, height3d, self.getZNear(), self.getZFar()))
        else:
            if self.isUpDownInverted():
                return np.array(pxz.geom.perspectiveMatrix(self.getFovX(), -self.viewer.aspect(), self.getZNear(), self.getZFar()))
            else:
                return np.array(pxz.geom.perspectiveMatrix(self.getFovX(), self.viewer.aspect(), self.getZNear(), self.getZFar()))