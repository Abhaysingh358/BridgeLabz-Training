using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections.Advanced
{
    internal class ObjectMapper
    {
        public static T ToObject<T>(Dictionary<string, object> props) where T : new()
        {
            T obj = new T();
            Type type = typeof(T);

            foreach (var field in type.GetFields(
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                if (props.ContainsKey(field.Name))
                    field.SetValue(obj, props[field.Name]);
            }
            return obj;
        }
    }
}