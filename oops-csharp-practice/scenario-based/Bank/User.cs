using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.oops_csharp_practice.scenario_based.Bank
{

    public class User
    {
        public string name;
        public string address;
        public long mobile;
        public double balance;

        public int accountNumber;
        public int pin;

        // This method shows the user's current available balance.
        public void CheckBalance()
        {
            Console.WriteLine("\nCurrent Balance: " + balance + "\n");
        }

        // This method withdraws money after checking min balance and transaction limit.

        public void WithdrawMoney(double minBalance, double maxTransaction)
        {
            Console.Write("Enter amount to withdraw: ");
            double amount = double.Parse(Console.ReadLine());

            if (amount > maxTransaction)
            {
                Console.WriteLine("ERROR: Exceeds Maximum Transaction Limit!\n");
                return;
            }

            if (balance - amount < minBalance)
            {
                Console.WriteLine("ERROR: Minimum Balance Rule Violated!\n");
                return;
            }

            balance -= amount;
            Console.WriteLine("Withdrawal Successful!\n");
        }
    }
}

