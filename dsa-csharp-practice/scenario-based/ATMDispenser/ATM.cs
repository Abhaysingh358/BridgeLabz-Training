using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.ATMDispenser
{ 
    public class ATM
    {
        // creating object of dispenser class
        private Dispenser dispenser = new Dispenser();

        //making scenario one method 
        public void WithdrawWithAllNotes()
        {
            Withdraw(new int[] { 500, 200, 100, 50, 20, 10, 5, 2, 1 });
        }

        // for Scenario 2
        public void WithdrawWithout500Note()
        {
            Withdraw(new int[] { 200, 100, 50, 20, 10, 5, 2, 1 });
        }

        // for Scenario 3
        public void WithdrawWithFallback()
        {
            Withdraw(new int[] { 100, 50 });
        }

        // creating withdraw method to wihdraw money
        private void Withdraw(int[] denominations)
        {
            Console.Write("Enter amount: ");
            int amount = int.Parse(Console.ReadLine());


            Note[] notes = CreateNotes(denominations);

            dispenser.DispenseCash(amount, notes);
            Display(notes);
        }

        // this method takes denomination and make notes object
        private Note[] CreateNotes(int[] denominations)
        {
            Note[] notes = new Note[denominations.Length];

            for (int i = 0; i < denominations.Length; i++)
            {
                notes[i] = new Note();
                notes[i].SetDenomination(denominations[i]);
            }

            return notes;
        }

        private void Display(Note[] notes)
        {
            Console.WriteLine("Dispensed Notes:");

            bool any = false;

            for (int i = 0; i < notes.Length; i++)
            {
                if (notes[i].GetCount() > 0)
                {
                    Console.WriteLine($"{notes[i].GetDenomination()}rs. x {notes[i].GetCount()}");
                    any = true;
                }
            }

            if (!any)
            {
                Console.WriteLine("No notes dispensed.");
            }
        }
    }

}
