
using System.Text.RegularExpressions;

namespace UnitTesting
{
    public class UserRegistration
    {
        public bool RegisterUser(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username is required");

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("Invalid email format");

            if (password.Length < 8)
                throw new ArgumentException("Password must be at least 8 characters");

            return true; // simulate successful registration
        }
    }
}
