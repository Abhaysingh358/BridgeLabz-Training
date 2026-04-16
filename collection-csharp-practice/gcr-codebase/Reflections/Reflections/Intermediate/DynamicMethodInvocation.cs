using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections.Intermediate
{
    class MathOperations
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
    }

    class DynamicMethodInvocation
    {
        static void Main()
        {
            MathOperations obj = new MathOperations();
            Type type = obj.GetType();

            Console.Write("Enter method name: ");
            string methodName = Console.ReadLine();

            MethodInfo method = type.GetMethod(methodName);
            int result = (int)method.Invoke(obj, new object[] { 10, 5 });

            Console.WriteLine("Result: " + result);
        }
    }
}
