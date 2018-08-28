using Shop.Filters;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    [Log]
    //[Authorize]
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return Content ("Napis");
        }

        //[ActionName("Pokaz")]
        //[HttpGet]
        //[HttpPost]
        //[Authorize(Roles="Admin")]
        //[Log]
        public ActionResult Display(int id)
        {

            Product product = new Product();
            product.Id = 1;
            product.Name = "Książka ASP.NET MVC";
            product.Description = "Znajdziemy tutaj bardzo dużo wiedzy!";
            product.Price = 100;

            if (product.Id == id)
                return View("~/Views/Product/Index.cshtml",product);
            if (id == 2)
                return new HttpNotFoundResult("Komunikat do wy&#x15B;wietlenia.");
            if (id == 3)
                return RedirectToAction("About", "Home");
            if (id == 4)
                throw new Exception("Coś poszło nie tak");
            return new EmptyResult();
        }
    }
}