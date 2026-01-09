using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.StackImpl;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.StackSortRecursion
{
    internal class StackSorter
    {
        private Stack stack;

        public StackSorter(Stack stack)
        {
            this.stack = stack;
        }

        // Sort stack using recursion
        public void SortStack()
        {
            if (stack.IsEmpty())
                return;

            int top = stack.Pop();
            SortStack();
            InsertSorted(top);
        }

        // Insert element in sorted order
        private void InsertSorted(int value)
        {
            if (stack.IsEmpty())
            {
                stack.Push(value);
                return;
            }

            int top = stack.Pop();

            if (top <= value)
            {
                stack.Push(top);
                stack.Push(value);
            }
            else
            {
                InsertSorted(value);
                stack.Push(top);
            }
        }
    }
}
