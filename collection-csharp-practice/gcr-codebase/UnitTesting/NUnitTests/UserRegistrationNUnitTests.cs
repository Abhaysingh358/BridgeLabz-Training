
using UnitTesting;

namespace BridgeLabz.NUnitTests
{
    public class UserRegistrationNUnitTests
    {
        private UserRegistration registration;

        [SetUp]
        public void Setup()
        {
            registration = new UserRegistration();
        }

        [Test]
        public void RegisterUser_ValidInputs_ReturnsTrue()
        {
            Assert.IsTrue(registration.RegisterUser("abhay", "abhay@gmail.com", "Password1"));
        }

        [TestCase("", "test@gmail.com", "Password1")]
        [TestCase("user", "invalidemail", "Password1")]
        [TestCase("user", "test@gmail.com", "short")]
        public void RegisterUser_InvalidInputs_ThrowsException(string user, string email, string password)
        {
            Assert.Throws<ArgumentException>(() =>
                registration.RegisterUser(user, email, password));
        }
    }
}
