using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayout.Models;

namespace WebAppLayout.Controllers
{
    public class ProductController : Controller
    {
        List<Product> listProducts = new List<Product>
        {
            new Product(){Id=1,Name="Earbuds",Price=2500.50,Company="Boat"},
            new Product(){Id=2,Name="Laptop",Price=85000.75,Company="HP"},
            new Product(){Id=3,Name="SmartPhone",Price=48000.25,Company="Nothing"},
            new Product(){Id=4,Name="Cycle",Price=18103.50,Company="Decathlon"},
            new Product(){Id=5,Name="WiFi",Price=1199.25,Company="Jio"},
            new Product(){Id=6,Name="KeyBoard",Price=4495.50,Company="Logitech"},
        };
        // GET: Product
        public ActionResult Index()
        {
            //ViewBag
            //ViewData
            //TempData
            ViewData["Message"] = "Welcome to Products";
            ViewBag.noP = listProducts.Count;
            return View(listProducts);
        }
        public ActionResult TempEx()
        {
            TempData["msg"] = "I am coming froom Temp Example";
            return RedirectToAction("Index","Home");
        }
    }
}