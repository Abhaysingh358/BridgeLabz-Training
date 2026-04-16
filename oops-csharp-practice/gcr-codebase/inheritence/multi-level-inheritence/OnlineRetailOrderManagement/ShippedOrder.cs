using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.inheritence.Multilevel_Inheritance.OnlineRetailOrderManagement
{
    // sub class of order class
    internal class ShippedOrder : Order
    {
        // attribute
        protected string TrackingNumber;

        // parametrized constructor
        public ShippedOrder(int orderId, string orderDate, string trackingNumber)
            : base(orderId, orderDate)
        {
            this.TrackingNumber = trackingNumber;
        }

        // string override method
        public override string ToString()
        {
            return base.ToString() + $" , Tracking Number : {TrackingNumber}";
        }
    }
}
