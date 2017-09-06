using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using doyouknowme.Models;

namespace doyouknowme.Controllers
{
    public class profileController : Controller
    {
        [HttpGet]
        public IActionResult user(int id)
        {
            return View("user");
        }

        [HttpPost]
        public IActionResult add(UserProfile profile)
        {
            ViewBag.name = profile.uname;
            ViewBag.id = profile.id;
            ViewBag.email = profile.email;
            ViewBag.picture = profile.picture;
            return View("user");
        }
    }
}