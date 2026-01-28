using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections.Intermediate
{
    class Configuration
    {
        private static string API_KEY = "OLD_KEY";
    }

    class ModifyStaticFields
    {
        static void Main()
        {
            Type type = typeof(Configuration);

            FieldInfo field = type.GetField("API_KEY", bindingAttr: BindingFlags.NonPublic | BindingFlags.Static);

            field.SetValue(null, "NEW_KEY");

            Console.WriteLine("Updated API_KEY: " + field.GetValue(null));
        }
    }
}
