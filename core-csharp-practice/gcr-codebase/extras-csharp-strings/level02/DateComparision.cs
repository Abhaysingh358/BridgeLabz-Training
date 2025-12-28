using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace DateComparisonDemo
{
    internal class DateComparison
    {
        public static string CompareDates(DateTime date1, DateTime date2)
        {
            int comparedDates = date1.CompareTo(date2);

            // comparison of dates to find out which comes before whom
            if (comparedDates < 0)
            {
                return $"{date1:yyyy-MM-dd} is BEFORE {date2:yyyy-MM-dd}";
            }

            else if (comparedDates > 0)
            {
                return $"{date1:yyyy-MM-dd} is AFTER {date2:yyyy-MM-dd}";
            }

            else
            {
                return $"{date1:yyyy-MM-dd} is the SAME as {date2:yyyy-MM-dd}";
            }
        }

        static void Main(string[] args)
        {
            //input of dates

            Console.WriteLine("Enter first date (yyyy-mm-dd):");
            DateTime date1 = DateTime.Parse(Console.ReadLine()); 

            Console.WriteLine("Enter second date (yyyy-mm-dd):");
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            // string results of methods
            string result = CompareDates(date1, date2);

            //displaying the results
            Console.WriteLine("\n" + result);
        }
    }
}

