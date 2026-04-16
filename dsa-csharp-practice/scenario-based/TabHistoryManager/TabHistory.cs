using System;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.TabHistoryManager
{
    internal class TabHistory : ITabHistory
    {
        private HistoryNode head;
        private HistoryNode tail;
        private HistoryNode current;

        public TabHistory()
        {
            head = null;
            tail = null;
            current = null;
        }

        // check that url is visited
        public void Visit(string url)
        {
            HistoryNode newNode = new HistoryNode(url);

            if (head == null)
            {
                head = tail = current = newNode;
                Console.WriteLine("Visited: " + url);
                return;
            }

            // If user is not at the end, clear forward history
            if (current != tail)
            {
                HistoryNode temp = current.GetNext();

                while (temp != null)
                {
                    HistoryNode nextTemp = temp.GetNext();
                    temp.SetPrev(null);
                    temp.SetNext(null);
                    temp = nextTemp;
                }

                current.SetNext(null);
                tail = current;
            }

            newNode.SetPrev(current);
            current.SetNext(newNode);

            current = newNode;
            tail = newNode;

            Console.WriteLine("Visited: " + url);
        }

        // back button to back from tabs
        public void Back()
        {
            if (current == null)
            {
                Console.WriteLine("No history available.");
                return;
            }

            if (current.GetPrev() == null)
            {
                Console.WriteLine("No previous page.");
                return;
            }

            current = current.GetPrev();
            Console.WriteLine("Back to: " + current.GetUrl());
        }

        // forward to use next  page 
        public void Forward()
        {
            if (current == null)
            {
                Console.WriteLine("No history available.");
                return;
            }

            if (current.GetNext() == null)
            {
                Console.WriteLine("No next page.");
                return;
            }

            current = current.GetNext();
            Console.WriteLine("Forward to: " + current.GetUrl());
        }

        // this shows currently which tab and page actice
        public void ShowCurrentPage()
        {
            if (current == null)
            {
                Console.WriteLine("No page opened yet.");
                return;
            }

            Console.WriteLine("Current page: " + current.GetUrl());
        }

        public bool CanGoBack()
        {
            return current != null && current.GetPrev() != null;
        }

        public bool CanGoForward()
        {
            return current != null && current.GetNext() != null;
        }
    }
}
