
using UnitTesting;

namespace BridgeLabz.MSTests
{
    [TestClass]
    public class BankAccountMSTests
    {
        private BankAccount account;

        [TestInitialize]
        public void Setup()
        {
            account = new BankAccount(1000);
        }

        [TestMethod]
        public void Deposit_IncreasesBalance()
        {
            account.Deposit(500);
            Assert.AreEqual(1500, account.GetBalance());
        }

        [TestMethod]
        public void Withdraw_DecreasesBalance()
        {
            account.Withdraw(300);
            Assert.AreEqual(700, account.GetBalance());
        }

        [TestMethod]
        public void Withdraw_MoreThanBalance_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => account.Withdraw(2000));
        }
    }
}
