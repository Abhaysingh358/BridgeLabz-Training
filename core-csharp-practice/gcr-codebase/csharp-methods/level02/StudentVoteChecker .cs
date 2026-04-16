using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level02
{
    public class StudentVoteChecker
    {
        // Method to check if a student is eligible to vote based on age
        public bool CanStudentVote(int age)
        {
            if(age <= 0) return false;

            if(age >= 18 && age <= 120)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Main method to test the CanStudentVote method
        static void Main(string[] args)
        {
            int[] age = new int[10];

            // Input ages for 10 students
            for (int i = 0; i < age.Length; i++)
            {
                Console.WriteLine("Enter the age of student " + (i + 1) + " : ");
                age[i] = int.Parse(Console.ReadLine());
            }

            StudentVoteChecker checker = new StudentVoteChecker(); // Creating an instance of StudentVoteChecker

            // Check and display voting eligibility for each student
            for (int i = 0; i < age.Length; i++)
            {
                bool canVote = checker.CanStudentVote(age[i]);
                if(canVote)
                {
                    Console.WriteLine("Student " + (i + 1) + " with age " + age[i] + " is eligible to vote.");
                }
                else
                {
                    Console.WriteLine("Student " + (i + 1) + " with age " + age[i] + " is NOT eligible to vote.");
                }
            }
        }
    }
}
