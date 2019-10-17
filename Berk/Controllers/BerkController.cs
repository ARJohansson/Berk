using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Berk.Models;

namespace Berk.Controllers
{
    public class BerkController : Controller
    {
        //Returns the view from the History View Page, this is the
        // Index for the BerkController
        public IActionResult Index()
        {
            return View("Info");
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
    }
}