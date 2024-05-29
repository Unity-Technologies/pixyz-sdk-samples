import abc

from pathlib import Path
from imgui_bundle import imgui

class Fonts(abc.ABC):
    _FONT_PATH = None
    _FONT_REGULAR_NAME = "Roboto/Roboto-Regular.ttf"
    _FONT_MONO_NAME    = "SourceCodePro-Regular.ttf"
    
    _FONT_SIZE = 16
    _fonts_regular = {}
    _fonts_mono    = {}
    
    @classmethod
    def initialize(cls, project_path:str, monitorContentScalings:list):
        cls._FONT_PATH = Path(project_path) / "assets/fonts"

        path_regular = str(cls._FONT_PATH / cls._FONT_REGULAR_NAME)
        path_mono = str(cls._FONT_PATH / cls._FONT_MONO_NAME)

        io = imgui.get_io()
        for monitor_name, scaleFactor in monitorContentScalings:
            size = int(cls._FONT_SIZE * scaleFactor)
            font = io.fonts.add_font_from_file_ttf(path_regular, size)
            cls._fonts_regular[monitor_name] = font
            font = io.fonts.add_font_from_file_ttf(path_mono, size)
            cls._fonts_mono[monitor_name] = font
            
    @classmethod
    def get_regular(cls, monitor_name:str):
        return cls._fonts_regular[monitor_name]
    
    @classmethod
    def get_mono(cls, monitor_name:str):
        return cls._fonts_mono[monitor_name]