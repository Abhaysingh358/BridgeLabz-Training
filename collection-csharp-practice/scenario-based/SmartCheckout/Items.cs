using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.scenario_based.SmartCheckout
{
    public class Items
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Items(string itemName, double price, int stock)
        {
            ItemName = itemName;
            Price = price;
            Stock = stock;
        }
    }

}

