import pxz

class FunctionLibrary:
    def __init__(self, ui):
        self.ui = ui
        self.modules = pxz.core.getModules()
        self._moduleCache = []
        self._createModuleCache()

    def getPrettyFunctionString(self, module, function, addParameters=True):
        if addParameters:
            params = ", ".join([param.type.name + " " + param.name for param in function.parameters])
        else:
            params = "..." if function.parameters else ""
        return module.name.lower() + "." + function.name + "(" + params + ")"

    def getModulesCopy(self):
        # caching the modules to improve performance
        # pxz.core.getModules() takes easily 300ms, so we store up to 10 modules in self._moduleCache
        if not self._moduleCache:
            # if the cache is empty, we need to wait for the cache to be filled
            self.ui.processQueue.wait()
        modules = self._moduleCache.pop()
        self._createModuleCache()
        return modules

    def _createModuleCache(self):
        def createModuleCache():
            while len(self._moduleCache) < 10:
                self._moduleCache.insert(0, pxz.core.getModules())
        self.ui.processQueue.enqueue(createModuleCache)

    def getDefaultParameters(self, module, function):
        functionDescription = self.getFunctionDescription(module, function)
        return {param.name: param.defaultValue for param in functionDescription.parameters}

    def getFunctionDescription(self, moduleName, function):
        module = next((m for m in self.modules if m.name == moduleName), None)
        if not module:
            raise Exception("Module not found")
        for group in module.groups:
            for f in group.functions:
                if f.name == function:
                    return f
        raise Exception("Function not found")
