import socket
import threading
#from nvcodec import VideoDecoder

class StreamDecoder:
    def __init__(self, streamInfo):
        print("Creating Nv decoder")
        #self.decoder = VideoDecoder()
        self.socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        print("Connecting stream decoder to " + streamInfo.host + ":" + str(streamInfo.port))
        self.socket.connect(("127.0.0.1", streamInfo.port))
        self.socket.send(streamInfo.viewer.to_bytes(4,'little'))

    def threadLoop(self):
        self.running = True
        while self.running:
            try:
                sizeBuffer = self.socket.recv(8)
                size = int.from_bytes(sizeBuffer, 'little', signed=False)
                dataBuffer = self.socket.recv(size)
                print("Received buffer (size=" + str(size) + ")")
                # frames = self.decoder.decode(dataBuffer)
            except Exception as e:
                print("Exception : " + str(e))

    def start(self):
        print("Starting Decoder thread")
        self.thread = threading.Thread(target=self.threadLoop, args=())
        self.thread.start()

    def stop(self):
        self.running = False
        self.thread.join()