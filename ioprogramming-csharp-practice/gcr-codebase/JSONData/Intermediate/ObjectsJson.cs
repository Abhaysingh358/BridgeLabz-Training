using JSON.Basic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONData.Intermediate
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class ObjectsJson
    {
        static void Main()
        {
            List<User> users = new List<User>
            {
                new User { Name="Alice", Age=22 },
                new User { Name="Bob", Age=30 }
            };

            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
