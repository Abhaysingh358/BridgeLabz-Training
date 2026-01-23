using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.Exceptions
{

    class DivisionCalculator
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter numerator: ");
                int numerator = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter denominator: ");
                int denominator = Convert.ToInt32(Console.ReadLine());

                int divisionResult = numerator / denominator;

                Console.WriteLine($"\nResult: {numerator} / {denominator} = {divisionResult}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\nError: Division by zero is not allowed.");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: Please enter only numeric values.");
            }
        }
    }

}
