using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.oops_csharp_practice.scenario_based.Bank
{

    internal class Manager
    {
        public User[] users = new User[50];
        public int count = 0;

        public double minBalance = 100;
        public double maxTransaction = 100000000;

        //  checks whether the entered account number has exactly 6 digits.
        public bool IsValidAccountNumberLength(int acc)
        {
            return acc >= 100000 && acc <= 999999;
        }

        // This method checks if the given account number is already used by another user.
        public bool IsAccountNumberUnique(int acc)
        {
            for (int i = 0; i < count; i++)
            {
                if (users[i].accountNumber == acc)
                    return false;
            }
            return true;
        }

        // This method repeatedly takes account number input until it is valid and unique.
        public int GetValidUniqueAccountNumber()
        {
            while (true)
            {
                Console.Write("Enter a 6-digit Account Number: ");
                int acc = int.Parse(Console.ReadLine());

                if (!IsValidAccountNumberLength(acc))
                {
                    Console.WriteLine("Error: Account number must be exactly 6 digits!\n");
                    continue;
                }

                if (!IsAccountNumberUnique(acc))
                {
                    Console.WriteLine("Error: This account number already exists!\n");
                    continue;
                }

                return acc;
            }
        }

        // This method takes input for a 4-digit PIN and validates it.
        public int GetValidPIN()
        {
            while (true)
            {
                Console.Write("Set 4-digit PIN: ");
                int pin = int.Parse(Console.ReadLine());

                if (pin >= 1000 && pin <= 9999)
                    return pin;

                Console.WriteLine("Error: PIN must be exactly 4 digits!\n");
            }
        }

        // This method adds a new user to the bank.
        public void AddUser()
        {
            User u = new User();

            Console.Write("Enter Name: ");
            u.name = Console.ReadLine();

            Console.Write("Enter Address: ");
            u.address = Console.ReadLine();

            Console.Write("Enter Mobile: ");
            u.mobile = long.Parse(Console.ReadLine());

            Console.Write("Enter Opening Balance: ");
            u.balance = double.Parse(Console.ReadLine());

            u.accountNumber = GetValidUniqueAccountNumber();
            u.pin = GetValidPIN();

            users[count] = u;
            count++;

            Console.WriteLine("User Added Successfully!\n");
        }


        // This method deposits money into a user's account (manager only operation).
        public void DepositToUser()
        {
            Console.Write("Enter Account Number: ");
            int account = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                if (users[i].accountNumber == account)
                {
                    Console.Write("Enter Cash Amount to Deposit: ");
                    double amount = double.Parse(Console.ReadLine());

                    users[i].balance += amount;

                    Console.WriteLine("Cash Deposited Successfully!\n");
                    return;
                }
            }

            Console.WriteLine("User Not Found!\n");
        }

        // This method logs in a user using account number and pin.
        public User FindUser()
        {
            Console.Write("Enter Account Number: ");
            int acc = int.Parse(Console.ReadLine());

            Console.Write("Enter PIN: ");
            int p = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                if (users[i].accountNumber == acc && users[i].pin == p)
                    return users[i];
            }

            Console.WriteLine("Invalid Account Number or PIN!\n");
            return null;
        }

        // This method transfers money from one user to another.
        public void TransferMoney(User sender)
        {
            Console.Write("Enter Receiver Account Number: ");
            int receiverAccount = int.Parse(Console.ReadLine());

            User receiver = null;

            for (int i = 0; i < count; i++)
            {

                if (users[i].accountNumber == receiverAccount)
                {
                    receiver = users[i];
                    break;
                }
            }

            if (receiver == null)
            {
                Console.WriteLine("Receiver Not Found!\n");
                return;
            }

            Console.Write("Enter Amount to Transfer: ");
            double amount = double.Parse(Console.ReadLine());

            if (amount > maxTransaction)
            {
                Console.WriteLine("ERROR: Amount exceeds max transaction limit!\n");

                return;
            }

            if (sender.balance - amount < minBalance)
            {
                Console.WriteLine("ERROR: Minimum Balance Rule Violated!\n");
                return;

            }

            sender.balance -= amount;
            receiver.balance += amount;

            Console.WriteLine("Transfer Successful!");
            Console.WriteLine($"{amount} rs. sent to {receiver.name} (Account: {receiver.accountNumber})\n");
        }


        // This method prints all users stored in the system.
        public void ViewAllUsers()
        {
            if (count == 0)
            {
                Console.WriteLine("No Users Found.\n");
                return;
            }

            Console.WriteLine("\nUsers' List");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. {users[i].name} , Acc: {users[i].accountNumber} " +
                                                    $",Balance: {users[i].balance}");
            }
            Console.WriteLine();
        }

        // This method removes a user using account number.
        public void RemoveUser()
        {
            Console.WriteLine("Enter account number to delete");
            long AccountNumber = long.Parse(Console.ReadLine());

        }

    }

}
