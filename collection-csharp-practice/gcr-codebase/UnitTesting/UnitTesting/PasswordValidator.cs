using System.Text.RegularExpressions;

namespace UnitTesting
{
    public class PasswordValidator
    {
        public bool IsValid(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            if (password.Length < 8)
                return false;

            bool hasUppercase = Regex.IsMatch(password, "[A-Z]");
            bool hasDigit = Regex.IsMatch(password, "[0-9]");

            return hasUppercase && hasDigit;
        }
    }
}
