using Microsoft.AspNetCore.Mvc;
using MoviApp.Data;
using MoviApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index(int? id)
        {
            //ProductCategoryModel model = new ProductCategoryModel();
            //model.Categories = CategoryRepository.Categories;
            //model.Movies = ProductRepository.Movies;

            var movies = ProductRepository.Movies;

            if (id!=null)
            {
                movies = movies.Where(i => i.CategoryId == id).ToList();
            }




            return View(movies);
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            //ProductCategoryModel model = new ProductCategoryModel();
            //model.Categories = CategoryRepository.Categories;
            //model.Movie = ProductRepository.GetById(id);
            return View(ProductRepository.GetById(id));
        }
    }
}
