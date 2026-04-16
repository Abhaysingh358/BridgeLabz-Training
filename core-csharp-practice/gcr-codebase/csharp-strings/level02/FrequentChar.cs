using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level02
{
    internal class FrequentChar
    {
        public static char MostFrequent(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return ' ';
            }

            int[] fq = new int[256]; // ASCII character set size
            int maxFreq = 0;

            for(int i = 0; i < s.Length; i++)
            {
                fq[s[i]]++; // count frequency of ascii numbers
            }

            int maxfq = 0;
            char ch = ' ';

            for(int i = 0; i < fq.Length; i++)
            {
                if(fq[i] > maxfq) // finding maximum frequency
                {
                    maxfq = fq[i]; // updating maximum frequency
                    ch = (char)i; // converting ascii number to character
                }
            }
            return ch;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string s = Console.ReadLine();

            char result = MostFrequent(s);
            Console.WriteLine($"Most Frequent Character in \"{s}\" is : {result}");
            
        }
    }
}
