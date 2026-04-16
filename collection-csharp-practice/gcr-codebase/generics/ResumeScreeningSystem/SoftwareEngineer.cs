using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.ResumeScreening
{
    internal class SoftwareEngineer : JobRole
    {
        public SoftwareEngineer(string name, int experience)
            : base(name, experience) { }

        public override void Evaluate()
        {
            Console.WriteLine($"{CandidateName} : Software Engineer , Experience: {Experience} years");
        }
    }
}
