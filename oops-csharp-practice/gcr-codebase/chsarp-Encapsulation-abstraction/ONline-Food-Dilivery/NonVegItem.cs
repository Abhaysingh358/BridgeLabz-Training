using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.ONline_Food_Dilivery
{
    internal class NonVegItem : FoodItem, IDiscountable
    {
        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) + 50; // extra charge
        }

        public double ApplyDiscount()
        {
            return CalculateTotalPrice() * 0.05;
        }

        public string GetDiscountDetails()
        {
            return "Non-Veg Discount 5%";
        }
    }
}
