using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.linear_and_binary_search.ContenateString
{
    internal class Concatenate
    {
        public void ConcatenateString()
        {
            Console.WriteLine("Enter the size of the array");
            int size = int.Parse(Console.ReadLine());

            string[] s = new string[size];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = Console.ReadLine();
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; ++i)
            {
                sb.Append(s[i]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
