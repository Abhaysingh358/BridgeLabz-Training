

namespace UnitTesting
{
    public class BankAccount
    {
        private double balance;

        public BankAccount(double initialBalance = 0)
        {
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit must be positive");

            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal must be positive");

            if (amount > balance)
                throw new InvalidOperationException("Insufficient funds");

            balance -= amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
