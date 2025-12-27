using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level02
{
    internal class RemoveSpecificCharacter
    {
        public static string RemoveCharacter(string s, char ch)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            // using string builder to add the result in string format
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                // checking if the character is not equal to the specific character
                if (s[i] != ch)
                {
                    // adding the character to the string builder
                    sb.Append(s[i]);
                }
            }
            // returning the string builder as string
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string s = Console.ReadLine();

            Console.WriteLine("Enter the character to be removed:");
            char ch = Console.ReadLine()[0];

            // Call the method to remove specific character and display the result
            string result = RemoveCharacter(s, ch);
            Console.WriteLine("String after removing '" + ch + "': " + result);
        }

    }
}
