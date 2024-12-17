using System;
using System.Collections.Generic;
using System.IO;

namespace PiXYZDemo
{
    using UnityEngine.Pixyz.Algo;
    using UnityEngine.Pixyz.Scene;
    using UnityEngine.Pixyz.IO;
    
    using static System.Formats.Asn1.AsnWriter;
    using System.Xml.Linq;
    using UnityEngine.Pixyz.API;

    class Program
    {
        static PiXYZAPI api = PiXYZAPI.Initialize();

        static void OptimiseModel(uint root, string fileName)
        {
            var stats = PixyzUtils.GetStats(api, root);
            var t0 = stats.Item1;
            var n_triangles = stats.Item2;
            var n_vertices = stats.Item3;
            var n_parts = stats.Item4;

            var occurrences = new OccurrenceList((int)root);

            Console.WriteLine("Removing Holes...");
            double diameter = 10;
            api.Algo.RemoveHoles(occurrences, true, false, false, diameter, 0);

            Console.WriteLine("Delete Patches...");
            api.Algo.DeletePatches(occurrences, true);

            Console.WriteLine("Decimating...");
            api.Algo.Decimate(occurrences, 1, 0.1, 3, -1, false);

            Console.WriteLine("Removing Hidden Geometries...");
            api.Algo.RemoveOccludedGeometries(occurrences, SelectionLevel.Polygons, 1024, 16, 90, false, 1);

            var newStats = PixyzUtils.GetStats(api, root);
            var t1 = newStats.Item1;
            PixyzUtils.PrintStats(fileName, t1 - t0, n_triangles, newStats.Item2, n_vertices, newStats.Item3, n_parts, newStats.Item4);
        }

        static void ConvertFile(string inputFile, string outputFolder, List<string> extensions, bool optimization, string orgId, string projId, string collectionPath, List<string> tags)
        {
            var modelFiles = new List<string>();
            var fileName = Path.GetFileNameWithoutExtension(inputFile);

            api.Core.SetLogFile(Path.Combine(outputFolder, fileName + ".log"));

            var root = ImportModel(inputFile);

            PrepareModel(root);

            if (optimization)
            {
                OptimiseModel(root, fileName);
            }

            foreach (var extension in extensions)
            {
                Console.WriteLine($"Exporting {extension}...");
                api.IO.ExportScene(Path.Combine(outputFolder, fileName + extension));
                modelFiles.Add(Path.Combine(outputFolder, fileName + extension));
            }
        }

        static uint ImportModel(string filepath)
        {
            Console.WriteLine($"Importing {filepath}...");
            return api.IO.ImportScene(filepath);
        }

        static void PrepareModel(uint root)
        {
            var occurrences = new OccurrenceList((int)root);

            Console.WriteLine("Calculating Tolerances... ");
            double tolerance = Math.Min(MathUtils.AabbDiagLength(api.Scene.GetAABB(occurrences)) / 1000, 0.1);

            Console.WriteLine("Repairing CAD... ");
            api.Algo.RepairCAD(occurrences, tolerance, false);

            Console.WriteLine("Repairing Meshes... ");
            api.Algo.RepairMesh(occurrences, tolerance, true, false);

            Console.WriteLine("Tessellating Meshes... ");
            api.Algo.Tessellate(occurrences, tolerance, -1, -1);
        }

        static void ExportModel(string filepath, string extension, uint root)
        {
            var finalPath = Path.Combine(Path.GetDirectoryName(filepath), Path.GetFileNameWithoutExtension(filepath) + extension);
            Console.WriteLine($"Exporting {finalPath}...");
            api.IO.ExportScene(finalPath, root);
        }

        static void ConfigureLicenseAndTokens()
        {
            if (!api.Core.CheckLicense())
            {
                api.Core.ConfigureLicenseServer("lics-it-gcp-p01", 27005, true);
                Console.WriteLine("Configured license server.");
            }

            Console.WriteLine("Adding available tokens.");
            foreach (var token in api.Core.ListTokens().list)
            {
                try
                {
                    api.Core.NeedToken(token);
                    Console.WriteLine($"Token {token} added successfully.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Failed to add token {token}: {e.Message}");
                }
            }
        }

        static void Main(string[] args)
        {

            string modelFilePath = "../../../../../../../python/Windows/shared/shared_models/SkidLoaderSolidworks/Skid Loader ASSM 11-4-21.SLDASM";

            ConfigureLicenseAndTokens();

            if (api.Core.CheckLicense())
            {
                var root = ImportModel(modelFilePath);
                PixyzUtils.SaveScreenshot(api, (int)root, Path.Combine(Path.GetDirectoryName(modelFilePath), "before.png"), Orientation.LEFT);
                PrepareModel(root);
                PixyzUtils.SaveScreenshot(api, (int)root, Path.Combine(Path.GetDirectoryName(modelFilePath), "after.png"), Orientation.FRONT);
                PixyzUtils.ExtractHierarchyToJson(api, root, Path.Combine(Path.GetDirectoryName(modelFilePath), $"{Path.GetFileNameWithoutExtension(modelFilePath)}.json"));
                ExportModel(modelFilePath, "_new.glb", root);
            }
            else
            {
                Console.WriteLine("No License Available");
            }
        }
    }
}