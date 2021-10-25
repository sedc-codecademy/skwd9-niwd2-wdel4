using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using ViewModelsVM;

namespace claas03Lamazon.Controllers
{
    public class ProductController : Controller
    {
        private IProductServices _productService;

        public ProductController(IProductServices productServices)
        {
            _productService = productServices;
        }

        public IActionResult Index()
        {
            List<ProductViewModel> productViewModels = _productService.GetAllProducts();
            return View(productViewModels);
        }

        public IActionResult Details(int? id)
        {
            if(id == null)
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

        public IActionResult CreateProductPost(ProductViewModel productViewModel)
        {
            try
            {
                _productService.CreateProduct(productViewModel);
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                return View("ExceptionView");
            }
        }
    }
}
