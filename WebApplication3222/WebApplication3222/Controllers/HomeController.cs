using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3222.Models;
using WebApplication3222.Services;

namespace WebApplication3222.Controllers
{
    public class HomeController : Controller
    {

        static List<int> listIs = new List<int> { };
        static List<int> listIncr = new List<int> { };
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Index(string myTextbox, [FromServices] ISort listSort)
        {
            listSort.Sort(); //DI 4

            int temp = Convert.ToInt32(myTextbox);
            listIs.Add(temp);

            ViewBag.Name = string.Join(", ", listIs);

            listIs.Sort();
            ViewBag.Sort = string.Join(", ", listIs);


            return View("Index");
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
