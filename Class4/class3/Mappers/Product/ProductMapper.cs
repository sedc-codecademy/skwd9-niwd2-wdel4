using System;
using System.Collections.Generic;
using System.Text;
using ViewModelsVM;

namespace Mappers.Product
{
    public static class ProductMapper
    {
        public static ProductViewModel ToProductViewModel(this Domain.Domain.Product product)
        {
            return new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Category = product.CategoryType,
                Price = product.Price
            };
        }

        public static Domain.Domain.Product ToProduct(this ProductViewModel productViewModel)
        {
            return new Domain.Domain.Product
            {
                Id = productViewModel.Id,
                Name = productViewModel.Name,
                Description = productViewModel.Description,
                CategoryType = productViewModel.Category,
                Price = productViewModel.Price
            };
        }

        public static List<ProductViewModel> ToProductViewModelList(this List<Domain.Domain.Product> products)
        {
            List<ProductViewModel> viewModels = new List<ProductViewModel>();
            foreach(Domain.Domain.Product product in products)
            {
                viewModels.Add(product.ToProductViewModel());
            }

            return viewModels;
        }
    }
}
