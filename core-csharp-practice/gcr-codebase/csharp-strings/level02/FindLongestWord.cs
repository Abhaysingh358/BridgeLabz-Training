using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level02
{
    internal class FindLongestWord
    {
        public static  string LongestWord(string s)
        {
            // checking for null or empty string
            if (string.IsNullOrWhiteSpace(s))
            {
                return "";
            }

            // it will split the word by space and store it in words array
            string[] words = s.Split(' ');
            string longestWord = "";

            foreach (string word in words)
            {
                // if length of current word is greater than longestWord then update longestWord
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            return longestWord;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string s = Console.ReadLine();


            // Call the method to find the longest word
            string result = LongestWord(s);


            // Display the result
            if (string.IsNullOrEmpty(result))
            {
                Console.WriteLine("No words found in the input string.");
            }
            else
            {
                Console.WriteLine("The longest word is: " + result);
            }
        }
    }
}
