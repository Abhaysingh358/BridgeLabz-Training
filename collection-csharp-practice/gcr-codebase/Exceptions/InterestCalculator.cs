using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.Exceptions
{
    class InterestCalculator
    {
        static double CalculateInterest(double amount, double rate, int years)
        {
            if (amount < 0 || rate < 0)
            {
                throw new ArgumentException("Amount and rate must be positive");
            }

            // Simple Interest Formula: (P * R * T) / 100
            double interest = (amount * rate * years) / 100;
            return interest;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Amount: ");
                double principalAmount = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Rate : ");
                double interestRate = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Years: ");
                int numberOfYears = Convert.ToInt32(Console.ReadLine());

                double totalInterest = CalculateInterest(principalAmount, interestRate, numberOfYears);

                Console.WriteLine($"\nCalculated Interest: {totalInterest}");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid input: Amount and rate must be positive");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input: Please enter numeric values only.");
            }
        }
    }

}
