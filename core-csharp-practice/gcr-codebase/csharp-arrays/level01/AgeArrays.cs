using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.arrays.level01
{
    internal class AgeArrays
    {
        static void Main(string[] args)
        {
            int[] age = new int[10];
            for (int i = 0; i < age.Length; i++)
            {
                age[i] = int.Parse(Console.ReadLine());
            }

// check condtion and iterate
            for (int i = 0; i < age.Length; ++i)
            {
                if (age[i] < 18 && age[i] > 0) // age should be greater than 0
                {
                    Console.WriteLine("Student with " + age[i] + " can not  vote ");
                }
                else if (age[i] < 120 && age[i] > 17)
                {
                    Console.WriteLine("Student with " + age[i] + " can vote ");
                }

                else
                {
                    Console.WriteLine("enetr the valid age between 1 to 120");

                }
            }

        }
    }
}

