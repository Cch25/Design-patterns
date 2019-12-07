using System;

namespace Bridge.Bridge.Implementations
{
    public class SMSSender : IMessageSender
    {
        public void SendMessage(string subject, string body, string CC)
        {
            Console.WriteLine($"Called via the sms.");
            string message = !string.IsNullOrEmpty(CC)            ?
                    $"Subject: {subject} \nBody: {body} \nCC: {CC}" :
                    $"Subject: {subject} \nBody: {body}";
            Console.WriteLine(message);
        }
    }
}
