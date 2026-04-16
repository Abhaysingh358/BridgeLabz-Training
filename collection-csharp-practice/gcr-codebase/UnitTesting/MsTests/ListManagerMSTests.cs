
using UnitTesting;

namespace BridgeLabz.MSTests
{
    [TestClass]
    public class ListManagerMSTests
    {
        private ListManager manager;
        private List<int> list;

        [TestInitialize]
        public void Setup()
        {
            manager = new ListManager();
            list = new List<int>();
        }

        [TestMethod]
        public void AddElement_AddsItemToList()
        {
            manager.AddElement(list, 5);

            Assert.AreEqual(1, list.Count);
            Assert.IsTrue(list.Contains(5));
        }

        [TestMethod]
        public void RemoveElement_RemovesItemFromList()
        {
            list.Add(10);
            list.Add(20);

            manager.RemoveElement(list, 10);

            Assert.AreEqual(1, list.Count);
            Assert.IsFalse(list.Contains(10));
        }

        [TestMethod]
        public void GetSize_ReturnsCorrectCount()
        {
            list.AddRange(new[] { 1, 2, 3 });

            Assert.AreEqual(3, manager.GetSize(list));
        }
    }
}
