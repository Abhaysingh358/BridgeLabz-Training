
using UnitTesting;

namespace BridgeLabz.NUnitTests
{
    public class NumberUtilsNUnitTests
    {
        private NumberUtils utils;

        [SetUp]
        public void Setup()
        {
            utils = new NumberUtils();
        }

        [TestCase(2, true)]
        [TestCase(4, true)]
        [TestCase(6, true)]
        [TestCase(7, false)]
        [TestCase(9, false)]
        public void IsEven_ReturnsCorrectResult(int number, bool expected)
        {
            Assert.AreEqual(expected, utils.IsEven(number));
        }
    }
}
