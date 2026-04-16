
using UnitTesting;

namespace BridgeLabz.NUnitTests
{
    public class MathUtilsNUnitTests
    {
        private MathUtils math;

        [SetUp]
        public void Setup()
        {
            math = new MathUtils();
        }

        [Test]
        public void Divide_ByZero_ThrowsArithmeticException()
        {
            Assert.Throws<ArithmeticException>(() => math.Divide(10, 0));
        }
    }
}
