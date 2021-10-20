using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Models.Domain;
using SEDC.Lamazon.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.Lamazon.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "List of orders";
            ViewData.Add("Message", $"The number of orders is: {StaticDb.Orders.Count}");
            List<Order> orders = StaticDb.Orders;
            List<OrderViewModel> orderViewModels = new List<OrderViewModel>();

            foreach (Order order in orders)
            {
                orderViewModels.Add(new OrderViewModel
                {
                    Id = order.Id,
                    Status = order.Status,
                    Paid = order.Paid,
                    ProductName = order.Product.Name,
                    ProductPrice = order.Product.Price,
                    UserFullName = order.User.FullName
                });
            }

            return View(orderViewModels);
        }
    }
}
