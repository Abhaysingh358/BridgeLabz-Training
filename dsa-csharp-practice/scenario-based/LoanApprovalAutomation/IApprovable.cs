using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabz.gcr_codebase.DSA.scenario_based.LoanApprovalAutomation
{
    internal interface IApprovable
    {
        bool ApproveLoan(Applicant applicant);
        double CalculateEMI();
    }
}
