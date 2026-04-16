using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.constructors_level01.UniversityManagementSystem
{
    internal class program
    {
        static void Main(string[] args)
        {
            PostgraduateStudent p = new PostgraduateStudent();
            p.InputPostgraduate(); // taking input

            Console.WriteLine("Do you want to update the CGPA? (yes/no)");
            string ans = Console.ReadLine();

            if (ans.ToLower() == "yes")
            {
                Console.WriteLine("Enter new CGPA:");
                double newCgpa = double.Parse(Console.ReadLine());
                p.SetCGPA(newCgpa);
            }

            p.DisplayPostgraduate();
        }
    }
    
}
