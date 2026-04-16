using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.Banking_System
{
    internal class CurrentAccount : BankAccount
    {
        // current account interest
        public override double CalculateInterest()
        {
            return Balance * 0.02;
        }
    }
}
