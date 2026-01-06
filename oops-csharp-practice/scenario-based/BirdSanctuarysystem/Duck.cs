using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.BirdSanctuarysystem
{
    internal class Duck : Bird , ISwimmable
    {
        public Duck(string name ,bool Injured ,double size , string date  )
            : base(name, Injured , size , date)
        {

        }

        public bool Swim() { return true; }

        public override string ToString()
        {
            return base.ToString() + $", Duck Swimes : {Swim()}";
        } 
    }
}
