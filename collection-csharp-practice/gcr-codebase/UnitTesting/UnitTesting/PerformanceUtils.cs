
namespace BridgeLabz
{
    public class PerformanceUtils
    {
        public string LongRunningTask()
        {
            Thread.Sleep(3000);   // Simulates slow operation (3 seconds)
            return "Done";
        }
    }
}
