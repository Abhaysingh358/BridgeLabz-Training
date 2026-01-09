using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.LinkedListImpl
{

    public class LinkedList
    {
        private Node head;

        // add at beginning
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        // add at end
        public void AddLast(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
        }

        // remove from beginning
        public int RemoveFirst()
        {
            if (head == null)
                throw new Exception("List is empty");

            int value = head.data;
            head = head.next;
            return value;
        }

        // remove from end
        public int RemoveLast()
        {
            if (head == null)
                throw new Exception("List is empty");

            if (head.next == null)
            {
                int value = head.data;
                head = null;
                return value;
            }

            Node temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }

            int removed = temp.next.data;
            temp.next = null;
            return removed;
        }

        // display list
        public void Display()
        {
            Node temp = head;

            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }

            Console.WriteLine("null");
        }

        // check empty
        public bool IsEmpty()
        {
            return head == null;
        }
    }

}
