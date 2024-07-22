# Pixyz Engine SDK Samples

This GitHub repo contains a set of Pixyz Engine SDK samples to help users get started with the Pixyz SDK.

## Samples

- Import Optimize Export: Describe the first feature here.
- Folder Watcher: Describe the second feature here.
- Parallel Processing: Describe the third feature here.

## Git LFS Setup

This repository uses Git LFS (Large File Storage) to manage large files. To ensure you have Git LFS installed and set up correctly, follow these steps:

**Install Git LFS:** Download and install Git LFS from [here](https://git-lfs.github.com/)

## Installation Instructions

1. Clone the GitHub Repo using your tool of choice. The example below uses GitHub Desktop by copying and pasting the GitHub repo URL

   <img src="https://github.com/user-attachments/assets/b038e8b6-cc25-4906-870a-a25a0ee8ddd0" alt="chrome_7XEMK8S1q6" width="400">
   <img src="https://github.com/user-attachments/assets/5ba4f11b-b536-4c66-abaa-8aa5351126e3" alt="GitHubDesktop_WqFnh62IFS" width="400">

3. Create a python project using your script editor of choice. This example is using PyCharm and you simply point to the python/Windows folder
   
   <img src="https://github.com/user-attachments/assets/e4f3c2eb-3e07-4c51-86fb-71f24e284287" alt="pycharm64_HCQ2Ogd087" width="400">
   <img src="https://github.com/user-attachments/assets/e2a16094-a327-42ea-a93e-beed960ab03b" alt="pycharm64_YgdAnDVArh" width="400">

5. Add pixyz SDK bin and lib folder to the projects interpreter path. To do this in pycharm go to Settings>Python Interpreter>Show All>Show Interpreter Paths>Add(+)
Then Select the bin and lib folder located at [Project directory]/shared/shared_modules/PiXYZAPI-XXXX.X.X.X/
<img src="https://github.com/user-attachments/assets/e6f031b4-83f8-40d6-99de-9b13506b63f5" alt="NVIDIA_Share_QB9oyf7bev" width ="400">
<img src="https://github.com/user-attachments/assets/ea6dc905-67bc-4d13-87d1-33a90921abf3" alt="NVIDIA_Share_sPbZ4yqFK1" width ="400">

7. To install the local Unity Cloud SDK package for the folder watcher sample run "pip install shared/shared_modules/unity_cloud-0.9.0-py3-none-win_amd64.whl" in the local terminal
8. To install the python QT package for the parallel processing sample run "pip install pyside6" in the local terminal

**The Project is now installed and setup. To use the samples please follow the usage instructions below**

## Usage Instructions
**The samples repository is split up into three samples**
Note: All the samples use the common functions defined in the ImportOptimiseExport script. You will need to follow these first initial steps for other samples to work.
**Import Optimise Export**
1. Pixyz SDK license setup
2. Step 2: Describe the second usage step.
3. Step 3: Describe the third usage step.

**Folder Watcher**
1. 
2. Service Account
3. Step 2: Describe the second usage step.
4. Step 3: Describe the third usage step.

**Parallel Processing**
Note: This sample consumes multiple pixyz licenses at the same time as they are initialized in separate processes that run in parallel
1. Make sure that you have pyside6 installed as per step 8 in the installation doc. This is what is used to create the user interface
2. Locate the main parallel processign folder. You will see two scripts, one is the main script that controls the UI and exectues the second script per process that is started.
3. Run the main script, you will see a new window appear, you can use this window to add new files to import by using the + button at the bottom. Each file that you import will start a new process and consume a node of pixyz SDK. These will run in parallel until completed or terminated.  
4. All processes that are running or completed will be present in the main UI process. Any information that is printed to the console will be shown in the label field

# Converting to public repository
Any and all Unity software of any description (including components) (1) whose source is to be made available other than under a Unity source code license or (2) in respect of which a public announcement is to be made concerning its inner workings, may be licensed and released only upon the prior approval of Legal.
The process for that is to access, complete, and submit this [FORM](https://airtable.com/appj757BYrNIMuTBI/shriEdWiQuxWmJOku).
