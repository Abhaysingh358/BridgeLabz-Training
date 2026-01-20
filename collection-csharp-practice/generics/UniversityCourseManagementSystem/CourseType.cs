using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.UniversityCourseManagementSystem
{
    // Base abstract class for all course evaluation types
    internal abstract class CourseType
    {
        public string CourseCode { get; private set; }
        public string CourseName { get; private set; }
        public string Department { get; private set; }

        protected CourseType(string courseCode, string courseName, string department)
        {
            CourseCode = courseCode;
            CourseName = courseName;
            Department = department;
        }

        // Each evaluation type must implement its own evaluation details
        public abstract void DisplayEvaluation();
    }
}

