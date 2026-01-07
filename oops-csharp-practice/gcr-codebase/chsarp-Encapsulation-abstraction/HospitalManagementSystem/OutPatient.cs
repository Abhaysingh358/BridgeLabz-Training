using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.HospitalManagementSystem
{
    internal class OutPatient: Patient
    {
        public string Date;
        public int fee;

        public OutPatient(string name, int age, long ID, string Date, int fee) : base(name, age, ID)
        {
            this.Date = Date;
            this.fee = fee;
        }

        public override void Display()
        {
            Console.WriteLine("Patient name: " + name);
            Console.WriteLine("Patient age: " + age);
            Console.WriteLine("Patient Id: " + ID);
            Console.WriteLine("Appointment Date: " + Date);
            Console.WriteLine("Consultation Fee: " + fee);
        }

        public override double CalculateBill()
        {
            return fee;
        }
    }
}
