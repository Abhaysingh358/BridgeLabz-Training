using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace JSONData.Basic
{
    internal class ExtractFields
    {
        static void Main()
        {
            string json = File.ReadAllText("user.json");
            JObject obj = JObject.Parse(json);

            Console.WriteLine("Name: " + obj["name"]);
            Console.WriteLine("Email: " + obj["email"]);
        }
    }
}
