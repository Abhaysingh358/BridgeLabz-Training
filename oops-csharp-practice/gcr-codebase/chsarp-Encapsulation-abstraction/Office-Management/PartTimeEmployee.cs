using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Office_Management
{
    internal class PartTimeEmployee:Employee , IDepartment
    {
        private int workHours;
        private string department;

        public PartTimeEmployee(int employeeId, string name, double hourlyRate, int workHours)
            : base(employeeId, name, hourlyRate)
        {
            this.workHours = workHours;
        }

        // Salary based on hours
        public override double CalculateSalary()
        {
            return baseSalary * workHours;
        }

        // Interface implementation
        public void AssignDepartment(string departmentName)
        {
            department = departmentName;
        }

        public string GetDepartmentDetails()
        {
            return department;
        }
    }
}
