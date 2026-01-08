using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.SinglyLinkedList.Student_Record_Management
{
    internal class Menu
    {
        private StudentLinkedList list;
        private StudentUtility utility;

        public Menu()
        {
            list = new StudentLinkedList();
            utility = new StudentUtility();
        }

        public void Start()
        {
            int choice;

            do
            {
                Console.WriteLine("\n1.AddBegin 2.AddEnd 3.AddPos 4.Delete 5.Search 6.Update 7.Display 0.Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        list.AddAtBeginning(utility.CreateStudent());
                        break;

                    case 2:
                        list.AddAtEnd(utility.CreateStudent());
                        break;

                    case 3:
                        Console.Write("Position: ");
                        int pos = int.Parse(Console.ReadLine());
                        list.AddAtPosition(utility.CreateStudent(), pos);
                        break;

                    case 4:
                        Console.Write("Roll: ");
                        list.DeleteByRollNumber(int.Parse(Console.ReadLine()));
                        break;

                    case 5:
                        Console.Write("Roll: ");
                        Student s = list.SearchByRollNumber(int.Parse(Console.ReadLine()));
                        if (s != null)
                            utility.Print(s);
                        else
                            Console.WriteLine("Student not found.");
                        break;

                    case 6:
                        Console.Write("Roll: ");
                        int r = int.Parse(Console.ReadLine());
                        Console.Write("Grade: ");
                        char g = char.Parse(Console.ReadLine());
                        list.UpdateGrade(r, g);
                        break;

                    case 7:
                        list.DisplayAll();
                        break;
                }

            } while (choice != 0);
        }
    }
}
