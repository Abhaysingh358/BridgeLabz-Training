using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.UniversityCourseManagementSystem
{
    // Course evaluated through Exams
    internal class ExamCourse : CourseType
    {
        public int TotalMarks { get; private set; }
        public int PassingMarks { get; private set; }

        public ExamCourse(string courseCode, string courseName, string department, int totalMarks, int passingMarks)
            : base(courseCode, courseName, department)
        {
            TotalMarks = totalMarks;
            PassingMarks = passingMarks;
        }

        public override void DisplayEvaluation()
        {
            Console.WriteLine("----- Exam Course Evaluation -----");
            Console.WriteLine("Course Code   : " + CourseCode);
            Console.WriteLine("Course Name   : " + CourseName);
            Console.WriteLine("Department    : " + Department);
            Console.WriteLine("Total Marks   : " + TotalMarks);
            Console.WriteLine("Passing Marks : " + PassingMarks);
        }
    }
}

