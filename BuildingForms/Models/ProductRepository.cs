using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingForms.Models
{
    public static class ProductRepository
    {
        private static List<Product> _products;

        static ProductRepository()
        {
            _products = new List<Product>
          {
              new Product(){Id=1,Name="Telefon 1", Description="DEscription 1",Price=1340,isApproved=true},
              new Product(){Id=1,Name="Telefon 2", Description="DEscription 2",Price=1560,isApproved=false},
              new Product(){Id=1,Name="Telefon 3", Description="DEscription 3",Price=7810,isApproved=false},
              new Product(){Id=1,Name="Telefon 4", Description="DEscription 4",Price=17850,isApproved=true},
              new Product(){Id=1,Name="Telefon 5", Description="DEscription 5",Price=910,isApproved=true},
              new Product(){Id=1,Name="Telefon 6", Description="DEscription 6",Price=410,isApproved=false},
              new Product(){Id=1,Name="Telefon 6", Description="DEscription 7",Price=20,isApproved=true}
          };
        }


        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static void AddProduct(Product entity)
        {
            _products.Add(entity);
        }

    }
}
