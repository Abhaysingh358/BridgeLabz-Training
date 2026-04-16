using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.BirdSanctuarysystem
{
    internal class Bird
    {
        private string name;
        private bool Injured;
        private double size;
        private string date;

        public Bird(string name, bool injured, double size, string date)
        {
            this.name = name;
            Injured = injured;
            this.size = size;
            this.date = date;
        }

        public override string ToString()
        {
            return $"Bird : {name} , Injured : {Injured} , Size : {size}, Date : {date}";
        }
    }
}
