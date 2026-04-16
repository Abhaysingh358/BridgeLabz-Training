using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONData.Intermediate
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
    internal class JsonReport
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{ Id=1, Name="John", Department="IT" },
                new Employee{ Id=2, Name="Sara", Department="HR" }
            };

            string report = JsonConvert.SerializeObject(employees, Formatting.Indented);
            Console.WriteLine(report);
        }
    }
}
