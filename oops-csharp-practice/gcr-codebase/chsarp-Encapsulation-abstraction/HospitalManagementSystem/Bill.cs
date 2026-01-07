using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.HospitalManagementSystem
{
    internal class Bill
    {
        public static void GenerateBill(Patient patient)
        {
            patient.Display();
            double totalBill = patient.CalculateBill();
            Console.WriteLine("Total Billable Amount " + totalBill);
        }
    }
}
