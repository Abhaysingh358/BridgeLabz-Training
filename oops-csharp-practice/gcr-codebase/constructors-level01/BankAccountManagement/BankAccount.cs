using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.constructors_level01.BankAccountManagement
{
    public class BankAccount
    {
        public int AccountNumber;
        protected string AccountHolder;
        private double Balance;

        public BankAccount(int accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public double GetBalance()
        {
            return Balance;
        }

        // method to deposit money
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }


        // method to withdraw money
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Invalid or insufficient balance.");
            }
        }

        // displaying details
        public void Display()
        {
            Console.WriteLine("Bank Account Details");
            Console.WriteLine($"Account Number : {AccountNumber}");
            Console.WriteLine($"Account Holder : {AccountHolder}");
            Console.WriteLine($"Balance        : {Balance}");
        }


    }

    public class SavingsAccount : BankAccount
    {
        double interestRate = 4.5;

        // parameterized constructor calling base constructor
        public SavingsAccount(int accNo, string holderName, double initialBalance)

            : base(accNo, holderName, initialBalance)
        {
        }

        public void DisplaySavingsAccount()
        {
            Console.WriteLine("Savings Account Details");
            Console.WriteLine($"Account Number : {AccountNumber}");   // public
            Console.WriteLine($"Account Holder : {AccountHolder}");   // protected
            Console.WriteLine($"Balance  : {GetBalance()}");    // private via method
            Console.WriteLine($"Interest Rate  : {interestRate}%");
        }
    }
}
