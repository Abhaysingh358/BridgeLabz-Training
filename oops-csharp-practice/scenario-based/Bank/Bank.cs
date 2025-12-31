using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.oops_csharp_practice.scenario_based.Bank
{
    using System;

    public class Bank
    {
        // These fields store the basic identity of the bank.
        public string bankName = "Bank of BridgeLabz";
        public string ifscCode = "BOB00123";
        public string bankAddress = "Goverdhan Chauraha, Mathura";

        // This array represents all services that the bank provides.
        public string[] services = {
        "Withdraw Money",
        "Check Balance",
        "Transfer Money",
        "Open New Account",
        "Cash Deposit (Manager Only)",
        "Add User , Remove User , Deposite money (Manager only)"
    };

        // This method prints the basic details of the bank.
        public void DisplayBankInfo()
        {
            Console.WriteLine("\nBANK INFORMATION");
            Console.WriteLine("Bank Name: " + bankName);
            Console.WriteLine("IFSC Code: " + ifscCode);
            Console.WriteLine("Address: " + bankAddress);
            Console.WriteLine();
        }

        // This method prints all the services offered by the bank.
        public void DisplayServices()
        {
            Console.WriteLine("SERVICES");
            for (int i = 0; i < services.Length; i++)
                Console.WriteLine((i + 1) + ". " + services[i]);
            Console.WriteLine();
        }
    }

}
