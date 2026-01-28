

namespace BridgeLabz.MSTests
{
    [TestClass]
    public class PerformanceMSTests
    {
        private PerformanceUtils utils;

        [TestInitialize]
        public void Setup()
        {
            utils = new PerformanceUtils();
        }

        [TestMethod]
        [Timeout(20000)]   // Fail if more than 2 seconds
        public void LongRunningTask_ShouldCompleteWithinTime()
        {
            utils.LongRunningTask();
        }
    }
}
