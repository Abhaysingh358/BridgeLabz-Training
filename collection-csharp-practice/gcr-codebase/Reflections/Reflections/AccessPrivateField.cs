using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    class Person
    {
        private int age = 20;
    }

    class AccessPrivateField
    {
        static void Main()
        {
            Person p = new Person();

            //Get Type information of the object (Reflection)
            Type type = p.GetType();

            //Get private field "age" using BindingFlags
            FieldInfo field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

            //Change private field value using Reflection
            field.SetValue(p, 30);

            //Read private field value using Reflection
            Console.WriteLine("Age: " + field.GetValue(p));
        }
    }
}
