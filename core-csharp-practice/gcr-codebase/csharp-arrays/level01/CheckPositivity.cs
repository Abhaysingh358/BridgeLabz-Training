using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.arrays.level01
{
    internal class CheckPositivity
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("enter the " + (i + 1) + "number");
                num[i] = int.Parse(Console.ReadLine());

            }

// in below loop  code checks the postivity , negativity of number 

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > 0) // number is greater than zero --> positive
                {
                    Console.WriteLine("the number " + num[i] + "is positive ");
                }
                else if (num[i] == 0) 
                {
                    Console.WriteLine("The " + num[i] + " is zero");
                }
                else
                {
                    Console.WriteLine("The number is Negative");
                }
            }
        }
    }
}
