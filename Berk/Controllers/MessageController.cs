﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Berk.Models;

namespace Berk.Controllers
{
    public class MessageController : Controller
    {
        Message message;
        Member member = new Member();
        /*public MessageController()
        {
            if (MessageRepository.Messages.Count == 0)
            {
                member.Name = "Lisa Beau";
                message = new Message()
                {
                    MemberName = member.Name,
                    MessageText = "Welcome to Berk!"
                };
                MessageRepository.ContactPage(message);
            }
        }*/

        // Returns the view from the Message Board this is
        // the Index for the MessageController
        public IActionResult Index(DateTime sent)
        {
            return View("MessageBoard", sent);
        }
        
        [HttpPost]
        public RedirectToActionResult MessageBoard(string memberName, string messageText,
                                                        DateTime sent)
        {
            message = new Message { Sent = sent };
            message.MemberName = memberName;
            message.MessageText = messageText;
            MessageRepository.AddMessage(message);

            return RedirectToAction("MessageAdmin");
        }

        // Returns the view from the ContactPage View
        public IActionResult ContactPage(DateTime sent)
        {
            return View("ContactPage", sent);
        }

        // Posts the message from the ContactPage form into the Message page
        [HttpPost]
        public RedirectToActionResult ContactPage(string memberName, string messageText,
                                                    DateTime sent)
        {
            message = new Message { Sent = sent };
            message.MemberName = memberName;
            message.MessageText = messageText;
            MessageRepository.AddMessage(message);

            return RedirectToAction("Messages");
        }

        // Returns the view from the Messages View
        public IActionResult Messages()
        {
            List<Message> messages = MessageRepository.Messages;
            messages.Sort((m1, m2) => DateTime.Compare(m1.Sent, m2.Sent));
            return View(messages);
        }

        public IActionResult MessageAdmin()
        {
            List<Message> messages = MessageRepository.Messages;
            messages.Sort((m1, m2) => DateTime.Compare(m1.Sent, m2.Sent));
            return View(messages);
        }
    }
}