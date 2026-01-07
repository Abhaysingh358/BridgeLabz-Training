using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.E_Commerce
{
    internal class Clothing : Product, ITaxable
    {
        public override double CalculateDiscount()
        {
            return Price * 0.20;
        }

        public double CalculateTax()
        {
            return Price * 0.12;
        }

        public string GetTaxDetails()
        {
            return "GST 12%";
        }
    }
}
