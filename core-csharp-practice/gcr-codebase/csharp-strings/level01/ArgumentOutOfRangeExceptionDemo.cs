using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level01
{
    internal class ArgumentOutOfRangeExceptionDemo
    {
        public static void ArgumentOutOfRangeExceptionMethod()
        {
            string str = "BridgeLabz";
            try
            {
                // this block of code is Intentionally using an invalid range for substring
                string substr = str.Substring(5, 20);
                Console.WriteLine($"Substring: {substr}");
            }
            // catch block to handle ArgumentOutOfRangeException
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("ArgumentOutOfRangeException occurred!");
                Console.WriteLine($"Error message: {e.Message}");
            }
            // it is optional to use finally block
            finally
            {
                Console.WriteLine("Try-catch block has finished executing.");
            }
        }

        static void Main(string[] args)
        {
            // displaying demo title
            Console.WriteLine("ArgumentOutOfRangeException Demo");
            ArgumentOutOfRangeExceptionMethod();
        }
    }
}
