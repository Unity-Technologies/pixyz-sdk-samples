import sys
import pxz
from pxz import core
import os
import platform
import ctypes


def init_pixyz():

    # init Pixyz
    pxz.initialize("PixyzSDK", "204b0ede26cfc54774cbbdaa175c1456c43b253144396405304009f926c0ebfcd5")

    if debugger_is_active():
        # set log level to INFO so that we can see the logs in the console
        core.configureInterfaceLogger(True, True, True)
        core.addConsoleVerbose(core.Verbose.INFO)
    else:
        core.configureInterfaceLogger(False, False, False)

    # add all tokens
    for token in pxz.core.listTokens():
        core.addWantedToken(token)

    # if no license is found, try to configure a license server
    if not core.checkLicense():
        core.configureLicenseServer("lics-it-gcp-p01", 27005, True)

    if os.name == "nt":
        initialize_dedicated_graphics()


def debugger_is_active() -> bool:
    """Return true if the debugger is currently active"""
    return hasattr(sys, 'gettrace') and sys.gettrace() is not None


def initialize_dedicated_graphics():
    """force program to be executed on discrete GPU in case of a dual integrated/discrete architecture
    """
    try:
        if platform.architecture()[0] == "64bit":
            nvapi = ctypes.WinDLL("nvapi64.dll")
        else:
            nvapi = ctypes.WinDLL("nvapi.dll")

        nvapi.fake()  # Call the 'fake' entry point
    except:
        pass  # Ignore any exceptions since the 'fake' entry point doesn't exist
