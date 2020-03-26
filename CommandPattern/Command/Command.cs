using System;

namespace Command.Command
{
    public class Command : ICommand
    {
        private int _balance;
        private BankAccount _bankAccount;
        private ActionType _actionType;
        public Command(BankAccount bankAccount, int amount, ActionType actionType)
        {
            if (bankAccount is null)
            {
                throw new ArgumentNullException(nameof(bankAccount));
            }

            _bankAccount = bankAccount;
            _balance = amount;
            _actionType = actionType;

        }

        public void Call()
        {
            switch (_actionType)
            {
                case ActionType.Deposit:
                    _bankAccount.Deposit(_balance);
                    break;
                case ActionType.Withdraw:
                    _bankAccount.Withdraw(_balance);
                    break;
            }
            _bankAccount.CheckBalance();
        }
        public void Undo()
        {
            switch (_actionType)
            {
                case ActionType.Deposit:
                    _bankAccount.Withdraw(_balance);
                    break;
                case ActionType.Withdraw:
                    _bankAccount.Deposit(_balance);
                    break;
            }
            _bankAccount.CheckBalance();
        }
    }
}