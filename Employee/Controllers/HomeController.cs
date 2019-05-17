using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Employee.Models;

namespace Employee.Controllers
{
    public class HomeController : Controller
    {

        private readonly EmployeeContext _context;
        public HomeController(EmployeeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {

                var calisanlar = _context.Calisanlar.ToList();   
                return View(calisanlar);
            
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Calisan model)
        {
            _context.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

     
    }
}
