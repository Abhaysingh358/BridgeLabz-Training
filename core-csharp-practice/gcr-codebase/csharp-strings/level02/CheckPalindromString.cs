using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level02
{
    internal class CheckPalindromString
    {
        public static bool IsPalindrome(string s)
        {
            if (s == null)
            {
                return false;
            }
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string s = Console.ReadLine();
            if (s == null)
            {
                Console.WriteLine("Input string is null.");
                return;
            }

            // Call the method to check if the string is a palindrome
            bool result = IsPalindrome(s);

            // Display the result
            if (result)
            {
                Console.WriteLine($"\"{s}\" is a palindrome."); 
                // using escaped quotes to display quotes around the string
            }
            else
            {
                Console.WriteLine($"\"{s}\" is not a palindrome.");
            }
        }
    }
}
