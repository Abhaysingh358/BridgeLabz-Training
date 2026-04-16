using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.ResumeScreening
{
    internal class DataScientist : JobRole
    {
        public DataScientist(string name, int experience)
            : base(name, experience) { }

        public override void Evaluate()
        {
            Console.WriteLine($"{CandidateName} | Data Scientist | Experience: {Experience} years");
        }
    }
}
