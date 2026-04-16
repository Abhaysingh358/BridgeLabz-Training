using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Annotations.Beginner
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ImportantMethodAttribute : Attribute
    {
        public string Level { get; }

        public ImportantMethodAttribute(string level = "HIGH")
        {
            Level = level;
        }
    }
    public class Service
    {
        [ImportantMethod] // default HIGH
        public void ProcessPayment()
        {
            Console.WriteLine("Processing payment");
        }

        [ImportantMethod("LOW")]
        public void LogActivity()
        {
            Console.WriteLine("Logging activity");
        }

        public void HelperMethod()
        {
            Console.WriteLine("Helper method");
        }
    }
    class ImportantMethod
    {
        static void Main()
        {
            var methods = typeof(Service).GetMethods();

            foreach (var method in methods)
            {
                var attr = method.GetCustomAttribute<ImportantMethodAttribute>();
                if (attr != null)
                {
                    Console.WriteLine($"Method: {method.Name}, Level: {attr.Level}");
                }
            }
        }
    }
}
