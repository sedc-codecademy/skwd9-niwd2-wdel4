using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.Lamazon.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = StaticDb.Products;
            return View(products);
        }

        public IActionResult Details(int? id)
        {
            Product product = StaticDb.Products.FirstOrDefault(x => x.Id == id);
            if(id != null)
            {
                return View(product);
            }
            return new EmptyResult();
        }
    }
}
