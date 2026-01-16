using System;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.TabHistoryManager
{
    internal class HistoryNode
    {
        private string url;
        private DateTime visitedAt;
        private HistoryNode prev;
        private HistoryNode next;

        public HistoryNode(string url)
        {
            this.url = url;
            this.visitedAt = DateTime.Now;
            this.prev = null;
            this.next = null;
        }

        public string GetUrl()
        {
            return url;
        }

        public DateTime GetVisitedAt()
        {
            return visitedAt;
        }

        public HistoryNode GetPrev()
        {
            return prev;
        }

        public HistoryNode GetNext()
        {
            return next;
        }

        public void SetPrev(HistoryNode prevNode)
        {
            this.prev = prevNode;
        }

        public void SetNext(HistoryNode nextNode)
        {
            this.next = nextNode;
        }
    }
}
