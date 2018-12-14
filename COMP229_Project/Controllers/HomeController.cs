using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using COMP229_Project.Models;

namespace COMP229_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "What is Banada?";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "How to contact Banana?";

            return View();
        }

        public IActionResult myWatch()
        {
            ViewData["Message"] = "How about myWatch???";
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
