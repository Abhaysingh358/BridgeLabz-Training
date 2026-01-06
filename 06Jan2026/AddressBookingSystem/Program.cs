using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.review.AddressBookingSystem
{
    class Program
    {
        static void Main()
        {
            Utility u = new Utility(20);
            Menu menu = new Menu(u);
            menu.Start();
        }
    }

}
