

namespace BridgeLabz.NUnitTests
{
    public class PerformanceNUnitTests
    {
        private PerformanceUtils utils;

        [SetUp]
        public void Setup()
        {
            utils = new PerformanceUtils();
        }

        [Test]
        [Timeout(20000)]   // Fail if takes more than 2 seconds
        public void LongRunningTask_ShouldCompleteWithinTime()
        {
            utils.LongRunningTask();
        }
    }
}
