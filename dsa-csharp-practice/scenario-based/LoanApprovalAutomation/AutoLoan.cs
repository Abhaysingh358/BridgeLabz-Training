using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.LoanApprovalAutomation
{
    internal class AutoLoan : LoanApplication
    {
        public AutoLoan(double loanAmount, int termMonths)
            : base(loanAmount, termMonths, 10.0)
        {
            LoanType = "Auto Loan";
        }

        //Polymorphism: Auto loan EMI includes extra 1% processing fee
        public override double CalculateEMI()
        {
            double processingFee = LoanAmount * 0.01;
            double newLoanAmount = LoanAmount + processingFee;

            // use base formula with changed principal
            double P = newLoanAmount;
            double R = (InterestRate / 12.0) / 100.0;
            int N = TermMonths;

            double pow = System.Math.Pow(1 + R, N);
            double emi = (P * R * pow) / (pow - 1);

            return emi;
        }
    }
}

