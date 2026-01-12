using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.linear_and_binary_search.RemoveDuplicates
{
    internal class RemoveDuplicates
    {
        public void RemoveDuplicate() {
            Console.WriteLine("Enter the String");
            string s = Console.ReadLine();

            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("String is Empty"); return;
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(s[0]);
            for(int i = 1; i < s.Length; i++)
            {
                if (!sb.ToString().Contains(s[i]))
                {
                    sb.Append(s[i]);
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
