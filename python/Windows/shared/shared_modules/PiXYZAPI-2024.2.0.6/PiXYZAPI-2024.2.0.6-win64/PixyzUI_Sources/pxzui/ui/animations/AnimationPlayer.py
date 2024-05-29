import time

import pxz

from pxzui.ui.WindowBase import WindowBase
from imgui_bundle import imgui, ImVec2


def onAnimationPlayingStatusChanged(animationId, animationPlayerInfo, animationPlayer):
    animationPlayer.onAnimationPlayingStatusChanged(animationId, animationPlayerInfo)

class AnimationPlayer(WindowBase):
    def __init__(self, animationLibrary, viewer):
        super().__init__()
        self.animationLibrary = animationLibrary
        self.viewer = viewer
        self._currentAnimation = None
        self._selectedAnimIndex = 0
        self._currentFrame = 0
        self._speed = 1.0
        self._isPlaying = False
        self._isLooping = False
        self._showSeleleton = False
        self._sessionIsResetting = False
        pxz.view.addAnimationPlayingStatusChangedCallback(onAnimationPlayingStatusChanged, self)

    def draw(self):
        # get copy from library
        animations = self.animationLibrary.getAllCopy()
        if not animations:
            self._currentAnimation = None
            imgui.text("Import animations to play them here.")
            return
        # UI start
        if imgui.begin_table("Animation UI", 2):
            imgui.table_next_row()
            imgui.table_next_column()
            # animation selector
            self.drawAnimationSelectionCombo(animations)
            # time slider
            self.drawTimeSlider(animations)
            # looping
            self.drawLoopingToggle()
            # speed
            self.drawSpeedCombo()
            # skeleton
            self.drawShowSkeletonToggle()
            imgui.end_table()
        # play/pause button
        if imgui.button(("Play" if self.isPaused() else "Pause") + "##AnimationPlayerButton", ImVec2(imgui.get_content_region_avail()[0], 0)):
            self.playPauseAnimation()
        if imgui.button("Stop" + "##AnimationPlayerStopButton", ImVec2(imgui.get_content_region_avail()[0], 0)):
            pxz.view.stopAllAnimation()
        # perform actual animation step
        if self._currentAnimation is not None and self.animationLibrary.animationExists(self._currentAnimation) and pxz.view.isAnimationPlaying(self._currentAnimation):
            pxz.view.applyPlayingAnimations(self.viewer.getCurrentTime())

    def playPauseAnimation(self):
        if self.isPaused():
            pxz.view.applyPlayingAnimations(self.viewer.getCurrentTime())
            if self._currentFrame != 0:
                pxz.view.resumeAnimation(self._currentAnimation)
            else:
                pxz.view.playAnimation(self._currentAnimation, self._speed, self._isLooping)
        else:
            pxz.view.pauseAnimation(self._currentAnimation)
        pxz.view.applyPlayingAnimations(self.viewer.getCurrentTime())

    def isPaused(self):
        if self._currentAnimation is None:
            return True
        return not pxz.view.getAnimationPlayerInfo(self._currentAnimation).isPlaying

    def onAnimationPlayingStatusChanged(self, animationId, animationPlayerInfo):
        if animationId == self._currentAnimation:
            self._currentFrame = animationPlayerInfo.currentFrame
            self._isLooping = animationPlayerInfo.isLooping
            self._isPlaying = animationPlayerInfo.isPlaying
            self._speed = animationPlayerInfo.speed

    def drawAnimationSelectionCombo(self, animations):
        imgui.text("Animation ID")
        imgui.table_next_column()
        allAnimationIDs = list(animations.keys())
        if self._currentAnimation is not None and self._currentAnimation in allAnimationIDs:
            self._selectedAnimIndex = allAnimationIDs.index(self._currentAnimation)
        imgui.set_next_item_width(imgui.get_content_region_avail()[0])
        allAnimationIDsWithNames = [animations[int(animId)].name + ' (' + str(animId) + ')' for animId in allAnimationIDs]
        animationComboChanged, self._selectedAnimIndex = imgui.combo("##AnimationSelectionCombo", self._selectedAnimIndex, allAnimationIDsWithNames)
        if self._selectedAnimIndex < len(allAnimationIDs):
            self._currentAnimation = allAnimationIDs[self._selectedAnimIndex]
        if self._currentAnimation is None or self._sessionIsResetting:
            imgui.end_table()
            return
        imgui.table_next_row()
        imgui.table_next_column()

    def drawTimeSlider(self, animations):
        imgui.text("Frame")
        imgui.table_next_column()
        imgui.set_next_item_width(imgui.get_content_region_avail()[0])
        sliderChanged, self._currentFrame = imgui.slider_int("##AnimationSlider", self._currentFrame, 0, animations[self._currentAnimation].length)
        if sliderChanged and self.animationLibrary.animationExists(self._currentAnimation):
            pxz.view.setAnimationFrame(self._currentAnimation, self._currentFrame)
        imgui.table_next_row()
        imgui.table_next_column()

    def drawLoopingToggle(self):
        imgui.text("Loop")
        imgui.table_next_column()
        imgui.set_next_item_width(imgui.get_content_region_avail()[0])
        isLoopingChanged, self._isLooping = imgui.checkbox("##AnimationLoop", self._isLooping)
        if isLoopingChanged and self.animationLibrary.animationExists(self._currentAnimation):
            pxz.view.setAnimationLoop(self._currentAnimation, self._isLooping)
        imgui.table_next_row()
        imgui.table_next_column()

    def drawSpeedCombo(self):
        imgui.text("Speed")
        imgui.table_next_column()
        speedListString = ['x0.1', 'x0.5', 'x1.0', 'x2.0', 'x4.0']
        speedList       = [  0.1 ,   0.5 ,   1.0 ,   2.0 ,   4.0 ]
        imgui.set_next_item_width(imgui.get_content_region_avail()[0])
        speedChanged, speedListIndex = imgui.combo("##SpeedCombo", speedList.index(self._speed), speedListString)
        if speedChanged and self.animationLibrary.animationExists(self._currentAnimation):
            self._speed = speedList[speedListIndex]
            pxz.view.setAnimationSpeed(self._currentAnimation, self._speed)
        imgui.table_next_row()
        imgui.table_next_column()

    def drawShowSkeletonToggle(self):
        imgui.text("Show Skeleton")
        imgui.table_next_column()
        imgui.set_next_item_width(imgui.get_content_region_avail()[0])
        isShowSkeletonChanged, self._showSeleleton = imgui.checkbox("##ShowSkeleton", self._showSeleleton)
        if isShowSkeletonChanged:
            if self._showSeleleton:
                try:
                    pxz.core.lockEntityRegistration()
                    self.skeletonOcc = pxz.scene.createSkeletonMesh(pxz.scene.getRoot())
                    pxz.core.unlockEntityRegistration()
                    pxz.scene.setParent(self.skeletonOcc, self.viewer.hiddenOccurrence)
                except:
                    pass
            else:
                pxz.scene.deleteOccurrences([self.skeletonOcc])
        imgui.table_next_row()
        imgui.table_next_column()