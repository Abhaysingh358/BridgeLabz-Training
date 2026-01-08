using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.SinglyLinkedList.Student_Record_Management
{
    internal class StudentLinkedList
    {
        private Student Head;

        // Add at Beginning 
        public void AddAtBeginning(Student student)
        {
            student.Next = Head;
            Head = student;
        }

        // Add at the end
        public void AddAtEnd(Student student)
        {
            if (Head == null)
            {
                Head = student;
                return;
            }

            Student temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = student;
        }

        // adding student at a position
        public void AddAtPosition(Student student, int position)
        {
            if (position <= 1)
            {
                AddAtBeginning(student);
                return;
            }

            Student temp = Head;
            for (int i = 0; i < position - 1; i++)
            {
                if (temp != null)
                {
                    temp = temp.Next;
                }
                else
                {
                    Console.WriteLine("Invalid Position");
                    return;
                }
            }
        }

        // deleting by roll number
        public void DeleteByRollNumber(int rollNum)
        {
            if (Head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            if(Head.RollNumber == rollNum)
            {
                Head = Head.Next;
                Console.WriteLine("Student deleted.");
                return;

            }

            Student temp = Head;
            while (temp.Next != null && temp.Next.RollNumber != rollNum)
            {
                temp = temp.Next;
            }

            if (temp.Next == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            temp.Next = temp.Next.Next;
            Console.WriteLine("Student deleted.");
        }


        // search by roll number
        public Student SearchByRollNumber(int rollNum)
        {
            Student temp = Head;

            while (temp != null)
            {
                if (temp.RollNumber == rollNum)
                {
                    return temp;
                }
                temp = temp.Next;
            }
            return null;
        }

        // update grade
        public void UpdateGrade(int roll, char grade)
        {
            Student temp = Head;
            while (temp != null)
            {
                if (temp.RollNumber == roll)
                {
                    temp.Grade = grade;
                    Console.WriteLine("Grade updated.");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Student not found.");
        }


        // Displaying All
        public void DisplayAll()
        {
            if (Head == null)
            {
                Console.WriteLine("No records available.");
                return;
            }

            Student temp = Head;
            while (temp != null)
            {
                DisplayStudent(temp);
                temp = temp.Next;
            }
        }

        private void DisplayStudent(Student s)
        {
            Console.WriteLine($"Roll: {s.RollNumber}, Name: {s.Name}, Age: {s.Age}, Grade: {s.Grade}");
        }
    }
}
