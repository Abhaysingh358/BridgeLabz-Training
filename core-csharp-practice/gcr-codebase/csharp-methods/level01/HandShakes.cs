using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level01
{
    internal class HandShakes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of people : ");
            int num = int.Parse(Console.ReadLine());

            HandShakes hs = new HandShakes();

            Console.WriteLine("The total number of handshakes possible is : " + hs.handshakes(num));
        }

        public int handshakes(int n)
        {
            int result = (n * (n - 1)) / 2;
            return result;
        }
    }
}
