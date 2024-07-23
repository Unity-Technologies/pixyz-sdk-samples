import json
import os
from ctypes import windll

from ImportOptimiseExport import import_optimise_export as import_optimise_export
from shared.shared_utils.pixyz_utils import pixyz_init as pixyz_init


def main(config_file):
    printLogo()
    input_folder, output_folder, extensions, optimization, publish_to_assetmanager, orgid, projid, collection_path, tags = read_config(
        config_file)

    waiting = False

    while (1):
        input_files = [file for file in os.listdir(input_folder) \
                       if (os.path.isfile(input_folder + '/' + file) \
                           and getFileExtension(file) not in ['.xml', ''])]

        if len(input_files) == 0:
            if not waiting:
                print('\n')
                print('Waiting for files to process...\n')
                waiting = True
            continue
        elif not isCopyFinished(input_folder + '/' + input_files[0]):
            continue
        else:
            waiting = False

        input_file = input_folder + '/' + input_files[0]
        executepixyzSDK(input_file, output_folder, extensions, optimization, publish_to_assetmanager, orgid, projid,
                        collection_path, tags)

        os.remove(input_file)  # remove when finishing processing


def read_config(config_file):
    with open(config_file) as config:
        inputs = json.load(config)

    # Get arguments from config json file
    input_folder = inputs['input_folder']
    # convert relative path to absolute path (if needed)
    input_folder = os.path.abspath(input_folder)
    output_folder = inputs['output_folder']
    # convert relative path to absolute path
    output_folder = os.path.abspath(output_folder)
    extensions = inputs['extensions']
    optimization = inputs['optimization']
    # read asset manager cloud inputs
    publish_to_assetmanager = inputs['publish_to_assetmanager']
    orgid = inputs['orgid']
    projid = inputs['projid']
    collection_path = inputs['collectionpath']
    tags = inputs['tags']

    print('\n')
    print('Input folder: %s\n' % input_folder)
    print('Output folder: %s\n' % output_folder)
    print('Extensions: %s\n' % ' '.join(extensions))
    print('Publish to Asset Manager: %s\n' % publish_to_assetmanager)
    print('Organisation ID: %s\n' % orgid)
    print('Project ID: %s\n' % projid)
    print('Collection Path: %s\n' % collection_path)
    print('Asset Tags: %s\n' % tags)

    return input_folder, output_folder, extensions, optimization, publish_to_assetmanager, orgid, projid, collection_path, tags


def isCopyFinished(inputFile):
    """
    Check if the file that was dropped in the input folder has finished being copied
    """
    generic_write = 1 << 30
    file_share_read = 0x00000001
    open_existing = 3
    file_attribute_normal = 0x80
    handle = windll.Kernel32.CreateFileW(inputFile, generic_write, file_share_read, None, open_existing,
                                         file_attribute_normal, None)
    if handle != -1:
        windll.Kernel32.CloseHandle(handle)
        return True
    return False


def getFileExtension(file):
    return os.path.splitext(file)[1]


def executepixyzSDK(input_file, output_folder, extensions, optimization, publish_to_assetmanager, orgid, projid,
                    collection_path, tags):
    pixyz_init.init_pixyz()
    if publish_to_assetmanager == "True":
        from shared.shared_utils.unity_cloud_utils import unitycloud_init as unitycloud_init
        unitycloud_init.unitycloud_init()
    import_optimise_export.convertFile(input_file, output_folder, extensions, optimization, publish_to_assetmanager,
                                       orgid, projid, collection_path, tags)


def printLogo():
    print('')
    print("     #######                %######     ")
    print("  ##############        &#############& ")
    print("######      ######    ######      &#####")
    print("####          &###########          ####")
    print("####%            ######             ####")
    print(" #####&       &###### ####        #####%")
    print("   ######   ######    ######   &######  ")
    print("     ######& ###        &##########     ")
    print("       #######             ######       ")
    print("    &###########&       #### &######    ")
    print("  ######     ######  &######    ######& ")
    print(" #####         ##% ######         &####%")
    print("####%           %#######            ####")
    print("####%         ############&         ####")
    print(" #####&    %#####%     ######%    #####%")
    print("   ############          #############  ")
    print("     #######                %######     ")


if __name__ == "__main__":
    main("config.json")
