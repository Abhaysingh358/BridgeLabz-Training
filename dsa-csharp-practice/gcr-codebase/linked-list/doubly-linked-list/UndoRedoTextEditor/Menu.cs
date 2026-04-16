using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.DoublyLinkedList.UndoRedoTextEditor
{
    internal class Menu
    {
        private UndoRedoManager manager;
        private TextEditorUtility util;

        public Menu()
        {
            manager = new UndoRedoManager(10);
            util = new TextEditorUtility();
        }

        public void Start()
        {
            int choice;

            do
            {
                Console.WriteLine(
                    "\n1.Type Text 2.Undo 3.Redo 4.Display 0.Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter text: ");
                        manager.AddState(Console.ReadLine());
                        break;

                    case 2:
                        manager.Undo();
                        break;

                    case 3:
                        manager.Redo();
                        break;

                    case 4:
                        util.Display(manager.GetCurrentText());
                        break;
                }

            } while (choice != 0);
        }
    }
}
