using System;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.TabHistoryManager
{
    internal interface ITabHistory
    {
        void Visit(string url);
        void Back();
        void Forward();
        void ShowCurrentPage();
        bool CanGoBack();
        bool CanGoForward();
    }
}
