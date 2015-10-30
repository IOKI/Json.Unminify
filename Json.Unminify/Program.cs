using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Json.Unminify
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var fileStream = File.OpenRead(args[0]))
            using (var stremReader = new StreamReader(fileStream))
            using (var jsonReader = new JsonTextReader(stremReader))
            {
                var json = JObject.Load(jsonReader);
                File.WriteAllText(args[1], json.ToString(Formatting.Indented));
            }
        }
    }
}
