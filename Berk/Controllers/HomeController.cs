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
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Berk.Models;

namespace Berk.Controllers
{
    public class HomeController : Controller
    {
        // Returns the view from the MyView View Page
        public IActionResult Index()
        {
            return View("MyView");
        }


        // Returns the view from the Info View Page
        public IActionResult History()
        {
            return View();
        }
    }
}