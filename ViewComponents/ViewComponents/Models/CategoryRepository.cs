using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponents.Models
{
    public class CategoryRepository : ICategoryRepository
    {

        private List<Category> _categories = new List<Category>() {
            new Category(){ CategoryId =1 ,CategoryName="Telefon"},
            new Category(){ CategoryId =2 ,CategoryName="Bilgisayar"},
            new Category(){ CategoryId =3 ,CategoryName="Tablet"}
        };

        public IEnumerable<Category> Categories => _categories;


        public void AddCategory(Category entity)
        {
            _categories.Add(entity);
        }
    }
}
