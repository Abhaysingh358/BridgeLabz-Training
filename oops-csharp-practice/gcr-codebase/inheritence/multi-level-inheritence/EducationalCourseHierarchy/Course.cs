using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.inheritence.Multilevel_Inheritance.EducationalCourseHierarchy
{
    internal class Course
    {
        // attributes
        protected string CourseName;
        protected int Duration;

        // parametrized
        public Course(string courseName, int duration)
        {
            this.CourseName = courseName;
            this.Duration = duration;
        }

        // string override
        public override string ToString()
        {
            return $"Course Name : {CourseName} , Duration : {Duration} weeks";
        }
    }
}
