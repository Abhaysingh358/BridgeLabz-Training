using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.SinglyLinkedList.SocialMediaFriends
{
    internal class Menu
    {
        private SocialNetworkLinkedList network = new SocialNetworkLinkedList();
        private SocialUtility util = new SocialUtility();

        public void Start()
        {
            int choice;

            do
            {
                Console.WriteLine(
                    "\n1.AddUser 2.AddFriend 3.RemoveFriend 4.DisplayFriends 5.MutualFriends 6.SearchId 7.SearchName 8.CountFriends 0.Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        network.AddUser(util.CreateUser());
                        break;

                    case 2:
                        Console.Write("User1 ID: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("User2 ID: ");
                        int b = int.Parse(Console.ReadLine());
                        network.AddFriendConnection(a, b);
                        break;

                    case 3:
                        Console.Write("User1 ID: ");
                        int c = int.Parse(Console.ReadLine());
                        Console.Write("User2 ID: ");
                        int d = int.Parse(Console.ReadLine());
                        network.RemoveFriendConnection(c, d);
                        break;

                    case 4:
                        Console.Write("User ID: ");
                        network.DisplayFriends(int.Parse(Console.ReadLine()), util);
                        break;

                    case 5:
                        Console.Write("User1 ID: ");
                        int m1 = int.Parse(Console.ReadLine());
                        Console.Write("User2 ID: ");
                        int m2 = int.Parse(Console.ReadLine());
                        network.FindMutualFriends(m1, m2, util);
                        break;

                    case 6:
                        Console.Write("User ID: ");
                        User byId = network.SearchById(int.Parse(Console.ReadLine()));
                        if (byId != null) util.Print(byId);
                        break;

                    case 7:
                        Console.Write("Name: ");
                        User byName = network.SearchByName(Console.ReadLine());
                        if (byName != null) util.Print(byName);
                        break;

                    case 8:
                        network.CountFriends();
                        break;
                }

            } while (choice != 0);
        }
    }
}
