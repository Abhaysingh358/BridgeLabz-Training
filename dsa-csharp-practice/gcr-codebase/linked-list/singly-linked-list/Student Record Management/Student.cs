using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.SinglyLinkedList.Student_Record_Management
{
    internal class Student
    {
        public int RollNumber;
        public string Name;
        public int Age;
        public char Grade;
        public Student Next;

        public Student(int rollNumber ,string name ,int age , char grade)
        {
            this.RollNumber = rollNumber;
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
            Next = null;
        }
    }
}
