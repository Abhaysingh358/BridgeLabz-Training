using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Annotations.Advanced
{
    [AttributeUsage(AttributeTargets.Method)]
    public class RoleAllowedAttribute : Attribute
    {
        public string Role { get; }

        public RoleAllowedAttribute(string role)
        {
            Role = role;
        }
    }

    public class AdminService
    {
        [RoleAllowed("ADMIN")]
        public void DeleteUser()
        {
            Console.WriteLine("User deleted");
        }
    }

    internal class RoleAllowed
    {
        static void Main()
        {
            string currentUserRole = "USER"; // change to ADMIN to allow

            var service = new AdminService();
            var method = typeof(AdminService).GetMethod("DeleteUser");
            var attr = method.GetCustomAttribute<RoleAllowedAttribute>();

            if (attr != null && attr.Role != currentUserRole)
            {
                Console.WriteLine("Access Denied!");
                return;
            }

            method.Invoke(service, null);
        }
    }
}
