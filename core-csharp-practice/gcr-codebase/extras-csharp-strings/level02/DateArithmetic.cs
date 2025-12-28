using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.extras_csharp_strings.level02
{
    internal class DateArithmetic
    {
        public static void Operations(DateTime date)
        {
            // add 7 days by using  AddDays()
            DateTime day = date.AddDays(7);

            // add 1 month by using built-in function AddMonths()
            DateTime mon = date.AddMonths(1);

            // adding 2 years by using built-in function AddYears()
            DateTime yrs = date.AddYears(2);

            // subtracting 3 weeks which means 21 days beacuse c sharp does not have AddWeeks()
            DateTime week = date.AddDays(-21);

            Console.WriteLine($"Original Date : {date:yyyy - MM - dd}");
            Console.WriteLine($"Added 7 days : {day:yyyy - MM - dd}");
            Console.WriteLine($"Added 1 month : {mon:yyyy - MM - dd}");
            Console.WriteLine($"Added 2 years : {yrs:yyyy - MM - dd}");
            Console.WriteLine($"Subtracted 3 weeks : {yrs:yyyy - MM - dd}");


        }

        static void Main(string[] args) 
        {
            // taking input of date 
            Console.WriteLine("Enter a date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            // calling method
            Operations(date);

        }
    }
}
