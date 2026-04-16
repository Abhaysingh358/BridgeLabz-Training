using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.ExamProctor
{
    internal class NavigationStack
    {
        private StackNode top;
        private int count;

        public int Count
        {
            get { return count; }
        }

       // push Question's id into stack

        public void Push(int questionId)
        {
            StackNode stackNode = new StackNode(questionId);
            if (top == null)
            {
                top = stackNode;
            }

            else
            {
                stackNode.Next = top;
                top = stackNode;
            }
            count++;
        }


        // remove and return last visited question
        public int Pop()
        {
            if(top == null)
            {
                return -1;
            }

            int value = top.QuestionId;
            top = top.Next;
            count--;
            return value;
        }

        //return lastvisited question id without removing
        public int Peek()
        {
            if(top==null)
            {
                return -1;
            }
            else
            {
               return top.QuestionId;
            }
        }

        // Check stack is empty or not
        public bool IsEmpty()
        {
            return top == null;
        }

        public void Clear()
        {
            top = null;
            count = 0;
        }
    }
}
