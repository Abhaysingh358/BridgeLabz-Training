using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.SmartHomeAutomationSystem
{
    internal class Menu
    {
        private Controller controller = new Controller();

        public void ShowMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Smart Home Automation Menu ---");
                Console.WriteLine("1. Add Light");
                Console.WriteLine("2. Add Fan");
                Console.WriteLine("3. Add AC");
                Console.WriteLine("4. Turn ON all devices (Light & Fan only)");
                Console.WriteLine("5. Turn OFF all devices");
                Console.WriteLine("6. Turn ON AC");
                Console.WriteLine("7. Turn OFF AC");
                Console.WriteLine("8. Display all devices");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        controller.AddLight();
                        Console.WriteLine("Light added.");
                        break;

                    case 2:
                        controller.AddFan();
                        Console.WriteLine("Fan added.");
                        break;

                    case 3:
                        controller.AddAC();
                        Console.WriteLine("AC added.");
                        break;

                    case 4:
                        controller.TurnOnAllDevices();
                        Console.WriteLine("Lights and Fans turned ON.");
                        break;

                    case 5:
                        controller.TurnOffAllDevices();
                        Console.WriteLine("All devices turned OFF.");
                        break;

                    case 6:
                        controller.TurnOnAC();
                        Console.WriteLine("AC turned ON.");
                        break;

                    case 7:
                        controller.TurnOffAC();
                        Console.WriteLine("AC turned OFF.");
                        break;

                    case 8:
                        controller.DisplayAllDevices();
                        break;

                    case 0:
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } while (choice != 0);
        }
    }
}
