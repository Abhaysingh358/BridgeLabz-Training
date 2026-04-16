using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.oops_csharp_practice.scenario_based.Bank
{
    using System;

    internal class Menu
    {
        static Bank bank = new Bank();
        static Manager manager = new Manager();

        // This method starts the application and shows the main menu.
        public static void Start()
        {
            bank.DisplayBankInfo();   // Show bank details.
            bank.DisplayServices();   // Show available services.

            while (true)
            {
                Console.WriteLine("<====MAIN MENU =====>");
                Console.WriteLine("1. User Login");
                Console.WriteLine("2. Manager Login");
                Console.WriteLine("3. Exit");
                Console.Write("Choose: ");

                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1: UserMenu(); break;        // Go to user menu.
                    case 2: ManagerMenu(); break;     // Go to manager menu.
                    case 3: return;     // Exit the program.
                    default: Console.WriteLine("Invalid Choice!\n"); break;
                }
            }
        }

        // This method handles all user-side operations.
        static void UserMenu()
        {
            User u = manager.FindUser();   // User login using account number + PIN.
            if (u == null) return;

            while (true)
            {
                Console.WriteLine("\n---- USER MENU ----");
                Console.WriteLine("1. Withdraw Money");
                Console.WriteLine("2. Check Balance");
                Console.WriteLine("3. Transfer Money");
                Console.WriteLine("4. Back");
                Console.Write("Choose: ");

                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        u.WithdrawMoney(manager.minBalance, manager.maxTransaction);   // Withdraw money.
                        break;

                    case 2:
                        u.CheckBalance();    // Check current balance.
                        break;

                    case 3:
                        manager.TransferMoney(u);   // Transfer money to another user.
                        break;

                    case 4:
                        return;     // Go back to main menu.

                    default:
                        Console.WriteLine("Invalid Choice!\n");
                        break;
                }
            }
        }


        // This method handles all manager/admin-level operations.
        static void ManagerMenu()
        {
            Console.Write("Enter Manager Password: ");
            string pwd = Console.ReadLine();

            if (pwd != "admin123")
            {
                Console.WriteLine("Wrong Password!\n");
                return;
            }

            while (true)
            {
                Console.WriteLine("\n MANAGER MENU ");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Delete User");
                Console.WriteLine("3. Deposit Cash to User");
                Console.WriteLine("4. View All Users");
                Console.WriteLine("5. Back");
                Console.Write("Choose: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: manager.AddUser(); break;    // Create a new user.
                    case 2: manager.RemoveUser(); break;      // Delete a user by account number.
                    case 3: manager.DepositToUser(); break;   // Deposit cash to user account.
                    case 4: manager.ViewAllUsers(); break;  // Show all bank users.
                    case 5: return;     // Return to main menu.
                    default: Console.WriteLine("Invalid Choice!\n"); break;
                }
            }
        }
    }

}
