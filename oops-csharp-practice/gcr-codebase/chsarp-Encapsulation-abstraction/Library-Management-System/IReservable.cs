using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.Library_Management_System
{
    internal interface IReservable
    {
        void ReserveItem();
        bool CheckAvailability();
    }
}
