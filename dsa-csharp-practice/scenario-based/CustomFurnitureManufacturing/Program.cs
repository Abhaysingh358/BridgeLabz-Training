using BridgeLabz.gcr_codebase.DSA.scenario_based.CustomFurnitureManufacturing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgeLabz.gcr_codebase.DSA.scenario_based.CustomFurnitureManufacturing
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Rod rod = new Rod(12);

            // price[i] = price of rod piece length i (index 0 is dummy)
            int[] prices = { 0, 2, 5, 7, 8, 10, 17, 17, 20, 24, 30, 32, 35 };

            PriceCatalog catalog = new PriceCatalog(prices);

            Menu menu = new Menu();
            menu.Show(rod, catalog);
        }
    }
}
