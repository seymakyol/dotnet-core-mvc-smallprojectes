using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewComponents.Models;

namespace ViewComponents.Controllers
{
    public class HomeController : Controller
    {

        private ICategoryRepository categoryRepository;
        private IProductRepository productRepository;

        public HomeController(ICategoryRepository _categoryRepository, IProductRepository _productRepository)
        {
            categoryRepository = _categoryRepository;
            productRepository=_productRepository;
        }

        public IActionResult Index()
        {
            return View(productRepository.Products);
        }

 
    }
}
