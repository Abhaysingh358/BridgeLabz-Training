using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.SinglyLinkedList.SocialMediaFriends
{
    internal class User
    {
        public int UserId;
        public string Name;
        public int Age;

        public FriendNode FriendsHead; // linked list of friends
        public User Next;              // linked list of users

        public User(int userId, string name, int age)
        {
            UserId = userId;
            Name = name;
            Age = age;
            FriendsHead = null;
            Next = null;
        }
    }
}
