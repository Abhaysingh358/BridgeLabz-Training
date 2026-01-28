using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections.Advanced
{
    internal class ExecutionTiming
    {
        public static void Measure(object obj)
        {
            Type type = obj.GetType();

            foreach (var method in type.GetMethods(
                BindingFlags.Public | BindingFlags.Instance))
            {
                if (method.DeclaringType == typeof(object)) continue;

                Stopwatch sw = Stopwatch.StartNew();
                method.Invoke(obj, null);
                sw.Stop();

                Console.WriteLine($"{method.Name}: {sw.ElapsedMilliseconds} ms");
            }
        }
    }
}
