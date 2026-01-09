using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.StackImpl;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.Queue
{
    internal class QueueUsingOneStack
    {
        private Stack stack = new Stack();

        // Enqueue operation
        public void Enqueue(int data)
        {
            stack.Push(data);
        }

        // Dequeue operation (core logic)
        public int Dequeue()
        {
            if (stack.IsEmpty())
                throw new Exception("Queue is empty");

            return DequeueHelper();
        }

        // Recursive helper method
        private int DequeueHelper()
        {
            int top = stack.Pop();

            if (stack.IsEmpty())
            {
                // this is the bottom element (front of queue)
                return top;
            }

            int result = DequeueHelper();
            stack.Push(top); // push back while returning
            return result;
        }
    }
}
