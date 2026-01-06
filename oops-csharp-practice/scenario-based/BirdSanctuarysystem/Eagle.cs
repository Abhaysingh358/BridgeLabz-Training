using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.BirdSanctuarysystem
{
    internal class Eagle : Bird  , IFlyable
    {
        public Eagle(string name, bool injured, double size, string date)
            : base(name, injured, size, date)
        {
        }
        
        public bool Fly()
        {
            return true;
        }

        public override string ToString()
        {
            return base.ToString() + $", Eagle Flies : {Fly()}";
        }
    }
}
