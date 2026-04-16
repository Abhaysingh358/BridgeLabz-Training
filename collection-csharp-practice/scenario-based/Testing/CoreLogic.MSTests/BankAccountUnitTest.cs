namespace CoreLogic.MSTests;

[TestClass]
public sealed class BankAccountUnitTest
{
    [TestMethod]
    public void Test_Deposit_ValidAmount()
    {
        BankAccount account  = new BankAccount(100m);
        account.Deposit(50m);
        Assert.AreEqual(150m,account.Balance);
    }

   [TestMethod]
    public void Test_Deposit_NegativeAmount()
    {
        BankAccount account = new BankAccount(100m);

        Exception ex = Assert.Throws<Exception>(() => account.Deposit(-20m));

        Assert.AreEqual("Deposit amount cannot be negative", ex.Message);
    }

    [TestMethod]
    public void Test_Withdraw_ValidAmount()
    {
        BankAccount account = new BankAccount(200m);

        account.Withdraw(80m);

        Assert.AreEqual(120m, account.Balance);
    }


    [TestMethod]
    public void Test_Withdraw_InsufficientFunds()
    {
        BankAccount account = new BankAccount(50m);

        Exception ex = Assert.Throws<Exception>(() => account.Withdraw(100m));

        Assert.AreEqual("Insufficient funds.", ex.Message);
    }

    
}
