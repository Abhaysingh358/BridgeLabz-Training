using System;

namespace BridgeLabz.review.RotateListByK
{
    internal class LinkedList
    {
        public Node head;

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public void DisplayBeforRotated()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }

            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        public void RotateByK(int k)
        {
            if (head == null || k == 0)
                return;

            Node current = head;
            int length = 1;

            while (current.next != null)
            {
                current = current.next;
                length++;
            }

            // make circular
            current.next = head;

            k = k % length;

            if (k == 0)
            {
                current.next = null;
                return;
            }

            Node newTail = head;

            for (int i = 1; i < k; i++)
            {
                newTail = newTail.next;
            }

            head = newTail.next;
            newTail.next = null;
        }

        public void DisplayAfterRotation()
        {
            DisplayBeforRotated();
        }
    }
}
