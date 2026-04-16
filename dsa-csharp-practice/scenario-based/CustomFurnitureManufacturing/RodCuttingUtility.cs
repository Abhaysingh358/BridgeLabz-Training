using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.CustomFurnitureManufacturing
{
    using System;

    public static class RodCuttingUtility
    {
        // Scenario A (No DP)
        public static int ScenarioA_MaxRevenue(Rod rod, PriceCatalog catalog)
        {
            return Solve(rod.Length, catalog);
        }

 
        // Scenario B (No DP)
        // Max revenue with waste constraint:
        // waste <= allowedWaste
        public static int ScenarioB_MaxRevenueWithWaste(Rod rod, PriceCatalog catalog, int allowedWaste)
        {
            int n = rod.Length;

            int bestRevenue = int.MinValue;

            int startUsed = n - allowedWaste;
            if (startUsed < 0) startUsed = 0;

            for (int usedLen = startUsed; usedLen <= n; usedLen++)
            {
                int revenue = Solve(usedLen, catalog);
                bestRevenue = Math.Max(bestRevenue, revenue);
            }

            return bestRevenue;
        }

        // Scenario C (No DP)
        // Max revenue + minimum waste
        // Priority:
        // 1) max revenue
        // 2) if tie => min waste
      
        public static void ScenarioC_MaxRevenueMinWaste(Rod rod, PriceCatalog catalog, out int bestRevenue, out int bestWaste)
        {
            int n = rod.Length;

            bestRevenue = int.MinValue;
            bestWaste = int.MaxValue;

            for (int usedLen = 0; usedLen <= n; usedLen++)
            {
                int revenue = Solve(usedLen, catalog);
                int waste = n - usedLen;

                if (revenue > bestRevenue || (revenue == bestRevenue && waste < bestWaste))
                {
                    bestRevenue = revenue;
                    bestWaste = waste;
                }
            }
        }

      // internal pure recursion
        private static int Solve(int n, PriceCatalog catalog)
        {
            if (n == 0) return 0;

            int best = int.MinValue;

            for (int cut = 1; cut <= n; cut++)
            {
                int revenue = catalog.GetPrice(cut) + Solve(n - cut, catalog);
                best = Math.Max(best, revenue);
            }

            return best;
        }
    }


}
