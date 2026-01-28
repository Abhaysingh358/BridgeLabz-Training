
using UnitTesting;

namespace BridgeLabz.MSTests
{
    [TestClass]
    public class DatabaseConnectionMSTests
    {
        private DatabaseConnection db;

        [TestInitialize]
        public void Setup()
        {
            db = new DatabaseConnection();
            db.Connect();
        }

        [TestCleanup]
        public void Cleanup()
        {
            db.Disconnect();
        }

        [TestMethod]
        public void Connection_ShouldBeOpen_BeforeEachTest()
        {
            Assert.IsTrue(db.IsConnected);
        }

        [TestMethod]
        public void Connection_ShouldRemainOpen_DuringTest()
        {
            Assert.IsTrue(db.IsConnected);
        }
    }
}
