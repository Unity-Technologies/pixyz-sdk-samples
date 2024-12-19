namespace PiXYZDemo
{
    using Newtonsoft.Json;
    using UnityEngine.Pixyz.API;
    using UnityEngine.Pixyz.Geom;
    using UnityEngine.Pixyz.Scene;
    using UnityEngine.Pixyz.View;


    public enum Orientation
    {
        FRONT = 0,
        BACK = 1,
        TOP = 2,
        BOTTOM = 3,
        LEFT = 4,
        RIGHT = 5
    }

    public static class PixyzUtils
    {
        public static (double, int, int, int) GetStats(uint root)
        {
            PixyzInit.api.Core.ConfigureInterfaceLogger(false, false, false);

            double t = DateTime.Now.TimeOfDay.TotalSeconds;
            var occurrences = new OccurrenceList((int)root);

            int n_triangles = (int)PixyzInit.api.Scene.GetPolygonCount(occurrences, true, false, false);
            int n_vertices = (int)PixyzInit.api.Scene.GetVertexCount(occurrences, false, false, false);
            int n_parts = PixyzInit.api.Scene.GetPartOccurrences((uint)root).length;
            PixyzInit.api.Core.ConfigureInterfaceLogger(true, true, true);

            return (t, n_triangles, n_vertices, n_parts);
        }

        public static void SaveScreenshot(int occurrence, string path, Orientation orientation = Orientation.FRONT,
                                   CameraType type = CameraType.Perspective, int resolution = 1024,
                                   int fov = 60, bool showEdges = false, bool showLines = false)
        {
            Console.WriteLine("Taking Screenshot...");

            Point3 direction = orientation switch
            {
                Orientation.FRONT => new Point3 { x = 0, y = 0, z = -1 },
                Orientation.BACK => new Point3 { x = 0, y = 0, z = 1 },
                Orientation.TOP => new Point3 { x = 0, y = -1, z = 0 },
                Orientation.BOTTOM => new Point3 { x = 0, y = 1, z = 0 },
                Orientation.LEFT => new Point3 { x = 1, y = 0, z = 0 },
                Orientation.RIGHT => new Point3 { x = -1, y = 0, z = 0 },
                _ => new Point3 { x = 0, y = 0, z = 0 }
            };

            var occurrences = new OccurrenceList(occurrence);

            var viewer = PixyzInit.api.View.CreateViewer(resolution, resolution);
            var gpuScene = PixyzInit.api.View.CreateGPUScene(occurrences, showEdges);
            PixyzInit.api.View.AddGPUScene(gpuScene, viewer);
            PixyzInit.api.View.FitCamera(direction, type, fov, viewer, occurrences);

            PixyzInit.api.View.SetViewerProperty("ShowEdges", showEdges ? "True" : "False", viewer);
            PixyzInit.api.View.SetViewerProperty("ShowLines", showLines ? "True" : "False", viewer);

            PixyzInit.api.View.TakeScreenshot(path, viewer);
            Console.WriteLine("Screenshot saved at: " + path);
            PixyzInit.api.View.DestroyViewer(viewer);
            PixyzInit.api.View.DestroyGPUScene(gpuScene);
        }

        public static void PrintStats(string fileName, double t, int n_triangles, int _n_triangles,
                               int n_vertices, int _n_vertices, int n_parts, int _n_parts)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"{"file",-20}{fileName}\n");
            Console.WriteLine($"{"optimization",-20}{t:0.000} s\n");
            Console.WriteLine($"{"triangles",-20}{n_triangles} -> {_n_triangles}\n");
            Console.WriteLine($"{"vertices",-20}{n_vertices} -> {_n_vertices}\n");
            Console.WriteLine($"{"parts",-20}{n_parts} -> {_n_parts}\n");
        }

        static Dictionary<string, string> GetMetadataDict(PropertyValue propertyValue)
        {
            return new Dictionary<string, string>
            {
                { "name", propertyValue.name },
                { "value", propertyValue.value }
            };
        }

        static Dictionary<string, object> GetHierarchyDict(uint occurrence)
        {
            var hierarchyDict = new Dictionary<string, object>
            {
                { "name", PixyzInit.api.Core.GetProperty(occurrence, "Name") }
            };

            var matrix = PixyzInit.api.Scene.GetLocalMatrix(occurrence);
            var vector3lst = PixyzInit.api.Geom.ToTRS(matrix);
            hierarchyDict.Add("translation", new List<double> { vector3lst[0]._base.x, vector3lst[0]._base.y, vector3lst[0]._base.z });
            hierarchyDict.Add("rotation", new List<double> { vector3lst[1]._base.x, vector3lst[1]._base.y, vector3lst[1]._base.z });
            hierarchyDict.Add("scale", new List<double> { vector3lst[2]._base.x, vector3lst[2]._base.y, vector3lst[2]._base.z });

            var children = new List<Dictionary<string, object>>();
            foreach (var child in PixyzInit.api.Scene.GetChildren(occurrence).list)
            {
                children.Add(GetHierarchyDict(child));
            }
            hierarchyDict.Add("children", children);

            if (PixyzInit.api.Scene.HasComponent(occurrence, ComponentType.Metadata))
            {

                var metadataComponent = PixyzInit.api.Scene.GetComponent(occurrence, ComponentType.Metadata);
                var occurrences = new MetadataList(1);
                occurrences[0] = metadataComponent;

                MetadataDefinitionList metadataDefinitions = PixyzInit.api.Scene.GetMetadatasDefinitions(occurrences);


                MetadataDefinition metadataDefinition = metadataDefinitions[0];

                var metadataList = new List<Dictionary<string, string>>();

                foreach (PropertyValue propertyValue in metadataDefinition._base.list)
                {
                    metadataList.Add(GetMetadataDict(propertyValue));
                }

                hierarchyDict.Add("metadata", metadataList);
            }

            return hierarchyDict;
        }

        public static void ExtractHierarchyToJson(uint root, string filePath)
        {
            var hierarchyDict = GetHierarchyDict(root);
            using (var writer = new StreamWriter(filePath))
            {
                var json = JsonConvert.SerializeObject(hierarchyDict, Formatting.Indented);
                writer.Write(json);
            }
            Console.WriteLine("\nDone: structure tree exported at " + filePath);
        }
    }
}

