using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.ResumeScreening
{
    internal class ResumeMenu
    {
        public void start()
        {
            Resume<JobRole> resumeSystem = new Resume<JobRole>();

            Console.Write("Enter number of candidates: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\nSelect Job Role:");
                Console.WriteLine("1. Software Engineer");
                Console.WriteLine("2. Data Scientist");
                Console.Write("Choice: ");
                int choice = int.Parse(Console.ReadLine());

                Console.Write("Candidate Name: ");
                string name = Console.ReadLine();

                Console.Write("Years of Experience: ");
                int exp = int.Parse(Console.ReadLine());

                if (choice == 1)
                    resumeSystem.AddCandidate(new SoftwareEngineer(name, exp));
                else if (choice == 2)
                    resumeSystem.AddCandidate(new DataScientist(name, exp));
                else
                    Console.WriteLine("Invalid role. Skipped.");
            }

            resumeSystem.ScreenCandidates();
        }
    }
}
