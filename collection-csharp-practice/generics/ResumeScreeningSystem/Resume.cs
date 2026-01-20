using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.ResumeScreening
{
    internal class Resume<T> where T : JobRole
    {
        private List<T> candidates = new List<T>();

        public void AddCandidate(T candidate)
        {
            candidates.Add(candidate);
        }

        public void ScreenCandidates()
        {
            Console.WriteLine("\n<=======Screening Results======>");
            foreach (T candidate in candidates)
            {
                candidate.Evaluate();
            }
        }
    }
}
