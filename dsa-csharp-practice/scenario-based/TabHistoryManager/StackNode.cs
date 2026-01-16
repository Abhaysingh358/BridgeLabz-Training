namespace BridgeLabz.gcr_codebase.DSA.scenario_based.TabHistoryManager
{
    // making custom stack
    internal class StackNode
    {
        private Tab data;
        private StackNode next;

        public StackNode(Tab tab)
        {
            data = tab;
            next = null;
        }

        public Tab GetData()
        {
            return data;
        }

        public StackNode GetNext()
        {
            return next;
        }

        public void SetNext(StackNode nextNode)
        {
            next = nextNode;
        }
    }
}
