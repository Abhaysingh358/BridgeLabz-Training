using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.EmployeeWageComputation
{
    internal class Employee
    {
        private int EmployeeID { get; set; }
        private string EmployeeName { get; set; }

        private int EmployeeSalary { get; set; }

        private long EmployeePhone {  get; set; }
        private string EmailId { get; set; }


        public override string ToString()
        {
            return $"EmployeeId : {EmployeeID} , Employee Name : {EmployeeName} ," +
                $"\nEmployee Salary : {EmployeeSalary}  , Phone No. : {EmployeePhone}" +
                $"\nEmployee EmailId : {EmailId}";
        }


    }
}
