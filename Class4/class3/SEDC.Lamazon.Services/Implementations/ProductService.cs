using SEDC.Lamazon.DataAccess;
using SEDC.Lamazon.Domain;
using SEDC.Lamazon.Mappers.Product;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Services.Implementations
{
    public class ProductService : IProductService
    {
        private IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public void CreateProduct(ProductViewModel productViewModel)
        {
            Product product = productViewModel.ToProduct();


            int productId = _productRepository.Insert(product);
            if (productId <= 0)
            {
                throw new Exception("Something went wrong while saving the new product");
            }
        }

        public void EditProduct(ProductViewModel productViewModel)
        {
            throw new NotImplementedException();
        }

        public List<ProductViewModel> GetAllProducts()
        {
            List<Product> products = _productRepository.GetAll();

            return products.ToProductViewModelList();
        }

        public ProductViewModel GetOrderForEditing(int id)
        {
            throw new NotImplementedException();
        }

        public ProductViewModel GetProductById(int id)
        {
            Product product = _productRepository.GetById(id);
            if (product == null)
            {
                //log the exception
                throw new Exception($"Product with id {id} does not exist!");
            }

            return product.ToProductViewModel();
        }
    }
}
