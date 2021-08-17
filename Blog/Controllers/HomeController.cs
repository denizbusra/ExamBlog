using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            MyPostGenerator generator = new MyPostGenerator();
            return View(generator.GeneratePost().Take(2).ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult AllPost()
        {
            MyPostGenerator generator = new MyPostGenerator();
            return View(generator.GeneratePost());
        }

        public IActionResult PostDetail(int id)
        {
            MyPostGenerator generator = new MyPostGenerator();
            MyPost blog = generator.GeneratePost().Where(x => x.Id == id).FirstOrDefault();
            return View(blog);
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
