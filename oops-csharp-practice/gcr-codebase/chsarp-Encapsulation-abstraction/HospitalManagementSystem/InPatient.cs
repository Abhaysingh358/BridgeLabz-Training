using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.HospitalManagementSystem
{
    internal class InPatient:Patient
    {
        public int roomNo;
        public int DaysAdmitted;

        public InPatient(string name, int age, long ID, int roomNo, int DaysAdmitted) : base(name, age, ID)
        {
            this.roomNo = roomNo;
            this.DaysAdmitted = DaysAdmitted;
        }

        public override void Display()
        {
            Console.WriteLine("Patient name:" +name);
            Console.WriteLine("Patient age: " + age);
            Console.WriteLine("Patient Id: " + ID);
            Console.WriteLine("Room Number: " + roomNo);
            Console.WriteLine("Days Admitted: " + DaysAdmitted);
        }

        public override double CalculateBill()
        {
            double roomChargePerDay = 500.0;
            return roomChargePerDay * DaysAdmitted;
        }
    }
}
