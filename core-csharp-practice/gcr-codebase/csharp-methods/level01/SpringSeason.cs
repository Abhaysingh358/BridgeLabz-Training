using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level01
{
    internal class SpringSeason
    {
        public bool IsSpring(int month, int day)
        {
            // Spring starts on March 20
            if (month == 3 && day >= 20)
                return true;

            // Full months April  and May 
            if (month == 4 || month == 5)
                return true;

            // Until June 20
            if (month == 6 && day <= 20)
                return true;

            return false;
        }

        static void Main(string[] args)
        {
            //input of month and date
            Console.WriteLine("Enter month (1-12): ");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter day (1-31): ");
            int day = int.Parse(Console.ReadLine());

            // Create an instance of SpringSeason
            SpringSeason springSeason = new SpringSeason();

            
            bool isSpring = springSeason.IsSpring(month, day);

            // Check if the given date is in spring season

            if (isSpring)
            {
                Console.WriteLine("spring season.");
            }
            else
            {
                Console.WriteLine("not a spring season.");
            }
        }
    }
}
