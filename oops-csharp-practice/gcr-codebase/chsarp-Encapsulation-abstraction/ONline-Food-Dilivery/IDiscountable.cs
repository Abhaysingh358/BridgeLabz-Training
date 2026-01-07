using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.ONline_Food_Dilivery
{
    internal interface IDiscountable
    {
        double ApplyDiscount();
        string GetDiscountDetails();
    }
}
