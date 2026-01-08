using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.SinglyLinkedList.SocialMediaFriends
{
    internal class SocialNetworkLinkedList
    {
        private User Head;

        // Add new user
        public void AddUser(User user)
        {
            user.Next = Head;
            Head = user;
        }

        // Search by ID
        public User SearchById(int userId)
        {
            User temp = Head;
            while (temp != null)
            {
                if (temp.UserId == userId)
                    return temp;
                temp = temp.Next;
            }
            return null;
        }

        // Search by Name
        public User SearchByName(string name)
        {
            User temp = Head;
            while (temp != null)
            {
                if (temp.Name.Equals(name))
                    return temp;
                temp = temp.Next;
            }
            return null;
        }

        // Add friend connection
        public void AddFriendConnection(int id1, int id2)
        {
            User u1 = SearchById(id1);
            User u2 = SearchById(id2);

            if (u1 == null || u2 == null)
            {
                Console.WriteLine("Both users must exist.");
                return;
            }

            AddFriend(u1, id2);
            AddFriend(u2, id1);
        }
        private void AddFriend(User user, int friendId)
        {
            FriendNode temp = user.FriendsHead;
            while (temp != null)
            {
                if (temp.FriendId == friendId)
                    return;
                temp = temp.Next;
            }

            FriendNode newFriend = new FriendNode(friendId);
            newFriend.Next = user.FriendsHead;
            user.FriendsHead = newFriend;
        }

        // Remove friend connection
        public void RemoveFriendConnection(int id1, int id2)
        {
            User u1 = SearchById(id1);
            User u2 = SearchById(id2);

            if (u1 == null || u2 == null) return;

            RemoveFriend(u1, id2);
            RemoveFriend(u2, id1);
        }

        private void RemoveFriend(User user, int friendId)
        {
            FriendNode temp = user.FriendsHead;
            FriendNode prev = null;

            while (temp != null)
            {
                if (temp.FriendId == friendId)
                {
                    if (prev == null)
                        user.FriendsHead = temp.Next;
                    else
                        prev.Next = temp.Next;
                    return;
                }
                prev = temp;
                temp = temp.Next;
            }
        }

        // Display friends of a user
        public void DisplayFriends(int userId, SocialUtility util)
        {
            User user = SearchById(userId);
            if (user == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            if (user.FriendsHead == null)
            {
                Console.WriteLine("No friends.");
                return;
            }

            FriendNode temp = user.FriendsHead;
            while (temp != null)
            {
                User friend = SearchById(temp.FriendId);
                if (friend != null)
                    util.Print(friend);
                else
                    Console.WriteLine($"Friend with ID {temp.FriendId} not found.");

                temp = temp.Next;
            }
        }


        // Mutual friends
        public void FindMutualFriends(int id1, int id2, SocialUtility util)
        {
            User u1 = SearchById(id1);
            User u2 = SearchById(id2);

            if (u1 == null || u2 == null) return;

            FriendNode f1 = u1.FriendsHead;
            while (f1 != null)
            {
                if (IsFriend(u2, f1.FriendId))
                {
                    User mutual = SearchById(f1.FriendId);
                    if (mutual != null)
                        util.Print(mutual);
                }
                f1 = f1.Next;
            }
        }

        private bool IsFriend(User user, int friendId)
        {
            FriendNode temp = user.FriendsHead;
            while (temp != null)
            {
                if (temp.FriendId == friendId)
                    return true;
                temp = temp.Next;
            }
            return false;
        }

        // Count friends per user
        public void CountFriends()
        {
            User temp = Head;
            while (temp != null)
            {
                int count = 0;
                FriendNode f = temp.FriendsHead;
                while (f != null)
                {
                    count++;
                    f = f.Next;
                }
                Console.WriteLine($"{temp.Name} has {count} friends");
                temp = temp.Next;
            }
        }
    }
}
