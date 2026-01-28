
using UnitTesting;

namespace BridgeLabz.MSTests
{
    [TestClass]
    public class NumberUtilsMSTests
    {
        private NumberUtils utils;

        [TestInitialize]
        public void Setup()
        {
            utils = new NumberUtils();
        }

        [DataTestMethod]
        [DataRow(2, true)]
        [DataRow(4, true)]
        [DataRow(6, true)]
        [DataRow(7, false)]
        [DataRow(9, false)]
        public void IsEven_ReturnsCorrectResult(int number, bool expected)
        {
            Assert.AreEqual(expected, utils.IsEven(number));
        }
    }
}
