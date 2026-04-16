namespace BridgeLabz.gcr_codebase.DSA.scenario_based.TabHistoryManager
{
    internal class TabNode
    {
        private Tab tab;
        private TabNode prev;
        private TabNode next;

        public TabNode(Tab tab)
        {
            this.tab = tab;
            this.prev = null;
            this.next = null;
        }

        public Tab GetTab()
        {
            return tab;
        }

        public TabNode GetPrev()
        {
            return prev;
        }

        public TabNode GetNext()
        {
            return next;
        }

        public void SetPrev(TabNode prevNode)
        {
            prev = prevNode;
        }

        public void SetNext(TabNode nextNode)
        {
            next = nextNode;
        }
    }
}
