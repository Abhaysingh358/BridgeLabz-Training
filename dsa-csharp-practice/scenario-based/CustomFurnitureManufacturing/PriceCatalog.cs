using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.CustomFurnitureManufacturing
{
    public class PriceCatalog
    {
        public int[] Price { get; private set; }

        public PriceCatalog(int[] price)
        {
            Price = price;
        }

        public int GetPrice(int length)
        {
            return Price[length];
        }
    }

}
