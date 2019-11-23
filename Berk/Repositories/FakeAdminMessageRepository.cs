using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Berk.Models;

namespace Berk.Repositories
{
    public class FakeAdminMessageRepository : IAdminMessageRepository
    {
        private List<Message> messages = new List<Message>();

        public List<Message> Messages { get { return messages; } }

        public FakeAdminMessageRepository()
        {
            AddTestData();
        }

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

        public void AddTestData()
        {
            Member member = new Member();
            Message message = new Message()
            {
                MemberName = "Lisa Beau",
                MessageText = "Welcome to Berk!",
                Sent = new DateTime(2019, 10, 16, 10, 45, 32)
            };
            member.Name = message.MemberName;
            member.Messages.Add(message);
            messages.Add(message);

            message = new Message()
            {
                MemberName = "Travis Luthern",
                MessageText = "If you have any questions, feel free to contact us!",
                Sent = new DateTime(2019, 10, 16, 11, 00, 12)
            };
            member.Name = message.MemberName;
            member.Messages.Add(message);
            messages.Add(message);

            message = new Message()
            {
                MemberName = "Ulfric Stormheart",
                MessageText = "This is Berk's new website.",
                Sent = new DateTime(2019, 10, 16, 8, 00, 42)
            };
            member.Name = message.MemberName;
            member.Messages.Add(message);
            messages.Add(message);
        }
    }
}
