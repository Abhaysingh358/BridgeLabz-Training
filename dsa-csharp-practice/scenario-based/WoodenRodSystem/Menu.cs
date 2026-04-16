using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.WoodenRodSystem
{
        internal class Menu
        {
            private const int SCALE = 100; // 2 decimal fixed (0.xx)

            public static void Start()
            {
                // Lengths are stored in scaled units
                WoodLog[] logs =
                {
                new WoodLog(1 * SCALE, 2),
                new WoodLog(2 * SCALE, 5),
                new WoodLog(3 * SCALE, 7),
                new WoodLog(4 * SCALE, 8),
                new WoodLog(5 * SCALE, 10)
            };

                int rodLength = 12 * SCALE;

                Console.Write("Enter kerf/cut-loss (like  0.20): ");
                if (!double.TryParse(Console.ReadLine(), out double kerfInput) || kerfInput < 0)
                {
                    Console.WriteLine("Invalid kerf. Default kerf = 0.00");
                    kerfInput = 0;
                }

                int kerf = (int)Math.Round(kerfInput * SCALE);

                Utility utility = new Utility();

                while (true)
                {
                    Console.WriteLine("\n--- Furniture Rod Cutting ---");
                    Console.WriteLine("1. Scenario 1 - Max Revenue");
                    Console.WriteLine("2. Scenario 2 - Waste Constraint");
                    Console.WriteLine("3. Scenario 3 - Revenue + Min Waste");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter choice: ");

                    if (!int.TryParse(Console.ReadLine(), out int choice))
                    {
                        Console.WriteLine("Invalid choice input.");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            utility.Scenario1(logs, rodLength, kerf);
                            break;

                        case 2:
                            Console.Write("Enter allowed waste (like 1.50): ");
                            if (!double.TryParse(Console.ReadLine(), out double wasteInput) || wasteInput < 0)
                            {
                                Console.WriteLine("Invalid waste input.");
                                break;
                            }

                            int allowedWaste = (int)Math.Round(wasteInput * SCALE);
                            utility.Scenario2(logs, rodLength, allowedWaste, kerf);
                            break;

                        case 3:
                            utility.Scenario3(logs, rodLength, kerf);
                            break;

                        case 4:
                            Console.WriteLine("Exiting...");
                            return;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
            }
        }
}
