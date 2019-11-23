using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Berk.Models;

namespace Berk.Repositories
{
    // Temp class to store messages and for testing purposes
    public class MessageRepository : IMessageRepository
    {
        private static List<Message> messages = new List<Message>();

        public List<Message> Messages { get { return messages; } }
        
        public void AddMessage(Message message)
        {
            messages.Add(message);
        }

        public Message GetMessageBySender(String name)
        {
            Message message = messages.Find(m => m.MemberName == name);
            return message;
        }

        public Message GetMessageByTime(DateTime sent)
        {
            Message message = messages.Find(m => m.Sent == sent);
            return message;
        }
        
    }
}
