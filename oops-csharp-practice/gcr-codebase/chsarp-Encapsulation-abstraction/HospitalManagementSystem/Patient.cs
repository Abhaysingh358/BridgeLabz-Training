using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.HospitalManagementSystem
{
    abstract class Patient:IPlayable
    {
        public string name;
        public int age;
        public long ID;

        protected Patient(string name, int age, long ID)
        {
            this.name = name;
            this.age = age;
            this.ID = ID;
        }

        public abstract void Display();
        public abstract double CalculateBill();
    }
}
