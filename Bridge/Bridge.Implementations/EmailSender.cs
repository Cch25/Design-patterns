using System;

namespace Bridge.Bridge.Implementations
{
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string subject, string body, string CC)
        {
            Console.WriteLine($"{GetType().Name}: Called via the email.");
            string message = !string.IsNullOrEmpty(CC) ?
                $"Subject: {subject} \nBody: {body} \nCC: {CC}" :
                $"Subject: {subject} \nBody: {body}";
            Console.WriteLine(message);

        }
    }
}
