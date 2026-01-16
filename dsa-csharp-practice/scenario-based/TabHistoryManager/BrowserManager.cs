using System;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.TabHistoryManager
{
    internal class BrowserManager : ITabManager
    {
        private TabLinkedList openTabs;
        private ClosedTabStack closedTabs;
        private Tab activeTab;
        private int tabCounter;

        public BrowserManager()
        {
            openTabs = new TabLinkedList();
            closedTabs = new ClosedTabStack();
            activeTab = null;
            tabCounter = 1;
        }

        public void OpenNewTab()
        {
            Tab tab = new Tab(tabCounter++);
            openTabs.AddLast(tab);
            activeTab = tab;

            Console.WriteLine("New tab opened. TabId: " + tab.GetTabId());
        }

        public void CloseCurrentTab()
        {
            if (activeTab == null)
            {
                Console.WriteLine("No active tab to close.");
                return;
            }

            Tab removed = openTabs.RemoveById(activeTab.GetTabId());

            if (removed == null)
            {
                Console.WriteLine("Tab not found.");
                return;
            }

            closedTabs.Push(removed);
            Console.WriteLine("Closed TabId: " + removed.GetTabId());

            activeTab = openTabs.GetLastTab();
        }

        public void RestoreLastClosedTab()
        {
            Tab restored = closedTabs.Pop();

            if (restored == null)
            {
                Console.WriteLine("No closed tab to restore.");
                return;
            }

            openTabs.AddLast(restored);
            activeTab = restored;

            Console.WriteLine("Restored TabId: " + restored.GetTabId());
        }

        public void SwitchTab(int tabId)
        {
            Tab found = openTabs.FindById(tabId);

            if (found == null)
            {
                Console.WriteLine("Tab not found.");
                return;
            }

            activeTab = found;
            Console.WriteLine("Switched to TabId: " + activeTab.GetTabId());
        }

        public void Navigate(string url)
        {
            if (activeTab == null)
            {
                Console.WriteLine("No active tab. Open a tab first.");
                return;
            }

            activeTab.NavigateTo(url);
        }

        public void Back()
        {
            if (activeTab == null)
            {
                Console.WriteLine("No active tab.");
                return;
            }

            activeTab.GetHistory().Back();
        }

        public void Forward()
        {
            if (activeTab == null)
            {
                Console.WriteLine("No active tab.");
                return;
            }

            activeTab.GetHistory().Forward();
        }

        public void ShowCurrent()
        {
            if (activeTab == null)
            {
                Console.WriteLine("No active tab.");
                return;
            }

            activeTab.GetHistory().ShowCurrentPage();
        }

        public bool HasActiveTab()
        {
            return activeTab != null;
        }

        public void ShowAllTabs()
        {
            openTabs.DisplayTabs(activeTab);
        }
    }
}
