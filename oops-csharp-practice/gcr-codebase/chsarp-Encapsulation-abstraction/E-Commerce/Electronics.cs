using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.E_Commerce
{
    internal class Electronics : Product, ITaxable
    {
        public override double CalculateDiscount()
        {
            return Price * 0.10;
        }

        public double CalculateTax()
        {
            return Price * 0.18;
        }

        public string GetTaxDetails()
        {
            return "GST 18%";
        }
    }
}
