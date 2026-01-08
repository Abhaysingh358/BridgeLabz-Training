using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgeLabz.gcr_codebase.DSA.LinkedList.SinglyLinkedList.Student_Record_Management
{
    internal class StudentUtility
    {
        public Student CreateStudent()
        {
            Console.Write("Roll: ");
            int roll = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Grade: ");
            char grade = char.Parse(Console.ReadLine());

            return new Student(roll, name, age, grade);
        }

        public void Print(Student s)
        {
            Console.WriteLine($"Roll: {s.RollNumber}, Name: {s.Name}, Age: {s.Age}, Grade: {s.Grade}");
        }
    }
}
