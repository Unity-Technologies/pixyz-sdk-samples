
class IWidget:
    def draw(self):
        raise NotImplementedError

    def getValue(self):
        raise NotImplementedError

    def setValue(self, value):
        raise NotImplementedError

    def destroy(self):
        # can be overwritten to clean up before the widget is destroyed (e.g. listeners)
        pass
