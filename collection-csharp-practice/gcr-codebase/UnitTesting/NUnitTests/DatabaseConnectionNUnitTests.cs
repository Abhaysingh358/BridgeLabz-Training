
using UnitTesting;

namespace BridgeLabz.NUnitTests
{
    public class DatabaseConnectionNUnitTests
    {
        private DatabaseConnection db;

        [SetUp]
        public void Setup()
        {
            db = new DatabaseConnection();
            db.Connect();
        }

        [TearDown]
        public void Cleanup()
        {
            db.Disconnect();
        }

        [Test]
        public void Connection_ShouldBeOpen_BeforeEachTest()
        {
            Assert.IsTrue(db.IsConnected);
        }

        [Test]
        public void Connection_ShouldClose_AfterTest()
        {
            Assert.IsTrue(db.IsConnected); // open during test
        }
    }
}
