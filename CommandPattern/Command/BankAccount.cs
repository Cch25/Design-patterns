using System;

namespace Command.Command
{
    public class BankAccount : IBankAccount
    {
        private int _balance;
        public BankAccount()
        {
        }
        public void Deposit(int amount)
        {
            _balance += amount;
        }

        public bool Withdraw(int amount)
        {
            if (_balance - amount > 0)
            {
                _balance -= amount;
                return true;
            }
            return false;
        }
        public void CheckBalance()
        {
            Console.WriteLine($"You have {_balance:C} in our bank.");
        }
    }
}