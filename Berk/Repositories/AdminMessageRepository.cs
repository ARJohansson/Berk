using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Berk.Models;
using Microsoft.EntityFrameworkCore;

namespace Berk.Repositories
{
    public class AdminMessageRepository : IAdminMessageRepository
    {
        private AppDbContext context;
        private static List<Message> messages = new List<Message>();

        public List<Message> Messages { get { return context.Messages.ToList(); } }

        public AdminMessageRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
        }

        public void AddMessage(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
        }

        public Message GetMessageBySender(String name)
        {
            Message message;
            message = context.Messages.First(m => m.MemberName == name);
            return message;
        }

        public Message GetMessageByTime(DateTime sent)
        {
            Message message;
            message = context.Messages.First(m => m.Sent == sent);
            return message;
        }
    }
}
