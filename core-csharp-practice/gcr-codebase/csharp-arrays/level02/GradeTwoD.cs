using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BridgeLabz.arrays.level02
{
    internal class GradeTwoD
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of students: ");
            int num = int.Parse(Console.ReadLine());

            // Arrays to store data of all students
            int[,] marks = new int[num ,3]; // it wi
          
            double[] percentage = new double[num];
            char[] grade = new char[num];

            // INPUT LOOP
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"\nStudent {i + 1} Marks:");

                // Physics
                Console.Write("Enter Physics Marks: ");
                int phy = int.Parse(Console.ReadLine());

                // Chemistry
                Console.Write("Enter Chemistry Marks: ");
                int chm = int.Parse(Console.ReadLine());

                // Maths
                Console.Write("Enter Maths Marks: ");
                int mts = int.Parse(Console.ReadLine());

                // Input Validation
                if (phy < 0 || chm < 0 || mts < 0)
                {
                    Console.WriteLine("Marks cannot be negative! Please enter again.");
                    i--;     // Repeat same student
                    continue;
                }

                marks[i,0] = phy;
                marks[i, 1] = chm;
                marks[i, 2] = mts;
            }

            // PROCESSING LOOP
            for (int i = 0; i < num; i++)
            {
                // Calculate percentage
                percentage[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;

                // Assign grade based on percentage
                double pct = percentage[i];

                if (pct >= 80)
                    grade[i] = 'A';
                    
                else if (pct >= 70)

                    grade[i] = 'B';

                else if (pct >= 60)

                    grade[i] = 'C';

                else if (pct >= 50)

                    grade[i] = 'D';

                else if (pct >= 40)

                    grade[i] = 'E';

                else

                    grade[i] = 'R';
            }

            // OUTPUT
            Console.WriteLine("\nSTUDENT RESULTS");

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"\nStudent {i + 1}:");
                Console.WriteLine($"Physics   : {marks[i, 0]}");
                Console.WriteLine($"Chemistry : {marks[i, 1]}");
                Console.WriteLine($"Maths     : {marks[i, 2]}");
                Console.WriteLine($"Percentage: {percentage[i]:0.00}%");
                Console.WriteLine($"Grade     : {grade[i]}");
            }
        }
    }
}

