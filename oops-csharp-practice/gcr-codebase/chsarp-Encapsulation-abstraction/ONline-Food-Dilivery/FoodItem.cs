using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.ONline_Food_Dilivery
{
    internal abstract class FoodItem
    {
        // basic food details
        private string itemName;
        private double price;
        private int quantity;

        public string ItemName { get { return itemName; } }
        public double Price { get { return price; } }
        public int Quantity { get { return quantity; } }

        // setters for encapsulation
        public void SetItemName(string name) { itemName = name; }
        public void SetPrice(double p) { price = p; }
        public void SetQuantity(int q) { quantity = q; }

        // common method
        public void GetItemDetails()
        {
            Console.WriteLine(itemName + " Qty:" + quantity);
        }

        // implemented differently
        public abstract double CalculateTotalPrice();
    }
}
