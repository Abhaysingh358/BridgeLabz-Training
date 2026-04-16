
using UnitTesting;

namespace BridgeLabz.MSTests
{
    [TestClass]
    public class MathUtilsMSTests
    {
        private MathUtils math;

        [TestInitialize]
        public void Setup()
        {
            math = new MathUtils();
        }

        [TestMethod]
        public void Divide_ByZero_ThrowsArithmeticException()
        {
            Assert.Throws<ArithmeticException>(() => math.Divide(10, 0));
        }
    }
}
