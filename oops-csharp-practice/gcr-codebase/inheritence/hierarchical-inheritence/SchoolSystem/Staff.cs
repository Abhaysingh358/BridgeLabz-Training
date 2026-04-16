using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.inheritence.hierarchical_inheritence.SchoolSystem
{
    internal class Staff : Person
    {
        string Department;

        public Staff(string name, int age, string department)
            : base(name, age)
        {
            this.Department = department;
        }

        public override string ToString()
        {
            return "Staff : " + base.ToString() + $" , Department : {Department}";


        }
    }
}
