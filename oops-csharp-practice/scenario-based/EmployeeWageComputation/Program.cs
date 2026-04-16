using BridgeLabz.review.AddressBookingSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployee employeeUtility = new EmployeeUtility();
            EmployeeMenu menu = new EmployeeMenu(employeeUtility);
            menu.ShowMenu();
        }
    }
}
