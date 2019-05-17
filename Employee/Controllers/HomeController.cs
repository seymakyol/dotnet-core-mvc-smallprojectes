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

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_context.Calisanlar.Find(id));
        }


        public IActionResult Edit(Calisan newCalisan,int id)
        {
            var calisan = _context.Calisanlar.Find(id);

            calisan.Name = newCalisan.Name;
            calisan.Age = newCalisan.Age;
            _context.SaveChanges();
            return RedirectToAction("Index");
               
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Calisan calisan=_context.Calisanlar.Find(id);
            _context.Calisanlar.Remove(calisan);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
