using System;

namespace CalendarProgram
{
    internal class Calendar
    {
        // Method to get month name
        public static string GetMonthName(int month)
        {
            string[] monthNames = {
                "January","February","March","April","May","June",
                "July","August","September","October","November","December"
            };

            return monthNames[month - 1];
        }

        // Method to check leap year
        public static bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        // Method to get number of days in month
        public static int GetDaysInMonth(int month, int year)
        {
            int[] days = { 31, 28, 31, 30, 31, 30,
                           31, 31, 30, 31, 30, 31 };

            if (month == 2 && IsLeapYear(year))
                return 29;

            return days[month - 1];
        }

        // Method to get first day of the month using Gregorian calendar algorithm
        public static int GetFirstDay(int day, int month, int year)
        {
            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (day + x + (31 * m0) / 12) % 7;

            return d0;   // 0 = Sunday, 1 = Monday, ... 6 = Saturday
        }

        static void Main(string[] args)
        {
            Console.Write("Enter month (1-12): ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            string monthName = GetMonthName(month);
            int days = GetDaysInMonth(month, year);

            // First weekday of the given month
            int firstDay = GetFirstDay(1, month, year);

            // Print month & header
            Console.WriteLine("\n" + monthName + " " + year);
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            // First loop → indentation before day 1
            for (int i = 0; i < firstDay; i++)
            {
                Console.Write("    ");
            }

            // Second loop → print all days of the month
            for (int day = 1; day <= days; day++)
            {
                Console.Write($"{day,3} ");

                // Move to next line after Saturday
                if ((firstDay + day) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }
    }
}
