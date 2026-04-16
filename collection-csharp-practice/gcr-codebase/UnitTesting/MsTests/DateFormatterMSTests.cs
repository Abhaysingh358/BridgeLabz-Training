
using UnitTesting;

namespace BridgeLabz.MSTests
{
    [TestClass]
    public class DateFormatterMSTests
    {
        private DateFormatter formatter;

        [TestInitialize]
        public void Setup()
        {
            formatter = new DateFormatter();
        }

        [TestMethod]
        [DataRow("2025-01-15", "15-01-2025")]
        [DataRow("2024-12-31", "31-12-2024")]
        public void FormatDate_ValidInput_ReturnsFormattedDate(string input, string expected)
        {
            Assert.AreEqual(expected, formatter.FormatDate(input));
        }

        [DataTestMethod]
        [DataRow("15-01-2025")]
        [DataRow("2025/01/15")]
        [DataRow("invalid")]
        public void FormatDate_InvalidInput_ThrowsException(string input)
        {
            Assert.Throws<FormatException>(() => formatter.FormatDate(input));
        }
    }
}
