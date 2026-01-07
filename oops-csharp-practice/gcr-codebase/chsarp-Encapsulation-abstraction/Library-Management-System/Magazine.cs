using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.Library_Management_System
{
    internal class Magazine : LibraryItem, IReservable
    {
        private bool isAvailable = true;

        public override int GetLoanDuration()
        {
            return 7;
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
                Console.WriteLine("Magazine Reserved");
            }
            else
            {
                Console.WriteLine("Magazine Not Available");
            }
        }
    }
}
