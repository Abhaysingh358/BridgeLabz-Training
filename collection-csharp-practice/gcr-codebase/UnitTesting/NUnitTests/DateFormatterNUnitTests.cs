
using UnitTesting;

namespace BridgeLabz.NUnitTests
{
    public class DateFormatterNUnitTests
    {
        private DateFormatter formatter;

        [SetUp]
        public void Setup()
        {
            formatter = new DateFormatter();
        }

        [TestCase("2025-01-15", "15-01-2025")]
        [TestCase("2024-12-31", "31-12-2024")]
        public void FormatDate_ValidInput_ReturnsFormattedDate(string input, string expected)
        {
            Assert.AreEqual(expected, formatter.FormatDate(input));
        }

        [TestCase("15-01-2025")]
        [TestCase("2025/01/15")]
        [TestCase("invalid")]
        public void FormatDate_InvalidInput_ThrowsException(string input)
        {
            Assert.Throws<FormatException>(() => formatter.FormatDate(input));
        }
    }
}
