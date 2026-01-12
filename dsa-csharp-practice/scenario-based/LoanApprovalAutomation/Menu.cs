using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.LoanApprovalAutomation
{
    internal class Menu
    {
        public void Start()
        {
    
            Console.WriteLine(" Welcome to LoanBuddy   ");
           

            // Take applicant details
            Console.Write("\nEnter Applicant Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Credit Score: ");
            int creditScore = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Monthly Income: ");
            double income = Convert.ToDouble(Console.ReadLine());

            Applicant applicant = new Applicant(name, creditScore, income);

            // Take loan details
            Console.Write("\nEnter Loan Amount: ");
            double loanAmount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Term (Months): ");
            int termMonths = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSelect Loan Type:");
            Console.WriteLine("1. Personal Loan");
            Console.WriteLine("2. Home Loan");
            Console.WriteLine("3. Auto Loan");
            Console.Write("Enter choice: ");
            int loanChoice = Convert.ToInt32(Console.ReadLine());

            LoanApplication application = null;

            switch (loanChoice)
            {
                case 1:
                    application = new PersonalLoan(loanAmount, termMonths);
                    break;

                case 2:
                    application = new HomeLoan(loanAmount, termMonths);
                    break;

                case 3:
                    application = new AutoLoan(loanAmount, termMonths);
                    break;

                default:
                    Console.WriteLine("Invalid loan type ❌");
                    return;
            }

            // Process loan
            LoanApprovalEngine engine = new LoanApprovalEngine();
            engine.ProcessLoan(applicant, application);
            engine.PrintLoanReport(applicant, application);
        }
    }
}

