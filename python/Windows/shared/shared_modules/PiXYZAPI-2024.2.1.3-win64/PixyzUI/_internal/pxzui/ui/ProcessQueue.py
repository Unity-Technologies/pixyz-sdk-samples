import pxz
import queue
import threading


class ProcessQueue:
    def __init__(self, ui):
        self.queue = queue.Queue()
        self.ui = ui
        self.worker_running = False

    def enqueue(self, func, *args, **kwargs):
        self.queue.put((func, args, kwargs))
        if not self.worker_running:
            self.worker_running = True
            thread = threading.Thread(target=self.work)
            thread.start()

    def work(self):
        pxz.core.setCurrentThreadAsProcessThread()
        while not self.queue.empty():
            func, args, kwargs = self.queue.get(timeout=1)
            try:
                func(*args, **kwargs)
            except Exception as error:
                print("An exception occurred during task:", error)
            self.ui.taskFinished()
            self.queue.task_done()
        self.worker_running = False

    def wait(self):
        self.queue.join()
