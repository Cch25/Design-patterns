namespace Command.Command
{
    public interface ICommandHandler
    {
        void SetCommand(ICommand command);
        void Invoke(CommandType commandType);
    }
}