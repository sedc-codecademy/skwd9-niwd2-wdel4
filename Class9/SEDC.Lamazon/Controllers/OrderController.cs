using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.Enums;
using SEDC.Lamazon.WebModels.ViewModels;

namespace SEDC.Lamazon.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;

        public OrderController(IOrderService orderService, IUserService userService)
        {
            _orderService = orderService;
            _userService = userService;
        }

        [Authorize(Roles ="admin")]
        public IActionResult ListAllOrders()
        {
            List<OrderViewModel> orders = _orderService.GetAllOrders().ToList();
            return View(orders);
        }

        public IActionResult ApproveOrder(int orderId)
        {
            OrderViewModel order = _orderService.GetOrderById(orderId);
            _orderService.ChangeStatus(order.Id, order.User.Id, StatusTypeViewModel.Confirmed);
            return RedirectToAction("listallorders");
        }

        public IActionResult DeclineOrder(int orderId)
        {
            OrderViewModel order = _orderService.GetOrderById(orderId);
            _orderService.ChangeStatus(order.Id, order.User.Id, StatusTypeViewModel.Declined);
            return RedirectToAction("listallorders");
        }

        [Authorize(Roles = "user")]
        public IActionResult ListOrders()
        {
            try
            {
                UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
                List<OrderViewModel> userOrders = _orderService.GetAllOrders()
                                                                   .Where(x => x.User.Id == user.Id)
                                                                   .ToList();
                return View(userOrders);
            }
            catch (Exception ex)
            {

                throw new Exception($"Message: {ex.Message}");
            }
        }

        [Authorize(Roles = "user")]
        public IActionResult OrderDetails(int orderId)
        {
            try
            {
                UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
                OrderViewModel order = _orderService.GetOrderById(orderId, user.Id);

                if (order.Id > 0)
                {
                    return View("order", order);
                }
                else
                {
                    throw new Exception($"Invalid order");
                }
            }
            catch (Exception ex)
            {

                throw new Exception($"Message: {ex.Message}");
            }
        }

        [Authorize(Roles = "user")]
        public IActionResult ChangeStatus(int orderId, int statusId)
        {
            try
            {
                UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
                _orderService.ChangeStatus(orderId, user.Id, (StatusTypeViewModel)statusId);
                return RedirectToAction("ListOrders");
            }
            catch (Exception ex)
            {

                throw new Exception($"Message: {ex.Message}");
            }
        }

        public int AddProduct(int productId)
        {
            try
            {
                UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
                OrderViewModel order = _orderService.GetCurrentOrder(user.Id);

                int result = _orderService.AddProduct(order.Id, productId, user.Id);
                return result;

            }
            catch (Exception ex)
            {
                throw new Exception($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
        }

        [Authorize(Roles ="user")]
        public IActionResult Order()
        {
            try
            {
                UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
                OrderViewModel order = _orderService.GetCurrentOrder(user.Id);
                return View(order);
            }
            catch (Exception ex)
            {
                throw new Exception($"Message: {ex.Message} | Exceprion {ex.InnerException}");
            }

        }
    }
}
