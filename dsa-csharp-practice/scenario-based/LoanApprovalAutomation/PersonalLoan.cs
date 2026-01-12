using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.LoanApprovalAutomation
{
    internal class PersonalLoan : LoanApplication
    {
        // Constructor for Personal Loan
        public PersonalLoan(double loanAmount, int termMonths)
            : base(loanAmount, termMonths, 13.5)
        {
            LoanType = "Personal Loan";
        }
    }
}
