using System;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level01
{
    internal class SimpleInterest
    {

        public double Interest(double principle, double rate, double time)
        {
            double SI = (principle * rate * time) / 100;
            return SI;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Principal Amount: ");
            double principle = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Rate : ");
            double rate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Time in years : ");
            double time = double.Parse(Console.ReadLine());

            SimpleInterest calc = new SimpleInterest();

            Console.WriteLine("The Simple interest is : " + calc.Interest(principle, rate, time));
        }
    }
}
