using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.SinglyLinkedList.SocialMediaFriends
{
    internal class FriendNode
    {
        public int FriendId;
        public FriendNode Next;

        public FriendNode(int friendId)
        {
            FriendId = friendId;
            Next = null;
        }
    }
}
