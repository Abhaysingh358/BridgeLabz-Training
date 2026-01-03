using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.key_word_csharp_level01.EmployeeManagementSystem
{
    internal class Employee
    {
        static string CompanyName = "BridgeLabz";
        static int TotalEmployees = 0;
        readonly int Id;

        string Name;
        string Designation;

        public Employee(int employeeId, string employeeName, string designation)
        {
            this.Id = employeeId;
            this.Name = employeeName;
            this.Designation = designation;
            TotalEmployees++;
        }

        public static void DisplayTotalEmployees()
        {
            Console.WriteLine($"Total Employees : {TotalEmployees}");
        }

        public void Display()
        {
         
                Console.WriteLine("Employee Details");
                Console.WriteLine($"Company Name : {CompanyName}");
                Console.WriteLine($"Employee ID  : {Id}");
                Console.WriteLine($"Name         : {Name}");
                Console.WriteLine($"Designation  : {Designation}");
                Console.WriteLine();
           
        }
    }
}
