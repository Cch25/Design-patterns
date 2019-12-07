using System;

namespace Bridge.Bridge.Implementations
{
    public class VoiceMailSender : IMessageSender
    {
        public void SendMessage(string subject, string body, string CC)
        {
            Console.WriteLine($"Called via the voice mail.");
            string message = !string.IsNullOrEmpty(CC)            ?
                    $"Subject: {subject} \nBody: {body} \nCC: {CC}" :
                    $"Subject: {subject} \nBody: {body}";
            Console.WriteLine(message);
        }
    }
}
