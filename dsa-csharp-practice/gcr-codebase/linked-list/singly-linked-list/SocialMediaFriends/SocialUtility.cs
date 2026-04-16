using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.SinglyLinkedList.SocialMediaFriends
{
    internal class SocialUtility
    {
        public User CreateUser()
        {
            Console.Write("User ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            return new User(id, name, age);
        }

        public void Print(User user)
        {
            Console.WriteLine($"ID:{user.UserId}, Name:{user.Name}, Age:{user.Age}");
        }
    }
}
