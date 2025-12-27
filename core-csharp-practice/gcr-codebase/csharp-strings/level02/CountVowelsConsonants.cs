using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level02
{
    internal class CountVowelsConsonants
    {
        public static int[] CountVowelsAndConsonants(string s)
        {
            if (s == null)
            {
                return new int[] { };

            }

            int vowelCnt = 0;
            int consonantCnt = 0;
            s = s.Trim().ToLower();

            foreach (char c in s)
            {
                // Check if character is an alphabet
                if ((c >= 'a' && c <= 'z'))
                {
                    // Check if character is a vowel
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        vowelCnt++;
                    }
                    // Else it is a consonant
                    else
                    {
                        consonantCnt++;
                    }
                }
            }
            return new int[] { vowelCnt, consonantCnt };

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string s = Console.ReadLine();


            // Call the method to count vowels and consonants
            int[] result = CountVowelsAndConsonants(s);
            if (result.Length == 0)
            {
                Console.WriteLine("Input string is null.");
            }
            // Display the results
            else
            {
                Console.WriteLine("Number of Vowels : "+ result[0]);
                Console.WriteLine("Number of Consonants : " + result[1]);
              
            }
        }
    }
}
