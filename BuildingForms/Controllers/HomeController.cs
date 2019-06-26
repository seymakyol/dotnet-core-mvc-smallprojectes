using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildingForms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BuildingForms.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {


            return View(ProductRepository.Products);
        }
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(new List<string>()
            { "Telefon", "TAblet", "Bilgisayar" });


            return View();

        }



        [HttpPost]
        public IActionResult Create(Product product)
        {

            ProductRepository.AddProduct(product);
            return RedirectToAction("Index");

        }

        public IActionResult Search(string q)
        {
            if (string.IsNullOrWhiteSpace(q))
            return View();

            return View("Index", ProductRepository.Products.Where(i => i.Name.Contains(q)));
        }
    }
}