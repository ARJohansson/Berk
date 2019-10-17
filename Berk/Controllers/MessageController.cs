using System;
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
        public MessageController()
        {
            if (MessageRepository.Messages.Count == 0)
            {
                message = new Message()
                {
                    Sender = "Lisa Beau",
                    MessageText = "Welcome to Berk!"
                };
                MessageRepository.ContactPage(message);
            }
        }

        // Returns the view from the Message Board this is
        // the Index for the MessageController
        public IActionResult Index()
        {
            return View("MessageBoard");
        }

        // Returns the view from the ContactPage View
        public IActionResult ContactPage()
        {
            return View();
        }

        // Posts the message from the ContactPage form into the Message page
        [HttpPost]
        public RedirectToActionResult ContactPage(string sender, string messageText)
        {
            message = new Message();
            message.Sender = sender;
            message.MessageText = messageText;
            MessageRepository.ContactPage(message);

            return RedirectToAction("Messages");
        }

        // Returns the view from the Messages View
        public IActionResult Messages()
        {
            List<Message> messages = MessageRepository.Messages;
            return View(messages);
        }
    }
}