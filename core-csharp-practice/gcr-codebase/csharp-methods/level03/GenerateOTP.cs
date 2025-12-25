using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 


namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level03
{
    internal class GenerateOTP
    {
        //  Method to generate 6-digit OTP
        public static int OTP()
        {
            Random r = new Random();
            return r.Next(100000, 1000000); // this will generate 6-digit number
        }

        //  Method to check if all OTPs are unique
        public static bool IsUnique(int[] otp)
        {
            for (int i = 0; i < otp.Length; i++)
            {
                for (int j = i + 1; j < otp.Length; j++)
                {
                    if (otp[i] == otp[j])
                    {
                        return false;     
                    }
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int[] otps = new int[10];

            // Generate  OTPs and store them in array
            for (int i = 0; i < otps.Length; i++)
            {
                otps[i] = OTP();
            }

            Console.WriteLine("Generated OTPs:");
            for (int i = 0; i < otps.Length; i++)
            {
                Console.WriteLine("OTP " + (i + 1) + " : " + otps[i]);
            }

            // Check uniqueness
            bool unique = IsUnique(otps);

            Console.WriteLine("\n Are all OTPs Unique  ?  : " + unique);
        }
    }
}

