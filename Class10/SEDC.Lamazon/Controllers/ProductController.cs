using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.ViewModels;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.Lamazon.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Authorize(Roles ="user")]
        public IActionResult Products()
        {
            Log.Information("Fetching all products");
            List<ProductViewModel> products = _productService.GetAllProducts().ToList();

            foreach (var product in products)
            {
                //Log.Information("Product: {@ListedProduct}", product);
                Log.Information("Product Name: {productName}", product.Name);
            }

            return View(products);
        }
    }
}
