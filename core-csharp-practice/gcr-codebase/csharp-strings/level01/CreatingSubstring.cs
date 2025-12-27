using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level01
{
    internal class CreatingSubstring
    {
        public static string SubString(string s , int startidx , int endidx)
        {
            // method to create substring
            if (startidx >=0 && endidx <= s.Length) {
                return s.Substring(startidx, endidx);
            }
            else
            {
                return "start index and end index shoul be in range";
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string s = Console.ReadLine();

            Console.WriteLine("enter the start index");
            int startidx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the end index");
            int endidx = Convert.ToInt32(Console.ReadLine());

            // calling substring method
            string sub = SubString(s, startidx, endidx);
            Console.WriteLine(sub);
        }
    }
}
