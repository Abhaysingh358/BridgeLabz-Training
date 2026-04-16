using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.EduResults
{
    internal class EduResultsUtility : IEduResultsOperations
    {
        private District[] districts;
        private int districtCount;

        private RankSheetGenerator rankSheetGenerator;
        private StudentLinkedList stateRankList;

        public EduResultsUtility()
        {
            // Fixed districts (no collections)
            districts = new District[3];
            districts[0] = new District("Pune");
            districts[1] = new District("Mumbai");
            districts[2] = new District("Nagpur");

            districtCount = 3;

            rankSheetGenerator = new RankSheetGenerator();
            stateRankList = null;
        }

        // -------------------- INPUT HELPERS --------------------

        private int SelectDistrict()
        {
            Console.WriteLine("\n--- Select District ---");
            for (int i = 0; i < districtCount; i++)
            {
                Console.WriteLine($"{i + 1}. {districts[i].GetDistrictName()}");
            }

            Console.Write("Enter district number: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice < 1 || choice > districtCount)
            {
                Console.WriteLine("Invalid district choice");
                return -1;
            }

            return choice - 1;
        }

        // -------------------- MENU OPERATIONS --------------------

        // Add Student
        public void AddStudent()
        {
            int index = SelectDistrict();
            if (index == -1) return;

            Student student = new Student();

            Console.Write("Enter Roll Number: ");
            student._rollNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            student._name = Console.ReadLine();

            Console.Write("Enter Marks (double): ");
            double marks = Convert.ToDouble(Console.ReadLine());

            // If you have SetMarks() then use it
            student.SetMarks(marks);

            districts[index].AddStudent(student);

            Console.WriteLine("Student Added Successfully.");
        }

        // Delete Student
        public void DeleteStudent()
        {
            int index = SelectDistrict();
            if (index == -1) return;

            Console.Write("Enter Roll Number to Delete: ");
            int roll = Convert.ToInt32(Console.ReadLine());

            districts[index].RemoveStudent(roll);
        }

        // Show LeaderBoard (State Rank List)
        public void ShowLeaderBoard()
        {
            // Step 1: sort each district list
            for (int i = 0; i < districtCount; i++)
            {
                districts[i].SortDistrictList();
            }

            // Step 2: merge all districts using RankSheetGenerator
            stateRankList = rankSheetGenerator.GenerateStateRankList(districts);

            Console.WriteLine("\nSTATE WISE LEADERBOARD GENERATED SUCCESSFULLY.\n");

            // Step 3: display final leaderboard
            if (stateRankList != null)
            {
                stateRankList.DisplayStudents();
            }
            else
            {
                Console.WriteLine("No students available in any district.");
            }
        }
    }
}

