using NUnit.Framework;

namespace CoreLogic.NUnitTests;

[TestFixture]
public class BankAccountUnitTest
{
    [Test]
    public void Test_Deposit_ValidAmount()
    {
        BankAccount account = new BankAccount(100m);

        account.Deposit(50m);

        Assert.That(account.Balance, Is.EqualTo(150m));
    }

    [Test]
    public void Test_Deposit_NegativeAmount()
    {
        BankAccount account = new BankAccount(100m);

        Exception ex = Assert.Throws<Exception>(() => account.Deposit(-20m));

        Assert.That(ex.Message, Is.EqualTo("Deposit amount cannot be negative"));
    }

    [Test]
    public void Test_Withdraw_ValidAmount()
    {
        BankAccount account = new BankAccount(200m);

        account.Withdraw(80m);

        Assert.That(account.Balance, Is.EqualTo(120m));
    }

    [Test]
    public void Test_Withdraw_InsufficientFunds()
    {
        BankAccount account = new BankAccount(50m);

        Exception ex = Assert.Throws<Exception>(() => account.Withdraw(100m));

        Assert.That(ex.Message, Is.EqualTo("Insufficient funds."));
    }
}
