using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.Banking_System
{
    internal interface ILoanable
    {
        void ApplyForLoan();
        double CalculateLoanEligibility();
    }
}
