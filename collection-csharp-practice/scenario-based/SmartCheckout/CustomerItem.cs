using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.scenario_based.SmartCheckout
{
    public class CustomerItem
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }

        public CustomerItem(string itemName, int quantity)
        {
            ItemName = itemName;
            Quantity = quantity;
        }
    }

}
