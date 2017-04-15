using System;

namespace CrossAnalytics.iOS
{
    public class MessageService : IMessage
    {
        public MessageService()
        {
        }
        public string getMessage()
        {
            return "Message from iOS";
        }
    }
}
