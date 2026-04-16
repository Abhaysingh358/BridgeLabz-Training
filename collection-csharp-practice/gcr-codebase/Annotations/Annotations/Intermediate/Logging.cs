using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Annotations.Intermediate
{
    [AttributeUsage(AttributeTargets.Method)]
    public class LogExecutionTimeAttribute : Attribute { }

    public class Service
    {
        [LogExecutionTime]
        public void FastMethod()
        {
            Thread.Sleep(200);
        }

        [LogExecutionTime]
        public void SlowMethod()
        {
            Thread.Sleep(600);
        }
    }

    internal class Logging
    {
        static void Main()
        {
            Service service = new Service();
            var methods = typeof(Service).GetMethods();

            foreach (var method in methods)
            {
                if (method.GetCustomAttribute<LogExecutionTimeAttribute>() != null)
                {
                    var watch = Stopwatch.StartNew();
                    method.Invoke(service, null);
                    watch.Stop();

                    Console.WriteLine($"{method.Name} executed in {watch.ElapsedMilliseconds} ms");
                }
            }
        }
    }
}
