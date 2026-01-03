using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.constructors_level01.OnlineCourseManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course c1 = new Course();
           

            c1.Display();

            Course.ChangeInstituteName();

            c1.Display();
           

        }
    }
}
