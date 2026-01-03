using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.oops_csharp_practice.class_and_objects_level01.EmployeeDetails

{
   internal class MainProgram
   {
       static void Main(string[] args)
       {
           Employee employee = new Employee();
           employee.Input();
           employee.Display();
       }
   }
}
