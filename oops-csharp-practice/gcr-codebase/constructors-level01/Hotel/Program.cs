using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.constructors_level01.Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using default constructor (input)
            HotelBooking b1 = new HotelBooking();
            b1.Display();

            // Using parameterized constructor
            HotelBooking b2 = new HotelBooking("Abhay Singh", "Deluxe", 3);
            b2.Display();

            // Using copy constructor
            HotelBooking b3 = new HotelBooking(b2);
            b3.Display();
        }
    }
}
