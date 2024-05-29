import pxz

class FunctionLibrary:
    def __init__(self):
        self.modules = pxz.core.getModules()

    def getPrettyFunctionString(self, module, function, addParameters=True):
        if addParameters:
            params = ", ".join([param.type.name + " " + param.name for param in function.parameters])
        else:
            params = "..." if function.parameters else ""
        return module.name + "." + function.name + "(" + params + ")"
