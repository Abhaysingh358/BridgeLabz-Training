using System;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.TabHistoryManager
{
    internal class TabLinkedList
    {
        private TabNode head;
        private TabNode tail;
        private int count;

        public TabLinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public int Count()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void AddLast(Tab tab)
        {
            TabNode newNode = new TabNode(tab);

            if (head == null)
            {
                head = tail = newNode;
                count++;
                return;
            }

            tail.SetNext(newNode);
            newNode.SetPrev(tail);
            tail = newNode;
            count++;
        }

        public Tab FindById(int tabId)
        {
            TabNode temp = head;

            while (temp != null)
            {
                if (temp.GetTab().GetTabId() == tabId)
                    return temp.GetTab();

                temp = temp.GetNext();
            }

            return null;
        }

        public Tab RemoveById(int tabId)
        {
            if (head == null)
                return null;

            TabNode temp = head;

            while (temp != null)
            {
                if (temp.GetTab().GetTabId() == tabId)
                {
                    Tab removedTab = temp.GetTab();

                    if (head == tail)
                    {
                        head = null;
                        tail = null;
                    }
                    else if (temp == head)
                    {
                        head = head.GetNext();
                        head.SetPrev(null);
                    }
                    else if (temp == tail)
                    {
                        tail = tail.GetPrev();
                        tail.SetNext(null);
                    }
                    else
                    {
                        TabNode p = temp.GetPrev();
                        TabNode n = temp.GetNext();
                        p.SetNext(n);
                        n.SetPrev(p);
                    }

                    temp.SetPrev(null);
                    temp.SetNext(null);
                    count--;
                    return removedTab;
                }

                temp = temp.GetNext();
            }

            return null;
        }

        public Tab GetLastTab()
        {
            if (tail == null)
                return null;

            return tail.GetTab();
        }

        public void DisplayTabs(Tab activeTab)
        {
            if (head == null)
            {
                Console.WriteLine("No tabs open.");
                return;
            }

            Console.WriteLine("\n----- Open Tabs -----");
            TabNode temp = head;

            while (temp != null)
            {
                Tab tab = temp.GetTab();

                if (activeTab != null && tab.GetTabId() == activeTab.GetTabId())
                    Console.WriteLine("TabId: " + tab.GetTabId() + "  Title: " + tab.GetTitle() + "  [ACTIVE]");
                else
                    Console.WriteLine("TabId: " + tab.GetTabId() + "  Title: " + tab.GetTitle());

                temp = temp.GetNext();
            }

            Console.WriteLine("----------------------");
        }
    }
}
