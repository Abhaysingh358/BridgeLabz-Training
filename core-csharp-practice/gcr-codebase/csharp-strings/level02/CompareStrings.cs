using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level02
{
    internal class CompareStrings
    {

        // method to find minimum of two integers
        public static int Min(int a, int b)
        {
            return (a < b) ? a : b;
        }

        public static int  CompareLexicographically(string s1, string s2)
        {
          int len1 = s1.Length;
          int len2 = s2.Length;
          int minLen = Min(len1, len2);
          for(int i =0; i< minLen; i++)
            {
                if (s1[i] < s2[i])
                {
                    return -1; //  s1 comes before s2
                }
                else if (s1[i] > s2[i])
                {
                    return 1; // s2 comes before s1
                }
            }

            if (len1 < len2)
            {
                return -1; // shorter word comes first
            }


            else if (len1 > len2)
            {
                return 1; // longer word comes after
            }

            else
            {
                return 0; // both are equal
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string:");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter second string:");
            string s2 = Console.ReadLine();

            int result = CompareLexicographically(s1, s2);

            if (result == 0)
            {
                Console.WriteLine("Both strings are equal.");
            }
            else if (result < 0)
            {
                Console.WriteLine($"\"{s1}\" comes before \"{s2}\" lexicographically.");
            }
            else
            {
                Console.WriteLine($"\"{s2}\" comes before \"{s1}\" lexicographically.");
            }
        }
    }
}
