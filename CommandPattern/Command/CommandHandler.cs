using System.Collections.Generic;

namespace Command.Command
{
    public class CommandHandler : ICommandHandler
    {
        private List<ICommand> _commands;
        public CommandHandler()
        {
            _commands = new List<ICommand>();
        }
        public void SetCommand(ICommand command)
        {
            _commands.Add(command);
        }
        public void Invoke(CommandType commandType)
        {
            switch (commandType)
            {
                case CommandType.Do:
                    _commands.ForEach(x => x.Call());
                    break;
                case CommandType.Undo:
                    _commands.ForEach(x => x.Undo());
                    break;
                default:
                    break;
            }
        }
    }
}