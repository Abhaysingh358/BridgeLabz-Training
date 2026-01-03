using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.constructors_level01.VehicleRegistration
{
    internal class Menu
    {

        public void MenuProgram()
        {
            Vehicle v = null;

            while (true) 
            {
                Console.WriteLine("Vehicle Registration System");
                Console.WriteLine("1. Register New Vehicle");
                Console.WriteLine("2. Display Vehicle Details");
                Console.WriteLine("3. Update Registration Fee");
                Console.WriteLine("4. Exit");

                Console.WriteLine("Enter your choice");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {

                case 1:
                    v= new Vehicle();
                    v.Input();
                        break;

                case 2:
                        if (v != null)
                        {
                            v.Display();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No Vehicle register yet");
                            break;
                        }

                case 3:
                        Vehicle.ChangeRegistrationFee();
                        break;

                case 4:
                        Console.WriteLine("Thank you");
                        return;

                default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
            }

        }
        
         
    }

    
}
