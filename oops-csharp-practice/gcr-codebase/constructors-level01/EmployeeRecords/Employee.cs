using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.constructors_level01.EmployeeRecords
{
    public class Employee
    {
        public int employeeID;          
        protected string department;    
        private double salary;           


        // parameterized constructor
        public Employee(int id, string dept, double initialSalary)
        {
            employeeID = id;
            department = dept;
            salary = initialSalary;
        }


        // public method to modify private salary
        public void UpdateSalary(double newSalary)
        {
            if (newSalary > 0)
            {
                salary = newSalary;
            }
            else
            {
                Console.WriteLine("Invalid salary amount.");
            }
        }

        // public method to access private salary
        public double GetSalary()
        {
            return salary;
        }

        public void Display()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine($"Employee ID : {employeeID}");
            Console.WriteLine($"Department  : {department}");
            Console.WriteLine($"Salary      : {salary}");
        }
    }

    public class Manager : Employee
    {
        string level;

        // parameterized constructor calling base constructor
        public Manager(int id, string dept, double salary, string level) : base(id, dept, salary)

        {
            this.level = level;
        }

        public void DisplayManagerDetails()
        {
            Console.WriteLine("Manager Details");
            Console.WriteLine($"Employee ID : {employeeID}");    // public to allowed
            Console.WriteLine($"Department  : {department}");    // protected to allowed
            Console.WriteLine($"Salary  : {GetSalary()}");   // private to via method
            Console.WriteLine($"Level  : {level}");
        }
    }
}
