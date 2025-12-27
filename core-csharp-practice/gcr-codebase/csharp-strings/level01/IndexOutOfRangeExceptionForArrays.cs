using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level01
{
    internal class IndexOutOfRangeExceptionForArrays
    {
        public static void IndexOutOfRangeExceptionMethod()
        {
            int[] num = { 1, 2, 3, 4, 5 };
            try
            {
                // Attempting to access an invalid index
                Console.WriteLine(num[7]);
            }
            // Catch block to handle IndexOutOfRangeException
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException occurred!");
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
            Console.WriteLine("IndexOutOfRangeException Demo");
            IndexOutOfRangeExceptionMethod();
        }
    }
}
