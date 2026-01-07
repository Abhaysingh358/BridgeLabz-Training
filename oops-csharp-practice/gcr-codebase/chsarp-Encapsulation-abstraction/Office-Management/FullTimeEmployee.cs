using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Office_Management
{
    internal class FullTimeEmployee:Employee,IDepartment
    {
        private string department;

        public FullTimeEmployee(int employeeId, string name, double baseSalary)
            : base(employeeId, name, baseSalary)
        {
        }

        // Fixed salary calculation
        public override double CalculateSalary()
        {
            return baseSalary;
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
