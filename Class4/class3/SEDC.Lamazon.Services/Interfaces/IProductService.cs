using SEDC.Lamazon.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Services.Interfaces
{
    public interface IProductService
    {
        List<ProductViewModel> GetAllProducts();
        ProductViewModel GetProductById(int value);
        void CreateProduct(ProductViewModel productViewModel);
        ProductViewModel GetOrderForEditing(int id);
        void EditProduct(ProductViewModel productViewModel);
    }
}
