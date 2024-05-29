import os
import platform
import sys
import ctypes
import pxz
current_progress = 0
def init_pixyz():
    # init Pixyz
    print("Initializing pixyz sdk")
    pxz.initialize("PixyzSDK", "204b0ede26cfc54774cbbdaa175c1456c43b253144396405304009f926c0ebfcd5")

    if debugger_is_active():
        # set log level to INFO so that we can see the logs in the console
        pxz.core.configureInterfaceLogger(True, True, True)
        pxz.core.addConsoleVerbose(pxz.core.Verbose.INFO)
    else:
        pxz.core.configureInterfaceLogger(False, False, False)

    # add all tokens
    for token in pxz.core.listTokens():
        pxz.core.addWantedToken(token)
    if os.name == "nt":
        initialize_dedicated_graphics()

    pxz.core.addProgressChangedCallback(onProgressChangedCallback, 0)
    pxz.core.addOnSessionResetCallback(onSessionResetCallback, 0)

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

def debugger_is_active() -> bool:
    """Return true if the debugger is currently active"""
    return hasattr(sys, 'gettrace') and sys.gettrace() is not None

def get_pixyz_license():
    print(f"Getting pixyz license ")
    # if no license is found, try to configure a license server
    if not pxz.core.checkLicense():
        pxz.core.configureLicenseServer("lics-it-gcp-p01", 27005, True)
def onProgressChangedCallback(progress):
    global current_progress
    if progress != -1:
        if progress % 5 == 0:
            if progress != current_progress:
                print("Progress: {0}".format(progress))
                current_progress = progress


def onSessionResetCallback():
    print("Session reset")