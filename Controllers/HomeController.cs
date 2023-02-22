using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult add()
        {
            try
            {
                int num1 = Convert.ToInt32(HttpContext.Request.Form["txtfirst"].ToString());
                int num2 = Convert.ToInt32(HttpContext.Request.Form["txtsecond"].ToString());

                int sum = num1 + num2;

                ViewBag.SumResult = sum.ToString();
            }

            catch(Exception)
            {
                ViewBag.SumResult = "Wrong Input";
            }

            return View("index");
        }

        public IActionResult minus()
        {
            try
            {
                int num1 = Convert.ToInt32(HttpContext.Request.Form["txtfirst"].ToString());
                int num2 = Convert.ToInt32(HttpContext.Request.Form["txtsecond"].ToString());

                int minus = num1 - num2;

                ViewBag.MinResult = minus.ToString();
            }

            catch (Exception)
            {
                ViewBag.MinResult = "Wrong Input";
            }

            return View("index");
        }

        public IActionResult mul()
        {
            try
            {
                int num1 = Convert.ToInt32(HttpContext.Request.Form["txtfirst"].ToString());
                int num2 = Convert.ToInt32(HttpContext.Request.Form["txtsecond"].ToString());

                int mul = num1 * num2;

                ViewBag.MinResult = mul.ToString();
            }

            catch (Exception)
            {
                ViewBag.MulResult = "Wrong Input";
            }

            return View("index");
        }

        public IActionResult div()
        {
            try
            {
                int num1 = Convert.ToInt32(HttpContext.Request.Form["txtfirst"].ToString());
                int num2 = Convert.ToInt32(HttpContext.Request.Form["txtsecond"].ToString());

                int div = num1 / num2;

                ViewBag.MinResult = div.ToString();
            }

            catch (Exception)
            {
                ViewBag.DivResult = "Wrong Input";
            }

            return View("index");
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