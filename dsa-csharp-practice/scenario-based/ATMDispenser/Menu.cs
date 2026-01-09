using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.ATMDispenser
{ 
    public class Menu
    {
        private ATM atm = new ATM();

        public void Start()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- ATM MENU ---");
                Console.WriteLine("1. Withdraw (All Notes Available)");
                Console.WriteLine("2. Withdraw (500rs. Removed)");
                Console.WriteLine("3. Withdraw (Fallback Scenario)");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        atm.WithdrawWithAllNotes();
                        break;
                    case 2:
                        atm.WithdrawWithout500Note();
                        break;
                    case 3:
                        atm.WithdrawWithFallback();
                        break;
                }

            } while (choice != 4);
        }
    }

}
