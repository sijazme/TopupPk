using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using TopupPk.Models;

namespace TopupPk.Controllers
{
    public class HomeController : Controller
    {

        IServiceProvider _serviceProvider;
        public HomeController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public IActionResult Index()
        {
            using (var context = new TopupPkContext(
                _serviceProvider.GetRequiredService<DbContextOptions<TopupPkContext>>()))
            {

                if (context.Retailers.Any())
                {

                }
            }

           return View();
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
            return View();
        }
    }
}
