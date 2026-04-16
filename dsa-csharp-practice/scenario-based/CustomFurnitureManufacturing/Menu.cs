using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.CustomFurnitureManufacturing
{
    public class Menu
    {
        public void Show(Rod rod, PriceCatalog catalog)
        {
            while (true)
            {
                Console.WriteLine("\n===============================");
                Console.WriteLine(" Custom Furniture Manufacturing");
                Console.WriteLine("===============================");
                Console.WriteLine("1. Scenario A - Max Revenue (Exact Full Rod)");
                Console.WriteLine("2. Scenario B - Max Revenue with Waste Constraint");
                Console.WriteLine("3. Scenario C - Max Revenue + Minimum Waste");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            int revenue = RodCuttingUtility.ScenarioA_MaxRevenue(rod, catalog);

                            Console.WriteLine("\n--- Scenario A Result ---");
                            Console.WriteLine("Rod Length: " + rod.Length);
                            Console.WriteLine("Max Revenue: " + revenue);
                            break;
                        }

                    case 2:
                        {
                            Console.Write("\nEnter allowed waste (W): ");
                            int w = Convert.ToInt32(Console.ReadLine());

                            int revenue = RodCuttingUtility.ScenarioB_MaxRevenueWithWaste(rod, catalog, w);

                            Console.WriteLine("\n--- Scenario B Result ---");
                            Console.WriteLine("Rod Length: " + rod.Length);
                            Console.WriteLine("Allowed Waste: " + w);
                            Console.WriteLine("Max Revenue: " + revenue);
                            break;
                        }

                    case 3:
                        {
                            RodCuttingUtility.ScenarioC_MaxRevenueMinWaste(
                                rod, catalog,
                                out int bestRevenue,
                                out int bestWaste
                            );

                            Console.WriteLine("\n--- Scenario C Result ---");
                            Console.WriteLine("Rod Length: " + rod.Length);
                            Console.WriteLine("Max Revenue: " + bestRevenue);
                            Console.WriteLine("Minimum Waste: " + bestWaste);
                            break;
                        }

                    case 0:
                        Console.WriteLine("Exit");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
