using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgeLabz.collection_csharp_practice.scenario_based.AmbulanceRoute
{
    internal class AmbulanceRouteMenu
    {
        private  IAmbulanceRouteUtility routeUtility;

        public void Start()
        {
            routeUtility = new AmbulanceRouteUtility();

            while (true)
            {
                Console.WriteLine("\n=====>> Ambulance Route System <<=====");
                Console.WriteLine("1. Add Hospital Unit");
                Console.WriteLine("2. Redirect Patient");
                Console.WriteLine("3. Mark Unit Under Maintenance");
                Console.WriteLine("4. Remove Hospital Unit");
                Console.WriteLine("5. Display Route");
                Console.WriteLine("6. Exit");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        routeUtility.AddHospitalUnit();
                        break;

                    case 2:
                        routeUtility.RedirectPatient();
                        break;

                    case 3:
                        routeUtility.MarkUnderMaintenance();
                        break;

                    case 4:
                        routeUtility.RemoveHospitalUnit();
                        break;

                    case 5:
                        routeUtility.DisplayRoute();
                        break;

                    case 6:
                        Console.WriteLine("System closed.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}

