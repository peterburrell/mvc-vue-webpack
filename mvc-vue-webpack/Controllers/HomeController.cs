using System;
using System.Linq;
using System.Threading;
using System.Web.Mvc;

namespace mvc_vue_webpack.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Page1()
        {
            return View();
        }

        public ActionResult Page2()
        {
            return View();
        }

        public ActionResult Page3()
        {
            return View();
        }

        [Route("api/products")]
        public JsonResult GetProducts()
        {
            // simulate delay
            Thread.Sleep(1500);

            var random = new Random();

            var products = Enumerable.Range(1, 20).Select(n => new
            {
                id = n,
                name = $"Product {n}",
                price = random.NextDouble() * 100,
                inventory = random.Next(0, 1000),
                lastUpdated = DateTime.UtcNow.AddDays(-random.Next(100)).ToString("O")
            });

            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}