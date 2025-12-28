using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.extras_csharp_strings.level01
{
    internal class GCMAndLCM
    {
        // Using Euclidiean theorem to find out the GCD of two numbers
        public static int Gcd(int a, int b)
        {
            if (b > a)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // using lcm * gcd = a * b  to find out the LCM of two numbers
        public static int Lcm(int a, int b)
        {
            return (a * b) / Gcd(a, b);
        }

        // method to get both GCD and LCM and converted to string
        public static string GetGcdLcm(int a, int b)
        {
            int gcd = Gcd(a, b);
            int lcm = Lcm(a, b);
            return $"GCD of {a} and {b} is: {gcd} ,LCM of {a} and {b} is: {lcm}";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());

            // calling the method to get GCD and LCM and displaiyng the result
            string result = GetGcdLcm(num1, num2);
            Console.WriteLine(result);



        }
    }
}
