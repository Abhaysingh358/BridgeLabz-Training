using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.E_Commerce
{
    internal class Groceries: Product
    {
        public override double CalculateDiscount()
    {
        return Price * 0.05;
    }
}
}
