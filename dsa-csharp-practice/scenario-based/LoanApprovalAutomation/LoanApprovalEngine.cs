using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.LoanApprovalAutomation
{
    internal class LoanApprovalEngine
    {
        public void ProcessLoan(Applicant applicant, LoanApplication application)
        {
            bool approved = application.ApproveLoan(applicant);

            if (approved)
                application.SetStatus(LoanStatus.Approved);
            else
                application.SetStatus(LoanStatus.Rejected);
        }

        public void PrintLoanReport(Applicant applicant, LoanApplication application)
        {
            double emi = application.CalculateEMI();

         
            Console.WriteLine("           LoanBuddy Report            ");
            Console.WriteLine("=======================================");
            Console.WriteLine(applicant);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Loan Type   : {application.LoanType}");
            Console.WriteLine($"Loan Amount : {application.LoanAmount}");
            Console.WriteLine($"Interest Rate  : {application.InterestRate}percent");
            Console.WriteLine($"Term (Months)  : {application.TermMonths}");
            Console.WriteLine($"EMI : {Math.Round(emi, 2)}");
            Console.WriteLine($"Loan Status  : {application.Status}");
            Console.WriteLine("=======================================\n");
        }
    }
}

