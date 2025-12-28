using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.extras_csharp_strings.level01
{
    internal class PalindromeChecker
    {
        public static string IsPalindrome(string s)
        {
            s = s.Replace(" ", "").ToLower();
            char[] ch = s.ToCharArray();
            int left = 0;
            int right = ch.Length - 1;

            // string is divided in two parts and each character from start is compared with
            // each character from end
            while (left < right)
            {
                if (ch[left] != ch[right])
                {
                    return $"String is not palindrome";
                }
                left++;
                right--;
            }
            string palindrome = new string(ch);
            return $"String is palindrom : {palindrome}";

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check if it is a palindrome:");
            string inputStr = Console.ReadLine();

            // calling the method to check if the string is a palindrome
            string result = IsPalindrome(inputStr);
            Console.WriteLine(result);
        }
    }
}
