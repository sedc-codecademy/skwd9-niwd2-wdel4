using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViewModelsVM;

namespace Mappers.Order
{
    public static class OrderMapper
    {
        public static OrderViewModel ToOrderViewModel(this Domain.Domain.Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                Status = order.Status,
                UserFullName = order.User.FullName,
                UserName = order.User.Username,
                ProductNames = order.ProductOrders.Select(x => x.Product.Name).ToList(),
                Price = order.ProductOrders.Select(x => x.Product.Price).ToList().Sum()
            };
        }
    }
}
