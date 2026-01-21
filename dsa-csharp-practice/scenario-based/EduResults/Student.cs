using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.EduResults
{
    internal class Student
    {
        public int _rollNumber { get; set; }
        public string _name { get; set; }
        public double _marks { get; set; }

        public void SetMarks(double marks)
        {
            if(marks >= 0 && marks <=100)
            {
                _marks = marks; 
            }
        }

    }
}
