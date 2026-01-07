using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.EmployeeWageComputation
{
    internal class EmployeeUtility : IEmployee
    {
        private static Random random = new Random();

        public bool IsPresent()
        {
            
            return random.Next(0, 2) == 1;
        }
    }
}
