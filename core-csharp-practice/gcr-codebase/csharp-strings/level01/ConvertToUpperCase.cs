using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level01
{
    internal class ConvertToUpperCase
    {
        public static string ToUpperCase(string s)
        {
            char[] ch = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                ch[i] = char.ToUpper(s[i]);
            }

            string UpperCase = new string(ch);
            return UpperCase;
        }
        static void Main(string[] args)
        {
            // Displaying demo title
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();

            if (s == null)
            {
                Console.WriteLine("Input string is null.");
                return;
            }
            else
            {
                string upper = s.ToUpper();
                if (upper == ToUpperCase(s))
                {
                    Console.WriteLine("Both methods give the same result.");
                }
                else
                {
                    Console.WriteLine("Methods give different results.");
                }
                Console.WriteLine(ToUpperCase(s));
            }
        }
    }
}

