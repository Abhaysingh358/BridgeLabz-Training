using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.BirdSanctuarysystem
{
    internal class Sparrow : Bird , IFlyable
    {
        public Sparrow(string name, bool injured, double size, string date) 
            : base(name, injured, size, date)
        {
        }

        public bool Fly()
        {
            return true;
        }

        public override string ToString()
        {
            return base.ToString() + $", Sparrow Flies : {Fly()}";
        }
    }
}
