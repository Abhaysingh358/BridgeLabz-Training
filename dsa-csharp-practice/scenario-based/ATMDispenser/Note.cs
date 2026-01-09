using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.ATMDispenser
{
    public class Note
    {
        private int Denomination;
        
        private int Count;
        // Denomination = value written in the currency , and we are using indian currency


        // using getters and setters
        public int GetDenomination()
        {
            return Denomination;
        }

        public void SetDenomination(int denomination)
        {
            this.Denomination = denomination;
        }

        public int GetCount()
        {
            return Count;
        }

        public void SetCount(int count)
        {
            this.Count = count;
        }
    }
}
