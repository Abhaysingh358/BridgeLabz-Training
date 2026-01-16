using System;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.TabHistoryManager
{
    internal class BrowserMenu
    {
        private ITabManager manager;

        public BrowserMenu()
        {
            manager = new BrowserManager();
        }

        public void ShowMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n------ Tab History Manager Menu ------");
                Console.WriteLine("1. Open New Tab");
                Console.WriteLine("2. Switch Tab");
                Console.WriteLine("3. Navigate to URL");
                Console.WriteLine("4. Back");
                Console.WriteLine("5. Forward");
                Console.WriteLine("6. Show Current Page");
                Console.WriteLine("7. Show All Tabs");
                Console.WriteLine("8. Close Current Tab");
                Console.WriteLine("9. Restore Closed Tab");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                bool valid = int.TryParse(Console.ReadLine(), out choice);
                if (!valid) choice = -1;

                switch (choice)
                {
                    case 1:
                        manager.OpenNewTab();
                        break;

                    case 2:
                        Console.Write("Enter TabId: ");
                        int id;
                        if (int.TryParse(Console.ReadLine(), out id))
                            manager.SwitchTab(id);
                        else
                            Console.WriteLine("Invalid TabId.");
                        break;

                    case 3:
                        Console.Write("Enter URL: ");
                        string url = Console.ReadLine();
                        manager.Navigate(url);
                        break;

                    case 4:
                        manager.Back();
                        break;

                    case 5:
                        manager.Forward();
                        break;

                    case 6:
                        manager.ShowCurrent();
                        break;

                    case 7:
                        manager.ShowAllTabs();
                        break;

                    case 8:
                        manager.CloseCurrentTab();
                        break;

                    case 9:
                        manager.RestoreLastClosedTab();
                        break;

                    case 0:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
