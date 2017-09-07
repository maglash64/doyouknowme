using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using doyouknowme.Models;

namespace doyouknowme.Controllers
{
    public static class UserData
    {
        public static UserProfile profile;
    }
    public class profileController : Controller
    {
        [HttpGet]
        public IActionResult user(string id)
        {
            ViewBag.name = UserData.profile.uname;
            ViewBag.email = UserData.profile.email;
            ViewBag.picture = "src=" + UserData.profile.picture;
            return View("user");
        }

        [HttpPost]
        public IActionResult add(UserProfile profile)
        {
            UserData.profile = profile;
            return RedirectToAction("user","profile",new{ id = profile.id } );
        }
    }
}