using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            Product product = new Product();
            product.Name = "Książka ASP.NET MVC";
            product.Description = "Znajdziemy tutaj bardzo dużo wiedzy!";
            product.Price = 100;

            return View(product);
        }
    }
}