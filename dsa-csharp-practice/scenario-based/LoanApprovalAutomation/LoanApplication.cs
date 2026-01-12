using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.LoanApprovalAutomation
{
    internal abstract class LoanApplication : IApprovable
    {
        public string LoanType { get; protected set; }
        public int TermMonths { get; protected set; }
        public double InterestRate { get; protected set; } // annual percent
        public double LoanAmount { get; protected set; }

        // cannot change from outside
        public string Status { get; private set; } = LoanStatus.Pending;

        protected LoanApplication(double loanAmount, int termMonths, double interestRate)
        {
            LoanAmount = loanAmount;
            TermMonths = termMonths;
            InterestRate = interestRate;
        }

        // only internal engine can change
        internal void SetStatus(string status)
        {
            Status = status;
        }

        //  Default Approval Rule (can override)
        public virtual bool ApproveLoan(Applicant applicant)
        {
            int score = applicant.GetCreditScore();

            if (score < 650) return false;

            double emi = CalculateEMI();

            // EMI should not exceed 40% of monthly income
            if (emi > applicant.Income * 0.40) return false;

            return true;
        }

        // EMI formula using operators
        // EMI = P × R × (1+R)^N / ((1+R)^N – 1)
        public virtual double CalculateEMI()
        {
            double P = LoanAmount;
            double R = (InterestRate / 12.0) / 100.0; // monthly interest
            int N = TermMonths;

            double pow = Math.Pow(1 + R, N);

            double emi = (P * R * pow) / (pow - 1);

            return emi;
        }
    }
}
