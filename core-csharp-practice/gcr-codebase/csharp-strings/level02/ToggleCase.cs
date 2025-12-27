using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level02
{
    internal class ToggleCase
    {
        public static string ToggleAscii(string s)
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(s))
            {
                return "";
            }

            for(int i = 0; i< s.Length; i++)
            {
                //below code convert lowercase to uppercase
                if (s[i] >= 'a' && s[i] <= 'z')
                { 
                    sb.Append( (char)(s[i] - 32));
                }

                
                //below code convert uppercase to lowercase


                if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    sb.Append((char)(s[i] +32));
                }
                
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string s = Console.ReadLine();
            // Call the method to toggle case and display the result

            string result = ToggleAscii(s);
            Console.WriteLine("Toggled Case String: " + result);
        }
    }
}
