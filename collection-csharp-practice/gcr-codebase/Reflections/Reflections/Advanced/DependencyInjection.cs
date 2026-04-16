using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections.Advanced
{
    [AttributeUsage(AttributeTargets.Field)]
    class InjectAttribute : Attribute { }

    // Simple DI container
    class DependencyInjection
    {
        public static void Inject(object obj)
        {
            // Get runtime type info of object
            Type type = obj.GetType();

            // Get all private instance fields
            foreach (var field in type.GetFields(
                BindingFlags.NonPublic | BindingFlags.Instance))
            {
                // Check if field has [Inject] attribute
                if (field.GetCustomAttribute<InjectAttribute>() != null)
                {
                    // Create instance of field type
                    object dep = Activator.CreateInstance(field.FieldType);

                    // Assign created object to the field
                    field.SetValue(obj, dep);
                }
            }
        }
    }
}