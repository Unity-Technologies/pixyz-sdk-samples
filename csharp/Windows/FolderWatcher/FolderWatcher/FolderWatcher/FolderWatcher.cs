
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace PiXYZDemo
{
    class FolderWatcher
    {
        private static void WatchFolder (string configFile)
        {
            var (inputFolder, outputFolder, extensions, optimization, publishToAssetmanager, orgid, projid, collectionPath, tags) = ReadConfig(configFile);

            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = inputFolder;
                watcher.Filter = "*.*";
                watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;

                watcher.Created += (sender, e) => OnChanged(e.FullPath, inputFolder, outputFolder, extensions, optimization, publishToAssetmanager, orgid, projid, collectionPath, tags);

                watcher.EnableRaisingEvents = true;

                Console.WriteLine("\nWaiting for files to process...\n");
                Console.ReadLine(); // Keep the application running
            }

        }

        private static void OnChanged(string filePath, string inputFolder, string outputFolder, string[] extensions, bool optimization, string publishToAssetmanager, string orgid, string projid, string collectionPath, string[] tags)
        {
            string fileExtension = GetFileExtension(filePath);

            if (extensions.Contains(fileExtension))
            {
                Console.WriteLine($"Processing file: {filePath}");

                // Add your processing logic here
                ExecutePixyzSDK(filePath, outputFolder, extensions, optimization, publishToAssetmanager, orgid, projid, collectionPath, tags);

                // Remove the file after processing if needed:
                File.Delete(filePath);
                Console.WriteLine($"File deleted: {filePath}");
            }
        }

        private static (string, string, string[], bool, string, string, string, string, string[]) ReadConfig(string configFile)
        {
            var configContent = File.ReadAllText("../../../"+configFile);
            dynamic inputs = JsonConvert.DeserializeObject(configContent);

            string inputFolder = Path.GetFullPath((string)inputs.input_folder);
            string outputFolder = Path.GetFullPath((string)inputs.output_folder);
            string[] extensions = ((IEnumerable<object>)inputs.extensions).Select(x => x.ToString()).ToArray();
            bool optimization = (bool)inputs.optimization;
            string publishToAssetmanager = (string)inputs.publish_to_assetmanager;
            string orgid = (string)inputs.orgid;
            string projid = (string)inputs.projid;
            string collectionPath = (string)inputs.collectionpath;
            string[] tags = inputs.tags.ToObject<string[]>();

            Console.WriteLine("\n");
            Console.WriteLine($"Input folder: {inputFolder}\n");
            Console.WriteLine($"Output folder: {outputFolder}\n");
            Console.WriteLine($"Extensions: {string.Join(" ", extensions)}\n");
            Console.WriteLine($"Publish to Asset Manager: {publishToAssetmanager}\n");
            Console.WriteLine($"Organisation ID: {orgid}\n");
            Console.WriteLine($"Project ID: {projid}\n");
            Console.WriteLine($"Collection Path: {collectionPath}\n");
            Console.WriteLine($"Asset Tags:  {string.Join(" ", tags)}\n");

            return (inputFolder, outputFolder, extensions, optimization, publishToAssetmanager, orgid, projid, collectionPath, tags);
        }

        private static void ExecutePixyzSDK(string inputFile, string outputFolder, string[] extensions, bool optimization, string publishToAssetmanager, string orgid, string projid, string collectionPath, string[] tags)
        {
            PixyzInit.GetPixyzLicense();

            if (PixyzInit.api.Core.CheckLicense())
            {
                ImportOptimiseExport.ConvertFile(inputFile, outputFolder, extensions.ToList(), optimization, orgid, projid, collectionPath, tags.ToList());
            }
            else
            {
                Console.WriteLine("No License Available");
            }
            
        }

        private static string GetFileExtension(string file)
        {
            return Path.GetExtension(file);
        }

        static void PrintLogo()
        {
            Console.WriteLine("");
            Console.WriteLine("     #######                %######     ");
            Console.WriteLine("  ##############        &#############& ");
            Console.WriteLine("######      ######    ######      &#####");
            Console.WriteLine("####          &###########          ####");
            Console.WriteLine("####%            ######             ####");
            Console.WriteLine(" #####&       &###### ####        #####%");
            Console.WriteLine("   ######   ######    ######   &######  ");
            Console.WriteLine("     ######& ###        &##########     ");
            Console.WriteLine("       #######             ######       ");
            Console.WriteLine("    &###########&       #### &######    ");
            Console.WriteLine("  ######     ######  &######    ######& ");
            Console.WriteLine(" #####         ##% ######         &####%");
            Console.WriteLine("####%           %#######            ####");
            Console.WriteLine("####%         ############&         ####");
            Console.WriteLine(" #####&    %#####%     ######%    #####%");
            Console.WriteLine("   ############          #############  ");
            Console.WriteLine("     #######                %######     ");
        }
        static void Main(string[] args)
        {
            PixyzInit.InitPixyz();
            PrintLogo();
            WatchFolder("config.json");
        }
    }
}