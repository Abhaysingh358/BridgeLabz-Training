using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections.Intermediate
{
    [AttributeUsage(AttributeTargets.Class)]
    class AuthorAttribute : Attribute
    {
        public string Name { get; }
        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }

    [Author("John Doe")]
    class Book { }

    class RetrieveAttributes
    {
        static void Main()
        {
            Type type = typeof(Book);
            var attr = type.GetCustomAttribute<AuthorAttribute>();

            Console.WriteLine("Author: " + attr.Name);
        }
    }
}
