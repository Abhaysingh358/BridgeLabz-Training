using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level02
{
    internal class LeapYear
    {
        // Method to check if a year is a Leap Year
        public static bool IsLeapYear(int year)
        {
            //  Gregorian calendar starts from 1582
            if (year < 1582)
                return false;

            // Leap year rules
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                return true;

            return false;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            bool leap = IsLeapYear(year);

            if (year < 1582)
            {
                Console.WriteLine("Year must be 1582 or later. Not a valid Gregorian calendar year.");
            }
            else if (leap)
            {
                Console.WriteLine(year + " is a Leap Year.");
            }
            else
            {
                Console.WriteLine(year + " is NOT a Leap Year.");
            }
        }
    }
}

