using Bridge.Bridge.Implementations;

namespace Bridge.Bridge.Abstractions
{
    /// <summary>
    /// Refined abstractization
    /// </summary>
    public class UserMessage : Message
    {
        public string CC { get; set; }
        public UserMessage(IMessageSender messageSender, string subject, string body) : base(messageSender, subject, body)
        {
        }
        public UserMessage(string subject, string body) : base(new EmailSender(), subject, body)
        {

        }
        public UserMessage(string subject, string cc, string body) : base(new EmailSender(), subject, body)
        {
            CC = cc;
        }

        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body, CC);
        }
    }
}
