using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModelsVM;

namespace claas03Lamazon.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;

        public OrderController(IOrderService orderservice)
        {
            _orderService = orderservice;
        }
        public IActionResult Index()
        {
            List<OrderViewModel> orderViewModels = _orderService.GetAllOrders();
            return View(orderViewModels);
        }

        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return new EmptyResult();
            }

            try
            {
                OrderViewModel orderViewModel = _orderService.GetOrderById(id.Value);
                return View(orderViewModel);
            }
            catch (Exception)
            {

                return View("ExceptionView");
            }
        }
    }
}
