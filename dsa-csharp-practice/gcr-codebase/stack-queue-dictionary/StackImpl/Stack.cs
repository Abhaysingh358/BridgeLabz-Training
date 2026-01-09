using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.LinkedListImpl;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.StackImpl
{
    internal class Stack
    {
        private LinkedListImpl.LinkedList list = new LinkedListImpl.LinkedList();

        public void Push(int data)
        {
            list.AddFirst(data);
        }

        public int Pop()
        {
            return list.RemoveFirst();
        }

        public bool IsEmpty()
        {
            return list.IsEmpty();
        }

        public void Display()
        {
            list.Display();
        }

    }
}
