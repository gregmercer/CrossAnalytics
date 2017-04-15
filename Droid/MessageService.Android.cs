using System;

namespace CrossAnalytics.Droid
{
    public class MessageService : IMessage
    {
        public MessageService()
        {
        }
        public string getMessage()
        {
            return "Message from Android";
        }
    }
}
