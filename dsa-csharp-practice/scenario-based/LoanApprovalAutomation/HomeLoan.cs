using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.LoanApprovalAutomation
{
    internal class HomeLoan : LoanApplication
    {
        public HomeLoan(double loanAmount, int termMonths)
            : base(loanAmount, termMonths, 8.5)
        {
            LoanType = "Home Loan";
        }

        // Polymorphism (different approval rules)
        public override bool ApproveLoan(Applicant applicant)
        {
            int score = applicant.GetCreditScore();
            if (score < 700) return false;

            double emi = CalculateEMI();

            // Home loan: allow EMI up to 50%
            if (emi > applicant.Income * 0.50) return false;

            return true;
        }
    }
}

