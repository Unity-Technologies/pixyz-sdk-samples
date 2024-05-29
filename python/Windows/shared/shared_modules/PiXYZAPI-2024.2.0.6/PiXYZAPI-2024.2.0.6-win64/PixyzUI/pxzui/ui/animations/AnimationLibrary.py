import pxz


def onAnimationAdded(animationId, animationLibrary):
    animationLibrary.onAnimationAdded(animationId)

def onAnimationRemoved(animationId, animationLibrary):
    animationLibrary.onAnimationRemoved(animationId)

def onAnimationCleared(animationLibrary):
    animationLibrary.onAnimationCleared()

class AnimationLibrary:
    def __init__(self):
        self._allAnimations = {}
        pxz.scene.addAnimationAddedCallback(onAnimationAdded, self)
        pxz.scene.addAnimationRemovedCallback(onAnimationRemoved, self)
        pxz.scene.addAnimationClearedCallback(onAnimationCleared, self)

    def onAnimationAdded(self, animationId):
        self._allAnimations[animationId] = pxz.scene.getAnimationInfo(animationId)

    def onAnimationRemoved(self, animationId):
        del self._allAnimations[animationId]

    def onAnimationCleared(self):
        self._allAnimations.clear()

    def getAllCopy(self):
        return self._allAnimations.copy()

    def animationExists(self, animationId):
        return animationId in self._allAnimations.keys()
