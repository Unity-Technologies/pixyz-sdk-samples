import pxz


class AnimationLibrary:
    def __init__(self, ui):
        self.ui = ui
        self._allAnimations = {}
        self.ui.window.callback_manager.addAnimationAddedCallback(self.onAnimationAdded)
        self.ui.window.callback_manager.addAnimationRemovedCallback(self.onAnimationRemoved)
        self.ui.window.callback_manager.addAnimationClearedCallback(self.onAnimationCleared)

    def __del__(self):
        self.ui.window.callback_manager.removeAnimationAddedCallback(self.onAnimationAdded)
        self.ui.window.callback_manager.removeAnimationRemovedCallback(self.onAnimationRemoved)
        self.ui.window.callback_manager.removeAnimationClearedCallback(self.onAnimationCleared)

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
