using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.extras_csharp_strings.level01
{
    internal class BasicCalculator
    {
        // Addition method
        public static string Add(double a , double b)
        {
            return $"The Additon of {a} and {b} is : {a + b}";
        }

        // subtraction method
        public static string Subtract(double a, double b)
        {
            return $"The Subtraction of {a} and {b} is : {a - b}";
        }

        // multiplicaton method
        public static string Multiply(double a, double b)
        {
            return $"The Multiplication of {a} and {b} is : {a * b}";
        }

        // division method
        public static string divide(double a, double b)
        {
            if (b == 0)
            {
                return $"Division by Zero is not allowed";
            }
            return $"The Additon of {a} and {b} is : {a / b}";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("This is a BAsic calculator which can perform" +
                " : addition , substraction ,multiplication , and division");

            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            
            Console.WriteLine("Enter the operation : add / subtract / multiply / divide");
            string opt = Console.ReadLine();
            opt = opt.ToLower(); // converting lower so that is user mistankely typed in capital letters

            // menu driven , user can choose the operation 
            switch (opt)
            {
                case "add":

                    Console.WriteLine(Add(num1, num2));
                    break;

                case "subtract":
                    Console.WriteLine(Subtract(num1, num2));
                    break;

                case "multiply":
                    Console.WriteLine(Multiply(num1, num2));
                    break;

                case "divide":
                    Console.WriteLine(divide(num1, num2));
                    break;

                default:
                    Console.WriteLine("invalid option");
                    break;
            }

        }
    }
}
