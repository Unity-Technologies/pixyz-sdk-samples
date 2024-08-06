class ConfigOwner:
    def __init__(self):
        self._config = {}

    def restoreConfig(self, config):
        for key in config.keys():
            self._config[key] = config[key]

    def saveConfig(self):
        return self._config

    def getConfig(self, key):
        return self._config[key] if key in self._config.keys() else None

    def setConfig(self, key, value):
        self._config[key] = value

    def hasConfig(self, key):
        return key in self._config.keys()
