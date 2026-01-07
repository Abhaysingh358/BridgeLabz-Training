using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.E_Commerce
{
    internal interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
    }
}
