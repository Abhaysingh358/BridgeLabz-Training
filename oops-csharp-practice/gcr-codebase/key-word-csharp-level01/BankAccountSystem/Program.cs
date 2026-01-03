using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.key_word_csharp_level01.BankAccountSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount(101, "Abhay Singh");
            BankAccount acc2 = new BankAccount(102, "Ravi Kumar");

            // using is operator 
            if (acc1 is BankAccount)
            {
                acc1.Display(); // calling methods
            }

            if (acc2 is BankAccount)
            {
                acc2.Display();
            }

            // calling methods
            BankAccount.GetTotalAccounts();

        }
    }
}
