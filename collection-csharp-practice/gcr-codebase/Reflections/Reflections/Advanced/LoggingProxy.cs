using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflections.Advanced
{
    // Proxy class
    class LoggingProxy<T> : DispatchProxy
    {
        private T _target;

        public static T Create(T target)
        {
            var proxy = Create<T, LoggingProxy<T>>();
            (proxy as LoggingProxy<T>)._target = target;
            return proxy;
        }

        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            Console.WriteLine("Calling: " + targetMethod.Name);
            return targetMethod.Invoke(_target, args);
        }
    }
    // Real service
    class Service
    {
        public void DoWork()
        {
            Console.WriteLine("Doing work");
        }
    }
    class LoggingProxy
    {
        static void Main()
        {
            Service service = new Service();
            // Create proxy
            Service proxy = LoggingProxy<Service>.Create(service);
            // Call method (goes through proxy)
            proxy.DoWork();
        }
    }
}