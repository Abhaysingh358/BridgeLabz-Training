using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.ONline_Food_Dilivery
{
    internal class VegItem : FoodItem, IDiscountable
    {
        public override double CalculateTotalPrice()
        {
            return Price * Quantity;
        }

        public double ApplyDiscount()
        {
            return CalculateTotalPrice() * 0.10;
        }

        public string GetDiscountDetails()
        {
            return "Veg Discount 10%";
        }
    }
}
