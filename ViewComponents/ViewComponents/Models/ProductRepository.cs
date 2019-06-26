using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponents.Models
{
    public class ProductRepository : IProductRepository
    {

        private List<Product> _products = new List<Product>()
        {
            new Product(){ProductId=1,ProductName="Samsung S7", Price=2000,IsApproved=true,CategoryId=1},
            new Product(){ProductId=2,ProductName="Samsung S8", Price=3000,IsApproved=true,CategoryId=1},
            new Product(){ProductId=3,ProductName="Samsung S9", Price=4000,IsApproved=false,CategoryId=1},


            new Product(){ProductId=4,ProductName="Apple S7", Price=2000,IsApproved=true,CategoryId=2},
            new Product(){ProductId=5,ProductName="Apple S8", Price=3000,IsApproved=true,CategoryId=2},
            new Product(){ProductId=6,ProductName="Apple S9", Price=4000,IsApproved=false,CategoryId=2},


            new Product(){ProductId=7,ProductName="Tablet S7", Price=6000,IsApproved=true,CategoryId=3},
            new Product(){ProductId=8,ProductName="Tablet S8", Price=7000,IsApproved=true,CategoryId=3},
            new Product(){ProductId=9,ProductName="Tablet S9", Price=8000,IsApproved=false,CategoryId=3},
        };
        public IEnumerable<Product> Products => _products;

        public void AddProduct(Product entity)
        {
            _products.Add(entity);
        }
    }
}
