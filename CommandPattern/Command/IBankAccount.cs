namespace Command.Command
{
    public interface IBankAccount
    {
        void Deposit(int amount);
        bool Withdraw(int amount);
        void CheckBalance();
    }
}