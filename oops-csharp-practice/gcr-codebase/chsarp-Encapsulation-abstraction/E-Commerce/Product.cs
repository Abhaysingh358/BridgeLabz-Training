using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.E_Commerce
{
    internal abstract class Product
    {
        private int productId;
        private string name;
        private double price;

        public int ProductId { get { return productId; } }
        public string Name { get { return name; } }
        public double Price { get { return price; } }

        public void SetProductId(int id) { productId = id; }
        public void SetName(string n) { name = n; }
        public void SetPrice(double p) { price = p; }

        public abstract double CalculateDiscount();
    }
}
