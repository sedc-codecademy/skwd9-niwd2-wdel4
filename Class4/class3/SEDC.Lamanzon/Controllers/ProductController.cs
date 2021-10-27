using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.Lamanzon.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            List<ProductViewModel> productViewModels = _productService.GetAllProducts();
            return View(productViewModels);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View("BadRequest");
            }

            try
            {
                ProductViewModel productViewModel = _productService.GetProductById(id.Value);
                return View(productViewModel);
            }
            catch (Exception ex)
            {
                return View("ExceptionView");
            }
        }

        public IActionResult CreateProduct()
        {
            ProductViewModel productViewModel = new ProductViewModel();
            return View(productViewModel);
        }

        [HttpPost]
        public IActionResult CreateProductPost(ProductViewModel productViewModel)
        {
            try
            {
                    _productService.CreateProduct(productViewModel);
                    return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View("ExceptionView");
            }

        }
    }
}
