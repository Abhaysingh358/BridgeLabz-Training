
using UnitTesting;

namespace BridgeLabz.NUnitTests
{
    public class StringUtilsNUnitTests
    {
        private StringUtils utils;

        [SetUp]
        public void Setup()
        {
            utils = new StringUtils();
        }

        [Test]
        public void Reverse_ReturnsReversedString()
        {
            Assert.AreEqual("olleh", utils.Reverse("hello"));
        }

        [Test]
        public void IsPalindrome_ReturnsTrueForPalindrome()
        {
            Assert.IsTrue(utils.IsPalindrome("madam"));
        }

        [Test]
        public void IsPalindrome_ReturnsFalseForNonPalindrome()
        {
            Assert.IsFalse(utils.IsPalindrome("hello"));
        }

        [Test]
        public void ToUpperCase_ConvertsCorrectly()
        {
            Assert.AreEqual("HELLO", utils.ToUpperCase("hello"));
        }
    }
}
