using Bridge.Bridge.Implementations;

namespace Bridge.Bridge.Abstractions
{
    public abstract class Message
    {
        public IMessageSender MessageSender { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public Message(IMessageSender messageSender, string subject, string body)
        {
            MessageSender = messageSender;
            Subject = subject;
            Body = body;
        }
        public abstract void Send();
    }
}
