using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.inheritence.hierarchical_inheritence.BankAccountTypes
{
    internal class SavingsAccount : BankAccount
    {
        //attributes
        double InterestRate;

        // parametrized constructor
        public SavingsAccount(int accountNumber, double balance, double interestRate)
            : base(accountNumber, balance)
        {
            this.InterestRate = interestRate; //  reference
        }

        public override string ToString()
        {
            return "Savings Account -> " + base.ToString() + $" , Interest Rate : {InterestRate}%";

        }
    }
}
