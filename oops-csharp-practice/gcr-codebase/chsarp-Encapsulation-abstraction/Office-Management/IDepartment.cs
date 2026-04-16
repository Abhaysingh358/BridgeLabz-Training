using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Office_Management
{
    internal interface IDepartment
    {
        void AssignDepartment(string departmentName);
        string GetDepartmentDetails();
    }
}
