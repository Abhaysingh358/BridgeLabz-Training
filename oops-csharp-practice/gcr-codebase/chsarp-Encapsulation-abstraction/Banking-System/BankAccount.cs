using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.Banking_System
{
    internal abstract class BankAccount
    {
        private int accountNumber;
        private string holderName;
        private double balance;

        public int AccountNumber { get { return accountNumber; } }
        public string HolderName { get { return holderName; } }
        public double Balance { get { return balance; } }

        // setters for encapsulation
        public void SetAccountNumber(int num) { accountNumber = num; }
        public void SetHolderName(string name) { holderName = name; }
        public void SetBalance(double bal) { balance = bal; }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
                balance -= amount;
        }

        // interest differs for each account
        public abstract double CalculateInterest();
    }
}
