import sys
from PySide6.QtWidgets import (QApplication, QMainWindow, QWidget, QVBoxLayout, QHBoxLayout, QPushButton, QLabel, QScrollArea, QFrame, QSizePolicy, QFileDialog)
from PySide6.QtCore import QProcess, Qt
from PySide6.QtGui import QIcon
import sys
python_executable_path = sys.executable
class ProcessWidget(QFrame):
    def __init__(self, command, args, description, update_counter):
        super().__init__()
        self.process = QProcess()
        self.updateCounter = update_counter  # Function to update the process counter
        self.initUI(description)

        # Start the process with specified arguments
        self.process.start(command, args)
        self.process.readyReadStandardOutput.connect(self.handleStdout)
        self.process.finished.connect(self.processFinished)

        self.setMaximumHeight(64)  # Set maximum height for each row

    def initUI(self, description):
        self.setLayout(QHBoxLayout())
        self.setFrameShape(QFrame.StyledPanel)  # Correctly setting the frame shape
        self.setFrameShadow(QFrame.Raised)  # Correctly setting the frame shadow
        self.setLineWidth(1)  # Example line width
        self.label = QLabel(f"Started: {description}")
        self.label.setWordWrap(True)
        self.stopButton = QPushButton("Stop Process")
        self.stopButton.clicked.connect(self.stopProcess)

        self.layout().addWidget(self.label)
        self.layout().addWidget(self.stopButton)
    def handleStdout(self):
        data = self.process.readAllStandardOutput().data().decode()
        self.label.setText(f"Process: {data.strip()}")

    def stopProcess(self):
        self.process.kill()
        self.label.setText("Process terminated")
        self.stopButton.setDisabled(True)

    def processFinished(self, exitCode, exitStatus):
        self.updateCounter(-1)  # Decrement process counter
        if self.label.text() != "Process terminated":
            self.label.setText("Process completed")
        self.stopButton.setDisabled(True)

class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.descriptionLabel = None
        self.maxProcesses = 5
        self.currentProcesses = 0
        self.initUI()

    def initUI(self):
        self.setWindowTitle('Multi-Process Monitor')
        self.setGeometry(100, 100, 800, 600)

        # Central widget and layout
        central_widget = QWidget()
        self.setCentralWidget(central_widget)
        layout = QVBoxLayout()
        central_widget.setLayout(layout)

        # Description label
        self.descriptionLabel = QLabel(f"Current Process Count: 0 of {self.maxProcesses}")
        layout.addWidget(self.descriptionLabel)

        # Scroll area setup
        self.scrollArea = QScrollArea()
        self.scrollArea.setWidgetResizable(True)
        self.scrollWidget = QWidget()
        self.scrollArea.setWidget(self.scrollWidget)

        # Scroll layout setup
        self.scrollLayout = QVBoxLayout(self.scrollWidget)
        self.scrollLayout.setSpacing(10)
        self.scrollWidget.setLayout(self.scrollLayout)

        # Adding a stretch at the end of the layout to push all widgets up
        self.scrollLayout.addStretch(1)

        layout.addWidget(self.scrollArea)

        # Start button with Plus Icon, placed below the scroll area
        self.startButton = QPushButton()
        self.startButton.setIcon(QIcon.fromTheme("list-add"))
        self.startButton.clicked.connect(self.openFileDialog)
        layout.addWidget(self.startButton)

    def openFileDialog(self):
        if self.currentProcesses < self.maxProcesses:
            filename, _ = QFileDialog.getOpenFileName(self, "Select File")
            if filename:
                self.start_process(filename)

    def start_process(self, filename):
        command = python_executable_path
        args = ["pixyz_process.py", filename]
        description = f"Running pixyz Process for {filename}"
        widget = ProcessWidget(command, args, description, self.updateProcessCounter)
        self.scrollLayout.insertWidget(self.scrollLayout.count() - 1, widget)
        self.updateProcessCounter(1)  # Increment process counter

    def updateProcessCounter(self, increment):
        self.currentProcesses += increment
        self.descriptionLabel.setText(f"Current Process Count: {self.currentProcesses} of {self.maxProcesses}")
        self.startButton.setEnabled(self.currentProcesses < self.maxProcesses)

if __name__ == '__main__':
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec())