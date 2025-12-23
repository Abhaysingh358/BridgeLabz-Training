using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabz.arrays.level01
{
    internal class MaxFactor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the NUmber ");
            int num = int.Parse(Console.ReadLine());


            int maxFactor = 10;
            int[] factors = new int[maxFactor];

            int idx = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    if (idx == maxFactor)
                    {

                        int newMax = maxFactor * 2; // double the array size to new variable
                        int[] temp = new int[newMax];

                        for (int j = 0; j < maxFactor; j++)
                        {
                            temp[j] = factors[j]; // copying the array elements
                        }

                        factors = temp;
                        maxFactor = newMax;// making size of factor array's index doubled


                    }

                    factors[idx] = i;
                    idx++;
                }
            }

            // displaying the array
            Console.WriteLine("\nFactors of " + num + ":");
            for (int i = 0; i < idx; i++)
            {
                Console.Write(factors[i] + " ");
            }



        }
    }
}
