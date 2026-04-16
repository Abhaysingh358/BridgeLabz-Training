using System;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.TabHistoryManager
{
    internal class Tab
    {
        private int tabId;
        private string title;
        private TabHistory history;

        public Tab(int tabId)
        {
            this.tabId = tabId;
            this.title = "New Tab";
            this.history = new TabHistory();
        }

        public int GetTabId()
        {
            return tabId;
        }

        public string GetTitle()
        {
            return title;
        }

        public TabHistory GetHistory()
        {
            return history;
        }

        public void NavigateTo(string url)
        {
            title = url;
            history.Visit(url);
        }
    }
}
