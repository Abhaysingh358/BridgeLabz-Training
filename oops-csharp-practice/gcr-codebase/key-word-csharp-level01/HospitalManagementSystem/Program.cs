using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.key_word_csharp_level01.HospitalManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient p1 = new Patient(1, "Abhay Singh", 22, "Fever");
            Patient p2 = new Patient(2, "Ravi Kumar", 30, "Cold");

            // using is operator before displaying
            if (p1 is Patient)
            {
                p1.Display();
            }

            if (p2 is Patient)
            {
                p2.Display();
            }

            

            Patient.GetTotalPatients();
        }
    }
}
