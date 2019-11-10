using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Berk.Models;
using Microsoft.AspNetCore.Mvc;

namespace Berk.Controllers
{
    public class PracticeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public RedirectResult Redirect()
        {
            return Redirect("/Practice/CodeType");
        }

        public ContentResult ContentResult()
        {
            String welcome = "Welcome to the Practice pages!";
            return Content(welcome);
        }

        public String CodeType()
        {
            String str1 = "My TypeCode practice.";
            TypeCode g = str1.GetTypeCode();
            String print = "The Typcode for: '" + str1 + "' is: " + g.ToString("D") + 
                ". Which means it is a " + str1.GetTypeCode();
            return print;
        }

        public JsonResult Object()
        {
            object obj;
            Random num = new Random();
            int i = num.Next(5) + 1;
            if (i == 1)
            {
                obj = "string object";
            }
            else if (i == 2)
            {
                obj = 15;
            }
            else if (i == 3)
                obj = 2.00;
            else if (i == 4)
            {
                obj = new Member()
                {
                    Name = "Allison",
                    Email = "allisonjames@yahoo.com",
                    Joined = new DateTime(2007, 10, 10)
                };
            }
            else
                obj = 'c';
            return Json(obj);
        }
    }
}