using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabz.arrays.level01
{
    internal class OddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enetr the value ");
            int num = int.Parse(Console.ReadLine());

            int[] even = new int[num / 2 + 1];
            int[] odd = new int[num / 2 + 1];
            int evenIdx = 0, oddIdx = 0;

            if (num <= 0)
            {
                Console.WriteLine("Error");
                return;
            }
            // store the elemnts by their property if they are even assigned to even array 

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    even[evenIdx] = i;
                    evenIdx++;
                }
                else
                {
                    odd[oddIdx] = i;
                    oddIdx++;
                }
            }

            // displaying odd numbers
            Console.WriteLine("odd numbers started");

            for (int j = 0; j < oddIdx; j++)
            {
                Console.WriteLine(odd[j]);
            }

            // displaying even numbers
            Console.WriteLine("Even numbers started");

            for (int j = 0; j < evenIdx; j++)
            {

                Console.WriteLine(even[j]);
            }
        }
    }
}
