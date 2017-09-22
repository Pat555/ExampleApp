using ExampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleApp.Controllers
{
    public class HomeController : Controller
    {
        IRepository repo;

        public HomeController(IRepository repoImpl)
        {
            repo = repoImpl;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View(repo.Products);
        }
    }
}