using SEDC.Lamazon.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Mappers.Product
{
    public static class ProductMapper
    {
        public static ProductViewModel ToProductViewModel(this Domain.Product product)
        {
            return new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Category = product.Category,
                Price = product.Price
            };
        }

        public static Domain.Product ToProduct(this ProductViewModel productViewModel)
        {

            return new Domain.Product
            {
                Id = productViewModel.Id,
                Name = productViewModel.Name,
                Description = productViewModel.Description,
                Category = productViewModel.Category,
                Price = productViewModel.Price
            };
        }

        public static List<ProductViewModel> ToProductViewModelList(this List<Domain.Product> products)
        {
            List<ProductViewModel> viewModels = new List<ProductViewModel>();
            foreach (Domain.Product product in products)
            {
                viewModels.Add(product.ToProductViewModel());
            }

            return viewModels;
        }
    }
}
