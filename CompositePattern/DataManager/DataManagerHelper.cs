using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace CompositePattern.DataManager
{
    internal class DataManagerHelper
    {
        public static List<RootObject> ParseJson()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\test.json");
            string text = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<RootObject>>(File.ReadAllText(path));
        }
    }
}
