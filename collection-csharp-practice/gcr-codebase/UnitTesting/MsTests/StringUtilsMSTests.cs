
using UnitTesting;

namespace BridgeLabz.MSTests
{
    [TestClass]
    public class StringUtilsMSTests
    {
        private StringUtils utils;

        [TestInitialize]
        public void Setup()
        {
            utils = new StringUtils();
        }

        [TestMethod]
        public void Reverse_ReturnsReversedString()
        {
            Assert.AreEqual("olleh", utils.Reverse("hello"));
        }

        [TestMethod]
        public void IsPalindrome_ReturnsTrueForPalindrome()
        {
            Assert.IsTrue(utils.IsPalindrome("madam"));
        }

        [TestMethod]
        public void IsPalindrome_ReturnsFalseForNonPalindrome()
        {
            Assert.IsFalse(utils.IsPalindrome("hello"));
        }

        [TestMethod]
        public void ToUpperCase_ConvertsCorrectly()
        {
            Assert.AreEqual("HELLO", utils.ToUpperCase("hello"));
        }
    }
}
