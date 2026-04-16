using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace BridgeLabz.gcr_codebase.DSA.scenario_based.TrafficManager
{

    /// <summary>
    /// Create QueueNode and store:

    ///Vehicle data

    //QueueNode next

    //Because:

    //Vehicle holds all real vehicle details (number/type/time)

    //QueueNode just acts as a wrapper node for linking
    /// </summary>
   

    internal class QueueNode
    {
        public Vehicle data;
        public QueueNode Next;

       
        public QueueNode(Vehicle data)
        {
            this.data = data;
            this.Next = null;
        }

       
    }
}
