namespace BridgeLabz.gcr_codebase.DSA.scenario_based.TabHistoryManager
{
    // using custom stack to store closed tabs
    internal class ClosedTabStack
    {
        private StackNode top;
        private int count;

        public ClosedTabStack()
        {
            top = null;
            count = 0;
        }

        public void Push(Tab tab)
        {
            if (tab == null)
                return;

            StackNode node = new StackNode(tab);

            node.SetNext(top);
            top = node;
            count++;
        }

        public Tab Pop()
        {
            if (top == null)
                return null;

            Tab data = top.GetData();
            top = top.GetNext();
            count--;

            return data;
        }

        public Tab Peek()
        {
            if (top == null)
                return null;

            return top.GetData();
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public int Count()
        {
            return count;
        }
    }
}
