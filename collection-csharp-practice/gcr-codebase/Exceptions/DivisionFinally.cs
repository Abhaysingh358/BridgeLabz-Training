using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.Exceptions
{
    class DivisionFinally
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter numerator: ");
                int numerator = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter denominator: ");
                int denominator = Convert.ToInt32(Console.ReadLine());

                int result = numerator / denominator;

                Console.WriteLine($"\nResult: {numerator} / {denominator} = {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\nError: Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: Please enter only integer numbers.");
            }
            finally
            {
                Console.WriteLine("\nOperation completed");
            }
        }
    }

}
