import pxz

class Utility:
    @staticmethod
    def createFunctionParameterWidget(ui, typeObj, name, defaultValue=""):
        # Exceptions
        if typeObj.type == 8:
            # this is a callback, most likely not to be ever used from the UI. We just return a string widget
            from pxzui.ui.widgets.base.StringWidget import StringWidget
            return StringWidget(ui, name, defaultValue)
        # types that we can handle before finishing alias recursion
        if typeObj.name.lower() == "filepath":
            from pxzui.ui.widgets.base.FilepathWidget import FilepathWidget
            return FilepathWidget(ui, name, defaultValue)
        elif typeObj.name.lower() == "directorypath":
            from pxzui.ui.widgets.base.FilepathWidget import FilepathWidget
            return FilepathWidget(ui, name, defaultValue, True)
        # Expected cases:
        match typeObj.type:
            case pxz.core.TypeDescType.ALIAS:
                aliasType = pxz.core.getType(typeObj.module, typeObj.definition[1].alias)
                return Utility.createFunctionParameterWidget(ui, aliasType, name, defaultValue)
            case pxz.core.TypeDescType.ARRAY:
                from pxzui.ui.widgets.functionWidgets.ArrayWidget import ArrayWidget
                return ArrayWidget(ui, typeObj, name, defaultValue)
            case pxz.core.TypeDescType.BASE:
                # currently there are no functions that need additional arguments, so we can pass None
                return Utility.createBaseWidget(ui, typeObj.name, name, defaultValue)
            case pxz.core.TypeDescType.ENUM:
                from pxzui.ui.widgets.base.EnumWidget import EnumWidget
                return EnumWidget(name, defaultValue, typeObj.definition[1].labels)
            case pxz.core.TypeDescType.LIST:
                from pxzui.ui.widgets.functionWidgets.ListWidget import ListWidget
                return ListWidget(ui, typeObj, name, defaultValue)
            case pxz.core.TypeDescType.SELECT:
                from pxzui.ui.widgets.functionWidgets.SelectWidget import SelectWidget
                return SelectWidget(ui, typeObj, name, defaultValue)
            case pxz.core.TypeDescType.STRUCT:
                from pxzui.ui.widgets.functionWidgets.StructWidget import StructWidget
                return StructWidget(ui, typeObj, name, defaultValue)
            case _:
                raise Exception("ERROR: Unhandled parameter type \"" + str(typeObj.type) + "\"!")

    @staticmethod
    def createPropertyWidget(ui, propertyInfo):
        # is there a more elegant way to get the property type name from the type int?
        propertyTypeNames = {v: k for k, v in pxz.core.PropertyType.__dict__.items()}
        typeName = propertyTypeNames[propertyInfo.type]
        if typeName == "ENTITY":
            return Utility.createEntityWidget(ui, propertyInfo)
        elif typeName == "ENUM":
            from pxzui.ui.widgets.base.EnumWidget import EnumWidget
            return EnumWidget(propertyInfo.name, propertyInfo.value, pxz.core.listEnumLabels(propertyInfo.subType).labels, False)
        else:
            return Utility.createBaseWidget(ui, typeName, propertyInfo.name, propertyInfo.value)

    @staticmethod
    def createEntityWidget(ui, propertyInfo):
        if propertyInfo.subType == 11001:
            # MATERIAL
            from pxzui.ui.widgets.entityWidgets.MaterialWidget import MaterialWidget
            return MaterialWidget(ui, propertyInfo.name, propertyInfo.value)
        else:
            from pxzui.ui.widgets.base.StringWidget import StringWidget
            return StringWidget(ui, propertyInfo.name, propertyInfo.value)

    @staticmethod
    def createBaseWidget(ui, typeName, name, defaultValue=""):
        match typeName.lower().replace(" ", "").replace("_", ""):
            case "angle":
                from pxzui.ui.widgets.base.DoubleWidget import DoubleWidget
                return DoubleWidget(name, defaultValue)
            case "bool" | "boolean":
                from pxzui.ui.widgets.base.BooleanWidget import BooleanWidget
                return BooleanWidget(name, defaultValue)
            case "boundedint" | "boundedinteger" | "bounded_integer":
                from pxzui.ui.widgets.base.BoundedIntWidget import BoundedIntWidget
                return BoundedIntWidget(name, defaultValue)
            case "coeff":
                from pxzui.ui.widgets.base.CoeffWidget import CoeffWidget
                return CoeffWidget(name, defaultValue)
            case "coeffortexture":
                from pxzui.ui.widgets.base.CoeffOrTextureWidget import CoeffOrTextureWidget
                return CoeffOrTextureWidget(ui, name, defaultValue)
            case "coloralpha":
                from pxzui.ui.widgets.base.ColorAlphaWidget import ColorAlphaWidget
                return ColorAlphaWidget(name, defaultValue)
            case "color":
                from pxzui.ui.widgets.base.ColorWidget import ColorWidget
                return ColorWidget(name, defaultValue)
            case "colorortexture":
                from pxzui.ui.widgets.base.ColorOrTextureWidget import ColorOrTextureWidget
                return ColorOrTextureWidget(ui, name, defaultValue)
            case "distance":
                from pxzui.ui.widgets.base.DoubleWidget import DoubleWidget
                return DoubleWidget(name, defaultValue)
            case "double":
                from pxzui.ui.widgets.base.DoubleWidget import DoubleWidget
                return DoubleWidget(name, defaultValue)
            case "filepath":
                from pxzui.ui.widgets.base.FilepathWidget import FilepathWidget
                return FilepathWidget(ui, name, defaultValue)
            case "inheritablebool":
                from pxzui.ui.widgets.base.InheritableBooleanWidget import InheritableBooleanWidget
                return InheritableBooleanWidget(name, defaultValue)
            case "ident" | "identifier":
                from pxzui.ui.widgets.base.StringWidget import StringWidget
                return StringWidget(ui, name, defaultValue)
            case "int" | "integer":
                from pxzui.ui.widgets.base.IntWidget import IntWidget
                return IntWidget(name, defaultValue)
            case "matrix4":
                from pxzui.ui.widgets.base.Matrix4Widget import Matrix4Widget
                return Matrix4Widget(name, defaultValue)
            case "point3":
                from pxzui.ui.widgets.base.Point3Widget import Point3Widget
                return Point3Widget(name, defaultValue)
            case "ptr":
                from pxzui.ui.widgets.base.StringWidget import StringWidget
                return StringWidget(ui, name, defaultValue)
            case "real":
                from pxzui.ui.widgets.base.DoubleWidget import DoubleWidget
                return DoubleWidget(name, defaultValue)
            case "string":
                from pxzui.ui.widgets.base.StringWidget import StringWidget
                return StringWidget(ui, name, defaultValue)
            case "texture" | "texturedef":
                from pxzui.ui.widgets.base.TextureWidget import TextureWidget
                return TextureWidget(ui, name, defaultValue)
            case "uint" | "unsignedint" | "unsignedinteger":
                from pxzui.ui.widgets.base.UIntWidget import UIntWidget
                return UIntWidget(name, defaultValue)
            case _:
                print("ERROR: Unsupported BaseType " + str(typeName) + ".")
                from pxzui.ui.widgets.base.StringWidget import StringWidget
                return StringWidget(ui, name, defaultValue)
                # raise Exception("ERROR: Unsupported BaseType " + str(typeName) + ".")

    @staticmethod
    def parseList(inputString):
        # Remove whitespace from the input string
        inputString = ''.join(inputString.split())
        # Initialize variables
        result = []
        currentItem = ''
        nestLevel = 0
        # Iterate over each character in the input string
        for char in inputString:
            if char == '[':
                if nestLevel > 0:
                    currentItem += char
                nestLevel += 1
            elif char == ']':
                nestLevel -= 1
                if nestLevel > 0:
                    currentItem += char
                elif nestLevel == 0:
                    result.append(currentItem)
                    currentItem = ''
            elif char == ',' and nestLevel == 1 and currentItem:
                result.append(currentItem)
                currentItem = ''
            elif nestLevel >= 0:
                currentItem += char
        if currentItem:
            result.append(currentItem)
        return result

    @staticmethod
    def parseFloatList(inputString):
        s = ''.join(i for i in inputString if i.isdigit() or i in '-.,/\\')
        return [float(x) for x in s.split(',')]

    @staticmethod
    def isFunctionParameterString(type):
        if type.type == pxz.core.TypeDescType.ALIAS:
            aliasType = pxz.core.getType(type.module, type.definition[1].alias)
            return Utility.isFunctionParameterString(aliasType)
        if type.type == pxz.core.TypeDescType.BASE:
            return type.name.lower() == "string"
        else:
            return False
