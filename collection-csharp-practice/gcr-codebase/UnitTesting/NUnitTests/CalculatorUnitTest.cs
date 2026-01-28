
using UnitTesting;
using NUnit.Framework;

namespace BridgeLabz.NUnitTests
{
    public class CalculatorUnitTest
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_ReturnsCorrectSum()
        {
            Assert.AreEqual(10,calculator.Add(5,5));
        }

        [Test]
        public void Subtract_ReturnsCorrectDifference()
        {
            Assert.AreEqual(4 ,calculator.Subtract(9,5));
        }

        [Test]
        public void Multiply_ReturnsCorrectProduct()
        {
            Assert.AreEqual(20, calculator.Multiply(4, 5));
        }

        [Test]
        public void Divide_ReturnsCorrectQuotient()
        {
            Assert.AreEqual(5, calculator.Divide(10, 2));
        }

        [Test]

        public void DivideByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
    }
}