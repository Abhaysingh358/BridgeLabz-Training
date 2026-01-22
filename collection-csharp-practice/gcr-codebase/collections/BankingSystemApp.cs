using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.collections
{
    class WithdrawalRequest
    {
        public int AccountId { get; private set; }
        public double Amount { get; private set; }

        public WithdrawalRequest(int accountId, double amount)
        {
            AccountId = accountId;
            Amount = amount;
        }
    }

    class BankingSystem
    {
        private Dictionary<int, double> balances;
        private Queue<WithdrawalRequest> withdrawalQueue;

        public BankingSystem()
        {
            balances = new Dictionary<int, double>();
            withdrawalQueue = new Queue<WithdrawalRequest>();
        }

        public void CreateAccount()
        {
            Console.Write("Enter Account ID: ");
            int id = int.Parse(Console.ReadLine());

            if (balances.ContainsKey(id))
            {
                Console.WriteLine("Account already exists.");
                return;
            }

            Console.Write("Enter initial balance: ");
            double balance = double.Parse(Console.ReadLine());

            balances[id] = balance;
            Console.WriteLine("Account created.");
        }

        public void Deposit()
        {
            Console.Write("Enter Account ID: ");
            int id = int.Parse(Console.ReadLine());

            if (!balances.ContainsKey(id))
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.Write("Enter deposit amount: ");
            double amount = double.Parse(Console.ReadLine());

            balances[id] += amount;
            Console.WriteLine("Deposit successful.");
        }

        public void AddWithdrawalRequest()
        {
            Console.Write("Enter Account ID: ");
            int id = int.Parse(Console.ReadLine());

            if (!balances.ContainsKey(id))
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.Write("Enter withdrawal amount: ");
            double amount = double.Parse(Console.ReadLine());

            withdrawalQueue.Enqueue(new WithdrawalRequest(id, amount));
            Console.WriteLine("Withdrawal request added to queue.");
        }

        public void ProcessWithdrawals()
        {
            Console.WriteLine("\nProcessing Withdrawal Requests:");

            if (withdrawalQueue.Count == 0)
            {
                Console.WriteLine("No withdrawal requests in queue.");
                return;
            }

            while (withdrawalQueue.Count > 0)
            {
                WithdrawalRequest req = withdrawalQueue.Dequeue();
                int id = req.AccountId;
                double amount = req.Amount;

                if (!balances.ContainsKey(id))
                {
                    Console.WriteLine("Account not found: " + id);
                    continue;
                }

                if (balances[id] >= amount)
                {
                    balances[id] -= amount;
                    Console.WriteLine("Withdrawal processed: Account " + id 
                        + " Amount " + amount);
                }
                else
                {
                    Console.WriteLine("Insufficient balance: Account " 
                        + id + " Requested " + amount);
                }
            }
        }

        public void DisplayAccounts()
        {
            Console.WriteLine("\nAccounts (Dictionary):");

            if (balances.Count == 0)
            {
                Console.WriteLine("No accounts available.");
                return;
            }

            foreach (var kv in balances)
                Console.WriteLine("Account " + kv.Key 
                    + " Balance " + kv.Value);
        }

        public void DisplaySortedByBalance()
        {
            Console.WriteLine("\nAccounts Sorted by Balance (SortedDictionary):");

            if (balances.Count == 0)
            {
                Console.WriteLine("No accounts available.");
                return;
            }

            SortedDictionary<double, List<int>> sorted = new 
                SortedDictionary<double, List<int>>();

            foreach (var kv in balances)
            {
                int accountId = kv.Key;
                double balance = kv.Value;

                if (!sorted.ContainsKey(balance))
                    sorted[balance] = new List<int>();

                sorted[balance].Add(accountId);
            }

            foreach (var kv in sorted)
            {
                double balance = kv.Key;
                List<int> accounts = kv.Value;

                foreach (int id in accounts)
                    Console.WriteLine("Account " + id + " Balance " + balance);
            }
        }

        public void CheckBalance()
        {
            Console.Write("Enter Account ID: ");
            int id = int.Parse(Console.ReadLine());

            if (!balances.ContainsKey(id))
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.WriteLine("Account " + id + " Balance " + balances[id]);
        }
    }

    class BankingSystemApp
    {
        static void Main()
        {
            BankingSystem bank = new BankingSystem();

            while (true)
            {
                Console.WriteLine("\nBanking System Menu");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Add Withdrawal Request");
                Console.WriteLine("4. Process Withdrawals");
                Console.WriteLine("5. Display All Accounts");
                Console.WriteLine("6. Display Sorted by Balance");
                Console.WriteLine("7. Check Balance");
                Console.WriteLine("8. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        bank.CreateAccount();
                        break;
                    case 2:
                        bank.Deposit();
                        break;
                    case 3:
                        bank.AddWithdrawalRequest();
                        break;
                    case 4:
                        bank.ProcessWithdrawals();
                        break;
                    case 5:
                        bank.DisplayAccounts();
                        break;
                    case 6:
                        bank.DisplaySortedByBalance();
                        break;
                    case 7:
                        bank.CheckBalance();
                        break;
                    case 8:
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }

}
