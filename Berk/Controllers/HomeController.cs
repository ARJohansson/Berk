/*
 * Author: Ashley Johansson
 * Date Created: 10/04/19 10:13 AM
 * Date Updated: 10/06/19  4:20 PM
 * Controls/Manages the site's View Pages, allowing them
 * to be viewed by the user
 * The Berk Community is a fan-made representation based on
 * the How To Train Your Dragon movies produced by Dreamworks, 
 * and based on the books by Cresida Cowell. I do not own the rights
 * to any of the characters, creatures, or locations mentioned in this site.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Berk.Models;

namespace Berk.Controllers
{
    public class HomeController : Controller
    {
        Message message;
        public HomeController()
        {
            if (MessageRepository.Messages.Count == 0)
            {
                message = new Message()
                {
                    Sender = "Lisa Beau",
                    MessageText = "Hi, is the repository working?"
                };
                MessageRepository.ContactPage(message);
            }
        }

        // Returns the view from the MyView View Page
        public IActionResult Index()
        {
            return View("MyView");
        }

        // Returns the view from the History View Page
        public IActionResult History()
        {
            return View();
        }
        
        // Returns the view from the MessageBoard View Page
        public IActionResult MessageBoard()
        {
            return View();
        }

        // Returns the view from the Info View Page
        public IActionResult Info()
        {
            return View();
        }
        
        // Returns the view from the Locations View Page
        public IActionResult Locations()
        {
            return View();
        }

        // Returns the view from the VIP View Page
        public IActionResult VIP()
        {
            return View();
        }

        // Returns the view from the ContactPage View
        public IActionResult ContactPage()
        {
            return View();
        }

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