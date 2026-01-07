using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Office_Management
{
    internal class Menu
    {
        Employee[] employees;
        int count;

        public Menu()
        {
            employees = new Employee[5];
            count = 0;
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\nEmployee Management System");
                Console.WriteLine("1. Add Full Time Employee");
                Console.WriteLine("2. Add Part Time Employee");
                Console.WriteLine("3. Display All Employees");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddFullTimeEmployee();
                        break;

                    case 2:
                        AddPartTimeEmployee();
                        break;

                    case 3:
                        DisplayEmployees();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
        private void AddFullTimeEmployee()
        {
            if (count >= employees.Length)
            {
                Console.WriteLine("Employee storage full");
                return;
            }
            Console.Write("Enter ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Department: ");
            string dept = Console.ReadLine();
            FullTimeEmployee emp = new FullTimeEmployee(id, name, salary);
            emp.AssignDepartment(dept);

            employees[count++] = emp;
            Console.WriteLine("Full Time Employee Added");
        }

        private void AddPartTimeEmployee()
        {
            if (count >= employees.Length)
            {
                Console.WriteLine("Employee storage full");
                return;
            }
            Console.Write("Enter ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Hourly Rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Work Hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Department: ");
            string dept = Console.ReadLine();
            PartTimeEmployee emp = new PartTimeEmployee(id, name, rate, hours);
            emp.AssignDepartment(dept);
            employees[count++] = emp;
            Console.WriteLine("Part Time Employee Added");
        }

        private void DisplayEmployees()
        {
            if (count == 0)
            {
                Console.WriteLine("No employees available");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                employees[i].Display();

                if (employees[i] is IDepartment dept)
                {
                    Console.WriteLine("Department  : " + dept.GetDepartmentDetails());
                }
            }
        }
    }
}
