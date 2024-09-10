from imgui_bundle import imgui, ImVec2


# https://pthom.github.io/imgui_bundle/faq.html#_windows_linux_how_to_correctly_size_and_position_the_widgets
#

def EmVec2(x=None, y=None):
    k = imgui.get_font_size()
    if x is None:
        newX = -1
    else:
        newX = k * x
    if y is None:
        newY = -1
    else:
        newY = k * y
    return ImVec2(newX, newY)

