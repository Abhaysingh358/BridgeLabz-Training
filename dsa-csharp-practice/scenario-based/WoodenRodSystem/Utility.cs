using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.WoodenRodSystem
{
    
        internal class Utility : ILogOperations
        {
            private int bestRevenue;
            private int minWaste;

            // Scenario 1: Maximum Revenue (Exact cut OR allow waste but maximize revenue)
            public void Scenario1(WoodLog[] logs, int rodLength, int kerf)
            {
                bestRevenue = 0;
                FindMaxRevenue(logs, rodLength, 0, kerf);

                Console.WriteLine("Maximum Revenue: " + bestRevenue);
            }

            private void FindMaxRevenue(WoodLog[] logs, int remaining, int revenue, int kerf)
            {
                // remaining can be waste also (stop condition)
                if (remaining <= 0)
                {
                    if (revenue > bestRevenue)
                        bestRevenue = revenue;
                    return;
                }

                foreach (WoodLog log in logs)
                {
                    // Each piece needs log.Size
                    // Kerf applies only if we will cut again (i.e., after taking piece rod still > 0)
                    if (log.Size <= remaining)
                    {
                        int afterPiece = remaining - log.Size;

                        int afterKerf = afterPiece;

                        // if after taking piece some length is still left, it means we made a cut
                        // so reduce kerf
                        if (afterPiece > 0)
                            afterKerf = afterPiece - kerf;

                        if (afterKerf >= 0) // valid cut
                            FindMaxRevenue(logs, afterKerf, revenue + log.Price, kerf);
                    }
                }

                // Also consider stopping here (remaining becomes waste)
                if (revenue > bestRevenue)
                    bestRevenue = revenue;
            }

            // Scenario 2: Waste constraint
            public void Scenario2(WoodLog[] logs, int rodLength, int allowedWaste, int kerf)
            {
                bestRevenue = 0;
                FindWithWasteConstraint(logs, rodLength, 0, allowedWaste, kerf);

                Console.WriteLine("Maximum Revenue (with waste constraint): " + bestRevenue);
            }

            private void FindWithWasteConstraint(WoodLog[] logs, int remaining, int revenue, int wasteLeft, int kerf)
            {
                // stop when remaining is within allowed waste
                if (remaining <= wasteLeft)
                {
                    if (revenue > bestRevenue)
                        bestRevenue = revenue;
                    return;
                }

                foreach (WoodLog log in logs)
                {
                    if (log.Size <= remaining)
                    {
                        int afterPiece = remaining - log.Size;
                        int afterKerf = afterPiece;

                        if (afterPiece > 0)
                            afterKerf = afterPiece - kerf;

                        if (afterKerf >= 0)
                            FindWithWasteConstraint(logs, afterKerf, revenue + log.Price, wasteLeft, kerf);
                    }
                }
            }

            // Scenario 3: Best revenue + minimum waste
            public void Scenario3(WoodLog[] logs, int rodLength, int kerf)
            {
                bestRevenue = 0;
                minWaste = int.MaxValue;

                FindRevenueAndWaste(logs, rodLength, 0, kerf);

                Console.WriteLine("Maximum Revenue: " + bestRevenue);
                Console.WriteLine("Minimum Waste: " + minWaste);
            }

            private void FindRevenueAndWaste(WoodLog[] logs, int remaining, int revenue, int kerf)
            {
                // Consider stopping here
                if (remaining >= 0)
                {
                    int waste = remaining;

                    if (revenue > bestRevenue || (revenue == bestRevenue && waste < minWaste))
                    {
                        bestRevenue = revenue;
                        minWaste = waste;
                    }
                }

                foreach (WoodLog log in logs)
                {
                    if (log.Size <= remaining)
                    {
                        int afterPiece = remaining - log.Size;
                        int afterKerf = afterPiece;

                        if (afterPiece > 0)
                            afterKerf = afterPiece - kerf;

                        if (afterKerf >= 0)
                            FindRevenueAndWaste(logs, afterKerf, revenue + log.Price, kerf);
                    }
                }
            }
        }
}

