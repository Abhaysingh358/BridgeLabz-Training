using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    class StudentInfo
    {
        public int Id;
        public string Name;

        public void Display()
        {
            Console.WriteLine("Hello Student");
        }
    }
    class GetClass
    {
        static void Main(string[] args)
        {
            //Get Type info
            Type type = typeof(Student);

            //Create object dynamically
            object obj = Activator.CreateInstance(type);

            //Set field value
            FieldInfo field = type.GetField("Name");
            field.SetValue(obj, "Rahul");

            //Call method dynamically
            MethodInfo method = type.GetMethod("Display");
            method.Invoke(obj, null);

            //Get field value
            Console.WriteLine(field.GetValue(obj));
        }
    }
}