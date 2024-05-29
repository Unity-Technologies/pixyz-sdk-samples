from imgui_bundle import imgui
from imgui_bundle import imspinner
import pxz

def onProgressionChanged(progress, progressBar):
    progressBar.progression = progress

def onStepStart(stepName, progressBar):
    progressBar.stepName = stepName
class ProgressBar:
    def __init__(self, ui):
        self.ui = ui
        self.progression = -1
        self.stepName = ""
        pxz.core.addProgressChangedCallback(onProgressionChanged, self)
        pxz.core.addProgressStepStartCallback(onStepStart, self)

    def draw(self):
        if self.progression >= 0:
            windowFlags = imgui.WindowFlags_.no_title_bar | imgui.WindowFlags_.no_move | imgui.WindowFlags_.no_resize #|imgui.WindowFlags_.no_background
            centralNode = imgui.internal.dock_builder_get_central_node(self.ui.dockSpaceID)
            windowSizeX = min(700, centralNode.size.x-20)
            imgui.set_next_window_pos((centralNode.pos.x + (centralNode.size.x-windowSizeX)/2, centralNode.pos.y + centralNode.size.y-42-5))
            imgui.set_next_window_size((windowSizeX,42))
            imgui.begin("ProgressBar", False, windowFlags)
            imspinner.spinner_arc_rotation("Spinner", 10, 4)
            imgui.same_line()
            text = self.stepName + " " + str(self.progression) + "%"
            imgui.progress_bar(self.progression/100., overlay=text, size_arg=(windowSizeX-45, 25))
            imgui.end()

    def taskFinished(self):
        self.progression = -1


