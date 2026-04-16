using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.Library_Management_System
{
    internal class Book : LibraryItem, IReservable
    {
        private bool isAvailable = true; // availability flag

        public override int GetLoanDuration()
        {
            return 14; // days
        }

        public bool CheckAvailability()
        {
            return isAvailable;
        }

        public void ReserveItem()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine("Book Reserved");
            }
            else
            {
                Console.WriteLine("Book Not Available");
            }
        }
    }

}
