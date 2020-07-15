using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab20.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab20.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Summary(Registration registration)
        {
            return View(registration);
        }
    }
}
