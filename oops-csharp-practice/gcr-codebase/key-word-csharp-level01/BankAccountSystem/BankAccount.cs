using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.key_word_csharp_level01.BankAccountSystem
{
    internal class BankAccount
    {
        static string BankName = "SBI";
        static int TotalAccounts=0;

        public readonly int AccountNumber;
        string AccountHolder;

        // creating a parametrize constructor
        public BankAccount(int AccountNumber ,  string AccountHolder)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolder = AccountHolder;
            TotalAccounts++;
        }

        // static method to count total accounts
        public static void GetTotalAccounts()
        {
            Console.WriteLine($"Total Accounts Created : {TotalAccounts}");
        }

        // method to display
        public void Display()
        {
            Console.WriteLine("Bank Account Details");
            Console.WriteLine($"Bank Name      : {BankName}");
            Console.WriteLine($"Account Number : {AccountNumber}");
            Console.WriteLine($"Account Holder : {AccountHolder}");

        }


    }
}
