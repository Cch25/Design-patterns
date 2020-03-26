namespace Command.Command
{
    public class CommandPattern
    {
        public void Command()
        {
            BankAccount ba = new BankAccount();
            ICommandHandler commandHandler = new CommandHandler();
            commandHandler.SetCommand(new Command(ba, 100, ActionType.Deposit));
            commandHandler.SetCommand(new Command(ba, 50, ActionType.Withdraw));
            commandHandler.Invoke(CommandType.Do);
            commandHandler.Invoke(CommandType.Undo);
        }
    }
}