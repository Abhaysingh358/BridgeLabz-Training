
using UnitTesting;

namespace BridgeLabz.NUnitTests
{
    public class ListManagerNUnitTests
    {
        private ListManager manager;
        private List<int> list;

        [SetUp]
        public void Setup()
        {
            manager = new ListManager();
            list = new List<int>();
        }

        [Test]
        public void AddElement_AddsItemToList()
        {
            manager.AddElement(list, 5);

            Assert.AreEqual(1, list.Count);
            Assert.Contains(5, list);
        }

        [Test]
        public void RemoveElement_RemovesItemFromList()
        {
            list.Add(10);
            list.Add(20);

            manager.RemoveElement(list, 10);

            Assert.AreEqual(1, list.Count);
            Assert.IsFalse(list.Contains(10));
        }

        [Test]
        public void GetSize_ReturnsCorrectCount()
        {
            list.AddRange(new[] { 1, 2, 3 });

            Assert.AreEqual(3, manager.GetSize(list));
        }
    }
}
