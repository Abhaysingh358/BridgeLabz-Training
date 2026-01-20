using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.UniversityCourseManagementSystem
{
    // Course evaluated through Assignments
    internal class AssignmentCourse : CourseType
    {
        public int NumberOfAssignments { get; private set; }
        public int MaxMarksPerAssignment { get; private set; }

        public AssignmentCourse(string courseCode, string courseName, string department, int numberOfAssignments, int maxMarksPerAssignment)
            : base(courseCode, courseName, department)
        {
            NumberOfAssignments = numberOfAssignments;
            MaxMarksPerAssignment = maxMarksPerAssignment;
        }

        public override void DisplayEvaluation()
        {
            Console.WriteLine("----- Assignment Course Evaluation -----");
            Console.WriteLine("Course Code            : " + CourseCode);
            Console.WriteLine("Course Name            : " + CourseName);
            Console.WriteLine("Department             : " + Department);
            Console.WriteLine("Assignments Count      : " + NumberOfAssignments);
            Console.WriteLine("Max Marks/Assignment   : " + MaxMarksPerAssignment);
        }
    }
}

