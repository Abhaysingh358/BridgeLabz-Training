using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.Exceptions
{
    class ExceptionPropagation
    {
        static void Method1()
        {
            Console.WriteLine("Inside Method1()");
            int result = 10 / 0; // Exception occurs here
            Console.WriteLine("This line will NOT execute");
        }

        static void Method2()
        {
            Console.WriteLine("Inside Method2()");
            Method1();
            Console.WriteLine("This line will NOT execute");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Inside Main()");

            try
            {
                Method2();
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Handled exception in Main");
            }

            Console.WriteLine("Program ended normally");
        }
    }

}
