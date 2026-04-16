using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections.Advanced
{
    internal class JsonRepresentation
    {
        public static string ToJson(object obj)
        {
            Type type = obj.GetType();
            StringBuilder sb = new StringBuilder("{");

            foreach (var f in type.GetFields(
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                sb.Append($"\"{f.Name}\": \"{f.GetValue(obj)}\", ");
            }

            return sb.ToString().TrimEnd(',', ' ') + "}";
        }
    }
}
