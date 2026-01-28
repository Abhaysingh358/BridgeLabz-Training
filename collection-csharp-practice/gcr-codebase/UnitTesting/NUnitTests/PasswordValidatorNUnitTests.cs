
using UnitTesting;

namespace BridgeLabz.NUnitTests
{
    public class PasswordValidatorNUnitTests
    {
        private PasswordValidator validator;

        [SetUp]
        public void Setup()
        {
            validator = new PasswordValidator();
        }

        [TestCase("Password1", true)]
        [TestCase("StrongPass9", true)]
        [TestCase("weakpass1", false)]   // no uppercase
        [TestCase("SHORT1", false)]      // too short
        [TestCase("NoNumber", false)]    // no digit
        public void Password_Validation_WorksCorrectly(string password, bool expected)
        {
            Assert.AreEqual(expected, validator.IsValid(password));
        }
    }
}
