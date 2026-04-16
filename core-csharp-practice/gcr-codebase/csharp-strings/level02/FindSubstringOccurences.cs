using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level02
{
    internal class FindSubstringOccurences
    {
        public static int CountSubstring(string str, string subStr)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(subStr))
            {
                return 0;
            }


            int cnt = 0; // count occurrences

            int limit = str.Length - subStr.Length;

            for (int i = 0; i <= limit; i++)
            {
                // Assume a match is found
                bool isMatch = true;

                // Compare each character of subStr
                for (int j = 0; j < subStr.Length; j++)
                {
                    // If any character doesn't match, set isMatch to false and break
                    if (str[i + j] != subStr[j])
                    {
                        isMatch = false;
                        break;
                    }
                }

                if (isMatch)
                {
                    cnt++;
                }
            }

            return cnt;
        }

        
        // we can also use indexOf method to find the occurrences of substring in main string

        public static int CountOccurrencesIndexOf(string str, string sub)
        {
            int count = 0;
            int index = 0;

            while ((index = str.IndexOf(sub, index)) != -1)
            {
                count++;
                index += 1;
            }

            return count;
        }

        // we can also use split method to find the occurrences of substring in main string

        public static int CountOccurrencesSplit(string str, string sub)
        {
            if (string.IsNullOrEmpty(sub))
                return 0;

            string[] parts = str.Split(new string[] { sub }, StringSplitOptions.None);
            return parts.Length - 1;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the main string:");
            string str = Console.ReadLine();

            Console.WriteLine("Enter the substring to find:");
            string subStr = Console.ReadLine();

            // Call the method to count substring occurrences
            int result = CountSubstring(str, subStr);

            // Display the result
            Console.WriteLine($"The substring '{subStr}' occurs {result} times in the main string.");

            Console.WriteLine("\nUsing IndexOf method:");
            int resultIndexOf = CountOccurrencesIndexOf(str, subStr);
            Console.WriteLine($"The substring '{subStr}' occurs {resultIndexOf} times in the main string.");

            Console.WriteLine("\nUsing Split method:");
            int resultSplit = CountOccurrencesSplit(str, subStr);
            Console.WriteLine($"The substring '{subStr}' occurs {resultSplit} times in the main string.");

        }
    }
}
