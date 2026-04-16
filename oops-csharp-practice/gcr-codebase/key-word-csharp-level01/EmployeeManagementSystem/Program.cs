using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.key_word_csharp_level01.EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "Abhay Singh", "Software Engineer");
            Employee e2 = new Employee(2, "Ravi Kumar", "Senior Developer");
            if (e1 is Employee)
            {
                e1.Display();
            }
            else
            {
                Console.WriteLine("Is a non object");
            }
            // using is operator before displaying details

            if (e2 is Employee)
            {
                e2.Display();
            }
            else
            {
                Console.WriteLine("Is a non object");
            }


            // static method call
            Employee.DisplayTotalEmployees();
        }
    }
}
