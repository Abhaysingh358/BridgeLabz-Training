using UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BridgeLabz.MSTests
{
    [TestClass]
    public class CalculatorMSTests
    {
        private Calculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void Add_ReturnsCorrectSum()
        {
            Assert.AreEqual(10, calculator.Add(5, 5));
        }

        [TestMethod]
        public void Subtract_ReturnsCorrectDifference()
        {
            Assert.AreEqual(2, calculator.Subtract(5, 3));
        }

        [TestMethod]
        public void Multiply_ReturnsCorrectProduct()
        {
            Assert.AreEqual(20, calculator.Multiply(4, 5));
        }

        [TestMethod]
        public void Divide_ReturnsCorrectQuotient()
        {
            Assert.AreEqual(5, calculator.Divide(10, 2));
        }

        [TestMethod]

        public void Divide_ByZero_ShouldThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }


    }
}
