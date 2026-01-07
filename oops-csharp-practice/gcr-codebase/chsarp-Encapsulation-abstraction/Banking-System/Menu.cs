using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.Banking_System
{
    internal class Menu
    {
        BankAccount[] accounts = new BankAccount[3]; // array used
        int index = 0;

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Savings");
                Console.WriteLine("2.Current");
                Console.WriteLine("3.Deposit");
                Console.WriteLine("4.Show Interest");
                Console.WriteLine("5.Apply for Loan");
                Console.WriteLine("6.Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: 
                        AddAccount(new SavingsAccount()); 
                        break;
                    case 2: 
                        AddAccount(new CurrentAccount()); 
                        break;
                    case 3: 
                        DepositMoney(); 
                        break;
                    case 4: 
                        ShowInterest(); 
                        break;
                    case 5:
                        ApplyLoan();
                        break;
                    case 6: 
                        return;
                }
            }
        }

        void AddAccount(BankAccount acc)
        {
            if (index >= accounts.Length) return;

            Console.Write("Acc No: ");
            acc.SetAccountNumber(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Name: ");
            acc.SetHolderName(Console.ReadLine());

            Console.Write("Balance: ");
            acc.SetBalance(Convert.ToDouble(Console.ReadLine()));

            accounts[index++] = acc;
        }

        void DepositMoney()
        {
            Console.Write("Index: ");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.Write("Amount: ");
            double amt = Convert.ToDouble(Console.ReadLine());

            accounts[i].Deposit(amt);
        }

        void ShowInterest()
        {
            for (int i = 0; i < index; i++)
            {
                BankAccount acc = accounts[i];
                double interest = acc.CalculateInterest(); // polymorphism
                Console.WriteLine(acc.HolderName + " Interest: " + interest);
            }
        }
        void ApplyLoan()
        {
            Console.Write("Index: ");
            int i = Convert.ToInt32(Console.ReadLine());

            if (accounts[i] is ILoanable loan)
            {
                loan.ApplyForLoan(); // everything handled inside
            }
        }
    }
}
