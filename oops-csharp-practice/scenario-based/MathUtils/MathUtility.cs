using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.oops_csharp_practice.scenario_based.MathUtils
{
    internal class MathUtility
    {
        public int Factorial(int num)
        {
            int fact = 1;

            if (num < 0) return -1;

            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }

        public bool IsPrime(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public int GCD(int num1, int num2)
        {
            while (num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            return num1;
        }

        public int Fibonacci(int num)
        {
            if (num <= 1)
                return num;

            int a = 0, b = 1, c = 0;

            for (int i = 2; i <= num; i++)
            {
                c = a + b;

                a = b;
                b = c;
            }

            return c;
        }

        public int Input()
        {
            while (true)
            {
                int num;

                Console.WriteLine("Enter the num in integer");

                if (int.TryParse(Console.ReadLine(), out num))

                {
                    return num;
                }

                Console.WriteLine("Invalid input! Please enter an integer.\n");
            }
        }

        // This method calls the utility methods with the provided number
        public void UsingUtils()
        {
            int num1 = Input();

            
            Console.WriteLine("Using Math Utility class");
            Console.WriteLine("Factorial : " + Factorial(num1));
            Console.WriteLine("Is Prime : " + IsPrime(num1));
            Console.WriteLine("Fibonacci : " + Fibonacci(num1));

            Console.WriteLine("Enter another number for GCD:");

            int num2 = Input();

            Console.WriteLine("GCD: " + GCD(num1, num2));
        }
    }
}
