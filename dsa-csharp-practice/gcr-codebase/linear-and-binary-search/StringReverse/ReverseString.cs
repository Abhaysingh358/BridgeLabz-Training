using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.StringReverse.linear_and_binary_search
{
    internal class ReverseString
    {
        
        void Reverse()
        {
            Console.WriteLine("Enter the string");

            string s = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = s.Length-1; i >=0; i--)
            {
                sb.Append(s[i]);
            }

            Console.WriteLine(sb.ToString());
        }

        static void Main(string[] args) 
        {
            ReverseString reverse = new ReverseString();
            reverse.Reverse();
        }
    }

    
}
