using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONData.Basic
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class ObjectJson
    {
        static void Main()
        {
            List<User> users = new List<User>
            {
                new User { Name = "Tom", Age = 22 },
                new User { Name = "Jerry", Age = 28 }
            };

            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
