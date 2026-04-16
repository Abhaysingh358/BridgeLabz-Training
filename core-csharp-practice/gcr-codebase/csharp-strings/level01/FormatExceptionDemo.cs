using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level01
{
    internal class FormatExceptionDemo
    {
        public static void FormatExceptionMethod()
        {
            string asANumber = "351653gvhg"; // Intentionally invalid number format
            try
            {
                // This block of code attempts to parse an invalid number format
                int number = int.Parse(asANumber);
                Console.WriteLine($"Parsed number: {number}");
            }
            // Catch block to handle FormatException
            catch (FormatException e)
            {
                Console.WriteLine("FormatException occurred!");
                Console.WriteLine($"Error message: {e.Message}");
            }
            // It is optional to use finally block
            finally
            {
                Console.WriteLine("Try-catch block has finished executing.");
            }
        }

        static void Main(string[] args)
        {
            // Displaying demo title
            Console.WriteLine("FormatException Demo");
            FormatExceptionMethod();
        }
    }
}
