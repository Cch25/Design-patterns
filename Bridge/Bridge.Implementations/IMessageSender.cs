namespace Bridge.Bridge.Implementations
{
    public interface IMessageSender //this will act as a bridge
    {
        void SendMessage(string subject, string body, string cc = "");
    }
}
