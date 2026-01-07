using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Office_Management
{
    internal abstract class Employee
    {
        private long employeeId;
        private string name;
        protected double baseSalary;

        public Employee(long employeeId, string name, double baseSalary)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.baseSalary = baseSalary;
        }

        public long EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract double CalculateSalary();

        public void Display()
        {
            Console.WriteLine("employee id " + EmployeeId);
            Console.WriteLine("name :" + Name);
            Console.WriteLine("baseSalary : " + baseSalary);

        }
    }
}
