using Bridge.Bridge.Abstractions;
using Bridge.Bridge.Implementations;
using System;

namespace Bridge
{
    public class BridgeDemo
    {

        public void BridgePattern()
        {
            Console.WriteLine("***Server message***");
            Message message = new SystemMessage("Hi", "this is my content");
            message.Send();
            Console.WriteLine("\n***User message***");
            Message userMessage = new UserMessage("Hi", "c.chiritoiu07@gmail.com", "How are you?");
            userMessage.MessageSender = new SMSSender();
            userMessage.Send();
        }
    }
}
