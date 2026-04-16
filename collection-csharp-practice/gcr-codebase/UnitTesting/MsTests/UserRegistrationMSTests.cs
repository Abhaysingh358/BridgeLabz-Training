
using UnitTesting;

namespace BridgeLabz.MSTests
{
    [TestClass]
    public class UserRegistrationMSTests
    {
        private UserRegistration registration;

        [TestInitialize]
        public void Setup()
        {
            registration = new UserRegistration();
        }

        [TestMethod]
        public void RegisterUser_ValidInputs_ReturnsTrue()
        {
            Assert.IsTrue(registration.RegisterUser("abhay", "abhay@gmail.com", "Password1"));
        }

        [DataTestMethod]
        [DataRow("", "test@gmail.com", "Password1")]
        [DataRow("user", "invalidemail", "Password1")]
        [DataRow("user", "test@gmail.com", "short")]
        public void RegisterUser_InvalidInputs_ThrowsException(string user, string email, string password)
        {
            Assert.Throws<ArgumentException>(() =>
                registration.RegisterUser(user, email, password));
        }
    }
}
