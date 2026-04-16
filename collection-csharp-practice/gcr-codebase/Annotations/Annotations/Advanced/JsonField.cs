using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Annotations.Advanced
{
    internal class JsonField
    {
        [AttributeUsage(AttributeTargets.Property)]
        public class JsonFieldAttribute : Attribute
        {
            public string Name { get; set; }
        }

        public class User
        {
            [JsonField(Name = "user_name")]
            public string Username { get; set; }

            [JsonField(Name = "user_age")]
            public int Age { get; set; }
        }

        public static class SimpleJsonSerializer
        {
            public static string ToJson(object obj)
            {
                var sb = new StringBuilder("{");
                var props = obj.GetType().GetProperties();

                foreach (var prop in props)
                {
                    var attr = prop.GetCustomAttribute<JsonFieldAttribute>();
                    if (attr != null)
                    {
                        sb.Append($"\"{attr.Name}\":\"{prop.GetValue(obj)}\",");
                    }
                }

                sb.Length--; // remove last comma
                sb.Append("}");
                return sb.ToString();
            }
        }
    }
}
