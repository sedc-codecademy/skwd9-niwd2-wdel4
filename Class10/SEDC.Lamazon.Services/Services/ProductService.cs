using AutoMapper;
using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Models;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Lamazon.Services.Services
{
    public class ProductService : IProductService
    {
        protected readonly IRepository<Product> _productRepository;
        protected readonly IMapper _mapper;

        public ProductService(IRepository<Product> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public IEnumerable<ProductViewModel> GetAllProducts()
        {
            List<Product> products = _productRepository.GetAll().ToList();
            return _mapper.Map<List<Product>, List<ProductViewModel>>(products);
        }
    }
}
