using System;
using System.Collections.Generic;
using System.Text;
using ViewModelsVM;

namespace Services.Interfaces
{
    public interface IProductServices
    {
        List<ProductViewModel> GetAllProducts();
        ProductViewModel GetProductById(int value);
        void CreateProduct(ProductViewModel productViewModel);
        ProductViewModel GetOrderForEditing(int id);
        void EditProduct(ProductViewModel productViewModel);
    }
}
