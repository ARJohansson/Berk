/*
    * Author: Ashley Johansson
    * Date Created: 10/17/19 4:00 PM
    * Date Updated: 11/21/19  1:54 PM
    * A Controller for Berk Related Views
    * such as Information, Loccation, and VIP pages
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Berk.Models;
using Berk.Repositories;

namespace Berk.Controllers
{
    public class BerkController : Controller
    {
        ILocationRepository lRepo;
        IPeopleRepository pRepo;
        public BerkController(ILocationRepository lR, IPeopleRepository pR)
        {
            lRepo = lR;
            pRepo = pR;
        }
        //Returns the view from the History View Page, this is the
        // Index for the BerkController
        public IActionResult Index()
        {
            return View("Info");
        }

        // Returns the view from the Info View Page
        public IActionResult Info()
        {
            return View("Info");
        }

        // Returns the view from the Locations View Page
        public IActionResult Locations()
        {
            List<Location> locations = lRepo.Locations;
            locations.Sort((pl1, pl2) => string.Compare( pl1.Name, pl2.Name, StringComparison.Ordinal));
            return View(locations);
        }

        // Returns the view from the VIP View Page
        public IActionResult VIP()
        {
            List<VIP> people = pRepo.VIPs;
            people.Sort((vip1, vip2) => string.Compare(vip1.Name, vip2.Name, StringComparison.Ordinal));
            return View(people);
        }

        public IActionResult AddComment(string place)
        {
            return View("AddComment", HttpUtility.HtmlDecode(place));
        }

        [HttpPost]
        public RedirectToActionResult AddComment(string place, 
                                                 string memberName,
                                                 string commentText)
        {
            Location location = lRepo.GetLocationByName(place);
            location.Commments.Add(new Comment()
            {
                Sender = memberName,
                MemberName = new Member() { Name = memberName },
                CommentText = commentText
            });
            return RedirectToAction("Locations");
        }
    }
}