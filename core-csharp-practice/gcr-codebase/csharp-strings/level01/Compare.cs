//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level01
//{
//    internal class Compare
//    {
//        public static bool IsEqual(string str1, string str2)
//            {
//            // comparing length of the strings
//            if(str1.Length != str2.Length)
//                {
//                    return false;
//                }

//            //Cheking character by charcater
//            //int c sharp we use string[i] to check character in place of charAt()
//            for (int i = 0; i < str1.Length ; i++)
//                {
//                    if (str1[i] != str2[i])
//                    {
//                        return false;
//                    }
//                }
//                return true;
//        }
//        static void Main(string[] args)
//        {
//            // taking input of both strings
//            Console.WriteLine("Enter the String 1 ");
//            String s1 = Console.ReadLine();

//            Console.WriteLine("Enter the String 2 ");
//            String s2 = Console.ReadLine(); 

//            // displaying the results
//            Console.WriteLine(" Are the Strings equal ? : " + IsEqual(s1,s2));
//        }
//    }
//}
