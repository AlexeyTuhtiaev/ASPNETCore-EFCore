using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Web.Models;
using Dal;
using Dal.Entities;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepo _repo;

        public HomeController(IRepo repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            IEnumerable<User> users = _repo.GetAll();
            return View(users.ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
