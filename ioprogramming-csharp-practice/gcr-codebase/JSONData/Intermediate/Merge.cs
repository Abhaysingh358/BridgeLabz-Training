using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONData.Intermediate
{
    internal class Merge
    {
        static void Main()
        {
            JObject json1 = JObject.Parse(File.ReadAllText("file1.json"));
            JObject json2 = JObject.Parse(File.ReadAllText("file2.json"));

            json1.Merge(json2);
            Console.WriteLine(json1.ToString());
        }
    }
}
