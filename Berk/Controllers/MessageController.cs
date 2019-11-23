/*
    * Author: Ashley Johansson
    * Date Created: 10/17/19 4:00 PM
    * Date Updated: 11/21/19  2:19 PM
    * A Controller for Message Related Views
    * such as Index, MessageAdmin, MessageBoard
    * and ContactPage
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Berk.Models;
using Berk.Repositories;

namespace Berk.Controllers
{
    public class MessageController : Controller
    {
        // Declares global variables
        IMessageRepository mRepo;
        IAdminMessageRepository aRepo;
        Message message;
        Member member = new Member();

        // Public controller constructor takes a message repository
        // and an admin message repository as parameters
        public MessageController(IMessageRepository mR, IAdminMessageRepository aR)
        {
            mRepo = mR;
            aRepo = aR;
            // If the message Repository is empty, add a new message
            if (mRepo.Messages.Count == 0)
            {
                message = new Message()
                {
                    MemberName = "Lisa Beau",
                    MessageText = "Welcome to Berk!",
                    Sent = new DateTime(2019, 10, 16, 10, 45, 32)
                };
                member.Name = message.MemberName;
                member.Messages.Add(message);
                mRepo.AddMessage(message);
            }

            // If the admin message repository is empty, add a new message
            if (aRepo.Messages.Count == 0)
            {
                message = new Message()
                {
                    MemberName = "Lisa Beau",
                    MessageText = "Welcome to Berk! If you have any questions " +
                        "feel free to contact us. Happy Dragon Training!",
                    Sent = new DateTime(2019, 10, 16, 10, 45, 32)
                };
                member.Name = message.MemberName;
                member.Messages.Add(message);
                aRepo.AddMessage(message);
            }
        }

        // Returns the view from the Message Board this is
        // the Index for the MessageController
        [HttpGet]
        public IActionResult Index()
        {
            List<Message> messages = mRepo.Messages;

            ViewData["recentMessage"] = messages[messages.Count - 1].MemberName;
            messages.Sort((m1, m2) => (m1.Sent.CompareTo(m2.Sent)));
            ViewBag.messageCount = messages.Count;
            return View(messages);
        }

        // Returns the view from the ContactPage
        public IActionResult ContactPage()
        {
            return View();
        }

        // Posts the message from the ContactPage form into the Message page
        // It contains a list of messages to/from Berk members
        [HttpPost]
        public RedirectToActionResult ContactPage(string memberName, string messageText,
                                                    DateTime sent)
        {
            message = new Message { Sent = sent };
            Member user = (new Member() { Name = memberName });
            message.MemberName = memberName;
            message.MessageText = messageText;
            mRepo.AddMessage(message);

            return RedirectToAction("Index");
        }

        // Returns the view from the MessageBoard
        public IActionResult MessageBoard(DateTime sent, string name)
        {
            return View("MessageBoard", HttpUtility.HtmlDecode(name));
        }

        // Posts the message from the MessageBoard to the Admin Message Page
        [HttpPost]
        public RedirectToActionResult MessageBoard(string memberName, string messageText, 
                                                    DateTime sent)
        {
            Message m2 = new Message { Sent = sent };
            //Message m2 = AdminMessageRepository.GetMessageByTime(sent);
            m2.MemberName = memberName;
            m2.MessageText = messageText;
            aRepo.AddMessage(m2);

            return RedirectToAction("MessageAdmin");
        }

        // Return the view from the MessageAdmin page
        // It contains is a list of messages to/from Berk Admins
        public IActionResult MessageAdmin()
        {
            List<Message> messages = aRepo.Messages;
            messages.Sort((m1, m2) => (m1.Sent.CompareTo(m2.Sent)));
            return View("MessageAdmin", messages);
        }
    }
}