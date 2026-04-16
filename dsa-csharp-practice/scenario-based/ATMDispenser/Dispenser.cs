using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.ATMDispenser
{ 

    // using dispenser where the main logic will have written
    public class Dispenser
    {
        public void DispenseCash(int amount, Note[] notes)
        {
            int remaining = amount;

            for (int i = 0; i < notes.Length; i++)
            {
                notes[i].SetCount(0);
                int value = notes[i].GetDenomination();

                if (remaining >= value)
                {
                    int count = remaining / value;
                    remaining %= value;
                    notes[i].SetCount(count);
                }
            }

            if (remaining != 0)
            {
                Console.WriteLine($"Exact change not possible. Remaining amount: {remaining}rs.");
            }
        }
    }

}
