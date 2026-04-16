using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.key_word_csharp_level01.UniversityStudentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "Abhay Singh", 'A');
            Student s2 = new Student(2, "Ravi Kumar", 'B');

            // using is operator before display
            if (s1 is Student)
            {
                s1.Display();
            }

            if (s2 is Student)
            {
                s2.Display();
            }

            // update grade after checking type
            if (s1 is Student)
            {
                s1.UpdateGrade('A');
                s1.Display();
            }

           

            Student.DisplayTotalStudents();
        }
    }
}
