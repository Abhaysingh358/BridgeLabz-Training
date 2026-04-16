using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.Exceptions
{

    class ArrayIndexFetcherApp
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

                Console.Write("\nEnter index to retrieve value: ");
                int targetIndex = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Value at index {targetIndex}: {numbersArray[targetIndex]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index!");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Array is not initialized!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter valid numeric values.");
            }
        }
    }

}
