using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Berk.Models;

namespace Berk.Repositories
{
    public interface IMessageRepository
    {
        List<Message> Messages { get; }
        void AddMessage(Message message);
        Message GetMessageBySender(string name);
        Message GetMessageByTime(DateTime time);
    }
}
