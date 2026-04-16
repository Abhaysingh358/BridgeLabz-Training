using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.inheritence.hierarchical_inheritence.SchoolSystem
{
    internal class Student : Person
    {
        string Grade;

        public Student(string name, int age, string grade)
            : base(name, age)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return "Student : " + base.ToString() + $" , Grade : {Grade}";

        }
    }
}
