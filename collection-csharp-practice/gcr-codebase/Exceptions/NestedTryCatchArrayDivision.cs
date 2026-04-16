using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.Exceptions
{
    class NestedTryCatchArrayDivision
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter size of array: ");
                int arraySize = Convert.ToInt32(Console.ReadLine());

                int[] numbersArray = new int[arraySize];

                Console.WriteLine("Enter array elements:");
                for (int i = 0; i < arraySize; i++)
                {
                    Console.Write($"Element [{i}]: ");
                    numbersArray[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("\nEnter index to access: ");
                int indexToAccess = Convert.ToInt32(Console.ReadLine());

                // Outer try for index access
                try
                {
                    int selectedValue = numbersArray[indexToAccess];

                    Console.Write("Enter divisor: ");
                    int divisor = Convert.ToInt32(Console.ReadLine());

                    // Inner try for division
                    try
                    {
                        int result = selectedValue / divisor;
                        Console.WriteLine($"\nDivision Result: {selectedValue} / {divisor} = {result}");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("\nCannot divide by zero!");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("\nInvalid array index!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid input! Please enter numeric values only.");
            }
        }
    }

}
