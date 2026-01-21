using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.EduResults
{
    internal class StudentNode
    {
        public Student data { get; set; }
        public StudentNode next { get; set; }

        public StudentNode(Student student)
        {
            this.data = student;
            this.next = null;
        }
    }
}
