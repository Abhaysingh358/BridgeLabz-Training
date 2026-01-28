
using UnitTesting;

namespace BridgeLabz.NUnitTests
{
    public class BankAccountNUnitTests
    {
        private BankAccount account;

        [SetUp]
        public void Setup()
        {
            account = new BankAccount(1000);
        }

        [Test]
        public void Deposit_IncreasesBalance()
        {
            account.Deposit(500);

            Assert.AreEqual(1500, account.GetBalance());
        }

        [Test]
        public void Withdraw_DecreasesBalance()
        {
            account.Withdraw(300);

            Assert.AreEqual(700, account.GetBalance());
        }

        [Test]
        public void Withdraw_MoreThanBalance_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => account.Withdraw(2000));
        }
    }
}
