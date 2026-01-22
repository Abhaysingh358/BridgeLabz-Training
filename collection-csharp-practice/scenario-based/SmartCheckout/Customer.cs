using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.scenario_based.SmartCheckout
{

    public class Customer
    {
        public int CustomerId { get; set; }
        public List<CustomerItem> Items { get; set; }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            Items = new List<CustomerItem>(); // ready to store items
        }

        public void AddItem(string itemName, int quantity)
        {
            Items.Add(new CustomerItem(itemName, quantity));
        }
    }

}
