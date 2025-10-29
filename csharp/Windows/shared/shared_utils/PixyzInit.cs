namespace PiXYZDemo
{
    using Newtonsoft.Json;
    using System.Runtime.InteropServices;
    using UnityEngine.Pixyz.API;
    using UnityEngine.Pixyz.Geom;
    using UnityEngine.Pixyz.Scene;
    using UnityEngine.Pixyz.View;


    public static class PixyzInit
    {
        public static PiXYZAPI api;

        private static int currentProgress = 0;

        static string serverName = "Server Name";
        static ushort serverPort = 27005;

        public static void InitPixyz()
        {
            Console.WriteLine("Initializing pixyz sdk");
            
            api = PiXYZAPI.Initialize();

            Console.WriteLine("Adding available tokens.");
            foreach (var token in api.Core.ListTokens().list)
            {
                try
                {
                    api.Core.AddWantedToken(token);
                    Console.WriteLine($"Token {token} added successfully.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Failed to add token {token}: {e.Message}");
                }
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                InitializeDedicatedGraphics();
            }

            api.Core.AddProgressChangedCallback(OnProgressChangedCallback, 0);
            api.Core.AddOnSessionResetCallback(OnSessionResetCallback, 0);

        }

        public static void GetPixyzLicense()
        {
            if (!api.Core.CheckLicense())
            {
                api.Core.ConfigureLicenseServer(serverName, serverPort, true);
                Console.WriteLine("Configured license server.");
            }

        }

        private static void InitializeDedicatedGraphics()
        {
            // Force program to be executed on discrete GPU in case of a dual integrated/discrete architecture
            try
            {
                var is64Bit = RuntimeInformation.ProcessArchitecture == Architecture.X64;
                var dllName = is64Bit ? "nvapi64.dll" : "nvapi.dll";
                var nvapi = NativeLibrary.Load(dllName);

                // Simulate a call to a nonexistent method as a placeholder
                // If there are specific functions to be called, replace 'Fake' with them
                var fakeMethod = NativeLibrary.GetExport(nvapi, "fake");
               // fakeMethod.DynamicInvoke(); // Assumes handle to 'fake' method for demonstration

                NativeLibrary.Free(nvapi);
            }
            catch (Exception)
            {
                // Ignore any exceptions since the 'fake' entry point doesn't exist
            }
        }
        private static void OnProgressChangedCallback(nint userdata, int progress)
        {
            if (progress != -1)
            {
                if (progress % 5 == 0)
                {
                    if (progress != currentProgress)
                    {
                        Console.WriteLine($"Progress: {progress}");
                        currentProgress = progress;
                    }
                }
            }
        }

        private static void OnSessionResetCallback(nint userdata)
        {
            Console.WriteLine("Session reset");
        }
    }
}

