using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level01
{
    internal class CheckPositive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number : ");
            int num = int.Parse(Console.ReadLine());

            CheckPositive number = new CheckPositive(); // creating instance 

            int result = number.check(num);

            if(result == 1)
            {
                Console.WriteLine("number is positive ");
            }
            else if(result == -1)
            {
                Console.WriteLine("number is Negative");
            }
            else
            {
                Console.WriteLine("number is zero");
            }
           

        }

        // methods to check number
        public int check(int n)
        {
            if (n > 0)
            {
                return 1;
            }
            else if (n == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
