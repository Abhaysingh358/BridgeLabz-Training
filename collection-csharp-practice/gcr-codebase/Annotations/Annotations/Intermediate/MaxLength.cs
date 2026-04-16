using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Annotations.Intermediate
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class MaxLengthAttribute : Attribute
    {
        public int Length { get; }

        public MaxLengthAttribute(int length)
        {
            Length = length;
        }
    }

    public class User
    {
        [MaxLength(10)]
        public string Username { get; }

        public User(string username)
        {
            var field = typeof(User).GetField(nameof(Username));
            var attr = field.GetCustomAttribute<MaxLengthAttribute>();

            if (attr != null && username.Length > attr.Length)
                throw new ArgumentException($"Username cannot exceed {attr.Length} characters");

            Username = username;
        }
    }
}
