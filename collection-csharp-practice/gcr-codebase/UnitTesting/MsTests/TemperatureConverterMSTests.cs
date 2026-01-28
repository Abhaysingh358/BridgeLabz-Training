
using UnitTesting;

namespace BridgeLabz.MSTests
{
    [TestClass]
    public class TemperatureConverterMSTests
    {
        private TemperatureConverter converter;

        [TestInitialize]
        public void Setup()
        {
            converter = new TemperatureConverter();
        }

        [DataTestMethod]
        [DataRow(0, 32)]
        [DataRow(100, 212)]
        [DataRow(37, 98.6)]
        public void CelsiusToFahrenheit_WorksCorrectly(double celsius, double expected)
        {
            Assert.AreEqual(expected, converter.CelsiusToFahrenheit(celsius), 0.01);
        }

        [DataTestMethod]
        [DataRow(32, 0)]
        [DataRow(212, 100)]
        [DataRow(98.6, 37)]
        public void FahrenheitToCelsius_WorksCorrectly(double fahrenheit, double expected)
        {
            Assert.AreEqual(expected, converter.FahrenheitToCelsius(fahrenheit), 0.01);
        }
    }
}
