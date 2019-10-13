using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berk.Models
{
    // Temp class to store messages and for testing purposes
    public class MessageRepository
    {
        private static List<Message> messages = new List<Message>();

        public static List<Message> Messages { get { return messages; } }
        public static void AddMessage(Message message)
        {
            messages.Add(message);
        }
    }
}
