using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.constructors_level01.BankAccountManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount s = new SavingsAccount(101, "Abhay Singh", 5000);


            s.DisplaySavingsAccount();
            s.Deposit(2000);
            s.Withdraw(1500);

            s.DisplaySavingsAccount();
        }
    }
}
