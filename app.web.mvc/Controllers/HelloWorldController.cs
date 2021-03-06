﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace app.web.mvc.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/
        public IActionResult Welcome(string name, int numTimes = 1, int ID = 1)
        {
            ViewData["Message"] = $"Hello {name}";
            ViewData["NumTimes"] = numTimes;
            ViewData["ID"] = ID;
            return View();
        }
    }
}
