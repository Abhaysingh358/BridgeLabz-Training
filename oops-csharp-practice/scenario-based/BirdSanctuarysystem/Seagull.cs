using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.BirdSanctuarysystem
{
    internal class Seagull : Bird ,IFlyable ,ISwimmable
    {
        public Seagull(string name ,bool Injured ,double size ,string date)
        : base(name,Injured,size,date)
        { }

        public bool Fly() { return true; }
        public bool Swim() { return true; }

        public override string ToString()
        {
            return base.ToString() + $", Seagull can Fly : {Fly()} , and Swim also : {Swim()}";
        }
    }
}
