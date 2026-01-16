namespace BridgeLabz.gcr_codebase.DSA.scenario_based.TabHistoryManager
{
    internal interface ITabManager
    {
        void OpenNewTab();
        void CloseCurrentTab();
        void RestoreLastClosedTab();
        void SwitchTab(int tabId);

        void Navigate(string url);
        void Back();
        void Forward();
        void ShowCurrent();
        bool HasActiveTab();
        void ShowAllTabs();
    }
}
