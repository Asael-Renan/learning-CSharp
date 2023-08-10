using Exeption.Entities.Exceptions;

namespace Exeption.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string? Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdralLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdralLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new InvalidWithdrawalException("withdrawal limit exceeded");
            }
            else if (Balance < amount)
            {
                throw new InvalidWithdrawalException("not enough balance");
            }
            else
            {
                Balance -= amount;
            }
        }
    }
}