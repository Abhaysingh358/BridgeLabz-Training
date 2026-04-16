using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabz.dbms_csharp_practice.scenario_based.AddressBookSystem
{
    public static class ValidationUtility
    {
        public static bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^[A-Za-z]{2,}$");
        }

        public static bool IsValidPhoneNumber(string phone)
        {
            return Regex.IsMatch(phone, "^[6-9][0-9]{9}$");
        }

        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool IsValidZip(string zip)
        {
            return Regex.IsMatch(zip, "^[0-9]{6}$");
        }
    }
}
