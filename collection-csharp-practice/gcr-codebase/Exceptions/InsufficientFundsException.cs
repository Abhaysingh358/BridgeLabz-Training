using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.Exceptions
{
    class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message)
        {
        }
    }

    class BankAccount
    {
        public double Balance { get; private set; }

        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Invalid amount!");
            }

            if (amount > Balance)
            {
                throw new InsufficientFundsException("Insufficient balance!");
            }

            Balance -= amount;
        }
    }

    class BankTransactionApp
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter initial balance: ");
                double initialBalance = Convert.ToDouble(Console.ReadLine());

                BankAccount account = new BankAccount(initialBalance);

                Console.Write("Enter withdrawal amount: ");
                double withdrawAmount = Convert.ToDouble(Console.ReadLine());

                account.Withdraw(withdrawAmount);

                Console.WriteLine($"Withdrawal successful, new balance: {account.Balance}");
            }
            catch (InsufficientFundsException)
            {
                Console.WriteLine("Insufficient balance!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid amount!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter numeric values.");
            }
        }
    }

}
