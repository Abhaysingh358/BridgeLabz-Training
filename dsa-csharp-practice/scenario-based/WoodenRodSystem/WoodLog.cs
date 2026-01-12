using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.WoodenRodSystem
{
    internal class WoodLog
    {
        public int Size { get; set; }     
        public int Price { get; set; }

        public WoodLog(int size, int price)
        {
            Size = size;
            Price = price;
        }
    }
}
