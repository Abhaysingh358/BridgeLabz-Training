using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabz.ioprogramming_csharp_practice.scenario_based.AddressBookSystem
{
    public static class ValidationUtility
    {
       
         // Validate First Name / Last Name (only alphabets, min 2 chars)
        public static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            return Regex.IsMatch(name , @"^[A-Za-z]{2,}$");
        }

        // Validating indial format phone number (10 digits)
        public static bool IsValidPhoneNumber(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            return Regex.IsMatch(phone, "^[6-9][0-9]{9}$");
        }

        // Validate Email
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        // Validate Zip / Pincode (6 digits)
        public static bool IsValidZip(string zip)
        {
            if (string.IsNullOrWhiteSpace(zip))
                return false;

            return Regex.IsMatch(zip, "^[0-9]{6}$");
        }
    }
}
