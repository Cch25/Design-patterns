using Bridge.Bridge.Implementations;

namespace Bridge.Bridge.Abstractions
{
    /// <summary>
    /// Refined abstractization
    /// </summary>
    public class SystemMessage : Message
    {
        public SystemMessage(IMessageSender messageSender, string subject, string body) : base(messageSender, subject, body)
        {
        }
        public SystemMessage(string subject, string body) : this(new EmailSender(), subject, body)
        {

        }

        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body);
        }
    }
}
