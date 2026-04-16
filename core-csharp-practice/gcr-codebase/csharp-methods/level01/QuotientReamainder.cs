using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level01
{
    internal class QuotientReamainder
    {
        // Method to return remainder and quotient
        public static int[] FindRemainderAndQuotient(int num, int divisor)
        {
            int quotient = num / divisor;
            int rem = num % divisor; //  remainder calculation

            return new int[] { rem, quotient };
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the Number: ");
            int  num = int.Parse(Console.ReadLine());

            Console.Write("Enter the Divisor: ");
             int divisor = int.Parse(Console.ReadLine());


            int[] result = FindRemainderAndQuotient(num, divisor);


            Console.WriteLine("\nRemainder : " + result[0]);
            Console.WriteLine("Quotient  : " + result[1]);
        }

    }
}
