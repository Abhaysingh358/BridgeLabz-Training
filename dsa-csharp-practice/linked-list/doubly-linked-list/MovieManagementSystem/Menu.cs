using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.DoublyLinkedList.MovieManagementSystem
{
    internal class Menu
    {
        private MovieLinkedList list;
        private MovieUtility util;

        public Menu()
        {
            list = new MovieLinkedList();
            util = new MovieUtility();
        }

        public void Start()
        {
            int choice;

            do
            {
                Console.WriteLine("\n1.AddBegin 2.AddEnd 3.AddPos 4.Remove 5.SearchDir 6.SearchRate 7.Update 8.Forward 9.Reverse 0.Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        list.AddAtBeginning(util.CreateMovie());
                        break;

                    case 2:
                        list.AddAtEnd(util.CreateMovie());
                        break;

                    case 3:
                        Console.Write("Position: ");
                        int pos = int.Parse(Console.ReadLine());
                        list.AddAtPosition(util.CreateMovie(), pos);
                        break;

                    case 4:
                        Console.Write("Title: ");
                        list.RemoveByTitle(Console.ReadLine());
                        break;

                    case 5:
                        Console.Write("Director: ");
                        list.SearchByDirector(Console.ReadLine(), util);
                        break;

                    case 6:
                        Console.Write("Rating: ");
                        list.SearchByRating(double.Parse(Console.ReadLine()), util);
                        break;

                    case 7:
                        Console.Write("Title: ");
                        string t = Console.ReadLine();
                        Console.Write("New Rating: ");
                        double r = double.Parse(Console.ReadLine());
                        list.UpdateRating(t, r);
                        break;

                    case 8:
                        list.DisplayForward(util);
                        break;

                    case 9:
                        list.DisplayReverse(util);
                        break;
                }

            } while (choice != 0);
        }
    }
}
