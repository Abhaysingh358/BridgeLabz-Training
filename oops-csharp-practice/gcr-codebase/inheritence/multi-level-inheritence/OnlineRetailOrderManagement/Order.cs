using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.inheritence.Multilevel_Inheritance.OnlineRetailOrderManagement
{
    internal class Order
    {
        // attributes
        protected int OrderId;
        protected string OrderDate;

        // parametrized constructor
        public Order(int orderId, string orderDate)
        {
            this.OrderId = orderId;
            this.OrderDate = orderDate;
        }

        // string override method
        public override string ToString()
        {
            return $"Order ID : {OrderId} , Order Date : {OrderDate}";
        }
    }
}
