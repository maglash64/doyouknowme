using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace doyouknowme.Controllers
{
    public class profileController : Controller
    {
        public IActionResult user()
        {
            return View();
        }
        public IActionResult user(int id)
        {
            return View();
        }
    }
}