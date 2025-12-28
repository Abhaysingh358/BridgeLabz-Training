using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace DateFormattingDemo
{
    internal class DateFormatting
    {
        
        // method to get date in different formats
        public static string GetFormattedDates()
        {
            DateTime date = DateTime.Now;

            string format1 = date.ToString("dd/MM/yyyy"); 
            string format2 = date.ToString("yyyy-MM-dd");
            string format3 = date.ToString("ddd, MMM dd, yyyy"); 

            return $"Format 1 (dd/MM/yyyy): {format1}\n" +
                   $"Format 2 (yyyy-MM-dd): {format2}\n" +
                   $"Format 3 (EEE, MMM dd, yyyy): {format3}";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Current Date in Multiple Formats:\n");

            // calling method and displaying result
            string result = GetFormattedDates();
            Console.WriteLine(result);
        }
    }
}
