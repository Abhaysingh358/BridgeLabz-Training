using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.constructors_level01.Person.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Abhay", 22);
            Person p2 = new Person(p1);   // using copy constructor

            p1.Display();
            p2.Display();

        }
    }
}
