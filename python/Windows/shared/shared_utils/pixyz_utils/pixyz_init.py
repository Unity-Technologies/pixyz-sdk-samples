import os
import platform
import sys
import ctypes
import pxz

current_progress = 0
# By default, you don't need a product/validation key except for version before 2024.2.0.24 and special cases
product_name = None
validation_key = None
server_name = "SERVER_HOSTNAME"
port = 27005


def initPixyz():
    # init Pixyz
    print("Initializing pixyz sdk")
    if validation_key is None:
        pxz.initialize()
    else:
        pxz.initialize(product_name, validation_key)

    if debuggerIsActive():
        # set log level to INFO so that we can see the logs in the console
        pxz.core.configureInterfaceLogger(True, True, True)
        pxz.core.addConsoleVerbose(pxz.core.Verbose.INFO)
    else:
        pxz.core.configureInterfaceLogger(False, False, False)

    # add all tokens
    for token in pxz.core.listTokens():
        pxz.core.needToken(token)
    if os.name == "nt":
        initializeDedicatedGraphics()

    pxz.core.addProgressChangedCallback(onProgressChangedCallback, 0)
    pxz.core.addOnSessionResetCallback(onSessionResetCallback, 0)


def initializeDedicatedGraphics():
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


def debuggerIsActive() -> bool:
    """Return true if the debugger is currently active"""
    return hasattr(sys, 'gettrace') and sys.gettrace() is not None


def getPixyzLicense():
    print(f"Getting pixyz license ")
    # if no license is found, try to configure a license server
    if not pxz.core.checkLicense():
        pxz.core.configureLicenseServer(server_name, port, True)


def onProgressChangedCallback(progress):
    global current_progress
    if progress != -1:
        if progress % 5 == 0:
            if progress != current_progress:
                print("Progress: {0}".format(progress))
                current_progress = progress


def onSessionResetCallback():
    print("Session reset")
