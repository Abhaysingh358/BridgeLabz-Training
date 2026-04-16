using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level02
{
    internal class ReverseString
    {
        public static string ToReverse(string s)
        {
            //checking for null or empty string
                if (string.IsNullOrEmpty(s))
                    {
                        return s;
                    }

                char[] ch = new char[s.Length];
                int left = 0;
                int right = s.Length - 1;
            
            //using while loop to reverse the string
                while (left <= right)
                {
                    ch[left] = s[right];
                    ch[right] = s[left];
                    left++;
                    right--;
                }

            // we can also use Array.Reverse method to reverse char array instead of using while loop 
       
            return new string(ch);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string s = Console.ReadLine();

            // Call the method to reverse the string and display the result
            Console.WriteLine("Reversed String: " + ToReverse(s));
        }
    }
}
