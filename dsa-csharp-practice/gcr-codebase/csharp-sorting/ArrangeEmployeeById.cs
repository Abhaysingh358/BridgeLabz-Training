using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_sorting
{
    // Employeeclass
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return "Employee Id: " + Id + "\nName: " + Name;
        }
    }
    internal class ArrangeEmployeeById
    {
        // insartion Srot method to  sort employees by Id (ascending)
        static void InsertionSortById(Employee[] employees)
        {
            for (int i = 1; i < employees.Length; i++)
            {
                Employee key = employees[i];
                int j = i - 1;

                while (j >= 0 && employees[j].Id > key.Id)
                {
                    employees[j + 1] = employees[j];
                    j--;
                }
                employees[j + 1] = key;
            }
        }
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[5];
            for (int i = 0; i < employees.Length; i++)
            {
                int id = Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                employees[i] = new Employee(id, name);
            }
            Console.WriteLine("\nBefore Sorting");
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i]);
            }
            // sort employees by Id
            InsertionSortById(employees);
            Console.WriteLine("\nAfter Sorting");
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}

