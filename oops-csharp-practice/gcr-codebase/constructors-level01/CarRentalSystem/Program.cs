using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.constructors_level01.CarRentalSystem
{
    internal class Program
    {


        static void Main(string[] args)
        {
            CarRental c = new CarRental();
            c.Input();
            c.Display();

            CarRental c2 = new CarRental("Abhay Singh", "SUV", 4);  // Using parameterized constructor
            c2.Display();
        }
    }
}

