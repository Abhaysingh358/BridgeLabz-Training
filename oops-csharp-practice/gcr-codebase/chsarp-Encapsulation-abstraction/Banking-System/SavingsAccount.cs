using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.Banking_System
{
    internal class SavingsAccount : BankAccount, ILoanable
    {
        // savings interest logic
        public override double CalculateInterest()
        {
            return Balance * 0.04;
        }
        public void ApplyForLoan()
        {
            // simple loan apply
            double eligibleAmount = CalculateLoanEligibility();

            Console.WriteLine("Eligible Loan: " + eligibleAmount);
            Console.Write("Enter Loan Amount: ");
            double requestAmount = double.Parse(Console.ReadLine());

            if (requestAmount <= eligibleAmount)
            {
                Deposit(requestAmount); // add loan to balance
                Console.WriteLine("Loan Approved");
            }
            else
            {
                Console.WriteLine("Loan Rejected");
            }
        }
        public double CalculateLoanEligibility()
        {
            return Balance * 5;
        }
    }
}
