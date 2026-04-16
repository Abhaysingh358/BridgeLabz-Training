using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.LoanApprovalAutomation
{
    internal class Applicant
    {
        public string Name { get; private set; }
        public double Income { get; private set; }   // monthly income

        private int CreditScore; // private

        public Applicant(string name, int creditScore, double income)
        {
            Name = name;
            CreditScore = creditScore;
            Income = income;
        }

        // Only internal system can check credit score
        internal int GetCreditScore()
        {
            return CreditScore;
        }

        public override string ToString()
        {
            return $"Applicant Name : {Name}\nIncome         : {Income}\nCredit Score   : {CreditScore}";
        }
    }
}
