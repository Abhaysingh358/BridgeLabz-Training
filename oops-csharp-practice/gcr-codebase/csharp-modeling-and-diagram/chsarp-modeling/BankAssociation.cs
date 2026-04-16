using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.class_modeling_and_diagram.csharp_modeling
{
    internal class BankAssociation
    {
        // Main method
        static void Main(string[] args)
        {
            Bank bank = new Bank("B.D.v. Indian bank");
            Customer c1 = new Customer("pushpak", 5000);
            //bank with customer
            bank.OpenAccount(c1);
            c1.ViewBalance();
        }
    }

    class Bank
    {
        // Bank name
        public string BankName;
        // Constructor
        public Bank(string name)
        {
            BankName = name;
        }
        // Method to open account
        public void OpenAccount(Customer customer)
        {
            Console.WriteLine(customer.Name + " opened in " + BankName);
        }
    }

    class Customer
    {
        // Customer name
        public string Name;
        public double Balance;

        public Customer(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }
        //  
        public void ViewBalance()
        {
            Console.WriteLine("Balance: " + Balance);
        }
    }
}
