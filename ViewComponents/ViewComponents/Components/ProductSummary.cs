using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponents.Models;

namespace ViewComponents.Components
{
    public class ProductSummary : ViewComponent
    {
        private IProductRepository productRepository;

        public ProductSummary(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }

        public string Invoke()
        {
            return $"{productRepository.Products.Count()}  ürününü toplam fiyatı {productRepository.Products.Sum(i=>i.Price)} TL";
        }
    }
    
}
