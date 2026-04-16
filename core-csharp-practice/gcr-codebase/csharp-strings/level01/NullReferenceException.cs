using System;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level01
{
    internal class NullReferenceExceptionDemo
    {
        public static void NullReferenceExceptionMethod()
        {
            string s = null; // Intentionally setting string to null

            try
            {
                int len = s.Length; // This will throw NullReferenceException
                Console.WriteLine($"The length of the string is {len}");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("NullReferenceException occurred!");
                Console.WriteLine($"Error message: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Try-catch block has finished executing.");
            }
        }

        static void Main(string[] strings)
        {
            Console.WriteLine("NullReferenceException Demo");
            NullReferenceExceptionMethod();
        }
    }
}
