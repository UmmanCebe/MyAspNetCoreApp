using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers
{

    public class Productt
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.name = "Umman Cebe";
            //ViewData["age"] = 30;

            //ViewData["names"] = new List<string>() { "Ahmet", "Mehmet", "Ayşe" };

            //TempData["name"] = "Umman Cebe";

            var productList = new List<Productt>()
            {
                new () { Id = 1, Name = "Kalem" },
                new () { Id = 2, Name = "Defter" },
                new () { Id = 3, Name = "Silgi" }
            };

            return View(productList);
        }

        public IActionResult Index2()
        {
            //return View();
            return RedirectToAction("Index");
        }

        public IActionResult Index3()
        {
            return View();

        }

        public IActionResult ParameterResult(int id)
        {
            return RedirectToAction("JsonResultParameter", new { id = id });
        }

        public IActionResult JsonResultParameter(int id)
        {
            var data = new { Id = id };
            return Json(data);
        }

        public IActionResult ContentResult()
        {
            return Content("Content Resul Döndü");
        }

        public IActionResult JsonResult()
        {
            var data = new { Name = "Ahmet", Age = 30 };
            return Json(data);
        }

        public IActionResult EmptyResut()
        {
            return new EmptyResult();
        }

    }
}
