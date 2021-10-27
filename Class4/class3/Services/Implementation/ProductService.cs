using DataAccess;
using Domain.Domain;
using Mappers.Product;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModelsVM;

namespace Services.Implementation
{
    public class ProductService : IProductServices
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
            if(productId <= 0)
            {
                throw new Exception($"Something went wrong while saving the new product");
            }
        }

        public void DeleteProduct(int id)
        {
            try
            {
                _productRepository.DeleteById(id);
            }
            catch (Exception)
            {

                throw new Exception($"Product with id {id} does not exist");
            }
        }

        public void EditProduct(ProductViewModel productViewModel)
        {
            Product productDb = _productRepository.GetById(productViewModel.Id);
            if(productDb == null)
            {
                //log
                throw new Exception($"The product with id {productViewModel.Id} was not found!");
            }

            Product editedProduct = productViewModel.ToProduct();
            _productRepository.Update(editedProduct);
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
            if(product == null)
            {
                throw new Exception($"Product with id {id} does not exist");
            }

            return product.ToProductViewModel();
        }
    }
}
