using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level02
{
    internal class RemoveDuplicatesFromString
    {
        public static string RemoveDuplicates(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            StringBuilder result = new StringBuilder();



            // Add the first character to the result
            // This ensures that we always have at least one character in the result

            for (int i = 1; i < s.Length; i++)
            {
                if (!result.ToString().Contains(s[i]))
                {
                    result.Append(s[i]);
                }
                else
                {
                    continue;
                }
            }

            return result.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string s = Console.ReadLine();

            // this will Call the method to remove duplicates and display the result
            string result = RemoveDuplicates(s);
            Console.WriteLine("String after removing duplicates: " + result);
        }
    }
}
