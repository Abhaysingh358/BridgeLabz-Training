using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.StackImpl;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.QueueTwoStack
{
    internal class QueueUsingTwoStacks
    {
        private Stack enqueueStack = new Stack();
        private Stack dequeueStack = new Stack();

        public void Enqueue(int data)
        {
            enqueueStack.Push(data);
        }

        public int Dequeue()
        {
            if (dequeueStack.IsEmpty())
            {
                if (enqueueStack.IsEmpty())
                    throw new Exception("Queue is empty");

                while (!enqueueStack.IsEmpty())
                {
                    dequeueStack.Push(enqueueStack.Pop());
                }
            }

            return dequeueStack.Pop();
        }

        public void Display()
        {
            // display front elements
            if (!dequeueStack.IsEmpty())
            {
                dequeueStack.Display();
            }

            Stack tempStack = new Stack();

            while (!enqueueStack.IsEmpty())
            {
                tempStack.Push(enqueueStack.Pop());
            }

            if (!tempStack.IsEmpty())
            {
                tempStack.Display();
            }

            // restore enqueueStack
            while (!tempStack.IsEmpty())
            {
                enqueueStack.Push(tempStack.Pop());
            }
        }

    }
}
