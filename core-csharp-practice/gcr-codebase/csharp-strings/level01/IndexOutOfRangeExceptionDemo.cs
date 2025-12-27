using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level01
{
    internal class IndexOutOfRangeExceptionDemo
    {
        public static void IndexOutOfRangeExceptionMethod()
        {
            string str = "BridgeLabz";
            try
            {
                // this block of code Intentionally accessing an out-of-bounds index
                char ch = str[20];
                Console.WriteLine($"Character at index 20 is {ch}");
            }

            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException occurred!");
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
            Console.WriteLine("IndexOutOfRangeException Demo");
            IndexOutOfRangeExceptionMethod();
        }
    }
}
