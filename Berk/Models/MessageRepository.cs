﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berk.Models
{
    // Temp class to store messages and for testing purposes
    public static class MessageRepository
    {
        private static List<Message> messages = new List<Message>();

        public static List<Message> Messages { get { return messages; } }
        
        static MessageRepository()
        {
            AddTestData();
        }

        public static void AddMessage(Message message)
        {
            messages.Add(message);
        }

        public static Message GetMessageBySender(String name)
        {
            Message message = messages.Find(m => m.MemberName == name);
            return message;
        }

        public static Message GetMessageByTime(DateTime sent)
        {
            Message message = messages.Find(m => m.Sent == sent);
            return message;
        }

        static void AddTestData()
        {
            Message message = new Message()
            {
                MemberName = "Lisa Beau",
                MessageText = "Welcome to Berk!",
                Sent = new DateTime(2019, 10, 16, 10, 45, 32)
            };
            messages.Add(message);

            message = new Message()
            {
                MemberName = "Travis Luthern",
                MessageText = "If you have any questions, feel free to contact us!",
                Sent = new DateTime(2019, 10, 16, 11, 00, 12)
            };
            messages.Add(message);

            message = new Message()
            {
                MemberName = "Ulfric Stormheart",
                MessageText = "This is Berk's new website.",
                Sent = new DateTime(2019, 10, 16, 8, 00, 42)
            };
            messages.Add(message);
        }
        
        /*public static void ContactPage(Message message)
        {
            messages.Add(message);
        }

        public static void MessageBoard(Message message)
        {
            messages.Add(message);
        }*/
    }
}
