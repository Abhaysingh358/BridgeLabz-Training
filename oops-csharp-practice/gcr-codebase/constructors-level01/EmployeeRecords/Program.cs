using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.constructors_level01.EmployeeRecords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager(501, "IT", 75000, "Senior Manager");


            m.DisplayManagerDetails();

            Console.WriteLine("Updating Salary");
            m.UpdateSalary(85000);

            m.DisplayManagerDetails();
        }
    }
}
