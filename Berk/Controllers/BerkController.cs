/*
    * Author: Ashley Johansson
    * Date Created: 10/17/19 4:00 PM
    * Date Updated: 10/17/19  6:37 AM
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
            List<Location> locations = LocationRepository.Locations;
            locations.Sort((pl1, pl2) => string.Compare( pl1.Name, pl2.Name, StringComparison.Ordinal));
            return View(locations);
        }

        // Returns the view from the VIP View Page
        public IActionResult VIP()
        {
            List<VIP> people = PeopleRepository.VIPs;
            people.Sort((vip1, vip2) => string.Compare(vip1.Name, vip2.Name, StringComparison.Ordinal));
            return View(people);
        }
    }
}