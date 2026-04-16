using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level02
{
    internal class CheckAnagrams
    {

        // A simple approach using sorting but it will take O(n log n) time complexity
        public static bool isAnaagrams(string s1 , string s2)
        {
            if(s1 == null || s2 == null)
                return false;

            // if lengths are not equal then they cannot be anagrams
            if (s1.Length != s2.Length)
            {
                return false;
            }
            // convert strings to char array and sort them
            char[] charArray1 = s1.ToCharArray();
            char[] charArray2 = s2.ToCharArray();

            Array.Sort(charArray1);
            Array.Sort(charArray2);

            // compare sorted char arrays
            for (int i = 0; i < charArray1.Length; i++)
            {
                if (charArray1[i] != charArray2[i])
                {
                    return false;
                }
            }
            return true;
        }

        // An optimized approach using frequency counting with O(n) time complexity
        public static bool IsAnagramFrequency(string s1 , string s2)
        {
            if (s1 == null || s2 == null)
                return false;
            
            s1 = s1.ToLower().Replace(" " , "");
            s2 = s2.ToLower().Replace(" " , "");

            if (s1.Length != s2.Length)
                return false;

            int[] freq = new int[256]; // assuming ASCII character set

            // count frequency of each character in both strings
            for (int i = 0; i < s1.Length; i++)
            {
                freq[s1[i]]++;
                freq[s2[i]]--; 
            }

            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] != 0) // if frequency is not zero then they are not anagrams
                    return false;
            }

            return true;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string:");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter the second string:");
            string s2 = Console.ReadLine();

            // Call both methods to check for anagrams and display the results
            bool result1 = isAnaagrams(s1, s2);
            Console.WriteLine($"Are \"{s1}\" and \"{s2}\" anagrams (using sorting)? : {result1}");

            bool result2 = IsAnagramFrequency(s1, s2);
            Console.WriteLine($"Are \"{s1}\" and \"{s2}\" anagrams (using frequency counting)? : {result2}");
        }
    }
}
