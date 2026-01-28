using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Annotations.Advanced
{
    [AttributeUsage(AttributeTargets.Method)]
    public class CacheResultAttribute : Attribute { }

    public class Calculator
    {
        [CacheResult]
        public int SlowSquare(int x)
        {
            Thread.Sleep(1000); // simulate heavy work
            return x * x;
        }
    }

    internal class CacheResult
    {
        static Dictionary<string, object> cache = new();

        static void Main()
        {
            var calc = new Calculator();
            var method = typeof(Calculator).GetMethod("SlowSquare");

            Console.WriteLine(InvokeWithCache(calc, method, 5)); // slow
            Console.WriteLine(InvokeWithCache(calc, method, 5)); // fast
        }

        static object InvokeWithCache(object obj, MethodInfo method, object param)
        {
            string key = method.Name + param;

            if (cache.ContainsKey(key))
                return cache[key];

            var result = method.Invoke(obj, new[] { param });
            cache[key] = result;
            return result;
        }
    }
}
