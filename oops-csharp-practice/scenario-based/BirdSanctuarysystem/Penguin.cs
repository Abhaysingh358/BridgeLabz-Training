using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.BirdSanctuarysystem
{
    internal class Penguin : Bird , ISwimmable
    {
        public Penguin(string name ,bool injured , double size ,string date)
            : base(name , injured , size , date) { }

        public bool Swim() {  return true; }

        public override string ToString()
        {
            return base.ToString() + $", Penguin can Swims : {Swim()}";
        }
    }
}
