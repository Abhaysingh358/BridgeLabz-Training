using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.ParcelTracker
{
    internal class CheckPointNode
    {
        public string StageName { get; set;}
        public DateTime StageTime { get; set;} 
        public CheckPointNode Next { get; set; }

        public CheckPointNode(string stageName)
        {
            this.StageName = stageName;
            this.StageTime = DateTime.Now;
            this.Next = null;
        }


    }
}
