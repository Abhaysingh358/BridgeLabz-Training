
using UnitTesting;

namespace BridgeLabz.NUnitTests
{
    public class TemperatureConverterNUnitTests
    {
        private TemperatureConverter converter;

        [SetUp]
        public void Setup()
        {
            converter = new TemperatureConverter();
        }

        [TestCase(0, 32)]
        [TestCase(100, 212)]
        [TestCase(37, 98.6)]
        public void CelsiusToFahrenheit_WorksCorrectly(double celsius, double expected)
        {
            Assert.AreEqual(expected, converter.CelsiusToFahrenheit(celsius), 0.01);
        }

        [TestCase(32, 0)]
        [TestCase(212, 100)]
        [TestCase(98.6, 37)]
        public void FahrenheitToCelsius_WorksCorrectly(double fahrenheit, double expected)
        {
            Assert.AreEqual(expected, converter.FahrenheitToCelsius(fahrenheit), 0.01);
        }
    }
}
