
using UnitTesting;

namespace BridgeLabz.MSTests
{
    [TestClass]
    public class PasswordValidatorMSTests
    {
        private PasswordValidator validator;

        [TestInitialize]
        public void Setup()
        {
            validator = new PasswordValidator();
        }

        [DataTestMethod]
        [DataRow("Password1", true)]
        [DataRow("StrongPass9", true)]
        [DataRow("weakpass1", false)]
        [DataRow("SHORT1", false)]
        [DataRow("NoNumber", false)]
        public void Password_Validation_WorksCorrectly(string password, bool expected)
        {
            Assert.AreEqual(expected, validator.IsValid(password));
        }
    }
}
